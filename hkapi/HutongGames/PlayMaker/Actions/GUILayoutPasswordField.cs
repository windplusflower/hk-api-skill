using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000BB8 RID: 3000
	[ActionCategory(ActionCategory.GUILayout)]
	[Tooltip("GUILayout Password Field. Optionally send an event if the text has been edited.")]
	public class GUILayoutPasswordField : GUILayoutAction
	{
		// Token: 0x06003F5C RID: 16220 RVA: 0x00166FEA File Offset: 0x001651EA
		public override void Reset()
		{
			this.text = null;
			this.maxLength = 25;
			this.style = "TextField";
			this.mask = "*";
			this.changedEvent = null;
		}

		// Token: 0x06003F5D RID: 16221 RVA: 0x00167028 File Offset: 0x00165228
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

		// Token: 0x0400437C RID: 17276
		[UIHint(UIHint.Variable)]
		[Tooltip("The password Text")]
		public FsmString text;

		// Token: 0x0400437D RID: 17277
		[Tooltip("The Maximum Length of the field")]
		public FsmInt maxLength;

		// Token: 0x0400437E RID: 17278
		[Tooltip("The Style of the Field")]
		public FsmString style;

		// Token: 0x0400437F RID: 17279
		[Tooltip("Event sent when field content changed")]
		public FsmEvent changedEvent;

		// Token: 0x04004380 RID: 17280
		[Tooltip("Replacement character to hide the password")]
		public FsmString mask;
	}
}
