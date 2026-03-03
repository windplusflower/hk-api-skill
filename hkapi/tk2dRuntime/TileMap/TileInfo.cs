using System;

namespace tk2dRuntime.TileMap
{
	// Token: 0x02000658 RID: 1624
	[Serializable]
	public class TileInfo
	{
		// Token: 0x06002759 RID: 10073 RVA: 0x000DE5AA File Offset: 0x000DC7AA
		public TileInfo()
		{
			this.stringVal = "";
			base..ctor();
		}

		// Token: 0x04002B71 RID: 11121
		public string stringVal;

		// Token: 0x04002B72 RID: 11122
		public int intVal;

		// Token: 0x04002B73 RID: 11123
		public float floatVal;

		// Token: 0x04002B74 RID: 11124
		public bool enablePrefabOffset;
	}
}
