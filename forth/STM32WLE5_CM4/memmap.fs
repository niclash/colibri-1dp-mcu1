\ TEMPLATE FILE for STM32WLE5_CM4
\ created by svdcutter for Mecrisp-Stellaris Forth by Matthias Koch
\ sdvcutter  takes a CMSIS-SVD file plus a hand edited config.xml file as input 
\ By Terry Porter "terry@tjporter.com.au", released under the GPL V2 Licence

 compiletoflash

\ available forth template words as selected by config.xml

$40012400 constant ADC ( Analog to digital convertor ) 
ADC $0 + constant ADC-ISR ( ADC interrupt and status register ) 
ADC $4 + constant ADC-IER ( ADC interrupt enable register ) 
ADC $8 + constant ADC-CR ( ADC control register ) 
ADC $C + constant ADC-CFGR1 ( ADC configuration register 1 ) 
ADC $10 + constant ADC-CFGR2 ( ADC configuration register 2 ) 
ADC $14 + constant ADC-SMPR ( ADC sampling time register ) 
ADC $20 + constant ADC-AWD1TR ( ADC watchdog threshold register ) 
ADC $24 + constant ADC-AWD2TR ( ADC watchdog threshold register ) 
ADC $28 + constant ADC-CHSELR0 ( channel selection register ) 
ADC $28 + constant ADC-CHSELR1 ( channel selection register ) 
ADC $2C + constant ADC-AWD3TR ( ADC watchdog threshold register ) 
ADC $40 + constant ADC-DR ( ADC data register ) 
ADC $A0 + constant ADC-AWD2CR ( ADC Analog Watchdog 2 Configuration register ) 
ADC $A4 + constant ADC-AWD3CR ( ADC Analog Watchdog 3 Configuration register ) 
ADC $B4 + constant ADC-CALFACT ( ADC Calibration factor ) 
ADC $308 + constant ADC-CCR ( ADC common configuration register ) 
: ADC-ISR. ." ADC-ISR (read-write) $" ADC-ISR @ hex. ADC-ISR 1b. ;
: ADC-IER. ." ADC-IER (read-write) $" ADC-IER @ hex. ADC-IER 1b. ;
: ADC-CR. ." ADC-CR (read-write) $" ADC-CR @ hex. ADC-CR 1b. ;
: ADC-CFGR1. ." ADC-CFGR1 (read-write) $" ADC-CFGR1 @ hex. ADC-CFGR1 1b. ;
: ADC-CFGR2. ." ADC-CFGR2 (read-write) $" ADC-CFGR2 @ hex. ADC-CFGR2 1b. ;
: ADC-SMPR. ." ADC-SMPR (read-write) $" ADC-SMPR @ hex. ADC-SMPR 1b. ;
: ADC-AWD1TR. ." ADC-AWD1TR (read-write) $" ADC-AWD1TR @ hex. ADC-AWD1TR 1b. ;
: ADC-AWD2TR. ." ADC-AWD2TR (read-write) $" ADC-AWD2TR @ hex. ADC-AWD2TR 1b. ;
: ADC-CHSELR0. ." ADC-CHSELR0 (read-write) $" ADC-CHSELR0 @ hex. ADC-CHSELR0 1b. ;
: ADC-CHSELR1. ." ADC-CHSELR1 (read-write) $" ADC-CHSELR1 @ hex. ADC-CHSELR1 1b. ;
: ADC-AWD3TR. ." ADC-AWD3TR (read-write) $" ADC-AWD3TR @ hex. ADC-AWD3TR 1b. ;
: ADC-DR. ." ADC-DR (read-only) $" ADC-DR @ hex. ADC-DR 1b. ;
: ADC-AWD2CR. ." ADC-AWD2CR (read-write) $" ADC-AWD2CR @ hex. ADC-AWD2CR 1b. ;
: ADC-AWD3CR. ." ADC-AWD3CR (read-write) $" ADC-AWD3CR @ hex. ADC-AWD3CR 1b. ;
: ADC-CALFACT. ." ADC-CALFACT (read-write) $" ADC-CALFACT @ hex. ADC-CALFACT 1b. ;
: ADC-CCR. ." ADC-CCR (read-write) $" ADC-CCR @ hex. ADC-CCR 1b. ;
: ADC.
ADC-ISR.
ADC-IER.
ADC-CR.
ADC-CFGR1.
ADC-CFGR2.
ADC-SMPR.
ADC-AWD1TR.
ADC-AWD2TR.
ADC-CHSELR0.
ADC-CHSELR1.
ADC-AWD3TR.
ADC-DR.
ADC-AWD2CR.
ADC-AWD3CR.
ADC-CALFACT.
ADC-CCR.
;

$40023000 constant CRC ( Cyclic redundancy check calculation unit ) 
CRC $0 + constant CRC-DR ( Data register ) 
CRC $4 + constant CRC-IDR ( Independent data register ) 
CRC $8 + constant CRC-CR ( Control register ) 
CRC $10 + constant CRC-INIT ( Initial CRC value ) 
CRC $14 + constant CRC-POL ( polynomial ) 
: CRC-DR. ." CRC-DR (read-write) $" CRC-DR @ hex. CRC-DR 1b. ;
: CRC-IDR. ." CRC-IDR (read-write) $" CRC-IDR @ hex. CRC-IDR 1b. ;
: CRC-CR. ." CRC-CR (read-write) $" CRC-CR @ hex. CRC-CR 1b. ;
: CRC-INIT. ." CRC-INIT (read-write) $" CRC-INIT @ hex. CRC-INIT 1b. ;
: CRC-POL. ." CRC-POL (read-write) $" CRC-POL @ hex. CRC-POL 1b. ;
: CRC.
CRC-DR.
CRC-IDR.
CRC-CR.
CRC-INIT.
CRC-POL.
;

$48000000 constant GPIOA ( General-purpose I/Os ) 
GPIOA $0 + constant GPIOA-MODER ( GPIO port mode register ) 
GPIOA $4 + constant GPIOA-OTYPER ( GPIO port output type register ) 
GPIOA $8 + constant GPIOA-OSPEEDR ( GPIO port output speed register ) 
GPIOA $C + constant GPIOA-PUPDR ( GPIO port pull-up/pull-down register ) 
GPIOA $10 + constant GPIOA-IDR ( GPIO port input data register ) 
GPIOA $14 + constant GPIOA-ODR ( GPIO port output data register ) 
GPIOA $18 + constant GPIOA-BSRR ( GPIO port bit set/reset register ) 
GPIOA $1C + constant GPIOA-LCKR ( GPIO port configuration lock register ) 
GPIOA $20 + constant GPIOA-AFRL ( GPIO alternate function low register ) 
GPIOA $24 + constant GPIOA-AFRH ( GPIO alternate function high register ) 
GPIOA $28 + constant GPIOA-BRR ( GPIO port bit reset register ) 
: GPIOA-MODER. ." GPIOA-MODER (read-write) $" GPIOA-MODER @ hex. GPIOA-MODER 1b. ;
: GPIOA-OTYPER. ." GPIOA-OTYPER (read-write) $" GPIOA-OTYPER @ hex. GPIOA-OTYPER 1b. ;
: GPIOA-OSPEEDR. ." GPIOA-OSPEEDR (read-write) $" GPIOA-OSPEEDR @ hex. GPIOA-OSPEEDR 1b. ;
: GPIOA-PUPDR. ." GPIOA-PUPDR (read-write) $" GPIOA-PUPDR @ hex. GPIOA-PUPDR 1b. ;
: GPIOA-IDR. ." GPIOA-IDR (read-only) $" GPIOA-IDR @ hex. GPIOA-IDR 1b. ;
: GPIOA-ODR. ." GPIOA-ODR (read-write) $" GPIOA-ODR @ hex. GPIOA-ODR 1b. ;
: GPIOA-BSRR. ." GPIOA-BSRR (write-only) $" GPIOA-BSRR @ hex. GPIOA-BSRR 1b. ;
: GPIOA-LCKR. ." GPIOA-LCKR (read-write) $" GPIOA-LCKR @ hex. GPIOA-LCKR 1b. ;
: GPIOA-AFRL. ." GPIOA-AFRL (read-write) $" GPIOA-AFRL @ hex. GPIOA-AFRL 1b. ;
: GPIOA-AFRH. ." GPIOA-AFRH (read-write) $" GPIOA-AFRH @ hex. GPIOA-AFRH 1b. ;
: GPIOA-BRR. ." GPIOA-BRR (read-write) $" GPIOA-BRR @ hex. GPIOA-BRR 1b. ;
: GPIOA.
GPIOA-MODER.
GPIOA-OTYPER.
GPIOA-OSPEEDR.
GPIOA-PUPDR.
GPIOA-IDR.
GPIOA-ODR.
GPIOA-BSRR.
GPIOA-LCKR.
GPIOA-AFRL.
GPIOA-AFRH.
GPIOA-BRR.
;

