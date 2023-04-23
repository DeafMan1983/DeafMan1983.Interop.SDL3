namespace DeafMan1983.Interop.SDL3;

using System;
using System.Runtime.InteropServices;

public unsafe static partial class SDL3
{
    private const string libSDL3 = "SDL3";

    [DllImport(libSDL3)]
    public static extern SDL_AssertState SDL_ReportAssertion(SDL_AssertData* data, [NativeTypeName("const char *")] sbyte* func, [NativeTypeName("const char *")] sbyte* file, int line);

    [DllImport(libSDL3)]
    public static extern void SDL_SetAssertionHandler([NativeTypeName("SDL_AssertionHandler")] delegate* unmanaged[Cdecl]<SDL_AssertData*, void*, SDL_AssertState> handler, void* userdata);

    [DllImport(libSDL3)]
    [return: NativeTypeName("SDL_AssertionHandler")]
    public static extern delegate* unmanaged[Cdecl]<SDL_AssertData*, void*, SDL_AssertState> SDL_GetDefaultAssertionHandler();

    [DllImport(libSDL3)]
    [return: NativeTypeName("SDL_AssertionHandler")]
    public static extern delegate* unmanaged[Cdecl]<SDL_AssertData*, void*, SDL_AssertState> SDL_GetAssertionHandler(void** puserdata);

    [DllImport(libSDL3)]
    [return: NativeTypeName("const SDL_AssertData *")]
    public static extern SDL_AssertData* SDL_GetAssertionReport();

    [DllImport(libSDL3)]
    public static extern void SDL_ResetAssertionReport();

    [DllImport(libSDL3)]
    public static extern SDL_bool SDL_AtomicTryLock([NativeTypeName("SDL_SpinLock *")] int* @lock);

    [DllImport(libSDL3)]
    public static extern void SDL_AtomicLock([NativeTypeName("SDL_SpinLock *")] int* @lock);

    [DllImport(libSDL3)]
    public static extern void SDL_AtomicUnlock([NativeTypeName("SDL_SpinLock *")] int* @lock);

    [DllImport(libSDL3)]
    public static extern void SDL_MemoryBarrierReleaseFunction();

    [DllImport(libSDL3)]
    public static extern void SDL_MemoryBarrierAcquireFunction();

    [DllImport(libSDL3)]
    public static extern SDL_bool SDL_AtomicCAS(SDL_atomic_t* a, int oldval, int newval);

    [DllImport(libSDL3)]
    public static extern int SDL_AtomicSet(SDL_atomic_t* a, int v);

    [DllImport(libSDL3)]
    public static extern int SDL_AtomicGet(SDL_atomic_t* a);

    [DllImport(libSDL3)]
    public static extern int SDL_AtomicAdd(SDL_atomic_t* a, int v);

    [DllImport(libSDL3)]
    public static extern SDL_bool SDL_AtomicCASPtr(void** a, void* oldval, void* newval);

    [DllImport(libSDL3)]
    public static extern void* SDL_AtomicSetPtr(void** a, void* v);

    [DllImport(libSDL3)]
    public static extern void* SDL_AtomicGetPtr(void** a);

    [DllImport(libSDL3)]
    public static extern int SDL_GetNumAudioDrivers();

    [DllImport(libSDL3)]
    [return: NativeTypeName("const char *")]
    public static extern sbyte* SDL_GetAudioDriver(int index);

    [DllImport(libSDL3)]
    [return: NativeTypeName("const char *")]
    public static extern sbyte* SDL_GetCurrentAudioDriver();

    [DllImport(libSDL3)]
    public static extern int SDL_GetNumAudioDevices(int iscapture);

    [DllImport(libSDL3)]
    [return: NativeTypeName("const char *")]
    public static extern sbyte* SDL_GetAudioDeviceName(int index, int iscapture);

    [DllImport(libSDL3)]
    public static extern int SDL_GetAudioDeviceSpec(int index, int iscapture, SDL_AudioSpec* spec);

    [DllImport(libSDL3)]
    public static extern int SDL_GetDefaultAudioInfo([NativeTypeName("char **")] sbyte** name, SDL_AudioSpec* spec, int iscapture);

    [DllImport(libSDL3)]
    [return: NativeTypeName("SDL_AudioDeviceID")]
    public static extern uint SDL_OpenAudioDevice([NativeTypeName("const char *")] sbyte* device, int iscapture, [NativeTypeName("const SDL_AudioSpec *")] SDL_AudioSpec* desired, SDL_AudioSpec* obtained, int allowed_changes);

    [DllImport(libSDL3)]
    public static extern SDL_AudioStatus SDL_GetAudioDeviceStatus([NativeTypeName("SDL_AudioDeviceID")] uint dev);

    [DllImport(libSDL3)]
    public static extern int SDL_PlayAudioDevice([NativeTypeName("SDL_AudioDeviceID")] uint dev);

    [DllImport(libSDL3)]
    public static extern int SDL_PauseAudioDevice([NativeTypeName("SDL_AudioDeviceID")] uint dev);

    [DllImport(libSDL3)]
    public static extern SDL_AudioSpec* SDL_LoadWAV_RW(SDL_RWops* src, int freesrc, SDL_AudioSpec* spec, [NativeTypeName("Uint8 **")] byte** audio_buf, [NativeTypeName("Uint32 *")] uint* audio_len);

    [DllImport(libSDL3)]
    public static extern SDL_AudioStream* SDL_CreateAudioStream([NativeTypeName("SDL_AudioFormat")] ushort src_format, [NativeTypeName("Uint8")] byte src_channels, int src_rate, [NativeTypeName("SDL_AudioFormat")] ushort dst_format, [NativeTypeName("Uint8")] byte dst_channels, int dst_rate);

    [DllImport(libSDL3)]
    public static extern int SDL_PutAudioStreamData(SDL_AudioStream* stream, [NativeTypeName("const void *")] void* buf, int len);

    [DllImport(libSDL3)]
    public static extern int SDL_GetAudioStreamData(SDL_AudioStream* stream, void* buf, int len);

    [DllImport(libSDL3)]
    public static extern int SDL_GetAudioStreamAvailable(SDL_AudioStream* stream);

    [DllImport(libSDL3)]
    public static extern int SDL_FlushAudioStream(SDL_AudioStream* stream);

    [DllImport(libSDL3)]
    public static extern int SDL_ClearAudioStream(SDL_AudioStream* stream);

    [DllImport(libSDL3)]
    public static extern void SDL_DestroyAudioStream(SDL_AudioStream* stream);

    [DllImport(libSDL3)]
    public static extern int SDL_MixAudioFormat([NativeTypeName("Uint8 *")] byte* dst, [NativeTypeName("const Uint8 *")] byte* src, [NativeTypeName("SDL_AudioFormat")] ushort format, [NativeTypeName("Uint32")] uint len, int volume);

    [DllImport(libSDL3)]
    public static extern int SDL_QueueAudio([NativeTypeName("SDL_AudioDeviceID")] uint dev, [NativeTypeName("const void *")] void* data, [NativeTypeName("Uint32")] uint len);

    [DllImport(libSDL3)]
    [return: NativeTypeName("Uint32")]
    public static extern uint SDL_DequeueAudio([NativeTypeName("SDL_AudioDeviceID")] uint dev, void* data, [NativeTypeName("Uint32")] uint len);

    [DllImport(libSDL3)]
    [return: NativeTypeName("Uint32")]
    public static extern uint SDL_GetQueuedAudioSize([NativeTypeName("SDL_AudioDeviceID")] uint dev);

    [DllImport(libSDL3)]
    public static extern int SDL_ClearQueuedAudio([NativeTypeName("SDL_AudioDeviceID")] uint dev);

    [DllImport(libSDL3)]
    public static extern int SDL_LockAudioDevice([NativeTypeName("SDL_AudioDeviceID")] uint dev);

    [DllImport(libSDL3)]
    public static extern void SDL_UnlockAudioDevice([NativeTypeName("SDL_AudioDeviceID")] uint dev);

    [DllImport(libSDL3)]
    public static extern void SDL_CloseAudioDevice([NativeTypeName("SDL_AudioDeviceID")] uint dev);

    [DllImport(libSDL3)]
    public static extern int SDL_ConvertAudioSamples([NativeTypeName("SDL_AudioFormat")] ushort src_format, [NativeTypeName("Uint8")] byte src_channels, int src_rate, [NativeTypeName("const Uint8 *")] byte* src_data, int src_len, [NativeTypeName("SDL_AudioFormat")] ushort dst_format, [NativeTypeName("Uint8")] byte dst_channels, int dst_rate, [NativeTypeName("Uint8 **")] byte** dst_data, int* dst_len);

    [DllImport(libSDL3)]
    public static extern SDL_BlendMode SDL_ComposeCustomBlendMode(SDL_BlendFactor srcColorFactor, SDL_BlendFactor dstColorFactor, SDL_BlendOperation colorOperation, SDL_BlendFactor srcAlphaFactor, SDL_BlendFactor dstAlphaFactor, SDL_BlendOperation alphaOperation);

    [DllImport(libSDL3)]
    public static extern int SDL_SetClipboardText([NativeTypeName("const char *")] sbyte* text);

    [DllImport(libSDL3)]
    [return: NativeTypeName("char *")]
    public static extern sbyte* SDL_GetClipboardText();

    [DllImport(libSDL3)]
    public static extern SDL_bool SDL_HasClipboardText();

    [DllImport(libSDL3)]
    public static extern int SDL_SetPrimarySelectionText([NativeTypeName("const char *")] sbyte* text);

    [DllImport(libSDL3)]
    [return: NativeTypeName("char *")]
    public static extern sbyte* SDL_GetPrimarySelectionText();

    [DllImport(libSDL3)]
    public static extern SDL_bool SDL_HasPrimarySelectionText();

    [DllImport(libSDL3)]
    public static extern int SDL_GetCPUCount();

    [DllImport(libSDL3)]
    public static extern int SDL_GetCPUCacheLineSize();

    [DllImport(libSDL3)]
    public static extern SDL_bool SDL_HasRDTSC();

    [DllImport(libSDL3)]
    public static extern SDL_bool SDL_HasAltiVec();

    [DllImport(libSDL3)]
    public static extern SDL_bool SDL_HasMMX();

    [DllImport(libSDL3)]
    public static extern SDL_bool SDL_HasSSE();

    [DllImport(libSDL3)]
    public static extern SDL_bool SDL_HasSSE2();

    [DllImport(libSDL3)]
    public static extern SDL_bool SDL_HasSSE3();

    [DllImport(libSDL3)]
    public static extern SDL_bool SDL_HasSSE41();

    [DllImport(libSDL3)]
    public static extern SDL_bool SDL_HasSSE42();

    [DllImport(libSDL3)]
    public static extern SDL_bool SDL_HasAVX();

    [DllImport(libSDL3)]
    public static extern SDL_bool SDL_HasAVX2();

    [DllImport(libSDL3)]
    public static extern SDL_bool SDL_HasAVX512F();

    [DllImport(libSDL3)]
    public static extern SDL_bool SDL_HasARMSIMD();

    [DllImport(libSDL3)]
    public static extern SDL_bool SDL_HasNEON();

    [DllImport(libSDL3)]
    public static extern SDL_bool SDL_HasLSX();

    [DllImport(libSDL3)]
    public static extern SDL_bool SDL_HasLASX();

    [DllImport(libSDL3)]
    public static extern int SDL_GetSystemRAM();

    [DllImport(libSDL3)]
    [return: NativeTypeName("size_t")]
    public static extern nuint SDL_SIMDGetAlignment();

    [DllImport(libSDL3)]
    public static extern int SDL_SetError([NativeTypeName("const char *")] sbyte* fmt, __arglist);

    [DllImport(libSDL3)]
    [return: NativeTypeName("const char *")]
    public static extern sbyte* SDL_GetError();

    [DllImport(libSDL3)]
    [return: NativeTypeName("char *")]
    public static extern sbyte* SDL_GetErrorMsg([NativeTypeName("char *")] sbyte* errstr, int maxlen);

    [DllImport(libSDL3)]
    public static extern void SDL_ClearError();

    [DllImport(libSDL3)]
    public static extern int SDL_Error(SDL_errorcode code);

    [DllImport(libSDL3)]
    public static extern void SDL_PumpEvents();

    [DllImport(libSDL3)]
    public static extern int SDL_PeepEvents(SDL_Event* events, int numevents, SDL_eventaction action, [NativeTypeName("Uint32")] uint minType, [NativeTypeName("Uint32")] uint maxType);

    [DllImport(libSDL3)]
    public static extern SDL_bool SDL_HasEvent([NativeTypeName("Uint32")] uint type);

    [DllImport(libSDL3)]
    public static extern SDL_bool SDL_HasEvents([NativeTypeName("Uint32")] uint minType, [NativeTypeName("Uint32")] uint maxType);

    [DllImport(libSDL3)]
    public static extern void SDL_FlushEvent([NativeTypeName("Uint32")] uint type);

    [DllImport(libSDL3)]
    public static extern void SDL_FlushEvents([NativeTypeName("Uint32")] uint minType, [NativeTypeName("Uint32")] uint maxType);

    [DllImport(libSDL3)]
    public static extern bool SDL_PollEvent(SDL_Event* @event);

    [DllImport(libSDL3)]
    public static extern bool SDL_WaitEvent(SDL_Event* @event);

    [DllImport(libSDL3)]
    public static extern bool SDL_WaitEventTimeout(SDL_Event* @event, [NativeTypeName("Sint32")] int timeoutMS);

    [DllImport(libSDL3)]
    public static extern bool SDL_PushEvent(SDL_Event* @event);

    [DllImport(libSDL3)]
    public static extern void SDL_SetEventFilter([NativeTypeName("SDL_EventFilter")] delegate* unmanaged[Cdecl]<void*, SDL_Event*, int> filter, void* userdata);

    [DllImport(libSDL3)]
    public static extern SDL_bool SDL_GetEventFilter([NativeTypeName("SDL_EventFilter *")] delegate* unmanaged[Cdecl]<void*, SDL_Event*, int>* filter, void** userdata);

    [DllImport(libSDL3)]
    public static extern void SDL_AddEventWatch([NativeTypeName("SDL_EventFilter")] delegate* unmanaged[Cdecl]<void*, SDL_Event*, int> filter, void* userdata);

    [DllImport(libSDL3)]
    public static extern void SDL_DelEventWatch([NativeTypeName("SDL_EventFilter")] delegate* unmanaged[Cdecl]<void*, SDL_Event*, int> filter, void* userdata);

    [DllImport(libSDL3)]
    public static extern void SDL_FilterEvents([NativeTypeName("SDL_EventFilter")] delegate* unmanaged[Cdecl]<void*, SDL_Event*, int> filter, void* userdata);

    [DllImport(libSDL3)]
    public static extern void SDL_SetEventEnabled([NativeTypeName("Uint32")] uint type, SDL_bool enabled);

    [DllImport(libSDL3)]
    public static extern SDL_bool SDL_EventEnabled([NativeTypeName("Uint32")] uint type);

    [DllImport(libSDL3)]
    [return: NativeTypeName("Uint32")]
    public static extern uint SDL_RegisterEvents(int numevents);

    [DllImport(libSDL3)]
    [return: NativeTypeName("char *")]
    public static extern sbyte* SDL_GetBasePath();

    [DllImport(libSDL3)]
    [return: NativeTypeName("char *")]
    public static extern sbyte* SDL_GetPrefPath([NativeTypeName("const char *")] sbyte* org, [NativeTypeName("const char *")] sbyte* app);

    [DllImport(libSDL3)]
    public static extern int SDL_AddGamepadMapping([NativeTypeName("const char *")] sbyte* mappingString);

    [DllImport(libSDL3)]
    public static extern int SDL_AddGamepadMappingsFromRW(SDL_RWops* rw, int freerw);

    [DllImport(libSDL3)]
    public static extern int SDL_GetNumGamepadMappings();

    [DllImport(libSDL3)]
    [return: NativeTypeName("char *")]
    public static extern sbyte* SDL_GetGamepadMappingForIndex(int mapping_index);

    [DllImport(libSDL3)]
    [return: NativeTypeName("char *")]
    public static extern sbyte* SDL_GetGamepadMappingForGUID([NativeTypeName("SDL_JoystickGUID")] SDL_GUID guid);

    [DllImport(libSDL3)]
    [return: NativeTypeName("char *")]
    public static extern sbyte* SDL_GetGamepadMapping(SDL_Gamepad* gamepad);

    [DllImport(libSDL3)]
    [return: NativeTypeName("SDL_JoystickID *")]
    public static extern uint* SDL_GetGamepads(int* count);

    [DllImport(libSDL3)]
    public static extern SDL_bool SDL_IsGamepad([NativeTypeName("SDL_JoystickID")] uint instance_id);

    [DllImport(libSDL3)]
    [return: NativeTypeName("const char *")]
    public static extern sbyte* SDL_GetGamepadInstanceName([NativeTypeName("SDL_JoystickID")] uint instance_id);

    [DllImport(libSDL3)]
    [return: NativeTypeName("const char *")]
    public static extern sbyte* SDL_GetGamepadInstancePath([NativeTypeName("SDL_JoystickID")] uint instance_id);

    [DllImport(libSDL3)]
    public static extern int SDL_GetGamepadInstancePlayerIndex([NativeTypeName("SDL_JoystickID")] uint instance_id);

    [DllImport(libSDL3)]
    [return: NativeTypeName("SDL_JoystickGUID")]
    public static extern SDL_GUID SDL_GetGamepadInstanceGUID([NativeTypeName("SDL_JoystickID")] uint instance_id);

    [DllImport(libSDL3)]
    [return: NativeTypeName("Uint16")]
    public static extern ushort SDL_GetGamepadInstanceVendor([NativeTypeName("SDL_JoystickID")] uint instance_id);

    [DllImport(libSDL3)]
    [return: NativeTypeName("Uint16")]
    public static extern ushort SDL_GetGamepadInstanceProduct([NativeTypeName("SDL_JoystickID")] uint instance_id);

    [DllImport(libSDL3)]
    [return: NativeTypeName("Uint16")]
    public static extern ushort SDL_GetGamepadInstanceProductVersion([NativeTypeName("SDL_JoystickID")] uint instance_id);

    [DllImport(libSDL3)]
    public static extern SDL_GamepadType SDL_GetGamepadInstanceType([NativeTypeName("SDL_JoystickID")] uint instance_id);

    [DllImport(libSDL3)]
    [return: NativeTypeName("char *")]
    public static extern sbyte* SDL_GetGamepadInstanceMapping([NativeTypeName("SDL_JoystickID")] uint instance_id);

    [DllImport(libSDL3)]
    public static extern SDL_Gamepad* SDL_OpenGamepad([NativeTypeName("SDL_JoystickID")] uint instance_id);

    [DllImport(libSDL3)]
    public static extern SDL_Gamepad* SDL_GetGamepadFromInstanceID([NativeTypeName("SDL_JoystickID")] uint instance_id);

    [DllImport(libSDL3)]
    public static extern SDL_Gamepad* SDL_GetGamepadFromPlayerIndex(int player_index);

    [DllImport(libSDL3)]
    [return: NativeTypeName("const char *")]
    public static extern sbyte* SDL_GetGamepadName(SDL_Gamepad* gamepad);

    [DllImport(libSDL3)]
    [return: NativeTypeName("const char *")]
    public static extern sbyte* SDL_GetGamepadPath(SDL_Gamepad* gamepad);

    [DllImport(libSDL3)]
    public static extern SDL_GamepadType SDL_GetGamepadType(SDL_Gamepad* gamepad);

    [DllImport(libSDL3)]
    public static extern int SDL_GetGamepadPlayerIndex(SDL_Gamepad* gamepad);

    [DllImport(libSDL3)]
    public static extern int SDL_SetGamepadPlayerIndex(SDL_Gamepad* gamepad, int player_index);

    [DllImport(libSDL3)]
    [return: NativeTypeName("Uint16")]
    public static extern ushort SDL_GetGamepadVendor(SDL_Gamepad* gamepad);

    [DllImport(libSDL3)]
    [return: NativeTypeName("Uint16")]
    public static extern ushort SDL_GetGamepadProduct(SDL_Gamepad* gamepad);

    [DllImport(libSDL3)]
    [return: NativeTypeName("Uint16")]
    public static extern ushort SDL_GetGamepadProductVersion(SDL_Gamepad* gamepad);

    [DllImport(libSDL3)]
    [return: NativeTypeName("Uint16")]
    public static extern ushort SDL_GetGamepadFirmwareVersion(SDL_Gamepad* gamepad);

    [DllImport(libSDL3)]
    [return: NativeTypeName("const char *")]
    public static extern sbyte* SDL_GetGamepadSerial(SDL_Gamepad* gamepad);

    [DllImport(libSDL3)]
    public static extern SDL_bool SDL_GamepadConnected(SDL_Gamepad* gamepad);

    [DllImport(libSDL3)]
    public static extern SDL_Joystick* SDL_GetGamepadJoystick(SDL_Gamepad* gamepad);

    [DllImport(libSDL3)]
    public static extern void SDL_SetGamepadEventsEnabled(SDL_bool enabled);

    [DllImport(libSDL3)]
    public static extern SDL_bool SDL_GamepadEventsEnabled();

    [DllImport(libSDL3)]
    public static extern void SDL_UpdateGamepads();

    [DllImport(libSDL3)]
    public static extern SDL_GamepadAxis SDL_GetGamepadAxisFromString([NativeTypeName("const char *")] sbyte* str);

    [DllImport(libSDL3)]
    [return: NativeTypeName("const char *")]
    public static extern sbyte* SDL_GetGamepadStringForAxis(SDL_GamepadAxis axis);

    [DllImport(libSDL3)]
    public static extern SDL_GamepadBinding SDL_GetGamepadBindForAxis(SDL_Gamepad* gamepad, SDL_GamepadAxis axis);

    [DllImport(libSDL3)]
    public static extern SDL_bool SDL_GamepadHasAxis(SDL_Gamepad* gamepad, SDL_GamepadAxis axis);

    [DllImport(libSDL3)]
    [return: NativeTypeName("Sint16")]
    public static extern short SDL_GetGamepadAxis(SDL_Gamepad* gamepad, SDL_GamepadAxis axis);

    [DllImport(libSDL3)]
    public static extern SDL_GamepadButton SDL_GetGamepadButtonFromString([NativeTypeName("const char *")] sbyte* str);

    [DllImport(libSDL3)]
    [return: NativeTypeName("const char *")]
    public static extern sbyte* SDL_GetGamepadStringForButton(SDL_GamepadButton button);

    [DllImport(libSDL3)]
    public static extern SDL_GamepadBinding SDL_GetGamepadBindForButton(SDL_Gamepad* gamepad, SDL_GamepadButton button);

    [DllImport(libSDL3)]
    public static extern SDL_bool SDL_GamepadHasButton(SDL_Gamepad* gamepad, SDL_GamepadButton button);

    [DllImport(libSDL3)]
    [return: NativeTypeName("Uint8")]
    public static extern byte SDL_GetGamepadButton(SDL_Gamepad* gamepad, SDL_GamepadButton button);

    [DllImport(libSDL3)]
    public static extern int SDL_GetNumGamepadTouchpads(SDL_Gamepad* gamepad);

    [DllImport(libSDL3)]
    public static extern int SDL_GetNumGamepadTouchpadFingers(SDL_Gamepad* gamepad, int touchpad);

    [DllImport(libSDL3)]
    public static extern int SDL_GetGamepadTouchpadFinger(SDL_Gamepad* gamepad, int touchpad, int finger, [NativeTypeName("Uint8 *")] byte* state, float* x, float* y, float* pressure);

    [DllImport(libSDL3)]
    public static extern SDL_bool SDL_GamepadHasSensor(SDL_Gamepad* gamepad, SDL_SensorType type);

    [DllImport(libSDL3)]
    public static extern int SDL_SetGamepadSensorEnabled(SDL_Gamepad* gamepad, SDL_SensorType type, SDL_bool enabled);

    [DllImport(libSDL3)]
    public static extern SDL_bool SDL_GamepadSensorEnabled(SDL_Gamepad* gamepad, SDL_SensorType type);

