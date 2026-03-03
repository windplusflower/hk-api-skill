using System;
using HutongGames.PlayMaker;

// Token: 0x0200014F RID: 335
[ActionCategory("Hollow Knight")]
public class FindAlertRange : FsmStateAction
{
	// Token: 0x060007CE RID: 1998 RVA: 0x0002C0EA File Offset: 0x0002A2EA
	public override void Reset()
	{
		this.target = new FsmOwnerDefault();
		this.storeResult = new FsmObject();
	}

	// Token: 0x060007CF RID: 1999 RVA: 0x0002C102 File Offset: 0x0002A302
	public override void OnEnter()
	{
		this.storeResult.Value = AlertRange.Find(this.target.GetSafe(this), this.childName);
		base.Finish();
	}

	// Token: 0x040008A5 RID: 2213
	[UIHint(UIHint.Variable)]
	public FsmOwnerDefault target;

	// Token: 0x040008A6 RID: 2214
	[UIHint(UIHint.Variable)]
	[ObjectType(typeof(AlertRange))]
	public FsmObject storeResult;

	// Token: 0x040008A7 RID: 2215
	public string childName;
}
