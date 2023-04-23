namespace DeafMan1983.Interop.SDL3;

public unsafe partial struct SDL_PixelFormat
{
    [NativeTypeName("Uint32")]
    public uint format;

    public SDL_Palette* palette;

    [NativeTypeName("Uint8")]
    public byte BitsPerPixel;

    [NativeTypeName("Uint8")]
    public byte BytesPerPixel;

    [NativeTypeName("Uint8[2]")]
    public fixed byte padding[2];

    [NativeTypeName("Uint32")]
    public uint Rmask;

    [NativeTypeName("Uint32")]
    public uint Gmask;

    [NativeTypeName("Uint32")]
    public uint Bmask;

    [NativeTypeName("Uint32")]
    public uint Amask;

    [NativeTypeName("Uint8")]
    public byte Rloss;

    [NativeTypeName("Uint8")]
    public byte Gloss;

    [NativeTypeName("Uint8")]
    public byte Bloss;

    [NativeTypeName("Uint8")]
    public byte Aloss;

    [NativeTypeName("Uint8")]
    public byte Rshift;

    [NativeTypeName("Uint8")]
    public byte Gshift;

    [NativeTypeName("Uint8")]
    public byte Bshift;

    [NativeTypeName("Uint8")]
    public byte Ashift;

    public int refcount;

    [NativeTypeName("struct SDL_PixelFormat *")]
    public SDL_PixelFormat* next;
}