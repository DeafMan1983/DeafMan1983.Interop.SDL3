namespace DeafMan1983.Interop.SDL3;

using System.Runtime.InteropServices;
using static DeafMan1983.Interop.SDL3.SDL3;

public partial struct SDL_Gamepad
{
}

public partial struct SDL_GamepadBinding
{
    public SDL_GamepadBindingType bindType;

    [NativeTypeName("union (anonymous union at /usr/include/SDL3/SDL_gamepad.h:144:5)")]
    public _value_e__Union value;

    [StructLayout(LayoutKind.Explicit)]
    public partial struct _value_e__Union
    {
        [FieldOffset(0)]
        public int button;

        [FieldOffset(0)]
        public int axis;

        [FieldOffset(0)]
        [NativeTypeName("struct (anonymous struct at /usr/include/SDL3/SDL_gamepad.h:148:9)")]
        public _hat_e__Struct hat;

        public partial struct _hat_e__Struct
        {
            public int hat;

            public int hat_mask;
        }
    }
}