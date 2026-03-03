using System;
using UnityEngine;

// Token: 0x0200055D RID: 1373
[AddComponentMenu("2D Toolkit/Sprite/tk2dClippedSprite")]
[RequireComponent(typeof(MeshRenderer))]
[RequireComponent(typeof(MeshFilter))]
[ExecuteInEditMode]
public class tk2dClippedSprite : tk2dBaseSprite
{
	// Token: 0x170003E0 RID: 992
	// (get) Token: 0x06001E6F RID: 7791 RVA: 0x00097128 File Offset: 0x00095328
	// (set) Token: 0x06001E70 RID: 7792 RVA: 0x0009718C File Offset: 0x0009538C
	public Rect ClipRect
	{
		get
		{
			this._clipRect.Set(this._clipBottomLeft.x, this._clipBottomLeft.y, this._clipTopRight.x - this._clipBottomLeft.x, this._clipTopRight.y - this._clipBottomLeft.y);
			return this._clipRect;
		}
		set
		{
			Vector2 vector = new Vector2(value.x, value.y);
			this.clipBottomLeft = vector;
			vector.x += value.width;
			vector.y += value.height;
			this.clipTopRight = vector;
		}
	}

	// Token: 0x170003E1 RID: 993
	// (get) Token: 0x06001E71 RID: 7793 RVA: 0x000971E0 File Offset: 0x000953E0
	// (set) Token: 0x06001E72 RID: 7794 RVA: 0x000971E8 File Offset: 0x000953E8
	public Vector2 clipBottomLeft
	{
		get
		{
			return this._clipBottomLeft;
		}
		set
		{
			if (value != this._clipBottomLeft)
			{
				this._clipBottomLeft = new Vector2(value.x, value.y);
				this.Build();
				this.UpdateCollider();
			}
		}
	}

	// Token: 0x170003E2 RID: 994
	// (get) Token: 0x06001E73 RID: 7795 RVA: 0x0009721B File Offset: 0x0009541B
	// (set) Token: 0x06001E74 RID: 7796 RVA: 0x00097223 File Offset: 0x00095423
	public Vector2 clipTopRight
	{
		get
		{
			return this._clipTopRight;
		}
		set
		{
			if (value != this._clipTopRight)
			{
				this._clipTopRight = new Vector2(value.x, value.y);
				this.Build();
				this.UpdateCollider();
			}
		}
	}

	// Token: 0x170003E3 RID: 995
	// (get) Token: 0x06001E75 RID: 7797 RVA: 0x00097256 File Offset: 0x00095456
	// (set) Token: 0x06001E76 RID: 7798 RVA: 0x0009725E File Offset: 0x0009545E
	public bool CreateBoxCollider
	{
		get
		{
			return this._createBoxCollider;
		}
		set
		{
			if (this._createBoxCollider != value)
			{
				this._createBoxCollider = value;
				this.UpdateCollider();
			}
		}
	}

	// Token: 0x06001E77 RID: 7799 RVA: 0x00097278 File Offset: 0x00095478
	private new void Awake()
	{
		base.Awake();
		this.mesh = new Mesh();
		this.mesh.MarkDynamic();
		this.mesh.hideFlags = HideFlags.DontSave;
		base.GetComponent<MeshFilter>().mesh = this.mesh;
		if (base.Collection)
		{
			if (this._spriteId < 0 || this._spriteId >= base.Collection.Count)
			{
				this._spriteId = 0;
			}
			this.Build();
		}
	}

	// Token: 0x06001E78 RID: 7800 RVA: 0x000972F5 File Offset: 0x000954F5
	protected void OnDestroy()
	{
		if (this.mesh)
		{
			UnityEngine.Object.Destroy(this.mesh);
		}
	}

	// Token: 0x06001E79 RID: 7801 RVA: 0x0009730F File Offset: 0x0009550F
	protected new void SetColors(Color32[] dest)
	{
		if (base.CurrentSprite.positions.Length == 4)
		{
			tk2dSpriteGeomGen.SetSpriteColors(dest, 0, 4, this._color, this.collectionInst.premultipliedAlpha);
		}
	}

