using System;
using System.Collections.Generic;
using UnityEngine;

// Token: 0x0200057B RID: 1403
[AddComponentMenu("2D Toolkit/Backend/tk2dSpriteCollection")]
public class tk2dSpriteCollection : MonoBehaviour
{
	// Token: 0x170003FD RID: 1021
	// (get) Token: 0x06001F26 RID: 7974 RVA: 0x0009B2B3 File Offset: 0x000994B3
	// (set) Token: 0x06001F27 RID: 7975 RVA: 0x0009B2BB File Offset: 0x000994BB
	public Texture2D[] DoNotUse__TextureRefs
	{
		get
		{
			return this.textureRefs;
		}
		set
		{
			this.textureRefs = value;
		}
	}

	// Token: 0x170003FE RID: 1022
	// (get) Token: 0x06001F28 RID: 7976 RVA: 0x0009B2C4 File Offset: 0x000994C4
	public bool HasPlatformData
	{
		get
		{
			return this.platforms.Count > 1;
		}
	}

	// Token: 0x06001F29 RID: 7977 RVA: 0x0009B2D4 File Offset: 0x000994D4
	public void Upgrade()
	{
		if (this.version == 4)
		{
			return;
		}
		Debug.Log("SpriteCollection '" + base.name + "' - Upgraded from version " + this.version.ToString());
		if (this.version == 0)
		{
			if (this.pixelPerfectPointSampled)
			{
				this.filterMode = FilterMode.Point;
			}
			else
			{
				this.filterMode = FilterMode.Bilinear;
			}
			this.userDefinedTextureSettings = true;
		}
		if (this.version < 3 && this.textureRefs != null && this.textureParams != null && this.textureRefs.Length == this.textureParams.Length)
		{
			for (int i = 0; i < this.textureRefs.Length; i++)
			{
				this.textureParams[i].texture = this.textureRefs[i];
			}
			this.textureRefs = null;
		}
		if (this.version < 4)
		{
			this.sizeDef.CopyFromLegacy(this.useTk2dCamera, this.targetOrthoSize, (float)this.targetHeight);
		}
		this.version = 4;
	}

	// Token: 0x06001F2A RID: 7978 RVA: 0x0009B3C0 File Offset: 0x000995C0
	public tk2dSpriteCollection()
	{
		this.platforms = new List<tk2dSpriteCollectionPlatform>();
		this.maxTextureSize = 2048;
		this.forcedTextureWidth = 2048;
		this.forcedTextureHeight = 2048;
		this.removeDuplicates = true;
		this.atlasTextureFiles = new TextAsset[0];
		this.targetHeight = 640;
		this.targetOrthoSize = 10f;
		this.sizeDef = tk2dSpriteCollectionSize.Default();
		this.globalScale = 1f;
		this.globalTextureRescale = 1f;
		this.attachPointTestSprites = new List<tk2dSpriteCollection.AttachPointTestSprite>();
		this.filterMode = FilterMode.Bilinear;
		this.wrapMode = TextureWrapMode.Clamp;
		this.anisoLevel = 1;
		this.physicsDepth = 0.1f;
		this.padAmount = -1;
		this.autoUpdate = true;
		this.editorDisplayScale = 1f;
		this.assetName = "";
		this.linkedSpriteCollections = new List<tk2dLinkedSpriteCollection>();
		base..ctor();
	}

	// Token: 0x040024B2 RID: 9394
	public const int CURRENT_VERSION = 4;

	// Token: 0x040024B3 RID: 9395
	[SerializeField]
	private tk2dSpriteCollectionDefinition[] textures;

	// Token: 0x040024B4 RID: 9396
	[SerializeField]
	private Texture2D[] textureRefs;

	// Token: 0x040024B5 RID: 9397
	public tk2dSpriteSheetSource[] spriteSheets;

	// Token: 0x040024B6 RID: 9398
	public tk2dSpriteCollectionFont[] fonts;

	// Token: 0x040024B7 RID: 9399
	public tk2dSpriteCollectionDefault defaults;

	// Token: 0x040024B8 RID: 9400
	public List<tk2dSpriteCollectionPlatform> platforms;

	// Token: 0x040024B9 RID: 9401
	public bool managedSpriteCollection;

	// Token: 0x040024BA RID: 9402
	public tk2dSpriteCollection linkParent;

	// Token: 0x040024BB RID: 9403
	public bool loadable;

	// Token: 0x040024BC RID: 9404
	public tk2dSpriteCollection.AtlasFormat atlasFormat;

	// Token: 0x040024BD RID: 9405
	public int maxTextureSize;

	// Token: 0x040024BE RID: 9406
	public bool forceTextureSize;

	// Token: 0x040024BF RID: 9407
	public int forcedTextureWidth;

	// Token: 0x040024C0 RID: 9408
	public int forcedTextureHeight;

	// Token: 0x040024C1 RID: 9409
	public tk2dSpriteCollection.TextureCompression textureCompression;

	// Token: 0x040024C2 RID: 9410
	public int atlasWidth;

	// Token: 0x040024C3 RID: 9411
	public int atlasHeight;

	// Token: 0x040024C4 RID: 9412
	public bool forceSquareAtlas;

	// Token: 0x040024C5 RID: 9413
	public float atlasWastage;

	// Token: 0x040024C6 RID: 9414
	public bool allowMultipleAtlases;

