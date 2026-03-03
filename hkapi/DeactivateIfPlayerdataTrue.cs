using System;
using UnityEngine;

// Token: 0x0200011A RID: 282
public class DeactivateIfPlayerdataTrue : MonoBehaviour
{
	// Token: 0x060006A3 RID: 1699 RVA: 0x00026D36 File Offset: 0x00024F36
	private void Start()
	{
		this.gm = GameManager.instance;
		this.pd = this.gm.playerData;
	}

	// Token: 0x060006A4 RID: 1700 RVA: 0x00026D54 File Offset: 0x00024F54
	private void OnEnable()
	{
		if (this.gm == null)
		{
			this.gm = GameManager.instance;
		}
		if (this.pd == null)
		{
			this.pd = this.gm.playerData;
		}
		if (this.pd.GetBool(this.boolName))
		{
			base.gameObject.SetActive(false);
		}
	}

	// Token: 0x04000737 RID: 1847
	public string boolName;

	// Token: 0x04000738 RID: 1848
	private GameManager gm;

	// Token: 0x04000739 RID: 1849
	private PlayerData pd;
}
