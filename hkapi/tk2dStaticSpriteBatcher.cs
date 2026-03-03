using System;
using System.Collections.Generic;
using tk2dRuntime;
using UnityEngine;

// Token: 0x02000590 RID: 1424
[AddComponentMenu("2D Toolkit/Sprite/tk2dStaticSpriteBatcher")]
[RequireComponent(typeof(MeshRenderer))]
[RequireComponent(typeof(MeshFilter))]
[ExecuteInEditMode]
public class tk2dStaticSpriteBatcher : MonoBehaviour, ISpriteCollectionForceBuild
{
	// Token: 0x06001F8F RID: 8079 RVA: 0x0009E312 File Offset: 0x0009C512
	public bool CheckFlag(tk2dStaticSpriteBatcher.Flags mask)
	{
		return (this.flags & mask) > tk2dStaticSpriteBatcher.Flags.None;
	}

	// Token: 0x06001F90 RID: 8080 RVA: 0x0009E31F File Offset: 0x0009C51F
	public void SetFlag(tk2dStaticSpriteBatcher.Flags mask, bool value)
	{
		if (this.CheckFlag(mask) != value)
		{
			if (value)
			{
				this.flags |= mask;
			}
			else
			{
				this.flags &= ~mask;
			}
			this.Build();
		}
	}

	// Token: 0x06001F91 RID: 8081 RVA: 0x0009E353 File Offset: 0x0009C553
	private void Awake()
	{
		this.Build();
	}

	// Token: 0x06001F92 RID: 8082 RVA: 0x0009E35C File Offset: 0x0009C55C
	private bool UpgradeData()
	{
		if (this.version == tk2dStaticSpriteBatcher.CURRENT_VERSION)
		{
			return false;
		}
		if (this._scale == Vector3.zero)
		{
			this._scale = Vector3.one;
		}
		if (this.version < 2 && this.batchedSprites != null)
		{
			tk2dBatchedSprite[] array = this.batchedSprites;
			for (int i = 0; i < array.Length; i++)
			{
				array[i].parentId = -1;
			}
		}
		if (this.version < 3)
		{
			if (this.batchedSprites != null)
			{
				foreach (tk2dBatchedSprite tk2dBatchedSprite in this.batchedSprites)
				{
					if (tk2dBatchedSprite.spriteId == -1)
					{
						tk2dBatchedSprite.type = tk2dBatchedSprite.Type.EmptyGameObject;
					}
					else
					{
						tk2dBatchedSprite.type = tk2dBatchedSprite.Type.Sprite;
						if (tk2dBatchedSprite.spriteCollection == null)
						{
							tk2dBatchedSprite.spriteCollection = this.spriteCollection;
						}
					}
				}
				this.UpdateMatrices();
			}
			this.spriteCollection = null;
		}
		this.version = tk2dStaticSpriteBatcher.CURRENT_VERSION;
		return true;
	}

	// Token: 0x06001F93 RID: 8083 RVA: 0x0009E43A File Offset: 0x0009C63A
	protected void OnDestroy()
	{
		if (this.mesh)
		{
			UnityEngine.Object.Destroy(this.mesh);
		}
		if (this.colliderMesh)
		{
			UnityEngine.Object.Destroy(this.colliderMesh);
		}
	}

