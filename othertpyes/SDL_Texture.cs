namespace DeafMan1983.Interop.SDL3;

public unsafe partial struct SDL_Texture
{
    public readonly void* Value;

    public SDL_Texture(void* value)
    {
        Value = value;
    }

    public static SDL_Texture NULL => new SDL_Texture(null);

    public static bool operator ==(SDL_Texture left, SDL_Texture right) => left.Value == right.Value;

    public static bool operator !=(SDL_Texture left, SDL_Texture right) => left.Value != right.Value;

    public static bool operator <(SDL_Texture left, SDL_Texture right) => left.Value < right.Value;

    public static bool operator <=(SDL_Texture left, SDL_Texture right) => left.Value <= right.Value;

    public static bool operator >(SDL_Texture left, SDL_Texture right) => left.Value > right.Value;

    public static bool operator >=(SDL_Texture left, SDL_Texture right) => left.Value >= right.Value;

    public static explicit operator SDL_Texture(void* value) => new SDL_Texture(value);

    public static implicit operator void*(SDL_Texture value) => value.Value;

    public static explicit operator SDL_Texture(byte value) => new SDL_Texture((void*)(value));

    public static explicit operator byte(SDL_Texture value) => (byte)(value.Value);

    public static explicit operator SDL_Texture(short value) => new SDL_Texture((void*)(value));

    public static explicit operator short(SDL_Texture value) => (short)(value.Value);

    public static explicit operator SDL_Texture(int value) => new SDL_Texture((void*)(value));

    public static explicit operator int(SDL_Texture value) => (int)(value.Value);

    public static explicit operator SDL_Texture(long value) => new SDL_Texture((void*)(value));

    public static explicit operator long(SDL_Texture value) => (long)(value.Value);

    public static explicit operator SDL_Texture(nint value) => new SDL_Texture((void*)(value));

    public static implicit operator nint(SDL_Texture value) => (nint)(value.Value);

    public static explicit operator SDL_Texture(sbyte value) => new SDL_Texture((void*)(value));

    public static explicit operator sbyte(SDL_Texture value) => (sbyte)(value.Value);

    public static explicit operator SDL_Texture(ushort value) => new SDL_Texture((void*)(value));

    public static explicit operator ushort(SDL_Texture value) => (ushort)(value.Value);

    public static explicit operator SDL_Texture(uint value) => new SDL_Texture((void*)(value));

    public static explicit operator uint(SDL_Texture value) => (uint)(value.Value);

    public static explicit operator SDL_Texture(ulong value) => new SDL_Texture((void*)(value));

    public static explicit operator ulong(SDL_Texture value) => (ulong)(value.Value);

    public static explicit operator SDL_Texture(nuint value) => new SDL_Texture((void*)(value));

    public static implicit operator nuint(SDL_Texture value) => (nuint)(value.Value);

    public int CompareTo(object? obj)
    {
        if (obj is SDL_Texture other)
        {
            return CompareTo(other);
        }

        return (obj is null) ? 1 : throw new ArgumentException("obj is not an instance of SDL_Texture.");
    }

    public int CompareTo(SDL_Texture other) => ((nuint)(Value)).CompareTo((nuint)(other.Value));

    public override bool Equals(object? obj) => (obj is SDL_Texture other) && Equals(other);

    public bool Equals(SDL_Texture other) => ((nuint)(Value)).Equals((nuint)(other.Value));

    public override int GetHashCode() => ((nuint)(Value)).GetHashCode();

    public override string ToString() => ((nuint)(Value)).ToString((sizeof(nint) == 4) ? "X8" : "X16");

    public string ToString(string? format, IFormatProvider? formatProvider) => ((nuint)(Value)).ToString(format, formatProvider);
}