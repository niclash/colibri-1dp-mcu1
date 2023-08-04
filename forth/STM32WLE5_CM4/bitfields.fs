\ STM32WLE5_CM4 Register Bitfield Definitions for Mecrisp-Stellaris Forth by Matthias Koch. 
\ bitfield.xsl takes STM32Fxx.svd, config.xml and produces bitfield.fs
\ Written by Terry Porter "terry@tjporter.com.au" 2016 - 2018 and released under the GPL V2.
\ Replace 'bis!' (set bit) with 'bic!' to CLEAR bit, 'bit@' to test bit etc.


\ ADC-ISR (read-write)
: ADC-ISR_ADRDY   %1 0 lshift ADC-ISR bis! ;  \ ADC-ISR_ADRDY    ADRDY
: ADC-ISR_EOSMP   %1 1 lshift ADC-ISR bis! ;  \ ADC-ISR_EOSMP    EOSMP
: ADC-ISR_EOC   %1 2 lshift ADC-ISR bis! ;  \ ADC-ISR_EOC    EOC
: ADC-ISR_EOS   %1 3 lshift ADC-ISR bis! ;  \ ADC-ISR_EOS    EOS
: ADC-ISR_OVR   %1 4 lshift ADC-ISR bis! ;  \ ADC-ISR_OVR    OVR
: ADC-ISR_AWD1   %1 7 lshift ADC-ISR bis! ;  \ ADC-ISR_AWD1    AWD1
: ADC-ISR_AWD2   %1 8 lshift ADC-ISR bis! ;  \ ADC-ISR_AWD2    AWD2
: ADC-ISR_AWD3   %1 9 lshift ADC-ISR bis! ;  \ ADC-ISR_AWD3    AWD3
: ADC-ISR_EOCAL   %1 11 lshift ADC-ISR bis! ;  \ ADC-ISR_EOCAL    EOCAL
: ADC-ISR_CCRDY   %1 13 lshift ADC-ISR bis! ;  \ ADC-ISR_CCRDY    CCRDY

\ ADC-IER (read-write)
: ADC-IER_ADRDYIE   %1 0 lshift ADC-IER bis! ;  \ ADC-IER_ADRDYIE    ADRDYIE
: ADC-IER_EOSMPIE   %1 1 lshift ADC-IER bis! ;  \ ADC-IER_EOSMPIE    EOSMPIE
: ADC-IER_EOCIE   %1 2 lshift ADC-IER bis! ;  \ ADC-IER_EOCIE    EOCIE
: ADC-IER_EOSIE   %1 3 lshift ADC-IER bis! ;  \ ADC-IER_EOSIE    EOSIE
: ADC-IER_OVRIE   %1 4 lshift ADC-IER bis! ;  \ ADC-IER_OVRIE    OVRIE
: ADC-IER_AWD1IE   %1 7 lshift ADC-IER bis! ;  \ ADC-IER_AWD1IE    AWD1IE
: ADC-IER_AWD2IE   %1 8 lshift ADC-IER bis! ;  \ ADC-IER_AWD2IE    AWD2IE
: ADC-IER_AWD3IE   %1 9 lshift ADC-IER bis! ;  \ ADC-IER_AWD3IE    AWD3IE
: ADC-IER_EOCALIE   %1 11 lshift ADC-IER bis! ;  \ ADC-IER_EOCALIE    EOCALIE
: ADC-IER_CCRDYIE   %1 13 lshift ADC-IER bis! ;  \ ADC-IER_CCRDYIE    CCRDYIE

\ ADC-CR (read-write)
: ADC-CR_ADEN   %1 0 lshift ADC-CR bis! ;  \ ADC-CR_ADEN    ADEN
: ADC-CR_ADDIS   %1 1 lshift ADC-CR bis! ;  \ ADC-CR_ADDIS    ADDIS
: ADC-CR_ADSTART   %1 2 lshift ADC-CR bis! ;  \ ADC-CR_ADSTART    ADSTART
: ADC-CR_ADSTP   %1 4 lshift ADC-CR bis! ;  \ ADC-CR_ADSTP    ADSTP
: ADC-CR_ADVREGEN   %1 28 lshift ADC-CR bis! ;  \ ADC-CR_ADVREGEN    ADVREGEN
: ADC-CR_ADCAL   %1 31 lshift ADC-CR bis! ;  \ ADC-CR_ADCAL    ADCAL

\ ADC-CFGR1 (read-write)
: ADC-CFGR1_DMAEN   %1 0 lshift ADC-CFGR1 bis! ;  \ ADC-CFGR1_DMAEN    DMAEN
: ADC-CFGR1_DMACFG   %1 1 lshift ADC-CFGR1 bis! ;  \ ADC-CFGR1_DMACFG    DMACFG
: ADC-CFGR1_SCANDIR   %1 2 lshift ADC-CFGR1 bis! ;  \ ADC-CFGR1_SCANDIR    SCANDIR
: ADC-CFGR1_RES   ( %XX -- ) 3 lshift ADC-CFGR1 bis! ;  \ ADC-CFGR1_RES    RES
: ADC-CFGR1_ALIGN   %1 5 lshift ADC-CFGR1 bis! ;  \ ADC-CFGR1_ALIGN    ALIGN
: ADC-CFGR1_EXTSEL   ( %XXX -- ) 6 lshift ADC-CFGR1 bis! ;  \ ADC-CFGR1_EXTSEL    EXTSEL
: ADC-CFGR1_EXTEN   ( %XX -- ) 10 lshift ADC-CFGR1 bis! ;  \ ADC-CFGR1_EXTEN    EXTEN
: ADC-CFGR1_OVRMOD   %1 12 lshift ADC-CFGR1 bis! ;  \ ADC-CFGR1_OVRMOD    OVRMOD
: ADC-CFGR1_CONT   %1 13 lshift ADC-CFGR1 bis! ;  \ ADC-CFGR1_CONT    CONT
: ADC-CFGR1_WAIT   %1 14 lshift ADC-CFGR1 bis! ;  \ ADC-CFGR1_WAIT    WAIT
: ADC-CFGR1_AUTOFF   %1 15 lshift ADC-CFGR1 bis! ;  \ ADC-CFGR1_AUTOFF    AUTOFF
: ADC-CFGR1_DISCEN   %1 16 lshift ADC-CFGR1 bis! ;  \ ADC-CFGR1_DISCEN    DISCEN
: ADC-CFGR1_CHSELRMOD   %1 21 lshift ADC-CFGR1 bis! ;  \ ADC-CFGR1_CHSELRMOD    CHSELRMOD
: ADC-CFGR1_AWD1SGL   %1 22 lshift ADC-CFGR1 bis! ;  \ ADC-CFGR1_AWD1SGL    AWD1SGL
: ADC-CFGR1_AWD1EN   %1 23 lshift ADC-CFGR1 bis! ;  \ ADC-CFGR1_AWD1EN    AWD1EN
: ADC-CFGR1_AWD1CH   ( %XXXXX -- ) 26 lshift ADC-CFGR1 bis! ;  \ ADC-CFGR1_AWD1CH    AWD1CH

\ ADC-CFGR2 (read-write)
: ADC-CFGR2_OVSE   %1 0 lshift ADC-CFGR2 bis! ;  \ ADC-CFGR2_OVSE    OVSE
: ADC-CFGR2_OVSR0   %1 2 lshift ADC-CFGR2 bis! ;  \ ADC-CFGR2_OVSR0    OVSR0
: ADC-CFGR2_OVSR1   %1 3 lshift ADC-CFGR2 bis! ;  \ ADC-CFGR2_OVSR1    OVSR1
: ADC-CFGR2_OVSR2   %1 4 lshift ADC-CFGR2 bis! ;  \ ADC-CFGR2_OVSR2    OVSR2
: ADC-CFGR2_OVSS0   %1 5 lshift ADC-CFGR2 bis! ;  \ ADC-CFGR2_OVSS0    OVSS0
: ADC-CFGR2_OVSS1   %1 6 lshift ADC-CFGR2 bis! ;  \ ADC-CFGR2_OVSS1    OVSS1
: ADC-CFGR2_OVSS2   %1 7 lshift ADC-CFGR2 bis! ;  \ ADC-CFGR2_OVSS2    OVSS2
: ADC-CFGR2_OVSS3   %1 8 lshift ADC-CFGR2 bis! ;  \ ADC-CFGR2_OVSS3    OVSS3
: ADC-CFGR2_TOVS   %1 9 lshift ADC-CFGR2 bis! ;  \ ADC-CFGR2_TOVS    TOVS
: ADC-CFGR2_LFTRIG   %1 29 lshift ADC-CFGR2 bis! ;  \ ADC-CFGR2_LFTRIG    LFTRIG
: ADC-CFGR2_CKMODE   ( %XX -- ) 30 lshift ADC-CFGR2 bis! ;  \ ADC-CFGR2_CKMODE    CKMODE

\ ADC-SMPR (read-write)
: ADC-SMPR_SMP1   ( %XXX -- ) 0 lshift ADC-SMPR bis! ;  \ ADC-SMPR_SMP1    SMP1
: ADC-SMPR_SMP2   ( %XXX -- ) 4 lshift ADC-SMPR bis! ;  \ ADC-SMPR_SMP2    SMP2
: ADC-SMPR_SMPSEL  8 lshift ADC-SMPR bis! ;  \ ADC-SMPR_SMPSEL    SMPSEL

\ ADC-AWD1TR (read-write)
: ADC-AWD1TR_LT1   ( %XXXXXXXXXXX -- ) 0 lshift ADC-AWD1TR bis! ;  \ ADC-AWD1TR_LT1    LT1
: ADC-AWD1TR_HT1   ( %XXXXXXXXXXX -- ) 16 lshift ADC-AWD1TR bis! ;  \ ADC-AWD1TR_HT1    HT1

\ ADC-AWD2TR (read-write)
: ADC-AWD2TR_LT2   ( %XXXXXXXXXXX -- ) 0 lshift ADC-AWD2TR bis! ;  \ ADC-AWD2TR_LT2    LT2
: ADC-AWD2TR_HT2   ( %XXXXXXXXXXX -- ) 16 lshift ADC-AWD2TR bis! ;  \ ADC-AWD2TR_HT2    HT2

\ ADC-CHSELR0 (read-write)
: ADC-CHSELR0_CHSEL  0 lshift ADC-CHSELR0 bis! ;  \ ADC-CHSELR0_CHSEL    CHSEL

\ ADC-CHSELR1 (read-write)
: ADC-CHSELR1_SQ1   ( %XXXX -- ) 0 lshift ADC-CHSELR1 bis! ;  \ ADC-CHSELR1_SQ1    SQ1
: ADC-CHSELR1_SQ2   ( %XXXX -- ) 4 lshift ADC-CHSELR1 bis! ;  \ ADC-CHSELR1_SQ2    SQ2
: ADC-CHSELR1_SQ3   ( %XXXX -- ) 8 lshift ADC-CHSELR1 bis! ;  \ ADC-CHSELR1_SQ3    SQ3
: ADC-CHSELR1_SQ4   ( %XXXX -- ) 12 lshift ADC-CHSELR1 bis! ;  \ ADC-CHSELR1_SQ4    SQ4
: ADC-CHSELR1_SQ5   ( %XXXX -- ) 16 lshift ADC-CHSELR1 bis! ;  \ ADC-CHSELR1_SQ5    SQ5
: ADC-CHSELR1_SQ6   ( %XXXX -- ) 20 lshift ADC-CHSELR1 bis! ;  \ ADC-CHSELR1_SQ6    SQ6
: ADC-CHSELR1_SQ7   ( %XXXX -- ) 24 lshift ADC-CHSELR1 bis! ;  \ ADC-CHSELR1_SQ7    SQ7
: ADC-CHSELR1_SQ8   ( %XXXX -- ) 28 lshift ADC-CHSELR1 bis! ;  \ ADC-CHSELR1_SQ8    SQ8

\ ADC-AWD3TR (read-write)
: ADC-AWD3TR_LT3   ( %XXXXXXXXXXX -- ) 0 lshift ADC-AWD3TR bis! ;  \ ADC-AWD3TR_LT3    LT3
: ADC-AWD3TR_HT3   ( %XXXXXXXXXXX -- ) 16 lshift ADC-AWD3TR bis! ;  \ ADC-AWD3TR_HT3    HT3

\ ADC-DR (read-only)
: ADC-DR_DATA   ( %XXXXXXXXXXXXXXXX -- ) 0 lshift ADC-DR bis! ;  \ ADC-DR_DATA    DATA

\ ADC-AWD2CR (read-write)
: ADC-AWD2CR_AWD2CH  0 lshift ADC-AWD2CR bis! ;  \ ADC-AWD2CR_AWD2CH    AWD2CH

\ ADC-AWD3CR (read-write)
: ADC-AWD3CR_AWD3CH  0 lshift ADC-AWD3CR bis! ;  \ ADC-AWD3CR_AWD3CH    AWD3CH

\ ADC-CALFACT (read-write)
: ADC-CALFACT_CALFACT   ( %XXXXXXX -- ) 0 lshift ADC-CALFACT bis! ;  \ ADC-CALFACT_CALFACT    CALFACT

\ ADC-CCR (read-write)
: ADC-CCR_PRESC0   %1 18 lshift ADC-CCR bis! ;  \ ADC-CCR_PRESC0    PRESC0
: ADC-CCR_PRESC1   %1 19 lshift ADC-CCR bis! ;  \ ADC-CCR_PRESC1    PRESC1
: ADC-CCR_PRESC2   %1 20 lshift ADC-CCR bis! ;  \ ADC-CCR_PRESC2    PRESC2
: ADC-CCR_PRESC3   %1 21 lshift ADC-CCR bis! ;  \ ADC-CCR_PRESC3    PRESC3
: ADC-CCR_VREFEN   %1 22 lshift ADC-CCR bis! ;  \ ADC-CCR_VREFEN    VREFEN
: ADC-CCR_TSEN   %1 23 lshift ADC-CCR bis! ;  \ ADC-CCR_TSEN    TSEN
: ADC-CCR_VBATEN   %1 24 lshift ADC-CCR bis! ;  \ ADC-CCR_VBATEN    VBATEN

\ CRC-DR (read-write)
: CRC-DR_DR   ( %XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX -- ) 0 lshift CRC-DR bis! ;  \ CRC-DR_DR    Data register bits

\ CRC-IDR (read-write)
: CRC-IDR_IDR   ( %XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX -- ) 0 lshift CRC-IDR bis! ;  \ CRC-IDR_IDR    General-purpose 32-bit data register bits

\ CRC-CR (read-write)
: CRC-CR_REV_OUT   %1 7 lshift CRC-CR bis! ;  \ CRC-CR_REV_OUT    Reverse output data
: CRC-CR_REV_IN   ( %XX -- ) 5 lshift CRC-CR bis! ;  \ CRC-CR_REV_IN    Reverse input data
: CRC-CR_POLYSIZE   ( %XX -- ) 3 lshift CRC-CR bis! ;  \ CRC-CR_POLYSIZE    Polynomial size
: CRC-CR_RESET   %1 0 lshift CRC-CR bis! ;  \ CRC-CR_RESET    RESET bit

\ CRC-INIT (read-write)
: CRC-INIT_CRC_INIT   ( %XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX -- ) 0 lshift CRC-INIT bis! ;  \ CRC-INIT_CRC_INIT    Programmable initial CRC value

\ CRC-POL (read-write)
: CRC-POL_POL   ( %XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX -- ) 0 lshift CRC-POL bis! ;  \ CRC-POL_POL    Programmable polynomial

\ GPIOA-MODER (read-write)
: GPIOA-MODER_MODER15   ( %XX -- ) 30 lshift GPIOA-MODER bis! ;  \ GPIOA-MODER_MODER15    MODER15
: GPIOA-MODER_MODER14   ( %XX -- ) 28 lshift GPIOA-MODER bis! ;  \ GPIOA-MODER_MODER14    MODER14
: GPIOA-MODER_MODER13   ( %XX -- ) 26 lshift GPIOA-MODER bis! ;  \ GPIOA-MODER_MODER13    MODER13
: GPIOA-MODER_MODER12   ( %XX -- ) 24 lshift GPIOA-MODER bis! ;  \ GPIOA-MODER_MODER12    MODER12
: GPIOA-MODER_MODER11   ( %XX -- ) 22 lshift GPIOA-MODER bis! ;  \ GPIOA-MODER_MODER11    MODER11
: GPIOA-MODER_MODER10   ( %XX -- ) 20 lshift GPIOA-MODER bis! ;  \ GPIOA-MODER_MODER10    MODER10
: GPIOA-MODER_MODER9   ( %XX -- ) 18 lshift GPIOA-MODER bis! ;  \ GPIOA-MODER_MODER9    MODER9
: GPIOA-MODER_MODER8   ( %XX -- ) 16 lshift GPIOA-MODER bis! ;  \ GPIOA-MODER_MODER8    MODER8
: GPIOA-MODER_MODER7   ( %XX -- ) 14 lshift GPIOA-MODER bis! ;  \ GPIOA-MODER_MODER7    MODER7
: GPIOA-MODER_MODER6   ( %XX -- ) 12 lshift GPIOA-MODER bis! ;  \ GPIOA-MODER_MODER6    MODER6
: GPIOA-MODER_MODER5   ( %XX -- ) 10 lshift GPIOA-MODER bis! ;  \ GPIOA-MODER_MODER5    MODER5
: GPIOA-MODER_MODER4   ( %XX -- ) 8 lshift GPIOA-MODER bis! ;  \ GPIOA-MODER_MODER4    MODER4
: GPIOA-MODER_MODER3   ( %XX -- ) 6 lshift GPIOA-MODER bis! ;  \ GPIOA-MODER_MODER3    MODER3
: GPIOA-MODER_MODER2   ( %XX -- ) 4 lshift GPIOA-MODER bis! ;  \ GPIOA-MODER_MODER2    MODER2
: GPIOA-MODER_MODER1   ( %XX -- ) 2 lshift GPIOA-MODER bis! ;  \ GPIOA-MODER_MODER1    MODER1
: GPIOA-MODER_MODER0   ( %XX -- ) 0 lshift GPIOA-MODER bis! ;  \ GPIOA-MODER_MODER0    MODER0

\ GPIOA-OTYPER (read-write)
: GPIOA-OTYPER_OT15   %1 15 lshift GPIOA-OTYPER bis! ;  \ GPIOA-OTYPER_OT15    Port x configuration bits y = 0..15
: GPIOA-OTYPER_OT14   %1 14 lshift GPIOA-OTYPER bis! ;  \ GPIOA-OTYPER_OT14    Port x configuration bits y = 0..15
: GPIOA-OTYPER_OT13   %1 13 lshift GPIOA-OTYPER bis! ;  \ GPIOA-OTYPER_OT13    Port x configuration bits y = 0..15
: GPIOA-OTYPER_OT12   %1 12 lshift GPIOA-OTYPER bis! ;  \ GPIOA-OTYPER_OT12    Port x configuration bits y = 0..15
: GPIOA-OTYPER_OT11   %1 11 lshift GPIOA-OTYPER bis! ;  \ GPIOA-OTYPER_OT11    Port x configuration bits y = 0..15
: GPIOA-OTYPER_OT10   %1 10 lshift GPIOA-OTYPER bis! ;  \ GPIOA-OTYPER_OT10    Port x configuration bits y = 0..15
: GPIOA-OTYPER_OT9   %1 9 lshift GPIOA-OTYPER bis! ;  \ GPIOA-OTYPER_OT9    Port x configuration bits y = 0..15
: GPIOA-OTYPER_OT8   %1 8 lshift GPIOA-OTYPER bis! ;  \ GPIOA-OTYPER_OT8    Port x configuration bits y = 0..15
: GPIOA-OTYPER_OT7   %1 7 lshift GPIOA-OTYPER bis! ;  \ GPIOA-OTYPER_OT7    Port x configuration bits y = 0..15
: GPIOA-OTYPER_OT6   %1 6 lshift GPIOA-OTYPER bis! ;  \ GPIOA-OTYPER_OT6    Port x configuration bits y = 0..15
: GPIOA-OTYPER_OT5   %1 5 lshift GPIOA-OTYPER bis! ;  \ GPIOA-OTYPER_OT5    Port x configuration bits y = 0..15
: GPIOA-OTYPER_OT4   %1 4 lshift GPIOA-OTYPER bis! ;  \ GPIOA-OTYPER_OT4    Port x configuration bits y = 0..15
: GPIOA-OTYPER_OT3   %1 3 lshift GPIOA-OTYPER bis! ;  \ GPIOA-OTYPER_OT3    Port x configuration bits y = 0..15
: GPIOA-OTYPER_OT2   %1 2 lshift GPIOA-OTYPER bis! ;  \ GPIOA-OTYPER_OT2    Port x configuration bits y = 0..15
: GPIOA-OTYPER_OT1   %1 1 lshift GPIOA-OTYPER bis! ;  \ GPIOA-OTYPER_OT1    Port x configuration bits y = 0..15
: GPIOA-OTYPER_OT0   %1 0 lshift GPIOA-OTYPER bis! ;  \ GPIOA-OTYPER_OT0    Port x configuration bits y = 0..15

\ GPIOA-OSPEEDR (read-write)
: GPIOA-OSPEEDR_OSPEEDR15   ( %XX -- ) 30 lshift GPIOA-OSPEEDR bis! ;  \ GPIOA-OSPEEDR_OSPEEDR15    Port x configuration bits y = 0..15
: GPIOA-OSPEEDR_OSPEEDR14   ( %XX -- ) 28 lshift GPIOA-OSPEEDR bis! ;  \ GPIOA-OSPEEDR_OSPEEDR14    Port x configuration bits y = 0..15
: GPIOA-OSPEEDR_OSPEEDR13   ( %XX -- ) 26 lshift GPIOA-OSPEEDR bis! ;  \ GPIOA-OSPEEDR_OSPEEDR13    Port x configuration bits y = 0..15
: GPIOA-OSPEEDR_OSPEEDR12   ( %XX -- ) 24 lshift GPIOA-OSPEEDR bis! ;  \ GPIOA-OSPEEDR_OSPEEDR12    Port x configuration bits y = 0..15
: GPIOA-OSPEEDR_OSPEEDR11   ( %XX -- ) 22 lshift GPIOA-OSPEEDR bis! ;  \ GPIOA-OSPEEDR_OSPEEDR11    Port x configuration bits y = 0..15
: GPIOA-OSPEEDR_OSPEEDR10   ( %XX -- ) 20 lshift GPIOA-OSPEEDR bis! ;  \ GPIOA-OSPEEDR_OSPEEDR10    Port x configuration bits y = 0..15
: GPIOA-OSPEEDR_OSPEEDR9   ( %XX -- ) 18 lshift GPIOA-OSPEEDR bis! ;  \ GPIOA-OSPEEDR_OSPEEDR9    Port x configuration bits y = 0..15
: GPIOA-OSPEEDR_OSPEEDR8   ( %XX -- ) 16 lshift GPIOA-OSPEEDR bis! ;  \ GPIOA-OSPEEDR_OSPEEDR8    Port x configuration bits y = 0..15
: GPIOA-OSPEEDR_OSPEEDR7   ( %XX -- ) 14 lshift GPIOA-OSPEEDR bis! ;  \ GPIOA-OSPEEDR_OSPEEDR7    Port x configuration bits y = 0..15
: GPIOA-OSPEEDR_OSPEEDR6   ( %XX -- ) 12 lshift GPIOA-OSPEEDR bis! ;  \ GPIOA-OSPEEDR_OSPEEDR6    Port x configuration bits y = 0..15
: GPIOA-OSPEEDR_OSPEEDR5   ( %XX -- ) 10 lshift GPIOA-OSPEEDR bis! ;  \ GPIOA-OSPEEDR_OSPEEDR5    Port x configuration bits y = 0..15
: GPIOA-OSPEEDR_OSPEEDR4   ( %XX -- ) 8 lshift GPIOA-OSPEEDR bis! ;  \ GPIOA-OSPEEDR_OSPEEDR4    Port x configuration bits y = 0..15
: GPIOA-OSPEEDR_OSPEEDR3   ( %XX -- ) 6 lshift GPIOA-OSPEEDR bis! ;  \ GPIOA-OSPEEDR_OSPEEDR3    Port x configuration bits y = 0..15
: GPIOA-OSPEEDR_OSPEEDR2   ( %XX -- ) 4 lshift GPIOA-OSPEEDR bis! ;  \ GPIOA-OSPEEDR_OSPEEDR2    Port x configuration bits y = 0..15
: GPIOA-OSPEEDR_OSPEEDR1   ( %XX -- ) 2 lshift GPIOA-OSPEEDR bis! ;  \ GPIOA-OSPEEDR_OSPEEDR1    Port x configuration bits y = 0..15
: GPIOA-OSPEEDR_OSPEEDR0   ( %XX -- ) 0 lshift GPIOA-OSPEEDR bis! ;  \ GPIOA-OSPEEDR_OSPEEDR0    Port x configuration bits y = 0..15

\ GPIOA-PUPDR (read-write)
: GPIOA-PUPDR_PUPDR15   ( %XX -- ) 30 lshift GPIOA-PUPDR bis! ;  \ GPIOA-PUPDR_PUPDR15    Port x configuration bits y = 0..15
: GPIOA-PUPDR_PUPDR14   ( %XX -- ) 28 lshift GPIOA-PUPDR bis! ;  \ GPIOA-PUPDR_PUPDR14    Port x configuration bits y = 0..15
: GPIOA-PUPDR_PUPDR13   ( %XX -- ) 26 lshift GPIOA-PUPDR bis! ;  \ GPIOA-PUPDR_PUPDR13    Port x configuration bits y = 0..15
: GPIOA-PUPDR_PUPDR12   ( %XX -- ) 24 lshift GPIOA-PUPDR bis! ;  \ GPIOA-PUPDR_PUPDR12    Port x configuration bits y = 0..15
: GPIOA-PUPDR_PUPDR11   ( %XX -- ) 22 lshift GPIOA-PUPDR bis! ;  \ GPIOA-PUPDR_PUPDR11    Port x configuration bits y = 0..15
: GPIOA-PUPDR_PUPDR10   ( %XX -- ) 20 lshift GPIOA-PUPDR bis! ;  \ GPIOA-PUPDR_PUPDR10    Port x configuration bits y = 0..15
: GPIOA-PUPDR_PUPDR9   ( %XX -- ) 18 lshift GPIOA-PUPDR bis! ;  \ GPIOA-PUPDR_PUPDR9    Port x configuration bits y = 0..15
: GPIOA-PUPDR_PUPDR8   ( %XX -- ) 16 lshift GPIOA-PUPDR bis! ;  \ GPIOA-PUPDR_PUPDR8    Port x configuration bits y = 0..15
: GPIOA-PUPDR_PUPDR7   ( %XX -- ) 14 lshift GPIOA-PUPDR bis! ;  \ GPIOA-PUPDR_PUPDR7    Port x configuration bits y = 0..15
: GPIOA-PUPDR_PUPDR6   ( %XX -- ) 12 lshift GPIOA-PUPDR bis! ;  \ GPIOA-PUPDR_PUPDR6    Port x configuration bits y = 0..15
: GPIOA-PUPDR_PUPDR5   ( %XX -- ) 10 lshift GPIOA-PUPDR bis! ;  \ GPIOA-PUPDR_PUPDR5    Port x configuration bits y = 0..15
: GPIOA-PUPDR_PUPDR4   ( %XX -- ) 8 lshift GPIOA-PUPDR bis! ;  \ GPIOA-PUPDR_PUPDR4    Port x configuration bits y = 0..15
: GPIOA-PUPDR_PUPDR3   ( %XX -- ) 6 lshift GPIOA-PUPDR bis! ;  \ GPIOA-PUPDR_PUPDR3    Port x configuration bits y = 0..15
: GPIOA-PUPDR_PUPDR2   ( %XX -- ) 4 lshift GPIOA-PUPDR bis! ;  \ GPIOA-PUPDR_PUPDR2    Port x configuration bits y = 0..15
: GPIOA-PUPDR_PUPDR1   ( %XX -- ) 2 lshift GPIOA-PUPDR bis! ;  \ GPIOA-PUPDR_PUPDR1    Port x configuration bits y = 0..15
: GPIOA-PUPDR_PUPDR0   ( %XX -- ) 0 lshift GPIOA-PUPDR bis! ;  \ GPIOA-PUPDR_PUPDR0    Port x configuration bits y = 0..15

\ GPIOA-IDR (read-only)
: GPIOA-IDR_IDR15   %1 15 lshift GPIOA-IDR bis! ;  \ GPIOA-IDR_IDR15    Port input data y = 0..15
: GPIOA-IDR_IDR14   %1 14 lshift GPIOA-IDR bis! ;  \ GPIOA-IDR_IDR14    Port input data y = 0..15
: GPIOA-IDR_IDR13   %1 13 lshift GPIOA-IDR bis! ;  \ GPIOA-IDR_IDR13    Port input data y = 0..15
: GPIOA-IDR_IDR12   %1 12 lshift GPIOA-IDR bis! ;  \ GPIOA-IDR_IDR12    Port input data y = 0..15
: GPIOA-IDR_IDR11   %1 11 lshift GPIOA-IDR bis! ;  \ GPIOA-IDR_IDR11    Port input data y = 0..15
: GPIOA-IDR_IDR10   %1 10 lshift GPIOA-IDR bis! ;  \ GPIOA-IDR_IDR10    Port input data y = 0..15
: GPIOA-IDR_IDR9   %1 9 lshift GPIOA-IDR bis! ;  \ GPIOA-IDR_IDR9    Port input data y = 0..15
: GPIOA-IDR_IDR8   %1 8 lshift GPIOA-IDR bis! ;  \ GPIOA-IDR_IDR8    Port input data y = 0..15
: GPIOA-IDR_IDR7   %1 7 lshift GPIOA-IDR bis! ;  \ GPIOA-IDR_IDR7    Port input data y = 0..15
: GPIOA-IDR_IDR6   %1 6 lshift GPIOA-IDR bis! ;  \ GPIOA-IDR_IDR6    Port input data y = 0..15
: GPIOA-IDR_IDR5   %1 5 lshift GPIOA-IDR bis! ;  \ GPIOA-IDR_IDR5    Port input data y = 0..15
: GPIOA-IDR_IDR4   %1 4 lshift GPIOA-IDR bis! ;  \ GPIOA-IDR_IDR4    Port input data y = 0..15
: GPIOA-IDR_IDR3   %1 3 lshift GPIOA-IDR bis! ;  \ GPIOA-IDR_IDR3    Port input data y = 0..15
: GPIOA-IDR_IDR2   %1 2 lshift GPIOA-IDR bis! ;  \ GPIOA-IDR_IDR2    Port input data y = 0..15
: GPIOA-IDR_IDR1   %1 1 lshift GPIOA-IDR bis! ;  \ GPIOA-IDR_IDR1    Port input data y = 0..15
: GPIOA-IDR_IDR0   %1 0 lshift GPIOA-IDR bis! ;  \ GPIOA-IDR_IDR0    Port input data y = 0..15

\ GPIOA-ODR (read-write)
: GPIOA-ODR_ODR15   %1 15 lshift GPIOA-ODR bis! ;  \ GPIOA-ODR_ODR15    Port output data y = 0..15
: GPIOA-ODR_ODR14   %1 14 lshift GPIOA-ODR bis! ;  \ GPIOA-ODR_ODR14    Port output data y = 0..15
: GPIOA-ODR_ODR13   %1 13 lshift GPIOA-ODR bis! ;  \ GPIOA-ODR_ODR13    Port output data y = 0..15
: GPIOA-ODR_ODR12   %1 12 lshift GPIOA-ODR bis! ;  \ GPIOA-ODR_ODR12    Port output data y = 0..15
: GPIOA-ODR_ODR11   %1 11 lshift GPIOA-ODR bis! ;  \ GPIOA-ODR_ODR11    Port output data y = 0..15
: GPIOA-ODR_ODR10   %1 10 lshift GPIOA-ODR bis! ;  \ GPIOA-ODR_ODR10    Port output data y = 0..15
: GPIOA-ODR_ODR9   %1 9 lshift GPIOA-ODR bis! ;  \ GPIOA-ODR_ODR9    Port output data y = 0..15
: GPIOA-ODR_ODR8   %1 8 lshift GPIOA-ODR bis! ;  \ GPIOA-ODR_ODR8    Port output data y = 0..15
: GPIOA-ODR_ODR7   %1 7 lshift GPIOA-ODR bis! ;  \ GPIOA-ODR_ODR7    Port output data y = 0..15
: GPIOA-ODR_ODR6   %1 6 lshift GPIOA-ODR bis! ;  \ GPIOA-ODR_ODR6    Port output data y = 0..15
: GPIOA-ODR_ODR5   %1 5 lshift GPIOA-ODR bis! ;  \ GPIOA-ODR_ODR5    Port output data y = 0..15
: GPIOA-ODR_ODR4   %1 4 lshift GPIOA-ODR bis! ;  \ GPIOA-ODR_ODR4    Port output data y = 0..15
: GPIOA-ODR_ODR3   %1 3 lshift GPIOA-ODR bis! ;  \ GPIOA-ODR_ODR3    Port output data y = 0..15
: GPIOA-ODR_ODR2   %1 2 lshift GPIOA-ODR bis! ;  \ GPIOA-ODR_ODR2    Port output data y = 0..15
: GPIOA-ODR_ODR1   %1 1 lshift GPIOA-ODR bis! ;  \ GPIOA-ODR_ODR1    Port output data y = 0..15
: GPIOA-ODR_ODR0   %1 0 lshift GPIOA-ODR bis! ;  \ GPIOA-ODR_ODR0    Port output data y = 0..15

\ GPIOA-BSRR (write-only)
: GPIOA-BSRR_BR15   %1 31 lshift GPIOA-BSRR bis! ;  \ GPIOA-BSRR_BR15    Port x reset bit y y = 0..15
: GPIOA-BSRR_BR14   %1 30 lshift GPIOA-BSRR bis! ;  \ GPIOA-BSRR_BR14    Port x reset bit y y = 0..15
: GPIOA-BSRR_BR13   %1 29 lshift GPIOA-BSRR bis! ;  \ GPIOA-BSRR_BR13    Port x reset bit y y = 0..15
: GPIOA-BSRR_BR12   %1 28 lshift GPIOA-BSRR bis! ;  \ GPIOA-BSRR_BR12    Port x reset bit y y = 0..15
: GPIOA-BSRR_BR11   %1 27 lshift GPIOA-BSRR bis! ;  \ GPIOA-BSRR_BR11    Port x reset bit y y = 0..15
: GPIOA-BSRR_BR10   %1 26 lshift GPIOA-BSRR bis! ;  \ GPIOA-BSRR_BR10    Port x reset bit y y = 0..15
: GPIOA-BSRR_BR9   %1 25 lshift GPIOA-BSRR bis! ;  \ GPIOA-BSRR_BR9    Port x reset bit y y = 0..15
: GPIOA-BSRR_BR8   %1 24 lshift GPIOA-BSRR bis! ;  \ GPIOA-BSRR_BR8    Port x reset bit y y = 0..15
: GPIOA-BSRR_BR7   %1 23 lshift GPIOA-BSRR bis! ;  \ GPIOA-BSRR_BR7    Port x reset bit y y = 0..15
: GPIOA-BSRR_BR6   %1 22 lshift GPIOA-BSRR bis! ;  \ GPIOA-BSRR_BR6    Port x reset bit y y = 0..15
: GPIOA-BSRR_BR5   %1 21 lshift GPIOA-BSRR bis! ;  \ GPIOA-BSRR_BR5    Port x reset bit y y = 0..15
: GPIOA-BSRR_BR4   %1 20 lshift GPIOA-BSRR bis! ;  \ GPIOA-BSRR_BR4    Port x reset bit y y = 0..15
: GPIOA-BSRR_BR3   %1 19 lshift GPIOA-BSRR bis! ;  \ GPIOA-BSRR_BR3    Port x reset bit y y = 0..15
: GPIOA-BSRR_BR2   %1 18 lshift GPIOA-BSRR bis! ;  \ GPIOA-BSRR_BR2    Port x reset bit y y = 0..15
: GPIOA-BSRR_BR1   %1 17 lshift GPIOA-BSRR bis! ;  \ GPIOA-BSRR_BR1    Port x reset bit y y = 0..15
: GPIOA-BSRR_BR0   %1 16 lshift GPIOA-BSRR bis! ;  \ GPIOA-BSRR_BR0    Port x set bit y y= 0..15
: GPIOA-BSRR_BS15   %1 15 lshift GPIOA-BSRR bis! ;  \ GPIOA-BSRR_BS15    Port x set bit y y= 0..15
: GPIOA-BSRR_BS14   %1 14 lshift GPIOA-BSRR bis! ;  \ GPIOA-BSRR_BS14    Port x set bit y y= 0..15
: GPIOA-BSRR_BS13   %1 13 lshift GPIOA-BSRR bis! ;  \ GPIOA-BSRR_BS13    Port x set bit y y= 0..15
: GPIOA-BSRR_BS12   %1 12 lshift GPIOA-BSRR bis! ;  \ GPIOA-BSRR_BS12    Port x set bit y y= 0..15
: GPIOA-BSRR_BS11   %1 11 lshift GPIOA-BSRR bis! ;  \ GPIOA-BSRR_BS11    Port x set bit y y= 0..15
: GPIOA-BSRR_BS10   %1 10 lshift GPIOA-BSRR bis! ;  \ GPIOA-BSRR_BS10    Port x set bit y y= 0..15
: GPIOA-BSRR_BS9   %1 9 lshift GPIOA-BSRR bis! ;  \ GPIOA-BSRR_BS9    Port x set bit y y= 0..15
: GPIOA-BSRR_BS8   %1 8 lshift GPIOA-BSRR bis! ;  \ GPIOA-BSRR_BS8    Port x set bit y y= 0..15
: GPIOA-BSRR_BS7   %1 7 lshift GPIOA-BSRR bis! ;  \ GPIOA-BSRR_BS7    Port x set bit y y= 0..15
: GPIOA-BSRR_BS6   %1 6 lshift GPIOA-BSRR bis! ;  \ GPIOA-BSRR_BS6    Port x set bit y y= 0..15
: GPIOA-BSRR_BS5   %1 5 lshift GPIOA-BSRR bis! ;  \ GPIOA-BSRR_BS5    Port x set bit y y= 0..15
: GPIOA-BSRR_BS4   %1 4 lshift GPIOA-BSRR bis! ;  \ GPIOA-BSRR_BS4    Port x set bit y y= 0..15
: GPIOA-BSRR_BS3   %1 3 lshift GPIOA-BSRR bis! ;  \ GPIOA-BSRR_BS3    Port x set bit y y= 0..15
: GPIOA-BSRR_BS2   %1 2 lshift GPIOA-BSRR bis! ;  \ GPIOA-BSRR_BS2    Port x set bit y y= 0..15
: GPIOA-BSRR_BS1   %1 1 lshift GPIOA-BSRR bis! ;  \ GPIOA-BSRR_BS1    Port x set bit y y= 0..15
: GPIOA-BSRR_BS0   %1 0 lshift GPIOA-BSRR bis! ;  \ GPIOA-BSRR_BS0    Port x set bit y y= 0..15

