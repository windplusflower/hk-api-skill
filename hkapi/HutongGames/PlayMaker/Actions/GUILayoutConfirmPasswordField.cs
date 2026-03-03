using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000BAA RID: 2986
	[ActionCategory(ActionCategory.GUILayout)]
	[Tooltip("GUILayout Password Field. Optionally send an event if the text has been edited.")]
	public class GUILayoutConfirmPasswordField : GUILayoutAction
	{
		// Token: 0x06003F33 RID: 16179 RVA: 0x00166950 File Offset: 0x00164B50
		public override void Reset()
		{
			this.text = null;
			this.maxLength = 25;
			this.style = "TextField";
			this.mask = "*";
			this.changedEvent = null;
			this.confirm = false;
			this.password = null;
		}

		// Token: 0x06003F34 RID: 16180 RVA: 0x001669AC File Offset: 0x00164BAC
		public override void OnGUI()
		{
			bool changed = GUI.changed;
			GUI.changed = false;
			this.text.Value = GUILayout.PasswordField(this.text.Value, this.mask.Value[0], this.style.Value, base.LayoutOptions);
			if (GUI.changed)
			{
				base.Fsm.Event(this.changedEvent);
				GUIUtility.ExitGUI();
				return;
			}
			GUI.changed = changed;
		}

		// Token: 0x0400435C RID: 17244
		[UIHint(UIHint.Variable)]
		[Tooltip("The password Text")]
		public FsmString text;

		// Token: 0x0400435D RID: 17245
		[Tooltip("The Maximum Length of the field")]
		public FsmInt maxLength;

		// Token: 0x0400435E RID: 17246
		[Tooltip("The Style of the Field")]
		public FsmString style;

		// Token: 0x0400435F RID: 17247
		[Tooltip("Event sent when field content changed")]
		public FsmEvent changedEvent;

		// Token: 0x04004360 RID: 17248
		[Tooltip("Replacement character to hide the password")]
		public FsmString mask;

		// Token: 0x04004361 RID: 17249
		[Tooltip("GUILayout Password Field. Optionally send an event if the text has been edited.")]
		public FsmBool confirm;

		// Token: 0x04004362 RID: 17250
		[Tooltip("Confirmation content")]
		public FsmString password;
	}
}