	// Token: 0x06001F94 RID: 8084 RVA: 0x0009E46C File Offset: 0x0009C66C
	public void UpdateMatrices()
	{
		bool flag = false;
		tk2dBatchedSprite[] array = this.batchedSprites;
		for (int i = 0; i < array.Length; i++)
		{
			if (array[i].parentId != -1)
			{
				flag = true;
				break;
			}
		}
		if (flag)
		{
			Matrix4x4 rhs = default(Matrix4x4);
			List<tk2dBatchedSprite> list = new List<tk2dBatchedSprite>(this.batchedSprites);
			list.Sort((tk2dBatchedSprite a, tk2dBatchedSprite b) => a.parentId.CompareTo(b.parentId));
			using (List<tk2dBatchedSprite>.Enumerator enumerator = list.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					tk2dBatchedSprite tk2dBatchedSprite = enumerator.Current;
					rhs.SetTRS(tk2dBatchedSprite.position, tk2dBatchedSprite.rotation, tk2dBatchedSprite.localScale);
					tk2dBatchedSprite.relativeMatrix = ((tk2dBatchedSprite.parentId == -1) ? Matrix4x4.identity : this.batchedSprites[tk2dBatchedSprite.parentId].relativeMatrix) * rhs;
				}
				return;
			}
		}
		foreach (tk2dBatchedSprite tk2dBatchedSprite2 in this.batchedSprites)
		{
			tk2dBatchedSprite2.relativeMatrix.SetTRS(tk2dBatchedSprite2.position, tk2dBatchedSprite2.rotation, tk2dBatchedSprite2.localScale);
		}
	}

	// Token: 0x06001F95 RID: 8085 RVA: 0x0009E5A0 File Offset: 0x0009C7A0
	public void Build()
	{
		this.UpgradeData();
		if (this.mesh == null)
		{
			this.mesh = new Mesh();
			this.mesh.hideFlags = HideFlags.DontSave;
			base.GetComponent<MeshFilter>().mesh = this.mesh;
		}
		else
		{
			this.mesh.Clear();
		}
		if (this.colliderMesh)
		{
			UnityEngine.Object.Destroy(this.colliderMesh);
			this.colliderMesh = null;
		}
		if (this.batchedSprites != null && this.batchedSprites.Length != 0)
		{
			this.SortBatchedSprites();
			this.BuildRenderMesh();
			this.BuildPhysicsMesh();
		}
	}

	// Token: 0x06001F96 RID: 8086 RVA: 0x0009E63C File Offset: 0x0009C83C
	private void SortBatchedSprites()
	{
		List<tk2dBatchedSprite> list = new List<tk2dBatchedSprite>();
		List<tk2dBatchedSprite> list2 = new List<tk2dBatchedSprite>();
		List<tk2dBatchedSprite> list3 = new List<tk2dBatchedSprite>();
		foreach (tk2dBatchedSprite tk2dBatchedSprite in this.batchedSprites)
		{
			if (!tk2dBatchedSprite.IsDrawn)
			{
				list3.Add(tk2dBatchedSprite);
			}
			else
			{
				Material material = this.GetMaterial(tk2dBatchedSprite);
				if (material != null)
				{
					if (material.renderQueue == 2000)
					{
						list.Add(tk2dBatchedSprite);
					}
					else
					{
						list2.Add(tk2dBatchedSprite);
					}
				}
				else
				{
					list.Add(tk2dBatchedSprite);
				}
			}
		}
		List<tk2dBatchedSprite> list4 = new List<tk2dBatchedSprite>(list.Count + list2.Count + list3.Count);
		list4.AddRange(list);
		list4.AddRange(list2);
		list4.AddRange(list3);
		Dictionary<tk2dBatchedSprite, int> dictionary = new Dictionary<tk2dBatchedSprite, int>();
		int num = 0;
		foreach (tk2dBatchedSprite key in list4)
		{
			dictionary[key] = num++;
		}
		foreach (tk2dBatchedSprite tk2dBatchedSprite2 in list4)
		{
			if (tk2dBatchedSprite2.parentId != -1)
			{
				tk2dBatchedSprite2.parentId = dictionary[this.batchedSprites[tk2dBatchedSprite2.parentId]];
			}
		}
		this.batchedSprites = list4.ToArray();
	}

	// Token: 0x06001F97 RID: 8087 RVA: 0x0009E7C0 File Offset: 0x0009C9C0
	private Material GetMaterial(tk2dBatchedSprite bs)
	{
		tk2dBatchedSprite.Type type = bs.type;
		if (type == tk2dBatchedSprite.Type.EmptyGameObject)
		{
			return null;
		}
		if (type != tk2dBatchedSprite.Type.TextMesh)
		{
			return bs.GetSpriteDefinition().materialInst;
		}
		return this.allTextMeshData[bs.xRefId].font.materialInst;
	}

	// Token: 0x06001F98 RID: 8088 RVA: 0x0009E804 File Offset: 0x0009CA04
	private void BuildRenderMesh()
	{
		List<Material> list = new List<Material>();
		List<List<int>> list2 = new List<List<int>>();
		bool flag = false;
		bool flag2 = false;
		bool flag3 = false;
		bool flag4 = this.CheckFlag(tk2dStaticSpriteBatcher.Flags.FlattenDepth);
		foreach (tk2dBatchedSprite tk2dBatchedSprite in this.batchedSprites)
		{
			tk2dSpriteDefinition spriteDefinition = tk2dBatchedSprite.GetSpriteDefinition();
			if (spriteDefinition != null)
			{
				flag |= (spriteDefinition.normals != null && spriteDefinition.normals.Length != 0);
				flag2 |= (spriteDefinition.tangents != null && spriteDefinition.tangents.Length != 0);
			}
			if (tk2dBatchedSprite.type == tk2dBatchedSprite.Type.TextMesh)
			{
				tk2dTextMeshData tk2dTextMeshData = this.allTextMeshData[tk2dBatchedSprite.xRefId];
				if (tk2dTextMeshData.font != null && tk2dTextMeshData.font.inst.textureGradients)
				{
					flag3 = true;
				}
			}
		}
		List<int> list3 = new List<int>();
		List<int> list4 = new List<int>();
		int num = 0;
		foreach (tk2dBatchedSprite tk2dBatchedSprite2 in this.batchedSprites)
		{
			if (!tk2dBatchedSprite2.IsDrawn)
			{
				break;
			}
			tk2dSpriteDefinition spriteDefinition2 = tk2dBatchedSprite2.GetSpriteDefinition();
			int num2 = 0;
			int item = 0;
			switch (tk2dBatchedSprite2.type)
			{
			case tk2dBatchedSprite.Type.Sprite:
				if (spriteDefinition2 != null)
				{
					tk2dSpriteGeomGen.GetSpriteGeomDesc(out num2, out item, spriteDefinition2);
				}
				break;
			case tk2dBatchedSprite.Type.TiledSprite:
				if (spriteDefinition2 != null)
				{
					tk2dSpriteGeomGen.GetTiledSpriteGeomDesc(out num2, out item, spriteDefinition2, tk2dBatchedSprite2.Dimensions);
				}
				break;
			case tk2dBatchedSprite.Type.SlicedSprite:
				if (spriteDefinition2 != null)
				{
					tk2dSpriteGeomGen.GetSlicedSpriteGeomDesc(out num2, out item, spriteDefinition2, tk2dBatchedSprite2.CheckFlag(tk2dBatchedSprite.Flags.SlicedSprite_BorderOnly));
				}
				break;
			case tk2dBatchedSprite.Type.ClippedSprite:
				if (spriteDefinition2 != null)
				{
					tk2dSpriteGeomGen.GetClippedSpriteGeomDesc(out num2, out item, spriteDefinition2);
				}
				break;
			case tk2dBatchedSprite.Type.TextMesh:
			{
				tk2dTextMeshData tk2dTextMeshData2 = this.allTextMeshData[tk2dBatchedSprite2.xRefId];
				tk2dTextGeomGen.GetTextMeshGeomDesc(out num2, out item, tk2dTextGeomGen.Data(tk2dTextMeshData2, tk2dTextMeshData2.font.inst, tk2dBatchedSprite2.FormattedText));
				break;
			}
			}
			num += num2;
			list3.Add(num2);
			list4.Add(item);
		}
		Vector3[] array2 = flag ? new Vector3[num] : null;
		Vector4[] array3 = flag2 ? new Vector4[num] : null;
		Vector3[] array4 = new Vector3[num];
		Color32[] array5 = new Color32[num];
		Vector2[] array6 = new Vector2[num];
		Vector2[] array7 = flag3 ? new Vector2[num] : null;
		int num3 = 0;
		Material material = null;
		List<int> list5 = null;
		Matrix4x4 identity = Matrix4x4.identity;
		identity.m00 = this._scale.x;
		identity.m11 = this._scale.y;
		identity.m22 = this._scale.z;
		int num4 = 0;
		foreach (tk2dBatchedSprite tk2dBatchedSprite3 in this.batchedSprites)
		{
			if (!tk2dBatchedSprite3.IsDrawn)
			{
				break;
			}
			if (tk2dBatchedSprite3.type == tk2dBatchedSprite.Type.EmptyGameObject)
			{
				num4++;
			}
			else
			{
				tk2dSpriteDefinition spriteDefinition3 = tk2dBatchedSprite3.GetSpriteDefinition();
				int num5 = list3[num4];
				int num6 = list4[num4];
				Material material2 = this.GetMaterial(tk2dBatchedSprite3);
				if (material2 != material)
				{
					if (material != null)
					{
						list.Add(material);
						list2.Add(list5);
					}
					material = material2;
					list5 = new List<int>();
				}
				Vector3[] array8 = new Vector3[num5];
				Vector2[] array9 = new Vector2[num5];
				Vector2[] array10 = flag3 ? new Vector2[num5] : null;
				Color32[] array11 = new Color32[num5];
				Vector3[] array12 = flag ? new Vector3[num5] : null;
				Vector4[] array13 = flag2 ? new Vector4[num5] : null;
				int[] array14 = new int[num6];
				Vector3 zero = Vector3.zero;
				Vector3 zero2 = Vector3.zero;
				switch (tk2dBatchedSprite3.type)
				{
				case tk2dBatchedSprite.Type.Sprite:
					if (spriteDefinition3 != null)
					{
						tk2dSpriteGeomGen.SetSpriteGeom(array8, array9, array12, array13, 0, spriteDefinition3, Vector3.one);
						tk2dSpriteGeomGen.SetSpriteIndices(array14, 0, num3, spriteDefinition3);
					}
					break;
				case tk2dBatchedSprite.Type.TiledSprite:
					if (spriteDefinition3 != null)
					{
						tk2dSpriteGeomGen.SetTiledSpriteGeom(array8, array9, 0, out zero, out zero2, spriteDefinition3, Vector3.one, tk2dBatchedSprite3.Dimensions, tk2dBatchedSprite3.anchor, tk2dBatchedSprite3.BoxColliderOffsetZ, tk2dBatchedSprite3.BoxColliderExtentZ);
						tk2dSpriteGeomGen.SetTiledSpriteIndices(array14, 0, num3, spriteDefinition3, tk2dBatchedSprite3.Dimensions);
					}
					break;
				case tk2dBatchedSprite.Type.SlicedSprite:
					if (spriteDefinition3 != null)
					{
						tk2dSpriteGeomGen.SetSlicedSpriteGeom(array8, array9, 0, out zero, out zero2, spriteDefinition3, Vector3.one, tk2dBatchedSprite3.Dimensions, tk2dBatchedSprite3.SlicedSpriteBorderBottomLeft, tk2dBatchedSprite3.SlicedSpriteBorderTopRight, tk2dBatchedSprite3.anchor, tk2dBatchedSprite3.BoxColliderOffsetZ, tk2dBatchedSprite3.BoxColliderExtentZ);
						tk2dSpriteGeomGen.SetSlicedSpriteIndices(array14, 0, num3, spriteDefinition3, tk2dBatchedSprite3.CheckFlag(tk2dBatchedSprite.Flags.SlicedSprite_BorderOnly));
					}
					break;
				case tk2dBatchedSprite.Type.ClippedSprite:
					if (spriteDefinition3 != null)
					{
						tk2dSpriteGeomGen.SetClippedSpriteGeom(array8, array9, 0, out zero, out zero2, spriteDefinition3, Vector3.one, tk2dBatchedSprite3.ClippedSpriteRegionBottomLeft, tk2dBatchedSprite3.ClippedSpriteRegionTopRight, tk2dBatchedSprite3.BoxColliderOffsetZ, tk2dBatchedSprite3.BoxColliderExtentZ);
						tk2dSpriteGeomGen.SetClippedSpriteIndices(array14, 0, num3, spriteDefinition3);
					}
					break;
				case tk2dBatchedSprite.Type.TextMesh:
				{
					tk2dTextMeshData tk2dTextMeshData3 = this.allTextMeshData[tk2dBatchedSprite3.xRefId];
					tk2dTextGeomGen.GeomData geomData = tk2dTextGeomGen.Data(tk2dTextMeshData3, tk2dTextMeshData3.font.inst, tk2dBatchedSprite3.FormattedText);
					int target = tk2dTextGeomGen.SetTextMeshGeom(array8, array9, array10, array11, 0, geomData);
					if (!geomData.fontInst.isPacked)
					{
						Color32 color = tk2dTextMeshData3.color;
						Color32 color2 = tk2dTextMeshData3.useGradient ? tk2dTextMeshData3.color2 : tk2dTextMeshData3.color;
						for (int j = 0; j < array11.Length; j++)
						{
							Color32 color3 = (j % 4 < 2) ? color : color2;
							byte b = array11[j].r * color3.r / byte.MaxValue;
							byte b2 = array11[j].g * color3.g / byte.MaxValue;
							byte b3 = array11[j].b * color3.b / byte.MaxValue;
							byte b4 = array11[j].a * color3.a / byte.MaxValue;
							if (geomData.fontInst.premultipliedAlpha)
							{
								b = b * b4 / byte.MaxValue;
								b2 = b2 * b4 / byte.MaxValue;
								b3 = b3 * b4 / byte.MaxValue;
							}
							array11[j] = new Color32(b, b2, b3, b4);
						}
					}
					tk2dTextGeomGen.SetTextMeshIndices(array14, 0, num3, geomData, target);
					break;
				}
				}
				tk2dBatchedSprite3.CachedBoundsCenter = zero;
				tk2dBatchedSprite3.CachedBoundsExtents = zero2;
				if (num5 > 0 && tk2dBatchedSprite3.type != tk2dBatchedSprite.Type.TextMesh)
				{
					bool premulAlpha = tk2dBatchedSprite3.spriteCollection != null && tk2dBatchedSprite3.spriteCollection.premultipliedAlpha;
					tk2dSpriteGeomGen.SetSpriteColors(array11, 0, num5, tk2dBatchedSprite3.color, premulAlpha);
				}
				Matrix4x4 matrix4x = identity * tk2dBatchedSprite3.relativeMatrix;
				for (int k = 0; k < num5; k++)
				{
					Vector3 vector = Vector3.Scale(array8[k], tk2dBatchedSprite3.baseScale);
					vector = matrix4x.MultiplyPoint(vector);
					if (flag4)
					{
						vector.z = 0f;
					}
					array4[num3 + k] = vector;
					array6[num3 + k] = array9[k];
					if (flag3)
					{
						array7[num3 + k] = array10[k];
					}
					array5[num3 + k] = array11[k];
					if (flag)
					{
						array2[num3 + k] = tk2dBatchedSprite3.rotation * array12[k];
					}
					if (flag2)
					{
						Vector3 vector2 = new Vector3(array13[k].x, array13[k].y, array13[k].z);
						vector2 = tk2dBatchedSprite3.rotation * vector2;
						array3[num3 + k] = new Vector4(vector2.x, vector2.y, vector2.z, array13[k].w);
					}
				}
				list5.AddRange(array14);
				num3 += num5;
				num4++;
			}
		}
		if (list5 != null)
		{
			list.Add(material);
			list2.Add(list5);
		}
		if (this.mesh)
		{
			this.mesh.vertices = array4;
			this.mesh.uv = array6;
			if (flag3)
			{
				this.mesh.uv2 = array7;
			}
			this.mesh.colors32 = array5;
			if (flag)
			{
				this.mesh.normals = array2;
			}
			if (flag2)
			{
				this.mesh.tangents = array3;
			}
			this.mesh.subMeshCount = list2.Count;
			for (int l = 0; l < list2.Count; l++)
			{
				this.mesh.SetTriangles(list2[l].ToArray(), l);
			}
			this.mesh.RecalculateBounds();
		}
		base.GetComponent<Renderer>().sharedMaterials = list.ToArray();
	}

	// Token: 0x06001F99 RID: 8089 RVA: 0x0009F0E4 File Offset: 0x0009D2E4
	private void BuildPhysicsMesh()
	{
		MeshCollider component = base.GetComponent<MeshCollider>();
		if (component != null)
		{
			if (base.GetComponent<Collider>() != component)
			{
				return;
			}
			if (!this.CheckFlag(tk2dStaticSpriteBatcher.Flags.GenerateCollider))
			{
				UnityEngine.Object.Destroy(component);
			}
		}
		EdgeCollider2D[] components = base.GetComponents<EdgeCollider2D>();
		if (!this.CheckFlag(tk2dStaticSpriteBatcher.Flags.GenerateCollider))
		{
			EdgeCollider2D[] array = components;
			for (int i = 0; i < array.Length; i++)
			{
				UnityEngine.Object.Destroy(array[i]);
			}
		}
		if (!this.CheckFlag(tk2dStaticSpriteBatcher.Flags.GenerateCollider))
		{
			return;
		}
		bool flattenDepth = this.CheckFlag(tk2dStaticSpriteBatcher.Flags.FlattenDepth);
		int num = 0;
		int num2 = 0;
		int num3 = 0;
		bool flag = true;
		foreach (tk2dBatchedSprite tk2dBatchedSprite in this.batchedSprites)
		{
			if (!tk2dBatchedSprite.IsDrawn)
			{
				break;
			}
			tk2dSpriteDefinition spriteDefinition = tk2dBatchedSprite.GetSpriteDefinition();
			bool flag2 = false;
			bool flag3 = false;
			switch (tk2dBatchedSprite.type)
			{
			case tk2dBatchedSprite.Type.Sprite:
				if (spriteDefinition != null && spriteDefinition.colliderType == tk2dSpriteDefinition.ColliderType.Mesh)
				{
					flag2 = true;
				}
				if (spriteDefinition != null && spriteDefinition.colliderType == tk2dSpriteDefinition.ColliderType.Box)
				{
					flag3 = true;
				}
				break;
			case tk2dBatchedSprite.Type.TiledSprite:
			case tk2dBatchedSprite.Type.SlicedSprite:
			case tk2dBatchedSprite.Type.ClippedSprite:
				flag3 = tk2dBatchedSprite.CheckFlag(tk2dBatchedSprite.Flags.Sprite_CreateBoxCollider);
				break;
			}
			if (flag2)
			{
				num += spriteDefinition.colliderIndicesFwd.Length;
				num2 += spriteDefinition.colliderVertices.Length;
				num3 += spriteDefinition.edgeCollider2D.Length;
				num3 += spriteDefinition.polygonCollider2D.Length;
			}
			else if (flag3)
			{
				num += 36;
				num2 += 8;
				num3++;
			}
			if (spriteDefinition.physicsEngine == tk2dSpriteDefinition.PhysicsEngine.Physics2D)
			{
				flag = false;
			}
		}
		if ((flag && num == 0) || (!flag && num3 == 0))
		{
			if (this.colliderMesh != null)
			{
				UnityEngine.Object.Destroy(this.colliderMesh);
				this.colliderMesh = null;
			}
			if (component != null)
			{
				UnityEngine.Object.Destroy(component);
			}
			EdgeCollider2D[] array = components;
			for (int i = 0; i < array.Length; i++)
			{
				UnityEngine.Object.Destroy(array[i]);
			}
			return;
		}
		if (flag)
		{
			EdgeCollider2D[] array = components;
			for (int i = 0; i < array.Length; i++)
			{
				UnityEngine.Object.Destroy(array[i]);
			}
		}
		else
		{
			if (this.colliderMesh != null)
			{
				UnityEngine.Object.Destroy(this.colliderMesh);
			}
			if (component != null)
			{
				UnityEngine.Object.Destroy(component);
			}
		}
		if (flag)
		{
			this.BuildPhysicsMesh3D(component, flattenDepth, num2, num);
			return;
		}
		this.BuildPhysicsMesh2D(components, num3);
	}

	// Token: 0x06001F9A RID: 8090 RVA: 0x0009F32C File Offset: 0x0009D52C
	private void BuildPhysicsMesh2D(EdgeCollider2D[] edgeColliders, int numEdgeColliders)
	{
		for (int i = numEdgeColliders; i < edgeColliders.Length; i++)
		{
			UnityEngine.Object.Destroy(edgeColliders[i]);
		}
		Vector2[] array = new Vector2[5];
		if (numEdgeColliders > edgeColliders.Length)
		{
			EdgeCollider2D[] array2 = new EdgeCollider2D[numEdgeColliders];
			int num = Mathf.Min(numEdgeColliders, edgeColliders.Length);
			for (int j = 0; j < num; j++)
			{
				array2[j] = edgeColliders[j];
			}
			for (int k = num; k < numEdgeColliders; k++)
			{
				array2[k] = base.gameObject.AddComponent<EdgeCollider2D>();
			}
			edgeColliders = array2;
		}
		Matrix4x4 identity = Matrix4x4.identity;
		identity.m00 = this._scale.x;
		identity.m11 = this._scale.y;
		identity.m22 = this._scale.z;
		int num2 = 0;
		foreach (tk2dBatchedSprite tk2dBatchedSprite in this.batchedSprites)
		{
			if (!tk2dBatchedSprite.IsDrawn)
			{
				break;
			}
			tk2dSpriteDefinition spriteDefinition = tk2dBatchedSprite.GetSpriteDefinition();
			bool flag = false;
			bool flag2 = false;
			Vector3 a = Vector3.zero;
			Vector3 b = Vector3.zero;
			switch (tk2dBatchedSprite.type)
			{
			case tk2dBatchedSprite.Type.Sprite:
				if (spriteDefinition != null && spriteDefinition.colliderType == tk2dSpriteDefinition.ColliderType.Mesh)
				{
					flag = true;
				}
				if (spriteDefinition != null && spriteDefinition.colliderType == tk2dSpriteDefinition.ColliderType.Box)
				{
					flag2 = true;
					a = spriteDefinition.colliderVertices[0];
					b = spriteDefinition.colliderVertices[1];
				}
				break;
			case tk2dBatchedSprite.Type.TiledSprite:
			case tk2dBatchedSprite.Type.SlicedSprite:
			case tk2dBatchedSprite.Type.ClippedSprite:
				flag2 = tk2dBatchedSprite.CheckFlag(tk2dBatchedSprite.Flags.Sprite_CreateBoxCollider);
				if (flag2)
				{
					a = tk2dBatchedSprite.CachedBoundsCenter;
					b = tk2dBatchedSprite.CachedBoundsExtents;
				}
				break;
			}
			Matrix4x4 matrix4x = identity * tk2dBatchedSprite.relativeMatrix;
			if (flag)
			{
				foreach (tk2dCollider2DData tk2dCollider2DData in spriteDefinition.edgeCollider2D)
				{
					Vector2[] array5 = new Vector2[tk2dCollider2DData.points.Length];
					for (int n = 0; n < tk2dCollider2DData.points.Length; n++)
					{
						array5[n] = matrix4x.MultiplyPoint(tk2dCollider2DData.points[n]);
					}
					edgeColliders[num2].points = array5;
				}
				foreach (tk2dCollider2DData tk2dCollider2DData2 in spriteDefinition.polygonCollider2D)
				{
					Vector2[] array6 = new Vector2[tk2dCollider2DData2.points.Length + 1];
					for (int num3 = 0; num3 < tk2dCollider2DData2.points.Length; num3++)
					{
						array6[num3] = matrix4x.MultiplyPoint(tk2dCollider2DData2.points[num3]);
					}
					array6[tk2dCollider2DData2.points.Length] = array6[0];
					edgeColliders[num2].points = array6;
				}
				num2++;
			}
			else if (flag2)
			{
				Vector3 vector = a - b;
				Vector3 vector2 = a + b;
				array[0] = matrix4x.MultiplyPoint(new Vector2(vector.x, vector.y));
				array[1] = matrix4x.MultiplyPoint(new Vector2(vector2.x, vector.y));
				array[2] = matrix4x.MultiplyPoint(new Vector2(vector2.x, vector2.y));
				array[3] = matrix4x.MultiplyPoint(new Vector2(vector.x, vector2.y));
				array[4] = array[0];
				edgeColliders[num2].points = array;
				num2++;
			}
		}
	}

	// Token: 0x06001F9B RID: 8091 RVA: 0x0009F6E8 File Offset: 0x0009D8E8
	private void BuildPhysicsMesh3D(MeshCollider meshCollider, bool flattenDepth, int numVertices, int numIndices)
	{
		if (meshCollider == null)
		{
			meshCollider = base.gameObject.AddComponent<MeshCollider>();
		}
		if (this.colliderMesh == null)
		{
			this.colliderMesh = new Mesh();
			this.colliderMesh.hideFlags = HideFlags.DontSave;
		}
		else
		{
			this.colliderMesh.Clear();
		}
		int num = 0;
		Vector3[] array = new Vector3[numVertices];
		int num2 = 0;
		int[] array2 = new int[numIndices];
		Matrix4x4 identity = Matrix4x4.identity;
		identity.m00 = this._scale.x;
		identity.m11 = this._scale.y;
		identity.m22 = this._scale.z;
		foreach (tk2dBatchedSprite tk2dBatchedSprite in this.batchedSprites)
		{
			if (!tk2dBatchedSprite.IsDrawn)
			{
				break;
			}
			tk2dSpriteDefinition spriteDefinition = tk2dBatchedSprite.GetSpriteDefinition();
			bool flag = false;
			bool flag2 = false;
			Vector3 origin = Vector3.zero;
			Vector3 extents = Vector3.zero;
			switch (tk2dBatchedSprite.type)
			{
			case tk2dBatchedSprite.Type.Sprite:
				if (spriteDefinition != null && spriteDefinition.colliderType == tk2dSpriteDefinition.ColliderType.Mesh)
				{
					flag = true;
				}
				if (spriteDefinition != null && spriteDefinition.colliderType == tk2dSpriteDefinition.ColliderType.Box)
				{
					flag2 = true;
					origin = spriteDefinition.colliderVertices[0];
					extents = spriteDefinition.colliderVertices[1];
				}
				break;
			case tk2dBatchedSprite.Type.TiledSprite:
			case tk2dBatchedSprite.Type.SlicedSprite:
			case tk2dBatchedSprite.Type.ClippedSprite:
				flag2 = tk2dBatchedSprite.CheckFlag(tk2dBatchedSprite.Flags.Sprite_CreateBoxCollider);
				if (flag2)
				{
					origin = tk2dBatchedSprite.CachedBoundsCenter;
					extents = tk2dBatchedSprite.CachedBoundsExtents;
				}
				break;
			}
			Matrix4x4 mat = identity * tk2dBatchedSprite.relativeMatrix;
			if (flattenDepth)
			{
				mat.m23 = 0f;
			}
			if (flag)
			{
				tk2dSpriteGeomGen.SetSpriteDefinitionMeshData(array, array2, num, num2, num, spriteDefinition, mat, tk2dBatchedSprite.baseScale);
				num += spriteDefinition.colliderVertices.Length;
				num2 += spriteDefinition.colliderIndicesFwd.Length;
			}
			else if (flag2)
			{
				tk2dSpriteGeomGen.SetBoxMeshData(array, array2, num, num2, num, origin, extents, mat, tk2dBatchedSprite.baseScale);
				num += 8;
				num2 += 36;
			}
		}
		this.colliderMesh.vertices = array;
		this.colliderMesh.triangles = array2;
		meshCollider.sharedMesh = this.colliderMesh;
	}

	// Token: 0x06001F9C RID: 8092 RVA: 0x0009F905 File Offset: 0x0009DB05
	public bool UsesSpriteCollection(tk2dSpriteCollectionData spriteCollection)
	{
		return this.spriteCollection == spriteCollection;
	}

	// Token: 0x06001F9D RID: 8093 RVA: 0x0009E353 File Offset: 0x0009C553
	public void ForceBuild()
	{
		this.Build();
	}

	// Token: 0x06001F9E RID: 8094 RVA: 0x0009F913 File Offset: 0x0009DB13
	public tk2dStaticSpriteBatcher()
	{
		this.flags = tk2dStaticSpriteBatcher.Flags.GenerateCollider;
		this._scale = new Vector3(1f, 1f, 1f);
		base..ctor();
	}

	// Token: 0x06001F9F RID: 8095 RVA: 0x0009F93C File Offset: 0x0009DB3C
	// Note: this type is marked as 'beforefieldinit'.
	static tk2dStaticSpriteBatcher()
	{
		tk2dStaticSpriteBatcher.CURRENT_VERSION = 3;
	}

	// Token: 0x04002583 RID: 9603
	public static int CURRENT_VERSION;

	// Token: 0x04002584 RID: 9604
	public int version;

	// Token: 0x04002585 RID: 9605
	public tk2dBatchedSprite[] batchedSprites;

	// Token: 0x04002586 RID: 9606
	public tk2dTextMeshData[] allTextMeshData;

	// Token: 0x04002587 RID: 9607
	public tk2dSpriteCollectionData spriteCollection;

	// Token: 0x04002588 RID: 9608
	[SerializeField]
	private tk2dStaticSpriteBatcher.Flags flags;

	// Token: 0x04002589 RID: 9609
	private Mesh mesh;

	// Token: 0x0400258A RID: 9610
	private Mesh colliderMesh;

	// Token: 0x0400258B RID: 9611
	[SerializeField]
	private Vector3 _scale;

	// Token: 0x02000591 RID: 1425
	public enum Flags
	{
		// Token: 0x0400258D RID: 9613
		None,
		// Token: 0x0400258E RID: 9614
		GenerateCollider,
		// Token: 0x0400258F RID: 9615
		FlattenDepth,
		// Token: 0x04002590 RID: 9616
		SortToCamera = 4
	}
}
