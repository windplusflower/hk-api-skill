using System;

namespace tk2dRuntime.TileMap
{
	// Token: 0x0200064D RID: 1613
	[Serializable]
	public class SpriteChannel
	{
		// Token: 0x06002713 RID: 10003 RVA: 0x000DC62C File Offset: 0x000DA82C
		public SpriteChannel()
		{
			this.chunks = new SpriteChunk[0];
		}

		// Token: 0x04002B4E RID: 11086
		public SpriteChunk[] chunks;
	}
}
