using System;
using HutongGames.PlayMaker;

// Token: 0x020001C4 RID: 452
[ActionCategory("Hollow Knight")]
public class CheckCanSeeHero : FsmStateAction
{
	// Token: 0x060009FB RID: 2555 RVA: 0x000372CD File Offset: 0x000354CD
	public override void Reset()
	{
		this.storeResult = new FsmBool();
	}

	// Token: 0x060009FC RID: 2556 RVA: 0x000372DA File Offset: 0x000354DA
	public override void OnEnter()
	{
		this.source = base.Owner.GetComponent<LineOfSightDetector>();
		this.Apply();
		if (!this.everyFrame)
		{
			base.Finish();
		}
	}

	// Token: 0x060009FD RID: 2557 RVA: 0x00037301 File Offset: 0x00035501
	public override void OnUpdate()
	{
		this.Apply();
	}

	// Token: 0x060009FE RID: 2558 RVA: 0x00037309 File Offset: 0x00035509
	private void Apply()
	{
		if (this.source != null)
		{
			this.storeResult.Value = this.source.CanSeeHero;
			return;
		}
		this.storeResult.Value = false;
	}

	// Token: 0x04000B1C RID: 2844
	[UIHint(UIHint.Variable)]
	public FsmBool storeResult;

	// Token: 0x04000B1D RID: 2845
	public bool everyFrame;

	// Token: 0x04000B1E RID: 2846
	private LineOfSightDetector source;
}
