namespace DeafMan1983.Interop.SDL3;

using System.Runtime.InteropServices;

public unsafe static partial class SDL3
{
    // SDL_stdinc.h

    // typedef int SDL_bool; Just int
    public const int SDL_FALSE = 0,
                     SDL_TRUE = 1;

    // typedef int8_t Sint8;; Just sbyte
    public const sbyte SDL_MAX_SINT8 = 0x7F,
                       SDL_MIN_SINT8 = -0x7F;

    // typedef uint8_t Uint8; Just byte
    public const byte SDL_MAX_UINT8 = 0xFF,
                      SDL_MIN_UINT8 = 0x00;

    // typedef int16_t Sint16; Just short
    public const short SDL_MAX_SINT16 = 0x7FFF,
                       SDL_MIN_SINT16 = -0x7FFF;

    // typedef uint16_t Uint16; Just ushort
    public const ushort SDL_MAX_UINT16 = 0xFFFF,
                        SDL_MIN_UINT16 = 0x0000;

    // typedef int32_t Sint32; Just int
    public const int SDL_MAX_SINT32 = 0x7FFFFFFF,
                     SDL_MIN_SINT32 = -0x7FFFFFFF;

    // typedef uint32_t Uint32; Just uint
    public const uint SDL_MAX_UINT32 = 0xFFFFFFFFu,
                      SDL_MIN_UINT32 = 0x00000000u;

    // typedef int64_t Sint64; Just long
    public const long SDL_MAX_SINT64 = 0x7FFFFFFFFFFFFFFFL,
                      SDL_MIN_SINT64 = ~0x7FFFFFFFFFFFFFFFL;

    // typedef uint64_t Uint64; Just ulong
    public const ulong SDL_MAX_UINT64 = 0xFFFFFFFFFFFFFFFFuL,
                        SDL_MIN_UINT64 = 0x0000000000000000uL;

    public const float SDL_FLT_EPSILON = 1.1920928955078125e-07F;

    [DllImport(libSDL3)]
    public static extern void *SDL_malloc([NativeTypeName("size_t")] nuint size);

    [DllImport(libSDL3)]
    public static extern void *SDL_calloc([NativeTypeName("size_t")] nuint nmemb, [NativeTypeName("size_t")] nuint size);

    [DllImport(libSDL3)]
    public static extern void *SDL_realloc(void *mem, [NativeTypeName("size_t")] nuint size);

    [DllImport(libSDL3)]
    public static extern void SDL_free(void *mem);

    [DllImport(libSDL3)]
    public static extern void SDL_GetOriginalMemoryFunctions(delegate *unmanaged<nuint, void *> *malloc_func, delegate* unmanaged<nuint, nuint, void*> *calloc_func, delegate* unmanaged<void*, nuint, void*> *realloc_func, delegate* unmanaged[Cdecl]<void*, void> *free_func);

    [DllImport(libSDL3)]
    public static extern void SDL_GetMemoryFunctions(delegate *unmanaged<nuint, void *> *malloc_func, delegate* unmanaged<nuint, nuint, void*> *calloc_func, delegate* unmanaged<void*, nuint, void*> *realloc_func, delegate* unmanaged[Cdecl]<void*, void> *free_func);

    [DllImport(libSDL3)]
    public static extern int SDL_SetMemoryFunctions(delegate *unmanaged<nuint, void *> malloc_func, delegate* unmanaged<nuint, nuint, void*> calloc_func, delegate* unmanaged<void*, nuint, void*> realloc_func, delegate* unmanaged[Cdecl]<void*, void> free_func);

    [DllImport(libSDL3)]
    public static extern void *SDL_aligned_alloc([NativeTypeName("size_t")] nuint alignment, [NativeTypeName("size_t")] nuint size);

    [DllImport(libSDL3)]
    public static extern void SDL_aligned_free(void* mem);

    [DllImport(libSDL3)]
    public static extern int SDL_GetNumAllocations();

    [DllImport(libSDL3)]
    [return: NativeTypeName("char *")]
    public static extern sbyte *SDL_getenv([NativeTypeName("const char *")] sbyte *name);

    [DllImport(libSDL3)]
    public static extern int SDL_setenv([NativeTypeName("const char *")] sbyte* name, [NativeTypeName("const char *")] sbyte* value, int overwrite);

    [DllImport(libSDL3)]
    public static extern void SDL_qsort(void* @base, [NativeTypeName("size_t")] nuint nmemb, [NativeTypeName("size_t")] nuint size, [NativeTypeName("int (*)(const void *, const void *)")] delegate* unmanaged<void*, void*, int> compare);

    [DllImport(libSDL3)]
    public static extern void* SDL_bsearch([NativeTypeName("const void *")] void* key, [NativeTypeName("const void *")] void* @base, [NativeTypeName("size_t")] nuint nmemb, [NativeTypeName("size_t")] nuint size, [NativeTypeName("int (*)(const void *, const void *)")] delegate* unmanaged<void*, void*, int> compare);

    [DllImport(libSDL3)]
    public static extern int SDL_abs(int x);

    [DllImport(libSDL3)]
    public static extern int SDL_isalpha(int x);

    [DllImport(libSDL3)]
    public static extern int SDL_isalnum(int x);

    [DllImport(libSDL3)]
    public static extern int SDL_isblank(int x);

    [DllImport(libSDL3)]
    public static extern int SDL_iscntrl(int x);

    [DllImport(libSDL3)]
    public static extern int SDL_isdigit(int x);

    [DllImport(libSDL3)]
    public static extern int SDL_isxdigit(int x);

    [DllImport(libSDL3)]
    public static extern int SDL_ispunct(int x);

    [DllImport(libSDL3)]
    public static extern int SDL_isspace(int x);

    [DllImport(libSDL3)]
    public static extern int SDL_isupper(int x);

    [DllImport(libSDL3)]
    public static extern int SDL_islower(int x);

    [DllImport(libSDL3)]
    public static extern int SDL_isprint(int x);

    [DllImport(libSDL3)]
    public static extern int SDL_isgraph(int x);

    [DllImport(libSDL3)]
    public static extern int SDL_toupper(int x);

    [DllImport(libSDL3)]
    public static extern int SDL_tolower(int x);


}