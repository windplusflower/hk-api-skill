using System;
using HutongGames.PlayMaker;

// Token: 0x0200030D RID: 781
[ActionCategory("Hollow Knight")]
public class GetRespawningHero : FsmStateAction
{
	// Token: 0x06001128 RID: 4392 RVA: 0x00050D54 File Offset: 0x0004EF54
	public override void Reset()
	{
		this.variable = new FsmBool();
	}

	// Token: 0x06001129 RID: 4393 RVA: 0x00050D61 File Offset: 0x0004EF61
	public override void OnEnter()
	{
		if (GameManager.instance)
		{
			this.variable.Value = GameManager.instance.RespawningHero;
		}
		base.Finish();
	}

	// Token: 0x040010E6 RID: 4326
	[RequiredField]
	[UIHint(UIHint.Variable)]
	public FsmBool variable;
}
