using System;
using System.Collections.Generic;
using UnityEngine;

namespace TMPro
{
	// Token: 0x02000606 RID: 1542
	public struct TMP_MeshInfo
	{
		// Token: 0x0600244D RID: 9293 RVA: 0x000BA934 File Offset: 0x000B8B34
		public TMP_MeshInfo(Mesh mesh, int size)
		{
			if (mesh == null)
			{
				mesh = new Mesh();
			}
			else
			{
				mesh.Clear();
			}
			this.mesh = mesh;
			size = Mathf.Min(size, 16383);
			int num = size * 4;
			int num2 = size * 6;
			this.vertexCount = 0;
			this.vertices = new Vector3[num];
			this.uvs0 = new Vector2[num];
			this.uvs2 = new Vector2[num];
			this.colors32 = new Color32[num];
			this.normals = new Vector3[num];
			this.tangents = new Vector4[num];
			this.triangles = new int[num2];
			int num3 = 0;
			int num4 = 0;
			while (num4 / 4 < size)
			{
				for (int i = 0; i < 4; i++)
				{
					this.vertices[num4 + i] = Vector3.zero;
					this.uvs0[num4 + i] = Vector2.zero;
					this.uvs2[num4 + i] = Vector2.zero;
					this.colors32[num4 + i] = TMP_MeshInfo.s_DefaultColor;
					this.normals[num4 + i] = TMP_MeshInfo.s_DefaultNormal;
					this.tangents[num4 + i] = TMP_MeshInfo.s_DefaultTangent;
				}
				this.triangles[num3] = num4;
				this.triangles[num3 + 1] = num4 + 1;
				this.triangles[num3 + 2] = num4 + 2;
				this.triangles[num3 + 3] = num4 + 2;
				this.triangles[num3 + 4] = num4 + 3;
				this.triangles[num3 + 5] = num4;
				num4 += 4;
				num3 += 6;
			}
			this.mesh.vertices = this.vertices;
			this.mesh.normals = this.normals;
			this.mesh.tangents = this.tangents;
			this.mesh.triangles = this.triangles;
			this.mesh.bounds = new Bounds(Vector3.zero, new Vector3(3840f, 2160f, 0f));
		}

