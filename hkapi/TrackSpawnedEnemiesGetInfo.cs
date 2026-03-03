using System;
using HutongGames.PlayMaker;
using UnityEngine;

// Token: 0x020001D5 RID: 469
[ActionCategory("Hollow Knight")]
public class TrackSpawnedEnemiesGetInfo : FsmStateAction
{
	// Token: 0x06000A4B RID: 2635 RVA: 0x00038357 File Offset: 0x00036557
	public override void Reset()
	{
		this.Target = null;
		this.TotalTracked = null;
		this.TotalAlive = null;
	}

	// Token: 0x06000A4C RID: 2636 RVA: 0x00038370 File Offset: 0x00036570
	public override void OnEnter()
	{
		GameObject safe = this.Target.GetSafe(this);
		if (safe)
		{
			TrackSpawnedEnemies component = safe.GetComponent<TrackSpawnedEnemies>();
			if (component)
			{
				if (!this.TotalTracked.IsNone)
				{
					this.TotalTracked.Value = component.TotalTracked;
				}
				if (!this.TotalAlive.IsNone)
				{
					this.TotalAlive.Value = component.TotalAlive;
				}
			}
		}
		base.Finish();
	}

	// Token: 0x04000B61 RID: 2913
	public FsmOwnerDefault Target;

	// Token: 0x04000B62 RID: 2914
	[UIHint(UIHint.Variable)]
	public FsmInt TotalTracked;

	// Token: 0x04000B63 RID: 2915
	[UIHint(UIHint.Variable)]
	public FsmInt TotalAlive;
}
