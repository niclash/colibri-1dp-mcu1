
0 variable slot-eeprom-ptr

\ todo: slot 1 and 2 hard hardcoded for now
\ the actual number is available on boot on IO_SELECTn pins on the bus.
2 variable #slots

\ TODO: LATER WHEN WE HAVE THE HARDWARE FOR IT!!!
\ 0 tca9548-select        \ select motherboard
\ 0 open-eeprom           \ reads 2kB from EEPROM, first bank
\ 2dup
\ 2048 evaluate           \ TODO: Will this require EEPROM is filled to end with SPACE ?
\ drop close-eeprom       \ free up allocated memory

\ arrays of word/function pointers for the slot SPI, i.e. init, tick, read and write
#slots @
dup buffer: slot-init   \ init words ( -- channels ), where "channels" are the number of Cayenne LPP data points needed.
dup buffer: slot-tick   \ tick words ( millis -- flag ), where "millis" is system tick counter in milliseconds (overflows every 49 days), "flag" is true if re-init is needed.
dup buffer: slot-read   \ read words ( channel -- value type ), "channel" is 1..n, where "n" was reported in init word. "type" is the Cayenne LPP type, and "value" is the value of the channel.
    buffer: slot-write  \ write words ( value channel -- err ), "channel" is 1..n, where "n" was reported in init word, and "value" is the value of the channel. flag is true if re-init is needed



: slot-reinit ( slot# -- )          \ Called to re-initialize the board in a slot. This should happen if a 'tick' returns false.
  dup reset-low 1 delay    \ RST low
  dup power-off 1 delay    \ Power down the slot, wait
  dup power-on 1 delay     \ Power up the slot, wait
  dup reset-high 1 delay   \ RST hi
  1- cells slot-init @ execute      \ call "init" for slot
;

: slot-powerup ( slot# -- )     \ Called on Colibri powerup for each slot, ONLY ONCE.
  dup power-on 1 delay     \ Power up the slot, wait
  dup reset-low 1 delay    \ RST low
  dup reset-high 1 delay   \ RST hi

                           \ read the EEPROM
                           \ execute forth code

  dup 1- cells
  \ attach hooks
  dup ' init swap slot-init !
  dup ' tick swap slot-tick !
  dup ' read swap slot-read !
      ' write swap slot-write !

  slot-init @ execute \ call "init" for slot
;

: tick-slot ( slot# -- ) \ called by io thread to execute one cycle
  1- cells slot-tick @ execute
;
