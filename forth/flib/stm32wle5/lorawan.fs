\ Interfacing with the LoraWAN stack that is written in C.
\

: lora-cb ( xt -- )  \ register the callback for when a subpacket is sent to a slot routine.
                     \ The callback must have the call signature of ( addr u -- ) addr to a byte array of size u.
  drop ( not implement yet )
;

: lora-send ( value channel type -- )  \ sends a subpacket in the next cycle of LoraWAN communications. "value" is the
                                       \ value to be added to the Cayenne buffer on "channel" and with the LPP "type".
  drop drop drop ( not implement yet )
;

