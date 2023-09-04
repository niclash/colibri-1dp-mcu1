
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
dup buffer: slot-write  \ write words ( value channel -- err ), "channel" is 1..n, where "n" was reported in init word, and "value" is the value of the channel. flag is true if re-init is needed
cells buffer: channels  \ How many channels exist on the expansion board, as reported in "init"


: slot-reinit ( slot# -- )          \ Called to re-initialize the board in a slot. This should happen if a 'tick' returns false.
  dup slot-off 1 delay      \ Power down the slot, wait
  dup slot-on 1 delay       \ Power up the slot, wait
  dup slot-reset 1 delay    \ RESET cycle
  1- cells slot-init @ execute      \ call "init" for slot
;

: slot-powerup ( slot# -- )     \ Called on Colibri powerup for each slot, ONLY ONCE.
  dup slot-on 1 delay       \ Power up the slot, wait
  dup slot-reset 1 delay    \ RESET cycle
  dup slot-select           \ Select slot

  1 block-read              \ read the EEPROM
  if .yellow< ." EEPROM not present in slot. " >.

  2dup #1024 evaluate       \ execute forth code from EEPROM. EEPROM should have been filled with SPACE at end.
  if swap ." Error interpreting EEPROM in slot " . free exit then  \ EEPROM program must have ( slot# c-addr len -- err? )

  dup 1- cells
  \ attach hooks
  ' (init) over cells slot-init + !
  ' (tick) over cells slot-tick + !
  ' (read) over cells slot-read + !
  ' (write) over cells slot-write + !

  slot-init @ execute       \ call "init" for slot
  ( slot# channels )

;

: tick-slot ( slot# -- ) \ called by io thread to execute one cycle
  1- cells slot-tick @ execute
;
