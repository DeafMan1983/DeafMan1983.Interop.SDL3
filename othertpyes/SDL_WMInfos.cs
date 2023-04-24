namespace DeafMan1983.Interop.SDL3;

using System.Runtime.InteropServices;

public unsafe partial struct SDL_SysWMmsg
{
    [NativeTypeName("Uint32")]
    public uint version;

    [NativeTypeName("Uint32")]
    public uint subsystem;

    [NativeTypeName("Uint32[2]")]
    public fixed uint padding[2];

    [NativeTypeName("union (anonymous union at /usr/include/SDL3/SDL_syswm.h:228:5)")]
    public Message msg;

    [StructLayout(LayoutKind.Explicit)]
    public partial struct Message
    {
        [FieldOffset(0)]
        [NativeTypeName("struct (anonymous struct at /usr/include/SDL3/SDL_syswm.h:239:9)")]
        public X11 x11;

        [FieldOffset(0)]
        public int dummy;

        public partial struct X11
        {
            [NativeTypeName("XEvent")]
            public void* @event;
        }
    }
}

public unsafe partial struct SDL_SysWMinfo
{
    [NativeTypeName("Uint32")]
    public uint version;

    [NativeTypeName("Uint32")]
    public uint subsystem;

    [NativeTypeName("Uint32[2]")]
    public fixed uint padding[2];

    [NativeTypeName("union (anonymous union at /usr/include/SDL3/SDL_syswm.h:261:5)")]
    public WMInfo info;

    [StructLayout(LayoutKind.Explicit)]
    public partial struct WMInfo
    {
        [FieldOffset(0)]
        [NativeTypeName("struct (anonymous struct at /usr/include/SDL3/SDL_syswm.h:278:9)")]
        public X11 x11;

        [FieldOffset(0)]
        [NativeTypeName("struct (anonymous struct at /usr/include/SDL3/SDL_syswm.h:317:9)")]
        public WL wl;

        [FieldOffset(0)]
        [NativeTypeName("struct (anonymous struct at /usr/include/SDL3/SDL_syswm.h:346:9)")]
        public KMSDRM kmsdrm;

        [FieldOffset(0)]
        [NativeTypeName("void *[14]")]
        public fixed ulong dummy_ptrs[14];

        [FieldOffset(0)]
        [NativeTypeName("Uint64[14]")]
        public fixed ulong dummy_ints[14];

        public unsafe partial struct X11
        {
            [NativeTypeName("Display *")]
            public void* display;

            public int screen_number;

            [NativeTypeName("Window")]
            public void* window;
        }

        public unsafe partial struct WL
        {
            [NativeTypeName("struct wl_display *")]
            public void* display;

            [NativeTypeName("struct wl_surface *")]
            public void* surface;

            [NativeTypeName("struct wl_egl_window *")]
            public void* egl_window;

            [NativeTypeName("struct xdg_surface *")]
            public void* xdg_surface;

            [NativeTypeName("struct xdg_toplevel *")]
            public void* xdg_toplevel;

            [NativeTypeName("struct xdg_popup *")]
            public void* xdg_popup;

            [NativeTypeName("struct xdg_positioner *")]
            public void* xdg_positioner;
        }

        public unsafe partial struct KMSDRM
        {
            public int dev_index;

            public int drm_fd;

            [NativeTypeName("struct gbm_device *")]
            public void* gbm_dev;
        }

        // public unsafe partial struct _dummy_ptrs_e__FixedBuffer
        // {
        //     public void* e0;
        //     public void* e1;
        //     public void* e2;
        //     public void* e3;
        //     public void* e4;
        //     public void* e5;
        //     public void* e6;
        //     public void* e7;
        //     public void* e8;
        //     public void* e9;
        //     public void* e10;
        //     public void* e11;
        //     public void* e12;
        //     public void* e13;

        //     public ref void* this[int index]
        //     {
        //         get
        //         {
        //             fixed (void** pThis = &e0)
        //             {
        //                 return ref pThis[index];
        //             }
        //         }
        //     }
        // }

        // public partial struct _dummy_ints_e__FixedBuffer
        // {
        //     public nuint e0;
        //     public nuint e1;
        //     public nuint e2;
        //     public nuint e3;
        //     public nuint e4;
        //     public nuint e5;
        //     public nuint e6;
        //     public nuint e7;
        //     public nuint e8;
        //     public nuint e9;
        //     public nuint e10;
        //     public nuint e11;
        //     public nuint e12;
        //     public nuint e13;

        //     public ref nuint this[int index]
        //     {
        //         get
        //         {
        //             return ref AsSpan()[index];
        //         }
        //     }

        //     public Span<nuint> AsSpan() => MemoryMarshal.CreateSpan(ref e0, 14);
        // }
    }
}