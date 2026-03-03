using System;
using HutongGames.PlayMaker;

// Token: 0x020001DA RID: 474
[ActionCategory("Hollow Knight")]
public class StopWalker : WalkerAction
{
	// Token: 0x06000A69 RID: 2665 RVA: 0x00038C60 File Offset: 0x00036E60
	protected override void Apply(Walker walker)
	{
		walker.Stop(Walker.StopReasons.Controlled);
	}
}
