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
: ADC-ISR. ." ADC-ISR (read-write) $" ADC-ISR @ hex. ;
: ADC-IER. ." ADC-IER (read-write) $" ADC-IER @ hex. ;
: ADC-CR. ." ADC-CR (read-write) $" ADC-CR @ hex. ;
: ADC-CFGR1. ." ADC-CFGR1 (read-write) $" ADC-CFGR1 @ hex. ;
: ADC-CFGR2. ." ADC-CFGR2 (read-write) $" ADC-CFGR2 @ hex. ;
: ADC-SMPR. ." ADC-SMPR (read-write) $" ADC-SMPR @ hex. ;
: ADC-AWD1TR. ." ADC-AWD1TR (read-write) $" ADC-AWD1TR @ hex. ;
: ADC-AWD2TR. ." ADC-AWD2TR (read-write) $" ADC-AWD2TR @ hex. ;
: ADC-CHSELR0. ." ADC-CHSELR0 (read-write) $" ADC-CHSELR0 @ hex. ;
: ADC-CHSELR1. ." ADC-CHSELR1 (read-write) $" ADC-CHSELR1 @ hex. ;
: ADC-AWD3TR. ." ADC-AWD3TR (read-write) $" ADC-AWD3TR @ hex. ;
: ADC-DR. ." ADC-DR (read-only) $" ADC-DR @ hex. ;
: ADC-AWD2CR. ." ADC-AWD2CR (read-write) $" ADC-AWD2CR @ hex. ;
: ADC-AWD3CR. ." ADC-AWD3CR (read-write) $" ADC-AWD3CR @ hex. ;
: ADC-CALFACT. ." ADC-CALFACT (read-write) $" ADC-CALFACT @ hex. ;
: ADC-CCR. ." ADC-CCR (read-write) $" ADC-CCR @ hex. ;
: ADC.
 cr ADC-ISR.
 cr ADC-IER.
 cr ADC-CR.
 cr ADC-CFGR1.
 cr ADC-CFGR2.
 cr ADC-SMPR.
 cr ADC-AWD1TR.
 cr ADC-AWD2TR.
 cr ADC-CHSELR0.
 cr ADC-CHSELR1.
 cr ADC-AWD3TR.
 cr ADC-DR.
 cr ADC-AWD2CR.
 cr ADC-AWD3CR.
 cr ADC-CALFACT.
 cr ADC-CCR.
;

$58001800 constant AES ( Advanced encryption standard hardware accelerator 1 ) 
AES $0 + constant AES-CR ( control register ) 
AES $4 + constant AES-SR ( status register ) 
AES $8 + constant AES-DINR ( data input register ) 
AES $C + constant AES-DOUTR ( data output register ) 
AES $10 + constant AES-KEYR0 ( key register 0 ) 
AES $14 + constant AES-KEYR1 ( key register 1 ) 
AES $18 + constant AES-KEYR2 ( key register 2 ) 
AES $1C + constant AES-KEYR3 ( key register 3 ) 
AES $20 + constant AES-IVR0 ( initialization vector register 0 ) 
AES $24 + constant AES-IVR1 ( initialization vector register 1 ) 
AES $28 + constant AES-IVR2 ( initialization vector register 2 ) 
AES $2C + constant AES-IVR3 ( initialization vector register 3 ) 
AES $30 + constant AES-KEYR4 ( key register 4 ) 
AES $34 + constant AES-KEYR5 ( key register 5 ) 
AES $38 + constant AES-KEYR6 ( key register 6 ) 
AES $3C + constant AES-KEYR7 ( key register 7 ) 
AES $40 + constant AES-SUSP0R ( AES suspend register 0 ) 
AES $44 + constant AES-SUSP1R ( AES suspend register 1 ) 
AES $48 + constant AES-SUSP2R ( AES suspend register 2 ) 
AES $4C + constant AES-SUSP3R ( AES suspend register 3 ) 
AES $50 + constant AES-SUSP4R ( AES suspend register 4 ) 
AES $54 + constant AES-SUSP5R ( AES suspend register 5 ) 
AES $58 + constant AES-SUSP6R ( AES suspend register 6 ) 
AES $5C + constant AES-SUSP7R ( AES suspend register 7 ) 
: AES-CR. ." AES-CR (read-write) $" AES-CR @ hex. ;
: AES-SR. ." AES-SR (read-only) $" AES-SR @ hex. ;
: AES-DINR. ." AES-DINR (read-write) $" AES-DINR @ hex. ;
: AES-DOUTR. ." AES-DOUTR (read-only) $" AES-DOUTR @ hex. ;
: AES-KEYR0. ." AES-KEYR0 (write-only) $" AES-KEYR0 @ hex. ;
: AES-KEYR1. ." AES-KEYR1 (write-only) $" AES-KEYR1 @ hex. ;
: AES-KEYR2. ." AES-KEYR2 (write-only) $" AES-KEYR2 @ hex. ;
: AES-KEYR3. ." AES-KEYR3 (write-only) $" AES-KEYR3 @ hex. ;
: AES-IVR0. ." AES-IVR0 (read-write) $" AES-IVR0 @ hex. ;
: AES-IVR1. ." AES-IVR1 (read-write) $" AES-IVR1 @ hex. ;
: AES-IVR2. ." AES-IVR2 (read-write) $" AES-IVR2 @ hex. ;
: AES-IVR3. ." AES-IVR3 (read-write) $" AES-IVR3 @ hex. ;
: AES-KEYR4. ." AES-KEYR4 (write-only) $" AES-KEYR4 @ hex. ;
: AES-KEYR5. ." AES-KEYR5 (write-only) $" AES-KEYR5 @ hex. ;
: AES-KEYR6. ." AES-KEYR6 (write-only) $" AES-KEYR6 @ hex. ;
: AES-KEYR7. ." AES-KEYR7 (write-only) $" AES-KEYR7 @ hex. ;
: AES-SUSP0R. ." AES-SUSP0R (read-write) $" AES-SUSP0R @ hex. ;
: AES-SUSP1R. ." AES-SUSP1R (read-write) $" AES-SUSP1R @ hex. ;
: AES-SUSP2R. ." AES-SUSP2R (read-write) $" AES-SUSP2R @ hex. ;
: AES-SUSP3R. ." AES-SUSP3R (read-write) $" AES-SUSP3R @ hex. ;
: AES-SUSP4R. ." AES-SUSP4R (read-write) $" AES-SUSP4R @ hex. ;
: AES-SUSP5R. ." AES-SUSP5R (read-write) $" AES-SUSP5R @ hex. ;
: AES-SUSP6R. ." AES-SUSP6R (read-write) $" AES-SUSP6R @ hex. ;
: AES-SUSP7R. ." AES-SUSP7R (read-write) $" AES-SUSP7R @ hex. ;
: AES.
 cr AES-CR.
 cr AES-SR.
 cr AES-DINR.
 cr AES-DOUTR.
 cr AES-KEYR0.
 cr AES-KEYR1.
 cr AES-KEYR2.
 cr AES-KEYR3.
 cr AES-IVR0.
 cr AES-IVR1.
 cr AES-IVR2.
 cr AES-IVR3.
 cr AES-KEYR4.
 cr AES-KEYR5.
 cr AES-KEYR6.
 cr AES-KEYR7.
 cr AES-SUSP0R.
 cr AES-SUSP1R.
 cr AES-SUSP2R.
 cr AES-SUSP3R.
 cr AES-SUSP4R.
 cr AES-SUSP5R.
 cr AES-SUSP6R.
 cr AES-SUSP7R.
;

$40010200 constant COMP ( Comparator ) 
COMP $0 + constant COMP-COMP1_CSR ( COMP1_CSR ) 
COMP $4 + constant COMP-COMP2_CSR ( COMP2_CSR ) 
: COMP-COMP1_CSR. ." COMP-COMP1_CSR () $" COMP-COMP1_CSR @ hex. ;
: COMP-COMP2_CSR. ." COMP-COMP2_CSR () $" COMP-COMP2_CSR @ hex. ;
: COMP.
 cr COMP-COMP1_CSR.
 cr COMP-COMP2_CSR.
;

$40023000 constant CRC ( Cyclic redundancy check calculation unit ) 
CRC $0 + constant CRC-DR ( Data register ) 
CRC $4 + constant CRC-IDR ( Independent data register ) 
CRC $8 + constant CRC-CR ( Control register ) 
CRC $10 + constant CRC-INIT ( Initial CRC value ) 
CRC $14 + constant CRC-POL ( polynomial ) 
: CRC-DR. ." CRC-DR (read-write) $" CRC-DR @ hex. ;
: CRC-IDR. ." CRC-IDR (read-write) $" CRC-IDR @ hex. ;
: CRC-CR. ." CRC-CR (read-write) $" CRC-CR @ hex. ;
: CRC-INIT. ." CRC-INIT (read-write) $" CRC-INIT @ hex. ;
: CRC-POL. ." CRC-POL (read-write) $" CRC-POL @ hex. ;
: CRC.
 cr CRC-DR.
 cr CRC-IDR.
 cr CRC-CR.
 cr CRC-INIT.
 cr CRC-POL.
;

$40007400 constant DAC ( Digital-to-analog converter ) 
DAC $0 + constant DAC-CR ( control register ) 
DAC $4 + constant DAC-SWTRGR ( software trigger register ) 
DAC $8 + constant DAC-DHR12R1 ( channel1 12-bit right-aligned data holding register ) 
DAC $C + constant DAC-DHR12L1 ( channel1 12-bit left aligned data holding register ) 
DAC $10 + constant DAC-DHR8R1 ( channel1 8-bit right aligned data holding register ) 
DAC $20 + constant DAC-DHR12RD ( Dual DAC 12-bit right-aligned data holding register ) 
DAC $24 + constant DAC-DHR12LD ( Dual DAC 12-bit left aligned data holding register ) 
DAC $28 + constant DAC-DHR8RD ( Dual DAC 8-bit right aligned data holding register ) 
DAC $2C + constant DAC-DOR1 ( DAC channel1 data output register ) 
DAC $34 + constant DAC-SR ( status register ) 
DAC $38 + constant DAC-CCR ( calibration control register ) 
DAC $3C + constant DAC-MCR ( mode control register ) 
DAC $40 + constant DAC-SHSR1 ( Sample and Hold sample time register 1 ) 
DAC $48 + constant DAC-SHHR ( Sample and Hold hold time register ) 
DAC $4C + constant DAC-SHRR ( Sample and Hold refresh time register ) 
: DAC-CR. ." DAC-CR (read-write) $" DAC-CR @ hex. ;
: DAC-SWTRGR. ." DAC-SWTRGR () $" DAC-SWTRGR @ hex. ;
: DAC-DHR12R1. ." DAC-DHR12R1 (read-write) $" DAC-DHR12R1 @ hex. ;
: DAC-DHR12L1. ." DAC-DHR12L1 (read-write) $" DAC-DHR12L1 @ hex. ;
: DAC-DHR8R1. ." DAC-DHR8R1 (read-write) $" DAC-DHR8R1 @ hex. ;
: DAC-DHR12RD. ." DAC-DHR12RD (read-write) $" DAC-DHR12RD @ hex. ;
: DAC-DHR12LD. ." DAC-DHR12LD (read-write) $" DAC-DHR12LD @ hex. ;
: DAC-DHR8RD. ." DAC-DHR8RD (read-write) $" DAC-DHR8RD @ hex. ;
: DAC-DOR1. ." DAC-DOR1 (read-only) $" DAC-DOR1 @ hex. ;
: DAC-SR. ." DAC-SR () $" DAC-SR @ hex. ;
: DAC-CCR. ." DAC-CCR (read-write) $" DAC-CCR @ hex. ;
: DAC-MCR. ." DAC-MCR (read-write) $" DAC-MCR @ hex. ;
: DAC-SHSR1. ." DAC-SHSR1 (read-write) $" DAC-SHSR1 @ hex. ;
: DAC-SHHR. ." DAC-SHHR (read-write) $" DAC-SHHR @ hex. ;
: DAC-SHRR. ." DAC-SHRR (read-write) $" DAC-SHRR @ hex. ;
: DAC.
 cr DAC-CR.
 cr DAC-SWTRGR.
 cr DAC-DHR12R1.
 cr DAC-DHR12L1.
 cr DAC-DHR8R1.
 cr DAC-DHR12RD.
 cr DAC-DHR12LD.
 cr DAC-DHR8RD.
 cr DAC-DOR1.
 cr DAC-SR.
 cr DAC-CCR.
 cr DAC-MCR.
 cr DAC-SHSR1.
 cr DAC-SHHR.
 cr DAC-SHRR.
;

$E0042000 constant DBGMCU ( Microcontroller Debug Unit ) 
DBGMCU $0 + constant DBGMCU-IDCODER ( DBGMCU Identity Code Register ) 
DBGMCU $4 + constant DBGMCU-CR ( DBGMCU Configuration Register ) 
DBGMCU $3C + constant DBGMCU-APB1FZR1 ( DBGMCU CPU1 APB1 Peripheral Freeze Register 1 ) 
DBGMCU $44 + constant DBGMCU-APB1FZR2 ( DBGMCU CPU1 APB1 Peripheral Freeze Register 2 ) 
DBGMCU $4C + constant DBGMCU-APB2FZR ( DBGMCU CPU1 APB2 Peripheral Freeze Register ) 
: DBGMCU-IDCODER. ." DBGMCU-IDCODER (read-only) $" DBGMCU-IDCODER @ hex. ;
: DBGMCU-CR. ." DBGMCU-CR (read-write) $" DBGMCU-CR @ hex. ;
: DBGMCU-APB1FZR1. ." DBGMCU-APB1FZR1 (read-write) $" DBGMCU-APB1FZR1 @ hex. ;
: DBGMCU-APB1FZR2. ." DBGMCU-APB1FZR2 (read-write) $" DBGMCU-APB1FZR2 @ hex. ;
: DBGMCU-APB2FZR. ." DBGMCU-APB2FZR (read-write) $" DBGMCU-APB2FZR @ hex. ;
: DBGMCU.
 cr DBGMCU-IDCODER.
 cr DBGMCU-CR.
 cr DBGMCU-APB1FZR1.
 cr DBGMCU-APB1FZR2.
 cr DBGMCU-APB2FZR.
;

