
0 variable out1
0 variable out2

: init2 i2c-addr $60 >i2c 0 >i2c 0 >i2c 0 i2c-xfer drop ;
: init ( -- channels ) $60 init2 $61 init2 2 ;
: tick2 i2c-addr out1 dup $FF and >i2c $100 / >i2c 0 i2c-xfer ;
: tick ( millis -- flag ) $60 tick2 $61 tick2 or 0= ;
: read ( channel -- value type ) 1 = if out1 else out2 then lpp-analog-output ;
: write ( value channel -- flag ) 1- aqv-out + ! ;

