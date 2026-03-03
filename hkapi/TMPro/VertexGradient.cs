using System;
using UnityEngine;

namespace TMPro
{
	// Token: 0x02000639 RID: 1593
	[Serializable]
	public struct VertexGradient
	{
		// Token: 0x0600262E RID: 9774 RVA: 0x000C86F4 File Offset: 0x000C68F4
		public VertexGradient(Color color)
		{
			this.topLeft = color;
			this.topRight = color;
			this.bottomLeft = color;
			this.bottomRight = color;
		}

		// Token: 0x0600262F RID: 9775 RVA: 0x000C8712 File Offset: 0x000C6912
		public VertexGradient(Color color0, Color color1, Color color2, Color color3)
		{
			this.topLeft = color0;
			this.topRight = color1;
			this.bottomLeft = color2;
			this.bottomRight = color3;
		}

		// Token: 0x04002A70 RID: 10864
		public Color topLeft;

		// Token: 0x04002A71 RID: 10865
		public Color topRight;

		// Token: 0x04002A72 RID: 10866
		public Color bottomLeft;

		// Token: 0x04002A73 RID: 10867
		public Color bottomRight;
	}
}