$40020000 constant DMA1 ( Direct memory access controller ) 
DMA1 $0 + constant DMA1-ISR ( interrupt status register ) 
DMA1 $4 + constant DMA1-IFCR ( interrupt flag clear register ) 
DMA1 $8 + constant DMA1-CCR1 ( channel x configuration register ) 
DMA1 $C + constant DMA1-CNDTR1 ( channel x number of data to transfer register ) 
DMA1 $10 + constant DMA1-CPAR1 ( channel x peripheral address register ) 
DMA1 $14 + constant DMA1-CMAR1 ( channel x memory address register ) 
DMA1 $1C + constant DMA1-CCR2 ( channel x configuration register ) 
DMA1 $20 + constant DMA1-CNDTR2 ( channel x number of data to transfer register ) 
DMA1 $24 + constant DMA1-CPAR2 ( channel x peripheral address register ) 
DMA1 $28 + constant DMA1-CMAR2 ( channel x memory address register ) 
DMA1 $30 + constant DMA1-CCR3 ( channel x configuration register ) 
DMA1 $34 + constant DMA1-CNDTR3 ( channel x number of data to transfer register ) 
DMA1 $38 + constant DMA1-CPAR3 ( channel x peripheral address register ) 
DMA1 $3C + constant DMA1-CMAR3 ( channel x memory address register ) 
DMA1 $44 + constant DMA1-CCR4 ( channel x configuration register ) 
DMA1 $48 + constant DMA1-CNDTR4 ( channel x number of data to transfer register ) 
DMA1 $4C + constant DMA1-CPAR4 ( channel x peripheral address register ) 
DMA1 $50 + constant DMA1-CMAR4 ( channel x memory address register ) 
DMA1 $58 + constant DMA1-CCR5 ( channel x configuration register ) 
DMA1 $5C + constant DMA1-CNDTR5 ( channel x number of data to transfer register ) 
DMA1 $60 + constant DMA1-CPAR5 ( channel x peripheral address register ) 
DMA1 $64 + constant DMA1-CMAR5 ( channel x memory address register ) 
DMA1 $6C + constant DMA1-CCR6 ( channel x configuration register ) 
DMA1 $70 + constant DMA1-CNDTR6 ( channel x number of data to transfer register ) 
DMA1 $74 + constant DMA1-CPAR6 ( channel x peripheral address register ) 
DMA1 $78 + constant DMA1-CMAR6 ( channel x memory address register ) 
DMA1 $80 + constant DMA1-CCR7 ( channel x configuration register ) 
DMA1 $84 + constant DMA1-CNDTR7 ( channel x number of data to transfer register ) 
DMA1 $88 + constant DMA1-CPAR7 ( channel x peripheral address register ) 
DMA1 $8C + constant DMA1-CMAR7 ( channel x memory address register ) 
: DMA1-ISR. ." DMA1-ISR (read-only) $" DMA1-ISR @ hex. ;
: DMA1-IFCR. ." DMA1-IFCR (write-only) $" DMA1-IFCR @ hex. ;
: DMA1-CCR1. ." DMA1-CCR1 (read-write) $" DMA1-CCR1 @ hex. ;
: DMA1-CNDTR1. ." DMA1-CNDTR1 (read-write) $" DMA1-CNDTR1 @ hex. ;
: DMA1-CPAR1. ." DMA1-CPAR1 (read-write) $" DMA1-CPAR1 @ hex. ;
: DMA1-CMAR1. ." DMA1-CMAR1 (read-write) $" DMA1-CMAR1 @ hex. ;
: DMA1-CCR2. ." DMA1-CCR2 (read-write) $" DMA1-CCR2 @ hex. ;
: DMA1-CNDTR2. ." DMA1-CNDTR2 (read-write) $" DMA1-CNDTR2 @ hex. ;
: DMA1-CPAR2. ." DMA1-CPAR2 (read-write) $" DMA1-CPAR2 @ hex. ;
: DMA1-CMAR2. ." DMA1-CMAR2 (read-write) $" DMA1-CMAR2 @ hex. ;
: DMA1-CCR3. ." DMA1-CCR3 (read-write) $" DMA1-CCR3 @ hex. ;
: DMA1-CNDTR3. ." DMA1-CNDTR3 (read-write) $" DMA1-CNDTR3 @ hex. ;
: DMA1-CPAR3. ." DMA1-CPAR3 (read-write) $" DMA1-CPAR3 @ hex. ;
: DMA1-CMAR3. ." DMA1-CMAR3 (read-write) $" DMA1-CMAR3 @ hex. ;
: DMA1-CCR4. ." DMA1-CCR4 (read-write) $" DMA1-CCR4 @ hex. ;
: DMA1-CNDTR4. ." DMA1-CNDTR4 (read-write) $" DMA1-CNDTR4 @ hex. ;
: DMA1-CPAR4. ." DMA1-CPAR4 (read-write) $" DMA1-CPAR4 @ hex. ;
: DMA1-CMAR4. ." DMA1-CMAR4 (read-write) $" DMA1-CMAR4 @ hex. ;
: DMA1-CCR5. ." DMA1-CCR5 (read-write) $" DMA1-CCR5 @ hex. ;
: DMA1-CNDTR5. ." DMA1-CNDTR5 (read-write) $" DMA1-CNDTR5 @ hex. ;
: DMA1-CPAR5. ." DMA1-CPAR5 (read-write) $" DMA1-CPAR5 @ hex. ;
: DMA1-CMAR5. ." DMA1-CMAR5 (read-write) $" DMA1-CMAR5 @ hex. ;
: DMA1-CCR6. ." DMA1-CCR6 (read-write) $" DMA1-CCR6 @ hex. ;
: DMA1-CNDTR6. ." DMA1-CNDTR6 (read-write) $" DMA1-CNDTR6 @ hex. ;
: DMA1-CPAR6. ." DMA1-CPAR6 (read-write) $" DMA1-CPAR6 @ hex. ;
: DMA1-CMAR6. ." DMA1-CMAR6 (read-write) $" DMA1-CMAR6 @ hex. ;
: DMA1-CCR7. ." DMA1-CCR7 (read-write) $" DMA1-CCR7 @ hex. ;
: DMA1-CNDTR7. ." DMA1-CNDTR7 (read-write) $" DMA1-CNDTR7 @ hex. ;
: DMA1-CPAR7. ." DMA1-CPAR7 (read-write) $" DMA1-CPAR7 @ hex. ;
: DMA1-CMAR7. ." DMA1-CMAR7 (read-write) $" DMA1-CMAR7 @ hex. ;
: DMA1.
 cr DMA1-ISR.
 cr DMA1-IFCR.
 cr DMA1-CCR1.
 cr DMA1-CNDTR1.
 cr DMA1-CPAR1.
 cr DMA1-CMAR1.
 cr DMA1-CCR2.
 cr DMA1-CNDTR2.
 cr DMA1-CPAR2.
 cr DMA1-CMAR2.
 cr DMA1-CCR3.
 cr DMA1-CNDTR3.
 cr DMA1-CPAR3.
 cr DMA1-CMAR3.
 cr DMA1-CCR4.
 cr DMA1-CNDTR4.
 cr DMA1-CPAR4.
 cr DMA1-CMAR4.
 cr DMA1-CCR5.
 cr DMA1-CNDTR5.
 cr DMA1-CPAR5.
 cr DMA1-CMAR5.
 cr DMA1-CCR6.
 cr DMA1-CNDTR6.
 cr DMA1-CPAR6.
 cr DMA1-CMAR6.
 cr DMA1-CCR7.
 cr DMA1-CNDTR7.
 cr DMA1-CPAR7.
 cr DMA1-CMAR7.
;

$40020400 constant DMA2 ( Direct memory access controller ) 
DMA2 $0 + constant DMA2-ISR ( interrupt status register ) 
DMA2 $4 + constant DMA2-IFCR ( interrupt flag clear register ) 
DMA2 $8 + constant DMA2-CCR1 ( channel x configuration register ) 
DMA2 $C + constant DMA2-CNDTR1 ( channel x number of data to transfer register ) 
DMA2 $10 + constant DMA2-CPAR1 ( channel x peripheral address register ) 
DMA2 $14 + constant DMA2-CMAR1 ( channel x memory address register ) 
DMA2 $1C + constant DMA2-CCR2 ( channel x configuration register ) 
DMA2 $20 + constant DMA2-CNDTR2 ( channel x number of data to transfer register ) 
DMA2 $24 + constant DMA2-CPAR2 ( channel x peripheral address register ) 
DMA2 $28 + constant DMA2-CMAR2 ( channel x memory address register ) 
DMA2 $30 + constant DMA2-CCR3 ( channel x configuration register ) 
DMA2 $34 + constant DMA2-CNDTR3 ( channel x number of data to transfer register ) 
DMA2 $38 + constant DMA2-CPAR3 ( channel x peripheral address register ) 
DMA2 $3C + constant DMA2-CMAR3 ( channel x memory address register ) 
DMA2 $44 + constant DMA2-CCR4 ( channel x configuration register ) 
DMA2 $48 + constant DMA2-CNDTR4 ( channel x number of data to transfer register ) 
DMA2 $4C + constant DMA2-CPAR4 ( channel x peripheral address register ) 
DMA2 $50 + constant DMA2-CMAR4 ( channel x memory address register ) 
DMA2 $58 + constant DMA2-CCR5 ( channel x configuration register ) 
DMA2 $5C + constant DMA2-CNDTR5 ( channel x number of data to transfer register ) 
DMA2 $60 + constant DMA2-CPAR5 ( channel x peripheral address register ) 
DMA2 $64 + constant DMA2-CMAR5 ( channel x memory address register ) 
DMA2 $6C + constant DMA2-CCR6 ( channel x configuration register ) 
DMA2 $70 + constant DMA2-CNDTR6 ( channel x number of data to transfer register ) 
DMA2 $74 + constant DMA2-CPAR6 ( channel x peripheral address register ) 
DMA2 $78 + constant DMA2-CMAR6 ( channel x memory address register ) 
DMA2 $80 + constant DMA2-CCR7 ( channel x configuration register ) 
DMA2 $84 + constant DMA2-CNDTR7 ( channel x number of data to transfer register ) 
DMA2 $88 + constant DMA2-CPAR7 ( channel x peripheral address register ) 
DMA2 $8C + constant DMA2-CMAR7 ( channel x memory address register ) 
: DMA2-ISR. ." DMA2-ISR (read-only) $" DMA2-ISR @ hex. ;
: DMA2-IFCR. ." DMA2-IFCR (write-only) $" DMA2-IFCR @ hex. ;
: DMA2-CCR1. ." DMA2-CCR1 (read-write) $" DMA2-CCR1 @ hex. ;
: DMA2-CNDTR1. ." DMA2-CNDTR1 (read-write) $" DMA2-CNDTR1 @ hex. ;
: DMA2-CPAR1. ." DMA2-CPAR1 (read-write) $" DMA2-CPAR1 @ hex. ;
: DMA2-CMAR1. ." DMA2-CMAR1 (read-write) $" DMA2-CMAR1 @ hex. ;
: DMA2-CCR2. ." DMA2-CCR2 (read-write) $" DMA2-CCR2 @ hex. ;
: DMA2-CNDTR2. ." DMA2-CNDTR2 (read-write) $" DMA2-CNDTR2 @ hex. ;
: DMA2-CPAR2. ." DMA2-CPAR2 (read-write) $" DMA2-CPAR2 @ hex. ;
: DMA2-CMAR2. ." DMA2-CMAR2 (read-write) $" DMA2-CMAR2 @ hex. ;
: DMA2-CCR3. ." DMA2-CCR3 (read-write) $" DMA2-CCR3 @ hex. ;
: DMA2-CNDTR3. ." DMA2-CNDTR3 (read-write) $" DMA2-CNDTR3 @ hex. ;
: DMA2-CPAR3. ." DMA2-CPAR3 (read-write) $" DMA2-CPAR3 @ hex. ;
: DMA2-CMAR3. ." DMA2-CMAR3 (read-write) $" DMA2-CMAR3 @ hex. ;
: DMA2-CCR4. ." DMA2-CCR4 (read-write) $" DMA2-CCR4 @ hex. ;
: DMA2-CNDTR4. ." DMA2-CNDTR4 (read-write) $" DMA2-CNDTR4 @ hex. ;
: DMA2-CPAR4. ." DMA2-CPAR4 (read-write) $" DMA2-CPAR4 @ hex. ;
: DMA2-CMAR4. ." DMA2-CMAR4 (read-write) $" DMA2-CMAR4 @ hex. ;
: DMA2-CCR5. ." DMA2-CCR5 (read-write) $" DMA2-CCR5 @ hex. ;
: DMA2-CNDTR5. ." DMA2-CNDTR5 (read-write) $" DMA2-CNDTR5 @ hex. ;
: DMA2-CPAR5. ." DMA2-CPAR5 (read-write) $" DMA2-CPAR5 @ hex. ;
: DMA2-CMAR5. ." DMA2-CMAR5 (read-write) $" DMA2-CMAR5 @ hex. ;
: DMA2-CCR6. ." DMA2-CCR6 (read-write) $" DMA2-CCR6 @ hex. ;
: DMA2-CNDTR6. ." DMA2-CNDTR6 (read-write) $" DMA2-CNDTR6 @ hex. ;
: DMA2-CPAR6. ." DMA2-CPAR6 (read-write) $" DMA2-CPAR6 @ hex. ;
: DMA2-CMAR6. ." DMA2-CMAR6 (read-write) $" DMA2-CMAR6 @ hex. ;
: DMA2-CCR7. ." DMA2-CCR7 (read-write) $" DMA2-CCR7 @ hex. ;
: DMA2-CNDTR7. ." DMA2-CNDTR7 (read-write) $" DMA2-CNDTR7 @ hex. ;
: DMA2-CPAR7. ." DMA2-CPAR7 (read-write) $" DMA2-CPAR7 @ hex. ;
: DMA2-CMAR7. ." DMA2-CMAR7 (read-write) $" DMA2-CMAR7 @ hex. ;
: DMA2.
 cr DMA2-ISR.
 cr DMA2-IFCR.
 cr DMA2-CCR1.
 cr DMA2-CNDTR1.
 cr DMA2-CPAR1.
 cr DMA2-CMAR1.
 cr DMA2-CCR2.
 cr DMA2-CNDTR2.
 cr DMA2-CPAR2.
 cr DMA2-CMAR2.
 cr DMA2-CCR3.
 cr DMA2-CNDTR3.
 cr DMA2-CPAR3.
 cr DMA2-CMAR3.
 cr DMA2-CCR4.
 cr DMA2-CNDTR4.
 cr DMA2-CPAR4.
 cr DMA2-CMAR4.
 cr DMA2-CCR5.
 cr DMA2-CNDTR5.
 cr DMA2-CPAR5.
 cr DMA2-CMAR5.
 cr DMA2-CCR6.
 cr DMA2-CNDTR6.
 cr DMA2-CPAR6.
 cr DMA2-CMAR6.
 cr DMA2-CCR7.
 cr DMA2-CNDTR7.
 cr DMA2-CPAR7.
 cr DMA2-CMAR7.
;

$40020800 constant DMAMUX ( DMA request multiplexer ) 
DMAMUX $0 + constant DMAMUX-C0CR ( request line multiplexer channel x configuration register ) 
DMAMUX $4 + constant DMAMUX-C1CR ( request line multiplexer channel x configuration register ) 
DMAMUX $8 + constant DMAMUX-C2CR ( request line multiplexer channel x configuration register ) 
DMAMUX $C + constant DMAMUX-C3CR ( request line multiplexer channel x configuration register ) 
DMAMUX $10 + constant DMAMUX-C4CR ( request line multiplexer channel x configuration register ) 
DMAMUX $14 + constant DMAMUX-C5CR ( request line multiplexer channel x configuration register ) 
DMAMUX $18 + constant DMAMUX-C6CR ( request line multiplexer channel x configuration register ) 
DMAMUX $1C + constant DMAMUX-C7CR ( request line multiplexer channel x configuration register ) 
DMAMUX $20 + constant DMAMUX-C8CR ( request line multiplexer channel x configuration register ) 
DMAMUX $24 + constant DMAMUX-C9CR ( request line multiplexer channel x configuration register ) 
DMAMUX $28 + constant DMAMUX-C10CR ( C10CR ) 
DMAMUX $2C + constant DMAMUX-C11CR ( C11CR ) 
DMAMUX $30 + constant DMAMUX-C12CR ( C12CR ) 
DMAMUX $34 + constant DMAMUX-C13CR ( C13CR ) 
DMAMUX $80 + constant DMAMUX-CSR ( request line multiplexer interrupt channel status register ) 
DMAMUX $84 + constant DMAMUX-CCFR ( request line multiplexer interrupt channel clear flag register ) 
DMAMUX $100 + constant DMAMUX-RG0CR ( request generator channel x configuration register ) 
DMAMUX $104 + constant DMAMUX-RG1CR ( request generator channel x configuration register ) 
DMAMUX $108 + constant DMAMUX-RG2CR ( request generator channel x configuration register ) 
DMAMUX $10C + constant DMAMUX-RG3CR ( request generator channel x configuration register ) 
DMAMUX $140 + constant DMAMUX-RGSR ( request generator interrupt status register ) 
DMAMUX $144 + constant DMAMUX-RGCFR ( request generator interrupt clear flag register ) 
: DMAMUX-C0CR. ." DMAMUX-C0CR (read-write) $" DMAMUX-C0CR @ hex. ;
: DMAMUX-C1CR. ." DMAMUX-C1CR (read-write) $" DMAMUX-C1CR @ hex. ;
: DMAMUX-C2CR. ." DMAMUX-C2CR (read-write) $" DMAMUX-C2CR @ hex. ;
: DMAMUX-C3CR. ." DMAMUX-C3CR (read-write) $" DMAMUX-C3CR @ hex. ;
: DMAMUX-C4CR. ." DMAMUX-C4CR (read-write) $" DMAMUX-C4CR @ hex. ;
: DMAMUX-C5CR. ." DMAMUX-C5CR (read-write) $" DMAMUX-C5CR @ hex. ;
: DMAMUX-C6CR. ." DMAMUX-C6CR (read-write) $" DMAMUX-C6CR @ hex. ;
: DMAMUX-C7CR. ." DMAMUX-C7CR (read-write) $" DMAMUX-C7CR @ hex. ;
: DMAMUX-C8CR. ." DMAMUX-C8CR (read-write) $" DMAMUX-C8CR @ hex. ;
: DMAMUX-C9CR. ." DMAMUX-C9CR (read-write) $" DMAMUX-C9CR @ hex. ;
: DMAMUX-C10CR. ." DMAMUX-C10CR (read-write) $" DMAMUX-C10CR @ hex. ;
: DMAMUX-C11CR. ." DMAMUX-C11CR (read-write) $" DMAMUX-C11CR @ hex. ;
: DMAMUX-C12CR. ." DMAMUX-C12CR (read-write) $" DMAMUX-C12CR @ hex. ;
: DMAMUX-C13CR. ." DMAMUX-C13CR (read-write) $" DMAMUX-C13CR @ hex. ;
: DMAMUX-CSR. ." DMAMUX-CSR (read-only) $" DMAMUX-CSR @ hex. ;
: DMAMUX-CCFR. ." DMAMUX-CCFR (write-only) $" DMAMUX-CCFR @ hex. ;
: DMAMUX-RG0CR. ." DMAMUX-RG0CR (read-write) $" DMAMUX-RG0CR @ hex. ;
: DMAMUX-RG1CR. ." DMAMUX-RG1CR (read-write) $" DMAMUX-RG1CR @ hex. ;
: DMAMUX-RG2CR. ." DMAMUX-RG2CR (read-write) $" DMAMUX-RG2CR @ hex. ;
: DMAMUX-RG3CR. ." DMAMUX-RG3CR (read-write) $" DMAMUX-RG3CR @ hex. ;
: DMAMUX-RGSR. ." DMAMUX-RGSR (read-only) $" DMAMUX-RGSR @ hex. ;
: DMAMUX-RGCFR. ." DMAMUX-RGCFR (write-only) $" DMAMUX-RGCFR @ hex. ;
: DMAMUX.
 cr DMAMUX-C0CR.
 cr DMAMUX-C1CR.
 cr DMAMUX-C2CR.
 cr DMAMUX-C3CR.
 cr DMAMUX-C4CR.
 cr DMAMUX-C5CR.
 cr DMAMUX-C6CR.
 cr DMAMUX-C7CR.
 cr DMAMUX-C8CR.
 cr DMAMUX-C9CR.
 cr DMAMUX-C10CR.
 cr DMAMUX-C11CR.
 cr DMAMUX-C12CR.
 cr DMAMUX-C13CR.
 cr DMAMUX-CSR.
 cr DMAMUX-CCFR.
 cr DMAMUX-RG0CR.
 cr DMAMUX-RG1CR.
 cr DMAMUX-RG2CR.
 cr DMAMUX-RG3CR.
 cr DMAMUX-RGSR.
 cr DMAMUX-RGCFR.
;

