using System;
using UnityEngine;

// Token: 0x020004A9 RID: 1193
public class PlatformSpecificSprite : MonoBehaviour
{
	// Token: 0x06001A88 RID: 6792 RVA: 0x0007F44C File Offset: 0x0007D64C
	private void OnEnable()
	{
		if (!this.spriteRenderer)
		{
			return;
		}
		foreach (PlatformSpecificSprite.PlatformSpriteMatch platformSpriteMatch in this.sprites)
		{
			if (platformSpriteMatch.Platform == Application.platform)
			{
				this.spriteRenderer.sprite = platformSpriteMatch.Sprite;
				return;
			}
		}
	}

	// Token: 0x04001FEB RID: 8171
	[SerializeField]
	private SpriteRenderer spriteRenderer;

	// Token: 0x04001FEC RID: 8172
	[SerializeField]
	private PlatformSpecificSprite.PlatformSpriteMatch[] sprites;

	// Token: 0x020004AA RID: 1194
	[Serializable]
	public struct PlatformSpriteMatch
	{
		// Token: 0x04001FED RID: 8173
		public RuntimePlatform Platform;

		// Token: 0x04001FEE RID: 8174
		public Sprite Sprite;
	}
}
