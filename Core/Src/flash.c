/**
 *  @brief
 *      HAL Flash routines.
 *
 *      Program and erase are blocking (RTOS)!
 *      The STM32WB has only one flash bank and the access to the flash
 *      during program/erase is not possible.
 *      Erase takes about 20 ms, program 2 ms.
 *  @file
 *      flash.c
 *  @author
 *      Peter Schmid, peter@spyr.ch
 *  @date
 *      2020-02-19
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
#include "cmsis_os.h"

// Application include files
// *************************
#include "main.h"
#include "flash.h"

static osMutexId_t FLASH_MutexID;

static const osMutexAttr_t FLASH_MutexAttr = {
		NULL,				// no name required
		osMutexPrioInherit,	// attr_bits
		NULL,				// memory for control block
		0U					// size for control block
};

// Variable used for Erase procedure
static FLASH_EraseInitTypeDef EraseInitStruct;

/**
 *  @brief
 *      Initializes the FLASH.
 *  @return
 *      None
 */
void FLASH_init(void) {
	FLASH_MutexID = osMutexNew(&FLASH_MutexAttr);
	EraseInitStruct.TypeErase    = FLASH_TYPEERASE_PAGES;
	EraseInitStruct.NbPages      = 1;
	EraseInitStruct.Page         = 0;
}


/**
 *  @brief
 *      Programs 8 bytes (doubleword) in the FLASH.
 *  @param[in]
 *      Address  first byte
 *  @param[in]
 *      word1
 *  @param[in]
 *      word2
 *  @return
 *      HAL Status
 */
int FLASH_programDouble(uint32_t Address, uint32_t word1, uint32_t word2) {
	int return_value;

	if (Address < 0x08020000 || Address >= 0x08040000) {
		Error_Handler();
		return -1;
	}

	// only one thread is allowed to use the flash
	osMutexAcquire(FLASH_MutexID, osWaitForever);

	if (HAL_FLASH_Unlock() == HAL_ERROR) {
		Error_Handler();
	}
    uint64_t data = ((uint64_t) word2 << 32) + ((uint64_t) word1);
	return_value = HAL_FLASH_Program(FLASH_TYPEPROGRAM_DOUBLEWORD, Address, data);
	if (return_value != HAL_OK) {
		return_value = HAL_ERROR;
		Error_Handler();
	}

	if (HAL_FLASH_Lock() == HAL_ERROR) {
		Error_Handler();
	}

	osMutexRelease(FLASH_MutexID);
	return return_value;
}


/**
 *  @brief
 *      Erases a sector (2kB) in the flash.
 *  @param[in]
 *      Address  first byte
 *  @return
 *      HAL Status
 */
int FLASH_erasePage(uint32_t Address) {
	int return_value;
	uint32_t PageError;

	// only one thread is allowed to use the flash
	osMutexAcquire(FLASH_MutexID, osWaitForever);

	if (HAL_FLASH_Unlock() == HAL_ERROR) {
		Error_Handler();
	}
    uint32_t offset = Address - 0x08000000;
    EraseInitStruct.Page = offset / FLASH_PAGE_SIZE;
	return_value = HAL_FLASHEx_Erase(&EraseInitStruct, &PageError);
	if (return_value != HAL_OK) {
		return_value = HAL_ERROR;
		Error_Handler();
	}

	if (HAL_FLASH_Lock() == HAL_ERROR) {
		Error_Handler();
	}

	osMutexRelease(FLASH_MutexID);
	return return_value;
}


// Private Functions
// *****************




