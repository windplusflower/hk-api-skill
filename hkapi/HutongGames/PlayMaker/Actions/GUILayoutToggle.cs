using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000BBD RID: 3005
	[ActionCategory(ActionCategory.GUILayout)]
	[Tooltip("Makes an on/off Toggle Button and stores the button state in a Bool Variable.")]
	public class GUILayoutToggle : GUILayoutAction
	{
		// Token: 0x06003F6B RID: 16235 RVA: 0x00167318 File Offset: 0x00165518
		public override void Reset()
		{
			base.Reset();
			this.storeButtonState = null;
			this.text = "";
			this.image = null;
			this.tooltip = "";
			this.style = "Toggle";
			this.changedEvent = null;
		}

		// Token: 0x06003F6C RID: 16236 RVA: 0x00167370 File Offset: 0x00165570
		public override void OnGUI()
		{
			bool changed = GUI.changed;
			GUI.changed = false;
			this.storeButtonState.Value = GUILayout.Toggle(this.storeButtonState.Value, new GUIContent(this.text.Value, this.image.Value, this.tooltip.Value), this.style.Value, base.LayoutOptions);
			if (GUI.changed)
			{
				base.Fsm.Event(this.changedEvent);
				GUIUtility.ExitGUI();
				return;
			}
			GUI.changed = changed;
		}

		// Token: 0x0400438E RID: 17294
		[RequiredField]
		[UIHint(UIHint.Variable)]
		public FsmBool storeButtonState;

		// Token: 0x0400438F RID: 17295
		public FsmTexture image;

		// Token: 0x04004390 RID: 17296
		public FsmString text;

		// Token: 0x04004391 RID: 17297
		public FsmString tooltip;

		// Token: 0x04004392 RID: 17298
		public FsmString style;

		// Token: 0x04004393 RID: 17299
		public FsmEvent changedEvent;
	}
}
