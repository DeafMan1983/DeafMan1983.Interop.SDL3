namespace DeafMan1983.Interop.SDL3;

using System.Runtime.InteropServices;

using static DeafMan1983.Interop.SDL3.SDL3;

public partial struct SDL_CommonEvent
{
    [NativeTypeName("Uint32")]
    public SDL_EventType type;

    [NativeTypeName("Uint64")]
    public nuint timestamp;
}

public partial struct SDL_DisplayEvent
{
    [NativeTypeName("Uint32")]
    public SDL_EventType type;

    [NativeTypeName("Uint64")]
    public nuint timestamp;

    [NativeTypeName("SDL_DisplayID")]
    public uint displayID;

    [NativeTypeName("Sint32")]
    public int data1;
}

public partial struct SDL_WindowEvent
{
    [NativeTypeName("Uint32")]
    public SDL_EventType type;

    [NativeTypeName("Uint64")]
    public nuint timestamp;

    [NativeTypeName("SDL_WindowID")]
    public uint windowID;

    [NativeTypeName("Sint32")]
    public int data1;

    [NativeTypeName("Sint32")]
    public int data2;
}

public partial struct SDL_KeyboardEvent
{
    [NativeTypeName("Uint32")]
    public SDL_EventType type;

    [NativeTypeName("Uint64")]
    public nuint timestamp;

    [NativeTypeName("SDL_WindowID")]
    public uint windowID;

    [NativeTypeName("Uint8")]
    public byte state;

    [NativeTypeName("Uint8")]
    public byte repeat;

    [NativeTypeName("Uint8")]
    public byte padding2;

    [NativeTypeName("Uint8")]
    public byte padding3;

    public SDL_Keysym keysym;
}

public unsafe partial struct SDL_TextEditingEvent
{
    [NativeTypeName("Uint32")]
    public SDL_EventType type;

    [NativeTypeName("Uint64")]
    public nuint timestamp;

    [NativeTypeName("SDL_WindowID")]
    public uint windowID;

    [NativeTypeName("char[32]")]
    public fixed sbyte text[32];

    [NativeTypeName("Sint32")]
    public int start;

    [NativeTypeName("Sint32")]
    public int length;
}

public unsafe partial struct SDL_TextEditingExtEvent
{
    [NativeTypeName("Uint32")]
    public SDL_EventType type;

    [NativeTypeName("Uint64")]
    public nuint timestamp;

    [NativeTypeName("SDL_WindowID")]
    public uint windowID;

    [NativeTypeName("char *")]
    public sbyte* text;

    [NativeTypeName("Sint32")]
    public int start;

    [NativeTypeName("Sint32")]
    public int length;
}

public unsafe partial struct SDL_TextInputEvent
{
    [NativeTypeName("Uint32")]
    public SDL_EventType type;

    [NativeTypeName("Uint64")]
    public nuint timestamp;

    [NativeTypeName("SDL_WindowID")]
    public uint windowID;

    [NativeTypeName("char[32]")]
    public fixed sbyte text[32];
}

public partial struct SDL_MouseMotionEvent
{
    [NativeTypeName("Uint32")]
    public SDL_EventType type;

    [NativeTypeName("Uint64")]
    public nuint timestamp;

    [NativeTypeName("SDL_WindowID")]
    public uint windowID;

    [NativeTypeName("SDL_MouseID")]
    public uint which;

    [NativeTypeName("Uint32")]
    public uint state;

    public float x;

    public float y;

    public float xrel;

    public float yrel;
}

public partial struct SDL_MouseButtonEvent
{
    [NativeTypeName("Uint32")]
    public SDL_EventType type;

    [NativeTypeName("Uint64")]
    public nuint timestamp;

    [NativeTypeName("SDL_WindowID")]
    public uint windowID;

    [NativeTypeName("SDL_MouseID")]
    public uint which;

    [NativeTypeName("Uint8")]
    public byte button;

    [NativeTypeName("Uint8")]
    public byte state;

    [NativeTypeName("Uint8")]
    public byte clicks;

    [NativeTypeName("Uint8")]
    public byte padding;

    public float x;

    public float y;
}

public partial struct SDL_MouseWheelEvent
{
    [NativeTypeName("Uint32")]
    public SDL_EventType type;

    [NativeTypeName("Uint64")]
    public nuint timestamp;

    [NativeTypeName("SDL_WindowID")]
    public uint windowID;

    [NativeTypeName("SDL_MouseID")]
    public uint which;

    public float x;

    public float y;

    [NativeTypeName("Uint32")]
    public uint direction;

    public float mouseX;

    public float mouseY;
}

public partial struct SDL_JoyAxisEvent
{
    [NativeTypeName("Uint32")]
    public SDL_EventType type;

    [NativeTypeName("Uint64")]
    public nuint timestamp;

    [NativeTypeName("SDL_JoystickID")]
    public uint which;

    [NativeTypeName("Uint8")]
    public byte axis;

