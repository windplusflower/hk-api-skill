using System;
using HutongGames.PlayMaker;

// Token: 0x02000150 RID: 336
[ActionCategory("Hollow Knight")]
public class CheckAlertRange : FsmStateAction
{
	// Token: 0x060007D1 RID: 2001 RVA: 0x0002C12C File Offset: 0x0002A32C
	public override void Reset()
	{
		this.alertRange = new FsmObject();
		this.storeResult = new FsmBool();
	}

	// Token: 0x060007D2 RID: 2002 RVA: 0x0002C144 File Offset: 0x0002A344
	public override void OnEnter()
	{
		this.Apply();
		if (!this.everyFrame)
		{
			base.Finish();
		}
	}

	// Token: 0x060007D3 RID: 2003 RVA: 0x0002C15A File Offset: 0x0002A35A
	public override void OnUpdate()
	{
		this.Apply();
	}

	// Token: 0x060007D4 RID: 2004 RVA: 0x0002C164 File Offset: 0x0002A364
	private void Apply()
	{
		AlertRange alertRange = this.alertRange.Value as AlertRange;
		if (alertRange != null)
		{
			this.storeResult.Value = alertRange.IsHeroInRange;
			return;
		}
		this.storeResult.Value = false;
	}

	// Token: 0x040008A8 RID: 2216
	[UIHint(UIHint.Variable)]
	[ObjectType(typeof(AlertRange))]
	public FsmObject alertRange;

	// Token: 0x040008A9 RID: 2217
	[UIHint(UIHint.Variable)]
	public FsmBool storeResult;

	// Token: 0x040008AA RID: 2218
	public bool everyFrame;
}
