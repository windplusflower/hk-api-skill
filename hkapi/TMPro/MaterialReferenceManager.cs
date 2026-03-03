using System;
using System.Collections.Generic;
using UnityEngine;

namespace TMPro
{
	// Token: 0x020005D4 RID: 1492
	public class MaterialReferenceManager
	{
		// Token: 0x1700046A RID: 1130
		// (get) Token: 0x060022D6 RID: 8918 RVA: 0x000B419B File Offset: 0x000B239B
		public static MaterialReferenceManager instance
		{
			get
			{
				if (MaterialReferenceManager.s_Instance == null)
				{
					MaterialReferenceManager.s_Instance = new MaterialReferenceManager();
				}
				return MaterialReferenceManager.s_Instance;
			}
		}

		// Token: 0x060022D7 RID: 8919 RVA: 0x000B41B3 File Offset: 0x000B23B3
		public static void AddFontAsset(TMP_FontAsset fontAsset)
		{
			MaterialReferenceManager.instance.AddFontAssetInternal(fontAsset);
		}

		// Token: 0x060022D8 RID: 8920 RVA: 0x000B41C0 File Offset: 0x000B23C0
		private void AddFontAssetInternal(TMP_FontAsset fontAsset)
		{
			if (this.m_FontAssetReferenceLookup.ContainsKey(fontAsset.hashCode))
			{
				return;
			}
			this.m_FontAssetReferenceLookup.Add(fontAsset.hashCode, fontAsset);
			this.m_FontMaterialReferenceLookup.Add(fontAsset.materialHashCode, fontAsset.material);
		}

		// Token: 0x060022D9 RID: 8921 RVA: 0x000B41FF File Offset: 0x000B23FF
		public static void AddSpriteAsset(TMP_SpriteAsset spriteAsset)
		{
			MaterialReferenceManager.instance.AddSpriteAssetInternal(spriteAsset);
		}

		// Token: 0x060022DA RID: 8922 RVA: 0x000B420C File Offset: 0x000B240C
		private void AddSpriteAssetInternal(TMP_SpriteAsset spriteAsset)
		{
			if (this.m_SpriteAssetReferenceLookup.ContainsKey(spriteAsset.hashCode))
			{
				return;
			}
			this.m_SpriteAssetReferenceLookup.Add(spriteAsset.hashCode, spriteAsset);
			this.m_FontMaterialReferenceLookup.Add(spriteAsset.hashCode, spriteAsset.material);
		}

		// Token: 0x060022DB RID: 8923 RVA: 0x000B424B File Offset: 0x000B244B
		public static void AddSpriteAsset(int hashCode, TMP_SpriteAsset spriteAsset)
		{
			MaterialReferenceManager.instance.AddSpriteAssetInternal(hashCode, spriteAsset);
		}

		// Token: 0x060022DC RID: 8924 RVA: 0x000B4259 File Offset: 0x000B2459
		private void AddSpriteAssetInternal(int hashCode, TMP_SpriteAsset spriteAsset)
		{
			if (this.m_SpriteAssetReferenceLookup.ContainsKey(hashCode))
			{
				return;
			}
			this.m_SpriteAssetReferenceLookup.Add(hashCode, spriteAsset);
			this.m_FontMaterialReferenceLookup.Add(hashCode, spriteAsset.material);
			if (spriteAsset.hashCode == 0)
			{
				spriteAsset.hashCode = hashCode;
			}
		}

		// Token: 0x060022DD RID: 8925 RVA: 0x000B4298 File Offset: 0x000B2498
		public static void AddFontMaterial(int hashCode, Material material)
		{
			MaterialReferenceManager.instance.AddFontMaterialInternal(hashCode, material);
		}

		// Token: 0x060022DE RID: 8926 RVA: 0x000B42A6 File Offset: 0x000B24A6
		private void AddFontMaterialInternal(int hashCode, Material material)
		{
			this.m_FontMaterialReferenceLookup.Add(hashCode, material);
		}

		// Token: 0x060022DF RID: 8927 RVA: 0x000B42B5 File Offset: 0x000B24B5
		public bool Contains(TMP_FontAsset font)
		{
			return this.m_FontAssetReferenceLookup.ContainsKey(font.hashCode);
		}

		// Token: 0x060022E0 RID: 8928 RVA: 0x000B42B5 File Offset: 0x000B24B5
		public bool Contains(TMP_SpriteAsset sprite)
		{
			return this.m_FontAssetReferenceLookup.ContainsKey(sprite.hashCode);
		}

		// Token: 0x060022E1 RID: 8929 RVA: 0x000B42CD File Offset: 0x000B24CD
		public static bool TryGetFontAsset(int hashCode, out TMP_FontAsset fontAsset)
		{
			return MaterialReferenceManager.instance.TryGetFontAssetInternal(hashCode, out fontAsset);
		}

		// Token: 0x060022E2 RID: 8930 RVA: 0x000B42DB File Offset: 0x000B24DB
		private bool TryGetFontAssetInternal(int hashCode, out TMP_FontAsset fontAsset)
		{
			fontAsset = null;
			return this.m_FontAssetReferenceLookup.TryGetValue(hashCode, out fontAsset);
		}

		// Token: 0x060022E3 RID: 8931 RVA: 0x000B42F2 File Offset: 0x000B24F2
		public static bool TryGetSpriteAsset(int hashCode, out TMP_SpriteAsset spriteAsset)
		{
			return MaterialReferenceManager.instance.TryGetSpriteAssetInternal(hashCode, out spriteAsset);
		}

		// Token: 0x060022E4 RID: 8932 RVA: 0x000B4300 File Offset: 0x000B2500
		private bool TryGetSpriteAssetInternal(int hashCode, out TMP_SpriteAsset spriteAsset)
		{
			spriteAsset = null;
			return this.m_SpriteAssetReferenceLookup.TryGetValue(hashCode, out spriteAsset);
		}

		// Token: 0x060022E5 RID: 8933 RVA: 0x000B4317 File Offset: 0x000B2517
		public static bool TryGetMaterial(int hashCode, out Material material)
		{
			return MaterialReferenceManager.instance.TryGetMaterialInternal(hashCode, out material);
		}

		// Token: 0x060022E6 RID: 8934 RVA: 0x000B4325 File Offset: 0x000B2525
		private bool TryGetMaterialInternal(int hashCode, out Material material)
		{
			material = null;
			return this.m_FontMaterialReferenceLookup.TryGetValue(hashCode, out material);
		}

		// Token: 0x060022E7 RID: 8935 RVA: 0x000B433C File Offset: 0x000B253C
		public MaterialReferenceManager()
		{
			this.m_FontMaterialReferenceLookup = new Dictionary<int, Material>();
			this.m_FontAssetReferenceLookup = new Dictionary<int, TMP_FontAsset>();
			this.m_SpriteAssetReferenceLookup = new Dictionary<int, TMP_SpriteAsset>();
			base..ctor();
		}

		// Token: 0x0400276F RID: 10095
		private static MaterialReferenceManager s_Instance;

		// Token: 0x04002770 RID: 10096
		private Dictionary<int, Material> m_FontMaterialReferenceLookup;

		// Token: 0x04002771 RID: 10097
		private Dictionary<int, TMP_FontAsset> m_FontAssetReferenceLookup;

		// Token: 0x04002772 RID: 10098
		private Dictionary<int, TMP_SpriteAsset> m_SpriteAssetReferenceLookup;
	}
}
