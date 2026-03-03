using System;
using HutongGames.PlayMaker;
using UnityEngine;

// Token: 0x02000515 RID: 1301
[ActionCategory("Hollow Knight")]
public class VibrationPlayerPlay : FsmStateAction
{
	// Token: 0x06001CA4 RID: 7332 RVA: 0x00085E98 File Offset: 0x00084098
	public override void Reset()
	{
		base.Reset();
		this.target = new FsmOwnerDefault();
	}

	// Token: 0x06001CA5 RID: 7333 RVA: 0x00085EAC File Offset: 0x000840AC
	public override void OnEnter()
	{
		base.OnEnter();
		GameObject safe = this.target.GetSafe(this);
		if (safe != null)
		{
			VibrationPlayer component = safe.GetComponent<VibrationPlayer>();
			if (component != null)
			{
				component.Play();
			}
		}
		base.Finish();
	}

	// Token: 0x04002229 RID: 8745
	public FsmOwnerDefault target;
}
