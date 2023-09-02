\ Programming the functions of a Expansion Module to its EEPROm, requires
\   1. The Colibri AQV board to be in slot IO1

\ Documentation (code below is stored in text format in EEPROM, so no comments to save space.
\ : compute  ( addr -- out ) --> out=v*k/m (don't support offsets)
\ : init - see eeprom.fs
\ : init-dac ( device -- ) \ initialize DAC and set to 0 output.
\ : write-dac ( device out -- ) \ sets the output on the given device
\ : tick - see eeprom.fs
\ : read - see eeprom.fs
\ : write - see eeprom.fs

\ Next line will write the remaining text to \\\ (three backslashes) to block 1 in EEPROM
1 block-program
0 variable out1 2 cells allot
0 variable out2 2 cells allot
: compute dup @ swap 1 cells + dup @ swap 1 cells + @ -rot * swap / ;
: init-dac i2c-addr $60 >i2c 0 >i2c 0 >i2c 0 i2c-xfer drop ;
: init $60 init-dac $61 init-dac 2 0 eeprom-cell ;
: write-dac i2c-addr dup $FF and >i2c $100 / >i2c 0 i2c-xfer ;
: tick out1 compute / $60 write-dac out2 compute $61 write-dac or 0= ;
: read 1 = if out1 else out2 then lpp-analog-output ;
: write 3 = if swap 1 = if out1 else out2 then ! else drop drop then ;
\\\   \ End of code in EEPROM

\ Test cases
