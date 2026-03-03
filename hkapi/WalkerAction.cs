using System;
using HutongGames.PlayMaker;
using UnityEngine;

// Token: 0x020001D9 RID: 473
[ActionCategory("Hollow Knight")]
public abstract class WalkerAction : FsmStateAction
{
	// Token: 0x06000A64 RID: 2660 RVA: 0x00038BBC File Offset: 0x00036DBC
	public override void Reset()
	{
		base.Reset();
		this.target = new FsmOwnerDefault();
		this.everyFrame = false;
	}

	// Token: 0x06000A65 RID: 2661 RVA: 0x00038BD8 File Offset: 0x00036DD8
	public override void OnEnter()
	{
		base.OnEnter();
		GameObject safe = this.target.GetSafe(this);
		if (safe != null)
		{
			this.walker = safe.GetComponent<Walker>();
			if (this.walker != null)
			{
				this.Apply(this.walker);
			}
		}
		else
		{
			this.walker = null;
		}
		if (!this.everyFrame)
		{
			base.Finish();
		}
	}

	// Token: 0x06000A66 RID: 2662 RVA: 0x00038C3E File Offset: 0x00036E3E
	public override void OnUpdate()
	{
		base.OnUpdate();
		if (this.walker != null)
		{
			this.Apply(this.walker);
		}
	}

	// Token: 0x06000A67 RID: 2663
	protected abstract void Apply(Walker walker);

	// Token: 0x04000B96 RID: 2966
	public FsmOwnerDefault target;

	// Token: 0x04000B97 RID: 2967
	public bool everyFrame;

	// Token: 0x04000B98 RID: 2968
	private Walker walker;
}
