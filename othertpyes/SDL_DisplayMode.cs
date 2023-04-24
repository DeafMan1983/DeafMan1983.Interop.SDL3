namespace DeafMan1983.Interop.SDL3;

using System;
using static DeafMan1983.Interop.SDL3.SDL3;

public unsafe partial struct SDL_DisplayMode
{
    public SDL_DisplayID displayID;
    public UInt32 format;
    public int pixel_w;
    public int pixel_h; 
    public int screen_w; 
    public int screen_h; 
    public float display_scale; 
    public float refresh_rate;  
    public void *driverdata; 
}