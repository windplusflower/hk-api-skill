using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000BB4 RID: 2996
	[ActionCategory(ActionCategory.GUILayout)]
	[Tooltip("A Horizontal Slider linked to a Float Variable.")]
	public class GUILayoutHorizontalSlider : GUILayoutAction
	{
		// Token: 0x06003F50 RID: 16208 RVA: 0x00166CBA File Offset: 0x00164EBA
		public override void Reset()
		{
			base.Reset();
			this.floatVariable = null;
			this.leftValue = 0f;
			this.rightValue = 100f;
			this.changedEvent = null;
		}

		// Token: 0x06003F51 RID: 16209 RVA: 0x00166CF0 File Offset: 0x00164EF0
		public override void OnGUI()
		{
			bool changed = GUI.changed;
			GUI.changed = false;
			if (this.floatVariable != null)
			{
				this.floatVariable.Value = GUILayout.HorizontalSlider(this.floatVariable.Value, this.leftValue.Value, this.rightValue.Value, base.LayoutOptions);
			}
			if (GUI.changed)
			{
				base.Fsm.Event(this.changedEvent);
				GUIUtility.ExitGUI();
				return;
			}
			GUI.changed = changed;
		}

		// Token: 0x0400436E RID: 17262
		[RequiredField]
		[UIHint(UIHint.Variable)]
		public FsmFloat floatVariable;

		// Token: 0x0400436F RID: 17263
		[RequiredField]
		public FsmFloat leftValue;

		// Token: 0x04004370 RID: 17264
		[RequiredField]
		public FsmFloat rightValue;

		// Token: 0x04004371 RID: 17265
		public FsmEvent changedEvent;
	}
}
