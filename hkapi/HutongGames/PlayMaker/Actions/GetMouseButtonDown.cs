using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000BFD RID: 3069
	[ActionCategory(ActionCategory.Input)]
	[Tooltip("Sends an Event when the specified Mouse Button is pressed. Optionally store the button state in a bool variable.")]
	public class GetMouseButtonDown : FsmStateAction
	{
		// Token: 0x0600407C RID: 16508 RVA: 0x0016A5BD File Offset: 0x001687BD
		public override void Reset()
		{
			this.button = MouseButton.Left;
			this.sendEvent = null;
			this.storeResult = null;
			this.inUpdateOnly = true;
		}

		// Token: 0x0600407D RID: 16509 RVA: 0x0016A5DB File Offset: 0x001687DB
		public override void OnEnter()
		{
			if (!this.inUpdateOnly)
			{
				this.DoGetMouseButtonDown();
			}
		}

		// Token: 0x0600407E RID: 16510 RVA: 0x0016A5EB File Offset: 0x001687EB
		public override void OnUpdate()
		{
			this.DoGetMouseButtonDown();
		}

		// Token: 0x0600407F RID: 16511 RVA: 0x0016A5F4 File Offset: 0x001687F4
		private void DoGetMouseButtonDown()
		{
			bool mouseButtonDown = Input.GetMouseButtonDown((int)this.button);
			if (mouseButtonDown)
			{
				base.Fsm.Event(this.sendEvent);
			}
			this.storeResult.Value = mouseButtonDown;
		}

		// Token: 0x040044D9 RID: 17625
		[RequiredField]
		[Tooltip("The mouse button to test.")]
		public MouseButton button;

		// Token: 0x040044DA RID: 17626
		[Tooltip("Event to send if the mouse button is down.")]
		public FsmEvent sendEvent;

		// Token: 0x040044DB RID: 17627
		[UIHint(UIHint.Variable)]
		[Tooltip("Store the button state in a Bool Variable.")]
		public FsmBool storeResult;

		// Token: 0x040044DC RID: 17628
		[Tooltip("Uncheck to run when entering the state.")]
		public bool inUpdateOnly;
	}
}