$58000800 constant EXTI ( External interrupt/event controller ) 
EXTI $0 + constant EXTI-RTSR1 ( rising trigger selection register ) 
EXTI $4 + constant EXTI-FTSR1 ( falling trigger selection register ) 
EXTI $8 + constant EXTI-SWIER1 ( software interrupt event register ) 
EXTI $C + constant EXTI-PR1 ( EXTI pending register ) 
EXTI $20 + constant EXTI-RTSR2 ( rising trigger selection register ) 
EXTI $24 + constant EXTI-FTSR2 ( falling trigger selection register ) 
EXTI $28 + constant EXTI-SWIER2 ( software interrupt event register ) 
EXTI $2C + constant EXTI-PR2 ( pending register ) 
EXTI $80 + constant EXTI-IMR1 ( interrupt mask register ) 
EXTI $84 + constant EXTI-EMR1 ( event mask register ) 
EXTI $90 + constant EXTI-IMR2 ( interrupt mask register ) 
: EXTI-RTSR1. ." EXTI-RTSR1 (read-write) $" EXTI-RTSR1 @ hex. ;
: EXTI-FTSR1. ." EXTI-FTSR1 (read-write) $" EXTI-FTSR1 @ hex. ;
: EXTI-SWIER1. ." EXTI-SWIER1 (read-write) $" EXTI-SWIER1 @ hex. ;
: EXTI-PR1. ." EXTI-PR1 (read-write) $" EXTI-PR1 @ hex. ;
: EXTI-RTSR2. ." EXTI-RTSR2 (read-write) $" EXTI-RTSR2 @ hex. ;
: EXTI-FTSR2. ." EXTI-FTSR2 (read-write) $" EXTI-FTSR2 @ hex. ;
: EXTI-SWIER2. ." EXTI-SWIER2 (read-write) $" EXTI-SWIER2 @ hex. ;
: EXTI-PR2. ." EXTI-PR2 (read-write) $" EXTI-PR2 @ hex. ;
: EXTI-IMR1. ." EXTI-IMR1 (read-write) $" EXTI-IMR1 @ hex. ;
: EXTI-EMR1. ." EXTI-EMR1 (read-write) $" EXTI-EMR1 @ hex. ;
: EXTI-IMR2. ." EXTI-IMR2 (read-write) $" EXTI-IMR2 @ hex. ;
: EXTI.
 cr EXTI-RTSR1.
 cr EXTI-FTSR1.
 cr EXTI-SWIER1.
 cr EXTI-PR1.
 cr EXTI-RTSR2.
 cr EXTI-FTSR2.
 cr EXTI-SWIER2.
 cr EXTI-PR2.
 cr EXTI-IMR1.
 cr EXTI-EMR1.
 cr EXTI-IMR2.
;

$58004000 constant FLASH ( Flash ) 
FLASH $0 + constant FLASH-ACR ( Access control register ) 
FLASH $8 + constant FLASH-KEYR ( Flash key register ) 
FLASH $C + constant FLASH-OPTKEYR ( Option byte key register ) 
FLASH $10 + constant FLASH-SR ( Status register ) 
FLASH $14 + constant FLASH-CR ( Flash control register ) 
FLASH $18 + constant FLASH-ECCR ( Flash ECC register ) 
FLASH $20 + constant FLASH-OPTR ( Flash option register ) 
FLASH $24 + constant FLASH-PCROP1ASR ( Flash PCROP zone A Start address register ) 
FLASH $28 + constant FLASH-PCROP1AER ( Flash PCROP zone A End address register ) 
FLASH $2C + constant FLASH-WRP1AR ( Flash WRP area A address register ) 
FLASH $30 + constant FLASH-WRP1BR ( Flash WRP area B address register ) 
FLASH $34 + constant FLASH-PCROP1BSR ( Flash PCROP zone B Start address register ) 
FLASH $38 + constant FLASH-PCROP1BER ( Flash PCROP zone B End address register ) 
: FLASH-ACR. ." FLASH-ACR (read-write) $" FLASH-ACR @ hex. ;
: FLASH-KEYR. ." FLASH-KEYR (write-only) $" FLASH-KEYR @ hex. ;
: FLASH-OPTKEYR. ." FLASH-OPTKEYR (write-only) $" FLASH-OPTKEYR @ hex. ;
: FLASH-SR. ." FLASH-SR () $" FLASH-SR @ hex. ;
: FLASH-CR. ." FLASH-CR (read-write) $" FLASH-CR @ hex. ;
: FLASH-ECCR. ." FLASH-ECCR () $" FLASH-ECCR @ hex. ;
: FLASH-OPTR. ." FLASH-OPTR (read-write) $" FLASH-OPTR @ hex. ;
: FLASH-PCROP1ASR. ." FLASH-PCROP1ASR (read-write) $" FLASH-PCROP1ASR @ hex. ;
: FLASH-PCROP1AER. ." FLASH-PCROP1AER () $" FLASH-PCROP1AER @ hex. ;
: FLASH-WRP1AR. ." FLASH-WRP1AR (read-write) $" FLASH-WRP1AR @ hex. ;
: FLASH-WRP1BR. ." FLASH-WRP1BR (read-write) $" FLASH-WRP1BR @ hex. ;
: FLASH-PCROP1BSR. ." FLASH-PCROP1BSR (read-write) $" FLASH-PCROP1BSR @ hex. ;
: FLASH-PCROP1BER. ." FLASH-PCROP1BER (read-write) $" FLASH-PCROP1BER @ hex. ;
: FLASH.
 cr FLASH-ACR.
 cr FLASH-KEYR.
 cr FLASH-OPTKEYR.
 cr FLASH-SR.
 cr FLASH-CR.
 cr FLASH-ECCR.
 cr FLASH-OPTR.
 cr FLASH-PCROP1ASR.
 cr FLASH-PCROP1AER.
 cr FLASH-WRP1AR.
 cr FLASH-WRP1BR.
 cr FLASH-PCROP1BSR.
 cr FLASH-PCROP1BER.
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
: GPIOA-MODER. ." GPIOA-MODER (read-write) $" GPIOA-MODER @ hex. ;
: GPIOA-OTYPER. ." GPIOA-OTYPER (read-write) $" GPIOA-OTYPER @ hex. ;
: GPIOA-OSPEEDR. ." GPIOA-OSPEEDR (read-write) $" GPIOA-OSPEEDR @ hex. ;
: GPIOA-PUPDR. ." GPIOA-PUPDR (read-write) $" GPIOA-PUPDR @ hex. ;
: GPIOA-IDR. ." GPIOA-IDR (read-only) $" GPIOA-IDR @ hex. ;
: GPIOA-ODR. ." GPIOA-ODR (read-write) $" GPIOA-ODR @ hex. ;
: GPIOA-BSRR. ." GPIOA-BSRR (write-only) $" GPIOA-BSRR @ hex. ;
: GPIOA-LCKR. ." GPIOA-LCKR (read-write) $" GPIOA-LCKR @ hex. ;
: GPIOA-AFRL. ." GPIOA-AFRL (read-write) $" GPIOA-AFRL @ hex. ;
: GPIOA-AFRH. ." GPIOA-AFRH (read-write) $" GPIOA-AFRH @ hex. ;
: GPIOA-BRR. ." GPIOA-BRR (read-write) $" GPIOA-BRR @ hex. ;
: GPIOA.
 cr GPIOA-MODER.
 cr GPIOA-OTYPER.
 cr GPIOA-OSPEEDR.
 cr GPIOA-PUPDR.
 cr GPIOA-IDR.
 cr GPIOA-ODR.
 cr GPIOA-BSRR.
 cr GPIOA-LCKR.
 cr GPIOA-AFRL.
 cr GPIOA-AFRH.
 cr GPIOA-BRR.
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
: GPIOB-MODER. ." GPIOB-MODER (read-write) $" GPIOB-MODER @ hex. ;
: GPIOB-OTYPER. ." GPIOB-OTYPER (read-write) $" GPIOB-OTYPER @ hex. ;
: GPIOB-OSPEEDR. ." GPIOB-OSPEEDR (read-write) $" GPIOB-OSPEEDR @ hex. ;
: GPIOB-PUPDR. ." GPIOB-PUPDR (read-write) $" GPIOB-PUPDR @ hex. ;
: GPIOB-IDR. ." GPIOB-IDR (read-only) $" GPIOB-IDR @ hex. ;
: GPIOB-ODR. ." GPIOB-ODR (read-write) $" GPIOB-ODR @ hex. ;
: GPIOB-BSRR. ." GPIOB-BSRR (write-only) $" GPIOB-BSRR @ hex. ;
: GPIOB-LCKR. ." GPIOB-LCKR (read-write) $" GPIOB-LCKR @ hex. ;
: GPIOB-AFRL. ." GPIOB-AFRL (read-write) $" GPIOB-AFRL @ hex. ;
: GPIOB-AFRH. ." GPIOB-AFRH (read-write) $" GPIOB-AFRH @ hex. ;
: GPIOB-BRR. ." GPIOB-BRR (read-write) $" GPIOB-BRR @ hex. ;
: GPIOB.
 cr GPIOB-MODER.
 cr GPIOB-OTYPER.
 cr GPIOB-OSPEEDR.
 cr GPIOB-PUPDR.
 cr GPIOB-IDR.
 cr GPIOB-ODR.
 cr GPIOB-BSRR.
 cr GPIOB-LCKR.
 cr GPIOB-AFRL.
 cr GPIOB-AFRH.
 cr GPIOB-BRR.
;

$48000800 constant GPIOC ( General-purpose I/Os ) 
GPIOC $0 + constant GPIOC-MODER ( GPIO port mode register ) 
GPIOC $4 + constant GPIOC-OTYPER ( GPIO port output type register ) 
GPIOC $8 + constant GPIOC-OSPEEDR ( GPIO port output speed register ) 
GPIOC $C + constant GPIOC-PUPDR ( GPIO port pull-up/pull-down register ) 
GPIOC $10 + constant GPIOC-IDR ( GPIO port input data register ) 
GPIOC $14 + constant GPIOC-ODR ( GPIO port output data register ) 
GPIOC $18 + constant GPIOC-BSRR ( GPIO port bit set/reset register ) 
GPIOC $1C + constant GPIOC-LCKR ( GPIO port configuration lock register ) 
GPIOC $20 + constant GPIOC-AFRL ( GPIO alternate function low register ) 
GPIOC $24 + constant GPIOC-AFRH ( GPIO alternate function high register ) 
GPIOC $28 + constant GPIOC-BRR ( GPIO port bit reset register ) 
: GPIOC-MODER. ." GPIOC-MODER (read-write) $" GPIOC-MODER @ hex. ;
: GPIOC-OTYPER. ." GPIOC-OTYPER (read-write) $" GPIOC-OTYPER @ hex. ;
: GPIOC-OSPEEDR. ." GPIOC-OSPEEDR (read-write) $" GPIOC-OSPEEDR @ hex. ;
: GPIOC-PUPDR. ." GPIOC-PUPDR (read-write) $" GPIOC-PUPDR @ hex. ;
: GPIOC-IDR. ." GPIOC-IDR (read-only) $" GPIOC-IDR @ hex. ;
: GPIOC-ODR. ." GPIOC-ODR (read-write) $" GPIOC-ODR @ hex. ;
: GPIOC-BSRR. ." GPIOC-BSRR (write-only) $" GPIOC-BSRR @ hex. ;
: GPIOC-LCKR. ." GPIOC-LCKR (read-write) $" GPIOC-LCKR @ hex. ;
: GPIOC-AFRL. ." GPIOC-AFRL (read-write) $" GPIOC-AFRL @ hex. ;
: GPIOC-AFRH. ." GPIOC-AFRH (read-write) $" GPIOC-AFRH @ hex. ;
: GPIOC-BRR. ." GPIOC-BRR (read-write) $" GPIOC-BRR @ hex. ;
: GPIOC.
 cr GPIOC-MODER.
 cr GPIOC-OTYPER.
 cr GPIOC-OSPEEDR.
 cr GPIOC-PUPDR.
 cr GPIOC-IDR.
 cr GPIOC-ODR.
 cr GPIOC-BSRR.
 cr GPIOC-LCKR.
 cr GPIOC-AFRL.
 cr GPIOC-AFRH.
 cr GPIOC-BRR.
;

$48001C00 constant GPIOH ( General-purpose I/Os ) 
GPIOH $0 + constant GPIOH-MODER ( GPIO port mode register ) 
GPIOH $4 + constant GPIOH-OTYPER ( GPIO port output type register ) 
GPIOH $8 + constant GPIOH-OSPEEDR ( GPIO port output speed register ) 
GPIOH $C + constant GPIOH-PUPDR ( GPIO port pull-up/pull-down register ) 
GPIOH $10 + constant GPIOH-IDR ( GPIO port input data register ) 
GPIOH $14 + constant GPIOH-ODR ( GPIO port output data register ) 
GPIOH $18 + constant GPIOH-BSRR ( GPIO port bit set/reset register ) 
GPIOH $1C + constant GPIOH-LCKR ( GPIO port configuration lock register ) 
GPIOH $20 + constant GPIOH-AFRL ( GPIO alternate function low register ) 
GPIOH $24 + constant GPIOH-AFRH ( GPIO alternate function high register ) 
GPIOH $28 + constant GPIOH-BRR ( GPIO port bit reset register ) 
: GPIOH-MODER. ." GPIOH-MODER (read-write) $" GPIOH-MODER @ hex. ;
: GPIOH-OTYPER. ." GPIOH-OTYPER (read-write) $" GPIOH-OTYPER @ hex. ;
: GPIOH-OSPEEDR. ." GPIOH-OSPEEDR (read-write) $" GPIOH-OSPEEDR @ hex. ;
: GPIOH-PUPDR. ." GPIOH-PUPDR (read-write) $" GPIOH-PUPDR @ hex. ;
: GPIOH-IDR. ." GPIOH-IDR (read-only) $" GPIOH-IDR @ hex. ;
: GPIOH-ODR. ." GPIOH-ODR (read-write) $" GPIOH-ODR @ hex. ;
: GPIOH-BSRR. ." GPIOH-BSRR (write-only) $" GPIOH-BSRR @ hex. ;
: GPIOH-LCKR. ." GPIOH-LCKR (read-write) $" GPIOH-LCKR @ hex. ;
: GPIOH-AFRL. ." GPIOH-AFRL (read-write) $" GPIOH-AFRL @ hex. ;
: GPIOH-AFRH. ." GPIOH-AFRH (read-write) $" GPIOH-AFRH @ hex. ;
: GPIOH-BRR. ." GPIOH-BRR (read-write) $" GPIOH-BRR @ hex. ;
: GPIOH.
 cr GPIOH-MODER.
 cr GPIOH-OTYPER.
 cr GPIOH-OSPEEDR.
 cr GPIOH-PUPDR.
 cr GPIOH-IDR.
 cr GPIOH-ODR.
 cr GPIOH-BSRR.
 cr GPIOH-LCKR.
 cr GPIOH-AFRL.
 cr GPIOH-AFRH.
 cr GPIOH-BRR.
;

