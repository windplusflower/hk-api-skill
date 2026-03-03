using System;
using UnityEngine;

// Token: 0x02000576 RID: 1398
[Serializable]
public class tk2dSpriteSheetSource
{
	// Token: 0x06001F1B RID: 7963 RVA: 0x0009AEBC File Offset: 0x000990BC
	public void CopyFrom(tk2dSpriteSheetSource src)
	{
		this.texture = src.texture;
		this.tilesX = src.tilesX;
		this.tilesY = src.tilesY;
		this.numTiles = src.numTiles;
		this.anchor = src.anchor;
		this.pad = src.pad;
		this.scale = src.scale;
		this.colliderType = src.colliderType;
		this.version = src.version;
		this.active = src.active;
		this.tileWidth = src.tileWidth;
		this.tileHeight = src.tileHeight;
		this.tileSpacingX = src.tileSpacingX;
		this.tileSpacingY = src.tileSpacingY;
		this.tileMarginX = src.tileMarginX;
		this.tileMarginY = src.tileMarginY;
		this.splitMethod = src.splitMethod;
	}

	// Token: 0x06001F1C RID: 7964 RVA: 0x0009AF98 File Offset: 0x00099198
	public bool CompareTo(tk2dSpriteSheetSource src)
	{
		return !(this.texture != src.texture) && this.tilesX == src.tilesX && this.tilesY == src.tilesY && this.numTiles == src.numTiles && this.anchor == src.anchor && this.pad == src.pad && !(this.scale != src.scale) && this.colliderType == src.colliderType && this.version == src.version && this.active == src.active && this.tileWidth == src.tileWidth && this.tileHeight == src.tileHeight && this.tileSpacingX == src.tileSpacingX && this.tileSpacingY == src.tileSpacingY && this.tileMarginX == src.tileMarginX && this.tileMarginY == src.tileMarginY && this.splitMethod == src.splitMethod;
	}

	// Token: 0x170003F9 RID: 1017
	// (get) Token: 0x06001F1D RID: 7965 RVA: 0x0009B0C0 File Offset: 0x000992C0
	public string Name
	{
		get
		{
			if (!(this.texture != null))
			{
				return "New Sprite Sheet";
			}
			return this.texture.name;
		}
	}

	// Token: 0x06001F1E RID: 7966 RVA: 0x0009B0E1 File Offset: 0x000992E1
	public tk2dSpriteSheetSource()
	{
		this.anchor = tk2dSpriteSheetSource.Anchor.MiddleCenter;
		this.scale = new Vector3(1f, 1f, 1f);
		base..ctor();
	}

	// Token: 0x04002485 RID: 9349
	public Texture2D texture;

	// Token: 0x04002486 RID: 9350
	public int tilesX;

	// Token: 0x04002487 RID: 9351
	public int tilesY;

	// Token: 0x04002488 RID: 9352
	public int numTiles;

	// Token: 0x04002489 RID: 9353
	public tk2dSpriteSheetSource.Anchor anchor;

	// Token: 0x0400248A RID: 9354
	public tk2dSpriteCollectionDefinition.Pad pad;

	// Token: 0x0400248B RID: 9355
	public Vector3 scale;

	// Token: 0x0400248C RID: 9356
	public bool additive;

	// Token: 0x0400248D RID: 9357
	public bool active;

	// Token: 0x0400248E RID: 9358
	public int tileWidth;

	// Token: 0x0400248F RID: 9359
	public int tileHeight;

	// Token: 0x04002490 RID: 9360
	public int tileMarginX;

	// Token: 0x04002491 RID: 9361
	public int tileMarginY;

	// Token: 0x04002492 RID: 9362
	public int tileSpacingX;

	// Token: 0x04002493 RID: 9363
	public int tileSpacingY;

	// Token: 0x04002494 RID: 9364
	public tk2dSpriteSheetSource.SplitMethod splitMethod;

	// Token: 0x04002495 RID: 9365
	public int version;

	// Token: 0x04002496 RID: 9366
	public const int CURRENT_VERSION = 1;

	// Token: 0x04002497 RID: 9367
	public tk2dSpriteCollectionDefinition.ColliderType colliderType;

	// Token: 0x02000577 RID: 1399
	public enum Anchor
	{
		// Token: 0x04002499 RID: 9369
		UpperLeft,
		// Token: 0x0400249A RID: 9370
		UpperCenter,
		// Token: 0x0400249B RID: 9371
		UpperRight,
		// Token: 0x0400249C RID: 9372
		MiddleLeft,
		// Token: 0x0400249D RID: 9373
		MiddleCenter,
		// Token: 0x0400249E RID: 9374
		MiddleRight,
		// Token: 0x0400249F RID: 9375
		LowerLeft,
		// Token: 0x040024A0 RID: 9376
		LowerCenter,
		// Token: 0x040024A1 RID: 9377
		LowerRight
	}

	// Token: 0x02000578 RID: 1400
	public enum SplitMethod
	{
		// Token: 0x040024A3 RID: 9379
		UniformDivision
	}
}
