\ Words to read and write from/to a ST Microelectronics 24LC16 EEPROM.
\

$50 constant 24LC16.ADDR

: 24lc16-write-frag ( src-addr len dest-addr -- err )
  dup 8 rshift $FF and 24LC16.ADDR + i2c-addr   \ compute i2c device address
  $FF and >i2c                                  \ write address within page
  0 do
    dup c@ >i2c
    1 +
  loop
  drop
  0 i2c-xfer                                    \ I2C transfer, no read
;

: 24lc16-read-frag ( src-addr len -- err )
  dup max-read&write-size @ > if     \ check max size
    ." Max reading " max-read&write-size @ . ." bytes. Was " .
    drop drop -1
    exit
  then
  swap
  ( len src-addr )
  dup 8 rshift $FF and 24LC16.ADDR + i2c-addr   \ compute i2c device address
  $FF and >i2c                                  \ write address within page
  i2c-xfer                                      \ i2c transfer, length is TOS
;

