\ Words from Forth 2012 Standard, and Forth200x committee; https://forth-standard.org/standard/search

\ This is simply a copy of the content on the website, and is possibly subject to licensing.
\ This is (at best) work in progress, otherwise simply reference material for future work.



\ GET-ORDER
\ Returns the number of word lists n in the search order and the word list identifiers widn ... wid1
\ identifying these word lists.
\ wid1 identifies the word list that is searched first, and widn the word list that is searched last.
\ The search order is unaffected.
variable #order

create context 16 ( wordlists ) cells allot

: get-order ( -- wid1 ... widn n )
   #order @ 0 ?do
     #order @ i - 1- cells context + @
   loop
   #order @
;

\ SET-ORDER
\ Set the search order to the word lists identified by widn ... wid1.
\ Subsequently, word list wid1 will be searched first, and word list widn searched last.
\ If n is zero, empty the search order.
\ If n is minus one, set the search order to the implementation-defined minimum search order.
\ The minimum search order shall include the words FORTH-WORDLIST and SET-ORDER.
\ A system shall allow n to be at least eight.
: set-order ( wid1 ... widn n -0 )
   dup -1 = if
     drop <push system default word lists and n>  \ TODO
   then
   dup #order !
   0 ?do i cells context + ! loop
;

\ FORTH-WORDLIST
\ Return wid, the identifier of the word list that includes all standard words provided by the implementation.
\ This word list is initially the compilation word list and is part of the initial search order.
$cafebabe constant forth-wordlist

\ FORTH
\ Transform the search order consisting of widn, ... wid2, wid1 (where wid1 is searched first)
\ into widn, ... wid2, widFORTH-WORDLIST.
: (wordlist) ( wid "<name>" -- ; )
   create ,
   does>
     @ >r
     get-order nip
     r> swap set-order
;
forth-wordlist (wordlist) forth

\ GET-CURRENT SET-CURRENT
variable compilation-wordlist
: get-current ( -- wid ) compilation-wordlist @ ; \ Return wid, the identifier of the compilation word list.
: set-current ( wid -- ) compilation-wordlist ! ; \ Set the compilation word list to the word list identified by wid.


\ ALSO
\ Transform the search order consisting of widn, ... wid2, wid1 (where wid1 is searched first)
\ into widn, ... wid2, wid1, wid1.
\ An ambiguous condition exists if there are too many word lists in the search order.
: also ( -- )
   get-order over swap 1+ set-order
;

\ DEFINITIONS
\ Make the compilation word list the same as the first word list in the search order.
\ Specifies that the names of subsequent definitions will be placed in the compilation word list.
\ Subsequent changes in the search order will not affect the compilation word list.
: discard ( x1 ... xn u -- ) \ Drop u+1 stack items
   0 ?do drop loop
;
: definitions ( -- )
   get-order swap set-current discard
;

\ Extend the semantics of 6.1.1550 FIND to be: ( c-addr -- c-addr 0 | xt 1 | xt -1 )
\ Find the definition named in the counted string at c-addr.
\ If the definition is not found after searching all the word lists in the search order, return c-addr and zero.
\ If the definition is found, return xt.
\ If the definition is immediate, also return one (1); otherwise also return minus-one (-1).
\ For a given string, the values returned by FIND while compiling may differ from those returned while not compiling.
: find ( c-addr -- c-addr 0 | xt 1 | xt -1 )
   0                              ( c-addr 0 )
   #order @ 0 ?DO
      over count                  ( c-addr 0 c-addr' u )
      i cells context + @         ( c-addr 0 c-addr' u wid )
      search-wordlist             ( c-addr 0; 0 | w 1 | q -1 )
      ?dup if                     ( c-addr 0; w 1 | w -1 )
             2swap 2drop leave    ( w 1 | w -1 )
         then                     ( c-addr 0 )
      loop                        ( c-addr 0 | w 1 | w -1 )
   ;

\ ONLY
\ Set the search order to the implementation-defined minimum search order.
\ The minimum search order shall include the words FORTH-WORDLIST and SET-ORDER.
: only ( -- ) -1 set-order ;


\ ORDER
\ Display the word lists in the search order in their search order sequence, from first searched to last searched.
\ Also display the word list into which new definitions will be placed.
\ The display format is implementation dependent.
\
\ ORDER may be implemented using pictured numeric output words.
\ Consequently, its use may corrupt the transient region identified by #>.
: order ( -- ) ; \ TODO no implementation on site

\ PREVIOUS
\ Transform the search order consisting of widn, ... wid2, wid1 (where wid1 is searched first) into widn, ... wid2.
\ An ambiguous condition exists if the search order was empty before PREVIOUS was executed.
: previous ( -- ) get-order nip 1- set-order ;

\ SEARCH-WORDLIST
\ ( c-addr u wid -- 0 | xt 1 | xt -1 )
\ Find the definition identified by the string c-addr u in the word list identified by wid.
\ If the definition is not found, return zero.
\ If the definition is found, return its execution token xt and one (1) if the definition is immediate,
\ minus-one (-1) otherwise.
: search-wordlist ( c-addr u wid -- 0 | xt 1 | xt -1 ) ; \ TODO no implementation on site

\ WORDLIST
\ Create a new empty word list, returning its word list identifier wid. The new word list may be returned
\ from a pool of preallocated word lists or may be dynamically allocated in data space. A system shall allow
\ the creation of at least 8 new word lists in addition to any provided as part of the system.
: wordlist ( -- wid ) ; \ TODO no implementation on site


\ and from https://forth-standard.org/proposals/vocabulary

\ VOCABULARY
\ ( "name" -- )
\ Skip leading space delimiters.
\ Parse name delimited by a space.
\ Create a definition for name with the execution semantics defined below.
\ Create a new empty word list wid and associate it with name.
\
\ name is referred to as a "vocabulary".
\
\ Typical use:
\ VOCABULARY Assembler
\ ONLY FORTH ALSO Assembler DEFINITIONS ( set search order to  ... FORTH Assembler Assembler )

: vocabulary ( -- )
     wordlist create ,
   does> ( -- ) @
      >r get-order swap drop
      r> swap set-order
;