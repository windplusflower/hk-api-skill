using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000BA9 RID: 2985
	[ActionCategory(ActionCategory.GUILayout)]
	[Tooltip("GUILayout Button. Sends an Event when pressed. Optionally stores the button state in a Bool Variable.")]
	public class GUILayoutButton : GUILayoutAction
	{
		// Token: 0x06003F30 RID: 16176 RVA: 0x00166838 File Offset: 0x00164A38
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

		// Token: 0x06003F31 RID: 16177 RVA: 0x00166890 File Offset: 0x00164A90
		public override void OnGUI()
		{
			bool flag;
			if (string.IsNullOrEmpty(this.style.Value))
			{
				flag = GUILayout.Button(new GUIContent(this.text.Value, this.image.Value, this.tooltip.Value), base.LayoutOptions);
			}
			else
			{
				flag = GUILayout.Button(new GUIContent(this.text.Value, this.image.Value, this.tooltip.Value), this.style.Value, base.LayoutOptions);
			}
			if (flag)
			{
				base.Fsm.Event(this.sendEvent);
			}
			if (this.storeButtonState != null)
			{
				this.storeButtonState.Value = flag;
			}
		}

		// Token: 0x04004356 RID: 17238
		public FsmEvent sendEvent;

		// Token: 0x04004357 RID: 17239
		[UIHint(UIHint.Variable)]
		public FsmBool storeButtonState;

		// Token: 0x04004358 RID: 17240
		public FsmTexture image;

		// Token: 0x04004359 RID: 17241
		public FsmString text;

		// Token: 0x0400435A RID: 17242
		public FsmString tooltip;

		// Token: 0x0400435B RID: 17243
		public FsmString style;
	}
}
