using System;
using System.Runtime.InteropServices;

namespace DeafMan1983.Interop.SDL3
{
    public partial struct TTF_Font
    {
    }        

    public static unsafe partial class SDL3
    {
        [NativeTypeName("unsigned int")]
        public enum TTF_Direction : uint
        {
        }

        public static TTF_Direction TTF_DIRECTION_LTR = 0,
            TTF_DIRECTION_RTL,
            TTF_DIRECTION_TTB,
            TTF_DIRECTION_BTT;

        private const string libSDL3_TTF = "SDL3_ttf";


        [DllImport(libSDL3_TTF)]
        [return: NativeTypeName("const SDL_version *")]
        public static extern SDL_version* TTF_Linked_Version();

        [DllImport(libSDL3_TTF)]
        public static extern void TTF_GetFreeTypeVersion(int* major, int* minor, int* patch);

        [DllImport(libSDL3_TTF)]
        public static extern void TTF_GetHarfBuzzVersion(int* major, int* minor, int* patch);

        [DllImport(libSDL3_TTF)]
        public static extern void TTF_ByteSwappedUNICODE(int swapped);

        [DllImport(libSDL3_TTF)]
        public static extern int TTF_Init();

        [DllImport(libSDL3_TTF)]
        [return: NativeTypeName("TTF_Font *")]
        public static extern TTF_Font* TTF_OpenFont([NativeTypeName("const char *")] sbyte* file, int ptsize);

        [DllImport(libSDL3_TTF)]
        [return: NativeTypeName("TTF_Font *")]
        public static extern TTF_Font* TTF_OpenFontIndex([NativeTypeName("const char *")] sbyte* file, int ptsize, [NativeTypeName("long")] nint index);

        [DllImport(libSDL3_TTF)]
        [return: NativeTypeName("TTF_Font *")]
        public static extern TTF_Font* TTF_OpenFontRW(SDL_RWops* src, int freesrc, int ptsize);

        [DllImport(libSDL3_TTF)]
        [return: NativeTypeName("TTF_Font *")]
        public static extern TTF_Font* TTF_OpenFontIndexRW(SDL_RWops* src, int freesrc, int ptsize, [NativeTypeName("long")] nint index);

        [DllImport(libSDL3_TTF)]
        [return: NativeTypeName("TTF_Font *")]
        public static extern TTF_Font* TTF_OpenFontDPI([NativeTypeName("const char *")] sbyte* file, int ptsize, [NativeTypeName("unsigned int")] uint hdpi, [NativeTypeName("unsigned int")] uint vdpi);

        [DllImport(libSDL3_TTF)]
        [return: NativeTypeName("TTF_Font *")]
        public static extern TTF_Font* TTF_OpenFontIndexDPI([NativeTypeName("const char *")] sbyte* file, int ptsize, [NativeTypeName("long")] nint index, [NativeTypeName("unsigned int")] uint hdpi, [NativeTypeName("unsigned int")] uint vdpi);

        [DllImport(libSDL3_TTF)]
        [return: NativeTypeName("TTF_Font *")]
        public static extern TTF_Font* TTF_OpenFontDPIRW(SDL_RWops* src, int freesrc, int ptsize, [NativeTypeName("unsigned int")] uint hdpi, [NativeTypeName("unsigned int")] uint vdpi);

        [DllImport(libSDL3_TTF)]
        [return: NativeTypeName("TTF_Font *")]
        public static extern TTF_Font* TTF_OpenFontIndexDPIRW(SDL_RWops* src, int freesrc, int ptsize, [NativeTypeName("long")] nint index, [NativeTypeName("unsigned int")] uint hdpi, [NativeTypeName("unsigned int")] uint vdpi);

        [DllImport(libSDL3_TTF)]
        public static extern int TTF_SetFontSize([NativeTypeName("TTF_Font *")] TTF_Font* font, int ptsize);

        [DllImport(libSDL3_TTF)]
        public static extern int TTF_SetFontSizeDPI([NativeTypeName("TTF_Font *")] TTF_Font* font, int ptsize, [NativeTypeName("unsigned int")] uint hdpi, [NativeTypeName("unsigned int")] uint vdpi);

        [DllImport(libSDL3_TTF)]
        public static extern int TTF_GetFontStyle([NativeTypeName("const TTF_Font *")] TTF_Font* font);

