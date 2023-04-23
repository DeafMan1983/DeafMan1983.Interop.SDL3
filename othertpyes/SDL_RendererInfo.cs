namespace DeafMan1983.Interop.SDL3;

public unsafe partial struct SDL_RendererInfo
{
    [NativeTypeName("const char *")]
    public sbyte* name;

    [NativeTypeName("Uint32")]
    public uint flags;

    [NativeTypeName("Uint32")]
    public uint num_texture_formats;

    [NativeTypeName("Uint32[16]")]
    public fixed uint texture_formats[16];

    public int max_texture_width;

    public int max_texture_height;
}