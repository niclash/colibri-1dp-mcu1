
: io-thread ( -- )
  osNewDataStack
  tca9548-select
  0 tca9548-select
  \ initialize mother board

  \ read Forth programs
  #slots @ 1+ 1 do
    i tca9548-select
    i slot-powerup
  loop

  \ loop forever
  begin
    #slots @ 1+ 0 do  \ loops all slots, incl motherboard
      i tca9548-select
      i tick-slot
    loop
  until
  osThreadExit
;

' io-thread 0 0 osThreadNew