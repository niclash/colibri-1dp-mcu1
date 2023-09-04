0 variable in1
0 variable in2
#375000 variable k1_1
#375000 variable k1_2
#1000 variable k2_1
#1000 variable k2_2
1 variable channel

: (start-convert)
 $48 i2c-addr 1 >i2c
 case
   1 of %11110011 endof \ AI1
   2 of %11100011 endof \ AI2
   3 of %11010011 endof \ GND
   4 of %11000011 endof \ Vcc
 endcase
 >i2c
 %01000011 >i2c
 0 i2c-xfer
;
: (read-adc) $48 i2c-addr 0 >i2c 2 i2c-xfer 0= if i2c-buf dup c@ $100 * swap 1+ c@ + else -1 then ;
: (toggle) channel @ 1 = if 2 else 1 then channel ! ;
: (store) channel 1 = if in1 else in2 then ! ;

\ API
: [init] channel (start-convert) drop 2 ;
: [tick] (read-adc) dup -1 <> if (store) (toggle) (start-convert) else drop slots-error-counter 1 +! then 0 ;
: [read] 1 = if k2_1 @ k1_1 @ in1 else k2_2 @ k1_2 @ in2 then * / lpp-analog-input ;
: [write] lpp-analog-input <> if drop drop -1 exit then 1 = if in1 else in2 then ! 0 ;
\ \\\