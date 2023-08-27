
1 constant #ws2812b

#ws2812b #12 *
    buffer: ws2812b-dma

0 variable ws2812b-index

: (ws2812b) ( n --  )
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
      ws2812b-index @ c!
      1 ws2812b-index +!
    loop
    drop
;

: spi-dma-config ( -- )
  spi-init                          \ enable SPI1
  SPI1 DMA1 dma1-spi-channel CPAR ! \ set peripheral address
  dma-init
    dma-from-memory
    dma-peri-16                     \ two bytes per transfer
    dma-mem-16
    dma-mem-inc
  DMA1 dma1-spi-channel dma-config
;

: ws2812b-init ( -- )
  spi-dma-config
  ws2812b-dma ws2812b-index !       \ reset write pointer
;

: ws2812b-add ( r g b -- )( -- )
  -rot (ws2812b) (ws2812b) (ws2812b)
;

: ws2812b-send ( -- )
  ws2812b-dma
  #ws2812b #6 *                     \ two bytes per transfer
  >spi-dma
;

: ws2812b ( r g b -- )( -- )
  ws2812b-init
\  ws2812b-add
\  ws2812b-dma dump16
\  ws2812b-send
;
