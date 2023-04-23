namespace DeafMan1983.Interop.SDL3;

public partial struct SDL_hid_device_
{
}

public unsafe partial struct SDL_hid_device_info
{
    [NativeTypeName("char *")]
    public sbyte* path;

    [NativeTypeName("unsigned short")]
    public ushort vendor_id;

    [NativeTypeName("unsigned short")]
    public ushort product_id;

    [NativeTypeName("wchar_t *")]
    public uint* serial_number;

    [NativeTypeName("unsigned short")]
    public ushort release_number;

    [NativeTypeName("wchar_t *")]
    public uint* manufacturer_string;

    [NativeTypeName("wchar_t *")]
    public uint* product_string;

    [NativeTypeName("unsigned short")]
    public ushort usage_page;

    [NativeTypeName("unsigned short")]
    public ushort usage;

    public int interface_number;

    public int interface_class;

    public int interface_subclass;

    public int interface_protocol;

    [NativeTypeName("struct SDL_hid_device_info *")]
    public SDL_hid_device_info* next;
}