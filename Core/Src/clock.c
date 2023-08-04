/**
 *  @brief
 *      Real Time Clock (RTC).
 *
 *  @file
 *      clock.c
 *  @author
 *      Peter Schmid, peter@spyr.ch
 *  @date
 *      2020-06-03
 *  @remark
 *      Language: C, STM32CubeIDE GCC
 *  @copyright
 *      Peter Schmid, Switzerland
 *
 *      This project Mecrsip-Cube is free software: you can redistribute it
 *      and/or modify it under the terms of the GNU General Public License
 *      as published by the Free Software Foundation, either version 3 of
 *      the License, or (at your option) any later version.
 *
 *      Mecrsip-Cube is distributed in the hope that it will be useful, but
 *      WITHOUT ANY WARRANTY; without even the implied warranty of
 *      MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE. See the GNU
 *      General Public License for more details.
 *
 *      You should have received a copy of the GNU General Public License
 *      along with Mecrsip-Cube. If not, see http://www.gnu.org/licenses/.
 */

// System include files
// ********************
#include <stdio.h>
#include "cmsis_os.h"
#include "time.h"
#include "string.h"

// Application include files
// *************************
#include "main.h"
#include "clock.h"

#define DATE_2000_01_01 (946684800u)
#define DATE_2099_12_31 (4102358400u)


// Private function prototypes
// ***************************

// Global Variables
// ****************

// RTOS resources
// **************

static osMutexId_t RTC_MutexID;
static const osMutexAttr_t RTC_MutexAttr = {
		NULL,				// no name required
		osMutexPrioInherit,	// attr_bits
		NULL,				// memory for control block
		0U					// size for control block
};

static osSemaphoreId_t RTC_SemaphoreID;


// Hardware resources
// ******************

extern RTC_HandleTypeDef hrtc;


// Public Functions
// ****************

/**
 *  @brief
 *      Initializes the RTC.
 *  @return
 *      None
 */
void RTC_init(void) {
	RTC_MutexID = osMutexNew(&RTC_MutexAttr);
//	ASSERT_fatal(RTC_MutexID != NULL, ASSERT_MUTEX_CREATION, __get_PC());

	RTC_SemaphoreID = osSemaphoreNew(1, 0, NULL);
//	ASSERT_fatal(RTC_SemaphoreID != NULL, ASSERT_SEMAPHORE_CREATION, __get_PC());

	/* RTC WakeUpTimer Interrupt Configuration: EXTI configuration */
	__HAL_RTC_WAKEUPTIMER_EXTI_ENABLE_IT();

    HAL_NVIC_EnableIRQ(RTC_WKUP_IRQn);
}


/**
 *  @brief
 *      Returns the unix time stamp.
 *
 *      Epoch is 1.1.1970. But valid dates are from 1.1.2000 to 31.12.2099
 *      because of the STM32WB RTC peripheral.
 *  @return
 *      Unix time stamp (unsigned).
 */
uint32_t RTC_getTime(void){
	RTC_TimeTypeDef sTime;
	RTC_DateTypeDef sDate;
	time_t timestamp;
	struct tm tm_s;

	HAL_RTC_GetTime(&hrtc, &sTime, RTC_FORMAT_BIN);
	HAL_RTC_GetDate(&hrtc, &sDate, RTC_FORMAT_BIN);

	tm_s.tm_year = sDate.Year + 100;
	tm_s.tm_mon = sDate.Month - 1;
	tm_s.tm_mday = sDate.Date;

	tm_s.tm_hour = sTime.Hours;
	tm_s.tm_min = sTime.Minutes;
	tm_s.tm_sec = sTime.Seconds;

	timestamp = mktime(&tm_s);

	return timestamp;
}


/**
 *  @brief
 *      Initializes the RTC.
 *  @return
 *      None
 */
