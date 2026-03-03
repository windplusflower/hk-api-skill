using System;

namespace XInputDotNetPure
{
	// Token: 0x020006B2 RID: 1714
	public struct GamePadDPad
	{
		// Token: 0x060028AC RID: 10412 RVA: 0x000E4A52 File Offset: 0x000E2C52
		internal GamePadDPad(ButtonState up, ButtonState down, ButtonState left, ButtonState right)
		{
			this.up = up;
			this.down = down;
			this.left = left;
			this.right = right;
		}

		// Token: 0x1700058B RID: 1419
		// (get) Token: 0x060028AD RID: 10413 RVA: 0x000E4A71 File Offset: 0x000E2C71
		public ButtonState Up
		{
			get
			{
				return this.up;
			}
		}

		// Token: 0x1700058C RID: 1420
		// (get) Token: 0x060028AE RID: 10414 RVA: 0x000E4A79 File Offset: 0x000E2C79
		public ButtonState Down
		{
			get
			{
				return this.down;
			}
		}

		// Token: 0x1700058D RID: 1421
		// (get) Token: 0x060028AF RID: 10415 RVA: 0x000E4A81 File Offset: 0x000E2C81
		public ButtonState Left
		{
			get
			{
				return this.left;
			}
		}

		// Token: 0x1700058E RID: 1422
		// (get) Token: 0x060028B0 RID: 10416 RVA: 0x000E4A89 File Offset: 0x000E2C89
		public ButtonState Right
		{
			get
			{
				return this.right;
			}
		}

		// Token: 0x04002E8A RID: 11914
		private ButtonState up;

		// Token: 0x04002E8B RID: 11915
		private ButtonState down;

		// Token: 0x04002E8C RID: 11916
		private ButtonState left;

		// Token: 0x04002E8D RID: 11917
		private ButtonState right;
	}
}
