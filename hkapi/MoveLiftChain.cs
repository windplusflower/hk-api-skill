using System;
using HutongGames.PlayMaker;

// Token: 0x0200051A RID: 1306
[ActionCategory("Hollow Knight")]
public class MoveLiftChain : LiftChainAction
{
	// Token: 0x06001CB7 RID: 7351 RVA: 0x000861AC File Offset: 0x000843AC
	protected override void Apply(LiftChain liftChain)
	{
		if (!this.goUp.IsNone)
		{
			if (this.goUp.Value)
			{
				liftChain.GoUp();
				return;
			}
			liftChain.GoDown();
		}
	}

	// Token: 0x06001CB8 RID: 7352 RVA: 0x000861D5 File Offset: 0x000843D5
	public MoveLiftChain()
	{
		this.goUp = new FsmBool();
		base..ctor();
	}

	// Token: 0x04002232 RID: 8754
	public FsmBool goUp;
}
