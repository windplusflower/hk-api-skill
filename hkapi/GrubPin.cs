using System;
using System.Collections.Generic;
using UnityEngine;

// Token: 0x0200045F RID: 1119
public class GrubPin : MonoBehaviour
{
	// Token: 0x06001932 RID: 6450 RVA: 0x000787C2 File Offset: 0x000769C2
	private void Start()
	{
		this.pd = PlayerData.instance;
	}

	// Token: 0x06001933 RID: 6451 RVA: 0x000787CF File Offset: 0x000769CF
	private void OnEnable()
	{
		if (this.pd == null)
		{
			this.pd = PlayerData.instance;
		}
		if (this.pd.GetVariable<List<string>>("scenesGrubRescued").Contains(base.name))
		{
			base.gameObject.SetActive(false);
		}
	}

	// Token: 0x04001E3F RID: 7743
	private PlayerData pd;
}
