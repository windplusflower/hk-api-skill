using System;
using System.Collections.Generic;
using UnityEngine;

// Token: 0x0200056B RID: 1387
[Serializable]
public class tk2dSpriteCollectionDefinition
{
	// Token: 0x06001F13 RID: 7955 RVA: 0x0009A5E0 File Offset: 0x000987E0
	public void CopyFrom(tk2dSpriteCollectionDefinition src)
	{
		this.name = src.name;
		this.disableTrimming = src.disableTrimming;
		this.additive = src.additive;
		this.scale = src.scale;
		this.texture = src.texture;
		this.materialId = src.materialId;
		this.anchor = src.anchor;
		this.anchorX = src.anchorX;
		this.anchorY = src.anchorY;
		this.overrideMesh = src.overrideMesh;
		this.doubleSidedSprite = src.doubleSidedSprite;
		this.customSpriteGeometry = src.customSpriteGeometry;
		this.geometryIslands = src.geometryIslands;
		this.dice = src.dice;
		this.diceUnitX = src.diceUnitX;
		this.diceUnitY = src.diceUnitY;
		this.diceFilter = src.diceFilter;
		this.pad = src.pad;
		this.source = src.source;
		this.fromSpriteSheet = src.fromSpriteSheet;
		this.hasSpriteSheetId = src.hasSpriteSheetId;
		this.spriteSheetX = src.spriteSheetX;
		this.spriteSheetY = src.spriteSheetY;
		this.spriteSheetId = src.spriteSheetId;
		this.extractRegion = src.extractRegion;
		this.regionX = src.regionX;
		this.regionY = src.regionY;
		this.regionW = src.regionW;
		this.regionH = src.regionH;
		this.regionId = src.regionId;
		this.colliderType = src.colliderType;
		this.boxColliderMin = src.boxColliderMin;
		this.boxColliderMax = src.boxColliderMax;
		this.polyColliderCap = src.polyColliderCap;
		this.colliderColor = src.colliderColor;
		this.colliderConvex = src.colliderConvex;
		this.colliderSmoothSphereCollisions = src.colliderSmoothSphereCollisions;
		this.extraPadding = src.extraPadding;
		this.colliderData = new List<tk2dSpriteCollectionDefinition.ColliderData>(src.colliderData.Count);
		foreach (tk2dSpriteCollectionDefinition.ColliderData src2 in src.colliderData)
		{
			tk2dSpriteCollectionDefinition.ColliderData colliderData = new tk2dSpriteCollectionDefinition.ColliderData();
			colliderData.CopyFrom(src2);
			this.colliderData.Add(colliderData);
		}
		if (src.polyColliderIslands != null)
		{
			this.polyColliderIslands = new tk2dSpriteColliderIsland[src.polyColliderIslands.Length];
			for (int i = 0; i < this.polyColliderIslands.Length; i++)
			{
				this.polyColliderIslands[i] = new tk2dSpriteColliderIsland();
				this.polyColliderIslands[i].CopyFrom(src.polyColliderIslands[i]);
			}
		}
		else
		{
			this.polyColliderIslands = new tk2dSpriteColliderIsland[0];
		}
		if (src.geometryIslands != null)
		{
			this.geometryIslands = new tk2dSpriteColliderIsland[src.geometryIslands.Length];
			for (int j = 0; j < this.geometryIslands.Length; j++)
			{
				this.geometryIslands[j] = new tk2dSpriteColliderIsland();
				this.geometryIslands[j].CopyFrom(src.geometryIslands[j]);
			}
		}
		else
		{
			this.geometryIslands = new tk2dSpriteColliderIsland[0];
		}
		this.attachPoints = new List<tk2dSpriteDefinition.AttachPoint>(src.attachPoints.Count);
		foreach (tk2dSpriteDefinition.AttachPoint src3 in src.attachPoints)
		{
			tk2dSpriteDefinition.AttachPoint attachPoint = new tk2dSpriteDefinition.AttachPoint();
			attachPoint.CopyFrom(src3);
			this.attachPoints.Add(attachPoint);
		}
	}

	// Token: 0x06001F14 RID: 7956 RVA: 0x0009A958 File Offset: 0x00098B58
	public void Clear()
	{
		tk2dSpriteCollectionDefinition src = new tk2dSpriteCollectionDefinition();
		this.CopyFrom(src);
	}

