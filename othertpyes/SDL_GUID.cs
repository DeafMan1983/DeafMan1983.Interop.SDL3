namespace DeafMan1983.Interop.SDL3;

public unsafe partial struct SDL_GUID
{
    [NativeTypeName("Uint8[16]")]
    public fixed byte data[16];
}