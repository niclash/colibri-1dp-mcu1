
\ EEPROMs are using the following format;
\ Memory is segmented into 1Kbytes blocks, called pages.
\
\ Page 0 - Binary data, in Cell (4 bytes) format
\ Page 1 and beyond - Source code with an SPI of "init", "tick", "read", "write"
\
\ Page 0
\   Cell 0 - Vendor
\               1 = Bali Automation
\   Cell 1 - Vendor-specific Family number
\   Cell 2 - Vendor-specific Model number
\   Cell 3-4 - Pointer + Length to Vendor string

\ Page 1 is read and executed on RESET. If additional pages are to be read, that
\ must be included in Page 1 code. The code must not "compiletoflash", and is re-read
\ on each reset.

\ The module's code MUST contain definitions of the following words;
\   init  ( -- channels )               -  executed after Page 1 has been read and executed, and IF tick/read/write is signaling "error".
\   tick  ( millis -- flag )            -  called cyclically every 100ms.
\   read  ( channel -- value type )     -  read value from a channel, type is the LPP Cayenne type with -1 signaling "error".
\   write ( channel addr type -- err )  -  write a value of LPP Cayenne type to a channel. addr is the address to the LPP packet.

#1024 constant block-size

0 variable write-frag     \ declare function pointer to write fragment
0 variable read-frag

