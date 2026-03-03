using System;
using UnityEngine;

// Token: 0x02000054 RID: 84
public class ActivateIfPlayerdataTrue : MonoBehaviour
{
	// Token: 0x060001BF RID: 447 RVA: 0x0000BEB4 File Offset: 0x0000A0B4
	private void Start()
	{
		this.gm = GameManager.instance;
		this.pd = this.gm.playerData;
		if (this.pd.GetBool(this.boolName))
		{
			base.gameObject.SetActive(true);
		}
	}

	// Token: 0x0400016D RID: 365
	public string boolName;

	// Token: 0x0400016E RID: 366
	private GameManager gm;

	// Token: 0x0400016F RID: 367
	private PlayerData pd;
}