$48000400 constant GPIOB ( General-purpose I/Os ) 
GPIOB $0 + constant GPIOB-MODER ( GPIO port mode register ) 
GPIOB $4 + constant GPIOB-OTYPER ( GPIO port output type register ) 
GPIOB $8 + constant GPIOB-OSPEEDR ( GPIO port output speed register ) 
GPIOB $C + constant GPIOB-PUPDR ( GPIO port pull-up/pull-down register ) 
GPIOB $10 + constant GPIOB-IDR ( GPIO port input data register ) 
GPIOB $14 + constant GPIOB-ODR ( GPIO port output data register ) 
GPIOB $18 + constant GPIOB-BSRR ( GPIO port bit set/reset register ) 
GPIOB $1C + constant GPIOB-LCKR ( GPIO port configuration lock register ) 
GPIOB $20 + constant GPIOB-AFRL ( GPIO alternate function low register ) 
GPIOB $24 + constant GPIOB-AFRH ( GPIO alternate function high register ) 
GPIOB $28 + constant GPIOB-BRR ( GPIO port bit reset register ) 
: GPIOB-MODER. ." GPIOB-MODER (read-write) $" GPIOB-MODER @ hex. GPIOB-MODER 1b. ;
: GPIOB-OTYPER. ." GPIOB-OTYPER (read-write) $" GPIOB-OTYPER @ hex. GPIOB-OTYPER 1b. ;
: GPIOB-OSPEEDR. ." GPIOB-OSPEEDR (read-write) $" GPIOB-OSPEEDR @ hex. GPIOB-OSPEEDR 1b. ;
: GPIOB-PUPDR. ." GPIOB-PUPDR (read-write) $" GPIOB-PUPDR @ hex. GPIOB-PUPDR 1b. ;
: GPIOB-IDR. ." GPIOB-IDR (read-only) $" GPIOB-IDR @ hex. GPIOB-IDR 1b. ;
: GPIOB-ODR. ." GPIOB-ODR (read-write) $" GPIOB-ODR @ hex. GPIOB-ODR 1b. ;
: GPIOB-BSRR. ." GPIOB-BSRR (write-only) $" GPIOB-BSRR @ hex. GPIOB-BSRR 1b. ;
: GPIOB-LCKR. ." GPIOB-LCKR (read-write) $" GPIOB-LCKR @ hex. GPIOB-LCKR 1b. ;
: GPIOB-AFRL. ." GPIOB-AFRL (read-write) $" GPIOB-AFRL @ hex. GPIOB-AFRL 1b. ;
: GPIOB-AFRH. ." GPIOB-AFRH (read-write) $" GPIOB-AFRH @ hex. GPIOB-AFRH 1b. ;
: GPIOB-BRR. ." GPIOB-BRR (read-write) $" GPIOB-BRR @ hex. GPIOB-BRR 1b. ;
: GPIOB.
GPIOB-MODER.
GPIOB-OTYPER.
GPIOB-OSPEEDR.
GPIOB-PUPDR.
GPIOB-IDR.
GPIOB-ODR.
GPIOB-BSRR.
GPIOB-LCKR.
GPIOB-AFRL.
GPIOB-AFRH.
GPIOB-BRR.
;

$40005800 constant I2C2 ( Inter-integrated circuit ) 
I2C2 $0 + constant I2C2-CR1 ( Control register 1 ) 
I2C2 $4 + constant I2C2-CR2 ( Control register 2 ) 
I2C2 $8 + constant I2C2-OAR1 ( Own address register 1 ) 
I2C2 $C + constant I2C2-OAR2 ( Own address register 2 ) 
I2C2 $10 + constant I2C2-TIMINGR ( Timing register ) 
I2C2 $14 + constant I2C2-TIMEOUTR ( Status register 1 ) 
I2C2 $18 + constant I2C2-ISR ( Interrupt and Status register ) 
I2C2 $1C + constant I2C2-ICR ( Interrupt clear register ) 
I2C2 $20 + constant I2C2-PECR ( PEC register ) 
I2C2 $24 + constant I2C2-RXDR ( Receive data register ) 
I2C2 $28 + constant I2C2-TXDR ( Transmit data register ) 
: I2C2-CR1. ." I2C2-CR1 (read-write) $" I2C2-CR1 @ hex. I2C2-CR1 1b. ;
: I2C2-CR2. ." I2C2-CR2 (read-write) $" I2C2-CR2 @ hex. I2C2-CR2 1b. ;
: I2C2-OAR1. ." I2C2-OAR1 (read-write) $" I2C2-OAR1 @ hex. I2C2-OAR1 1b. ;
: I2C2-OAR2. ." I2C2-OAR2 (read-write) $" I2C2-OAR2 @ hex. I2C2-OAR2 1b. ;
: I2C2-TIMINGR. ." I2C2-TIMINGR (read-write) $" I2C2-TIMINGR @ hex. I2C2-TIMINGR 1b. ;
: I2C2-TIMEOUTR. ." I2C2-TIMEOUTR (read-write) $" I2C2-TIMEOUTR @ hex. I2C2-TIMEOUTR 1b. ;
: I2C2-ISR. ." I2C2-ISR () $" I2C2-ISR @ hex. I2C2-ISR 1b. ;
: I2C2-ICR. ." I2C2-ICR (write-only) $" I2C2-ICR @ hex. I2C2-ICR 1b. ;
: I2C2-PECR. ." I2C2-PECR (read-only) $" I2C2-PECR @ hex. I2C2-PECR 1b. ;
: I2C2-RXDR. ." I2C2-RXDR (read-only) $" I2C2-RXDR @ hex. I2C2-RXDR 1b. ;
: I2C2-TXDR. ." I2C2-TXDR (read-write) $" I2C2-TXDR @ hex. I2C2-TXDR 1b. ;
: I2C2.
I2C2-CR1.
I2C2-CR2.
I2C2-OAR1.
I2C2-OAR2.
I2C2-TIMINGR.
I2C2-TIMEOUTR.
I2C2-ISR.
I2C2-ICR.
I2C2-PECR.
I2C2-RXDR.
I2C2-TXDR.
;

