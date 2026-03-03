using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;

namespace TMPro
{
	// Token: 0x020005FE RID: 1534
	public static class TMP_MaterialManager
	{
		// Token: 0x06002433 RID: 9267 RVA: 0x000BA068 File Offset: 0x000B8268
		public static Material GetStencilMaterial(Material baseMaterial, int stencilID)
		{
			if (!baseMaterial.HasProperty(ShaderUtilities.ID_StencilID))
			{
				Debug.LogWarning("Selected Shader does not support Stencil Masking. Please select the Distance Field or Mobile Distance Field Shader.");
				return baseMaterial;
			}
			int instanceID = baseMaterial.GetInstanceID();
			for (int i = 0; i < TMP_MaterialManager.m_materialList.Count; i++)
			{
				if (TMP_MaterialManager.m_materialList[i].baseMaterial.GetInstanceID() == instanceID && TMP_MaterialManager.m_materialList[i].stencilID == stencilID)
				{
					TMP_MaterialManager.m_materialList[i].count++;
					return TMP_MaterialManager.m_materialList[i].stencilMaterial;
				}
			}
			Material material = new Material(baseMaterial);
			material.hideFlags = HideFlags.HideAndDontSave;
			material.shaderKeywords = baseMaterial.shaderKeywords;
			ShaderUtilities.GetShaderPropertyIDs();
			material.SetFloat(ShaderUtilities.ID_StencilID, (float)stencilID);
			material.SetFloat(ShaderUtilities.ID_StencilComp, 4f);
			TMP_MaterialManager.MaskingMaterial maskingMaterial = new TMP_MaterialManager.MaskingMaterial();
			maskingMaterial.baseMaterial = baseMaterial;
			maskingMaterial.stencilMaterial = material;
			maskingMaterial.stencilID = stencilID;
			maskingMaterial.count = 1;
			TMP_MaterialManager.m_materialList.Add(maskingMaterial);
			return material;
		}

		// Token: 0x06002434 RID: 9268 RVA: 0x000BA16C File Offset: 0x000B836C
		public static void ReleaseStencilMaterial(Material stencilMaterial)
		{
			int instanceID = stencilMaterial.GetInstanceID();
			int i = 0;
			while (i < TMP_MaterialManager.m_materialList.Count)
			{
				if (TMP_MaterialManager.m_materialList[i].stencilMaterial.GetInstanceID() == instanceID)
				{
					if (TMP_MaterialManager.m_materialList[i].count > 1)
					{
						TMP_MaterialManager.m_materialList[i].count--;
						return;
					}
					UnityEngine.Object.DestroyImmediate(TMP_MaterialManager.m_materialList[i].stencilMaterial);
					TMP_MaterialManager.m_materialList.RemoveAt(i);
					stencilMaterial = null;
					return;
				}
				else
				{
					i++;
				}
			}
		}

		// Token: 0x06002435 RID: 9269 RVA: 0x000BA204 File Offset: 0x000B8404
		public static Material GetBaseMaterial(Material stencilMaterial)
		{
			int num = TMP_MaterialManager.m_materialList.FindIndex((TMP_MaterialManager.MaskingMaterial item) => item.stencilMaterial == stencilMaterial);
			if (num == -1)
			{
				return null;
			}
			return TMP_MaterialManager.m_materialList[num].baseMaterial;
		}

		// Token: 0x06002436 RID: 9270 RVA: 0x000BA24B File Offset: 0x000B844B
		public static Material SetStencil(Material material, int stencilID)
		{
			material.SetFloat(ShaderUtilities.ID_StencilID, (float)stencilID);
			if (stencilID == 0)
			{
				material.SetFloat(ShaderUtilities.ID_StencilComp, 8f);
			}
			else
			{
				material.SetFloat(ShaderUtilities.ID_StencilComp, 4f);
			}
			return material;
		}

