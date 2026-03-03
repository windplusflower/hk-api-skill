using System;
using UnityEngine;

// Token: 0x02000593 RID: 1427
[AddComponentMenu("2D Toolkit/Sprite/tk2dTiledSprite")]
[RequireComponent(typeof(MeshRenderer))]
[RequireComponent(typeof(MeshFilter))]
[ExecuteInEditMode]
public class tk2dTiledSprite : tk2dBaseSprite
{
	// Token: 0x17000416 RID: 1046
	// (get) Token: 0x06001FA3 RID: 8099 RVA: 0x0009F963 File Offset: 0x0009DB63
	// (set) Token: 0x06001FA4 RID: 8100 RVA: 0x0009F96B File Offset: 0x0009DB6B
	public Vector2 dimensions
	{
		get
		{
			return this._dimensions;
		}
		set
		{
			if (value != this._dimensions)
			{
				this._dimensions = value;
				this.UpdateVertices();
				this.UpdateCollider();
			}
		}
	}

	// Token: 0x17000417 RID: 1047
	// (get) Token: 0x06001FA5 RID: 8101 RVA: 0x0009F98E File Offset: 0x0009DB8E
	// (set) Token: 0x06001FA6 RID: 8102 RVA: 0x0009F996 File Offset: 0x0009DB96
	public tk2dBaseSprite.Anchor anchor
	{
		get
		{
			return this._anchor;
		}
		set
		{
			if (value != this._anchor)
			{
				this._anchor = value;
				this.UpdateVertices();
				this.UpdateCollider();
			}
		}
	}

	// Token: 0x17000418 RID: 1048
	// (get) Token: 0x06001FA7 RID: 8103 RVA: 0x0009F9B4 File Offset: 0x0009DBB4
	// (set) Token: 0x06001FA8 RID: 8104 RVA: 0x0009F9BC File Offset: 0x0009DBBC
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

