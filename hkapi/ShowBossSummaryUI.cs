using System;
using HutongGames.PlayMaker;
using UnityEngine;

// Token: 0x0200026D RID: 621
[ActionCategory("Hollow Knight")]
public class ShowBossSummaryUI : FsmStateAction
{
	// Token: 0x06000D08 RID: 3336 RVA: 0x000419A6 File Offset: 0x0003FBA6
	public override void Reset()
	{
		this.target = null;
		this.activate = new FsmBool(true);
	}

	// Token: 0x06000D09 RID: 3337 RVA: 0x000419C0 File Offset: 0x0003FBC0
	public override void OnEnter()
	{
		GameObject safe = this.target.GetSafe(this);
		if (safe)
		{
			BossSummaryBoard component = safe.GetComponent<BossSummaryBoard>();
			if (component)
			{
				if (this.activate.Value)
				{
					component.Show();
				}
				else
				{
					component.Hide();
				}
			}
		}
		base.Finish();
	}

	// Token: 0x06000D0A RID: 3338 RVA: 0x00041A12 File Offset: 0x0003FC12
	public ShowBossSummaryUI()
	{
		this.activate = true;
		base..ctor();
	}

	// Token: 0x04000DF3 RID: 3571
	public FsmOwnerDefault target;

	// Token: 0x04000DF4 RID: 3572
	public FsmBool activate;
}