\ GPIOA-LCKR (read-write)
: GPIOA-LCKR_LCKK   %1 16 lshift GPIOA-LCKR bis! ;  \ GPIOA-LCKR_LCKK    Port x lock bit y y= 0..15
: GPIOA-LCKR_LCK15   %1 15 lshift GPIOA-LCKR bis! ;  \ GPIOA-LCKR_LCK15    Port x lock bit y y= 0..15
: GPIOA-LCKR_LCK14   %1 14 lshift GPIOA-LCKR bis! ;  \ GPIOA-LCKR_LCK14    Port x lock bit y y= 0..15
: GPIOA-LCKR_LCK13   %1 13 lshift GPIOA-LCKR bis! ;  \ GPIOA-LCKR_LCK13    Port x lock bit y y= 0..15
: GPIOA-LCKR_LCK12   %1 12 lshift GPIOA-LCKR bis! ;  \ GPIOA-LCKR_LCK12    Port x lock bit y y= 0..15
: GPIOA-LCKR_LCK11   %1 11 lshift GPIOA-LCKR bis! ;  \ GPIOA-LCKR_LCK11    Port x lock bit y y= 0..15
: GPIOA-LCKR_LCK10   %1 10 lshift GPIOA-LCKR bis! ;  \ GPIOA-LCKR_LCK10    Port x lock bit y y= 0..15
: GPIOA-LCKR_LCK9   %1 9 lshift GPIOA-LCKR bis! ;  \ GPIOA-LCKR_LCK9    Port x lock bit y y= 0..15
: GPIOA-LCKR_LCK8   %1 8 lshift GPIOA-LCKR bis! ;  \ GPIOA-LCKR_LCK8    Port x lock bit y y= 0..15
: GPIOA-LCKR_LCK7   %1 7 lshift GPIOA-LCKR bis! ;  \ GPIOA-LCKR_LCK7    Port x lock bit y y= 0..15
: GPIOA-LCKR_LCK6   %1 6 lshift GPIOA-LCKR bis! ;  \ GPIOA-LCKR_LCK6    Port x lock bit y y= 0..15
: GPIOA-LCKR_LCK5   %1 5 lshift GPIOA-LCKR bis! ;  \ GPIOA-LCKR_LCK5    Port x lock bit y y= 0..15
: GPIOA-LCKR_LCK4   %1 4 lshift GPIOA-LCKR bis! ;  \ GPIOA-LCKR_LCK4    Port x lock bit y y= 0..15
: GPIOA-LCKR_LCK3   %1 3 lshift GPIOA-LCKR bis! ;  \ GPIOA-LCKR_LCK3    Port x lock bit y y= 0..15
: GPIOA-LCKR_LCK2   %1 2 lshift GPIOA-LCKR bis! ;  \ GPIOA-LCKR_LCK2    Port x lock bit y y= 0..15
: GPIOA-LCKR_LCK1   %1 1 lshift GPIOA-LCKR bis! ;  \ GPIOA-LCKR_LCK1    Port x lock bit y y= 0..15
: GPIOA-LCKR_LCK0   %1 0 lshift GPIOA-LCKR bis! ;  \ GPIOA-LCKR_LCK0    Port x lock bit y y= 0..15

\ GPIOA-AFRL (read-write)
: GPIOA-AFRL_AFRL7   ( %XXXX -- ) 28 lshift GPIOA-AFRL bis! ;  \ GPIOA-AFRL_AFRL7    Alternate function selection for port x bit y y = 0..7
: GPIOA-AFRL_AFRL6   ( %XXXX -- ) 24 lshift GPIOA-AFRL bis! ;  \ GPIOA-AFRL_AFRL6    Alternate function selection for port x bit y y = 0..7
: GPIOA-AFRL_AFRL5   ( %XXXX -- ) 20 lshift GPIOA-AFRL bis! ;  \ GPIOA-AFRL_AFRL5    Alternate function selection for port x bit y y = 0..7
: GPIOA-AFRL_AFRL4   ( %XXXX -- ) 16 lshift GPIOA-AFRL bis! ;  \ GPIOA-AFRL_AFRL4    Alternate function selection for port x bit y y = 0..7
: GPIOA-AFRL_AFRL3   ( %XXXX -- ) 12 lshift GPIOA-AFRL bis! ;  \ GPIOA-AFRL_AFRL3    Alternate function selection for port x bit y y = 0..7
: GPIOA-AFRL_AFRL2   ( %XXXX -- ) 8 lshift GPIOA-AFRL bis! ;  \ GPIOA-AFRL_AFRL2    Alternate function selection for port x bit y y = 0..7
: GPIOA-AFRL_AFRL1   ( %XXXX -- ) 4 lshift GPIOA-AFRL bis! ;  \ GPIOA-AFRL_AFRL1    Alternate function selection for port x bit y y = 0..7
: GPIOA-AFRL_AFRL0   ( %XXXX -- ) 0 lshift GPIOA-AFRL bis! ;  \ GPIOA-AFRL_AFRL0    Alternate function selection for port x bit y y = 0..7

\ GPIOA-AFRH (read-write)
: GPIOA-AFRH_AFRH15   ( %XXXX -- ) 28 lshift GPIOA-AFRH bis! ;  \ GPIOA-AFRH_AFRH15    Alternate function selection for port x bit y y = 8..15
: GPIOA-AFRH_AFRH14   ( %XXXX -- ) 24 lshift GPIOA-AFRH bis! ;  \ GPIOA-AFRH_AFRH14    Alternate function selection for port x bit y y = 8..15
: GPIOA-AFRH_AFRH13   ( %XXXX -- ) 20 lshift GPIOA-AFRH bis! ;  \ GPIOA-AFRH_AFRH13    Alternate function selection for port x bit y y = 8..15
: GPIOA-AFRH_AFRH12   ( %XXXX -- ) 16 lshift GPIOA-AFRH bis! ;  \ GPIOA-AFRH_AFRH12    Alternate function selection for port x bit y y = 8..15
: GPIOA-AFRH_AFRH11   ( %XXXX -- ) 12 lshift GPIOA-AFRH bis! ;  \ GPIOA-AFRH_AFRH11    Alternate function selection for port x bit y y = 8..15
: GPIOA-AFRH_AFRH10   ( %XXXX -- ) 8 lshift GPIOA-AFRH bis! ;  \ GPIOA-AFRH_AFRH10    Alternate function selection for port x bit y y = 8..15
: GPIOA-AFRH_AFRH9   ( %XXXX -- ) 4 lshift GPIOA-AFRH bis! ;  \ GPIOA-AFRH_AFRH9    Alternate function selection for port x bit y y = 8..15
: GPIOA-AFRH_AFRH8   ( %XXXX -- ) 0 lshift GPIOA-AFRH bis! ;  \ GPIOA-AFRH_AFRH8    Alternate function selection for port x bit y y = 8..15

\ GPIOA-BRR (read-write)
: GPIOA-BRR_BR0   %1 0 lshift GPIOA-BRR bis! ;  \ GPIOA-BRR_BR0    Port Reset bit
: GPIOA-BRR_BR1   %1 1 lshift GPIOA-BRR bis! ;  \ GPIOA-BRR_BR1    Port Reset bit
: GPIOA-BRR_BR2   %1 2 lshift GPIOA-BRR bis! ;  \ GPIOA-BRR_BR2    Port Reset bit
: GPIOA-BRR_BR3   %1 3 lshift GPIOA-BRR bis! ;  \ GPIOA-BRR_BR3    Port Reset bit
: GPIOA-BRR_BR4   %1 4 lshift GPIOA-BRR bis! ;  \ GPIOA-BRR_BR4    Port Reset bit
: GPIOA-BRR_BR5   %1 5 lshift GPIOA-BRR bis! ;  \ GPIOA-BRR_BR5    Port Reset bit
: GPIOA-BRR_BR6   %1 6 lshift GPIOA-BRR bis! ;  \ GPIOA-BRR_BR6    Port Reset bit
: GPIOA-BRR_BR7   %1 7 lshift GPIOA-BRR bis! ;  \ GPIOA-BRR_BR7    Port Reset bit
: GPIOA-BRR_BR8   %1 8 lshift GPIOA-BRR bis! ;  \ GPIOA-BRR_BR8    Port Reset bit
: GPIOA-BRR_BR9   %1 9 lshift GPIOA-BRR bis! ;  \ GPIOA-BRR_BR9    Port Reset bit
: GPIOA-BRR_BR10   %1 10 lshift GPIOA-BRR bis! ;  \ GPIOA-BRR_BR10    Port Reset bit
: GPIOA-BRR_BR11   %1 11 lshift GPIOA-BRR bis! ;  \ GPIOA-BRR_BR11    Port Reset bit
: GPIOA-BRR_BR12   %1 12 lshift GPIOA-BRR bis! ;  \ GPIOA-BRR_BR12    Port Reset bit
: GPIOA-BRR_BR13   %1 13 lshift GPIOA-BRR bis! ;  \ GPIOA-BRR_BR13    Port Reset bit
: GPIOA-BRR_BR14   %1 14 lshift GPIOA-BRR bis! ;  \ GPIOA-BRR_BR14    Port Reset bit
: GPIOA-BRR_BR15   %1 15 lshift GPIOA-BRR bis! ;  \ GPIOA-BRR_BR15    Port Reset bit

\ GPIOB-MODER (read-write)
: GPIOB-MODER_MODER15   ( %XX -- ) 30 lshift GPIOB-MODER bis! ;  \ GPIOB-MODER_MODER15    Port x configuration bits y = 0..15
: GPIOB-MODER_MODER14   ( %XX -- ) 28 lshift GPIOB-MODER bis! ;  \ GPIOB-MODER_MODER14    Port x configuration bits y = 0..15
: GPIOB-MODER_MODER13   ( %XX -- ) 26 lshift GPIOB-MODER bis! ;  \ GPIOB-MODER_MODER13    Port x configuration bits y = 0..15
: GPIOB-MODER_MODER12   ( %XX -- ) 24 lshift GPIOB-MODER bis! ;  \ GPIOB-MODER_MODER12    Port x configuration bits y = 0..15
: GPIOB-MODER_MODER11   ( %XX -- ) 22 lshift GPIOB-MODER bis! ;  \ GPIOB-MODER_MODER11    Port x configuration bits y = 0..15
: GPIOB-MODER_MODER10   ( %XX -- ) 20 lshift GPIOB-MODER bis! ;  \ GPIOB-MODER_MODER10    Port x configuration bits y = 0..15
: GPIOB-MODER_MODER9   ( %XX -- ) 18 lshift GPIOB-MODER bis! ;  \ GPIOB-MODER_MODER9    Port x configuration bits y = 0..15
: GPIOB-MODER_MODER8   ( %XX -- ) 16 lshift GPIOB-MODER bis! ;  \ GPIOB-MODER_MODER8    Port x configuration bits y = 0..15
: GPIOB-MODER_MODER7   ( %XX -- ) 14 lshift GPIOB-MODER bis! ;  \ GPIOB-MODER_MODER7    Port x configuration bits y = 0..15
: GPIOB-MODER_MODER6   ( %XX -- ) 12 lshift GPIOB-MODER bis! ;  \ GPIOB-MODER_MODER6    Port x configuration bits y = 0..15
: GPIOB-MODER_MODER5   ( %XX -- ) 10 lshift GPIOB-MODER bis! ;  \ GPIOB-MODER_MODER5    Port x configuration bits y = 0..15
: GPIOB-MODER_MODER4   ( %XX -- ) 8 lshift GPIOB-MODER bis! ;  \ GPIOB-MODER_MODER4    Port x configuration bits y = 0..15
: GPIOB-MODER_MODER3   ( %XX -- ) 6 lshift GPIOB-MODER bis! ;  \ GPIOB-MODER_MODER3    Port x configuration bits y = 0..15
: GPIOB-MODER_MODER2   ( %XX -- ) 4 lshift GPIOB-MODER bis! ;  \ GPIOB-MODER_MODER2    Port x configuration bits y = 0..15
: GPIOB-MODER_MODER1   ( %XX -- ) 2 lshift GPIOB-MODER bis! ;  \ GPIOB-MODER_MODER1    Port x configuration bits y = 0..15
: GPIOB-MODER_MODER0   ( %XX -- ) 0 lshift GPIOB-MODER bis! ;  \ GPIOB-MODER_MODER0    Port x configuration bits y = 0..15

\ GPIOB-OTYPER (read-write)
: GPIOB-OTYPER_OT15   %1 15 lshift GPIOB-OTYPER bis! ;  \ GPIOB-OTYPER_OT15    Port x configuration bits y = 0..15
: GPIOB-OTYPER_OT14   %1 14 lshift GPIOB-OTYPER bis! ;  \ GPIOB-OTYPER_OT14    Port x configuration bits y = 0..15
: GPIOB-OTYPER_OT13   %1 13 lshift GPIOB-OTYPER bis! ;  \ GPIOB-OTYPER_OT13    Port x configuration bits y = 0..15
: GPIOB-OTYPER_OT12   %1 12 lshift GPIOB-OTYPER bis! ;  \ GPIOB-OTYPER_OT12    Port x configuration bits y = 0..15
: GPIOB-OTYPER_OT11   %1 11 lshift GPIOB-OTYPER bis! ;  \ GPIOB-OTYPER_OT11    Port x configuration bits y = 0..15
: GPIOB-OTYPER_OT10   %1 10 lshift GPIOB-OTYPER bis! ;  \ GPIOB-OTYPER_OT10    Port x configuration bits y = 0..15
: GPIOB-OTYPER_OT9   %1 9 lshift GPIOB-OTYPER bis! ;  \ GPIOB-OTYPER_OT9    Port x configuration bits y = 0..15
: GPIOB-OTYPER_OT8   %1 8 lshift GPIOB-OTYPER bis! ;  \ GPIOB-OTYPER_OT8    Port x configuration bits y = 0..15
: GPIOB-OTYPER_OT7   %1 7 lshift GPIOB-OTYPER bis! ;  \ GPIOB-OTYPER_OT7    Port x configuration bits y = 0..15
: GPIOB-OTYPER_OT6   %1 6 lshift GPIOB-OTYPER bis! ;  \ GPIOB-OTYPER_OT6    Port x configuration bits y = 0..15
: GPIOB-OTYPER_OT5   %1 5 lshift GPIOB-OTYPER bis! ;  \ GPIOB-OTYPER_OT5    Port x configuration bits y = 0..15
: GPIOB-OTYPER_OT4   %1 4 lshift GPIOB-OTYPER bis! ;  \ GPIOB-OTYPER_OT4    Port x configuration bits y = 0..15
: GPIOB-OTYPER_OT3   %1 3 lshift GPIOB-OTYPER bis! ;  \ GPIOB-OTYPER_OT3    Port x configuration bits y = 0..15
: GPIOB-OTYPER_OT2   %1 2 lshift GPIOB-OTYPER bis! ;  \ GPIOB-OTYPER_OT2    Port x configuration bits y = 0..15
: GPIOB-OTYPER_OT1   %1 1 lshift GPIOB-OTYPER bis! ;  \ GPIOB-OTYPER_OT1    Port x configuration bits y = 0..15
: GPIOB-OTYPER_OT0   %1 0 lshift GPIOB-OTYPER bis! ;  \ GPIOB-OTYPER_OT0    Port x configuration bits y = 0..15

\ GPIOB-OSPEEDR (read-write)
: GPIOB-OSPEEDR_OSPEEDR15   ( %XX -- ) 30 lshift GPIOB-OSPEEDR bis! ;  \ GPIOB-OSPEEDR_OSPEEDR15    Port x configuration bits y = 0..15
: GPIOB-OSPEEDR_OSPEEDR14   ( %XX -- ) 28 lshift GPIOB-OSPEEDR bis! ;  \ GPIOB-OSPEEDR_OSPEEDR14    Port x configuration bits y = 0..15
: GPIOB-OSPEEDR_OSPEEDR13   ( %XX -- ) 26 lshift GPIOB-OSPEEDR bis! ;  \ GPIOB-OSPEEDR_OSPEEDR13    Port x configuration bits y = 0..15
: GPIOB-OSPEEDR_OSPEEDR12   ( %XX -- ) 24 lshift GPIOB-OSPEEDR bis! ;  \ GPIOB-OSPEEDR_OSPEEDR12    Port x configuration bits y = 0..15
: GPIOB-OSPEEDR_OSPEEDR11   ( %XX -- ) 22 lshift GPIOB-OSPEEDR bis! ;  \ GPIOB-OSPEEDR_OSPEEDR11    Port x configuration bits y = 0..15
: GPIOB-OSPEEDR_OSPEEDR10   ( %XX -- ) 20 lshift GPIOB-OSPEEDR bis! ;  \ GPIOB-OSPEEDR_OSPEEDR10    Port x configuration bits y = 0..15
: GPIOB-OSPEEDR_OSPEEDR9   ( %XX -- ) 18 lshift GPIOB-OSPEEDR bis! ;  \ GPIOB-OSPEEDR_OSPEEDR9    Port x configuration bits y = 0..15
: GPIOB-OSPEEDR_OSPEEDR8   ( %XX -- ) 16 lshift GPIOB-OSPEEDR bis! ;  \ GPIOB-OSPEEDR_OSPEEDR8    Port x configuration bits y = 0..15
: GPIOB-OSPEEDR_OSPEEDR7   ( %XX -- ) 14 lshift GPIOB-OSPEEDR bis! ;  \ GPIOB-OSPEEDR_OSPEEDR7    Port x configuration bits y = 0..15
: GPIOB-OSPEEDR_OSPEEDR6   ( %XX -- ) 12 lshift GPIOB-OSPEEDR bis! ;  \ GPIOB-OSPEEDR_OSPEEDR6    Port x configuration bits y = 0..15
: GPIOB-OSPEEDR_OSPEEDR5   ( %XX -- ) 10 lshift GPIOB-OSPEEDR bis! ;  \ GPIOB-OSPEEDR_OSPEEDR5    Port x configuration bits y = 0..15
: GPIOB-OSPEEDR_OSPEEDR4   ( %XX -- ) 8 lshift GPIOB-OSPEEDR bis! ;  \ GPIOB-OSPEEDR_OSPEEDR4    Port x configuration bits y = 0..15
: GPIOB-OSPEEDR_OSPEEDR3   ( %XX -- ) 6 lshift GPIOB-OSPEEDR bis! ;  \ GPIOB-OSPEEDR_OSPEEDR3    Port x configuration bits y = 0..15
: GPIOB-OSPEEDR_OSPEEDR2   ( %XX -- ) 4 lshift GPIOB-OSPEEDR bis! ;  \ GPIOB-OSPEEDR_OSPEEDR2    Port x configuration bits y = 0..15
: GPIOB-OSPEEDR_OSPEEDR1   ( %XX -- ) 2 lshift GPIOB-OSPEEDR bis! ;  \ GPIOB-OSPEEDR_OSPEEDR1    Port x configuration bits y = 0..15
: GPIOB-OSPEEDR_OSPEEDR0   ( %XX -- ) 0 lshift GPIOB-OSPEEDR bis! ;  \ GPIOB-OSPEEDR_OSPEEDR0    Port x configuration bits y = 0..15

\ GPIOB-PUPDR (read-write)
: GPIOB-PUPDR_PUPDR15   ( %XX -- ) 30 lshift GPIOB-PUPDR bis! ;  \ GPIOB-PUPDR_PUPDR15    Port x configuration bits y = 0..15
: GPIOB-PUPDR_PUPDR14   ( %XX -- ) 28 lshift GPIOB-PUPDR bis! ;  \ GPIOB-PUPDR_PUPDR14    Port x configuration bits y = 0..15
: GPIOB-PUPDR_PUPDR13   ( %XX -- ) 26 lshift GPIOB-PUPDR bis! ;  \ GPIOB-PUPDR_PUPDR13    Port x configuration bits y = 0..15
: GPIOB-PUPDR_PUPDR12   ( %XX -- ) 24 lshift GPIOB-PUPDR bis! ;  \ GPIOB-PUPDR_PUPDR12    Port x configuration bits y = 0..15
: GPIOB-PUPDR_PUPDR11   ( %XX -- ) 22 lshift GPIOB-PUPDR bis! ;  \ GPIOB-PUPDR_PUPDR11    Port x configuration bits y = 0..15
: GPIOB-PUPDR_PUPDR10   ( %XX -- ) 20 lshift GPIOB-PUPDR bis! ;  \ GPIOB-PUPDR_PUPDR10    Port x configuration bits y = 0..15
: GPIOB-PUPDR_PUPDR9   ( %XX -- ) 18 lshift GPIOB-PUPDR bis! ;  \ GPIOB-PUPDR_PUPDR9    Port x configuration bits y = 0..15
: GPIOB-PUPDR_PUPDR8   ( %XX -- ) 16 lshift GPIOB-PUPDR bis! ;  \ GPIOB-PUPDR_PUPDR8    Port x configuration bits y = 0..15
: GPIOB-PUPDR_PUPDR7   ( %XX -- ) 14 lshift GPIOB-PUPDR bis! ;  \ GPIOB-PUPDR_PUPDR7    Port x configuration bits y = 0..15
: GPIOB-PUPDR_PUPDR6   ( %XX -- ) 12 lshift GPIOB-PUPDR bis! ;  \ GPIOB-PUPDR_PUPDR6    Port x configuration bits y = 0..15
: GPIOB-PUPDR_PUPDR5   ( %XX -- ) 10 lshift GPIOB-PUPDR bis! ;  \ GPIOB-PUPDR_PUPDR5    Port x configuration bits y = 0..15
: GPIOB-PUPDR_PUPDR4   ( %XX -- ) 8 lshift GPIOB-PUPDR bis! ;  \ GPIOB-PUPDR_PUPDR4    Port x configuration bits y = 0..15
: GPIOB-PUPDR_PUPDR3   ( %XX -- ) 6 lshift GPIOB-PUPDR bis! ;  \ GPIOB-PUPDR_PUPDR3    Port x configuration bits y = 0..15
: GPIOB-PUPDR_PUPDR2   ( %XX -- ) 4 lshift GPIOB-PUPDR bis! ;  \ GPIOB-PUPDR_PUPDR2    Port x configuration bits y = 0..15
: GPIOB-PUPDR_PUPDR1   ( %XX -- ) 2 lshift GPIOB-PUPDR bis! ;  \ GPIOB-PUPDR_PUPDR1    Port x configuration bits y = 0..15
: GPIOB-PUPDR_PUPDR0   ( %XX -- ) 0 lshift GPIOB-PUPDR bis! ;  \ GPIOB-PUPDR_PUPDR0    Port x configuration bits y = 0..15

\ GPIOB-IDR (read-only)
: GPIOB-IDR_IDR15   %1 15 lshift GPIOB-IDR bis! ;  \ GPIOB-IDR_IDR15    Port input data y = 0..15
: GPIOB-IDR_IDR14   %1 14 lshift GPIOB-IDR bis! ;  \ GPIOB-IDR_IDR14    Port input data y = 0..15
: GPIOB-IDR_IDR13   %1 13 lshift GPIOB-IDR bis! ;  \ GPIOB-IDR_IDR13    Port input data y = 0..15
: GPIOB-IDR_IDR12   %1 12 lshift GPIOB-IDR bis! ;  \ GPIOB-IDR_IDR12    Port input data y = 0..15
: GPIOB-IDR_IDR11   %1 11 lshift GPIOB-IDR bis! ;  \ GPIOB-IDR_IDR11    Port input data y = 0..15
: GPIOB-IDR_IDR10   %1 10 lshift GPIOB-IDR bis! ;  \ GPIOB-IDR_IDR10    Port input data y = 0..15
: GPIOB-IDR_IDR9   %1 9 lshift GPIOB-IDR bis! ;  \ GPIOB-IDR_IDR9    Port input data y = 0..15
: GPIOB-IDR_IDR8   %1 8 lshift GPIOB-IDR bis! ;  \ GPIOB-IDR_IDR8    Port input data y = 0..15
: GPIOB-IDR_IDR7   %1 7 lshift GPIOB-IDR bis! ;  \ GPIOB-IDR_IDR7    Port input data y = 0..15
: GPIOB-IDR_IDR6   %1 6 lshift GPIOB-IDR bis! ;  \ GPIOB-IDR_IDR6    Port input data y = 0..15
: GPIOB-IDR_IDR5   %1 5 lshift GPIOB-IDR bis! ;  \ GPIOB-IDR_IDR5    Port input data y = 0..15
: GPIOB-IDR_IDR4   %1 4 lshift GPIOB-IDR bis! ;  \ GPIOB-IDR_IDR4    Port input data y = 0..15
: GPIOB-IDR_IDR3   %1 3 lshift GPIOB-IDR bis! ;  \ GPIOB-IDR_IDR3    Port input data y = 0..15
: GPIOB-IDR_IDR2   %1 2 lshift GPIOB-IDR bis! ;  \ GPIOB-IDR_IDR2    Port input data y = 0..15
: GPIOB-IDR_IDR1   %1 1 lshift GPIOB-IDR bis! ;  \ GPIOB-IDR_IDR1    Port input data y = 0..15
: GPIOB-IDR_IDR0   %1 0 lshift GPIOB-IDR bis! ;  \ GPIOB-IDR_IDR0    Port input data y = 0..15

\ GPIOB-ODR (read-write)
: GPIOB-ODR_ODR15   %1 15 lshift GPIOB-ODR bis! ;  \ GPIOB-ODR_ODR15    Port output data y = 0..15
: GPIOB-ODR_ODR14   %1 14 lshift GPIOB-ODR bis! ;  \ GPIOB-ODR_ODR14    Port output data y = 0..15
: GPIOB-ODR_ODR13   %1 13 lshift GPIOB-ODR bis! ;  \ GPIOB-ODR_ODR13    Port output data y = 0..15
: GPIOB-ODR_ODR12   %1 12 lshift GPIOB-ODR bis! ;  \ GPIOB-ODR_ODR12    Port output data y = 0..15
: GPIOB-ODR_ODR11   %1 11 lshift GPIOB-ODR bis! ;  \ GPIOB-ODR_ODR11    Port output data y = 0..15
: GPIOB-ODR_ODR10   %1 10 lshift GPIOB-ODR bis! ;  \ GPIOB-ODR_ODR10    Port output data y = 0..15
: GPIOB-ODR_ODR9   %1 9 lshift GPIOB-ODR bis! ;  \ GPIOB-ODR_ODR9    Port output data y = 0..15
: GPIOB-ODR_ODR8   %1 8 lshift GPIOB-ODR bis! ;  \ GPIOB-ODR_ODR8    Port output data y = 0..15
: GPIOB-ODR_ODR7   %1 7 lshift GPIOB-ODR bis! ;  \ GPIOB-ODR_ODR7    Port output data y = 0..15
: GPIOB-ODR_ODR6   %1 6 lshift GPIOB-ODR bis! ;  \ GPIOB-ODR_ODR6    Port output data y = 0..15
: GPIOB-ODR_ODR5   %1 5 lshift GPIOB-ODR bis! ;  \ GPIOB-ODR_ODR5    Port output data y = 0..15
: GPIOB-ODR_ODR4   %1 4 lshift GPIOB-ODR bis! ;  \ GPIOB-ODR_ODR4    Port output data y = 0..15
: GPIOB-ODR_ODR3   %1 3 lshift GPIOB-ODR bis! ;  \ GPIOB-ODR_ODR3    Port output data y = 0..15
: GPIOB-ODR_ODR2   %1 2 lshift GPIOB-ODR bis! ;  \ GPIOB-ODR_ODR2    Port output data y = 0..15
: GPIOB-ODR_ODR1   %1 1 lshift GPIOB-ODR bis! ;  \ GPIOB-ODR_ODR1    Port output data y = 0..15
: GPIOB-ODR_ODR0   %1 0 lshift GPIOB-ODR bis! ;  \ GPIOB-ODR_ODR0    Port output data y = 0..15

\ GPIOB-BSRR (write-only)
: GPIOB-BSRR_BR15   %1 31 lshift GPIOB-BSRR bis! ;  \ GPIOB-BSRR_BR15    Port x reset bit y y = 0..15
: GPIOB-BSRR_BR14   %1 30 lshift GPIOB-BSRR bis! ;  \ GPIOB-BSRR_BR14    Port x reset bit y y = 0..15
: GPIOB-BSRR_BR13   %1 29 lshift GPIOB-BSRR bis! ;  \ GPIOB-BSRR_BR13    Port x reset bit y y = 0..15
: GPIOB-BSRR_BR12   %1 28 lshift GPIOB-BSRR bis! ;  \ GPIOB-BSRR_BR12    Port x reset bit y y = 0..15
: GPIOB-BSRR_BR11   %1 27 lshift GPIOB-BSRR bis! ;  \ GPIOB-BSRR_BR11    Port x reset bit y y = 0..15
: GPIOB-BSRR_BR10   %1 26 lshift GPIOB-BSRR bis! ;  \ GPIOB-BSRR_BR10    Port x reset bit y y = 0..15
: GPIOB-BSRR_BR9   %1 25 lshift GPIOB-BSRR bis! ;  \ GPIOB-BSRR_BR9    Port x reset bit y y = 0..15
: GPIOB-BSRR_BR8   %1 24 lshift GPIOB-BSRR bis! ;  \ GPIOB-BSRR_BR8    Port x reset bit y y = 0..15
: GPIOB-BSRR_BR7   %1 23 lshift GPIOB-BSRR bis! ;  \ GPIOB-BSRR_BR7    Port x reset bit y y = 0..15
: GPIOB-BSRR_BR6   %1 22 lshift GPIOB-BSRR bis! ;  \ GPIOB-BSRR_BR6    Port x reset bit y y = 0..15
: GPIOB-BSRR_BR5   %1 21 lshift GPIOB-BSRR bis! ;  \ GPIOB-BSRR_BR5    Port x reset bit y y = 0..15
: GPIOB-BSRR_BR4   %1 20 lshift GPIOB-BSRR bis! ;  \ GPIOB-BSRR_BR4    Port x reset bit y y = 0..15
: GPIOB-BSRR_BR3   %1 19 lshift GPIOB-BSRR bis! ;  \ GPIOB-BSRR_BR3    Port x reset bit y y = 0..15
: GPIOB-BSRR_BR2   %1 18 lshift GPIOB-BSRR bis! ;  \ GPIOB-BSRR_BR2    Port x reset bit y y = 0..15
: GPIOB-BSRR_BR1   %1 17 lshift GPIOB-BSRR bis! ;  \ GPIOB-BSRR_BR1    Port x reset bit y y = 0..15
: GPIOB-BSRR_BR0   %1 16 lshift GPIOB-BSRR bis! ;  \ GPIOB-BSRR_BR0    Port x set bit y y= 0..15
: GPIOB-BSRR_BS15   %1 15 lshift GPIOB-BSRR bis! ;  \ GPIOB-BSRR_BS15    Port x set bit y y= 0..15
: GPIOB-BSRR_BS14   %1 14 lshift GPIOB-BSRR bis! ;  \ GPIOB-BSRR_BS14    Port x set bit y y= 0..15
: GPIOB-BSRR_BS13   %1 13 lshift GPIOB-BSRR bis! ;  \ GPIOB-BSRR_BS13    Port x set bit y y= 0..15
: GPIOB-BSRR_BS12   %1 12 lshift GPIOB-BSRR bis! ;  \ GPIOB-BSRR_BS12    Port x set bit y y= 0..15
: GPIOB-BSRR_BS11   %1 11 lshift GPIOB-BSRR bis! ;  \ GPIOB-BSRR_BS11    Port x set bit y y= 0..15
: GPIOB-BSRR_BS10   %1 10 lshift GPIOB-BSRR bis! ;  \ GPIOB-BSRR_BS10    Port x set bit y y= 0..15
: GPIOB-BSRR_BS9   %1 9 lshift GPIOB-BSRR bis! ;  \ GPIOB-BSRR_BS9    Port x set bit y y= 0..15
: GPIOB-BSRR_BS8   %1 8 lshift GPIOB-BSRR bis! ;  \ GPIOB-BSRR_BS8    Port x set bit y y= 0..15
: GPIOB-BSRR_BS7   %1 7 lshift GPIOB-BSRR bis! ;  \ GPIOB-BSRR_BS7    Port x set bit y y= 0..15
: GPIOB-BSRR_BS6   %1 6 lshift GPIOB-BSRR bis! ;  \ GPIOB-BSRR_BS6    Port x set bit y y= 0..15
: GPIOB-BSRR_BS5   %1 5 lshift GPIOB-BSRR bis! ;  \ GPIOB-BSRR_BS5    Port x set bit y y= 0..15
: GPIOB-BSRR_BS4   %1 4 lshift GPIOB-BSRR bis! ;  \ GPIOB-BSRR_BS4    Port x set bit y y= 0..15
: GPIOB-BSRR_BS3   %1 3 lshift GPIOB-BSRR bis! ;  \ GPIOB-BSRR_BS3    Port x set bit y y= 0..15
: GPIOB-BSRR_BS2   %1 2 lshift GPIOB-BSRR bis! ;  \ GPIOB-BSRR_BS2    Port x set bit y y= 0..15
: GPIOB-BSRR_BS1   %1 1 lshift GPIOB-BSRR bis! ;  \ GPIOB-BSRR_BS1    Port x set bit y y= 0..15
: GPIOB-BSRR_BS0   %1 0 lshift GPIOB-BSRR bis! ;  \ GPIOB-BSRR_BS0    Port x set bit y y= 0..15

\ GPIOB-LCKR (read-write)
: GPIOB-LCKR_LCKK   %1 16 lshift GPIOB-LCKR bis! ;  \ GPIOB-LCKR_LCKK    Port x lock bit y y= 0..15
: GPIOB-LCKR_LCK15   %1 15 lshift GPIOB-LCKR bis! ;  \ GPIOB-LCKR_LCK15    Port x lock bit y y= 0..15
: GPIOB-LCKR_LCK14   %1 14 lshift GPIOB-LCKR bis! ;  \ GPIOB-LCKR_LCK14    Port x lock bit y y= 0..15
: GPIOB-LCKR_LCK13   %1 13 lshift GPIOB-LCKR bis! ;  \ GPIOB-LCKR_LCK13    Port x lock bit y y= 0..15
: GPIOB-LCKR_LCK12   %1 12 lshift GPIOB-LCKR bis! ;  \ GPIOB-LCKR_LCK12    Port x lock bit y y= 0..15
: GPIOB-LCKR_LCK11   %1 11 lshift GPIOB-LCKR bis! ;  \ GPIOB-LCKR_LCK11    Port x lock bit y y= 0..15
: GPIOB-LCKR_LCK10   %1 10 lshift GPIOB-LCKR bis! ;  \ GPIOB-LCKR_LCK10    Port x lock bit y y= 0..15
: GPIOB-LCKR_LCK9   %1 9 lshift GPIOB-LCKR bis! ;  \ GPIOB-LCKR_LCK9    Port x lock bit y y= 0..15
: GPIOB-LCKR_LCK8   %1 8 lshift GPIOB-LCKR bis! ;  \ GPIOB-LCKR_LCK8    Port x lock bit y y= 0..15
: GPIOB-LCKR_LCK7   %1 7 lshift GPIOB-LCKR bis! ;  \ GPIOB-LCKR_LCK7    Port x lock bit y y= 0..15
: GPIOB-LCKR_LCK6   %1 6 lshift GPIOB-LCKR bis! ;  \ GPIOB-LCKR_LCK6    Port x lock bit y y= 0..15
: GPIOB-LCKR_LCK5   %1 5 lshift GPIOB-LCKR bis! ;  \ GPIOB-LCKR_LCK5    Port x lock bit y y= 0..15
: GPIOB-LCKR_LCK4   %1 4 lshift GPIOB-LCKR bis! ;  \ GPIOB-LCKR_LCK4    Port x lock bit y y= 0..15
: GPIOB-LCKR_LCK3   %1 3 lshift GPIOB-LCKR bis! ;  \ GPIOB-LCKR_LCK3    Port x lock bit y y= 0..15
: GPIOB-LCKR_LCK2   %1 2 lshift GPIOB-LCKR bis! ;  \ GPIOB-LCKR_LCK2    Port x lock bit y y= 0..15
: GPIOB-LCKR_LCK1   %1 1 lshift GPIOB-LCKR bis! ;  \ GPIOB-LCKR_LCK1    Port x lock bit y y= 0..15
: GPIOB-LCKR_LCK0   %1 0 lshift GPIOB-LCKR bis! ;  \ GPIOB-LCKR_LCK0    Port x lock bit y y= 0..15

