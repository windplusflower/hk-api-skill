using System;
using System.Runtime.InteropServices;

namespace InControl
{
	// Token: 0x020006FB RID: 1787
	internal static class Native
	{
		// Token: 0x06002C19 RID: 11289
		[DllImport("InControlNative", CallingConvention = CallingConvention.Cdecl, EntryPoint = "InControl_Init")]
		public static extern void Init(NativeInputOptions options);

		// Token: 0x06002C1A RID: 11290
		[DllImport("InControlNative", CallingConvention = CallingConvention.Cdecl, EntryPoint = "InControl_Stop")]
		public static extern void Stop();

		// Token: 0x06002C1B RID: 11291
		[DllImport("InControlNative", CallingConvention = CallingConvention.Cdecl, EntryPoint = "InControl_GetVersionInfo")]
		public static extern void GetVersionInfo(out NativeVersionInfo versionInfo);

		// Token: 0x06002C1C RID: 11292
		[DllImport("InControlNative", CallingConvention = CallingConvention.Cdecl, EntryPoint = "InControl_GetDeviceInfo")]
		public static extern bool GetDeviceInfo(uint handle, out InputDeviceInfo deviceInfo);

		// Token: 0x06002C1D RID: 11293
		[DllImport("InControlNative", CallingConvention = CallingConvention.Cdecl, EntryPoint = "InControl_GetDeviceState")]
		public static extern bool GetDeviceState(uint handle, out IntPtr deviceState);

		// Token: 0x06002C1E RID: 11294
		[DllImport("InControlNative", CallingConvention = CallingConvention.Cdecl, EntryPoint = "InControl_GetDeviceEvents")]
		public static extern int GetDeviceEvents(out IntPtr deviceEvents);

		// Token: 0x06002C1F RID: 11295
		[DllImport("InControlNative", CallingConvention = CallingConvention.Cdecl, EntryPoint = "InControl_SetHapticState")]
		public static extern void SetHapticState(uint handle, byte motor0, byte motor1);

		// Token: 0x06002C20 RID: 11296
		[DllImport("InControlNative", CallingConvention = CallingConvention.Cdecl, EntryPoint = "InControl_SetLightColor")]
		public static extern void SetLightColor(uint handle, byte red, byte green, byte blue);

		// Token: 0x06002C21 RID: 11297
		[DllImport("InControlNative", CallingConvention = CallingConvention.Cdecl, EntryPoint = "InControl_SetLightFlash")]
		public static extern void SetLightFlash(uint handle, byte flashOnDuration, byte flashOffDuration);

		// Token: 0x06002C22 RID: 11298
		[DllImport("InControlNative", CallingConvention = CallingConvention.Cdecl, EntryPoint = "InControl_GetAnalogGlyphName")]
		public static extern uint GetAnalogGlyphName(uint handle, uint index, out IntPtr glyphName);

		// Token: 0x06002C23 RID: 11299
		[DllImport("InControlNative", CallingConvention = CallingConvention.Cdecl, EntryPoint = "InControl_GetButtonGlyphName")]
		public static extern uint GetButtonGlyphName(uint handle, uint index, out IntPtr glyphName);

		// Token: 0x0400319E RID: 12702
		private const string libraryName = "InControlNative";

		// Token: 0x0400319F RID: 12703
		private const CallingConvention callingConvention = CallingConvention.Cdecl;
	}
}
