using System;
using UnityEngine;

// Token: 0x0200046B RID: 1131
public class InvRelicBackboard : MonoBehaviour
{
	// Token: 0x0600195C RID: 6492 RVA: 0x00078EA4 File Offset: 0x000770A4
	private void Awake()
	{
		this.spriteRenderer = base.GetComponent<SpriteRenderer>();
	}

	// Token: 0x0600195D RID: 6493 RVA: 0x00078EB4 File Offset: 0x000770B4
	private void OnEnable()
	{
		if (this.spriteRenderer != null)
		{
			if (this.playerData == null)
			{
				this.playerData = PlayerData.instance;
			}
			if (!this.playerData.GetBool("foundTrinket1") && !this.playerData.GetBool("foundTrinket2") && !this.playerData.GetBool("foundTrinket3") && !this.playerData.GetBool("foundTrinket4"))
			{
				this.spriteRenderer.sprite = this.inactiveSprite;
				return;
			}
			this.spriteRenderer.sprite = this.activeSprite;
		}
	}

	// Token: 0x04001E71 RID: 7793
	public Sprite activeSprite;

	// Token: 0x04001E72 RID: 7794
	public Sprite inactiveSprite;

	// Token: 0x04001E73 RID: 7795
	private PlayerData playerData;

	// Token: 0x04001E74 RID: 7796
	private SpriteRenderer spriteRenderer;
}
