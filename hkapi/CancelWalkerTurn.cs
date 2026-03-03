using System;
using HutongGames.PlayMaker;

// Token: 0x020001DC RID: 476
[ActionCategory("Hollow Knight")]
public class CancelWalkerTurn : WalkerAction
{
	// Token: 0x06000A6E RID: 2670 RVA: 0x00038CBF File Offset: 0x00036EBF
	protected override void Apply(Walker walker)
	{
		walker.CancelTurn();
	}
}