$E000E100 constant NVIC ( Nested Vectored Interrupt Controller ) 
NVIC $0 + constant NVIC-ISER0 ( Interrupt Set-Enable Register ) 
NVIC $4 + constant NVIC-ISER1 ( Interrupt Set-Enable Register ) 
NVIC $80 + constant NVIC-ICER0 ( Interrupt Clear-Enable Register ) 
NVIC $84 + constant NVIC-ICER1 ( Interrupt Clear-Enable Register ) 
NVIC $100 + constant NVIC-ISPR0 ( Interrupt Set-Pending Register ) 
NVIC $104 + constant NVIC-ISPR1 ( Interrupt Set-Pending Register ) 
NVIC $180 + constant NVIC-ICPR0 ( Interrupt Clear-Pending Register ) 
NVIC $184 + constant NVIC-ICPR1 ( Interrupt Clear-Pending Register ) 
NVIC $200 + constant NVIC-IABR0 ( Interrupt Active Bit Register ) 
NVIC $204 + constant NVIC-IABR1 ( Interrupt Active Bit Register ) 
NVIC $300 + constant NVIC-IPR0 ( Interrupt Priority Register ) 
NVIC $304 + constant NVIC-IPR1 ( Interrupt Priority Register ) 
NVIC $308 + constant NVIC-IPR2 ( Interrupt Priority Register ) 
NVIC $30C + constant NVIC-IPR3 ( Interrupt Priority Register ) 
NVIC $310 + constant NVIC-IPR4 ( Interrupt Priority Register ) 
NVIC $314 + constant NVIC-IPR5 ( Interrupt Priority Register ) 
NVIC $318 + constant NVIC-IPR6 ( Interrupt Priority Register ) 
NVIC $31C + constant NVIC-IPR7 ( Interrupt Priority Register ) 
NVIC $320 + constant NVIC-IPR8 ( Interrupt Priority Register ) 
NVIC $324 + constant NVIC-IPR9 ( Interrupt Priority Register ) 
NVIC $328 + constant NVIC-IPR10 ( Interrupt Priority Register ) 
NVIC $32C + constant NVIC-IPR11 ( Interrupt Priority Register ) 
NVIC $330 + constant NVIC-IPR12 ( Interrupt Priority Register ) 
NVIC $334 + constant NVIC-IPR13 ( Interrupt Priority Register ) 
NVIC $338 + constant NVIC-IPR14 ( Interrupt Priority Register ) 
NVIC $33C + constant NVIC-IPR15 ( Interrupt Priority Register ) 
NVIC $340 + constant NVIC-IPR16 ( Interrupt Priority Register ) 
NVIC $344 + constant NVIC-IPR17 ( Interrupt Priority Register ) 
: NVIC-ISER0. ." NVIC-ISER0 (read-write) $" NVIC-ISER0 @ hex. NVIC-ISER0 1b. ;
: NVIC-ISER1. ." NVIC-ISER1 (read-write) $" NVIC-ISER1 @ hex. NVIC-ISER1 1b. ;
: NVIC-ICER0. ." NVIC-ICER0 (read-write) $" NVIC-ICER0 @ hex. NVIC-ICER0 1b. ;
: NVIC-ICER1. ." NVIC-ICER1 (read-write) $" NVIC-ICER1 @ hex. NVIC-ICER1 1b. ;
: NVIC-ISPR0. ." NVIC-ISPR0 (read-write) $" NVIC-ISPR0 @ hex. NVIC-ISPR0 1b. ;
: NVIC-ISPR1. ." NVIC-ISPR1 (read-write) $" NVIC-ISPR1 @ hex. NVIC-ISPR1 1b. ;
: NVIC-ICPR0. ." NVIC-ICPR0 (read-write) $" NVIC-ICPR0 @ hex. NVIC-ICPR0 1b. ;
: NVIC-ICPR1. ." NVIC-ICPR1 (read-write) $" NVIC-ICPR1 @ hex. NVIC-ICPR1 1b. ;
: NVIC-IABR0. ." NVIC-IABR0 (read-only) $" NVIC-IABR0 @ hex. NVIC-IABR0 1b. ;
: NVIC-IABR1. ." NVIC-IABR1 (read-only) $" NVIC-IABR1 @ hex. NVIC-IABR1 1b. ;
: NVIC-IPR0. ." NVIC-IPR0 (read-write) $" NVIC-IPR0 @ hex. NVIC-IPR0 1b. ;
: NVIC-IPR1. ." NVIC-IPR1 (read-write) $" NVIC-IPR1 @ hex. NVIC-IPR1 1b. ;
: NVIC-IPR2. ." NVIC-IPR2 (read-write) $" NVIC-IPR2 @ hex. NVIC-IPR2 1b. ;
: NVIC-IPR3. ." NVIC-IPR3 (read-write) $" NVIC-IPR3 @ hex. NVIC-IPR3 1b. ;
: NVIC-IPR4. ." NVIC-IPR4 (read-write) $" NVIC-IPR4 @ hex. NVIC-IPR4 1b. ;
: NVIC-IPR5. ." NVIC-IPR5 (read-write) $" NVIC-IPR5 @ hex. NVIC-IPR5 1b. ;
: NVIC-IPR6. ." NVIC-IPR6 (read-write) $" NVIC-IPR6 @ hex. NVIC-IPR6 1b. ;
: NVIC-IPR7. ." NVIC-IPR7 (read-write) $" NVIC-IPR7 @ hex. NVIC-IPR7 1b. ;
: NVIC-IPR8. ." NVIC-IPR8 (read-write) $" NVIC-IPR8 @ hex. NVIC-IPR8 1b. ;
: NVIC-IPR9. ." NVIC-IPR9 (read-write) $" NVIC-IPR9 @ hex. NVIC-IPR9 1b. ;
: NVIC-IPR10. ." NVIC-IPR10 (read-write) $" NVIC-IPR10 @ hex. NVIC-IPR10 1b. ;
: NVIC-IPR11. ." NVIC-IPR11 (read-write) $" NVIC-IPR11 @ hex. NVIC-IPR11 1b. ;
: NVIC-IPR12. ." NVIC-IPR12 (read-write) $" NVIC-IPR12 @ hex. NVIC-IPR12 1b. ;
: NVIC-IPR13. ." NVIC-IPR13 (read-write) $" NVIC-IPR13 @ hex. NVIC-IPR13 1b. ;
: NVIC-IPR14. ." NVIC-IPR14 (read-write) $" NVIC-IPR14 @ hex. NVIC-IPR14 1b. ;
: NVIC-IPR15. ." NVIC-IPR15 (read-write) $" NVIC-IPR15 @ hex. NVIC-IPR15 1b. ;
: NVIC-IPR16. ." NVIC-IPR16 (read-write) $" NVIC-IPR16 @ hex. NVIC-IPR16 1b. ;
: NVIC-IPR17. ." NVIC-IPR17 (read-write) $" NVIC-IPR17 @ hex. NVIC-IPR17 1b. ;
: NVIC.
NVIC-ISER0.
NVIC-ISER1.
NVIC-ICER0.
NVIC-ICER1.
NVIC-ISPR0.
NVIC-ISPR1.
NVIC-ICPR0.
NVIC-ICPR1.
NVIC-IABR0.
NVIC-IABR1.
NVIC-IPR0.
NVIC-IPR1.
NVIC-IPR2.
NVIC-IPR3.
NVIC-IPR4.
NVIC-IPR5.
NVIC-IPR6.
NVIC-IPR7.
NVIC-IPR8.
NVIC-IPR9.
NVIC-IPR10.
NVIC-IPR11.
NVIC-IPR12.
NVIC-IPR13.
NVIC-IPR14.
NVIC-IPR15.
NVIC-IPR16.
NVIC-IPR17.
;

$E000EF00 constant NVIC_STIR ( Nested vectored interrupt controller ) 
NVIC_STIR $0 + constant NVIC_STIR-STIR ( Software trigger interrupt register ) 
: NVIC_STIR-STIR. ." NVIC_STIR-STIR (read-write) $" NVIC_STIR-STIR @ hex. NVIC_STIR-STIR 1b. ;
: NVIC_STIR.
NVIC_STIR-STIR.
;

$58000400 constant PWR ( Power control ) 
PWR $0 + constant PWR-CR1 ( Power control register 1 ) 
PWR $4 + constant PWR-CR2 ( Power control register 2 ) 
PWR $8 + constant PWR-CR3 ( Power control register 3 ) 
PWR $C + constant PWR-CR4 ( Power control register 4 ) 
PWR $10 + constant PWR-SR1 ( Power status register 1 ) 
PWR $14 + constant PWR-SR2 ( Power status register 2 ) 
PWR $18 + constant PWR-SCR ( Power status clear register ) 
PWR $1C + constant PWR-CR5 ( Power control register 5 ) 
PWR $20 + constant PWR-PUCRA ( Power Port A pull-up control register ) 
PWR $24 + constant PWR-PDCRA ( Power Port A pull-down control register ) 
PWR $28 + constant PWR-PUCRB ( Power Port B pull-up control register ) 
PWR $2C + constant PWR-PDCRB ( Power Port B pull-down control register ) 
PWR $30 + constant PWR-PUCRC ( Power Port C pull-up control register ) 
PWR $34 + constant PWR-PDCRC ( Power Port C pull-down control register ) 
PWR $58 + constant PWR-PUCRH ( Power Port H pull-up control register ) 
PWR $5C + constant PWR-PDCRH ( Power Port H pull-down control register ) 
PWR $88 + constant PWR-EXTSCR ( Power extended status and status clear register ) 
PWR $90 + constant PWR-SUBGHZSPICR ( Power SPI3 control register ) 
: PWR-CR1. ." PWR-CR1 (read-write) $" PWR-CR1 @ hex. PWR-CR1 1b. ;
: PWR-CR2. ." PWR-CR2 (read-write) $" PWR-CR2 @ hex. PWR-CR2 1b. ;
: PWR-CR3. ." PWR-CR3 (read-write) $" PWR-CR3 @ hex. PWR-CR3 1b. ;
: PWR-CR4. ." PWR-CR4 (read-write) $" PWR-CR4 @ hex. PWR-CR4 1b. ;
: PWR-SR1. ." PWR-SR1 (read-only) $" PWR-SR1 @ hex. PWR-SR1 1b. ;
: PWR-SR2. ." PWR-SR2 (read-only) $" PWR-SR2 @ hex. PWR-SR2 1b. ;
: PWR-SCR. ." PWR-SCR (write-only) $" PWR-SCR @ hex. PWR-SCR 1b. ;
: PWR-CR5. ." PWR-CR5 (read-write) $" PWR-CR5 @ hex. PWR-CR5 1b. ;
: PWR-PUCRA. ." PWR-PUCRA (read-write) $" PWR-PUCRA @ hex. PWR-PUCRA 1b. ;
: PWR-PDCRA. ." PWR-PDCRA (read-write) $" PWR-PDCRA @ hex. PWR-PDCRA 1b. ;
: PWR-PUCRB. ." PWR-PUCRB (read-write) $" PWR-PUCRB @ hex. PWR-PUCRB 1b. ;
: PWR-PDCRB. ." PWR-PDCRB (read-write) $" PWR-PDCRB @ hex. PWR-PDCRB 1b. ;
: PWR-PUCRC. ." PWR-PUCRC (read-write) $" PWR-PUCRC @ hex. PWR-PUCRC 1b. ;
: PWR-PDCRC. ." PWR-PDCRC (read-write) $" PWR-PDCRC @ hex. PWR-PDCRC 1b. ;
: PWR-PUCRH. ." PWR-PUCRH (read-write) $" PWR-PUCRH @ hex. PWR-PUCRH 1b. ;
: PWR-PDCRH. ." PWR-PDCRH (read-write) $" PWR-PDCRH @ hex. PWR-PDCRH 1b. ;
: PWR-EXTSCR. ." PWR-EXTSCR () $" PWR-EXTSCR @ hex. PWR-EXTSCR 1b. ;
: PWR-SUBGHZSPICR. ." PWR-SUBGHZSPICR (read-write) $" PWR-SUBGHZSPICR @ hex. PWR-SUBGHZSPICR 1b. ;
: PWR.
PWR-CR1.
PWR-CR2.
PWR-CR3.
PWR-CR4.
PWR-SR1.
PWR-SR2.
PWR-SCR.
PWR-CR5.
PWR-PUCRA.
PWR-PDCRA.
PWR-PUCRB.
PWR-PDCRB.
PWR-PUCRC.
PWR-PDCRC.
PWR-PUCRH.
PWR-PDCRH.
PWR-EXTSCR.
PWR-SUBGHZSPICR.
;

