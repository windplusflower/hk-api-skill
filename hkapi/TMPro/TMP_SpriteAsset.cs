using System;
using System.Collections.Generic;
using UnityEngine;

namespace TMPro
{
	// Token: 0x0200060B RID: 1547
	public class TMP_SpriteAsset : TMP_Asset
	{
		// Token: 0x170004CF RID: 1231
		// (get) Token: 0x06002480 RID: 9344 RVA: 0x000BBF5D File Offset: 0x000BA15D
		public static TMP_SpriteAsset defaultSpriteAsset
		{
			get
			{
				if (TMP_SpriteAsset.m_defaultSpriteAsset == null)
				{
					TMP_SpriteAsset.m_defaultSpriteAsset = Resources.Load<TMP_SpriteAsset>("Sprite Assets/Default Sprite Asset");
				}
				return TMP_SpriteAsset.m_defaultSpriteAsset;
			}
		}

		// Token: 0x06002481 RID: 9345 RVA: 0x00003603 File Offset: 0x00001803
		private void OnEnable()
		{
		}

		// Token: 0x06002482 RID: 9346 RVA: 0x000BBF80 File Offset: 0x000BA180
		private Material GetDefaultSpriteMaterial()
		{
			ShaderUtilities.GetShaderPropertyIDs();
			Material material = new Material(Shader.Find("TextMeshPro/Sprite"));
			material.SetTexture(ShaderUtilities.ID_MainTex, this.spriteSheet);
			material.hideFlags = HideFlags.HideInHierarchy;
			return material;
		}

		// Token: 0x06002483 RID: 9347 RVA: 0x000BBFB0 File Offset: 0x000BA1B0
		public int GetSpriteIndex(int hashCode)
		{
			for (int i = 0; i < this.spriteInfoList.Count; i++)
			{
				if (this.spriteInfoList[i].hashCode == hashCode)
				{
					return i;
				}
			}
			return -1;
		}

		// Token: 0x04002898 RID: 10392
		public static TMP_SpriteAsset m_defaultSpriteAsset;

		// Token: 0x04002899 RID: 10393
		public Texture spriteSheet;

		// Token: 0x0400289A RID: 10394
		public List<TMP_Sprite> spriteInfoList;

		// Token: 0x0400289B RID: 10395
		private List<Sprite> m_sprites;
	}
}
