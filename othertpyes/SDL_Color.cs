namespace DeafMan1983.Interop.SDL3;

public partial struct SDL_Color
{
    [NativeTypeName("Uint8")]
    public byte r;

    [NativeTypeName("Uint8")]
    public byte g;

    [NativeTypeName("Uint8")]
    public byte b;

    [NativeTypeName("Uint8")]
    public byte a;
}