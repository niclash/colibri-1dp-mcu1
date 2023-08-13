\ hardware timers
\ this only handles TIMER 1, 2, 16, and 17

$40012C00 constant TIM1 ( Advanced-control timers )
$40000000 constant TIM2 ( General-purpose-timers )
$40014400 constant TIM16 ( General-purpose timers )
$40014800 constant TIM17 ( General-purpose timers )

create timers 0 , TIM1 , TIM2 , 0 , 0 , 0 , 0 , 0 , 0 , 0 , 0 , 0 , 0 , 0 , 0 , 0 , TIM16 , TIM17 ,

\ $40007C00 constant LPTIM1 ( Low-power timer )
\ $40009400 constant LPTIM2 ( Low-power timer )
\ $40009800 constant LPTIM3 ( Low-power timer )

$00 constant TIM.CR1
$04 constant TIM.CR2
$0C constant TIM.DIER
$28 constant TIM.PSC
$2C constant TIM.ARR

: timer-base ( n -- addr )  \ return base address for timer 1..14
  cells timers + ;

: timer-enabit ( n -- bit addr )  \ return bit and enable address for timer n
  2- bit RCC-APB1ENR ;

: timer-init ( u n -- )  \ enable timer n as free-running with period u
  dup timer-enabit bis!  \ clock enable
             timer-base >r
  dup 16 rshift TIM.PSC r@ + h!    \ upper 16 bits are used to set prescaler
                TIM.ARR r@ + h!    \ period is auto-reload value
         8 bit TIM.DIER r@ + bis!  \ UDE
  %010 4 lshift TIM.CR2 r@ + !     \ MMS = update
          0 bit TIM.CR1 r> + !     \ CEN
;

: timer-deinit ( n -- )  \ disable timer n
  timer-enabit bic! ;
