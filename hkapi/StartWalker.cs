using System;
using HutongGames.PlayMaker;

// Token: 0x020001DB RID: 475
[ActionCategory("Hollow Knight")]
public class StartWalker : WalkerAction
{
	// Token: 0x06000A6B RID: 2667 RVA: 0x00038C71 File Offset: 0x00036E71
	public override void Reset()
	{
		base.Reset();
		this.walkRight = new FsmBool
		{
			UseVariable = true
		};
	}

	// Token: 0x06000A6C RID: 2668 RVA: 0x00038C8B File Offset: 0x00036E8B
	protected override void Apply(Walker walker)
	{
		if (this.walkRight.IsNone)
		{
			walker.StartMoving();
		}
		else
		{
			walker.Go(this.walkRight.Value ? 1 : -1);
		}
		walker.ClearTurnCooldown();
	}

	// Token: 0x04000B99 RID: 2969
	public FsmBool walkRight;
}
