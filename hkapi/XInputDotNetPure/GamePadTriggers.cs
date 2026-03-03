using System;

namespace XInputDotNetPure
{
	// Token: 0x020006B5 RID: 1717
	public struct GamePadTriggers
	{
		// Token: 0x060028B8 RID: 10424 RVA: 0x000E4AE2 File Offset: 0x000E2CE2
		internal GamePadTriggers(float left, float right)
		{
			this.left = left;
			this.right = right;
		}

		// Token: 0x17000594 RID: 1428
		// (get) Token: 0x060028B9 RID: 10425 RVA: 0x000E4AF2 File Offset: 0x000E2CF2
		public float Left
		{
			get
			{
				return this.left;
			}
		}

		// Token: 0x17000595 RID: 1429
		// (get) Token: 0x060028BA RID: 10426 RVA: 0x000E4AFA File Offset: 0x000E2CFA
		public float Right
		{
			get
			{
				return this.right;
			}
		}

		// Token: 0x04002E91 RID: 11921
		private float left;

		// Token: 0x04002E92 RID: 11922
		private float right;
	}
}
