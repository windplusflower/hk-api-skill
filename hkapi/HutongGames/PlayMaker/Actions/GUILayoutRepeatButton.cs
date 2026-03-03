using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000BB9 RID: 3001
	[ActionCategory(ActionCategory.GUILayout)]
	[Tooltip("GUILayout Repeat Button. Sends an Event while pressed. Optionally store the button state in a Bool Variable.")]
	public class GUILayoutRepeatButton : GUILayoutAction
	{
		// Token: 0x06003F5F RID: 16223 RVA: 0x001670A8 File Offset: 0x001652A8
		public override void Reset()
		{
			base.Reset();
			this.sendEvent = null;
			this.storeButtonState = null;
			this.text = "";
			this.image = null;
			this.tooltip = "";
			this.style = "";
		}

		// Token: 0x06003F60 RID: 16224 RVA: 0x00167100 File Offset: 0x00165300
		public override void OnGUI()
		{
			bool flag;
			if (string.IsNullOrEmpty(this.style.Value))
			{
				flag = GUILayout.RepeatButton(new GUIContent(this.text.Value, this.image.Value, this.tooltip.Value), base.LayoutOptions);
			}
			else
			{
				flag = GUILayout.RepeatButton(new GUIContent(this.text.Value, this.image.Value, this.tooltip.Value), this.style.Value, base.LayoutOptions);
			}
			if (flag)
			{
				base.Fsm.Event(this.sendEvent);
			}
			this.storeButtonState.Value = flag;
		}

		// Token: 0x04004381 RID: 17281
		public FsmEvent sendEvent;

		// Token: 0x04004382 RID: 17282
		[UIHint(UIHint.Variable)]
		public FsmBool storeButtonState;

		// Token: 0x04004383 RID: 17283
		public FsmTexture image;

		// Token: 0x04004384 RID: 17284
		public FsmString text;

		// Token: 0x04004385 RID: 17285
		public FsmString tooltip;

		// Token: 0x04004386 RID: 17286
		public FsmString style;
	}
}