	// Token: 0x040024C7 RID: 9415
	public bool removeDuplicates;

	// Token: 0x040024C8 RID: 9416
	public tk2dSpriteCollectionDefinition[] textureParams;

	// Token: 0x040024C9 RID: 9417
	public tk2dSpriteCollectionData spriteCollection;

	// Token: 0x040024CA RID: 9418
	public bool premultipliedAlpha;

	// Token: 0x040024CB RID: 9419
	public Material[] altMaterials;

	// Token: 0x040024CC RID: 9420
	public Material[] atlasMaterials;

	// Token: 0x040024CD RID: 9421
	public Texture2D[] atlasTextures;

	// Token: 0x040024CE RID: 9422
	public TextAsset[] atlasTextureFiles;

	// Token: 0x040024CF RID: 9423
	[SerializeField]
	private bool useTk2dCamera;

	// Token: 0x040024D0 RID: 9424
	[SerializeField]
	private int targetHeight;

	// Token: 0x040024D1 RID: 9425
	[SerializeField]
	private float targetOrthoSize;

	// Token: 0x040024D2 RID: 9426
	public tk2dSpriteCollectionSize sizeDef;

	// Token: 0x040024D3 RID: 9427
	public float globalScale;

	// Token: 0x040024D4 RID: 9428
	public float globalTextureRescale;

	// Token: 0x040024D5 RID: 9429
	public List<tk2dSpriteCollection.AttachPointTestSprite> attachPointTestSprites;

	// Token: 0x040024D6 RID: 9430
	[SerializeField]
	private bool pixelPerfectPointSampled;

	// Token: 0x040024D7 RID: 9431
	public FilterMode filterMode;

	// Token: 0x040024D8 RID: 9432
	public TextureWrapMode wrapMode;

	// Token: 0x040024D9 RID: 9433
	public bool userDefinedTextureSettings;

	// Token: 0x040024DA RID: 9434
	public bool mipmapEnabled;

	// Token: 0x040024DB RID: 9435
	public int anisoLevel;

	// Token: 0x040024DC RID: 9436
	public tk2dSpriteDefinition.PhysicsEngine physicsEngine;

	// Token: 0x040024DD RID: 9437
	public float physicsDepth;

	// Token: 0x040024DE RID: 9438
	public bool disableTrimming;

	// Token: 0x040024DF RID: 9439
	public bool disableRotation;

	// Token: 0x040024E0 RID: 9440
	public tk2dSpriteCollection.NormalGenerationMode normalGenerationMode;

	// Token: 0x040024E1 RID: 9441
	public int padAmount;

	// Token: 0x040024E2 RID: 9442
	public bool autoUpdate;

	// Token: 0x040024E3 RID: 9443
	public float editorDisplayScale;

	// Token: 0x040024E4 RID: 9444
	public int version;

	// Token: 0x040024E5 RID: 9445
	public string assetName;

	// Token: 0x040024E6 RID: 9446
	public List<tk2dLinkedSpriteCollection> linkedSpriteCollections;

	// Token: 0x0200057C RID: 1404
	public enum NormalGenerationMode
	{
		// Token: 0x040024E8 RID: 9448
		None,
		// Token: 0x040024E9 RID: 9449
		NormalsOnly,
		// Token: 0x040024EA RID: 9450
		NormalsAndTangents
	}

	// Token: 0x0200057D RID: 1405
	public enum TextureCompression
	{
		// Token: 0x040024EC RID: 9452
		Uncompressed,
		// Token: 0x040024ED RID: 9453
		Reduced16Bit,
		// Token: 0x040024EE RID: 9454
		Compressed,
		// Token: 0x040024EF RID: 9455
		Dithered16Bit_Alpha,
		// Token: 0x040024F0 RID: 9456
		Dithered16Bit_NoAlpha
	}

	// Token: 0x0200057E RID: 1406
	public enum AtlasFormat
	{
		// Token: 0x040024F2 RID: 9458
		UnityTexture,
		// Token: 0x040024F3 RID: 9459
		Png
	}

	// Token: 0x0200057F RID: 1407
	[Serializable]
	public class AttachPointTestSprite
	{
		// Token: 0x06001F2B RID: 7979 RVA: 0x0009B4A3 File Offset: 0x000996A3
		public bool CompareTo(tk2dSpriteCollection.AttachPointTestSprite src)
		{
			return src.attachPointName == this.attachPointName && src.spriteCollection == this.spriteCollection && src.spriteId == this.spriteId;
		}

		// Token: 0x06001F2C RID: 7980 RVA: 0x0009B4DB File Offset: 0x000996DB
		public void CopyFrom(tk2dSpriteCollection.AttachPointTestSprite src)
		{
			this.attachPointName = src.attachPointName;
			this.spriteCollection = src.spriteCollection;
			this.spriteId = src.spriteId;
		}

		// Token: 0x06001F2D RID: 7981 RVA: 0x0009B501 File Offset: 0x00099701
		public AttachPointTestSprite()
		{
			this.attachPointName = "";
			this.spriteId = -1;
			base..ctor();
		}

		// Token: 0x040024F4 RID: 9460
		public string attachPointName;

		// Token: 0x040024F5 RID: 9461
		public tk2dSpriteCollectionData spriteCollection;

		// Token: 0x040024F6 RID: 9462
		public int spriteId;
	}
}
