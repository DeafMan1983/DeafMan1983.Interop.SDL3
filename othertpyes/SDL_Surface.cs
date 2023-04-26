namespace DeafMan1983.Interop.SDL3;

public unsafe partial struct SDL_Surface
{
    public readonly void* Value;

    public SDL_Surface(void* value)
    {
        Value = value;
    }

    public static SDL_Surface NULL => new SDL_Surface(null);

    public static bool operator ==(SDL_Surface left, SDL_Surface right) => left.Value == right.Value;

    public static bool operator !=(SDL_Surface left, SDL_Surface right) => left.Value != right.Value;

    public static bool operator <(SDL_Surface left, SDL_Surface right) => left.Value < right.Value;

    public static bool operator <=(SDL_Surface left, SDL_Surface right) => left.Value <= right.Value;

    public static bool operator >(SDL_Surface left, SDL_Surface right) => left.Value > right.Value;

    public static bool operator >=(SDL_Surface left, SDL_Surface right) => left.Value >= right.Value;

    public static explicit operator SDL_Surface(void* value) => new SDL_Surface(value);

    public static implicit operator void*(SDL_Surface value) => value.Value;

    public static explicit operator SDL_Surface(byte value) => new SDL_Surface((void*)(value));

    public static explicit operator byte(SDL_Surface value) => (byte)(value.Value);

    public static explicit operator SDL_Surface(short value) => new SDL_Surface((void*)(value));

    public static explicit operator short(SDL_Surface value) => (short)(value.Value);

    public static explicit operator SDL_Surface(int value) => new SDL_Surface((void*)(value));

    public static explicit operator int(SDL_Surface value) => (int)(value.Value);

    public static explicit operator SDL_Surface(long value) => new SDL_Surface((void*)(value));

    public static explicit operator long(SDL_Surface value) => (long)(value.Value);

    public static explicit operator SDL_Surface(nint value) => new SDL_Surface((void*)(value));

    public static implicit operator nint(SDL_Surface value) => (nint)(value.Value);

    public static explicit operator SDL_Surface(sbyte value) => new SDL_Surface((void*)(value));

    public static explicit operator sbyte(SDL_Surface value) => (sbyte)(value.Value);

    public static explicit operator SDL_Surface(ushort value) => new SDL_Surface((void*)(value));

    public static explicit operator ushort(SDL_Surface value) => (ushort)(value.Value);

    public static explicit operator SDL_Surface(uint value) => new SDL_Surface((void*)(value));

    public static explicit operator uint(SDL_Surface value) => (uint)(value.Value);

    public static explicit operator SDL_Surface(ulong value) => new SDL_Surface((void*)(value));

    public static explicit operator ulong(SDL_Surface value) => (ulong)(value.Value);

    public static explicit operator SDL_Surface(nuint value) => new SDL_Surface((void*)(value));

    public static implicit operator nuint(SDL_Surface value) => (nuint)(value.Value);

    public int CompareTo(object? obj)
    {
        if (obj is SDL_Surface other)
        {
            return CompareTo(other);
        }

        return (obj is null) ? 1 : throw new ArgumentException("obj is not an instance of SDL_Surface.");
    }

    public int CompareTo(SDL_Surface other) => ((nuint)(Value)).CompareTo((nuint)(other.Value));

    public override bool Equals(object? obj) => (obj is SDL_Surface other) && Equals(other);

    public bool Equals(SDL_Surface other) => ((nuint)(Value)).Equals((nuint)(other.Value));

    public override int GetHashCode() => ((nuint)(Value)).GetHashCode();

    public override string ToString() => ((nuint)(Value)).ToString((sizeof(nint) == 4) ? "X8" : "X16");

    public string ToString(string? format, IFormatProvider? formatProvider) => ((nuint)(Value)).ToString(format, formatProvider);


    [NativeTypeName("Uint32")]
    public uint flags;

    public SDL_PixelFormat* format;

    public int w;

    public int h;

    public int pitch;

    public void* pixels;

    public void* userdata;

    public int locked;

