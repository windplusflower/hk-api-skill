using System;
using UnityEngine;

// Token: 0x0200058D RID: 1421
[Serializable]
public class tk2dBatchedSprite
{
	// Token: 0x1700040B RID: 1035
	// (get) Token: 0x06001F76 RID: 8054 RVA: 0x0009E154 File Offset: 0x0009C354
	// (set) Token: 0x06001F77 RID: 8055 RVA: 0x0009E161 File Offset: 0x0009C361
	public float BoxColliderOffsetZ
	{
		get
		{
			return this.colliderData.x;
		}
		set
		{
			this.colliderData.x = value;
		}
	}

	// Token: 0x1700040C RID: 1036
	// (get) Token: 0x06001F78 RID: 8056 RVA: 0x0009E16F File Offset: 0x0009C36F
	// (set) Token: 0x06001F79 RID: 8057 RVA: 0x0009E17C File Offset: 0x0009C37C
	public float BoxColliderExtentZ
	{
		get
		{
			return this.colliderData.y;
		}
		set
		{
			this.colliderData.y = value;
		}
	}

	// Token: 0x1700040D RID: 1037
	// (get) Token: 0x06001F7A RID: 8058 RVA: 0x0009E18A File Offset: 0x0009C38A
	// (set) Token: 0x06001F7B RID: 8059 RVA: 0x0009E192 File Offset: 0x0009C392
	public string FormattedText
	{
		get
		{
			return this.formattedText;
		}
		set
		{
			this.formattedText = value;
		}
	}

	// Token: 0x1700040E RID: 1038
	// (get) Token: 0x06001F7C RID: 8060 RVA: 0x0009E19B File Offset: 0x0009C39B
	// (set) Token: 0x06001F7D RID: 8061 RVA: 0x0009E1A3 File Offset: 0x0009C3A3
	public Vector2 ClippedSpriteRegionBottomLeft
	{
		get
		{
			return this.internalData0;
		}
		set
		{
			this.internalData0 = value;
		}
	}

	// Token: 0x1700040F RID: 1039
	// (get) Token: 0x06001F7E RID: 8062 RVA: 0x0009E1AC File Offset: 0x0009C3AC
	// (set) Token: 0x06001F7F RID: 8063 RVA: 0x0009E1B4 File Offset: 0x0009C3B4
	public Vector2 ClippedSpriteRegionTopRight
	{
		get
		{
			return this.internalData1;
		}
		set
		{
			this.internalData1 = value;
		}
	}

	// Token: 0x17000410 RID: 1040
	// (get) Token: 0x06001F80 RID: 8064 RVA: 0x0009E19B File Offset: 0x0009C39B
	// (set) Token: 0x06001F81 RID: 8065 RVA: 0x0009E1A3 File Offset: 0x0009C3A3
	public Vector2 SlicedSpriteBorderBottomLeft
	{
		get
		{
			return this.internalData0;
		}
		set
		{
			this.internalData0 = value;
		}
	}

	// Token: 0x17000411 RID: 1041
	// (get) Token: 0x06001F82 RID: 8066 RVA: 0x0009E1AC File Offset: 0x0009C3AC
	// (set) Token: 0x06001F83 RID: 8067 RVA: 0x0009E1B4 File Offset: 0x0009C3B4
	public Vector2 SlicedSpriteBorderTopRight
	{
		get
		{
			return this.internalData1;
		}
		set
		{
			this.internalData1 = value;
		}
	}

	// Token: 0x17000412 RID: 1042
	// (get) Token: 0x06001F84 RID: 8068 RVA: 0x0009E1BD File Offset: 0x0009C3BD
	// (set) Token: 0x06001F85 RID: 8069 RVA: 0x0009E1C5 File Offset: 0x0009C3C5
	public Vector2 Dimensions
	{
		get
		{
			return this.internalData2;
		}
		set
		{
			this.internalData2 = value;
		}
	}

	// Token: 0x17000413 RID: 1043
	// (get) Token: 0x06001F86 RID: 8070 RVA: 0x0009E1CE File Offset: 0x0009C3CE
	public bool IsDrawn
	{
		get
		{
			return this.type > tk2dBatchedSprite.Type.EmptyGameObject;
		}
	}

	// Token: 0x06001F87 RID: 8071 RVA: 0x0009E1D9 File Offset: 0x0009C3D9
	public bool CheckFlag(tk2dBatchedSprite.Flags mask)
	{
		return (this.flags & mask) > tk2dBatchedSprite.Flags.None;
	}

	// Token: 0x06001F88 RID: 8072 RVA: 0x0009E1E6 File Offset: 0x0009C3E6
	public void SetFlag(tk2dBatchedSprite.Flags mask, bool value)
	{
		if (value)
		{
			this.flags |= mask;
			return;
		}
		this.flags &= ~mask;
	}

