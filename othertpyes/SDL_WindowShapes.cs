namespace DeafMan1983.Interop.SDL3;

using System.Runtime.InteropServices;
using static DeafMan1983.Interop.SDL3.SDL3;

[StructLayout(LayoutKind.Explicit)]
public partial struct SDL_WindowShapeParams
{
    [FieldOffset(0)]
    [NativeTypeName("Uint8")]
    public byte binarizationCutoff;

    [FieldOffset(0)]
    public SDL_Color colorKey;
}

public partial struct SDL_WindowShapeMode
{
    public WindowShapeMode mode;

    public SDL_WindowShapeParams parameters;
}