    [DllImport(libSDL3)]
    public static extern float SDL_GetGamepadSensorDataRate(SDL_Gamepad* gamepad, SDL_SensorType type);

    [DllImport(libSDL3)]
    public static extern int SDL_GetGamepadSensorData(SDL_Gamepad* gamepad, SDL_SensorType type, float* data, int num_values);

    [DllImport(libSDL3)]
    public static extern int SDL_RumbleGamepad(SDL_Gamepad* gamepad, [NativeTypeName("Uint16")] ushort low_frequency_rumble, [NativeTypeName("Uint16")] ushort high_frequency_rumble, [NativeTypeName("Uint32")] uint duration_ms);

    [DllImport(libSDL3)]
    public static extern int SDL_RumbleGamepadTriggers(SDL_Gamepad* gamepad, [NativeTypeName("Uint16")] ushort left_rumble, [NativeTypeName("Uint16")] ushort right_rumble, [NativeTypeName("Uint32")] uint duration_ms);

    [DllImport(libSDL3)]
    public static extern SDL_bool SDL_GamepadHasLED(SDL_Gamepad* gamepad);

    [DllImport(libSDL3)]
    public static extern SDL_bool SDL_GamepadHasRumble(SDL_Gamepad* gamepad);

    [DllImport(libSDL3)]
    public static extern SDL_bool SDL_GamepadHasRumbleTriggers(SDL_Gamepad* gamepad);

    [DllImport(libSDL3)]
    public static extern int SDL_SetGamepadLED(SDL_Gamepad* gamepad, [NativeTypeName("Uint8")] byte red, [NativeTypeName("Uint8")] byte green, [NativeTypeName("Uint8")] byte blue);

    [DllImport(libSDL3)]
    public static extern int SDL_SendGamepadEffect(SDL_Gamepad* gamepad, [NativeTypeName("const void *")] void* data, int size);

    [DllImport(libSDL3)]
    public static extern void SDL_CloseGamepad(SDL_Gamepad* gamepad);

    [DllImport(libSDL3)]
    [return: NativeTypeName("const char *")]
    public static extern sbyte* SDL_GetGamepadAppleSFSymbolsNameForButton(SDL_Gamepad* gamepad, SDL_GamepadButton button);

    [DllImport(libSDL3)]
    [return: NativeTypeName("const char *")]
    public static extern sbyte* SDL_GetGamepadAppleSFSymbolsNameForAxis(SDL_Gamepad* gamepad, SDL_GamepadAxis axis);

    [DllImport(libSDL3)]
    public static extern int SDL_NumHaptics();

    [DllImport(libSDL3)]
    [return: NativeTypeName("const char *")]
    public static extern sbyte* SDL_HapticName(int device_index);

    [DllImport(libSDL3)]
    public static extern SDL_Haptic* SDL_HapticOpen(int device_index);

    [DllImport(libSDL3)]
    public static extern int SDL_HapticOpened(int device_index);

    [DllImport(libSDL3)]
    public static extern int SDL_HapticIndex(SDL_Haptic* haptic);

    [DllImport(libSDL3)]
    public static extern int SDL_MouseIsHaptic();

    [DllImport(libSDL3)]
    public static extern SDL_Haptic* SDL_HapticOpenFromMouse();

    [DllImport(libSDL3)]
    public static extern int SDL_JoystickIsHaptic(SDL_Joystick* joystick);

    [DllImport(libSDL3)]
    public static extern SDL_Haptic* SDL_HapticOpenFromJoystick(SDL_Joystick* joystick);

    [DllImport(libSDL3)]
    public static extern void SDL_HapticClose(SDL_Haptic* haptic);

    [DllImport(libSDL3)]
    public static extern int SDL_HapticNumEffects(SDL_Haptic* haptic);

    [DllImport(libSDL3)]
    public static extern int SDL_HapticNumEffectsPlaying(SDL_Haptic* haptic);

    [DllImport(libSDL3)]
    [return: NativeTypeName("unsigned int")]
    public static extern uint SDL_HapticQuery(SDL_Haptic* haptic);

    [DllImport(libSDL3)]
    public static extern int SDL_HapticNumAxes(SDL_Haptic* haptic);

    [DllImport(libSDL3)]
    public static extern int SDL_HapticEffectSupported(SDL_Haptic* haptic, SDL_HapticEffect* effect);

    [DllImport(libSDL3)]
    public static extern int SDL_HapticNewEffect(SDL_Haptic* haptic, SDL_HapticEffect* effect);

    [DllImport(libSDL3)]
    public static extern int SDL_HapticUpdateEffect(SDL_Haptic* haptic, int effect, SDL_HapticEffect* data);

    [DllImport(libSDL3)]
    public static extern int SDL_HapticRunEffect(SDL_Haptic* haptic, int effect, [NativeTypeName("Uint32")] uint iterations);

    [DllImport(libSDL3)]
    public static extern int SDL_HapticStopEffect(SDL_Haptic* haptic, int effect);

    [DllImport(libSDL3)]
    public static extern void SDL_HapticDestroyEffect(SDL_Haptic* haptic, int effect);

    [DllImport(libSDL3)]
    public static extern int SDL_HapticGetEffectStatus(SDL_Haptic* haptic, int effect);

    [DllImport(libSDL3)]
    public static extern int SDL_HapticSetGain(SDL_Haptic* haptic, int gain);

    [DllImport(libSDL3)]
    public static extern int SDL_HapticSetAutocenter(SDL_Haptic* haptic, int autocenter);

    [DllImport(libSDL3)]
    public static extern int SDL_HapticPause(SDL_Haptic* haptic);

    [DllImport(libSDL3)]
    public static extern int SDL_HapticUnpause(SDL_Haptic* haptic);

    [DllImport(libSDL3)]
    public static extern int SDL_HapticStopAll(SDL_Haptic* haptic);

    [DllImport(libSDL3)]
    public static extern int SDL_HapticRumbleSupported(SDL_Haptic* haptic);

    [DllImport(libSDL3)]
    public static extern int SDL_HapticRumbleInit(SDL_Haptic* haptic);

    [DllImport(libSDL3)]
    public static extern int SDL_HapticRumblePlay(SDL_Haptic* haptic, float strength, [NativeTypeName("Uint32")] uint length);

    [DllImport(libSDL3)]
    public static extern int SDL_HapticRumbleStop(SDL_Haptic* haptic);

    [DllImport(libSDL3)]
    public static extern int SDL_hid_init();

    [DllImport(libSDL3)]
    public static extern int SDL_hid_exit();

    [DllImport(libSDL3)]
    [return: NativeTypeName("Uint32")]
    public static extern uint SDL_hid_device_change_count();

    [DllImport(libSDL3)]
    public static extern SDL_hid_device_info* SDL_hid_enumerate([NativeTypeName("unsigned short")] ushort vendor_id, [NativeTypeName("unsigned short")] ushort product_id);

    [DllImport(libSDL3)]
    public static extern void SDL_hid_free_enumeration(SDL_hid_device_info* devs);

    [DllImport(libSDL3)]
    [return: NativeTypeName("SDL_hid_device *")]
    public static extern SDL_hid_device_* SDL_hid_open([NativeTypeName("unsigned short")] ushort vendor_id, [NativeTypeName("unsigned short")] ushort product_id, [NativeTypeName("const wchar_t *")] uint* serial_number);

    [DllImport(libSDL3)]
    [return: NativeTypeName("SDL_hid_device *")]
    public static extern SDL_hid_device_* SDL_hid_open_path([NativeTypeName("const char *")] sbyte* path, int bExclusive);

    [DllImport(libSDL3)]
    public static extern int SDL_hid_write([NativeTypeName("SDL_hid_device *")] SDL_hid_device_* dev, [NativeTypeName("const unsigned char *")] byte* data, [NativeTypeName("size_t")] nuint length);

    [DllImport(libSDL3)]
    public static extern int SDL_hid_read_timeout([NativeTypeName("SDL_hid_device *")] SDL_hid_device_* dev, [NativeTypeName("unsigned char *")] byte* data, [NativeTypeName("size_t")] nuint length, int milliseconds);

    [DllImport(libSDL3)]
    public static extern int SDL_hid_read([NativeTypeName("SDL_hid_device *")] SDL_hid_device_* dev, [NativeTypeName("unsigned char *")] byte* data, [NativeTypeName("size_t")] nuint length);

    [DllImport(libSDL3)]
    public static extern int SDL_hid_set_nonblocking([NativeTypeName("SDL_hid_device *")] SDL_hid_device_* dev, int nonblock);

    [DllImport(libSDL3)]
    public static extern int SDL_hid_send_feature_report([NativeTypeName("SDL_hid_device *")] SDL_hid_device_* dev, [NativeTypeName("const unsigned char *")] byte* data, [NativeTypeName("size_t")] nuint length);

    [DllImport(libSDL3)]
    public static extern int SDL_hid_get_feature_report([NativeTypeName("SDL_hid_device *")] SDL_hid_device_* dev, [NativeTypeName("unsigned char *")] byte* data, [NativeTypeName("size_t")] nuint length);

    [DllImport(libSDL3)]
    public static extern int SDL_hid_close([NativeTypeName("SDL_hid_device *")] SDL_hid_device_* dev);

    [DllImport(libSDL3)]
    public static extern int SDL_hid_get_manufacturer_string([NativeTypeName("SDL_hid_device *")] SDL_hid_device_* dev, [NativeTypeName("wchar_t *")] uint* @string, [NativeTypeName("size_t")] nuint maxlen);

    [DllImport(libSDL3)]
    public static extern int SDL_hid_get_product_string([NativeTypeName("SDL_hid_device *")] SDL_hid_device_* dev, [NativeTypeName("wchar_t *")] uint* @string, [NativeTypeName("size_t")] nuint maxlen);

    [DllImport(libSDL3)]
    public static extern int SDL_hid_get_serial_number_string([NativeTypeName("SDL_hid_device *")] SDL_hid_device_* dev, [NativeTypeName("wchar_t *")] uint* @string, [NativeTypeName("size_t")] nuint maxlen);

    [DllImport(libSDL3)]
    public static extern int SDL_hid_get_indexed_string([NativeTypeName("SDL_hid_device *")] SDL_hid_device_* dev, int string_index, [NativeTypeName("wchar_t *")] uint* @string, [NativeTypeName("size_t")] nuint maxlen);

    [DllImport(libSDL3)]
    public static extern void SDL_hid_ble_scan(SDL_bool active);

    [DllImport(libSDL3)]
    public static extern int SDL_GUIDToString(SDL_GUID guid, [NativeTypeName("char *")] sbyte* pszGUID, int cbGUID);

    [DllImport(libSDL3)]
    public static extern SDL_GUID SDL_GUIDFromString([NativeTypeName("const char *")] sbyte* pchGUID);

    [DllImport(libSDL3)]
    public static extern SDL_bool SDL_SetHintWithPriority([NativeTypeName("const char *")] sbyte* name, [NativeTypeName("const char *")] sbyte* value, SDL_HintPriority priority);

    [DllImport(libSDL3)]
    public static extern SDL_bool SDL_SetHint([NativeTypeName("const char *")] sbyte* name, [NativeTypeName("const char *")] sbyte* value);

    [DllImport(libSDL3)]
    public static extern SDL_bool SDL_ResetHint([NativeTypeName("const char *")] sbyte* name);

    [DllImport(libSDL3)]
    public static extern void SDL_ResetHints();

    [DllImport(libSDL3)]
    [return: NativeTypeName("const char *")]
    public static extern sbyte* SDL_GetHint([NativeTypeName("const char *")] sbyte* name);

    [DllImport(libSDL3)]
    public static extern SDL_bool SDL_GetHintBoolean([NativeTypeName("const char *")] sbyte* name, SDL_bool default_value);

    [DllImport(libSDL3)]
    public static extern int SDL_AddHintCallback([NativeTypeName("const char *")] sbyte* name, [NativeTypeName("SDL_HintCallback")] delegate* unmanaged[Cdecl]<void*, sbyte*, sbyte*, sbyte*, void> callback, void* userdata);

    [DllImport(libSDL3)]
    public static extern void SDL_DelHintCallback([NativeTypeName("const char *")] sbyte* name, [NativeTypeName("SDL_HintCallback")] delegate* unmanaged[Cdecl]<void*, sbyte*, sbyte*, sbyte*, void> callback, void* userdata);

    [DllImport(libSDL3)]
    public static extern void SDL_ClearHints();

    [DllImport(libSDL3)]
    public static extern bool SDL_Init(UInt32 flags);

    [DllImport(libSDL3)]
    public static extern bool SDL_InitSubSystem(UInt32 flags);

    [DllImport(libSDL3)]
    public static extern UInt32 SDL_WasInit(UInt32 flags);

    [DllImport(libSDL3)]
    public static extern void SDL_Quit();

    [DllImport(libSDL3)]
    public static extern void SDL_QuitSubSystem([NativeTypeName("Uint32")] uint flags);

    [DllImport(libSDL3)]
    public static extern void SDL_LockJoysticks();

    [DllImport(libSDL3)]
    public static extern void SDL_UnlockJoysticks();

    [DllImport(libSDL3)]
    [return: NativeTypeName("SDL_JoystickID *")]
    public static extern uint* SDL_GetJoysticks(int* count);

    [DllImport(libSDL3)]
    [return: NativeTypeName("const char *")]
    public static extern sbyte* SDL_GetJoystickInstanceName([NativeTypeName("SDL_JoystickID")] uint instance_id);

    [DllImport(libSDL3)]
    [return: NativeTypeName("const char *")]
    public static extern sbyte* SDL_GetJoystickInstancePath([NativeTypeName("SDL_JoystickID")] uint instance_id);

    [DllImport(libSDL3)]
    public static extern int SDL_GetJoystickInstancePlayerIndex([NativeTypeName("SDL_JoystickID")] uint instance_id);

    [DllImport(libSDL3)]
    [return: NativeTypeName("SDL_JoystickGUID")]
    public static extern SDL_GUID SDL_GetJoystickInstanceGUID([NativeTypeName("SDL_JoystickID")] uint instance_id);

    [DllImport(libSDL3)]
    [return: NativeTypeName("Uint16")]
    public static extern ushort SDL_GetJoystickInstanceVendor([NativeTypeName("SDL_JoystickID")] uint instance_id);

    [DllImport(libSDL3)]
    [return: NativeTypeName("Uint16")]
    public static extern ushort SDL_GetJoystickInstanceProduct([NativeTypeName("SDL_JoystickID")] uint instance_id);

    [DllImport(libSDL3)]
    [return: NativeTypeName("Uint16")]
    public static extern ushort SDL_GetJoystickInstanceProductVersion([NativeTypeName("SDL_JoystickID")] uint instance_id);

    [DllImport(libSDL3)]
    public static extern SDL_JoystickType SDL_GetJoystickInstanceType([NativeTypeName("SDL_JoystickID")] uint instance_id);

    [DllImport(libSDL3)]
    public static extern SDL_Joystick* SDL_OpenJoystick([NativeTypeName("SDL_JoystickID")] uint instance_id);

    [DllImport(libSDL3)]
    public static extern SDL_Joystick* SDL_GetJoystickFromInstanceID([NativeTypeName("SDL_JoystickID")] uint instance_id);

    [DllImport(libSDL3)]
    public static extern SDL_Joystick* SDL_GetJoystickFromPlayerIndex(int player_index);

    [DllImport(libSDL3)]
    [return: NativeTypeName("SDL_JoystickID")]
    public static extern uint SDL_AttachVirtualJoystick(SDL_JoystickType type, int naxes, int nbuttons, int nhats);

    [DllImport(libSDL3)]
    [return: NativeTypeName("SDL_JoystickID")]
    public static extern uint SDL_AttachVirtualJoystickEx([NativeTypeName("const SDL_VirtualJoystickDesc *")] SDL_VirtualJoystickDesc* desc);

    [DllImport(libSDL3)]
    public static extern int SDL_DetachVirtualJoystick([NativeTypeName("SDL_JoystickID")] uint instance_id);

    [DllImport(libSDL3)]
    public static extern SDL_bool SDL_IsJoystickVirtual([NativeTypeName("SDL_JoystickID")] uint instance_id);

    [DllImport(libSDL3)]
    public static extern int SDL_SetJoystickVirtualAxis(SDL_Joystick* joystick, int axis, [NativeTypeName("Sint16")] short value);

    [DllImport(libSDL3)]
    public static extern int SDL_SetJoystickVirtualButton(SDL_Joystick* joystick, int button, [NativeTypeName("Uint8")] byte value);

    [DllImport(libSDL3)]
    public static extern int SDL_SetJoystickVirtualHat(SDL_Joystick* joystick, int hat, [NativeTypeName("Uint8")] byte value);

    [DllImport(libSDL3)]
    [return: NativeTypeName("const char *")]
    public static extern sbyte* SDL_GetJoystickName(SDL_Joystick* joystick);

    [DllImport(libSDL3)]
    [return: NativeTypeName("const char *")]
    public static extern sbyte* SDL_GetJoystickPath(SDL_Joystick* joystick);

    [DllImport(libSDL3)]
    public static extern int SDL_GetJoystickPlayerIndex(SDL_Joystick* joystick);

    [DllImport(libSDL3)]
    public static extern int SDL_SetJoystickPlayerIndex(SDL_Joystick* joystick, int player_index);

    [DllImport(libSDL3)]
    [return: NativeTypeName("SDL_JoystickGUID")]
    public static extern SDL_GUID SDL_GetJoystickGUID(SDL_Joystick* joystick);

    [DllImport(libSDL3)]
    [return: NativeTypeName("Uint16")]
    public static extern ushort SDL_GetJoystickVendor(SDL_Joystick* joystick);

    [DllImport(libSDL3)]
    [return: NativeTypeName("Uint16")]
    public static extern ushort SDL_GetJoystickProduct(SDL_Joystick* joystick);

    [DllImport(libSDL3)]
    [return: NativeTypeName("Uint16")]
    public static extern ushort SDL_GetJoystickProductVersion(SDL_Joystick* joystick);

    [DllImport(libSDL3)]
    [return: NativeTypeName("Uint16")]
    public static extern ushort SDL_GetJoystickFirmwareVersion(SDL_Joystick* joystick);

    [DllImport(libSDL3)]
    [return: NativeTypeName("const char *")]
    public static extern sbyte* SDL_GetJoystickSerial(SDL_Joystick* joystick);

    [DllImport(libSDL3)]
    public static extern SDL_JoystickType SDL_GetJoystickType(SDL_Joystick* joystick);

    [DllImport(libSDL3)]
    public static extern int SDL_GetJoystickGUIDString([NativeTypeName("SDL_JoystickGUID")] SDL_GUID guid, [NativeTypeName("char *")] sbyte* pszGUID, int cbGUID);

    [DllImport(libSDL3)]
    [return: NativeTypeName("SDL_JoystickGUID")]
    public static extern SDL_GUID SDL_GetJoystickGUIDFromString([NativeTypeName("const char *")] sbyte* pchGUID);

    [DllImport(libSDL3)]
    public static extern void SDL_GetJoystickGUIDInfo([NativeTypeName("SDL_JoystickGUID")] SDL_GUID guid, [NativeTypeName("Uint16 *")] ushort* vendor, [NativeTypeName("Uint16 *")] ushort* product, [NativeTypeName("Uint16 *")] ushort* version, [NativeTypeName("Uint16 *")] ushort* crc16);

    [DllImport(libSDL3)]
    public static extern SDL_bool SDL_JoystickConnected(SDL_Joystick* joystick);

    [DllImport(libSDL3)]
    [return: NativeTypeName("SDL_JoystickID")]
    public static extern uint SDL_GetJoystickInstanceID(SDL_Joystick* joystick);

    [DllImport(libSDL3)]
    public static extern int SDL_GetNumJoystickAxes(SDL_Joystick* joystick);

    [DllImport(libSDL3)]
    public static extern int SDL_GetNumJoystickHats(SDL_Joystick* joystick);

    [DllImport(libSDL3)]
    public static extern int SDL_GetNumJoystickButtons(SDL_Joystick* joystick);

    [DllImport(libSDL3)]
    public static extern void SDL_SetJoystickEventsEnabled(SDL_bool enabled);

    [DllImport(libSDL3)]
    public static extern SDL_bool SDL_JoystickEventsEnabled();

    [DllImport(libSDL3)]
    public static extern void SDL_UpdateJoysticks();

    [DllImport(libSDL3)]
    [return: NativeTypeName("Sint16")]
    public static extern short SDL_GetJoystickAxis(SDL_Joystick* joystick, int axis);

    [DllImport(libSDL3)]
    public static extern SDL_bool SDL_GetJoystickAxisInitialState(SDL_Joystick* joystick, int axis, [NativeTypeName("Sint16 *")] short* state);

    [DllImport(libSDL3)]
    [return: NativeTypeName("Uint8")]
    public static extern byte SDL_GetJoystickHat(SDL_Joystick* joystick, int hat);

    [DllImport(libSDL3)]
    [return: NativeTypeName("Uint8")]
    public static extern byte SDL_GetJoystickButton(SDL_Joystick* joystick, int button);

    [DllImport(libSDL3)]
    public static extern int SDL_RumbleJoystick(SDL_Joystick* joystick, [NativeTypeName("Uint16")] ushort low_frequency_rumble, [NativeTypeName("Uint16")] ushort high_frequency_rumble, [NativeTypeName("Uint32")] uint duration_ms);

    [DllImport(libSDL3)]
    public static extern int SDL_RumbleJoystickTriggers(SDL_Joystick* joystick, [NativeTypeName("Uint16")] ushort left_rumble, [NativeTypeName("Uint16")] ushort right_rumble, [NativeTypeName("Uint32")] uint duration_ms);

    [DllImport(libSDL3)]
    public static extern SDL_bool SDL_JoystickHasLED(SDL_Joystick* joystick);

    [DllImport(libSDL3)]
    public static extern SDL_bool SDL_JoystickHasRumble(SDL_Joystick* joystick);

    [DllImport(libSDL3)]
    public static extern SDL_bool SDL_JoystickHasRumbleTriggers(SDL_Joystick* joystick);

    [DllImport(libSDL3)]
    public static extern int SDL_SetJoystickLED(SDL_Joystick* joystick, [NativeTypeName("Uint8")] byte red, [NativeTypeName("Uint8")] byte green, [NativeTypeName("Uint8")] byte blue);

    [DllImport(libSDL3)]
    public static extern int SDL_SendJoystickEffect(SDL_Joystick* joystick, [NativeTypeName("const void *")] void* data, int size);

    [DllImport(libSDL3)]
    public static extern void SDL_CloseJoystick(SDL_Joystick* joystick);

    [DllImport(libSDL3)]
    public static extern SDL_JoystickPowerLevel SDL_GetJoystickPowerLevel(SDL_Joystick* joystick);

    [DllImport(libSDL3)]
    public static extern SDL_Window* SDL_GetKeyboardFocus();

    [DllImport(libSDL3)]
    [return: NativeTypeName("const Uint8 *")]
    public static extern byte* SDL_GetKeyboardState(int* numkeys);

    [DllImport(libSDL3)]
    public static extern void SDL_ResetKeyboard();

    [DllImport(libSDL3)]
    public static extern SDL_Keymod SDL_GetModState();

    [DllImport(libSDL3)]
    public static extern void SDL_SetModState(SDL_Keymod modstate);

    [DllImport(libSDL3)]
    [return: NativeTypeName("SDL_Keycode")]
    public static extern int SDL_GetKeyFromScancode(SDL_Scancode scancode);

    [DllImport(libSDL3)]
    public static extern SDL_Scancode SDL_GetScancodeFromKey([NativeTypeName("SDL_Keycode")] int key);

    [DllImport(libSDL3)]
    [return: NativeTypeName("const char *")]
    public static extern sbyte* SDL_GetScancodeName(SDL_Scancode scancode);

    [DllImport(libSDL3)]
    public static extern SDL_Scancode SDL_GetScancodeFromName([NativeTypeName("const char *")] sbyte* name);

    [DllImport(libSDL3)]
    [return: NativeTypeName("const char *")]
    public static extern sbyte* SDL_GetKeyName([NativeTypeName("SDL_Keycode")] int key);

