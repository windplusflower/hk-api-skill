using System;
using HutongGames.PlayMaker;

// Token: 0x020004FD RID: 1277
public class CheckStaticBool : FsmStateAction
{
	// Token: 0x06001C2A RID: 7210 RVA: 0x00085427 File Offset: 0x00083627
	public override void Reset()
	{
		this.variableName = null;
		this.trueEvent = null;
		this.falseEvent = null;
	}

	// Token: 0x06001C2B RID: 7211 RVA: 0x00085440 File Offset: 0x00083640
	public override void OnEnter()
	{
		if (!this.variableName.IsNone && StaticVariableList.Exists(this.variableName.Value) && StaticVariableList.GetValue<bool>(this.variableName.Value))
		{
			base.Fsm.Event(this.trueEvent);
		}
		base.Fsm.Event(this.falseEvent);
		base.Finish();
	}

	// Token: 0x040021E8 RID: 8680
	public FsmString variableName;

	// Token: 0x040021E9 RID: 8681
	public FsmEvent trueEvent;

	// Token: 0x040021EA RID: 8682
	public FsmEvent falseEvent;
}
