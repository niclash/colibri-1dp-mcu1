\ Words to read and write from/to a ST Microelectronics M24C64 EEPROM.
\

$50 constant M24C64.ADDR

: m24c64-write-frag ( src-addr len dest-addr -- err )
  M24C64.ADDR i2c-addr
  ( src-addr len dest-addr )
  dup 8 rshift $FF and
  ( src-addr len dest-addr dest-addr )
  >i2c
  ( src-addr len dest-addr )
  $FF and >i2c
  ( src-addr len )
  0 do
    ( src-addr )
    dup c@ >i2c
    1 +
  loop
  ( src-addr )
  drop
  0 i2c-xfer
;

: m24c64-read-frag ( src-addr len -- err )
  dup max-read&write-size @ > if     \ check max size
    ." Max reading " max-read&write-size . ." bytes. Was " .
    drop drop -1
    exit
  then
  swap
  ( len src-addr )
  M24C64.ADDR i2c-addr
  ( len src-addr )
  dup 8 rshift $FF and >i2c
  $FF and >i2c
  ( len )
  i2c-xfer
  ( err )
;
