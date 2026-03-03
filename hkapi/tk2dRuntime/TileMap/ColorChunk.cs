using System;
using UnityEngine;

namespace tk2dRuntime.TileMap
{
	// Token: 0x0200064E RID: 1614
	[Serializable]
	public class ColorChunk
	{
		// Token: 0x1700055C RID: 1372
		// (get) Token: 0x06002714 RID: 10004 RVA: 0x000DC640 File Offset: 0x000DA840
		// (set) Token: 0x06002715 RID: 10005 RVA: 0x000DC648 File Offset: 0x000DA848
		public bool Dirty { get; set; }

		// Token: 0x1700055D RID: 1373
		// (get) Token: 0x06002716 RID: 10006 RVA: 0x000DC651 File Offset: 0x000DA851
		public bool Empty
		{
			get
			{
				return this.colors.Length == 0;
			}
		}

		// Token: 0x06002717 RID: 10007 RVA: 0x000DC65D File Offset: 0x000DA85D
		public ColorChunk()
		{
			this.colors = new Color32[0];
		}

		// Token: 0x04002B50 RID: 11088
		public Color32[] colors;
	}
}
