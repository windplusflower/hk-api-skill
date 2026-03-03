using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000BBB RID: 3003
	[ActionCategory(ActionCategory.GUILayout)]
	[Tooltip("GUILayout Text Field. Optionally send an event if the text has been edited.")]
	public class GUILayoutTextField : GUILayoutAction
	{
		// Token: 0x06003F65 RID: 16229 RVA: 0x001671D9 File Offset: 0x001653D9
		public override void Reset()
		{
			base.Reset();
			this.text = null;
			this.maxLength = 25;
			this.style = "TextField";
			this.changedEvent = null;
		}

		// Token: 0x06003F66 RID: 16230 RVA: 0x0016720C File Offset: 0x0016540C
		public override void OnGUI()
		{
			bool changed = GUI.changed;
			GUI.changed = false;
			this.text.Value = GUILayout.TextField(this.text.Value, this.maxLength.Value, this.style.Value, base.LayoutOptions);
			if (GUI.changed)
			{
				base.Fsm.Event(this.changedEvent);
				GUIUtility.ExitGUI();
				return;
			}
			GUI.changed = changed;
		}

		// Token: 0x04004388 RID: 17288
		[UIHint(UIHint.Variable)]
		public FsmString text;

		// Token: 0x04004389 RID: 17289
		public FsmInt maxLength;

		// Token: 0x0400438A RID: 17290
		public FsmString style;

		// Token: 0x0400438B RID: 17291
		public FsmEvent changedEvent;
	}
}
