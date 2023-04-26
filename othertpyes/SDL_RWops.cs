namespace DeafMan1983.Interop.SDL3;

using System.Runtime.InteropServices;
using static DeafMan1983.Interop.SDL3.SDL3;

public unsafe partial struct SDL_RWops
{
    public readonly void* Value;

    public SDL_RWops(void* value)
    {
        Value = value;
    }

    public static SDL_RWops NULL => new SDL_RWops(null);

    public static bool operator ==(SDL_RWops left, SDL_RWops right) => left.Value == right.Value;

    public static bool operator !=(SDL_RWops left, SDL_RWops right) => left.Value != right.Value;

    public static bool operator <(SDL_RWops left, SDL_RWops right) => left.Value < right.Value;

    public static bool operator <=(SDL_RWops left, SDL_RWops right) => left.Value <= right.Value;

    public static bool operator >(SDL_RWops left, SDL_RWops right) => left.Value > right.Value;

    public static bool operator >=(SDL_RWops left, SDL_RWops right) => left.Value >= right.Value;

    public static explicit operator SDL_RWops(void* value) => new SDL_RWops(value);

    public static implicit operator void*(SDL_RWops value) => value.Value;

    public static explicit operator SDL_RWops(byte value) => new SDL_RWops((void*)(value));

    public static explicit operator byte(SDL_RWops value) => (byte)(value.Value);

    public static explicit operator SDL_RWops(short value) => new SDL_RWops((void*)(value));

    public static explicit operator short(SDL_RWops value) => (short)(value.Value);

    public static explicit operator SDL_RWops(int value) => new SDL_RWops((void*)(value));

    public static explicit operator int(SDL_RWops value) => (int)(value.Value);

    public static explicit operator SDL_RWops(long value) => new SDL_RWops((void*)(value));

    public static explicit operator long(SDL_RWops value) => (long)(value.Value);

    public static explicit operator SDL_RWops(nint value) => new SDL_RWops((void*)(value));

    public static implicit operator nint(SDL_RWops value) => (nint)(value.Value);

    public static explicit operator SDL_RWops(sbyte value) => new SDL_RWops((void*)(value));

    public static explicit operator sbyte(SDL_RWops value) => (sbyte)(value.Value);

    public static explicit operator SDL_RWops(ushort value) => new SDL_RWops((void*)(value));

    public static explicit operator ushort(SDL_RWops value) => (ushort)(value.Value);

    public static explicit operator SDL_RWops(uint value) => new SDL_RWops((void*)(value));

    public static explicit operator uint(SDL_RWops value) => (uint)(value.Value);

    public static explicit operator SDL_RWops(ulong value) => new SDL_RWops((void*)(value));

    public static explicit operator ulong(SDL_RWops value) => (ulong)(value.Value);

    public static explicit operator SDL_RWops(nuint value) => new SDL_RWops((void*)(value));

    public static implicit operator nuint(SDL_RWops value) => (nuint)(value.Value);

    public int CompareTo(object? obj)
    {
        if (obj is SDL_RWops other)
        {
            return CompareTo(other);
        }

        return (obj is null) ? 1 : throw new ArgumentException("obj is not an instance of SDL_RWops.");
    }

    public int CompareTo(SDL_RWops other) => ((nuint)(Value)).CompareTo((nuint)(other.Value));

    public override bool Equals(object? obj) => (obj is SDL_RWops other) && Equals(other);

    public bool Equals(SDL_RWops other) => ((nuint)(Value)).Equals((nuint)(other.Value));

    public override int GetHashCode() => ((nuint)(Value)).GetHashCode();

    public override string ToString() => ((nuint)(Value)).ToString((sizeof(nint) == 4) ? "X8" : "X16");

    public string ToString(string? format, IFormatProvider? formatProvider) => ((nuint)(Value)).ToString(format, formatProvider);

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
            public SDL_bool autoclose;

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