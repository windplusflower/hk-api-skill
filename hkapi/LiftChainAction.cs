using System;
using HutongGames.PlayMaker;
using UnityEngine;

// Token: 0x02000519 RID: 1305
[ActionCategory("Hollow Knight")]
public abstract class LiftChainAction : FsmStateAction
{
	// Token: 0x06001CB2 RID: 7346 RVA: 0x00086107 File Offset: 0x00084307
	public override void Reset()
	{
		base.Reset();
		this.target = new FsmOwnerDefault();
		this.everyFrame = false;
	}

	// Token: 0x06001CB3 RID: 7347 RVA: 0x00086124 File Offset: 0x00084324
	public override void OnEnter()
	{
		base.OnEnter();
		GameObject safe = this.target.GetSafe(this);
		if (safe != null)
		{
			this.liftChain = safe.GetComponent<LiftChain>();
			if (this.liftChain != null)
			{
				this.Apply(this.liftChain);
			}
		}
		else
		{
			this.liftChain = null;
		}
		if (!this.everyFrame)
		{
			base.Finish();
		}
	}

	// Token: 0x06001CB4 RID: 7348 RVA: 0x0008618A File Offset: 0x0008438A
	public override void OnUpdate()
	{
		base.OnUpdate();
		if (this.liftChain != null)
		{
			this.Apply(this.liftChain);
		}
	}

	// Token: 0x06001CB5 RID: 7349
	protected abstract void Apply(LiftChain liftChain);

	// Token: 0x0400222F RID: 8751
	public FsmOwnerDefault target;

	// Token: 0x04002230 RID: 8752
	public bool everyFrame;

	// Token: 0x04002231 RID: 8753
	private LiftChain liftChain;
}
