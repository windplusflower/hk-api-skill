using System;
using UnityEngine;

namespace TMPro
{
	// Token: 0x0200063F RID: 1599
	[Serializable]
	public struct Mesh_Extents
	{
		// Token: 0x06002636 RID: 9782 RVA: 0x000C8909 File Offset: 0x000C6B09
		public Mesh_Extents(Vector2 min, Vector2 max)
		{
			this.min = min;
			this.max = max;
		}

		// Token: 0x06002637 RID: 9783 RVA: 0x000C891C File Offset: 0x000C6B1C
		public override string ToString()
		{
			return string.Concat(new string[]
			{
				"Min (",
				this.min.x.ToString("f2"),
				", ",
				this.min.y.ToString("f2"),
				")   Max (",
				this.max.x.ToString("f2"),
				", ",
				this.max.y.ToString("f2"),
				")"
			});
		}

		// Token: 0x04002A89 RID: 10889
		public Vector2 min;

		// Token: 0x04002A8A RID: 10890
		public Vector2 max;
	}
}