        [DllImport(libSDL3_TTF)]
        public static extern void TTF_SetFontStyle([NativeTypeName("TTF_Font *")] TTF_Font* font, int style);

        [DllImport(libSDL3_TTF)]
        public static extern int TTF_GetFontOutline([NativeTypeName("const TTF_Font *")] TTF_Font* font);

        [DllImport(libSDL3_TTF)]
        public static extern void TTF_SetFontOutline([NativeTypeName("TTF_Font *")] TTF_Font* font, int outline);

        [DllImport(libSDL3_TTF)]
        public static extern int TTF_GetFontHinting([NativeTypeName("const TTF_Font *")] TTF_Font* font);

        [DllImport(libSDL3_TTF)]
        public static extern void TTF_SetFontHinting([NativeTypeName("TTF_Font *")] TTF_Font* font, int hinting);

        [DllImport(libSDL3_TTF)]
        public static extern int TTF_GetFontWrappedAlign([NativeTypeName("const TTF_Font *")] TTF_Font* font);

        [DllImport(libSDL3_TTF)]
        public static extern void TTF_SetFontWrappedAlign([NativeTypeName("TTF_Font *")] TTF_Font* font, int align);

        [DllImport(libSDL3_TTF)]
        public static extern int TTF_FontHeight([NativeTypeName("const TTF_Font *")] TTF_Font* font);

        [DllImport(libSDL3_TTF)]
        public static extern int TTF_FontAscent([NativeTypeName("const TTF_Font *")] TTF_Font* font);

        [DllImport(libSDL3_TTF)]
        public static extern int TTF_FontDescent([NativeTypeName("const TTF_Font *")] TTF_Font* font);

        [DllImport(libSDL3_TTF)]
        public static extern int TTF_FontLineSkip([NativeTypeName("const TTF_Font *")] TTF_Font* font);

        [DllImport(libSDL3_TTF)]
        public static extern int TTF_GetFontKerning([NativeTypeName("const TTF_Font *")] TTF_Font* font);

        [DllImport(libSDL3_TTF)]
        public static extern void TTF_SetFontKerning([NativeTypeName("TTF_Font *")] TTF_Font* font, int allowed);

        [DllImport(libSDL3_TTF)]
        [return: NativeTypeName("long")]
        public static extern nint TTF_FontFaces([NativeTypeName("const TTF_Font *")] TTF_Font* font);

        [DllImport(libSDL3_TTF)]
        public static extern int TTF_FontFaceIsFixedWidth([NativeTypeName("const TTF_Font *")] TTF_Font* font);

        [DllImport(libSDL3_TTF)]
        [return: NativeTypeName("const char *")]
        public static extern sbyte* TTF_FontFaceFamilyName([NativeTypeName("const TTF_Font *")] TTF_Font* font);

        [DllImport(libSDL3_TTF)]
        [return: NativeTypeName("const char *")]
        public static extern sbyte* TTF_FontFaceStyleName([NativeTypeName("const TTF_Font *")] TTF_Font* font);

        [DllImport(libSDL3_TTF)]
        public static extern int TTF_GlyphIsProvided([NativeTypeName("TTF_Font *")] TTF_Font* font, [NativeTypeName("Uint16")] ushort ch);

        [DllImport(libSDL3_TTF)]
        public static extern int TTF_GlyphIsProvided32([NativeTypeName("TTF_Font *")] TTF_Font* font, [NativeTypeName("Uint32")] uint ch);

        [DllImport(libSDL3_TTF)]
        public static extern int TTF_GlyphMetrics([NativeTypeName("TTF_Font *")] TTF_Font* font, [NativeTypeName("Uint16")] ushort ch, int* minx, int* maxx, int* miny, int* maxy, int* advance);

        [DllImport(libSDL3_TTF)]
        public static extern int TTF_GlyphMetrics32([NativeTypeName("TTF_Font *")] TTF_Font* font, [NativeTypeName("Uint32")] uint ch, int* minx, int* maxx, int* miny, int* maxy, int* advance);

        [DllImport(libSDL3_TTF)]
        public static extern int TTF_SizeText([NativeTypeName("TTF_Font *")] TTF_Font* font, [NativeTypeName("const char *")] sbyte* text, int* w, int* h);

        [DllImport(libSDL3_TTF)]
        public static extern int TTF_SizeUTF8([NativeTypeName("TTF_Font *")] TTF_Font* font, [NativeTypeName("const char *")] sbyte* text, int* w, int* h);