    [DllImport(libSDL3)]
    [return: NativeTypeName("SDL_Keycode")]
    public static extern int SDL_GetKeyFromName([NativeTypeName("const char *")] sbyte* name);

    [DllImport(libSDL3)]
    public static extern void SDL_StartTextInput();

    [DllImport(libSDL3)]
    public static extern SDL_bool SDL_TextInputActive();

    [DllImport(libSDL3)]
    public static extern void SDL_StopTextInput();

    [DllImport(libSDL3)]
    public static extern void SDL_ClearComposition();

    [DllImport(libSDL3)]
    public static extern SDL_bool SDL_TextInputShown();

    [DllImport(libSDL3)]
    public static extern int SDL_SetTextInputRect([NativeTypeName("const SDL_Rect *")] SDL_Rect* rect);

    [DllImport(libSDL3)]
    public static extern SDL_bool SDL_HasScreenKeyboardSupport();

    [DllImport(libSDL3)]
    public static extern SDL_bool SDL_ScreenKeyboardShown(SDL_Window* window);

    [DllImport(libSDL3)]
    public static extern void* SDL_LoadObject([NativeTypeName("const char *")] sbyte* sofile);

    [DllImport(libSDL3)]
    [return: NativeTypeName("SDL_FunctionPointer")]
    public static extern delegate* unmanaged[Cdecl]<void> SDL_LoadFunction(void* handle, [NativeTypeName("const char *")] sbyte* name);

    [DllImport(libSDL3)]
    public static extern void SDL_UnloadObject(void* handle);

    [DllImport(libSDL3)]
    public static extern SDL_Locale* SDL_GetPreferredLocales();

    [DllImport(libSDL3)]
    public static extern void SDL_LogSetAllPriority(SDL_LogPriority priority);

    [DllImport(libSDL3)]
    public static extern void SDL_LogSetPriority(int category, SDL_LogPriority priority);

    [DllImport(libSDL3)]
    public static extern SDL_LogPriority SDL_LogGetPriority(int category);

    [DllImport(libSDL3)]
    public static extern void SDL_LogResetPriorities();

    [DllImport(libSDL3)]
    public static extern void SDL_Log([NativeTypeName("const char *")] sbyte* fmt, __arglist);

    [DllImport(libSDL3)]
    public static extern void SDL_LogVerbose(int category, [NativeTypeName("const char *")] sbyte* fmt, __arglist);

    [DllImport(libSDL3)]
    public static extern void SDL_LogDebug(int category, [NativeTypeName("const char *")] sbyte* fmt, __arglist);

    [DllImport(libSDL3)]
    public static extern void SDL_LogInfo(int category, [NativeTypeName("const char *")] sbyte* fmt, __arglist);

    [DllImport(libSDL3)]
    public static extern void SDL_LogWarn(int category, [NativeTypeName("const char *")] sbyte* fmt, __arglist);

    [DllImport(libSDL3)]
    public static extern void SDL_LogError(int category, [NativeTypeName("const char *")] sbyte* fmt, __arglist);

    [DllImport(libSDL3)]
    public static extern void SDL_LogCritical(int category, [NativeTypeName("const char *")] sbyte* fmt, __arglist);

    [DllImport(libSDL3)]
    public static extern void SDL_LogMessage(int category, SDL_LogPriority priority, [NativeTypeName("const char *")] sbyte* fmt, __arglist);

    [DllImport(libSDL3)]
    public static extern void SDL_LogMessageV(int category, SDL_LogPriority priority, [NativeTypeName("const char *")] sbyte* fmt, sbyte **ap);

    [DllImport(libSDL3)]
    public static extern void SDL_LogGetOutputFunction([NativeTypeName("SDL_LogOutputFunction *")] delegate* unmanaged[Cdecl]<void*, int, SDL_LogPriority, sbyte*, void>* callback, void** userdata);

    [DllImport(libSDL3)]
    public static extern void SDL_LogSetOutputFunction([NativeTypeName("SDL_LogOutputFunction")] delegate* unmanaged[Cdecl]<void*, int, SDL_LogPriority, sbyte*, void> callback, void* userdata);

    [DllImport(libSDL3)]
    public static extern int SDL_main(int argc, [NativeTypeName("char *[]")] sbyte** argv);

    [DllImport(libSDL3)]
    public static extern void SDL_SetMainReady();

    [DllImport(libSDL3)]
    public static extern int SDL_RunApp(int argc, [NativeTypeName("char *[]")] sbyte** argv, [NativeTypeName("SDL_main_func")] delegate* unmanaged[Cdecl]<int, sbyte**, int> mainFunction, void* reserved);

    [DllImport(libSDL3)]
    public static extern int SDL_ShowMessageBox([NativeTypeName("const SDL_MessageBoxData *")] SDL_MessageBoxData* messageboxdata, int* buttonid);

    [DllImport(libSDL3)]
    public static extern int SDL_ShowSimpleMessageBox([NativeTypeName("Uint32")] uint flags, [NativeTypeName("const char *")] sbyte* title, [NativeTypeName("const char *")] sbyte* message, SDL_Window* window);

    [DllImport(libSDL3)]
    [return: NativeTypeName("SDL_MetalView")]
    public static extern void* SDL_Metal_CreateView(SDL_Window* window);

    [DllImport(libSDL3)]
    public static extern void SDL_Metal_DestroyView([NativeTypeName("SDL_MetalView")] void* view);

    [DllImport(libSDL3)]
    public static extern void* SDL_Metal_GetLayer([NativeTypeName("SDL_MetalView")] void* view);

    [DllImport(libSDL3)]
    public static extern int SDL_OpenURL([NativeTypeName("const char *")] sbyte* url);

    [DllImport(libSDL3)]
    public static extern SDL_Window* SDL_GetMouseFocus();

    [DllImport(libSDL3)]
    [return: NativeTypeName("Uint32")]
    public static extern uint SDL_GetMouseState(float* x, float* y);

    [DllImport(libSDL3)]
    [return: NativeTypeName("Uint32")]
    public static extern uint SDL_GetGlobalMouseState(float* x, float* y);

    [DllImport(libSDL3)]
    [return: NativeTypeName("Uint32")]
    public static extern uint SDL_GetRelativeMouseState(float* x, float* y);

    [DllImport(libSDL3)]
    public static extern void SDL_WarpMouseInWindow(SDL_Window* window, float x, float y);

    [DllImport(libSDL3)]
    public static extern int SDL_WarpMouseGlobal(float x, float y);

    [DllImport(libSDL3)]
    public static extern int SDL_SetRelativeMouseMode(SDL_bool enabled);

    [DllImport(libSDL3)]
    public static extern int SDL_CaptureMouse(SDL_bool enabled);

    [DllImport(libSDL3)]
    public static extern SDL_bool SDL_GetRelativeMouseMode();

    [DllImport(libSDL3)]
    public static extern SDL_Cursor* SDL_CreateCursor([NativeTypeName("const Uint8 *")] byte* data, [NativeTypeName("const Uint8 *")] byte* mask, int w, int h, int hot_x, int hot_y);

    [DllImport(libSDL3)]
    public static extern SDL_Cursor* SDL_CreateColorCursor(SDL_Surface* surface, int hot_x, int hot_y);

    [DllImport(libSDL3)]
    public static extern SDL_Cursor* SDL_CreateSystemCursor(SDL_SystemCursor id);

    [DllImport(libSDL3)]
    public static extern int SDL_SetCursor(SDL_Cursor* cursor);

    [DllImport(libSDL3)]
    public static extern SDL_Cursor* SDL_GetCursor();

    [DllImport(libSDL3)]
    public static extern SDL_Cursor* SDL_GetDefaultCursor();

    [DllImport(libSDL3)]
    public static extern void SDL_DestroyCursor(SDL_Cursor* cursor);

    [DllImport(libSDL3)]
    public static extern int SDL_ShowCursor();

    [DllImport(libSDL3)]
    public static extern int SDL_HideCursor();

    [DllImport(libSDL3)]
    public static extern SDL_bool SDL_CursorVisible();

    [DllImport(libSDL3)]
    public static extern SDL_mutex* SDL_CreateMutex();

    [DllImport(libSDL3)]
    public static extern int SDL_LockMutex(SDL_mutex* mutex);

    [DllImport(libSDL3)]
    public static extern int SDL_TryLockMutex(SDL_mutex* mutex);

    [DllImport(libSDL3)]
    public static extern int SDL_UnlockMutex(SDL_mutex* mutex);

    [DllImport(libSDL3)]
    public static extern void SDL_DestroyMutex(SDL_mutex* mutex);

    [DllImport(libSDL3)]
    [return: NativeTypeName("SDL_sem *")]
    public static extern SDL_semaphore* SDL_CreateSemaphore([NativeTypeName("Uint32")] uint initial_value);

    [DllImport(libSDL3)]
    public static extern void SDL_DestroySemaphore([NativeTypeName("SDL_sem *")] SDL_semaphore* sem);

    [DllImport(libSDL3)]
    public static extern int SDL_SemWait([NativeTypeName("SDL_sem *")] SDL_semaphore* sem);

    [DllImport(libSDL3)]
    public static extern int SDL_SemTryWait([NativeTypeName("SDL_sem *")] SDL_semaphore* sem);

    [DllImport(libSDL3)]
    public static extern int SDL_SemWaitTimeout([NativeTypeName("SDL_sem *")] SDL_semaphore* sem, [NativeTypeName("Sint32")] int timeoutMS);

    [DllImport(libSDL3)]
    public static extern int SDL_SemPost([NativeTypeName("SDL_sem *")] SDL_semaphore* sem);

    [DllImport(libSDL3)]
    [return: NativeTypeName("Uint32")]
    public static extern uint SDL_SemValue([NativeTypeName("SDL_sem *")] SDL_semaphore* sem);

    [DllImport(libSDL3)]
    public static extern SDL_cond* SDL_CreateCond();

    [DllImport(libSDL3)]
    public static extern void SDL_DestroyCond(SDL_cond* cond);

    [DllImport(libSDL3)]
    public static extern int SDL_CondSignal(SDL_cond* cond);

    [DllImport(libSDL3)]
    public static extern int SDL_CondBroadcast(SDL_cond* cond);

    [DllImport(libSDL3)]
    public static extern int SDL_CondWait(SDL_cond* cond, SDL_mutex* mutex);

    [DllImport(libSDL3)]
    public static extern int SDL_CondWaitTimeout(SDL_cond* cond, SDL_mutex* mutex, [NativeTypeName("Sint32")] int timeoutMS);

    [DllImport(libSDL3)]
    [return: NativeTypeName("const char *")]
    public static extern sbyte* SDL_GetPixelFormatName([NativeTypeName("Uint32")] uint format);

    [DllImport(libSDL3)]
    public static extern SDL_bool SDL_GetMasksForPixelFormatEnum([NativeTypeName("Uint32")] uint format, int* bpp, [NativeTypeName("Uint32 *")] uint* Rmask, [NativeTypeName("Uint32 *")] uint* Gmask, [NativeTypeName("Uint32 *")] uint* Bmask, [NativeTypeName("Uint32 *")] uint* Amask);

    [DllImport(libSDL3)]
    [return: NativeTypeName("Uint32")]
    public static extern uint SDL_GetPixelFormatEnumForMasks(int bpp, [NativeTypeName("Uint32")] uint Rmask, [NativeTypeName("Uint32")] uint Gmask, [NativeTypeName("Uint32")] uint Bmask, [NativeTypeName("Uint32")] uint Amask);

    [DllImport(libSDL3)]
    public static extern SDL_PixelFormat* SDL_CreatePixelFormat([NativeTypeName("Uint32")] uint pixel_format);

    [DllImport(libSDL3)]
    public static extern void SDL_DestroyPixelFormat(SDL_PixelFormat* format);

    [DllImport(libSDL3)]
    public static extern SDL_Palette* SDL_CreatePalette(int ncolors);

    [DllImport(libSDL3)]
    public static extern int SDL_SetPixelFormatPalette(SDL_PixelFormat* format, SDL_Palette* palette);

    [DllImport(libSDL3)]
    public static extern int SDL_SetPaletteColors(SDL_Palette* palette, [NativeTypeName("const SDL_Color *")] SDL_Color* colors, int firstcolor, int ncolors);

    [DllImport(libSDL3)]
    public static extern void SDL_DestroyPalette(SDL_Palette* palette);

    [DllImport(libSDL3)]
    [return: NativeTypeName("Uint32")]
    public static extern uint SDL_MapRGB([NativeTypeName("const SDL_PixelFormat *")] SDL_PixelFormat* format, [NativeTypeName("Uint8")] byte r, [NativeTypeName("Uint8")] byte g, [NativeTypeName("Uint8")] byte b);

    [DllImport(libSDL3)]
    [return: NativeTypeName("Uint32")]
    public static extern uint SDL_MapRGBA([NativeTypeName("const SDL_PixelFormat *")] SDL_PixelFormat* format, [NativeTypeName("Uint8")] byte r, [NativeTypeName("Uint8")] byte g, [NativeTypeName("Uint8")] byte b, [NativeTypeName("Uint8")] byte a);

    [DllImport(libSDL3)]
    public static extern void SDL_GetRGB([NativeTypeName("Uint32")] uint pixel, [NativeTypeName("const SDL_PixelFormat *")] SDL_PixelFormat* format, [NativeTypeName("Uint8 *")] byte* r, [NativeTypeName("Uint8 *")] byte* g, [NativeTypeName("Uint8 *")] byte* b);

    [DllImport(libSDL3)]
    public static extern void SDL_GetRGBA([NativeTypeName("Uint32")] uint pixel, [NativeTypeName("const SDL_PixelFormat *")] SDL_PixelFormat* format, [NativeTypeName("Uint8 *")] byte* r, [NativeTypeName("Uint8 *")] byte* g, [NativeTypeName("Uint8 *")] byte* b, [NativeTypeName("Uint8 *")] byte* a);

    [DllImport(libSDL3)]
    [return: NativeTypeName("const char *")]
    public static extern sbyte* SDL_GetPlatform();

    [DllImport(libSDL3)]
    public static extern SDL_PowerState SDL_GetPowerInfo(int* seconds, int* percent);

    [DllImport(libSDL3)]
    public static extern SDL_bool SDL_HasRectIntersection([NativeTypeName("const SDL_Rect *")] SDL_Rect* A, [NativeTypeName("const SDL_Rect *")] SDL_Rect* B);

    [DllImport(libSDL3)]
    public static extern SDL_bool SDL_GetRectIntersection([NativeTypeName("const SDL_Rect *")] SDL_Rect* A, [NativeTypeName("const SDL_Rect *")] SDL_Rect* B, SDL_Rect* result);

    [DllImport(libSDL3)]
    public static extern int SDL_GetRectUnion([NativeTypeName("const SDL_Rect *")] SDL_Rect* A, [NativeTypeName("const SDL_Rect *")] SDL_Rect* B, SDL_Rect* result);

    [DllImport(libSDL3)]
    public static extern SDL_bool SDL_GetRectEnclosingPoints([NativeTypeName("const SDL_Point *")] SDL_Point* points, int count, [NativeTypeName("const SDL_Rect *")] SDL_Rect* clip, SDL_Rect* result);

    [DllImport(libSDL3)]
    public static extern SDL_bool SDL_GetRectAndLineIntersection([NativeTypeName("const SDL_Rect *")] SDL_Rect* rect, int* X1, int* Y1, int* X2, int* Y2);

    [DllImport(libSDL3)]
    public static extern SDL_bool SDL_HasRectIntersectionFloat([NativeTypeName("const SDL_FRect *")] SDL_FRect* A, [NativeTypeName("const SDL_FRect *")] SDL_FRect* B);

    [DllImport(libSDL3)]
    public static extern SDL_bool SDL_GetRectIntersectionFloat([NativeTypeName("const SDL_FRect *")] SDL_FRect* A, [NativeTypeName("const SDL_FRect *")] SDL_FRect* B, SDL_FRect* result);

    [DllImport(libSDL3)]
    public static extern int SDL_GetRectUnionFloat([NativeTypeName("const SDL_FRect *")] SDL_FRect* A, [NativeTypeName("const SDL_FRect *")] SDL_FRect* B, SDL_FRect* result);

    [DllImport(libSDL3)]
    public static extern SDL_bool SDL_GetRectEnclosingPointsFloat([NativeTypeName("const SDL_FPoint *")] SDL_FPoint* points, int count, [NativeTypeName("const SDL_FRect *")] SDL_FRect* clip, SDL_FRect* result);

    [DllImport(libSDL3)]
    public static extern SDL_bool SDL_GetRectAndLineIntersectionFloat([NativeTypeName("const SDL_FRect *")] SDL_FRect* rect, float* X1, float* Y1, float* X2, float* Y2);

    [DllImport(libSDL3)]
    public static extern int SDL_GetNumRenderDrivers();

    [DllImport(libSDL3)]
    [return: NativeTypeName("const char *")]
    public static extern sbyte* SDL_GetRenderDriver(int index);

    [DllImport(libSDL3)]
    public static extern int SDL_CreateWindowAndRenderer(int width, int height, [NativeTypeName("Uint32")] uint window_flags, out SDL_Window* window, out SDL_Renderer* renderer);

    [DllImport(libSDL3)]
    public static extern SDL_Renderer* SDL_CreateRenderer(SDL_Window* window, [NativeTypeName("const char *")] sbyte* name, [NativeTypeName("Uint32")] uint flags);

    [DllImport(libSDL3)]
    public static extern SDL_Renderer* SDL_CreateSoftwareRenderer(SDL_Surface* surface);

    [DllImport(libSDL3)]
    public static extern SDL_Renderer* SDL_GetRenderer(SDL_Window* window);

    [DllImport(libSDL3)]
    public static extern SDL_Window* SDL_GetRenderWindow(SDL_Renderer* renderer);

    [DllImport(libSDL3)]
    public static extern int SDL_GetRendererInfo(SDL_Renderer* renderer, SDL_RendererInfo* info);

    [DllImport(libSDL3)]
    public static extern int SDL_GetRenderWindowSize(SDL_Renderer* renderer, int* w, int* h);

    [DllImport(libSDL3)]
    public static extern int SDL_GetRenderOutputSize(SDL_Renderer* renderer, int* w, int* h);

    [DllImport(libSDL3)]
    public static extern int SDL_GetCurrentRenderOutputSize(SDL_Renderer* renderer, int* w, int* h);

    [DllImport(libSDL3)]
    public static extern SDL_Texture* SDL_CreateTexture(SDL_Renderer* renderer, [NativeTypeName("Uint32")] uint format, int access, int w, int h);

    [DllImport(libSDL3)]
    public static extern SDL_Texture* SDL_CreateTextureFromSurface(SDL_Renderer* renderer, SDL_Surface* surface);

    [DllImport(libSDL3)]
    public static extern int SDL_QueryTexture(SDL_Texture* texture, [NativeTypeName("Uint32 *")] uint* format, int* access, int* w, int* h);

    [DllImport(libSDL3)]
    public static extern int SDL_SetTextureColorMod(SDL_Texture* texture, [NativeTypeName("Uint8")] byte r, [NativeTypeName("Uint8")] byte g, [NativeTypeName("Uint8")] byte b);

    [DllImport(libSDL3)]
    public static extern int SDL_GetTextureColorMod(SDL_Texture* texture, [NativeTypeName("Uint8 *")] byte* r, [NativeTypeName("Uint8 *")] byte* g, [NativeTypeName("Uint8 *")] byte* b);

    [DllImport(libSDL3)]
    public static extern int SDL_SetTextureAlphaMod(SDL_Texture* texture, [NativeTypeName("Uint8")] byte alpha);

    [DllImport(libSDL3)]
    public static extern int SDL_GetTextureAlphaMod(SDL_Texture* texture, [NativeTypeName("Uint8 *")] byte* alpha);

    [DllImport(libSDL3)]
    public static extern int SDL_SetTextureBlendMode(SDL_Texture* texture, SDL_BlendMode blendMode);

    [DllImport(libSDL3)]
    public static extern int SDL_GetTextureBlendMode(SDL_Texture* texture, SDL_BlendMode* blendMode);

    [DllImport(libSDL3)]
    public static extern int SDL_SetTextureScaleMode(SDL_Texture* texture, SDL_ScaleMode scaleMode);

    [DllImport(libSDL3)]
    public static extern int SDL_GetTextureScaleMode(SDL_Texture* texture, SDL_ScaleMode* scaleMode);

    [DllImport(libSDL3)]
    public static extern int SDL_SetTextureUserData(SDL_Texture* texture, void* userdata);

    [DllImport(libSDL3)]
    public static extern void* SDL_GetTextureUserData(SDL_Texture* texture);

    [DllImport(libSDL3)]
    public static extern int SDL_UpdateTexture(SDL_Texture* texture, [NativeTypeName("const SDL_Rect *")] SDL_Rect* rect, [NativeTypeName("const void *")] void* pixels, int pitch);

    [DllImport(libSDL3)]
    public static extern int SDL_UpdateYUVTexture(SDL_Texture* texture, [NativeTypeName("const SDL_Rect *")] SDL_Rect* rect, [NativeTypeName("const Uint8 *")] byte* Yplane, int Ypitch, [NativeTypeName("const Uint8 *")] byte* Uplane, int Upitch, [NativeTypeName("const Uint8 *")] byte* Vplane, int Vpitch);

    [DllImport(libSDL3)]
    public static extern int SDL_UpdateNVTexture(SDL_Texture* texture, [NativeTypeName("const SDL_Rect *")] SDL_Rect* rect, [NativeTypeName("const Uint8 *")] byte* Yplane, int Ypitch, [NativeTypeName("const Uint8 *")] byte* UVplane, int UVpitch);

    [DllImport(libSDL3)]
    public static extern int SDL_LockTexture(SDL_Texture* texture, [NativeTypeName("const SDL_Rect *")] SDL_Rect* rect, void** pixels, int* pitch);

    [DllImport(libSDL3)]
    public static extern int SDL_LockTextureToSurface(SDL_Texture* texture, [NativeTypeName("const SDL_Rect *")] SDL_Rect* rect, SDL_Surface** surface);

    [DllImport(libSDL3)]
    public static extern void SDL_UnlockTexture(SDL_Texture* texture);

    [DllImport(libSDL3)]
    public static extern int SDL_SetRenderTarget(SDL_Renderer* renderer, SDL_Texture* texture);

    [DllImport(libSDL3)]
    public static extern SDL_Texture* SDL_GetRenderTarget(SDL_Renderer* renderer);

    [DllImport(libSDL3)]
    public static extern int SDL_SetRenderLogicalPresentation(SDL_Renderer* renderer, int w, int h, SDL_RendererLogicalPresentation mode, SDL_ScaleMode scale_mode);

    [DllImport(libSDL3)]
    public static extern int SDL_GetRenderLogicalPresentation(SDL_Renderer* renderer, int* w, int* h, SDL_RendererLogicalPresentation* mode, SDL_ScaleMode* scale_mode);

    [DllImport(libSDL3)]
    public static extern int SDL_RenderCoordinatesFromWindow(SDL_Renderer* renderer, float window_x, float window_y, float* x, float* y);

    [DllImport(libSDL3)]
    public static extern int SDL_RenderCoordinatesToWindow(SDL_Renderer* renderer, float x, float y, float* window_x, float* window_y);

    [DllImport(libSDL3)]
    public static extern int SDL_ConvertEventToRenderCoordinates(SDL_Renderer* renderer, SDL_Event* @event);

    [DllImport(libSDL3)]
    public static extern int SDL_SetRenderViewport(SDL_Renderer* renderer, [NativeTypeName("const SDL_Rect *")] SDL_Rect* rect);

    [DllImport(libSDL3)]
    public static extern int SDL_GetRenderViewport(SDL_Renderer* renderer, SDL_Rect* rect);

    [DllImport(libSDL3)]
    public static extern int SDL_SetRenderClipRect(SDL_Renderer* renderer, [NativeTypeName("const SDL_Rect *")] SDL_Rect* rect);

    [DllImport(libSDL3)]
    public static extern int SDL_GetRenderClipRect(SDL_Renderer* renderer, SDL_Rect* rect);

    [DllImport(libSDL3)]
    public static extern SDL_bool SDL_RenderClipEnabled(SDL_Renderer* renderer);