	// Token: 0x06001F15 RID: 7957 RVA: 0x0009A974 File Offset: 0x00098B74
	public bool CompareTo(tk2dSpriteCollectionDefinition src)
	{
		if (this.name != src.name)
		{
			return false;
		}
		if (this.additive != src.additive)
		{
			return false;
		}
		if (this.scale != src.scale)
		{
			return false;
		}
		if (this.texture != src.texture)
		{
			return false;
		}
		if (this.materialId != src.materialId)
		{
			return false;
		}
		if (this.anchor != src.anchor)
		{
			return false;
		}
		if (this.anchorX != src.anchorX)
		{
			return false;
		}
		if (this.anchorY != src.anchorY)
		{
			return false;
		}
		if (this.overrideMesh != src.overrideMesh)
		{
			return false;
		}
		if (this.dice != src.dice)
		{
			return false;
		}
		if (this.diceUnitX != src.diceUnitX)
		{
			return false;
		}
		if (this.diceUnitY != src.diceUnitY)
		{
			return false;
		}
		if (this.diceFilter != src.diceFilter)
		{
			return false;
		}
		if (this.pad != src.pad)
		{
			return false;
		}
		if (this.extraPadding != src.extraPadding)
		{
			return false;
		}
		if (this.doubleSidedSprite != src.doubleSidedSprite)
		{
			return false;
		}
		if (this.customSpriteGeometry != src.customSpriteGeometry)
		{
			return false;
		}
		if (this.geometryIslands != src.geometryIslands)
		{
			return false;
		}
		if (this.geometryIslands != null && src.geometryIslands != null)
		{
			if (this.geometryIslands.Length != src.geometryIslands.Length)
			{
				return false;
			}
			for (int i = 0; i < this.geometryIslands.Length; i++)
			{
				if (!this.geometryIslands[i].CompareTo(src.geometryIslands[i]))
				{
					return false;
				}
			}
		}
		if (this.source != src.source)
		{
			return false;
		}
		if (this.fromSpriteSheet != src.fromSpriteSheet)
		{
			return false;
		}
		if (this.hasSpriteSheetId != src.hasSpriteSheetId)
		{
			return false;
		}
		if (this.spriteSheetId != src.spriteSheetId)
		{
			return false;
		}
		if (this.spriteSheetX != src.spriteSheetX)
		{
			return false;
		}
		if (this.spriteSheetY != src.spriteSheetY)
		{
			return false;
		}
		if (this.extractRegion != src.extractRegion)
		{
			return false;
		}
		if (this.regionX != src.regionX)
		{
			return false;
		}
		if (this.regionY != src.regionY)
		{
			return false;
		}
		if (this.regionW != src.regionW)
		{
			return false;
		}
		if (this.regionH != src.regionH)
		{
			return false;
		}
		if (this.regionId != src.regionId)
		{
			return false;
		}
		if (this.colliderType != src.colliderType)
		{
			return false;
		}
		if (this.boxColliderMin != src.boxColliderMin)
		{
			return false;
		}
		if (this.boxColliderMax != src.boxColliderMax)
		{
			return false;
		}
		if (this.polyColliderIslands != src.polyColliderIslands)
		{
			return false;
		}
		if (this.polyColliderIslands != null && src.polyColliderIslands != null)
		{
			if (this.polyColliderIslands.Length != src.polyColliderIslands.Length)
			{
				return false;
			}
			for (int j = 0; j < this.polyColliderIslands.Length; j++)
			{
				if (!this.polyColliderIslands[j].CompareTo(src.polyColliderIslands[j]))
				{
					return false;
				}
			}
		}
		if (this.colliderData.Count != src.colliderData.Count)
		{
			return false;
		}
		for (int k = 0; k < this.colliderData.Count; k++)
		{
			if (!this.colliderData[k].CompareTo(src.colliderData[k]))
			{
				return false;
			}
		}
		if (this.polyColliderCap != src.polyColliderCap)
		{
			return false;
		}
		if (this.colliderColor != src.colliderColor)
		{
			return false;
		}
		if (this.colliderSmoothSphereCollisions != src.colliderSmoothSphereCollisions)
		{
			return false;
		}
		if (this.colliderConvex != src.colliderConvex)
		{
			return false;
		}
		if (this.attachPoints.Count != src.attachPoints.Count)
		{
			return false;
		}
		for (int l = 0; l < this.attachPoints.Count; l++)
		{
			if (!this.attachPoints[l].CompareTo(src.attachPoints[l]))
			{
				return false;
			}
		}
		return true;
	}

