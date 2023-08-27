
$22 constant TCA6524.ADDR

: tca6424-reset

;

: tca6424-rd ( reg n -- val )   \ read register "reg" and "n" registers forward.
  TCA6524.ADDR i2c-addr
  $80 or                        \ enable auto-inc
  >i2c swap i2c-xfer
;

: tca6424! ( pin state -- )     \ set the output pin to state. LOW for 0 and HIGH for all other values
  0= if
    
  else
  then
;