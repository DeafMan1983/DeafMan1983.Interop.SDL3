namespace DeafMan1983.Interop.SDL3;

public unsafe partial struct SDL_Joystick
{

}

public unsafe partial struct SDL_VirtualJoystickDesc
{
    [NativeTypeName("Uint16")]
    public ushort version;

    [NativeTypeName("Uint16")]
    public ushort type;

    [NativeTypeName("Uint16")]
    public ushort naxes;

    [NativeTypeName("Uint16")]
    public ushort nbuttons;

    [NativeTypeName("Uint16")]
    public ushort nhats;

    [NativeTypeName("Uint16")]
    public ushort vendor_id;

    [NativeTypeName("Uint16")]
    public ushort product_id;

    [NativeTypeName("Uint16")]
    public ushort padding;

    [NativeTypeName("Uint32")]
    public uint button_mask;

    [NativeTypeName("Uint32")]
    public uint axis_mask;

    [NativeTypeName("const char *")]
    public sbyte* name;

    public void* userdata;

    [NativeTypeName("void (*)(void *)")]
    public delegate* unmanaged[Cdecl]<void*, void> Update;

    [NativeTypeName("void (*)(void *, int)")]
    public delegate* unmanaged[Cdecl]<void*, int, void> SetPlayerIndex;

    [NativeTypeName("int (*)(void *, Uint16, Uint16)")]
    public delegate* unmanaged[Cdecl]<void*, ushort, ushort, int> Rumble;

    [NativeTypeName("int (*)(void *, Uint16, Uint16)")]
    public delegate* unmanaged[Cdecl]<void*, ushort, ushort, int> RumbleTriggers;

    [NativeTypeName("int (*)(void *, Uint8, Uint8, Uint8)")]
    public delegate* unmanaged[Cdecl]<void*, byte, byte, byte, int> SetLED;

    [NativeTypeName("int (*)(void *, const void *, int)")]
    public delegate* unmanaged[Cdecl]<void*, void*, int, int> SendEffect;
}