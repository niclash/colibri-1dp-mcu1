
$40020000 constant DMA1
$40020400 constant DMA2

: ISR ( dma-addr -- addr )     \ ISR register address
;

: IFCR ( dma-addr -- addr )     \ IFCR register address
  4 +
;

: CCR ( dma-addr channel -- addr )
  1- $14 * $8 + +
;

: CNDTR ( dma-addr channel -- addr )
  1- $14 * $C + +
;

: CPAR ( dma-addr channel -- addr )
  1- $14 * $10 + +
;

: CMAR ( dma-addr channel -- addr )
  1- $14 * $14 + +
;

: GIF? ( dma-addr channel -- flag )     \ Fetch the Global interrupt/event flag for a channel
  1- $4 * swap ISR bit@
;
: TCIF? ( dma-addr channel -- flag )     \ Fetch the Transfer Complete interrupt/event flag for a channel
  1- $4 * 1+ swap ISR bit@
;
: HTIF? ( dma-addr channel -- flag )     \ Fetch the Half-Transfer event flag for a channel
  1- $4 * 2+ swap ISR bit@
;
: TEIF? ( dma-addr channel -- flag )     \ Fetch the Transfer Error event flag for a channel
  1- $4 * 3 + swap ISR bit@
;

: dma-init ( -- conf )
  0
;

: dma-tc-int ( conf -- conf )
  2 or
;
: dma-htc-int ( conf -- conf )
  4 or
;
: dma-terr-int ( conf -- conf )
  8 or
;

: dma-from-memory ( conf -- conf )
  16 or
;

: dma-circular ( conf -- conf )
  32 or
;

: dma-peri-inc ( conf -- conf )
  64 or
;

: dma-peri-16 ( conf -- conf )
  256 or
;

: dma-peri-32 ( conf -- conf )
  512 or
;

: dma-mem-inc ( conf -- conf )
  128 or
;

: dma-mem-16 ( conf -- conf )
  1024 or
;

: dma-mem-32 ( conf -- conf )
  2048 or
;

: dma-pri-med ( conf -- conf )
  4096 or
;

: dma-pri-high ( conf -- conf )
  8192 or
;

: dma-mem-mem ( conf -- conf )
  16384 or
;

: dma-config ( conf dma channel -- )
 CCR !
;

: dma-start ( dma channel -- )
  CCR 0 bit !                            \ set CCR, start transfer
;

: dma-channel.  ( dma channel -- )
  cr ."   CCR" dup . 2dup CCR @ hex.
  cr ." CNDTR" dup . 2dup CNDTR @ hex.
  cr ."  CPAR" dup . 2dup CPAR @ hex.
  cr ."  CMAR" dup . 2dup CMAR @ hex.
  2drop
;

: dma.  ( -- )
  cr ." DMA1 "
  cr ." -------------------- "
  cr ."    ISR " DMA1 ISR @ hex.
  cr ."   IFCR " DMA1 IFCR @ hex.
  8 1 do
    DMA1 i dma-channel.
  loop
\  cr cr ." DMA2 "
\  cr ." -------------------- "
\  cr ."    ISR " DMA1 ISR @ hex.
\  cr ."   IFCR " DMA1 IFCR @ hex.
\  8 1 do
\    DMA2 i dma-channel.
\  loop
;

\ DMA1 channels
1 constant dma1-spi-channel

\ DMA2 channels