	// Token: 0x06001F16 RID: 7958 RVA: 0x0009AD44 File Offset: 0x00098F44
	public tk2dSpriteCollectionDefinition()
	{
		this.name = "";
		this.scale = new Vector3(1f, 1f, 1f);
		this.anchor = tk2dSpriteCollectionDefinition.Anchor.MiddleCenter;
		this.geometryIslands = new tk2dSpriteColliderIsland[0];
		this.diceUnitX = 64;
		this.diceUnitY = 64;
		this.colliderData = new List<tk2dSpriteCollectionDefinition.ColliderData>();
		this.polyColliderCap = tk2dSpriteCollectionDefinition.PolygonColliderCap.FrontAndBack;
		this.attachPoints = new List<tk2dSpriteDefinition.AttachPoint>();
		base..ctor();
	}

	// Token: 0x04002423 RID: 9251
	public string name;

	// Token: 0x04002424 RID: 9252
	public bool disableTrimming;

	// Token: 0x04002425 RID: 9253
	public bool additive;

	// Token: 0x04002426 RID: 9254
	public Vector3 scale;

	// Token: 0x04002427 RID: 9255
	public Texture2D texture;

	// Token: 0x04002428 RID: 9256
	[NonSerialized]
	public Texture2D thumbnailTexture;

	// Token: 0x04002429 RID: 9257
	public int materialId;

	// Token: 0x0400242A RID: 9258
	public tk2dSpriteCollectionDefinition.Anchor anchor;

	// Token: 0x0400242B RID: 9259
	public float anchorX;

	// Token: 0x0400242C RID: 9260
	public float anchorY;

	// Token: 0x0400242D RID: 9261
	public UnityEngine.Object overrideMesh;

	// Token: 0x0400242E RID: 9262
	public bool doubleSidedSprite;

	// Token: 0x0400242F RID: 9263
	public bool customSpriteGeometry;

	// Token: 0x04002430 RID: 9264
	public tk2dSpriteColliderIsland[] geometryIslands;

	// Token: 0x04002431 RID: 9265
	public bool dice;

	// Token: 0x04002432 RID: 9266
	public int diceUnitX;

	// Token: 0x04002433 RID: 9267
	public int diceUnitY;

	// Token: 0x04002434 RID: 9268
	public tk2dSpriteCollectionDefinition.DiceFilter diceFilter;

	// Token: 0x04002435 RID: 9269
	public tk2dSpriteCollectionDefinition.Pad pad;

	// Token: 0x04002436 RID: 9270
	public int extraPadding;

	// Token: 0x04002437 RID: 9271
	public tk2dSpriteCollectionDefinition.Source source;

	// Token: 0x04002438 RID: 9272
	public bool fromSpriteSheet;

	// Token: 0x04002439 RID: 9273
	public bool hasSpriteSheetId;

	// Token: 0x0400243A RID: 9274
	public int spriteSheetId;

	// Token: 0x0400243B RID: 9275
	public int spriteSheetX;

	// Token: 0x0400243C RID: 9276
	public int spriteSheetY;

	// Token: 0x0400243D RID: 9277
	public bool extractRegion;

	// Token: 0x0400243E RID: 9278
	public int regionX;

	// Token: 0x0400243F RID: 9279
	public int regionY;

	// Token: 0x04002440 RID: 9280
	public int regionW;

	// Token: 0x04002441 RID: 9281
	public int regionH;

	// Token: 0x04002442 RID: 9282
	public int regionId;

	// Token: 0x04002443 RID: 9283
	public tk2dSpriteCollectionDefinition.ColliderType colliderType;

	// Token: 0x04002444 RID: 9284
	public List<tk2dSpriteCollectionDefinition.ColliderData> colliderData;

	// Token: 0x04002445 RID: 9285
	public Vector2 boxColliderMin;

	// Token: 0x04002446 RID: 9286
	public Vector2 boxColliderMax;

	// Token: 0x04002447 RID: 9287
	public tk2dSpriteColliderIsland[] polyColliderIslands;

	// Token: 0x04002448 RID: 9288
	public tk2dSpriteCollectionDefinition.PolygonColliderCap polyColliderCap;

	// Token: 0x04002449 RID: 9289
	public bool colliderConvex;

	// Token: 0x0400244A RID: 9290
	public bool colliderSmoothSphereCollisions;

	// Token: 0x0400244B RID: 9291
	public tk2dSpriteCollectionDefinition.ColliderColor colliderColor;

	// Token: 0x0400244C RID: 9292
	public List<tk2dSpriteDefinition.AttachPoint> attachPoints;

