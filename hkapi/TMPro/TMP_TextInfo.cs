using System;
using UnityEngine;

namespace TMPro
{
	// Token: 0x0200061F RID: 1567
	[Serializable]
	public class TMP_TextInfo
	{
		// Token: 0x060025C0 RID: 9664 RVA: 0x000C5D50 File Offset: 0x000C3F50
		public TMP_TextInfo()
		{
			this.characterInfo = new TMP_CharacterInfo[8];
			this.wordInfo = new TMP_WordInfo[16];
			this.linkInfo = new TMP_LinkInfo[0];
			this.lineInfo = new TMP_LineInfo[2];
			this.pageInfo = new TMP_PageInfo[16];
			this.meshInfo = new TMP_MeshInfo[1];
		}

		// Token: 0x060025C1 RID: 9665 RVA: 0x000C5DB0 File Offset: 0x000C3FB0
		public TMP_TextInfo(TMP_Text textComponent)
		{
			this.textComponent = textComponent;
			this.characterInfo = new TMP_CharacterInfo[8];
			this.wordInfo = new TMP_WordInfo[4];
			this.linkInfo = new TMP_LinkInfo[0];
			this.lineInfo = new TMP_LineInfo[2];
			this.pageInfo = new TMP_PageInfo[16];
			this.meshInfo = new TMP_MeshInfo[1];
			this.meshInfo[0].mesh = textComponent.mesh;
			this.materialCount = 1;
		}

		// Token: 0x060025C2 RID: 9666 RVA: 0x000C5E34 File Offset: 0x000C4034
		public void Clear()
		{
			this.characterCount = 0;
			this.spaceCount = 0;
			this.wordCount = 0;
			this.linkCount = 0;
			this.lineCount = 0;
			this.pageCount = 0;
			this.spriteCount = 0;
			for (int i = 0; i < this.meshInfo.Length; i++)
			{
				this.meshInfo[i].vertexCount = 0;
			}
		}

		// Token: 0x060025C3 RID: 9667 RVA: 0x000C5E98 File Offset: 0x000C4098
		public void ClearMeshInfo(bool updateMesh)
		{
			for (int i = 0; i < this.meshInfo.Length; i++)
			{
				this.meshInfo[i].Clear(updateMesh);
			}
		}

		// Token: 0x060025C4 RID: 9668 RVA: 0x000C5ECC File Offset: 0x000C40CC
		public void ClearAllMeshInfo()
		{
			for (int i = 0; i < this.meshInfo.Length; i++)
			{
				this.meshInfo[i].Clear(true);
			}
		}

		// Token: 0x060025C5 RID: 9669 RVA: 0x000C5F00 File Offset: 0x000C4100
		public void ResetVertexLayout(bool isVolumetric)
		{
			for (int i = 0; i < this.meshInfo.Length; i++)
			{
				this.meshInfo[i].ResizeMeshInfo(0, isVolumetric);
			}
		}

		// Token: 0x060025C6 RID: 9670 RVA: 0x000C5F34 File Offset: 0x000C4134
		public void ClearUnusedVertices(MaterialReference[] materials)
		{
			for (int i = 0; i < this.meshInfo.Length; i++)
			{
				int startIndex = 0;
				this.meshInfo[i].ClearUnusedVertices(startIndex);
			}
		}

		// Token: 0x060025C7 RID: 9671 RVA: 0x000C5F68 File Offset: 0x000C4168
		public void ClearLineInfo()
		{
			if (this.lineInfo == null)
			{
				this.lineInfo = new TMP_LineInfo[2];
			}
			for (int i = 0; i < this.lineInfo.Length; i++)
			{
				this.lineInfo[i].characterCount = 0;
				this.lineInfo[i].spaceCount = 0;
				this.lineInfo[i].width = 0f;
				this.lineInfo[i].ascender = TMP_TextInfo.k_InfinityVectorNegative.x;
				this.lineInfo[i].descender = TMP_TextInfo.k_InfinityVectorPositive.x;
				this.lineInfo[i].lineExtents.min = TMP_TextInfo.k_InfinityVectorPositive;
				this.lineInfo[i].lineExtents.max = TMP_TextInfo.k_InfinityVectorNegative;
				this.lineInfo[i].maxAdvance = 0f;
			}
		}

