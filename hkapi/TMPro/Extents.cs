using System;
using UnityEngine;

namespace TMPro
{
	// Token: 0x0200063E RID: 1598
	public struct Extents
	{
		// Token: 0x06002634 RID: 9780 RVA: 0x000C8855 File Offset: 0x000C6A55
		public Extents(Vector2 min, Vector2 max)
		{
			this.min = min;
			this.max = max;
		}

		// Token: 0x06002635 RID: 9781 RVA: 0x000C8868 File Offset: 0x000C6A68
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

		// Token: 0x04002A87 RID: 10887
		public Vector2 min;

		// Token: 0x04002A88 RID: 10888
		public Vector2 max;
	}
}
