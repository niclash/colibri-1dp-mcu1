1 slot-on 1 slot-reset
5 delay drop
1 slot-select drop
5 delay drop
open-eeprom

compiletoram

\ Next line will write the remaining text to \\\ (three backslashes) to block 1 in EEPROM
1 block-program
