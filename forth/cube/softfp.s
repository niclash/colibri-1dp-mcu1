/**
 *  @brief
 *      Interface to the Soft-FP library
 *
 *  @file
 *      fpu.s
 *  @author
 *      Niclas Hedhman, niclas@hedhman.org
 *  @date
 *      2023-08-09
 *  @remark
 *      Language: ARM Assembler
 *  @copyright
 *      Niclas Hedhman
 *
 *      This project Mecrisp-Cube is free software: you can redistribute it
 *      and/or modify it under the terms of the GNU General Public License
 *      as published by the Free Software Foundation, either version 3 of
 *      the License, or (at your option) any later version.
 *
 *      Mecrisp-Cube is distributed in the hope that it will be useful, but
 *      WITHOUT ANY WARRANTY; without even the implied warranty of
 *      MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE. See the GNU
 *      General Public License for more details.
 *
 *      You should have received a copy of the GNU General Public License
 *      along with Mecrisp-Cube. If not, see http://www.gnu.org/licenses/.
 */
// NOTE: This is not tested and may not work at all.
// If no FPU, we compile with softfp library
.if FPU == 0

@ -----------------------------------------------------------------------------
    Wortbirne Flag_foldable_2|Flag_inline, "f+"
f_add:
@   ( r1 r2 -- r3 ) Add r1 to r2 giving the sum r3.
@ -----------------------------------------------------------------------------
    popda   r1
    b       __aeabi_fadd

@ -----------------------------------------------------------------------------
    Wortbirne Flag_foldable_2|Flag_inline, "f-"
f_sub:
@   ( r1 r2 -- r3 ) Subtract r2 from r1, giving r3.
@ -----------------------------------------------------------------------------
    popda   r1
    b       __aeabi_fsub

@ -----------------------------------------------------------------------------
    Wortbirne Flag_foldable_2|Flag_inline, "f*"
f_star:
@   ( r1 r2 -- r3 ) Multiply r1 by r2 giving r3.
@ -----------------------------------------------------------------------------
    popda   r1
    b       __aeabi_fmul

@ -----------------------------------------------------------------------------
    Wortbirne Flag_foldable_2|Flag_inline, "f/"
f_slash:
@   ( r1 r2 -- r3 ) Divide r1 by r2, giving the quotient r3.
@ -----------------------------------------------------------------------------
    popda   r1
    b       __aeabi_fdiv

@ -----------------------------------------------------------------------------
    Wortbirne Flag_foldable_1|Flag_inline, "fsqrt"
fsqrt:
@   ( r1 -- r2 ) r2 is the square root of r1.
@ -----------------------------------------------------------------------------
    b       sqrtf

@ -----------------------------------------------------------------------------
    Wortbirne Flag_foldable_1|Flag_inline, "fabs"
fabs_:
@   ( r1 -- r2 ) r2 is the absolute value of r1.
@ -----------------------------------------------------------------------------
    b       fabs

@ -----------------------------------------------------------------------------
@   Wortbirne Flag_visible|Flag_foldable_1, "10**>f"
@pow10_to_f:
@   ( n -- r ) raise 10 to the power n, giving r.
@ -----------------------------------------------------------------------------
@    push    {lr}
@    mov     r1, tos
@    ldr     tos, =0x41200000     @ loading 10
@    bl      powf
@    pop     {pc}

@ -----------------------------------------------------------------------------
@   Wortbirne Flag_visible|Flag_foldable_1, "flog>n"
@flog_to_n:
@   ( r -- n ) n is the base-ten logarithm of r.
@ -----------------------------------------------------------------------------
     b      log10f

@ -----------------------------------------------------------------------------
    Wortbirne Flag_foldable_1|Flag_inline, "fnegate"
fnegate:
@   ( r1 -- r2 ) r2 is the negation of r1.
@ -----------------------------------------------------------------------------
    push    {lr}
    mov     r1, tos
    ldr     tos, =0x80000000
    bl      __aeabi_fsub
    pop     {pc}

@ -----------------------------------------------------------------------------
    Wortbirne Flag_visible|Flag_foldable_1, "fround"
