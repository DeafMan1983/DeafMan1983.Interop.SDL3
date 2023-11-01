# DeafMan1983.Interop.SDL3
SDL3 for C#

Edit: if SDL3 is complete release version then I will update libraries,okay?

Please be patient! if you use SDL2 then you can install by dotnet 
`dotnet add package DeafMan1983.Interop.SDL2`

NEW Nuget Package: [See to nuget-website](https://www.nuget.org/packages/DeafMan1983.Interop.SDL3)

# Changes and Fixes:
+ Added SDL3_ttf in C# ( Sorry take longer for SDL3_ttf )
* Added SDL_stdinc in C# Trying to resolve if I copy from *.h to *.cs and format and write own. ( Still in process )
* Replaced SDL_bool to int and some enum SDL_xxxxxxx to uint ( Still in process )
* Fixed and replaced to nint like you have tried Marshal.GetDelegateForFunctionPointer<T>() for GL, EGL and Vulkan too
* Removed operator implicit and explicit from SDL_Renderer ( Sony I forgot to remove! I will recheck and verify for whole SDL3 if they have updated codes in SDL3. )
* Fixed all structures and removed all operator implicit and explicit with void *value cause SDL_MapRGB and MapRGBA crashed.
* Added some SDL_hints define string but not all.... ( Still in process )

* Updated all structures with fake instance like TerraFX.Interop.Xlib's structures
* Changed uint to DisplayID and WindowID

Hello everyone I have made SDL3 for C# and you can use Nuget or here to download.

SDL3 from [SDL3](https://github.com/libsdl-org/SDL)

SDL3_image from [SDL3_image](https://github.com/libsdl-org/SDL_image)

SDL3_ttf from [SDL3_tff](https://github.com/libsdl-org/SDL_ttf)

But for SDL3 C# has 95 % completed converted by ClangSharpPInvokeGenerator but "SDL_stdinc.h" cannot convert to C# complete because ClangSharpPInvokeGenerator stopped to convert whole SDL_stdinc.h to C# format cause it has many errors. I can't resolve but SDL_floot, SDL_fabs etc are not needed just in System.Math and System.MathF

And I would like to release many new tutorial if you know about SDL3 like in C++/C

Enjoy your game development!

Original GitHub Url: [DeafMan1983.Interop.SDL3](https://github.com/DeafMan1983/DeafMan1983.Interop.SDL3)
