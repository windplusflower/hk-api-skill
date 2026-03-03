using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000B70 RID: 2928
	[ActionCategory(ActionCategory.Device)]
	[Tooltip("Sends an Event when the mobile device is shaken.")]
	public class DeviceShakeEvent : FsmStateAction
	{
		// Token: 0x06003E50 RID: 15952 RVA: 0x00163DF0 File Offset: 0x00161FF0
		public override void Reset()
		{
			this.shakeThreshold = 3f;
			this.sendEvent = null;
		}

		// Token: 0x06003E51 RID: 15953 RVA: 0x00163E0C File Offset: 0x0016200C
		public override void OnUpdate()
		{
			if (Input.acceleration.sqrMagnitude > this.shakeThreshold.Value * this.shakeThreshold.Value)
			{
				base.Fsm.Event(this.sendEvent);
			}
		}

		// Token: 0x04004261 RID: 16993
		[RequiredField]
		[Tooltip("Amount of acceleration required to trigger the event. Higher numbers require a harder shake.")]
		public FsmFloat shakeThreshold;

		// Token: 0x04004262 RID: 16994
		[RequiredField]
		[Tooltip("Event to send when Shake Threshold is exceded.")]
		public FsmEvent sendEvent;
	}
}