$58000000 constant RCC ( Reset and clock control ) 
RCC $0 + constant RCC-CR ( Clock control register ) 
RCC $4 + constant RCC-ICSCR ( Internal clock sources calibration register ) 
RCC $8 + constant RCC-CFGR ( Clock configuration register ) 
RCC $C + constant RCC-PLLCFGR ( PLL configuration register ) 
RCC $18 + constant RCC-CIER ( Clock interrupt enable register ) 
RCC $1C + constant RCC-CIFR ( Clock interrupt flag register ) 
RCC $20 + constant RCC-CICR ( Clock interrupt clear register ) 
RCC $28 + constant RCC-AHB1RSTR ( AHB1 peripheral reset register ) 
RCC $2C + constant RCC-AHB2RSTR ( AHB2 peripheral reset register ) 
RCC $30 + constant RCC-AHB3RSTR ( AHB3 peripheral reset register ) 
RCC $38 + constant RCC-APB1RSTR1 ( APB1 peripheral reset register 1 ) 
RCC $3C + constant RCC-APB1RSTR2 ( APB1 peripheral reset register 2 ) 
RCC $40 + constant RCC-APB2RSTR ( APB2 peripheral reset register ) 
RCC $44 + constant RCC-APB3RSTR ( APB3 peripheral reset register ) 
RCC $48 + constant RCC-AHB1ENR ( AHB1 peripheral clock enable register ) 
RCC $4C + constant RCC-AHB2ENR ( AHB2 peripheral clock enable register ) 
RCC $50 + constant RCC-AHB3ENR ( AHB3 peripheral clock enable register ) 
RCC $58 + constant RCC-APB1ENR1 ( APB1 peripheral clock enable register 1 ) 
RCC $5C + constant RCC-APB1ENR2 ( APB1 peripheral clock enable register 2 ) 
RCC $60 + constant RCC-APB2ENR ( APB2 peripheral clock enable register ) 
RCC $64 + constant RCC-APB3ENR ( APB3 peripheral clock enable register ) 
RCC $68 + constant RCC-AHB1SMENR ( AHB1 peripheral clocks enable in Sleep modes register ) 
RCC $6C + constant RCC-AHB2SMENR ( AHB2 peripheral clocks enable in Sleep modes register ) 
RCC $70 + constant RCC-AHB3SMENR ( AHB3 peripheral clocks enable in Sleep and Stop modes register ) 
RCC $78 + constant RCC-APB1SMENR1 ( APB1 peripheral clocks enable in Sleep mode register 1 ) 
RCC $7C + constant RCC-APB1SMENR2 ( APB1 peripheral clocks enable in Sleep mode register 2 ) 
RCC $80 + constant RCC-APB2SMENR ( APB2 peripheral clocks enable in Sleep mode register ) 
RCC $84 + constant RCC-APB3SMENR ( APB3 peripheral clock enable in Sleep mode register ) 
RCC $88 + constant RCC-CCIPR ( Peripherals independent clock configuration register ) 
RCC $90 + constant RCC-BDCR ( Backup domain control register ) 
RCC $94 + constant RCC-CSR ( Control/status register ) 
RCC $108 + constant RCC-EXTCFGR ( Extended clock recovery register ) 
: RCC-CR. ." RCC-CR () $" RCC-CR @ hex. RCC-CR 1b. ;
: RCC-ICSCR. ." RCC-ICSCR () $" RCC-ICSCR @ hex. RCC-ICSCR 1b. ;
: RCC-CFGR. ." RCC-CFGR () $" RCC-CFGR @ hex. RCC-CFGR 1b. ;
: RCC-PLLCFGR. ." RCC-PLLCFGR (read-write) $" RCC-PLLCFGR @ hex. RCC-PLLCFGR 1b. ;
: RCC-CIER. ." RCC-CIER (read-write) $" RCC-CIER @ hex. RCC-CIER 1b. ;
: RCC-CIFR. ." RCC-CIFR (read-only) $" RCC-CIFR @ hex. RCC-CIFR 1b. ;
: RCC-CICR. ." RCC-CICR (write-only) $" RCC-CICR @ hex. RCC-CICR 1b. ;
: RCC-AHB1RSTR. ." RCC-AHB1RSTR (read-write) $" RCC-AHB1RSTR @ hex. RCC-AHB1RSTR 1b. ;
: RCC-AHB2RSTR. ." RCC-AHB2RSTR (read-write) $" RCC-AHB2RSTR @ hex. RCC-AHB2RSTR 1b. ;
: RCC-AHB3RSTR. ." RCC-AHB3RSTR (read-write) $" RCC-AHB3RSTR @ hex. RCC-AHB3RSTR 1b. ;
: RCC-APB1RSTR1. ." RCC-APB1RSTR1 (read-write) $" RCC-APB1RSTR1 @ hex. RCC-APB1RSTR1 1b. ;
: RCC-APB1RSTR2. ." RCC-APB1RSTR2 (read-write) $" RCC-APB1RSTR2 @ hex. RCC-APB1RSTR2 1b. ;
: RCC-APB2RSTR. ." RCC-APB2RSTR (read-write) $" RCC-APB2RSTR @ hex. RCC-APB2RSTR 1b. ;
: RCC-APB3RSTR. ." RCC-APB3RSTR (read-write) $" RCC-APB3RSTR @ hex. RCC-APB3RSTR 1b. ;
: RCC-AHB1ENR. ." RCC-AHB1ENR (read-write) $" RCC-AHB1ENR @ hex. RCC-AHB1ENR 1b. ;
: RCC-AHB2ENR. ." RCC-AHB2ENR (read-write) $" RCC-AHB2ENR @ hex. RCC-AHB2ENR 1b. ;
: RCC-AHB3ENR. ." RCC-AHB3ENR (read-write) $" RCC-AHB3ENR @ hex. RCC-AHB3ENR 1b. ;
: RCC-APB1ENR1. ." RCC-APB1ENR1 () $" RCC-APB1ENR1 @ hex. RCC-APB1ENR1 1b. ;
: RCC-APB1ENR2. ." RCC-APB1ENR2 (read-write) $" RCC-APB1ENR2 @ hex. RCC-APB1ENR2 1b. ;
: RCC-APB2ENR. ." RCC-APB2ENR (read-write) $" RCC-APB2ENR @ hex. RCC-APB2ENR 1b. ;
: RCC-APB3ENR. ." RCC-APB3ENR (read-write) $" RCC-APB3ENR @ hex. RCC-APB3ENR 1b. ;
: RCC-AHB1SMENR. ." RCC-AHB1SMENR (read-write) $" RCC-AHB1SMENR @ hex. RCC-AHB1SMENR 1b. ;
: RCC-AHB2SMENR. ." RCC-AHB2SMENR (read-write) $" RCC-AHB2SMENR @ hex. RCC-AHB2SMENR 1b. ;
: RCC-AHB3SMENR. ." RCC-AHB3SMENR (read-write) $" RCC-AHB3SMENR @ hex. RCC-AHB3SMENR 1b. ;
: RCC-APB1SMENR1. ." RCC-APB1SMENR1 (read-write) $" RCC-APB1SMENR1 @ hex. RCC-APB1SMENR1 1b. ;
: RCC-APB1SMENR2. ." RCC-APB1SMENR2 (read-write) $" RCC-APB1SMENR2 @ hex. RCC-APB1SMENR2 1b. ;
: RCC-APB2SMENR. ." RCC-APB2SMENR (read-write) $" RCC-APB2SMENR @ hex. RCC-APB2SMENR 1b. ;
: RCC-APB3SMENR. ." RCC-APB3SMENR (read-write) $" RCC-APB3SMENR @ hex. RCC-APB3SMENR 1b. ;
: RCC-CCIPR. ." RCC-CCIPR (read-write) $" RCC-CCIPR @ hex. RCC-CCIPR 1b. ;
: RCC-BDCR. ." RCC-BDCR () $" RCC-BDCR @ hex. RCC-BDCR 1b. ;
: RCC-CSR. ." RCC-CSR () $" RCC-CSR @ hex. RCC-CSR 1b. ;
: RCC-EXTCFGR. ." RCC-EXTCFGR () $" RCC-EXTCFGR @ hex. RCC-EXTCFGR 1b. ;
: RCC.
RCC-CR.
RCC-ICSCR.
RCC-CFGR.
RCC-PLLCFGR.
RCC-CIER.
RCC-CIFR.
RCC-CICR.
RCC-AHB1RSTR.
RCC-AHB2RSTR.
RCC-AHB3RSTR.
RCC-APB1RSTR1.
RCC-APB1RSTR2.
RCC-APB2RSTR.
RCC-APB3RSTR.
RCC-AHB1ENR.
RCC-AHB2ENR.
RCC-AHB3ENR.
RCC-APB1ENR1.
RCC-APB1ENR2.
RCC-APB2ENR.
RCC-APB3ENR.
RCC-AHB1SMENR.
RCC-AHB2SMENR.
RCC-AHB3SMENR.
RCC-APB1SMENR1.
RCC-APB1SMENR2.
RCC-APB2SMENR.
RCC-APB3SMENR.
RCC-CCIPR.
RCC-BDCR.
RCC-CSR.
RCC-EXTCFGR.
;

