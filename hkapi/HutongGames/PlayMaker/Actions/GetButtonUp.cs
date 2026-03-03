using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000BD0 RID: 3024
	[ActionCategory(ActionCategory.Input)]
	[Tooltip("Sends an Event when a Button is released.")]
	public class GetButtonUp : FsmStateAction
	{
		// Token: 0x06003FB9 RID: 16313 RVA: 0x0016828E File Offset: 0x0016648E
		public override void Reset()
		{
			this.buttonName = "Fire1";
			this.sendEvent = null;
			this.storeResult = null;
		}

		// Token: 0x06003FBA RID: 16314 RVA: 0x001682B0 File Offset: 0x001664B0
		public override void OnUpdate()
		{
			bool buttonUp = Input.GetButtonUp(this.buttonName.Value);
			if (buttonUp)
			{
				base.Fsm.Event(this.sendEvent);
			}
			this.storeResult.Value = buttonUp;
		}

		// Token: 0x040043EA RID: 17386
		[RequiredField]
		[Tooltip("The name of the button. Set in the Unity Input Manager.")]
		public FsmString buttonName;

		// Token: 0x040043EB RID: 17387
		[Tooltip("Event to send if the button is released.")]
		public FsmEvent sendEvent;

		// Token: 0x040043EC RID: 17388
		[UIHint(UIHint.Variable)]
		[Tooltip("Set to True if the button is released.")]
		public FsmBool storeResult;
	}
}
