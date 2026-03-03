using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000BFE RID: 3070
	[ActionCategory(ActionCategory.Input)]
	[Tooltip("Sends an Event when the specified Mouse Button is released. Optionally store the button state in a bool variable.")]
	public class GetMouseButtonUp : FsmStateAction
	{
		// Token: 0x06004081 RID: 16513 RVA: 0x0016A62D File Offset: 0x0016882D
		public override void Reset()
		{
			this.button = MouseButton.Left;
			this.sendEvent = null;
			this.storeResult = null;
			this.inUpdateOnly = true;
		}

		// Token: 0x06004082 RID: 16514 RVA: 0x0016A64B File Offset: 0x0016884B
		public override void OnEnter()
		{
			if (!this.inUpdateOnly)
			{
				this.DoGetMouseButtonUp();
			}
		}

		// Token: 0x06004083 RID: 16515 RVA: 0x0016A65B File Offset: 0x0016885B
		public override void OnUpdate()
		{
			this.DoGetMouseButtonUp();
		}

		// Token: 0x06004084 RID: 16516 RVA: 0x0016A664 File Offset: 0x00168864
		public void DoGetMouseButtonUp()
		{
			bool mouseButtonUp = Input.GetMouseButtonUp((int)this.button);
			if (mouseButtonUp)
			{
				base.Fsm.Event(this.sendEvent);
			}
			this.storeResult.Value = mouseButtonUp;
		}

		// Token: 0x040044DD RID: 17629
		[RequiredField]
		[Tooltip("The mouse button to test.")]
		public MouseButton button;

		// Token: 0x040044DE RID: 17630
		[Tooltip("Event to send if the mouse button is down.")]
		public FsmEvent sendEvent;

		// Token: 0x040044DF RID: 17631
		[UIHint(UIHint.Variable)]
		[Tooltip("Store the pressed state in a Bool Variable.")]
		public FsmBool storeResult;

		// Token: 0x040044E0 RID: 17632
		[Tooltip("Uncheck to run when entering the state.")]
		public bool inUpdateOnly;
	}
}
