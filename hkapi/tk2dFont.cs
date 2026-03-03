using System;
using UnityEngine;

// Token: 0x02000544 RID: 1348
[AddComponentMenu("2D Toolkit/Backend/tk2dFont")]
public class tk2dFont : MonoBehaviour
{
	// Token: 0x06001D6D RID: 7533 RVA: 0x00091FA4 File Offset: 0x000901A4
	public void Upgrade()
	{
		if (this.version >= tk2dFont.CURRENT_VERSION)
		{
			return;
		}
		Debug.Log("Font '" + base.name + "' - Upgraded from version " + this.version.ToString());
		if (this.version == 0)
		{
			this.sizeDef.CopyFromLegacy(this.useTk2dCamera, this.targetOrthoSize, (float)this.targetHeight);
		}
		this.version = tk2dFont.CURRENT_VERSION;
	}

	// Token: 0x06001D6E RID: 7534 RVA: 0x00092015 File Offset: 0x00090215
	public tk2dFont()
	{
		this.targetHeight = 640;
		this.targetOrthoSize = 1f;
		this.sizeDef = tk2dSpriteCollectionSize.Default();
		this.gradientCount = 1;
		base..ctor();
	}

	// Token: 0x06001D6F RID: 7535 RVA: 0x00092045 File Offset: 0x00090245
	// Note: this type is marked as 'beforefieldinit'.
	static tk2dFont()
	{
		tk2dFont.CURRENT_VERSION = 1;
	}

	// Token: 0x04002300 RID: 8960
	public TextAsset bmFont;

	// Token: 0x04002301 RID: 8961
	public Material material;

	// Token: 0x04002302 RID: 8962
	public Texture texture;

	// Token: 0x04002303 RID: 8963
	public Texture2D gradientTexture;

	// Token: 0x04002304 RID: 8964
	public bool dupeCaps;

	// Token: 0x04002305 RID: 8965
	public bool flipTextureY;

	// Token: 0x04002306 RID: 8966
	[HideInInspector]
	public bool proxyFont;

	// Token: 0x04002307 RID: 8967
	[HideInInspector]
	[SerializeField]
	private bool useTk2dCamera;

	// Token: 0x04002308 RID: 8968
	[HideInInspector]
	[SerializeField]
	private int targetHeight;

	// Token: 0x04002309 RID: 8969
	[HideInInspector]
	[SerializeField]
	private float targetOrthoSize;

	// Token: 0x0400230A RID: 8970
	public tk2dSpriteCollectionSize sizeDef;

	// Token: 0x0400230B RID: 8971
	public int gradientCount;

	// Token: 0x0400230C RID: 8972
	public bool manageMaterial;

	// Token: 0x0400230D RID: 8973
	[HideInInspector]
	public bool loadable;

	// Token: 0x0400230E RID: 8974
	public int charPadX;

	// Token: 0x0400230F RID: 8975
	public tk2dFontData data;

	// Token: 0x04002310 RID: 8976
	public static int CURRENT_VERSION;

	// Token: 0x04002311 RID: 8977
	public int version;
}
