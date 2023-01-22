.gba
.open "MF_U.gba","MF_U_testDemo.gba",0x8000000

.definelabel GameMode,0x3000BDE
.definelabel DemoFlag,0x3001488
.definelabel PlayMusic,0x8003538
.definelabel DemoNumber,5


; new code
.org 0x8033114      ; unused sprite AI
LoadDemo:
    ; set game mode values
    ldr     r0,=GameMode
    mov     r1,3
    strh    r1,[r0,2]
    mov     r1,4
    strh    r1,[r0,4]
    ; set flag to load into demo
    ldr     r0,=DemoFlag
    mov     r1,1
    strb    r1,[r0]
    ; play title screen music
    mov     r0,0x4A
    mov     r1,0x10
    bl      PlayMusic
    ; return to hijacked code
    ldr     r0,=0x8087700
    mov     r15,r0
    .pool


; hijack code that initializes SubGameMode1
.org 0x80876AE
    ldr     r0,=LoadDemo
    mov     r15,r0
    .pool

; set demo number
.org 0x80718E8
    mov     r0,DemoNumber
    strb    r0,[r2]
    b       0x807190A

; repeat same demo
.org 0x8071978
    b       0x80719C0

; disable input
.org 0x800CAA0
    b       0x800CACC


.close