$58001400 constant HSEM ( Hardware semaphore ) 
HSEM $0 + constant HSEM-HSEM_R0 ( HSEM register HSEM_R0 HSEM_R31 ) 
HSEM $4 + constant HSEM-HSEM_R1 ( HSEM register HSEM_R0 HSEM_R31 ) 
HSEM $8 + constant HSEM-HSEM_R2 ( HSEM register HSEM_R0 HSEM_R31 ) 
HSEM $C + constant HSEM-HSEM_R3 ( HSEM register HSEM_R0 HSEM_R31 ) 
HSEM $10 + constant HSEM-HSEM_R4 ( HSEM register HSEM_R0 HSEM_R31 ) 
HSEM $14 + constant HSEM-HSEM_R5 ( HSEM register HSEM_R0 HSEM_R31 ) 
HSEM $18 + constant HSEM-HSEM_R6 ( HSEM register HSEM_R0 HSEM_R31 ) 
HSEM $1C + constant HSEM-HSEM_R7 ( HSEM register HSEM_R0 HSEM_R31 ) 
HSEM $20 + constant HSEM-HSEM_R8 ( HSEM register HSEM_R0 HSEM_R31 ) 
HSEM $24 + constant HSEM-HSEM_R9 ( HSEM register HSEM_R0 HSEM_R31 ) 
HSEM $28 + constant HSEM-HSEM_R10 ( HSEM register HSEM_R0 HSEM_R31 ) 
HSEM $2C + constant HSEM-HSEM_R11 ( HSEM register HSEM_R0 HSEM_R31 ) 
HSEM $30 + constant HSEM-HSEM_R12 ( HSEM register HSEM_R0 HSEM_R31 ) 
HSEM $34 + constant HSEM-HSEM_R13 ( HSEM register HSEM_R0 HSEM_R31 ) 
HSEM $38 + constant HSEM-HSEM_R14 ( HSEM register HSEM_R0 HSEM_R31 ) 
HSEM $3C + constant HSEM-HSEM_R15 ( HSEM register HSEM_R0 HSEM_R31 ) 
HSEM $80 + constant HSEM-HSEM_RLR0 ( HSEM Read lock register ) 
HSEM $84 + constant HSEM-HSEM_RLR1 ( HSEM Read lock register ) 
HSEM $88 + constant HSEM-HSEM_RLR2 ( HSEM Read lock register ) 
HSEM $8C + constant HSEM-HSEM_RLR3 ( HSEM Read lock register ) 
HSEM $90 + constant HSEM-HSEM_RLR4 ( HSEM Read lock register ) 
HSEM $94 + constant HSEM-HSEM_RLR5 ( HSEM Read lock register ) 
HSEM $98 + constant HSEM-HSEM_RLR6 ( HSEM Read lock register ) 
HSEM $9C + constant HSEM-HSEM_RLR7 ( HSEM Read lock register ) 
HSEM $A0 + constant HSEM-HSEM_RLR8 ( HSEM Read lock register ) 
HSEM $A4 + constant HSEM-HSEM_RLR9 ( HSEM Read lock register ) 
HSEM $A8 + constant HSEM-HSEM_RLR10 ( HSEM Read lock register ) 
HSEM $AC + constant HSEM-HSEM_RLR11 ( HSEM Read lock register ) 
HSEM $B0 + constant HSEM-HSEM_RLR12 ( HSEM Read lock register ) 
HSEM $B4 + constant HSEM-HSEM_RLR13 ( HSEM Read lock register ) 
HSEM $B8 + constant HSEM-HSEM_RLR14 ( HSEM Read lock register ) 
HSEM $BC + constant HSEM-HSEM_RLR15 ( HSEM Read lock register ) 
HSEM $100 + constant HSEM-HSEM_IER ( HSEM Interrupt enable register ) 
HSEM $104 + constant HSEM-HSEM_ICR ( HSEM Interrupt clear register ) 
HSEM $108 + constant HSEM-HSEM_ISR ( HSEM Interrupt status register ) 
HSEM $10C + constant HSEM-HSEM_MISR ( HSEM Masked interrupt status register ) 
HSEM $140 + constant HSEM-HSEM_CR ( HSEM Clear register ) 
HSEM $144 + constant HSEM-HSEM_KEYR ( HSEM Interrupt clear register ) 
: HSEM-HSEM_R0. ." HSEM-HSEM_R0 (read-write) $" HSEM-HSEM_R0 @ hex. ;
: HSEM-HSEM_R1. ." HSEM-HSEM_R1 (read-write) $" HSEM-HSEM_R1 @ hex. ;
: HSEM-HSEM_R2. ." HSEM-HSEM_R2 (read-write) $" HSEM-HSEM_R2 @ hex. ;
: HSEM-HSEM_R3. ." HSEM-HSEM_R3 (read-write) $" HSEM-HSEM_R3 @ hex. ;
: HSEM-HSEM_R4. ." HSEM-HSEM_R4 (read-write) $" HSEM-HSEM_R4 @ hex. ;
: HSEM-HSEM_R5. ." HSEM-HSEM_R5 (read-write) $" HSEM-HSEM_R5 @ hex. ;
: HSEM-HSEM_R6. ." HSEM-HSEM_R6 (read-write) $" HSEM-HSEM_R6 @ hex. ;
: HSEM-HSEM_R7. ." HSEM-HSEM_R7 (read-write) $" HSEM-HSEM_R7 @ hex. ;
: HSEM-HSEM_R8. ." HSEM-HSEM_R8 (read-write) $" HSEM-HSEM_R8 @ hex. ;
: HSEM-HSEM_R9. ." HSEM-HSEM_R9 (read-write) $" HSEM-HSEM_R9 @ hex. ;
: HSEM-HSEM_R10. ." HSEM-HSEM_R10 (read-write) $" HSEM-HSEM_R10 @ hex. ;
: HSEM-HSEM_R11. ." HSEM-HSEM_R11 (read-write) $" HSEM-HSEM_R11 @ hex. ;
: HSEM-HSEM_R12. ." HSEM-HSEM_R12 (read-write) $" HSEM-HSEM_R12 @ hex. ;
: HSEM-HSEM_R13. ." HSEM-HSEM_R13 (read-write) $" HSEM-HSEM_R13 @ hex. ;
: HSEM-HSEM_R14. ." HSEM-HSEM_R14 (read-write) $" HSEM-HSEM_R14 @ hex. ;
: HSEM-HSEM_R15. ." HSEM-HSEM_R15 (read-write) $" HSEM-HSEM_R15 @ hex. ;
: HSEM-HSEM_RLR0. ." HSEM-HSEM_RLR0 (read-only) $" HSEM-HSEM_RLR0 @ hex. ;
: HSEM-HSEM_RLR1. ." HSEM-HSEM_RLR1 (read-only) $" HSEM-HSEM_RLR1 @ hex. ;
: HSEM-HSEM_RLR2. ." HSEM-HSEM_RLR2 (read-only) $" HSEM-HSEM_RLR2 @ hex. ;
: HSEM-HSEM_RLR3. ." HSEM-HSEM_RLR3 (read-only) $" HSEM-HSEM_RLR3 @ hex. ;
: HSEM-HSEM_RLR4. ." HSEM-HSEM_RLR4 (read-only) $" HSEM-HSEM_RLR4 @ hex. ;
: HSEM-HSEM_RLR5. ." HSEM-HSEM_RLR5 (read-only) $" HSEM-HSEM_RLR5 @ hex. ;
: HSEM-HSEM_RLR6. ." HSEM-HSEM_RLR6 (read-only) $" HSEM-HSEM_RLR6 @ hex. ;
: HSEM-HSEM_RLR7. ." HSEM-HSEM_RLR7 (read-only) $" HSEM-HSEM_RLR7 @ hex. ;
: HSEM-HSEM_RLR8. ." HSEM-HSEM_RLR8 (read-only) $" HSEM-HSEM_RLR8 @ hex. ;
: HSEM-HSEM_RLR9. ." HSEM-HSEM_RLR9 (read-only) $" HSEM-HSEM_RLR9 @ hex. ;
: HSEM-HSEM_RLR10. ." HSEM-HSEM_RLR10 (read-only) $" HSEM-HSEM_RLR10 @ hex. ;
: HSEM-HSEM_RLR11. ." HSEM-HSEM_RLR11 (read-only) $" HSEM-HSEM_RLR11 @ hex. ;
: HSEM-HSEM_RLR12. ." HSEM-HSEM_RLR12 (read-only) $" HSEM-HSEM_RLR12 @ hex. ;
: HSEM-HSEM_RLR13. ." HSEM-HSEM_RLR13 (read-only) $" HSEM-HSEM_RLR13 @ hex. ;
: HSEM-HSEM_RLR14. ." HSEM-HSEM_RLR14 (read-only) $" HSEM-HSEM_RLR14 @ hex. ;
: HSEM-HSEM_RLR15. ." HSEM-HSEM_RLR15 (read-only) $" HSEM-HSEM_RLR15 @ hex. ;
: HSEM-HSEM_IER. ." HSEM-HSEM_IER (read-write) $" HSEM-HSEM_IER @ hex. ;
: HSEM-HSEM_ICR. ." HSEM-HSEM_ICR (read-write) $" HSEM-HSEM_ICR @ hex. ;
: HSEM-HSEM_ISR. ." HSEM-HSEM_ISR (read-only) $" HSEM-HSEM_ISR @ hex. ;
: HSEM-HSEM_MISR. ." HSEM-HSEM_MISR (read-only) $" HSEM-HSEM_MISR @ hex. ;
: HSEM-HSEM_CR. ." HSEM-HSEM_CR (write-only) $" HSEM-HSEM_CR @ hex. ;
: HSEM-HSEM_KEYR. ." HSEM-HSEM_KEYR (read-write) $" HSEM-HSEM_KEYR @ hex. ;
: HSEM.
 cr HSEM-HSEM_R0.
 cr HSEM-HSEM_R1.
 cr HSEM-HSEM_R2.
 cr HSEM-HSEM_R3.
 cr HSEM-HSEM_R4.
 cr HSEM-HSEM_R5.
 cr HSEM-HSEM_R6.
 cr HSEM-HSEM_R7.
 cr HSEM-HSEM_R8.
 cr HSEM-HSEM_R9.
 cr HSEM-HSEM_R10.
 cr HSEM-HSEM_R11.
 cr HSEM-HSEM_R12.
 cr HSEM-HSEM_R13.
 cr HSEM-HSEM_R14.
 cr HSEM-HSEM_R15.
 cr HSEM-HSEM_RLR0.
 cr HSEM-HSEM_RLR1.
 cr HSEM-HSEM_RLR2.
 cr HSEM-HSEM_RLR3.
 cr HSEM-HSEM_RLR4.
 cr HSEM-HSEM_RLR5.
 cr HSEM-HSEM_RLR6.
 cr HSEM-HSEM_RLR7.
 cr HSEM-HSEM_RLR8.
 cr HSEM-HSEM_RLR9.
 cr HSEM-HSEM_RLR10.
 cr HSEM-HSEM_RLR11.
 cr HSEM-HSEM_RLR12.
 cr HSEM-HSEM_RLR13.
 cr HSEM-HSEM_RLR14.
 cr HSEM-HSEM_RLR15.
 cr HSEM-HSEM_IER.
 cr HSEM-HSEM_ICR.
 cr HSEM-HSEM_ISR.
 cr HSEM-HSEM_MISR.
 cr HSEM-HSEM_CR.
 cr HSEM-HSEM_KEYR.
;

$40005400 constant I2C1 ( Inter-integrated circuit ) 
I2C1 $0 + constant I2C1-CR1 ( Control register 1 ) 
I2C1 $4 + constant I2C1-CR2 ( Control register 2 ) 
I2C1 $8 + constant I2C1-OAR1 ( Own address register 1 ) 
I2C1 $C + constant I2C1-OAR2 ( Own address register 2 ) 
I2C1 $10 + constant I2C1-TIMINGR ( Timing register ) 
I2C1 $14 + constant I2C1-TIMEOUTR ( Status register 1 ) 
I2C1 $18 + constant I2C1-ISR ( Interrupt and Status register ) 
I2C1 $1C + constant I2C1-ICR ( Interrupt clear register ) 
I2C1 $20 + constant I2C1-PECR ( PEC register ) 
I2C1 $24 + constant I2C1-RXDR ( Receive data register ) 
I2C1 $28 + constant I2C1-TXDR ( Transmit data register ) 
: I2C1-CR1. ." I2C1-CR1 (read-write) $" I2C1-CR1 @ hex. ;
: I2C1-CR2. ." I2C1-CR2 (read-write) $" I2C1-CR2 @ hex. ;
: I2C1-OAR1. ." I2C1-OAR1 (read-write) $" I2C1-OAR1 @ hex. ;
: I2C1-OAR2. ." I2C1-OAR2 (read-write) $" I2C1-OAR2 @ hex. ;
: I2C1-TIMINGR. ." I2C1-TIMINGR (read-write) $" I2C1-TIMINGR @ hex. ;
: I2C1-TIMEOUTR. ." I2C1-TIMEOUTR (read-write) $" I2C1-TIMEOUTR @ hex. ;
: I2C1-ISR. ." I2C1-ISR () $" I2C1-ISR @ hex. ;
: I2C1-ICR. ." I2C1-ICR (write-only) $" I2C1-ICR @ hex. ;
: I2C1-PECR. ." I2C1-PECR (read-only) $" I2C1-PECR @ hex. ;
: I2C1-RXDR. ." I2C1-RXDR (read-only) $" I2C1-RXDR @ hex. ;
: I2C1-TXDR. ." I2C1-TXDR (read-write) $" I2C1-TXDR @ hex. ;
: I2C1.
 cr I2C1-CR1.
 cr I2C1-CR2.
 cr I2C1-OAR1.
 cr I2C1-OAR2.
 cr I2C1-TIMINGR.
 cr I2C1-TIMEOUTR.
 cr I2C1-ISR.
 cr I2C1-ICR.
 cr I2C1-PECR.
 cr I2C1-RXDR.
 cr I2C1-TXDR.
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
: I2C2-CR1. ." I2C2-CR1 (read-write) $" I2C2-CR1 @ hex. ;
: I2C2-CR2. ." I2C2-CR2 (read-write) $" I2C2-CR2 @ hex. ;
: I2C2-OAR1. ." I2C2-OAR1 (read-write) $" I2C2-OAR1 @ hex. ;
: I2C2-OAR2. ." I2C2-OAR2 (read-write) $" I2C2-OAR2 @ hex. ;
: I2C2-TIMINGR. ." I2C2-TIMINGR (read-write) $" I2C2-TIMINGR @ hex. ;
: I2C2-TIMEOUTR. ." I2C2-TIMEOUTR (read-write) $" I2C2-TIMEOUTR @ hex. ;
: I2C2-ISR. ." I2C2-ISR () $" I2C2-ISR @ hex. ;
: I2C2-ICR. ." I2C2-ICR (write-only) $" I2C2-ICR @ hex. ;
: I2C2-PECR. ." I2C2-PECR (read-only) $" I2C2-PECR @ hex. ;
: I2C2-RXDR. ." I2C2-RXDR (read-only) $" I2C2-RXDR @ hex. ;
: I2C2-TXDR. ." I2C2-TXDR (read-write) $" I2C2-TXDR @ hex. ;
: I2C2.
 cr I2C2-CR1.
 cr I2C2-CR2.
 cr I2C2-OAR1.
 cr I2C2-OAR2.
 cr I2C2-TIMINGR.
 cr I2C2-TIMEOUTR.
 cr I2C2-ISR.
 cr I2C2-ICR.
 cr I2C2-PECR.
 cr I2C2-RXDR.
 cr I2C2-TXDR.
;

$40005C00 constant I2C3 ( Inter-integrated circuit ) 
I2C3 $0 + constant I2C3-CR1 ( Control register 1 ) 
I2C3 $4 + constant I2C3-CR2 ( Control register 2 ) 
I2C3 $8 + constant I2C3-OAR1 ( Own address register 1 ) 
I2C3 $C + constant I2C3-OAR2 ( Own address register 2 ) 
I2C3 $10 + constant I2C3-TIMINGR ( Timing register ) 
I2C3 $14 + constant I2C3-TIMEOUTR ( Status register 1 ) 
I2C3 $18 + constant I2C3-ISR ( Interrupt and Status register ) 
I2C3 $1C + constant I2C3-ICR ( Interrupt clear register ) 
I2C3 $20 + constant I2C3-PECR ( PEC register ) 
I2C3 $24 + constant I2C3-RXDR ( Receive data register ) 
I2C3 $28 + constant I2C3-TXDR ( Transmit data register ) 
: I2C3-CR1. ." I2C3-CR1 (read-write) $" I2C3-CR1 @ hex. ;
: I2C3-CR2. ." I2C3-CR2 (read-write) $" I2C3-CR2 @ hex. ;
: I2C3-OAR1. ." I2C3-OAR1 (read-write) $" I2C3-OAR1 @ hex. ;
: I2C3-OAR2. ." I2C3-OAR2 (read-write) $" I2C3-OAR2 @ hex. ;
: I2C3-TIMINGR. ." I2C3-TIMINGR (read-write) $" I2C3-TIMINGR @ hex. ;
: I2C3-TIMEOUTR. ." I2C3-TIMEOUTR (read-write) $" I2C3-TIMEOUTR @ hex. ;
: I2C3-ISR. ." I2C3-ISR () $" I2C3-ISR @ hex. ;
: I2C3-ICR. ." I2C3-ICR (write-only) $" I2C3-ICR @ hex. ;
: I2C3-PECR. ." I2C3-PECR (read-only) $" I2C3-PECR @ hex. ;
: I2C3-RXDR. ." I2C3-RXDR (read-only) $" I2C3-RXDR @ hex. ;
: I2C3-TXDR. ." I2C3-TXDR (read-write) $" I2C3-TXDR @ hex. ;
: I2C3.
 cr I2C3-CR1.
 cr I2C3-CR2.
 cr I2C3-OAR1.
 cr I2C3-OAR2.
 cr I2C3-TIMINGR.
 cr I2C3-TIMEOUTR.
 cr I2C3-ISR.
 cr I2C3-ICR.
 cr I2C3-PECR.
 cr I2C3-RXDR.
 cr I2C3-TXDR.
;

$40003000 constant IWDG ( Independent watchdog ) 
IWDG $0 + constant IWDG-KR ( Key register ) 
IWDG $4 + constant IWDG-PR ( Prescaler register ) 
IWDG $8 + constant IWDG-RLR ( Reload register ) 
IWDG $C + constant IWDG-SR ( Status register ) 
IWDG $10 + constant IWDG-WINR ( Window register ) 
: IWDG-KR. ." IWDG-KR (write-only) $" IWDG-KR @ hex. ;
: IWDG-PR. ." IWDG-PR (read-write) $" IWDG-PR @ hex. ;
: IWDG-RLR. ." IWDG-RLR (read-write) $" IWDG-RLR @ hex. ;
: IWDG-SR. ." IWDG-SR (read-only) $" IWDG-SR @ hex. ;
: IWDG-WINR. ." IWDG-WINR (read-write) $" IWDG-WINR @ hex. ;
: IWDG.
 cr IWDG-KR.
 cr IWDG-PR.
 cr IWDG-RLR.
 cr IWDG-SR.
 cr IWDG-WINR.
;