    [DllImport(libSDL3)]
    public static extern int SDL_SetRenderScale(SDL_Renderer* renderer, float scaleX, float scaleY);

    [DllImport(libSDL3)]
    public static extern int SDL_GetRenderScale(SDL_Renderer* renderer, float* scaleX, float* scaleY);

    [DllImport(libSDL3)]
    public static extern int SDL_SetRenderDrawColor(SDL_Renderer* renderer, [NativeTypeName("Uint8")] byte r, [NativeTypeName("Uint8")] byte g, [NativeTypeName("Uint8")] byte b, [NativeTypeName("Uint8")] byte a);

    [DllImport(libSDL3)]
    public static extern int SDL_GetRenderDrawColor(SDL_Renderer* renderer, [NativeTypeName("Uint8 *")] byte* r, [NativeTypeName("Uint8 *")] byte* g, [NativeTypeName("Uint8 *")] byte* b, [NativeTypeName("Uint8 *")] byte* a);

    [DllImport(libSDL3)]
    public static extern int SDL_SetRenderDrawBlendMode(SDL_Renderer* renderer, SDL_BlendMode blendMode);

    [DllImport(libSDL3)]
    public static extern int SDL_GetRenderDrawBlendMode(SDL_Renderer* renderer, SDL_BlendMode* blendMode);

    [DllImport(libSDL3)]
    public static extern int SDL_RenderClear(SDL_Renderer* renderer);

    [DllImport(libSDL3)]
    public static extern int SDL_RenderPoint(SDL_Renderer* renderer, float x, float y);

    [DllImport(libSDL3)]
    public static extern int SDL_RenderPoints(SDL_Renderer* renderer, [NativeTypeName("const SDL_FPoint *")] SDL_FPoint* points, int count);

    [DllImport(libSDL3)]
    public static extern int SDL_RenderLine(SDL_Renderer* renderer, float x1, float y1, float x2, float y2);

    [DllImport(libSDL3)]
    public static extern int SDL_RenderLines(SDL_Renderer* renderer, [NativeTypeName("const SDL_FPoint *")] SDL_FPoint* points, int count);

    [DllImport(libSDL3)]
    public static extern int SDL_RenderRect(SDL_Renderer* renderer, [NativeTypeName("const SDL_FRect *")] SDL_FRect* rect);

    [DllImport(libSDL3)]
    public static extern int SDL_RenderRects(SDL_Renderer* renderer, [NativeTypeName("const SDL_FRect *")] SDL_FRect* rects, int count);

    [DllImport(libSDL3)]
    public static extern int SDL_RenderFillRect(SDL_Renderer* renderer, [NativeTypeName("const SDL_FRect *")] SDL_FRect* rect);

    [DllImport(libSDL3)]
    public static extern int SDL_RenderFillRects(SDL_Renderer* renderer, [NativeTypeName("const SDL_FRect *")] SDL_FRect* rects, int count);

    [DllImport(libSDL3)]
    public static extern int SDL_RenderTexture(SDL_Renderer* renderer, SDL_Texture* texture, [NativeTypeName("const SDL_Rect *")] SDL_Rect* srcrect, [NativeTypeName("const SDL_FRect *")] SDL_FRect* dstrect);

    [DllImport(libSDL3)]
    public static extern int SDL_RenderTextureRotated(SDL_Renderer* renderer, SDL_Texture* texture, [NativeTypeName("const SDL_Rect *")] SDL_Rect* srcrect, [NativeTypeName("const SDL_FRect *")] SDL_FRect* dstrect, [NativeTypeName("const double")] double angle, [NativeTypeName("const SDL_FPoint *")] SDL_FPoint* center, [NativeTypeName("const SDL_RendererFlip")] SDL_RendererFlip flip);

    [DllImport(libSDL3)]
    public static extern int SDL_RenderGeometry(SDL_Renderer* renderer, SDL_Texture* texture, [NativeTypeName("const SDL_Vertex *")] SDL_Vertex* vertices, int num_vertices, [NativeTypeName("const int *")] int* indices, int num_indices);

    [DllImport(libSDL3)]
    public static extern int SDL_RenderGeometryRaw(SDL_Renderer* renderer, SDL_Texture* texture, [NativeTypeName("const float *")] float* xy, int xy_stride, [NativeTypeName("const SDL_Color *")] SDL_Color* color, int color_stride, [NativeTypeName("const float *")] float* uv, int uv_stride, int num_vertices, [NativeTypeName("const void *")] void* indices, int num_indices, int size_indices);

    [DllImport(libSDL3)]
    public static extern int SDL_RenderReadPixels(SDL_Renderer* renderer, [NativeTypeName("const SDL_Rect *")] SDL_Rect* rect, [NativeTypeName("Uint32")] uint format, void* pixels, int pitch);

    [DllImport(libSDL3)]
    public static extern int SDL_RenderPresent(SDL_Renderer* renderer);

    [DllImport(libSDL3)]
    public static extern void SDL_DestroyTexture(SDL_Texture* texture);

    [DllImport(libSDL3)]
    public static extern void SDL_DestroyRenderer(SDL_Renderer* renderer);

    [DllImport(libSDL3)]
    public static extern int SDL_RenderFlush(SDL_Renderer* renderer);

    [DllImport(libSDL3)]
    public static extern int SDL_GL_BindTexture(SDL_Texture* texture, float* texw, float* texh);

    [DllImport(libSDL3)]
    public static extern int SDL_GL_UnbindTexture(SDL_Texture* texture);

    [DllImport(libSDL3)]
    public static extern void* SDL_GetRenderMetalLayer(SDL_Renderer* renderer);

    [DllImport(libSDL3)]
    public static extern void* SDL_GetRenderMetalCommandEncoder(SDL_Renderer* renderer);

    [DllImport(libSDL3)]
    public static extern int SDL_SetRenderVSync(SDL_Renderer* renderer, int vsync);

    [DllImport(libSDL3)]
    public static extern int SDL_GetRenderVSync(SDL_Renderer* renderer, int* vsync);

    // SDL_rwops.h
    [DllImport(libSDL3)]
    public static extern SDL_RWops* SDL_RWFromFile([NativeTypeName("const char *")] sbyte* file, [NativeTypeName("const char *")] sbyte* mode);

    [DllImport(libSDL3)]
    public static extern SDL_RWops* SDL_RWFromMem(void* mem, int size);

    [DllImport(libSDL3)]
    public static extern SDL_RWops* SDL_RWFromConstMem([NativeTypeName("const void *")] void* mem, int size);

    [DllImport(libSDL3)]
    public static extern SDL_RWops* SDL_CreateRW();

    [DllImport(libSDL3)]
    public static extern void SDL_DestroyRW(SDL_RWops* area);

    [DllImport(libSDL3)]
    [return: NativeTypeName("Sint64")]
    public static extern nint SDL_RWsize(SDL_RWops* context);

    [DllImport(libSDL3)]
    [return: NativeTypeName("Sint64")]
    public static extern nint SDL_RWseek(SDL_RWops* context, [NativeTypeName("Sint64")] nint offset, int whence);

    [DllImport(libSDL3)]
    [return: NativeTypeName("Sint64")]
    public static extern nint SDL_RWtell(SDL_RWops* context);

    [DllImport(libSDL3)]
    [return: NativeTypeName("Sint64")]
    public static extern nint SDL_RWread(SDL_RWops* context, void* ptr, [NativeTypeName("Sint64")] nint size);

    [DllImport(libSDL3)]
    [return: NativeTypeName("Sint64")]
    public static extern nint SDL_RWwrite(SDL_RWops* context, [NativeTypeName("const void *")] void* ptr, [NativeTypeName("Sint64")] nint size);

    [DllImport(libSDL3)]
    public static extern int SDL_RWclose(SDL_RWops* context);

    [DllImport(libSDL3)]
    public static extern void* SDL_LoadFile_RW(SDL_RWops* src, [NativeTypeName("size_t *")] nuint* datasize, int freesrc);

    [DllImport(libSDL3)]
    public static extern void* SDL_LoadFile([NativeTypeName("const char *")] sbyte* file, [NativeTypeName("size_t *")] nuint* datasize);

    [DllImport(libSDL3)]
    [return: NativeTypeName("Uint8")]
    public static extern byte SDL_ReadU8(SDL_RWops* src);

    [DllImport(libSDL3)]
    [return: NativeTypeName("Uint16")]
    public static extern ushort SDL_ReadLE16(SDL_RWops* src);

    [DllImport(libSDL3)]
    [return: NativeTypeName("Uint16")]
    public static extern ushort SDL_ReadBE16(SDL_RWops* src);

    [DllImport(libSDL3)]
    [return: NativeTypeName("Uint32")]
    public static extern uint SDL_ReadLE32(SDL_RWops* src);

    [DllImport(libSDL3)]
    [return: NativeTypeName("Uint32")]
    public static extern uint SDL_ReadBE32(SDL_RWops* src);

    [DllImport(libSDL3)]
    [return: NativeTypeName("Uint64")]
    public static extern nuint SDL_ReadLE64(SDL_RWops* src);

    [DllImport(libSDL3)]
    [return: NativeTypeName("Uint64")]
    public static extern nuint SDL_ReadBE64(SDL_RWops* src);

    [DllImport(libSDL3)]
    [return: NativeTypeName("size_t")]
    public static extern nuint SDL_WriteU8(SDL_RWops* dst, [NativeTypeName("Uint8")] byte value);

    [DllImport(libSDL3)]
    [return: NativeTypeName("size_t")]
    public static extern nuint SDL_WriteLE16(SDL_RWops* dst, [NativeTypeName("Uint16")] ushort value);

    [DllImport(libSDL3)]
    [return: NativeTypeName("size_t")]
    public static extern nuint SDL_WriteBE16(SDL_RWops* dst, [NativeTypeName("Uint16")] ushort value);

    [DllImport(libSDL3)]
    [return: NativeTypeName("size_t")]
    public static extern nuint SDL_WriteLE32(SDL_RWops* dst, [NativeTypeName("Uint32")] uint value);

    [DllImport(libSDL3)]
    [return: NativeTypeName("size_t")]
    public static extern nuint SDL_WriteBE32(SDL_RWops* dst, [NativeTypeName("Uint32")] uint value);

    [DllImport(libSDL3)]
    [return: NativeTypeName("size_t")]
    public static extern nuint SDL_WriteLE64(SDL_RWops* dst, [NativeTypeName("Uint64")] nuint value);

    [DllImport(libSDL3)]
    [return: NativeTypeName("size_t")]
    public static extern nuint SDL_WriteBE64(SDL_RWops* dst, [NativeTypeName("Uint64")] nuint value);

    [DllImport(libSDL3)]
    [return: NativeTypeName("SDL_SensorID *")]
    public static extern uint* SDL_GetSensors(int* count);

    [DllImport(libSDL3)]
    [return: NativeTypeName("const char *")]
    public static extern sbyte* SDL_GetSensorInstanceName([NativeTypeName("SDL_SensorID")] uint instance_id);

    [DllImport(libSDL3)]
    public static extern SDL_SensorType SDL_GetSensorInstanceType([NativeTypeName("SDL_SensorID")] uint instance_id);

    [DllImport(libSDL3)]
    public static extern int SDL_GetSensorInstanceNonPortableType([NativeTypeName("SDL_SensorID")] uint instance_id);

    [DllImport(libSDL3)]
    public static extern SDL_Sensor* SDL_OpenSensor([NativeTypeName("SDL_SensorID")] uint instance_id);

    [DllImport(libSDL3)]
    public static extern SDL_Sensor* SDL_GetSensorFromInstanceID([NativeTypeName("SDL_SensorID")] uint instance_id);

    [DllImport(libSDL3)]
    [return: NativeTypeName("const char *")]
    public static extern sbyte* SDL_GetSensorName(SDL_Sensor* sensor);

    [DllImport(libSDL3)]
    public static extern SDL_SensorType SDL_GetSensorType(SDL_Sensor* sensor);

    [DllImport(libSDL3)]
    public static extern int SDL_GetSensorNonPortableType(SDL_Sensor* sensor);

    [DllImport(libSDL3)]
    [return: NativeTypeName("SDL_SensorID")]
    public static extern uint SDL_GetSensorInstanceID(SDL_Sensor* sensor);

    [DllImport(libSDL3)]
    public static extern int SDL_GetSensorData(SDL_Sensor* sensor, float* data, int num_values);

    [DllImport(libSDL3)]
    public static extern void SDL_CloseSensor(SDL_Sensor* sensor);

    [DllImport(libSDL3)]
    public static extern void SDL_UpdateSensors();

    // SDL_shape.h
    [DllImport(libSDL3)]
    public static extern SDL_Window* SDL_CreateShapedWindow([NativeTypeName("const char *")] sbyte* title, [NativeTypeName("unsigned int")] uint x, [NativeTypeName("unsigned int")] uint y, [NativeTypeName("unsigned int")] uint w, [NativeTypeName("unsigned int")] uint h, [NativeTypeName("Uint32")] uint flags);

    [DllImport(libSDL3)]
    public static extern SDL_bool SDL_IsShapedWindow([NativeTypeName("const SDL_Window *")] SDL_Window* window);

    [DllImport(libSDL3)]
    public static extern int SDL_SetWindowShape(SDL_Window* window, SDL_Surface* shape, SDL_WindowShapeMode* shape_mode);

    [DllImport(libSDL3)]
    public static extern int SDL_GetShapedWindowMode(SDL_Window* window, SDL_WindowShapeMode* shape_mode);

    // SDL_surface.h
    [DllImport(libSDL3)]
    public static extern SDL_Surface* SDL_CreateSurface(int width, int height, [NativeTypeName("Uint32")] uint format);

    [DllImport(libSDL3)]
    public static extern SDL_Surface* SDL_CreateSurfaceFrom(void* pixels, int width, int height, int pitch, [NativeTypeName("Uint32")] uint format);

    [DllImport(libSDL3)]
    public static extern void SDL_DestroySurface(SDL_Surface* surface);

    [DllImport(libSDL3)]
    public static extern int SDL_SetSurfacePalette(SDL_Surface* surface, SDL_Palette* palette);

    [DllImport(libSDL3)]
    public static extern int SDL_LockSurface(SDL_Surface* surface);

    [DllImport(libSDL3)]
    public static extern void SDL_UnlockSurface(SDL_Surface* surface);

    [DllImport(libSDL3)]
    public static extern SDL_Surface* SDL_LoadBMP_RW(SDL_RWops* src, int freesrc);

    [DllImport(libSDL3)]
    public static extern int SDL_SaveBMP_RW(SDL_Surface* surface, SDL_RWops* dst, int freedst);

    [DllImport(libSDL3)]
    public static extern int SDL_SetSurfaceRLE(SDL_Surface* surface, int flag);

    [DllImport(libSDL3)]
    public static extern SDL_bool SDL_SurfaceHasRLE(SDL_Surface* surface);

    [DllImport(libSDL3)]
    public static extern int SDL_SetSurfaceColorKey(SDL_Surface* surface, int flag, [NativeTypeName("Uint32")] uint key);

    [DllImport(libSDL3)]
    public static extern SDL_bool SDL_SurfaceHasColorKey(SDL_Surface* surface);

    [DllImport(libSDL3)]
    public static extern int SDL_GetSurfaceColorKey(SDL_Surface* surface, [NativeTypeName("Uint32 *")] uint* key);

    [DllImport(libSDL3)]
    public static extern int SDL_SetSurfaceColorMod(SDL_Surface* surface, [NativeTypeName("Uint8")] byte r, [NativeTypeName("Uint8")] byte g, [NativeTypeName("Uint8")] byte b);

    [DllImport(libSDL3)]
    public static extern int SDL_GetSurfaceColorMod(SDL_Surface* surface, [NativeTypeName("Uint8 *")] byte* r, [NativeTypeName("Uint8 *")] byte* g, [NativeTypeName("Uint8 *")] byte* b);

    [DllImport(libSDL3)]
    public static extern int SDL_SetSurfaceAlphaMod(SDL_Surface* surface, [NativeTypeName("Uint8")] byte alpha);

    [DllImport(libSDL3)]
    public static extern int SDL_GetSurfaceAlphaMod(SDL_Surface* surface, [NativeTypeName("Uint8 *")] byte* alpha);

    [DllImport(libSDL3)]
    public static extern int SDL_SetSurfaceBlendMode(SDL_Surface* surface, SDL_BlendMode blendMode);

    [DllImport(libSDL3)]
    public static extern int SDL_GetSurfaceBlendMode(SDL_Surface* surface, SDL_BlendMode* blendMode);

    [DllImport(libSDL3)]
    public static extern SDL_bool SDL_SetSurfaceClipRect(SDL_Surface* surface, [NativeTypeName("const SDL_Rect *")] SDL_Rect* rect);

    [DllImport(libSDL3)]
    public static extern int SDL_GetSurfaceClipRect(SDL_Surface* surface, SDL_Rect* rect);

    [DllImport(libSDL3)]
    public static extern SDL_Surface* SDL_DuplicateSurface(SDL_Surface* surface);

    [DllImport(libSDL3)]
    public static extern SDL_Surface* SDL_ConvertSurface(SDL_Surface* surface, [NativeTypeName("const SDL_PixelFormat *")] SDL_PixelFormat* format);

    [DllImport(libSDL3)]
    public static extern SDL_Surface* SDL_ConvertSurfaceFormat(SDL_Surface* surface, [NativeTypeName("Uint32")] uint pixel_format);

    [DllImport(libSDL3)]
    public static extern int SDL_ConvertPixels(int width, int height, [NativeTypeName("Uint32")] uint src_format, [NativeTypeName("const void *")] void* src, int src_pitch, [NativeTypeName("Uint32")] uint dst_format, void* dst, int dst_pitch);

    [DllImport(libSDL3)]
    public static extern int SDL_PremultiplyAlpha(int width, int height, [NativeTypeName("Uint32")] uint src_format, [NativeTypeName("const void *")] void* src, int src_pitch, [NativeTypeName("Uint32")] uint dst_format, void* dst, int dst_pitch);

    [DllImport(libSDL3)]
    public static extern int SDL_FillSurfaceRect(SDL_Surface* dst, [NativeTypeName("const SDL_Rect *")] SDL_Rect* rect, [NativeTypeName("Uint32")] uint color);

    [DllImport(libSDL3)]
    public static extern int SDL_FillSurfaceRects(SDL_Surface* dst, [NativeTypeName("const SDL_Rect *")] SDL_Rect* rects, int count, [NativeTypeName("Uint32")] uint color);

    [DllImport(libSDL3)]
    public static extern int SDL_BlitSurface(SDL_Surface* src, [NativeTypeName("const SDL_Rect *")] SDL_Rect* srcrect, SDL_Surface* dst, SDL_Rect* dstrect);

    [DllImport(libSDL3)]
    public static extern int SDL_BlitSurfaceUnchecked(SDL_Surface* src, SDL_Rect* srcrect, SDL_Surface* dst, SDL_Rect* dstrect);

    [DllImport(libSDL3)]
    public static extern int SDL_SoftStretch(SDL_Surface* src, [NativeTypeName("const SDL_Rect *")] SDL_Rect* srcrect, SDL_Surface* dst, [NativeTypeName("const SDL_Rect *")] SDL_Rect* dstrect);

    [DllImport(libSDL3)]
    public static extern int SDL_SoftStretchLinear(SDL_Surface* src, [NativeTypeName("const SDL_Rect *")] SDL_Rect* srcrect, SDL_Surface* dst, [NativeTypeName("const SDL_Rect *")] SDL_Rect* dstrect);

    [DllImport(libSDL3)]
    public static extern int SDL_BlitSurfaceScaled(SDL_Surface* src, [NativeTypeName("const SDL_Rect *")] SDL_Rect* srcrect, SDL_Surface* dst, SDL_Rect* dstrect);

    [DllImport(libSDL3)]
    public static extern int SDL_BlitSurfaceUncheckedScaled(SDL_Surface* src, SDL_Rect* srcrect, SDL_Surface* dst, SDL_Rect* dstrect);

    [DllImport(libSDL3)]
    public static extern void SDL_SetYUVConversionMode(SDL_YUV_CONVERSION_MODE mode);

    [DllImport(libSDL3)]
    public static extern SDL_YUV_CONVERSION_MODE SDL_GetYUVConversionMode();

    [DllImport(libSDL3)]
    public static extern SDL_YUV_CONVERSION_MODE SDL_GetYUVConversionModeForResolution(int width, int height);


    [DllImport(libSDL3)]
    public static extern int SDL_GetNumTouchDevices(); // WARNING It is for for statement

    [DllImport(libSDL3)]
    public static extern SDL_TouchID SDL_GetTouchDevice(int index);




















    [DllImport(libSDL3)]
    public static extern bool SDL_GetVersion(SDL_Version *vers);

    [DllImport(libSDL3)]
    public static extern sbyte *SDL_GetRevision();

    [DllImport(libSDL3)]
    public static extern bool SDL_GetNumVideoDrivers();

    [DllImport(libSDL3)]
    public static extern sbyte *SDL_GetVideoDriver(int index);

    [DllImport(libSDL3)]
    public static extern sbyte *SDL_GetCurrentVideoDriver();

    [DllImport(libSDL3)]
    public static extern SDL_DisplayID *SDL_GetDisplays(int *count);

    [DllImport(libSDL3)]
    public static extern SDL_DisplayID SDL_GetPrimaryDisplay();

    [DllImport(libSDL3)]
    public static extern sbyte *SDL_GetDisplayName(SDL_DisplayID displayID); 

    [DllImport(libSDL3)]
    public static extern bool SDL_GetDisplayBounds(SDL_DisplayID displayID, SDL_Rect *rect);

    [DllImport(libSDL3)]
    public static extern bool SDL_GetDisplayUsableBounds(SDL_DisplayID displayID, SDL_Rect *rect);

    [DllImport(libSDL3)]
    public static extern SDL_DisplayOrientation SDL_GetDisplayOrientation(SDL_DisplayID displayID);

    [DllImport(libSDL3)]
    public static extern SDL_DisplayMode **SDL_GetFullscreenDisplayModes(SDL_DisplayID displayID, int *count);

    [DllImport(libSDL3)]
    public static extern SDL_DisplayMode *SDL_GetClosestFullscreenDisplayMode(SDL_DisplayID displayID, int w, int h, float refresh_rate);

    [DllImport(libSDL3)]
    public static extern SDL_DisplayMode *SDL_GetDesktopDisplayMode(SDL_DisplayID displayID);

    [DllImport(libSDL3)]
    public static extern SDL_DisplayMode *SDL_GetCurrentDisplayMode(SDL_DisplayID displayID);

    [DllImport(libSDL3)]
    public static extern SDL_DisplayID SDL_GetDisplayForPoint(SDL_Point *point);

    [DllImport(libSDL3)]
    public static extern SDL_DisplayID SDL_GetDisplayForRect(SDL_Rect *rect);

    [DllImport(libSDL3)]
    public static extern SDL_DisplayID SDL_GetDisplayForWindow(SDL_Window *window);

    [DllImport(libSDL3)]
    public static extern bool SDL_SetWindowFullscreenMode(SDL_Window *window, SDL_DisplayMode *mode);

    [DllImport(libSDL3)]
    public static extern SDL_DisplayMode *SDL_GetWindowFullscreenMode(SDL_Window *window);

    // size_t in C# "nuint *"
    [DllImport(libSDL3)]
    public static extern void *SDL_GetWindowICCProfile(SDL_Window *window, nuint *size);

    [DllImport(libSDL3)]
    public static extern UInt32 SDL_GetWindowPixelFormat(SDL_Window *window);

    [DllImport(libSDL3)]
    public static extern SDL_Window *SDL_CreateWindow(sbyte *title, int x, int y, int w, int h, SDL_WindowFlags flags);

    [DllImport(libSDL3)]
    public static extern SDL_Window *SDL_CreateWindowFrom(void *data);

    [DllImport(libSDL3)]
    public static extern SDL_WindowID SDL_GetWindowID(SDL_Window *window);

    [DllImport(libSDL3)]
    public static extern SDL_Window *SDL_GetWindowFromID(SDL_WindowID id);

    [DllImport(libSDL3)]
    public static extern UInt32 SDL_GetWindowFlags(SDL_Window *window);