    [NativeTypeName("Uint8")]
    public byte padding1;

    [NativeTypeName("Uint8")]
    public byte padding2;

    [NativeTypeName("Uint8")]
    public byte padding3;

    [NativeTypeName("Sint16")]
    public short value;

    [NativeTypeName("Uint16")]
    public ushort padding4;
}

public partial struct SDL_JoyHatEvent
{
    [NativeTypeName("Uint32")]
    public SDL_EventType type;

    [NativeTypeName("Uint64")]
    public nuint timestamp;

    [NativeTypeName("SDL_JoystickID")]
    public uint which;

    [NativeTypeName("Uint8")]
    public byte hat;

    [NativeTypeName("Uint8")]
    public byte value;

    [NativeTypeName("Uint8")]
    public byte padding1;

    [NativeTypeName("Uint8")]
    public byte padding2;
}

public partial struct SDL_JoyButtonEvent
{
    [NativeTypeName("Uint32")]
    public SDL_EventType type;

    [NativeTypeName("Uint64")]
    public nuint timestamp;

    [NativeTypeName("SDL_JoystickID")]
    public uint which;

    [NativeTypeName("Uint8")]
    public byte button;

    [NativeTypeName("Uint8")]
    public byte state;

    [NativeTypeName("Uint8")]
    public byte padding1;

    [NativeTypeName("Uint8")]
    public byte padding2;
}

public partial struct SDL_JoyDeviceEvent
{
    [NativeTypeName("Uint32")]
    public SDL_EventType type;

    [NativeTypeName("Uint64")]
    public nuint timestamp;

    [NativeTypeName("SDL_JoystickID")]
    public uint which;
}

public partial struct SDL_JoyBatteryEvent
{
    [NativeTypeName("Uint32")]
    public SDL_EventType type;

    [NativeTypeName("Uint64")]
    public nuint timestamp;

    [NativeTypeName("SDL_JoystickID")]
    public uint which;

    public SDL_JoystickPowerLevel level;
}

public partial struct SDL_GamepadAxisEvent
{
    [NativeTypeName("Uint32")]
    public SDL_EventType type;

    [NativeTypeName("Uint64")]
    public nuint timestamp;

    [NativeTypeName("SDL_JoystickID")]
    public uint which;

    [NativeTypeName("Uint8")]
    public byte axis;

    [NativeTypeName("Uint8")]
    public byte padding1;

    [NativeTypeName("Uint8")]
    public byte padding2;

    [NativeTypeName("Uint8")]
    public byte padding3;

    [NativeTypeName("Sint16")]
    public short value;

    [NativeTypeName("Uint16")]
    public ushort padding4;
}

public partial struct SDL_GamepadButtonEvent
{
    [NativeTypeName("Uint32")]
    public SDL_EventType type;

    [NativeTypeName("Uint64")]
    public nuint timestamp;

    [NativeTypeName("SDL_JoystickID")]
    public uint which;

    [NativeTypeName("Uint8")]
    public byte button;

    [NativeTypeName("Uint8")]
    public byte state;

    [NativeTypeName("Uint8")]
    public byte padding1;

    [NativeTypeName("Uint8")]
    public byte padding2;
}

public partial struct SDL_GamepadDeviceEvent
{
    [NativeTypeName("Uint32")]
    public SDL_EventType type;

    [NativeTypeName("Uint64")]
    public nuint timestamp;

    [NativeTypeName("SDL_JoystickID")]
    public uint which;
}

public partial struct SDL_GamepadTouchpadEvent
{
    [NativeTypeName("Uint32")]
    public SDL_EventType type;

    [NativeTypeName("Uint64")]
    public nuint timestamp;

    [NativeTypeName("SDL_JoystickID")]
    public uint which;

    [NativeTypeName("Sint32")]
    public int touchpad;

    [NativeTypeName("Sint32")]
    public int finger;

    public float x;

    public float y;

    public float pressure;
}

public unsafe partial struct SDL_GamepadSensorEvent
{
    [NativeTypeName("Uint32")]
    public SDL_EventType type;

    [NativeTypeName("Uint64")]
    public nuint timestamp;

    [NativeTypeName("SDL_JoystickID")]
    public uint which;

    [NativeTypeName("Sint32")]
    public int sensor;

    [NativeTypeName("float[3]")]
    public fixed float data[3];

    [NativeTypeName("Uint64")]
    public nuint sensor_timestamp;
}

public partial struct SDL_AudioDeviceEvent
{
    [NativeTypeName("Uint32")]
    public SDL_EventType type;

    [NativeTypeName("Uint64")]
    public nuint timestamp;

    [NativeTypeName("SDL_AudioDeviceID")]
    public uint which;

    [NativeTypeName("Uint8")]
    public byte iscapture;

    [NativeTypeName("Uint8")]
    public byte padding1;

    [NativeTypeName("Uint8")]
    public byte padding2;

