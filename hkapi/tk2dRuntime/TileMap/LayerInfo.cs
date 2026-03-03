using System;
using UnityEngine;

namespace tk2dRuntime.TileMap
{
	// Token: 0x02000657 RID: 1623
	[Serializable]
	public class LayerInfo
	{
		// Token: 0x06002758 RID: 10072 RVA: 0x000DE570 File Offset: 0x000DC770
		public LayerInfo()
		{
			this.z = 0.1f;
			this.sortingLayerName = "";
			base..ctor();
			this.unityLayer = 0;
			this.useColor = true;
			this.generateCollider = true;
			this.skipMeshGeneration = false;
		}

		// Token: 0x04002B66 RID: 11110
		public string name;

		// Token: 0x04002B67 RID: 11111
		public int hash;

		// Token: 0x04002B68 RID: 11112
		public bool useColor;

		// Token: 0x04002B69 RID: 11113
		public bool generateCollider;

		// Token: 0x04002B6A RID: 11114
		public float z;

		// Token: 0x04002B6B RID: 11115
		public int unityLayer;

		// Token: 0x04002B6C RID: 11116
		public string sortingLayerName;

		// Token: 0x04002B6D RID: 11117
		public int sortingOrder;

		// Token: 0x04002B6E RID: 11118
		public bool skipMeshGeneration;

		// Token: 0x04002B6F RID: 11119
		public PhysicMaterial physicMaterial;

		// Token: 0x04002B70 RID: 11120
		public PhysicsMaterial2D physicsMaterial2D;
	}
}
