using System;
using UnityEngine;

// Token: 0x020005BB RID: 1467
[AddComponentMenu("2D Toolkit/UI/Core/tk2dUIMask")]
[RequireComponent(typeof(MeshRenderer))]
[RequireComponent(typeof(MeshFilter))]
[ExecuteInEditMode]
public class tk2dUIMask : MonoBehaviour
{
	// Token: 0x17000457 RID: 1111
	// (get) Token: 0x06002163 RID: 8547 RVA: 0x000A8087 File Offset: 0x000A6287
	private MeshFilter ThisMeshFilter
	{
		get
		{
			if (this._thisMeshFilter == null)
			{
				this._thisMeshFilter = base.GetComponent<MeshFilter>();
			}
			return this._thisMeshFilter;
		}
	}

	// Token: 0x17000458 RID: 1112
	// (get) Token: 0x06002164 RID: 8548 RVA: 0x000A80A9 File Offset: 0x000A62A9
	private BoxCollider ThisBoxCollider
	{
		get
		{
			if (this._thisBoxCollider == null)
			{
				this._thisBoxCollider = base.GetComponent<BoxCollider>();
			}
			return this._thisBoxCollider;
		}
	}

	// Token: 0x06002165 RID: 8549 RVA: 0x000A80CB File Offset: 0x000A62CB
	private void Awake()
	{
		this.Build();
	}

	// Token: 0x06002166 RID: 8550 RVA: 0x000A80D3 File Offset: 0x000A62D3
	private void OnDestroy()
	{
		if (this.ThisMeshFilter.sharedMesh != null)
		{
			UnityEngine.Object.Destroy(this.ThisMeshFilter.sharedMesh);
		}
	}

	// Token: 0x06002167 RID: 8551 RVA: 0x000A80F8 File Offset: 0x000A62F8
	private Mesh FillMesh(Mesh mesh)
	{
		Vector3 zero = Vector3.zero;
		switch (this.anchor)
		{
		case tk2dBaseSprite.Anchor.LowerLeft:
			zero = new Vector3(0f, 0f, 0f);
			break;
		case tk2dBaseSprite.Anchor.LowerCenter:
			zero = new Vector3(-this.size.x / 2f, 0f, 0f);
			break;
		case tk2dBaseSprite.Anchor.LowerRight:
			zero = new Vector3(-this.size.x, 0f, 0f);
			break;
		case tk2dBaseSprite.Anchor.MiddleLeft:
			zero = new Vector3(0f, -this.size.y / 2f, 0f);
			break;
		case tk2dBaseSprite.Anchor.MiddleCenter:
			zero = new Vector3(-this.size.x / 2f, -this.size.y / 2f, 0f);
			break;
		case tk2dBaseSprite.Anchor.MiddleRight:
			zero = new Vector3(-this.size.x, -this.size.y / 2f, 0f);
			break;
		case tk2dBaseSprite.Anchor.UpperLeft:
			zero = new Vector3(0f, -this.size.y, 0f);
			break;
		case tk2dBaseSprite.Anchor.UpperCenter:
			zero = new Vector3(-this.size.x / 2f, -this.size.y, 0f);
			break;
		case tk2dBaseSprite.Anchor.UpperRight:
			zero = new Vector3(-this.size.x, -this.size.y, 0f);
			break;
		}
		Vector3[] vertices = new Vector3[]
		{
			zero + new Vector3(0f, 0f, -this.depth),
			zero + new Vector3(this.size.x, 0f, -this.depth),
			zero + new Vector3(0f, this.size.y, -this.depth),
			zero + new Vector3(this.size.x, this.size.y, -this.depth)
		};
		mesh.vertices = vertices;
		mesh.uv = tk2dUIMask.uv;
		mesh.triangles = tk2dUIMask.indices;
		Bounds bounds = default(Bounds);
		bounds.SetMinMax(zero, zero + new Vector3(this.size.x, this.size.y, 0f));
		mesh.bounds = bounds;
		return mesh;
	}

	// Token: 0x06002168 RID: 8552 RVA: 0x000A83A4 File Offset: 0x000A65A4
	private void OnDrawGizmosSelected()
	{
		Mesh sharedMesh = this.ThisMeshFilter.sharedMesh;
		if (sharedMesh != null)
		{
			Gizmos.matrix = base.transform.localToWorldMatrix;
			Bounds bounds = sharedMesh.bounds;
			Gizmos.color = new Color32(56, 146, 227, 96);
			float num = -this.depth * 1.001f;
			Vector3 center = new Vector3(bounds.center.x, bounds.center.y, num * 0.5f);
			Vector3 vector = new Vector3(bounds.extents.x * 2f, bounds.extents.y * 2f, Mathf.Abs(num));
			Gizmos.DrawCube(center, vector);
			Gizmos.color = new Color32(22, 145, byte.MaxValue, byte.MaxValue);
			Gizmos.DrawWireCube(center, vector);
		}
	}

