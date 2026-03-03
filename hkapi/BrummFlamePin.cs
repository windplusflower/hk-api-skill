using System;
using UnityEngine;

// Token: 0x0200043A RID: 1082
public class BrummFlamePin : MonoBehaviour
{
	// Token: 0x06001864 RID: 6244 RVA: 0x00072770 File Offset: 0x00070970
	private void Start()
	{
		this.gm = GameManager.instance;
		this.pd = this.gm.playerData;
	}

	// Token: 0x06001865 RID: 6245 RVA: 0x00072790 File Offset: 0x00070990
	private void OnEnable()
	{
		base.gameObject.GetComponent<SpriteRenderer>().enabled = false;
		if (this.gm == null)
		{
			this.gm = GameManager.instance;
		}
		if (this.pd == null)
		{
			this.pd = this.gm.playerData;
		}
		if (this.pd.GetInt("flamesCollected") >= this.pd.GetInt("flamesRequired") || this.pd.GetBool("gotBrummsFlame") || !this.pd.GetBool("equippedCharm_40") || this.pd.GetInt("grimmChildLevel") != 3)
		{
			base.gameObject.SetActive(false);
		}
		base.gameObject.GetComponent<SpriteRenderer>().enabled = true;
	}

	// Token: 0x04001D2A RID: 7466
	private GameManager gm;

	// Token: 0x04001D2B RID: 7467
	private PlayerData pd;
}
