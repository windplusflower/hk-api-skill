using System;
using System.Collections.Generic;
using UnityEngine;

namespace TMPro
{
	// Token: 0x020005D5 RID: 1493
	public struct MaterialReference
	{
		// Token: 0x060022E8 RID: 8936 RVA: 0x000B4368 File Offset: 0x000B2568
		public MaterialReference(int index, TMP_FontAsset fontAsset, TMP_SpriteAsset spriteAsset, Material material, float padding)
		{
			this.index = index;
			this.fontAsset = fontAsset;
			this.spriteAsset = spriteAsset;
			this.material = material;
			this.isDefaultMaterial = (material.GetInstanceID() == fontAsset.material.GetInstanceID());
			this.isFallbackMaterial = false;
			this.fallbackMaterial = null;
			this.padding = padding;
			this.referenceCount = 0;
		}

		// Token: 0x060022E9 RID: 8937 RVA: 0x000B43D0 File Offset: 0x000B25D0
		public static bool Contains(MaterialReference[] materialReferences, TMP_FontAsset fontAsset)
		{
			int instanceID = fontAsset.GetInstanceID();
			int num = 0;
			while (num < materialReferences.Length && materialReferences[num].fontAsset != null)
			{
				if (materialReferences[num].fontAsset.GetInstanceID() == instanceID)
				{
					return true;
				}
				num++;
			}
			return false;
		}

		// Token: 0x060022EA RID: 8938 RVA: 0x000B4420 File Offset: 0x000B2620
		public static int AddMaterialReference(Material material, TMP_FontAsset fontAsset, MaterialReference[] materialReferences, Dictionary<int, int> materialReferenceIndexLookup)
		{
			int instanceID = material.GetInstanceID();
			int num = 0;
			if (materialReferenceIndexLookup.TryGetValue(instanceID, out num))
			{
				return num;
			}
			num = materialReferenceIndexLookup.Count;
			materialReferenceIndexLookup[instanceID] = num;
			materialReferences[num].index = num;
			materialReferences[num].fontAsset = fontAsset;
			materialReferences[num].spriteAsset = null;
			materialReferences[num].material = material;
			materialReferences[num].isDefaultMaterial = (instanceID == fontAsset.material.GetInstanceID());
			materialReferences[num].referenceCount = 0;
			return num;
		}

		// Token: 0x060022EB RID: 8939 RVA: 0x000B44B4 File Offset: 0x000B26B4
		public static int AddMaterialReference(Material material, TMP_SpriteAsset spriteAsset, MaterialReference[] materialReferences, Dictionary<int, int> materialReferenceIndexLookup)
		{
			int instanceID = material.GetInstanceID();
			int num = 0;
			if (materialReferenceIndexLookup.TryGetValue(instanceID, out num))
			{
				return num;
			}
			num = materialReferenceIndexLookup.Count;
			materialReferenceIndexLookup[instanceID] = num;
			materialReferences[num].index = num;
			materialReferences[num].fontAsset = materialReferences[0].fontAsset;
			materialReferences[num].spriteAsset = spriteAsset;
			materialReferences[num].material = material;
			materialReferences[num].isDefaultMaterial = true;
			materialReferences[num].referenceCount = 0;
			return num;
		}

		// Token: 0x04002773 RID: 10099
		public int index;

		// Token: 0x04002774 RID: 10100
		public TMP_FontAsset fontAsset;

		// Token: 0x04002775 RID: 10101
		public TMP_SpriteAsset spriteAsset;

		// Token: 0x04002776 RID: 10102
		public Material material;

		// Token: 0x04002777 RID: 10103
		public bool isDefaultMaterial;

		// Token: 0x04002778 RID: 10104
		public bool isFallbackMaterial;

		// Token: 0x04002779 RID: 10105
		public Material fallbackMaterial;

		// Token: 0x0400277A RID: 10106
		public float padding;

		// Token: 0x0400277B RID: 10107
		public int referenceCount;
	}
}
