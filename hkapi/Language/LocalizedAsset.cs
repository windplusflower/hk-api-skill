using System;
using UnityEngine;

namespace Language
{
	// Token: 0x020006AE RID: 1710
	public class LocalizedAsset : MonoBehaviour
	{
		// Token: 0x06002896 RID: 10390 RVA: 0x000E4867 File Offset: 0x000E2A67
		public void Awake()
		{
			LocalizedAsset.LocalizeAsset(this.localizeTarget);
		}

		// Token: 0x06002897 RID: 10391 RVA: 0x000E4867 File Offset: 0x000E2A67
		public void LocalizeAsset()
		{
			LocalizedAsset.LocalizeAsset(this.localizeTarget);
		}

		// Token: 0x06002898 RID: 10392 RVA: 0x000E4874 File Offset: 0x000E2A74
		public static void LocalizeAsset(UnityEngine.Object target)
		{
			if (target == null)
			{
				Debug.LogError("LocalizedAsset target is null");
				return;
			}
			if (target.GetType() == typeof(Material))
			{
				Material material = (Material)target;
				if (material.mainTexture != null)
				{
					Texture texture = (Texture)Language.GetAsset(material.mainTexture.name);
					if (texture != null)
					{
						material.mainTexture = texture;
						return;
					}
				}
			}
			else if (target.GetType() == typeof(MeshRenderer))
			{
				MeshRenderer meshRenderer = (MeshRenderer)target;
				if (meshRenderer.material.mainTexture != null)
				{
					Texture texture2 = (Texture)Language.GetAsset(meshRenderer.material.mainTexture.name);
					if (texture2 != null)
					{
						meshRenderer.material.mainTexture = texture2;
						return;
					}
				}
			}
			else
			{
				string str = "Could not localize this object type: ";
				Type type = target.GetType();
				Debug.LogError(str + ((type != null) ? type.ToString() : null));
			}
		}

		// Token: 0x04002E7C RID: 11900
		public UnityEngine.Object localizeTarget;
	}
}