fround:
@   ( r1 -- r2 ) round r1 to an integral value using the "round to nearest" rule, giving r2
@ -----------------------------------------------------------------------------
    b       roundf

@ -----------------------------------------------------------------------------
    Wortbirne Flag_foldable_1|Flag_inline, "f>s"
f_to_s:
@   ( r -- n ) n is the single-cell signed-integer equivalent of the integer portion of r.
@ -----------------------------------------------------------------------------
    b       __aeabi_f2iz

@ -----------------------------------------------------------------------------
    Wortbirne Flag_foldable_1|Flag_inline, "s>f"
s_to_f:
@   ( n -- r ) r is the floating-point equivalent of the single-cell value n.
@ -----------------------------------------------------------------------------
    b       __aeabi_i2f

@ -----------------------------------------------------------------------------
    Wortbirne Flag_inline, "pi"
pi:
@   (  -- r ) r is pi approx. 3.14159274101257324
@ -----------------------------------------------------------------------------
    pushdatos
    mov     tos, #0x0fdb
    movt    tos, #0x4049
    bx      lr

@ -----------------------------------------------------------------------------
    Wortbirne Flag_inline, "e"
euler:
@   (  -- r ) r is e approx. 2.718281828459045235360287
@ -----------------------------------------------------------------------------
    pushdatos
    mov     tos, #0xf854
    movt    tos, #0x402d
    bx      lr

@ -----------------------------------------------------------------------------
    Wortbirne Flag_visible|Flag_foldable_1, "f0="
f0equal:
@   ( r -- ? )          flag is true if r is equal to zero
@ -----------------------------------------------------------------------------
    subs    tos, #1
    sbcs    tos, tos
    bx      lr

@ -----------------------------------------------------------------------------
    Wortbirne Flag_visible|Flag_foldable_1, "f0<"
f0less:
@   ( r -- ? )          flag is true if r is less than zero
@ -----------------------------------------------------------------------------
    tst     tos, #0x80000000
    beq     1f
    mov     tos, #-1
    bx      lr
1:
    mov     tos, #0
    bx      lr

@ -----------------------------------------------------------------------------
    Wortbirne Flag_visible|Flag_foldable_2, "f<"
@   ( r1 r2 -- ? )      flag is true if r1 is less than r2
@ -----------------------------------------------------------------------------
    push    {lr}
    popda   r1
    bl      __aeabi_fcmplt
    pop     {pc}

@ -----------------------------------------------------------------------------
    Wortbirne Flag_visible|Flag_foldable_3, "f~"
@   ( r1 r2 r3 -- ? )   If r3 is positive, flag is true if the absolute value of (r1 minus r2) is less than r3
@                       If r3 is zero, flag is true if the implementation-dependent encoding of r1 and r2 are exactly identical
@                           (positive and negative zero are unequal if they have distinct encodings).
@                       If r3 is negative, flag is true if the absolute value of (r1 minus r2) is less than the absolute value
@                           of r3 times the sum of the absolute values of r1 and r2.
@ -----------------------------------------------------------------------------
    push    {lr}
    bl      rot
    bl      f_sub
    bl      f_abs
    bl      swap
    popda   r1
    bl      __aeabi_fcmplt
    mov     r1, tos
    ldr     tos, =0x0
    sub     r0, r1
    pop     {pc}

@ -----------------------------------------------------------------------------
    Wortbirne Flag_visible|Flag_foldable_1, "f>expo"
f2expo:
@   ( r1 -- n )       get exponent
@ -----------------------------------------------------------------------------
    lsr     tos, tos, #23        // remove fraction
    and     tos, tos, #0xff        // remove sign
    sub     tos, tos, #127        // bias
    bx      lr

@ -----------------------------------------------------------------------------
    Wortbirne Flag_visible|Flag_foldable_1, "f>fract"
f2fract:
@   ( r1 -- u )       get fraction part of r1
@ -----------------------------------------------------------------------------
    lsl     tos, tos, 9        // remove sign and exponent
    lsr     tos, tos, 9
    orr     tos, tos, #0x00800000        // set 23. bit
    bx      lr

