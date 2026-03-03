using System;
using System.Collections.Generic;
using tk2dRuntime;
using UnityEngine;

// Token: 0x02000588 RID: 1416
[AddComponentMenu("2D Toolkit/Backend/tk2dSpriteCollectionData")]
public class tk2dSpriteCollectionData : MonoBehaviour
{
	// Token: 0x17000402 RID: 1026
	// (get) Token: 0x06001F39 RID: 7993 RVA: 0x0009B79E File Offset: 0x0009999E
	// (set) Token: 0x06001F3A RID: 7994 RVA: 0x0009B7A6 File Offset: 0x000999A6
	public bool Transient { get; set; }

	// Token: 0x17000403 RID: 1027
	// (get) Token: 0x06001F3B RID: 7995 RVA: 0x0009B7AF File Offset: 0x000999AF
	public int Count
	{
		get
		{
			return this.inst.spriteDefinitions.Length;
		}
	}

	// Token: 0x06001F3C RID: 7996 RVA: 0x0009B7BE File Offset: 0x000999BE
	public int GetSpriteIdByName(string name)
	{
		return this.GetSpriteIdByName(name, 0);
	}

	// Token: 0x06001F3D RID: 7997 RVA: 0x0009B7C8 File Offset: 0x000999C8
	public int GetSpriteIdByName(string name, int defaultValue)
	{
		this.inst.InitDictionary();
		int result = defaultValue;
		if (!this.inst.spriteNameLookupDict.TryGetValue(name, out result))
		{
			return defaultValue;
		}
		return result;
	}

	// Token: 0x06001F3E RID: 7998 RVA: 0x0009B7FA File Offset: 0x000999FA
	public void ClearDictionary()
	{
		this.spriteNameLookupDict = null;
	}

	// Token: 0x06001F3F RID: 7999 RVA: 0x0009B804 File Offset: 0x00099A04
	public tk2dSpriteDefinition GetSpriteDefinition(string name)
	{
		int spriteIdByName = this.GetSpriteIdByName(name, -1);
		if (spriteIdByName == -1)
		{
			return null;
		}
		return this.spriteDefinitions[spriteIdByName];
	}

	// Token: 0x06001F40 RID: 8000 RVA: 0x0009B828 File Offset: 0x00099A28
	public void InitDictionary()
	{
		if (this.spriteNameLookupDict == null)
		{
			this.spriteNameLookupDict = new Dictionary<string, int>(this.spriteDefinitions.Length);
			for (int i = 0; i < this.spriteDefinitions.Length; i++)
			{
				this.spriteNameLookupDict[this.spriteDefinitions[i].name] = i;
			}
		}
	}

	// Token: 0x17000404 RID: 1028
	// (get) Token: 0x06001F41 RID: 8001 RVA: 0x0009B87C File Offset: 0x00099A7C
	public tk2dSpriteDefinition FirstValidDefinition
	{
		get
		{
			foreach (tk2dSpriteDefinition tk2dSpriteDefinition in this.inst.spriteDefinitions)
			{
				if (tk2dSpriteDefinition.Valid)
				{
					return tk2dSpriteDefinition;
				}
			}
			return null;
		}
	}

	// Token: 0x06001F42 RID: 8002 RVA: 0x0009B8B2 File Offset: 0x00099AB2
	public bool IsValidSpriteId(int id)
	{
		return id >= 0 && id < this.inst.spriteDefinitions.Length && this.inst.spriteDefinitions[id].Valid;
	}

	// Token: 0x17000405 RID: 1029
	// (get) Token: 0x06001F43 RID: 8003 RVA: 0x0009B8DC File Offset: 0x00099ADC
	public int FirstValidDefinitionIndex
	{
		get
		{
			tk2dSpriteCollectionData inst = this.inst;
			for (int i = 0; i < inst.spriteDefinitions.Length; i++)
			{
				if (inst.spriteDefinitions[i].Valid)
				{
					return i;
				}
			}
			return -1;
		}
	}

