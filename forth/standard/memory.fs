\ Words from Forth 2012 Standard, and Forth200x committee; https://forth-standard.org/standard/memory

\ ALLOCATE
\
\ Allocate u address units (bytes) of contiguous data space. The data-space pointer is unaffected by this operation.
\ The initial content of the allocated space is undefined.
\ If the allocation succeeds, a-addr is the aligned starting address of the allocated space and ior is zero.
\ If the operation fails, a-addr does not represent a valid address and ior is the implementation-defined I/O result code.
: allocate ( u -- a-addr ior ) pvPortMalloc swap drop dup ;

\ FREE
\ Return the contiguous region of data space indicated by a-addr to the system for later allocation.
\ a-addr shall indicate a region of data space that was previously obtained by ALLOCATE or RESIZE.
\ The data-space pointer is unaffected by this operation.
\ If the operation succeeds, ior is zero. If the operation fails, ior is the implementation-defined I/O result code.
: free ( a-addr -- ior ) vPortFree 0 ;

\ RESIZE
\ Change the allocation of the contiguous data space starting at the address a-addr1,
\ previously allocated by ALLOCATE or RESIZE, to u address units. u may be either larger or
\ smaller than the current size of the region. The data-space pointer is unaffected by this operation.
\ If the operation succeeds, a-addr2 is the aligned starting address of u address units of allocated
\ memory and ior is zero. a-addr2 may be, but need not be, the same as a-addr1.
\ If they are not the same, the values contained in the region at a-addr1 are copied to a-addr2,
\ up to the minimum size of either of the two regions.
\ If they are the same, the values contained in the region are preserved to the minimum of u or the original size.
\ If a-addr2 is not the same as a-addr1, the region of memory at a-addr1 is returned to the system
\ according to the operation of FREE.
\ If the operation fails, a-addr2 equals a-addr1, the region of memory at a-addr1 is unaffected, and ior is the implementation-defined I/O result code.
: resize ( a-addr1 u -- a-addr2 ior ) ." resize is not supported " cr drop 1 ;

