using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000BAB RID: 2987
	[ActionCategory(ActionCategory.GUILayout)]
	[Tooltip("GUILayout Password Field. Optionally send an event if the text has been edited.")]
	public class GUILayoutEmailField : GUILayoutAction
	{
		// Token: 0x06003F36 RID: 16182 RVA: 0x00166A2B File Offset: 0x00164C2B
		public override void Reset()
		{
			this.text = null;
			this.maxLength = 25;
			this.style = "TextField";
			this.valid = true;
			this.changedEvent = null;
		}

		// Token: 0x06003F37 RID: 16183 RVA: 0x00166A64 File Offset: 0x00164C64
		public override void OnGUI()
		{
			bool changed = GUI.changed;
			GUI.changed = false;
			this.text.Value = GUILayout.TextField(this.text.Value, this.style.Value, base.LayoutOptions);
			if (GUI.changed)
			{
				base.Fsm.Event(this.changedEvent);
				GUIUtility.ExitGUI();
				return;
			}
			GUI.changed = changed;
		}

		// Token: 0x04004363 RID: 17251
		[UIHint(UIHint.Variable)]
		[Tooltip("The email Text")]
		public FsmString text;

		// Token: 0x04004364 RID: 17252
		[Tooltip("The Maximum Length of the field")]
		public FsmInt maxLength;

		// Token: 0x04004365 RID: 17253
		[Tooltip("The Style of the Field")]
		public FsmString style;

		// Token: 0x04004366 RID: 17254
		[Tooltip("Event sent when field content changed")]
		public FsmEvent changedEvent;

		// Token: 0x04004367 RID: 17255
		[Tooltip("Email valid format flag")]
		public FsmBool valid;
	}
}