        [DllImport(libSDL3_TTF)]
        public static extern int TTF_SizeUNICODE([NativeTypeName("TTF_Font *")] TTF_Font* font, [NativeTypeName("const Uint16 *")] ushort* text, int* w, int* h);

        [DllImport(libSDL3_TTF)]
        public static extern int TTF_MeasureText([NativeTypeName("TTF_Font *")] TTF_Font* font, [NativeTypeName("const char *")] sbyte* text, int measure_width, int* extent, int* count);

        [DllImport(libSDL3_TTF)]
        public static extern int TTF_MeasureUTF8([NativeTypeName("TTF_Font *")] TTF_Font* font, [NativeTypeName("const char *")] sbyte* text, int measure_width, int* extent, int* count);

        [DllImport(libSDL3_TTF)]
        public static extern int TTF_MeasureUNICODE([NativeTypeName("TTF_Font *")] TTF_Font* font, [NativeTypeName("const Uint16 *")] ushort* text, int measure_width, int* extent, int* count);

        [DllImport(libSDL3_TTF)]
        public static extern SDL_Surface* TTF_RenderText_Solid([NativeTypeName("TTF_Font *")] TTF_Font* font, [NativeTypeName("const char *")] sbyte* text, SDL_Color fg);

        [DllImport(libSDL3_TTF)]
        public static extern SDL_Surface* TTF_RenderUTF8_Solid([NativeTypeName("TTF_Font *")] TTF_Font* font, [NativeTypeName("const char *")] sbyte* text, SDL_Color fg);

        [DllImport(libSDL3_TTF)]
        public static extern SDL_Surface* TTF_RenderUNICODE_Solid([NativeTypeName("TTF_Font *")] TTF_Font* font, [NativeTypeName("const Uint16 *")] ushort* text, SDL_Color fg);

        [DllImport(libSDL3_TTF)]
        public static extern SDL_Surface* TTF_RenderText_Solid_Wrapped([NativeTypeName("TTF_Font *")] TTF_Font* font, [NativeTypeName("const char *")] sbyte* text, SDL_Color fg, [NativeTypeName("Uint32")] uint wrapLength);

        [DllImport(libSDL3_TTF)]
        public static extern SDL_Surface* TTF_RenderUTF8_Solid_Wrapped([NativeTypeName("TTF_Font *")] TTF_Font* font, [NativeTypeName("const char *")] sbyte* text, SDL_Color fg, [NativeTypeName("Uint32")] uint wrapLength);

        [DllImport(libSDL3_TTF)]
        public static extern SDL_Surface* TTF_RenderUNICODE_Solid_Wrapped([NativeTypeName("TTF_Font *")] TTF_Font* font, [NativeTypeName("const Uint16 *")] ushort* text, SDL_Color fg, [NativeTypeName("Uint32")] uint wrapLength);

        [DllImport(libSDL3_TTF)]
        public static extern SDL_Surface* TTF_RenderGlyph_Solid([NativeTypeName("TTF_Font *")] TTF_Font* font, [NativeTypeName("Uint16")] ushort ch, SDL_Color fg);

        [DllImport(libSDL3_TTF)]
        public static extern SDL_Surface* TTF_RenderGlyph32_Solid([NativeTypeName("TTF_Font *")] TTF_Font* font, [NativeTypeName("Uint32")] uint ch, SDL_Color fg);

        [DllImport(libSDL3_TTF)]
        public static extern SDL_Surface* TTF_RenderText_Shaded([NativeTypeName("TTF_Font *")] TTF_Font* font, [NativeTypeName("const char *")] sbyte* text, SDL_Color fg, SDL_Color bg);

        [DllImport(libSDL3_TTF)]
        public static extern SDL_Surface* TTF_RenderUTF8_Shaded([NativeTypeName("TTF_Font *")] TTF_Font* font, [NativeTypeName("const char *")] sbyte* text, SDL_Color fg, SDL_Color bg);

        [DllImport(libSDL3_TTF)]
        public static extern SDL_Surface* TTF_RenderUNICODE_Shaded([NativeTypeName("TTF_Font *")] TTF_Font* font, [NativeTypeName("const Uint16 *")] ushort* text, SDL_Color fg, SDL_Color bg);

