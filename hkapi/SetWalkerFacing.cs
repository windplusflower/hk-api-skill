using System;
using HutongGames.PlayMaker;
using UnityEngine;

// Token: 0x020001DD RID: 477
[ActionCategory("Hollow Knight")]
public class SetWalkerFacing : WalkerAction
{
	// Token: 0x06000A70 RID: 2672 RVA: 0x00038CC7 File Offset: 0x00036EC7
	public override void Reset()
	{
		base.Reset();
		this.walkRight = new FsmBool
		{
			UseVariable = true
		};
		this.randomStartDir = new FsmBool();
	}

	// Token: 0x06000A71 RID: 2673 RVA: 0x00038CEC File Offset: 0x00036EEC
	protected override void Apply(Walker walker)
	{
		if (this.randomStartDir.Value)
		{
			walker.ChangeFacing((UnityEngine.Random.Range(0, 2) == 0) ? -1 : 1);
			return;
		}
		if (!this.walkRight.IsNone)
		{
			walker.ChangeFacing(this.walkRight.Value ? 1 : -1);
		}
	}

	// Token: 0x04000B9A RID: 2970
	public FsmBool walkRight;

	// Token: 0x04000B9B RID: 2971
	public FsmBool randomStartDir;
}