$58001000 constant RNG ( True random number generator ) 
RNG $0 + constant RNG-CR ( control register ) 
RNG $4 + constant RNG-SR ( status register ) 
RNG $8 + constant RNG-DR ( data register ) 
RNG $10 + constant RNG-HTCR ( health test control register ) 
: RNG-CR. ." RNG-CR (read-write) $" RNG-CR @ hex. RNG-CR 1b. ;
: RNG-SR. ." RNG-SR () $" RNG-SR @ hex. RNG-SR 1b. ;
: RNG-DR. ." RNG-DR (read-only) $" RNG-DR @ hex. RNG-DR 1b. ;
: RNG-HTCR. ." RNG-HTCR (read-write) $" RNG-HTCR @ hex. RNG-HTCR 1b. ;
: RNG.
RNG-CR.
RNG-SR.
RNG-DR.
RNG-HTCR.
;

$40002800 constant RTC ( Real-time clock ) 
RTC $0 + constant RTC-TR ( TR ) 
RTC $4 + constant RTC-DR ( DR ) 
RTC $8 + constant RTC-SSR ( SSR ) 
RTC $C + constant RTC-ICSR ( ICSR ) 
RTC $10 + constant RTC-PRER ( PRER ) 
RTC $14 + constant RTC-WUTR ( WUTR ) 
RTC $18 + constant RTC-CR ( CR ) 
RTC $24 + constant RTC-WPR ( write protection register ) 
RTC $28 + constant RTC-CALR ( CALR ) 
RTC $2C + constant RTC-SHIFTR ( SHIFTR ) 
RTC $30 + constant RTC-TSTR ( TSTR ) 
RTC $34 + constant RTC-TSDR ( TSDR ) 
RTC $38 + constant RTC-TSSSR ( TSSSR ) 
RTC $40 + constant RTC-ALRMAR ( ALRMAR ) 
RTC $44 + constant RTC-ALRMASSR ( ALRMASSR ) 
RTC $48 + constant RTC-ALRMBR ( ALRMBR ) 
RTC $4C + constant RTC-ALRMBSSR ( ALRMBSSR ) 
RTC $50 + constant RTC-SR ( SR ) 
RTC $54 + constant RTC-MISR ( MISR ) 
RTC $5C + constant RTC-SCR ( SCR ) 
RTC $70 + constant RTC-ALRABINR ( RTC alarm A binary mode register ) 
RTC $74 + constant RTC-ALRBBINR ( RTC alarm B binary mode register ) 
: RTC-TR. ." RTC-TR (read-write) $" RTC-TR @ hex. RTC-TR 1b. ;
: RTC-DR. ." RTC-DR (read-write) $" RTC-DR @ hex. RTC-DR 1b. ;
: RTC-SSR. ." RTC-SSR (read-only) $" RTC-SSR @ hex. RTC-SSR 1b. ;
: RTC-ICSR. ." RTC-ICSR () $" RTC-ICSR @ hex. RTC-ICSR 1b. ;
: RTC-PRER. ." RTC-PRER (read-write) $" RTC-PRER @ hex. RTC-PRER 1b. ;
: RTC-WUTR. ." RTC-WUTR (read-write) $" RTC-WUTR @ hex. RTC-WUTR 1b. ;
: RTC-CR. ." RTC-CR () $" RTC-CR @ hex. RTC-CR 1b. ;
: RTC-WPR. ." RTC-WPR (write-only) $" RTC-WPR @ hex. RTC-WPR 1b. ;
: RTC-CALR. ." RTC-CALR (read-write) $" RTC-CALR @ hex. RTC-CALR 1b. ;
: RTC-SHIFTR. ." RTC-SHIFTR (write-only) $" RTC-SHIFTR @ hex. RTC-SHIFTR 1b. ;
: RTC-TSTR. ." RTC-TSTR (read-only) $" RTC-TSTR @ hex. RTC-TSTR 1b. ;
: RTC-TSDR. ." RTC-TSDR (read-only) $" RTC-TSDR @ hex. RTC-TSDR 1b. ;
: RTC-TSSSR. ." RTC-TSSSR (read-only) $" RTC-TSSSR @ hex. RTC-TSSSR 1b. ;
: RTC-ALRMAR. ." RTC-ALRMAR (read-write) $" RTC-ALRMAR @ hex. RTC-ALRMAR 1b. ;
: RTC-ALRMASSR. ." RTC-ALRMASSR (read-write) $" RTC-ALRMASSR @ hex. RTC-ALRMASSR 1b. ;
: RTC-ALRMBR. ." RTC-ALRMBR (read-write) $" RTC-ALRMBR @ hex. RTC-ALRMBR 1b. ;
: RTC-ALRMBSSR. ." RTC-ALRMBSSR (read-write) $" RTC-ALRMBSSR @ hex. RTC-ALRMBSSR 1b. ;
: RTC-SR. ." RTC-SR (read-only) $" RTC-SR @ hex. RTC-SR 1b. ;
: RTC-MISR. ." RTC-MISR (read-only) $" RTC-MISR @ hex. RTC-MISR 1b. ;
: RTC-SCR. ." RTC-SCR (write-only) $" RTC-SCR @ hex. RTC-SCR 1b. ;
: RTC-ALRABINR. ." RTC-ALRABINR (read-write) $" RTC-ALRABINR @ hex. RTC-ALRABINR 1b. ;
: RTC-ALRBBINR. ." RTC-ALRBBINR (read-write) $" RTC-ALRBBINR @ hex. RTC-ALRBBINR 1b. ;
: RTC.
RTC-TR.
RTC-DR.
RTC-SSR.
RTC-ICSR.
RTC-PRER.
RTC-WUTR.
RTC-CR.
RTC-WPR.
RTC-CALR.
RTC-SHIFTR.
RTC-TSTR.
RTC-TSDR.
RTC-TSSSR.
RTC-ALRMAR.
RTC-ALRMASSR.
RTC-ALRMBR.
RTC-ALRMBSSR.
RTC-SR.
RTC-MISR.
RTC-SCR.
RTC-ALRABINR.
RTC-ALRBBINR.
;

