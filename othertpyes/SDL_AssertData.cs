namespace DeafMan1983.Interop.SDL3;

public unsafe partial struct SDL_AssertData
{
    public int always_ignore;

    [NativeTypeName("unsigned int")]
    public uint trigger_count;

    [NativeTypeName("const char *")]
    public sbyte* condition;

    [NativeTypeName("const char *")]
    public sbyte* filename;

    public int linenum;

    [NativeTypeName("const char *")]
    public sbyte* function;

    [NativeTypeName("const struct SDL_AssertData *")]
    public SDL_AssertData* next;
}