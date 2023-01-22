.gba
.open "ZM_U.gba","ZM_U_eventConnections.gba",0x8000000

.definelabel AreaID,0x3000054

.org 0x805EFA8
    ; r0 = math
    ; r4 = EventDataOffset
    ; r5 = NumOfDoors
    ; r6 = SrcDoor
    ; r7 = AreaID
    push    r4-r7,r14
    mov     r7,r8
    push    r7
    lsl     r0,r0,0x18
    lsr     r6,r0,0x18          ; r6 = SrcDoor
    ldr     r5,=0x29            ; r5 = NumOfDoors
    ldr     r0,=AreaID
    ldrb    r7,[r0]             ; r7 = AreaID
    ldr     r4,=0x83601D0       ; r4 = EventDataOffset
@@Loop:
    ldrb    r0,[r4]             ; r0 = CurrAreaID
    cmp     r7,r0
    bne     @@Continue          ; if AreaID == CurrAreaID
    ldrb    r0,[r4,1]               ; r0 = CurrSrcDoor
    cmp     r6,r0
    bne     @@Continue              ; if SrcDoor == CurrSrcDoor
    ldrb    r1,[r4,2]                   ; r1 = Event
    mov     r0,3                        ; r3 = 3 (parameter)
    bl      0x80608BC                   ; EventFunctions
    cmp     r0,0
    beq     @@Continue                  ; if event has occurred
    ldrb    r0,[r4,3]                       ; r0 = CurrDstDoor
    b       @@Return

    ; necessary so that data pointer has same offset
    .dh 0,0,0,0,0,0,0
    .pool
@@Continue:
    add     r4,4                ; CurrDataOffset += 4
    sub     r5,1                ; NumOfDoors--
    cmp     r5,0
    bgt     @@Loop              ; if NumOfDoors <= 0
    mov     r0,0xFF                 ; return 0xFF, else repeat
@@Return:
    pop     r3
    mov     r8,r3
    pop     r4-r7
    pop     r1
    bx      r1


.close
