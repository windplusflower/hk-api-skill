using System;
using System.Collections.Generic;
using UnityEngine;

namespace tk2dRuntime.TileMap
{
	// Token: 0x0200064C RID: 1612
	[Serializable]
	public class SpriteChunk
	{
		// Token: 0x0600270C RID: 9996 RVA: 0x000DC468 File Offset: 0x000DA668
		public SpriteChunk()
		{
			this.edgeColliders = new List<EdgeCollider2D>();
			base..ctor();
			this.spriteIds = new int[0];
		}

		// Token: 0x17000559 RID: 1369
		// (get) Token: 0x0600270D RID: 9997 RVA: 0x000DC487 File Offset: 0x000DA687
		// (set) Token: 0x0600270E RID: 9998 RVA: 0x000DC48F File Offset: 0x000DA68F
		public bool Dirty
		{
			get
			{
				return this.dirty;
			}
			set
			{
				this.dirty = value;
			}
		}

		// Token: 0x1700055A RID: 1370
		// (get) Token: 0x0600270F RID: 9999 RVA: 0x000DC498 File Offset: 0x000DA698
		public bool IsEmpty
		{
			get
			{
				return this.spriteIds.Length == 0;
			}
		}

		// Token: 0x1700055B RID: 1371
		// (get) Token: 0x06002710 RID: 10000 RVA: 0x000DC4A4 File Offset: 0x000DA6A4
		public bool HasGameData
		{
			get
			{
				return this.gameObject != null || this.mesh != null || this.meshCollider != null || this.colliderMesh != null || this.edgeColliders.Count > 0;
			}
		}

		// Token: 0x06002711 RID: 10001 RVA: 0x000DC4FC File Offset: 0x000DA6FC
		public void DestroyGameData(tk2dTileMap tileMap)
		{
			if (this.mesh != null)
			{
				tileMap.DestroyMesh(this.mesh);
			}
			if (this.gameObject != null)
			{
				tk2dUtil.DestroyImmediate(this.gameObject);
			}
			this.gameObject = null;
			this.mesh = null;
			this.DestroyColliderData(tileMap);
		}

		// Token: 0x06002712 RID: 10002 RVA: 0x000DC554 File Offset: 0x000DA754
		public void DestroyColliderData(tk2dTileMap tileMap)
		{
			if (this.colliderMesh != null)
			{
				tileMap.DestroyMesh(this.colliderMesh);
			}
			if (this.meshCollider != null && this.meshCollider.sharedMesh != null && this.meshCollider.sharedMesh != this.colliderMesh)
			{
				tileMap.DestroyMesh(this.meshCollider.sharedMesh);
			}
			if (this.meshCollider != null)
			{
				tk2dUtil.DestroyImmediate(this.meshCollider);
			}
			this.meshCollider = null;
			this.colliderMesh = null;
			if (this.edgeColliders.Count > 0)
			{
				for (int i = 0; i < this.edgeColliders.Count; i++)
				{
					tk2dUtil.DestroyImmediate(this.edgeColliders[i]);
				}
				this.edgeColliders.Clear();
			}
		}

		// Token: 0x04002B47 RID: 11079
		private bool dirty;

		// Token: 0x04002B48 RID: 11080
		public int[] spriteIds;

		// Token: 0x04002B49 RID: 11081
		public GameObject gameObject;

		// Token: 0x04002B4A RID: 11082
		public Mesh mesh;

		// Token: 0x04002B4B RID: 11083
		public MeshCollider meshCollider;

		// Token: 0x04002B4C RID: 11084
		public Mesh colliderMesh;

		// Token: 0x04002B4D RID: 11085
		public List<EdgeCollider2D> edgeColliders;
	}
}