$E000ED00 constant SCB ( System control block ) 
SCB $0 + constant SCB-CPUID ( CPUID base register ) 
SCB $4 + constant SCB-ICSR ( Interrupt control and state register ) 
SCB $8 + constant SCB-VTOR ( Vector table offset register ) 
SCB $C + constant SCB-AIRCR ( Application interrupt and reset control register ) 
SCB $10 + constant SCB-SCR ( System control register ) 
SCB $14 + constant SCB-CCR ( Configuration and control register ) 
SCB $18 + constant SCB-SHPR1 ( System handler priority registers ) 
SCB $1C + constant SCB-SHPR2 ( System handler priority registers ) 
SCB $20 + constant SCB-SHPR3 ( System handler priority registers ) 
SCB $24 + constant SCB-SHCSR ( System handler control and state register ) 
SCB $28 + constant SCB-CFSR_UFSR_BFSR_MMFSR ( Configurable fault status register ) 
SCB $2C + constant SCB-HFSR ( Hard fault status register ) 
SCB $34 + constant SCB-MMFAR ( Memory management fault address register ) 
SCB $38 + constant SCB-BFAR ( Bus fault address register ) 
SCB $3C + constant SCB-AFSR ( Auxiliary fault status register ) 
: SCB-CPUID. ." SCB-CPUID (read-only) $" SCB-CPUID @ hex. SCB-CPUID 1b. ;
: SCB-ICSR. ." SCB-ICSR (read-write) $" SCB-ICSR @ hex. SCB-ICSR 1b. ;
: SCB-VTOR. ." SCB-VTOR (read-write) $" SCB-VTOR @ hex. SCB-VTOR 1b. ;
: SCB-AIRCR. ." SCB-AIRCR (read-write) $" SCB-AIRCR @ hex. SCB-AIRCR 1b. ;
: SCB-SCR. ." SCB-SCR (read-write) $" SCB-SCR @ hex. SCB-SCR 1b. ;
: SCB-CCR. ." SCB-CCR (read-write) $" SCB-CCR @ hex. SCB-CCR 1b. ;
: SCB-SHPR1. ." SCB-SHPR1 (read-write) $" SCB-SHPR1 @ hex. SCB-SHPR1 1b. ;
: SCB-SHPR2. ." SCB-SHPR2 (read-write) $" SCB-SHPR2 @ hex. SCB-SHPR2 1b. ;
: SCB-SHPR3. ." SCB-SHPR3 (read-write) $" SCB-SHPR3 @ hex. SCB-SHPR3 1b. ;
: SCB-SHCSR. ." SCB-SHCSR (read-write) $" SCB-SHCSR @ hex. SCB-SHCSR 1b. ;
: SCB-CFSR_UFSR_BFSR_MMFSR. ." SCB-CFSR_UFSR_BFSR_MMFSR (read-write) $" SCB-CFSR_UFSR_BFSR_MMFSR @ hex. SCB-CFSR_UFSR_BFSR_MMFSR 1b. ;
: SCB-HFSR. ." SCB-HFSR (read-write) $" SCB-HFSR @ hex. SCB-HFSR 1b. ;
: SCB-MMFAR. ." SCB-MMFAR (read-write) $" SCB-MMFAR @ hex. SCB-MMFAR 1b. ;
: SCB-BFAR. ." SCB-BFAR (read-write) $" SCB-BFAR @ hex. SCB-BFAR 1b. ;
: SCB-AFSR. ." SCB-AFSR (read-write) $" SCB-AFSR @ hex. SCB-AFSR 1b. ;
: SCB.
SCB-CPUID.
SCB-ICSR.
SCB-VTOR.
SCB-AIRCR.
SCB-SCR.
SCB-CCR.
SCB-SHPR1.
SCB-SHPR2.
SCB-SHPR3.
SCB-SHCSR.
SCB-CFSR_UFSR_BFSR_MMFSR.
SCB-HFSR.
SCB-MMFAR.
SCB-BFAR.
SCB-AFSR.
;

$E000E008 constant SCB_ACTRL ( System control block ACTLR ) 
SCB_ACTRL $0 + constant SCB_ACTRL-ACTRL ( Auxiliary control register ) 
: SCB_ACTRL-ACTRL. ." SCB_ACTRL-ACTRL (read-write) $" SCB_ACTRL-ACTRL @ hex. SCB_ACTRL-ACTRL 1b. ;
: SCB_ACTRL.
SCB_ACTRL-ACTRL.
;

$40013000 constant SPI1 ( Serial peripheral interface/Inter-IC sound ) 
SPI1 $0 + constant SPI1-CR1 ( control register 1 ) 
SPI1 $4 + constant SPI1-CR2 ( control register 2 ) 
SPI1 $8 + constant SPI1-SR ( status register ) 
SPI1 $C + constant SPI1-DR ( data register ) 
SPI1 $10 + constant SPI1-CRCPR ( CRC polynomial register ) 
SPI1 $14 + constant SPI1-RXCRCR ( RX CRC register ) 
SPI1 $18 + constant SPI1-TXCRCR ( TX CRC register ) 
SPI1 $1C + constant SPI1-I2SCFGR ( configuration register ) 
SPI1 $20 + constant SPI1-I2SPR ( prescaler register ) 
: SPI1-CR1. ." SPI1-CR1 (read-write) $" SPI1-CR1 @ hex. SPI1-CR1 1b. ;
: SPI1-CR2. ." SPI1-CR2 (read-write) $" SPI1-CR2 @ hex. SPI1-CR2 1b. ;
: SPI1-SR. ." SPI1-SR () $" SPI1-SR @ hex. SPI1-SR 1b. ;
: SPI1-DR. ." SPI1-DR (read-write) $" SPI1-DR @ hex. SPI1-DR 1b. ;
: SPI1-CRCPR. ." SPI1-CRCPR (read-write) $" SPI1-CRCPR @ hex. SPI1-CRCPR 1b. ;
: SPI1-RXCRCR. ." SPI1-RXCRCR (read-only) $" SPI1-RXCRCR @ hex. SPI1-RXCRCR 1b. ;
: SPI1-TXCRCR. ." SPI1-TXCRCR (read-only) $" SPI1-TXCRCR @ hex. SPI1-TXCRCR 1b. ;
: SPI1-I2SCFGR. ." SPI1-I2SCFGR (read-write) $" SPI1-I2SCFGR @ hex. SPI1-I2SCFGR 1b. ;
: SPI1-I2SPR. ." SPI1-I2SPR (read-write) $" SPI1-I2SPR @ hex. SPI1-I2SPR 1b. ;
: SPI1.
SPI1-CR1.
SPI1-CR2.
SPI1-SR.
SPI1-DR.
SPI1-CRCPR.
SPI1-RXCRCR.
SPI1-TXCRCR.
SPI1-I2SCFGR.
SPI1-I2SPR.
;

$E000E010 constant STK ( SysTick timer ) 
STK $0 + constant STK-CTRL ( SysTick control and status register ) 
STK $4 + constant STK-LOAD ( SysTick reload value register ) 
STK $8 + constant STK-VAL ( SysTick current value register ) 
STK $C + constant STK-CALIB ( SysTick calibration value register ) 
: STK-CTRL. ." STK-CTRL (read-write) $" STK-CTRL @ hex. STK-CTRL 1b. ;
: STK-LOAD. ." STK-LOAD (read-write) $" STK-LOAD @ hex. STK-LOAD 1b. ;
: STK-VAL. ." STK-VAL (read-write) $" STK-VAL @ hex. STK-VAL 1b. ;
: STK-CALIB. ." STK-CALIB (read-write) $" STK-CALIB @ hex. STK-CALIB 1b. ;
: STK.
STK-CTRL.
STK-LOAD.
STK-VAL.
STK-CALIB.
;

$40010000 constant SYSCFG ( System configuration controller ) 
SYSCFG $0 + constant SYSCFG-MEMRMP ( memory remap register ) 
SYSCFG $4 + constant SYSCFG-CFGR1 ( configuration register 1 ) 
SYSCFG $8 + constant SYSCFG-EXTICR1 ( external interrupt configuration register 1 ) 
SYSCFG $C + constant SYSCFG-EXTICR2 ( external interrupt configuration register 2 ) 
SYSCFG $10 + constant SYSCFG-EXTICR3 ( external interrupt configuration register 3 ) 
SYSCFG $14 + constant SYSCFG-EXTICR4 ( external interrupt configuration register 4 ) 
SYSCFG $18 + constant SYSCFG-SCSR ( SCSR ) 
SYSCFG $1C + constant SYSCFG-CFGR2 ( CFGR2 ) 
SYSCFG $20 + constant SYSCFG-SWPR ( SWPR ) 
SYSCFG $24 + constant SYSCFG-SKR ( SKR ) 
SYSCFG $208 + constant SYSCFG-RFDCR ( radio debug control register ) 
: SYSCFG-MEMRMP. ." SYSCFG-MEMRMP (read-write) $" SYSCFG-MEMRMP @ hex. SYSCFG-MEMRMP 1b. ;
: SYSCFG-CFGR1. ." SYSCFG-CFGR1 (read-write) $" SYSCFG-CFGR1 @ hex. SYSCFG-CFGR1 1b. ;
: SYSCFG-EXTICR1. ." SYSCFG-EXTICR1 (read-write) $" SYSCFG-EXTICR1 @ hex. SYSCFG-EXTICR1 1b. ;
: SYSCFG-EXTICR2. ." SYSCFG-EXTICR2 (read-write) $" SYSCFG-EXTICR2 @ hex. SYSCFG-EXTICR2 1b. ;
: SYSCFG-EXTICR3. ." SYSCFG-EXTICR3 (read-write) $" SYSCFG-EXTICR3 @ hex. SYSCFG-EXTICR3 1b. ;
: SYSCFG-EXTICR4. ." SYSCFG-EXTICR4 (read-write) $" SYSCFG-EXTICR4 @ hex. SYSCFG-EXTICR4 1b. ;
: SYSCFG-SCSR. ." SYSCFG-SCSR () $" SYSCFG-SCSR @ hex. SYSCFG-SCSR 1b. ;
: SYSCFG-CFGR2. ." SYSCFG-CFGR2 () $" SYSCFG-CFGR2 @ hex. SYSCFG-CFGR2 1b. ;
: SYSCFG-SWPR. ." SYSCFG-SWPR (read-write) $" SYSCFG-SWPR @ hex. SYSCFG-SWPR 1b. ;
: SYSCFG-SKR. ." SYSCFG-SKR (write-only) $" SYSCFG-SKR @ hex. SYSCFG-SKR 1b. ;
: SYSCFG-RFDCR. ." SYSCFG-RFDCR (read-write) $" SYSCFG-RFDCR @ hex. SYSCFG-RFDCR 1b. ;
: SYSCFG.
SYSCFG-MEMRMP.
SYSCFG-CFGR1.
SYSCFG-EXTICR1.
SYSCFG-EXTICR2.
SYSCFG-EXTICR3.
SYSCFG-EXTICR4.
SYSCFG-SCSR.
SYSCFG-CFGR2.
SYSCFG-SWPR.
SYSCFG-SKR.
SYSCFG-RFDCR.
;

