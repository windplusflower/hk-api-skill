using System;
using HutongGames.PlayMaker;

// Token: 0x020001DE RID: 478
[ActionCategory("Hollow Knight")]
public class SetWalkerSpeed : WalkerAction
{
	// Token: 0x06000A73 RID: 2675 RVA: 0x00038D3E File Offset: 0x00036F3E
	public override void Reset()
	{
		base.Reset();
		this.walkSpeedL = new FsmFloat
		{
			UseVariable = true
		};
		this.walkSpeedR = new FsmFloat
		{
			UseVariable = true
		};
	}

	// Token: 0x06000A74 RID: 2676 RVA: 0x00038D6A File Offset: 0x00036F6A
	protected override void Apply(Walker walker)
	{
		if (!this.walkSpeedL.IsNone)
		{
			walker.walkSpeedL = this.walkSpeedL.Value;
		}
		if (!this.walkSpeedR.IsNone)
		{
			walker.walkSpeedR = this.walkSpeedR.Value;
		}
	}

	// Token: 0x04000B9C RID: 2972
	public FsmFloat walkSpeedL;

	// Token: 0x04000B9D RID: 2973
	public FsmFloat walkSpeedR;
}
