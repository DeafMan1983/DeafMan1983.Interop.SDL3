# DeafMan1983.Interop.SDL3
SDL3 for C#

# Changes and Fixes:
* Removed operator implicit and explicit from SDL_Renderer ( Sony I forgot to remove! I will recheck and verify for whole SDL3 if they have updated codes in SDL3. )
* Fixed all structures and removed all operator implicit and explicit with void *value cause SDL_MapRGB and MapRGBA crashed.
* Added some SDL_hints define string but not all....

* Updated all structures with fake instance like TerraFX.Interop.Xlib's structures
* Changed uint to DisplayID and WindowID

Hello everyone I have made SDL3 for C# and you can use Nuget or here to download.

SDL3 from [SDL3](https://github.com/libsdl-org/SDL)
SDL3_image from [SDL3_image](https://github.com/libsdl-org/SDL_image)

But for SDL3 C# has 95 % completed converted by ClangSharpPInvokeGenerator but "SDL_stdinc.h" cannot convert to C# complete because ClangSharpPInvokeGenerator stopped to convert whole SDL_stdinc.h to C# format cause it has many errors. I can't resolve but SDL_floot, SDL_fabs etc are not needed just in System.Math and System.MathF

And I would like to release many new tutorial if you know about SDL3 like in C++/C

Enjoy your game development!
