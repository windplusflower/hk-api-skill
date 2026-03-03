using System;
using UnityEngine;

// Token: 0x02000560 RID: 1376
[AddComponentMenu("2D Toolkit/Sprite/tk2dSlicedSprite")]
[RequireComponent(typeof(MeshRenderer))]
[RequireComponent(typeof(MeshFilter))]
[ExecuteInEditMode]
public class tk2dSlicedSprite : tk2dBaseSprite
{
	// Token: 0x170003E6 RID: 998
	// (get) Token: 0x06001E91 RID: 7825 RVA: 0x00097C5E File Offset: 0x00095E5E
	// (set) Token: 0x06001E92 RID: 7826 RVA: 0x00097C66 File Offset: 0x00095E66
	public bool BorderOnly
	{
		get
		{
			return this._borderOnly;
		}
		set
		{
			if (value != this._borderOnly)
			{
				this._borderOnly = value;
				this.UpdateIndices();
			}
		}
	}

	// Token: 0x170003E7 RID: 999
	// (get) Token: 0x06001E93 RID: 7827 RVA: 0x00097C7E File Offset: 0x00095E7E
	// (set) Token: 0x06001E94 RID: 7828 RVA: 0x00097C86 File Offset: 0x00095E86
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

	// Token: 0x170003E8 RID: 1000
	// (get) Token: 0x06001E95 RID: 7829 RVA: 0x00097CA9 File Offset: 0x00095EA9
	// (set) Token: 0x06001E96 RID: 7830 RVA: 0x00097CB1 File Offset: 0x00095EB1
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

	// Token: 0x06001E97 RID: 7831 RVA: 0x00097CD0 File Offset: 0x00095ED0
	public void SetBorder(float left, float bottom, float right, float top)
	{
		if (this.borderLeft != left || this.borderBottom != bottom || this.borderRight != right || this.borderTop != top)
		{
			this.borderLeft = left;
			this.borderBottom = bottom;
			this.borderRight = right;
			this.borderTop = top;
			this.UpdateVertices();
		}
	}

	// Token: 0x170003E9 RID: 1001
	// (get) Token: 0x06001E98 RID: 7832 RVA: 0x00097D25 File Offset: 0x00095F25
	// (set) Token: 0x06001E99 RID: 7833 RVA: 0x00097D2D File Offset: 0x00095F2D
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

	// Token: 0x06001E9A RID: 7834 RVA: 0x00097D48 File Offset: 0x00095F48
	private new void Awake()
	{
		base.Awake();
		this.mesh = new Mesh();
		this.mesh.MarkDynamic();
		this.mesh.hideFlags = HideFlags.DontSave;
		base.GetComponent<MeshFilter>().mesh = this.mesh;
		if (this.boxCollider == null)
		{
			this.boxCollider = base.GetComponent<BoxCollider>();
		}
		if (this.boxCollider2D == null)
		{
			this.boxCollider2D = base.GetComponent<BoxCollider2D>();
		}
		if (base.Collection)
		{
			if (this._spriteId < 0 || this._spriteId >= base.Collection.Count)
			{
				this._spriteId = 0;
			}
			this.Build();
		}
	}

	// Token: 0x06001E9B RID: 7835 RVA: 0x00097DF9 File Offset: 0x00095FF9
	protected void OnDestroy()
	{
		if (this.mesh)
		{
			UnityEngine.Object.Destroy(this.mesh);
		}
	}

	// Token: 0x06001E9C RID: 7836 RVA: 0x00097E13 File Offset: 0x00096013
	protected new void SetColors(Color32[] dest)
	{
		tk2dSpriteGeomGen.SetSpriteColors(dest, 0, 16, this._color, this.collectionInst.premultipliedAlpha);
	}

	// Token: 0x06001E9D RID: 7837 RVA: 0x00097E30 File Offset: 0x00096030
	protected void SetGeometry(Vector3[] vertices, Vector2[] uvs)
	{
		tk2dSpriteDefinition currentSprite = base.CurrentSprite;
		float colliderOffsetZ = (this.boxCollider != null) ? this.boxCollider.center.z : 0f;
		float colliderExtentZ = (this.boxCollider != null) ? (this.boxCollider.size.z * 0.5f) : 0.5f;
		tk2dSpriteGeomGen.SetSlicedSpriteGeom(this.meshVertices, this.meshUvs, 0, out this.boundsCenter, out this.boundsExtents, currentSprite, this._scale, this.dimensions, new Vector2(this.borderLeft, this.borderBottom), new Vector2(this.borderRight, this.borderTop), this.anchor, colliderOffsetZ, colliderExtentZ);
		if (this.meshNormals.Length != 0 || this.meshTangents.Length != 0)
		{
			tk2dSpriteGeomGen.SetSpriteVertexNormals(this.meshVertices, this.meshVertices[0], this.meshVertices[15], currentSprite.normals, currentSprite.tangents, this.meshNormals, this.meshTangents);
		}
		if (currentSprite.positions.Length != 4 || currentSprite.complexGeometry)
		{
			for (int i = 0; i < vertices.Length; i++)
			{
				vertices[i] = Vector3.zero;
			}
		}
	}

