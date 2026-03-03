using System;
using HutongGames.PlayMaker;

// Token: 0x0200051B RID: 1307
[ActionCategory("Hollow Knight")]
public class StopLiftChain : LiftChainAction
{
	// Token: 0x06001CB9 RID: 7353 RVA: 0x000861E8 File Offset: 0x000843E8
	protected override void Apply(LiftChain liftChain)
	{
		liftChain.Stop();
	}
}
