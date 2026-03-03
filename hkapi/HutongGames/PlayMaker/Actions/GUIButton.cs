using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000B9D RID: 2973
	[ActionCategory(ActionCategory.GUI)]
	[Tooltip("GUI button. Sends an Event when pressed. Optionally store the button state in a Bool Variable.")]
	public class GUIButton : GUIContentAction
	{
		// Token: 0x06003F0C RID: 16140 RVA: 0x00165EB0 File Offset: 0x001640B0
		public override void Reset()
		{
			base.Reset();
			this.sendEvent = null;
			this.storeButtonState = null;
			this.style = "Button";
		}

		// Token: 0x06003F0D RID: 16141 RVA: 0x00165ED8 File Offset: 0x001640D8
		public override void OnGUI()
		{
			base.OnGUI();
			bool value = false;
			if (GUI.Button(this.rect, this.content, this.style.Value))
			{
				base.Fsm.Event(this.sendEvent);
				value = true;
			}
			if (this.storeButtonState != null)
			{
				this.storeButtonState.Value = value;
			}
		}

		// Token: 0x04004326 RID: 17190
		public FsmEvent sendEvent;

		// Token: 0x04004327 RID: 17191
		[UIHint(UIHint.Variable)]
		public FsmBool storeButtonState;
	}
}
