\ read out the SM7391 pressure sensor
\ needs i2c
\ NOTE: If sm7391 is not powered, then it will sink SDA, which will hang the I2C bus!!!
\ On Colibri-1dp, the power of the sensor is controlled by PB3

[ifndef] SM7391.ADDR  $6C constant SM7391.ADDR  [then]

decimal

: sm7391-init ( -- nak ) \ nak on stack is true if sensor is missing/broken/inactive/un-powered.
  SM7391.ADDR i2c-addr  $22 >i2c $69 >i2c $B1 >i2c 0 i2c-xfer drop
;

: sm7391-raw ( reg len -- )
  swap SM7391.ADDR i2c-addr >i2c i2c-xfer drop
;

: sm7391-rd ( reg -- ) \ reads signed int16 from register
  2 sm7391-raw i2c-buf h@
  dup #32768 > if
    #65536 -
  then
;

: sm7391-pressure ( -- pressure-in-Pa )
  $30 sm7391-rd \ fetch pressure
  #26214 + #1000 * #52428 / #500 -
;

PB3 ios!
sm7391-init