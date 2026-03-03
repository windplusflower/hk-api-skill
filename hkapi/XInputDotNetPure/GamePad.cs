using System;
using System.Runtime.InteropServices;

namespace XInputDotNetPure
{
	// Token: 0x020006BB RID: 1723
	public class GamePad
	{
		// Token: 0x060028C2 RID: 10434 RVA: 0x000E4D88 File Offset: 0x000E2F88
		public static GamePadState GetState(PlayerIndex playerIndex)
		{
			IntPtr intPtr = Marshal.AllocHGlobal(Marshal.SizeOf(typeof(GamePadState.RawState)));
			int num = (int)Imports.XInputGamePadGetState((uint)playerIndex, intPtr);
			GamePadState.RawState rawState = (GamePadState.RawState)Marshal.PtrToStructure(intPtr, typeof(GamePadState.RawState));
			return new GamePadState(num == 0, rawState);
		}

		// Token: 0x060028C3 RID: 10435 RVA: 0x000E4DD0 File Offset: 0x000E2FD0
		public static void SetVibration(PlayerIndex playerIndex, float leftMotor, float rightMotor)
		{
			Imports.XInputGamePadSetState((uint)playerIndex, leftMotor, rightMotor);
		}
	}
}