\ GPIOB-AFRL (read-write)
: GPIOB-AFRL_AFRL7   ( %XXXX -- ) 28 lshift GPIOB-AFRL bis! ;  \ GPIOB-AFRL_AFRL7    Alternate function selection for port x bit y y = 0..7
: GPIOB-AFRL_AFRL6   ( %XXXX -- ) 24 lshift GPIOB-AFRL bis! ;  \ GPIOB-AFRL_AFRL6    Alternate function selection for port x bit y y = 0..7
: GPIOB-AFRL_AFRL5   ( %XXXX -- ) 20 lshift GPIOB-AFRL bis! ;  \ GPIOB-AFRL_AFRL5    Alternate function selection for port x bit y y = 0..7
: GPIOB-AFRL_AFRL4   ( %XXXX -- ) 16 lshift GPIOB-AFRL bis! ;  \ GPIOB-AFRL_AFRL4    Alternate function selection for port x bit y y = 0..7
: GPIOB-AFRL_AFRL3   ( %XXXX -- ) 12 lshift GPIOB-AFRL bis! ;  \ GPIOB-AFRL_AFRL3    Alternate function selection for port x bit y y = 0..7
: GPIOB-AFRL_AFRL2   ( %XXXX -- ) 8 lshift GPIOB-AFRL bis! ;  \ GPIOB-AFRL_AFRL2    Alternate function selection for port x bit y y = 0..7
: GPIOB-AFRL_AFRL1   ( %XXXX -- ) 4 lshift GPIOB-AFRL bis! ;  \ GPIOB-AFRL_AFRL1    Alternate function selection for port x bit y y = 0..7
: GPIOB-AFRL_AFRL0   ( %XXXX -- ) 0 lshift GPIOB-AFRL bis! ;  \ GPIOB-AFRL_AFRL0    Alternate function selection for port x bit y y = 0..7

\ GPIOB-AFRH (read-write)
: GPIOB-AFRH_AFRH15   ( %XXXX -- ) 28 lshift GPIOB-AFRH bis! ;  \ GPIOB-AFRH_AFRH15    Alternate function selection for port x bit y y = 8..15
: GPIOB-AFRH_AFRH14   ( %XXXX -- ) 24 lshift GPIOB-AFRH bis! ;  \ GPIOB-AFRH_AFRH14    Alternate function selection for port x bit y y = 8..15
: GPIOB-AFRH_AFRH13   ( %XXXX -- ) 20 lshift GPIOB-AFRH bis! ;  \ GPIOB-AFRH_AFRH13    Alternate function selection for port x bit y y = 8..15
: GPIOB-AFRH_AFRH12   ( %XXXX -- ) 16 lshift GPIOB-AFRH bis! ;  \ GPIOB-AFRH_AFRH12    Alternate function selection for port x bit y y = 8..15
: GPIOB-AFRH_AFRH11   ( %XXXX -- ) 12 lshift GPIOB-AFRH bis! ;  \ GPIOB-AFRH_AFRH11    Alternate function selection for port x bit y y = 8..15
: GPIOB-AFRH_AFRH10   ( %XXXX -- ) 8 lshift GPIOB-AFRH bis! ;  \ GPIOB-AFRH_AFRH10    Alternate function selection for port x bit y y = 8..15
: GPIOB-AFRH_AFRH9   ( %XXXX -- ) 4 lshift GPIOB-AFRH bis! ;  \ GPIOB-AFRH_AFRH9    Alternate function selection for port x bit y y = 8..15
: GPIOB-AFRH_AFRH8   ( %XXXX -- ) 0 lshift GPIOB-AFRH bis! ;  \ GPIOB-AFRH_AFRH8    Alternate function selection for port x bit y y = 8..15

\ GPIOB-BRR (read-write)
: GPIOB-BRR_BR0   %1 0 lshift GPIOB-BRR bis! ;  \ GPIOB-BRR_BR0    Port Reset bit
: GPIOB-BRR_BR1   %1 1 lshift GPIOB-BRR bis! ;  \ GPIOB-BRR_BR1    Port Reset bit
: GPIOB-BRR_BR2   %1 2 lshift GPIOB-BRR bis! ;  \ GPIOB-BRR_BR2    Port Reset bit
: GPIOB-BRR_BR3   %1 3 lshift GPIOB-BRR bis! ;  \ GPIOB-BRR_BR3    Port Reset bit
: GPIOB-BRR_BR4   %1 4 lshift GPIOB-BRR bis! ;  \ GPIOB-BRR_BR4    Port Reset bit
: GPIOB-BRR_BR5   %1 5 lshift GPIOB-BRR bis! ;  \ GPIOB-BRR_BR5    Port Reset bit
: GPIOB-BRR_BR6   %1 6 lshift GPIOB-BRR bis! ;  \ GPIOB-BRR_BR6    Port Reset bit
: GPIOB-BRR_BR7   %1 7 lshift GPIOB-BRR bis! ;  \ GPIOB-BRR_BR7    Port Reset bit
: GPIOB-BRR_BR8   %1 8 lshift GPIOB-BRR bis! ;  \ GPIOB-BRR_BR8    Port Reset bit
: GPIOB-BRR_BR9   %1 9 lshift GPIOB-BRR bis! ;  \ GPIOB-BRR_BR9    Port Reset bit
: GPIOB-BRR_BR10   %1 10 lshift GPIOB-BRR bis! ;  \ GPIOB-BRR_BR10    Port Reset bit
: GPIOB-BRR_BR11   %1 11 lshift GPIOB-BRR bis! ;  \ GPIOB-BRR_BR11    Port Reset bit
: GPIOB-BRR_BR12   %1 12 lshift GPIOB-BRR bis! ;  \ GPIOB-BRR_BR12    Port Reset bit
: GPIOB-BRR_BR13   %1 13 lshift GPIOB-BRR bis! ;  \ GPIOB-BRR_BR13    Port Reset bit
: GPIOB-BRR_BR14   %1 14 lshift GPIOB-BRR bis! ;  \ GPIOB-BRR_BR14    Port Reset bit
: GPIOB-BRR_BR15   %1 15 lshift GPIOB-BRR bis! ;  \ GPIOB-BRR_BR15    Port Reset bit

\ I2C2-CR1 (read-write)
: I2C2-CR1_PE   %1 0 lshift I2C2-CR1 bis! ;  \ I2C2-CR1_PE    Peripheral enable
: I2C2-CR1_TXIE   %1 1 lshift I2C2-CR1 bis! ;  \ I2C2-CR1_TXIE    TX Interrupt enable
: I2C2-CR1_RXIE   %1 2 lshift I2C2-CR1 bis! ;  \ I2C2-CR1_RXIE    RX Interrupt enable
: I2C2-CR1_ADDRIE   %1 3 lshift I2C2-CR1 bis! ;  \ I2C2-CR1_ADDRIE    Address match interrupt enable slave only
: I2C2-CR1_NACKIE   %1 4 lshift I2C2-CR1 bis! ;  \ I2C2-CR1_NACKIE    Not acknowledge received interrupt enable
: I2C2-CR1_STOPIE   %1 5 lshift I2C2-CR1 bis! ;  \ I2C2-CR1_STOPIE    STOP detection Interrupt enable
: I2C2-CR1_TCIE   %1 6 lshift I2C2-CR1 bis! ;  \ I2C2-CR1_TCIE    Transfer Complete interrupt enable
: I2C2-CR1_ERRIE   %1 7 lshift I2C2-CR1 bis! ;  \ I2C2-CR1_ERRIE    Error interrupts enable
: I2C2-CR1_DNF   ( %XXXX -- ) 8 lshift I2C2-CR1 bis! ;  \ I2C2-CR1_DNF    Digital noise filter
: I2C2-CR1_ANFOFF   %1 12 lshift I2C2-CR1 bis! ;  \ I2C2-CR1_ANFOFF    Analog noise filter OFF
: I2C2-CR1_TXDMAEN   %1 14 lshift I2C2-CR1 bis! ;  \ I2C2-CR1_TXDMAEN    DMA transmission requests enable
: I2C2-CR1_RXDMAEN   %1 15 lshift I2C2-CR1 bis! ;  \ I2C2-CR1_RXDMAEN    DMA reception requests enable
: I2C2-CR1_SBC   %1 16 lshift I2C2-CR1 bis! ;  \ I2C2-CR1_SBC    Slave byte control
: I2C2-CR1_NOSTRETCH   %1 17 lshift I2C2-CR1 bis! ;  \ I2C2-CR1_NOSTRETCH    Clock stretching disable
: I2C2-CR1_WUPEN   %1 18 lshift I2C2-CR1 bis! ;  \ I2C2-CR1_WUPEN    Wakeup from STOP enable
: I2C2-CR1_GCEN   %1 19 lshift I2C2-CR1 bis! ;  \ I2C2-CR1_GCEN    General call enable
: I2C2-CR1_SMBHEN   %1 20 lshift I2C2-CR1 bis! ;  \ I2C2-CR1_SMBHEN    SMBus Host address enable
: I2C2-CR1_SMBDEN   %1 21 lshift I2C2-CR1 bis! ;  \ I2C2-CR1_SMBDEN    SMBus Device Default address enable
: I2C2-CR1_ALERTEN   %1 22 lshift I2C2-CR1 bis! ;  \ I2C2-CR1_ALERTEN    SMBUS alert enable
: I2C2-CR1_PECEN   %1 23 lshift I2C2-CR1 bis! ;  \ I2C2-CR1_PECEN    PEC enable

\ I2C2-CR2 (read-write)
: I2C2-CR2_PECBYTE   %1 26 lshift I2C2-CR2 bis! ;  \ I2C2-CR2_PECBYTE    Packet error checking byte
: I2C2-CR2_AUTOEND   %1 25 lshift I2C2-CR2 bis! ;  \ I2C2-CR2_AUTOEND    Automatic end mode master mode
: I2C2-CR2_RELOAD   %1 24 lshift I2C2-CR2 bis! ;  \ I2C2-CR2_RELOAD    NBYTES reload mode
: I2C2-CR2_NBYTES   ( %XXXXXXXX -- ) 16 lshift I2C2-CR2 bis! ;  \ I2C2-CR2_NBYTES    Number of bytes
: I2C2-CR2_NACK   %1 15 lshift I2C2-CR2 bis! ;  \ I2C2-CR2_NACK    NACK generation slave mode
: I2C2-CR2_STOP   %1 14 lshift I2C2-CR2 bis! ;  \ I2C2-CR2_STOP    Stop generation master mode
: I2C2-CR2_START   %1 13 lshift I2C2-CR2 bis! ;  \ I2C2-CR2_START    Start generation
: I2C2-CR2_HEAD10R   %1 12 lshift I2C2-CR2 bis! ;  \ I2C2-CR2_HEAD10R    10-bit address header only read direction master receiver mode
: I2C2-CR2_ADD10   %1 11 lshift I2C2-CR2 bis! ;  \ I2C2-CR2_ADD10    10-bit addressing mode master mode
: I2C2-CR2_RD_WRN   %1 10 lshift I2C2-CR2 bis! ;  \ I2C2-CR2_RD_WRN    Transfer direction master mode
: I2C2-CR2_SADD  0 lshift I2C2-CR2 bis! ;  \ I2C2-CR2_SADD    Slave address bit master mode

\ I2C2-OAR1 (read-write)
: I2C2-OAR1_OA1  0 lshift I2C2-OAR1 bis! ;  \ I2C2-OAR1_OA1    Interface address
: I2C2-OAR1_OA1MODE   %1 10 lshift I2C2-OAR1 bis! ;  \ I2C2-OAR1_OA1MODE    Own Address 1 10-bit mode
: I2C2-OAR1_OA1EN   %1 15 lshift I2C2-OAR1 bis! ;  \ I2C2-OAR1_OA1EN    Own Address 1 enable

\ I2C2-OAR2 (read-write)
: I2C2-OAR2_OA2   ( %XXXXXXX -- ) 1 lshift I2C2-OAR2 bis! ;  \ I2C2-OAR2_OA2    Interface address
: I2C2-OAR2_OA2MSK   ( %XXX -- ) 8 lshift I2C2-OAR2 bis! ;  \ I2C2-OAR2_OA2MSK    Own Address 2 masks
: I2C2-OAR2_OA2EN   %1 15 lshift I2C2-OAR2 bis! ;  \ I2C2-OAR2_OA2EN    Own Address 2 enable

\ I2C2-TIMINGR (read-write)
: I2C2-TIMINGR_SCLL   ( %XXXXXXXX -- ) 0 lshift I2C2-TIMINGR bis! ;  \ I2C2-TIMINGR_SCLL    SCL low period master mode
: I2C2-TIMINGR_SCLH   ( %XXXXXXXX -- ) 8 lshift I2C2-TIMINGR bis! ;  \ I2C2-TIMINGR_SCLH    SCL high period master mode
: I2C2-TIMINGR_SDADEL   ( %XXXX -- ) 16 lshift I2C2-TIMINGR bis! ;  \ I2C2-TIMINGR_SDADEL    Data hold time
: I2C2-TIMINGR_SCLDEL   ( %XXXX -- ) 20 lshift I2C2-TIMINGR bis! ;  \ I2C2-TIMINGR_SCLDEL    Data setup time
: I2C2-TIMINGR_PRESC   ( %XXXX -- ) 28 lshift I2C2-TIMINGR bis! ;  \ I2C2-TIMINGR_PRESC    Timing prescaler

\ I2C2-TIMEOUTR (read-write)
: I2C2-TIMEOUTR_TIMEOUTA   ( %XXXXXXXXXXX -- ) 0 lshift I2C2-TIMEOUTR bis! ;  \ I2C2-TIMEOUTR_TIMEOUTA    Bus timeout A
: I2C2-TIMEOUTR_TIDLE   %1 12 lshift I2C2-TIMEOUTR bis! ;  \ I2C2-TIMEOUTR_TIDLE    Idle clock timeout detection
: I2C2-TIMEOUTR_TIMOUTEN   %1 15 lshift I2C2-TIMEOUTR bis! ;  \ I2C2-TIMEOUTR_TIMOUTEN    Clock timeout enable
: I2C2-TIMEOUTR_TIMEOUTB   ( %XXXXXXXXXXX -- ) 16 lshift I2C2-TIMEOUTR bis! ;  \ I2C2-TIMEOUTR_TIMEOUTB    Bus timeout B
: I2C2-TIMEOUTR_TEXTEN   %1 31 lshift I2C2-TIMEOUTR bis! ;  \ I2C2-TIMEOUTR_TEXTEN    Extended clock timeout enable

\ I2C2-ISR ()
: I2C2-ISR_ADDCODE   ( %XXXXXXX -- ) 17 lshift I2C2-ISR bis! ;  \ I2C2-ISR_ADDCODE    Address match code Slave mode
: I2C2-ISR_DIR   %1 16 lshift I2C2-ISR bis! ;  \ I2C2-ISR_DIR    Transfer direction Slave mode
: I2C2-ISR_BUSY   %1 15 lshift I2C2-ISR bis! ;  \ I2C2-ISR_BUSY    Bus busy
: I2C2-ISR_ALERT   %1 13 lshift I2C2-ISR bis! ;  \ I2C2-ISR_ALERT    SMBus alert
: I2C2-ISR_TIMEOUT   %1 12 lshift I2C2-ISR bis! ;  \ I2C2-ISR_TIMEOUT    Timeout or t_low detection flag
: I2C2-ISR_PECERR   %1 11 lshift I2C2-ISR bis! ;  \ I2C2-ISR_PECERR    PEC Error in reception
: I2C2-ISR_OVR   %1 10 lshift I2C2-ISR bis! ;  \ I2C2-ISR_OVR    Overrun/Underrun slave mode
: I2C2-ISR_ARLO   %1 9 lshift I2C2-ISR bis! ;  \ I2C2-ISR_ARLO    Arbitration lost
: I2C2-ISR_BERR   %1 8 lshift I2C2-ISR bis! ;  \ I2C2-ISR_BERR    Bus error
: I2C2-ISR_TCR   %1 7 lshift I2C2-ISR bis! ;  \ I2C2-ISR_TCR    Transfer Complete Reload
: I2C2-ISR_TC   %1 6 lshift I2C2-ISR bis! ;  \ I2C2-ISR_TC    Transfer Complete master mode
: I2C2-ISR_STOPF   %1 5 lshift I2C2-ISR bis! ;  \ I2C2-ISR_STOPF    Stop detection flag
: I2C2-ISR_NACKF   %1 4 lshift I2C2-ISR bis! ;  \ I2C2-ISR_NACKF    Not acknowledge received flag
: I2C2-ISR_ADDR   %1 3 lshift I2C2-ISR bis! ;  \ I2C2-ISR_ADDR    Address matched slave mode
: I2C2-ISR_RXNE   %1 2 lshift I2C2-ISR bis! ;  \ I2C2-ISR_RXNE    Receive data register not empty receivers
: I2C2-ISR_TXIS   %1 1 lshift I2C2-ISR bis! ;  \ I2C2-ISR_TXIS    Transmit interrupt status transmitters
: I2C2-ISR_TXE   %1 0 lshift I2C2-ISR bis! ;  \ I2C2-ISR_TXE    Transmit data register empty transmitters

\ I2C2-ICR (write-only)
: I2C2-ICR_ALERTCF   %1 13 lshift I2C2-ICR bis! ;  \ I2C2-ICR_ALERTCF    Alert flag clear
: I2C2-ICR_TIMOUTCF   %1 12 lshift I2C2-ICR bis! ;  \ I2C2-ICR_TIMOUTCF    Timeout detection flag clear
: I2C2-ICR_PECCF   %1 11 lshift I2C2-ICR bis! ;  \ I2C2-ICR_PECCF    PEC Error flag clear
: I2C2-ICR_OVRCF   %1 10 lshift I2C2-ICR bis! ;  \ I2C2-ICR_OVRCF    Overrun/Underrun flag clear
: I2C2-ICR_ARLOCF   %1 9 lshift I2C2-ICR bis! ;  \ I2C2-ICR_ARLOCF    Arbitration lost flag clear
: I2C2-ICR_BERRCF   %1 8 lshift I2C2-ICR bis! ;  \ I2C2-ICR_BERRCF    Bus error flag clear
: I2C2-ICR_STOPCF   %1 5 lshift I2C2-ICR bis! ;  \ I2C2-ICR_STOPCF    Stop detection flag clear
: I2C2-ICR_NACKCF   %1 4 lshift I2C2-ICR bis! ;  \ I2C2-ICR_NACKCF    Not Acknowledge flag clear
: I2C2-ICR_ADDRCF   %1 3 lshift I2C2-ICR bis! ;  \ I2C2-ICR_ADDRCF    Address Matched flag clear

\ I2C2-PECR (read-only)
: I2C2-PECR_PEC   ( %XXXXXXXX -- ) 0 lshift I2C2-PECR bis! ;  \ I2C2-PECR_PEC    Packet error checking register

\ I2C2-RXDR (read-only)
: I2C2-RXDR_RXDATA   ( %XXXXXXXX -- ) 0 lshift I2C2-RXDR bis! ;  \ I2C2-RXDR_RXDATA    8-bit receive data

\ I2C2-TXDR (read-write)
: I2C2-TXDR_TXDATA   ( %XXXXXXXX -- ) 0 lshift I2C2-TXDR bis! ;  \ I2C2-TXDR_TXDATA    8-bit transmit data

\ NVIC-ISER0 (read-write)
: NVIC-ISER0_SETENA   ( %XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX -- ) 0 lshift NVIC-ISER0 bis! ;  \ NVIC-ISER0_SETENA    SETENA

\ NVIC-ISER1 (read-write)
: NVIC-ISER1_SETENA   ( %XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX -- ) 0 lshift NVIC-ISER1 bis! ;  \ NVIC-ISER1_SETENA    SETENA

\ NVIC-ICER0 (read-write)
: NVIC-ICER0_CLRENA   ( %XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX -- ) 0 lshift NVIC-ICER0 bis! ;  \ NVIC-ICER0_CLRENA    CLRENA

\ NVIC-ICER1 (read-write)
: NVIC-ICER1_CLRENA   ( %XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX -- ) 0 lshift NVIC-ICER1 bis! ;  \ NVIC-ICER1_CLRENA    CLRENA

\ NVIC-ISPR0 (read-write)
: NVIC-ISPR0_SETPEND   ( %XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX -- ) 0 lshift NVIC-ISPR0 bis! ;  \ NVIC-ISPR0_SETPEND    SETPEND

\ NVIC-ISPR1 (read-write)
: NVIC-ISPR1_SETPEND   ( %XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX -- ) 0 lshift NVIC-ISPR1 bis! ;  \ NVIC-ISPR1_SETPEND    SETPEND

\ NVIC-ICPR0 (read-write)
: NVIC-ICPR0_CLRPEND   ( %XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX -- ) 0 lshift NVIC-ICPR0 bis! ;  \ NVIC-ICPR0_CLRPEND    CLRPEND

\ NVIC-ICPR1 (read-write)
: NVIC-ICPR1_CLRPEND   ( %XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX -- ) 0 lshift NVIC-ICPR1 bis! ;  \ NVIC-ICPR1_CLRPEND    CLRPEND

\ NVIC-IABR0 (read-only)
: NVIC-IABR0_ACTIVE   ( %XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX -- ) 0 lshift NVIC-IABR0 bis! ;  \ NVIC-IABR0_ACTIVE    ACTIVE

\ NVIC-IABR1 (read-only)
: NVIC-IABR1_ACTIVE   ( %XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX -- ) 0 lshift NVIC-IABR1 bis! ;  \ NVIC-IABR1_ACTIVE    ACTIVE

\ NVIC-IPR0 (read-write)
: NVIC-IPR0_IPR_N0   ( %XXXXXXXX -- ) 0 lshift NVIC-IPR0 bis! ;  \ NVIC-IPR0_IPR_N0    IPR_N0
: NVIC-IPR0_IPR_N1   ( %XXXXXXXX -- ) 8 lshift NVIC-IPR0 bis! ;  \ NVIC-IPR0_IPR_N1    IPR_N1
: NVIC-IPR0_IPR_N2   ( %XXXXXXXX -- ) 16 lshift NVIC-IPR0 bis! ;  \ NVIC-IPR0_IPR_N2    IPR_N2
: NVIC-IPR0_IPR_N3   ( %XXXXXXXX -- ) 24 lshift NVIC-IPR0 bis! ;  \ NVIC-IPR0_IPR_N3    IPR_N3

\ NVIC-IPR1 (read-write)
: NVIC-IPR1_IPR_N0   ( %XXXXXXXX -- ) 0 lshift NVIC-IPR1 bis! ;  \ NVIC-IPR1_IPR_N0    IPR_N0
: NVIC-IPR1_IPR_N1   ( %XXXXXXXX -- ) 8 lshift NVIC-IPR1 bis! ;  \ NVIC-IPR1_IPR_N1    IPR_N1
: NVIC-IPR1_IPR_N2   ( %XXXXXXXX -- ) 16 lshift NVIC-IPR1 bis! ;  \ NVIC-IPR1_IPR_N2    IPR_N2
: NVIC-IPR1_IPR_N3   ( %XXXXXXXX -- ) 24 lshift NVIC-IPR1 bis! ;  \ NVIC-IPR1_IPR_N3    IPR_N3

\ NVIC-IPR2 (read-write)
: NVIC-IPR2_IPR_N0   ( %XXXXXXXX -- ) 0 lshift NVIC-IPR2 bis! ;  \ NVIC-IPR2_IPR_N0    IPR_N0
: NVIC-IPR2_IPR_N1   ( %XXXXXXXX -- ) 8 lshift NVIC-IPR2 bis! ;  \ NVIC-IPR2_IPR_N1    IPR_N1
: NVIC-IPR2_IPR_N2   ( %XXXXXXXX -- ) 16 lshift NVIC-IPR2 bis! ;  \ NVIC-IPR2_IPR_N2    IPR_N2
: NVIC-IPR2_IPR_N3   ( %XXXXXXXX -- ) 24 lshift NVIC-IPR2 bis! ;  \ NVIC-IPR2_IPR_N3    IPR_N3

\ NVIC-IPR3 (read-write)
: NVIC-IPR3_IPR_N0   ( %XXXXXXXX -- ) 0 lshift NVIC-IPR3 bis! ;  \ NVIC-IPR3_IPR_N0    IPR_N0
: NVIC-IPR3_IPR_N1   ( %XXXXXXXX -- ) 8 lshift NVIC-IPR3 bis! ;  \ NVIC-IPR3_IPR_N1    IPR_N1
: NVIC-IPR3_IPR_N2   ( %XXXXXXXX -- ) 16 lshift NVIC-IPR3 bis! ;  \ NVIC-IPR3_IPR_N2    IPR_N2
: NVIC-IPR3_IPR_N3   ( %XXXXXXXX -- ) 24 lshift NVIC-IPR3 bis! ;  \ NVIC-IPR3_IPR_N3    IPR_N3

\ NVIC-IPR4 (read-write)
: NVIC-IPR4_IPR_N0   ( %XXXXXXXX -- ) 0 lshift NVIC-IPR4 bis! ;  \ NVIC-IPR4_IPR_N0    IPR_N0
: NVIC-IPR4_IPR_N1   ( %XXXXXXXX -- ) 8 lshift NVIC-IPR4 bis! ;  \ NVIC-IPR4_IPR_N1    IPR_N1
: NVIC-IPR4_IPR_N2   ( %XXXXXXXX -- ) 16 lshift NVIC-IPR4 bis! ;  \ NVIC-IPR4_IPR_N2    IPR_N2
: NVIC-IPR4_IPR_N3   ( %XXXXXXXX -- ) 24 lshift NVIC-IPR4 bis! ;  \ NVIC-IPR4_IPR_N3    IPR_N3

\ NVIC-IPR5 (read-write)
: NVIC-IPR5_IPR_N0   ( %XXXXXXXX -- ) 0 lshift NVIC-IPR5 bis! ;  \ NVIC-IPR5_IPR_N0    IPR_N0
: NVIC-IPR5_IPR_N1   ( %XXXXXXXX -- ) 8 lshift NVIC-IPR5 bis! ;  \ NVIC-IPR5_IPR_N1    IPR_N1
: NVIC-IPR5_IPR_N2   ( %XXXXXXXX -- ) 16 lshift NVIC-IPR5 bis! ;  \ NVIC-IPR5_IPR_N2    IPR_N2
: NVIC-IPR5_IPR_N3   ( %XXXXXXXX -- ) 24 lshift NVIC-IPR5 bis! ;  \ NVIC-IPR5_IPR_N3    IPR_N3

\ NVIC-IPR6 (read-write)
: NVIC-IPR6_IPR_N0   ( %XXXXXXXX -- ) 0 lshift NVIC-IPR6 bis! ;  \ NVIC-IPR6_IPR_N0    IPR_N0
: NVIC-IPR6_IPR_N1   ( %XXXXXXXX -- ) 8 lshift NVIC-IPR6 bis! ;  \ NVIC-IPR6_IPR_N1    IPR_N1
: NVIC-IPR6_IPR_N2   ( %XXXXXXXX -- ) 16 lshift NVIC-IPR6 bis! ;  \ NVIC-IPR6_IPR_N2    IPR_N2
: NVIC-IPR6_IPR_N3   ( %XXXXXXXX -- ) 24 lshift NVIC-IPR6 bis! ;  \ NVIC-IPR6_IPR_N3    IPR_N3

\ NVIC-IPR7 (read-write)
: NVIC-IPR7_IPR_N0   ( %XXXXXXXX -- ) 0 lshift NVIC-IPR7 bis! ;  \ NVIC-IPR7_IPR_N0    IPR_N0
: NVIC-IPR7_IPR_N1   ( %XXXXXXXX -- ) 8 lshift NVIC-IPR7 bis! ;  \ NVIC-IPR7_IPR_N1    IPR_N1
: NVIC-IPR7_IPR_N2   ( %XXXXXXXX -- ) 16 lshift NVIC-IPR7 bis! ;  \ NVIC-IPR7_IPR_N2    IPR_N2
: NVIC-IPR7_IPR_N3   ( %XXXXXXXX -- ) 24 lshift NVIC-IPR7 bis! ;  \ NVIC-IPR7_IPR_N3    IPR_N3

\ NVIC-IPR8 (read-write)
: NVIC-IPR8_IPR_N0   ( %XXXXXXXX -- ) 0 lshift NVIC-IPR8 bis! ;  \ NVIC-IPR8_IPR_N0    IPR_N0
: NVIC-IPR8_IPR_N1   ( %XXXXXXXX -- ) 8 lshift NVIC-IPR8 bis! ;  \ NVIC-IPR8_IPR_N1    IPR_N1
: NVIC-IPR8_IPR_N2   ( %XXXXXXXX -- ) 16 lshift NVIC-IPR8 bis! ;  \ NVIC-IPR8_IPR_N2    IPR_N2
: NVIC-IPR8_IPR_N3   ( %XXXXXXXX -- ) 24 lshift NVIC-IPR8 bis! ;  \ NVIC-IPR8_IPR_N3    IPR_N3

\ NVIC-IPR9 (read-write)
: NVIC-IPR9_IPR_N0   ( %XXXXXXXX -- ) 0 lshift NVIC-IPR9 bis! ;  \ NVIC-IPR9_IPR_N0    IPR_N0
: NVIC-IPR9_IPR_N1   ( %XXXXXXXX -- ) 8 lshift NVIC-IPR9 bis! ;  \ NVIC-IPR9_IPR_N1    IPR_N1
: NVIC-IPR9_IPR_N2   ( %XXXXXXXX -- ) 16 lshift NVIC-IPR9 bis! ;  \ NVIC-IPR9_IPR_N2    IPR_N2
: NVIC-IPR9_IPR_N3   ( %XXXXXXXX -- ) 24 lshift NVIC-IPR9 bis! ;  \ NVIC-IPR9_IPR_N3    IPR_N3

\ NVIC-IPR10 (read-write)
: NVIC-IPR10_IPR_N0   ( %XXXXXXXX -- ) 0 lshift NVIC-IPR10 bis! ;  \ NVIC-IPR10_IPR_N0    IPR_N0
: NVIC-IPR10_IPR_N1   ( %XXXXXXXX -- ) 8 lshift NVIC-IPR10 bis! ;  \ NVIC-IPR10_IPR_N1    IPR_N1
: NVIC-IPR10_IPR_N2   ( %XXXXXXXX -- ) 16 lshift NVIC-IPR10 bis! ;  \ NVIC-IPR10_IPR_N2    IPR_N2
: NVIC-IPR10_IPR_N3   ( %XXXXXXXX -- ) 24 lshift NVIC-IPR10 bis! ;  \ NVIC-IPR10_IPR_N3    IPR_N3

\ NVIC-IPR11 (read-write)
: NVIC-IPR11_IPR_N0   ( %XXXXXXXX -- ) 0 lshift NVIC-IPR11 bis! ;  \ NVIC-IPR11_IPR_N0    IPR_N0
: NVIC-IPR11_IPR_N1   ( %XXXXXXXX -- ) 8 lshift NVIC-IPR11 bis! ;  \ NVIC-IPR11_IPR_N1    IPR_N1
: NVIC-IPR11_IPR_N2   ( %XXXXXXXX -- ) 16 lshift NVIC-IPR11 bis! ;  \ NVIC-IPR11_IPR_N2    IPR_N2
: NVIC-IPR11_IPR_N3   ( %XXXXXXXX -- ) 24 lshift NVIC-IPR11 bis! ;  \ NVIC-IPR11_IPR_N3    IPR_N3

\ NVIC-IPR12 (read-write)
: NVIC-IPR12_IPR_N0   ( %XXXXXXXX -- ) 0 lshift NVIC-IPR12 bis! ;  \ NVIC-IPR12_IPR_N0    IPR_N0
: NVIC-IPR12_IPR_N1   ( %XXXXXXXX -- ) 8 lshift NVIC-IPR12 bis! ;  \ NVIC-IPR12_IPR_N1    IPR_N1
: NVIC-IPR12_IPR_N2   ( %XXXXXXXX -- ) 16 lshift NVIC-IPR12 bis! ;  \ NVIC-IPR12_IPR_N2    IPR_N2
: NVIC-IPR12_IPR_N3   ( %XXXXXXXX -- ) 24 lshift NVIC-IPR12 bis! ;  \ NVIC-IPR12_IPR_N3    IPR_N3

\ NVIC-IPR13 (read-write)
: NVIC-IPR13_IPR_N0   ( %XXXXXXXX -- ) 0 lshift NVIC-IPR13 bis! ;  \ NVIC-IPR13_IPR_N0    IPR_N0
: NVIC-IPR13_IPR_N1   ( %XXXXXXXX -- ) 8 lshift NVIC-IPR13 bis! ;  \ NVIC-IPR13_IPR_N1    IPR_N1
: NVIC-IPR13_IPR_N2   ( %XXXXXXXX -- ) 16 lshift NVIC-IPR13 bis! ;  \ NVIC-IPR13_IPR_N2    IPR_N2
: NVIC-IPR13_IPR_N3   ( %XXXXXXXX -- ) 24 lshift NVIC-IPR13 bis! ;  \ NVIC-IPR13_IPR_N3    IPR_N3

\ NVIC-IPR14 (read-write)
: NVIC-IPR14_IPR_N0   ( %XXXXXXXX -- ) 0 lshift NVIC-IPR14 bis! ;  \ NVIC-IPR14_IPR_N0    IPR_N0
: NVIC-IPR14_IPR_N1   ( %XXXXXXXX -- ) 8 lshift NVIC-IPR14 bis! ;  \ NVIC-IPR14_IPR_N1    IPR_N1
: NVIC-IPR14_IPR_N2   ( %XXXXXXXX -- ) 16 lshift NVIC-IPR14 bis! ;  \ NVIC-IPR14_IPR_N2    IPR_N2
: NVIC-IPR14_IPR_N3   ( %XXXXXXXX -- ) 24 lshift NVIC-IPR14 bis! ;  \ NVIC-IPR14_IPR_N3    IPR_N3

\ NVIC-IPR15 (read-write)
: NVIC-IPR15_IPR_N0   ( %XXXXXXXX -- ) 0 lshift NVIC-IPR15 bis! ;  \ NVIC-IPR15_IPR_N0    IPR_N0
: NVIC-IPR15_IPR_N1   ( %XXXXXXXX -- ) 8 lshift NVIC-IPR15 bis! ;  \ NVIC-IPR15_IPR_N1    IPR_N1
: NVIC-IPR15_IPR_N2   ( %XXXXXXXX -- ) 16 lshift NVIC-IPR15 bis! ;  \ NVIC-IPR15_IPR_N2    IPR_N2
: NVIC-IPR15_IPR_N3   ( %XXXXXXXX -- ) 24 lshift NVIC-IPR15 bis! ;  \ NVIC-IPR15_IPR_N3    IPR_N3

\ NVIC-IPR16 (read-write)
: NVIC-IPR16_IPR_N0   ( %XXXXXXXX -- ) 0 lshift NVIC-IPR16 bis! ;  \ NVIC-IPR16_IPR_N0    IPR_N0
: NVIC-IPR16_IPR_N1   ( %XXXXXXXX -- ) 8 lshift NVIC-IPR16 bis! ;  \ NVIC-IPR16_IPR_N1    IPR_N1
: NVIC-IPR16_IPR_N2   ( %XXXXXXXX -- ) 16 lshift NVIC-IPR16 bis! ;  \ NVIC-IPR16_IPR_N2    IPR_N2
: NVIC-IPR16_IPR_N3   ( %XXXXXXXX -- ) 24 lshift NVIC-IPR16 bis! ;  \ NVIC-IPR16_IPR_N3    IPR_N3

\ NVIC-IPR17 (read-write)
: NVIC-IPR17_IPR_N0   ( %XXXXXXXX -- ) 0 lshift NVIC-IPR17 bis! ;  \ NVIC-IPR17_IPR_N0    IPR_N0
: NVIC-IPR17_IPR_N1   ( %XXXXXXXX -- ) 8 lshift NVIC-IPR17 bis! ;  \ NVIC-IPR17_IPR_N1    IPR_N1
: NVIC-IPR17_IPR_N2   ( %XXXXXXXX -- ) 16 lshift NVIC-IPR17 bis! ;  \ NVIC-IPR17_IPR_N2    IPR_N2
: NVIC-IPR17_IPR_N3   ( %XXXXXXXX -- ) 24 lshift NVIC-IPR17 bis! ;  \ NVIC-IPR17_IPR_N3    IPR_N3

\ NVIC_STIR-STIR (read-write)
: NVIC_STIR-STIR_INTID   ( %XXXXXXXXX -- ) 0 lshift NVIC_STIR-STIR bis! ;  \ NVIC_STIR-STIR_INTID    Software generated interrupt ID

\ PWR-CR1 (read-write)
: PWR-CR1_LPR   %1 14 lshift PWR-CR1 bis! ;  \ PWR-CR1_LPR    Low-power run
: PWR-CR1_VOS   ( %XX -- ) 9 lshift PWR-CR1 bis! ;  \ PWR-CR1_VOS    Voltage scaling range selection
: PWR-CR1_DBP   %1 8 lshift PWR-CR1 bis! ;  \ PWR-CR1_DBP    Disable backup domain write protection
: PWR-CR1_FPDS   %1 5 lshift PWR-CR1 bis! ;  \ PWR-CR1_FPDS    Flash memory power down mode during LPSleep for CPU1
: PWR-CR1_FPDR   %1 4 lshift PWR-CR1 bis! ;  \ PWR-CR1_FPDR    Flash memory power down mode during LPRun for CPU1
: PWR-CR1_SUBGHZSPINSSSEL   %1 3 lshift PWR-CR1 bis! ;  \ PWR-CR1_SUBGHZSPINSSSEL    sub-GHz SPI NSS source select
: PWR-CR1_LPMS   ( %XXX -- ) 0 lshift PWR-CR1 bis! ;  \ PWR-CR1_LPMS    Low-power mode selection for CPU1

\ PWR-CR2 (read-write)
: PWR-CR2_PVME3   %1 6 lshift PWR-CR2 bis! ;  \ PWR-CR2_PVME3    Peripheral voltage monitoring 3 enable: VDDA vs. 1.62V
: PWR-CR2_PLS   ( %XXX -- ) 1 lshift PWR-CR2 bis! ;  \ PWR-CR2_PLS    Power voltage detector level selection.
: PWR-CR2_PVDE   %1 0 lshift PWR-CR2 bis! ;  \ PWR-CR2_PVDE    Power voltage detector enable