$40010100 constant SYSCFG_continue ( System configuration controller ) 
SYSCFG_continue $0 + constant SYSCFG_continue-IMR1 ( IMR1 ) 
SYSCFG_continue $4 + constant SYSCFG_continue-IMR2 ( IMR2 ) 
SYSCFG_continue $8 + constant SYSCFG_continue-C2IMR1 ( C2IMR1 ) 
SYSCFG_continue $C + constant SYSCFG_continue-C2IMR2 ( C2IMR2 ) 
: SYSCFG_continue-IMR1. ." SYSCFG_continue-IMR1 (read-write) $" SYSCFG_continue-IMR1 @ hex. SYSCFG_continue-IMR1 1b. ;
: SYSCFG_continue-IMR2. ." SYSCFG_continue-IMR2 (read-write) $" SYSCFG_continue-IMR2 @ hex. SYSCFG_continue-IMR2 1b. ;
: SYSCFG_continue-C2IMR1. ." SYSCFG_continue-C2IMR1 (read-write) $" SYSCFG_continue-C2IMR1 @ hex. SYSCFG_continue-C2IMR1 1b. ;
: SYSCFG_continue-C2IMR2. ." SYSCFG_continue-C2IMR2 (read-write) $" SYSCFG_continue-C2IMR2 @ hex. SYSCFG_continue-C2IMR2 1b. ;
: SYSCFG_continue.
SYSCFG_continue-IMR1.
SYSCFG_continue-IMR2.
SYSCFG_continue-C2IMR1.
SYSCFG_continue-C2IMR2.
;

$40014400 constant TIM16 ( General-purpose timers ) 
TIM16 $0 + constant TIM16-CR1 ( TIM16/TIM17 control register 1 ) 
TIM16 $4 + constant TIM16-CR2 ( TIM16/TIM17 control register 2 ) 
TIM16 $C + constant TIM16-DIER ( TIM16/TIM17 DMA/interrupt enable register ) 
TIM16 $10 + constant TIM16-SR ( TIM16/TIM17 status register ) 
TIM16 $14 + constant TIM16-EGR ( TIM16/TIM17 event generation register ) 
TIM16 $18 + constant TIM16-CCMR1_Output ( TIM16/TIM17 capture/compare mode register 1 ) 
TIM16 $18 + constant TIM16-CCMR1_Input ( TIM16/TIM17 capture/compare mode register 1 ) 
TIM16 $20 + constant TIM16-CCER ( TIM16/TIM17 capture/compare enable register ) 
TIM16 $24 + constant TIM16-CNT ( TIM16/TIM17 counter ) 
TIM16 $28 + constant TIM16-PSC ( TIM16/TIM17 prescaler ) 
TIM16 $2C + constant TIM16-ARR ( TIM16/TIM17 auto-reload register ) 
TIM16 $30 + constant TIM16-RCR ( TIM16/TIM17 repetition counter register ) 
TIM16 $34 + constant TIM16-CCR1 ( TIM16/TIM17 capture/compare register 1 ) 
TIM16 $44 + constant TIM16-BDTR ( TIM16/TIM17 break and dead-time register ) 
TIM16 $48 + constant TIM16-DCR ( TIM16/TIM17 DMA control register ) 
TIM16 $4C + constant TIM16-DMAR ( TIM16/TIM17 DMA address for full transfer ) 
TIM16 $50 + constant TIM16-TIM16_OR1 ( TIM16 option register 1 ) 
TIM16 $60 + constant TIM16-TIM16_AF1 ( TIM16 alternate function register 1 ) 
TIM16 $68 + constant TIM16-TIM16_TISEL ( TIM16 input selection register ) 
: TIM16-CR1. ." TIM16-CR1 (read-write) $" TIM16-CR1 @ hex. TIM16-CR1 1b. ;
: TIM16-CR2. ." TIM16-CR2 (read-write) $" TIM16-CR2 @ hex. TIM16-CR2 1b. ;
: TIM16-DIER. ." TIM16-DIER (read-write) $" TIM16-DIER @ hex. TIM16-DIER 1b. ;
: TIM16-SR. ." TIM16-SR (read-write) $" TIM16-SR @ hex. TIM16-SR 1b. ;
: TIM16-EGR. ." TIM16-EGR (write-only) $" TIM16-EGR @ hex. TIM16-EGR 1b. ;
: TIM16-CCMR1_Output. ." TIM16-CCMR1_Output (read-write) $" TIM16-CCMR1_Output @ hex. TIM16-CCMR1_Output 1b. ;
: TIM16-CCMR1_Input. ." TIM16-CCMR1_Input (read-write) $" TIM16-CCMR1_Input @ hex. TIM16-CCMR1_Input 1b. ;
: TIM16-CCER. ." TIM16-CCER (read-write) $" TIM16-CCER @ hex. TIM16-CCER 1b. ;
: TIM16-CNT. ." TIM16-CNT () $" TIM16-CNT @ hex. TIM16-CNT 1b. ;
: TIM16-PSC. ." TIM16-PSC (read-write) $" TIM16-PSC @ hex. TIM16-PSC 1b. ;
: TIM16-ARR. ." TIM16-ARR (read-write) $" TIM16-ARR @ hex. TIM16-ARR 1b. ;
: TIM16-RCR. ." TIM16-RCR (read-write) $" TIM16-RCR @ hex. TIM16-RCR 1b. ;
: TIM16-CCR1. ." TIM16-CCR1 (read-write) $" TIM16-CCR1 @ hex. TIM16-CCR1 1b. ;
: TIM16-BDTR. ." TIM16-BDTR (read-write) $" TIM16-BDTR @ hex. TIM16-BDTR 1b. ;
: TIM16-DCR. ." TIM16-DCR (read-write) $" TIM16-DCR @ hex. TIM16-DCR 1b. ;
: TIM16-DMAR. ." TIM16-DMAR (read-write) $" TIM16-DMAR @ hex. TIM16-DMAR 1b. ;
: TIM16-TIM16_OR1. ." TIM16-TIM16_OR1 (read-write) $" TIM16-TIM16_OR1 @ hex. TIM16-TIM16_OR1 1b. ;
: TIM16-TIM16_AF1. ." TIM16-TIM16_AF1 (read-write) $" TIM16-TIM16_AF1 @ hex. TIM16-TIM16_AF1 1b. ;
: TIM16-TIM16_TISEL. ." TIM16-TIM16_TISEL (read-write) $" TIM16-TIM16_TISEL @ hex. TIM16-TIM16_TISEL 1b. ;
: TIM16.
TIM16-CR1.
TIM16-CR2.
TIM16-DIER.
TIM16-SR.
TIM16-EGR.
TIM16-CCMR1_Output.
TIM16-CCMR1_Input.
TIM16-CCER.
TIM16-CNT.
TIM16-PSC.
TIM16-ARR.
TIM16-RCR.
TIM16-CCR1.
TIM16-BDTR.
TIM16-DCR.
TIM16-DMAR.
TIM16-TIM16_OR1.
TIM16-TIM16_AF1.
TIM16-TIM16_TISEL.
;