		// Token: 0x0600244E RID: 9294 RVA: 0x000BAB30 File Offset: 0x000B8D30
		public TMP_MeshInfo(Mesh mesh, int size, bool isVolumetric)
		{
			if (mesh == null)
			{
				mesh = new Mesh();
			}
			else
			{
				mesh.Clear();
			}
			this.mesh = mesh;
			int num = (!isVolumetric) ? 4 : 8;
			int num2 = (!isVolumetric) ? 6 : 36;
			size = Mathf.Min(size, 65532 / num);
			int num3 = size * num;
			int num4 = size * num2;
			this.vertexCount = 0;
			this.vertices = new Vector3[num3];
			this.uvs0 = new Vector2[num3];
			this.uvs2 = new Vector2[num3];
			this.colors32 = new Color32[num3];
			this.normals = new Vector3[num3];
			this.tangents = new Vector4[num3];
			this.triangles = new int[num4];
			int num5 = 0;
			int num6 = 0;
			while (num5 / num < size)
			{
				for (int i = 0; i < num; i++)
				{
					this.vertices[num5 + i] = Vector3.zero;
					this.uvs0[num5 + i] = Vector2.zero;
					this.uvs2[num5 + i] = Vector2.zero;
					this.colors32[num5 + i] = TMP_MeshInfo.s_DefaultColor;
					this.normals[num5 + i] = TMP_MeshInfo.s_DefaultNormal;
					this.tangents[num5 + i] = TMP_MeshInfo.s_DefaultTangent;
				}
				this.triangles[num6] = num5;
				this.triangles[num6 + 1] = num5 + 1;
				this.triangles[num6 + 2] = num5 + 2;
				this.triangles[num6 + 3] = num5 + 2;
				this.triangles[num6 + 4] = num5 + 3;
				this.triangles[num6 + 5] = num5;
				if (isVolumetric)
				{
					this.triangles[num6 + 6] = num5 + 4;
					this.triangles[num6 + 7] = num5 + 5;
					this.triangles[num6 + 8] = num5 + 1;
					this.triangles[num6 + 9] = num5 + 1;
					this.triangles[num6 + 10] = num5;
					this.triangles[num6 + 11] = num5 + 4;
					this.triangles[num6 + 12] = num5 + 3;
					this.triangles[num6 + 13] = num5 + 2;
					this.triangles[num6 + 14] = num5 + 6;
					this.triangles[num6 + 15] = num5 + 6;
					this.triangles[num6 + 16] = num5 + 7;
					this.triangles[num6 + 17] = num5 + 3;
					this.triangles[num6 + 18] = num5 + 1;
					this.triangles[num6 + 19] = num5 + 5;
					this.triangles[num6 + 20] = num5 + 6;
					this.triangles[num6 + 21] = num5 + 6;
					this.triangles[num6 + 22] = num5 + 2;
					this.triangles[num6 + 23] = num5 + 1;
					this.triangles[num6 + 24] = num5 + 4;
					this.triangles[num6 + 25] = num5;
					this.triangles[num6 + 26] = num5 + 3;
					this.triangles[num6 + 27] = num5 + 3;
					this.triangles[num6 + 28] = num5 + 7;
					this.triangles[num6 + 29] = num5 + 4;
					this.triangles[num6 + 30] = num5 + 7;
					this.triangles[num6 + 31] = num5 + 6;
					this.triangles[num6 + 32] = num5 + 5;
					this.triangles[num6 + 33] = num5 + 5;
					this.triangles[num6 + 34] = num5 + 4;
					this.triangles[num6 + 35] = num5 + 7;
				}
				num5 += num;
				num6 += num2;
			}
			this.mesh.vertices = this.vertices;
			this.mesh.normals = this.normals;
			this.mesh.tangents = this.tangents;
			this.mesh.triangles = this.triangles;
			this.mesh.bounds = new Bounds(Vector3.zero, new Vector3(3840f, 2160f, 64f));
		}

		// Token: 0x0600244F RID: 9295 RVA: 0x000BAF38 File Offset: 0x000B9138
		public void ResizeMeshInfo(int size)
		{
			size = Mathf.Min(size, 16383);
			int newSize = size * 4;
			int newSize2 = size * 6;
			int num = this.vertices.Length / 4;
			Array.Resize<Vector3>(ref this.vertices, newSize);
			Array.Resize<Vector3>(ref this.normals, newSize);
			Array.Resize<Vector4>(ref this.tangents, newSize);
			Array.Resize<Vector2>(ref this.uvs0, newSize);
			Array.Resize<Vector2>(ref this.uvs2, newSize);
			Array.Resize<Color32>(ref this.colors32, newSize);
			Array.Resize<int>(ref this.triangles, newSize2);
			if (size <= num)
			{
				this.mesh.triangles = this.triangles;
				this.mesh.vertices = this.vertices;
				this.mesh.normals = this.normals;
				this.mesh.tangents = this.tangents;
				return;
			}
			for (int i = num; i < size; i++)
			{
				int num2 = i * 4;
				int num3 = i * 6;
				this.normals[num2] = TMP_MeshInfo.s_DefaultNormal;
				this.normals[1 + num2] = TMP_MeshInfo.s_DefaultNormal;
				this.normals[2 + num2] = TMP_MeshInfo.s_DefaultNormal;
				this.normals[3 + num2] = TMP_MeshInfo.s_DefaultNormal;
				this.tangents[num2] = TMP_MeshInfo.s_DefaultTangent;
				this.tangents[1 + num2] = TMP_MeshInfo.s_DefaultTangent;
				this.tangents[2 + num2] = TMP_MeshInfo.s_DefaultTangent;
				this.tangents[3 + num2] = TMP_MeshInfo.s_DefaultTangent;
				this.triangles[num3] = num2;
				this.triangles[1 + num3] = 1 + num2;
				this.triangles[2 + num3] = 2 + num2;
				this.triangles[3 + num3] = 2 + num2;
				this.triangles[4 + num3] = 3 + num2;
				this.triangles[5 + num3] = num2;
			}
			this.mesh.vertices = this.vertices;
			this.mesh.normals = this.normals;
			this.mesh.tangents = this.tangents;
			this.mesh.triangles = this.triangles;
		}

