using System;
using System.Collections.Generic;
using UnityEngine;

// Token: 0x0200026C RID: 620
public class BossSummaryBoard : MonoBehaviour
{
	// Token: 0x06000D04 RID: 3332 RVA: 0x00041908 File Offset: 0x0003FB08
	private void Start()
	{
		if (this.bossSummaryUI)
		{
			GameObject gameObject = UnityEngine.Object.Instantiate<GameObject>(this.bossSummaryUI);
			this.ui = gameObject.GetComponent<BossSummaryUI>();
			if (this.ui)
			{
				this.ui.SetupUI(this.bossStatues);
			}
			gameObject.SetActive(false);
		}
	}

	// Token: 0x06000D05 RID: 3333 RVA: 0x0004195F File Offset: 0x0003FB5F
	public void Show()
	{
		if (this.ui)
		{
			this.ui.Show();
		}
	}

	// Token: 0x06000D06 RID: 3334 RVA: 0x00041979 File Offset: 0x0003FB79
	public void Hide()
	{
		if (this.ui)
		{
			this.ui.Hide();
		}
	}

	// Token: 0x06000D07 RID: 3335 RVA: 0x00041993 File Offset: 0x0003FB93
	public BossSummaryBoard()
	{
		this.bossStatues = new List<BossStatue>();
		base..ctor();
	}

	// Token: 0x04000DF0 RID: 3568
	public List<BossStatue> bossStatues;

	// Token: 0x04000DF1 RID: 3569
	[Space]
	public GameObject bossSummaryUI;

	// Token: 0x04000DF2 RID: 3570
	private BossSummaryUI ui;
}