$40007C00 constant LPTIM1 ( Low-power timer ) 
LPTIM1 $0 + constant LPTIM1-ISR ( interrupt and status register ) 
LPTIM1 $4 + constant LPTIM1-ICR ( interrupt clear register ) 
LPTIM1 $8 + constant LPTIM1-IER ( interrupt enable register ) 
LPTIM1 $C + constant LPTIM1-CFGR ( configuration register ) 
LPTIM1 $10 + constant LPTIM1-CR ( control register ) 
LPTIM1 $14 + constant LPTIM1-CMP ( compare register ) 
LPTIM1 $18 + constant LPTIM1-ARR ( autoreload register ) 
LPTIM1 $1C + constant LPTIM1-CNT ( counter register ) 
LPTIM1 $20 + constant LPTIM1-LPTIM1_OR ( option register ) 
LPTIM1 $28 + constant LPTIM1-RCR ( repetition register ) 
: LPTIM1-ISR. ." LPTIM1-ISR (read-only) $" LPTIM1-ISR @ hex. ;
: LPTIM1-ICR. ." LPTIM1-ICR (write-only) $" LPTIM1-ICR @ hex. ;
: LPTIM1-IER. ." LPTIM1-IER (read-write) $" LPTIM1-IER @ hex. ;
: LPTIM1-CFGR. ." LPTIM1-CFGR (read-write) $" LPTIM1-CFGR @ hex. ;
: LPTIM1-CR. ." LPTIM1-CR (read-write) $" LPTIM1-CR @ hex. ;
: LPTIM1-CMP. ." LPTIM1-CMP (read-write) $" LPTIM1-CMP @ hex. ;
: LPTIM1-ARR. ." LPTIM1-ARR (read-write) $" LPTIM1-ARR @ hex. ;
: LPTIM1-CNT. ." LPTIM1-CNT (read-only) $" LPTIM1-CNT @ hex. ;
: LPTIM1-LPTIM1_OR. ." LPTIM1-LPTIM1_OR (read-write) $" LPTIM1-LPTIM1_OR @ hex. ;
: LPTIM1-RCR. ." LPTIM1-RCR (read-write) $" LPTIM1-RCR @ hex. ;
: LPTIM1.
 cr LPTIM1-ISR.
 cr LPTIM1-ICR.
 cr LPTIM1-IER.
 cr LPTIM1-CFGR.
 cr LPTIM1-CR.
 cr LPTIM1-CMP.
 cr LPTIM1-ARR.
 cr LPTIM1-CNT.
 cr LPTIM1-LPTIM1_OR.
 cr LPTIM1-RCR.
;

$40009400 constant LPTIM2 ( Low-power timer ) 
LPTIM2 $0 + constant LPTIM2-ISR ( interrupt and status register ) 
LPTIM2 $4 + constant LPTIM2-ICR ( interrupt clear register ) 
LPTIM2 $8 + constant LPTIM2-IER ( interrupt enable register ) 
LPTIM2 $C + constant LPTIM2-CFGR ( configuration register ) 
LPTIM2 $10 + constant LPTIM2-CR ( control register ) 
LPTIM2 $14 + constant LPTIM2-CMP ( compare register ) 
LPTIM2 $18 + constant LPTIM2-ARR ( autoreload register ) 
LPTIM2 $1C + constant LPTIM2-CNT ( counter register ) 
LPTIM2 $20 + constant LPTIM2-LPTIM2_OR ( option register ) 
LPTIM2 $28 + constant LPTIM2-RCR ( repetition register ) 
: LPTIM2-ISR. ." LPTIM2-ISR (read-only) $" LPTIM2-ISR @ hex. ;
: LPTIM2-ICR. ." LPTIM2-ICR (write-only) $" LPTIM2-ICR @ hex. ;
: LPTIM2-IER. ." LPTIM2-IER (read-write) $" LPTIM2-IER @ hex. ;
: LPTIM2-CFGR. ." LPTIM2-CFGR (read-write) $" LPTIM2-CFGR @ hex. ;
: LPTIM2-CR. ." LPTIM2-CR (read-write) $" LPTIM2-CR @ hex. ;
: LPTIM2-CMP. ." LPTIM2-CMP (read-write) $" LPTIM2-CMP @ hex. ;
: LPTIM2-ARR. ." LPTIM2-ARR (read-write) $" LPTIM2-ARR @ hex. ;
: LPTIM2-CNT. ." LPTIM2-CNT (read-only) $" LPTIM2-CNT @ hex. ;
: LPTIM2-LPTIM2_OR. ." LPTIM2-LPTIM2_OR (read-write) $" LPTIM2-LPTIM2_OR @ hex. ;
: LPTIM2-RCR. ." LPTIM2-RCR (read-write) $" LPTIM2-RCR @ hex. ;
: LPTIM2.
 cr LPTIM2-ISR.
 cr LPTIM2-ICR.
 cr LPTIM2-IER.
 cr LPTIM2-CFGR.
 cr LPTIM2-CR.
 cr LPTIM2-CMP.
 cr LPTIM2-ARR.
 cr LPTIM2-CNT.
 cr LPTIM2-LPTIM2_OR.
 cr LPTIM2-RCR.
;

$40009800 constant LPTIM3 ( Low-power timer ) 
LPTIM3 $0 + constant LPTIM3-ISR ( interrupt and status register ) 
LPTIM3 $4 + constant LPTIM3-ICR ( interrupt clear register ) 
LPTIM3 $8 + constant LPTIM3-IER ( interrupt enable register ) 
LPTIM3 $C + constant LPTIM3-CFGR ( configuration register ) 
LPTIM3 $10 + constant LPTIM3-CR ( control register ) 
LPTIM3 $14 + constant LPTIM3-CMP ( compare register ) 
LPTIM3 $18 + constant LPTIM3-ARR ( autoreload register ) 
LPTIM3 $1C + constant LPTIM3-CNT ( counter register ) 
LPTIM3 $20 + constant LPTIM3-LPTIM3_OR ( option register ) 
LPTIM3 $28 + constant LPTIM3-RCR ( repetition register ) 
: LPTIM3-ISR. ." LPTIM3-ISR (read-only) $" LPTIM3-ISR @ hex. ;
: LPTIM3-ICR. ." LPTIM3-ICR (write-only) $" LPTIM3-ICR @ hex. ;
: LPTIM3-IER. ." LPTIM3-IER (read-write) $" LPTIM3-IER @ hex. ;
: LPTIM3-CFGR. ." LPTIM3-CFGR (read-write) $" LPTIM3-CFGR @ hex. ;
: LPTIM3-CR. ." LPTIM3-CR (read-write) $" LPTIM3-CR @ hex. ;
: LPTIM3-CMP. ." LPTIM3-CMP (read-write) $" LPTIM3-CMP @ hex. ;
: LPTIM3-ARR. ." LPTIM3-ARR (read-write) $" LPTIM3-ARR @ hex. ;
: LPTIM3-CNT. ." LPTIM3-CNT (read-only) $" LPTIM3-CNT @ hex. ;
: LPTIM3-LPTIM3_OR. ." LPTIM3-LPTIM3_OR (read-write) $" LPTIM3-LPTIM3_OR @ hex. ;
: LPTIM3-RCR. ." LPTIM3-RCR (read-write) $" LPTIM3-RCR @ hex. ;
: LPTIM3.
 cr LPTIM3-ISR.
 cr LPTIM3-ICR.
 cr LPTIM3-IER.
 cr LPTIM3-CFGR.
 cr LPTIM3-CR.
 cr LPTIM3-CMP.
 cr LPTIM3-ARR.
 cr LPTIM3-CNT.
 cr LPTIM3-LPTIM3_OR.
 cr LPTIM3-RCR.
;

$40008000 constant LPUART ( Universal synchronous asynchronous receiver transmitter ) 
LPUART $0 + constant LPUART-CR1_enabled ( Control register 1 ) 
LPUART $0 + constant LPUART-CR1_disabled ( Control register 1 ) 
LPUART $4 + constant LPUART-CR2 ( Control register 2 ) 
LPUART $8 + constant LPUART-CR3 ( Control register 3 ) 
LPUART $C + constant LPUART-BRR ( Baud rate register ) 
LPUART $18 + constant LPUART-RQR ( Request register ) 
LPUART $1C + constant LPUART-ISR_enabled ( Interrupt and status register ) 
LPUART $1C + constant LPUART-ISR_disabled ( Interrupt and status register ) 
LPUART $20 + constant LPUART-ICR ( Interrupt flag clear register ) 
LPUART $24 + constant LPUART-RDR ( Receive data register ) 
LPUART $28 + constant LPUART-TDR ( Transmit data register ) 
LPUART $2C + constant LPUART-PRESC ( Prescaler register ) 
: LPUART-CR1_enabled. ." LPUART-CR1_enabled (read-write) $" LPUART-CR1_enabled @ hex. ;
: LPUART-CR1_disabled. ." LPUART-CR1_disabled (read-write) $" LPUART-CR1_disabled @ hex. ;
: LPUART-CR2. ." LPUART-CR2 (read-write) $" LPUART-CR2 @ hex. ;
: LPUART-CR3. ." LPUART-CR3 (read-write) $" LPUART-CR3 @ hex. ;
: LPUART-BRR. ." LPUART-BRR (read-write) $" LPUART-BRR @ hex. ;
: LPUART-RQR. ." LPUART-RQR (write-only) $" LPUART-RQR @ hex. ;
: LPUART-ISR_enabled. ." LPUART-ISR_enabled (read-only) $" LPUART-ISR_enabled @ hex. ;
: LPUART-ISR_disabled. ." LPUART-ISR_disabled (read-only) $" LPUART-ISR_disabled @ hex. ;
: LPUART-ICR. ." LPUART-ICR (write-only) $" LPUART-ICR @ hex. ;
: LPUART-RDR. ." LPUART-RDR (read-only) $" LPUART-RDR @ hex. ;
: LPUART-TDR. ." LPUART-TDR (read-write) $" LPUART-TDR @ hex. ;
: LPUART-PRESC. ." LPUART-PRESC (read-write) $" LPUART-PRESC @ hex. ;
: LPUART.
 cr LPUART-CR1_enabled.
 cr LPUART-CR1_disabled.
 cr LPUART-CR2.
 cr LPUART-CR3.
 cr LPUART-BRR.
 cr LPUART-RQR.
 cr LPUART-ISR_enabled.
 cr LPUART-ISR_disabled.
 cr LPUART-ICR.
 cr LPUART-RDR.
 cr LPUART-TDR.
 cr LPUART-PRESC.
;

$E000ED90 constant MPU ( Memory protection unit ) 
MPU $0 + constant MPU-MPU_TYPER ( MPU type register ) 
MPU $4 + constant MPU-MPU_CTRL ( MPU control register ) 
MPU $8 + constant MPU-MPU_RNR ( MPU region number register ) 
MPU $C + constant MPU-MPU_RBAR ( MPU region base address register ) 
MPU $10 + constant MPU-MPU_RASR ( MPU region attribute and size register ) 
: MPU-MPU_TYPER. ." MPU-MPU_TYPER (read-only) $" MPU-MPU_TYPER @ hex. ;
: MPU-MPU_CTRL. ." MPU-MPU_CTRL (read-only) $" MPU-MPU_CTRL @ hex. ;
: MPU-MPU_RNR. ." MPU-MPU_RNR (read-write) $" MPU-MPU_RNR @ hex. ;
: MPU-MPU_RBAR. ." MPU-MPU_RBAR (read-write) $" MPU-MPU_RBAR @ hex. ;
: MPU-MPU_RASR. ." MPU-MPU_RASR (read-write) $" MPU-MPU_RASR @ hex. ;
: MPU.
 cr MPU-MPU_TYPER.
 cr MPU-MPU_CTRL.
 cr MPU-MPU_RNR.
 cr MPU-MPU_RBAR.
 cr MPU-MPU_RASR.
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
: NVIC-ISER0. ." NVIC-ISER0 (read-write) $" NVIC-ISER0 @ hex. ;
: NVIC-ISER1. ." NVIC-ISER1 (read-write) $" NVIC-ISER1 @ hex. ;
: NVIC-ICER0. ." NVIC-ICER0 (read-write) $" NVIC-ICER0 @ hex. ;
: NVIC-ICER1. ." NVIC-ICER1 (read-write) $" NVIC-ICER1 @ hex. ;
: NVIC-ISPR0. ." NVIC-ISPR0 (read-write) $" NVIC-ISPR0 @ hex. ;
: NVIC-ISPR1. ." NVIC-ISPR1 (read-write) $" NVIC-ISPR1 @ hex. ;
: NVIC-ICPR0. ." NVIC-ICPR0 (read-write) $" NVIC-ICPR0 @ hex. ;
: NVIC-ICPR1. ." NVIC-ICPR1 (read-write) $" NVIC-ICPR1 @ hex. ;
: NVIC-IABR0. ." NVIC-IABR0 (read-only) $" NVIC-IABR0 @ hex. ;
: NVIC-IABR1. ." NVIC-IABR1 (read-only) $" NVIC-IABR1 @ hex. ;
: NVIC-IPR0. ." NVIC-IPR0 (read-write) $" NVIC-IPR0 @ hex. ;
: NVIC-IPR1. ." NVIC-IPR1 (read-write) $" NVIC-IPR1 @ hex. ;
: NVIC-IPR2. ." NVIC-IPR2 (read-write) $" NVIC-IPR2 @ hex. ;
: NVIC-IPR3. ." NVIC-IPR3 (read-write) $" NVIC-IPR3 @ hex. ;
: NVIC-IPR4. ." NVIC-IPR4 (read-write) $" NVIC-IPR4 @ hex. ;
: NVIC-IPR5. ." NVIC-IPR5 (read-write) $" NVIC-IPR5 @ hex. ;
: NVIC-IPR6. ." NVIC-IPR6 (read-write) $" NVIC-IPR6 @ hex. ;
: NVIC-IPR7. ." NVIC-IPR7 (read-write) $" NVIC-IPR7 @ hex. ;
: NVIC-IPR8. ." NVIC-IPR8 (read-write) $" NVIC-IPR8 @ hex. ;
: NVIC-IPR9. ." NVIC-IPR9 (read-write) $" NVIC-IPR9 @ hex. ;
: NVIC-IPR10. ." NVIC-IPR10 (read-write) $" NVIC-IPR10 @ hex. ;
: NVIC-IPR11. ." NVIC-IPR11 (read-write) $" NVIC-IPR11 @ hex. ;
: NVIC-IPR12. ." NVIC-IPR12 (read-write) $" NVIC-IPR12 @ hex. ;
: NVIC-IPR13. ." NVIC-IPR13 (read-write) $" NVIC-IPR13 @ hex. ;
: NVIC-IPR14. ." NVIC-IPR14 (read-write) $" NVIC-IPR14 @ hex. ;
: NVIC-IPR15. ." NVIC-IPR15 (read-write) $" NVIC-IPR15 @ hex. ;
: NVIC-IPR16. ." NVIC-IPR16 (read-write) $" NVIC-IPR16 @ hex. ;
: NVIC-IPR17. ." NVIC-IPR17 (read-write) $" NVIC-IPR17 @ hex. ;
: NVIC.
 cr NVIC-ISER0.
 cr NVIC-ISER1.
 cr NVIC-ICER0.
 cr NVIC-ICER1.
 cr NVIC-ISPR0.
 cr NVIC-ISPR1.
 cr NVIC-ICPR0.
 cr NVIC-ICPR1.
 cr NVIC-IABR0.
 cr NVIC-IABR1.
 cr NVIC-IPR0.
 cr NVIC-IPR1.
 cr NVIC-IPR2.
 cr NVIC-IPR3.
 cr NVIC-IPR4.
 cr NVIC-IPR5.
 cr NVIC-IPR6.
 cr NVIC-IPR7.
 cr NVIC-IPR8.
 cr NVIC-IPR9.
 cr NVIC-IPR10.
 cr NVIC-IPR11.
 cr NVIC-IPR12.
 cr NVIC-IPR13.
 cr NVIC-IPR14.
 cr NVIC-IPR15.
 cr NVIC-IPR16.
 cr NVIC-IPR17.
;

$E000EF00 constant NVIC_STIR ( Nested vectored interrupt controller ) 
NVIC_STIR $0 + constant NVIC_STIR-STIR ( Software trigger interrupt register ) 
: NVIC_STIR-STIR. ." NVIC_STIR-STIR (read-write) $" NVIC_STIR-STIR @ hex. ;
: NVIC_STIR.
 cr NVIC_STIR-STIR.
;

