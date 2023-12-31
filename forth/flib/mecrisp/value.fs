
\ -----------------------------------------------------------------------------
\   Simple implementation without optimisation support
\ -----------------------------------------------------------------------------

: value ( initialisation -- ) ( -- value )
          s" variable (val)" evaluate
  <builds s" (val) ," evaluate
  does>   @ @
;

: to ( x -- )
  '
  begin dup h@ $4780 = swap 2+ swap until \ Skip "blx r0" opcode.
  @ \ The address of the corresponding (val) variable

  state @ if
    literal,
    postpone !
  else
    !
  then

immediate ;


\ -----------------------------------------------------------------------------
\   Full optimisation, for RA cores only. Will crash classic cores.
\ -----------------------------------------------------------------------------

\ :  'f  ( -- flags ) token find nip ;
\ : ['f] ( -- flags )  'f 0-foldable ;
\
\ : value ( initialisation -- ) ( -- value )
\   s" variable (val)" evaluate
\
\   \ Construct runtime
\
\   (create)
\
\   s" (val) literal," evaluate
\   postpone @
\
\   $4770 h, \ "bx lr" opcode.
\
\   \ Construct inline cache
\
\   $1000 setflags
\
\     2 h,
\     s" (val) ," evaluate  $2000    h,
\     ['] @    ,            ['f] @   h,
\
\   \ Finish definition
\   smudge
\ ;
\
\ : (parse-val) ( -- addr )
\   '
\   begin dup h@ $4770 = swap 2+ swap until \ Skip "bx lr" opcode.
\   2+ \ Skip cache length value
\   dup h@ swap 2+ h@ 16 lshift or \ The address of the corresponding (val) variable taken from the inline cache, unaligned access.
\ ;
\
\ : parse-val ( -- addr ) (parse-val) 0-foldable ;
\
\ : to ( x -- ) (parse-val) !
\   exit
\   [
\     $1000 setflags
\     2 h,
\     ' parse-val  ,   'f parse-val  h,
\     '         !  ,   'f         !  h,
\   ]
\ ;
\