\ PWR-CR3 (read-write)
: PWR-CR3_EIWUL   %1 15 lshift PWR-CR3 bis! ;  \ PWR-CR3_EIWUL    Enable internal wakeup line for CPU1
: PWR-CR3_EWRFIRQ   %1 13 lshift PWR-CR3 bis! ;  \ PWR-CR3_EWRFIRQ    akeup for CPU1
: PWR-CR3_EWRFBUSY   %1 11 lshift PWR-CR3 bis! ;  \ PWR-CR3_EWRFBUSY    Enable Radio BUSY Wakeup from Standby for CPU1
: PWR-CR3_APC   %1 10 lshift PWR-CR3 bis! ;  \ PWR-CR3_APC    Apply pull-up and pull-down configuration from CPU1
: PWR-CR3_RRS   %1 9 lshift PWR-CR3 bis! ;  \ PWR-CR3_RRS    SRAM2 retention in Standby mode
: PWR-CR3_EWPVD   %1 8 lshift PWR-CR3 bis! ;  \ PWR-CR3_EWPVD    Enable wakeup PVD for CPU1
: PWR-CR3_EULPEN   %1 7 lshift PWR-CR3 bis! ;  \ PWR-CR3_EULPEN    Ultra-low-power enable
: PWR-CR3_EWUP3   %1 2 lshift PWR-CR3 bis! ;  \ PWR-CR3_EWUP3    Enable Wakeup pin WKUP3 for CPU1
: PWR-CR3_EWUP2   %1 1 lshift PWR-CR3 bis! ;  \ PWR-CR3_EWUP2    Enable Wakeup pin WKUP2 for CPU1
: PWR-CR3_EWUP1   %1 0 lshift PWR-CR3 bis! ;  \ PWR-CR3_EWUP1    Enable Wakeup pin WKUP1 for CPU1

\ PWR-CR4 (read-write)
: PWR-CR4_WRFBUSYP   %1 11 lshift PWR-CR4 bis! ;  \ PWR-CR4_WRFBUSYP    Wakeup Radio BUSY polarity
: PWR-CR4_VBRS   %1 9 lshift PWR-CR4 bis! ;  \ PWR-CR4_VBRS    VBAT battery charging resistor selection
: PWR-CR4_VBE   %1 8 lshift PWR-CR4 bis! ;  \ PWR-CR4_VBE    VBAT battery charging enable
: PWR-CR4_WP3   %1 2 lshift PWR-CR4 bis! ;  \ PWR-CR4_WP3    Wakeup pin WKUP3 polarity
: PWR-CR4_WP2   %1 1 lshift PWR-CR4 bis! ;  \ PWR-CR4_WP2    Wakeup pin WKUP2 polarity
: PWR-CR4_WP1   %1 0 lshift PWR-CR4 bis! ;  \ PWR-CR4_WP1    Wakeup pin WKUP1 polarity

\ PWR-SR1 (read-only)
: PWR-SR1_WUFI   %1 15 lshift PWR-SR1 bis! ;  \ PWR-SR1_WUFI    Internal wakeup interrupt flag
: PWR-SR1_WRFBUSYF   %1 11 lshift PWR-SR1 bis! ;  \ PWR-SR1_WRFBUSYF    Radio BUSY wakeup flag
: PWR-SR1_WPVDF   %1 8 lshift PWR-SR1 bis! ;  \ PWR-SR1_WPVDF    Wakeup PVD flag
: PWR-SR1_WUF3   %1 2 lshift PWR-SR1 bis! ;  \ PWR-SR1_WUF3    Wakeup flag 3
: PWR-SR1_WUF2   %1 1 lshift PWR-SR1 bis! ;  \ PWR-SR1_WUF2    Wakeup flag 2
: PWR-SR1_WUF1   %1 0 lshift PWR-SR1 bis! ;  \ PWR-SR1_WUF1    Wakeup flag 1

\ PWR-SR2 (read-only)
: PWR-SR2_PVMO3   %1 14 lshift PWR-SR2 bis! ;  \ PWR-SR2_PVMO3    Peripheral voltage monitoring output: VDDA vs. 1.62 V
: PWR-SR2_PVDO   %1 11 lshift PWR-SR2 bis! ;  \ PWR-SR2_PVDO    Power voltage detector output
: PWR-SR2_VOSF   %1 10 lshift PWR-SR2 bis! ;  \ PWR-SR2_VOSF    Voltage scaling flag
: PWR-SR2_REGLPF   %1 9 lshift PWR-SR2 bis! ;  \ PWR-SR2_REGLPF    regulator1 low power flag
: PWR-SR2_REGLPS   %1 8 lshift PWR-SR2 bis! ;  \ PWR-SR2_REGLPS    regulator1 started
: PWR-SR2_FLASHRDY   %1 7 lshift PWR-SR2 bis! ;  \ PWR-SR2_FLASHRDY    Flash ready
: PWR-SR2_REGMRS   %1 6 lshift PWR-SR2 bis! ;  \ PWR-SR2_REGMRS    regulator2 low power flag
: PWR-SR2_RFEOLF   %1 5 lshift PWR-SR2 bis! ;  \ PWR-SR2_RFEOLF    Radio end of life flag
: PWR-SR2_LDORDY   %1 4 lshift PWR-SR2 bis! ;  \ PWR-SR2_LDORDY    LDO ready flag
: PWR-SR2_SMPSRDY   %1 3 lshift PWR-SR2 bis! ;  \ PWR-SR2_SMPSRDY    SMPS ready flag
: PWR-SR2_RFBUSYMS   %1 2 lshift PWR-SR2 bis! ;  \ PWR-SR2_RFBUSYMS    Radio BUSY masked signal status
: PWR-SR2_RFBUSYS   %1 1 lshift PWR-SR2 bis! ;  \ PWR-SR2_RFBUSYS    Radio BUSY signal status

\ PWR-SCR (write-only)
: PWR-SCR_CWRFBUSYF   %1 11 lshift PWR-SCR bis! ;  \ PWR-SCR_CWRFBUSYF    Clear wakeup Radio BUSY flag
: PWR-SCR_CWPVDF   %1 8 lshift PWR-SCR bis! ;  \ PWR-SCR_CWPVDF    Clear wakeup PVD interrupt flag
: PWR-SCR_CWUF3   %1 2 lshift PWR-SCR bis! ;  \ PWR-SCR_CWUF3    Clear wakeup flag 3
: PWR-SCR_CWUF2   %1 1 lshift PWR-SCR bis! ;  \ PWR-SCR_CWUF2    Clear wakeup flag 2
: PWR-SCR_CWUF1   %1 0 lshift PWR-SCR bis! ;  \ PWR-SCR_CWUF1    Clear wakeup flag 1

\ PWR-CR5 (read-write)
: PWR-CR5_SMPSEN   %1 15 lshift PWR-CR5 bis! ;  \ PWR-CR5_SMPSEN    Enable SMPS Step Down converter SMPS mode enabled.
: PWR-CR5_RFEOLEN   %1 14 lshift PWR-CR5 bis! ;  \ PWR-CR5_RFEOLEN    Enable Radio End Of Life detector enabled

\ PWR-PUCRA (read-write)
: PWR-PUCRA_PU15   %1 15 lshift PWR-PUCRA bis! ;  \ PWR-PUCRA_PU15    Port PA15 pull-up
: PWR-PUCRA_PU14   %1 14 lshift PWR-PUCRA bis! ;  \ PWR-PUCRA_PU14    PU14
: PWR-PUCRA_PU13   %1 13 lshift PWR-PUCRA bis! ;  \ PWR-PUCRA_PU13    Port PA[y] pull-up bit y y=0 to 13
: PWR-PUCRA_PU12   %1 12 lshift PWR-PUCRA bis! ;  \ PWR-PUCRA_PU12    PU12
: PWR-PUCRA_PU11   %1 11 lshift PWR-PUCRA bis! ;  \ PWR-PUCRA_PU11    PU11
: PWR-PUCRA_PU10   %1 10 lshift PWR-PUCRA bis! ;  \ PWR-PUCRA_PU10    PU10
: PWR-PUCRA_PU9   %1 9 lshift PWR-PUCRA bis! ;  \ PWR-PUCRA_PU9    PU9
: PWR-PUCRA_PU8   %1 8 lshift PWR-PUCRA bis! ;  \ PWR-PUCRA_PU8    PU8
: PWR-PUCRA_PU7   %1 7 lshift PWR-PUCRA bis! ;  \ PWR-PUCRA_PU7    PU7
: PWR-PUCRA_PU6   %1 6 lshift PWR-PUCRA bis! ;  \ PWR-PUCRA_PU6    PU6
: PWR-PUCRA_PU5   %1 5 lshift PWR-PUCRA bis! ;  \ PWR-PUCRA_PU5    PU5
: PWR-PUCRA_PU4   %1 4 lshift PWR-PUCRA bis! ;  \ PWR-PUCRA_PU4    PU4
: PWR-PUCRA_PU3   %1 3 lshift PWR-PUCRA bis! ;  \ PWR-PUCRA_PU3    PU3
: PWR-PUCRA_PU2   %1 2 lshift PWR-PUCRA bis! ;  \ PWR-PUCRA_PU2    PU2
: PWR-PUCRA_PU1   %1 1 lshift PWR-PUCRA bis! ;  \ PWR-PUCRA_PU1    PU1
: PWR-PUCRA_PU0   %1 0 lshift PWR-PUCRA bis! ;  \ PWR-PUCRA_PU0    PU0

\ PWR-PDCRA (read-write)
: PWR-PDCRA_PD15   %1 15 lshift PWR-PDCRA bis! ;  \ PWR-PDCRA_PD15    PD15
: PWR-PDCRA_PD14   %1 14 lshift PWR-PDCRA bis! ;  \ PWR-PDCRA_PD14    ull-down
: PWR-PDCRA_PD13   %1 13 lshift PWR-PDCRA bis! ;  \ PWR-PDCRA_PD13    PD13
: PWR-PDCRA_PD12   %1 12 lshift PWR-PDCRA bis! ;  \ PWR-PDCRA_PD12    Port PA[y] pull-down y=0 to 12
: PWR-PDCRA_PD11   %1 11 lshift PWR-PDCRA bis! ;  \ PWR-PDCRA_PD11    PD11
: PWR-PDCRA_PD10   %1 10 lshift PWR-PDCRA bis! ;  \ PWR-PDCRA_PD10    PD10
: PWR-PDCRA_PD9   %1 9 lshift PWR-PDCRA bis! ;  \ PWR-PDCRA_PD9    PD9
: PWR-PDCRA_PD8   %1 8 lshift PWR-PDCRA bis! ;  \ PWR-PDCRA_PD8    PD8
: PWR-PDCRA_PD7   %1 7 lshift PWR-PDCRA bis! ;  \ PWR-PDCRA_PD7    PD7
: PWR-PDCRA_PD6   %1 6 lshift PWR-PDCRA bis! ;  \ PWR-PDCRA_PD6    PD6
: PWR-PDCRA_PD5   %1 5 lshift PWR-PDCRA bis! ;  \ PWR-PDCRA_PD5    PD5
: PWR-PDCRA_PD4   %1 4 lshift PWR-PDCRA bis! ;  \ PWR-PDCRA_PD4    PD4
: PWR-PDCRA_PD3   %1 3 lshift PWR-PDCRA bis! ;  \ PWR-PDCRA_PD3    PD3
: PWR-PDCRA_PD2   %1 2 lshift PWR-PDCRA bis! ;  \ PWR-PDCRA_PD2    PD2
: PWR-PDCRA_PD1   %1 1 lshift PWR-PDCRA bis! ;  \ PWR-PDCRA_PD1    PD1
: PWR-PDCRA_PD0   %1 0 lshift PWR-PDCRA bis! ;  \ PWR-PDCRA_PD0    PD0

\ PWR-PUCRB (read-write)
: PWR-PUCRB_PU15   %1 15 lshift PWR-PUCRB bis! ;  \ PWR-PUCRB_PU15    Port PB[y] pull-up y=0 to 15
: PWR-PUCRB_PU14   %1 14 lshift PWR-PUCRB bis! ;  \ PWR-PUCRB_PU14    PU14
: PWR-PUCRB_PU13   %1 13 lshift PWR-PUCRB bis! ;  \ PWR-PUCRB_PU13    PU13
: PWR-PUCRB_PU12   %1 12 lshift PWR-PUCRB bis! ;  \ PWR-PUCRB_PU12    PU12
: PWR-PUCRB_PU11   %1 11 lshift PWR-PUCRB bis! ;  \ PWR-PUCRB_PU11    PU11
: PWR-PUCRB_PU10   %1 10 lshift PWR-PUCRB bis! ;  \ PWR-PUCRB_PU10    PU10
: PWR-PUCRB_PU9   %1 9 lshift PWR-PUCRB bis! ;  \ PWR-PUCRB_PU9    PU9
: PWR-PUCRB_PU8   %1 8 lshift PWR-PUCRB bis! ;  \ PWR-PUCRB_PU8    PU8
: PWR-PUCRB_PU7   %1 7 lshift PWR-PUCRB bis! ;  \ PWR-PUCRB_PU7    PU7
: PWR-PUCRB_PU6   %1 6 lshift PWR-PUCRB bis! ;  \ PWR-PUCRB_PU6    PU6
: PWR-PUCRB_PU5   %1 5 lshift PWR-PUCRB bis! ;  \ PWR-PUCRB_PU5    PU5
: PWR-PUCRB_PU4   %1 4 lshift PWR-PUCRB bis! ;  \ PWR-PUCRB_PU4    PU4
: PWR-PUCRB_PU3   %1 3 lshift PWR-PUCRB bis! ;  \ PWR-PUCRB_PU3    PU3
: PWR-PUCRB_PU2   %1 2 lshift PWR-PUCRB bis! ;  \ PWR-PUCRB_PU2    PU2
: PWR-PUCRB_PU1   %1 1 lshift PWR-PUCRB bis! ;  \ PWR-PUCRB_PU1    PU1
: PWR-PUCRB_PU0   %1 0 lshift PWR-PUCRB bis! ;  \ PWR-PUCRB_PU0    PU0

\ PWR-PDCRB (read-write)
: PWR-PDCRB_PD15   %1 15 lshift PWR-PDCRB bis! ;  \ PWR-PDCRB_PD15    Port PB[y] pull-down y=5 to 15
: PWR-PDCRB_PD14   %1 14 lshift PWR-PDCRB bis! ;  \ PWR-PDCRB_PD14    PD14
: PWR-PDCRB_PD13   %1 13 lshift PWR-PDCRB bis! ;  \ PWR-PDCRB_PD13    PD13
: PWR-PDCRB_PD12   %1 12 lshift PWR-PDCRB bis! ;  \ PWR-PDCRB_PD12    PD12
: PWR-PDCRB_PD11   %1 11 lshift PWR-PDCRB bis! ;  \ PWR-PDCRB_PD11    PD11
: PWR-PDCRB_PD10   %1 10 lshift PWR-PDCRB bis! ;  \ PWR-PDCRB_PD10    PD10
: PWR-PDCRB_PD9   %1 9 lshift PWR-PDCRB bis! ;  \ PWR-PDCRB_PD9    PD9
: PWR-PDCRB_PD8   %1 8 lshift PWR-PDCRB bis! ;  \ PWR-PDCRB_PD8    PD8
: PWR-PDCRB_PD7   %1 7 lshift PWR-PDCRB bis! ;  \ PWR-PDCRB_PD7    PD7
: PWR-PDCRB_PD6   %1 6 lshift PWR-PDCRB bis! ;  \ PWR-PDCRB_PD6    PD6
: PWR-PDCRB_PD5   %1 5 lshift PWR-PDCRB bis! ;  \ PWR-PDCRB_PD5    PD5
: PWR-PDCRB_PD4   %1 4 lshift PWR-PDCRB bis! ;  \ PWR-PDCRB_PD4    PD4
: PWR-PDCRB_PD3   %1 3 lshift PWR-PDCRB bis! ;  \ PWR-PDCRB_PD3    Port PB[y] pull-down y=0 to 3
: PWR-PDCRB_PD2   %1 2 lshift PWR-PDCRB bis! ;  \ PWR-PDCRB_PD2    PD2
: PWR-PDCRB_PD1   %1 1 lshift PWR-PDCRB bis! ;  \ PWR-PDCRB_PD1    PD1
: PWR-PDCRB_PD0   %1 0 lshift PWR-PDCRB bis! ;  \ PWR-PDCRB_PD0    PD0

\ PWR-PUCRC (read-write)
: PWR-PUCRC_PU15   %1 15 lshift PWR-PUCRC bis! ;  \ PWR-PUCRC_PU15    Port PC[y] pull-up y=13 to 15
: PWR-PUCRC_PU14   %1 14 lshift PWR-PUCRC bis! ;  \ PWR-PUCRC_PU14    PU14
: PWR-PUCRC_PU13   %1 13 lshift PWR-PUCRC bis! ;  \ PWR-PUCRC_PU13    PU13
: PWR-PUCRC_PU2   %1 2 lshift PWR-PUCRC bis! ;  \ PWR-PUCRC_PU2    PU2
: PWR-PUCRC_PU1   %1 1 lshift PWR-PUCRC bis! ;  \ PWR-PUCRC_PU1    PU1
: PWR-PUCRC_PU0   %1 0 lshift PWR-PUCRC bis! ;  \ PWR-PUCRC_PU0    PU0
: PWR-PUCRC_PU3   %1 3 lshift PWR-PUCRC bis! ;  \ PWR-PUCRC_PU3    PU3
: PWR-PUCRC_PU4   %1 4 lshift PWR-PUCRC bis! ;  \ PWR-PUCRC_PU4    PU4
: PWR-PUCRC_PU5   %1 5 lshift PWR-PUCRC bis! ;  \ PWR-PUCRC_PU5    PU5
: PWR-PUCRC_PU6   %1 6 lshift PWR-PUCRC bis! ;  \ PWR-PUCRC_PU6    PU6

\ PWR-PDCRC (read-write)
: PWR-PDCRC_PD15   %1 15 lshift PWR-PDCRC bis! ;  \ PWR-PDCRC_PD15    Port PC[y] pull-down y=13 to 15
: PWR-PDCRC_PD14   %1 14 lshift PWR-PDCRC bis! ;  \ PWR-PDCRC_PD14    PD14
: PWR-PDCRC_PD13   %1 13 lshift PWR-PDCRC bis! ;  \ PWR-PDCRC_PD13    PD13
: PWR-PDCRC_PD2   %1 2 lshift PWR-PDCRC bis! ;  \ PWR-PDCRC_PD2    PD2
: PWR-PDCRC_PD1   %1 1 lshift PWR-PDCRC bis! ;  \ PWR-PDCRC_PD1    PD1
: PWR-PDCRC_PD0   %1 0 lshift PWR-PDCRC bis! ;  \ PWR-PDCRC_PD0    PD0
: PWR-PDCRC_PD3   %1 3 lshift PWR-PDCRC bis! ;  \ PWR-PDCRC_PD3    PD3
: PWR-PDCRC_PD4   %1 4 lshift PWR-PDCRC bis! ;  \ PWR-PDCRC_PD4    PD4
: PWR-PDCRC_PD5   %1 5 lshift PWR-PDCRC bis! ;  \ PWR-PDCRC_PD5    PD5
: PWR-PDCRC_PD6   %1 6 lshift PWR-PDCRC bis! ;  \ PWR-PDCRC_PD6    PD6

\ PWR-PUCRH (read-write)
: PWR-PUCRH_PU3   %1 3 lshift PWR-PUCRH bis! ;  \ PWR-PUCRH_PU3    pull-up

\ PWR-PDCRH (read-write)
: PWR-PDCRH_PD3   %1 3 lshift PWR-PDCRH bis! ;  \ PWR-PDCRH_PD3    pull-down

\ PWR-EXTSCR ()
: PWR-EXTSCR_C1DS   %1 14 lshift PWR-EXTSCR bis! ;  \ PWR-EXTSCR_C1DS    CPU1 deepsleep mode
: PWR-EXTSCR_C1STOPF   %1 10 lshift PWR-EXTSCR bis! ;  \ PWR-EXTSCR_C1STOPF    System Stop0, 1 flag for CPU1. All core states retained
: PWR-EXTSCR_C1STOP2F   %1 9 lshift PWR-EXTSCR bis! ;  \ PWR-EXTSCR_C1STOP2F    System Stop2 flag for CPU1. partial core states retained
: PWR-EXTSCR_C1SBF   %1 8 lshift PWR-EXTSCR bis! ;  \ PWR-EXTSCR_C1SBF    System Standby flag for CPU1. no core states retained
: PWR-EXTSCR_C1CSSF   %1 0 lshift PWR-EXTSCR bis! ;  \ PWR-EXTSCR_C1CSSF    Clear CPU1 Stop Standby flags

\ PWR-SUBGHZSPICR (read-write)
: PWR-SUBGHZSPICR_NSS   %1 15 lshift PWR-SUBGHZSPICR bis! ;  \ PWR-SUBGHZSPICR_NSS    sub-GHz SPI NSS control

\ RCC-CR ()
: RCC-CR_PLLRDY   %1 25 lshift RCC-CR bis! ;  \ RCC-CR_PLLRDY    Main PLL clock ready flag
: RCC-CR_PLLON   %1 24 lshift RCC-CR bis! ;  \ RCC-CR_PLLON    Main PLL enable
: RCC-CR_HSEBYPPWR   %1 21 lshift RCC-CR bis! ;  \ RCC-CR_HSEBYPPWR    Enable HSE32 VDDTCXO output on package pin PB0-VDDTCXO.
: RCC-CR_HSEPRE   %1 20 lshift RCC-CR bis! ;  \ RCC-CR_HSEPRE    HSE32 sysclk prescaler
: RCC-CR_CSSON   %1 19 lshift RCC-CR bis! ;  \ RCC-CR_CSSON    HSE32 Clock security system enable
: RCC-CR_HSERDY   %1 17 lshift RCC-CR bis! ;  \ RCC-CR_HSERDY    HSE32 clock ready flag
: RCC-CR_HSEON   %1 16 lshift RCC-CR bis! ;  \ RCC-CR_HSEON    HSE32 clock enable
: RCC-CR_HSIKERDY   %1 12 lshift RCC-CR bis! ;  \ RCC-CR_HSIKERDY    HSI16 kernel clock ready flag for peripherals requests.
: RCC-CR_HSIASFS   %1 11 lshift RCC-CR bis! ;  \ RCC-CR_HSIASFS    HSI16 automatic start from Stop
: RCC-CR_HSIRDY   %1 10 lshift RCC-CR bis! ;  \ RCC-CR_HSIRDY    HSI16 clock ready flag. After wakeup from Stop this bit will be read 1 once the HSI16 is ready
: RCC-CR_HSIKERON   %1 9 lshift RCC-CR bis! ;  \ RCC-CR_HSIKERON    HSI16 always enable for peripheral kernel clocks.
: RCC-CR_HSION   %1 8 lshift RCC-CR bis! ;  \ RCC-CR_HSION    HSI16 clock enable
: RCC-CR_MSIRANGE   ( %XXXX -- ) 4 lshift RCC-CR bis! ;  \ RCC-CR_MSIRANGE    MSI clock ranges
: RCC-CR_MSIRGSEL   %1 3 lshift RCC-CR bis! ;  \ RCC-CR_MSIRGSEL    MSI range control selection
: RCC-CR_MSIPLLEN   %1 2 lshift RCC-CR bis! ;  \ RCC-CR_MSIPLLEN    MSI clock PLL enable
: RCC-CR_MSIRDY   %1 1 lshift RCC-CR bis! ;  \ RCC-CR_MSIRDY    MSI clock ready flag After reset this bit will be read 1 once the MSI is ready
: RCC-CR_MSION   %1 0 lshift RCC-CR bis! ;  \ RCC-CR_MSION    MSI clock enable

\ RCC-ICSCR ()
: RCC-ICSCR_HSITRIM   ( %XXXXXXX -- ) 24 lshift RCC-ICSCR bis! ;  \ RCC-ICSCR_HSITRIM    HSI16 clock trimming
: RCC-ICSCR_HSICAL   ( %XXXXXXXX -- ) 16 lshift RCC-ICSCR bis! ;  \ RCC-ICSCR_HSICAL    HSI16 clock calibration
: RCC-ICSCR_MSITRIM   ( %XXXXXXXX -- ) 8 lshift RCC-ICSCR bis! ;  \ RCC-ICSCR_MSITRIM    MSI clock trimming
: RCC-ICSCR_MSICAL   ( %XXXXXXXX -- ) 0 lshift RCC-ICSCR bis! ;  \ RCC-ICSCR_MSICAL    MSI clock calibration

\ RCC-CFGR ()
: RCC-CFGR_MCOPRE   ( %XXX -- ) 28 lshift RCC-CFGR bis! ;  \ RCC-CFGR_MCOPRE    Microcontroller clock output prescaler
: RCC-CFGR_MCOSEL   ( %XXXX -- ) 24 lshift RCC-CFGR bis! ;  \ RCC-CFGR_MCOSEL    Microcontroller clock output
: RCC-CFGR_PPRE2F   %1 18 lshift RCC-CFGR bis! ;  \ RCC-CFGR_PPRE2F    PCLK2 prescaler flag APB2
: RCC-CFGR_PPRE1F   %1 17 lshift RCC-CFGR bis! ;  \ RCC-CFGR_PPRE1F    PCLK1 prescaler flag APB1
: RCC-CFGR_HPREF   %1 16 lshift RCC-CFGR bis! ;  \ RCC-CFGR_HPREF    HCLK1 prescaler flag CPU1, AHB1, AHB2, and SRAM1
: RCC-CFGR_STOPWUCK   %1 15 lshift RCC-CFGR bis! ;  \ RCC-CFGR_STOPWUCK    Wakeup from Stop and CSS backup clock selection
: RCC-CFGR_PPRE2   ( %XXX -- ) 11 lshift RCC-CFGR bis! ;  \ RCC-CFGR_PPRE2    PCLK2 high-speed prescaler APB2
: RCC-CFGR_PPRE1   ( %XXX -- ) 8 lshift RCC-CFGR bis! ;  \ RCC-CFGR_PPRE1    PCLK1 low-speed prescaler APB1
: RCC-CFGR_HPRE   ( %XXXX -- ) 4 lshift RCC-CFGR bis! ;  \ RCC-CFGR_HPRE    HCLK1 prescaler CPU1, AHB1, AHB2, and SRAM1.
: RCC-CFGR_SWS   ( %XX -- ) 2 lshift RCC-CFGR bis! ;  \ RCC-CFGR_SWS    System clock switch status
: RCC-CFGR_SW   ( %XX -- ) 0 lshift RCC-CFGR bis! ;  \ RCC-CFGR_SW    System clock switch

\ RCC-PLLCFGR (read-write)
: RCC-PLLCFGR_PLLR   ( %XXX -- ) 29 lshift RCC-PLLCFGR bis! ;  \ RCC-PLLCFGR_PLLR    Main PLL division factor for PLLRCLK
: RCC-PLLCFGR_PLLREN   %1 28 lshift RCC-PLLCFGR bis! ;  \ RCC-PLLCFGR_PLLREN    Main PLL PLLRCLK output enable
: RCC-PLLCFGR_PLLQ   ( %XXX -- ) 25 lshift RCC-PLLCFGR bis! ;  \ RCC-PLLCFGR_PLLQ    Main PLL division factor for PLLQCLK
: RCC-PLLCFGR_PLLQEN   %1 24 lshift RCC-PLLCFGR bis! ;  \ RCC-PLLCFGR_PLLQEN    Main PLL PLLQCLK output enable
: RCC-PLLCFGR_PLLP   ( %XXXXX -- ) 17 lshift RCC-PLLCFGR bis! ;  \ RCC-PLLCFGR_PLLP    Main PLL division factor for PLLPCLK.
: RCC-PLLCFGR_PLLPEN   %1 16 lshift RCC-PLLCFGR bis! ;  \ RCC-PLLCFGR_PLLPEN    Main PLL PLLPCLK output enable
: RCC-PLLCFGR_PLLN   ( %XXXXXXX -- ) 8 lshift RCC-PLLCFGR bis! ;  \ RCC-PLLCFGR_PLLN    Main PLL multiplication factor for VCO
: RCC-PLLCFGR_PLLM   ( %XXX -- ) 4 lshift RCC-PLLCFGR bis! ;  \ RCC-PLLCFGR_PLLM    Division factor for the main PLL input clock
: RCC-PLLCFGR_PLLSRC   ( %XX -- ) 0 lshift RCC-PLLCFGR bis! ;  \ RCC-PLLCFGR_PLLSRC    Main PLL entry clock source

\ RCC-CIER (read-write)
: RCC-CIER_LSECSSIE   %1 9 lshift RCC-CIER bis! ;  \ RCC-CIER_LSECSSIE    LSE clock security system interrupt enable
: RCC-CIER_PLLRDYIE   %1 5 lshift RCC-CIER bis! ;  \ RCC-CIER_PLLRDYIE    PLL ready interrupt enable
: RCC-CIER_HSERDYIE   %1 4 lshift RCC-CIER bis! ;  \ RCC-CIER_HSERDYIE    HSE32 ready interrupt enable
: RCC-CIER_HSIRDYIE   %1 3 lshift RCC-CIER bis! ;  \ RCC-CIER_HSIRDYIE    HSI16 ready interrupt enable
: RCC-CIER_MSIRDYIE   %1 2 lshift RCC-CIER bis! ;  \ RCC-CIER_MSIRDYIE    MSI ready interrupt enable
: RCC-CIER_LSERDYIE   %1 1 lshift RCC-CIER bis! ;  \ RCC-CIER_LSERDYIE    LSE ready interrupt enable
: RCC-CIER_LSIRDYIE   %1 0 lshift RCC-CIER bis! ;  \ RCC-CIER_LSIRDYIE    LSI ready interrupt enable

\ RCC-CIFR (read-only)
: RCC-CIFR_LSECSSF   %1 9 lshift RCC-CIFR bis! ;  \ RCC-CIFR_LSECSSF    LSE Clock security system interrupt flag
: RCC-CIFR_CSSF   %1 8 lshift RCC-CIFR bis! ;  \ RCC-CIFR_CSSF    HSE32 Clock security system interrupt flag
: RCC-CIFR_PLLRDYF   %1 5 lshift RCC-CIFR bis! ;  \ RCC-CIFR_PLLRDYF    PLL ready interrupt flag
: RCC-CIFR_HSERDYF   %1 4 lshift RCC-CIFR bis! ;  \ RCC-CIFR_HSERDYF    HSE32 ready interrupt flag
: RCC-CIFR_HSIRDYF   %1 3 lshift RCC-CIFR bis! ;  \ RCC-CIFR_HSIRDYF    HSI16 ready interrupt flag
: RCC-CIFR_MSIRDYF   %1 2 lshift RCC-CIFR bis! ;  \ RCC-CIFR_MSIRDYF    MSI ready interrupt flag
: RCC-CIFR_LSERDYF   %1 1 lshift RCC-CIFR bis! ;  \ RCC-CIFR_LSERDYF    LSE ready interrupt flag
: RCC-CIFR_LSIRDYF   %1 0 lshift RCC-CIFR bis! ;  \ RCC-CIFR_LSIRDYF    LSI ready interrupt flag

\ RCC-CICR (write-only)
: RCC-CICR_LSECSSC   %1 9 lshift RCC-CICR bis! ;  \ RCC-CICR_LSECSSC    LSE Clock security system interrupt clear
: RCC-CICR_CSSC   %1 8 lshift RCC-CICR bis! ;  \ RCC-CICR_CSSC    HSE32 Clock security system interrupt clear
: RCC-CICR_PLLRDYC   %1 5 lshift RCC-CICR bis! ;  \ RCC-CICR_PLLRDYC    PLL ready interrupt clear
: RCC-CICR_HSERDYC   %1 4 lshift RCC-CICR bis! ;  \ RCC-CICR_HSERDYC    HSE32 ready interrupt clear
: RCC-CICR_HSIRDYC   %1 3 lshift RCC-CICR bis! ;  \ RCC-CICR_HSIRDYC    HSI16 ready interrupt clear
: RCC-CICR_MSIRDYC   %1 2 lshift RCC-CICR bis! ;  \ RCC-CICR_MSIRDYC    MSI ready interrupt clear
: RCC-CICR_LSERDYC   %1 1 lshift RCC-CICR bis! ;  \ RCC-CICR_LSERDYC    LSE ready interrupt clear
: RCC-CICR_LSIRDYC   %1 0 lshift RCC-CICR bis! ;  \ RCC-CICR_LSIRDYC    LSI ready interrupt clear

\ RCC-AHB1RSTR (read-write)
: RCC-AHB1RSTR_CRCRST   %1 12 lshift RCC-AHB1RSTR bis! ;  \ RCC-AHB1RSTR_CRCRST    CRC reset
: RCC-AHB1RSTR_DMAMUX1RST   %1 2 lshift RCC-AHB1RSTR bis! ;  \ RCC-AHB1RSTR_DMAMUX1RST    DMAMUX1 reset
: RCC-AHB1RSTR_DMA2RST   %1 1 lshift RCC-AHB1RSTR bis! ;  \ RCC-AHB1RSTR_DMA2RST    DMA2 reset
: RCC-AHB1RSTR_DMA1RST   %1 0 lshift RCC-AHB1RSTR bis! ;  \ RCC-AHB1RSTR_DMA1RST    DMA1 reset

\ RCC-AHB2RSTR (read-write)
: RCC-AHB2RSTR_GPIOHRST   %1 7 lshift RCC-AHB2RSTR bis! ;  \ RCC-AHB2RSTR_GPIOHRST    IO port H reset
: RCC-AHB2RSTR_GPIOCRST   %1 2 lshift RCC-AHB2RSTR bis! ;  \ RCC-AHB2RSTR_GPIOCRST    IO port C reset
: RCC-AHB2RSTR_GPIOBRST   %1 1 lshift RCC-AHB2RSTR bis! ;  \ RCC-AHB2RSTR_GPIOBRST    IO port B reset
: RCC-AHB2RSTR_GPIOARST   %1 0 lshift RCC-AHB2RSTR bis! ;  \ RCC-AHB2RSTR_GPIOARST    IO port A reset

\ RCC-AHB3RSTR (read-write)
: RCC-AHB3RSTR_FLASHRST   %1 25 lshift RCC-AHB3RSTR bis! ;  \ RCC-AHB3RSTR_FLASHRST    Flash interface reset
: RCC-AHB3RSTR_HSEMRST   %1 19 lshift RCC-AHB3RSTR bis! ;  \ RCC-AHB3RSTR_HSEMRST    HSEMRST
: RCC-AHB3RSTR_RNGRST   %1 18 lshift RCC-AHB3RSTR bis! ;  \ RCC-AHB3RSTR_RNGRST    RNGRST
: RCC-AHB3RSTR_AESRST   %1 17 lshift RCC-AHB3RSTR bis! ;  \ RCC-AHB3RSTR_AESRST    AESRST
: RCC-AHB3RSTR_PKARST   %1 16 lshift RCC-AHB3RSTR bis! ;  \ RCC-AHB3RSTR_PKARST    PKARST

\ RCC-APB1RSTR1 (read-write)
: RCC-APB1RSTR1_LPTIM1RST   %1 31 lshift RCC-APB1RSTR1 bis! ;  \ RCC-APB1RSTR1_LPTIM1RST    Low Power Timer 1 reset
: RCC-APB1RSTR1_DACRST   %1 29 lshift RCC-APB1RSTR1 bis! ;  \ RCC-APB1RSTR1_DACRST    DAC reset
: RCC-APB1RSTR1_I2C3RST   %1 23 lshift RCC-APB1RSTR1 bis! ;  \ RCC-APB1RSTR1_I2C3RST    I2C3 reset
: RCC-APB1RSTR1_I2C2RST   %1 22 lshift RCC-APB1RSTR1 bis! ;  \ RCC-APB1RSTR1_I2C2RST    I2C2 reset
: RCC-APB1RSTR1_I2C1RST   %1 21 lshift RCC-APB1RSTR1 bis! ;  \ RCC-APB1RSTR1_I2C1RST    I2C1 reset
: RCC-APB1RSTR1_USART2RST   %1 17 lshift RCC-APB1RSTR1 bis! ;  \ RCC-APB1RSTR1_USART2RST    USART2 reset
: RCC-APB1RSTR1_SPI2S2RST   %1 14 lshift RCC-APB1RSTR1 bis! ;  \ RCC-APB1RSTR1_SPI2S2RST    SPI2S2 reset
: RCC-APB1RSTR1_TIM2RST   %1 0 lshift RCC-APB1RSTR1 bis! ;  \ RCC-APB1RSTR1_TIM2RST    TIM2 timer reset

\ RCC-APB1RSTR2 (read-write)
: RCC-APB1RSTR2_LPTIM3RST   %1 6 lshift RCC-APB1RSTR2 bis! ;  \ RCC-APB1RSTR2_LPTIM3RST    Low-power timer 3 reset
: RCC-APB1RSTR2_LPTIM2RST   %1 5 lshift RCC-APB1RSTR2 bis! ;  \ RCC-APB1RSTR2_LPTIM2RST    Low-power timer 2 reset
: RCC-APB1RSTR2_LPUART1RST   %1 0 lshift RCC-APB1RSTR2 bis! ;  \ RCC-APB1RSTR2_LPUART1RST    Low-power UART 1 reset

\ RCC-APB2RSTR (read-write)
: RCC-APB2RSTR_TIM17RST   %1 18 lshift RCC-APB2RSTR bis! ;  \ RCC-APB2RSTR_TIM17RST    TIM17 timer reset
: RCC-APB2RSTR_TIM16RST   %1 17 lshift RCC-APB2RSTR bis! ;  \ RCC-APB2RSTR_TIM16RST    TIM16 timer reset
: RCC-APB2RSTR_USART1RST   %1 14 lshift RCC-APB2RSTR bis! ;  \ RCC-APB2RSTR_USART1RST    USART1 reset
: RCC-APB2RSTR_SPI1RST   %1 12 lshift RCC-APB2RSTR bis! ;  \ RCC-APB2RSTR_SPI1RST    SPI1 reset
: RCC-APB2RSTR_TIM1RST   %1 11 lshift RCC-APB2RSTR bis! ;  \ RCC-APB2RSTR_TIM1RST    TIM1 timer reset
: RCC-APB2RSTR_ADCRST   %1 9 lshift RCC-APB2RSTR bis! ;  \ RCC-APB2RSTR_ADCRST    ADC reset