$58002000 constant PKA ( Public key accelerator ) 
PKA $0 + constant PKA-CR ( control register ) 
PKA $4 + constant PKA-SR ( status register ) 
PKA $8 + constant PKA-CLRFR ( clear flag register ) 
: PKA-CR. ." PKA-CR (read-write) $" PKA-CR @ hex. ;
: PKA-SR. ." PKA-SR (read-only) $" PKA-SR @ hex. ;
: PKA-CLRFR. ." PKA-CLRFR (write-only) $" PKA-CLRFR @ hex. ;
: PKA.
 cr PKA-CR.
 cr PKA-SR.
 cr PKA-CLRFR.
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
: PWR-CR1. ." PWR-CR1 (read-write) $" PWR-CR1 @ hex. ;
: PWR-CR2. ." PWR-CR2 (read-write) $" PWR-CR2 @ hex. ;
: PWR-CR3. ." PWR-CR3 (read-write) $" PWR-CR3 @ hex. ;
: PWR-CR4. ." PWR-CR4 (read-write) $" PWR-CR4 @ hex. ;
: PWR-SR1. ." PWR-SR1 (read-only) $" PWR-SR1 @ hex. ;
: PWR-SR2. ." PWR-SR2 (read-only) $" PWR-SR2 @ hex. ;
: PWR-SCR. ." PWR-SCR (write-only) $" PWR-SCR @ hex. ;
: PWR-CR5. ." PWR-CR5 (read-write) $" PWR-CR5 @ hex. ;
: PWR-PUCRA. ." PWR-PUCRA (read-write) $" PWR-PUCRA @ hex. ;
: PWR-PDCRA. ." PWR-PDCRA (read-write) $" PWR-PDCRA @ hex. ;
: PWR-PUCRB. ." PWR-PUCRB (read-write) $" PWR-PUCRB @ hex. ;
: PWR-PDCRB. ." PWR-PDCRB (read-write) $" PWR-PDCRB @ hex. ;
: PWR-PUCRC. ." PWR-PUCRC (read-write) $" PWR-PUCRC @ hex. ;
: PWR-PDCRC. ." PWR-PDCRC (read-write) $" PWR-PDCRC @ hex. ;
: PWR-PUCRH. ." PWR-PUCRH (read-write) $" PWR-PUCRH @ hex. ;
: PWR-PDCRH. ." PWR-PDCRH (read-write) $" PWR-PDCRH @ hex. ;
: PWR-EXTSCR. ." PWR-EXTSCR () $" PWR-EXTSCR @ hex. ;
: PWR-SUBGHZSPICR. ." PWR-SUBGHZSPICR (read-write) $" PWR-SUBGHZSPICR @ hex. ;
: PWR.
 cr PWR-CR1.
 cr PWR-CR2.
 cr PWR-CR3.
 cr PWR-CR4.
 cr PWR-SR1.
 cr PWR-SR2.
 cr PWR-SCR.
 cr PWR-CR5.
 cr PWR-PUCRA.
 cr PWR-PDCRA.
 cr PWR-PUCRB.
 cr PWR-PDCRB.
 cr PWR-PUCRC.
 cr PWR-PDCRC.
 cr PWR-PUCRH.
 cr PWR-PDCRH.
 cr PWR-EXTSCR.
 cr PWR-SUBGHZSPICR.
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
: RCC-CR. ." RCC-CR () $" RCC-CR @ hex. ;
: RCC-ICSCR. ." RCC-ICSCR () $" RCC-ICSCR @ hex. ;
: RCC-CFGR. ." RCC-CFGR () $" RCC-CFGR @ hex. ;
: RCC-PLLCFGR. ." RCC-PLLCFGR (read-write) $" RCC-PLLCFGR @ hex. ;
: RCC-CIER. ." RCC-CIER (read-write) $" RCC-CIER @ hex. ;
: RCC-CIFR. ." RCC-CIFR (read-only) $" RCC-CIFR @ hex. ;
: RCC-CICR. ." RCC-CICR (write-only) $" RCC-CICR @ hex. ;
: RCC-AHB1RSTR. ." RCC-AHB1RSTR (read-write) $" RCC-AHB1RSTR @ hex. ;
: RCC-AHB2RSTR. ." RCC-AHB2RSTR (read-write) $" RCC-AHB2RSTR @ hex. ;
: RCC-AHB3RSTR. ." RCC-AHB3RSTR (read-write) $" RCC-AHB3RSTR @ hex. ;
: RCC-APB1RSTR1. ." RCC-APB1RSTR1 (read-write) $" RCC-APB1RSTR1 @ hex. ;
: RCC-APB1RSTR2. ." RCC-APB1RSTR2 (read-write) $" RCC-APB1RSTR2 @ hex. ;
: RCC-APB2RSTR. ." RCC-APB2RSTR (read-write) $" RCC-APB2RSTR @ hex. ;
: RCC-APB3RSTR. ." RCC-APB3RSTR (read-write) $" RCC-APB3RSTR @ hex. ;
: RCC-AHB1ENR. ." RCC-AHB1ENR (read-write) $" RCC-AHB1ENR @ hex. ;
: RCC-AHB2ENR. ." RCC-AHB2ENR (read-write) $" RCC-AHB2ENR @ hex. ;
: RCC-AHB3ENR. ." RCC-AHB3ENR (read-write) $" RCC-AHB3ENR @ hex. ;
: RCC-APB1ENR1. ." RCC-APB1ENR1 () $" RCC-APB1ENR1 @ hex. ;
: RCC-APB1ENR2. ." RCC-APB1ENR2 (read-write) $" RCC-APB1ENR2 @ hex. ;
: RCC-APB2ENR. ." RCC-APB2ENR (read-write) $" RCC-APB2ENR @ hex. ;
: RCC-APB3ENR. ." RCC-APB3ENR (read-write) $" RCC-APB3ENR @ hex. ;
: RCC-AHB1SMENR. ." RCC-AHB1SMENR (read-write) $" RCC-AHB1SMENR @ hex. ;
: RCC-AHB2SMENR. ." RCC-AHB2SMENR (read-write) $" RCC-AHB2SMENR @ hex. ;
: RCC-AHB3SMENR. ." RCC-AHB3SMENR (read-write) $" RCC-AHB3SMENR @ hex. ;
: RCC-APB1SMENR1. ." RCC-APB1SMENR1 (read-write) $" RCC-APB1SMENR1 @ hex. ;
: RCC-APB1SMENR2. ." RCC-APB1SMENR2 (read-write) $" RCC-APB1SMENR2 @ hex. ;
: RCC-APB2SMENR. ." RCC-APB2SMENR (read-write) $" RCC-APB2SMENR @ hex. ;
: RCC-APB3SMENR. ." RCC-APB3SMENR (read-write) $" RCC-APB3SMENR @ hex. ;
: RCC-CCIPR. ." RCC-CCIPR (read-write) $" RCC-CCIPR @ hex. ;
: RCC-BDCR. ." RCC-BDCR () $" RCC-BDCR @ hex. ;
: RCC-CSR. ." RCC-CSR () $" RCC-CSR @ hex. ;
: RCC-EXTCFGR. ." RCC-EXTCFGR () $" RCC-EXTCFGR @ hex. ;
: RCC.
 cr RCC-CR.
 cr RCC-ICSCR.
 cr RCC-CFGR.
 cr RCC-PLLCFGR.
 cr RCC-CIER.
 cr RCC-CIFR.
 cr RCC-CICR.
 cr RCC-AHB1RSTR.
 cr RCC-AHB2RSTR.
 cr RCC-AHB3RSTR.
 cr RCC-APB1RSTR1.
 cr RCC-APB1RSTR2.
 cr RCC-APB2RSTR.
 cr RCC-APB3RSTR.
 cr RCC-AHB1ENR.
 cr RCC-AHB2ENR.
 cr RCC-AHB3ENR.
 cr RCC-APB1ENR1.
 cr RCC-APB1ENR2.
 cr RCC-APB2ENR.
 cr RCC-APB3ENR.
 cr RCC-AHB1SMENR.
 cr RCC-AHB2SMENR.
 cr RCC-AHB3SMENR.
 cr RCC-APB1SMENR1.
 cr RCC-APB1SMENR2.
 cr RCC-APB2SMENR.
 cr RCC-APB3SMENR.
 cr RCC-CCIPR.
 cr RCC-BDCR.
 cr RCC-CSR.
 cr RCC-EXTCFGR.
;

$58001000 constant RNG ( True random number generator ) 
RNG $0 + constant RNG-CR ( control register ) 
RNG $4 + constant RNG-SR ( status register ) 
RNG $8 + constant RNG-DR ( data register ) 
RNG $10 + constant RNG-HTCR ( health test control register ) 
: RNG-CR. ." RNG-CR (read-write) $" RNG-CR @ hex. ;
: RNG-SR. ." RNG-SR () $" RNG-SR @ hex. ;
: RNG-DR. ." RNG-DR (read-only) $" RNG-DR @ hex. ;
: RNG-HTCR. ." RNG-HTCR (read-write) $" RNG-HTCR @ hex. ;
: RNG.
 cr RNG-CR.
 cr RNG-SR.
 cr RNG-DR.
 cr RNG-HTCR.
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
: RTC-TR. ." RTC-TR (read-write) $" RTC-TR @ hex. ;
: RTC-DR. ." RTC-DR (read-write) $" RTC-DR @ hex. ;
: RTC-SSR. ." RTC-SSR (read-only) $" RTC-SSR @ hex. ;
: RTC-ICSR. ." RTC-ICSR () $" RTC-ICSR @ hex. ;
: RTC-PRER. ." RTC-PRER (read-write) $" RTC-PRER @ hex. ;
: RTC-WUTR. ." RTC-WUTR (read-write) $" RTC-WUTR @ hex. ;
: RTC-CR. ." RTC-CR () $" RTC-CR @ hex. ;
: RTC-WPR. ." RTC-WPR (write-only) $" RTC-WPR @ hex. ;
: RTC-CALR. ." RTC-CALR (read-write) $" RTC-CALR @ hex. ;
: RTC-SHIFTR. ." RTC-SHIFTR (write-only) $" RTC-SHIFTR @ hex. ;
: RTC-TSTR. ." RTC-TSTR (read-only) $" RTC-TSTR @ hex. ;
: RTC-TSDR. ." RTC-TSDR (read-only) $" RTC-TSDR @ hex. ;
: RTC-TSSSR. ." RTC-TSSSR (read-only) $" RTC-TSSSR @ hex. ;
: RTC-ALRMAR. ." RTC-ALRMAR (read-write) $" RTC-ALRMAR @ hex. ;
: RTC-ALRMASSR. ." RTC-ALRMASSR (read-write) $" RTC-ALRMASSR @ hex. ;
: RTC-ALRMBR. ." RTC-ALRMBR (read-write) $" RTC-ALRMBR @ hex. ;
: RTC-ALRMBSSR. ." RTC-ALRMBSSR (read-write) $" RTC-ALRMBSSR @ hex. ;
: RTC-SR. ." RTC-SR (read-only) $" RTC-SR @ hex. ;
: RTC-MISR. ." RTC-MISR (read-only) $" RTC-MISR @ hex. ;
: RTC-SCR. ." RTC-SCR (write-only) $" RTC-SCR @ hex. ;
: RTC-ALRABINR. ." RTC-ALRABINR (read-write) $" RTC-ALRABINR @ hex. ;
: RTC-ALRBBINR. ." RTC-ALRBBINR (read-write) $" RTC-ALRBBINR @ hex. ;
: RTC.
 cr RTC-TR.
 cr RTC-DR.
 cr RTC-SSR.
 cr RTC-ICSR.
 cr RTC-PRER.
 cr RTC-WUTR.
 cr RTC-CR.
 cr RTC-WPR.
 cr RTC-CALR.
 cr RTC-SHIFTR.
 cr RTC-TSTR.
 cr RTC-TSDR.
 cr RTC-TSSSR.
 cr RTC-ALRMAR.
 cr RTC-ALRMASSR.
 cr RTC-ALRMBR.
 cr RTC-ALRMBSSR.
 cr RTC-SR.
 cr RTC-MISR.
 cr RTC-SCR.
 cr RTC-ALRABINR.
 cr RTC-ALRBBINR.
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
: SCB-CPUID. ." SCB-CPUID (read-only) $" SCB-CPUID @ hex. ;
: SCB-ICSR. ." SCB-ICSR (read-write) $" SCB-ICSR @ hex. ;
: SCB-VTOR. ." SCB-VTOR (read-write) $" SCB-VTOR @ hex. ;
: SCB-AIRCR. ." SCB-AIRCR (read-write) $" SCB-AIRCR @ hex. ;
: SCB-SCR. ." SCB-SCR (read-write) $" SCB-SCR @ hex. ;
: SCB-CCR. ." SCB-CCR (read-write) $" SCB-CCR @ hex. ;
: SCB-SHPR1. ." SCB-SHPR1 (read-write) $" SCB-SHPR1 @ hex. ;
: SCB-SHPR2. ." SCB-SHPR2 (read-write) $" SCB-SHPR2 @ hex. ;
: SCB-SHPR3. ." SCB-SHPR3 (read-write) $" SCB-SHPR3 @ hex. ;
: SCB-SHCSR. ." SCB-SHCSR (read-write) $" SCB-SHCSR @ hex. ;
: SCB-CFSR_UFSR_BFSR_MMFSR. ." SCB-CFSR_UFSR_BFSR_MMFSR (read-write) $" SCB-CFSR_UFSR_BFSR_MMFSR @ hex. ;
: SCB-HFSR. ." SCB-HFSR (read-write) $" SCB-HFSR @ hex. ;
: SCB-MMFAR. ." SCB-MMFAR (read-write) $" SCB-MMFAR @ hex. ;
: SCB-BFAR. ." SCB-BFAR (read-write) $" SCB-BFAR @ hex. ;
: SCB-AFSR. ." SCB-AFSR (read-write) $" SCB-AFSR @ hex. ;
: SCB.
 cr SCB-CPUID.
 cr SCB-ICSR.
 cr SCB-VTOR.
 cr SCB-AIRCR.
 cr SCB-SCR.
 cr SCB-CCR.
 cr SCB-SHPR1.
 cr SCB-SHPR2.
 cr SCB-SHPR3.
 cr SCB-SHCSR.
 cr SCB-CFSR_UFSR_BFSR_MMFSR.
 cr SCB-HFSR.
 cr SCB-MMFAR.
 cr SCB-BFAR.
 cr SCB-AFSR.
;

$E000E008 constant SCB_ACTRL ( System control block ACTLR ) 
SCB_ACTRL $0 + constant SCB_ACTRL-ACTRL ( Auxiliary control register ) 
: SCB_ACTRL-ACTRL. ." SCB_ACTRL-ACTRL (read-write) $" SCB_ACTRL-ACTRL @ hex. ;
: SCB_ACTRL.
 cr SCB_ACTRL-ACTRL.
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
: SPI1-CR1. ." SPI1-CR1 (read-write) $" SPI1-CR1 @ hex. ;
: SPI1-CR2. ." SPI1-CR2 (read-write) $" SPI1-CR2 @ hex. ;
: SPI1-SR. ." SPI1-SR () $" SPI1-SR @ hex. ;
: SPI1-DR. ." SPI1-DR (read-write) $" SPI1-DR @ hex. ;
: SPI1-CRCPR. ." SPI1-CRCPR (read-write) $" SPI1-CRCPR @ hex. ;
: SPI1-RXCRCR. ." SPI1-RXCRCR (read-only) $" SPI1-RXCRCR @ hex. ;
: SPI1-TXCRCR. ." SPI1-TXCRCR (read-only) $" SPI1-TXCRCR @ hex. ;
: SPI1-I2SCFGR. ." SPI1-I2SCFGR (read-write) $" SPI1-I2SCFGR @ hex. ;
: SPI1-I2SPR. ." SPI1-I2SPR (read-write) $" SPI1-I2SPR @ hex. ;
: SPI1.
 cr SPI1-CR1.
 cr SPI1-CR2.
 cr SPI1-SR.
 cr SPI1-DR.
 cr SPI1-CRCPR.
 cr SPI1-RXCRCR.
 cr SPI1-TXCRCR.
 cr SPI1-I2SCFGR.
 cr SPI1-I2SPR.
;

$40003800 constant SPI2 ( Serial peripheral interface/Inter-IC sound ) 
SPI2 $0 + constant SPI2-CR1 ( control register 1 ) 
SPI2 $4 + constant SPI2-CR2 ( control register 2 ) 
SPI2 $8 + constant SPI2-SR ( status register ) 
SPI2 $C + constant SPI2-DR ( data register ) 
SPI2 $10 + constant SPI2-CRCPR ( CRC polynomial register ) 
SPI2 $14 + constant SPI2-RXCRCR ( RX CRC register ) 
SPI2 $18 + constant SPI2-TXCRCR ( TX CRC register ) 
SPI2 $1C + constant SPI2-I2SCFGR ( configuration register ) 
SPI2 $20 + constant SPI2-I2SPR ( prescaler register ) 
: SPI2-CR1. ." SPI2-CR1 (read-write) $" SPI2-CR1 @ hex. ;
: SPI2-CR2. ." SPI2-CR2 (read-write) $" SPI2-CR2 @ hex. ;
: SPI2-SR. ." SPI2-SR () $" SPI2-SR @ hex. ;
: SPI2-DR. ." SPI2-DR (read-write) $" SPI2-DR @ hex. ;
: SPI2-CRCPR. ." SPI2-CRCPR (read-write) $" SPI2-CRCPR @ hex. ;
: SPI2-RXCRCR. ." SPI2-RXCRCR (read-only) $" SPI2-RXCRCR @ hex. ;
: SPI2-TXCRCR. ." SPI2-TXCRCR (read-only) $" SPI2-TXCRCR @ hex. ;
: SPI2-I2SCFGR. ." SPI2-I2SCFGR (read-write) $" SPI2-I2SCFGR @ hex. ;
: SPI2-I2SPR. ." SPI2-I2SPR (read-write) $" SPI2-I2SPR @ hex. ;
: SPI2.
 cr SPI2-CR1.
 cr SPI2-CR2.
 cr SPI2-SR.
 cr SPI2-DR.
 cr SPI2-CRCPR.
 cr SPI2-RXCRCR.
 cr SPI2-TXCRCR.
 cr SPI2-I2SCFGR.
 cr SPI2-I2SPR.
;

$58010000 constant SPI3 ( Serial peripheral interface/Inter-IC sound ) 
SPI3 $0 + constant SPI3-CR1 ( control register 1 ) 
SPI3 $4 + constant SPI3-CR2 ( control register 2 ) 
SPI3 $8 + constant SPI3-SR ( status register ) 
SPI3 $C + constant SPI3-DR ( data register ) 
SPI3 $10 + constant SPI3-CRCPR ( CRC polynomial register ) 
SPI3 $14 + constant SPI3-RXCRCR ( RX CRC register ) 
SPI3 $18 + constant SPI3-TXCRCR ( TX CRC register ) 
SPI3 $1C + constant SPI3-I2SCFGR ( configuration register ) 
SPI3 $20 + constant SPI3-I2SPR ( prescaler register ) 
: SPI3-CR1. ." SPI3-CR1 (read-write) $" SPI3-CR1 @ hex. ;
: SPI3-CR2. ." SPI3-CR2 (read-write) $" SPI3-CR2 @ hex. ;
: SPI3-SR. ." SPI3-SR () $" SPI3-SR @ hex. ;
: SPI3-DR. ." SPI3-DR (read-write) $" SPI3-DR @ hex. ;
: SPI3-CRCPR. ." SPI3-CRCPR (read-write) $" SPI3-CRCPR @ hex. ;
: SPI3-RXCRCR. ." SPI3-RXCRCR (read-only) $" SPI3-RXCRCR @ hex. ;
: SPI3-TXCRCR. ." SPI3-TXCRCR (read-only) $" SPI3-TXCRCR @ hex. ;
: SPI3-I2SCFGR. ." SPI3-I2SCFGR (read-write) $" SPI3-I2SCFGR @ hex. ;
: SPI3-I2SPR. ." SPI3-I2SPR (read-write) $" SPI3-I2SPR @ hex. ;
: SPI3.
 cr SPI3-CR1.
 cr SPI3-CR2.
 cr SPI3-SR.
 cr SPI3-DR.
 cr SPI3-CRCPR.
 cr SPI3-RXCRCR.
 cr SPI3-TXCRCR.
 cr SPI3-I2SCFGR.
 cr SPI3-I2SPR.
