using System;
using UnityEngine;

// Token: 0x02000466 RID: 1126
public class InvItemDisplay : MonoBehaviour
{
	// Token: 0x0600194E RID: 6478 RVA: 0x00078C5B File Offset: 0x00076E5B
	private void Awake()
	{
		this.spriteRenderer = base.GetComponent<SpriteRenderer>();
	}

	// Token: 0x0600194F RID: 6479 RVA: 0x00078C6C File Offset: 0x00076E6C
	private void OnEnable()
	{
		if (this.spriteRenderer != null)
		{
			if (this.playerData == null)
			{
				this.playerData = PlayerData.instance;
			}
			if (this.playerData.GetBool(this.playerDataBool))
			{
				this.spriteRenderer.sprite = this.activeSprite;
				return;
			}
			this.spriteRenderer.sprite = this.inactiveSprite;
		}
	}

	// Token: 0x04001E5D RID: 7773
	public string playerDataBool;

	// Token: 0x04001E5E RID: 7774
	public Sprite activeSprite;

	// Token: 0x04001E5F RID: 7775
	public Sprite inactiveSprite;

	// Token: 0x04001E60 RID: 7776
	private PlayerData playerData;

	// Token: 0x04001E61 RID: 7777
	private SpriteRenderer spriteRenderer;
}