		// Token: 0x06002450 RID: 9296 RVA: 0x000BB154 File Offset: 0x000B9354
		public void ResizeMeshInfo(int size, bool isVolumetric)
		{
			int num = (!isVolumetric) ? 4 : 8;
			int num2 = (!isVolumetric) ? 6 : 36;
			size = Mathf.Min(size, 65532 / num);
			int newSize = size * num;
			int newSize2 = size * num2;
			int num3 = this.vertices.Length / num;
			Array.Resize<Vector3>(ref this.vertices, newSize);
			Array.Resize<Vector3>(ref this.normals, newSize);
			Array.Resize<Vector4>(ref this.tangents, newSize);
			Array.Resize<Vector2>(ref this.uvs0, newSize);
			Array.Resize<Vector2>(ref this.uvs2, newSize);
			Array.Resize<Color32>(ref this.colors32, newSize);
			Array.Resize<int>(ref this.triangles, newSize2);
			if (size <= num3)
			{
				this.mesh.triangles = this.triangles;
				this.mesh.vertices = this.vertices;
				this.mesh.normals = this.normals;
				this.mesh.tangents = this.tangents;
				return;
			}
			for (int i = num3; i < size; i++)
			{
				int num4 = i * num;
				int num5 = i * num2;
				this.normals[num4] = TMP_MeshInfo.s_DefaultNormal;
				this.normals[1 + num4] = TMP_MeshInfo.s_DefaultNormal;
				this.normals[2 + num4] = TMP_MeshInfo.s_DefaultNormal;
				this.normals[3 + num4] = TMP_MeshInfo.s_DefaultNormal;
				this.tangents[num4] = TMP_MeshInfo.s_DefaultTangent;
				this.tangents[1 + num4] = TMP_MeshInfo.s_DefaultTangent;
				this.tangents[2 + num4] = TMP_MeshInfo.s_DefaultTangent;
				this.tangents[3 + num4] = TMP_MeshInfo.s_DefaultTangent;
				if (isVolumetric)
				{
					this.normals[4 + num4] = TMP_MeshInfo.s_DefaultNormal;
					this.normals[5 + num4] = TMP_MeshInfo.s_DefaultNormal;
					this.normals[6 + num4] = TMP_MeshInfo.s_DefaultNormal;
					this.normals[7 + num4] = TMP_MeshInfo.s_DefaultNormal;
					this.tangents[4 + num4] = TMP_MeshInfo.s_DefaultTangent;
					this.tangents[5 + num4] = TMP_MeshInfo.s_DefaultTangent;
					this.tangents[6 + num4] = TMP_MeshInfo.s_DefaultTangent;
					this.tangents[7 + num4] = TMP_MeshInfo.s_DefaultTangent;
				}
				this.triangles[num5] = num4;
				this.triangles[1 + num5] = 1 + num4;
				this.triangles[2 + num5] = 2 + num4;
				this.triangles[3 + num5] = 2 + num4;
				this.triangles[4 + num5] = 3 + num4;
				this.triangles[5 + num5] = num4;
				if (isVolumetric)
				{
					this.triangles[num5 + 6] = num4 + 4;
					this.triangles[num5 + 7] = num4 + 5;
					this.triangles[num5 + 8] = num4 + 1;
					this.triangles[num5 + 9] = num4 + 1;
					this.triangles[num5 + 10] = num4;
					this.triangles[num5 + 11] = num4 + 4;
					this.triangles[num5 + 12] = num4 + 3;
					this.triangles[num5 + 13] = num4 + 2;
					this.triangles[num5 + 14] = num4 + 6;
					this.triangles[num5 + 15] = num4 + 6;
					this.triangles[num5 + 16] = num4 + 7;
					this.triangles[num5 + 17] = num4 + 3;
					this.triangles[num5 + 18] = num4 + 1;
					this.triangles[num5 + 19] = num4 + 5;
					this.triangles[num5 + 20] = num4 + 6;
					this.triangles[num5 + 21] = num4 + 6;
					this.triangles[num5 + 22] = num4 + 2;
					this.triangles[num5 + 23] = num4 + 1;
					this.triangles[num5 + 24] = num4 + 4;
					this.triangles[num5 + 25] = num4;
					this.triangles[num5 + 26] = num4 + 3;
					this.triangles[num5 + 27] = num4 + 3;
					this.triangles[num5 + 28] = num4 + 7;
					this.triangles[num5 + 29] = num4 + 4;
					this.triangles[num5 + 30] = num4 + 7;
					this.triangles[num5 + 31] = num4 + 6;
					this.triangles[num5 + 32] = num4 + 5;
					this.triangles[num5 + 33] = num4 + 5;
					this.triangles[num5 + 34] = num4 + 4;
					this.triangles[num5 + 35] = num4 + 7;
				}
			}
			this.mesh.vertices = this.vertices;
			this.mesh.normals = this.normals;
			this.mesh.tangents = this.tangents;
			this.mesh.triangles = this.triangles;
		}