;

$E000E010 constant STK ( SysTick timer ) 
STK $0 + constant STK-CTRL ( SysTick control and status register ) 
STK $4 + constant STK-LOAD ( SysTick reload value register ) 
STK $8 + constant STK-VAL ( SysTick current value register ) 
STK $C + constant STK-CALIB ( SysTick calibration value register ) 
: STK-CTRL. ." STK-CTRL (read-write) $" STK-CTRL @ hex. ;
: STK-LOAD. ." STK-LOAD (read-write) $" STK-LOAD @ hex. ;
: STK-VAL. ." STK-VAL (read-write) $" STK-VAL @ hex. ;
: STK-CALIB. ." STK-CALIB (read-write) $" STK-CALIB @ hex. ;
: STK.
 cr STK-CTRL.
 cr STK-LOAD.
 cr STK-VAL.
 cr STK-CALIB.
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
: SYSCFG-MEMRMP. ." SYSCFG-MEMRMP (read-write) $" SYSCFG-MEMRMP @ hex. ;
: SYSCFG-CFGR1. ." SYSCFG-CFGR1 (read-write) $" SYSCFG-CFGR1 @ hex. ;
: SYSCFG-EXTICR1. ." SYSCFG-EXTICR1 (read-write) $" SYSCFG-EXTICR1 @ hex. ;
: SYSCFG-EXTICR2. ." SYSCFG-EXTICR2 (read-write) $" SYSCFG-EXTICR2 @ hex. ;
: SYSCFG-EXTICR3. ." SYSCFG-EXTICR3 (read-write) $" SYSCFG-EXTICR3 @ hex. ;
: SYSCFG-EXTICR4. ." SYSCFG-EXTICR4 (read-write) $" SYSCFG-EXTICR4 @ hex. ;
: SYSCFG-SCSR. ." SYSCFG-SCSR () $" SYSCFG-SCSR @ hex. ;
: SYSCFG-CFGR2. ." SYSCFG-CFGR2 () $" SYSCFG-CFGR2 @ hex. ;
: SYSCFG-SWPR. ." SYSCFG-SWPR (read-write) $" SYSCFG-SWPR @ hex. ;
: SYSCFG-SKR. ." SYSCFG-SKR (write-only) $" SYSCFG-SKR @ hex. ;
: SYSCFG-RFDCR. ." SYSCFG-RFDCR (read-write) $" SYSCFG-RFDCR @ hex. ;
: SYSCFG.
 cr SYSCFG-MEMRMP.
 cr SYSCFG-CFGR1.
 cr SYSCFG-EXTICR1.
 cr SYSCFG-EXTICR2.
 cr SYSCFG-EXTICR3.
 cr SYSCFG-EXTICR4.
 cr SYSCFG-SCSR.
 cr SYSCFG-CFGR2.
 cr SYSCFG-SWPR.
 cr SYSCFG-SKR.
 cr SYSCFG-RFDCR.
;

$40010100 constant SYSCFG_continue ( System configuration controller ) 
SYSCFG_continue $0 + constant SYSCFG_continue-IMR1 ( IMR1 ) 
SYSCFG_continue $4 + constant SYSCFG_continue-IMR2 ( IMR2 ) 
SYSCFG_continue $8 + constant SYSCFG_continue-C2IMR1 ( C2IMR1 ) 
SYSCFG_continue $C + constant SYSCFG_continue-C2IMR2 ( C2IMR2 ) 
: SYSCFG_continue-IMR1. ." SYSCFG_continue-IMR1 (read-write) $" SYSCFG_continue-IMR1 @ hex. ;
: SYSCFG_continue-IMR2. ." SYSCFG_continue-IMR2 (read-write) $" SYSCFG_continue-IMR2 @ hex. ;
: SYSCFG_continue-C2IMR1. ." SYSCFG_continue-C2IMR1 (read-write) $" SYSCFG_continue-C2IMR1 @ hex. ;
: SYSCFG_continue-C2IMR2. ." SYSCFG_continue-C2IMR2 (read-write) $" SYSCFG_continue-C2IMR2 @ hex. ;
: SYSCFG_continue.
 cr SYSCFG_continue-IMR1.
 cr SYSCFG_continue-IMR2.
 cr SYSCFG_continue-C2IMR1.
 cr SYSCFG_continue-C2IMR2.
;

$4000B000 constant TAMP ( Tamper and backup registers ) 
TAMP $0 + constant TAMP-CR1 ( control register 1 ) 
TAMP $4 + constant TAMP-CR2 ( control register 2 ) 
TAMP $8 + constant TAMP-CR3 ( TAMP control register 3 ) 
TAMP $C + constant TAMP-FLTCR ( TAMP filter control register ) 
TAMP $2C + constant TAMP-IER ( TAMP interrupt enable register ) 
TAMP $30 + constant TAMP-SR ( TAMP status register ) 
TAMP $34 + constant TAMP-MISR ( TAMP masked interrupt status register ) 
TAMP $3C + constant TAMP-SCR ( TAMP status clear register ) 
TAMP $40 + constant TAMP-COUNTR ( monotonic counter register ) 
TAMP $100 + constant TAMP-BKP0R ( TAMP backup register ) 
TAMP $104 + constant TAMP-BKP1R ( TAMP backup register ) 
TAMP $108 + constant TAMP-BKP2R ( TAMP backup register ) 
TAMP $10C + constant TAMP-BKP3R ( TAMP backup register ) 
TAMP $110 + constant TAMP-BKP4R ( TAMP backup register ) 
TAMP $114 + constant TAMP-BKP5R ( TAMP backup register ) 
TAMP $118 + constant TAMP-BKP6R ( TAMP backup register ) 
TAMP $11C + constant TAMP-BKP7R ( TAMP backup register ) 
TAMP $120 + constant TAMP-BKP8R ( TAMP backup register ) 
TAMP $124 + constant TAMP-BKP9R ( TAMP backup register ) 
TAMP $140 + constant TAMP-BKP10R ( TAMP backup register ) 
TAMP $144 + constant TAMP-BKP11R ( TAMP backup register ) 
TAMP $148 + constant TAMP-BKP12R ( TAMP backup register ) 
TAMP $14C + constant TAMP-BKP13R ( TAMP backup register ) 
TAMP $150 + constant TAMP-BKP14R ( TAMP backup register ) 
TAMP $154 + constant TAMP-BKP15R ( TAMP backup register ) 
TAMP $158 + constant TAMP-BKP16R ( TAMP backup register ) 
TAMP $15C + constant TAMP-BKP17R ( TAMP backup register ) 
TAMP $160 + constant TAMP-BKP18R ( TAMP backup register ) 
TAMP $164 + constant TAMP-BKP19R ( TAMP backup register ) 
: TAMP-CR1. ." TAMP-CR1 (read-write) $" TAMP-CR1 @ hex. ;
: TAMP-CR2. ." TAMP-CR2 (read-write) $" TAMP-CR2 @ hex. ;
: TAMP-CR3. ." TAMP-CR3 (read-write) $" TAMP-CR3 @ hex. ;
: TAMP-FLTCR. ." TAMP-FLTCR (read-write) $" TAMP-FLTCR @ hex. ;
: TAMP-IER. ." TAMP-IER (read-write) $" TAMP-IER @ hex. ;
: TAMP-SR. ." TAMP-SR (read-only) $" TAMP-SR @ hex. ;
: TAMP-MISR. ." TAMP-MISR (read-only) $" TAMP-MISR @ hex. ;
: TAMP-SCR. ." TAMP-SCR (write-only) $" TAMP-SCR @ hex. ;
: TAMP-COUNTR. ." TAMP-COUNTR (read-only) $" TAMP-COUNTR @ hex. ;
: TAMP-BKP0R. ." TAMP-BKP0R (read-write) $" TAMP-BKP0R @ hex. ;
: TAMP-BKP1R. ." TAMP-BKP1R (read-write) $" TAMP-BKP1R @ hex. ;
: TAMP-BKP2R. ." TAMP-BKP2R (read-write) $" TAMP-BKP2R @ hex. ;
: TAMP-BKP3R. ." TAMP-BKP3R (read-write) $" TAMP-BKP3R @ hex. ;
: TAMP-BKP4R. ." TAMP-BKP4R (read-write) $" TAMP-BKP4R @ hex. ;
: TAMP-BKP5R. ." TAMP-BKP5R (read-write) $" TAMP-BKP5R @ hex. ;
: TAMP-BKP6R. ." TAMP-BKP6R (read-write) $" TAMP-BKP6R @ hex. ;
: TAMP-BKP7R. ." TAMP-BKP7R (read-write) $" TAMP-BKP7R @ hex. ;
: TAMP-BKP8R. ." TAMP-BKP8R (read-write) $" TAMP-BKP8R @ hex. ;
: TAMP-BKP9R. ." TAMP-BKP9R (read-write) $" TAMP-BKP9R @ hex. ;
: TAMP-BKP10R. ." TAMP-BKP10R (read-write) $" TAMP-BKP10R @ hex. ;
: TAMP-BKP11R. ." TAMP-BKP11R (read-write) $" TAMP-BKP11R @ hex. ;
: TAMP-BKP12R. ." TAMP-BKP12R (read-write) $" TAMP-BKP12R @ hex. ;
: TAMP-BKP13R. ." TAMP-BKP13R (read-write) $" TAMP-BKP13R @ hex. ;
: TAMP-BKP14R. ." TAMP-BKP14R (read-write) $" TAMP-BKP14R @ hex. ;
: TAMP-BKP15R. ." TAMP-BKP15R (read-write) $" TAMP-BKP15R @ hex. ;
: TAMP-BKP16R. ." TAMP-BKP16R (read-write) $" TAMP-BKP16R @ hex. ;
: TAMP-BKP17R. ." TAMP-BKP17R (read-write) $" TAMP-BKP17R @ hex. ;
: TAMP-BKP18R. ." TAMP-BKP18R (read-write) $" TAMP-BKP18R @ hex. ;
: TAMP-BKP19R. ." TAMP-BKP19R (read-write) $" TAMP-BKP19R @ hex. ;
: TAMP.
 cr TAMP-CR1.
 cr TAMP-CR2.
 cr TAMP-CR3.
 cr TAMP-FLTCR.
 cr TAMP-IER.
 cr TAMP-SR.
 cr TAMP-MISR.
 cr TAMP-SCR.
 cr TAMP-COUNTR.
 cr TAMP-BKP0R.
 cr TAMP-BKP1R.
 cr TAMP-BKP2R.
 cr TAMP-BKP3R.
 cr TAMP-BKP4R.
 cr TAMP-BKP5R.
 cr TAMP-BKP6R.
 cr TAMP-BKP7R.
 cr TAMP-BKP8R.
 cr TAMP-BKP9R.
 cr TAMP-BKP10R.
 cr TAMP-BKP11R.
 cr TAMP-BKP12R.
 cr TAMP-BKP13R.
 cr TAMP-BKP14R.
 cr TAMP-BKP15R.
 cr TAMP-BKP16R.
 cr TAMP-BKP17R.
 cr TAMP-BKP18R.
 cr TAMP-BKP19R.
;

$40012C00 constant TIM1 ( Advanced-control timers ) 
TIM1 $0 + constant TIM1-CR1 ( control register 1 ) 
TIM1 $4 + constant TIM1-CR2 ( control register 2 ) 
TIM1 $8 + constant TIM1-SMCR ( slave mode control register ) 
TIM1 $C + constant TIM1-DIER ( DMA/interrupt enable register ) 
TIM1 $10 + constant TIM1-SR ( status register ) 
TIM1 $14 + constant TIM1-EGR ( event generation register ) 
TIM1 $18 + constant TIM1-CCMR1_Output ( capture/compare mode register 1 output mode ) 
TIM1 $18 + constant TIM1-CCMR1_Input ( capture/compare mode register 1 input mode ) 
TIM1 $1C + constant TIM1-CCMR2_Output ( capture/compare mode register 2 output mode ) 
TIM1 $1C + constant TIM1-CCMR2_Input ( capture/compare mode register 2 input mode ) 
TIM1 $20 + constant TIM1-CCER ( capture/compare enable register ) 
TIM1 $24 + constant TIM1-CNT ( counter ) 
TIM1 $28 + constant TIM1-PSC ( prescaler ) 
TIM1 $2C + constant TIM1-ARR ( auto-reload register ) 
TIM1 $30 + constant TIM1-RCR ( repetition counter register ) 
TIM1 $34 + constant TIM1-CCR1 ( capture/compare register 1 ) 
TIM1 $38 + constant TIM1-CCR2 ( capture/compare register 2 ) 
TIM1 $3C + constant TIM1-CCR3 ( capture/compare register 3 ) 
TIM1 $40 + constant TIM1-CCR4 ( capture/compare register 4 ) 
TIM1 $44 + constant TIM1-BDTR ( break and dead-time register ) 
TIM1 $48 + constant TIM1-DCR ( DMA control register ) 
TIM1 $4C + constant TIM1-DMAR ( DMA address for full transfer ) 
TIM1 $50 + constant TIM1-OR1 ( option register 1 ) 
TIM1 $54 + constant TIM1-CCMR3OutputComparemode ( capture/compare mode register 3 ) 
TIM1 $58 + constant TIM1-CCR5 ( capture/compare register 5 ) 
TIM1 $5C + constant TIM1-CCR6 ( capture/compare register 6 ) 
TIM1 $60 + constant TIM1-AF1 ( alternate function option register 1 ) 
TIM1 $64 + constant TIM1-AF2 ( Alternate function register 2 ) 
TIM1 $68 + constant TIM1-TISEL ( timer input selection register ) 
: TIM1-CR1. ." TIM1-CR1 (read-write) $" TIM1-CR1 @ hex. ;
: TIM1-CR2. ." TIM1-CR2 (read-write) $" TIM1-CR2 @ hex. ;
: TIM1-SMCR. ." TIM1-SMCR (read-write) $" TIM1-SMCR @ hex. ;
: TIM1-DIER. ." TIM1-DIER (read-write) $" TIM1-DIER @ hex. ;
: TIM1-SR. ." TIM1-SR (read-write) $" TIM1-SR @ hex. ;
: TIM1-EGR. ." TIM1-EGR (write-only) $" TIM1-EGR @ hex. ;
: TIM1-CCMR1_Output. ." TIM1-CCMR1_Output (read-write) $" TIM1-CCMR1_Output @ hex. ;
: TIM1-CCMR1_Input. ." TIM1-CCMR1_Input (read-write) $" TIM1-CCMR1_Input @ hex. ;
: TIM1-CCMR2_Output. ." TIM1-CCMR2_Output (read-write) $" TIM1-CCMR2_Output @ hex. ;
: TIM1-CCMR2_Input. ." TIM1-CCMR2_Input (read-write) $" TIM1-CCMR2_Input @ hex. ;
: TIM1-CCER. ." TIM1-CCER (read-write) $" TIM1-CCER @ hex. ;
: TIM1-CNT. ." TIM1-CNT () $" TIM1-CNT @ hex. ;
: TIM1-PSC. ." TIM1-PSC (read-write) $" TIM1-PSC @ hex. ;
: TIM1-ARR. ." TIM1-ARR (read-write) $" TIM1-ARR @ hex. ;
: TIM1-RCR. ." TIM1-RCR (read-write) $" TIM1-RCR @ hex. ;
: TIM1-CCR1. ." TIM1-CCR1 (read-write) $" TIM1-CCR1 @ hex. ;
: TIM1-CCR2. ." TIM1-CCR2 (read-write) $" TIM1-CCR2 @ hex. ;
: TIM1-CCR3. ." TIM1-CCR3 (read-write) $" TIM1-CCR3 @ hex. ;
: TIM1-CCR4. ." TIM1-CCR4 (read-write) $" TIM1-CCR4 @ hex. ;
: TIM1-BDTR. ." TIM1-BDTR (read-write) $" TIM1-BDTR @ hex. ;
: TIM1-DCR. ." TIM1-DCR (read-write) $" TIM1-DCR @ hex. ;
: TIM1-DMAR. ." TIM1-DMAR (read-write) $" TIM1-DMAR @ hex. ;
: TIM1-OR1. ." TIM1-OR1 (read-write) $" TIM1-OR1 @ hex. ;
: TIM1-CCMR3OutputComparemode. ." TIM1-CCMR3OutputComparemode (read-write) $" TIM1-CCMR3OutputComparemode @ hex. ;
: TIM1-CCR5. ." TIM1-CCR5 (read-write) $" TIM1-CCR5 @ hex. ;
: TIM1-CCR6. ." TIM1-CCR6 (read-write) $" TIM1-CCR6 @ hex. ;
: TIM1-AF1. ." TIM1-AF1 (read-write) $" TIM1-AF1 @ hex. ;
: TIM1-AF2. ." TIM1-AF2 (read-write) $" TIM1-AF2 @ hex. ;
: TIM1-TISEL. ." TIM1-TISEL (read-write) $" TIM1-TISEL @ hex. ;
: TIM1.
 cr TIM1-CR1.
 cr TIM1-CR2.
 cr TIM1-SMCR.
 cr TIM1-DIER.
 cr TIM1-SR.
 cr TIM1-EGR.
 cr TIM1-CCMR1_Output.
 cr TIM1-CCMR1_Input.
 cr TIM1-CCMR2_Output.
 cr TIM1-CCMR2_Input.
 cr TIM1-CCER.
 cr TIM1-CNT.
 cr TIM1-PSC.
 cr TIM1-ARR.
 cr TIM1-RCR.
 cr TIM1-CCR1.
 cr TIM1-CCR2.
 cr TIM1-CCR3.
 cr TIM1-CCR4.
 cr TIM1-BDTR.
 cr TIM1-DCR.
 cr TIM1-DMAR.
 cr TIM1-OR1.
 cr TIM1-CCMR3OutputComparemode.
 cr TIM1-CCR5.
 cr TIM1-CCR6.
 cr TIM1-AF1.
 cr TIM1-AF2.
 cr TIM1-TISEL.
