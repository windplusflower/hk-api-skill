using System;

namespace XInputDotNetPure
{
	// Token: 0x020006B1 RID: 1713
	public struct GamePadButtons
	{
		// Token: 0x060028A1 RID: 10401 RVA: 0x000E49A8 File Offset: 0x000E2BA8
		internal GamePadButtons(ButtonState start, ButtonState back, ButtonState leftStick, ButtonState rightStick, ButtonState leftShoulder, ButtonState rightShoulder, ButtonState a, ButtonState b, ButtonState x, ButtonState y)
		{
			this.start = start;
			this.back = back;
			this.leftStick = leftStick;
			this.rightStick = rightStick;
			this.leftShoulder = leftShoulder;
			this.rightShoulder = rightShoulder;
			this.a = a;
			this.b = b;
			this.x = x;
			this.y = y;
		}

		// Token: 0x17000581 RID: 1409
		// (get) Token: 0x060028A2 RID: 10402 RVA: 0x000E4A02 File Offset: 0x000E2C02
		public ButtonState Start
		{
			get
			{
				return this.start;
			}
		}

		// Token: 0x17000582 RID: 1410
		// (get) Token: 0x060028A3 RID: 10403 RVA: 0x000E4A0A File Offset: 0x000E2C0A
		public ButtonState Back
		{
			get
			{
				return this.back;
			}
		}

		// Token: 0x17000583 RID: 1411
		// (get) Token: 0x060028A4 RID: 10404 RVA: 0x000E4A12 File Offset: 0x000E2C12
		public ButtonState LeftStick
		{
			get
			{
				return this.leftStick;
			}
		}

		// Token: 0x17000584 RID: 1412
		// (get) Token: 0x060028A5 RID: 10405 RVA: 0x000E4A1A File Offset: 0x000E2C1A
		public ButtonState RightStick
		{
			get
			{
				return this.rightStick;
			}
		}

		// Token: 0x17000585 RID: 1413
		// (get) Token: 0x060028A6 RID: 10406 RVA: 0x000E4A22 File Offset: 0x000E2C22
		public ButtonState LeftShoulder
		{
			get
			{
				return this.leftShoulder;
			}
		}

		// Token: 0x17000586 RID: 1414
		// (get) Token: 0x060028A7 RID: 10407 RVA: 0x000E4A2A File Offset: 0x000E2C2A
		public ButtonState RightShoulder
		{
			get
			{
				return this.rightShoulder;
			}
		}

		// Token: 0x17000587 RID: 1415
		// (get) Token: 0x060028A8 RID: 10408 RVA: 0x000E4A32 File Offset: 0x000E2C32
		public ButtonState A
		{
			get
			{
				return this.a;
			}
		}

		// Token: 0x17000588 RID: 1416
		// (get) Token: 0x060028A9 RID: 10409 RVA: 0x000E4A3A File Offset: 0x000E2C3A
		public ButtonState B
		{
			get
			{
				return this.b;
			}
		}

		// Token: 0x17000589 RID: 1417
		// (get) Token: 0x060028AA RID: 10410 RVA: 0x000E4A42 File Offset: 0x000E2C42
		public ButtonState X
		{
			get
			{
				return this.x;
			}
		}

		// Token: 0x1700058A RID: 1418
		// (get) Token: 0x060028AB RID: 10411 RVA: 0x000E4A4A File Offset: 0x000E2C4A
		public ButtonState Y
		{
			get
			{
				return this.y;
			}
		}

		// Token: 0x04002E80 RID: 11904
		private ButtonState start;

		// Token: 0x04002E81 RID: 11905
		private ButtonState back;

		// Token: 0x04002E82 RID: 11906
		private ButtonState leftStick;

		// Token: 0x04002E83 RID: 11907
		private ButtonState rightStick;

		// Token: 0x04002E84 RID: 11908
		private ButtonState leftShoulder;

		// Token: 0x04002E85 RID: 11909
		private ButtonState rightShoulder;

		// Token: 0x04002E86 RID: 11910
		private ButtonState a;

		// Token: 0x04002E87 RID: 11911
		private ButtonState b;

		// Token: 0x04002E88 RID: 11912
		private ButtonState x;

		// Token: 0x04002E89 RID: 11913
		private ButtonState y;
	}
}
