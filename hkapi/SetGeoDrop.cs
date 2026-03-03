using System;
using HutongGames.PlayMaker;
using UnityEngine;

// Token: 0x020001AB RID: 427
[ActionCategory("Hollow Knight")]
public class SetGeoDrop : FsmStateAction
{
	// Token: 0x0600097D RID: 2429 RVA: 0x000345C2 File Offset: 0x000327C2
	public override void Reset()
	{
		this.target = new FsmOwnerDefault();
		this.smallGeo = new FsmInt();
		this.mediumGeo = new FsmInt();
		this.largeGeo = new FsmInt();
	}

	// Token: 0x0600097E RID: 2430 RVA: 0x000345F0 File Offset: 0x000327F0
	public override void OnEnter()
	{
		GameObject safe = this.target.GetSafe(this);
		if (safe != null)
		{
			HealthManager component = safe.GetComponent<HealthManager>();
			if (component != null)
			{
				if (!this.smallGeo.IsNone)
				{
					component.SetGeoSmall(this.smallGeo.Value);
				}
				if (!this.mediumGeo.IsNone)
				{
					component.SetGeoMedium(this.mediumGeo.Value);
				}
				if (!this.largeGeo.IsNone)
				{
					component.SetGeoLarge(this.largeGeo.Value);
				}
			}
		}
		base.Finish();
	}

	// Token: 0x04000A96 RID: 2710
	[UIHint(UIHint.Variable)]
	public FsmOwnerDefault target;

	// Token: 0x04000A97 RID: 2711
	public FsmInt smallGeo;

	// Token: 0x04000A98 RID: 2712
	public FsmInt mediumGeo;

	// Token: 0x04000A99 RID: 2713
	public FsmInt largeGeo;
}
