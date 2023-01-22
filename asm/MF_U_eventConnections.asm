.gba
.open "MF_U.gba","MF_U_eventConnections.gba",0x8000000

.definelabel AreaID,0x300002C
.definelabel EventCounter,0x3000B87

.org 0x8069508
    ; r0 = math
    ; r1 = EventDataOffset
    ; r2 = NumOfDoors
    ; r3 = AreaID
    ; r4 = SrcDoor
    ; r5 = Event
    push    r3-r7,r14
    mov     r7,r8
    push    r7
    lsl     r0,r0,0x18
    lsr     r0,r0,0x18
    mov     r4,r0               ; r4 = SrcDoor
    ldr     r2,=0x3C            ; r2 = NumOfDoors
    ldr     r1,=0x83C8C68       ; r1 = EventDataOffset
    ldr     r0,=AreaID
    ldrb    r3,[r0]             ; r3 = AreaID
    ldr     r0,=EventCounter
    ldrb    r5,[r0]             ; r5 = Event
@@Loop:
    ldrb    r0,[r1]             ; r0 = CurrAreaID
    cmp     r3,r0
    bne     @@Continue          ; if AreaID == CurrAreaID
    ldrb    r0,[r1,1]               ; r0 = CurrSrcDoor
    cmp     r4,r0
    bne     @@Continue              ; if SrcDoor == CurrSrcDoor
    ldrb    r0,[r1,2]                   ; r0 = DoorEvent
    cmp     r5,r0
    bcc     @@Continue                  ; if Event >= CurrEvent
    ldrb    r0,[r1,3]                       ; r0 = CurrDstDoor
    b       @@Return                        ; return

    ; necessary so that data pointer has same offset
    .dh 0,0,0,0,0,0,0,0
    .pool
@@Continue:
    add     r1,4                ; CurrDataOffset += 4
    sub     r2,1                ; NumOfDoors--
    cmp     r2,0
    bgt     @@Loop              ; if NumOfDoors <= 0
    mov     r0,0xFF                 ; return 0xFF, else repeat
@@Return:
    pop     r2
    mov     r8,r2
    pop     r3-r7
    pop     r1
    bx      r1


.close
