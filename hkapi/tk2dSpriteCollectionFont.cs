using System;
using UnityEngine;

// Token: 0x02000579 RID: 1401
[Serializable]
public class tk2dSpriteCollectionFont
{
	// Token: 0x06001F1F RID: 7967 RVA: 0x0009B10C File Offset: 0x0009930C
	public void CopyFrom(tk2dSpriteCollectionFont src)
	{
		this.active = src.active;
		this.bmFont = src.bmFont;
		this.texture = src.texture;
		this.dupeCaps = src.dupeCaps;
		this.flipTextureY = src.flipTextureY;
		this.charPadX = src.charPadX;
		this.data = src.data;
		this.editorData = src.editorData;
		this.materialId = src.materialId;
		this.gradientCount = src.gradientCount;
		this.gradientTexture = src.gradientTexture;
		this.useGradient = src.useGradient;
	}

	// Token: 0x170003FA RID: 1018
	// (get) Token: 0x06001F20 RID: 7968 RVA: 0x0009B1AC File Offset: 0x000993AC
	public string Name
	{
		get
		{
			if (this.bmFont == null || this.texture == null)
			{
				return "Empty";
			}
			if (this.data == null)
			{
				return this.bmFont.name + " (Inactive)";
			}
			return this.bmFont.name;
		}
	}

	// Token: 0x170003FB RID: 1019
	// (get) Token: 0x06001F21 RID: 7969 RVA: 0x0009B20C File Offset: 0x0009940C
	public bool InUse
	{
		get
		{
			return this.active && this.bmFont != null && this.texture != null && this.data != null && this.editorData != null;
		}
	}

	// Token: 0x06001F22 RID: 7970 RVA: 0x0009B259 File Offset: 0x00099459
	public tk2dSpriteCollectionFont()
	{
		this.gradientCount = 1;
		base..ctor();
	}

	// Token: 0x040024A4 RID: 9380
	public bool active;

	// Token: 0x040024A5 RID: 9381
	public TextAsset bmFont;

	// Token: 0x040024A6 RID: 9382
	public Texture2D texture;

	// Token: 0x040024A7 RID: 9383
	public bool dupeCaps;

	// Token: 0x040024A8 RID: 9384
	public bool flipTextureY;

	// Token: 0x040024A9 RID: 9385
	public int charPadX;

	// Token: 0x040024AA RID: 9386
	public tk2dFontData data;

	// Token: 0x040024AB RID: 9387
	public tk2dFont editorData;

	// Token: 0x040024AC RID: 9388
	public int materialId;

	// Token: 0x040024AD RID: 9389
	public bool useGradient;

	// Token: 0x040024AE RID: 9390
	public Texture2D gradientTexture;

	// Token: 0x040024AF RID: 9391
	public int gradientCount;
}
