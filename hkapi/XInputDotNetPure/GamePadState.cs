using System;

namespace XInputDotNetPure
{
	// Token: 0x020006B6 RID: 1718
	public struct GamePadState
	{
		// Token: 0x060028BB RID: 10427 RVA: 0x000E4B04 File Offset: 0x000E2D04
		internal GamePadState(bool isConnected, GamePadState.RawState rawState)
		{
			this.isConnected = isConnected;
			if (!isConnected)
			{
				rawState.dwPacketNumber = 0U;
				rawState.Gamepad.dwButtons = 0;
				rawState.Gamepad.bLeftTrigger = 0;
				rawState.Gamepad.bRightTrigger = 0;
				rawState.Gamepad.sThumbLX = 0;
				rawState.Gamepad.sThumbLY = 0;
				rawState.Gamepad.sThumbRX = 0;
				rawState.Gamepad.sThumbRY = 0;
			}
			this.packetNumber = rawState.dwPacketNumber;
			this.buttons = new GamePadButtons(((rawState.Gamepad.dwButtons & 16) != 0) ? ButtonState.Pressed : ButtonState.Released, ((rawState.Gamepad.dwButtons & 32) != 0) ? ButtonState.Pressed : ButtonState.Released, ((rawState.Gamepad.dwButtons & 64) != 0) ? ButtonState.Pressed : ButtonState.Released, ((rawState.Gamepad.dwButtons & 128) != 0) ? ButtonState.Pressed : ButtonState.Released, ((rawState.Gamepad.dwButtons & 256) != 0) ? ButtonState.Pressed : ButtonState.Released, ((rawState.Gamepad.dwButtons & 512) != 0) ? ButtonState.Pressed : ButtonState.Released, ((rawState.Gamepad.dwButtons & 4096) != 0) ? ButtonState.Pressed : ButtonState.Released, ((rawState.Gamepad.dwButtons & 8192) != 0) ? ButtonState.Pressed : ButtonState.Released, ((rawState.Gamepad.dwButtons & 16384) != 0) ? ButtonState.Pressed : ButtonState.Released, ((rawState.Gamepad.dwButtons & 32768) != 0) ? ButtonState.Pressed : ButtonState.Released);
			this.dPad = new GamePadDPad(((rawState.Gamepad.dwButtons & 1) != 0) ? ButtonState.Pressed : ButtonState.Released, ((rawState.Gamepad.dwButtons & 2) != 0) ? ButtonState.Pressed : ButtonState.Released, ((rawState.Gamepad.dwButtons & 4) != 0) ? ButtonState.Pressed : ButtonState.Released, ((rawState.Gamepad.dwButtons & 8) != 0) ? ButtonState.Pressed : ButtonState.Released);
			this.thumbSticks = new GamePadThumbSticks(new GamePadThumbSticks.StickValue((float)rawState.Gamepad.sThumbLX / 32767f, (float)rawState.Gamepad.sThumbLY / 32767f), new GamePadThumbSticks.StickValue((float)rawState.Gamepad.sThumbRX / 32767f, (float)rawState.Gamepad.sThumbRY / 32767f));
			this.triggers = new GamePadTriggers((float)rawState.Gamepad.bLeftTrigger / 255f, (float)rawState.Gamepad.bRightTrigger / 255f);
		}

		// Token: 0x17000596 RID: 1430
		// (get) Token: 0x060028BC RID: 10428 RVA: 0x000E4D55 File Offset: 0x000E2F55
		public uint PacketNumber
		{
			get
			{
				return this.packetNumber;
			}
		}

		// Token: 0x17000597 RID: 1431
		// (get) Token: 0x060028BD RID: 10429 RVA: 0x000E4D5D File Offset: 0x000E2F5D
		public bool IsConnected
		{
			get
			{
				return this.isConnected;
			}
		}

		// Token: 0x17000598 RID: 1432
		// (get) Token: 0x060028BE RID: 10430 RVA: 0x000E4D65 File Offset: 0x000E2F65
		public GamePadButtons Buttons
		{
			get
			{
				return this.buttons;
			}
		}

		// Token: 0x17000599 RID: 1433
		// (get) Token: 0x060028BF RID: 10431 RVA: 0x000E4D6D File Offset: 0x000E2F6D
		public GamePadDPad DPad
		{
			get
			{
				return this.dPad;
			}
		}

		// Token: 0x1700059A RID: 1434
		// (get) Token: 0x060028C0 RID: 10432 RVA: 0x000E4D75 File Offset: 0x000E2F75
		public GamePadTriggers Triggers
		{
			get
			{
				return this.triggers;
			}
		}

		// Token: 0x1700059B RID: 1435
		// (get) Token: 0x060028C1 RID: 10433 RVA: 0x000E4D7D File Offset: 0x000E2F7D
		public GamePadThumbSticks ThumbSticks
		{
			get
			{
				return this.thumbSticks;
			}
		}

		// Token: 0x04002E93 RID: 11923
		private bool isConnected;

		// Token: 0x04002E94 RID: 11924
		private uint packetNumber;

		// Token: 0x04002E95 RID: 11925
		private GamePadButtons buttons;

		// Token: 0x04002E96 RID: 11926
		private GamePadDPad dPad;

		// Token: 0x04002E97 RID: 11927
		private GamePadThumbSticks thumbSticks;

		// Token: 0x04002E98 RID: 11928
		private GamePadTriggers triggers;

		// Token: 0x020006B7 RID: 1719
		internal struct RawState
		{
			// Token: 0x04002E99 RID: 11929
			public uint dwPacketNumber;

			// Token: 0x04002E9A RID: 11930
			public GamePadState.RawState.GamePad Gamepad;

			// Token: 0x020006B8 RID: 1720
			public struct GamePad
			{
				// Token: 0x04002E9B RID: 11931
				public ushort dwButtons;

				// Token: 0x04002E9C RID: 11932
				public byte bLeftTrigger;

				// Token: 0x04002E9D RID: 11933
				public byte bRightTrigger;

				// Token: 0x04002E9E RID: 11934
				public short sThumbLX;

				// Token: 0x04002E9F RID: 11935
				public short sThumbLY;

				// Token: 0x04002EA0 RID: 11936
				public short sThumbRX;

				// Token: 0x04002EA1 RID: 11937
				public short sThumbRY;
			}
		}

		// Token: 0x020006B9 RID: 1721
		private enum ButtonsConstants
		{
			// Token: 0x04002EA3 RID: 11939
			DPadUp = 1,
			// Token: 0x04002EA4 RID: 11940
			DPadDown,
			// Token: 0x04002EA5 RID: 11941
			DPadLeft = 4,
			// Token: 0x04002EA6 RID: 11942
			DPadRight = 8,
			// Token: 0x04002EA7 RID: 11943
			Start = 16,
			// Token: 0x04002EA8 RID: 11944
			Back = 32,
			// Token: 0x04002EA9 RID: 11945
			LeftThumb = 64,
			// Token: 0x04002EAA RID: 11946
			RightThumb = 128,
			// Token: 0x04002EAB RID: 11947
			LeftShoulder = 256,
			// Token: 0x04002EAC RID: 11948
			RightShoulder = 512,
			// Token: 0x04002EAD RID: 11949
			A = 4096,
			// Token: 0x04002EAE RID: 11950
			B = 8192,
			// Token: 0x04002EAF RID: 11951
			X = 16384,
			// Token: 0x04002EB0 RID: 11952
			Y = 32768
		}
	}
}
