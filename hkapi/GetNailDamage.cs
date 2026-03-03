using System;
using HutongGames.PlayMaker;
using UnityEngine;

// Token: 0x02000212 RID: 530
public class GetNailDamage : FsmStateAction
{
	// Token: 0x06000B6E RID: 2926 RVA: 0x0003C702 File Offset: 0x0003A902
	public override void Reset()
	{
		this.storeValue = null;
	}

	// Token: 0x06000B6F RID: 2927 RVA: 0x0003C70C File Offset: 0x0003A90C
	public override void OnEnter()
	{
		if (!this.storeValue.IsNone)
		{
			if (BossSequenceController.BoundNail)
			{
				this.storeValue.Value = Mathf.Min(GameManager.instance.playerData.GetInt("nailDamage"), BossSequenceController.BoundNailDamage);
			}
			else
			{
				this.storeValue.Value = GameManager.instance.playerData.GetInt("nailDamage");
			}
		}
		base.Finish();
	}

	// Token: 0x04000C62 RID: 3170
	[UIHint(UIHint.Variable)]
	public FsmInt storeValue;
}