\ RCC-APB3RSTR (read-write)
: RCC-APB3RSTR_SUBGHZSPIRST   %1 0 lshift RCC-APB3RSTR bis! ;  \ RCC-APB3RSTR_SUBGHZSPIRST    Sub-GHz radio SPI reset

\ RCC-AHB1ENR (read-write)
: RCC-AHB1ENR_CRCEN   %1 12 lshift RCC-AHB1ENR bis! ;  \ RCC-AHB1ENR_CRCEN    CPU1 CRC clock enable
: RCC-AHB1ENR_DMAMUX1EN   %1 2 lshift RCC-AHB1ENR bis! ;  \ RCC-AHB1ENR_DMAMUX1EN    CPU1 DMAMUX1 clock enable
: RCC-AHB1ENR_DMA2EN   %1 1 lshift RCC-AHB1ENR bis! ;  \ RCC-AHB1ENR_DMA2EN    CPU1 DMA2 clock enable
: RCC-AHB1ENR_DMA1EN   %1 0 lshift RCC-AHB1ENR bis! ;  \ RCC-AHB1ENR_DMA1EN    CPU1 DMA1 clock enable

\ RCC-AHB2ENR (read-write)
: RCC-AHB2ENR_GPIOHEN   %1 7 lshift RCC-AHB2ENR bis! ;  \ RCC-AHB2ENR_GPIOHEN    CPU1 IO port H clock enable
: RCC-AHB2ENR_GPIOCEN   %1 2 lshift RCC-AHB2ENR bis! ;  \ RCC-AHB2ENR_GPIOCEN    CPU1 IO port C clock enable
: RCC-AHB2ENR_GPIOBEN   %1 1 lshift RCC-AHB2ENR bis! ;  \ RCC-AHB2ENR_GPIOBEN    CPU1 IO port B clock enable
: RCC-AHB2ENR_GPIOAEN   %1 0 lshift RCC-AHB2ENR bis! ;  \ RCC-AHB2ENR_GPIOAEN    CPU1 IO port A clock enable

\ RCC-AHB3ENR (read-write)
: RCC-AHB3ENR_FLASHEN   %1 25 lshift RCC-AHB3ENR bis! ;  \ RCC-AHB3ENR_FLASHEN    CPU1 Flash interface clock enable
: RCC-AHB3ENR_HSEMEN   %1 19 lshift RCC-AHB3ENR bis! ;  \ RCC-AHB3ENR_HSEMEN    HSEMEN
: RCC-AHB3ENR_RNGEN   %1 18 lshift RCC-AHB3ENR bis! ;  \ RCC-AHB3ENR_RNGEN    RNGEN
: RCC-AHB3ENR_AESEN   %1 17 lshift RCC-AHB3ENR bis! ;  \ RCC-AHB3ENR_AESEN    AESEN
: RCC-AHB3ENR_PKAEN   %1 16 lshift RCC-AHB3ENR bis! ;  \ RCC-AHB3ENR_PKAEN    PKAEN

\ RCC-APB1ENR1 ()
: RCC-APB1ENR1_LPTIM1EN   %1 31 lshift RCC-APB1ENR1 bis! ;  \ RCC-APB1ENR1_LPTIM1EN    CPU1 Low power timer 1 clocks enable
: RCC-APB1ENR1_DAC1EN   %1 29 lshift RCC-APB1ENR1 bis! ;  \ RCC-APB1ENR1_DAC1EN    CPU1 DAC1 clock enable
: RCC-APB1ENR1_I2C3EN   %1 23 lshift RCC-APB1ENR1 bis! ;  \ RCC-APB1ENR1_I2C3EN    CPU1 I2C3 clocks enable
: RCC-APB1ENR1_I2C2EN   %1 22 lshift RCC-APB1ENR1 bis! ;  \ RCC-APB1ENR1_I2C2EN    CPU1 I2C2 clocks enable
: RCC-APB1ENR1_I2C1EN   %1 21 lshift RCC-APB1ENR1 bis! ;  \ RCC-APB1ENR1_I2C1EN    CPU1 I2C1 clocks enable
: RCC-APB1ENR1_USART2EN   %1 17 lshift RCC-APB1ENR1 bis! ;  \ RCC-APB1ENR1_USART2EN    CPU1 USART2 clock enable
: RCC-APB1ENR1_SPI2S2EN   %1 14 lshift RCC-APB1ENR1 bis! ;  \ RCC-APB1ENR1_SPI2S2EN    CPU1 SPI2S2 clock enable
: RCC-APB1ENR1_WWDGEN   %1 11 lshift RCC-APB1ENR1 bis! ;  \ RCC-APB1ENR1_WWDGEN    CPU1 Window watchdog clock enable
: RCC-APB1ENR1_RTCAPBEN   %1 10 lshift RCC-APB1ENR1 bis! ;  \ RCC-APB1ENR1_RTCAPBEN    CPU1 RTC APB clock enable
: RCC-APB1ENR1_TIM2EN   %1 0 lshift RCC-APB1ENR1 bis! ;  \ RCC-APB1ENR1_TIM2EN    CPU1 TIM2 timer clock enable

\ RCC-APB1ENR2 (read-write)
: RCC-APB1ENR2_LPTIM3EN   %1 6 lshift RCC-APB1ENR2 bis! ;  \ RCC-APB1ENR2_LPTIM3EN    CPU1 Low power timer 3 clocks enable
: RCC-APB1ENR2_LPTIM2EN   %1 5 lshift RCC-APB1ENR2 bis! ;  \ RCC-APB1ENR2_LPTIM2EN    CPU1 Low power timer 2 clocks enable
: RCC-APB1ENR2_LPUART1EN   %1 0 lshift RCC-APB1ENR2 bis! ;  \ RCC-APB1ENR2_LPUART1EN    CPU1 Low power UART 1 clocks enable

\ RCC-APB2ENR (read-write)
: RCC-APB2ENR_TIM17EN   %1 18 lshift RCC-APB2ENR bis! ;  \ RCC-APB2ENR_TIM17EN    CPU1 TIM17 timer clock enable
: RCC-APB2ENR_TIM16EN   %1 17 lshift RCC-APB2ENR bis! ;  \ RCC-APB2ENR_TIM16EN    CPU1 TIM16 timer clock enable
: RCC-APB2ENR_USART1EN   %1 14 lshift RCC-APB2ENR bis! ;  \ RCC-APB2ENR_USART1EN    CPU1 USART1clocks enable
: RCC-APB2ENR_SPI1EN   %1 12 lshift RCC-APB2ENR bis! ;  \ RCC-APB2ENR_SPI1EN    CPU1 SPI1 clock enable
: RCC-APB2ENR_TIM1EN   %1 11 lshift RCC-APB2ENR bis! ;  \ RCC-APB2ENR_TIM1EN    CPU1 TIM1 timer clock enable
: RCC-APB2ENR_ADCEN   %1 9 lshift RCC-APB2ENR bis! ;  \ RCC-APB2ENR_ADCEN    CPU1 ADC clocks enable

\ RCC-APB3ENR (read-write)
: RCC-APB3ENR_SUBGHZSPIEN   %1 0 lshift RCC-APB3ENR bis! ;  \ RCC-APB3ENR_SUBGHZSPIEN    sub-GHz radio SPI clock enable

\ RCC-AHB1SMENR (read-write)
: RCC-AHB1SMENR_CRCSMEN   %1 12 lshift RCC-AHB1SMENR bis! ;  \ RCC-AHB1SMENR_CRCSMEN    CRC clock enable during CPU1 CSleep mode.
: RCC-AHB1SMENR_DMAMUX1SMEN   %1 2 lshift RCC-AHB1SMENR bis! ;  \ RCC-AHB1SMENR_DMAMUX1SMEN    DMAMUX1 clock enable during CPU1 CSleep mode.
: RCC-AHB1SMENR_DMA2SMEN   %1 1 lshift RCC-AHB1SMENR bis! ;  \ RCC-AHB1SMENR_DMA2SMEN    DMA2 clock enable during CPU1 CSleep mode
: RCC-AHB1SMENR_DMA1SMEN   %1 0 lshift RCC-AHB1SMENR bis! ;  \ RCC-AHB1SMENR_DMA1SMEN    DMA1 clock enable during CPU1 CSleep mode.

\ RCC-AHB2SMENR (read-write)
: RCC-AHB2SMENR_GPIOHSMEN   %1 7 lshift RCC-AHB2SMENR bis! ;  \ RCC-AHB2SMENR_GPIOHSMEN    IO port H clock enable during CPU1 CSleep mode.
: RCC-AHB2SMENR_GPIOCSMEN   %1 2 lshift RCC-AHB2SMENR bis! ;  \ RCC-AHB2SMENR_GPIOCSMEN    IO port C clock enable during CPU1 CSleep mode.
: RCC-AHB2SMENR_GPIOBSMEN   %1 1 lshift RCC-AHB2SMENR bis! ;  \ RCC-AHB2SMENR_GPIOBSMEN    IO port B clock enable during CPU1 CSleep mode.
: RCC-AHB2SMENR_GPIOASMEN   %1 0 lshift RCC-AHB2SMENR bis! ;  \ RCC-AHB2SMENR_GPIOASMEN    IO port A clock enable during CPU1 CSleep mode.

\ RCC-AHB3SMENR (read-write)
: RCC-AHB3SMENR_FLASHSMEN   %1 25 lshift RCC-AHB3SMENR bis! ;  \ RCC-AHB3SMENR_FLASHSMEN    Flash interface clock enable during CPU1 CSleep mode.
: RCC-AHB3SMENR_SRAM2SMEN   %1 24 lshift RCC-AHB3SMENR bis! ;  \ RCC-AHB3SMENR_SRAM2SMEN    SRAM2 memory interface clock enable during CPU1 CSleep mode
: RCC-AHB3SMENR_SRAM1SMEN   %1 23 lshift RCC-AHB3SMENR bis! ;  \ RCC-AHB3SMENR_SRAM1SMEN    SRAM1 interface clock enable during CPU1 CSleep mode.
: RCC-AHB3SMENR_RNGSMEN   %1 18 lshift RCC-AHB3SMENR bis! ;  \ RCC-AHB3SMENR_RNGSMEN    True RNG clocks enable during CPU1 Csleep and CStop modes
: RCC-AHB3SMENR_AESSMEN   %1 17 lshift RCC-AHB3SMENR bis! ;  \ RCC-AHB3SMENR_AESSMEN    AES accelerator clock enable during CPU1 CSleep mode.
: RCC-AHB3SMENR_PKASMEN   %1 16 lshift RCC-AHB3SMENR bis! ;  \ RCC-AHB3SMENR_PKASMEN    PKA accelerator clock enable during CPU1 CSleep mode.

\ RCC-APB1SMENR1 (read-write)
: RCC-APB1SMENR1_LPTIM1SMEN   %1 31 lshift RCC-APB1SMENR1 bis! ;  \ RCC-APB1SMENR1_LPTIM1SMEN    Low power timer 1 clock enable during CPU1 Csleep and CStop mode
: RCC-APB1SMENR1_DACSMEN   %1 29 lshift RCC-APB1SMENR1 bis! ;  \ RCC-APB1SMENR1_DACSMEN    DAC clock enable during CPU1 CSleep mode.
: RCC-APB1SMENR1_I2C3SMEN   %1 23 lshift RCC-APB1SMENR1 bis! ;  \ RCC-APB1SMENR1_I2C3SMEN    I2C3 clock enable during CPU1 Csleep and CStop modes
: RCC-APB1SMENR1_I2C2SMEN   %1 22 lshift RCC-APB1SMENR1 bis! ;  \ RCC-APB1SMENR1_I2C2SMEN    I2C2 clock enable during CPU1 Csleep and CStop modes
: RCC-APB1SMENR1_I2C1SMEN   %1 21 lshift RCC-APB1SMENR1 bis! ;  \ RCC-APB1SMENR1_I2C1SMEN    I2C1 clock enable during CPU1 Csleep and CStop modes
: RCC-APB1SMENR1_USART2SMEN   %1 17 lshift RCC-APB1SMENR1 bis! ;  \ RCC-APB1SMENR1_USART2SMEN    USART2 clock enable during CPU1 CSleep mode.
: RCC-APB1SMENR1_SPI2S2SMEN   %1 14 lshift RCC-APB1SMENR1 bis! ;  \ RCC-APB1SMENR1_SPI2S2SMEN    SPI2S2 clock enable during CPU1 CSleep mode.
: RCC-APB1SMENR1_WWDGSMEN   %1 11 lshift RCC-APB1SMENR1 bis! ;  \ RCC-APB1SMENR1_WWDGSMEN    Window watchdog clocks enable during CPU1 CSleep mode.
: RCC-APB1SMENR1_RTCAPBSMEN   %1 10 lshift RCC-APB1SMENR1 bis! ;  \ RCC-APB1SMENR1_RTCAPBSMEN    RTC bus clock enable during CPU1 CSleep mode.
: RCC-APB1SMENR1_TIM2SMEN   %1 0 lshift RCC-APB1SMENR1 bis! ;  \ RCC-APB1SMENR1_TIM2SMEN    TIM2 timer clock enable during CPU1 CSleep mode.

\ RCC-APB1SMENR2 (read-write)
: RCC-APB1SMENR2_LPTIM3SMEN   %1 6 lshift RCC-APB1SMENR2 bis! ;  \ RCC-APB1SMENR2_LPTIM3SMEN    Low power timer 3 clock enable during CPU1 Csleep and CStop modes
: RCC-APB1SMENR2_LPTIM2SMEN   %1 5 lshift RCC-APB1SMENR2 bis! ;  \ RCC-APB1SMENR2_LPTIM2SMEN    Low power timer 2 clock enable during CPU1 Csleep and CStop modes
: RCC-APB1SMENR2_LPUART1SMEN   %1 0 lshift RCC-APB1SMENR2 bis! ;  \ RCC-APB1SMENR2_LPUART1SMEN    Low power UART 1 clock enable during CPU1 Csleep and CStop modes.

\ RCC-APB2SMENR (read-write)
: RCC-APB2SMENR_TIM17SMEN   %1 18 lshift RCC-APB2SMENR bis! ;  \ RCC-APB2SMENR_TIM17SMEN    TIM17 timer clock enable during CPU1 CSleep mode.
: RCC-APB2SMENR_TIM16SMEN   %1 17 lshift RCC-APB2SMENR bis! ;  \ RCC-APB2SMENR_TIM16SMEN    TIM16 timer clock enable during CPU1 CSleep mode.
: RCC-APB2SMENR_USART1SMEN   %1 14 lshift RCC-APB2SMENR bis! ;  \ RCC-APB2SMENR_USART1SMEN    USART1 clock enable during CPU1 Csleep and CStop modes.
: RCC-APB2SMENR_SPI1SMEN   %1 12 lshift RCC-APB2SMENR bis! ;  \ RCC-APB2SMENR_SPI1SMEN    SPI1 clock enable during CPU1 CSleep mode.
: RCC-APB2SMENR_TIM1SMEN   %1 11 lshift RCC-APB2SMENR bis! ;  \ RCC-APB2SMENR_TIM1SMEN    TIM1 timer clock enable during CPU1 CSleep mode.
: RCC-APB2SMENR_ADCSMEN   %1 9 lshift RCC-APB2SMENR bis! ;  \ RCC-APB2SMENR_ADCSMEN    ADC clocks enable during CPU1 Csleep and CStop modes

\ RCC-APB3SMENR (read-write)
: RCC-APB3SMENR_SUBGHZSPISMEN   %1 0 lshift RCC-APB3SMENR bis! ;  \ RCC-APB3SMENR_SUBGHZSPISMEN    Sub-GHz radio SPI clock enable during Sleep and Stop modes

\ RCC-CCIPR (read-write)
: RCC-CCIPR_RNGSEL   ( %XX -- ) 30 lshift RCC-CCIPR bis! ;  \ RCC-CCIPR_RNGSEL    RNG clock source selection
: RCC-CCIPR_ADCSEL   ( %XX -- ) 28 lshift RCC-CCIPR bis! ;  \ RCC-CCIPR_ADCSEL    ADC clock source selection
: RCC-CCIPR_LPTIM3SEL   ( %XX -- ) 22 lshift RCC-CCIPR bis! ;  \ RCC-CCIPR_LPTIM3SEL    Low power timer 3 clock source selection
: RCC-CCIPR_LPTIM2SEL   ( %XX -- ) 20 lshift RCC-CCIPR bis! ;  \ RCC-CCIPR_LPTIM2SEL    Low power timer 2 clock source selection
: RCC-CCIPR_LPTIM1SEL   ( %XX -- ) 18 lshift RCC-CCIPR bis! ;  \ RCC-CCIPR_LPTIM1SEL    Low power timer 1 clock source selection
: RCC-CCIPR_I2C3SEL   ( %XX -- ) 16 lshift RCC-CCIPR bis! ;  \ RCC-CCIPR_I2C3SEL    I2C3 clock source selection
: RCC-CCIPR_I2C2SEL   ( %XX -- ) 14 lshift RCC-CCIPR bis! ;  \ RCC-CCIPR_I2C2SEL    I2C2 clock source selection
: RCC-CCIPR_I2C1SEL   ( %XX -- ) 12 lshift RCC-CCIPR bis! ;  \ RCC-CCIPR_I2C1SEL    I2C1 clock source selection
: RCC-CCIPR_LPUART1SEL   ( %XX -- ) 10 lshift RCC-CCIPR bis! ;  \ RCC-CCIPR_LPUART1SEL    LPUART1 clock source selection
: RCC-CCIPR_SPI2S2SEL   ( %XX -- ) 8 lshift RCC-CCIPR bis! ;  \ RCC-CCIPR_SPI2S2SEL    SPI2S2 I2S clock source selection
: RCC-CCIPR_USART2SEL   ( %XX -- ) 2 lshift RCC-CCIPR bis! ;  \ RCC-CCIPR_USART2SEL    USART2 clock source selection
: RCC-CCIPR_USART1SEL   ( %XX -- ) 0 lshift RCC-CCIPR bis! ;  \ RCC-CCIPR_USART1SEL    USART1 clock source selection

\ RCC-BDCR ()
: RCC-BDCR_LSCOSEL   %1 25 lshift RCC-BDCR bis! ;  \ RCC-BDCR_LSCOSEL    Low speed clock output selection
: RCC-BDCR_LSCOEN   %1 24 lshift RCC-BDCR bis! ;  \ RCC-BDCR_LSCOEN    Low speed clock output enable
: RCC-BDCR_BDRST   %1 16 lshift RCC-BDCR bis! ;  \ RCC-BDCR_BDRST    Backup domain software reset
: RCC-BDCR_RTCEN   %1 15 lshift RCC-BDCR bis! ;  \ RCC-BDCR_RTCEN    RTC clock enable
: RCC-BDCR_LSESYSRDY   %1 11 lshift RCC-BDCR bis! ;  \ RCC-BDCR_LSESYSRDY    LSE system clock ready
: RCC-BDCR_RTCSEL   ( %XX -- ) 8 lshift RCC-BDCR bis! ;  \ RCC-BDCR_RTCSEL    RTC clock source selection
: RCC-BDCR_LSESYSEN   %1 7 lshift RCC-BDCR bis! ;  \ RCC-BDCR_LSESYSEN    LSE system clock enable
: RCC-BDCR_LSECSSD   %1 6 lshift RCC-BDCR bis! ;  \ RCC-BDCR_LSECSSD    CSS on LSE failure Detection
: RCC-BDCR_LSECSSON   %1 5 lshift RCC-BDCR bis! ;  \ RCC-BDCR_LSECSSON    CSS on LSE enable
: RCC-BDCR_LSEDRV   ( %XX -- ) 3 lshift RCC-BDCR bis! ;  \ RCC-BDCR_LSEDRV    LSE oscillator drive capability
: RCC-BDCR_LSEBYP   %1 2 lshift RCC-BDCR bis! ;  \ RCC-BDCR_LSEBYP    LSE oscillator bypass
: RCC-BDCR_LSERDY   %1 1 lshift RCC-BDCR bis! ;  \ RCC-BDCR_LSERDY    LSE oscillator ready
: RCC-BDCR_LSEON   %1 0 lshift RCC-BDCR bis! ;  \ RCC-BDCR_LSEON    LSE oscillator enable

\ RCC-CSR ()
: RCC-CSR_LPWRRSTF   %1 31 lshift RCC-CSR bis! ;  \ RCC-CSR_LPWRRSTF    Low-power reset flag
: RCC-CSR_WWDGRSTF   %1 30 lshift RCC-CSR bis! ;  \ RCC-CSR_WWDGRSTF    Window watchdog reset flag
: RCC-CSR_IWDGRSTF   %1 29 lshift RCC-CSR bis! ;  \ RCC-CSR_IWDGRSTF    Independent window watchdog reset flag
: RCC-CSR_SFTRSTF   %1 28 lshift RCC-CSR bis! ;  \ RCC-CSR_SFTRSTF    Software reset flag
: RCC-CSR_BORRSTF   %1 27 lshift RCC-CSR bis! ;  \ RCC-CSR_BORRSTF    BOR flag
: RCC-CSR_PINRSTF   %1 26 lshift RCC-CSR bis! ;  \ RCC-CSR_PINRSTF    Pin reset flag
: RCC-CSR_OBLRSTF   %1 25 lshift RCC-CSR bis! ;  \ RCC-CSR_OBLRSTF    Option byte loader reset flag
: RCC-CSR_RFILARSTF   %1 24 lshift RCC-CSR bis! ;  \ RCC-CSR_RFILARSTF    Radio illegal access flag
: RCC-CSR_RMVF   %1 23 lshift RCC-CSR bis! ;  \ RCC-CSR_RMVF    Remove reset flag
: RCC-CSR_RFRST   %1 15 lshift RCC-CSR bis! ;  \ RCC-CSR_RFRST    Radio reset
: RCC-CSR_RFRSTF   %1 14 lshift RCC-CSR bis! ;  \ RCC-CSR_RFRSTF    Radio in reset status flag
: RCC-CSR_MSISRANGE   ( %XXXX -- ) 8 lshift RCC-CSR bis! ;  \ RCC-CSR_MSISRANGE    MSI clock ranges
: RCC-CSR_LSIPRE   %1 4 lshift RCC-CSR bis! ;  \ RCC-CSR_LSIPRE    LSI frequency prescaler
: RCC-CSR_LSIRDY   %1 1 lshift RCC-CSR bis! ;  \ RCC-CSR_LSIRDY    LSI oscillator ready
: RCC-CSR_LSION   %1 0 lshift RCC-CSR bis! ;  \ RCC-CSR_LSION    LSI oscillator enable

\ RCC-EXTCFGR ()
: RCC-EXTCFGR_SHDHPREF   %1 16 lshift RCC-EXTCFGR bis! ;  \ RCC-EXTCFGR_SHDHPREF    HCLK3 shared prescaler flag AHB3, Flash, and SRAM2
: RCC-EXTCFGR_SHDHPRE   ( %XXXX -- ) 0 lshift RCC-EXTCFGR bis! ;  \ RCC-EXTCFGR_SHDHPRE    HCLK3 shared prescaler AHB3, Flash, and SRAM2

\ RNG-CR (read-write)
: RNG-CR_RNGEN   %1 2 lshift RNG-CR bis! ;  \ RNG-CR_RNGEN    True random number generator enable
: RNG-CR_IE   %1 3 lshift RNG-CR bis! ;  \ RNG-CR_IE    Interrupt Enable
: RNG-CR_CED   %1 5 lshift RNG-CR bis! ;  \ RNG-CR_CED    Interrupt Enable
: RNG-CR_RNG_CONFIG3   ( %XXXX -- ) 8 lshift RNG-CR bis! ;  \ RNG-CR_RNG_CONFIG3    RNG_CONFIG3
: RNG-CR_NISTC   %1 12 lshift RNG-CR bis! ;  \ RNG-CR_NISTC    NISTC
: RNG-CR_RNG_CONFIG2   ( %XXX -- ) 13 lshift RNG-CR bis! ;  \ RNG-CR_RNG_CONFIG2    RNG_CONFIG2
: RNG-CR_CLKDIV   ( %XXXX -- ) 16 lshift RNG-CR bis! ;  \ RNG-CR_CLKDIV    CLKDIV
: RNG-CR_RNG_CONFIG1   ( %XXXXXX -- ) 20 lshift RNG-CR bis! ;  \ RNG-CR_RNG_CONFIG1    RNG_CONFIG1
: RNG-CR_CONDRST   %1 30 lshift RNG-CR bis! ;  \ RNG-CR_CONDRST    Conditioning soft reset
: RNG-CR_CONFIGLOCK   %1 31 lshift RNG-CR bis! ;  \ RNG-CR_CONFIGLOCK    CONFIGLOCK

\ RNG-SR ()
: RNG-SR_SEIS   %1 6 lshift RNG-SR bis! ;  \ RNG-SR_SEIS    Seed error interrupt status
: RNG-SR_CEIS   %1 5 lshift RNG-SR bis! ;  \ RNG-SR_CEIS    Clock error interrupt status
: RNG-SR_SECS   %1 2 lshift RNG-SR bis! ;  \ RNG-SR_SECS    Seed error current status
: RNG-SR_CECS   %1 1 lshift RNG-SR bis! ;  \ RNG-SR_CECS    Clock error current status
: RNG-SR_DRDY   %1 0 lshift RNG-SR bis! ;  \ RNG-SR_DRDY    Data Ready

\ RNG-DR (read-only)
: RNG-DR_RNDATA   ( %XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX -- ) 0 lshift RNG-DR bis! ;  \ RNG-DR_RNDATA    Random data

\ RNG-HTCR (read-write)
: RNG-HTCR_HTCFG   ( %XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX -- ) 0 lshift RNG-HTCR bis! ;  \ RNG-HTCR_HTCFG    health test configuration

\ RTC-TR (read-write)
: RTC-TR_PM   %1 22 lshift RTC-TR bis! ;  \ RTC-TR_PM    AM/PM notation
: RTC-TR_HT   ( %XX -- ) 20 lshift RTC-TR bis! ;  \ RTC-TR_HT    Hour tens in BCD format
: RTC-TR_HU   ( %XXXX -- ) 16 lshift RTC-TR bis! ;  \ RTC-TR_HU    Hour units in BCD format
: RTC-TR_MNT   ( %XXX -- ) 12 lshift RTC-TR bis! ;  \ RTC-TR_MNT    Minute tens in BCD format
: RTC-TR_MNU   ( %XXXX -- ) 8 lshift RTC-TR bis! ;  \ RTC-TR_MNU    Minute units in BCD format
: RTC-TR_ST   ( %XXX -- ) 4 lshift RTC-TR bis! ;  \ RTC-TR_ST    Second tens in BCD format
: RTC-TR_SU   ( %XXXX -- ) 0 lshift RTC-TR bis! ;  \ RTC-TR_SU    Second units in BCD format

\ RTC-DR (read-write)
: RTC-DR_YT   ( %XXXX -- ) 20 lshift RTC-DR bis! ;  \ RTC-DR_YT    Year tens in BCD format
: RTC-DR_YU   ( %XXXX -- ) 16 lshift RTC-DR bis! ;  \ RTC-DR_YU    Year units in BCD format
: RTC-DR_WDU   ( %XXX -- ) 13 lshift RTC-DR bis! ;  \ RTC-DR_WDU    Week day units
: RTC-DR_MT   %1 12 lshift RTC-DR bis! ;  \ RTC-DR_MT    Month tens in BCD format
: RTC-DR_MU   ( %XXXX -- ) 8 lshift RTC-DR bis! ;  \ RTC-DR_MU    Month units in BCD format
: RTC-DR_DT   ( %XX -- ) 4 lshift RTC-DR bis! ;  \ RTC-DR_DT    Date tens in BCD format
: RTC-DR_DU   ( %XXXX -- ) 0 lshift RTC-DR bis! ;  \ RTC-DR_DU    Date units in BCD format

\ RTC-SSR (read-only)
: RTC-SSR_SS   ( %XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX -- ) 0 lshift RTC-SSR bis! ;  \ RTC-SSR_SS    Synchronous binary counter

\ RTC-ICSR ()
: RTC-ICSR_RECALPF   %1 16 lshift RTC-ICSR bis! ;  \ RTC-ICSR_RECALPF    Recalibration pending Flag
: RTC-ICSR_BCDU   ( %XXX -- ) 10 lshift RTC-ICSR bis! ;  \ RTC-ICSR_BCDU    BCD update
: RTC-ICSR_BIN   ( %XX -- ) 8 lshift RTC-ICSR bis! ;  \ RTC-ICSR_BIN    Binary mode
: RTC-ICSR_INIT   %1 7 lshift RTC-ICSR bis! ;  \ RTC-ICSR_INIT    Initialization mode
: RTC-ICSR_INITF   %1 6 lshift RTC-ICSR bis! ;  \ RTC-ICSR_INITF    Initialization flag
: RTC-ICSR_RSF   %1 5 lshift RTC-ICSR bis! ;  \ RTC-ICSR_RSF    Registers synchronization flag
: RTC-ICSR_INITS   %1 4 lshift RTC-ICSR bis! ;  \ RTC-ICSR_INITS    Initialization status flag
: RTC-ICSR_SHPF   %1 3 lshift RTC-ICSR bis! ;  \ RTC-ICSR_SHPF    Shift operation pending
: RTC-ICSR_WUTWF   %1 2 lshift RTC-ICSR bis! ;  \ RTC-ICSR_WUTWF    Wakeup timer write flag

\ RTC-PRER (read-write)
: RTC-PRER_PREDIV_A   ( %XXXXXXX -- ) 16 lshift RTC-PRER bis! ;  \ RTC-PRER_PREDIV_A    Asynchronous prescaler factor
: RTC-PRER_PREDIV_S   ( %XXXXXXXXXXXXXXX -- ) 0 lshift RTC-PRER bis! ;  \ RTC-PRER_PREDIV_S    Synchronous prescaler factor

\ RTC-WUTR (read-write)
: RTC-WUTR_WUTOCLR   ( %XXXXXXXXXXXXXXXX -- ) 16 lshift RTC-WUTR bis! ;  \ RTC-WUTR_WUTOCLR    Wakeup auto-reload output clear value
: RTC-WUTR_WUT   ( %XXXXXXXXXXXXXXXX -- ) 0 lshift RTC-WUTR bis! ;  \ RTC-WUTR_WUT    Wakeup auto-reload value bits

\ RTC-CR ()
: RTC-CR_OUT2EN   %1 31 lshift RTC-CR bis! ;  \ RTC-CR_OUT2EN    RTC_OUT2 output enable
: RTC-CR_TAMPALRM_TYPE   %1 30 lshift RTC-CR bis! ;  \ RTC-CR_TAMPALRM_TYPE    TAMPALRM output type
: RTC-CR_TAMPALRM_PU   %1 29 lshift RTC-CR bis! ;  \ RTC-CR_TAMPALRM_PU    TAMPALRM pull-up enable
: RTC-CR_TAMPOE   %1 26 lshift RTC-CR bis! ;  \ RTC-CR_TAMPOE    Tamper detection output enable on TAMPALRM
: RTC-CR_TAMPTS   %1 25 lshift RTC-CR bis! ;  \ RTC-CR_TAMPTS    Activate timestamp on tamper detection event
: RTC-CR_ITSE   %1 24 lshift RTC-CR bis! ;  \ RTC-CR_ITSE    timestamp on internal event enable
: RTC-CR_COE   %1 23 lshift RTC-CR bis! ;  \ RTC-CR_COE    Calibration output enable
: RTC-CR_OSEL   ( %XX -- ) 21 lshift RTC-CR bis! ;  \ RTC-CR_OSEL    Output selection
: RTC-CR_POL   %1 20 lshift RTC-CR bis! ;  \ RTC-CR_POL    Output polarity
: RTC-CR_COSEL   %1 19 lshift RTC-CR bis! ;  \ RTC-CR_COSEL    Calibration output selection
: RTC-CR_BKP   %1 18 lshift RTC-CR bis! ;  \ RTC-CR_BKP    Backup
: RTC-CR_SUB1H   %1 17 lshift RTC-CR bis! ;  \ RTC-CR_SUB1H    Subtract 1 hour winter time change
: RTC-CR_ADD1H   %1 16 lshift RTC-CR bis! ;  \ RTC-CR_ADD1H    Add 1 hour summer time change
: RTC-CR_TSIE   %1 15 lshift RTC-CR bis! ;  \ RTC-CR_TSIE    Timestamp interrupt enable
: RTC-CR_WUTIE   %1 14 lshift RTC-CR bis! ;  \ RTC-CR_WUTIE    Wakeup timer interrupt enable
: RTC-CR_ALRBIE   %1 13 lshift RTC-CR bis! ;  \ RTC-CR_ALRBIE    Alarm B interrupt enable
: RTC-CR_ALRAIE   %1 12 lshift RTC-CR bis! ;  \ RTC-CR_ALRAIE    Alarm A interrupt enable
: RTC-CR_TSE   %1 11 lshift RTC-CR bis! ;  \ RTC-CR_TSE    timestamp enable
: RTC-CR_WUTE   %1 10 lshift RTC-CR bis! ;  \ RTC-CR_WUTE    Wakeup timer enable
: RTC-CR_ALRBE   %1 9 lshift RTC-CR bis! ;  \ RTC-CR_ALRBE    Alarm B enable
: RTC-CR_ALRAE   %1 8 lshift RTC-CR bis! ;  \ RTC-CR_ALRAE    Alarm A enable
: RTC-CR_SSRUIE   %1 7 lshift RTC-CR bis! ;  \ RTC-CR_SSRUIE    SSR underflow interrupt enable
: RTC-CR_FMT   %1 6 lshift RTC-CR bis! ;  \ RTC-CR_FMT    Hour format
: RTC-CR_BYPSHAD   %1 5 lshift RTC-CR bis! ;  \ RTC-CR_BYPSHAD    Bypass the shadow registers
: RTC-CR_REFCKON   %1 4 lshift RTC-CR bis! ;  \ RTC-CR_REFCKON    RTC_REFIN reference clock detection enable 50 or 60 Hz
: RTC-CR_TSEDGE   %1 3 lshift RTC-CR bis! ;  \ RTC-CR_TSEDGE    Timestamp event active edge
: RTC-CR_WUCKSEL   ( %XXX -- ) 0 lshift RTC-CR bis! ;  \ RTC-CR_WUCKSEL    Wakeup clock selection

\ RTC-WPR (write-only)
: RTC-WPR_KEY   ( %XXXXXXXX -- ) 0 lshift RTC-WPR bis! ;  \ RTC-WPR_KEY    Write protection key

\ RTC-CALR (read-write)
: RTC-CALR_CALP   %1 15 lshift RTC-CALR bis! ;  \ RTC-CALR_CALP    Use an 8-second calibration cycle period
: RTC-CALR_CALW8   %1 14 lshift RTC-CALR bis! ;  \ RTC-CALR_CALW8    Use a 16-second calibration cycle period
: RTC-CALR_CALW16   %1 13 lshift RTC-CALR bis! ;  \ RTC-CALR_CALW16    CALW16
: RTC-CALR_LPCAL   %1 12 lshift RTC-CALR bis! ;  \ RTC-CALR_LPCAL    Calibration low-power mode
: RTC-CALR_CALM   ( %XXXXXXXXX -- ) 0 lshift RTC-CALR bis! ;  \ RTC-CALR_CALM    Calibration minus

\ RTC-SHIFTR (write-only)
: RTC-SHIFTR_ADD1S   %1 31 lshift RTC-SHIFTR bis! ;  \ RTC-SHIFTR_ADD1S    Add one second
: RTC-SHIFTR_SUBFS   ( %XXXXXXXXXXXXXXX -- ) 0 lshift RTC-SHIFTR bis! ;  \ RTC-SHIFTR_SUBFS    Subtract a fraction of a second

\ RTC-TSTR (read-only)
: RTC-TSTR_PM   %1 22 lshift RTC-TSTR bis! ;  \ RTC-TSTR_PM    AM/PM notation
: RTC-TSTR_HT   ( %XX -- ) 20 lshift RTC-TSTR bis! ;  \ RTC-TSTR_HT    Hour tens in BCD format.
: RTC-TSTR_HU   ( %XXXX -- ) 16 lshift RTC-TSTR bis! ;  \ RTC-TSTR_HU    Hour units in BCD format.
: RTC-TSTR_MNT   ( %XXX -- ) 12 lshift RTC-TSTR bis! ;  \ RTC-TSTR_MNT    Minute tens in BCD format.
: RTC-TSTR_MNU   ( %XXXX -- ) 8 lshift RTC-TSTR bis! ;  \ RTC-TSTR_MNU    Minute units in BCD format.
: RTC-TSTR_ST   ( %XXX -- ) 4 lshift RTC-TSTR bis! ;  \ RTC-TSTR_ST    Second tens in BCD format.
: RTC-TSTR_SU   ( %XXXX -- ) 0 lshift RTC-TSTR bis! ;  \ RTC-TSTR_SU    Second units in BCD format.

\ RTC-TSDR (read-only)
: RTC-TSDR_WDU   ( %XXX -- ) 13 lshift RTC-TSDR bis! ;  \ RTC-TSDR_WDU    Week day units
: RTC-TSDR_MT   %1 12 lshift RTC-TSDR bis! ;  \ RTC-TSDR_MT    Month tens in BCD format
: RTC-TSDR_MU   ( %XXXX -- ) 8 lshift RTC-TSDR bis! ;  \ RTC-TSDR_MU    Month units in BCD format
: RTC-TSDR_DT   ( %XX -- ) 4 lshift RTC-TSDR bis! ;  \ RTC-TSDR_DT    Date tens in BCD format
: RTC-TSDR_DU   ( %XXXX -- ) 0 lshift RTC-TSDR bis! ;  \ RTC-TSDR_DU    Date units in BCD format

