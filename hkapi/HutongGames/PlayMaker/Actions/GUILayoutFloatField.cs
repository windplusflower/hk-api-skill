using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000BB2 RID: 2994
	[ActionCategory(ActionCategory.GUILayout)]
	[Tooltip("GUILayout Text Field to edit a Float Variable. Optionally send an event if the text has been edited.")]
	public class GUILayoutFloatField : GUILayoutAction
	{
		// Token: 0x06003F4A RID: 16202 RVA: 0x00166B10 File Offset: 0x00164D10
		public override void Reset()
		{
			base.Reset();
			this.floatVariable = null;
			this.style = "";
			this.changedEvent = null;
		}

		// Token: 0x06003F4B RID: 16203 RVA: 0x00166B38 File Offset: 0x00164D38
		public override void OnGUI()
		{
			bool changed = GUI.changed;
			GUI.changed = false;
			if (!string.IsNullOrEmpty(this.style.Value))
			{
				this.floatVariable.Value = float.Parse(GUILayout.TextField(this.floatVariable.Value.ToString(), this.style.Value, base.LayoutOptions));
			}
			else
			{
				this.floatVariable.Value = float.Parse(GUILayout.TextField(this.floatVariable.Value.ToString(), base.LayoutOptions));
			}
			if (GUI.changed)
			{
				base.Fsm.Event(this.changedEvent);
				GUIUtility.ExitGUI();
				return;
			}
			GUI.changed = changed;
		}

		// Token: 0x04004368 RID: 17256
		[UIHint(UIHint.Variable)]
		[Tooltip("Float Variable to show in the edit field.")]
		public FsmFloat floatVariable;

		// Token: 0x04004369 RID: 17257
		[Tooltip("Optional GUIStyle in the active GUISKin.")]
		public FsmString style;

		// Token: 0x0400436A RID: 17258
		[Tooltip("Optional event to send when the value changes.")]
		public FsmEvent changedEvent;
	}
}