	// Token: 0x06001FA9 RID: 8105 RVA: 0x0009F9D4 File Offset: 0x0009DBD4
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
			if (this.boxCollider == null)
			{
				this.boxCollider = base.GetComponent<BoxCollider>();
			}
			if (this.boxCollider2D == null)
			{
				this.boxCollider2D = base.GetComponent<BoxCollider2D>();
			}
		}
	}

	// Token: 0x06001FAA RID: 8106 RVA: 0x0009FA85 File Offset: 0x0009DC85
	protected void OnDestroy()
	{
		if (this.mesh)
		{
			UnityEngine.Object.Destroy(this.mesh);
		}
	}

	// Token: 0x06001FAB RID: 8107 RVA: 0x0009FAA0 File Offset: 0x0009DCA0
	protected new void SetColors(Color32[] dest)
	{
		int numVertices;
		int num;
		tk2dSpriteGeomGen.GetTiledSpriteGeomDesc(out numVertices, out num, base.CurrentSprite, this.dimensions);
		tk2dSpriteGeomGen.SetSpriteColors(dest, 0, numVertices, this._color, this.collectionInst.premultipliedAlpha);
	}

	// Token: 0x06001FAC RID: 8108 RVA: 0x0009FADC File Offset: 0x0009DCDC
	public override void Build()
	{
		tk2dSpriteDefinition currentSprite = base.CurrentSprite;
		int num;
		int num2;
		tk2dSpriteGeomGen.GetTiledSpriteGeomDesc(out num, out num2, currentSprite, this.dimensions);
		if (this.meshUvs == null || this.meshUvs.Length != num)
		{
			this.meshUvs = new Vector2[num];
			this.meshVertices = new Vector3[num];
			this.meshColors = new Color32[num];
		}
		if (this.meshIndices == null || this.meshIndices.Length != num2)
		{
			this.meshIndices = new int[num2];
		}
		this.meshNormals = new Vector3[0];
		this.meshTangents = new Vector4[0];
		if (currentSprite.normals != null && currentSprite.normals.Length != 0)
		{
			this.meshNormals = new Vector3[num];
		}
		if (currentSprite.tangents != null && currentSprite.tangents.Length != 0)
		{
			this.meshTangents = new Vector4[num];
		}
		float colliderOffsetZ = (this.boxCollider != null) ? this.boxCollider.center.z : 0f;
		float colliderExtentZ = (this.boxCollider != null) ? (this.boxCollider.size.z * 0.5f) : 0.5f;
		tk2dSpriteGeomGen.SetTiledSpriteGeom(this.meshVertices, this.meshUvs, 0, out this.boundsCenter, out this.boundsExtents, currentSprite, this._scale, this.dimensions, this.anchor, colliderOffsetZ, colliderExtentZ);
		tk2dSpriteGeomGen.SetTiledSpriteIndices(this.meshIndices, 0, 0, currentSprite, this.dimensions);
		if (this.meshNormals.Length != 0 || this.meshTangents.Length != 0)
		{
			Vector3 pMin = new Vector3(currentSprite.positions[0].x * this.dimensions.x * currentSprite.texelSize.x * base.scale.x, currentSprite.positions[0].y * this.dimensions.y * currentSprite.texelSize.y * base.scale.y);
			Vector3 pMax = new Vector3(currentSprite.positions[3].x * this.dimensions.x * currentSprite.texelSize.x * base.scale.x, currentSprite.positions[3].y * this.dimensions.y * currentSprite.texelSize.y * base.scale.y);
			tk2dSpriteGeomGen.SetSpriteVertexNormals(this.meshVertices, pMin, pMax, currentSprite.normals, currentSprite.tangents, this.meshNormals, this.meshTangents);
		}
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
		this.mesh.triangles = this.meshIndices;
		this.mesh.RecalculateBounds();
		this.mesh.bounds = tk2dBaseSprite.AdjustedMeshBounds(this.mesh.bounds, this.renderLayer);
		base.GetComponent<MeshFilter>().mesh = this.mesh;
		this.UpdateCollider();
		this.UpdateMaterial();
	}

	// Token: 0x06001FAD RID: 8109 RVA: 0x0009FE5A File Offset: 0x0009E05A
	protected override void UpdateGeometry()
	{
		this.UpdateGeometryImpl();
	}

	// Token: 0x06001FAE RID: 8110 RVA: 0x0009FE62 File Offset: 0x0009E062
	protected override void UpdateColors()
	{
		this.UpdateColorsImpl();
	}

	// Token: 0x06001FAF RID: 8111 RVA: 0x0009FE5A File Offset: 0x0009E05A
	protected override void UpdateVertices()
	{
		this.UpdateGeometryImpl();
	}

	// Token: 0x06001FB0 RID: 8112 RVA: 0x0009FE6A File Offset: 0x0009E06A
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

	// Token: 0x06001FB1 RID: 8113 RVA: 0x0009FEA1 File Offset: 0x0009E0A1
	protected void UpdateGeometryImpl()
	{
		this.Build();
	}

	// Token: 0x06001FB2 RID: 8114 RVA: 0x0009FEAC File Offset: 0x0009E0AC
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

	// Token: 0x06001FB3 RID: 8115 RVA: 0x00097799 File Offset: 0x00095999
	protected override void CreateCollider()
	{
		this.UpdateCollider();
	}

	// Token: 0x06001FB4 RID: 8116 RVA: 0x0009FF64 File Offset: 0x0009E164
	protected override void UpdateMaterial()
	{
		Renderer component = base.GetComponent<Renderer>();
		if (component.sharedMaterial != this.collectionInst.spriteDefinitions[base.spriteId].materialInst)
		{
			component.material = this.collectionInst.spriteDefinitions[base.spriteId].materialInst;
		}
	}

	// Token: 0x06001FB5 RID: 8117 RVA: 0x00098631 File Offset: 0x00096831
	protected override int GetCurrentVertexCount()
	{
		return 16;
	}

	// Token: 0x06001FB6 RID: 8118 RVA: 0x0009FFBC File Offset: 0x0009E1BC
	public override void ReshapeBounds(Vector3 dMin, Vector3 dMax)
	{
		float num = 0.1f;
		tk2dSpriteDefinition currentSprite = base.CurrentSprite;
		Vector2 vector = new Vector2(this._dimensions.x * currentSprite.texelSize.x, this._dimensions.y * currentSprite.texelSize.y);
		Vector3 vector2 = new Vector3(vector.x * this._scale.x, vector.y * this._scale.y);
		Vector3 vector3 = Vector3.zero;
		switch (this._anchor)
		{
		case tk2dBaseSprite.Anchor.LowerLeft:
			vector3.Set(0f, 0f, 0f);
			break;
		case tk2dBaseSprite.Anchor.LowerCenter:
			vector3.Set(0.5f, 0f, 0f);
			break;
		case tk2dBaseSprite.Anchor.LowerRight:
			vector3.Set(1f, 0f, 0f);
			break;
		case tk2dBaseSprite.Anchor.MiddleLeft:
			vector3.Set(0f, 0.5f, 0f);
			break;
		case tk2dBaseSprite.Anchor.MiddleCenter:
			vector3.Set(0.5f, 0.5f, 0f);
			break;
		case tk2dBaseSprite.Anchor.MiddleRight:
			vector3.Set(1f, 0.5f, 0f);
			break;
		case tk2dBaseSprite.Anchor.UpperLeft:
			vector3.Set(0f, 1f, 0f);
			break;
		case tk2dBaseSprite.Anchor.UpperCenter:
			vector3.Set(0.5f, 1f, 0f);
			break;
		case tk2dBaseSprite.Anchor.UpperRight:
			vector3.Set(1f, 1f, 0f);
			break;
		}
		vector3 = Vector3.Scale(vector3, vector2) * -1f;
		Vector3 vector4 = vector2 + dMax - dMin;
		vector4.x /= vector.x;
		vector4.y /= vector.y;
		if (Mathf.Abs(vector.x * vector4.x) < currentSprite.texelSize.x * num && Mathf.Abs(vector4.x) < Mathf.Abs(this._scale.x))
		{
			dMin.x = 0f;
			vector4.x = this._scale.x;
		}
		if (Mathf.Abs(vector.y * vector4.y) < currentSprite.texelSize.y * num && Mathf.Abs(vector4.y) < Mathf.Abs(this._scale.y))
		{
			dMin.y = 0f;
			vector4.y = this._scale.y;
		}
		Vector2 vector5 = new Vector3(Mathf.Approximately(this._scale.x, 0f) ? 0f : (vector4.x / this._scale.x), Mathf.Approximately(this._scale.y, 0f) ? 0f : (vector4.y / this._scale.y));
		Vector3 b = new Vector3(vector3.x * vector5.x, vector3.y * vector5.y);
		Vector3 position = dMin + vector3 - b;
		position.z = 0f;
		base.transform.position = base.transform.TransformPoint(position);
		this.dimensions = new Vector2(this._dimensions.x * vector5.x, this._dimensions.y * vector5.y);
	}

	// Token: 0x06001FB7 RID: 8119 RVA: 0x000A0351 File Offset: 0x0009E551
	public tk2dTiledSprite()
	{
		this._dimensions = new Vector2(50f, 50f);
		this.boundsCenter = Vector3.zero;
		this.boundsExtents = Vector3.zero;
		base..ctor();
	}

	// Token: 0x04002593 RID: 9619
	private Mesh mesh;

	// Token: 0x04002594 RID: 9620
	private Vector2[] meshUvs;

	// Token: 0x04002595 RID: 9621
	private Vector3[] meshVertices;

	// Token: 0x04002596 RID: 9622
	private Color32[] meshColors;

	// Token: 0x04002597 RID: 9623
	private Vector3[] meshNormals;

	// Token: 0x04002598 RID: 9624
	private Vector4[] meshTangents;

	// Token: 0x04002599 RID: 9625
	private int[] meshIndices;

	// Token: 0x0400259A RID: 9626
	[SerializeField]
	private Vector2 _dimensions;

	// Token: 0x0400259B RID: 9627
	[SerializeField]
	private tk2dBaseSprite.Anchor _anchor;

	// Token: 0x0400259C RID: 9628
	[SerializeField]
	protected bool _createBoxCollider;

	// Token: 0x0400259D RID: 9629
	private Vector3 boundsCenter;

	// Token: 0x0400259E RID: 9630
	private Vector3 boundsExtents;
}