\ RTC-TSSSR (read-only)
: RTC-TSSSR_SS   ( %XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX -- ) 0 lshift RTC-TSSSR bis! ;  \ RTC-TSSSR_SS    Sub second value

\ RTC-ALRMAR (read-write)
: RTC-ALRMAR_MSK4   %1 31 lshift RTC-ALRMAR bis! ;  \ RTC-ALRMAR_MSK4    Alarm A date mask
: RTC-ALRMAR_WDSEL   %1 30 lshift RTC-ALRMAR bis! ;  \ RTC-ALRMAR_WDSEL    Week day selection
: RTC-ALRMAR_DT   ( %XX -- ) 28 lshift RTC-ALRMAR bis! ;  \ RTC-ALRMAR_DT    Date tens in BCD format
: RTC-ALRMAR_DU   ( %XXXX -- ) 24 lshift RTC-ALRMAR bis! ;  \ RTC-ALRMAR_DU    Date units or day in BCD format
: RTC-ALRMAR_MSK3   %1 23 lshift RTC-ALRMAR bis! ;  \ RTC-ALRMAR_MSK3    Alarm A hours mask
: RTC-ALRMAR_PM   %1 22 lshift RTC-ALRMAR bis! ;  \ RTC-ALRMAR_PM    AM/PM notation
: RTC-ALRMAR_HT   ( %XX -- ) 20 lshift RTC-ALRMAR bis! ;  \ RTC-ALRMAR_HT    Hour tens in BCD format
: RTC-ALRMAR_HU   ( %XXXX -- ) 16 lshift RTC-ALRMAR bis! ;  \ RTC-ALRMAR_HU    Hour units in BCD format
: RTC-ALRMAR_MSK2   %1 15 lshift RTC-ALRMAR bis! ;  \ RTC-ALRMAR_MSK2    Alarm A minutes mask
: RTC-ALRMAR_MNT   ( %XXX -- ) 12 lshift RTC-ALRMAR bis! ;  \ RTC-ALRMAR_MNT    Minute tens in BCD format
: RTC-ALRMAR_MNU   ( %XXXX -- ) 8 lshift RTC-ALRMAR bis! ;  \ RTC-ALRMAR_MNU    Minute units in BCD format
: RTC-ALRMAR_MSK1   %1 7 lshift RTC-ALRMAR bis! ;  \ RTC-ALRMAR_MSK1    Alarm A seconds mask
: RTC-ALRMAR_ST   ( %XXX -- ) 4 lshift RTC-ALRMAR bis! ;  \ RTC-ALRMAR_ST    Second tens in BCD format.
: RTC-ALRMAR_SU   ( %XXXX -- ) 0 lshift RTC-ALRMAR bis! ;  \ RTC-ALRMAR_SU    Second units in BCD format.

\ RTC-ALRMASSR (read-write)
: RTC-ALRMASSR_SSCLR   %1 31 lshift RTC-ALRMASSR bis! ;  \ RTC-ALRMASSR_SSCLR    Clear synchronous counter on alarm Binary mode only
: RTC-ALRMASSR_MASKSS   ( %XXXXXX -- ) 24 lshift RTC-ALRMASSR bis! ;  \ RTC-ALRMASSR_MASKSS    Mask the most-significant bits starting at this bit
: RTC-ALRMASSR_SS   ( %XXXXXXXXXXXXXXX -- ) 0 lshift RTC-ALRMASSR bis! ;  \ RTC-ALRMASSR_SS    Sub seconds value

\ RTC-ALRMBR (read-write)
: RTC-ALRMBR_MSK4   %1 31 lshift RTC-ALRMBR bis! ;  \ RTC-ALRMBR_MSK4    Alarm B date mask
: RTC-ALRMBR_WDSEL   %1 30 lshift RTC-ALRMBR bis! ;  \ RTC-ALRMBR_WDSEL    Week day selection
: RTC-ALRMBR_DT   ( %XX -- ) 28 lshift RTC-ALRMBR bis! ;  \ RTC-ALRMBR_DT    Date tens in BCD format
: RTC-ALRMBR_DU   ( %XXXX -- ) 24 lshift RTC-ALRMBR bis! ;  \ RTC-ALRMBR_DU    Date units or day in BCD format
: RTC-ALRMBR_MSK3   %1 23 lshift RTC-ALRMBR bis! ;  \ RTC-ALRMBR_MSK3    Alarm B hours mask
: RTC-ALRMBR_PM   %1 22 lshift RTC-ALRMBR bis! ;  \ RTC-ALRMBR_PM    AM/PM notation
: RTC-ALRMBR_HT   ( %XX -- ) 20 lshift RTC-ALRMBR bis! ;  \ RTC-ALRMBR_HT    Hour tens in BCD format
: RTC-ALRMBR_HU   ( %XXXX -- ) 16 lshift RTC-ALRMBR bis! ;  \ RTC-ALRMBR_HU    Hour units in BCD format
: RTC-ALRMBR_MSK2   %1 15 lshift RTC-ALRMBR bis! ;  \ RTC-ALRMBR_MSK2    Alarm B minutes mask
: RTC-ALRMBR_MNT   ( %XXX -- ) 12 lshift RTC-ALRMBR bis! ;  \ RTC-ALRMBR_MNT    Minute tens in BCD format
: RTC-ALRMBR_MNU   ( %XXXX -- ) 8 lshift RTC-ALRMBR bis! ;  \ RTC-ALRMBR_MNU    Minute units in BCD format
: RTC-ALRMBR_MSK1   %1 7 lshift RTC-ALRMBR bis! ;  \ RTC-ALRMBR_MSK1    Alarm B seconds mask
: RTC-ALRMBR_ST   ( %XXX -- ) 4 lshift RTC-ALRMBR bis! ;  \ RTC-ALRMBR_ST    Second tens in BCD format
: RTC-ALRMBR_SU   ( %XXXX -- ) 0 lshift RTC-ALRMBR bis! ;  \ RTC-ALRMBR_SU    Second units in BCD format

\ RTC-ALRMBSSR (read-write)
: RTC-ALRMBSSR_SSCLR   %1 31 lshift RTC-ALRMBSSR bis! ;  \ RTC-ALRMBSSR_SSCLR    Clear synchronous counter on alarm Binary mode only
: RTC-ALRMBSSR_MASKSS   ( %XXXXXX -- ) 24 lshift RTC-ALRMBSSR bis! ;  \ RTC-ALRMBSSR_MASKSS    Mask the most-significant bits starting at this bit
: RTC-ALRMBSSR_SS   ( %XXXXXXXXXXXXXXX -- ) 0 lshift RTC-ALRMBSSR bis! ;  \ RTC-ALRMBSSR_SS    Sub seconds value

\ RTC-SR (read-only)
: RTC-SR_SSRUF   %1 6 lshift RTC-SR bis! ;  \ RTC-SR_SSRUF    SSR underflow flag
: RTC-SR_ITSF   %1 5 lshift RTC-SR bis! ;  \ RTC-SR_ITSF    Internal timestamp flag
: RTC-SR_TSOVF   %1 4 lshift RTC-SR bis! ;  \ RTC-SR_TSOVF    Timestamp overflow flag
: RTC-SR_TSF   %1 3 lshift RTC-SR bis! ;  \ RTC-SR_TSF    Timestamp flag
: RTC-SR_WUTF   %1 2 lshift RTC-SR bis! ;  \ RTC-SR_WUTF    Wakeup timer flag
: RTC-SR_ALRBF   %1 1 lshift RTC-SR bis! ;  \ RTC-SR_ALRBF    Alarm B flag
: RTC-SR_ALRAF   %1 0 lshift RTC-SR bis! ;  \ RTC-SR_ALRAF    Alarm A flag

\ RTC-MISR (read-only)
: RTC-MISR_SSRUMF   %1 6 lshift RTC-MISR bis! ;  \ RTC-MISR_SSRUMF    SSR underflow masked flag
: RTC-MISR_ITSMF   %1 5 lshift RTC-MISR bis! ;  \ RTC-MISR_ITSMF    Internal timestamp masked flag
: RTC-MISR_TSOVMF   %1 4 lshift RTC-MISR bis! ;  \ RTC-MISR_TSOVMF    Timestamp overflow masked flag
: RTC-MISR_TSMF   %1 3 lshift RTC-MISR bis! ;  \ RTC-MISR_TSMF    Timestamp masked flag
: RTC-MISR_WUTMF   %1 2 lshift RTC-MISR bis! ;  \ RTC-MISR_WUTMF    Wakeup timer masked flag
: RTC-MISR_ALRBMF   %1 1 lshift RTC-MISR bis! ;  \ RTC-MISR_ALRBMF    Alarm B masked flag
: RTC-MISR_ALRAMF   %1 0 lshift RTC-MISR bis! ;  \ RTC-MISR_ALRAMF    Alarm A masked flag

\ RTC-SCR (write-only)
: RTC-SCR_CSSRUF   %1 6 lshift RTC-SCR bis! ;  \ RTC-SCR_CSSRUF    Clear SSR underflow flag
: RTC-SCR_CITSF   %1 5 lshift RTC-SCR bis! ;  \ RTC-SCR_CITSF    Clear internal timestamp flag
: RTC-SCR_CTSOVF   %1 4 lshift RTC-SCR bis! ;  \ RTC-SCR_CTSOVF    Clear timestamp overflow flag
: RTC-SCR_CTSF   %1 3 lshift RTC-SCR bis! ;  \ RTC-SCR_CTSF    Clear timestamp flag
: RTC-SCR_CWUTF   %1 2 lshift RTC-SCR bis! ;  \ RTC-SCR_CWUTF    Clear wakeup timer flag
: RTC-SCR_CALRBF   %1 1 lshift RTC-SCR bis! ;  \ RTC-SCR_CALRBF    Clear alarm B flag
: RTC-SCR_CALRAF   %1 0 lshift RTC-SCR bis! ;  \ RTC-SCR_CALRAF    Clear alarm A flag

\ RTC-ALRABINR (read-write)
: RTC-ALRABINR_SS   ( %XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX -- ) 0 lshift RTC-ALRABINR bis! ;  \ RTC-ALRABINR_SS    Synchronous counter alarm value in Binary mode

\ RTC-ALRBBINR (read-write)
: RTC-ALRBBINR_SS   ( %XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX -- ) 0 lshift RTC-ALRBBINR bis! ;  \ RTC-ALRBBINR_SS    Synchronous counter alarm value in Binary mode

\ SCB-CPUID (read-only)
: SCB-CPUID_Revision   ( %XXXX -- ) 0 lshift SCB-CPUID bis! ;  \ SCB-CPUID_Revision    Revision number
: SCB-CPUID_PartNo   ( %XXXXXXXXXXX -- ) 4 lshift SCB-CPUID bis! ;  \ SCB-CPUID_PartNo    Part number of the processor
: SCB-CPUID_Constant   ( %XXXX -- ) 16 lshift SCB-CPUID bis! ;  \ SCB-CPUID_Constant    Reads as $F
: SCB-CPUID_Variant   ( %XXXX -- ) 20 lshift SCB-CPUID bis! ;  \ SCB-CPUID_Variant    Variant number
: SCB-CPUID_Implementer   ( %XXXXXXXX -- ) 24 lshift SCB-CPUID bis! ;  \ SCB-CPUID_Implementer    Implementer code

\ SCB-ICSR (read-write)
: SCB-ICSR_VECTACTIVE   ( %XXXXXXXXX -- ) 0 lshift SCB-ICSR bis! ;  \ SCB-ICSR_VECTACTIVE    Active vector
: SCB-ICSR_RETTOBASE   %1 11 lshift SCB-ICSR bis! ;  \ SCB-ICSR_RETTOBASE    Return to base level
: SCB-ICSR_VECTPENDING   ( %XXXXXXX -- ) 12 lshift SCB-ICSR bis! ;  \ SCB-ICSR_VECTPENDING    Pending vector
: SCB-ICSR_ISRPENDING   %1 22 lshift SCB-ICSR bis! ;  \ SCB-ICSR_ISRPENDING    Interrupt pending flag
: SCB-ICSR_PENDSTCLR   %1 25 lshift SCB-ICSR bis! ;  \ SCB-ICSR_PENDSTCLR    SysTick exception clear-pending bit
: SCB-ICSR_PENDSTSET   %1 26 lshift SCB-ICSR bis! ;  \ SCB-ICSR_PENDSTSET    SysTick exception set-pending bit
: SCB-ICSR_PENDSVCLR   %1 27 lshift SCB-ICSR bis! ;  \ SCB-ICSR_PENDSVCLR    PendSV clear-pending bit
: SCB-ICSR_PENDSVSET   %1 28 lshift SCB-ICSR bis! ;  \ SCB-ICSR_PENDSVSET    PendSV set-pending bit
: SCB-ICSR_NMIPENDSET   %1 31 lshift SCB-ICSR bis! ;  \ SCB-ICSR_NMIPENDSET    NMI set-pending bit.

\ SCB-VTOR (read-write)
: SCB-VTOR_TBLOFF  9 lshift SCB-VTOR bis! ;  \ SCB-VTOR_TBLOFF    Vector table base offset field

\ SCB-AIRCR (read-write)
: SCB-AIRCR_VECTRESET   %1 0 lshift SCB-AIRCR bis! ;  \ SCB-AIRCR_VECTRESET    VECTRESET
: SCB-AIRCR_VECTCLRACTIVE   %1 1 lshift SCB-AIRCR bis! ;  \ SCB-AIRCR_VECTCLRACTIVE    VECTCLRACTIVE
: SCB-AIRCR_SYSRESETREQ   %1 2 lshift SCB-AIRCR bis! ;  \ SCB-AIRCR_SYSRESETREQ    SYSRESETREQ
: SCB-AIRCR_PRIGROUP   ( %XXX -- ) 8 lshift SCB-AIRCR bis! ;  \ SCB-AIRCR_PRIGROUP    PRIGROUP
: SCB-AIRCR_ENDIANESS   %1 15 lshift SCB-AIRCR bis! ;  \ SCB-AIRCR_ENDIANESS    ENDIANESS
: SCB-AIRCR_VECTKEYSTAT   ( %XXXXXXXXXXXXXXXX -- ) 16 lshift SCB-AIRCR bis! ;  \ SCB-AIRCR_VECTKEYSTAT    Register key

\ SCB-SCR (read-write)
: SCB-SCR_SLEEPONEXIT   %1 1 lshift SCB-SCR bis! ;  \ SCB-SCR_SLEEPONEXIT    SLEEPONEXIT
: SCB-SCR_SLEEPDEEP   %1 2 lshift SCB-SCR bis! ;  \ SCB-SCR_SLEEPDEEP    SLEEPDEEP
: SCB-SCR_SEVEONPEND   %1 4 lshift SCB-SCR bis! ;  \ SCB-SCR_SEVEONPEND    Send Event on Pending bit

\ SCB-CCR (read-write)
: SCB-CCR_NONBASETHRDENA   %1 0 lshift SCB-CCR bis! ;  \ SCB-CCR_NONBASETHRDENA    Configures how the processor enters Thread mode
: SCB-CCR_USERSETMPEND   %1 1 lshift SCB-CCR bis! ;  \ SCB-CCR_USERSETMPEND    USERSETMPEND
: SCB-CCR_UNALIGN__TRP   %1 3 lshift SCB-CCR bis! ;  \ SCB-CCR_UNALIGN__TRP    UNALIGN_ TRP
: SCB-CCR_DIV_0_TRP   %1 4 lshift SCB-CCR bis! ;  \ SCB-CCR_DIV_0_TRP    DIV_0_TRP
: SCB-CCR_BFHFNMIGN   %1 8 lshift SCB-CCR bis! ;  \ SCB-CCR_BFHFNMIGN    BFHFNMIGN
: SCB-CCR_STKALIGN   %1 9 lshift SCB-CCR bis! ;  \ SCB-CCR_STKALIGN    STKALIGN

\ SCB-SHPR1 (read-write)
: SCB-SHPR1_PRI_4   ( %XXXXXXXX -- ) 0 lshift SCB-SHPR1 bis! ;  \ SCB-SHPR1_PRI_4    Priority of system handler 4
: SCB-SHPR1_PRI_5   ( %XXXXXXXX -- ) 8 lshift SCB-SHPR1 bis! ;  \ SCB-SHPR1_PRI_5    Priority of system handler 5
: SCB-SHPR1_PRI_6   ( %XXXXXXXX -- ) 16 lshift SCB-SHPR1 bis! ;  \ SCB-SHPR1_PRI_6    Priority of system handler 6

\ SCB-SHPR2 (read-write)
: SCB-SHPR2_PRI_11   ( %XXXXXXXX -- ) 24 lshift SCB-SHPR2 bis! ;  \ SCB-SHPR2_PRI_11    Priority of system handler 11

\ SCB-SHPR3 (read-write)
: SCB-SHPR3_PRI_14   ( %XXXXXXXX -- ) 16 lshift SCB-SHPR3 bis! ;  \ SCB-SHPR3_PRI_14    Priority of system handler 14
: SCB-SHPR3_PRI_15   ( %XXXXXXXX -- ) 24 lshift SCB-SHPR3 bis! ;  \ SCB-SHPR3_PRI_15    Priority of system handler 15

\ SCB-SHCSR (read-write)
: SCB-SHCSR_MEMFAULTACT   %1 0 lshift SCB-SHCSR bis! ;  \ SCB-SHCSR_MEMFAULTACT    Memory management fault exception active bit
: SCB-SHCSR_BUSFAULTACT   %1 1 lshift SCB-SHCSR bis! ;  \ SCB-SHCSR_BUSFAULTACT    Bus fault exception active bit
: SCB-SHCSR_USGFAULTACT   %1 3 lshift SCB-SHCSR bis! ;  \ SCB-SHCSR_USGFAULTACT    Usage fault exception active bit
: SCB-SHCSR_SVCALLACT   %1 7 lshift SCB-SHCSR bis! ;  \ SCB-SHCSR_SVCALLACT    SVC call active bit
: SCB-SHCSR_MONITORACT   %1 8 lshift SCB-SHCSR bis! ;  \ SCB-SHCSR_MONITORACT    Debug monitor active bit
: SCB-SHCSR_PENDSVACT   %1 10 lshift SCB-SHCSR bis! ;  \ SCB-SHCSR_PENDSVACT    PendSV exception active bit
: SCB-SHCSR_SYSTICKACT   %1 11 lshift SCB-SHCSR bis! ;  \ SCB-SHCSR_SYSTICKACT    SysTick exception active bit
: SCB-SHCSR_USGFAULTPENDED   %1 12 lshift SCB-SHCSR bis! ;  \ SCB-SHCSR_USGFAULTPENDED    Usage fault exception pending bit
: SCB-SHCSR_MEMFAULTPENDED   %1 13 lshift SCB-SHCSR bis! ;  \ SCB-SHCSR_MEMFAULTPENDED    Memory management fault exception pending bit
: SCB-SHCSR_BUSFAULTPENDED   %1 14 lshift SCB-SHCSR bis! ;  \ SCB-SHCSR_BUSFAULTPENDED    Bus fault exception pending bit
: SCB-SHCSR_SVCALLPENDED   %1 15 lshift SCB-SHCSR bis! ;  \ SCB-SHCSR_SVCALLPENDED    SVC call pending bit
: SCB-SHCSR_MEMFAULTENA   %1 16 lshift SCB-SHCSR bis! ;  \ SCB-SHCSR_MEMFAULTENA    Memory management fault enable bit
: SCB-SHCSR_BUSFAULTENA   %1 17 lshift SCB-SHCSR bis! ;  \ SCB-SHCSR_BUSFAULTENA    Bus fault enable bit
: SCB-SHCSR_USGFAULTENA   %1 18 lshift SCB-SHCSR bis! ;  \ SCB-SHCSR_USGFAULTENA    Usage fault enable bit

\ SCB-CFSR_UFSR_BFSR_MMFSR (read-write)
: SCB-CFSR_UFSR_BFSR_MMFSR_IACCVIOL   %1 1 lshift SCB-CFSR_UFSR_BFSR_MMFSR bis! ;  \ SCB-CFSR_UFSR_BFSR_MMFSR_IACCVIOL    Instruction access violation flag
: SCB-CFSR_UFSR_BFSR_MMFSR_MUNSTKERR   %1 3 lshift SCB-CFSR_UFSR_BFSR_MMFSR bis! ;  \ SCB-CFSR_UFSR_BFSR_MMFSR_MUNSTKERR    Memory manager fault on unstacking for a return from exception
: SCB-CFSR_UFSR_BFSR_MMFSR_MSTKERR   %1 4 lshift SCB-CFSR_UFSR_BFSR_MMFSR bis! ;  \ SCB-CFSR_UFSR_BFSR_MMFSR_MSTKERR    Memory manager fault on stacking for exception entry.
: SCB-CFSR_UFSR_BFSR_MMFSR_MLSPERR   %1 5 lshift SCB-CFSR_UFSR_BFSR_MMFSR bis! ;  \ SCB-CFSR_UFSR_BFSR_MMFSR_MLSPERR    MLSPERR
: SCB-CFSR_UFSR_BFSR_MMFSR_MMARVALID   %1 7 lshift SCB-CFSR_UFSR_BFSR_MMFSR bis! ;  \ SCB-CFSR_UFSR_BFSR_MMFSR_MMARVALID    Memory Management Fault Address Register MMAR valid flag
: SCB-CFSR_UFSR_BFSR_MMFSR_IBUSERR   %1 8 lshift SCB-CFSR_UFSR_BFSR_MMFSR bis! ;  \ SCB-CFSR_UFSR_BFSR_MMFSR_IBUSERR    Instruction bus error
: SCB-CFSR_UFSR_BFSR_MMFSR_PRECISERR   %1 9 lshift SCB-CFSR_UFSR_BFSR_MMFSR bis! ;  \ SCB-CFSR_UFSR_BFSR_MMFSR_PRECISERR    Precise data bus error
: SCB-CFSR_UFSR_BFSR_MMFSR_IMPRECISERR   %1 10 lshift SCB-CFSR_UFSR_BFSR_MMFSR bis! ;  \ SCB-CFSR_UFSR_BFSR_MMFSR_IMPRECISERR    Imprecise data bus error
: SCB-CFSR_UFSR_BFSR_MMFSR_UNSTKERR   %1 11 lshift SCB-CFSR_UFSR_BFSR_MMFSR bis! ;  \ SCB-CFSR_UFSR_BFSR_MMFSR_UNSTKERR    Bus fault on unstacking for a return from exception
: SCB-CFSR_UFSR_BFSR_MMFSR_STKERR   %1 12 lshift SCB-CFSR_UFSR_BFSR_MMFSR bis! ;  \ SCB-CFSR_UFSR_BFSR_MMFSR_STKERR    Bus fault on stacking for exception entry
: SCB-CFSR_UFSR_BFSR_MMFSR_LSPERR   %1 13 lshift SCB-CFSR_UFSR_BFSR_MMFSR bis! ;  \ SCB-CFSR_UFSR_BFSR_MMFSR_LSPERR    Bus fault on floating-point lazy state preservation
: SCB-CFSR_UFSR_BFSR_MMFSR_BFARVALID   %1 15 lshift SCB-CFSR_UFSR_BFSR_MMFSR bis! ;  \ SCB-CFSR_UFSR_BFSR_MMFSR_BFARVALID    Bus Fault Address Register BFAR valid flag
: SCB-CFSR_UFSR_BFSR_MMFSR_UNDEFINSTR   %1 16 lshift SCB-CFSR_UFSR_BFSR_MMFSR bis! ;  \ SCB-CFSR_UFSR_BFSR_MMFSR_UNDEFINSTR    Undefined instruction usage fault
: SCB-CFSR_UFSR_BFSR_MMFSR_INVSTATE   %1 17 lshift SCB-CFSR_UFSR_BFSR_MMFSR bis! ;  \ SCB-CFSR_UFSR_BFSR_MMFSR_INVSTATE    Invalid state usage fault
: SCB-CFSR_UFSR_BFSR_MMFSR_INVPC   %1 18 lshift SCB-CFSR_UFSR_BFSR_MMFSR bis! ;  \ SCB-CFSR_UFSR_BFSR_MMFSR_INVPC    Invalid PC load usage fault
: SCB-CFSR_UFSR_BFSR_MMFSR_NOCP   %1 19 lshift SCB-CFSR_UFSR_BFSR_MMFSR bis! ;  \ SCB-CFSR_UFSR_BFSR_MMFSR_NOCP    No coprocessor usage fault.
: SCB-CFSR_UFSR_BFSR_MMFSR_UNALIGNED   %1 24 lshift SCB-CFSR_UFSR_BFSR_MMFSR bis! ;  \ SCB-CFSR_UFSR_BFSR_MMFSR_UNALIGNED    Unaligned access usage fault
: SCB-CFSR_UFSR_BFSR_MMFSR_DIVBYZERO   %1 25 lshift SCB-CFSR_UFSR_BFSR_MMFSR bis! ;  \ SCB-CFSR_UFSR_BFSR_MMFSR_DIVBYZERO    Divide by zero usage fault

\ SCB-HFSR (read-write)
: SCB-HFSR_VECTTBL   %1 1 lshift SCB-HFSR bis! ;  \ SCB-HFSR_VECTTBL    Vector table hard fault
: SCB-HFSR_FORCED   %1 30 lshift SCB-HFSR bis! ;  \ SCB-HFSR_FORCED    Forced hard fault
: SCB-HFSR_DEBUG_VT   %1 31 lshift SCB-HFSR bis! ;  \ SCB-HFSR_DEBUG_VT    Reserved for Debug use

\ SCB-MMFAR (read-write)
: SCB-MMFAR_MMFAR   ( %XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX -- ) 0 lshift SCB-MMFAR bis! ;  \ SCB-MMFAR_MMFAR    Memory management fault address

\ SCB-BFAR (read-write)
: SCB-BFAR_BFAR   ( %XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX -- ) 0 lshift SCB-BFAR bis! ;  \ SCB-BFAR_BFAR    Bus fault address

\ SCB-AFSR (read-write)
: SCB-AFSR_IMPDEF   ( %XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX -- ) 0 lshift SCB-AFSR bis! ;  \ SCB-AFSR_IMPDEF    Implementation defined

\ SCB_ACTRL-ACTRL (read-write)
: SCB_ACTRL-ACTRL_DISMCYCINT   %1 0 lshift SCB_ACTRL-ACTRL bis! ;  \ SCB_ACTRL-ACTRL_DISMCYCINT    DISMCYCINT
: SCB_ACTRL-ACTRL_DISDEFWBUF   %1 1 lshift SCB_ACTRL-ACTRL bis! ;  \ SCB_ACTRL-ACTRL_DISDEFWBUF    DISDEFWBUF
: SCB_ACTRL-ACTRL_DISFOLD   %1 2 lshift SCB_ACTRL-ACTRL bis! ;  \ SCB_ACTRL-ACTRL_DISFOLD    DISFOLD
: SCB_ACTRL-ACTRL_DISFPCA   %1 8 lshift SCB_ACTRL-ACTRL bis! ;  \ SCB_ACTRL-ACTRL_DISFPCA    DISFPCA
: SCB_ACTRL-ACTRL_DISOOFP   %1 9 lshift SCB_ACTRL-ACTRL bis! ;  \ SCB_ACTRL-ACTRL_DISOOFP    DISOOFP

\ SPI1-CR1 (read-write)
: SPI1-CR1_BIDIMODE   %1 15 lshift SPI1-CR1 bis! ;  \ SPI1-CR1_BIDIMODE    Bidirectional data mode enable
: SPI1-CR1_BIDIOE   %1 14 lshift SPI1-CR1 bis! ;  \ SPI1-CR1_BIDIOE    Output enable in bidirectional mode
: SPI1-CR1_CRCEN   %1 13 lshift SPI1-CR1 bis! ;  \ SPI1-CR1_CRCEN    Hardware CRC calculation enable
: SPI1-CR1_CRCNEXT   %1 12 lshift SPI1-CR1 bis! ;  \ SPI1-CR1_CRCNEXT    CRC transfer next
: SPI1-CR1_DFF   %1 11 lshift SPI1-CR1 bis! ;  \ SPI1-CR1_DFF    Data frame format
: SPI1-CR1_RXONLY   %1 10 lshift SPI1-CR1 bis! ;  \ SPI1-CR1_RXONLY    Receive only
: SPI1-CR1_SSM   %1 9 lshift SPI1-CR1 bis! ;  \ SPI1-CR1_SSM    Software slave management
: SPI1-CR1_SSI   %1 8 lshift SPI1-CR1 bis! ;  \ SPI1-CR1_SSI    Internal slave select
: SPI1-CR1_LSBFIRST   %1 7 lshift SPI1-CR1 bis! ;  \ SPI1-CR1_LSBFIRST    Frame format
: SPI1-CR1_SPE   %1 6 lshift SPI1-CR1 bis! ;  \ SPI1-CR1_SPE    SPI enable
: SPI1-CR1_BR   ( %XXX -- ) 3 lshift SPI1-CR1 bis! ;  \ SPI1-CR1_BR    Baud rate control
: SPI1-CR1_MSTR   %1 2 lshift SPI1-CR1 bis! ;  \ SPI1-CR1_MSTR    Master selection
: SPI1-CR1_CPOL   %1 1 lshift SPI1-CR1 bis! ;  \ SPI1-CR1_CPOL    Clock polarity
: SPI1-CR1_CPHA   %1 0 lshift SPI1-CR1 bis! ;  \ SPI1-CR1_CPHA    Clock phase

\ SPI1-CR2 (read-write)
: SPI1-CR2_RXDMAEN   %1 0 lshift SPI1-CR2 bis! ;  \ SPI1-CR2_RXDMAEN    Rx buffer DMA enable
: SPI1-CR2_TXDMAEN   %1 1 lshift SPI1-CR2 bis! ;  \ SPI1-CR2_TXDMAEN    Tx buffer DMA enable
: SPI1-CR2_SSOE   %1 2 lshift SPI1-CR2 bis! ;  \ SPI1-CR2_SSOE    SS output enable
: SPI1-CR2_NSSP   %1 3 lshift SPI1-CR2 bis! ;  \ SPI1-CR2_NSSP    NSS pulse management
: SPI1-CR2_FRF   %1 4 lshift SPI1-CR2 bis! ;  \ SPI1-CR2_FRF    Frame format
: SPI1-CR2_ERRIE   %1 5 lshift SPI1-CR2 bis! ;  \ SPI1-CR2_ERRIE    Error interrupt enable
: SPI1-CR2_RXNEIE   %1 6 lshift SPI1-CR2 bis! ;  \ SPI1-CR2_RXNEIE    RX buffer not empty interrupt enable
: SPI1-CR2_TXEIE   %1 7 lshift SPI1-CR2 bis! ;  \ SPI1-CR2_TXEIE    Tx buffer empty interrupt enable
: SPI1-CR2_DS   ( %XXXX -- ) 8 lshift SPI1-CR2 bis! ;  \ SPI1-CR2_DS    Data size
: SPI1-CR2_FRXTH   %1 12 lshift SPI1-CR2 bis! ;  \ SPI1-CR2_FRXTH    FIFO reception threshold
: SPI1-CR2_LDMA_RX   %1 13 lshift SPI1-CR2 bis! ;  \ SPI1-CR2_LDMA_RX    Last DMA transfer for reception
: SPI1-CR2_LDMA_TX   %1 14 lshift SPI1-CR2 bis! ;  \ SPI1-CR2_LDMA_TX    Last DMA transfer for transmission

\ SPI1-SR ()
: SPI1-SR_RXNE   %1 0 lshift SPI1-SR bis! ;  \ SPI1-SR_RXNE    Receive buffer not empty
: SPI1-SR_TXE   %1 1 lshift SPI1-SR bis! ;  \ SPI1-SR_TXE    Transmit buffer empty
: SPI1-SR_CHSIDE   %1 2 lshift SPI1-SR bis! ;  \ SPI1-SR_CHSIDE    CHSIDE
: SPI1-SR_UDR   %1 3 lshift SPI1-SR bis! ;  \ SPI1-SR_UDR    UDR
: SPI1-SR_CRCERR   %1 4 lshift SPI1-SR bis! ;  \ SPI1-SR_CRCERR    CRC error flag
: SPI1-SR_MODF   %1 5 lshift SPI1-SR bis! ;  \ SPI1-SR_MODF    Mode fault
: SPI1-SR_OVR   %1 6 lshift SPI1-SR bis! ;  \ SPI1-SR_OVR    Overrun flag
: SPI1-SR_BSY   %1 7 lshift SPI1-SR bis! ;  \ SPI1-SR_BSY    Busy flag
: SPI1-SR_TIFRFE   %1 8 lshift SPI1-SR bis! ;  \ SPI1-SR_TIFRFE    TI frame format error
: SPI1-SR_FRLVL   ( %XX -- ) 9 lshift SPI1-SR bis! ;  \ SPI1-SR_FRLVL    FIFO reception level
: SPI1-SR_FTLVL   ( %XX -- ) 11 lshift SPI1-SR bis! ;  \ SPI1-SR_FTLVL    FIFO transmission level

\ SPI1-DR (read-write)
: SPI1-DR_DR   ( %XXXXXXXXXXXXXXXX -- ) 0 lshift SPI1-DR bis! ;  \ SPI1-DR_DR    Data register

\ SPI1-CRCPR (read-write)
: SPI1-CRCPR_CRCPOLY   ( %XXXXXXXXXXXXXXXX -- ) 0 lshift SPI1-CRCPR bis! ;  \ SPI1-CRCPR_CRCPOLY    CRC polynomial register

\ SPI1-RXCRCR (read-only)
: SPI1-RXCRCR_RxCRC   ( %XXXXXXXXXXXXXXXX -- ) 0 lshift SPI1-RXCRCR bis! ;  \ SPI1-RXCRCR_RxCRC    Rx CRC register

\ SPI1-TXCRCR (read-only)
: SPI1-TXCRCR_TxCRC   ( %XXXXXXXXXXXXXXXX -- ) 0 lshift SPI1-TXCRCR bis! ;  \ SPI1-TXCRCR_TxCRC    Tx CRC register

\ SPI1-I2SCFGR (read-write)
: SPI1-I2SCFGR_CHLEN   %1 0 lshift SPI1-I2SCFGR bis! ;  \ SPI1-I2SCFGR_CHLEN    CHLEN
: SPI1-I2SCFGR_DATLEN   ( %XX -- ) 1 lshift SPI1-I2SCFGR bis! ;  \ SPI1-I2SCFGR_DATLEN    DATLEN
: SPI1-I2SCFGR_CKPOL   %1 3 lshift SPI1-I2SCFGR bis! ;  \ SPI1-I2SCFGR_CKPOL    CKPOL
: SPI1-I2SCFGR_I2SSTD   ( %XX -- ) 4 lshift SPI1-I2SCFGR bis! ;  \ SPI1-I2SCFGR_I2SSTD    I2SSTD
: SPI1-I2SCFGR_PCMSYNC   %1 7 lshift SPI1-I2SCFGR bis! ;  \ SPI1-I2SCFGR_PCMSYNC    PCMSYNC
: SPI1-I2SCFGR_I2SCFG   ( %XX -- ) 8 lshift SPI1-I2SCFGR bis! ;  \ SPI1-I2SCFGR_I2SCFG    I2SCFG
: SPI1-I2SCFGR_I2SE   %1 10 lshift SPI1-I2SCFGR bis! ;  \ SPI1-I2SCFGR_I2SE    I2SE
: SPI1-I2SCFGR_I2SMOD   %1 11 lshift SPI1-I2SCFGR bis! ;  \ SPI1-I2SCFGR_I2SMOD    I2SMOD
: SPI1-I2SCFGR_ASTRTEN   %1 12 lshift SPI1-I2SCFGR bis! ;  \ SPI1-I2SCFGR_ASTRTEN    ASTRTEN

\ SPI1-I2SPR (read-write)
: SPI1-I2SPR_I2SDIV   ( %XXXXXXXX -- ) 0 lshift SPI1-I2SPR bis! ;  \ SPI1-I2SPR_I2SDIV    I2SDIV
: SPI1-I2SPR_ODD   %1 8 lshift SPI1-I2SPR bis! ;  \ SPI1-I2SPR_ODD    ODD
: SPI1-I2SPR_MCKOE   %1 9 lshift SPI1-I2SPR bis! ;  \ SPI1-I2SPR_MCKOE    MCKOE

\ STK-CTRL (read-write)
: STK-CTRL_ENABLE   %1 0 lshift STK-CTRL bis! ;  \ STK-CTRL_ENABLE    Counter enable
: STK-CTRL_TICKINT   %1 1 lshift STK-CTRL bis! ;  \ STK-CTRL_TICKINT    SysTick exception request enable
: STK-CTRL_CLKSOURCE   %1 2 lshift STK-CTRL bis! ;  \ STK-CTRL_CLKSOURCE    Clock source selection
: STK-CTRL_COUNTFLAG   %1 16 lshift STK-CTRL bis! ;  \ STK-CTRL_COUNTFLAG    COUNTFLAG

\ STK-LOAD (read-write)
: STK-LOAD_RELOAD   ( %XXXXXXXXXXXXXXXXXXXXXXXX -- ) 0 lshift STK-LOAD bis! ;  \ STK-LOAD_RELOAD    RELOAD value

\ STK-VAL (read-write)
: STK-VAL_CURRENT   ( %XXXXXXXXXXXXXXXXXXXXXXXX -- ) 0 lshift STK-VAL bis! ;  \ STK-VAL_CURRENT    Current counter value

\ STK-CALIB (read-write)
: STK-CALIB_TENMS   ( %XXXXXXXXXXXXXXXXXXXXXXXX -- ) 0 lshift STK-CALIB bis! ;  \ STK-CALIB_TENMS    Calibration value
: STK-CALIB_SKEW   %1 30 lshift STK-CALIB bis! ;  \ STK-CALIB_SKEW    SKEW flag: Indicates whether the TENMS value is exact
: STK-CALIB_NOREF   %1 31 lshift STK-CALIB bis! ;  \ STK-CALIB_NOREF    NOREF flag. Reads as zero

