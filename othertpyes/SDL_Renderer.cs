namespace DeafMan1983.Interop.SDL3;

public unsafe partial struct SDL_Renderer
{
    public readonly void* Value;

    public SDL_Renderer(void* value)
    {
        Value = value;
    }

    public static SDL_Renderer NULL => new SDL_Renderer(null);

    public static bool operator ==(SDL_Renderer left, SDL_Renderer right) => left.Value == right.Value;

    public static bool operator !=(SDL_Renderer left, SDL_Renderer right) => left.Value != right.Value;

    public static bool operator <(SDL_Renderer left, SDL_Renderer right) => left.Value < right.Value;

    public static bool operator <=(SDL_Renderer left, SDL_Renderer right) => left.Value <= right.Value;

    public static bool operator >(SDL_Renderer left, SDL_Renderer right) => left.Value > right.Value;

    public static bool operator >=(SDL_Renderer left, SDL_Renderer right) => left.Value >= right.Value;

    public static explicit operator SDL_Renderer(void* value) => new SDL_Renderer(value);

    public static implicit operator void*(SDL_Renderer value) => value.Value;

    public static explicit operator SDL_Renderer(byte value) => new SDL_Renderer((void*)(value));

    public static explicit operator byte(SDL_Renderer value) => (byte)(value.Value);

    public static explicit operator SDL_Renderer(short value) => new SDL_Renderer((void*)(value));

    public static explicit operator short(SDL_Renderer value) => (short)(value.Value);

    public static explicit operator SDL_Renderer(int value) => new SDL_Renderer((void*)(value));

    public static explicit operator int(SDL_Renderer value) => (int)(value.Value);

    public static explicit operator SDL_Renderer(long value) => new SDL_Renderer((void*)(value));

    public static explicit operator long(SDL_Renderer value) => (long)(value.Value);

    public static explicit operator SDL_Renderer(nint value) => new SDL_Renderer((void*)(value));

    public static implicit operator nint(SDL_Renderer value) => (nint)(value.Value);

    public static explicit operator SDL_Renderer(sbyte value) => new SDL_Renderer((void*)(value));

    public static explicit operator sbyte(SDL_Renderer value) => (sbyte)(value.Value);

    public static explicit operator SDL_Renderer(ushort value) => new SDL_Renderer((void*)(value));

    public static explicit operator ushort(SDL_Renderer value) => (ushort)(value.Value);

    public static explicit operator SDL_Renderer(uint value) => new SDL_Renderer((void*)(value));

    public static explicit operator uint(SDL_Renderer value) => (uint)(value.Value);

    public static explicit operator SDL_Renderer(ulong value) => new SDL_Renderer((void*)(value));

    public static explicit operator ulong(SDL_Renderer value) => (ulong)(value.Value);

    public static explicit operator SDL_Renderer(nuint value) => new SDL_Renderer((void*)(value));

    public static implicit operator nuint(SDL_Renderer value) => (nuint)(value.Value);

    public int CompareTo(object? obj)
    {
        if (obj is SDL_Renderer other)
        {
            return CompareTo(other);
        }

        return (obj is null) ? 1 : throw new ArgumentException("obj is not an instance of SDL_Renderer.");
    }

    public int CompareTo(SDL_Renderer other) => ((nuint)(Value)).CompareTo((nuint)(other.Value));

    public override bool Equals(object? obj) => (obj is SDL_Renderer other) && Equals(other);

    public bool Equals(SDL_Renderer other) => ((nuint)(Value)).Equals((nuint)(other.Value));

    public override int GetHashCode() => ((nuint)(Value)).GetHashCode();

    public override string ToString() => ((nuint)(Value)).ToString((sizeof(nint) == 4) ? "X8" : "X16");

    public string ToString(string? format, IFormatProvider? formatProvider) => ((nuint)(Value)).ToString(format, formatProvider);
}