using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000BCF RID: 3023
	[ActionCategory(ActionCategory.Input)]
	[Tooltip("Sends an Event when a Button is pressed.")]
	public class GetButtonDown : FsmStateAction
	{
		// Token: 0x06003FB6 RID: 16310 RVA: 0x0016822D File Offset: 0x0016642D
		public override void Reset()
		{
			this.buttonName = "Fire1";
			this.sendEvent = null;
			this.storeResult = null;
		}

		// Token: 0x06003FB7 RID: 16311 RVA: 0x00168250 File Offset: 0x00166450
		public override void OnUpdate()
		{
			bool buttonDown = Input.GetButtonDown(this.buttonName.Value);
			if (buttonDown)
			{
				base.Fsm.Event(this.sendEvent);
			}
			this.storeResult.Value = buttonDown;
		}

		// Token: 0x040043E7 RID: 17383
		[RequiredField]
		[Tooltip("The name of the button. Set in the Unity Input Manager.")]
		public FsmString buttonName;

		// Token: 0x040043E8 RID: 17384
		[Tooltip("Event to send if the button is pressed.")]
		public FsmEvent sendEvent;

		// Token: 0x040043E9 RID: 17385
		[Tooltip("Set to True if the button is pressed.")]
		[UIHint(UIHint.Variable)]
		public FsmBool storeResult;
	}
}