    [DllImport(libSDL3)]
    public static extern bool SDL_SetWindowTitle(SDL_Window *window, sbyte *title);

    [DllImport(libSDL3)]
    public static extern sbyte *SDL_GetWindowTitle(SDL_Window *window);

    [DllImport(libSDL3)]
    public static extern bool SDL_SetWindowIcon(SDL_Window *window, SDL_Surface *icon);

    [DllImport(libSDL3)]    
    public static extern void *SDL_SetWindowData(SDL_Window *window, sbyte *name, void *user_data);

    [DllImport(libSDL3)]
    public static extern void *SDL_GetWindowData(SDL_Window *window, sbyte *name);

    [DllImport(libSDL3)]
    public static extern bool SDL_SetWindowPosition(SDL_Window *window, int x, int y);

    [DllImport(libSDL3)]
    public static extern bool SDL_GetWindowPosition(SDL_Window *window, int *x, int *y);

    [DllImport(libSDL3)]
    public static extern bool SDL_SetWindowSize(SDL_Window *window, int w, int h);
    
    [DllImport(libSDL3)]
    public static extern bool SDL_GetWindowSize(SDL_Window *window, int *w, int *h);

    [DllImport(libSDL3)]
    public static extern bool SDL_GetWindowBordersSize(SDL_Window *window, int *top, int *left, int *bottom, int *right);

    [DllImport(libSDL3)]
    public static extern bool SDL_GetWindowSizeInPixels(SDL_Window *window, int *w, int *h);

    [DllImport(libSDL3)]
    public static extern bool SDL_SetWindowMinimumSize(SDL_Window *window, int min_w, int min_h);

    [DllImport(libSDL3)]
    public static extern bool SDL_GetWindowMinimumSize(SDL_Window *window, int *w, int *h);

    [DllImport(libSDL3)]
    public static extern bool SDL_SetWindowMaximumSize(SDL_Window *window, int max_w, int max_h);

    [DllImport(libSDL3)]
    public static extern bool SDL_GetWindowMaximumSize(SDL_Window *window, int *w, int *h);

    [DllImport(libSDL3)]
    public static extern bool SDL_SetWindowBordered(SDL_Window *window, SDL_bool bordered);

    [DllImport(libSDL3)]
    public static extern bool SDL_SetWindowResizable(SDL_Window *window, SDL_bool resizable);

    [DllImport(libSDL3)]
    public static extern bool SDL_SetWindowAlwaysOnTop(SDL_Window *window, SDL_bool on_top);

    [DllImport(libSDL3)]
    public static extern bool SDL_ShowWindow(SDL_Window *window);

    [DllImport(libSDL3)]
    public static extern bool SDL_HideWindow(SDL_Window *window);

    [DllImport(libSDL3)]
    public static extern bool SDL_RaiseWindow(SDL_Window *window);

    [DllImport(libSDL3)]
    public static extern bool SDL_MaximizeWindow(SDL_Window *window);

    [DllImport(libSDL3)]
    public static extern bool SDL_MinimizeWindow(SDL_Window *window);

    [DllImport(libSDL3)]
    public static extern bool SDL_RestoreWindow(SDL_Window *window);

    [DllImport(libSDL3)]
    public static extern bool SDL_SetWindowFullscreen(SDL_Window *window, SDL_bool fullscreen);

    [DllImport(libSDL3)]
    public static extern SDL_Surface *SDL_GetWindowSurface(SDL_Window *window);

    [DllImport(libSDL3)]
    public static extern bool SDL_UpdateWindowSurface(SDL_Window *window);

    [DllImport(libSDL3)]
    public static extern bool SDL_UpdateWindowSurfaceRects(SDL_Window *window, SDL_Rect *rects, int numrects);

    [DllImport(libSDL3)]
    public static extern bool SDL_SetWindowGrab(SDL_Window *window, SDL_bool grabbed);

    [DllImport(libSDL3)]
    public static extern bool SDL_SetWindowKeyboardGrab(SDL_Window *window, SDL_bool grabbed);

    [DllImport(libSDL3)]
    public static extern bool SDL_SetWindowMouseGrab(SDL_Window *window, SDL_bool grabbed);

    [DllImport(libSDL3)]
    public static extern SDL_bool SDL_GetWindowGrab(SDL_Window *window); 

    [DllImport(libSDL3)]
    public static extern SDL_bool SDL_GetWindowKeyboardGrab(SDL_Window *window);

    [DllImport(libSDL3)]
    public static extern SDL_bool SDL_GetWindowMouseGrab(SDL_Window *window);

    [DllImport(libSDL3)]
    public static extern SDL_Window *SDL_GetGrabbedWindow();

    [DllImport(libSDL3)]
    public static extern bool SDL_SetWindowMouseRect(SDL_Window *window, SDL_Rect *rect);

    [DllImport(libSDL3)]
    public static extern SDL_Rect *SDL_GetWindowMouseRect(SDL_Window *window); 

    [DllImport(libSDL3)]
    public static extern bool SDL_SetWindowOpacity(SDL_Window *window, float opacity);

    [DllImport(libSDL3)]
    public static extern bool SDL_GetWindowOpacity(SDL_Window *window, float *out_opacity);

    [DllImport(libSDL3)]
    public static extern bool SDL_SetWindowModalFor(SDL_Window *modal_window, SDL_Window *parent_window);

    [DllImport(libSDL3)]
    public static extern bool SDL_SetWindowInputFocus(SDL_Window *window);

    [DllImport(libSDL3)]
    public static extern bool SDL_SetWindowHitTest(SDL_Window *window, delegate* unmanaged<SDL_Window *, SDL_Point *, void *, SDL_HitTestResult> callback, void *callback_data);

    [DllImport(libSDL3)]
    public static extern bool SDL_FlashWindow(SDL_Window *window, SDL_FlashOperation operation);

    [DllImport(libSDL3)]
    public static extern void SDL_DestroyWindow(SDL_Window *window);

    [DllImport(libSDL3)]
    public static extern SDL_bool SDL_ScreenSaverEnabled();

    [DllImport(libSDL3)]
    public static extern bool SDL_EnableScreenSaver();

    [DllImport(libSDL3)]
    public static extern bool SDL_DisableScreenSaver();

    // OpenGL Functions - BEGIN






    // OpenGL Functions - End


    /**
        Macro functions
    **/

    public static int SDL_MostSignificantBitIndex32([NativeTypeName("Uint32")] uint x)
    {
        if (x == 0)
        {
            return -1;
        }

        return 31 - __builtin_clz(x);
    }

    public static SDL_bool SDL_HasExactlyOneBitSet32([NativeTypeName("Uint32")] uint x)
    {
        if ((x) != 0 && (x & (x - 1)) == 0)
        {
            return SDL_TRUE;
        }

        return SDL_FALSE;
    }

    [DllImport(libSDL3)]
    public static extern int __builtin_clz([NativeTypeName("unsigned int")] uint param0);

    public static SDL_bool SDL_PointInRect([NativeTypeName("const SDL_Point *")] SDL_Point* p, [NativeTypeName("const SDL_Rect *")] SDL_Rect* r)
    {
        return ((p->x >= r->x) && (p->x < (r->x + r->w)) && (p->y >= r->y) && (p->y < (r->y + r->h))) ? SDL_TRUE : SDL_FALSE;
    }

    public static SDL_bool SDL_RectEmpty([NativeTypeName("const SDL_Rect *")] SDL_Rect* r)
    {
        return ((r == null) || (r->w <= 0) || (r->h <= 0)) ? SDL_TRUE : SDL_FALSE;
    }

    public static SDL_bool SDL_RectsEqual([NativeTypeName("const SDL_Rect *")] SDL_Rect* a, [NativeTypeName("const SDL_Rect *")] SDL_Rect* b)
    {
        return ((a) != null && (b) != null && (a->x == b->x) && (a->y == b->y) && (a->w == b->w) && (a->h == b->h)) ? SDL_TRUE : SDL_FALSE;
    }

    public static SDL_bool SDL_PointInRectFloat([NativeTypeName("const SDL_FPoint *")] SDL_FPoint* p, [NativeTypeName("const SDL_FRect *")] SDL_FRect* r)
    {
        return ((p->x >= r->x) && (p->x < (r->x + r->w)) && (p->y >= r->y) && (p->y < (r->y + r->h))) ? SDL_TRUE : SDL_FALSE;
    }

    public static SDL_bool SDL_RectEmptyFloat([NativeTypeName("const SDL_FRect *")] SDL_FRect* r)
    {
        return ((r == null) || (r->w <= 0.0f) || (r->h <= 0.0f)) ? SDL_TRUE : SDL_FALSE;
    }

    public static SDL_bool SDL_RectsEqualEpsilon([NativeTypeName("const SDL_FRect *")] SDL_FRect* a, [NativeTypeName("const SDL_FRect *")] SDL_FRect* b, [NativeTypeName("const float")] float epsilon)
    {
        return ((a) != null && (b) != null && ((a == b) || ((MathF.Abs(a->x - b->x) <= epsilon) && (MathF.Abs(a->y - b->y) <= epsilon) && (MathF.Abs(a->w - b->w) <= epsilon) && (MathF.Abs(a->h - b->h) <= epsilon)))) ? SDL_TRUE : SDL_FALSE;
    }

    public static SDL_bool SDL_RectsEqualFloat([NativeTypeName("const SDL_FRect *")] SDL_FRect* a, [NativeTypeName("const SDL_FRect *")] SDL_FRect* b)
    {
        return SDL_RectsEqualEpsilon(a, b, 1.1920928955078125e-07F);
    }

    public static SDL_Version *SDL_VERSION(SDL_Version *v)
    {
        v->major = SDL_MAJOR_VERSION;
        v->minor = SDL_MINOR_VERSION;
        v->patch = SDL_PATCHLEVEL;
        return v;
    }


    /**
        defines and constexpos...
    **/

    [NativeTypeName("unsigned int")]
    public enum SDL_AssertState : uint
    {
    }

    public static SDL_AssertState SDL_ASSERTION_RETRY,
        SDL_ASSERTION_BREAK,
        SDL_ASSERTION_ABORT,
        SDL_ASSERTION_IGNORE,
        SDL_ASSERTION_ALWAYS_IGNORE;

    [NativeTypeName("unsigned int")]
    public enum SDL_AudioStatus : uint
    {
    }

    public static SDL_AudioStatus SDL_AUDIO_STOPPED = 0,
        SDL_AUDIO_PLAYING,
        SDL_AUDIO_PAUSED;

    [NativeTypeName("unsigned int")]
    public enum SDL_BlendMode : uint
    {
    }

    public const SDL_BlendMode SDL_BLENDMODE_NONE = 0x00000000,
        SDL_BLENDMODE_BLEND = (SDL_BlendMode)0x00000001,
        SDL_BLENDMODE_ADD = (SDL_BlendMode)0x00000002,
        SDL_BLENDMODE_MOD = (SDL_BlendMode)0x00000004,
        SDL_BLENDMODE_MUL = (SDL_BlendMode)0x00000008,
        SDL_BLENDMODE_INVALID = (SDL_BlendMode)0x7FFFFFFF;

    [NativeTypeName("unsigned int")]
    public enum SDL_BlendOperation : uint
    {
    }

    public const SDL_BlendOperation SDL_BLENDOPERATION_ADD = (SDL_BlendOperation)0x1,
        SDL_BLENDOPERATION_SUBTRACT = (SDL_BlendOperation)0x2,
        SDL_BLENDOPERATION_REV_SUBTRACT = (SDL_BlendOperation)0x3,
        SDL_BLENDOPERATION_MINIMUM = (SDL_BlendOperation)0x4,
        SDL_BLENDOPERATION_MAXIMUM = (SDL_BlendOperation)0x5;

    [NativeTypeName("unsigned int")]
    public enum SDL_BlendFactor : uint
    {
    }

    public const SDL_BlendFactor SDL_BLENDFACTOR_ZERO = (SDL_BlendFactor)0x1,
        SDL_BLENDFACTOR_ONE = (SDL_BlendFactor)0x2,
        SDL_BLENDFACTOR_SRC_COLOR = (SDL_BlendFactor)0x3,
        SDL_BLENDFACTOR_ONE_MINUS_SRC_COLOR = (SDL_BlendFactor)0x4,
        SDL_BLENDFACTOR_SRC_ALPHA = (SDL_BlendFactor)0x5,
        SDL_BLENDFACTOR_ONE_MINUS_SRC_ALPHA = (SDL_BlendFactor)0x6,
        SDL_BLENDFACTOR_DST_COLOR = (SDL_BlendFactor)0x7,
        SDL_BLENDFACTOR_ONE_MINUS_DST_COLOR = (SDL_BlendFactor)0x8,
        SDL_BLENDFACTOR_DST_ALPHA = (SDL_BlendFactor)0x9,
        SDL_BLENDFACTOR_ONE_MINUS_DST_ALPHA = (SDL_BlendFactor)0xA;

    [NativeTypeName("unsigned int")]
    public enum SDL_errorcode : uint
    {
    }

    public static SDL_errorcode SDL_ENOMEM,
        SDL_EFREAD,
        SDL_EFWRITE,
        SDL_EFSEEK,
        SDL_UNSUPPORTED,
        SDL_LASTERROR;

    [NativeTypeName("unsigned int")]
    public enum SDL_EventType : uint
    {
    }

    public static SDL_EventType SDL_EVENT_FIRST = 0,
        SDL_EVENT_QUIT = (SDL_EventType)0x100,
        SDL_EVENT_TERMINATING,
        SDL_EVENT_LOW_MEMORY,
        SDL_EVENT_WILL_ENTER_BACKGROUND,
        SDL_EVENT_DID_ENTER_BACKGROUND,
        SDL_EVENT_WILL_ENTER_FOREGROUND,
        SDL_EVENT_DID_ENTER_FOREGROUND,
        SDL_EVENT_LOCALE_CHANGED,
        SDL_EVENT_DISPLAY_ORIENTATION = (SDL_EventType)0x151,
        SDL_EVENT_DISPLAY_CONNECTED,
        SDL_EVENT_DISPLAY_DISCONNECTED,
        SDL_EVENT_DISPLAY_MOVED,
        SDL_EVENT_DISPLAY_FIRST = SDL_EVENT_DISPLAY_ORIENTATION,
        SDL_EVENT_DISPLAY_LAST = SDL_EVENT_DISPLAY_DISCONNECTED,
        SDL_EVENT_SYSWM = (SDL_EventType)0x201,
        SDL_EVENT_WINDOW_SHOWN,
        SDL_EVENT_WINDOW_HIDDEN,
        SDL_EVENT_WINDOW_EXPOSED,
        SDL_EVENT_WINDOW_MOVED,
        SDL_EVENT_WINDOW_RESIZED,
        SDL_EVENT_WINDOW_PIXEL_SIZE_CHANGED,
        SDL_EVENT_WINDOW_MINIMIZED,
        SDL_EVENT_WINDOW_MAXIMIZED,
        SDL_EVENT_WINDOW_RESTORED,
        SDL_EVENT_WINDOW_MOUSE_ENTER,
        SDL_EVENT_WINDOW_MOUSE_LEAVE,
        SDL_EVENT_WINDOW_FOCUS_GAINED,
        SDL_EVENT_WINDOW_FOCUS_LOST,
        SDL_EVENT_WINDOW_CLOSE_REQUESTED,
        SDL_EVENT_WINDOW_TAKE_FOCUS,
        SDL_EVENT_WINDOW_HIT_TEST,
        SDL_EVENT_WINDOW_ICCPROF_CHANGED,
        SDL_EVENT_WINDOW_DISPLAY_CHANGED,
        SDL_EVENT_WINDOW_FIRST = SDL_EVENT_WINDOW_SHOWN,
        SDL_EVENT_WINDOW_LAST = SDL_EVENT_WINDOW_DISPLAY_CHANGED,
        SDL_EVENT_KEY_DOWN = (SDL_EventType)0x300,
        SDL_EVENT_KEY_UP,
        SDL_EVENT_TEXT_EDITING,
        SDL_EVENT_TEXT_INPUT,
        SDL_EVENT_KEYMAP_CHANGED,
        SDL_EVENT_TEXT_EDITING_EXT,
        SDL_EVENT_MOUSE_MOTION = (SDL_EventType)0x400,
        SDL_EVENT_MOUSE_BUTTON_DOWN,
        SDL_EVENT_MOUSE_BUTTON_UP,
        SDL_EVENT_MOUSE_WHEEL,
        SDL_EVENT_JOYSTICK_AXIS_MOTION = (SDL_EventType)0x600,
        SDL_EVENT_JOYSTICK_HAT_MOTION = (SDL_EventType)0x602,
        SDL_EVENT_JOYSTICK_BUTTON_DOWN,
        SDL_EVENT_JOYSTICK_BUTTON_UP,
        SDL_EVENT_JOYSTICK_ADDED,
        SDL_EVENT_JOYSTICK_REMOVED,
        SDL_EVENT_JOYSTICK_BATTERY_UPDATED,
        SDL_EVENT_GAMEPAD_AXIS_MOTION = (SDL_EventType)0x650,
        SDL_EVENT_GAMEPAD_BUTTON_DOWN,
        SDL_EVENT_GAMEPAD_BUTTON_UP,
        SDL_EVENT_GAMEPAD_ADDED,
        SDL_EVENT_GAMEPAD_REMOVED,
        SDL_EVENT_GAMEPAD_REMAPPED,
        SDL_EVENT_GAMEPAD_TOUCHPAD_DOWN,
        SDL_EVENT_GAMEPAD_TOUCHPAD_MOTION,
        SDL_EVENT_GAMEPAD_TOUCHPAD_UP,
        SDL_EVENT_GAMEPAD_SENSOR_UPDATE,
        SDL_EVENT_FINGER_DOWN = (SDL_EventType)0x700,
        SDL_EVENT_FINGER_UP,
        SDL_EVENT_FINGER_MOTION,
        SDL_EVENT_CLIPBOARD_UPDATE = (SDL_EventType)0x900,
        SDL_EVENT_DROP_FILE = (SDL_EventType)0x1000,
        SDL_EVENT_DROP_TEXT,
        SDL_EVENT_DROP_BEGIN,
        SDL_EVENT_DROP_COMPLETE,
        SDL_EVENT_AUDIO_DEVICE_ADDED = (SDL_EventType)0x1100,
        SDL_EVENT_AUDIO_DEVICE_REMOVED,
        SDL_EVENT_SENSOR_UPDATE = (SDL_EventType)0x1200,
        SDL_EVENT_RENDER_TARGETS_RESET = (SDL_EventType)0x2000,
        SDL_EVENT_RENDER_DEVICE_RESET,
        SDL_EVENT_POLL_SENTINEL = (SDL_EventType)0x7F00,
        SDL_EVENT_USER = (SDL_EventType)0x8000,
        SDL_EVENT_LAST = (SDL_EventType)0xFFFF;

    [NativeTypeName("unsigned int")]
    public enum SDL_eventaction : uint
    {
    }

    public static SDL_eventaction SDL_ADDEVENT,
        SDL_PEEKEVENT,
        SDL_GETEVENT;

    [NativeTypeName("unsigned int")]
    public enum SDL_GamepadType : uint
    {
    }

    public static SDL_GamepadType SDL_GAMEPAD_TYPE_UNKNOWN = 0,
        SDL_GAMEPAD_TYPE_VIRTUAL,
        SDL_GAMEPAD_TYPE_XBOX360,
        SDL_GAMEPAD_TYPE_XBOXONE,
        SDL_GAMEPAD_TYPE_PS3,
        SDL_GAMEPAD_TYPE_PS4,
        SDL_GAMEPAD_TYPE_PS5,
        SDL_GAMEPAD_TYPE_NINTENDO_SWITCH_PRO,
        SDL_GAMEPAD_TYPE_NINTENDO_SWITCH_JOYCON_LEFT,
        SDL_GAMEPAD_TYPE_NINTENDO_SWITCH_JOYCON_RIGHT,
        SDL_GAMEPAD_TYPE_NINTENDO_SWITCH_JOYCON_PAIR,
        SDL_GAMEPAD_TYPE_AMAZON_LUNA,
        SDL_GAMEPAD_TYPE_GOOGLE_STADIA,
        SDL_GAMEPAD_TYPE_NVIDIA_SHIELD;

    public enum SDL_GamepadButton
    {
    }

    public static SDL_GamepadButton SDL_GAMEPAD_BUTTON_INVALID = (SDL_GamepadButton)(int)-1,
        SDL_GAMEPAD_BUTTON_A,
        SDL_GAMEPAD_BUTTON_B,
        SDL_GAMEPAD_BUTTON_X,
        SDL_GAMEPAD_BUTTON_Y,
        SDL_GAMEPAD_BUTTON_BACK,
        SDL_GAMEPAD_BUTTON_GUIDE,
        SDL_GAMEPAD_BUTTON_START,
        SDL_GAMEPAD_BUTTON_LEFT_STICK,
        SDL_GAMEPAD_BUTTON_RIGHT_STICK,
        SDL_GAMEPAD_BUTTON_LEFT_SHOULDER,
        SDL_GAMEPAD_BUTTON_RIGHT_SHOULDER,
        SDL_GAMEPAD_BUTTON_DPAD_UP,
        SDL_GAMEPAD_BUTTON_DPAD_DOWN,
        SDL_GAMEPAD_BUTTON_DPAD_LEFT,
        SDL_GAMEPAD_BUTTON_DPAD_RIGHT,
        SDL_GAMEPAD_BUTTON_MISC1,
        SDL_GAMEPAD_BUTTON_PADDLE1,
        SDL_GAMEPAD_BUTTON_PADDLE2,
        SDL_GAMEPAD_BUTTON_PADDLE3,
        SDL_GAMEPAD_BUTTON_PADDLE4,
        SDL_GAMEPAD_BUTTON_TOUCHPAD,
        SDL_GAMEPAD_BUTTON_MAX;

    public enum SDL_GamepadAxis
    {
    }

    public static SDL_GamepadAxis SDL_GAMEPAD_AXIS_INVALID = (SDL_GamepadAxis)(int)-1,
        SDL_GAMEPAD_AXIS_LEFTX,
        SDL_GAMEPAD_AXIS_LEFTY,
        SDL_GAMEPAD_AXIS_RIGHTX,
        SDL_GAMEPAD_AXIS_RIGHTY,
        SDL_GAMEPAD_AXIS_LEFT_TRIGGER,
        SDL_GAMEPAD_AXIS_RIGHT_TRIGGER,
        SDL_GAMEPAD_AXIS_MAX;

    [NativeTypeName("unsigned int")]
    public enum SDL_GamepadBindingType : uint
    {
    }

    public static SDL_GamepadBindingType SDL_GAMEPAD_BINDTYPE_NONE = 0,
        SDL_GAMEPAD_BINDTYPE_BUTTON,
        SDL_GAMEPAD_BINDTYPE_AXIS,
        SDL_GAMEPAD_BINDTYPE_HAT;

    [NativeTypeName("unsigned int")]
    public enum SDL_HintPriority : uint
    {
    }

    public static SDL_HintPriority SDL_HINT_DEFAULT,
        SDL_HINT_NORMAL,
        SDL_HINT_OVERRIDE;

    [NativeTypeName("unsigned int")]
    public enum SDL_JoystickType : uint
    {
    }

    public static SDL_JoystickType SDL_JOYSTICK_TYPE_UNKNOWN,
        SDL_JOYSTICK_TYPE_GAMEPAD,
        SDL_JOYSTICK_TYPE_WHEEL,
        SDL_JOYSTICK_TYPE_ARCADE_STICK,
        SDL_JOYSTICK_TYPE_FLIGHT_STICK,
        SDL_JOYSTICK_TYPE_DANCE_PAD,
        SDL_JOYSTICK_TYPE_GUITAR,
        SDL_JOYSTICK_TYPE_DRUM_KIT,
        SDL_JOYSTICK_TYPE_ARCADE_PAD,
        SDL_JOYSTICK_TYPE_THROTTLE;

    public enum SDL_JoystickPowerLevel
    {
    }

