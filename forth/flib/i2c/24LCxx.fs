\ Words to read and write to a 24LCxx EEPROM connected on the I2C bus
\

$50 constant 24lc-addr-start

: #pages-eeprom ( -- n ) \ returns the number of EEPROM banks that are available, each 2048 bytes long
    1   \ TODO, hard coded to a 24LC16
;

: open-eeprom ( page -- addr u )
  2048 allocate ( addr u ) drop         \ drop length of allocated buffer
  dup                                   \ keep copy to return
  0<> if                                \ memory was allocated?
    dup [ $100 i2c-buffer-size / , ]    \ address pointer into temporary buffer
    0 do
      24lc-addr-start + i2c-addr        \ set the I2C address
      i i2c-buffer-size * >i2c          \ set the address to read
      i2c-buffer-size i2c-xfer          \ transfer a full block
      if
        \ failed reading eeprom, we have 2 addresses on stack
        \ drop both addresses, and push a double zero
        2drop 0 0
        exit
      then
      \ now we need to copy i2c.buf to buffer on stack.
      dup i2c.buf swap i2c-buffer-size ( src-addr dest-addr len ) buffer-copy drop drop
      i2c-buffer-size +                 \ forward destination pointer
    loop
    drop                                \ drop destination pointer
  then
;

: close-eeprom ( addr -- )
  free drop
;

