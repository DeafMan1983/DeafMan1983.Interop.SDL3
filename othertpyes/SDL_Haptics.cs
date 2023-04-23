namespace DeafMan1983.Interop.SDL3;

using System.Runtime.InteropServices;
using static DeafMan1983.Interop.SDL3.SDL3;

public partial struct SDL_Haptic
{
}

public unsafe partial struct SDL_HapticDirection
{
    [NativeTypeName("Uint8")]
    public byte type;

    [NativeTypeName("Sint32[3]")]
    public fixed int dir[3];
}

public partial struct SDL_HapticConstant
{
    [NativeTypeName("Uint16")]
    public ushort type;

    public SDL_HapticDirection direction;

    [NativeTypeName("Uint32")]
    public uint length;

    [NativeTypeName("Uint16")]
    public ushort delay;

    [NativeTypeName("Uint16")]
    public ushort button;

    [NativeTypeName("Uint16")]
    public ushort interval;

    [NativeTypeName("Sint16")]
    public short level;

    [NativeTypeName("Uint16")]
    public ushort attack_length;

    [NativeTypeName("Uint16")]
    public ushort attack_level;

    [NativeTypeName("Uint16")]
    public ushort fade_length;

    [NativeTypeName("Uint16")]
    public ushort fade_level;
}

public partial struct SDL_HapticPeriodic
{
    [NativeTypeName("Uint16")]
    public ushort type;

    public SDL_HapticDirection direction;

    [NativeTypeName("Uint32")]
    public uint length;

    [NativeTypeName("Uint16")]
    public ushort delay;

    [NativeTypeName("Uint16")]
    public ushort button;

    [NativeTypeName("Uint16")]
    public ushort interval;

    [NativeTypeName("Uint16")]
    public ushort period;

    [NativeTypeName("Sint16")]
    public short magnitude;

    [NativeTypeName("Sint16")]
    public short offset;

    [NativeTypeName("Uint16")]
    public ushort phase;

    [NativeTypeName("Uint16")]
    public ushort attack_length;

    [NativeTypeName("Uint16")]
    public ushort attack_level;

    [NativeTypeName("Uint16")]
    public ushort fade_length;

    [NativeTypeName("Uint16")]
    public ushort fade_level;
}

public unsafe partial struct SDL_HapticCondition
{
    [NativeTypeName("Uint16")]
    public ushort type;

    public SDL_HapticDirection direction;

    [NativeTypeName("Uint32")]
    public uint length;

    [NativeTypeName("Uint16")]
    public ushort delay;

    [NativeTypeName("Uint16")]
    public ushort button;

    [NativeTypeName("Uint16")]
    public ushort interval;

    [NativeTypeName("Uint16[3]")]
    public fixed ushort right_sat[3];

    [NativeTypeName("Uint16[3]")]
    public fixed ushort left_sat[3];

    [NativeTypeName("Sint16[3]")]
    public fixed short right_coeff[3];

    [NativeTypeName("Sint16[3]")]
    public fixed short left_coeff[3];

    [NativeTypeName("Uint16[3]")]
    public fixed ushort deadband[3];

    [NativeTypeName("Sint16[3]")]
    public fixed short center[3];
}

public partial struct SDL_HapticRamp
{
    [NativeTypeName("Uint16")]
    public ushort type;

    public SDL_HapticDirection direction;

    [NativeTypeName("Uint32")]
    public uint length;

    [NativeTypeName("Uint16")]
    public ushort delay;

    [NativeTypeName("Uint16")]
    public ushort button;

    [NativeTypeName("Uint16")]
    public ushort interval;

    [NativeTypeName("Sint16")]
    public short start;

    [NativeTypeName("Sint16")]
    public short end;

    [NativeTypeName("Uint16")]
    public ushort attack_length;

    [NativeTypeName("Uint16")]
    public ushort attack_level;

    [NativeTypeName("Uint16")]
    public ushort fade_length;

    [NativeTypeName("Uint16")]
    public ushort fade_level;
}

public partial struct SDL_HapticLeftRight
{
    [NativeTypeName("Uint16")]
    public ushort type;

    [NativeTypeName("Uint32")]
    public uint length;

    [NativeTypeName("Uint16")]
    public ushort large_magnitude;

    [NativeTypeName("Uint16")]
    public ushort small_magnitude;
}

public unsafe partial struct SDL_HapticCustom
{
    [NativeTypeName("Uint16")]
    public ushort type;

    public SDL_HapticDirection direction;

    [NativeTypeName("Uint32")]
    public uint length;

    [NativeTypeName("Uint16")]
    public ushort delay;

    [NativeTypeName("Uint16")]
    public ushort button;

    [NativeTypeName("Uint16")]
    public ushort interval;

    [NativeTypeName("Uint8")]
    public byte channels;

    [NativeTypeName("Uint16")]
    public ushort period;

    [NativeTypeName("Uint16")]
    public ushort samples;

    [NativeTypeName("Uint16 *")]
    public ushort* data;

    [NativeTypeName("Uint16")]
    public ushort attack_length;

    [NativeTypeName("Uint16")]
    public ushort attack_level;

    [NativeTypeName("Uint16")]
    public ushort fade_length;

    [NativeTypeName("Uint16")]
    public ushort fade_level;
}

[StructLayout(LayoutKind.Explicit)]
public partial struct SDL_HapticEffect
{
    [FieldOffset(0)]
    [NativeTypeName("Uint16")]
    public ushort type;

    [FieldOffset(0)]
    public SDL_HapticConstant constant;

    [FieldOffset(0)]
    public SDL_HapticPeriodic periodic;

    [FieldOffset(0)]
    public SDL_HapticCondition condition;

    [FieldOffset(0)]
    public SDL_HapticRamp ramp;

    [FieldOffset(0)]
    public SDL_HapticLeftRight leftright;

    [FieldOffset(0)]
    public SDL_HapticCustom custom;
}