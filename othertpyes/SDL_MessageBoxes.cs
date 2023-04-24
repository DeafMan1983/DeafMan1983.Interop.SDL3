using System;
using System.Runtime.InteropServices;

namespace DeafMan1983.Interop.SDL3;

public unsafe partial struct SDL_MessageBoxButtonData
{
    [NativeTypeName("Uint32")]
    public uint flags;

    public int buttonid;

    [NativeTypeName("const char *")]
    public sbyte* text;
}

public partial struct SDL_MessageBoxColor
{
    [NativeTypeName("Uint8")]
    public byte r;

    [NativeTypeName("Uint8")]
    public byte g;

    [NativeTypeName("Uint8")]
    public byte b;
}

public partial struct SDL_MessageBoxColorScheme
{
    [NativeTypeName("SDL_MessageBoxColor[5]")]
    public _colors_e__FixedBuffer colors;

    public partial struct _colors_e__FixedBuffer
    {
        public SDL_MessageBoxColor e0;
        public SDL_MessageBoxColor e1;
        public SDL_MessageBoxColor e2;
        public SDL_MessageBoxColor e3;
        public SDL_MessageBoxColor e4;

        public ref SDL_MessageBoxColor this[int index]
        {
            get
            {
                return ref AsSpan()[index];
            }
        }

        public Span<SDL_MessageBoxColor> AsSpan() => MemoryMarshal.CreateSpan(ref e0, 5);
    }
}

public unsafe partial struct SDL_MessageBoxData
{
    [NativeTypeName("Uint32")]
    public uint flags;

    public SDL_Window* window;

    [NativeTypeName("const char *")]
    public sbyte* title;

    [NativeTypeName("const char *")]
    public sbyte* message;

    public int numbuttons;

    [NativeTypeName("const SDL_MessageBoxButtonData *")]
    public SDL_MessageBoxButtonData* buttons;

    [NativeTypeName("const SDL_MessageBoxColorScheme *")]
    public SDL_MessageBoxColorScheme* colorScheme;
}