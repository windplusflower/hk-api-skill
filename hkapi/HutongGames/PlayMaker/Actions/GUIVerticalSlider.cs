using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000BC1 RID: 3009
	[ActionCategory(ActionCategory.GUI)]
	[Tooltip("GUI Vertical Slider connected to a Float Variable.")]
	public class GUIVerticalSlider : GUIAction
	{
		// Token: 0x06003F7B RID: 16251 RVA: 0x00167788 File Offset: 0x00165988
		public override void Reset()
		{
			base.Reset();
			this.floatVariable = null;
			this.topValue = 100f;
			this.bottomValue = 0f;
			this.sliderStyle = "verticalslider";
			this.thumbStyle = "verticalsliderthumb";
			this.width = 0.1f;
		}

		// Token: 0x06003F7C RID: 16252 RVA: 0x001677F4 File Offset: 0x001659F4
		public override void OnGUI()
		{
			base.OnGUI();
			if (this.floatVariable != null)
			{
				this.floatVariable.Value = GUI.VerticalSlider(this.rect, this.floatVariable.Value, this.topValue.Value, this.bottomValue.Value, (this.sliderStyle.Value != "") ? this.sliderStyle.Value : "verticalslider", (this.thumbStyle.Value != "") ? this.thumbStyle.Value : "verticalsliderthumb");
			}
		}

		// Token: 0x040043A2 RID: 17314
		[RequiredField]
		[UIHint(UIHint.Variable)]
		public FsmFloat floatVariable;

		// Token: 0x040043A3 RID: 17315
		[RequiredField]
		public FsmFloat topValue;

		// Token: 0x040043A4 RID: 17316
		[RequiredField]
		public FsmFloat bottomValue;

		// Token: 0x040043A5 RID: 17317
		public FsmString sliderStyle;

		// Token: 0x040043A6 RID: 17318
		public FsmString thumbStyle;
	}
}
