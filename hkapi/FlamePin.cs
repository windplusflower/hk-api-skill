using System;
using System.Collections.Generic;
using UnityEngine;

// Token: 0x02000457 RID: 1111
public class FlamePin : MonoBehaviour
{
	// Token: 0x060018EC RID: 6380 RVA: 0x00074AC5 File Offset: 0x00072CC5
	private void Start()
	{
		this.pd = PlayerData.instance;
	}

	// Token: 0x060018ED RID: 6381 RVA: 0x00074AD4 File Offset: 0x00072CD4
	private void OnEnable()
	{
		base.gameObject.GetComponent<SpriteRenderer>().enabled = false;
		if (this.pd == null)
		{
			this.pd = PlayerData.instance;
		}
		if (this.pd.GetVariable<List<string>>("scenesFlameCollected").Contains(base.name) || (float)this.pd.GetInt("grimmChildLevel") != this.level || this.pd.GetInt("flamesCollected") >= this.pd.GetInt("flamesRequired") || !this.pd.GetBool("equippedCharm_40"))
		{
			base.gameObject.SetActive(false);
			return;
		}
		base.gameObject.GetComponent<SpriteRenderer>().enabled = true;
	}

	// Token: 0x04001DE0 RID: 7648
	private PlayerData pd;

	// Token: 0x04001DE1 RID: 7649
	public float level;
}