    public static SDL_JoystickPowerLevel SDL_JOYSTICK_POWER_UNKNOWN = (SDL_JoystickPowerLevel)(int)-1,
        SDL_JOYSTICK_POWER_EMPTY,
        SDL_JOYSTICK_POWER_LOW,
        SDL_JOYSTICK_POWER_MEDIUM,
        SDL_JOYSTICK_POWER_FULL,
        SDL_JOYSTICK_POWER_WIRED,
        SDL_JOYSTICK_POWER_MAX;

    [NativeTypeName("unsigned int")]
    public enum SDL_KeyCode : uint
    {
        SDLK_UNKNOWN = 0,
        SDLK_RETURN = '\r',
        SDLK_ESCAPE = '\x1B',
        SDLK_BACKSPACE = '\b',
        SDLK_TAB = '\t',
        SDLK_SPACE = ' ',
        SDLK_EXCLAIM = '!',
        SDLK_QUOTEDBL = '"',
        SDLK_HASH = '#',
        SDLK_PERCENT = '%',
        SDLK_DOLLAR = '$',
        SDLK_AMPERSAND = '&',
        SDLK_QUOTE = '\'',
        SDLK_LEFTPAREN = '(',
        SDLK_RIGHTPAREN = ')',
        SDLK_ASTERISK = '*',
        SDLK_PLUS = '+',
        SDLK_COMMA = ',',
        SDLK_MINUS = '-',
        SDLK_PERIOD = '.',
        SDLK_SLASH = '/',
        SDLK_0 = '0',
        SDLK_1 = '1',
        SDLK_2 = '2',
        SDLK_3 = '3',
        SDLK_4 = '4',
        SDLK_5 = '5',
        SDLK_6 = '6',
        SDLK_7 = '7',
        SDLK_8 = '8',
        SDLK_9 = '9',
        SDLK_COLON = ':',
        SDLK_SEMICOLON = ';',
        SDLK_LESS = '<',
        SDLK_EQUALS = '=',
        SDLK_GREATER = '>',
        SDLK_QUESTION = '?',
        SDLK_AT = '@',
        SDLK_LEFTBRACKET = '[',
        SDLK_BACKSLASH = '\\',
        SDLK_RIGHTBRACKET = ']',
        SDLK_CARET = '^',
        SDLK_UNDERSCORE = '_',
        SDLK_BACKQUOTE = '`',
        SDLK_a = 'a',
        SDLK_b = 'b',
        SDLK_c = 'c',
        SDLK_d = 'd',
        SDLK_e = 'e',
        SDLK_f = 'f',
        SDLK_g = 'g',
        SDLK_h = 'h',
        SDLK_i = 'i',
        SDLK_j = 'j',
        SDLK_k = 'k',
        SDLK_l = 'l',
        SDLK_m = 'm',
        SDLK_n = 'n',
        SDLK_o = 'o',
        SDLK_p = 'p',
        SDLK_q = 'q',
        SDLK_r = 'r',
        SDLK_s = 's',
        SDLK_t = 't',
        SDLK_u = 'u',
        SDLK_v = 'v',
        SDLK_w = 'w',
        SDLK_x = 'x',
        SDLK_y = 'y',
        SDLK_z = 'z',
        SDLK_CAPSLOCK = (SDL_SCANCODE_CAPSLOCK | (1 << 30)),
        SDLK_F1 = (SDL_SCANCODE_F1 | (1 << 30)),
        SDLK_F2 = (SDL_SCANCODE_F2 | (1 << 30)),
        SDLK_F3 = (SDL_SCANCODE_F3 | (1 << 30)),
        SDLK_F4 = (SDL_SCANCODE_F4 | (1 << 30)),
        SDLK_F5 = (SDL_SCANCODE_F5 | (1 << 30)),
        SDLK_F6 = (SDL_SCANCODE_F6 | (1 << 30)),
        SDLK_F7 = (SDL_SCANCODE_F7 | (1 << 30)),
        SDLK_F8 = (SDL_SCANCODE_F8 | (1 << 30)),
        SDLK_F9 = (SDL_SCANCODE_F9 | (1 << 30)),
        SDLK_F10 = (SDL_SCANCODE_F10 | (1 << 30)),
        SDLK_F11 = (SDL_SCANCODE_F11 | (1 << 30)),
        SDLK_F12 = (SDL_SCANCODE_F12 | (1 << 30)),
        SDLK_PRINTSCREEN = (SDL_SCANCODE_PRINTSCREEN | (1 << 30)),
        SDLK_SCROLLLOCK = (SDL_SCANCODE_SCROLLLOCK | (1 << 30)),
        SDLK_PAUSE = (SDL_SCANCODE_PAUSE | (1 << 30)),
        SDLK_INSERT = (SDL_SCANCODE_INSERT | (1 << 30)),
        SDLK_HOME = (SDL_SCANCODE_HOME | (1 << 30)),
        SDLK_PAGEUP = (SDL_SCANCODE_PAGEUP | (1 << 30)),
        SDLK_DELETE = '\x7F',
        SDLK_END = (SDL_SCANCODE_END | (1 << 30)),
        SDLK_PAGEDOWN = (SDL_SCANCODE_PAGEDOWN | (1 << 30)),
        SDLK_RIGHT = (SDL_SCANCODE_RIGHT | (1 << 30)),
        SDLK_LEFT = (SDL_SCANCODE_LEFT | (1 << 30)),
        SDLK_DOWN = (SDL_SCANCODE_DOWN | (1 << 30)),
        SDLK_UP = (SDL_SCANCODE_UP | (1 << 30)),
        SDLK_NUMLOCKCLEAR = (SDL_SCANCODE_NUMLOCKCLEAR | (1 << 30)),
        SDLK_KP_DIVIDE = (SDL_SCANCODE_KP_DIVIDE | (1 << 30)),
        SDLK_KP_MULTIPLY = (SDL_SCANCODE_KP_MULTIPLY | (1 << 30)),
        SDLK_KP_MINUS = (SDL_SCANCODE_KP_MINUS | (1 << 30)),
        SDLK_KP_PLUS = (SDL_SCANCODE_KP_PLUS | (1 << 30)),
        SDLK_KP_ENTER = (SDL_SCANCODE_KP_ENTER | (1 << 30)),
        SDLK_KP_1 = (SDL_SCANCODE_KP_1 | (1 << 30)),
        SDLK_KP_2 = (SDL_SCANCODE_KP_2 | (1 << 30)),
        SDLK_KP_3 = (SDL_SCANCODE_KP_3 | (1 << 30)),
        SDLK_KP_4 = (SDL_SCANCODE_KP_4 | (1 << 30)),
        SDLK_KP_5 = (SDL_SCANCODE_KP_5 | (1 << 30)),
        SDLK_KP_6 = (SDL_SCANCODE_KP_6 | (1 << 30)),
        SDLK_KP_7 = (SDL_SCANCODE_KP_7 | (1 << 30)),
        SDLK_KP_8 = (SDL_SCANCODE_KP_8 | (1 << 30)),
        SDLK_KP_9 = (SDL_SCANCODE_KP_9 | (1 << 30)),
        SDLK_KP_0 = (SDL_SCANCODE_KP_0 | (1 << 30)),
        SDLK_KP_PERIOD = (SDL_SCANCODE_KP_PERIOD | (1 << 30)),
        SDLK_APPLICATION = (SDL_SCANCODE_APPLICATION | (1 << 30)),
        SDLK_POWER = (SDL_SCANCODE_POWER | (1 << 30)),
        SDLK_KP_EQUALS = (SDL_SCANCODE_KP_EQUALS | (1 << 30)),
        SDLK_F13 = (SDL_SCANCODE_F13 | (1 << 30)),
        SDLK_F14 = (SDL_SCANCODE_F14 | (1 << 30)),
        SDLK_F15 = (SDL_SCANCODE_F15 | (1 << 30)),
        SDLK_F16 = (SDL_SCANCODE_F16 | (1 << 30)),
        SDLK_F17 = (SDL_SCANCODE_F17 | (1 << 30)),
        SDLK_F18 = (SDL_SCANCODE_F18 | (1 << 30)),
        SDLK_F19 = (SDL_SCANCODE_F19 | (1 << 30)),
        SDLK_F20 = (SDL_SCANCODE_F20 | (1 << 30)),
        SDLK_F21 = (SDL_SCANCODE_F21 | (1 << 30)),
        SDLK_F22 = (SDL_SCANCODE_F22 | (1 << 30)),
        SDLK_F23 = (SDL_SCANCODE_F23 | (1 << 30)),
        SDLK_F24 = (SDL_SCANCODE_F24 | (1 << 30)),
        SDLK_EXECUTE = (SDL_SCANCODE_EXECUTE | (1 << 30)),
        SDLK_HELP = (SDL_SCANCODE_HELP | (1 << 30)),
        SDLK_MENU = (SDL_SCANCODE_MENU | (1 << 30)),
        SDLK_SELECT = (SDL_SCANCODE_SELECT | (1 << 30)),
        SDLK_STOP = (SDL_SCANCODE_STOP | (1 << 30)),
        SDLK_AGAIN = (SDL_SCANCODE_AGAIN | (1 << 30)),
        SDLK_UNDO = (SDL_SCANCODE_UNDO | (1 << 30)),
        SDLK_CUT = (SDL_SCANCODE_CUT | (1 << 30)),
        SDLK_COPY = (SDL_SCANCODE_COPY | (1 << 30)),
        SDLK_PASTE = (SDL_SCANCODE_PASTE | (1 << 30)),
        SDLK_FIND = (SDL_SCANCODE_FIND | (1 << 30)),
        SDLK_MUTE = (SDL_SCANCODE_MUTE | (1 << 30)),
        SDLK_VOLUMEUP = (SDL_SCANCODE_VOLUMEUP | (1 << 30)),
        SDLK_VOLUMEDOWN = (SDL_SCANCODE_VOLUMEDOWN | (1 << 30)),
        SDLK_KP_COMMA = (SDL_SCANCODE_KP_COMMA | (1 << 30)),
        SDLK_KP_EQUALSAS400 = (SDL_SCANCODE_KP_EQUALSAS400 | (1 << 30)),
        SDLK_ALTERASE = (SDL_SCANCODE_ALTERASE | (1 << 30)),
        SDLK_SYSREQ = (SDL_SCANCODE_SYSREQ | (1 << 30)),
        SDLK_CANCEL = (SDL_SCANCODE_CANCEL | (1 << 30)),
        SDLK_CLEAR = (SDL_SCANCODE_CLEAR | (1 << 30)),
        SDLK_PRIOR = (SDL_SCANCODE_PRIOR | (1 << 30)),
        SDLK_RETURN2 = (SDL_SCANCODE_RETURN2 | (1 << 30)),
        SDLK_SEPARATOR = (SDL_SCANCODE_SEPARATOR | (1 << 30)),
        SDLK_OUT = (SDL_SCANCODE_OUT | (1 << 30)),
        SDLK_OPER = (SDL_SCANCODE_OPER | (1 << 30)),
        SDLK_CLEARAGAIN = (SDL_SCANCODE_CLEARAGAIN | (1 << 30)),
        SDLK_CRSEL = (SDL_SCANCODE_CRSEL | (1 << 30)),
        SDLK_EXSEL = (SDL_SCANCODE_EXSEL | (1 << 30)),
        SDLK_KP_00 = (SDL_SCANCODE_KP_00 | (1 << 30)),
        SDLK_KP_000 = (SDL_SCANCODE_KP_000 | (1 << 30)),
        SDLK_THOUSANDSSEPARATOR = (SDL_SCANCODE_THOUSANDSSEPARATOR | (1 << 30)),
        SDLK_DECIMALSEPARATOR = (SDL_SCANCODE_DECIMALSEPARATOR | (1 << 30)),
        SDLK_CURRENCYUNIT = (SDL_SCANCODE_CURRENCYUNIT | (1 << 30)),
        SDLK_CURRENCYSUBUNIT = (SDL_SCANCODE_CURRENCYSUBUNIT | (1 << 30)),
        SDLK_KP_LEFTPAREN = (SDL_SCANCODE_KP_LEFTPAREN | (1 << 30)),
        SDLK_KP_RIGHTPAREN = (SDL_SCANCODE_KP_RIGHTPAREN | (1 << 30)),
        SDLK_KP_LEFTBRACE = (SDL_SCANCODE_KP_LEFTBRACE | (1 << 30)),
        SDLK_KP_RIGHTBRACE = (SDL_SCANCODE_KP_RIGHTBRACE | (1 << 30)),
        SDLK_KP_TAB = (SDL_SCANCODE_KP_TAB | (1 << 30)),
        SDLK_KP_BACKSPACE = (SDL_SCANCODE_KP_BACKSPACE | (1 << 30)),
        SDLK_KP_A = (SDL_SCANCODE_KP_A | (1 << 30)),
        SDLK_KP_B = (SDL_SCANCODE_KP_B | (1 << 30)),
        SDLK_KP_C = (SDL_SCANCODE_KP_C | (1 << 30)),
        SDLK_KP_D = (SDL_SCANCODE_KP_D | (1 << 30)),
        SDLK_KP_E = (SDL_SCANCODE_KP_E | (1 << 30)),
        SDLK_KP_F = (SDL_SCANCODE_KP_F | (1 << 30)),
        SDLK_KP_XOR = (SDL_SCANCODE_KP_XOR | (1 << 30)),
        SDLK_KP_POWER = (SDL_SCANCODE_KP_POWER | (1 << 30)),
        SDLK_KP_PERCENT = (SDL_SCANCODE_KP_PERCENT | (1 << 30)),
        SDLK_KP_LESS = (SDL_SCANCODE_KP_LESS | (1 << 30)),
        SDLK_KP_GREATER = (SDL_SCANCODE_KP_GREATER | (1 << 30)),
        SDLK_KP_AMPERSAND = (SDL_SCANCODE_KP_AMPERSAND | (1 << 30)),
        SDLK_KP_DBLAMPERSAND = (SDL_SCANCODE_KP_DBLAMPERSAND | (1 << 30)),
        SDLK_KP_VERTICALBAR = (SDL_SCANCODE_KP_VERTICALBAR | (1 << 30)),
        SDLK_KP_DBLVERTICALBAR = (SDL_SCANCODE_KP_DBLVERTICALBAR | (1 << 30)),
        SDLK_KP_COLON = (SDL_SCANCODE_KP_COLON | (1 << 30)),
        SDLK_KP_HASH = (SDL_SCANCODE_KP_HASH | (1 << 30)),
        SDLK_KP_SPACE = (SDL_SCANCODE_KP_SPACE | (1 << 30)),
        SDLK_KP_AT = (SDL_SCANCODE_KP_AT | (1 << 30)),
        SDLK_KP_EXCLAM = (SDL_SCANCODE_KP_EXCLAM | (1 << 30)),
        SDLK_KP_MEMSTORE = (SDL_SCANCODE_KP_MEMSTORE | (1 << 30)),
        SDLK_KP_MEMRECALL = (SDL_SCANCODE_KP_MEMRECALL | (1 << 30)),
        SDLK_KP_MEMCLEAR = (SDL_SCANCODE_KP_MEMCLEAR | (1 << 30)),
        SDLK_KP_MEMADD = (SDL_SCANCODE_KP_MEMADD | (1 << 30)),
        SDLK_KP_MEMSUBTRACT = (SDL_SCANCODE_KP_MEMSUBTRACT | (1 << 30)),
        SDLK_KP_MEMMULTIPLY = (SDL_SCANCODE_KP_MEMMULTIPLY | (1 << 30)),
        SDLK_KP_MEMDIVIDE = (SDL_SCANCODE_KP_MEMDIVIDE | (1 << 30)),
        SDLK_KP_PLUSMINUS = (SDL_SCANCODE_KP_PLUSMINUS | (1 << 30)),
        SDLK_KP_CLEAR = (SDL_SCANCODE_KP_CLEAR | (1 << 30)),
        SDLK_KP_CLEARENTRY = (SDL_SCANCODE_KP_CLEARENTRY | (1 << 30)),
        SDLK_KP_BINARY = (SDL_SCANCODE_KP_BINARY | (1 << 30)),
        SDLK_KP_OCTAL = (SDL_SCANCODE_KP_OCTAL | (1 << 30)),
        SDLK_KP_DECIMAL = (SDL_SCANCODE_KP_DECIMAL | (1 << 30)),
        SDLK_KP_HEXADECIMAL = (SDL_SCANCODE_KP_HEXADECIMAL | (1 << 30)),
        SDLK_LCTRL = (SDL_SCANCODE_LCTRL | (1 << 30)),
        SDLK_LSHIFT = (SDL_SCANCODE_LSHIFT | (1 << 30)),
        SDLK_LALT = (SDL_SCANCODE_LALT | (1 << 30)),
        SDLK_LGUI = (SDL_SCANCODE_LGUI | (1 << 30)),
        SDLK_RCTRL = (SDL_SCANCODE_RCTRL | (1 << 30)),
        SDLK_RSHIFT = (SDL_SCANCODE_RSHIFT | (1 << 30)),
        SDLK_RALT = (SDL_SCANCODE_RALT | (1 << 30)),
        SDLK_RGUI = (SDL_SCANCODE_RGUI | (1 << 30)),
        SDLK_MODE = (SDL_SCANCODE_MODE | (1 << 30)),
        SDLK_AUDIONEXT = (SDL_SCANCODE_AUDIONEXT | (1 << 30)),
        SDLK_AUDIOPREV = (SDL_SCANCODE_AUDIOPREV | (1 << 30)),
        SDLK_AUDIOSTOP = (SDL_SCANCODE_AUDIOSTOP | (1 << 30)),
        SDLK_AUDIOPLAY = (SDL_SCANCODE_AUDIOPLAY | (1 << 30)),
        SDLK_AUDIOMUTE = (SDL_SCANCODE_AUDIOMUTE | (1 << 30)),
        SDLK_MEDIASELECT = (SDL_SCANCODE_MEDIASELECT | (1 << 30)),
        SDLK_WWW = (SDL_SCANCODE_WWW | (1 << 30)),
        SDLK_MAIL = (SDL_SCANCODE_MAIL | (1 << 30)),
        SDLK_CALCULATOR = (SDL_SCANCODE_CALCULATOR | (1 << 30)),
        SDLK_COMPUTER = (SDL_SCANCODE_COMPUTER | (1 << 30)),
        SDLK_AC_SEARCH = (SDL_SCANCODE_AC_SEARCH | (1 << 30)),
        SDLK_AC_HOME = (SDL_SCANCODE_AC_HOME | (1 << 30)),
        SDLK_AC_BACK = (SDL_SCANCODE_AC_BACK | (1 << 30)),
        SDLK_AC_FORWARD = (SDL_SCANCODE_AC_FORWARD | (1 << 30)),
        SDLK_AC_STOP = (SDL_SCANCODE_AC_STOP | (1 << 30)),
        SDLK_AC_REFRESH = (SDL_SCANCODE_AC_REFRESH | (1 << 30)),
        SDLK_AC_BOOKMARKS = (SDL_SCANCODE_AC_BOOKMARKS | (1 << 30)),
        SDLK_BRIGHTNESSDOWN = (SDL_SCANCODE_BRIGHTNESSDOWN | (1 << 30)),
        SDLK_BRIGHTNESSUP = (SDL_SCANCODE_BRIGHTNESSUP | (1 << 30)),
        SDLK_DISPLAYSWITCH = (SDL_SCANCODE_DISPLAYSWITCH | (1 << 30)),
        SDLK_KBDILLUMTOGGLE = (SDL_SCANCODE_KBDILLUMTOGGLE | (1 << 30)),
        SDLK_KBDILLUMDOWN = (SDL_SCANCODE_KBDILLUMDOWN | (1 << 30)),
        SDLK_KBDILLUMUP = (SDL_SCANCODE_KBDILLUMUP | (1 << 30)),
        SDLK_EJECT = (SDL_SCANCODE_EJECT | (1 << 30)),
        SDLK_SLEEP = (SDL_SCANCODE_SLEEP | (1 << 30)),
        SDLK_APP1 = (SDL_SCANCODE_APP1 | (1 << 30)),
        SDLK_APP2 = (SDL_SCANCODE_APP2 | (1 << 30)),
        SDLK_AUDIOREWIND = (SDL_SCANCODE_AUDIOREWIND | (1 << 30)),
        SDLK_AUDIOFASTFORWARD = (SDL_SCANCODE_AUDIOFASTFORWARD | (1 << 30)),
        SDLK_SOFTLEFT = (SDL_SCANCODE_SOFTLEFT | (1 << 30)),
        SDLK_SOFTRIGHT = (SDL_SCANCODE_SOFTRIGHT | (1 << 30)),
        SDLK_CALL = (SDL_SCANCODE_CALL | (1 << 30)),
        SDLK_ENDCALL = (SDL_SCANCODE_ENDCALL | (1 << 30)),
    }

    [NativeTypeName("unsigned int")]
    public enum SDL_Keymod : uint
    {
        SDL_KMOD_NONE = 0x0000,
        SDL_KMOD_LSHIFT = 0x0001,
        SDL_KMOD_RSHIFT = 0x0002,
        SDL_KMOD_LCTRL = 0x0040,
        SDL_KMOD_RCTRL = 0x0080,
        SDL_KMOD_LALT = 0x0100,
        SDL_KMOD_RALT = 0x0200,
        SDL_KMOD_LGUI = 0x0400,
        SDL_KMOD_RGUI = 0x0800,
        SDL_KMOD_NUM = 0x1000,
        SDL_KMOD_CAPS = 0x2000,
        SDL_KMOD_MODE = 0x4000,
        SDL_KMOD_SCROLL = 0x8000,
        SDL_KMOD_CTRL = SDL_KMOD_LCTRL | SDL_KMOD_RCTRL,
        SDL_KMOD_SHIFT = SDL_KMOD_LSHIFT | SDL_KMOD_RSHIFT,
        SDL_KMOD_ALT = SDL_KMOD_LALT | SDL_KMOD_RALT,
        SDL_KMOD_GUI = SDL_KMOD_LGUI | SDL_KMOD_RGUI,
        SDL_KMOD_RESERVED = SDL_KMOD_SCROLL,
    }

    [NativeTypeName("unsigned int")]
    public enum SDL_Scancode : uint {}
    
