using System;
using UnityEngine;

// Token: 0x02000469 RID: 1129
public class InvNailArtBackboard : MonoBehaviour
{
	// Token: 0x06001956 RID: 6486 RVA: 0x00078D59 File Offset: 0x00076F59
	private void Awake()
	{
		this.spriteRenderer = base.GetComponent<SpriteRenderer>();
	}

	// Token: 0x06001957 RID: 6487 RVA: 0x00078D68 File Offset: 0x00076F68
	private void OnEnable()
	{
		if (this.spriteRenderer != null)
		{
			if (this.playerData == null)
			{
				this.playerData = PlayerData.instance;
			}
			if (!this.playerData.GetBool("hasNailArt") || this.playerData.GetBool("hasAllNailArts"))
			{
				this.spriteRenderer.sprite = this.inactiveSprite;
				return;
			}
			this.spriteRenderer.sprite = this.activeSprite;
		}
	}

	// Token: 0x04001E66 RID: 7782
	public Sprite activeSprite;

	// Token: 0x04001E67 RID: 7783
	public Sprite inactiveSprite;

	// Token: 0x04001E68 RID: 7784
	private PlayerData playerData;

	// Token: 0x04001E69 RID: 7785
	private SpriteRenderer spriteRenderer;
}
