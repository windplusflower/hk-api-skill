using System;
using HutongGames.PlayMaker;

// Token: 0x0200023D RID: 573
[ActionCategory("Hollow Knight/GG")]
public class GGCheckBoundSoul : FsmStateAction
{
	// Token: 0x06000C39 RID: 3129 RVA: 0x0003EC5F File Offset: 0x0003CE5F
	public override void Reset()
	{
		this.boundEvent = null;
		this.unboundEvent = null;
	}

	// Token: 0x06000C3A RID: 3130 RVA: 0x0003EC70 File Offset: 0x0003CE70
	public override void OnEnter()
	{
		if (BossSequenceController.IsInSequence)
		{
			if (BossSequenceController.BoundSoul)
			{
				base.Fsm.Event(this.boundEvent);
			}
			else
			{
				base.Fsm.Event(this.unboundEvent);
			}
		}
		else
		{
			base.Fsm.Event(this.unboundEvent);
		}
		base.Finish();
	}

	// Token: 0x04000D05 RID: 3333
	public FsmEvent boundEvent;

	// Token: 0x04000D06 RID: 3334
	public FsmEvent unboundEvent;
}
