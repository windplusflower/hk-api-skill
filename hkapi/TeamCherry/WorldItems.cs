using System;
using System.Collections.Generic;
using UnityEngine;

namespace TeamCherry
{
	// Token: 0x02000660 RID: 1632
	[Serializable]
	public class WorldItems : ScriptableObject
	{
		// Token: 0x0600277F RID: 10111 RVA: 0x000DF2E2 File Offset: 0x000DD4E2
		public void OnEnable()
		{
			if (this.geoRocks == null)
			{
				this.geoRocks = new List<GeoRock>();
			}
		}

		// Token: 0x06002780 RID: 10112 RVA: 0x00003603 File Offset: 0x00001803
		public void RegisterGeoRock()
		{
		}

		// Token: 0x04002B86 RID: 11142
		public List<GeoRock> geoRocks;
	}
}