        [DllImport(libSDL3_TTF)]
        public static extern SDL_Surface* TTF_RenderText_Shaded_Wrapped([NativeTypeName("TTF_Font *")] TTF_Font* font, [NativeTypeName("const char *")] sbyte* text, SDL_Color fg, SDL_Color bg, [NativeTypeName("Uint32")] uint wrapLength);

        [DllImport(libSDL3_TTF)]
        public static extern SDL_Surface* TTF_RenderUTF8_Shaded_Wrapped([NativeTypeName("TTF_Font *")] TTF_Font* font, [NativeTypeName("const char *")] sbyte* text, SDL_Color fg, SDL_Color bg, [NativeTypeName("Uint32")] uint wrapLength);

        [DllImport(libSDL3_TTF)]
        public static extern SDL_Surface* TTF_RenderUNICODE_Shaded_Wrapped([NativeTypeName("TTF_Font *")] TTF_Font* font, [NativeTypeName("const Uint16 *")] ushort* text, SDL_Color fg, SDL_Color bg, [NativeTypeName("Uint32")] uint wrapLength);

        [DllImport(libSDL3_TTF)]
        public static extern SDL_Surface* TTF_RenderGlyph_Shaded([NativeTypeName("TTF_Font *")] TTF_Font* font, [NativeTypeName("Uint16")] ushort ch, SDL_Color fg, SDL_Color bg);

        [DllImport(libSDL3_TTF)]
        public static extern SDL_Surface* TTF_RenderGlyph32_Shaded([NativeTypeName("TTF_Font *")] TTF_Font* font, [NativeTypeName("Uint32")] uint ch, SDL_Color fg, SDL_Color bg);

        [DllImport(libSDL3_TTF)]
        public static extern SDL_Surface* TTF_RenderText_Blended([NativeTypeName("TTF_Font *")] TTF_Font* font, [NativeTypeName("const char *")] sbyte* text, SDL_Color fg);

        [DllImport(libSDL3_TTF)]
        public static extern SDL_Surface* TTF_RenderUTF8_Blended([NativeTypeName("TTF_Font *")] TTF_Font* font, [NativeTypeName("const char *")] sbyte* text, SDL_Color fg);

        [DllImport(libSDL3_TTF)]
        public static extern SDL_Surface* TTF_RenderUNICODE_Blended([NativeTypeName("TTF_Font *")] TTF_Font* font, [NativeTypeName("const Uint16 *")] ushort* text, SDL_Color fg);

        [DllImport(libSDL3_TTF)]
        public static extern SDL_Surface* TTF_RenderText_Blended_Wrapped([NativeTypeName("TTF_Font *")] TTF_Font* font, [NativeTypeName("const char *")] sbyte* text, SDL_Color fg, [NativeTypeName("Uint32")] uint wrapLength);

        [DllImport(libSDL3_TTF)]
        public static extern SDL_Surface* TTF_RenderUTF8_Blended_Wrapped([NativeTypeName("TTF_Font *")] TTF_Font* font, [NativeTypeName("const char *")] sbyte* text, SDL_Color fg, [NativeTypeName("Uint32")] uint wrapLength);

        [DllImport(libSDL3_TTF)]
        public static extern SDL_Surface* TTF_RenderUNICODE_Blended_Wrapped([NativeTypeName("TTF_Font *")] TTF_Font* font, [NativeTypeName("const Uint16 *")] ushort* text, SDL_Color fg, [NativeTypeName("Uint32")] uint wrapLength);

        [DllImport(libSDL3_TTF)]
        public static extern SDL_Surface* TTF_RenderGlyph_Blended([NativeTypeName("TTF_Font *")] TTF_Font* font, [NativeTypeName("Uint16")] ushort ch, SDL_Color fg);

        [DllImport(libSDL3_TTF)]
        public static extern SDL_Surface* TTF_RenderGlyph32_Blended([NativeTypeName("TTF_Font *")] TTF_Font* font, [NativeTypeName("Uint32")] uint ch, SDL_Color fg);

        [DllImport(libSDL3_TTF)]
        public static extern SDL_Surface* TTF_RenderText_LCD([NativeTypeName("TTF_Font *")] TTF_Font* font, [NativeTypeName("const char *")] sbyte* text, SDL_Color fg, SDL_Color bg);

        [DllImport(libSDL3_TTF)]
        public static extern SDL_Surface* TTF_RenderUTF8_LCD([NativeTypeName("TTF_Font *")] TTF_Font* font, [NativeTypeName("const char *")] sbyte* text, SDL_Color fg, SDL_Color bg);

