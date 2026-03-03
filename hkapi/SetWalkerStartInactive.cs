using System;
using HutongGames.PlayMaker;

// Token: 0x020001DF RID: 479
[ActionCategory("Hollow Knight")]
public class SetWalkerStartInactive : WalkerAction
{
	// Token: 0x06000A76 RID: 2678 RVA: 0x00038DA8 File Offset: 0x00036FA8
	public override void Reset()
	{
		base.Reset();
		this.startInactive = new FsmBool();
	}

	// Token: 0x06000A77 RID: 2679 RVA: 0x00038DBB File Offset: 0x00036FBB
	protected override void Apply(Walker walker)
	{
		walker.startInactive = this.startInactive.Value;
	}

	// Token: 0x04000B9E RID: 2974
	public FsmBool startInactive;
}