	// Token: 0x06002169 RID: 8553 RVA: 0x000A8490 File Offset: 0x000A6690
	public void Build()
	{
		if (this.ThisMeshFilter.sharedMesh == null)
		{
			Mesh mesh = new Mesh();
			mesh.MarkDynamic();
			mesh.hideFlags = HideFlags.DontSave;
			this.ThisMeshFilter.mesh = this.FillMesh(mesh);
		}
		else
		{
			this.FillMesh(this.ThisMeshFilter.sharedMesh);
		}
		if (this.createBoxCollider)
		{
			if (this.ThisBoxCollider == null)
			{
				this._thisBoxCollider = base.gameObject.AddComponent<BoxCollider>();
			}
			Bounds bounds = this.ThisMeshFilter.sharedMesh.bounds;
			this.ThisBoxCollider.center = new Vector3(bounds.center.x, bounds.center.y, -this.depth);
			this.ThisBoxCollider.size = new Vector3(bounds.size.x, bounds.size.y, 0.0002f);
			return;
		}
		if (this.ThisBoxCollider != null)
		{
			UnityEngine.Object.Destroy(this.ThisBoxCollider);
		}
	}

	// Token: 0x0600216A RID: 8554 RVA: 0x000A859C File Offset: 0x000A679C
	public void ReshapeBounds(Vector3 dMin, Vector3 dMax)
	{
		Vector3 vector = new Vector3(this.size.x, this.size.y);
		Vector3 vector2 = Vector3.zero;
		switch (this.anchor)
		{
		case tk2dBaseSprite.Anchor.LowerLeft:
			vector2.Set(0f, 0f, 0f);
			break;
		case tk2dBaseSprite.Anchor.LowerCenter:
			vector2.Set(0.5f, 0f, 0f);
			break;
		case tk2dBaseSprite.Anchor.LowerRight:
			vector2.Set(1f, 0f, 0f);
			break;
		case tk2dBaseSprite.Anchor.MiddleLeft:
			vector2.Set(0f, 0.5f, 0f);
			break;
		case tk2dBaseSprite.Anchor.MiddleCenter:
			vector2.Set(0.5f, 0.5f, 0f);
			break;
		case tk2dBaseSprite.Anchor.MiddleRight:
			vector2.Set(1f, 0.5f, 0f);
			break;
		case tk2dBaseSprite.Anchor.UpperLeft:
			vector2.Set(0f, 1f, 0f);
			break;
		case tk2dBaseSprite.Anchor.UpperCenter:
			vector2.Set(0.5f, 1f, 0f);
			break;
		case tk2dBaseSprite.Anchor.UpperRight:
			vector2.Set(1f, 1f, 0f);
			break;
		}
		vector2 = Vector3.Scale(vector2, vector) * -1f;
		Vector3 vector3 = vector + dMax - dMin;
		Vector3 b = new Vector3(Mathf.Approximately(vector.x, 0f) ? 0f : (vector2.x * vector3.x / vector.x), Mathf.Approximately(vector.y, 0f) ? 0f : (vector2.y * vector3.y / vector.y));
		Vector3 position = vector2 + dMin - b;
		position.z = 0f;
		base.transform.position = base.transform.TransformPoint(position);
		this.size = new Vector2(vector3.x, vector3.y);
		this.Build();
	}

	// Token: 0x0600216B RID: 8555 RVA: 0x000A87B7 File Offset: 0x000A69B7
	public tk2dUIMask()
	{
		this.anchor = tk2dBaseSprite.Anchor.MiddleCenter;
		this.size = new Vector2(1f, 1f);
		this.depth = 1f;
		this.createBoxCollider = true;
		base..ctor();
	}

	// Token: 0x0600216C RID: 8556 RVA: 0x000A87F0 File Offset: 0x000A69F0
	// Note: this type is marked as 'beforefieldinit'.
	static tk2dUIMask()
	{
		tk2dUIMask.uv = new Vector2[]
		{
			new Vector2(0f, 0f),
			new Vector2(1f, 0f),
			new Vector2(0f, 1f),
			new Vector2(1f, 1f)
		};
		tk2dUIMask.indices = new int[]
		{
			0,
			3,
			1,
			2,
			3,
			0
		};
	}

	// Token: 0x040026D4 RID: 9940
	public tk2dBaseSprite.Anchor anchor;

	// Token: 0x040026D5 RID: 9941
	public Vector2 size;

	// Token: 0x040026D6 RID: 9942
	public float depth;

	// Token: 0x040026D7 RID: 9943
	public bool createBoxCollider;

	// Token: 0x040026D8 RID: 9944
	private MeshFilter _thisMeshFilter;

	// Token: 0x040026D9 RID: 9945
	private BoxCollider _thisBoxCollider;

	// Token: 0x040026DA RID: 9946
	private static readonly Vector2[] uv;

	// Token: 0x040026DB RID: 9947
	private static readonly int[] indices;
}
