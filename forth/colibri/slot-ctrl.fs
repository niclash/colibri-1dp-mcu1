
\ Variables used for accessing eeprom on expansion board.

#0  variable eeprom-size
#16 variable max-read&write-size


\ This is for Rev D and later
\ : reset-low ( slot# -- )
\   7 and 8 + 0 swap tca6424!
\ ;
\
\ : reset-high ( slot# -- )
\   7 and 8 + 1 swap tca6424!
\ ;
\
\ : power-on ( slot# -- )  \ set PowerPin HIGH for slot# (base1)
\   7 and 1 swap tca6424!
\ ;
\
\ : power-off ( slot# -- ) \ set PowerPin LOW for slot# (base1)
\   7 and 0 swap tca6424!
\ ;

\ Rev C board

: slot-reset ( slot# -- )
  1 = if PA10 else PA9 then
  ioc!
  5 delay drop
  1 = if PA10 else PA9 then
  ios!
;

: slot-on ( slot# -- )  \ set PowerPin HIGH for slot# (base1)
  1 = if PA8 else PB2 then
  ios!
;

: slot-off ( slot# -- ) \ set PowerPin LOW for slot# (base1)
  1 = if PA8 else PB2 then
  ioc!
;

: slot-select ( slot# -- )
  dup slot-on
  \ TODO: When Rev D comes, we don't subtract 1.
  1- tca9548-select
;