	// Token: 0x06001E9E RID: 7838 RVA: 0x00097F68 File Offset: 0x00096168
	private void SetIndices()
	{
		int num = this._borderOnly ? 48 : 54;
		this.meshIndices = new int[num];
		tk2dSpriteGeomGen.SetSlicedSpriteIndices(this.meshIndices, 0, 0, base.CurrentSprite, this._borderOnly);
	}

	// Token: 0x06001E9F RID: 7839 RVA: 0x00097FA9 File Offset: 0x000961A9
	private bool NearEnough(float value, float compValue, float scale)
	{
		return Mathf.Abs(Mathf.Abs(value - compValue) / scale) < 0.01f;
	}

	// Token: 0x06001EA0 RID: 7840 RVA: 0x00097FC4 File Offset: 0x000961C4
	private void PermanentUpgradeLegacyMode()
	{
		tk2dSpriteDefinition currentSprite = base.CurrentSprite;
		float x = currentSprite.untrimmedBoundsData[0].x;
		float y = currentSprite.untrimmedBoundsData[0].y;
		float x2 = currentSprite.untrimmedBoundsData[1].x;
		float y2 = currentSprite.untrimmedBoundsData[1].y;
		if (this.NearEnough(x, 0f, x2) && this.NearEnough(y, -y2 / 2f, y2))
		{
			this._anchor = tk2dBaseSprite.Anchor.UpperCenter;
		}
		else if (this.NearEnough(x, 0f, x2) && this.NearEnough(y, 0f, y2))
		{
			this._anchor = tk2dBaseSprite.Anchor.MiddleCenter;
		}
		else if (this.NearEnough(x, 0f, x2) && this.NearEnough(y, y2 / 2f, y2))
		{
			this._anchor = tk2dBaseSprite.Anchor.LowerCenter;
		}
		else if (this.NearEnough(x, -x2 / 2f, x2) && this.NearEnough(y, -y2 / 2f, y2))
		{
			this._anchor = tk2dBaseSprite.Anchor.UpperRight;
		}
		else if (this.NearEnough(x, -x2 / 2f, x2) && this.NearEnough(y, 0f, y2))
		{
			this._anchor = tk2dBaseSprite.Anchor.MiddleRight;
		}
		else if (this.NearEnough(x, -x2 / 2f, x2) && this.NearEnough(y, y2 / 2f, y2))
		{
			this._anchor = tk2dBaseSprite.Anchor.LowerRight;
		}
		else if (this.NearEnough(x, x2 / 2f, x2) && this.NearEnough(y, -y2 / 2f, y2))
		{
			this._anchor = tk2dBaseSprite.Anchor.UpperLeft;
		}
		else if (this.NearEnough(x, x2 / 2f, x2) && this.NearEnough(y, 0f, y2))
		{
			this._anchor = tk2dBaseSprite.Anchor.MiddleLeft;
		}
		else if (this.NearEnough(x, x2 / 2f, x2) && this.NearEnough(y, y2 / 2f, y2))
		{
			this._anchor = tk2dBaseSprite.Anchor.LowerLeft;
		}
		else
		{
			Debug.LogError("tk2dSlicedSprite (" + base.name + ") error - Unable to determine anchor upgrading from legacy mode. Please fix this manually.");
			this._anchor = tk2dBaseSprite.Anchor.MiddleCenter;
		}
		float num = x2 / currentSprite.texelSize.x;
		float num2 = y2 / currentSprite.texelSize.y;
		this._dimensions.x = this._scale.x * num;
		this._dimensions.y = this._scale.y * num2;
		this._scale.Set(1f, 1f, 1f);
		this.legacyMode = false;
	}

	// Token: 0x06001EA1 RID: 7841 RVA: 0x00098258 File Offset: 0x00096458
	public override void Build()
	{
		if (this.legacyMode)
		{
			this.PermanentUpgradeLegacyMode();
		}
		tk2dSpriteDefinition currentSprite = base.CurrentSprite;
		this.meshUvs = new Vector2[16];
		this.meshVertices = new Vector3[16];
		this.meshColors = new Color32[16];
		this.meshNormals = new Vector3[0];
		this.meshTangents = new Vector4[0];
		if (currentSprite.normals != null && currentSprite.normals.Length != 0)
		{
			this.meshNormals = new Vector3[16];
		}
		if (currentSprite.tangents != null && currentSprite.tangents.Length != 0)
		{
			this.meshTangents = new Vector4[16];
		}
		this.SetIndices();
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
		this.mesh.triangles = this.meshIndices;
		this.mesh.RecalculateBounds();
		this.mesh.bounds = tk2dBaseSprite.AdjustedMeshBounds(this.mesh.bounds, this.renderLayer);
		base.GetComponent<MeshFilter>().mesh = this.mesh;
		this.UpdateCollider();
		this.UpdateMaterial();
	}