;

$40000000 constant TIM2 ( General-purpose-timers ) 
TIM2 $0 + constant TIM2-CR1 ( control register 1 ) 
TIM2 $4 + constant TIM2-CR2 ( control register 2 ) 
TIM2 $8 + constant TIM2-SMCR ( slave mode control register ) 
TIM2 $C + constant TIM2-DIER ( DMA/Interrupt enable register ) 
TIM2 $10 + constant TIM2-SR ( status register ) 
TIM2 $14 + constant TIM2-EGR ( event generation register ) 
TIM2 $18 + constant TIM2-CCMR1_Output ( capture/compare mode register 1 output mode ) 
TIM2 $18 + constant TIM2-CCMR1_Input ( capture/compare mode register 1 input mode ) 
TIM2 $1C + constant TIM2-CCMR2_Output ( capture/compare mode register 2 output mode ) 
TIM2 $1C + constant TIM2-CCMR2_Input ( capture/compare mode register 2 input mode ) 
TIM2 $20 + constant TIM2-CCER ( capture/compare enable register ) 
TIM2 $24 + constant TIM2-CNT ( counter ) 
TIM2 $28 + constant TIM2-PSC ( prescaler ) 
TIM2 $2C + constant TIM2-ARR ( auto-reload register ) 
TIM2 $34 + constant TIM2-CCR1 ( capture/compare register 1 ) 
TIM2 $38 + constant TIM2-CCR2 ( capture/compare register 2 ) 
TIM2 $3C + constant TIM2-CCR3 ( capture/compare register 3 ) 
TIM2 $40 + constant TIM2-CCR4 ( capture/compare register 4 ) 
TIM2 $48 + constant TIM2-DCR ( DMA control register ) 
TIM2 $4C + constant TIM2-DMAR ( DMA address for full transfer ) 
TIM2 $50 + constant TIM2-TIM2_OR1 ( TIM2 option register ) 
TIM2 $60 + constant TIM2-TIM2_AF1 ( TIM2 alternate function option register 1 ) 
TIM2 $68 + constant TIM2-TIM2_TISEL ( TIM2 timer input selection register ) 
: TIM2-CR1. ." TIM2-CR1 (read-write) $" TIM2-CR1 @ hex. ;
: TIM2-CR2. ." TIM2-CR2 (read-write) $" TIM2-CR2 @ hex. ;
: TIM2-SMCR. ." TIM2-SMCR (read-write) $" TIM2-SMCR @ hex. ;
: TIM2-DIER. ." TIM2-DIER (read-write) $" TIM2-DIER @ hex. ;
: TIM2-SR. ." TIM2-SR (read-write) $" TIM2-SR @ hex. ;
: TIM2-EGR. ." TIM2-EGR (write-only) $" TIM2-EGR @ hex. ;
: TIM2-CCMR1_Output. ." TIM2-CCMR1_Output (read-write) $" TIM2-CCMR1_Output @ hex. ;
: TIM2-CCMR1_Input. ." TIM2-CCMR1_Input (read-write) $" TIM2-CCMR1_Input @ hex. ;
: TIM2-CCMR2_Output. ." TIM2-CCMR2_Output (read-write) $" TIM2-CCMR2_Output @ hex. ;
: TIM2-CCMR2_Input. ." TIM2-CCMR2_Input (read-write) $" TIM2-CCMR2_Input @ hex. ;
: TIM2-CCER. ." TIM2-CCER (read-write) $" TIM2-CCER @ hex. ;
: TIM2-CNT. ." TIM2-CNT (read-write) $" TIM2-CNT @ hex. ;
: TIM2-PSC. ." TIM2-PSC (read-write) $" TIM2-PSC @ hex. ;
: TIM2-ARR. ." TIM2-ARR (read-write) $" TIM2-ARR @ hex. ;
: TIM2-CCR1. ." TIM2-CCR1 (read-write) $" TIM2-CCR1 @ hex. ;
: TIM2-CCR2. ." TIM2-CCR2 (read-write) $" TIM2-CCR2 @ hex. ;
: TIM2-CCR3. ." TIM2-CCR3 (read-write) $" TIM2-CCR3 @ hex. ;
: TIM2-CCR4. ." TIM2-CCR4 (read-write) $" TIM2-CCR4 @ hex. ;
: TIM2-DCR. ." TIM2-DCR (read-write) $" TIM2-DCR @ hex. ;
: TIM2-DMAR. ." TIM2-DMAR (read-write) $" TIM2-DMAR @ hex. ;
: TIM2-TIM2_OR1. ." TIM2-TIM2_OR1 (read-write) $" TIM2-TIM2_OR1 @ hex. ;
: TIM2-TIM2_AF1. ." TIM2-TIM2_AF1 (read-write) $" TIM2-TIM2_AF1 @ hex. ;
: TIM2-TIM2_TISEL. ." TIM2-TIM2_TISEL (read-write) $" TIM2-TIM2_TISEL @ hex. ;
: TIM2.
 cr TIM2-CR1.
 cr TIM2-CR2.
 cr TIM2-SMCR.
 cr TIM2-DIER.
 cr TIM2-SR.
 cr TIM2-EGR.
 cr TIM2-CCMR1_Output.
 cr TIM2-CCMR1_Input.
 cr TIM2-CCMR2_Output.
 cr TIM2-CCMR2_Input.
 cr TIM2-CCER.
 cr TIM2-CNT.
 cr TIM2-PSC.
 cr TIM2-ARR.
 cr TIM2-CCR1.
 cr TIM2-CCR2.
 cr TIM2-CCR3.
 cr TIM2-CCR4.
 cr TIM2-DCR.
 cr TIM2-DMAR.
 cr TIM2-TIM2_OR1.
 cr TIM2-TIM2_AF1.
 cr TIM2-TIM2_TISEL.
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
: TIM16-CR1. ." TIM16-CR1 (read-write) $" TIM16-CR1 @ hex. ;
: TIM16-CR2. ." TIM16-CR2 (read-write) $" TIM16-CR2 @ hex. ;
: TIM16-DIER. ." TIM16-DIER (read-write) $" TIM16-DIER @ hex. ;
: TIM16-SR. ." TIM16-SR (read-write) $" TIM16-SR @ hex. ;
: TIM16-EGR. ." TIM16-EGR (write-only) $" TIM16-EGR @ hex. ;
: TIM16-CCMR1_Output. ." TIM16-CCMR1_Output (read-write) $" TIM16-CCMR1_Output @ hex. ;
: TIM16-CCMR1_Input. ." TIM16-CCMR1_Input (read-write) $" TIM16-CCMR1_Input @ hex. ;
: TIM16-CCER. ." TIM16-CCER (read-write) $" TIM16-CCER @ hex. ;
: TIM16-CNT. ." TIM16-CNT () $" TIM16-CNT @ hex. ;
: TIM16-PSC. ." TIM16-PSC (read-write) $" TIM16-PSC @ hex. ;
: TIM16-ARR. ." TIM16-ARR (read-write) $" TIM16-ARR @ hex. ;
: TIM16-RCR. ." TIM16-RCR (read-write) $" TIM16-RCR @ hex. ;
: TIM16-CCR1. ." TIM16-CCR1 (read-write) $" TIM16-CCR1 @ hex. ;
: TIM16-BDTR. ." TIM16-BDTR (read-write) $" TIM16-BDTR @ hex. ;
: TIM16-DCR. ." TIM16-DCR (read-write) $" TIM16-DCR @ hex. ;
: TIM16-DMAR. ." TIM16-DMAR (read-write) $" TIM16-DMAR @ hex. ;
: TIM16-TIM16_OR1. ." TIM16-TIM16_OR1 (read-write) $" TIM16-TIM16_OR1 @ hex. ;
: TIM16-TIM16_AF1. ." TIM16-TIM16_AF1 (read-write) $" TIM16-TIM16_AF1 @ hex. ;
: TIM16-TIM16_TISEL. ." TIM16-TIM16_TISEL (read-write) $" TIM16-TIM16_TISEL @ hex. ;
: TIM16.
 cr TIM16-CR1.
 cr TIM16-CR2.
 cr TIM16-DIER.
 cr TIM16-SR.
 cr TIM16-EGR.
 cr TIM16-CCMR1_Output.
 cr TIM16-CCMR1_Input.
 cr TIM16-CCER.
 cr TIM16-CNT.
 cr TIM16-PSC.
 cr TIM16-ARR.
 cr TIM16-RCR.
 cr TIM16-CCR1.
 cr TIM16-BDTR.
 cr TIM16-DCR.
 cr TIM16-DMAR.
 cr TIM16-TIM16_OR1.
 cr TIM16-TIM16_AF1.
 cr TIM16-TIM16_TISEL.
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
: TIM17-CR1. ." TIM17-CR1 (read-write) $" TIM17-CR1 @ hex. ;
: TIM17-CR2. ." TIM17-CR2 (read-write) $" TIM17-CR2 @ hex. ;
: TIM17-DIER. ." TIM17-DIER (read-write) $" TIM17-DIER @ hex. ;
: TIM17-SR. ." TIM17-SR (read-write) $" TIM17-SR @ hex. ;
: TIM17-EGR. ." TIM17-EGR (write-only) $" TIM17-EGR @ hex. ;
: TIM17-CCMR1_Output. ." TIM17-CCMR1_Output (read-write) $" TIM17-CCMR1_Output @ hex. ;
: TIM17-CCMR1_Input. ." TIM17-CCMR1_Input (read-write) $" TIM17-CCMR1_Input @ hex. ;
: TIM17-CCER. ." TIM17-CCER (read-write) $" TIM17-CCER @ hex. ;
: TIM17-CNT. ." TIM17-CNT () $" TIM17-CNT @ hex. ;
: TIM17-PSC. ." TIM17-PSC (read-write) $" TIM17-PSC @ hex. ;
: TIM17-ARR. ." TIM17-ARR (read-write) $" TIM17-ARR @ hex. ;
: TIM17-RCR. ." TIM17-RCR (read-write) $" TIM17-RCR @ hex. ;
: TIM17-CCR1. ." TIM17-CCR1 (read-write) $" TIM17-CCR1 @ hex. ;
: TIM17-BDTR. ." TIM17-BDTR (read-write) $" TIM17-BDTR @ hex. ;
: TIM17-DCR. ." TIM17-DCR (read-write) $" TIM17-DCR @ hex. ;
: TIM17-DMAR. ." TIM17-DMAR (read-write) $" TIM17-DMAR @ hex. ;
: TIM17-TIM17_OR1. ." TIM17-TIM17_OR1 (read-write) $" TIM17-TIM17_OR1 @ hex. ;
: TIM17-TIM17_AF1. ." TIM17-TIM17_AF1 (read-write) $" TIM17-TIM17_AF1 @ hex. ;
: TIM17-TIM17_TISEL. ." TIM17-TIM17_TISEL (read-write) $" TIM17-TIM17_TISEL @ hex. ;
: TIM17.
 cr TIM17-CR1.
 cr TIM17-CR2.
 cr TIM17-DIER.
 cr TIM17-SR.
 cr TIM17-EGR.
 cr TIM17-CCMR1_Output.
 cr TIM17-CCMR1_Input.
 cr TIM17-CCER.
 cr TIM17-CNT.
 cr TIM17-PSC.
 cr TIM17-ARR.
 cr TIM17-RCR.
 cr TIM17-CCR1.
 cr TIM17-BDTR.
 cr TIM17-DCR.
 cr TIM17-DMAR.
 cr TIM17-TIM17_OR1.
 cr TIM17-TIM17_AF1.
 cr TIM17-TIM17_TISEL.
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
: USART1-CR1. ." USART1-CR1 (read-write) $" USART1-CR1 @ hex. ;
: USART1-CR2. ." USART1-CR2 (read-write) $" USART1-CR2 @ hex. ;
: USART1-CR3. ." USART1-CR3 (read-write) $" USART1-CR3 @ hex. ;
: USART1-BRR. ." USART1-BRR (read-write) $" USART1-BRR @ hex. ;
: USART1-GTPR. ." USART1-GTPR (read-write) $" USART1-GTPR @ hex. ;
: USART1-RTOR. ." USART1-RTOR (read-write) $" USART1-RTOR @ hex. ;
: USART1-RQR. ." USART1-RQR (read-write) $" USART1-RQR @ hex. ;
: USART1-ISR. ." USART1-ISR (read-only) $" USART1-ISR @ hex. ;
: USART1-ICR. ." USART1-ICR (write-only) $" USART1-ICR @ hex. ;
: USART1-RDR. ." USART1-RDR (read-only) $" USART1-RDR @ hex. ;
: USART1-TDR. ." USART1-TDR (read-write) $" USART1-TDR @ hex. ;
: USART1-PRESC. ." USART1-PRESC (read-write) $" USART1-PRESC @ hex. ;
: USART1.
 cr USART1-CR1.
 cr USART1-CR2.
 cr USART1-CR3.
 cr USART1-BRR.
 cr USART1-GTPR.
 cr USART1-RTOR.
 cr USART1-RQR.
 cr USART1-ISR.
 cr USART1-ICR.
 cr USART1-RDR.
 cr USART1-TDR.
 cr USART1-PRESC.
;

$40004400 constant USART2 ( Universal synchronous asynchronous receiver transmitter ) 
USART2 $0 + constant USART2-CR1 ( control register 1 ) 
USART2 $4 + constant USART2-CR2 ( control register 2 ) 
USART2 $8 + constant USART2-CR3 ( control register 3 ) 
USART2 $C + constant USART2-BRR ( baud rate register ) 
USART2 $10 + constant USART2-GTPR ( guard time and prescaler register ) 
USART2 $14 + constant USART2-RTOR ( receiver timeout register ) 
USART2 $18 + constant USART2-RQR ( request register ) 
USART2 $1C + constant USART2-ISR ( interrupt and status register ) 
USART2 $20 + constant USART2-ICR ( interrupt flag clear register ) 
USART2 $24 + constant USART2-RDR ( receive data register ) 
USART2 $28 + constant USART2-TDR ( transmit data register ) 
USART2 $2C + constant USART2-PRESC ( prescaler register ) 
: USART2-CR1. ." USART2-CR1 (read-write) $" USART2-CR1 @ hex. ;
: USART2-CR2. ." USART2-CR2 (read-write) $" USART2-CR2 @ hex. ;
: USART2-CR3. ." USART2-CR3 (read-write) $" USART2-CR3 @ hex. ;
: USART2-BRR. ." USART2-BRR (read-write) $" USART2-BRR @ hex. ;
: USART2-GTPR. ." USART2-GTPR (read-write) $" USART2-GTPR @ hex. ;
: USART2-RTOR. ." USART2-RTOR (read-write) $" USART2-RTOR @ hex. ;
: USART2-RQR. ." USART2-RQR (read-write) $" USART2-RQR @ hex. ;
: USART2-ISR. ." USART2-ISR (read-only) $" USART2-ISR @ hex. ;
: USART2-ICR. ." USART2-ICR (write-only) $" USART2-ICR @ hex. ;
: USART2-RDR. ." USART2-RDR (read-only) $" USART2-RDR @ hex. ;
: USART2-TDR. ." USART2-TDR (read-write) $" USART2-TDR @ hex. ;
: USART2-PRESC. ." USART2-PRESC (read-write) $" USART2-PRESC @ hex. ;
: USART2.
 cr USART2-CR1.
 cr USART2-CR2.
 cr USART2-CR3.
 cr USART2-BRR.
 cr USART2-GTPR.
 cr USART2-RTOR.
 cr USART2-RQR.
 cr USART2-ISR.
 cr USART2-ICR.
 cr USART2-RDR.
 cr USART2-TDR.
 cr USART2-PRESC.
;

$40010030 constant VREFBUF ( Voltage reference buffer ) 
VREFBUF $0 + constant VREFBUF-CSR ( control and status register ) 
VREFBUF $4 + constant VREFBUF-CCR ( calibration control register ) 
: VREFBUF-CSR. ." VREFBUF-CSR () $" VREFBUF-CSR @ hex. ;
: VREFBUF-CCR. ." VREFBUF-CCR (read-write) $" VREFBUF-CCR @ hex. ;
: VREFBUF.
 cr VREFBUF-CSR.
 cr VREFBUF-CCR.
;

$40002C00 constant WWDG ( System window watchdog ) 
WWDG $0 + constant WWDG-CR ( Control register ) 
WWDG $4 + constant WWDG-CFR ( Configuration register ) 
WWDG $8 + constant WWDG-SR ( Status register ) 
: WWDG-CR. ." WWDG-CR (read-write) $" WWDG-CR @ hex. ;
: WWDG-CFR. ." WWDG-CFR () $" WWDG-CFR @ hex. ;
: WWDG-SR. ." WWDG-SR (read-write) $" WWDG-SR @ hex. ;
: WWDG.
 cr WWDG-CR.
 cr WWDG-CFR.
 cr WWDG-SR.
;


compiletoram