	// Token: 0x06001F44 RID: 8004 RVA: 0x0009B918 File Offset: 0x00099B18
	public void InitMaterialIds()
	{
		if (this.inst.materialIdsValid)
		{
			return;
		}
		int num = -1;
		Dictionary<Material, int> dictionary = new Dictionary<Material, int>();
		for (int i = 0; i < this.inst.materials.Length; i++)
		{
			if (num == -1 && this.inst.materials[i] != null)
			{
				num = i;
			}
			dictionary[this.materials[i]] = i;
		}
		if (num == -1)
		{
			Debug.LogError("Init material ids failed.");
			return;
		}
		foreach (tk2dSpriteDefinition tk2dSpriteDefinition in this.inst.spriteDefinitions)
		{
			if (!dictionary.TryGetValue(tk2dSpriteDefinition.material, out tk2dSpriteDefinition.materialId))
			{
				tk2dSpriteDefinition.materialId = num;
			}
		}
		this.inst.materialIdsValid = true;
	}

	// Token: 0x17000406 RID: 1030
	// (get) Token: 0x06001F45 RID: 8005 RVA: 0x0009B9DC File Offset: 0x00099BDC
	public tk2dSpriteCollectionData inst
	{
		get
		{
			if (this.platformSpecificData == null)
			{
				if (this.hasPlatformData)
				{
					string currentPlatform = tk2dSystem.CurrentPlatform;
					string text = "";
					for (int i = 0; i < this.spriteCollectionPlatforms.Length; i++)
					{
						if (this.spriteCollectionPlatforms[i] == currentPlatform)
						{
							text = this.spriteCollectionPlatformGUIDs[i];
							break;
						}
					}
					if (text.Length == 0)
					{
						text = this.spriteCollectionPlatformGUIDs[0];
					}
					this.platformSpecificData = tk2dSystem.LoadResourceByGUID<tk2dSpriteCollectionData>(text);
				}
				else
				{
					this.platformSpecificData = this;
				}
			}
			this.platformSpecificData.Init();
			return this.platformSpecificData;
		}
	}

	// Token: 0x06001F46 RID: 8006 RVA: 0x0009BA70 File Offset: 0x00099C70
	private void Init()
	{
		if (this.materialInsts != null)
		{
			return;
		}
		if (this.spriteDefinitions == null)
		{
			this.spriteDefinitions = new tk2dSpriteDefinition[0];
		}
		if (this.materials == null)
		{
			this.materials = new Material[0];
		}
		this.materialInsts = new Material[this.materials.Length];
		if (this.needMaterialInstance)
		{
			if (tk2dSystem.OverrideBuildMaterial)
			{
				for (int i = 0; i < this.materials.Length; i++)
				{
					this.materialInsts[i] = new Material(Shader.Find("tk2d/BlendVertexColor"));
				}
			}
			else
			{
				bool flag = false;
				if (this.pngTextures.Length != 0)
				{
					flag = true;
					this.textureInsts = new Texture2D[this.pngTextures.Length];
					for (int j = 0; j < this.pngTextures.Length; j++)
					{
						Texture2D texture2D = new Texture2D(4, 4, TextureFormat.ARGB32, this.textureMipMaps);
						texture2D.LoadImage(this.pngTextures[j].bytes);
						this.textureInsts[j] = texture2D;
						texture2D.filterMode = this.textureFilterMode;
						texture2D.Apply(this.textureMipMaps, true);
					}
				}
				for (int k = 0; k < this.materials.Length; k++)
				{
					this.materialInsts[k] = UnityEngine.Object.Instantiate<Material>(this.materials[k]);
					if (flag)
					{
						int num = (this.materialPngTextureId.Length == 0) ? 0 : this.materialPngTextureId[k];
						this.materialInsts[k].mainTexture = this.textureInsts[num];
					}
				}
			}
			for (int l = 0; l < this.spriteDefinitions.Length; l++)
			{
				tk2dSpriteDefinition tk2dSpriteDefinition = this.spriteDefinitions[l];
				tk2dSpriteDefinition.materialInst = this.materialInsts[tk2dSpriteDefinition.materialId];
			}
		}
		else
		{
			for (int m = 0; m < this.materials.Length; m++)
			{
				this.materialInsts[m] = this.materials[m];
			}
			for (int n = 0; n < this.spriteDefinitions.Length; n++)
			{
				tk2dSpriteDefinition tk2dSpriteDefinition2 = this.spriteDefinitions[n];
				tk2dSpriteDefinition2.materialInst = tk2dSpriteDefinition2.material;
			}
		}
		tk2dEditorSpriteDataUnloader.Register(this);
	}