		// Token: 0x060025C8 RID: 9672 RVA: 0x000C6060 File Offset: 0x000C4260
		public TMP_MeshInfo[] CopyMeshInfoVertexData()
		{
			if (this.m_CachedMeshInfo == null || this.m_CachedMeshInfo.Length != this.meshInfo.Length)
			{
				this.m_CachedMeshInfo = new TMP_MeshInfo[this.meshInfo.Length];
				for (int i = 0; i < this.m_CachedMeshInfo.Length; i++)
				{
					int num = this.meshInfo[i].vertices.Length;
					this.m_CachedMeshInfo[i].vertices = new Vector3[num];
					this.m_CachedMeshInfo[i].uvs0 = new Vector2[num];
					this.m_CachedMeshInfo[i].uvs2 = new Vector2[num];
					this.m_CachedMeshInfo[i].colors32 = new Color32[num];
				}
			}
			for (int j = 0; j < this.m_CachedMeshInfo.Length; j++)
			{
				int num2 = this.meshInfo[j].vertices.Length;
				if (this.m_CachedMeshInfo[j].vertices.Length != num2)
				{
					this.m_CachedMeshInfo[j].vertices = new Vector3[num2];
					this.m_CachedMeshInfo[j].uvs0 = new Vector2[num2];
					this.m_CachedMeshInfo[j].uvs2 = new Vector2[num2];
					this.m_CachedMeshInfo[j].colors32 = new Color32[num2];
				}
				Array.Copy(this.meshInfo[j].vertices, this.m_CachedMeshInfo[j].vertices, num2);
				Array.Copy(this.meshInfo[j].uvs0, this.m_CachedMeshInfo[j].uvs0, num2);
				Array.Copy(this.meshInfo[j].uvs2, this.m_CachedMeshInfo[j].uvs2, num2);
				Array.Copy(this.meshInfo[j].colors32, this.m_CachedMeshInfo[j].colors32, num2);
			}
			return this.m_CachedMeshInfo;
		}

		// Token: 0x060025C9 RID: 9673 RVA: 0x000C6268 File Offset: 0x000C4468
		public static void Resize<T>(ref T[] array, int size)
		{
			int newSize = (size > 1024) ? (size + 256) : Mathf.NextPowerOfTwo(size);
			Array.Resize<T>(ref array, newSize);
		}

		// Token: 0x060025CA RID: 9674 RVA: 0x000C6294 File Offset: 0x000C4494
		public static void Resize<T>(ref T[] array, int size, bool isBlockAllocated)
		{
			if (isBlockAllocated)
			{
				size = ((size > 1024) ? (size + 256) : Mathf.NextPowerOfTwo(size));
			}
			if (size == array.Length)
			{
				return;
			}
			Array.Resize<T>(ref array, size);
		}

		// Token: 0x060025CB RID: 9675 RVA: 0x000C62C3 File Offset: 0x000C44C3
		// Note: this type is marked as 'beforefieldinit'.
		static TMP_TextInfo()
		{
			TMP_TextInfo.k_InfinityVectorPositive = new Vector2(1000000f, 1000000f);
			TMP_TextInfo.k_InfinityVectorNegative = new Vector2(-1000000f, -1000000f);
		}

		// Token: 0x040029CF RID: 10703
		private static Vector2 k_InfinityVectorPositive;

		// Token: 0x040029D0 RID: 10704
		private static Vector2 k_InfinityVectorNegative;

		// Token: 0x040029D1 RID: 10705
		public TMP_Text textComponent;

		// Token: 0x040029D2 RID: 10706
		public int characterCount;

		// Token: 0x040029D3 RID: 10707
		public int spriteCount;

		// Token: 0x040029D4 RID: 10708
		public int spaceCount;

		// Token: 0x040029D5 RID: 10709
		public int wordCount;

		// Token: 0x040029D6 RID: 10710
		public int linkCount;

		// Token: 0x040029D7 RID: 10711
		public int lineCount;

		// Token: 0x040029D8 RID: 10712
		public int pageCount;

		// Token: 0x040029D9 RID: 10713
		public int materialCount;

		// Token: 0x040029DA RID: 10714
		public TMP_CharacterInfo[] characterInfo;

		// Token: 0x040029DB RID: 10715
		public TMP_WordInfo[] wordInfo;

		// Token: 0x040029DC RID: 10716
		public TMP_LinkInfo[] linkInfo;

		// Token: 0x040029DD RID: 10717
		public TMP_LineInfo[] lineInfo;

		// Token: 0x040029DE RID: 10718
		public TMP_PageInfo[] pageInfo;

		// Token: 0x040029DF RID: 10719
		public TMP_MeshInfo[] meshInfo;

		// Token: 0x040029E0 RID: 10720
		private TMP_MeshInfo[] m_CachedMeshInfo;
	}
}
