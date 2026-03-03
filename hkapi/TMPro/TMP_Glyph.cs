using System;

namespace TMPro
{
	// Token: 0x0200062D RID: 1581
	[Serializable]
	public class TMP_Glyph : TMP_TextElement
	{
		// Token: 0x0600261B RID: 9755 RVA: 0x000C842C File Offset: 0x000C662C
		public static TMP_Glyph Clone(TMP_Glyph source)
		{
			return new TMP_Glyph
			{
				id = source.id,
				x = source.x,
				y = source.y,
				width = source.width,
				height = source.height,
				xOffset = source.xOffset,
				yOffset = source.yOffset,
				xAdvance = source.xAdvance,
				scale = source.scale
			};
		}
	}
}