	// Token: 0x06001E7A RID: 7802 RVA: 0x0009733C File Offset: 0x0009553C
	protected void SetGeometry(Vector3[] vertices, Vector2[] uvs)
	{
		tk2dSpriteDefinition currentSprite = base.CurrentSprite;
		float colliderOffsetZ = (this.boxCollider != null) ? this.boxCollider.center.z : 0f;
		float colliderExtentZ = (this.boxCollider != null) ? (this.boxCollider.size.z * 0.5f) : 0.5f;
		tk2dSpriteGeomGen.SetClippedSpriteGeom(this.meshVertices, this.meshUvs, 0, out this.boundsCenter, out this.boundsExtents, currentSprite, this._scale, this._clipBottomLeft, this._clipTopRight, colliderOffsetZ, colliderExtentZ);
		if (this.meshNormals.Length != 0 || this.meshTangents.Length != 0)
		{
			tk2dSpriteGeomGen.SetSpriteVertexNormals(this.meshVertices, this.meshVertices[0], this.meshVertices[3], currentSprite.normals, currentSprite.tangents, this.meshNormals, this.meshTangents);
		}
		if (currentSprite.positions.Length != 4 || currentSprite.complexGeometry)
		{
			for (int i = 0; i < vertices.Length; i++)
			{
				vertices[i] = Vector3.zero;
			}
		}
	}

	// Token: 0x06001E7B RID: 7803 RVA: 0x00097450 File Offset: 0x00095650
	public override void Build()
	{
		tk2dSpriteDefinition currentSprite = base.CurrentSprite;
		this.meshUvs = new Vector2[4];
		this.meshVertices = new Vector3[4];
		this.meshColors = new Color32[4];
		this.meshNormals = new Vector3[0];
		this.meshTangents = new Vector4[0];
		if (currentSprite.normals != null && currentSprite.normals.Length != 0)
		{
			this.meshNormals = new Vector3[4];
		}
		if (currentSprite.tangents != null && currentSprite.tangents.Length != 0)
		{
			this.meshTangents = new Vector4[4];
		}
		this.SetGeometry(this.meshVertices, this.meshUvs);
		this.SetColors(this.meshColors);
		if (this.mesh == null)
		{
			this.mesh = new Mesh();
			this.mesh.MarkDynamic();
			this.mesh.hideFlags = HideFlags.DontSave;
		}
		else
		{
			this.mesh.Clear();
		}
		this.mesh.vertices = this.meshVertices;
		this.mesh.colors32 = this.meshColors;
		this.mesh.uv = this.meshUvs;
		this.mesh.normals = this.meshNormals;
		this.mesh.tangents = this.meshTangents;
		int[] array = new int[6];
		tk2dSpriteGeomGen.SetClippedSpriteIndices(array, 0, 0, base.CurrentSprite);
		this.mesh.triangles = array;
		this.mesh.RecalculateBounds();
		this.mesh.bounds = tk2dBaseSprite.AdjustedMeshBounds(this.mesh.bounds, this.renderLayer);
		base.GetComponent<MeshFilter>().mesh = this.mesh;
		this.UpdateCollider();
		this.UpdateMaterial();
	}

	// Token: 0x06001E7C RID: 7804 RVA: 0x000975F5 File Offset: 0x000957F5
	protected override void UpdateGeometry()
	{
		this.UpdateGeometryImpl();
	}

	// Token: 0x06001E7D RID: 7805 RVA: 0x000975FD File Offset: 0x000957FD
	protected override void UpdateColors()
	{
		this.UpdateColorsImpl();
	}

	// Token: 0x06001E7E RID: 7806 RVA: 0x000975F5 File Offset: 0x000957F5
	protected override void UpdateVertices()
	{
		this.UpdateGeometryImpl();
	}

	// Token: 0x06001E7F RID: 7807 RVA: 0x00097605 File Offset: 0x00095805
	protected void UpdateColorsImpl()
	{
		if (this.meshColors == null || this.meshColors.Length == 0)
		{
			this.Build();
			return;
		}
		this.SetColors(this.meshColors);
		this.mesh.colors32 = this.meshColors;
	}

	// Token: 0x06001E80 RID: 7808 RVA: 0x0009763C File Offset: 0x0009583C
	protected void UpdateGeometryImpl()
	{
		if (this.meshVertices == null || this.meshVertices.Length == 0)
		{
			this.Build();
			return;
		}
		this.SetGeometry(this.meshVertices, this.meshUvs);
		this.mesh.vertices = this.meshVertices;
		this.mesh.uv = this.meshUvs;
		this.mesh.normals = this.meshNormals;
		this.mesh.tangents = this.meshTangents;
		this.mesh.RecalculateBounds();
		this.mesh.bounds = tk2dBaseSprite.AdjustedMeshBounds(this.mesh.bounds, this.renderLayer);
	}

	// Token: 0x06001E81 RID: 7809 RVA: 0x000976E4 File Offset: 0x000958E4
	protected override void UpdateCollider()
	{
		if (this.CreateBoxCollider)
		{
			if (base.CurrentSprite.physicsEngine == tk2dSpriteDefinition.PhysicsEngine.Physics3D)
			{
				if (this.boxCollider != null)
				{
					this.boxCollider.size = 2f * this.boundsExtents;
					this.boxCollider.center = this.boundsCenter;
					return;
				}
			}
			else if (base.CurrentSprite.physicsEngine == tk2dSpriteDefinition.PhysicsEngine.Physics2D && this.boxCollider2D != null)
			{
				this.boxCollider2D.size = 2f * this.boundsExtents;
				this.boxCollider2D.offset = this.boundsCenter;
			}
		}
	}

