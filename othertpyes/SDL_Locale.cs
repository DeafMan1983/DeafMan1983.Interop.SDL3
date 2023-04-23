namespace DeafMan1983.Interop.SDL3;

public unsafe partial struct SDL_Locale
{
    [NativeTypeName("const char *")]
    public sbyte* language;

    [NativeTypeName("const char *")]
    public sbyte* country;
}