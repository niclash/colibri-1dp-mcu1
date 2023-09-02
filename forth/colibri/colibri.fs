
: toggle dup @ not swap ! ; \ toggle a boolean flag

: 0<= ( n -- flag ) dup 0< swap 0= or ;  \ less than or equal to zero