\ SYSCFG-MEMRMP (read-write)
: SYSCFG-MEMRMP_MEM_MODE   ( %XXX -- ) 0 lshift SYSCFG-MEMRMP bis! ;  \ SYSCFG-MEMRMP_MEM_MODE    Memory mapping selection

\ SYSCFG-CFGR1 (read-write)
: SYSCFG-CFGR1_I2C3_FMP   %1 22 lshift SYSCFG-CFGR1 bis! ;  \ SYSCFG-CFGR1_I2C3_FMP    I2C3 Fast-mode Plus driving capability activation
: SYSCFG-CFGR1_I2C2_FMP   %1 21 lshift SYSCFG-CFGR1 bis! ;  \ SYSCFG-CFGR1_I2C2_FMP    I2C2 Fast-mode Plus driving capability activation
: SYSCFG-CFGR1_I2C1_FMP   %1 20 lshift SYSCFG-CFGR1 bis! ;  \ SYSCFG-CFGR1_I2C1_FMP    I2C1 Fast-mode Plus driving capability activation
: SYSCFG-CFGR1_I2C_PB9_FMP   %1 19 lshift SYSCFG-CFGR1 bis! ;  \ SYSCFG-CFGR1_I2C_PB9_FMP    Fast-mode Plus Fm+ driving capability activation on PB9
: SYSCFG-CFGR1_I2C_PB8_FMP   %1 18 lshift SYSCFG-CFGR1 bis! ;  \ SYSCFG-CFGR1_I2C_PB8_FMP    Fast-mode Plus Fm+ driving capability activation on PB8
: SYSCFG-CFGR1_I2C_PB7_FMP   %1 17 lshift SYSCFG-CFGR1 bis! ;  \ SYSCFG-CFGR1_I2C_PB7_FMP    Fast-mode Plus Fm+ driving capability activation on PB7
: SYSCFG-CFGR1_I2C_PB6_FMP   %1 16 lshift SYSCFG-CFGR1 bis! ;  \ SYSCFG-CFGR1_I2C_PB6_FMP    Fast-mode Plus Fm+ driving capability activation on PB6
: SYSCFG-CFGR1_BOOSTEN   %1 8 lshift SYSCFG-CFGR1 bis! ;  \ SYSCFG-CFGR1_BOOSTEN    I/O analog switch voltage booster enable

\ SYSCFG-EXTICR1 (read-write)
: SYSCFG-EXTICR1_EXTI3   ( %XXX -- ) 12 lshift SYSCFG-EXTICR1 bis! ;  \ SYSCFG-EXTICR1_EXTI3    EXTI 3 configuration bits
: SYSCFG-EXTICR1_EXTI2   ( %XXX -- ) 8 lshift SYSCFG-EXTICR1 bis! ;  \ SYSCFG-EXTICR1_EXTI2    EXTI 2 configuration bits
: SYSCFG-EXTICR1_EXTI1   ( %XXX -- ) 4 lshift SYSCFG-EXTICR1 bis! ;  \ SYSCFG-EXTICR1_EXTI1    EXTI 1 configuration bits
: SYSCFG-EXTICR1_EXTI0   ( %XXX -- ) 0 lshift SYSCFG-EXTICR1 bis! ;  \ SYSCFG-EXTICR1_EXTI0    EXTI 0 configuration bits

\ SYSCFG-EXTICR2 (read-write)
: SYSCFG-EXTICR2_EXTI7   ( %XXX -- ) 12 lshift SYSCFG-EXTICR2 bis! ;  \ SYSCFG-EXTICR2_EXTI7    EXTI 7 configuration bits
: SYSCFG-EXTICR2_EXTI6   ( %XXX -- ) 8 lshift SYSCFG-EXTICR2 bis! ;  \ SYSCFG-EXTICR2_EXTI6    EXTI 6 configuration bits
: SYSCFG-EXTICR2_EXTI5   ( %XXX -- ) 4 lshift SYSCFG-EXTICR2 bis! ;  \ SYSCFG-EXTICR2_EXTI5    EXTI 5 configuration bits
: SYSCFG-EXTICR2_EXTI4   ( %XXX -- ) 0 lshift SYSCFG-EXTICR2 bis! ;  \ SYSCFG-EXTICR2_EXTI4    EXTI 4 configuration bits

\ SYSCFG-EXTICR3 (read-write)
: SYSCFG-EXTICR3_EXTI11   ( %XXX -- ) 12 lshift SYSCFG-EXTICR3 bis! ;  \ SYSCFG-EXTICR3_EXTI11    EXTI 11 configuration bits
: SYSCFG-EXTICR3_EXTI10   ( %XXX -- ) 8 lshift SYSCFG-EXTICR3 bis! ;  \ SYSCFG-EXTICR3_EXTI10    EXTI 10 configuration bits
: SYSCFG-EXTICR3_EXTI9   ( %XXX -- ) 4 lshift SYSCFG-EXTICR3 bis! ;  \ SYSCFG-EXTICR3_EXTI9    EXTI 9 configuration bits
: SYSCFG-EXTICR3_EXTI8   ( %XXX -- ) 0 lshift SYSCFG-EXTICR3 bis! ;  \ SYSCFG-EXTICR3_EXTI8    EXTI 8 configuration bits

\ SYSCFG-EXTICR4 (read-write)
: SYSCFG-EXTICR4_EXTI15   ( %XXX -- ) 12 lshift SYSCFG-EXTICR4 bis! ;  \ SYSCFG-EXTICR4_EXTI15    EXTI15 configuration bits
: SYSCFG-EXTICR4_EXTI14   ( %XXX -- ) 8 lshift SYSCFG-EXTICR4 bis! ;  \ SYSCFG-EXTICR4_EXTI14    EXTI14 configuration bits
: SYSCFG-EXTICR4_EXTI13   ( %XXX -- ) 4 lshift SYSCFG-EXTICR4 bis! ;  \ SYSCFG-EXTICR4_EXTI13    EXTI13 configuration bits
: SYSCFG-EXTICR4_EXTI12   ( %XXX -- ) 0 lshift SYSCFG-EXTICR4 bis! ;  \ SYSCFG-EXTICR4_EXTI12    EXTI12 configuration bits

\ SYSCFG-SCSR ()
: SYSCFG-SCSR_PKASRAMBSY   %1 8 lshift SYSCFG-SCSR bis! ;  \ SYSCFG-SCSR_PKASRAMBSY    PKA SRAM busy by erase operation
: SYSCFG-SCSR_SRAMBSY   %1 1 lshift SYSCFG-SCSR bis! ;  \ SYSCFG-SCSR_SRAMBSY    SRAM1, SRAM2 and PKA SRAM busy by erase operation
: SYSCFG-SCSR_SRAM2ER   %1 0 lshift SYSCFG-SCSR bis! ;  \ SYSCFG-SCSR_SRAM2ER    SRAM2 erase

\ SYSCFG-CFGR2 ()
: SYSCFG-CFGR2_SPF   %1 8 lshift SYSCFG-CFGR2 bis! ;  \ SYSCFG-CFGR2_SPF    SRAM2 parity error flag
: SYSCFG-CFGR2_ECCL   %1 3 lshift SYSCFG-CFGR2 bis! ;  \ SYSCFG-CFGR2_ECCL    ECC Lock
: SYSCFG-CFGR2_PVDL   %1 2 lshift SYSCFG-CFGR2 bis! ;  \ SYSCFG-CFGR2_PVDL    PVD lock enable bit
: SYSCFG-CFGR2_SPL   %1 1 lshift SYSCFG-CFGR2 bis! ;  \ SYSCFG-CFGR2_SPL    SRAM2 parity lock bit
: SYSCFG-CFGR2_CLL   %1 0 lshift SYSCFG-CFGR2 bis! ;  \ SYSCFG-CFGR2_CLL    CPU1 LOCKUP Hardfault output enable bit

\ SYSCFG-SWPR (read-write)
: SYSCFG-SWPR_P31WP   %1 31 lshift SYSCFG-SWPR bis! ;  \ SYSCFG-SWPR_P31WP    SRAM2 1Kbyte page 31 write protection
: SYSCFG-SWPR_P30WP   %1 30 lshift SYSCFG-SWPR bis! ;  \ SYSCFG-SWPR_P30WP    SRAM2 1Kbyte page 30 write protection
: SYSCFG-SWPR_P29WP   %1 29 lshift SYSCFG-SWPR bis! ;  \ SYSCFG-SWPR_P29WP    SRAM2 1Kbyte page 29 write protection
: SYSCFG-SWPR_P28WP   %1 28 lshift SYSCFG-SWPR bis! ;  \ SYSCFG-SWPR_P28WP    SRAM2 1Kbyte page 28 write protection
: SYSCFG-SWPR_P27WP   %1 27 lshift SYSCFG-SWPR bis! ;  \ SYSCFG-SWPR_P27WP    SRAM2 1Kbyte page 27 write protection
: SYSCFG-SWPR_P26WP   %1 26 lshift SYSCFG-SWPR bis! ;  \ SYSCFG-SWPR_P26WP    SRAM2 1Kbyte page 26 write protection
: SYSCFG-SWPR_P25WP   %1 25 lshift SYSCFG-SWPR bis! ;  \ SYSCFG-SWPR_P25WP    SRAM2 1Kbyte page 25 write protection
: SYSCFG-SWPR_P24WP   %1 24 lshift SYSCFG-SWPR bis! ;  \ SYSCFG-SWPR_P24WP    SRAM2 1Kbyte page 24 write protection
: SYSCFG-SWPR_P23WP   %1 23 lshift SYSCFG-SWPR bis! ;  \ SYSCFG-SWPR_P23WP    SRAM2 1Kbyte page 23 write protection
: SYSCFG-SWPR_P22WP   %1 22 lshift SYSCFG-SWPR bis! ;  \ SYSCFG-SWPR_P22WP    SRAM2 1Kbyte page 22 write protection
: SYSCFG-SWPR_P21WP   %1 21 lshift SYSCFG-SWPR bis! ;  \ SYSCFG-SWPR_P21WP    SRAM2 1Kbyte page 21 write protection
: SYSCFG-SWPR_P20WP   %1 20 lshift SYSCFG-SWPR bis! ;  \ SYSCFG-SWPR_P20WP    SRAM2 1Kbyte page 20 write protection
: SYSCFG-SWPR_P19WP   %1 19 lshift SYSCFG-SWPR bis! ;  \ SYSCFG-SWPR_P19WP    SRAM2 1Kbyte page 19 write protection
: SYSCFG-SWPR_P18WP   %1 18 lshift SYSCFG-SWPR bis! ;  \ SYSCFG-SWPR_P18WP    SRAM2 1Kbyte page 18 write protection
: SYSCFG-SWPR_P17WP   %1 17 lshift SYSCFG-SWPR bis! ;  \ SYSCFG-SWPR_P17WP    SRAM2 1Kbyte page 17 write protection
: SYSCFG-SWPR_P16WP   %1 16 lshift SYSCFG-SWPR bis! ;  \ SYSCFG-SWPR_P16WP    SRAM2 1Kbyte page 16 write protection
: SYSCFG-SWPR_P15WP   %1 15 lshift SYSCFG-SWPR bis! ;  \ SYSCFG-SWPR_P15WP    SRAM2 1Kbyte page 15 write protection
: SYSCFG-SWPR_P14WP   %1 14 lshift SYSCFG-SWPR bis! ;  \ SYSCFG-SWPR_P14WP    SRAM2 1Kbyte page 14 write protection
: SYSCFG-SWPR_P13WP   %1 13 lshift SYSCFG-SWPR bis! ;  \ SYSCFG-SWPR_P13WP    SRAM2 1Kbyte page 13 write protection
: SYSCFG-SWPR_P12WP   %1 12 lshift SYSCFG-SWPR bis! ;  \ SYSCFG-SWPR_P12WP    SRAM2 1Kbyte page 12 write protection
: SYSCFG-SWPR_P11WP   %1 11 lshift SYSCFG-SWPR bis! ;  \ SYSCFG-SWPR_P11WP    SRAM2 1Kbyte page 11 write protection
: SYSCFG-SWPR_P10WP   %1 10 lshift SYSCFG-SWPR bis! ;  \ SYSCFG-SWPR_P10WP    SRAM2 1Kbyte page 10 write protection
: SYSCFG-SWPR_P9WP   %1 9 lshift SYSCFG-SWPR bis! ;  \ SYSCFG-SWPR_P9WP    SRAM2 1Kbyte page 9 write protection
: SYSCFG-SWPR_P8WP   %1 8 lshift SYSCFG-SWPR bis! ;  \ SYSCFG-SWPR_P8WP    SRAM2 1Kbyte page 8 write protection
: SYSCFG-SWPR_P7WP   %1 7 lshift SYSCFG-SWPR bis! ;  \ SYSCFG-SWPR_P7WP    SRAM2 1Kbyte page 7 write protection
: SYSCFG-SWPR_P6WP   %1 6 lshift SYSCFG-SWPR bis! ;  \ SYSCFG-SWPR_P6WP    SRAM2 1Kbyte page 6 write protection
: SYSCFG-SWPR_P5WP   %1 5 lshift SYSCFG-SWPR bis! ;  \ SYSCFG-SWPR_P5WP    SRAM2 1Kbyte page 5 write protection
: SYSCFG-SWPR_P4WP   %1 4 lshift SYSCFG-SWPR bis! ;  \ SYSCFG-SWPR_P4WP    SRAM2 1Kbyte page 4 write protection
: SYSCFG-SWPR_P3WP   %1 3 lshift SYSCFG-SWPR bis! ;  \ SYSCFG-SWPR_P3WP    SRAM2 1Kbyte page 3 write protection
: SYSCFG-SWPR_P2WP   %1 2 lshift SYSCFG-SWPR bis! ;  \ SYSCFG-SWPR_P2WP    SRAM2 1Kbyte page 2 write protection
: SYSCFG-SWPR_P1WP   %1 1 lshift SYSCFG-SWPR bis! ;  \ SYSCFG-SWPR_P1WP    SRAM2 1Kbyte page 1 write protection
: SYSCFG-SWPR_P0WP   %1 0 lshift SYSCFG-SWPR bis! ;  \ SYSCFG-SWPR_P0WP    SRAM2 1Kbyte page 0 write protection

\ SYSCFG-SKR (write-only)
: SYSCFG-SKR_KEY   ( %XXXXXXXX -- ) 0 lshift SYSCFG-SKR bis! ;  \ SYSCFG-SKR_KEY    SRAM2 write protection key for software erase

\ SYSCFG-RFDCR (read-write)
: SYSCFG-RFDCR_RFTBSEL   %1 0 lshift SYSCFG-RFDCR bis! ;  \ SYSCFG-RFDCR_RFTBSEL    radio debug test bus selection

\ SYSCFG_continue-IMR1 (read-write)
: SYSCFG_continue-IMR1_EXTI15IM   %1 31 lshift SYSCFG_continue-IMR1 bis! ;  \ SYSCFG_continue-IMR1_EXTI15IM    Peripheral EXTI15 interrupt mask to CPU1
: SYSCFG_continue-IMR1_EXTI14IM   %1 30 lshift SYSCFG_continue-IMR1 bis! ;  \ SYSCFG_continue-IMR1_EXTI14IM    Peripheral EXTI14 interrupt mask to CPU1
: SYSCFG_continue-IMR1_EXTI13IM   %1 29 lshift SYSCFG_continue-IMR1 bis! ;  \ SYSCFG_continue-IMR1_EXTI13IM    Peripheral EXTI13 interrupt mask to CPU1
: SYSCFG_continue-IMR1_EXTI12IM   %1 28 lshift SYSCFG_continue-IMR1 bis! ;  \ SYSCFG_continue-IMR1_EXTI12IM    Peripheral EXTI12 interrupt mask to CPU1
: SYSCFG_continue-IMR1_EXTI11IM   %1 27 lshift SYSCFG_continue-IMR1 bis! ;  \ SYSCFG_continue-IMR1_EXTI11IM    Peripheral EXTI11 interrupt mask to CPU1
: SYSCFG_continue-IMR1_EXTI10IM   %1 26 lshift SYSCFG_continue-IMR1 bis! ;  \ SYSCFG_continue-IMR1_EXTI10IM    Peripheral EXTI10 interrupt mask to CPU1
: SYSCFG_continue-IMR1_EXTI9IM   %1 25 lshift SYSCFG_continue-IMR1 bis! ;  \ SYSCFG_continue-IMR1_EXTI9IM    Peripheral EXTI9 interrupt mask to CPU1
: SYSCFG_continue-IMR1_EXTI8IM   %1 24 lshift SYSCFG_continue-IMR1 bis! ;  \ SYSCFG_continue-IMR1_EXTI8IM    Peripheral EXTI8 interrupt mask to CPU1
: SYSCFG_continue-IMR1_EXTI7IM   %1 23 lshift SYSCFG_continue-IMR1 bis! ;  \ SYSCFG_continue-IMR1_EXTI7IM    Peripheral EXTI7 interrupt mask to CPU1
: SYSCFG_continue-IMR1_EXTI6IM   %1 22 lshift SYSCFG_continue-IMR1 bis! ;  \ SYSCFG_continue-IMR1_EXTI6IM    Peripheral EXTI6 interrupt mask to CPU1
: SYSCFG_continue-IMR1_EXTI5IM   %1 21 lshift SYSCFG_continue-IMR1 bis! ;  \ SYSCFG_continue-IMR1_EXTI5IM    Peripheral EXTI5 interrupt mask to CPU1
: SYSCFG_continue-IMR1_RTCSSRUIM   %1 2 lshift SYSCFG_continue-IMR1 bis! ;  \ SYSCFG_continue-IMR1_RTCSSRUIM    RTCSSRUIM
: SYSCFG_continue-IMR1_RTCSTAMPTAMPLSECSSIM   %1 0 lshift SYSCFG_continue-IMR1 bis! ;  \ SYSCFG_continue-IMR1_RTCSTAMPTAMPLSECSSIM    RTCSTAMPTAMPLSECSSIM

\ SYSCFG_continue-IMR2 (read-write)
: SYSCFG_continue-IMR2_PVDIM   %1 20 lshift SYSCFG_continue-IMR2 bis! ;  \ SYSCFG_continue-IMR2_PVDIM    Peripheral xxx interrupt mask to CPU1
: SYSCFG_continue-IMR2_PVM3IM   %1 18 lshift SYSCFG_continue-IMR2 bis! ;  \ SYSCFG_continue-IMR2_PVM3IM    Peripheral xxx interrupt mask to CPU1

\ SYSCFG_continue-C2IMR1 (read-write)
: SYSCFG_continue-C2IMR1_EXTI15IM   %1 31 lshift SYSCFG_continue-C2IMR1 bis! ;  \ SYSCFG_continue-C2IMR1_EXTI15IM    Peripheral EXTI15 interrupt mask to CPU2
: SYSCFG_continue-C2IMR1_EXTI14IM   %1 30 lshift SYSCFG_continue-C2IMR1 bis! ;  \ SYSCFG_continue-C2IMR1_EXTI14IM    Peripheral EXTI14 interrupt mask to CPU2
: SYSCFG_continue-C2IMR1_EXTI13IM   %1 29 lshift SYSCFG_continue-C2IMR1 bis! ;  \ SYSCFG_continue-C2IMR1_EXTI13IM    Peripheral EXTI13 interrupt mask to CPU2
: SYSCFG_continue-C2IMR1_EXTI12IM   %1 28 lshift SYSCFG_continue-C2IMR1 bis! ;  \ SYSCFG_continue-C2IMR1_EXTI12IM    Peripheral EXTI12 interrupt mask to CPU2
: SYSCFG_continue-C2IMR1_EXTI11IM   %1 27 lshift SYSCFG_continue-C2IMR1 bis! ;  \ SYSCFG_continue-C2IMR1_EXTI11IM    Peripheral EXTI11 interrupt mask to CPU2
: SYSCFG_continue-C2IMR1_EXTI10IM   %1 26 lshift SYSCFG_continue-C2IMR1 bis! ;  \ SYSCFG_continue-C2IMR1_EXTI10IM    Peripheral EXTI10 interrupt mask to CPU2
: SYSCFG_continue-C2IMR1_EXTI9IM   %1 25 lshift SYSCFG_continue-C2IMR1 bis! ;  \ SYSCFG_continue-C2IMR1_EXTI9IM    Peripheral EXTI9 interrupt mask to CPU2
: SYSCFG_continue-C2IMR1_EXTI8IM   %1 24 lshift SYSCFG_continue-C2IMR1 bis! ;  \ SYSCFG_continue-C2IMR1_EXTI8IM    Peripheral EXTI8 interrupt mask to CPU2
: SYSCFG_continue-C2IMR1_EXTI7IM   %1 23 lshift SYSCFG_continue-C2IMR1 bis! ;  \ SYSCFG_continue-C2IMR1_EXTI7IM    Peripheral EXTI7 interrupt mask to CPU2
: SYSCFG_continue-C2IMR1_EXTI6IM   %1 22 lshift SYSCFG_continue-C2IMR1 bis! ;  \ SYSCFG_continue-C2IMR1_EXTI6IM    Peripheral EXTI6 interrupt mask to CPU2
: SYSCFG_continue-C2IMR1_EXTI5IM   %1 21 lshift SYSCFG_continue-C2IMR1 bis! ;  \ SYSCFG_continue-C2IMR1_EXTI5IM    Peripheral EXTI5 interrupt mask to CPU2
: SYSCFG_continue-C2IMR1_EXTI4IM   %1 20 lshift SYSCFG_continue-C2IMR1 bis! ;  \ SYSCFG_continue-C2IMR1_EXTI4IM    Peripheral EXTI4 interrupt mask to CPU2
: SYSCFG_continue-C2IMR1_EXTI3IM   %1 19 lshift SYSCFG_continue-C2IMR1 bis! ;  \ SYSCFG_continue-C2IMR1_EXTI3IM    Peripheral EXTI3 interrupt mask to CPU2
: SYSCFG_continue-C2IMR1_EXTI2IM   %1 18 lshift SYSCFG_continue-C2IMR1 bis! ;  \ SYSCFG_continue-C2IMR1_EXTI2IM    Peripheral EXTI2 interrupt mask to CPU2
: SYSCFG_continue-C2IMR1_EXTI1IM   %1 17 lshift SYSCFG_continue-C2IMR1 bis! ;  \ SYSCFG_continue-C2IMR1_EXTI1IM    Peripheral EXTI1 interrupt mask to CPU2
: SYSCFG_continue-C2IMR1_EXTI0IM   %1 16 lshift SYSCFG_continue-C2IMR1 bis! ;  \ SYSCFG_continue-C2IMR1_EXTI0IM    Peripheral EXTI0 interrupt mask to CPU2
: SYSCFG_continue-C2IMR1_DAC1IM   %1 13 lshift SYSCFG_continue-C2IMR1 bis! ;  \ SYSCFG_continue-C2IMR1_DAC1IM    Peripheral DAC1 interrupt mask to CPU2
: SYSCFG_continue-C2IMR1_ADCIM   %1 12 lshift SYSCFG_continue-C2IMR1 bis! ;  \ SYSCFG_continue-C2IMR1_ADCIM    Peripheral ADC interrupt mask to CPU2
: SYSCFG_continue-C2IMR1_COMPIM   %1 11 lshift SYSCFG_continue-C2IMR1 bis! ;  \ SYSCFG_continue-C2IMR1_COMPIM    Peripheral COMP interrupt mask to CPU2
: SYSCFG_continue-C2IMR1_FLASHIM   %1 6 lshift SYSCFG_continue-C2IMR1 bis! ;  \ SYSCFG_continue-C2IMR1_FLASHIM    Peripheral FLASH interrupt mask to CPU2
: SYSCFG_continue-C2IMR1_RCCIM   %1 5 lshift SYSCFG_continue-C2IMR1 bis! ;  \ SYSCFG_continue-C2IMR1_RCCIM    Peripheral RCC interrupt mask to CPU2
: SYSCFG_continue-C2IMR1_RTCWKUPIM   %1 3 lshift SYSCFG_continue-C2IMR1 bis! ;  \ SYSCFG_continue-C2IMR1_RTCWKUPIM    Peripheral RTCWKUP interrupt mask to CPU2
: SYSCFG_continue-C2IMR1_RTCSSRUIM   %1 2 lshift SYSCFG_continue-C2IMR1 bis! ;  \ SYSCFG_continue-C2IMR1_RTCSSRUIM    RTCSSRUIM
: SYSCFG_continue-C2IMR1_RTCALARMIM   %1 1 lshift SYSCFG_continue-C2IMR1 bis! ;  \ SYSCFG_continue-C2IMR1_RTCALARMIM    Peripheral RTCALARM interrupt mask to CPU2
: SYSCFG_continue-C2IMR1_RTCSTAMPTAMPLSECSSIM   %1 0 lshift SYSCFG_continue-C2IMR1 bis! ;  \ SYSCFG_continue-C2IMR1_RTCSTAMPTAMPLSECSSIM    Peripheral RTCSTAMPTAMPLSECSS interrupt mask to CPU2
: SYSCFG_continue-C2IMR1_AES1IM   %1 10 lshift SYSCFG_continue-C2IMR1 bis! ;  \ SYSCFG_continue-C2IMR1_AES1IM    AES1IM
: SYSCFG_continue-C2IMR1_PKAIM   %1 8 lshift SYSCFG_continue-C2IMR1 bis! ;  \ SYSCFG_continue-C2IMR1_PKAIM    PKAIM

\ SYSCFG_continue-C2IMR2 (read-write)
: SYSCFG_continue-C2IMR2_PVDIM   %1 20 lshift SYSCFG_continue-C2IMR2 bis! ;  \ SYSCFG_continue-C2IMR2_PVDIM    Peripheral PVD interrupt mask to CPU2
: SYSCFG_continue-C2IMR2_PVM3IM   %1 18 lshift SYSCFG_continue-C2IMR2 bis! ;  \ SYSCFG_continue-C2IMR2_PVM3IM    Peripheral PVM3 interrupt mask to CPU2
: SYSCFG_continue-C2IMR2_DMAMUX1IM   %1 15 lshift SYSCFG_continue-C2IMR2 bis! ;  \ SYSCFG_continue-C2IMR2_DMAMUX1IM    Peripheral DMAMUX1 interrupt mask to CPU2
: SYSCFG_continue-C2IMR2_DMA2CH7IM   %1 14 lshift SYSCFG_continue-C2IMR2 bis! ;  \ SYSCFG_continue-C2IMR2_DMA2CH7IM    Peripheral DMA2CH7 interrupt mask to CPU2
: SYSCFG_continue-C2IMR2_DMA2CH6IM   %1 13 lshift SYSCFG_continue-C2IMR2 bis! ;  \ SYSCFG_continue-C2IMR2_DMA2CH6IM    Peripheral DMA2CH6 interrupt mask to CPU2
: SYSCFG_continue-C2IMR2_DMA2CH5IM   %1 12 lshift SYSCFG_continue-C2IMR2 bis! ;  \ SYSCFG_continue-C2IMR2_DMA2CH5IM    Peripheral DMA2CH5 interrupt mask to CPU2
: SYSCFG_continue-C2IMR2_DMA2CH4IM   %1 11 lshift SYSCFG_continue-C2IMR2 bis! ;  \ SYSCFG_continue-C2IMR2_DMA2CH4IM    Peripheral DMA2CH4 interrupt mask to CPU2
: SYSCFG_continue-C2IMR2_DMA2CH3IM   %1 10 lshift SYSCFG_continue-C2IMR2 bis! ;  \ SYSCFG_continue-C2IMR2_DMA2CH3IM    Peripheral DMA2CH3 interrupt mask to CPU2
: SYSCFG_continue-C2IMR2_DMA2CH2IM   %1 9 lshift SYSCFG_continue-C2IMR2 bis! ;  \ SYSCFG_continue-C2IMR2_DMA2CH2IM    Peripheral DMA2CH2 interrupt mask to CPU2
: SYSCFG_continue-C2IMR2_DMA2CH1IM   %1 8 lshift SYSCFG_continue-C2IMR2 bis! ;  \ SYSCFG_continue-C2IMR2_DMA2CH1IM    Peripheral DMA2CH1 interrupt mask to CPU2
: SYSCFG_continue-C2IMR2_DMA1CH7IM   %1 6 lshift SYSCFG_continue-C2IMR2 bis! ;  \ SYSCFG_continue-C2IMR2_DMA1CH7IM    Peripheral DMA1CH7 interrupt mask to CPU2
: SYSCFG_continue-C2IMR2_DMA1CH6IM   %1 5 lshift SYSCFG_continue-C2IMR2 bis! ;  \ SYSCFG_continue-C2IMR2_DMA1CH6IM    Peripheral DMA1CH6 interrupt mask to CPU2
: SYSCFG_continue-C2IMR2_DMA1CH5IM   %1 4 lshift SYSCFG_continue-C2IMR2 bis! ;  \ SYSCFG_continue-C2IMR2_DMA1CH5IM    Peripheral DMA1CH5 interrupt mask to CPU2
: SYSCFG_continue-C2IMR2_DMA1CH4IM   %1 3 lshift SYSCFG_continue-C2IMR2 bis! ;  \ SYSCFG_continue-C2IMR2_DMA1CH4IM    Peripheral DMA1CH4 interrupt mask to CPU2
: SYSCFG_continue-C2IMR2_DMA1CH3IM   %1 2 lshift SYSCFG_continue-C2IMR2 bis! ;  \ SYSCFG_continue-C2IMR2_DMA1CH3IM    Peripheral DMA1CH3 interrupt mask to CPU2
: SYSCFG_continue-C2IMR2_DMA1CH2IM   %1 1 lshift SYSCFG_continue-C2IMR2 bis! ;  \ SYSCFG_continue-C2IMR2_DMA1CH2IM    Peripheral DMA1CH2 interrupt mask to CPU2
: SYSCFG_continue-C2IMR2_DMA1CH1IM   %1 0 lshift SYSCFG_continue-C2IMR2 bis! ;  \ SYSCFG_continue-C2IMR2_DMA1CH1IM    Peripheral DMA1CH1 interrupt mask to CPU2

\ TIM16-CR1 (read-write)
: TIM16-CR1_UIFREMAP   %1 11 lshift TIM16-CR1 bis! ;  \ TIM16-CR1_UIFREMAP    UIF status bit remapping
: TIM16-CR1_CKD   ( %XX -- ) 8 lshift TIM16-CR1 bis! ;  \ TIM16-CR1_CKD    Clock division
: TIM16-CR1_ARPE   %1 7 lshift TIM16-CR1 bis! ;  \ TIM16-CR1_ARPE    Auto-reload preload enable
: TIM16-CR1_OPM   %1 3 lshift TIM16-CR1 bis! ;  \ TIM16-CR1_OPM    One pulse mode
: TIM16-CR1_URS   %1 2 lshift TIM16-CR1 bis! ;  \ TIM16-CR1_URS    Update request source
: TIM16-CR1_UDIS   %1 1 lshift TIM16-CR1 bis! ;  \ TIM16-CR1_UDIS    Update disable
: TIM16-CR1_CEN   %1 0 lshift TIM16-CR1 bis! ;  \ TIM16-CR1_CEN    Counter enable

\ TIM16-CR2 (read-write)
: TIM16-CR2_OIS1N   %1 9 lshift TIM16-CR2 bis! ;  \ TIM16-CR2_OIS1N    OIS1N
: TIM16-CR2_OIS1   %1 8 lshift TIM16-CR2 bis! ;  \ TIM16-CR2_OIS1    OIS1
: TIM16-CR2_CCDS   %1 3 lshift TIM16-CR2 bis! ;  \ TIM16-CR2_CCDS    CCDS
: TIM16-CR2_CCUS   %1 2 lshift TIM16-CR2 bis! ;  \ TIM16-CR2_CCUS    CCUS
: TIM16-CR2_CCPC   %1 0 lshift TIM16-CR2 bis! ;  \ TIM16-CR2_CCPC    CCPC

\ TIM16-DIER (read-write)
: TIM16-DIER_COMDE   %1 13 lshift TIM16-DIER bis! ;  \ TIM16-DIER_COMDE    COM DMA request enable
: TIM16-DIER_CC1DE   %1 9 lshift TIM16-DIER bis! ;  \ TIM16-DIER_CC1DE    Capture/Compare 1 DMA request enable
: TIM16-DIER_UDE   %1 8 lshift TIM16-DIER bis! ;  \ TIM16-DIER_UDE    Update DMA request enable
: TIM16-DIER_BIE   %1 7 lshift TIM16-DIER bis! ;  \ TIM16-DIER_BIE    Break interrupt enable
: TIM16-DIER_COMIE   %1 5 lshift TIM16-DIER bis! ;  \ TIM16-DIER_COMIE    COM interrupt enable
: TIM16-DIER_CC1IE   %1 1 lshift TIM16-DIER bis! ;  \ TIM16-DIER_CC1IE    Capture/Compare 1 interrupt enable
: TIM16-DIER_UIE   %1 0 lshift TIM16-DIER bis! ;  \ TIM16-DIER_UIE    Update interrupt enable

\ TIM16-SR (read-write)
: TIM16-SR_CC1OF   %1 9 lshift TIM16-SR bis! ;  \ TIM16-SR_CC1OF    Capture/Compare 1 overcapture flag
: TIM16-SR_BIF   %1 7 lshift TIM16-SR bis! ;  \ TIM16-SR_BIF    Break interrupt flag
: TIM16-SR_COMIF   %1 5 lshift TIM16-SR bis! ;  \ TIM16-SR_COMIF    COM interrupt flag
: TIM16-SR_CC1IF   %1 1 lshift TIM16-SR bis! ;  \ TIM16-SR_CC1IF    Capture/Compare 1 interrupt flag
: TIM16-SR_UIF   %1 0 lshift TIM16-SR bis! ;  \ TIM16-SR_UIF    Update interrupt flag

\ TIM16-EGR (write-only)
: TIM16-EGR_BG   %1 7 lshift TIM16-EGR bis! ;  \ TIM16-EGR_BG    Break generation
: TIM16-EGR_COMG   %1 5 lshift TIM16-EGR bis! ;  \ TIM16-EGR_COMG    Capture/Compare control update generation
: TIM16-EGR_CC1G   %1 1 lshift TIM16-EGR bis! ;  \ TIM16-EGR_CC1G    Capture/Compare 1 generation
: TIM16-EGR_UG   %1 0 lshift TIM16-EGR bis! ;  \ TIM16-EGR_UG    Update generation

\ TIM16-CCMR1_Output (read-write)
: TIM16-CCMR1_Output_OC1M_3   %1 16 lshift TIM16-CCMR1_Output bis! ;  \ TIM16-CCMR1_Output_OC1M_3    OC1M
: TIM16-CCMR1_Output_OC1M   ( %XXX -- ) 4 lshift TIM16-CCMR1_Output bis! ;  \ TIM16-CCMR1_Output_OC1M    OC1M
: TIM16-CCMR1_Output_OC1PE   %1 3 lshift TIM16-CCMR1_Output bis! ;  \ TIM16-CCMR1_Output_OC1PE    OC1PE
: TIM16-CCMR1_Output_OC1FE   %1 2 lshift TIM16-CCMR1_Output bis! ;  \ TIM16-CCMR1_Output_OC1FE    OC1FE
: TIM16-CCMR1_Output_CC1S   ( %XX -- ) 0 lshift TIM16-CCMR1_Output bis! ;  \ TIM16-CCMR1_Output_CC1S    CC1S

\ TIM16-CCMR1_Input (read-write)
: TIM16-CCMR1_Input_IC1F   ( %XXXX -- ) 4 lshift TIM16-CCMR1_Input bis! ;  \ TIM16-CCMR1_Input_IC1F    IC1F
: TIM16-CCMR1_Input_IC1PSC   ( %XX -- ) 2 lshift TIM16-CCMR1_Input bis! ;  \ TIM16-CCMR1_Input_IC1PSC    IC1PSC
: TIM16-CCMR1_Input_CC1S   ( %XX -- ) 0 lshift TIM16-CCMR1_Input bis! ;  \ TIM16-CCMR1_Input_CC1S    CC1S

\ TIM16-CCER (read-write)
: TIM16-CCER_CC1NP   %1 3 lshift TIM16-CCER bis! ;  \ TIM16-CCER_CC1NP    Capture/Compare 1 complementary output polarity
: TIM16-CCER_CC1NE   %1 2 lshift TIM16-CCER bis! ;  \ TIM16-CCER_CC1NE    Capture/Compare 1 complementary output enable
: TIM16-CCER_CC1P   %1 1 lshift TIM16-CCER bis! ;  \ TIM16-CCER_CC1P    Capture/Compare 1 output polarity
: TIM16-CCER_CC1E   %1 0 lshift TIM16-CCER bis! ;  \ TIM16-CCER_CC1E    Capture/Compare 1 output enable

\ TIM16-CNT ()
: TIM16-CNT_UIFCPYorRes   %1 31 lshift TIM16-CNT bis! ;  \ TIM16-CNT_UIFCPYorRes    UIF Copy
: TIM16-CNT_CNT   ( %XXXXXXXXXXXXXXXX -- ) 0 lshift TIM16-CNT bis! ;  \ TIM16-CNT_CNT    CNT

\ TIM16-PSC (read-write)
: TIM16-PSC_PSC   ( %XXXXXXXXXXXXXXXX -- ) 0 lshift TIM16-PSC bis! ;  \ TIM16-PSC_PSC    Prescaler value

\ TIM16-ARR (read-write)
: TIM16-ARR_ARR   ( %XXXXXXXXXXXXXXXX -- ) 0 lshift TIM16-ARR bis! ;  \ TIM16-ARR_ARR    Auto-reload value

\ TIM16-RCR (read-write)
: TIM16-RCR_REP   ( %XXXXXXXX -- ) 0 lshift TIM16-RCR bis! ;  \ TIM16-RCR_REP    Repetition counter value

\ TIM16-CCR1 (read-write)
: TIM16-CCR1_CCR1   ( %XXXXXXXXXXXXXXXX -- ) 0 lshift TIM16-CCR1 bis! ;  \ TIM16-CCR1_CCR1    Capture/Compare 1 value

