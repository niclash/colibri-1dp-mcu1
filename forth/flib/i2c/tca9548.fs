
$70 constant MUX.ADDR

: tca9548-reset ( -- )
  $70 i2c-addr 0 >i2c 0 i2c-xfer
;

: tca9548-select ( slot# -- ) \ set the multiplexer to the slot number
  $70 i2c-addr 1 swap lshift >i2c 0 i2c-xfer
;

