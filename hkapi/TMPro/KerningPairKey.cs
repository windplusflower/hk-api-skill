using System;

namespace TMPro
{
	// Token: 0x02000630 RID: 1584
	public struct KerningPairKey
	{
		// Token: 0x0600261E RID: 9758 RVA: 0x000C84AA File Offset: 0x000C66AA
		public KerningPairKey(int ascii_left, int ascii_right)
		{
			this.ascii_Left = ascii_left;
			this.ascii_Right = ascii_right;
			this.key = (ascii_right << 16) + ascii_left;
		}

		// Token: 0x04002A35 RID: 10805
		public int ascii_Left;

		// Token: 0x04002A36 RID: 10806
		public int ascii_Right;

		// Token: 0x04002A37 RID: 10807
		public int key;
	}
}
