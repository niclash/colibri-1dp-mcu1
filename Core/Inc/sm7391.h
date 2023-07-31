#ifndef _SM7391_H
#define _SM7391_H

#ifndef POWER_SM7391_PORT
#define POWER_SM7391_PORT GPIOB
#endif

#ifndef POWER_SM7391_PIN
#define POWER_SM7391_PIN GPIO_PIN_3
#endif

extern void Error_Handler();

void sm7391_init();
void sm7391_deinit();
float sm7391_read_sensor();

typedef enum
{
    SENSOR_UNKNWON = 0,
    SENSOR_POWERED_UP = 1,
    SENSOR_POWERED_DOWN = 2,
    SENSOR_FAULT = 3
} sm7391_powerState;

#endif //_SM7391_H