	// Token: 0x06001F47 RID: 8007 RVA: 0x0009BC6C File Offset: 0x00099E6C
	public static tk2dSpriteCollectionData CreateFromTexture(Texture texture, tk2dSpriteCollectionSize size, string[] names, Rect[] regions, Vector2[] anchors)
	{
		return SpriteCollectionGenerator.CreateFromTexture(texture, size, names, regions, anchors);
	}

	// Token: 0x06001F48 RID: 8008 RVA: 0x0009BC79 File Offset: 0x00099E79
	public static tk2dSpriteCollectionData CreateFromTexturePacker(tk2dSpriteCollectionSize size, string texturePackerData, Texture texture)
	{
		return SpriteCollectionGenerator.CreateFromTexturePacker(size, texturePackerData, texture);
	}

	// Token: 0x06001F49 RID: 8009 RVA: 0x0009BC84 File Offset: 0x00099E84
	public void ResetPlatformData()
	{
		tk2dEditorSpriteDataUnloader.Unregister(this);
		if (this.platformSpecificData != null)
		{
			this.platformSpecificData.DestroyTextureInsts();
		}
		this.DestroyTextureInsts();
		if (this.platformSpecificData)
		{
			this.platformSpecificData = null;
		}
		this.materialInsts = null;
	}

	// Token: 0x06001F4A RID: 8010 RVA: 0x0009BCD4 File Offset: 0x00099ED4
	private void DestroyTextureInsts()
	{
		Texture2D[] array = this.textureInsts;
		for (int i = 0; i < array.Length; i++)
		{
			UnityEngine.Object.DestroyImmediate(array[i]);
		}
		this.textureInsts = new Texture2D[0];
	}

	// Token: 0x06001F4B RID: 8011 RVA: 0x0009BD0C File Offset: 0x00099F0C
	public void UnloadTextures()
	{
		tk2dSpriteCollectionData inst = this.inst;
		Texture[] array = inst.textures;
		for (int i = 0; i < array.Length; i++)
		{
			Resources.UnloadAsset((Texture2D)array[i]);
		}
		inst.DestroyMaterialInsts();
		inst.DestroyTextureInsts();
	}

	// Token: 0x06001F4C RID: 8012 RVA: 0x0009BD50 File Offset: 0x00099F50
	private void DestroyMaterialInsts()
	{
		if (this.needMaterialInstance)
		{
			Material[] array = this.materialInsts;
			for (int i = 0; i < array.Length; i++)
			{
				UnityEngine.Object.DestroyImmediate(array[i]);
			}
		}
		this.materialInsts = null;
	}

	// Token: 0x06001F4D RID: 8013 RVA: 0x0009BD8C File Offset: 0x00099F8C
	private void OnDestroy()
	{
		if (this.Transient)
		{
			Material[] array = this.materials;
			for (int i = 0; i < array.Length; i++)
			{
				UnityEngine.Object.DestroyImmediate(array[i]);
			}
		}
		else if (this.needMaterialInstance)
		{
			Material[] array = this.materialInsts;
			for (int i = 0; i < array.Length; i++)
			{
				UnityEngine.Object.DestroyImmediate(array[i]);
			}
			this.materialInsts = new Material[0];
			Texture2D[] array2 = this.textureInsts;
			for (int i = 0; i < array2.Length; i++)
			{
				UnityEngine.Object.DestroyImmediate(array2[i]);
			}
			this.textureInsts = new Texture2D[0];
		}
		this.ResetPlatformData();
	}

