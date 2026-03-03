using System;
using System.Collections.Generic;
using UnityEngine;

// Token: 0x02000547 RID: 1351
[AddComponentMenu("2D Toolkit/Backend/tk2dFontData")]
public class tk2dFontData : MonoBehaviour
{
	// Token: 0x170003AC RID: 940
	// (get) Token: 0x06001D72 RID: 7538 RVA: 0x00092050 File Offset: 0x00090250
	public tk2dFontData inst
	{
		get
		{
			if (this.platformSpecificData == null || this.platformSpecificData.materialInst == null)
			{
				if (this.hasPlatformData)
				{
					string currentPlatform = tk2dSystem.CurrentPlatform;
					string text = "";
					for (int i = 0; i < this.fontPlatforms.Length; i++)
					{
						if (this.fontPlatforms[i] == currentPlatform)
						{
							text = this.fontPlatformGUIDs[i];
							break;
						}
					}
					if (text.Length == 0)
					{
						text = this.fontPlatformGUIDs[0];
					}
					this.platformSpecificData = tk2dSystem.LoadResourceByGUID<tk2dFontData>(text);
				}
				else
				{
					this.platformSpecificData = this;
				}
				this.platformSpecificData.Init();
			}
			return this.platformSpecificData;
		}
	}

	// Token: 0x06001D73 RID: 7539 RVA: 0x000920FC File Offset: 0x000902FC
	private void Init()
	{
		if (this.needMaterialInstance)
		{
			if (!this.spriteCollection)
			{
				this.materialInst = UnityEngine.Object.Instantiate<Material>(this.material);
				this.materialInst.hideFlags = HideFlags.DontSave;
				return;
			}
			tk2dSpriteCollectionData inst = this.spriteCollection.inst;
			for (int i = 0; i < inst.materials.Length; i++)
			{
				if (inst.materials[i] == this.material)
				{
					this.materialInst = inst.materialInsts[i];
					break;
				}
			}
			if (this.materialInst == null && !this.needMaterialInstance)
			{
				Debug.LogError("Fatal error - font from sprite collection is has an invalid material");
				return;
			}
		}
		else
		{
			this.materialInst = this.material;
		}
	}

	// Token: 0x06001D74 RID: 7540 RVA: 0x000921B1 File Offset: 0x000903B1
	public void ResetPlatformData()
	{
		if (this.hasPlatformData && this.platformSpecificData)
		{
			this.platformSpecificData = null;
		}
		this.materialInst = null;
	}

	// Token: 0x06001D75 RID: 7541 RVA: 0x000921D6 File Offset: 0x000903D6
	private void OnDestroy()
	{
		if (this.needMaterialInstance && this.spriteCollection == null)
		{
			UnityEngine.Object.DestroyImmediate(this.materialInst);
		}
	}

	// Token: 0x06001D76 RID: 7542 RVA: 0x000921FC File Offset: 0x000903FC
	public void InitDictionary()
	{
		if (this.useDictionary && this.charDict == null)
		{
			this.charDict = new Dictionary<int, tk2dFontChar>(this.charDictKeys.Count);
			for (int i = 0; i < this.charDictKeys.Count; i++)
			{
				this.charDict[this.charDictKeys[i]] = this.charDictValues[i];
			}
		}
	}

	// Token: 0x06001D77 RID: 7543 RVA: 0x00092268 File Offset: 0x00090468
	public void SetDictionary(Dictionary<int, tk2dFontChar> dict)
	{
		this.charDictKeys = new List<int>(dict.Keys);
		this.charDictValues = new List<tk2dFontChar>();
		for (int i = 0; i < this.charDictKeys.Count; i++)
		{
			this.charDictValues.Add(dict[this.charDictKeys[i]]);
		}
	}

	// Token: 0x06001D78 RID: 7544 RVA: 0x000922C4 File Offset: 0x000904C4
	public tk2dFontData()
	{
		this.gradientCount = 1;
		this.invOrthoSize = 1f;
		this.halfTargetHeight = 1f;
		base..ctor();
	}

	// Token: 0x0400231D RID: 8989
	public const int CURRENT_VERSION = 2;

	// Token: 0x0400231E RID: 8990
	[HideInInspector]
	public int version;

	// Token: 0x0400231F RID: 8991
	public float lineHeight;

	// Token: 0x04002320 RID: 8992
	public tk2dFontChar[] chars;

	// Token: 0x04002321 RID: 8993
	[SerializeField]
	private List<int> charDictKeys;

	// Token: 0x04002322 RID: 8994
	[SerializeField]
	private List<tk2dFontChar> charDictValues;

	// Token: 0x04002323 RID: 8995
	public string[] fontPlatforms;

	// Token: 0x04002324 RID: 8996
	public string[] fontPlatformGUIDs;

	// Token: 0x04002325 RID: 8997
	private tk2dFontData platformSpecificData;

	// Token: 0x04002326 RID: 8998
	public bool hasPlatformData;

	// Token: 0x04002327 RID: 8999
	public bool managedFont;

	// Token: 0x04002328 RID: 9000
	public bool needMaterialInstance;

	// Token: 0x04002329 RID: 9001
	public bool isPacked;

	// Token: 0x0400232A RID: 9002
	public bool premultipliedAlpha;

	// Token: 0x0400232B RID: 9003
	public tk2dSpriteCollectionData spriteCollection;

	// Token: 0x0400232C RID: 9004
	public Dictionary<int, tk2dFontChar> charDict;

	// Token: 0x0400232D RID: 9005
	public bool useDictionary;

	// Token: 0x0400232E RID: 9006
	public tk2dFontKerning[] kerning;

	// Token: 0x0400232F RID: 9007
	public float largestWidth;

	// Token: 0x04002330 RID: 9008
	public Material material;

	// Token: 0x04002331 RID: 9009
	[NonSerialized]
	public Material materialInst;

	// Token: 0x04002332 RID: 9010
	public Texture2D gradientTexture;

	// Token: 0x04002333 RID: 9011
	public bool textureGradients;

	// Token: 0x04002334 RID: 9012
	public int gradientCount;

	// Token: 0x04002335 RID: 9013
	public Vector2 texelSize;

	// Token: 0x04002336 RID: 9014
	[HideInInspector]
	public float invOrthoSize;

	// Token: 0x04002337 RID: 9015
	[HideInInspector]
	public float halfTargetHeight;
}
