using System.Runtime.InteropServices;

namespace DeafMan1983.Interop.SDL3
{

        public unsafe partial struct IMG_Animation
        {
            public int w;

            public int h;

            public int count;

            public SDL_Surface** frames;

            public int* delays;
        }

    public static unsafe partial class SDL3
    {
        private const string libSDL3_image = "SDL3_image";

        [NativeTypeName("unsigned int")]
        public enum IMG_InitFlags : uint
        {
        }

        public const IMG_InitFlags IMG_INIT_JPG = (IMG_InitFlags)0x00000001,
            IMG_INIT_PNG = (IMG_InitFlags)0x00000002,
            IMG_INIT_TIF = (IMG_InitFlags)0x00000004,
            IMG_INIT_WEBP = (IMG_InitFlags)0x00000008,
            IMG_INIT_JXL = (IMG_InitFlags)0x00000010,
            IMG_INIT_AVIF = (IMG_InitFlags)0x00000020;

        [DllImport(libSDL3_image)]
        [return: NativeTypeName("const SDL_version *")]
        public static extern SDL_version* IMG_Linked_Version();

        [DllImport(libSDL3_image)]
        public static extern bool IMG_Init(IMG_InitFlags flags);

        [DllImport(libSDL3_image)]
        public static extern void IMG_Quit();

        [DllImport(libSDL3_image)]
        public static extern SDL_Surface* IMG_LoadTyped_RW(SDL_RWops* src, int freesrc, [NativeTypeName("const char *")] sbyte* type);

        [DllImport(libSDL3_image)]
        public static extern SDL_Surface* IMG_Load([NativeTypeName("const char *")] sbyte* file);

        [DllImport(libSDL3_image)]
        public static extern SDL_Surface* IMG_Load_RW(SDL_RWops* src, int freesrc);

        [DllImport(libSDL3_image)]
        public static extern SDL_Texture* IMG_LoadTexture(SDL_Renderer* renderer, [NativeTypeName("const char *")] sbyte* file);

        [DllImport(libSDL3_image)]
        public static extern SDL_Texture* IMG_LoadTexture_RW(SDL_Renderer* renderer, SDL_RWops* src, int freesrc);

        [DllImport(libSDL3_image)]
        public static extern SDL_Texture* IMG_LoadTextureTyped_RW(SDL_Renderer* renderer, SDL_RWops* src, int freesrc, [NativeTypeName("const char *")] sbyte* type);

        [DllImport(libSDL3_image)]
        public static extern int IMG_isAVIF(SDL_RWops* src);

        [DllImport(libSDL3_image)]
        public static extern int IMG_isICO(SDL_RWops* src);

        [DllImport(libSDL3_image)]
        public static extern int IMG_isCUR(SDL_RWops* src);

        [DllImport(libSDL3_image)]
        public static extern int IMG_isBMP(SDL_RWops* src);

        [DllImport(libSDL3_image)]
        public static extern int IMG_isGIF(SDL_RWops* src);

        [DllImport(libSDL3_image)]
        public static extern int IMG_isJPG(SDL_RWops* src);

        [DllImport(libSDL3_image)]
        public static extern int IMG_isJXL(SDL_RWops* src);

        [DllImport(libSDL3_image)]
        public static extern int IMG_isLBM(SDL_RWops* src);

        [DllImport(libSDL3_image)]
        public static extern int IMG_isPCX(SDL_RWops* src);

        [DllImport(libSDL3_image)]
        public static extern int IMG_isPNG(SDL_RWops* src);

        [DllImport(libSDL3_image)]
        public static extern int IMG_isPNM(SDL_RWops* src);

        [DllImport(libSDL3_image)]
        public static extern int IMG_isSVG(SDL_RWops* src);

        [DllImport(libSDL3_image)]
        public static extern int IMG_isQOI(SDL_RWops* src);

        [DllImport(libSDL3_image)]
        public static extern int IMG_isTIF(SDL_RWops* src);

        [DllImport(libSDL3_image)]
        public static extern int IMG_isXCF(SDL_RWops* src);

        [DllImport(libSDL3_image)]
        public static extern int IMG_isXPM(SDL_RWops* src);

        [DllImport(libSDL3_image)]
        public static extern int IMG_isXV(SDL_RWops* src);

        [DllImport(libSDL3_image)]
        public static extern int IMG_isWEBP(SDL_RWops* src);

        [DllImport(libSDL3_image)]
        public static extern SDL_Surface* IMG_LoadAVIF_RW(SDL_RWops* src);