	// Token: 0x0200056C RID: 1388
	public enum Anchor
	{
		// Token: 0x0400244E RID: 9294
		UpperLeft,
		// Token: 0x0400244F RID: 9295
		UpperCenter,
		// Token: 0x04002450 RID: 9296
		UpperRight,
		// Token: 0x04002451 RID: 9297
		MiddleLeft,
		// Token: 0x04002452 RID: 9298
		MiddleCenter,
		// Token: 0x04002453 RID: 9299
		MiddleRight,
		// Token: 0x04002454 RID: 9300
		LowerLeft,
		// Token: 0x04002455 RID: 9301
		LowerCenter,
		// Token: 0x04002456 RID: 9302
		LowerRight,
		// Token: 0x04002457 RID: 9303
		Custom
	}

	// Token: 0x0200056D RID: 1389
	public enum Pad
	{
		// Token: 0x04002459 RID: 9305
		Default,
		// Token: 0x0400245A RID: 9306
		BlackZeroAlpha,
		// Token: 0x0400245B RID: 9307
		Extend,
		// Token: 0x0400245C RID: 9308
		TileXY,
		// Token: 0x0400245D RID: 9309
		TileX,
		// Token: 0x0400245E RID: 9310
		TileY
	}

	// Token: 0x0200056E RID: 1390
	public enum ColliderType
	{
		// Token: 0x04002460 RID: 9312
		UserDefined,
		// Token: 0x04002461 RID: 9313
		ForceNone,
		// Token: 0x04002462 RID: 9314
		BoxTrimmed,
		// Token: 0x04002463 RID: 9315
		BoxCustom,
		// Token: 0x04002464 RID: 9316
		Polygon,
		// Token: 0x04002465 RID: 9317
		Advanced
	}

	// Token: 0x0200056F RID: 1391
	public enum PolygonColliderCap
	{
		// Token: 0x04002467 RID: 9319
		None,
		// Token: 0x04002468 RID: 9320
		FrontAndBack,
		// Token: 0x04002469 RID: 9321
		Front,
		// Token: 0x0400246A RID: 9322
		Back
	}

	// Token: 0x02000570 RID: 1392
	public enum ColliderColor
	{
		// Token: 0x0400246C RID: 9324
		Default,
		// Token: 0x0400246D RID: 9325
		Red,
		// Token: 0x0400246E RID: 9326
		White,
		// Token: 0x0400246F RID: 9327
		Black
	}

	// Token: 0x02000571 RID: 1393
	public enum Source
	{
		// Token: 0x04002471 RID: 9329
		Sprite,
		// Token: 0x04002472 RID: 9330
		SpriteSheet,
		// Token: 0x04002473 RID: 9331
		Font
	}

	// Token: 0x02000572 RID: 1394
	public enum DiceFilter
	{
		// Token: 0x04002475 RID: 9333
		Complete,
		// Token: 0x04002476 RID: 9334
		SolidOnly,
		// Token: 0x04002477 RID: 9335
		TransparentOnly
	}

	// Token: 0x02000573 RID: 1395
	[Serializable]
	public class ColliderData
	{
		// Token: 0x06001F17 RID: 7959 RVA: 0x0009ADBC File Offset: 0x00098FBC
		public void CopyFrom(tk2dSpriteCollectionDefinition.ColliderData src)
		{
			this.name = src.name;
			this.type = src.type;
			this.origin = src.origin;
			this.size = src.size;
			this.angle = src.angle;
		}

		// Token: 0x06001F18 RID: 7960 RVA: 0x0009ADFC File Offset: 0x00098FFC
		public bool CompareTo(tk2dSpriteCollectionDefinition.ColliderData src)
		{
			return this.name == src.name && this.type == src.type && this.origin == src.origin && this.size == src.size && this.angle == src.angle;
		}

		// Token: 0x06001F19 RID: 7961 RVA: 0x0009AE60 File Offset: 0x00099060
		public ColliderData()
		{
			this.name = "";
			this.origin = Vector3.zero;
			this.size = Vector3.zero;
			base..ctor();
		}

		// Token: 0x04002478 RID: 9336
		public string name;

		// Token: 0x04002479 RID: 9337
		public tk2dSpriteCollectionDefinition.ColliderData.Type type;

		// Token: 0x0400247A RID: 9338
		public Vector2 origin;

		// Token: 0x0400247B RID: 9339
		public Vector2 size;

		// Token: 0x0400247C RID: 9340
		public float angle;

		// Token: 0x02000574 RID: 1396
		public enum Type
		{
			// Token: 0x0400247E RID: 9342
			Box,
			// Token: 0x0400247F RID: 9343
			Circle
		}
	}
}