	// Token: 0x06001E82 RID: 7810 RVA: 0x00097799 File Offset: 0x00095999
	protected override void CreateCollider()
	{
		this.UpdateCollider();
	}

	// Token: 0x06001E83 RID: 7811 RVA: 0x000977A4 File Offset: 0x000959A4
	protected override void UpdateMaterial()
	{
		Renderer component = base.GetComponent<Renderer>();
		if (component.sharedMaterial != this.collectionInst.spriteDefinitions[base.spriteId].materialInst)
		{
			component.material = this.collectionInst.spriteDefinitions[base.spriteId].materialInst;
		}
	}

	// Token: 0x06001E84 RID: 7812 RVA: 0x000977F9 File Offset: 0x000959F9
	protected override int GetCurrentVertexCount()
	{
		return 4;
	}

	// Token: 0x06001E85 RID: 7813 RVA: 0x000977FC File Offset: 0x000959FC
	public override void ReshapeBounds(Vector3 dMin, Vector3 dMax)
	{
		float num = 0.1f;
		tk2dSpriteDefinition currentSprite = base.CurrentSprite;
		Vector3 vector = new Vector3(Mathf.Abs(this._scale.x), Mathf.Abs(this._scale.y), Mathf.Abs(this._scale.z));
		Vector3 vector2 = Vector3.Scale(currentSprite.untrimmedBoundsData[0], this._scale) - 0.5f * Vector3.Scale(currentSprite.untrimmedBoundsData[1], vector);
		Vector3 vector3 = Vector3.Scale(currentSprite.untrimmedBoundsData[1], vector) + dMax - dMin;
		vector3.x /= currentSprite.untrimmedBoundsData[1].x;
		vector3.y /= currentSprite.untrimmedBoundsData[1].y;
		if (currentSprite.untrimmedBoundsData[1].x * vector3.x < currentSprite.texelSize.x * num && vector3.x < vector.x)
		{
			dMin.x = 0f;
			vector3.x = vector.x;
		}
		if (currentSprite.untrimmedBoundsData[1].y * vector3.y < currentSprite.texelSize.y * num && vector3.y < vector.y)
		{
			dMin.y = 0f;
			vector3.y = vector.y;
		}
		Vector2 vector4 = new Vector3(Mathf.Approximately(vector.x, 0f) ? 0f : (vector3.x / vector.x), Mathf.Approximately(vector.y, 0f) ? 0f : (vector3.y / vector.y));
		Vector3 b = new Vector3(vector2.x * vector4.x, vector2.y * vector4.y);
		Vector3 position = dMin + vector2 - b;
		position.z = 0f;
		base.transform.position = base.transform.TransformPoint(position);
		base.scale = new Vector3(this._scale.x * vector4.x, this._scale.y * vector4.y, this._scale.z);
	}

	// Token: 0x06001E86 RID: 7814 RVA: 0x00097A6C File Offset: 0x00095C6C
	public tk2dClippedSprite()
	{
		this._clipBottomLeft = new Vector2(0f, 0f);
		this._clipTopRight = new Vector2(1f, 1f);
		this._clipRect = new Rect(0f, 0f, 0f, 0f);
		this.boundsCenter = Vector3.zero;
		this.boundsExtents = Vector3.zero;
		base..ctor();
	}

	// Token: 0x040023CB RID: 9163
	private Mesh mesh;

	// Token: 0x040023CC RID: 9164
	private Vector2[] meshUvs;

	// Token: 0x040023CD RID: 9165
	private Vector3[] meshVertices;

	// Token: 0x040023CE RID: 9166
	private Color32[] meshColors;

	// Token: 0x040023CF RID: 9167
	private Vector3[] meshNormals;

	// Token: 0x040023D0 RID: 9168
	private Vector4[] meshTangents;

	// Token: 0x040023D1 RID: 9169
	private int[] meshIndices;

	// Token: 0x040023D2 RID: 9170
	public Vector2 _clipBottomLeft;

	// Token: 0x040023D3 RID: 9171
	public Vector2 _clipTopRight;

	// Token: 0x040023D4 RID: 9172
	private Rect _clipRect;

	// Token: 0x040023D5 RID: 9173
	[SerializeField]
	protected bool _createBoxCollider;

	// Token: 0x040023D6 RID: 9174
	private Vector3 boundsCenter;

	// Token: 0x040023D7 RID: 9175
	private Vector3 boundsExtents;
}
