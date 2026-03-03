using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000BBF RID: 3007
	[ActionCategory(ActionCategory.GUILayout)]
	[Tooltip("A Vertical Slider linked to a Float Variable.")]
	public class GUILayoutVerticalSlider : GUILayoutAction
	{
		// Token: 0x06003F75 RID: 16245 RVA: 0x001676BA File Offset: 0x001658BA
		public override void Reset()
		{
			base.Reset();
			this.floatVariable = null;
			this.topValue = 100f;
			this.bottomValue = 0f;
			this.changedEvent = null;
		}

		// Token: 0x06003F76 RID: 16246 RVA: 0x001676F0 File Offset: 0x001658F0
		public override void OnGUI()
		{
			bool changed = GUI.changed;
			GUI.changed = false;
			if (this.floatVariable != null)
			{
				this.floatVariable.Value = GUILayout.VerticalSlider(this.floatVariable.Value, this.topValue.Value, this.bottomValue.Value, base.LayoutOptions);
			}
			if (GUI.changed)
			{
				base.Fsm.Event(this.changedEvent);
				GUIUtility.ExitGUI();
				return;
			}
			GUI.changed = changed;
		}

		// Token: 0x0400439D RID: 17309
		[RequiredField]
		[UIHint(UIHint.Variable)]
		public FsmFloat floatVariable;

		// Token: 0x0400439E RID: 17310
		[RequiredField]
		public FsmFloat topValue;

		// Token: 0x0400439F RID: 17311
		[RequiredField]
		public FsmFloat bottomValue;

		// Token: 0x040043A0 RID: 17312
		public FsmEvent changedEvent;
	}
}
