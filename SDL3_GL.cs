using System.Runtime.InteropServices;

namespace DeafMan1983.Interop.SDL3;
public static unsafe partial class SDL3
{

    [NativeTypeName("unsigned int")]
    public enum SDL_GLattr : uint
    {
    }

    public static SDL_GLattr SDL_GL_RED_SIZE,
        SDL_GL_GREEN_SIZE,
        SDL_GL_BLUE_SIZE,
        SDL_GL_ALPHA_SIZE,
        SDL_GL_BUFFER_SIZE,
        SDL_GL_DOUBLEBUFFER,
        SDL_GL_DEPTH_SIZE,
        SDL_GL_STENCIL_SIZE,
        SDL_GL_ACCUM_RED_SIZE,
        SDL_GL_ACCUM_GREEN_SIZE,
        SDL_GL_ACCUM_BLUE_SIZE,
        SDL_GL_ACCUM_ALPHA_SIZE,
        SDL_GL_STEREO,
        SDL_GL_MULTISAMPLEBUFFERS,
        SDL_GL_MULTISAMPLESAMPLES,
        SDL_GL_ACCELERATED_VISUAL,
        SDL_GL_RETAINED_BACKING,
        SDL_GL_CONTEXT_MAJOR_VERSION,
        SDL_GL_CONTEXT_MINOR_VERSION,
        SDL_GL_CONTEXT_FLAGS,
        SDL_GL_CONTEXT_PROFILE_MASK,
        SDL_GL_SHARE_WITH_CURRENT_CONTEXT,
        SDL_GL_FRAMEBUFFER_SRGB_CAPABLE,
        SDL_GL_CONTEXT_RELEASE_BEHAVIOR,
        SDL_GL_CONTEXT_RESET_NOTIFICATION,
        SDL_GL_CONTEXT_NO_ERROR,
        SDL_GL_FLOATBUFFERS,
        SDL_GL_EGL_PLATFORM;

    [NativeTypeName("unsigned int")]
    public enum SDL_GLprofile : uint
    {
    }

    public const SDL_GLprofile SDL_GL_CONTEXT_PROFILE_CORE = (SDL_GLprofile)0x0001,
        SDL_GL_CONTEXT_PROFILE_COMPATIBILITY = (SDL_GLprofile)0x0002,
        SDL_GL_CONTEXT_PROFILE_ES = (SDL_GLprofile)0x0004;

    [NativeTypeName("unsigned int")]
    public enum SDL_GLcontextFlag : uint
    {
    }

    public const SDL_GLcontextFlag SDL_GL_CONTEXT_DEBUG_FLAG = (SDL_GLcontextFlag)0x0001,
        SDL_GL_CONTEXT_FORWARD_COMPATIBLE_FLAG = (SDL_GLcontextFlag)0x0002,
        SDL_GL_CONTEXT_ROBUST_ACCESS_FLAG = (SDL_GLcontextFlag)0x0004,
        SDL_GL_CONTEXT_RESET_ISOLATION_FLAG = (SDL_GLcontextFlag)0x0008;

    [NativeTypeName("unsigned int")]
    public enum SDL_GLcontextReleaseFlag : uint
    {
    }

    public const SDL_GLcontextReleaseFlag SDL_GL_CONTEXT_RELEASE_BEHAVIOR_NONE = 0x0000,
        SDL_GL_CONTEXT_RELEASE_BEHAVIOR_FLUSH = (SDL_GLcontextReleaseFlag)0x0001;

    [NativeTypeName("unsigned int")]
    public enum SDL_GLContextResetNotification : uint
    {
    }

    public const SDL_GLContextResetNotification SDL_GL_CONTEXT_RESET_NO_NOTIFICATION = 0x0000,
        SDL_GL_CONTEXT_RESET_LOSE_CONTEXT = (SDL_GLContextResetNotification)0x0001;

    [DllImport(libSDL3)]
    public static extern int SDL_GL_LoadLibrary([NativeTypeName("const char *")] sbyte* path);

    [DllImport(libSDL3)]
    [return: NativeTypeName("SDL_FunctionPointer")]
    public static extern delegate* unmanaged[Cdecl]<void *> SDL_GL_GetProcAddress([NativeTypeName("const char *")] sbyte* proc);

    [DllImport(libSDL3)]
    [return: NativeTypeName("SDL_FunctionPointer")]
    public static extern delegate* unmanaged[Cdecl]<void *> SDL_EGL_GetProcAddress([NativeTypeName("const char *")] sbyte* proc);

    [DllImport(libSDL3)]
    public static extern void SDL_GL_UnloadLibrary();

    [DllImport(libSDL3)]
    public static extern SDL_bool SDL_GL_ExtensionSupported([NativeTypeName("const char *")] sbyte* extension);

    [DllImport(libSDL3)]
    public static extern void SDL_GL_ResetAttributes();

    [DllImport(libSDL3)]
    public static extern int SDL_GL_SetAttribute(SDL_GLattr attr, int value);

    [DllImport(libSDL3)]
    public static extern int SDL_GL_GetAttribute(SDL_GLattr attr, int* value);

    [DllImport(libSDL3)]
    [return: NativeTypeName("SDL_GLContext")]
    public static extern void* SDL_GL_CreateContext(SDL_Window* window);

    [DllImport(libSDL3)]
    public static extern int SDL_GL_MakeCurrent(SDL_Window* window, [NativeTypeName("SDL_GLContext")] void* context);

    [DllImport(libSDL3)]
    public static extern SDL_Window* SDL_GL_GetCurrentWindow();

    [DllImport(libSDL3)]
    [return: NativeTypeName("SDL_GLContext")]
    public static extern void* SDL_GL_GetCurrentContext();

    [DllImport(libSDL3)]
    [return: NativeTypeName("SDL_EGLDisplay")]
    public static extern void* SDL_EGL_GetCurrentEGLDisplay();

    [DllImport(libSDL3)]
    [return: NativeTypeName("SDL_EGLConfig")]
    public static extern void* SDL_EGL_GetCurrentEGLConfig();

    [DllImport(libSDL3)]
    [return: NativeTypeName("SDL_EGLSurface")]
    public static extern void* SDL_EGL_GetWindowEGLSurface(SDL_Window* window);

    [DllImport(libSDL3)]
    public static extern void SDL_EGL_SetEGLAttributeCallbacks([NativeTypeName("SDL_EGLAttribArrayCallback")] delegate* unmanaged[Cdecl]<nint*> platformAttribCallback, [NativeTypeName("SDL_EGLIntArrayCallback")] delegate* unmanaged[Cdecl]<int*> surfaceAttribCallback, [NativeTypeName("SDL_EGLIntArrayCallback")] delegate* unmanaged[Cdecl]<int*> contextAttribCallback);

    [DllImport(libSDL3)]
    public static extern int SDL_GL_SetSwapInterval(int interval);

    [DllImport(libSDL3)]
    public static extern int SDL_GL_GetSwapInterval(int* interval);

    [DllImport(libSDL3)]
    public static extern int SDL_GL_SwapWindow(SDL_Window* window);

    [DllImport(libSDL3)]
    public static extern int SDL_GL_DeleteContext([NativeTypeName("SDL_GLContext")] void* context);
}