    public const SDL_Scancode SDL_SCANCODE_UNKNOWN = (SDL_Scancode)0,
        SDL_SCANCODE_A = (SDL_Scancode)4,
        SDL_SCANCODE_B = (SDL_Scancode)5,
        SDL_SCANCODE_C = (SDL_Scancode)6,
        SDL_SCANCODE_D = (SDL_Scancode)7,
        SDL_SCANCODE_E = (SDL_Scancode)8,
        SDL_SCANCODE_F = (SDL_Scancode)9,
        SDL_SCANCODE_G = (SDL_Scancode)10,
        SDL_SCANCODE_H = (SDL_Scancode)11,
        SDL_SCANCODE_I = (SDL_Scancode)12,
        SDL_SCANCODE_J = (SDL_Scancode)13,
        SDL_SCANCODE_K = (SDL_Scancode)14,
        SDL_SCANCODE_L = (SDL_Scancode)15,
        SDL_SCANCODE_M = (SDL_Scancode)16,
        SDL_SCANCODE_N = (SDL_Scancode)17,
        SDL_SCANCODE_O = (SDL_Scancode)18,
        SDL_SCANCODE_P = (SDL_Scancode)19,
        SDL_SCANCODE_Q = (SDL_Scancode)20,
        SDL_SCANCODE_R = (SDL_Scancode)21,
        SDL_SCANCODE_S = (SDL_Scancode)22,
        SDL_SCANCODE_T = (SDL_Scancode)23,
        SDL_SCANCODE_U = (SDL_Scancode)24,
        SDL_SCANCODE_V = (SDL_Scancode)25,
        SDL_SCANCODE_W = (SDL_Scancode)26,
        SDL_SCANCODE_X = (SDL_Scancode)27,
        SDL_SCANCODE_Y = (SDL_Scancode)28,
        SDL_SCANCODE_Z = (SDL_Scancode)29,
        SDL_SCANCODE_1 = (SDL_Scancode)30,
        SDL_SCANCODE_2 = (SDL_Scancode)31,
        SDL_SCANCODE_3 = (SDL_Scancode)32,
        SDL_SCANCODE_4 = (SDL_Scancode)33,
        SDL_SCANCODE_5 = (SDL_Scancode)34,
        SDL_SCANCODE_6 = (SDL_Scancode)35,
        SDL_SCANCODE_7 = (SDL_Scancode)36,
        SDL_SCANCODE_8 = (SDL_Scancode)37,
        SDL_SCANCODE_9 = (SDL_Scancode)38,
        SDL_SCANCODE_0 = (SDL_Scancode)39,
        SDL_SCANCODE_RETURN = (SDL_Scancode)40,
        SDL_SCANCODE_ESCAPE = (SDL_Scancode)41,
        SDL_SCANCODE_BACKSPACE = (SDL_Scancode)42,
        SDL_SCANCODE_TAB = (SDL_Scancode)43,
        SDL_SCANCODE_SPACE = (SDL_Scancode)44,
        SDL_SCANCODE_MINUS = (SDL_Scancode)45,
        SDL_SCANCODE_EQUALS = (SDL_Scancode)46,
        SDL_SCANCODE_LEFTBRACKET = (SDL_Scancode)47,
        SDL_SCANCODE_RIGHTBRACKET = (SDL_Scancode)48,
        SDL_SCANCODE_BACKSLASH = (SDL_Scancode)49,
        SDL_SCANCODE_NONUSHASH = (SDL_Scancode)50,
        SDL_SCANCODE_SEMICOLON = (SDL_Scancode)51,
        SDL_SCANCODE_APOSTROPHE = (SDL_Scancode)52,
        SDL_SCANCODE_GRAVE = (SDL_Scancode)53,
        SDL_SCANCODE_COMMA = (SDL_Scancode)54,
        SDL_SCANCODE_PERIOD = (SDL_Scancode)55,
        SDL_SCANCODE_SLASH = (SDL_Scancode)56,
        SDL_SCANCODE_CAPSLOCK = (SDL_Scancode)57,
        SDL_SCANCODE_F1 = (SDL_Scancode)58,
        SDL_SCANCODE_F2 = (SDL_Scancode)59,
        SDL_SCANCODE_F3 = (SDL_Scancode)60,
        SDL_SCANCODE_F4 = (SDL_Scancode)61,
        SDL_SCANCODE_F5 = (SDL_Scancode)62,
        SDL_SCANCODE_F6 = (SDL_Scancode)63,
        SDL_SCANCODE_F7 = (SDL_Scancode)64,
        SDL_SCANCODE_F8 = (SDL_Scancode)65,
        SDL_SCANCODE_F9 = (SDL_Scancode)66,
        SDL_SCANCODE_F10 = (SDL_Scancode)67,
        SDL_SCANCODE_F11 = (SDL_Scancode)68,
        SDL_SCANCODE_F12 = (SDL_Scancode)69,
        SDL_SCANCODE_PRINTSCREEN = (SDL_Scancode)70,
        SDL_SCANCODE_SCROLLLOCK = (SDL_Scancode)71,
        SDL_SCANCODE_PAUSE = (SDL_Scancode)72,
        SDL_SCANCODE_INSERT = (SDL_Scancode)73,
        SDL_SCANCODE_HOME = (SDL_Scancode)74,
        SDL_SCANCODE_PAGEUP = (SDL_Scancode)75,
        SDL_SCANCODE_DELETE = (SDL_Scancode)76,
        SDL_SCANCODE_END = (SDL_Scancode)77,
        SDL_SCANCODE_PAGEDOWN = (SDL_Scancode)78,
        SDL_SCANCODE_RIGHT = (SDL_Scancode)79,
        SDL_SCANCODE_LEFT = (SDL_Scancode)80,
        SDL_SCANCODE_DOWN = (SDL_Scancode)81,
        SDL_SCANCODE_UP = (SDL_Scancode)82,
        SDL_SCANCODE_NUMLOCKCLEAR = (SDL_Scancode)83,
        SDL_SCANCODE_KP_DIVIDE = (SDL_Scancode)84,
        SDL_SCANCODE_KP_MULTIPLY = (SDL_Scancode)85,
        SDL_SCANCODE_KP_MINUS = (SDL_Scancode)86,
        SDL_SCANCODE_KP_PLUS = (SDL_Scancode)87,
        SDL_SCANCODE_KP_ENTER = (SDL_Scancode)88,
        SDL_SCANCODE_KP_1 = (SDL_Scancode)89,
        SDL_SCANCODE_KP_2 = (SDL_Scancode)90,
        SDL_SCANCODE_KP_3 = (SDL_Scancode)91,
        SDL_SCANCODE_KP_4 = (SDL_Scancode)92,
        SDL_SCANCODE_KP_5 = (SDL_Scancode)93,
        SDL_SCANCODE_KP_6 = (SDL_Scancode)94,
        SDL_SCANCODE_KP_7 = (SDL_Scancode)95,
        SDL_SCANCODE_KP_8 = (SDL_Scancode)96,
        SDL_SCANCODE_KP_9 = (SDL_Scancode)97,
        SDL_SCANCODE_KP_0 = (SDL_Scancode)98,
        SDL_SCANCODE_KP_PERIOD = (SDL_Scancode)99,
        SDL_SCANCODE_NONUSBACKSLASH = (SDL_Scancode)100,
        SDL_SCANCODE_APPLICATION = (SDL_Scancode)101,
        SDL_SCANCODE_POWER = (SDL_Scancode)102,
        SDL_SCANCODE_KP_EQUALS = (SDL_Scancode)103,
        SDL_SCANCODE_F13 = (SDL_Scancode)104,
        SDL_SCANCODE_F14 = (SDL_Scancode)105,
        SDL_SCANCODE_F15 = (SDL_Scancode)106,
        SDL_SCANCODE_F16 = (SDL_Scancode)107,
        SDL_SCANCODE_F17 = (SDL_Scancode)108,
        SDL_SCANCODE_F18 = (SDL_Scancode)109,
        SDL_SCANCODE_F19 = (SDL_Scancode)110,
        SDL_SCANCODE_F20 = (SDL_Scancode)111,
        SDL_SCANCODE_F21 = (SDL_Scancode)112,
        SDL_SCANCODE_F22 = (SDL_Scancode)113,
        SDL_SCANCODE_F23 = (SDL_Scancode)114,
        SDL_SCANCODE_F24 = (SDL_Scancode)115,
        SDL_SCANCODE_EXECUTE = (SDL_Scancode)116,
        SDL_SCANCODE_HELP = (SDL_Scancode)117,
        SDL_SCANCODE_MENU = (SDL_Scancode)118,
        SDL_SCANCODE_SELECT = (SDL_Scancode)119,
        SDL_SCANCODE_STOP = (SDL_Scancode)120,
        SDL_SCANCODE_AGAIN = (SDL_Scancode)121,
        SDL_SCANCODE_UNDO = (SDL_Scancode)122,
        SDL_SCANCODE_CUT = (SDL_Scancode)123,
        SDL_SCANCODE_COPY = (SDL_Scancode)124,
        SDL_SCANCODE_PASTE = (SDL_Scancode)125,
        SDL_SCANCODE_FIND = (SDL_Scancode)126,
        SDL_SCANCODE_MUTE = (SDL_Scancode)127,
        SDL_SCANCODE_VOLUMEUP = (SDL_Scancode)128,
        SDL_SCANCODE_VOLUMEDOWN = (SDL_Scancode)129,
        SDL_SCANCODE_KP_COMMA = (SDL_Scancode)133,
        SDL_SCANCODE_KP_EQUALSAS400 = (SDL_Scancode)134,
        SDL_SCANCODE_INTERNATIONAL1 = (SDL_Scancode)135,
        SDL_SCANCODE_INTERNATIONAL2 = (SDL_Scancode)136,
        SDL_SCANCODE_INTERNATIONAL3 = (SDL_Scancode)137,
        SDL_SCANCODE_INTERNATIONAL4 = (SDL_Scancode)138,
        SDL_SCANCODE_INTERNATIONAL5 = (SDL_Scancode)139,
        SDL_SCANCODE_INTERNATIONAL6 = (SDL_Scancode)140,
        SDL_SCANCODE_INTERNATIONAL7 = (SDL_Scancode)141,
        SDL_SCANCODE_INTERNATIONAL8 = (SDL_Scancode)142,
        SDL_SCANCODE_INTERNATIONAL9 = (SDL_Scancode)143,
        SDL_SCANCODE_LANG1 = (SDL_Scancode)144,
        SDL_SCANCODE_LANG2 = (SDL_Scancode)145,
        SDL_SCANCODE_LANG3 = (SDL_Scancode)146,
        SDL_SCANCODE_LANG4 = (SDL_Scancode)147,
        SDL_SCANCODE_LANG5 = (SDL_Scancode)148,
        SDL_SCANCODE_LANG6 = (SDL_Scancode)149,
        SDL_SCANCODE_LANG7 = (SDL_Scancode)150,
        SDL_SCANCODE_LANG8 = (SDL_Scancode)151,
        SDL_SCANCODE_LANG9 = (SDL_Scancode)152,
        SDL_SCANCODE_ALTERASE = (SDL_Scancode)153,
        SDL_SCANCODE_SYSREQ = (SDL_Scancode)154,
        SDL_SCANCODE_CANCEL = (SDL_Scancode)155,
        SDL_SCANCODE_CLEAR = (SDL_Scancode)156,
        SDL_SCANCODE_PRIOR = (SDL_Scancode)157,
        SDL_SCANCODE_RETURN2 = (SDL_Scancode)158,
        SDL_SCANCODE_SEPARATOR = (SDL_Scancode)159,
        SDL_SCANCODE_OUT = (SDL_Scancode)160,
        SDL_SCANCODE_OPER = (SDL_Scancode)161,
        SDL_SCANCODE_CLEARAGAIN = (SDL_Scancode)162,
        SDL_SCANCODE_CRSEL = (SDL_Scancode)163,
        SDL_SCANCODE_EXSEL = (SDL_Scancode)164,
        SDL_SCANCODE_KP_00 = (SDL_Scancode)176,
        SDL_SCANCODE_KP_000 = (SDL_Scancode)177,
        SDL_SCANCODE_THOUSANDSSEPARATOR = (SDL_Scancode)178,
        SDL_SCANCODE_DECIMALSEPARATOR = (SDL_Scancode)179,
        SDL_SCANCODE_CURRENCYUNIT = (SDL_Scancode)180,
        SDL_SCANCODE_CURRENCYSUBUNIT = (SDL_Scancode)181,
        SDL_SCANCODE_KP_LEFTPAREN = (SDL_Scancode)182,
        SDL_SCANCODE_KP_RIGHTPAREN = (SDL_Scancode)183,
        SDL_SCANCODE_KP_LEFTBRACE = (SDL_Scancode)184,
        SDL_SCANCODE_KP_RIGHTBRACE = (SDL_Scancode)185,
        SDL_SCANCODE_KP_TAB = (SDL_Scancode)186,
        SDL_SCANCODE_KP_BACKSPACE = (SDL_Scancode)187,
        SDL_SCANCODE_KP_A = (SDL_Scancode)188,
        SDL_SCANCODE_KP_B = (SDL_Scancode)189,
        SDL_SCANCODE_KP_C = (SDL_Scancode)190,
        SDL_SCANCODE_KP_D = (SDL_Scancode)191,
        SDL_SCANCODE_KP_E = (SDL_Scancode)192,
        SDL_SCANCODE_KP_F = (SDL_Scancode)193,
        SDL_SCANCODE_KP_XOR = (SDL_Scancode)194,
        SDL_SCANCODE_KP_POWER = (SDL_Scancode)195,
        SDL_SCANCODE_KP_PERCENT = (SDL_Scancode)196,
        SDL_SCANCODE_KP_LESS = (SDL_Scancode)197,
        SDL_SCANCODE_KP_GREATER = (SDL_Scancode)198,
        SDL_SCANCODE_KP_AMPERSAND = (SDL_Scancode)199,
        SDL_SCANCODE_KP_DBLAMPERSAND = (SDL_Scancode)200,
        SDL_SCANCODE_KP_VERTICALBAR = (SDL_Scancode)201,
        SDL_SCANCODE_KP_DBLVERTICALBAR = (SDL_Scancode)202,
        SDL_SCANCODE_KP_COLON = (SDL_Scancode)203,
        SDL_SCANCODE_KP_HASH = (SDL_Scancode)204,
        SDL_SCANCODE_KP_SPACE = (SDL_Scancode)205,
        SDL_SCANCODE_KP_AT = (SDL_Scancode)206,
        SDL_SCANCODE_KP_EXCLAM = (SDL_Scancode)207,
        SDL_SCANCODE_KP_MEMSTORE = (SDL_Scancode)208,
        SDL_SCANCODE_KP_MEMRECALL = (SDL_Scancode)209,
        SDL_SCANCODE_KP_MEMCLEAR = (SDL_Scancode)210,
        SDL_SCANCODE_KP_MEMADD = (SDL_Scancode)211,
        SDL_SCANCODE_KP_MEMSUBTRACT = (SDL_Scancode)212,
        SDL_SCANCODE_KP_MEMMULTIPLY = (SDL_Scancode)213,
        SDL_SCANCODE_KP_MEMDIVIDE = (SDL_Scancode)214,
        SDL_SCANCODE_KP_PLUSMINUS = (SDL_Scancode)215,
        SDL_SCANCODE_KP_CLEAR = (SDL_Scancode)216,
        SDL_SCANCODE_KP_CLEARENTRY = (SDL_Scancode)217,
        SDL_SCANCODE_KP_BINARY = (SDL_Scancode)218,
        SDL_SCANCODE_KP_OCTAL = (SDL_Scancode)219,
        SDL_SCANCODE_KP_DECIMAL = (SDL_Scancode)220,
        SDL_SCANCODE_KP_HEXADECIMAL = (SDL_Scancode)221,
        SDL_SCANCODE_LCTRL = (SDL_Scancode)224,
        SDL_SCANCODE_LSHIFT = (SDL_Scancode)225,
        SDL_SCANCODE_LALT = (SDL_Scancode)226,
        SDL_SCANCODE_LGUI = (SDL_Scancode)227,
        SDL_SCANCODE_RCTRL = (SDL_Scancode)228,
        SDL_SCANCODE_RSHIFT = (SDL_Scancode)229,
        SDL_SCANCODE_RALT = (SDL_Scancode)230,
        SDL_SCANCODE_RGUI = (SDL_Scancode)231,
        SDL_SCANCODE_MODE = (SDL_Scancode)257,
        SDL_SCANCODE_AUDIONEXT = (SDL_Scancode)258,
        SDL_SCANCODE_AUDIOPREV = (SDL_Scancode)259,
        SDL_SCANCODE_AUDIOSTOP = (SDL_Scancode)260,
        SDL_SCANCODE_AUDIOPLAY = (SDL_Scancode)261,
        SDL_SCANCODE_AUDIOMUTE = (SDL_Scancode)262,
        SDL_SCANCODE_MEDIASELECT = (SDL_Scancode)263,
        SDL_SCANCODE_WWW = (SDL_Scancode)264,
        SDL_SCANCODE_MAIL = (SDL_Scancode)265,
        SDL_SCANCODE_CALCULATOR = (SDL_Scancode)266,
        SDL_SCANCODE_COMPUTER = (SDL_Scancode)267,
        SDL_SCANCODE_AC_SEARCH = (SDL_Scancode)268,
        SDL_SCANCODE_AC_HOME = (SDL_Scancode)269,
        SDL_SCANCODE_AC_BACK = (SDL_Scancode)270,
        SDL_SCANCODE_AC_FORWARD = (SDL_Scancode)271,
        SDL_SCANCODE_AC_STOP = (SDL_Scancode)272,
        SDL_SCANCODE_AC_REFRESH = (SDL_Scancode)273,
        SDL_SCANCODE_AC_BOOKMARKS = (SDL_Scancode)274,
        SDL_SCANCODE_BRIGHTNESSDOWN = (SDL_Scancode)275,
        SDL_SCANCODE_BRIGHTNESSUP = (SDL_Scancode)276,
        SDL_SCANCODE_DISPLAYSWITCH = (SDL_Scancode)277,
        SDL_SCANCODE_KBDILLUMTOGGLE = (SDL_Scancode)278,
        SDL_SCANCODE_KBDILLUMDOWN = (SDL_Scancode)279,
        SDL_SCANCODE_KBDILLUMUP = (SDL_Scancode)280,
        SDL_SCANCODE_EJECT = (SDL_Scancode)281,
        SDL_SCANCODE_SLEEP = (SDL_Scancode)282,
        SDL_SCANCODE_APP1 = (SDL_Scancode)283,
        SDL_SCANCODE_APP2 = (SDL_Scancode)284,
        SDL_SCANCODE_AUDIOREWIND = (SDL_Scancode)285,
        SDL_SCANCODE_AUDIOFASTFORWARD = (SDL_Scancode)286,
        SDL_SCANCODE_SOFTLEFT = (SDL_Scancode)287,
        SDL_SCANCODE_SOFTRIGHT = (SDL_Scancode)288,
        SDL_SCANCODE_CALL = (SDL_Scancode)289,
        SDL_SCANCODE_ENDCALL = (SDL_Scancode)290,
        SDL_NUM_SCANCODES = (SDL_Scancode)512;

    [NativeTypeName("unsigned int")]
    public enum SDL_LogCategory : uint
    {
    }

    public static SDL_LogCategory SDL_LOG_CATEGORY_APPLICATION,
        SDL_LOG_CATEGORY_ERROR,
        SDL_LOG_CATEGORY_ASSERT,
        SDL_LOG_CATEGORY_SYSTEM,
        SDL_LOG_CATEGORY_AUDIO,
        SDL_LOG_CATEGORY_VIDEO,
        SDL_LOG_CATEGORY_RENDER,
        SDL_LOG_CATEGORY_INPUT,
        SDL_LOG_CATEGORY_TEST,
        SDL_LOG_CATEGORY_RESERVED1,
        SDL_LOG_CATEGORY_RESERVED2,
        SDL_LOG_CATEGORY_RESERVED3,
        SDL_LOG_CATEGORY_RESERVED4,
        SDL_LOG_CATEGORY_RESERVED5,
        SDL_LOG_CATEGORY_RESERVED6,
        SDL_LOG_CATEGORY_RESERVED7,
        SDL_LOG_CATEGORY_RESERVED8,
        SDL_LOG_CATEGORY_RESERVED9,
        SDL_LOG_CATEGORY_RESERVED10,
        SDL_LOG_CATEGORY_CUSTOM;

    [NativeTypeName("unsigned int")]
    public enum SDL_LogPriority : uint
    {
    }

    public static SDL_LogPriority SDL_LOG_PRIORITY_VERBOSE = (SDL_LogPriority)1,
        SDL_LOG_PRIORITY_DEBUG,
        SDL_LOG_PRIORITY_INFO,
        SDL_LOG_PRIORITY_WARN,
        SDL_LOG_PRIORITY_ERROR,
        SDL_LOG_PRIORITY_CRITICAL,
        SDL_NUM_LOG_PRIORITIES;

    [NativeTypeName("unsigned int")]
    public enum SDL_MessageBoxFlags : uint
    {
    }

    public const SDL_MessageBoxFlags SDL_MESSAGEBOX_ERROR = (SDL_MessageBoxFlags)0x00000010,
        SDL_MESSAGEBOX_WARNING = (SDL_MessageBoxFlags)0x00000020,
        SDL_MESSAGEBOX_INFORMATION = (SDL_MessageBoxFlags)0x00000040,
        SDL_MESSAGEBOX_BUTTONS_LEFT_TO_RIGHT = (SDL_MessageBoxFlags)0x00000080,
        SDL_MESSAGEBOX_BUTTONS_RIGHT_TO_LEFT = (SDL_MessageBoxFlags)0x00000100;

    [NativeTypeName("unsigned int")]
    public enum SDL_MessageBoxButtonFlags : uint
    {
    }

    public const SDL_MessageBoxButtonFlags SDL_MESSAGEBOX_BUTTON_RETURNKEY_DEFAULT = (SDL_MessageBoxButtonFlags)0x00000001,
        SDL_MESSAGEBOX_BUTTON_ESCAPEKEY_DEFAULT = (SDL_MessageBoxButtonFlags)0x00000002;

    [NativeTypeName("unsigned int")]
    public enum SDL_MessageBoxColorType : uint
    {
    }

    public static SDL_MessageBoxColorType SDL_MESSAGEBOX_COLOR_BACKGROUND,
        SDL_MESSAGEBOX_COLOR_TEXT,
        SDL_MESSAGEBOX_COLOR_BUTTON_BORDER,
        SDL_MESSAGEBOX_COLOR_BUTTON_BACKGROUND,
        SDL_MESSAGEBOX_COLOR_BUTTON_SELECTED,
        SDL_MESSAGEBOX_COLOR_MAX;

    [NativeTypeName("unsigned int")]
    public enum SDL_SystemCursor : uint
    {
    }

    public static SDL_SystemCursor SDL_SYSTEM_CURSOR_ARROW,
        SDL_SYSTEM_CURSOR_IBEAM,
        SDL_SYSTEM_CURSOR_WAIT,
        SDL_SYSTEM_CURSOR_CROSSHAIR,
        SDL_SYSTEM_CURSOR_WAITARROW,
        SDL_SYSTEM_CURSOR_SIZENWSE,
        SDL_SYSTEM_CURSOR_SIZENESW,
        SDL_SYSTEM_CURSOR_SIZEWE,
        SDL_SYSTEM_CURSOR_SIZENS,
        SDL_SYSTEM_CURSOR_SIZEALL,
        SDL_SYSTEM_CURSOR_NO,
        SDL_SYSTEM_CURSOR_HAND,
        SDL_NUM_SYSTEM_CURSORS;

    [NativeTypeName("unsigned int")]
    public enum SDL_MouseWheelDirection : uint
    {
    }

    public static SDL_MouseWheelDirection SDL_MOUSEWHEEL_NORMAL,
        SDL_MOUSEWHEEL_FLIPPED;

    [NativeTypeName("unsigned int")]
    public enum SDL_PixelType : uint
    {
    }

    public static SDL_PixelType SDL_PIXELTYPE_UNKNOWN,
        SDL_PIXELTYPE_INDEX1,
        SDL_PIXELTYPE_INDEX4,
        SDL_PIXELTYPE_INDEX8,
        SDL_PIXELTYPE_PACKED8,
        SDL_PIXELTYPE_PACKED16,
        SDL_PIXELTYPE_PACKED32,
        SDL_PIXELTYPE_ARRAYU8,
        SDL_PIXELTYPE_ARRAYU16,
        SDL_PIXELTYPE_ARRAYU32,
        SDL_PIXELTYPE_ARRAYF16,
        SDL_PIXELTYPE_ARRAYF32;

    [NativeTypeName("unsigned int")]
    public enum SDL_BitmapOrder : uint
    {
    }

    public static SDL_BitmapOrder SDL_BITMAPORDER_NONE,
        SDL_BITMAPORDER_4321,
        SDL_BITMAPORDER_1234;

    [NativeTypeName("unsigned int")]
    public enum SDL_PackedOrder : uint
    {
    }

    public static SDL_PackedOrder SDL_PACKEDORDER_NONE,
        SDL_PACKEDORDER_XRGB,
        SDL_PACKEDORDER_RGBX,
        SDL_PACKEDORDER_ARGB,
        SDL_PACKEDORDER_RGBA,
        SDL_PACKEDORDER_XBGR,
        SDL_PACKEDORDER_BGRX,
        SDL_PACKEDORDER_ABGR,
        SDL_PACKEDORDER_BGRA;

    [NativeTypeName("unsigned int")]
    public enum SDL_ArrayOrder : uint
    {
    }

    public static SDL_ArrayOrder SDL_ARRAYORDER_NONE,
        SDL_ARRAYORDER_RGB,
        SDL_ARRAYORDER_BGR;

    [NativeTypeName("unsigned int")]
    public enum SDL_PackedLayout : uint
    {
    }

    public static SDL_PackedLayout SDL_PACKEDLAYOUT_NONE,
        SDL_PACKEDLAYOUT_332,
        SDL_PACKEDLAYOUT_4444,
        SDL_PACKEDLAYOUT_1555,
        SDL_PACKEDLAYOUT_5551,
        SDL_PACKEDLAYOUT_565,
        SDL_PACKEDLAYOUT_8888,
        SDL_PACKEDLAYOUT_2101010,
        SDL_PACKEDLAYOUT_1010102;

