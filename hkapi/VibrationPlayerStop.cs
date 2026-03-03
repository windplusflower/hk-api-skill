using System;
using HutongGames.PlayMaker;
using UnityEngine;

// Token: 0x02000516 RID: 1302
[ActionCategory("Hollow Knight")]
public class VibrationPlayerStop : FsmStateAction
{
	// Token: 0x06001CA7 RID: 7335 RVA: 0x00085EF1 File Offset: 0x000840F1
	public override void Reset()
	{
		base.Reset();
		this.target = new FsmOwnerDefault();
	}

	// Token: 0x06001CA8 RID: 7336 RVA: 0x00085F04 File Offset: 0x00084104
	public override void OnEnter()
	{
		base.OnEnter();
		GameObject safe = this.target.GetSafe(this);
		if (safe != null)
		{
			VibrationPlayer component = safe.GetComponent<VibrationPlayer>();
			if (component != null)
			{
				component.Stop();
			}
		}
		base.Finish();
	}

	// Token: 0x0400222A RID: 8746
	public FsmOwnerDefault target;
}
