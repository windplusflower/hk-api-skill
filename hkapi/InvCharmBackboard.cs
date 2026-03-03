using System;
using UnityEngine;

// Token: 0x02000461 RID: 1121
public class InvCharmBackboard : MonoBehaviour
{
	// Token: 0x0600193B RID: 6459 RVA: 0x0007892F File Offset: 0x00076B2F
	private void Awake()
	{
		this.spriteRenderer = base.GetComponent<SpriteRenderer>();
	}

	// Token: 0x0600193C RID: 6460 RVA: 0x00078940 File Offset: 0x00076B40
	private void OnEnable()
	{
		if (!this.positionedCharm)
		{
			this.charmObject.transform.localPosition = new Vector3(base.transform.localPosition.x, base.transform.localPosition.y, base.transform.localPosition.z - 0.001f);
			this.positionedCharm = true;
		}
		if (this.playerData == null)
		{
			this.playerData = PlayerData.instance;
		}
		if (this.playerData.GetBool(this.gotCharmString) && this.playerData.GetBool(this.newCharmString))
		{
			this.newOrb.SetActive(true);
		}
		if (this.playerData.GetBool(this.gotCharmString) && !this.blanked)
		{
			this.spriteRenderer.sprite = this.blankSprite;
			this.blanked = true;
		}
		if (!this.playerData.GetBool(this.gotCharmString) && this.blanked)
		{
			this.spriteRenderer.sprite = this.activeSprite;
			this.blanked = false;
		}
	}

	// Token: 0x0600193D RID: 6461 RVA: 0x00078A52 File Offset: 0x00076C52
	public void SelectCharm()
	{
		if (this.playerData.GetBool(this.newCharmString))
		{
			this.playerData.SetBool(this.newCharmString, false);
			this.newOrb.GetComponent<SimpleFadeOut>().FadeOut();
		}
	}

	// Token: 0x0600193E RID: 6462 RVA: 0x00078A89 File Offset: 0x00076C89
	public int GetCharmNum()
	{
		return this.charmNum;
	}

	// Token: 0x0600193F RID: 6463 RVA: 0x00078A91 File Offset: 0x00076C91
	public string GetCharmString()
	{
		return this.gotCharmString;
	}

	// Token: 0x06001940 RID: 6464 RVA: 0x00078A99 File Offset: 0x00076C99
	public string GetCharmNumString()
	{
		return this.charmNumString;
	}

	// Token: 0x04001E49 RID: 7753
	public GameObject charmObject;

	// Token: 0x04001E4A RID: 7754
	public GameObject newOrb;

	// Token: 0x04001E4B RID: 7755
	public int charmNum;

	// Token: 0x04001E4C RID: 7756
	public string charmNumString;

	// Token: 0x04001E4D RID: 7757
	public string gotCharmString;

	// Token: 0x04001E4E RID: 7758
	public string newCharmString;

	// Token: 0x04001E4F RID: 7759
	public Sprite blankSprite;

	// Token: 0x04001E50 RID: 7760
	public Sprite activeSprite;

	// Token: 0x04001E51 RID: 7761
	private bool positionedCharm;

	// Token: 0x04001E52 RID: 7762
	private PlayerData playerData;

	// Token: 0x04001E53 RID: 7763
	private GameObject orb;

	// Token: 0x04001E54 RID: 7764
	private SpriteRenderer spriteRenderer;

	// Token: 0x04001E55 RID: 7765
	private bool blanked;
}