: open-eeprom ( -- )      \ initialize eeprom structure, must be called after changing slot, before reading/writing
  $50 i2c-addr 0 i2c-xfer if                \ true if no eeprom present
    .red< ." No EEPROM present. " >.
    exit
  then
  $57 i2c-addr 0 i2c-xfer if                \ true if failed, so not 24LC16
    \ it is a M24C64
    ['] m24c64-write-frag write-frag !      \ set up pointer to writing a fragment
    ['] m24c64-read-frag read-frag !        \ set up pointer to reading a fragment
    #8192 eeprom-size !                     \ total size of eeprom
  else
    \ it is a 24LC16
    ['] 24lc16-write-frag write-frag !      \ set up pointer to writing a fragment
    ['] 24lc16-read-frag read-frag !        \ set up pointer to reading a fragment
    #2048 eeprom-size !                     \ total size of eeprom
  then
;

: (read&write-len) ( len -- len ) max-read&write-size @ min ;   \ verified

: (update-ptr&len) ( src-addr dest-addr len -- new-src-addr new-dest-addr new-len )
    -rot 2 pick
    (read&write-len) +      \ forward dest pointer
    swap 2 pick
    (read&write-len) +      \ forward src pointer
    rot
    dup (read&write-len) -  \ compute length remaining
    swap -rot               \ adjust stack
;

: (clean-stack) drop drop drop ; \ verified

: (write-frag) ( src-addr dest-addr len -- src-addr dest-addr len err? )
    2 pick
    ( src-addr dest-addr len src-addr )
    2 pick
    ( src-addr dest-addr len src-addr dest-addr )
    2 pick
    ( src-addr dest-addr len src-addr dest-addr len )
    (read&write-len)        \ adjust to max bytes to write
    ( src-addr dest-addr len src-addr dest-addr len )
    swap
    ( src-addr dest-addr len src-addr len dest-addr )
    .s
    write-frag @
    dup 0= if
      .red< ." EEPROM has not been opened. " >.
      drop drop -1
    else
      execute
    then
    ( src-addr dest-addr len err? )
;

: write-eeprom ( src-addr dest-addr len -- err )
  begin
    (write-frag)
    if
      .red< ." Error writing to EEPROM. " >.
      (clean-stack)                 \ Clean up stack
      -1 exit                       \ exit write-eeprom with error
    then
    (update-ptr&len)
  dup 0= until                      \ should always end up on 0 at the end
  (clean-stack) 0                   \ clean up stack and return no error
;

: (read-frag) ( src-addr len -- src-addr len flag )
    2dup
    ( src-addr len src-addr len )
    (read&write-len)
    ( src-addr len src-addr len )
    .s
    read-frag @
    .s
    dup 0= if
      .red< ." EEPROM has not been opened. " >.
      drop drop -1
    else
      execute
    then
;

: (copy-i2c-to-buffer) ( dest-addr src-addr len -- dest-addr src-addr len )
    rot
    ( src-addr len dest-addr )
    dup
    ( src-addr len dest-addr dest-addr )
    i2c.buf
    ( src-addr len dest-addr dest-addr i2cbuf-addr )
    3 pick (read&write-len)
    ( src-addr len dest-addr dest-addr i2cbuf-addr len )
    buffer-copy drop drop
    ( src-addr len dest-addr )
    -rot
    ( dest-addr src-addr len )
;

: read-eeprom ( src-addr dest-addr len -- err )
  rot swap
  ( dest-addr src-addr len )
  begin
    ( dest-addr src-addr len )
    (read-frag)
    ( dest-addr src-addr len err? )
    if
      .red< ." Error reading from EEPROM. " >.
      (clean-stack)
      -1 exit
    then
    ( dest-addr src-addr len )
    (copy-i2c-to-buffer)
    ( dest-addr src-addr len )
    (update-ptr&len)
  dup 0<= until
  (clean-stack) 0
;

: block-read ( block# -- addr flag ) \ reads 1024 bytes from EEPROM, allocates buffer for write, must call "free" later if no error
  block-size allocate
  if
    .red< ." Out of memory. " >.
    drop drop
    0 -1 exit
  then
\  dup block-size $AA fill           \ fill RAM with $AA to see what is read vs what is left alone. TODO: Remove after debugging
  ( block# dest-addr )
  dup
  ( block# dest-addr dest-addr )
  rot
  ( dest-addr dest-addr block# )
  block-size *
  ( dest-addr dest-addr src-addr )
  swap
  ( dest-addr src-addr dest-addr )
  block-size
  ( dest-addr src-addr dest-addr length)
  read-eeprom
  .s
  ( dest-addr err )
  if
    .red< ." Unable to read EEPROM. " >.
    free        \ free the allocated memory
    drop
    0 -1        \ return with error (and addr=0)
  else
    0           \ return with no error
  then
;

: block-write ( src-addr len block# -- err )
  block-size *
  ( src-addr len dest-addr )
  swap
  ( src-addr dest-addr len )
  write-eeprom
;

: eeprom-cell@ ( addr -- n err ) \ reads the integer value in the EEPROM at the address and put on TOS
  dup #1023
  > if
    .red< ." Out of range. " >.
    drop 0 -1 exit
  then
  4 read-frag @ execute i2c.buf @ swap
;

: eeprom-cell! ( n addr -- err ) \ write the TOS integer value to the EEPROM at the address addr
  dup #1023 > if
    .red< ." Out of range. " >.
    0 -1 exit
  then
  swap
  ( addr value )
  i2c.buf $10 + !
  ( addr )
  i2c.buf $10 +
  ( addr src )
  4
  ( addr src len )
  rot
  ( src len addr )
  write-frag @ execute
;

: block-terminated? ( block-buffer-ptr -- block-buffer-ptr flag ) \ checks if the last 3 characters are "\\\"
  dup 3 - c@ #92 =
  ( block-buffer-ptr flag )
  over 2 - c@ #92 = and
  ( block-buffer-ptr flag )
  over 1 - c@ #92 = and
;

: crlf? ( bufptr ch  --  bufptr ch flag ) \ checks if a newline has been received
  over
  c@
  #13 = if -1 exit then  \ if CR then we signal true and return
  over
  c@ #10 = if               \ if LF
    over 1- c@ #13 <>            \    check if we have signaled CR earlier, if so, then return false, else true
  else
    0
  then
;

: send-ok
  bl emit bl emit .yellow< ." ok." >. cr
;

: block-program ( block# -- )  \ reads terminal input until "\\\" (three backslashes) and writes content to eeprom block.
  send-ok cr        \ Ensure that "forth-sender" program keeps on track.
  #1024 allocate
  if
    .red< ." Out of memory." >. cr
    drop drop -1
    exit
  then
  ( block# buffer )
  dup
  ( block# buffer bufptr )
  #1024 0 do
  ( block# buffer bufptr )
    dup
  ( block# buffer bufptr bufptr )
    key         \ read terminal input
  ( block# buffer bufptr bufptr ch )
    dup
  ( block# buffer bufptr bufptr ch ch )
    rot
  ( block# buffer bufptr ch ch bufptr )
    c!
  ( block# buffer bufptr ch )
    crlf? if send-ok then
  ( block# buffer bufptr ch )
    emit
  ( block# buffer bufptr )
    1 +
  ( block# buffer bufptr )
    block-terminated? if leave then     \ exit loop if found termination
  loop
  ( block# buffer bufptr )
  over
  ( block# buffer bufptr buffer )
  -
  ( block# buffer length)
  dup #1024 = if
    .red< ." Terminal input is too large. " >.
    (clean-stack)
    exit
  then
  ( block# buffer length )
  over >r
  ( block# buffer length )
  rot
  ( buffer len block# )
\  block-write
\  ( err? )
\  if
\    .red< ." EEPROM was not written. " cr >.
\  then
\  r>
\  free
\  if
\    .red< ." Unable to free memory properly. " >.
\  then
;
