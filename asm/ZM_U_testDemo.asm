.gba
.open "ZM_U.gba","ZM_U_testDemo.gba",0x8000000

.definelabel GameMode,0x3000C70
.definelabel PlayMusic,0x80039F4
.definelabel DemoNumber,2


; new code
.org 0x8043DF0      ; unused sprite AI
LoadDemo:
    bl      0x8060B20
    ; set game mode values
    ldr     r0,=GameMode
    mov     r1,0xB
    strh    r1,[r0]
    mov     r1,0
    strh    r1,[r0,2]
    strh    r1,[r0,4]
    ; play title screen music
    mov     r0,2
    mov     r1,2
    bl      PlayMusic
    ; set music switch flag
    ldr     r0,=0x3001D21
    mov     r1,4
    strb    r1,[r0]
    ; return to hijacked code
    ldr     r0,=0x807EFE8
    mov     r15,r0
    .pool


; hijack code that initializes SubGameMode1
.org 0x807EFD8
    ldr     r0,=LoadDemo
    mov     r15,r0
    .pool

; set demo number
.org 0x8060B42
    mov     r0,DemoNumber
    strb    r0,[r3]
    b       0x8060B5E

; repeat same demo
.org 0x8060DB8
    b       0x8060DF8

; disable input
.org 0x800C39C
    b       0x800C3C8


.close