    [NativeTypeName("Uint8")]
    public byte padding3;
}

public partial struct SDL_TouchFingerEvent
{
    [NativeTypeName("Uint32")]
    public SDL_EventType type;

    [NativeTypeName("Uint64")]
    public nuint timestamp;

    [NativeTypeName("SDL_TouchID")]
    public nint touchId;

    [NativeTypeName("SDL_FingerID")]
    public nint fingerId;

    public float x;

    public float y;

    public float dx;

    public float dy;

    public float pressure;

    [NativeTypeName("SDL_WindowID")]
    public uint windowID;
}

public unsafe partial struct SDL_DropEvent
{
    [NativeTypeName("Uint32")]
    public SDL_EventType type;

    [NativeTypeName("Uint64")]
    public nuint timestamp;

    [NativeTypeName("char *")]
    public sbyte* file;

    [NativeTypeName("SDL_WindowID")]
    public uint windowID;
}

public unsafe partial struct SDL_SensorEvent
{
    [NativeTypeName("Uint32")]
    public SDL_EventType type;

    [NativeTypeName("Uint64")]
    public nuint timestamp;

    [NativeTypeName("SDL_SensorID")]
    public uint which;

    [NativeTypeName("float[6]")]
    public fixed float data[6];

    [NativeTypeName("Uint64")]
    public nuint sensor_timestamp;
}

public partial struct SDL_QuitEvent
{
    [NativeTypeName("Uint32")]
    public SDL_EventType type;

    [NativeTypeName("Uint64")]
    public nuint timestamp;
}

public partial struct SDL_OSEvent
{
    [NativeTypeName("Uint32")]
    public SDL_EventType type;

    [NativeTypeName("Uint64")]
    public nuint timestamp;
}

public unsafe partial struct SDL_UserEvent
{
    [NativeTypeName("Uint32")]
    public SDL_EventType type;

    [NativeTypeName("Uint64")]
    public nuint timestamp;

    [NativeTypeName("SDL_WindowID")]
    public uint windowID;

    [NativeTypeName("Sint32")]
    public int code;

    public void* data1;

    public void* data2;
}

public partial struct SDL_SysWMmsg
{
}

public unsafe partial struct SDL_SysWMEvent
{
    [NativeTypeName("Uint32")]
    public SDL_EventType type;

    [NativeTypeName("Uint64")]
    public nuint timestamp;

    public SDL_SysWMmsg* msg;
}

[StructLayout(LayoutKind.Explicit)]
public unsafe partial struct SDL_Event
{
    [FieldOffset(0)]
    [NativeTypeName("Uint32")]
    public SDL_EventType type;

    [FieldOffset(0)]
    public SDL_CommonEvent common;

    [FieldOffset(0)]
    public SDL_DisplayEvent display;

    [FieldOffset(0)]
    public SDL_WindowEvent window;

    [FieldOffset(0)]
    public SDL_KeyboardEvent key;

    [FieldOffset(0)]
    public SDL_TextEditingEvent edit;

    [FieldOffset(0)]
    public SDL_TextEditingExtEvent editExt;

    [FieldOffset(0)]
    public SDL_TextInputEvent text;

    [FieldOffset(0)]
    public SDL_MouseMotionEvent motion;

    [FieldOffset(0)]
    public SDL_MouseButtonEvent button;

    [FieldOffset(0)]
    public SDL_MouseWheelEvent wheel;

    [FieldOffset(0)]
    public SDL_JoyAxisEvent jaxis;

    [FieldOffset(0)]
    public SDL_JoyHatEvent jhat;

    [FieldOffset(0)]
    public SDL_JoyButtonEvent jbutton;

    [FieldOffset(0)]
    public SDL_JoyDeviceEvent jdevice;

    [FieldOffset(0)]
    public SDL_JoyBatteryEvent jbattery;

    [FieldOffset(0)]
    public SDL_GamepadAxisEvent caxis;

    [FieldOffset(0)]
    public SDL_GamepadButtonEvent cbutton;

    [FieldOffset(0)]
    public SDL_GamepadDeviceEvent cdevice;

    [FieldOffset(0)]
    public SDL_GamepadTouchpadEvent ctouchpad;

    [FieldOffset(0)]
    public SDL_GamepadSensorEvent csensor;

    [FieldOffset(0)]
    public SDL_AudioDeviceEvent adevice;

    [FieldOffset(0)]
    public SDL_SensorEvent sensor;

    [FieldOffset(0)]
    public SDL_QuitEvent quit;

    [FieldOffset(0)]
    public SDL_UserEvent user;

    [FieldOffset(0)]
    public SDL_SysWMEvent syswm;

    [FieldOffset(0)]
    public SDL_TouchFingerEvent tfinger;

    [FieldOffset(0)]
    public SDL_DropEvent drop;

    [FieldOffset(0)]
    [NativeTypeName("Uint8[128]")]
    public fixed byte padding[128];
}