\ ANSI color value printed to terminal

: >.   ( -- )
  #27 emit ." [0m"
;

: .black< ( -- )
  #27 emit ." [30m"
;

: .red< ( -- )
  #27 emit ." [31m"
;

: .green< ( -- )
  #27 emit ." [32m"
;

: .yellow< ( -- )
  #27 emit ." [33m"
;

: .blue< ( -- )
  #27 emit ." [34m"
;

: .magenta< ( -- )
  #27 emit ." [35m"
;

: .cyan< ( -- )
  #27 emit ." [36m"
;

: .white< ( -- )
  #27 emit ." [37m"
;

: .gray< ( -- )
  #27 emit ." [90m"
;

: .br-red< ( -- )
  #27 emit ." [91m"
;

: .br-green< ( -- )
  #27 emit ." [92m"
;

: .br-yellow< ( -- )
  #27 emit ." [93m"
;

: .br-blue< ( -- )
  #27 emit ." [94m"
;

: .br-magenta< ( -- )
  #27 emit ." [95m"
;

: .br-cyan< ( -- )
  #27 emit ." [96m"
;

: .br-white< ( -- )
  #27 emit ." [97m"
;

