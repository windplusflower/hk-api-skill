using System;
using HutongGames.PlayMaker;

// Token: 0x02000151 RID: 337
[ActionCategory("Hollow Knight")]
public class CheckAlertRangeByName : FsmStateAction
{
	// Token: 0x060007D6 RID: 2006 RVA: 0x0002C1A9 File Offset: 0x0002A3A9
	public override void Reset()
	{
		this.storeResult = new FsmBool();
	}

	// Token: 0x060007D7 RID: 2007 RVA: 0x0002C1B6 File Offset: 0x0002A3B6
	public override void OnEnter()
	{
		this.source = AlertRange.Find(base.Owner, this.childName);
		this.Apply();
		if (!this.everyFrame)
		{
			base.Finish();
		}
	}

	// Token: 0x060007D8 RID: 2008 RVA: 0x0002C1E3 File Offset: 0x0002A3E3
	public override void OnUpdate()
	{
		this.Apply();
	}

	// Token: 0x060007D9 RID: 2009 RVA: 0x0002C1EB File Offset: 0x0002A3EB
	private void Apply()
	{
		if (this.source != null)
		{
			this.storeResult.Value = this.source.IsHeroInRange;
			return;
		}
		this.storeResult.Value = false;
	}

	// Token: 0x040008AB RID: 2219
	[UIHint(UIHint.Variable)]
	public FsmBool storeResult;

	// Token: 0x040008AC RID: 2220
	public string childName;

	// Token: 0x040008AD RID: 2221
	public bool everyFrame;

	// Token: 0x040008AE RID: 2222
	private AlertRange source;
}
