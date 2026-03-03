using System;

namespace TMPro
{
	// Token: 0x02000631 RID: 1585
	[Serializable]
	public class KerningPair
	{
		// Token: 0x0600261F RID: 9759 RVA: 0x000C84C6 File Offset: 0x000C66C6
		public KerningPair(int left, int right, float offset)
		{
			this.AscII_Left = left;
			this.AscII_Right = right;
			this.XadvanceOffset = offset;
		}

		// Token: 0x04002A38 RID: 10808
		public int AscII_Left;

		// Token: 0x04002A39 RID: 10809
		public int AscII_Right;

		// Token: 0x04002A3A RID: 10810
		public float XadvanceOffset;
	}
}
