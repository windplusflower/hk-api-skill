using System;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000BD5 RID: 3029
	[ActionCategory(ActionCategory.Color)]
	[Tooltip("Get the RGBA channels of a Color Variable and store them in Float Variables.")]
	public class GetColorRGBA : FsmStateAction
	{
		// Token: 0x06003FCD RID: 16333 RVA: 0x00168690 File Offset: 0x00166890
		public override void Reset()
		{
			this.color = null;
			this.storeRed = null;
			this.storeGreen = null;
			this.storeBlue = null;
			this.storeAlpha = null;
			this.everyFrame = false;
		}

		// Token: 0x06003FCE RID: 16334 RVA: 0x001686BC File Offset: 0x001668BC
		public override void OnEnter()
		{
			this.DoGetColorRGBA();
			if (!this.everyFrame)
			{
				base.Finish();
			}
		}

		// Token: 0x06003FCF RID: 16335 RVA: 0x001686D2 File Offset: 0x001668D2
		public override void OnUpdate()
		{
			this.DoGetColorRGBA();
		}

		// Token: 0x06003FD0 RID: 16336 RVA: 0x001686DC File Offset: 0x001668DC
		private void DoGetColorRGBA()
		{
			if (this.color.IsNone)
			{
				return;
			}
			this.storeRed.Value = this.color.Value.r;
			this.storeGreen.Value = this.color.Value.g;
			this.storeBlue.Value = this.color.Value.b;
			this.storeAlpha.Value = this.color.Value.a;
		}

		// Token: 0x040043FC RID: 17404
		[RequiredField]
		[UIHint(UIHint.Variable)]
		[Tooltip("The Color variable.")]
		public FsmColor color;

		// Token: 0x040043FD RID: 17405
		[UIHint(UIHint.Variable)]
		[Tooltip("Store the red channel in a float variable.")]
		public FsmFloat storeRed;

		// Token: 0x040043FE RID: 17406
		[UIHint(UIHint.Variable)]
		[Tooltip("Store the green channel in a float variable.")]
		public FsmFloat storeGreen;

		// Token: 0x040043FF RID: 17407
		[UIHint(UIHint.Variable)]
		[Tooltip("Store the blue channel in a float variable.")]
		public FsmFloat storeBlue;

		// Token: 0x04004400 RID: 17408
		[UIHint(UIHint.Variable)]
		[Tooltip("Store the alpha channel in a float variable.")]
		public FsmFloat storeAlpha;

		// Token: 0x04004401 RID: 17409
		[Tooltip("Repeat every frame. Useful if the color variable is changing.")]
		public bool everyFrame;
	}
}