    [NativeTypeName("unsigned int")]
    public enum SDL_PixelFormatEnum : uint
    {
    }

    public static SDL_PixelFormatEnum SDL_PIXELFORMAT_UNKNOWN,
        SDL_PIXELFORMAT_INDEX1LSB = ((SDL_PixelFormatEnum)((1 << 28) | ((int)(SDL_PIXELTYPE_INDEX1) << 24) | ((int)(SDL_BITMAPORDER_4321) << 20) | ((0) << 16) | ((1) << 8) | ((0) << 0))),
        SDL_PIXELFORMAT_INDEX1MSB = ((SDL_PixelFormatEnum)((1 << 28) | ((int)(SDL_PIXELTYPE_INDEX1) << 24) | ((int)(SDL_BITMAPORDER_1234) << 20) | ((0) << 16) | ((1) << 8) | ((0) << 0))),
        SDL_PIXELFORMAT_INDEX4LSB = ((SDL_PixelFormatEnum)((1 << 28) | ((int)(SDL_PIXELTYPE_INDEX4) << 24) | ((int)(SDL_BITMAPORDER_4321) << 20) | ((0) << 16) | ((4) << 8) | ((0) << 0))),
        SDL_PIXELFORMAT_INDEX4MSB = ((SDL_PixelFormatEnum)((1 << 28) | ((int)(SDL_PIXELTYPE_INDEX4) << 24) | ((int)(SDL_BITMAPORDER_1234) << 20) | ((0) << 16) | ((4) << 8) | ((0) << 0))),
        SDL_PIXELFORMAT_INDEX8 = ((SDL_PixelFormatEnum)((1 << 28) | ((int)(SDL_PIXELTYPE_INDEX8) << 24) | ((0) << 20) | ((0) << 16) | ((8) << 8) | ((1) << 0))),
        SDL_PIXELFORMAT_RGB332 = ((SDL_PixelFormatEnum)((1 << 28) | ((int)(SDL_PIXELTYPE_PACKED8) << 24) | ((int)(SDL_PACKEDORDER_XRGB) << 20) | ((int)(SDL_PACKEDLAYOUT_332) << 16) | ((8) << 8) | ((1) << 0))),
        SDL_PIXELFORMAT_XRGB4444 = ((SDL_PixelFormatEnum)((1 << 28) | ((int)(SDL_PIXELTYPE_PACKED16) << 24) | ((int)(SDL_PACKEDORDER_XRGB) << 20) | ((int)(SDL_PACKEDLAYOUT_4444) << 16) | ((12) << 8) | ((2) << 0))),
        SDL_PIXELFORMAT_RGB444 = SDL_PIXELFORMAT_XRGB4444,
        SDL_PIXELFORMAT_XBGR4444 = ((SDL_PixelFormatEnum)((1 << 28) | ((int)(SDL_PIXELTYPE_PACKED16) << 24) | ((int)(SDL_PACKEDORDER_XBGR) << 20) | ((int)(SDL_PACKEDLAYOUT_4444) << 16) | ((12) << 8) | ((2) << 0))),
        SDL_PIXELFORMAT_BGR444 = SDL_PIXELFORMAT_XBGR4444,
        SDL_PIXELFORMAT_XRGB1555 = ((SDL_PixelFormatEnum)((1 << 28) | ((int)(SDL_PIXELTYPE_PACKED16) << 24) | ((int)(SDL_PACKEDORDER_XRGB) << 20) | ((int)(SDL_PACKEDLAYOUT_1555) << 16) | ((15) << 8) | ((2) << 0))),
        SDL_PIXELFORMAT_RGB555 = SDL_PIXELFORMAT_XRGB1555,
        SDL_PIXELFORMAT_XBGR1555 = ((SDL_PixelFormatEnum)((1 << 28) | ((int)(SDL_PIXELTYPE_PACKED16) << 24) | ((int)(SDL_PACKEDORDER_XBGR) << 20) | ((int)(SDL_PACKEDLAYOUT_1555) << 16) | ((15) << 8) | ((2) << 0))),
        SDL_PIXELFORMAT_BGR555 = SDL_PIXELFORMAT_XBGR1555,
        SDL_PIXELFORMAT_ARGB4444 = ((SDL_PixelFormatEnum)((1 << 28) | ((int)(SDL_PIXELTYPE_PACKED16) << 24) | ((int)(SDL_PACKEDORDER_ARGB) << 20) | ((int)(SDL_PACKEDLAYOUT_4444) << 16) | ((16) << 8) | ((2) << 0))),
        SDL_PIXELFORMAT_RGBA4444 = ((SDL_PixelFormatEnum)((1 << 28) | ((int)(SDL_PIXELTYPE_PACKED16) << 24) | ((int)(SDL_PACKEDORDER_RGBA) << 20) | ((int)(SDL_PACKEDLAYOUT_4444) << 16) | ((16) << 8) | ((2) << 0))),
        SDL_PIXELFORMAT_ABGR4444 = ((SDL_PixelFormatEnum)((1 << 28) | ((int)(SDL_PIXELTYPE_PACKED16) << 24) | ((int)(SDL_PACKEDORDER_ABGR) << 20) | ((int)(SDL_PACKEDLAYOUT_4444) << 16) | ((16) << 8) | ((2) << 0))),
        SDL_PIXELFORMAT_BGRA4444 = ((SDL_PixelFormatEnum)((1 << 28) | ((int)(SDL_PIXELTYPE_PACKED16) << 24) | ((int)(SDL_PACKEDORDER_BGRA) << 20) | ((int)(SDL_PACKEDLAYOUT_4444) << 16) | ((16) << 8) | ((2) << 0))),
        SDL_PIXELFORMAT_ARGB1555 = ((SDL_PixelFormatEnum)((1 << 28) | ((int)(SDL_PIXELTYPE_PACKED16) << 24) | ((int)(SDL_PACKEDORDER_ARGB) << 20) | ((int)(SDL_PACKEDLAYOUT_1555) << 16) | ((16) << 8) | ((2) << 0))),
        SDL_PIXELFORMAT_RGBA5551 = ((SDL_PixelFormatEnum)((1 << 28) | ((int)(SDL_PIXELTYPE_PACKED16) << 24) | ((int)(SDL_PACKEDORDER_RGBA) << 20) | ((int)(SDL_PACKEDLAYOUT_5551) << 16) | ((16) << 8) | ((2) << 0))),
        SDL_PIXELFORMAT_ABGR1555 = ((SDL_PixelFormatEnum)((1 << 28) | ((int)(SDL_PIXELTYPE_PACKED16) << 24) | ((int)(SDL_PACKEDORDER_ABGR) << 20) | ((int)(SDL_PACKEDLAYOUT_1555) << 16) | ((16) << 8) | ((2) << 0))),
        SDL_PIXELFORMAT_BGRA5551 = ((SDL_PixelFormatEnum)((1 << 28) | ((int)(SDL_PIXELTYPE_PACKED16) << 24) | ((int)(SDL_PACKEDORDER_BGRA) << 20) | ((int)(SDL_PACKEDLAYOUT_5551) << 16) | ((16) << 8) | ((2) << 0))),
        SDL_PIXELFORMAT_RGB565 = ((SDL_PixelFormatEnum)((1 << 28) | ((int)(SDL_PIXELTYPE_PACKED16) << 24) | ((int)(SDL_PACKEDORDER_XRGB) << 20) | ((int)(SDL_PACKEDLAYOUT_565) << 16) | ((16) << 8) | ((2) << 0))),
        SDL_PIXELFORMAT_BGR565 = ((SDL_PixelFormatEnum)((1 << 28) | ((int)(SDL_PIXELTYPE_PACKED16) << 24) | ((int)(SDL_PACKEDORDER_XBGR) << 20) | ((int)(SDL_PACKEDLAYOUT_565) << 16) | ((16) << 8) | ((2) << 0))),
        SDL_PIXELFORMAT_RGB24 = ((SDL_PixelFormatEnum)((1 << 28) | ((int)(SDL_PIXELTYPE_ARRAYU8) << 24) | ((int)(SDL_ARRAYORDER_RGB) << 20) | ((0) << 16) | ((24) << 8) | ((3) << 0))),
        SDL_PIXELFORMAT_BGR24 = ((SDL_PixelFormatEnum)((1 << 28) | ((int)(SDL_PIXELTYPE_ARRAYU8) << 24) | ((int)(SDL_ARRAYORDER_BGR) << 20) | ((0) << 16) | ((24) << 8) | ((3) << 0))),
        SDL_PIXELFORMAT_XRGB8888 = ((SDL_PixelFormatEnum)((1 << 28) | ((int)(SDL_PIXELTYPE_PACKED32) << 24) | ((int)(SDL_PACKEDORDER_XRGB) << 20) | ((int)(SDL_PACKEDLAYOUT_8888) << 16) | ((24) << 8) | ((4) << 0))),
        SDL_PIXELFORMAT_RGB888 = SDL_PIXELFORMAT_XRGB8888,
        SDL_PIXELFORMAT_RGBX8888 = ((SDL_PixelFormatEnum)((1 << 28) | ((int)(SDL_PIXELTYPE_PACKED32) << 24) | ((int)(SDL_PACKEDORDER_RGBX) << 20) | ((int)(SDL_PACKEDLAYOUT_8888) << 16) | ((24) << 8) | ((4) << 0))),
        SDL_PIXELFORMAT_XBGR8888 = ((SDL_PixelFormatEnum)((1 << 28) | ((int)(SDL_PIXELTYPE_PACKED32) << 24) | ((int)(SDL_PACKEDORDER_XBGR) << 20) | ((int)(SDL_PACKEDLAYOUT_8888) << 16) | ((24) << 8) | ((4) << 0))),
        SDL_PIXELFORMAT_BGR888 = SDL_PIXELFORMAT_XBGR8888,
        SDL_PIXELFORMAT_BGRX8888 = ((SDL_PixelFormatEnum)((1 << 28) | ((int)(SDL_PIXELTYPE_PACKED32) << 24) | ((int)(SDL_PACKEDORDER_BGRX) << 20) | ((int)(SDL_PACKEDLAYOUT_8888) << 16) | ((24) << 8) | ((4) << 0))),
        SDL_PIXELFORMAT_ARGB8888 = ((SDL_PixelFormatEnum)((1 << 28) | ((int)(SDL_PIXELTYPE_PACKED32) << 24) | ((int)(SDL_PACKEDORDER_ARGB) << 20) | ((int)(SDL_PACKEDLAYOUT_8888) << 16) | ((32) << 8) | ((4) << 0))),
        SDL_PIXELFORMAT_RGBA8888 = ((SDL_PixelFormatEnum)((1 << 28) | ((int)(SDL_PIXELTYPE_PACKED32) << 24) | ((int)(SDL_PACKEDORDER_RGBA) << 20) | ((int)(SDL_PACKEDLAYOUT_8888) << 16) | ((32) << 8) | ((4) << 0))),
        SDL_PIXELFORMAT_ABGR8888 = ((SDL_PixelFormatEnum)((1 << 28) | ((int)(SDL_PIXELTYPE_PACKED32) << 24) | ((int)(SDL_PACKEDORDER_ABGR) << 20) | ((int)(SDL_PACKEDLAYOUT_8888) << 16) | ((32) << 8) | ((4) << 0))),
        SDL_PIXELFORMAT_BGRA8888 = ((SDL_PixelFormatEnum)((1 << 28) | ((int)(SDL_PIXELTYPE_PACKED32) << 24) | ((int)(SDL_PACKEDORDER_BGRA) << 20) | ((int)(SDL_PACKEDLAYOUT_8888) << 16) | ((32) << 8) | ((4) << 0))),
        SDL_PIXELFORMAT_ARGB2101010 = ((SDL_PixelFormatEnum)((1 << 28) | ((int)(SDL_PIXELTYPE_PACKED32) << 24) | ((int)(SDL_PACKEDORDER_ARGB) << 20) | ((int)(SDL_PACKEDLAYOUT_2101010) << 16) | ((32) << 8) | ((4) << 0))),
        SDL_PIXELFORMAT_RGBA32 = SDL_PIXELFORMAT_ABGR8888,
        SDL_PIXELFORMAT_ARGB32 = SDL_PIXELFORMAT_BGRA8888,
        SDL_PIXELFORMAT_BGRA32 = SDL_PIXELFORMAT_ARGB8888,
        SDL_PIXELFORMAT_ABGR32 = SDL_PIXELFORMAT_RGBA8888,
        SDL_PIXELFORMAT_YV12 = ((SDL_PixelFormatEnum)(((uint)((byte)('Y')) << 0) | ((uint)((byte)('V')) << 8) | ((uint)((byte)('1')) << 16) | ((uint)((byte)('2')) << 24))),
        SDL_PIXELFORMAT_IYUV = ((SDL_PixelFormatEnum)(((uint)((byte)('I')) << 0) | ((uint)((byte)('Y')) << 8) | ((uint)((byte)('U')) << 16) | ((uint)((byte)('V')) << 24))),
        SDL_PIXELFORMAT_YUY2 = ((SDL_PixelFormatEnum)(((uint)((byte)('Y')) << 0) | ((uint)((byte)('U')) << 8) | ((uint)((byte)('Y')) << 16) | ((uint)((byte)('2')) << 24))),
        SDL_PIXELFORMAT_UYVY = ((SDL_PixelFormatEnum)(((uint)((byte)('U')) << 0) | ((uint)((byte)('Y')) << 8) | ((uint)((byte)('V')) << 16) | ((uint)((byte)('Y')) << 24))),
        SDL_PIXELFORMAT_YVYU = ((SDL_PixelFormatEnum)(((uint)((byte)('Y')) << 0) | ((uint)((byte)('V')) << 8) | ((uint)((byte)('Y')) << 16) | ((uint)((byte)('U')) << 24))),
        SDL_PIXELFORMAT_NV12 = ((SDL_PixelFormatEnum)(((uint)((byte)('N')) << 0) | ((uint)((byte)('V')) << 8) | ((uint)((byte)('1')) << 16) | ((uint)((byte)('2')) << 24))),
        SDL_PIXELFORMAT_NV21 = ((SDL_PixelFormatEnum)(((uint)((byte)('N')) << 0) | ((uint)((byte)('V')) << 8) | ((uint)((byte)('2')) << 16) | ((uint)((byte)('1')) << 24))),
        SDL_PIXELFORMAT_EXTERNAL_OES = ((SDL_PixelFormatEnum)(((uint)((byte)('O')) << 0) | ((uint)((byte)('E')) << 8) | ((uint)((byte)('S')) << 16) | ((uint)((byte)(' ')) << 24)));

    [NativeTypeName("unsigned int")]
    public enum SDL_PowerState : uint
    {
    }

    public static SDL_PowerState SDL_POWERSTATE_UNKNOWN,
        SDL_POWERSTATE_ON_BATTERY,
        SDL_POWERSTATE_NO_BATTERY,
        SDL_POWERSTATE_CHARGING,
        SDL_POWERSTATE_CHARGED;
    
    [NativeTypeName("unsigned int")]
    public enum SDL_RendererFlags : uint
    {
    }

    public const SDL_RendererFlags SDL_RENDERER_SOFTWARE = (SDL_RendererFlags)0x00000001,
        SDL_RENDERER_ACCELERATED = (SDL_RendererFlags)0x00000002,
        SDL_RENDERER_PRESENTVSYNC = (SDL_RendererFlags)0x00000004;

    [NativeTypeName("unsigned int")]
    public enum SDL_ScaleMode : uint
    {
    }

    public static SDL_ScaleMode SDL_SCALEMODE_NEAREST,
        SDL_SCALEMODE_LINEAR,
        SDL_SCALEMODE_BEST;
        
    [NativeTypeName("unsigned int")]
    public enum SDL_TextureAccess : uint
    {
    }

    public static SDL_TextureAccess SDL_TEXTUREACCESS_STATIC,
        SDL_TEXTUREACCESS_STREAMING,
        SDL_TEXTUREACCESS_TARGET;

    [NativeTypeName("unsigned int")]
    public enum SDL_TextureModulate : uint
    {
    }

    public const SDL_TextureModulate SDL_TEXTUREMODULATE_NONE = 0x00000000,
        SDL_TEXTUREMODULATE_COLOR = (SDL_TextureModulate)0x00000001,
        SDL_TEXTUREMODULATE_ALPHA = (SDL_TextureModulate)0x00000002;

    [NativeTypeName("unsigned int")]
    public enum SDL_RendererFlip : uint
    {
    }

    public const SDL_RendererFlip SDL_FLIP_NONE = 0x00000000,
        SDL_FLIP_HORIZONTAL = (SDL_RendererFlip)0x00000001,
        SDL_FLIP_VERTICAL = (SDL_RendererFlip)0x00000002;

    [NativeTypeName("unsigned int")]
    public enum SDL_RendererLogicalPresentation : uint
    {
    }

    public static SDL_RendererLogicalPresentation SDL_LOGICAL_PRESENTATION_DISABLED,
        SDL_LOGICAL_PRESENTATION_MATCH,
        SDL_LOGICAL_PRESENTATION_STRETCH,
        SDL_LOGICAL_PRESENTATION_LETTERBOX,
        SDL_LOGICAL_PRESENTATION_OVERSCAN,
        SDL_LOGICAL_PRESENTATION_INTEGER_SCALE;
    
    public enum SDL_SensorType
    {
    }

    public static SDL_SensorType SDL_SENSOR_INVALID = (SDL_SensorType)(int)-1,
        SDL_SENSOR_UNKNOWN,
        SDL_SENSOR_ACCEL,
        SDL_SENSOR_GYRO,
        SDL_SENSOR_ACCEL_L,
        SDL_SENSOR_GYRO_L,
        SDL_SENSOR_ACCEL_R,
        SDL_SENSOR_GYRO_R;

    [NativeTypeName("unsigned int")]
    public enum WindowShapeMode : uint
    {
    }

    public static WindowShapeMode ShapeModeDefault,
        ShapeModeBinarizeAlpha,
        ShapeModeReverseBinarizeAlpha,
        ShapeModeColorKey;

    [NativeTypeName("unsigned int")]
    public enum SDL_YUV_CONVERSION_MODE : uint
    {
    }

    public static SDL_YUV_CONVERSION_MODE SDL_YUV_CONVERSION_JPEG,
        SDL_YUV_CONVERSION_BT601,
        SDL_YUV_CONVERSION_BT709,
        SDL_YUV_CONVERSION_AUTOMATIC;    
    
    public enum SDL_bool : int {}
    public const SDL_bool SDL_FALSE = (SDL_bool)0,
                          SDL_TRUE = (SDL_bool)1;


    public enum SDL_TouchID : Int64 {}
    public enum SDL_FingerID : Int64 {}

    public enum SDL_DisplayID : UInt32 {}
    public enum SDL_WindowID : UInt32 {}

    public const UInt32 SDL_INIT_TIMER        = 0x00000001,
                        SDL_INIT_AUDIO        = 0x00000010,
                        SDL_INIT_VIDEO        = 0x00000020,
                        SDL_INIT_JOYSTICK     = 0x00000200, 
                        SDL_INIT_HAPTIC       = 0x00001000,
                        SDL_INIT_GAMEPAD      = 0x00002000, 
                        SDL_INIT_EVENTS       = 0x00004000,
                        SDL_INIT_SENSOR       = 0x00008000;

    public enum SDL_TouchDeviceType
    {
    }

    public static SDL_TouchDeviceType SDL_TOUCH_DEVICE_INVALID = (SDL_TouchDeviceType)(int)-1,
        SDL_TOUCH_DEVICE_DIRECT,
        SDL_TOUCH_DEVICE_INDIRECT_ABSOLUTE,
        SDL_TOUCH_DEVICE_INDIRECT_RELATIVE;

    public const UInt32 SDL_TOUCH_MOUSEID = 0;
    public const Int64 SDL_MOUSE_TOUCHID = -1;




    public const byte SDL_MAJOR_VERSION = 3,
                      SDL_MINOR_VERSION = 0,
                      SDL_PATCHLEVEL    = 0;

    [Flags]
    public enum SDL_HitTestResult
    {
    }

    public static SDL_HitTestResult SDL_HITTEST_NORMAL,
        SDL_HITTEST_DRAGGABLE,
        SDL_HITTEST_RESIZE_TOPLEFT,
        SDL_HITTEST_RESIZE_TOP,
        SDL_HITTEST_RESIZE_TOPRIGHT,
        SDL_HITTEST_RESIZE_RIGHT,
        SDL_HITTEST_RESIZE_BOTTOMRIGHT,
        SDL_HITTEST_RESIZE_BOTTOM,
        SDL_HITTEST_RESIZE_BOTTOMLEFT,
        SDL_HITTEST_RESIZE_LEFT;

    public enum SDL_WindowFlags
    {
    }

    public const SDL_WindowFlags SDL_WINDOW_FULLSCREEN           = (SDL_WindowFlags)0x00000001,   /**< window is in fullscreen mode */
        SDL_WINDOW_OPENGL               = (SDL_WindowFlags)0x00000002,   /**< window usable with OpenGL context */
        SDL_WINDOW_HIDDEN               = (SDL_WindowFlags)0x00000008,   /**< window is not visible */
        SDL_WINDOW_BORDERLESS           = (SDL_WindowFlags)0x00000010,   /**< no window decoration */
        SDL_WINDOW_RESIZABLE            = (SDL_WindowFlags)0x00000020,   /**< window can be resized */
        SDL_WINDOW_MINIMIZED            = (SDL_WindowFlags)0x00000040,   /**< window is minimized */
        SDL_WINDOW_MAXIMIZED            = (SDL_WindowFlags)0x00000080,   /**< window is maximized */
        SDL_WINDOW_MOUSE_GRABBED        = (SDL_WindowFlags)0x00000100,   /**< window has grabbed mouse input */
        SDL_WINDOW_INPUT_FOCUS          = (SDL_WindowFlags)0x00000200,   /**< window has input focus */
        SDL_WINDOW_MOUSE_FOCUS          = (SDL_WindowFlags)0x00000400,   /**< window has mouse focus */
        SDL_WINDOW_FOREIGN              = (SDL_WindowFlags)0x00000800,   /**< window not created by SDL */
        SDL_WINDOW_MOUSE_CAPTURE        = (SDL_WindowFlags)0x00004000,   /**< window has mouse captured (unrelated to MOUSE_GRABBED) */
        SDL_WINDOW_ALWAYS_ON_TOP        = (SDL_WindowFlags)0x00008000,   /**< window should always be above others */
        SDL_WINDOW_SKIP_TASKBAR         = (SDL_WindowFlags)0x00010000,   /**< window should not be added to the taskbar */
        SDL_WINDOW_UTILITY              = (SDL_WindowFlags)0x00020000,   /**< window should be treated as a utility window */
        SDL_WINDOW_TOOLTIP              = (SDL_WindowFlags)0x00040000,   /**< window should be treated as a tooltip */
        SDL_WINDOW_POPUP_MENU           = (SDL_WindowFlags)0x00080000,   /**< window should be treated as a popup menu */
        SDL_WINDOW_KEYBOARD_GRABBED     = (SDL_WindowFlags)0x00100000,   /**< window has grabbed keyboard input */
        SDL_WINDOW_VULKAN               = (SDL_WindowFlags)0x10000000,   /**< window usable for Vulkan surface */
        SDL_WINDOW_METAL                = (SDL_WindowFlags)0x20000000;    /**< window usable for Metal view */

    public enum SDL_DisplayOrientation
    {
    }

    public static SDL_DisplayOrientation SDL_ORIENTATION_UNKNOWN,
        SDL_ORIENTATION_LANDSCAPE,     
        SDL_ORIENTATION_LANDSCAPE_FLIPPED,  
        SDL_ORIENTATION_PORTRAIT,  
        SDL_ORIENTATION_PORTRAIT_FLIPPED;

    public enum SDL_FlashOperation
    {
    }

    public static SDL_FlashOperation SDL_FLASH_CANCEL,
        SDL_FLASH_BRIEFLY, 
        SDL_FLASH_UNTIL_FOCUSED;

}