    public void* list_blitmap;

    public SDL_Rect clip_rect;

    public SDL_BlitMap* map;

    public int refcount;
}

public unsafe partial struct SDL_BlitMap
{
    public readonly void* Value;

    public SDL_BlitMap(void* value)
    {
        Value = value;
    }

    public static SDL_BlitMap NULL => new SDL_BlitMap(null);

    public static bool operator ==(SDL_BlitMap left, SDL_BlitMap right) => left.Value == right.Value;

    public static bool operator !=(SDL_BlitMap left, SDL_BlitMap right) => left.Value != right.Value;

    public static bool operator <(SDL_BlitMap left, SDL_BlitMap right) => left.Value < right.Value;

    public static bool operator <=(SDL_BlitMap left, SDL_BlitMap right) => left.Value <= right.Value;

    public static bool operator >(SDL_BlitMap left, SDL_BlitMap right) => left.Value > right.Value;

    public static bool operator >=(SDL_BlitMap left, SDL_BlitMap right) => left.Value >= right.Value;

    public static explicit operator SDL_BlitMap(void* value) => new SDL_BlitMap(value);

    public static implicit operator void*(SDL_BlitMap value) => value.Value;

    public static explicit operator SDL_BlitMap(byte value) => new SDL_BlitMap((void*)(value));

    public static explicit operator byte(SDL_BlitMap value) => (byte)(value.Value);

    public static explicit operator SDL_BlitMap(short value) => new SDL_BlitMap((void*)(value));

    public static explicit operator short(SDL_BlitMap value) => (short)(value.Value);

    public static explicit operator SDL_BlitMap(int value) => new SDL_BlitMap((void*)(value));

    public static explicit operator int(SDL_BlitMap value) => (int)(value.Value);

    public static explicit operator SDL_BlitMap(long value) => new SDL_BlitMap((void*)(value));

    public static explicit operator long(SDL_BlitMap value) => (long)(value.Value);

    public static explicit operator SDL_BlitMap(nint value) => new SDL_BlitMap((void*)(value));

    public static implicit operator nint(SDL_BlitMap value) => (nint)(value.Value);

    public static explicit operator SDL_BlitMap(sbyte value) => new SDL_BlitMap((void*)(value));

    public static explicit operator sbyte(SDL_BlitMap value) => (sbyte)(value.Value);

    public static explicit operator SDL_BlitMap(ushort value) => new SDL_BlitMap((void*)(value));

    public static explicit operator ushort(SDL_BlitMap value) => (ushort)(value.Value);

    public static explicit operator SDL_BlitMap(uint value) => new SDL_BlitMap((void*)(value));

    public static explicit operator uint(SDL_BlitMap value) => (uint)(value.Value);

    public static explicit operator SDL_BlitMap(ulong value) => new SDL_BlitMap((void*)(value));

    public static explicit operator ulong(SDL_BlitMap value) => (ulong)(value.Value);

    public static explicit operator SDL_BlitMap(nuint value) => new SDL_BlitMap((void*)(value));

    public static implicit operator nuint(SDL_BlitMap value) => (nuint)(value.Value);

    public int CompareTo(object? obj)
    {
        if (obj is SDL_BlitMap other)
        {
            return CompareTo(other);
        }

        return (obj is null) ? 1 : throw new ArgumentException("obj is not an instance of SDL_BlitMap.");
    }

    public int CompareTo(SDL_BlitMap other) => ((nuint)(Value)).CompareTo((nuint)(other.Value));

    public override bool Equals(object? obj) => (obj is SDL_BlitMap other) && Equals(other);

    public bool Equals(SDL_BlitMap other) => ((nuint)(Value)).Equals((nuint)(other.Value));

    public override int GetHashCode() => ((nuint)(Value)).GetHashCode();

    public override string ToString() => ((nuint)(Value)).ToString((sizeof(nint) == 4) ? "X8" : "X16");

    public string ToString(string? format, IFormatProvider? formatProvider) => ((nuint)(Value)).ToString(format, formatProvider);
}