		// Token: 0x06002437 RID: 9271 RVA: 0x000BA280 File Offset: 0x000B8480
		public static void AddMaskingMaterial(Material baseMaterial, Material stencilMaterial, int stencilID)
		{
			int num = TMP_MaterialManager.m_materialList.FindIndex((TMP_MaterialManager.MaskingMaterial item) => item.stencilMaterial == stencilMaterial);
			if (num == -1)
			{
				TMP_MaterialManager.MaskingMaterial maskingMaterial = new TMP_MaterialManager.MaskingMaterial();
				maskingMaterial.baseMaterial = baseMaterial;
				maskingMaterial.stencilMaterial = stencilMaterial;
				maskingMaterial.stencilID = stencilID;
				maskingMaterial.count = 1;
				TMP_MaterialManager.m_materialList.Add(maskingMaterial);
				return;
			}
			stencilMaterial = TMP_MaterialManager.m_materialList[num].stencilMaterial;
			TMP_MaterialManager.m_materialList[num].count++;
		}

		// Token: 0x06002438 RID: 9272 RVA: 0x000BA318 File Offset: 0x000B8518
		public static void RemoveStencilMaterial(Material stencilMaterial)
		{
			int num = TMP_MaterialManager.m_materialList.FindIndex((TMP_MaterialManager.MaskingMaterial item) => item.stencilMaterial == stencilMaterial);
			if (num != -1)
			{
				TMP_MaterialManager.m_materialList.RemoveAt(num);
			}
		}

		// Token: 0x06002439 RID: 9273 RVA: 0x000BA358 File Offset: 0x000B8558
		public static void ReleaseBaseMaterial(Material baseMaterial)
		{
			int num = TMP_MaterialManager.m_materialList.FindIndex((TMP_MaterialManager.MaskingMaterial item) => item.baseMaterial == baseMaterial);
			if (num == -1)
			{
				Debug.Log("No Masking Material exists for " + baseMaterial.name);
				return;
			}
			if (TMP_MaterialManager.m_materialList[num].count > 1)
			{
				TMP_MaterialManager.m_materialList[num].count--;
				Debug.Log(string.Concat(new string[]
				{
					"Removed (1) reference to ",
					TMP_MaterialManager.m_materialList[num].stencilMaterial.name,
					". There are ",
					TMP_MaterialManager.m_materialList[num].count.ToString(),
					" references left."
				}));
				return;
			}
			Debug.Log("Removed last reference to " + TMP_MaterialManager.m_materialList[num].stencilMaterial.name + " with ID " + TMP_MaterialManager.m_materialList[num].stencilMaterial.GetInstanceID().ToString());
			UnityEngine.Object.DestroyImmediate(TMP_MaterialManager.m_materialList[num].stencilMaterial);
			TMP_MaterialManager.m_materialList.RemoveAt(num);
		}

		// Token: 0x0600243A RID: 9274 RVA: 0x000BA494 File Offset: 0x000B8694
		public static void ClearMaterials()
		{
			if (TMP_MaterialManager.m_materialList.Count<TMP_MaterialManager.MaskingMaterial>() == 0)
			{
				Debug.Log("Material List has already been cleared.");
				return;
			}
			for (int i = 0; i < TMP_MaterialManager.m_materialList.Count<TMP_MaterialManager.MaskingMaterial>(); i++)
			{
				UnityEngine.Object.DestroyImmediate(TMP_MaterialManager.m_materialList[i].stencilMaterial);
				TMP_MaterialManager.m_materialList.RemoveAt(i);
			}
		}

		// Token: 0x0600243B RID: 9275 RVA: 0x000BA4F0 File Offset: 0x000B86F0
		public static int GetStencilID(GameObject obj)
		{
			int num = 0;
			List<Mask> list = TMP_ListPool<Mask>.Get();
			obj.GetComponentsInParent<Mask>(false, list);
			for (int i = 0; i < list.Count; i++)
			{
				if (list[i].MaskEnabled())
				{
					num++;
				}
			}
			TMP_ListPool<Mask>.Release(list);
			return Mathf.Min((1 << num) - 1, 255);
		}