        [DllImport(libSDL3_image)]
        public static extern SDL_Surface* IMG_LoadICO_RW(SDL_RWops* src);

        [DllImport(libSDL3_image)]
        public static extern SDL_Surface* IMG_LoadCUR_RW(SDL_RWops* src);

        [DllImport(libSDL3_image)]
        public static extern SDL_Surface* IMG_LoadBMP_RW(SDL_RWops* src);

        [DllImport(libSDL3_image)]
        public static extern SDL_Surface* IMG_LoadGIF_RW(SDL_RWops* src);

        [DllImport(libSDL3_image)]
        public static extern SDL_Surface* IMG_LoadJPG_RW(SDL_RWops* src);

        [DllImport(libSDL3_image)]
        public static extern SDL_Surface* IMG_LoadJXL_RW(SDL_RWops* src);

        [DllImport(libSDL3_image)]
        public static extern SDL_Surface* IMG_LoadLBM_RW(SDL_RWops* src);

        [DllImport(libSDL3_image)]
        public static extern SDL_Surface* IMG_LoadPCX_RW(SDL_RWops* src);

        [DllImport(libSDL3_image)]
        public static extern SDL_Surface* IMG_LoadPNG_RW(SDL_RWops* src);

        [DllImport(libSDL3_image)]
        public static extern SDL_Surface* IMG_LoadPNM_RW(SDL_RWops* src);

        [DllImport(libSDL3_image)]
        public static extern SDL_Surface* IMG_LoadSVG_RW(SDL_RWops* src);

        [DllImport(libSDL3_image)]
        public static extern SDL_Surface* IMG_LoadQOI_RW(SDL_RWops* src);

        [DllImport(libSDL3_image)]
        public static extern SDL_Surface* IMG_LoadTGA_RW(SDL_RWops* src);

        [DllImport(libSDL3_image)]
        public static extern SDL_Surface* IMG_LoadTIF_RW(SDL_RWops* src);

        [DllImport(libSDL3_image)]
        public static extern SDL_Surface* IMG_LoadXCF_RW(SDL_RWops* src);

        [DllImport(libSDL3_image)]
        public static extern SDL_Surface* IMG_LoadXPM_RW(SDL_RWops* src);

        [DllImport(libSDL3_image)]
        public static extern SDL_Surface* IMG_LoadXV_RW(SDL_RWops* src);

        [DllImport(libSDL3_image)]
        public static extern SDL_Surface* IMG_LoadWEBP_RW(SDL_RWops* src);

        [DllImport(libSDL3_image)]
        public static extern SDL_Surface* IMG_LoadSizedSVG_RW(SDL_RWops* src, int width, int height);

        [DllImport(libSDL3_image)]
        public static extern SDL_Surface* IMG_ReadXPMFromArray([NativeTypeName("char **")] sbyte** xpm);

        [DllImport(libSDL3_image)]
        public static extern SDL_Surface* IMG_ReadXPMFromArrayToRGB888([NativeTypeName("char **")] sbyte** xpm);

        [DllImport(libSDL3_image)]
        public static extern int IMG_SavePNG(SDL_Surface* surface, [NativeTypeName("const char *")] sbyte* file);

        [DllImport(libSDL3_image)]
        public static extern int IMG_SavePNG_RW(SDL_Surface* surface, SDL_RWops* dst, int freedst);

        [DllImport(libSDL3_image)]
        public static extern int IMG_SaveJPG(SDL_Surface* surface, [NativeTypeName("const char *")] sbyte* file, int quality);

        [DllImport(libSDL3_image)]
        public static extern int IMG_SaveJPG_RW(SDL_Surface* surface, SDL_RWops* dst, int freedst, int quality);

        [DllImport(libSDL3_image)]
        public static extern IMG_Animation* IMG_LoadAnimation([NativeTypeName("const char *")] sbyte* file);

        [DllImport(libSDL3_image)]
        public static extern IMG_Animation* IMG_LoadAnimation_RW(SDL_RWops* src, int freesrc);

        [DllImport(libSDL3_image)]
        public static extern IMG_Animation* IMG_LoadAnimationTyped_RW(SDL_RWops* src, int freesrc, [NativeTypeName("const char *")] sbyte* type);

        [DllImport(libSDL3_image)]
        public static extern void IMG_FreeAnimation(IMG_Animation* anim);

        [DllImport(libSDL3_image)]
        public static extern IMG_Animation* IMG_LoadGIFAnimation_RW(SDL_RWops* src);

        [DllImport(libSDL3_image)]
        public static extern IMG_Animation* IMG_LoadWEBPAnimation_RW(SDL_RWops* src);
    }
}