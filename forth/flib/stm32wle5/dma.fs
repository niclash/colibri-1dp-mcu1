
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

: dma-channel.  ( dma channel -- )
  cr ."   CCR" dup . 2dup CCR dup hex. @ hex.
  cr ." CNDTR" dup . 2dup CNDTR dup hex. @ hex.
  cr ."  CPAR" dup . 2dup CPAR dup hex. @ hex.
  cr ."  CMAR" dup . 2dup CMAR dup hex. @ hex.
  2drop
;

: dma1.  ( -- )
  cr ." DMA1 " DMA1 hex.
  cr ." -------------------- "
  cr ."    ISR " DMA1 ISR dup hex. @ hex.
  cr ."   IFCR " DMA1 IFCR dup hex. @ hex.
  8 1 do
    DMA1 i dma-channel.
  loop
;

: dma2.
  cr cr ." DMA2 " DMA2 hex.
  cr ." -------------------- "
  cr ."    ISR " DMA2 ISR dup hex. @ hex.
  cr ."   IFCR " DMA2 IFCR dup hex. @ hex.
  8 1 do
    DMA2 i dma-channel.
  loop
;

: dma-init ( -- conf )
  3 RCC-AHB1ENR bis!    \ enable DMA1 and DMA2 clocks
  3 RCC-AHB1RSTR bis!   \ reset DMA1 and DMA2
  nop
  3 RCC-AHB1RSTR bic!   \ release reset signal on DMA1 and DMA2
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
  $10 or
;

: dma-circular ( conf -- conf )
  $20 or
;

: dma-peri-inc ( conf -- conf )
  $40 or
;

: dma-peri-16 ( conf -- conf )
  $100 or
;

: dma-peri-32 ( conf -- conf )
  $200 or
;

: dma-mem-inc ( conf -- conf )
  $80 or
;

: dma-mem-16 ( conf -- conf )
  $400 or
;

: dma-mem-32 ( conf -- conf )
  $800 or
;

: dma-pri-med ( conf -- conf )
  $1000 or
;

: dma-pri-high ( conf -- conf )
  $2000 or
;

: dma-mem-mem ( conf -- conf )
  $4000 or
;

: dma-config ( conf dma channel -- )
 CCR !
;

: dma-start ( dma channel -- )
  CCR 0 bit swap bis!               \ set CCR, start transfer
;