		// Token: 0x06002451 RID: 9297 RVA: 0x000BB614 File Offset: 0x000B9814
		public void Clear()
		{
			if (this.vertices == null)
			{
				return;
			}
			Array.Clear(this.vertices, 0, this.vertices.Length);
			this.vertexCount = 0;
			if (this.mesh != null)
			{
				this.mesh.vertices = this.vertices;
			}
		}

		// Token: 0x06002452 RID: 9298 RVA: 0x000BB664 File Offset: 0x000B9864
		public void Clear(bool uploadChanges)
		{
			if (this.vertices == null)
			{
				return;
			}
			Array.Clear(this.vertices, 0, this.vertices.Length);
			this.vertexCount = 0;
			if (uploadChanges && this.mesh != null)
			{
				this.mesh.vertices = this.vertices;
			}
		}

		// Token: 0x06002453 RID: 9299 RVA: 0x000BB6B8 File Offset: 0x000B98B8
		public void ClearUnusedVertices()
		{
			int num = this.vertices.Length - this.vertexCount;
			if (num > 0)
			{
				Array.Clear(this.vertices, this.vertexCount, num);
			}
		}

		// Token: 0x06002454 RID: 9300 RVA: 0x000BB6EC File Offset: 0x000B98EC
		public void ClearUnusedVertices(int startIndex)
		{
			int num = this.vertices.Length - startIndex;
			if (num > 0)
			{
				Array.Clear(this.vertices, startIndex, num);
			}
		}

		// Token: 0x06002455 RID: 9301 RVA: 0x000BB718 File Offset: 0x000B9918
		public void ClearUnusedVertices(int startIndex, bool updateMesh)
		{
			int num = this.vertices.Length - startIndex;
			if (num > 0)
			{
				Array.Clear(this.vertices, startIndex, num);
			}
			if (updateMesh && this.mesh != null)
			{
				this.mesh.vertices = this.vertices;
			}
		}

		// Token: 0x06002456 RID: 9302 RVA: 0x000BB763 File Offset: 0x000B9963
		public void SortGeometry(VertexSortingOrder order)
		{
			switch (order)
			{
			default:
				return;
			}
		}

		// Token: 0x06002457 RID: 9303 RVA: 0x000BB778 File Offset: 0x000B9978
		public void SortGeometry(IList<int> sortingOrder)
		{
			int count = sortingOrder.Count;
			if (count * 4 > this.vertices.Length)
			{
				return;
			}
			for (int i = 0; i < count; i++)
			{
				int j;
				for (j = sortingOrder[i]; j < i; j = sortingOrder[j])
				{
				}
				if (j != i)
				{
					this.SwapVertexData(j * 4, i * 4);
				}
			}
		}

