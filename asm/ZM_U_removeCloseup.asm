.gba
.open "ZM_U.gba","ZM_U_removeCloseup.gba",0x8000000

.definelabel HideHudFlag,0x300004A

.org 0x806061C
    ldr     r0,=HideHudFlag
    strb    r5,[r0]     ; makes HUD visible from start
    b       0x8060746   ; skips code that overwrites VRAM
    .pool

.org 0x805F9A4
    mov     r0,0xD
    strb    r0,[r2,2]   ; skips stages involving Samus's eyes
    b       0x805FD3E


.close