	// Token: 0x06001F4E RID: 8014 RVA: 0x0009BE20 File Offset: 0x0009A020
	public tk2dSpriteCollectionData()
	{
		this.textureInsts = new Texture2D[0];
		this.pngTextures = new TextAsset[0];
		this.materialPngTextureId = new int[0];
		this.textureFilterMode = FilterMode.Bilinear;
		this.assetName = "";
		this.invOrthoSize = 1f;
		this.halfTargetHeight = 1f;
		this.dataGuid = "";
		base..ctor();
	}

	// Token: 0x06001F4F RID: 8015 RVA: 0x0009BE8A File Offset: 0x0009A08A
	// Note: this type is marked as 'beforefieldinit'.
	static tk2dSpriteCollectionData()
	{
		tk2dSpriteCollectionData.internalResourcePrefix = "tk2dInternal$.";
	}

	// Token: 0x04002531 RID: 9521
	public const int CURRENT_VERSION = 3;

	// Token: 0x04002532 RID: 9522
	public int version;

	// Token: 0x04002533 RID: 9523
	public bool materialIdsValid;

	// Token: 0x04002534 RID: 9524
	public bool needMaterialInstance;

	// Token: 0x04002536 RID: 9526
	public tk2dSpriteDefinition[] spriteDefinitions;

	// Token: 0x04002537 RID: 9527
	private Dictionary<string, int> spriteNameLookupDict;

	// Token: 0x04002538 RID: 9528
	public bool premultipliedAlpha;

	// Token: 0x04002539 RID: 9529
	public Material material;

	// Token: 0x0400253A RID: 9530
	public Material[] materials;

	// Token: 0x0400253B RID: 9531
	[NonSerialized]
	public Material[] materialInsts;

	// Token: 0x0400253C RID: 9532
	[NonSerialized]
	public Texture2D[] textureInsts;

	// Token: 0x0400253D RID: 9533
	public Texture[] textures;

	// Token: 0x0400253E RID: 9534
	public TextAsset[] pngTextures;

	// Token: 0x0400253F RID: 9535
	public int[] materialPngTextureId;

	// Token: 0x04002540 RID: 9536
	public FilterMode textureFilterMode;

	// Token: 0x04002541 RID: 9537
	public bool textureMipMaps;

	// Token: 0x04002542 RID: 9538
	public bool allowMultipleAtlases;

	// Token: 0x04002543 RID: 9539
	public string spriteCollectionGUID;

	// Token: 0x04002544 RID: 9540
	public string spriteCollectionName;

	// Token: 0x04002545 RID: 9541
	public string assetName;

	// Token: 0x04002546 RID: 9542
	public bool loadable;

	// Token: 0x04002547 RID: 9543
	public float invOrthoSize;

	// Token: 0x04002548 RID: 9544
	public float halfTargetHeight;

	// Token: 0x04002549 RID: 9545
	public int buildKey;

	// Token: 0x0400254A RID: 9546
	public string dataGuid;

	// Token: 0x0400254B RID: 9547
	public bool managedSpriteCollection;

	// Token: 0x0400254C RID: 9548
	public bool hasPlatformData;

	// Token: 0x0400254D RID: 9549
	public string[] spriteCollectionPlatforms;

	// Token: 0x0400254E RID: 9550
	public string[] spriteCollectionPlatformGUIDs;

	// Token: 0x0400254F RID: 9551
	private tk2dSpriteCollectionData platformSpecificData;

	// Token: 0x04002550 RID: 9552
	public static readonly string internalResourcePrefix;
}
