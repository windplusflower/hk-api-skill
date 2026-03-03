using System;
using HutongGames.PlayMaker;
using UnityEngine;

// Token: 0x0200024E RID: 590
[ActionCategory("Hollow Knight")]
public class GGGetBossDoorCompletion : FsmStateAction
{
	// Token: 0x06000C6B RID: 3179 RVA: 0x0003F78D File Offset: 0x0003D98D
	public override void Reset()
	{
		this.unlocked = null;
		this.completed = null;
		this.allBindings = null;
		this.noHits = null;
		this.boundNail = null;
		this.boundShell = null;
		this.boundCharms = null;
		this.boundSoul = null;
	}

	// Token: 0x06000C6C RID: 3180 RVA: 0x0003F7C8 File Offset: 0x0003D9C8
	public override void OnEnter()
	{
		if (!string.IsNullOrEmpty(this.playerDataVariable.Value))
		{
			BossSequenceDoor.Completion completion = GameManager.instance.GetPlayerDataVariable<BossSequenceDoor.Completion>(this.playerDataVariable.Value);
			this.unlocked.Value = completion.unlocked;
			this.completed.Value = completion.completed;
			this.allBindings.Value = completion.allBindings;
			this.noHits.Value = completion.noHits;
			this.boundNail.Value = completion.boundNail;
			this.boundShell.Value = completion.boundShell;
			this.boundCharms.Value = completion.boundCharms;
			this.boundSoul.Value = completion.boundSoul;
		}
		base.Finish();
	}

	// Token: 0x04000D47 RID: 3399
	public FsmString playerDataVariable;

	// Token: 0x04000D48 RID: 3400
	[Space]
	[UIHint(UIHint.Variable)]
	public FsmBool unlocked;

	// Token: 0x04000D49 RID: 3401
	[UIHint(UIHint.Variable)]
	public FsmBool completed;

	// Token: 0x04000D4A RID: 3402
	[UIHint(UIHint.Variable)]
	public FsmBool allBindings;

	// Token: 0x04000D4B RID: 3403
	[UIHint(UIHint.Variable)]
	public FsmBool noHits;

	// Token: 0x04000D4C RID: 3404
	[Space]
	[UIHint(UIHint.Variable)]
	public FsmBool boundNail;

	// Token: 0x04000D4D RID: 3405
	[UIHint(UIHint.Variable)]
	public FsmBool boundShell;

	// Token: 0x04000D4E RID: 3406
	[UIHint(UIHint.Variable)]
	public FsmBool boundCharms;

	// Token: 0x04000D4F RID: 3407
	[UIHint(UIHint.Variable)]
	public FsmBool boundSoul;
}