	// Token: 0x06001EA2 RID: 7842 RVA: 0x00098406 File Offset: 0x00096606
	protected override void UpdateGeometry()
	{
		this.UpdateGeometryImpl();
	}

	// Token: 0x06001EA3 RID: 7843 RVA: 0x0009840E File Offset: 0x0009660E
	protected override void UpdateColors()
	{
		this.UpdateColorsImpl();
	}

	// Token: 0x06001EA4 RID: 7844 RVA: 0x00098406 File Offset: 0x00096606
	protected override void UpdateVertices()
	{
		this.UpdateGeometryImpl();
	}

	// Token: 0x06001EA5 RID: 7845 RVA: 0x00098416 File Offset: 0x00096616
	private void UpdateIndices()
	{
		if (this.mesh != null)
		{
			this.SetIndices();
			this.mesh.triangles = this.meshIndices;
		}
	}

	// Token: 0x06001EA6 RID: 7846 RVA: 0x0009843D File Offset: 0x0009663D
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

	// Token: 0x06001EA7 RID: 7847 RVA: 0x00098474 File Offset: 0x00096674
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
		this.UpdateCollider();
	}

	// Token: 0x06001EA8 RID: 7848 RVA: 0x00098524 File Offset: 0x00096724
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

	// Token: 0x06001EA9 RID: 7849 RVA: 0x00097799 File Offset: 0x00095999
	protected override void CreateCollider()
	{
		this.UpdateCollider();
	}

	// Token: 0x06001EAA RID: 7850 RVA: 0x000985DC File Offset: 0x000967DC
	protected override void UpdateMaterial()
	{
		Renderer component = base.GetComponent<Renderer>();
		if (component.sharedMaterial != this.collectionInst.spriteDefinitions[base.spriteId].materialInst)
		{
			component.material = this.collectionInst.spriteDefinitions[base.spriteId].materialInst;
		}
	}

	// Token: 0x06001EAB RID: 7851 RVA: 0x00098631 File Offset: 0x00096831
	protected override int GetCurrentVertexCount()
	{
		return 16;
	}

	// Token: 0x06001EAC RID: 7852 RVA: 0x00098638 File Offset: 0x00096838
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

	// Token: 0x06001EAD RID: 7853 RVA: 0x000989D0 File Offset: 0x00096BD0
	public tk2dSlicedSprite()
	{
		this._dimensions = new Vector2(50f, 50f);
		this.borderTop = 0.2f;
		this.borderBottom = 0.2f;
		this.borderLeft = 0.2f;
		this.borderRight = 0.2f;
		this.boundsCenter = Vector3.zero;
		this.boundsExtents = Vector3.zero;
		base..ctor();
	}

	// Token: 0x040023DF RID: 9183
	private Mesh mesh;

	// Token: 0x040023E0 RID: 9184
	private Vector2[] meshUvs;

	// Token: 0x040023E1 RID: 9185
	private Vector3[] meshVertices;

	// Token: 0x040023E2 RID: 9186
	private Color32[] meshColors;

	// Token: 0x040023E3 RID: 9187
	private Vector3[] meshNormals;

	// Token: 0x040023E4 RID: 9188
	private Vector4[] meshTangents;

	// Token: 0x040023E5 RID: 9189
	private int[] meshIndices;

	// Token: 0x040023E6 RID: 9190
	[SerializeField]
	private Vector2 _dimensions;

	// Token: 0x040023E7 RID: 9191
	[SerializeField]
	private tk2dBaseSprite.Anchor _anchor;

	// Token: 0x040023E8 RID: 9192
	[SerializeField]
	private bool _borderOnly;

	// Token: 0x040023E9 RID: 9193
	[SerializeField]
	private bool legacyMode;

	// Token: 0x040023EA RID: 9194
	public float borderTop;

	// Token: 0x040023EB RID: 9195
	public float borderBottom;

	// Token: 0x040023EC RID: 9196
	public float borderLeft;

	// Token: 0x040023ED RID: 9197
	public float borderRight;

	// Token: 0x040023EE RID: 9198
	[SerializeField]
	protected bool _createBoxCollider;

	// Token: 0x040023EF RID: 9199
	private Vector3 boundsCenter;

	// Token: 0x040023F0 RID: 9200
	private Vector3 boundsExtents;
}