$40014800 constant TIM17 ( General-purpose timers ) 
TIM17 $0 + constant TIM17-CR1 ( TIM16/TIM17 control register 1 ) 
TIM17 $4 + constant TIM17-CR2 ( TIM16/TIM17 control register 2 ) 
TIM17 $C + constant TIM17-DIER ( TIM16/TIM17 DMA/interrupt enable register ) 
TIM17 $10 + constant TIM17-SR ( TIM16/TIM17 status register ) 
TIM17 $14 + constant TIM17-EGR ( TIM16/TIM17 event generation register ) 
TIM17 $18 + constant TIM17-CCMR1_Output ( TIM16/TIM17 capture/compare mode register 1 ) 
TIM17 $18 + constant TIM17-CCMR1_Input ( TIM16/TIM17 capture/compare mode register 1 ) 
TIM17 $20 + constant TIM17-CCER ( TIM16/TIM17 capture/compare enable register ) 
TIM17 $24 + constant TIM17-CNT ( TIM16/TIM17 counter ) 
TIM17 $28 + constant TIM17-PSC ( TIM16/TIM17 prescaler ) 
TIM17 $2C + constant TIM17-ARR ( TIM16/TIM17 auto-reload register ) 
TIM17 $30 + constant TIM17-RCR ( TIM16/TIM17 repetition counter register ) 
TIM17 $34 + constant TIM17-CCR1 ( TIM16/TIM17 capture/compare register 1 ) 
TIM17 $44 + constant TIM17-BDTR ( TIM16/TIM17 break and dead-time register ) 
TIM17 $48 + constant TIM17-DCR ( TIM16/TIM17 DMA control register ) 
TIM17 $4C + constant TIM17-DMAR ( TIM16/TIM17 DMA address for full transfer ) 
TIM17 $50 + constant TIM17-TIM17_OR1 ( TIM17 option register 1 ) 
TIM17 $60 + constant TIM17-TIM17_AF1 ( TIM17 alternate function register 1 ) 
TIM17 $68 + constant TIM17-TIM17_TISEL ( TIM17 input selection register ) 
: TIM17-CR1. ." TIM17-CR1 (read-write) $" TIM17-CR1 @ hex. TIM17-CR1 1b. ;
: TIM17-CR2. ." TIM17-CR2 (read-write) $" TIM17-CR2 @ hex. TIM17-CR2 1b. ;
: TIM17-DIER. ." TIM17-DIER (read-write) $" TIM17-DIER @ hex. TIM17-DIER 1b. ;
: TIM17-SR. ." TIM17-SR (read-write) $" TIM17-SR @ hex. TIM17-SR 1b. ;
: TIM17-EGR. ." TIM17-EGR (write-only) $" TIM17-EGR @ hex. TIM17-EGR 1b. ;
: TIM17-CCMR1_Output. ." TIM17-CCMR1_Output (read-write) $" TIM17-CCMR1_Output @ hex. TIM17-CCMR1_Output 1b. ;
: TIM17-CCMR1_Input. ." TIM17-CCMR1_Input (read-write) $" TIM17-CCMR1_Input @ hex. TIM17-CCMR1_Input 1b. ;
: TIM17-CCER. ." TIM17-CCER (read-write) $" TIM17-CCER @ hex. TIM17-CCER 1b. ;
: TIM17-CNT. ." TIM17-CNT () $" TIM17-CNT @ hex. TIM17-CNT 1b. ;
: TIM17-PSC. ." TIM17-PSC (read-write) $" TIM17-PSC @ hex. TIM17-PSC 1b. ;
: TIM17-ARR. ." TIM17-ARR (read-write) $" TIM17-ARR @ hex. TIM17-ARR 1b. ;
: TIM17-RCR. ." TIM17-RCR (read-write) $" TIM17-RCR @ hex. TIM17-RCR 1b. ;
: TIM17-CCR1. ." TIM17-CCR1 (read-write) $" TIM17-CCR1 @ hex. TIM17-CCR1 1b. ;
: TIM17-BDTR. ." TIM17-BDTR (read-write) $" TIM17-BDTR @ hex. TIM17-BDTR 1b. ;
: TIM17-DCR. ." TIM17-DCR (read-write) $" TIM17-DCR @ hex. TIM17-DCR 1b. ;
: TIM17-DMAR. ." TIM17-DMAR (read-write) $" TIM17-DMAR @ hex. TIM17-DMAR 1b. ;
: TIM17-TIM17_OR1. ." TIM17-TIM17_OR1 (read-write) $" TIM17-TIM17_OR1 @ hex. TIM17-TIM17_OR1 1b. ;
: TIM17-TIM17_AF1. ." TIM17-TIM17_AF1 (read-write) $" TIM17-TIM17_AF1 @ hex. TIM17-TIM17_AF1 1b. ;
: TIM17-TIM17_TISEL. ." TIM17-TIM17_TISEL (read-write) $" TIM17-TIM17_TISEL @ hex. TIM17-TIM17_TISEL 1b. ;
: TIM17.
TIM17-CR1.
TIM17-CR2.
TIM17-DIER.
TIM17-SR.
TIM17-EGR.
TIM17-CCMR1_Output.
TIM17-CCMR1_Input.
TIM17-CCER.
TIM17-CNT.
TIM17-PSC.
TIM17-ARR.
TIM17-RCR.
TIM17-CCR1.
TIM17-BDTR.
TIM17-DCR.
TIM17-DMAR.
TIM17-TIM17_OR1.
TIM17-TIM17_AF1.
TIM17-TIM17_TISEL.
;

$40013800 constant USART1 ( Universal synchronous asynchronous receiver transmitter ) 
USART1 $0 + constant USART1-CR1 ( control register 1 ) 
USART1 $4 + constant USART1-CR2 ( control register 2 ) 
USART1 $8 + constant USART1-CR3 ( control register 3 ) 
USART1 $C + constant USART1-BRR ( baud rate register ) 
USART1 $10 + constant USART1-GTPR ( guard time and prescaler register ) 
USART1 $14 + constant USART1-RTOR ( receiver timeout register ) 
USART1 $18 + constant USART1-RQR ( request register ) 
USART1 $1C + constant USART1-ISR ( interrupt and status register ) 
USART1 $20 + constant USART1-ICR ( interrupt flag clear register ) 
USART1 $24 + constant USART1-RDR ( receive data register ) 
USART1 $28 + constant USART1-TDR ( transmit data register ) 
USART1 $2C + constant USART1-PRESC ( prescaler register ) 
: USART1-CR1. ." USART1-CR1 (read-write) $" USART1-CR1 @ hex. USART1-CR1 1b. ;
: USART1-CR2. ." USART1-CR2 (read-write) $" USART1-CR2 @ hex. USART1-CR2 1b. ;
: USART1-CR3. ." USART1-CR3 (read-write) $" USART1-CR3 @ hex. USART1-CR3 1b. ;
: USART1-BRR. ." USART1-BRR (read-write) $" USART1-BRR @ hex. USART1-BRR 1b. ;
: USART1-GTPR. ." USART1-GTPR (read-write) $" USART1-GTPR @ hex. USART1-GTPR 1b. ;
: USART1-RTOR. ." USART1-RTOR (read-write) $" USART1-RTOR @ hex. USART1-RTOR 1b. ;
: USART1-RQR. ." USART1-RQR (read-write) $" USART1-RQR @ hex. USART1-RQR 1b. ;
: USART1-ISR. ." USART1-ISR (read-only) $" USART1-ISR @ hex. USART1-ISR 1b. ;
: USART1-ICR. ." USART1-ICR (write-only) $" USART1-ICR @ hex. USART1-ICR 1b. ;
: USART1-RDR. ." USART1-RDR (read-only) $" USART1-RDR @ hex. USART1-RDR 1b. ;
: USART1-TDR. ." USART1-TDR (read-write) $" USART1-TDR @ hex. USART1-TDR 1b. ;
: USART1-PRESC. ." USART1-PRESC (read-write) $" USART1-PRESC @ hex. USART1-PRESC 1b. ;
: USART1.
USART1-CR1.
USART1-CR2.
USART1-CR3.
USART1-BRR.
USART1-GTPR.
USART1-RTOR.
USART1-RQR.
USART1-ISR.
USART1-ICR.
USART1-RDR.
USART1-TDR.
USART1-PRESC.
;

$40010030 constant VREFBUF ( Voltage reference buffer ) 
VREFBUF $0 + constant VREFBUF-CSR ( control and status register ) 
VREFBUF $4 + constant VREFBUF-CCR ( calibration control register ) 
: VREFBUF-CSR. ." VREFBUF-CSR () $" VREFBUF-CSR @ hex. VREFBUF-CSR 1b. ;
: VREFBUF-CCR. ." VREFBUF-CCR (read-write) $" VREFBUF-CCR @ hex. VREFBUF-CCR 1b. ;
: VREFBUF.
VREFBUF-CSR.
VREFBUF-CCR.
;


compiletoram