        [DllImport(libSDL3_TTF)]
        public static extern SDL_Surface* TTF_RenderUNICODE_LCD([NativeTypeName("TTF_Font *")] TTF_Font* font, [NativeTypeName("const Uint16 *")] ushort* text, SDL_Color fg, SDL_Color bg);

        [DllImport(libSDL3_TTF)]
        public static extern SDL_Surface* TTF_RenderText_LCD_Wrapped([NativeTypeName("TTF_Font *")] TTF_Font* font, [NativeTypeName("const char *")] sbyte* text, SDL_Color fg, SDL_Color bg, [NativeTypeName("Uint32")] uint wrapLength);

        [DllImport(libSDL3_TTF)]
        public static extern SDL_Surface* TTF_RenderUTF8_LCD_Wrapped([NativeTypeName("TTF_Font *")] TTF_Font* font, [NativeTypeName("const char *")] sbyte* text, SDL_Color fg, SDL_Color bg, [NativeTypeName("Uint32")] uint wrapLength);

        [DllImport(libSDL3_TTF)]
        public static extern SDL_Surface* TTF_RenderUNICODE_LCD_Wrapped([NativeTypeName("TTF_Font *")] TTF_Font* font, [NativeTypeName("const Uint16 *")] ushort* text, SDL_Color fg, SDL_Color bg, [NativeTypeName("Uint32")] uint wrapLength);

        [DllImport(libSDL3_TTF)]
        public static extern SDL_Surface* TTF_RenderGlyph_LCD([NativeTypeName("TTF_Font *")] TTF_Font* font, [NativeTypeName("Uint16")] ushort ch, SDL_Color fg, SDL_Color bg);

        [DllImport(libSDL3_TTF)]
        public static extern SDL_Surface* TTF_RenderGlyph32_LCD([NativeTypeName("TTF_Font *")] TTF_Font* font, [NativeTypeName("Uint32")] uint ch, SDL_Color fg, SDL_Color bg);

        [DllImport(libSDL3_TTF)]
        public static extern void TTF_CloseFont([NativeTypeName("TTF_Font *")] TTF_Font* font);

        [DllImport(libSDL3_TTF)]
        public static extern void TTF_Quit();

        [DllImport(libSDL3_TTF)]
        public static extern int TTF_WasInit();

        [DllImport(libSDL3_TTF)]
        [Obsolete]
        public static extern int TTF_GetFontKerningSize([NativeTypeName("TTF_Font *")] TTF_Font* font, int prev_index, int index);

        [DllImport(libSDL3_TTF)]
        public static extern int TTF_GetFontKerningSizeGlyphs([NativeTypeName("TTF_Font *")] TTF_Font* font, [NativeTypeName("Uint16")] ushort previous_ch, [NativeTypeName("Uint16")] ushort ch);

        [DllImport(libSDL3_TTF)]
        public static extern int TTF_GetFontKerningSizeGlyphs32([NativeTypeName("TTF_Font *")] TTF_Font* font, [NativeTypeName("Uint32")] uint previous_ch, [NativeTypeName("Uint32")] uint ch);

        [DllImport(libSDL3_TTF)]
        public static extern int TTF_SetFontSDF([NativeTypeName("TTF_Font *")] TTF_Font* font, int on_off);

        [DllImport(libSDL3_TTF)]
        public static extern int TTF_GetFontSDF([NativeTypeName("const TTF_Font *")] TTF_Font* font);

        [DllImport(libSDL3_TTF)]
        [Obsolete]
        public static extern int TTF_SetDirection(int direction);

        [DllImport(libSDL3_TTF)]
        [Obsolete]
        public static extern int TTF_SetScript(int script);

        [DllImport(libSDL3_TTF)]
        public static extern int TTF_SetFontDirection([NativeTypeName("TTF_Font *")] TTF_Font* font, TTF_Direction direction);

        [DllImport(libSDL3_TTF)]
        public static extern int TTF_SetFontScriptName([NativeTypeName("TTF_Font *")] TTF_Font* font, [NativeTypeName("const char *")] sbyte* script);

        [DllImport(libSDL3_TTF)]
        public static extern int TTF_IsFontScalable([NativeTypeName("const TTF_Font *")] TTF_Font* font);
    }
}