using System;
using HutongGames.PlayMaker;

// Token: 0x020001C3 RID: 451
[ActionCategory("Hollow Knight")]
public class GetCanSeeHero : FsmStateAction
{
	// Token: 0x060009F6 RID: 2550 RVA: 0x00037251 File Offset: 0x00035451
	public override void Reset()
	{
		this.lineOfSightDetector = new FsmObject();
		this.storeResult = new FsmBool();
	}

	// Token: 0x060009F7 RID: 2551 RVA: 0x00037269 File Offset: 0x00035469
	public override void OnEnter()
	{
		this.Apply();
		if (!this.everyFrame)
		{
			base.Finish();
		}
	}

	// Token: 0x060009F8 RID: 2552 RVA: 0x0003727F File Offset: 0x0003547F
	public override void OnUpdate()
	{
		this.Apply();
	}

	// Token: 0x060009F9 RID: 2553 RVA: 0x00037288 File Offset: 0x00035488
	private void Apply()
	{
		LineOfSightDetector lineOfSightDetector = this.lineOfSightDetector.Value as LineOfSightDetector;
		if (lineOfSightDetector != null)
		{
			this.storeResult.Value = lineOfSightDetector.CanSeeHero;
			return;
		}
		this.storeResult.Value = false;
	}

	// Token: 0x04000B19 RID: 2841
	[UIHint(UIHint.Variable)]
	[ObjectType(typeof(LineOfSightDetector))]
	public FsmObject lineOfSightDetector;

	// Token: 0x04000B1A RID: 2842
	[UIHint(UIHint.Variable)]
	public FsmBool storeResult;

	// Token: 0x04000B1B RID: 2843
	public bool everyFrame;
}
