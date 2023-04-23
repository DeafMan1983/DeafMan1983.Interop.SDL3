namespace DeafMan1983.Interop.SDL3;

using static DeafMan1983.Interop.SDL3.SDL3;
public partial struct SDL_Keysym
{
    public uint scancode;

    [NativeTypeName("SDL_Keycode")]
    public SDL_KeyCode sym;

    [NativeTypeName("Uint16")]
    public ushort mod;

    [NativeTypeName("Uint32")]
    public uint unused;
}