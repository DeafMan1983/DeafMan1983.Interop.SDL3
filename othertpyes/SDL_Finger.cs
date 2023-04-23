namespace DeafMan1983.Interop.SDL3;

using static DeafMan1983.Interop.SDL3.SDL3;

public unsafe partial struct SDL_Finger
{
    public SDL_FingerID id;
    public float x;
    public float y;
    public float pressure;
}