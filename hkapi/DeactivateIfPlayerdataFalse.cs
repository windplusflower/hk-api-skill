using System;
using UnityEngine;

// Token: 0x02000118 RID: 280
public class DeactivateIfPlayerdataFalse : MonoBehaviour
{
	// Token: 0x0600069C RID: 1692 RVA: 0x00026C16 File Offset: 0x00024E16
	private void Start()
	{
		this.gm = GameManager.instance;
		this.pd = this.gm.playerData;
	}

	// Token: 0x0600069D RID: 1693 RVA: 0x00026C34 File Offset: 0x00024E34
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
		if (!this.pd.GetBool(this.boolName))
		{
			base.gameObject.SetActive(false);
		}
	}

	// Token: 0x04000730 RID: 1840
	public string boolName;

	// Token: 0x04000731 RID: 1841
	private GameManager gm;

	// Token: 0x04000732 RID: 1842
	private PlayerData pd;
}
