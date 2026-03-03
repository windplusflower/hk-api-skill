using System;
using UnityEngine;

// Token: 0x0200046A RID: 1130
public class InvNailSprite : MonoBehaviour
{
	// Token: 0x06001959 RID: 6489 RVA: 0x00078DDD File Offset: 0x00076FDD
	private void Awake()
	{
		this.spriteRenderer = base.GetComponent<SpriteRenderer>();
	}

	// Token: 0x0600195A RID: 6490 RVA: 0x00078DEC File Offset: 0x00076FEC
	private void OnEnable()
	{
		if (this.playerData == null)
		{
			this.playerData = PlayerData.instance;
		}
		switch (this.playerData.GetInt("nailSmithUpgrades"))
		{
		case 0:
			this.spriteRenderer.sprite = this.level1;
			return;
		case 1:
			this.spriteRenderer.sprite = this.level2;
			return;
		case 2:
			this.spriteRenderer.sprite = this.level3;
			return;
		case 3:
			this.spriteRenderer.sprite = this.level4;
			return;
		case 4:
			this.spriteRenderer.sprite = this.level5;
			return;
		default:
			this.spriteRenderer.sprite = this.level1;
			return;
		}
	}

	// Token: 0x04001E6A RID: 7786
	public Sprite level1;

	// Token: 0x04001E6B RID: 7787
	public Sprite level2;

	// Token: 0x04001E6C RID: 7788
	public Sprite level3;

	// Token: 0x04001E6D RID: 7789
	public Sprite level4;

	// Token: 0x04001E6E RID: 7790
	public Sprite level5;

	// Token: 0x04001E6F RID: 7791
	private SpriteRenderer spriteRenderer;

	// Token: 0x04001E70 RID: 7792
	private PlayerData playerData;
}
