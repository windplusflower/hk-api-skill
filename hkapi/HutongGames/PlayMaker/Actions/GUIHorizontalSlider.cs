using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000B9F RID: 2975
	[ActionCategory(ActionCategory.GUI)]
	[Tooltip("GUI Horizontal Slider connected to a Float Variable.")]
	public class GUIHorizontalSlider : GUIAction
	{
		// Token: 0x06003F12 RID: 16146 RVA: 0x00165FB4 File Offset: 0x001641B4
		public override void Reset()
		{
			base.Reset();
			this.floatVariable = null;
			this.leftValue = 0f;
			this.rightValue = 100f;
			this.sliderStyle = "horizontalslider";
			this.thumbStyle = "horizontalsliderthumb";
		}

		// Token: 0x06003F13 RID: 16147 RVA: 0x00166010 File Offset: 0x00164210
		public override void OnGUI()
		{
			base.OnGUI();
			if (this.floatVariable != null)
			{
				this.floatVariable.Value = GUI.HorizontalSlider(this.rect, this.floatVariable.Value, this.leftValue.Value, this.rightValue.Value, (this.sliderStyle.Value != "") ? this.sliderStyle.Value : "horizontalslider", (this.thumbStyle.Value != "") ? this.thumbStyle.Value : "horizontalsliderthumb");
			}
		}

		// Token: 0x0400432D RID: 17197
		[RequiredField]
		[UIHint(UIHint.Variable)]
		public FsmFloat floatVariable;

		// Token: 0x0400432E RID: 17198
		[RequiredField]
		public FsmFloat leftValue;

		// Token: 0x0400432F RID: 17199
		[RequiredField]
		public FsmFloat rightValue;

		// Token: 0x04004330 RID: 17200
		public FsmString sliderStyle;

		// Token: 0x04004331 RID: 17201
		public FsmString thumbStyle;
	}
}