	// Token: 0x17000414 RID: 1044
	// (get) Token: 0x06001F89 RID: 8073 RVA: 0x0009E209 File Offset: 0x0009C409
	// (set) Token: 0x06001F8A RID: 8074 RVA: 0x0009E211 File Offset: 0x0009C411
	public Vector3 CachedBoundsCenter
	{
		get
		{
			return this.cachedBoundsCenter;
		}
		set
		{
			this.cachedBoundsCenter = value;
		}
	}

	// Token: 0x17000415 RID: 1045
	// (get) Token: 0x06001F8B RID: 8075 RVA: 0x0009E21A File Offset: 0x0009C41A
	// (set) Token: 0x06001F8C RID: 8076 RVA: 0x0009E222 File Offset: 0x0009C422
	public Vector3 CachedBoundsExtents
	{
		get
		{
			return this.cachedBoundsExtents;
		}
		set
		{
			this.cachedBoundsExtents = value;
		}
	}

	// Token: 0x06001F8D RID: 8077 RVA: 0x0009E22B File Offset: 0x0009C42B
	public tk2dSpriteDefinition GetSpriteDefinition()
	{
		if (this.spriteCollection != null && this.spriteId != -1)
		{
			return this.spriteCollection.inst.spriteDefinitions[this.spriteId];
		}
		return null;
	}

	// Token: 0x06001F8E RID: 8078 RVA: 0x0009E260 File Offset: 0x0009C460
	public tk2dBatchedSprite()
	{
		this.type = tk2dBatchedSprite.Type.Sprite;
		this.name = "";
		this.parentId = -1;
		this.xRefId = -1;
		this.rotation = Quaternion.identity;
		this.position = Vector3.zero;
		this.localScale = Vector3.one;
		this.color = Color.white;
		this.baseScale = Vector3.one;
		this.colliderData = new Vector2(0f, 1f);
		this.formattedText = "";
		this.relativeMatrix = Matrix4x4.identity;
		this.cachedBoundsCenter = Vector3.zero;
		this.cachedBoundsExtents = Vector3.zero;
		base..ctor();
		this.parentId = -1;
	}

	// Token: 0x04002562 RID: 9570
	public tk2dBatchedSprite.Type type;

	// Token: 0x04002563 RID: 9571
	public string name;

	// Token: 0x04002564 RID: 9572
	public int parentId;

	// Token: 0x04002565 RID: 9573
	public int spriteId;

	// Token: 0x04002566 RID: 9574
	public int xRefId;

	// Token: 0x04002567 RID: 9575
	public tk2dSpriteCollectionData spriteCollection;

	// Token: 0x04002568 RID: 9576
	public Quaternion rotation;

	// Token: 0x04002569 RID: 9577
	public Vector3 position;

	// Token: 0x0400256A RID: 9578
	public Vector3 localScale;

	// Token: 0x0400256B RID: 9579
	public Color color;

	// Token: 0x0400256C RID: 9580
	public Vector3 baseScale;

	// Token: 0x0400256D RID: 9581
	public int renderLayer;

	// Token: 0x0400256E RID: 9582
	[SerializeField]
	private Vector2 internalData0;

	// Token: 0x0400256F RID: 9583
	[SerializeField]
	private Vector2 internalData1;

	// Token: 0x04002570 RID: 9584
	[SerializeField]
	private Vector2 internalData2;

	// Token: 0x04002571 RID: 9585
	[SerializeField]
	private Vector2 colliderData;

	// Token: 0x04002572 RID: 9586
	[SerializeField]
	private string formattedText;

	// Token: 0x04002573 RID: 9587
	[SerializeField]
	private tk2dBatchedSprite.Flags flags;

	// Token: 0x04002574 RID: 9588
	public tk2dBaseSprite.Anchor anchor;

	// Token: 0x04002575 RID: 9589
	public Matrix4x4 relativeMatrix;

	// Token: 0x04002576 RID: 9590
	private Vector3 cachedBoundsCenter;

	// Token: 0x04002577 RID: 9591
	private Vector3 cachedBoundsExtents;

	// Token: 0x0200058E RID: 1422
	public enum Type
	{
		// Token: 0x04002579 RID: 9593
		EmptyGameObject,
		// Token: 0x0400257A RID: 9594
		Sprite,
		// Token: 0x0400257B RID: 9595
		TiledSprite,
		// Token: 0x0400257C RID: 9596
		SlicedSprite,
		// Token: 0x0400257D RID: 9597
		ClippedSprite,
		// Token: 0x0400257E RID: 9598
		TextMesh
	}

	// Token: 0x0200058F RID: 1423
	[Flags]
	public enum Flags
	{
		// Token: 0x04002580 RID: 9600
		None = 0,
		// Token: 0x04002581 RID: 9601
		Sprite_CreateBoxCollider = 1,
		// Token: 0x04002582 RID: 9602
		SlicedSprite_BorderOnly = 2
	}
}