		// Token: 0x06002458 RID: 9304 RVA: 0x000BB7CC File Offset: 0x000B99CC
		public void SwapVertexData(int src, int dst)
		{
			Vector3 vector = this.vertices[dst];
			this.vertices[dst] = this.vertices[src];
			this.vertices[src] = vector;
			vector = this.vertices[dst + 1];
			this.vertices[dst + 1] = this.vertices[src + 1];
			this.vertices[src + 1] = vector;
			vector = this.vertices[dst + 2];
			this.vertices[dst + 2] = this.vertices[src + 2];
			this.vertices[src + 2] = vector;
			vector = this.vertices[dst + 3];
			this.vertices[dst + 3] = this.vertices[src + 3];
			this.vertices[src + 3] = vector;
			Vector2 vector2 = this.uvs0[dst];
			this.uvs0[dst] = this.uvs0[src];
			this.uvs0[src] = vector2;
			vector2 = this.uvs0[dst + 1];
			this.uvs0[dst + 1] = this.uvs0[src + 1];
			this.uvs0[src + 1] = vector2;
			vector2 = this.uvs0[dst + 2];
			this.uvs0[dst + 2] = this.uvs0[src + 2];
			this.uvs0[src + 2] = vector2;
			vector2 = this.uvs0[dst + 3];
			this.uvs0[dst + 3] = this.uvs0[src + 3];
			this.uvs0[src + 3] = vector2;
			vector2 = this.uvs2[dst];
			this.uvs2[dst] = this.uvs2[src];
			this.uvs2[src] = vector2;
			vector2 = this.uvs2[dst + 1];
			this.uvs2[dst + 1] = this.uvs2[src + 1];
			this.uvs2[src + 1] = vector2;
			vector2 = this.uvs2[dst + 2];
			this.uvs2[dst + 2] = this.uvs2[src + 2];
			this.uvs2[src + 2] = vector2;
			vector2 = this.uvs2[dst + 3];
			this.uvs2[dst + 3] = this.uvs2[src + 3];
			this.uvs2[src + 3] = vector2;
			Color32 color = this.colors32[dst];
			this.colors32[dst] = this.colors32[src];
			this.colors32[src] = color;
			color = this.colors32[dst + 1];
			this.colors32[dst + 1] = this.colors32[src + 1];
			this.colors32[src + 1] = color;
			color = this.colors32[dst + 2];
			this.colors32[dst + 2] = this.colors32[src + 2];
			this.colors32[src + 2] = color;
			color = this.colors32[dst + 3];
			this.colors32[dst + 3] = this.colors32[src + 3];
			this.colors32[src + 3] = color;
		}

		// Token: 0x06002459 RID: 9305 RVA: 0x000BBB68 File Offset: 0x000B9D68
		// Note: this type is marked as 'beforefieldinit'.
		static TMP_MeshInfo()
		{
			TMP_MeshInfo.s_DefaultColor = new Color32(byte.MaxValue, byte.MaxValue, byte.MaxValue, byte.MaxValue);
			TMP_MeshInfo.s_DefaultNormal = new Vector3(0f, 0f, -1f);
			TMP_MeshInfo.s_DefaultTangent = new Vector4(-1f, 0f, 0f, 1f);
		}

		// Token: 0x0400286D RID: 10349
		private static readonly Color32 s_DefaultColor;

		// Token: 0x0400286E RID: 10350
		private static readonly Vector3 s_DefaultNormal;

		// Token: 0x0400286F RID: 10351
		private static readonly Vector4 s_DefaultTangent;

		// Token: 0x04002870 RID: 10352
		public Mesh mesh;

		// Token: 0x04002871 RID: 10353
		public int vertexCount;

		// Token: 0x04002872 RID: 10354
		public Vector3[] vertices;

		// Token: 0x04002873 RID: 10355
		public Vector3[] normals;

		// Token: 0x04002874 RID: 10356
		public Vector4[] tangents;

		// Token: 0x04002875 RID: 10357
		public Vector2[] uvs0;

		// Token: 0x04002876 RID: 10358
		public Vector2[] uvs2;

		// Token: 0x04002877 RID: 10359
		public Color32[] colors32;

		// Token: 0x04002878 RID: 10360
		public int[] triangles;
	}
}
