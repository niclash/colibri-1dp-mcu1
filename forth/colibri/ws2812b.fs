
\ Neopixel support
\
\ Usage:
\ $8000 rgb niclas  \ create a word that sets the LED to green when executing
\
\ $8000 set-rgb     \ sets the LED to green

: neopixel ( n --  )
    4 0 do
      dup 3 and ( input masked )
      case
        0 of $88 endof
        1 of $C8 endof
        2 of $8C endof
        3 of $CC endof
      endcase
      ( input value )
      swap
      ror ror                   \ shift in next two bits
    loop
    drop
;

: (neopixel) ( n --  )
    #24 lshift \ move all bits up
    4 0 do
      rol rol                   \ shift in next two bits
      dup 3 and ( input masked )
      case
        0 of $88 endof
        1 of $C8 endof
        2 of $8C endof
        3 of $CC endof
      endcase
      literal,      \ compile top of stack (TOS) as a literal to word being defined
      ['] >spi      \ address of ">spi" to TOS
      call,         \ compile a call to the address on TOS
    loop
    drop
;

: split-rgb ( rgb -- b r g )
  dup $FF and swap ( blue )
  dup #16 rshift $FF and swap ( red )
  #8 rshift $FF and ( green )
;

: rgb ( rgb -- )( -- )
  <builds
    split-rgb       \ convert 24 bits into three 8bits in order of b r g (green on TOS)
    (neopixel)      \ generate bitstream for green
    (neopixel)      \ generate bitstream for red
    (neopixel)      \ generate bitstream for blue
    ret,            \ generate a return
  does> execute
;

: set-rgb ( rgb -- )( -- )
    split-rgb       \ convert 24 bits into three 8bits in order of b r g (green on TOS)
    ( b r g -- )
    2 pick
    cr .s
    neopixel        \ generate bitstream for green
    ( b r g b1 b2 b3 b4 -- )
    #5 pick
    .s
    neopixel        \ generate bitstream for red
    ( b r g b1 b2 b3 b4 b5 b6 b7 b8 -- )
    #8 pick
    .s
    neopixel        \ generate bitstream for blue
    .s
    pause
    >spi
    >spi
    >spi
    >spi

    >spi
    >spi
    >spi
    >spi

    >spi
    >spi
    >spi
    >spi
    drop drop drop
;

