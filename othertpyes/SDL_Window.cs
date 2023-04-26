namespace DeafMan1983.Interop.SDL3;

public unsafe partial struct SDL_Window
{
    public readonly void* Value;

    public SDL_Window(void* value)
    {
        Value = value;
    }

    public static SDL_Window NULL => new SDL_Window(null);

    public static bool operator ==(SDL_Window left, SDL_Window right) => left.Value == right.Value;

    public static bool operator !=(SDL_Window left, SDL_Window right) => left.Value != right.Value;

    public static bool operator <(SDL_Window left, SDL_Window right) => left.Value < right.Value;

    public static bool operator <=(SDL_Window left, SDL_Window right) => left.Value <= right.Value;

    public static bool operator >(SDL_Window left, SDL_Window right) => left.Value > right.Value;

    public static bool operator >=(SDL_Window left, SDL_Window right) => left.Value >= right.Value;

    public static explicit operator SDL_Window(void* value) => new SDL_Window(value);

    public static implicit operator void*(SDL_Window value) => value.Value;

    public static explicit operator SDL_Window(byte value) => new SDL_Window((void*)(value));

    public static explicit operator byte(SDL_Window value) => (byte)(value.Value);

    public static explicit operator SDL_Window(short value) => new SDL_Window((void*)(value));

    public static explicit operator short(SDL_Window value) => (short)(value.Value);

    public static explicit operator SDL_Window(int value) => new SDL_Window((void*)(value));

    public static explicit operator int(SDL_Window value) => (int)(value.Value);

    public static explicit operator SDL_Window(long value) => new SDL_Window((void*)(value));

    public static explicit operator long(SDL_Window value) => (long)(value.Value);

    public static explicit operator SDL_Window(nint value) => new SDL_Window((void*)(value));

    public static implicit operator nint(SDL_Window value) => (nint)(value.Value);

    public static explicit operator SDL_Window(sbyte value) => new SDL_Window((void*)(value));

    public static explicit operator sbyte(SDL_Window value) => (sbyte)(value.Value);

    public static explicit operator SDL_Window(ushort value) => new SDL_Window((void*)(value));

    public static explicit operator ushort(SDL_Window value) => (ushort)(value.Value);

    public static explicit operator SDL_Window(uint value) => new SDL_Window((void*)(value));

    public static explicit operator uint(SDL_Window value) => (uint)(value.Value);

    public static explicit operator SDL_Window(ulong value) => new SDL_Window((void*)(value));

    public static explicit operator ulong(SDL_Window value) => (ulong)(value.Value);

    public static explicit operator SDL_Window(nuint value) => new SDL_Window((void*)(value));

    public static implicit operator nuint(SDL_Window value) => (nuint)(value.Value);

    public int CompareTo(object? obj)
    {
        if (obj is SDL_Window other)
        {
            return CompareTo(other);
        }

        return (obj is null) ? 1 : throw new ArgumentException("obj is not an instance of SDL_Window.");
    }

    public int CompareTo(SDL_Window other) => ((nuint)(Value)).CompareTo((nuint)(other.Value));

    public override bool Equals(object? obj) => (obj is SDL_Window other) && Equals(other);

    public bool Equals(SDL_Window other) => ((nuint)(Value)).Equals((nuint)(other.Value));

    public override int GetHashCode() => ((nuint)(Value)).GetHashCode();

    public override string ToString() => ((nuint)(Value)).ToString((sizeof(nint) == 4) ? "X8" : "X16");

    public string ToString(string? format, IFormatProvider? formatProvider) => ((nuint)(Value)).ToString(format, formatProvider);
}