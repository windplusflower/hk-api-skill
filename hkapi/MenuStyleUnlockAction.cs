using System;
using HutongGames.PlayMaker;

// Token: 0x0200049C RID: 1180
[ActionCategory("Hollow Knight")]
public class MenuStyleUnlockAction : FsmStateAction
{
	// Token: 0x06001A53 RID: 6739 RVA: 0x0007E602 File Offset: 0x0007C802
	public override void Reset()
	{
		this.unlockKey = null;
	}

	// Token: 0x06001A54 RID: 6740 RVA: 0x0007E60B File Offset: 0x0007C80B
	public override void OnEnter()
	{
		if (!string.IsNullOrEmpty(this.unlockKey.Value))
		{
			MenuStyleUnlock.Unlock(this.unlockKey.Value);
		}
		base.Finish();
	}

	// Token: 0x04001FAB RID: 8107
	public FsmString unlockKey;
}
