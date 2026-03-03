using System;
using UnityEngine;

// Token: 0x02000119 RID: 281
public class DeactivateIfPlayerdataFalseDelayed : MonoBehaviour
{
	// Token: 0x0600069F RID: 1695 RVA: 0x00026C92 File Offset: 0x00024E92
	private void Start()
	{
		this.gm = GameManager.instance;
		this.pd = this.gm.playerData;
	}

	// Token: 0x060006A0 RID: 1696 RVA: 0x00026CB0 File Offset: 0x00024EB0
	private void OnEnable()
	{
		if (this.delay <= 0f)
		{
			this.DoCheck();
			return;
		}
		base.Invoke("DoCheck", this.delay);
	}

	// Token: 0x060006A1 RID: 1697 RVA: 0x00026CD8 File Offset: 0x00024ED8
	private void DoCheck()
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

	// Token: 0x04000733 RID: 1843
	public string boolName;

	// Token: 0x04000734 RID: 1844
	public float delay;

	// Token: 0x04000735 RID: 1845
	private GameManager gm;

	// Token: 0x04000736 RID: 1846
	private PlayerData pd;
}