@ -----------------------------------------------------------------------------
@   Wortbirne Flag_visible, "f."
@ f_dot:
@   ( r --  ) Display, with a trailing space, the rounded floating-point number r in fixed-point notation
@ -----------------------------------------------------------------------------

@ -----------------------------------------------------------------------------
@   Wortbirne Flag_visible, "fs."
@ fs_type:
@   ( r --  )     display, with a trailing space, the floating-point number r in scientific notation
@ -----------------------------------------------------------------------------

@ -----------------------------------------------------------------------------
@   Wortbirne Flag_visible, "fe."
@ fe_type:
@   ( r --  )     display, with a trailing space, the floating-point number r in engineering notation
@ -----------------------------------------------------------------------------

@ -----------------------------------------------------------------------------
@   Wortbirne Flag_visible, "fm."
@fm_type:
@   ( r --  )     display, with a trailing space, the floating-point number r in metric notation
@ -----------------------------------------------------------------------------

@ -----------------------------------------------------------------------------
    Wortbirne Flag_visible, "precision"
precision:
@   ( -- u )      return the number of significant digits currently used by F., FE., or FS. as u
@ -----------------------------------------------------------------------------
    pushdatos
    ldr     tos, =Fprecision
    ldr     tos, [tos]
    bx      lr

@ -----------------------------------------------------------------------------
    Wortbirne Flag_visible, "set-precision"
set_precision:
@   ( -- u )      ( u -- )      set the number of significant digits currently used by F., FE., or FS. to u
@ -----------------------------------------------------------------------------
    cmp     tos, #0
    blt     1f
    cmp     tos, #8
    bgt     1f
    ldr     r0, =Fprecision
    str     tos, [r0]
1:
    drop
    bx      lr


// Words Using C Math Library
// **************************

@ -----------------------------------------------------------------------------
    Wortbirne Flag_visible, ">float"
