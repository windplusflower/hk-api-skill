using System;
using HutongGames.PlayMaker;

// Token: 0x02000031 RID: 49
[ActionCategory("Hollow Knight")]
public class WaitForHeroInPosition : FsmStateAction
{
	// Token: 0x06000115 RID: 277 RVA: 0x000065F2 File Offset: 0x000047F2
	public override void Reset()
	{
		this.sendEvent = null;
		this.skipIfAlreadyPositioned = new FsmBool(false);
	}

	// Token: 0x06000116 RID: 278 RVA: 0x0000660C File Offset: 0x0000480C
	public override void OnEnter()
	{
		if (HeroController.instance && !HeroController.instance.isHeroInPosition)
		{
			HeroController.HeroInPosition temp = null;
			temp = delegate(bool <p0>)
			{
				this.Fsm.Event(this.sendEvent);
				HeroController.instance.heroInPosition -= temp;
				this.Finish();
			};
			HeroController.instance.heroInPosition += temp;
			return;
		}
		base.Finish();
	}

	// Token: 0x040000DA RID: 218
	[RequiredField]
	public FsmEvent sendEvent;

	// Token: 0x040000DB RID: 219
	public FsmBool skipIfAlreadyPositioned;
}
