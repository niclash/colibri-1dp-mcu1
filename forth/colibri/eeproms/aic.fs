
0 variable in1
0 variable in2
1 variable k1_1
1 variable k1_2
1 variable k2_1
1 variable k2_2
0 variable channel

: init2 i2c-addr  ;
: init ( -- channels ) $60 init2 $61 init2 2 ;
: tick2 i2c-addr ;

: start-convert 1 >i2c channel if $A5 else $B5 then >i2c $83 >i2c 0 i2c-xfer ;
: read-adc $49 i2c-addr 0 >i2c 2 i2c-xfer ;

: tick ( millis -- flag )
  read-adc
  0= if
    i2c.buf @
    channel if in1 else in2 then !
    channel toggle
    start-convert
  then
  0
;
: read ( channel -- value type ) 1 = if k1_2 k1_1 in1 else k2_2 k2_2 in2 then * / lpp-analog-input ;
: write ( value channel -- flag ) 1 = if in1 else in2 then ! 0 ;