int RTC_setTime(uint32_t timestamp){
	RTC_TimeTypeDef sTime;
	RTC_DateTypeDef sDate;
	time_t time;
	struct tm tm_s;

	time = (time_t)timestamp;
	if (timestamp < DATE_2000_01_01 || timestamp > DATE_2099_12_31) {
		// the RTC peripheral can handle dates from
		// 2000-01-01T00:00:00+00:00 to 2099-12-31T00:00:00+00:00
		return -1;
	}

	gmtime_r(&time, &tm_s);

	sDate.Year = tm_s.tm_year - 100;
	sDate.Month = tm_s.tm_mon + 1;
	sDate.Date = tm_s.tm_mday;
	sDate.WeekDay = tm_s.tm_wday;

	sTime.Hours = tm_s.tm_hour;
	sTime.Minutes = tm_s.tm_min;
	sTime.Seconds = tm_s.tm_sec;
	sTime.DayLightSaving = RTC_DAYLIGHTSAVING_NONE;
	sTime.StoreOperation = RTC_STOREOPERATION_RESET;
	sTime.SubSeconds = 0;

	HAL_RTC_SetTime(&hrtc, &sTime, RTC_FORMAT_BIN);
	HAL_RTC_SetDate(&hrtc, &sDate, RTC_FORMAT_BIN);

	return 0;
}

/**
 *  @brief
 *      Gets the time
 *  @return
 *      hhmmss
 */
uint32_t RTC_getClockTime(void) {
	RTC_TimeTypeDef sTime;

	HAL_RTC_GetTime(&hrtc, &sTime, RTC_FORMAT_BIN);
	return sTime.Hours*100*100 + sTime.Minutes*100 + sTime.Seconds;
}

/**
 *  @brief
 *      Gets the date
 *  @return
 *      yyyymmdd
 */
uint32_t RTC_getClockDate(void) {
	RTC_DateTypeDef sDate;

	HAL_RTC_GetDate(&hrtc, &sDate, RTC_FORMAT_BIN);
	return (sDate.Year + 2000)*100*100 + (sDate.Month*100) + sDate.Date;
}


/**
 *  @brief
 *      Waits for alarm A.
 *  @return
 *      none
 */
void RTC_waitAlarmA() {
	osSemaphoreAcquire(RTC_SemaphoreID, osWaitForever);
}


/**
 *  @brief
 *      Waits for alarm A.
 *  @param[in]
 *      hour   0..23, -1 don't care
 *  @param[in]
 *      minute 0..59, -1 don't care
 *  @param[in]
 *      second 0..59, -1 don't care
 *  @return
 *      none
 */
void RTC_setAlarmA(int hour, int minute, int second) {
	RTC_AlarmTypeDef sAlarm = {0};
	uint32_t mask = RTC_ALARMMASK_DATEWEEKDAY;

	if (hour >= 0 && hour <24) {
		sAlarm.AlarmTime.Hours = hour;
	} else {
		sAlarm.AlarmTime.Hours = 0;
		mask |= RTC_ALARMMASK_HOURS;
	}

	if (minute >= 0 && minute < 60) {
		sAlarm.AlarmTime.Minutes = minute;
	} else {
		sAlarm.AlarmTime.Minutes = 0;
		mask |= RTC_ALARMMASK_MINUTES;
	}

	if (second >= 0 && second < 60) {
		sAlarm.AlarmTime.Seconds = second;
	} else {
		sAlarm.AlarmTime.Seconds = 0;
		mask |= RTC_ALARMMASK_SECONDS;
	}

	sAlarm.AlarmTime.SubSeconds = 0;
	sAlarm.AlarmTime.DayLightSaving = RTC_DAYLIGHTSAVING_NONE;
	sAlarm.AlarmTime.StoreOperation = RTC_STOREOPERATION_RESET;
	sAlarm.AlarmSubSecondMask = RTC_ALARMSUBSECONDMASK_NONE;
	sAlarm.AlarmDateWeekDaySel = RTC_ALARMDATEWEEKDAYSEL_DATE;
	sAlarm.AlarmDateWeekDay = 1;
	sAlarm.AlarmMask = mask;

	// set semaphore
	osSemaphoreAcquire(RTC_SemaphoreID, 0);

	sAlarm.Alarm = RTC_ALARM_A;
	if (HAL_RTC_SetAlarm_IT(&hrtc, &sAlarm, RTC_FORMAT_BIN) != HAL_OK)
	{
		Error_Handler();
	}

}


// Callbacks
// *********

/**
  * @brief
  * 	Alarm A callback.
  * 	It sets the RTC semaphore to synchronize threads.
  * @param[in]
  * 	hrtc RTC handle, not used
  * @retval
  * 	None
  */
void RTC_AlarmAEventCallback(RTC_HandleTypeDef *hrtc) {
  /* Prevent unused argument(s) compilation warning */
  UNUSED(hrtc);

  osSemaphoreRelease(RTC_SemaphoreID);
}

