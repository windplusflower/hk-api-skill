using System;
using HutongGames.PlayMaker;
using UnityEngine;

// Token: 0x0200024C RID: 588
[ActionCategory("Hollow Knight")]
public class ShowBossDoorLockedUI : FsmStateAction
{
	// Token: 0x06000C66 RID: 3174 RVA: 0x0003F6BF File Offset: 0x0003D8BF
	public override void Reset()
	{
		this.target = null;
		this.value = new FsmBool(true);
	}

	// Token: 0x06000C67 RID: 3175 RVA: 0x0003F6DC File Offset: 0x0003D8DC
	public override void OnEnter()
	{
		GameObject safe = this.target.GetSafe(this);
		if (safe)
		{
			BossSequenceDoor component = safe.GetComponent<BossSequenceDoor>();
			if (component)
			{
				component.ShowLockUI(this.value.Value);
			}
		}
		base.Finish();
	}

	// Token: 0x04000D45 RID: 3397
	public FsmOwnerDefault target;

	// Token: 0x04000D46 RID: 3398
	public FsmBool value;
}
