
#include "sm7391.h"
#include "main.h"

static sm7391_powerState state;
static HAL_StatusTypeDef status;

static void reset_sensor()
{
    if (state == SENSOR_POWERED_UP)
        return;
    // Power up sensor
    HAL_GPIO_WritePin(POWER_SM7391_PORT, POWER_SM7391_PIN, GPIO_PIN_SET);
    HAL_Delay(2);
    uint8_t tx[10] = {0x22, 0x69, 0xb1};
    status = HAL_I2C_Master_Transmit(&hi2c2, 0x6C << 1, tx, 3, 100);
    if (status == HAL_OK)
    {
        state = SENSOR_POWERED_UP;
    } else
    {
        state = SENSOR_UNKNWON;
    }
}

static void powerdown_sensor()
{
    if (state == SENSOR_POWERED_DOWN)
        return;
//    uint8_t tx[10] = {0x22, 0x32, 0x6C};
//    status = HAL_I2C_Master_Transmit(&hi2c1, 0x6C << 1, tx, 3, 100);
//    if (status == HAL_OK)
//    {
//        state = SENSOR_POWERED_DOWN;
//    } else
//    {
//        state = SENSOR_UNKNWON;
//    }

//    // Power down the sensor.
    HAL_GPIO_WritePin(POWER_SM7391_PORT, POWER_SM7391_PIN, GPIO_PIN_RESET);
}

static int16_t convertPa(int16_t reading)
{
    float pmax = 500;
    float pmin = -500;
    int offseted = reading + 26214;
    float pread = pmin + ((float) offseted / 52428.0f) * (pmax - pmin);
    return (int16_t) pread;
}

void waitUntilReady()
{
    while (HAL_OK != HAL_I2C_IsDeviceReady(&hi2c2, 0x6C << 1, 3, 100)); // wait until ready
}

float sm7391_read_sensor()
{
    int16_t pressure = 0;
    reset_sensor();
    status = HAL_I2C_IsDeviceReady(&hi2c2, 0x6C << 1, 3, 100);
    if (status != HAL_OK)
    {
        state = 0xfc;
        return pressure;
    }
    uint8_t tx[10] = {0x2E};
    status = HAL_I2C_Master_Transmit(&hi2c2, 0x6C << 1, tx, 1, 100);
    if (status != HAL_OK)
    {
        state = 0xfb;
        return pressure;
    }
    int16_t rx[10];
    status = HAL_I2C_Master_Receive(&hi2c2, 0x6C << 1, (uint8_t *) rx, 6, 100);
    if (status != HAL_OK)
    {
        state = 0xfa;
        return pressure;
    }
    uint16_t sensor_status = rx[2];
    if ((sensor_status & 0x08) == 0x08)
    {
        pressure = convertPa(rx[1]);
    }
    waitUntilReady();
    powerdown_sensor();
    return pressure;
}

void sm7391_init()
{
    reset_sensor();
}