\ TIM16-BDTR (read-write)
: TIM16-BDTR_BKBID   %1 28 lshift TIM16-BDTR bis! ;  \ TIM16-BDTR_BKBID    Break Bidirectional
: TIM16-BDTR_BKDSRM   %1 26 lshift TIM16-BDTR bis! ;  \ TIM16-BDTR_BKDSRM    Break Disarm
: TIM16-BDTR_BKF   ( %XXXX -- ) 16 lshift TIM16-BDTR bis! ;  \ TIM16-BDTR_BKF    Break filter
: TIM16-BDTR_MOE   %1 15 lshift TIM16-BDTR bis! ;  \ TIM16-BDTR_MOE    Main output enable
: TIM16-BDTR_AOE   %1 14 lshift TIM16-BDTR bis! ;  \ TIM16-BDTR_AOE    Automatic output enable
: TIM16-BDTR_BKP   %1 13 lshift TIM16-BDTR bis! ;  \ TIM16-BDTR_BKP    Break polarity
: TIM16-BDTR_BKE   %1 12 lshift TIM16-BDTR bis! ;  \ TIM16-BDTR_BKE    Break enable
: TIM16-BDTR_OSSR   %1 11 lshift TIM16-BDTR bis! ;  \ TIM16-BDTR_OSSR    Off-state selection for Run mode
: TIM16-BDTR_OSSI   %1 10 lshift TIM16-BDTR bis! ;  \ TIM16-BDTR_OSSI    Off-state selection for Idle mode
: TIM16-BDTR_LOCK   ( %XX -- ) 8 lshift TIM16-BDTR bis! ;  \ TIM16-BDTR_LOCK    Lock configuration
: TIM16-BDTR_DT   ( %XXXXXXXX -- ) 0 lshift TIM16-BDTR bis! ;  \ TIM16-BDTR_DT    Dead-time generator setup

\ TIM16-DCR (read-write)
: TIM16-DCR_DBL   ( %XXXXX -- ) 8 lshift TIM16-DCR bis! ;  \ TIM16-DCR_DBL    DMA burst length
: TIM16-DCR_DBA   ( %XXXXX -- ) 0 lshift TIM16-DCR bis! ;  \ TIM16-DCR_DBA    DMA base address

\ TIM16-DMAR (read-write)
: TIM16-DMAR_DMAB   ( %XXXXXXXXXXXXXXXX -- ) 0 lshift TIM16-DMAR bis! ;  \ TIM16-DMAR_DMAB    DMA register for burst accesses

\ TIM16-TIM16_OR1 (read-write)
: TIM16-TIM16_OR1_TI1_RMP   ( %XX -- ) 0 lshift TIM16-TIM16_OR1 bis! ;  \ TIM16-TIM16_OR1_TI1_RMP    Timer 17 input 1 connection

\ TIM16-TIM16_AF1 (read-write)
: TIM16-TIM16_AF1_BKCMP2P   %1 11 lshift TIM16-TIM16_AF1 bis! ;  \ TIM16-TIM16_AF1_BKCMP2P    BRK COMP2 input polarity
: TIM16-TIM16_AF1_BKCMP1P   %1 10 lshift TIM16-TIM16_AF1 bis! ;  \ TIM16-TIM16_AF1_BKCMP1P    BRK COMP1 input polarity
: TIM16-TIM16_AF1_BKINP   %1 9 lshift TIM16-TIM16_AF1 bis! ;  \ TIM16-TIM16_AF1_BKINP    BRK BKIN input polarity
: TIM16-TIM16_AF1_BKCMP2E   %1 2 lshift TIM16-TIM16_AF1 bis! ;  \ TIM16-TIM16_AF1_BKCMP2E    BRK COMP2 enable
: TIM16-TIM16_AF1_BKCMP1E   %1 1 lshift TIM16-TIM16_AF1 bis! ;  \ TIM16-TIM16_AF1_BKCMP1E    BRK COMP1 enable
: TIM16-TIM16_AF1_BKINE   %1 0 lshift TIM16-TIM16_AF1 bis! ;  \ TIM16-TIM16_AF1_BKINE    BRK BKIN input enable

\ TIM16-TIM16_TISEL (read-write)
: TIM16-TIM16_TISEL_TISEL   ( %XXXX -- ) 0 lshift TIM16-TIM16_TISEL bis! ;  \ TIM16-TIM16_TISEL_TISEL    TISEL

\ TIM17-CR1 (read-write)
: TIM17-CR1_UIFREMAP   %1 11 lshift TIM17-CR1 bis! ;  \ TIM17-CR1_UIFREMAP    UIF status bit remapping
: TIM17-CR1_CKD   ( %XX -- ) 8 lshift TIM17-CR1 bis! ;  \ TIM17-CR1_CKD    Clock division
: TIM17-CR1_ARPE   %1 7 lshift TIM17-CR1 bis! ;  \ TIM17-CR1_ARPE    Auto-reload preload enable
: TIM17-CR1_OPM   %1 3 lshift TIM17-CR1 bis! ;  \ TIM17-CR1_OPM    One pulse mode
: TIM17-CR1_URS   %1 2 lshift TIM17-CR1 bis! ;  \ TIM17-CR1_URS    Update request source
: TIM17-CR1_UDIS   %1 1 lshift TIM17-CR1 bis! ;  \ TIM17-CR1_UDIS    Update disable
: TIM17-CR1_CEN   %1 0 lshift TIM17-CR1 bis! ;  \ TIM17-CR1_CEN    Counter enable

\ TIM17-CR2 (read-write)
: TIM17-CR2_OIS1N   %1 9 lshift TIM17-CR2 bis! ;  \ TIM17-CR2_OIS1N    OIS1N
: TIM17-CR2_OIS1   %1 8 lshift TIM17-CR2 bis! ;  \ TIM17-CR2_OIS1    OIS1
: TIM17-CR2_CCDS   %1 3 lshift TIM17-CR2 bis! ;  \ TIM17-CR2_CCDS    CCDS
: TIM17-CR2_CCUS   %1 2 lshift TIM17-CR2 bis! ;  \ TIM17-CR2_CCUS    CCUS
: TIM17-CR2_CCPC   %1 0 lshift TIM17-CR2 bis! ;  \ TIM17-CR2_CCPC    CCPC

\ TIM17-DIER (read-write)
: TIM17-DIER_COMDE   %1 13 lshift TIM17-DIER bis! ;  \ TIM17-DIER_COMDE    COM DMA request enable
: TIM17-DIER_CC1DE   %1 9 lshift TIM17-DIER bis! ;  \ TIM17-DIER_CC1DE    Capture/Compare 1 DMA request enable
: TIM17-DIER_UDE   %1 8 lshift TIM17-DIER bis! ;  \ TIM17-DIER_UDE    Update DMA request enable
: TIM17-DIER_BIE   %1 7 lshift TIM17-DIER bis! ;  \ TIM17-DIER_BIE    Break interrupt enable
: TIM17-DIER_COMIE   %1 5 lshift TIM17-DIER bis! ;  \ TIM17-DIER_COMIE    COM interrupt enable
: TIM17-DIER_CC1IE   %1 1 lshift TIM17-DIER bis! ;  \ TIM17-DIER_CC1IE    Capture/Compare 1 interrupt enable
: TIM17-DIER_UIE   %1 0 lshift TIM17-DIER bis! ;  \ TIM17-DIER_UIE    Update interrupt enable

\ TIM17-SR (read-write)
: TIM17-SR_CC1OF   %1 9 lshift TIM17-SR bis! ;  \ TIM17-SR_CC1OF    Capture/Compare 1 overcapture flag
: TIM17-SR_BIF   %1 7 lshift TIM17-SR bis! ;  \ TIM17-SR_BIF    Break interrupt flag
: TIM17-SR_COMIF   %1 5 lshift TIM17-SR bis! ;  \ TIM17-SR_COMIF    COM interrupt flag
: TIM17-SR_CC1IF   %1 1 lshift TIM17-SR bis! ;  \ TIM17-SR_CC1IF    Capture/Compare 1 interrupt flag
: TIM17-SR_UIF   %1 0 lshift TIM17-SR bis! ;  \ TIM17-SR_UIF    Update interrupt flag

\ TIM17-EGR (write-only)
: TIM17-EGR_BG   %1 7 lshift TIM17-EGR bis! ;  \ TIM17-EGR_BG    Break generation
: TIM17-EGR_COMG   %1 5 lshift TIM17-EGR bis! ;  \ TIM17-EGR_COMG    Capture/Compare control update generation
: TIM17-EGR_CC1G   %1 1 lshift TIM17-EGR bis! ;  \ TIM17-EGR_CC1G    Capture/Compare 1 generation
: TIM17-EGR_UG   %1 0 lshift TIM17-EGR bis! ;  \ TIM17-EGR_UG    Update generation

\ TIM17-CCMR1_Output (read-write)
: TIM17-CCMR1_Output_OC1M_3   %1 16 lshift TIM17-CCMR1_Output bis! ;  \ TIM17-CCMR1_Output_OC1M_3    OC1M
: TIM17-CCMR1_Output_OC1M   ( %XXX -- ) 4 lshift TIM17-CCMR1_Output bis! ;  \ TIM17-CCMR1_Output_OC1M    OC1M
: TIM17-CCMR1_Output_OC1PE   %1 3 lshift TIM17-CCMR1_Output bis! ;  \ TIM17-CCMR1_Output_OC1PE    OC1PE
: TIM17-CCMR1_Output_OC1FE   %1 2 lshift TIM17-CCMR1_Output bis! ;  \ TIM17-CCMR1_Output_OC1FE    OC1FE
: TIM17-CCMR1_Output_CC1S   ( %XX -- ) 0 lshift TIM17-CCMR1_Output bis! ;  \ TIM17-CCMR1_Output_CC1S    CC1S

\ TIM17-CCMR1_Input (read-write)
: TIM17-CCMR1_Input_IC1F   ( %XXXX -- ) 4 lshift TIM17-CCMR1_Input bis! ;  \ TIM17-CCMR1_Input_IC1F    IC1F
: TIM17-CCMR1_Input_IC1PSC   ( %XX -- ) 2 lshift TIM17-CCMR1_Input bis! ;  \ TIM17-CCMR1_Input_IC1PSC    IC1PSC
: TIM17-CCMR1_Input_CC1S   ( %XX -- ) 0 lshift TIM17-CCMR1_Input bis! ;  \ TIM17-CCMR1_Input_CC1S    CC1S

\ TIM17-CCER (read-write)
: TIM17-CCER_CC1NP   %1 3 lshift TIM17-CCER bis! ;  \ TIM17-CCER_CC1NP    Capture/Compare 1 complementary output polarity
: TIM17-CCER_CC1NE   %1 2 lshift TIM17-CCER bis! ;  \ TIM17-CCER_CC1NE    Capture/Compare 1 complementary output enable
: TIM17-CCER_CC1P   %1 1 lshift TIM17-CCER bis! ;  \ TIM17-CCER_CC1P    Capture/Compare 1 output polarity
: TIM17-CCER_CC1E   %1 0 lshift TIM17-CCER bis! ;  \ TIM17-CCER_CC1E    Capture/Compare 1 output enable

\ TIM17-CNT ()
: TIM17-CNT_UIFCPYorRes   %1 31 lshift TIM17-CNT bis! ;  \ TIM17-CNT_UIFCPYorRes    UIF Copy
: TIM17-CNT_CNT   ( %XXXXXXXXXXXXXXXX -- ) 0 lshift TIM17-CNT bis! ;  \ TIM17-CNT_CNT    CNT

\ TIM17-PSC (read-write)
: TIM17-PSC_PSC   ( %XXXXXXXXXXXXXXXX -- ) 0 lshift TIM17-PSC bis! ;  \ TIM17-PSC_PSC    Prescaler value

\ TIM17-ARR (read-write)
: TIM17-ARR_ARR   ( %XXXXXXXXXXXXXXXX -- ) 0 lshift TIM17-ARR bis! ;  \ TIM17-ARR_ARR    Auto-reload value

\ TIM17-RCR (read-write)
: TIM17-RCR_REP   ( %XXXXXXXX -- ) 0 lshift TIM17-RCR bis! ;  \ TIM17-RCR_REP    Repetition counter value

\ TIM17-CCR1 (read-write)
: TIM17-CCR1_CCR1   ( %XXXXXXXXXXXXXXXX -- ) 0 lshift TIM17-CCR1 bis! ;  \ TIM17-CCR1_CCR1    Capture/Compare 1 value

\ TIM17-BDTR (read-write)
: TIM17-BDTR_BKBID   %1 28 lshift TIM17-BDTR bis! ;  \ TIM17-BDTR_BKBID    Break Bidirectional
: TIM17-BDTR_BKDSRM   %1 26 lshift TIM17-BDTR bis! ;  \ TIM17-BDTR_BKDSRM    Break Disarm
: TIM17-BDTR_BKF   ( %XXXX -- ) 16 lshift TIM17-BDTR bis! ;  \ TIM17-BDTR_BKF    Break filter
: TIM17-BDTR_MOE   %1 15 lshift TIM17-BDTR bis! ;  \ TIM17-BDTR_MOE    Main output enable
: TIM17-BDTR_AOE   %1 14 lshift TIM17-BDTR bis! ;  \ TIM17-BDTR_AOE    Automatic output enable
: TIM17-BDTR_BKP   %1 13 lshift TIM17-BDTR bis! ;  \ TIM17-BDTR_BKP    Break polarity
: TIM17-BDTR_BKE   %1 12 lshift TIM17-BDTR bis! ;  \ TIM17-BDTR_BKE    Break enable
: TIM17-BDTR_OSSR   %1 11 lshift TIM17-BDTR bis! ;  \ TIM17-BDTR_OSSR    Off-state selection for Run mode
: TIM17-BDTR_OSSI   %1 10 lshift TIM17-BDTR bis! ;  \ TIM17-BDTR_OSSI    Off-state selection for Idle mode
: TIM17-BDTR_LOCK   ( %XX -- ) 8 lshift TIM17-BDTR bis! ;  \ TIM17-BDTR_LOCK    Lock configuration
: TIM17-BDTR_DT   ( %XXXXXXXX -- ) 0 lshift TIM17-BDTR bis! ;  \ TIM17-BDTR_DT    Dead-time generator setup

\ TIM17-DCR (read-write)
: TIM17-DCR_DBL   ( %XXXXX -- ) 8 lshift TIM17-DCR bis! ;  \ TIM17-DCR_DBL    DMA burst length
: TIM17-DCR_DBA   ( %XXXXX -- ) 0 lshift TIM17-DCR bis! ;  \ TIM17-DCR_DBA    DMA base address

\ TIM17-DMAR (read-write)
: TIM17-DMAR_DMAB   ( %XXXXXXXXXXXXXXXX -- ) 0 lshift TIM17-DMAR bis! ;  \ TIM17-DMAR_DMAB    DMA register for burst accesses

\ TIM17-TIM17_OR1 (read-write)
: TIM17-TIM17_OR1_TI1_RMP   ( %XX -- ) 0 lshift TIM17-TIM17_OR1 bis! ;  \ TIM17-TIM17_OR1_TI1_RMP    Timer 17 input 1 connection

\ TIM17-TIM17_AF1 (read-write)
: TIM17-TIM17_AF1_BKCMP2P   %1 11 lshift TIM17-TIM17_AF1 bis! ;  \ TIM17-TIM17_AF1_BKCMP2P    BRK COMP2 input polarity
: TIM17-TIM17_AF1_BKCMP1P   %1 10 lshift TIM17-TIM17_AF1 bis! ;  \ TIM17-TIM17_AF1_BKCMP1P    BRK COMP1 input polarity
: TIM17-TIM17_AF1_BKINP   %1 9 lshift TIM17-TIM17_AF1 bis! ;  \ TIM17-TIM17_AF1_BKINP    BRK BKIN input polarity
: TIM17-TIM17_AF1_BKCMP2E   %1 2 lshift TIM17-TIM17_AF1 bis! ;  \ TIM17-TIM17_AF1_BKCMP2E    BRK COMP2 enable
: TIM17-TIM17_AF1_BKCMP1E   %1 1 lshift TIM17-TIM17_AF1 bis! ;  \ TIM17-TIM17_AF1_BKCMP1E    BRK COMP1 enable
: TIM17-TIM17_AF1_BKINE   %1 0 lshift TIM17-TIM17_AF1 bis! ;  \ TIM17-TIM17_AF1_BKINE    BRK BKIN input enable

\ TIM17-TIM17_TISEL (read-write)
: TIM17-TIM17_TISEL_TISEL   ( %XXXX -- ) 0 lshift TIM17-TIM17_TISEL bis! ;  \ TIM17-TIM17_TISEL_TISEL    TISEL

\ USART1-CR1 (read-write)
: USART1-CR1_RXFFIE   %1 31 lshift USART1-CR1 bis! ;  \ USART1-CR1_RXFFIE    RXFIFO Full interrupt enable
: USART1-CR1_TXFEIE   %1 30 lshift USART1-CR1 bis! ;  \ USART1-CR1_TXFEIE    TXFIFO empty interrupt enable
: USART1-CR1_FIFOEN   %1 29 lshift USART1-CR1 bis! ;  \ USART1-CR1_FIFOEN    FIFO mode enable
: USART1-CR1_M1   %1 28 lshift USART1-CR1 bis! ;  \ USART1-CR1_M1    Word length
: USART1-CR1_EOBIE   %1 27 lshift USART1-CR1 bis! ;  \ USART1-CR1_EOBIE    End of Block interrupt enable
: USART1-CR1_RTOIE   %1 26 lshift USART1-CR1 bis! ;  \ USART1-CR1_RTOIE    Receiver timeout interrupt enable
: USART1-CR1_DEAT4   %1 25 lshift USART1-CR1 bis! ;  \ USART1-CR1_DEAT4    Driver Enable assertion time
: USART1-CR1_DEAT3   %1 24 lshift USART1-CR1 bis! ;  \ USART1-CR1_DEAT3    DEAT3
: USART1-CR1_DEAT2   %1 23 lshift USART1-CR1 bis! ;  \ USART1-CR1_DEAT2    DEAT2
: USART1-CR1_DEAT1   %1 22 lshift USART1-CR1 bis! ;  \ USART1-CR1_DEAT1    DEAT1
: USART1-CR1_DEAT0   %1 21 lshift USART1-CR1 bis! ;  \ USART1-CR1_DEAT0    DEAT0
: USART1-CR1_DEDT4   %1 20 lshift USART1-CR1 bis! ;  \ USART1-CR1_DEDT4    Driver Enable deassertion time
: USART1-CR1_DEDT3   %1 19 lshift USART1-CR1 bis! ;  \ USART1-CR1_DEDT3    DEDT3
: USART1-CR1_DEDT2   %1 18 lshift USART1-CR1 bis! ;  \ USART1-CR1_DEDT2    DEDT2
: USART1-CR1_DEDT1   %1 17 lshift USART1-CR1 bis! ;  \ USART1-CR1_DEDT1    DEDT1
: USART1-CR1_DEDT0   %1 16 lshift USART1-CR1 bis! ;  \ USART1-CR1_DEDT0    DEDT0
: USART1-CR1_OVER8   %1 15 lshift USART1-CR1 bis! ;  \ USART1-CR1_OVER8    Oversampling mode
: USART1-CR1_CMIE   %1 14 lshift USART1-CR1 bis! ;  \ USART1-CR1_CMIE    Character match interrupt enable
: USART1-CR1_MME   %1 13 lshift USART1-CR1 bis! ;  \ USART1-CR1_MME    Mute mode enable
: USART1-CR1_M   %1 12 lshift USART1-CR1 bis! ;  \ USART1-CR1_M    Word length
: USART1-CR1_WAKE   %1 11 lshift USART1-CR1 bis! ;  \ USART1-CR1_WAKE    Receiver wakeup method
: USART1-CR1_PCE   %1 10 lshift USART1-CR1 bis! ;  \ USART1-CR1_PCE    Parity control enable
: USART1-CR1_PS   %1 9 lshift USART1-CR1 bis! ;  \ USART1-CR1_PS    Parity selection
: USART1-CR1_PEIE   %1 8 lshift USART1-CR1 bis! ;  \ USART1-CR1_PEIE    PE interrupt enable
: USART1-CR1_TXEIE   %1 7 lshift USART1-CR1 bis! ;  \ USART1-CR1_TXEIE    Transmit data register empty/TXFIFO not full interrupt enable
: USART1-CR1_TCIE   %1 6 lshift USART1-CR1 bis! ;  \ USART1-CR1_TCIE    Transmission complete interrupt enable
: USART1-CR1_RXNEIE   %1 5 lshift USART1-CR1 bis! ;  \ USART1-CR1_RXNEIE    Receive data register not empty/RXFIFO not empty interrupt enable
: USART1-CR1_IDLEIE   %1 4 lshift USART1-CR1 bis! ;  \ USART1-CR1_IDLEIE    IDLE interrupt enable
: USART1-CR1_TE   %1 3 lshift USART1-CR1 bis! ;  \ USART1-CR1_TE    Transmitter enable
: USART1-CR1_RE   %1 2 lshift USART1-CR1 bis! ;  \ USART1-CR1_RE    Receiver enable
: USART1-CR1_UESM   %1 1 lshift USART1-CR1 bis! ;  \ USART1-CR1_UESM    USART enable in low-power mode
: USART1-CR1_UE   %1 0 lshift USART1-CR1 bis! ;  \ USART1-CR1_UE    USART enable

\ USART1-CR2 (read-write)
: USART1-CR2_ADD7_4   ( %XXXX -- ) 28 lshift USART1-CR2 bis! ;  \ USART1-CR2_ADD7_4    Address of the USART node
: USART1-CR2_ADD3_0   ( %XXXX -- ) 24 lshift USART1-CR2 bis! ;  \ USART1-CR2_ADD3_0    Address of the USART node
: USART1-CR2_RTOEN   %1 23 lshift USART1-CR2 bis! ;  \ USART1-CR2_RTOEN    Receiver timeout enable
: USART1-CR2_ABRMOD1   %1 22 lshift USART1-CR2 bis! ;  \ USART1-CR2_ABRMOD1    Auto baud rate mode
: USART1-CR2_ABRMOD0   %1 21 lshift USART1-CR2 bis! ;  \ USART1-CR2_ABRMOD0    ABRMOD0
: USART1-CR2_ABREN   %1 20 lshift USART1-CR2 bis! ;  \ USART1-CR2_ABREN    Auto baud rate enable
: USART1-CR2_MSBFIRST   %1 19 lshift USART1-CR2 bis! ;  \ USART1-CR2_MSBFIRST    Most significant bit first
: USART1-CR2_DATAINV   %1 18 lshift USART1-CR2 bis! ;  \ USART1-CR2_DATAINV    Binary data inversion
: USART1-CR2_TXINV   %1 17 lshift USART1-CR2 bis! ;  \ USART1-CR2_TXINV    TX pin active level inversion
: USART1-CR2_RXINV   %1 16 lshift USART1-CR2 bis! ;  \ USART1-CR2_RXINV    RX pin active level inversion
: USART1-CR2_SWAP   %1 15 lshift USART1-CR2 bis! ;  \ USART1-CR2_SWAP    Swap TX/RX pins
: USART1-CR2_LINEN   %1 14 lshift USART1-CR2 bis! ;  \ USART1-CR2_LINEN    LIN mode enable
: USART1-CR2_STOP   ( %XX -- ) 12 lshift USART1-CR2 bis! ;  \ USART1-CR2_STOP    stop bits
: USART1-CR2_CLKEN   %1 11 lshift USART1-CR2 bis! ;  \ USART1-CR2_CLKEN    Clock enable
: USART1-CR2_CPOL   %1 10 lshift USART1-CR2 bis! ;  \ USART1-CR2_CPOL    Clock polarity
: USART1-CR2_CPHA   %1 9 lshift USART1-CR2 bis! ;  \ USART1-CR2_CPHA    Clock phase
: USART1-CR2_LBCL   %1 8 lshift USART1-CR2 bis! ;  \ USART1-CR2_LBCL    Last bit clock pulse
: USART1-CR2_LBDIE   %1 6 lshift USART1-CR2 bis! ;  \ USART1-CR2_LBDIE    LIN break detection interrupt enable
: USART1-CR2_LBDL   %1 5 lshift USART1-CR2 bis! ;  \ USART1-CR2_LBDL    LIN break detection length
: USART1-CR2_ADDM7   %1 4 lshift USART1-CR2 bis! ;  \ USART1-CR2_ADDM7    7-bit Address Detection/4-bit Address Detection
: USART1-CR2_DIS_NSS   %1 3 lshift USART1-CR2 bis! ;  \ USART1-CR2_DIS_NSS    DIS_NSS
: USART1-CR2_SLVEN   %1 0 lshift USART1-CR2 bis! ;  \ USART1-CR2_SLVEN    Synchronous Slave mode enable

\ USART1-CR3 (read-write)
: USART1-CR3_TXFTCFG   ( %XXX -- ) 29 lshift USART1-CR3 bis! ;  \ USART1-CR3_TXFTCFG    TXFIFO threshold configuration
: USART1-CR3_RXFTIE   %1 28 lshift USART1-CR3 bis! ;  \ USART1-CR3_RXFTIE    RXFIFO threshold interrupt enable
: USART1-CR3_RXFTCFG   ( %XXX -- ) 25 lshift USART1-CR3 bis! ;  \ USART1-CR3_RXFTCFG    Receive FIFO threshold configuration
: USART1-CR3_TCBGTIE   %1 24 lshift USART1-CR3 bis! ;  \ USART1-CR3_TCBGTIE    Transmission Complete before guard time, interrupt enable
: USART1-CR3_TXFTIE   %1 23 lshift USART1-CR3 bis! ;  \ USART1-CR3_TXFTIE    TXFIFO threshold interrupt enable
: USART1-CR3_WUFIE   %1 22 lshift USART1-CR3 bis! ;  \ USART1-CR3_WUFIE    Wakeup from low-power mode interrupt enable
: USART1-CR3_WUS   ( %XX -- ) 20 lshift USART1-CR3 bis! ;  \ USART1-CR3_WUS    Wakeup from low-power mode interrupt flag selection
: USART1-CR3_SCARCNT2_0   ( %XXX -- ) 17 lshift USART1-CR3 bis! ;  \ USART1-CR3_SCARCNT2_0    Smartcard auto-retry count
: USART1-CR3_DEP   %1 15 lshift USART1-CR3 bis! ;  \ USART1-CR3_DEP    Driver enable polarity selection
: USART1-CR3_DEM   %1 14 lshift USART1-CR3 bis! ;  \ USART1-CR3_DEM    Driver enable mode
: USART1-CR3_DDRE   %1 13 lshift USART1-CR3 bis! ;  \ USART1-CR3_DDRE    DMA Disable on Reception Error
: USART1-CR3_OVRDIS   %1 12 lshift USART1-CR3 bis! ;  \ USART1-CR3_OVRDIS    OVRDIS: Overrun Disable
: USART1-CR3_ONEBIT   %1 11 lshift USART1-CR3 bis! ;  \ USART1-CR3_ONEBIT    One sample bit method enable
: USART1-CR3_CTSIE   %1 10 lshift USART1-CR3 bis! ;  \ USART1-CR3_CTSIE    CTS interrupt enable
: USART1-CR3_CTSE   %1 9 lshift USART1-CR3 bis! ;  \ USART1-CR3_CTSE    CTS enable
: USART1-CR3_RTSE   %1 8 lshift USART1-CR3 bis! ;  \ USART1-CR3_RTSE    RTS enable
: USART1-CR3_DMAT   %1 7 lshift USART1-CR3 bis! ;  \ USART1-CR3_DMAT    DMA enable transmitter
: USART1-CR3_DMAR   %1 6 lshift USART1-CR3 bis! ;  \ USART1-CR3_DMAR    DMA enable receiver
: USART1-CR3_SCEN   %1 5 lshift USART1-CR3 bis! ;  \ USART1-CR3_SCEN    Smartcard mode enable
: USART1-CR3_NACK   %1 4 lshift USART1-CR3 bis! ;  \ USART1-CR3_NACK    Smartcard NACK enable
: USART1-CR3_HDSEL   %1 3 lshift USART1-CR3 bis! ;  \ USART1-CR3_HDSEL    Half-duplex selection
: USART1-CR3_IRLP   %1 2 lshift USART1-CR3 bis! ;  \ USART1-CR3_IRLP    IrDA low-power
: USART1-CR3_IREN   %1 1 lshift USART1-CR3 bis! ;  \ USART1-CR3_IREN    IrDA mode enable
: USART1-CR3_EIE   %1 0 lshift USART1-CR3 bis! ;  \ USART1-CR3_EIE    Error interrupt enable

\ USART1-BRR (read-write)
: USART1-BRR_BRR   ( %XXXXXXXXXXXXXXXX -- ) 0 lshift USART1-BRR bis! ;  \ USART1-BRR_BRR    BRR

\ USART1-GTPR (read-write)
: USART1-GTPR_GT   ( %XXXXXXXX -- ) 8 lshift USART1-GTPR bis! ;  \ USART1-GTPR_GT    Guard time value
: USART1-GTPR_PSC   ( %XXXXXXXX -- ) 0 lshift USART1-GTPR bis! ;  \ USART1-GTPR_PSC    Prescaler value

\ USART1-RTOR (read-write)
: USART1-RTOR_BLEN   ( %XXXXXXXX -- ) 24 lshift USART1-RTOR bis! ;  \ USART1-RTOR_BLEN    Block Length
: USART1-RTOR_RTO   ( %XXXXXXXXXXXXXXXXXXXXXXXX -- ) 0 lshift USART1-RTOR bis! ;  \ USART1-RTOR_RTO    Receiver timeout value

\ USART1-RQR (read-write)
: USART1-RQR_TXFRQ   %1 4 lshift USART1-RQR bis! ;  \ USART1-RQR_TXFRQ    Transmit data flush request
: USART1-RQR_RXFRQ   %1 3 lshift USART1-RQR bis! ;  \ USART1-RQR_RXFRQ    Receive data flush request
: USART1-RQR_MMRQ   %1 2 lshift USART1-RQR bis! ;  \ USART1-RQR_MMRQ    Mute mode request
: USART1-RQR_SBKRQ   %1 1 lshift USART1-RQR bis! ;  \ USART1-RQR_SBKRQ    Send break request
: USART1-RQR_ABRRQ   %1 0 lshift USART1-RQR bis! ;  \ USART1-RQR_ABRRQ    Auto baud rate request

\ USART1-ISR (read-only)
: USART1-ISR_TXFT   %1 27 lshift USART1-ISR bis! ;  \ USART1-ISR_TXFT    TXFT
: USART1-ISR_RXFT   %1 26 lshift USART1-ISR bis! ;  \ USART1-ISR_RXFT    RXFT
: USART1-ISR_TCBGT   %1 25 lshift USART1-ISR bis! ;  \ USART1-ISR_TCBGT    TCBGT
: USART1-ISR_RXFF   %1 24 lshift USART1-ISR bis! ;  \ USART1-ISR_RXFF    RXFF
: USART1-ISR_TXFE   %1 23 lshift USART1-ISR bis! ;  \ USART1-ISR_TXFE    TXFE
: USART1-ISR_REACK   %1 22 lshift USART1-ISR bis! ;  \ USART1-ISR_REACK    REACK
: USART1-ISR_TEACK   %1 21 lshift USART1-ISR bis! ;  \ USART1-ISR_TEACK    TEACK
: USART1-ISR_WUF   %1 20 lshift USART1-ISR bis! ;  \ USART1-ISR_WUF    WUF
: USART1-ISR_RWU   %1 19 lshift USART1-ISR bis! ;  \ USART1-ISR_RWU    RWU
: USART1-ISR_SBKF   %1 18 lshift USART1-ISR bis! ;  \ USART1-ISR_SBKF    SBKF
: USART1-ISR_CMF   %1 17 lshift USART1-ISR bis! ;  \ USART1-ISR_CMF    CMF
: USART1-ISR_BUSY   %1 16 lshift USART1-ISR bis! ;  \ USART1-ISR_BUSY    BUSY
: USART1-ISR_ABRF   %1 15 lshift USART1-ISR bis! ;  \ USART1-ISR_ABRF    ABRF
: USART1-ISR_ABRE   %1 14 lshift USART1-ISR bis! ;  \ USART1-ISR_ABRE    ABRE
: USART1-ISR_UDR   %1 13 lshift USART1-ISR bis! ;  \ USART1-ISR_UDR    UDR
: USART1-ISR_EOBF   %1 12 lshift USART1-ISR bis! ;  \ USART1-ISR_EOBF    EOBF
: USART1-ISR_RTOF   %1 11 lshift USART1-ISR bis! ;  \ USART1-ISR_RTOF    RTOF
: USART1-ISR_CTS   %1 10 lshift USART1-ISR bis! ;  \ USART1-ISR_CTS    CTS
: USART1-ISR_CTSIF   %1 9 lshift USART1-ISR bis! ;  \ USART1-ISR_CTSIF    CTSIF
: USART1-ISR_LBDF   %1 8 lshift USART1-ISR bis! ;  \ USART1-ISR_LBDF    LBDF
: USART1-ISR_TXE   %1 7 lshift USART1-ISR bis! ;  \ USART1-ISR_TXE    TXE
: USART1-ISR_TC   %1 6 lshift USART1-ISR bis! ;  \ USART1-ISR_TC    TC
: USART1-ISR_RXNE   %1 5 lshift USART1-ISR bis! ;  \ USART1-ISR_RXNE    RXNE
: USART1-ISR_IDLE   %1 4 lshift USART1-ISR bis! ;  \ USART1-ISR_IDLE    IDLE
: USART1-ISR_ORE   %1 3 lshift USART1-ISR bis! ;  \ USART1-ISR_ORE    ORE
: USART1-ISR_NE   %1 2 lshift USART1-ISR bis! ;  \ USART1-ISR_NE    NE
: USART1-ISR_FE   %1 1 lshift USART1-ISR bis! ;  \ USART1-ISR_FE    FE
: USART1-ISR_PE   %1 0 lshift USART1-ISR bis! ;  \ USART1-ISR_PE    PE

\ USART1-ICR (write-only)
: USART1-ICR_WUCF   %1 20 lshift USART1-ICR bis! ;  \ USART1-ICR_WUCF    Wakeup from low-power mode clear flag
: USART1-ICR_CMCF   %1 17 lshift USART1-ICR bis! ;  \ USART1-ICR_CMCF    Character match clear flag
: USART1-ICR_UDRCF   %1 13 lshift USART1-ICR bis! ;  \ USART1-ICR_UDRCF    SPI slave underrun clear flag
: USART1-ICR_EOBCF   %1 12 lshift USART1-ICR bis! ;  \ USART1-ICR_EOBCF    End of block clear flag
: USART1-ICR_RTOCF   %1 11 lshift USART1-ICR bis! ;  \ USART1-ICR_RTOCF    Receiver timeout clear flag
: USART1-ICR_CTSCF   %1 9 lshift USART1-ICR bis! ;  \ USART1-ICR_CTSCF    CTS clear flag
: USART1-ICR_LBDCF   %1 8 lshift USART1-ICR bis! ;  \ USART1-ICR_LBDCF    LIN break detection clear flag
: USART1-ICR_TCBGTCF   %1 7 lshift USART1-ICR bis! ;  \ USART1-ICR_TCBGTCF    Transmission complete before Guard time clear flag
: USART1-ICR_TCCF   %1 6 lshift USART1-ICR bis! ;  \ USART1-ICR_TCCF    Transmission complete clear flag
: USART1-ICR_TXFECF   %1 5 lshift USART1-ICR bis! ;  \ USART1-ICR_TXFECF    TXFIFO empty clear flag
: USART1-ICR_IDLECF   %1 4 lshift USART1-ICR bis! ;  \ USART1-ICR_IDLECF    Idle line detected clear flag
: USART1-ICR_ORECF   %1 3 lshift USART1-ICR bis! ;  \ USART1-ICR_ORECF    Overrun error clear flag
: USART1-ICR_NECF   %1 2 lshift USART1-ICR bis! ;  \ USART1-ICR_NECF    Noise detected clear flag
: USART1-ICR_FECF   %1 1 lshift USART1-ICR bis! ;  \ USART1-ICR_FECF    Framing error clear flag
: USART1-ICR_PECF   %1 0 lshift USART1-ICR bis! ;  \ USART1-ICR_PECF    Parity error clear flag

\ USART1-RDR (read-only)
: USART1-RDR_RDR   ( %XXXXXXXXX -- ) 0 lshift USART1-RDR bis! ;  \ USART1-RDR_RDR    Receive data value

\ USART1-TDR (read-write)
: USART1-TDR_TDR   ( %XXXXXXXXX -- ) 0 lshift USART1-TDR bis! ;  \ USART1-TDR_TDR    Transmit data value

\ USART1-PRESC (read-write)
: USART1-PRESC_PRESCALER   ( %XXXX -- ) 0 lshift USART1-PRESC bis! ;  \ USART1-PRESC_PRESCALER    Clock prescaler

\ VREFBUF-CSR ()
: VREFBUF-CSR_VRR   %1 3 lshift VREFBUF-CSR bis! ;  \ VREFBUF-CSR_VRR    Voltage reference buffer ready
: VREFBUF-CSR_VRS   %1 2 lshift VREFBUF-CSR bis! ;  \ VREFBUF-CSR_VRS    Voltage reference scale
: VREFBUF-CSR_HIZ   %1 1 lshift VREFBUF-CSR bis! ;  \ VREFBUF-CSR_HIZ    High impedance mode
: VREFBUF-CSR_ENVR   %1 0 lshift VREFBUF-CSR bis! ;  \ VREFBUF-CSR_ENVR    Voltage reference buffer mode enable

\ VREFBUF-CCR (read-write)
: VREFBUF-CCR_TRIM   ( %XXXXXX -- ) 0 lshift VREFBUF-CCR bis! ;  \ VREFBUF-CCR_TRIM    Trimming code
