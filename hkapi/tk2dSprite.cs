using System;
using UnityEngine;

// Token: 0x02000561 RID: 1377
[AddComponentMenu("2D Toolkit/Sprite/tk2dSprite")]
[RequireComponent(typeof(MeshRenderer))]
[RequireComponent(typeof(MeshFilter))]
[ExecuteInEditMode]
public class tk2dSprite : tk2dBaseSprite
{
	// Token: 0x06001EAE RID: 7854 RVA: 0x00098A3C File Offset: 0x00096C3C
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

	// Token: 0x06001EAF RID: 7855 RVA: 0x00098AB9 File Offset: 0x00096CB9
	protected void OnDestroy()
	{
		if (this.mesh)
		{
			UnityEngine.Object.Destroy(this.mesh);
		}
		if (this.meshColliderMesh)
		{
			UnityEngine.Object.Destroy(this.meshColliderMesh);
		}
	}

	// Token: 0x06001EB0 RID: 7856 RVA: 0x00098AEC File Offset: 0x00096CEC
	public override void Build()
	{
		tk2dSpriteDefinition tk2dSpriteDefinition = this.collectionInst.spriteDefinitions[base.spriteId];
		this.meshVertices = new Vector3[tk2dSpriteDefinition.positions.Length];
		this.meshColors = new Color32[tk2dSpriteDefinition.positions.Length];
		this.meshNormals = new Vector3[0];
		this.meshTangents = new Vector4[0];
		if (tk2dSpriteDefinition.normals != null && tk2dSpriteDefinition.normals.Length != 0)
		{
			this.meshNormals = new Vector3[tk2dSpriteDefinition.normals.Length];
		}
		if (tk2dSpriteDefinition.tangents != null && tk2dSpriteDefinition.tangents.Length != 0)
		{
			this.meshTangents = new Vector4[tk2dSpriteDefinition.tangents.Length];
		}
		base.SetPositions(this.meshVertices, this.meshNormals, this.meshTangents);
		base.SetColors(this.meshColors);
		if (this.mesh == null)
		{
			this.mesh = new Mesh();
			this.mesh.MarkDynamic();
			this.mesh.hideFlags = HideFlags.DontSave;
			base.GetComponent<MeshFilter>().mesh = this.mesh;
		}
		this.mesh.Clear();
		this.mesh.vertices = this.meshVertices;
		this.mesh.normals = this.meshNormals;
		this.mesh.tangents = this.meshTangents;
		this.mesh.colors32 = this.meshColors;
		this.mesh.uv = tk2dSpriteDefinition.uvs;
		this.mesh.triangles = tk2dSpriteDefinition.indices;
		this.mesh.bounds = tk2dBaseSprite.AdjustedMeshBounds(base.GetBounds(), this.renderLayer);
		this.UpdateMaterial();
		this.CreateCollider();
	}

	// Token: 0x06001EB1 RID: 7857 RVA: 0x00098C91 File Offset: 0x00096E91
	public static tk2dSprite AddComponent(GameObject go, tk2dSpriteCollectionData spriteCollection, int spriteId)
	{
		return tk2dBaseSprite.AddComponent<tk2dSprite>(go, spriteCollection, spriteId);
	}

	// Token: 0x06001EB2 RID: 7858 RVA: 0x00098C9B File Offset: 0x00096E9B
	public static tk2dSprite AddComponent(GameObject go, tk2dSpriteCollectionData spriteCollection, string spriteName)
	{
		return tk2dBaseSprite.AddComponent<tk2dSprite>(go, spriteCollection, spriteName);
	}

	// Token: 0x06001EB3 RID: 7859 RVA: 0x00098CA5 File Offset: 0x00096EA5
	public static GameObject CreateFromTexture(Texture texture, tk2dSpriteCollectionSize size, Rect region, Vector2 anchor)
	{
		return tk2dBaseSprite.CreateFromTexture<tk2dSprite>(texture, size, region, anchor);
	}

	// Token: 0x06001EB4 RID: 7860 RVA: 0x00098CB0 File Offset: 0x00096EB0
	protected override void UpdateGeometry()
	{
		this.UpdateGeometryImpl();
	}

	// Token: 0x06001EB5 RID: 7861 RVA: 0x00098CB8 File Offset: 0x00096EB8
	protected override void UpdateColors()
	{
		this.UpdateColorsImpl();
	}

	// Token: 0x06001EB6 RID: 7862 RVA: 0x00098CC0 File Offset: 0x00096EC0
	protected override void UpdateVertices()
	{
		this.UpdateVerticesImpl();
	}

	// Token: 0x06001EB7 RID: 7863 RVA: 0x00098CC8 File Offset: 0x00096EC8
	protected void UpdateColorsImpl()
	{
		if (this.mesh == null || this.meshColors == null || this.meshColors.Length == 0)
		{
			return;
		}
		base.SetColors(this.meshColors);
		this.mesh.colors32 = this.meshColors;
	}