		// Token: 0x0600243C RID: 9276 RVA: 0x000BA548 File Offset: 0x000B8748
		public static Material GetFallbackMaterial(Material sourceMaterial, Material targetMaterial)
		{
			int instanceID = sourceMaterial.GetInstanceID();
			Texture texture = targetMaterial.GetTexture(ShaderUtilities.ID_MainTex);
			int instanceID2 = texture.GetInstanceID();
			long num = (long)instanceID << 32 | (long)((ulong)instanceID2);
			TMP_MaterialManager.FallbackMaterial fallbackMaterial;
			if (TMP_MaterialManager.m_fallbackMaterials.TryGetValue(num, out fallbackMaterial))
			{
				return fallbackMaterial.fallbackMaterial;
			}
			Material material = new Material(sourceMaterial);
			material.hideFlags = HideFlags.HideAndDontSave;
			material.SetTexture(ShaderUtilities.ID_MainTex, texture);
			material.SetFloat(ShaderUtilities.ID_GradientScale, targetMaterial.GetFloat(ShaderUtilities.ID_GradientScale));
			material.SetFloat(ShaderUtilities.ID_TextureWidth, targetMaterial.GetFloat(ShaderUtilities.ID_TextureWidth));
			material.SetFloat(ShaderUtilities.ID_TextureHeight, targetMaterial.GetFloat(ShaderUtilities.ID_TextureHeight));
			material.SetFloat(ShaderUtilities.ID_WeightNormal, targetMaterial.GetFloat(ShaderUtilities.ID_WeightNormal));
			material.SetFloat(ShaderUtilities.ID_WeightBold, targetMaterial.GetFloat(ShaderUtilities.ID_WeightBold));
			fallbackMaterial = new TMP_MaterialManager.FallbackMaterial();
			fallbackMaterial.baseID = instanceID;
			fallbackMaterial.baseMaterial = sourceMaterial;
			fallbackMaterial.fallbackMaterial = material;
			fallbackMaterial.count = 0;
			TMP_MaterialManager.m_fallbackMaterials.Add(num, fallbackMaterial);
			TMP_MaterialManager.m_fallbackMaterialLookup.Add(material.GetInstanceID(), num);
			return material;
		}

		// Token: 0x0600243D RID: 9277 RVA: 0x000BA66C File Offset: 0x000B886C
		public static void AddFallbackMaterialReference(Material targetMaterial)
		{
			if (targetMaterial == null)
			{
				return;
			}
			int instanceID = targetMaterial.GetInstanceID();
			long key;
			TMP_MaterialManager.FallbackMaterial fallbackMaterial;
			if (TMP_MaterialManager.m_fallbackMaterialLookup.TryGetValue(instanceID, out key) && TMP_MaterialManager.m_fallbackMaterials.TryGetValue(key, out fallbackMaterial))
			{
				fallbackMaterial.count++;
			}
		}

		// Token: 0x0600243E RID: 9278 RVA: 0x000BA6B8 File Offset: 0x000B88B8
		public static void RemoveFallbackMaterialReference(Material targetMaterial)
		{
			if (targetMaterial == null)
			{
				return;
			}
			int instanceID = targetMaterial.GetInstanceID();
			long num;
			TMP_MaterialManager.FallbackMaterial fallbackMaterial;
			if (TMP_MaterialManager.m_fallbackMaterialLookup.TryGetValue(instanceID, out num) && TMP_MaterialManager.m_fallbackMaterials.TryGetValue(num, out fallbackMaterial))
			{
				fallbackMaterial.count--;
				if (fallbackMaterial.count < 1)
				{
					TMP_MaterialManager.m_fallbackCleanupList.Add(num);
				}
			}
		}

		// Token: 0x0600243F RID: 9279 RVA: 0x000BA718 File Offset: 0x000B8918
		public static void CleanupFallbackMaterials()
		{
			for (int i = 0; i < TMP_MaterialManager.m_fallbackCleanupList.Count; i++)
			{
				long key = TMP_MaterialManager.m_fallbackCleanupList[i];
				TMP_MaterialManager.FallbackMaterial fallbackMaterial;
				if (TMP_MaterialManager.m_fallbackMaterials.TryGetValue(key, out fallbackMaterial) && fallbackMaterial.count < 1)
				{
					Material fallbackMaterial2 = fallbackMaterial.fallbackMaterial;
					UnityEngine.Object.DestroyImmediate(fallbackMaterial2);
					TMP_MaterialManager.m_fallbackMaterials.Remove(key);
					TMP_MaterialManager.m_fallbackMaterialLookup.Remove(fallbackMaterial2.GetInstanceID());
				}
			}
		}

