using System;
using UnityEngine;

namespace TMPro
{
	// Token: 0x020005D7 RID: 1495
	[Serializable]
	public class TMP_ColorGradient : ScriptableObject
	{
		// Token: 0x060022ED RID: 8941 RVA: 0x000B4540 File Offset: 0x000B2740
		public TMP_ColorGradient()
		{
			Color white = Color.white;
			this.topLeft = white;
			this.topRight = white;
			this.bottomLeft = white;
			this.bottomRight = white;
		}

		// Token: 0x060022EE RID: 8942 RVA: 0x000B4575 File Offset: 0x000B2775
		public TMP_ColorGradient(Color color)
		{
			this.topLeft = color;
			this.topRight = color;
			this.bottomLeft = color;
			this.bottomRight = color;
		}

		// Token: 0x060022EF RID: 8943 RVA: 0x000B4599 File Offset: 0x000B2799
		public TMP_ColorGradient(Color color0, Color color1, Color color2, Color color3)
		{
			this.topLeft = color0;
			this.topRight = color1;
			this.bottomLeft = color2;
			this.bottomRight = color3;
		}

		// Token: 0x0400277F RID: 10111
		public Color topLeft;

		// Token: 0x04002780 RID: 10112
		public Color topRight;

		// Token: 0x04002781 RID: 10113
		public Color bottomLeft;

		// Token: 0x04002782 RID: 10114
		public Color bottomRight;
	}
}