	// Token: 0x06001EB8 RID: 7864 RVA: 0x00098D08 File Offset: 0x00096F08
	protected void UpdateVerticesImpl()
	{
		tk2dSpriteDefinition tk2dSpriteDefinition = this.collectionInst.spriteDefinitions[base.spriteId];
		if (this.mesh == null || this.meshVertices == null || this.meshVertices.Length == 0)
		{
			return;
		}
		if (tk2dSpriteDefinition.normals.Length != this.meshNormals.Length)
		{
			this.meshNormals = ((tk2dSpriteDefinition.normals != null && tk2dSpriteDefinition.normals.Length != 0) ? new Vector3[tk2dSpriteDefinition.normals.Length] : new Vector3[0]);
		}
		if (tk2dSpriteDefinition.tangents.Length != this.meshTangents.Length)
		{
			this.meshTangents = ((tk2dSpriteDefinition.tangents != null && tk2dSpriteDefinition.tangents.Length != 0) ? new Vector4[tk2dSpriteDefinition.tangents.Length] : new Vector4[0]);
		}
		base.SetPositions(this.meshVertices, this.meshNormals, this.meshTangents);
		this.mesh.vertices = this.meshVertices;
		this.mesh.normals = this.meshNormals;
		this.mesh.tangents = this.meshTangents;
		this.mesh.uv = tk2dSpriteDefinition.uvs;
		this.mesh.bounds = tk2dBaseSprite.AdjustedMeshBounds(base.GetBounds(), this.renderLayer);
	}

	// Token: 0x06001EB9 RID: 7865 RVA: 0x00098E3C File Offset: 0x0009703C
	protected void UpdateGeometryImpl()
	{
		if (this.mesh == null)
		{
			return;
		}
		tk2dSpriteDefinition tk2dSpriteDefinition = this.collectionInst.spriteDefinitions[base.spriteId];
		if (this.meshVertices == null || this.meshVertices.Length != tk2dSpriteDefinition.positions.Length)
		{
			this.meshVertices = new Vector3[tk2dSpriteDefinition.positions.Length];
			this.meshColors = new Color32[tk2dSpriteDefinition.positions.Length];
		}
		if (this.meshNormals == null || (tk2dSpriteDefinition.normals != null && this.meshNormals.Length != tk2dSpriteDefinition.normals.Length))
		{
			this.meshNormals = new Vector3[tk2dSpriteDefinition.normals.Length];
		}
		else if (tk2dSpriteDefinition.normals == null)
		{
			this.meshNormals = new Vector3[0];
		}
		if (this.meshTangents == null || (tk2dSpriteDefinition.tangents != null && this.meshTangents.Length != tk2dSpriteDefinition.tangents.Length))
		{
			this.meshTangents = new Vector4[tk2dSpriteDefinition.tangents.Length];
		}
		else if (tk2dSpriteDefinition.tangents == null)
		{
			this.meshTangents = new Vector4[0];
		}
		base.SetPositions(this.meshVertices, this.meshNormals, this.meshTangents);
		base.SetColors(this.meshColors);
		this.mesh.Clear();
		this.mesh.vertices = this.meshVertices;
		this.mesh.normals = this.meshNormals;
		this.mesh.tangents = this.meshTangents;
		this.mesh.colors32 = this.meshColors;
		this.mesh.uv = tk2dSpriteDefinition.uvs;
		this.mesh.bounds = tk2dBaseSprite.AdjustedMeshBounds(base.GetBounds(), this.renderLayer);
		this.mesh.triangles = tk2dSpriteDefinition.indices;
	}

	// Token: 0x06001EBA RID: 7866 RVA: 0x00098FF4 File Offset: 0x000971F4
	protected override void UpdateMaterial()
	{
		Renderer component = base.GetComponent<Renderer>();
		if (component.sharedMaterial != this.collectionInst.spriteDefinitions[base.spriteId].materialInst)
		{
			component.material = this.collectionInst.spriteDefinitions[base.spriteId].materialInst;
		}
	}

	// Token: 0x06001EBB RID: 7867 RVA: 0x00099049 File Offset: 0x00097249
	protected override int GetCurrentVertexCount()
	{
		if (this.meshVertices == null)
		{
			return 0;
		}
		return this.meshVertices.Length;
	}

	// Token: 0x06001EBC RID: 7868 RVA: 0x0009905D File Offset: 0x0009725D
	public override void ForceBuild()
	{
		base.ForceBuild();
		base.GetComponent<MeshFilter>().mesh = this.mesh;
	}

	// Token: 0x06001EBD RID: 7869 RVA: 0x00099078 File Offset: 0x00097278
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

	// Token: 0x040023F1 RID: 9201
	private Mesh mesh;

	// Token: 0x040023F2 RID: 9202
	private Vector3[] meshVertices;

	// Token: 0x040023F3 RID: 9203
	private Vector3[] meshNormals;

	// Token: 0x040023F4 RID: 9204
	private Vector4[] meshTangents;

	// Token: 0x040023F5 RID: 9205
	private Color32[] meshColors;
}
