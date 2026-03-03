using System;
using UnityEngine;

// Token: 0x0200054A RID: 1354
[Serializable]
public class tk2dTextMeshData
{
	// Token: 0x06001D89 RID: 7561 RVA: 0x000933D0 File Offset: 0x000915D0
	public tk2dTextMeshData()
	{
		this.text = "";
		this.color = Color.white;
		this.color2 = Color.white;
		this.anchor = TextAnchor.LowerLeft;
		this.scale = Vector3.one;
		this.maxChars = 16;
		base..ctor();
	}

	// Token: 0x04002342 RID: 9026
	public int version;

	// Token: 0x04002343 RID: 9027
	public tk2dFontData font;

	// Token: 0x04002344 RID: 9028
	public string text;

	// Token: 0x04002345 RID: 9029
	public Color color;

	// Token: 0x04002346 RID: 9030
	public Color color2;

	// Token: 0x04002347 RID: 9031
	public bool useGradient;

	// Token: 0x04002348 RID: 9032
	public int textureGradient;

	// Token: 0x04002349 RID: 9033
	public TextAnchor anchor;

	// Token: 0x0400234A RID: 9034
	public int renderLayer;

	// Token: 0x0400234B RID: 9035
	public Vector3 scale;

	// Token: 0x0400234C RID: 9036
	public bool kerning;

	// Token: 0x0400234D RID: 9037
	public int maxChars;

	// Token: 0x0400234E RID: 9038
	public bool inlineStyling;

	// Token: 0x0400234F RID: 9039
	public bool formatting;

	// Token: 0x04002350 RID: 9040
	public int wordWrapWidth;

	// Token: 0x04002351 RID: 9041
	public float spacing;

	// Token: 0x04002352 RID: 9042
	public float lineSpacing;
}
