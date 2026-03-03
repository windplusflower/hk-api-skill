using System;
using HutongGames.PlayMaker;

// Token: 0x0200029D RID: 669
[ActionCategory("Hollow Knight")]
public class ShowGodfinderIconQueued : FsmStateAction
{
	// Token: 0x06000E07 RID: 3591 RVA: 0x000450BD File Offset: 0x000432BD
	public override void Reset()
	{
		this.delay = null;
	}

	// Token: 0x06000E08 RID: 3592 RVA: 0x000450C6 File Offset: 0x000432C6
	public override void OnEnter()
	{
		GodfinderIcon.ShowIconQueued(this.delay.Value);
		base.Finish();
	}

	// Token: 0x04000EDD RID: 3805
	public FsmFloat delay;
}