to_float:
@   (a # -- r f ) convert the numbered string to float r, on success flag is true
@ -----------------------------------------------------------------------------
    push    {lr}
    mov     r1, tos        // #
    drop
    mov     r0, tos        // a

    // TODO: Is this correct???
    bl      __aeabi_str2f
    pushdatos
    mov     tos, #-1
    ldr     r2, =0x7fc00000  // NaN
    cmp     tos, r2
    bne     1f            // success
    mov     tos, #0        // fail
1:
    pop     {pc}

@ -----------------------------------------------------------------------------
    Wortbirne Flag_visible, "fnumber"
fnumber:
    @ (a # -- r u ) convert the numbered string to float r, on success u is 1 or 2, fail 0
        //                single precision u = 1, double precision u = 2
@ -----------------------------------------------------------------------------
    push    {lr}
    bl      to_float
    cmp     tos, #0
    beq     1f            // fail
    mov     tos, #1        // success
1:
    pop     {pc}

@ -----------------------------------------------------------------------------
    Wortbirne Flag_visible|Flag_foldable_1, "fsin"
fsin:
@   ( r1 -- r2 )       r2 is the sine of the radian angle r1
@ -----------------------------------------------------------------------------
    b       sinf

@ -----------------------------------------------------------------------------
    Wortbirne Flag_visible|Flag_foldable_1, "fcos"
fcos:
@   ( r1 -- r2 )       r2 is the cosine of the radian angle r1
@ -----------------------------------------------------------------------------
    b       cosf

@ -----------------------------------------------------------------------------
    Wortbirne Flag_visible|Flag_foldable_1, "ftan"
ftan:
@   ( r1 -- r2 )       r2 is the principal radian angle whose tangent is r1
@ -----------------------------------------------------------------------------
    b       tanf

@ -----------------------------------------------------------------------------
    Wortbirne Flag_visible|Flag_foldable_1, "fasin"
fasin:
@   ( r1 -- r2 )       r2 is the principal radian angle whose sine is r1
@ -----------------------------------------------------------------------------
    b       fasin

@ -----------------------------------------------------------------------------
    Wortbirne Flag_visible|Flag_foldable_1, "facos"
facos:
@   ( r1 -- r2 )       r2 is the principal radian angle whose cosine is r1
@ -----------------------------------------------------------------------------
    b       acosf

@ -----------------------------------------------------------------------------
    Wortbirne Flag_visible|Flag_foldable_1, "fatan"
fatan:
@   ( r1 -- r2 )       r2 is the principal radian angle whose tangent is r1.
@ -----------------------------------------------------------------------------
    b       atanf

@ -----------------------------------------------------------------------------
    Wortbirne Flag_visible|Flag_foldable_1, "fsinh"
fsinh:
@   ( r1 -- r2 )       r2 is the hyperbolic sine of r1
@ -----------------------------------------------------------------------------
    b       sinhf

@ -----------------------------------------------------------------------------
    Wortbirne Flag_visible|Flag_foldable_1, "fcosh"
fcosh:
@   ( r1 -- r2 )       r2 is the hyperbolic cosine of r1
@ -----------------------------------------------------------------------------
    b       coshf

@ -----------------------------------------------------------------------------
    Wortbirne Flag_visible|Flag_foldable_1, "ftanh"
ftanh:
@   ( r1 -- r2 )       r2 is the hyperbolic tangent of r1
@ -----------------------------------------------------------------------------
    b       tanhf

@ -----------------------------------------------------------------------------
    Wortbirne Flag_visible|Flag_foldable_1, "fasinh"
fasinh:
@   ( r1 -- r2 )       r2 is the floating-point value whose hyperbolic sine is r1
@ -----------------------------------------------------------------------------
    b       asinhf

@ -----------------------------------------------------------------------------
    Wortbirne Flag_visible|Flag_foldable_1, "facosh"
facosh:
@   ( r1 -- r2 )       r2 is the floating-point value whose hyperbolic cosine is r1
@ -----------------------------------------------------------------------------
    b       acoshf

@ -----------------------------------------------------------------------------
    Wortbirne Flag_visible|Flag_foldable_1, "fatanh"
fatanh:
@   ( r1 -- r2 )       r2 is the floating-point value whose hyperbolic tangent is r1.
@ -----------------------------------------------------------------------------
    b       atanhf

@ -----------------------------------------------------------------------------
    Wortbirne Flag_visible|Flag_foldable_1, "fceil"
fceil:
@   ( r1 -- r2 )       return the smallest integral value that is not less than r1
@ -----------------------------------------------------------------------------
    b       ceilf

@ -----------------------------------------------------------------------------
    Wortbirne Flag_visible|Flag_foldable_1, "ffloor"
ffloor:
@   ( r1 -- r2 )       Round r1 to an integral value using the "round toward negative infinity" rule, giving r2
@ -----------------------------------------------------------------------------
    b       floorf

@ -----------------------------------------------------------------------------
    Wortbirne Flag_visible|Flag_foldable_1, "fexp"
fexp:
@   ( r1 -- r2 )       raise e to the power r1, giving r2.
@ -----------------------------------------------------------------------------
    b       expf

@ -----------------------------------------------------------------------------
    Wortbirne Flag_visible|Flag_foldable_1, "fln"
fln:
@   ( r1 -- r2 )       r2 is the natural logarithm of r1. An ambiguous condition exists if r1 is less than or equal to zero
@ -----------------------------------------------------------------------------
    b       logf

@ -----------------------------------------------------------------------------
    Wortbirne Flag_visible|Flag_foldable_1, "flog"
flog:
@   ( r1 -- r2 )       r2 is the base-ten logarithm of r1. An ambiguous condition exists if r1 is less than or equal to zero
@ -----------------------------------------------------------------------------
    b       log10f

@ -----------------------------------------------------------------------------
    Wortbirne Flag_visible|Flag_foldable_2, "f**"
fpow:
@   ( r1 r2 -- r3 )       raise r1 to the power r2, giving the product r3
@ -----------------------------------------------------------------------------
    popda   r1
    b       powf

.ltorg @ Hier werden viele spezielle Hardwarestellenkonstanten gebraucht, schreibe sie gleich !

.endif // FPU == 1

