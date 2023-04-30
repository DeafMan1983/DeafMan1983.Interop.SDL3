namespace DeafMan1983.Interop.SDL3;

using System.Runtime.InteropServices;
using static DeafMan1983.Interop.SDL3.SDL3;

public unsafe partial struct SDL_RWops
{
    [NativeTypeName("Sint64 (*)(struct SDL_RWops *)")]
    public delegate* unmanaged[Cdecl]<SDL_RWops*, nint> size;

    [NativeTypeName("Sint64 (*)(struct SDL_RWops *, Sint64, int)")]
    public delegate* unmanaged[Cdecl]<SDL_RWops*, nint, int, nint> seek;

    [NativeTypeName("Sint64 (*)(struct SDL_RWops *, void *, Sint64)")]
    public delegate* unmanaged[Cdecl]<SDL_RWops*, void*, nint, nint> read;

    [NativeTypeName("Sint64 (*)(struct SDL_RWops *, const void *, Sint64)")]
    public delegate* unmanaged[Cdecl]<SDL_RWops*, void*, nint, nint> write;

    [NativeTypeName("int (*)(struct SDL_RWops *)")]
    public delegate* unmanaged[Cdecl]<SDL_RWops*, int> close;

    [NativeTypeName("Uint32")]
    public uint type;

    [NativeTypeName("union (anonymous union at /usr/include/SDL3/SDL_rwops.h:104:5)")]
    public _hidden_e__Union hidden;

    [StructLayout(LayoutKind.Explicit)]
    public partial struct _hidden_e__Union
    {
        [FieldOffset(0)]
        [NativeTypeName("struct (anonymous struct at /usr/include/SDL3/SDL_rwops.h:125:9)")]
        public _stdio_e__Struct stdio;

        [FieldOffset(0)]
        [NativeTypeName("struct (anonymous struct at /usr/include/SDL3/SDL_rwops.h:131:9)")]
        public _mem_e__Struct mem;

        [FieldOffset(0)]
        [NativeTypeName("struct (anonymous struct at /usr/include/SDL3/SDL_rwops.h:137:9)")]
        public _unknown_e__Struct unknown;

        public unsafe partial struct _stdio_e__Struct
        {
            public int autoclose;

            public void* fp;
        }

        public unsafe partial struct _mem_e__Struct
        {
            [NativeTypeName("Uint8 *")]
            public byte* @base;

            [NativeTypeName("Uint8 *")]
            public byte* here;

            [NativeTypeName("Uint8 *")]
            public byte* stop;
        }

        public unsafe partial struct _unknown_e__Struct
        {
            public void* data1;

            public void* data2;
        }
    }
}