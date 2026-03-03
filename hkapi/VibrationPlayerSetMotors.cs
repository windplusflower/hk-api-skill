using System;
using HutongGames.PlayMaker;
using UnityEngine;

// Token: 0x02000517 RID: 1303
[ActionCategory("Hollow Knight")]
public class VibrationPlayerSetMotors : FsmStateAction
{
	// Token: 0x06001CAA RID: 7338 RVA: 0x00085F49 File Offset: 0x00084149
	public override void Reset()
	{
		base.Reset();
		this.target = new FsmOwnerDefault();
		this.motors = new FsmEnum
		{
			Value = VibrationMotors.All
		};
	}

	// Token: 0x06001CAB RID: 7339 RVA: 0x00085F74 File Offset: 0x00084174
	public override void OnEnter()
	{
		base.OnEnter();
		GameObject safe = this.target.GetSafe(this);
		if (safe != null)
		{
			VibrationPlayer component = safe.GetComponent<VibrationPlayer>();
			if (component != null && !this.motors.IsNone)
			{
				VibrationTarget vibrationTarget = component.Target;
				component.Target = new VibrationTarget((VibrationMotors)this.motors.Value);
			}
		}
		base.Finish();
	}

	// Token: 0x0400222B RID: 8747
	public FsmOwnerDefault target;

	// Token: 0x0400222C RID: 8748
	[ObjectType(typeof(VibrationMotors))]
	public FsmEnum motors;
}