		// Token: 0x06002440 RID: 9280 RVA: 0x000BA78C File Offset: 0x000B898C
		public static void ReleaseFallbackMaterial(Material fallackMaterial)
		{
			if (fallackMaterial == null)
			{
				return;
			}
			int instanceID = fallackMaterial.GetInstanceID();
			long key;
			TMP_MaterialManager.FallbackMaterial fallbackMaterial;
			if (TMP_MaterialManager.m_fallbackMaterialLookup.TryGetValue(instanceID, out key) && TMP_MaterialManager.m_fallbackMaterials.TryGetValue(key, out fallbackMaterial))
			{
				if (fallbackMaterial.count > 1)
				{
					fallbackMaterial.count--;
					return;
				}
				UnityEngine.Object.DestroyImmediate(fallbackMaterial.fallbackMaterial);
				TMP_MaterialManager.m_fallbackMaterials.Remove(key);
				TMP_MaterialManager.m_fallbackMaterialLookup.Remove(instanceID);
				fallackMaterial = null;
			}
		}

		// Token: 0x06002441 RID: 9281 RVA: 0x000BA808 File Offset: 0x000B8A08
		public static void CopyMaterialPresetProperties(Material source, Material destination)
		{
			Texture texture = destination.GetTexture(ShaderUtilities.ID_MainTex);
			float @float = destination.GetFloat(ShaderUtilities.ID_GradientScale);
			float float2 = destination.GetFloat(ShaderUtilities.ID_TextureWidth);
			float float3 = destination.GetFloat(ShaderUtilities.ID_TextureHeight);
			float float4 = destination.GetFloat(ShaderUtilities.ID_WeightNormal);
			float float5 = destination.GetFloat(ShaderUtilities.ID_WeightBold);
			destination.CopyPropertiesFromMaterial(source);
			destination.shaderKeywords = source.shaderKeywords;
			destination.SetTexture(ShaderUtilities.ID_MainTex, texture);
			destination.SetFloat(ShaderUtilities.ID_GradientScale, @float);
			destination.SetFloat(ShaderUtilities.ID_TextureWidth, float2);
			destination.SetFloat(ShaderUtilities.ID_TextureHeight, float3);
			destination.SetFloat(ShaderUtilities.ID_WeightNormal, float4);
			destination.SetFloat(ShaderUtilities.ID_WeightBold, float5);
		}

		// Token: 0x06002442 RID: 9282 RVA: 0x000BA8BC File Offset: 0x000B8ABC
		// Note: this type is marked as 'beforefieldinit'.
		static TMP_MaterialManager()
		{
			TMP_MaterialManager.m_materialList = new List<TMP_MaterialManager.MaskingMaterial>();
			TMP_MaterialManager.m_fallbackMaterials = new Dictionary<long, TMP_MaterialManager.FallbackMaterial>();
			TMP_MaterialManager.m_fallbackMaterialLookup = new Dictionary<int, long>();
			TMP_MaterialManager.m_fallbackCleanupList = new List<long>();
		}

		// Token: 0x04002859 RID: 10329
		private static List<TMP_MaterialManager.MaskingMaterial> m_materialList;

		// Token: 0x0400285A RID: 10330
		private static Dictionary<long, TMP_MaterialManager.FallbackMaterial> m_fallbackMaterials;

		// Token: 0x0400285B RID: 10331
		private static Dictionary<int, long> m_fallbackMaterialLookup;

		// Token: 0x0400285C RID: 10332
		private static List<long> m_fallbackCleanupList;

		// Token: 0x020005FF RID: 1535
		private class FallbackMaterial
		{
			// Token: 0x0400285D RID: 10333
			public int baseID;

			// Token: 0x0400285E RID: 10334
			public Material baseMaterial;

			// Token: 0x0400285F RID: 10335
			public Material fallbackMaterial;

			// Token: 0x04002860 RID: 10336
			public int count;
		}

		// Token: 0x02000600 RID: 1536
		private class MaskingMaterial
		{
			// Token: 0x04002861 RID: 10337
			public Material baseMaterial;

			// Token: 0x04002862 RID: 10338
			public Material stencilMaterial;

			// Token: 0x04002863 RID: 10339
			public int count;

			// Token: 0x04002864 RID: 10340
			public int stencilID;
		}
	}
}
