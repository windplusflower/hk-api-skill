using System;
using UnityEngine;

namespace GUIBlendModes
{
	// Token: 0x020008B4 RID: 2228
	public static class BlendMaterials
	{
		// Token: 0x06003196 RID: 12694 RVA: 0x0012E4D4 File Offset: 0x0012C6D4
		public static void Initialize()
		{
			BlendMaterials.Materials = new Material[84];
			for (int i = 0; i < 21; i++)
			{
				BlendMaterials.Materials[i] = Resources.Load<Material>("UIBlend" + (i + BlendMode.Darken).ToString());
			}
			for (int j = 21; j < 42; j++)
			{
				BlendMaterials.Materials[j] = Resources.Load<Material>("UIBlend" + ((BlendMode)(j - 20)).ToString() + "Optimized");
			}
			for (int k = 42; k < 63; k++)
			{
				BlendMaterials.Materials[k] = Resources.Load<Material>("UIFontBlend" + ((BlendMode)(k - 41)).ToString());
			}
			for (int l = 63; l < 84; l++)
			{
				BlendMaterials.Materials[l] = Resources.Load<Material>("UIFontBlend" + ((BlendMode)(l - 62)).ToString() + "Optimized");
			}
			BlendMaterials.Initialized = true;
		}

		// Token: 0x06003197 RID: 12695 RVA: 0x0012E5DC File Offset: 0x0012C7DC
		public static Material GetMaterial(BlendMode mode, bool font, bool optimized)
		{
			if (!BlendMaterials.Initialized)
			{
				BlendMaterials.Initialize();
			}
			if (font)
			{
				if (mode != BlendMode.Normal)
				{
					return BlendMaterials.Materials[mode - BlendMode.Darken + (optimized ? 63 : 42)];
				}
				return null;
			}
			else
			{
				if (mode != BlendMode.Normal)
				{
					return BlendMaterials.Materials[mode - BlendMode.Darken + (optimized ? 21 : 0)];
				}
				return null;
			}
		}

		// Token: 0x04003313 RID: 13075
		public static Material[] Materials;

		// Token: 0x04003314 RID: 13076
		public static bool Initialized;
	}
}
