using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000C9C RID: 3228
	[ActionCategory(ActionCategory.Color)]
	[Tooltip("Sets the RGBA channels of a Color Variable. To leave any channel unchanged, set variable to 'None'.")]
	public class SetColorRGBA : FsmStateAction
	{
		// Token: 0x0600435C RID: 17244 RVA: 0x00172DA4 File Offset: 0x00170FA4
		public override void Reset()
		{
			this.colorVariable = null;
			this.red = 0f;
			this.green = 0f;
			this.blue = 0f;
			this.alpha = 1f;
			this.everyFrame = false;
		}

		// Token: 0x0600435D RID: 17245 RVA: 0x00172DFF File Offset: 0x00170FFF
		public override void OnEnter()
		{
			this.DoSetColorRGBA();
			if (!this.everyFrame)
			{
				base.Finish();
			}
		}

		// Token: 0x0600435E RID: 17246 RVA: 0x00172E15 File Offset: 0x00171015
		public override void OnUpdate()
		{
			this.DoSetColorRGBA();
		}

		// Token: 0x0600435F RID: 17247 RVA: 0x00172E20 File Offset: 0x00171020
		private void DoSetColorRGBA()
		{
			if (this.colorVariable == null)
			{
				return;
			}
			Color value = this.colorVariable.Value;
			if (!this.red.IsNone)
			{
				value.r = this.red.Value;
			}
			if (!this.green.IsNone)
			{
				value.g = this.green.Value;
			}
			if (!this.blue.IsNone)
			{
				value.b = this.blue.Value;
			}
			if (!this.alpha.IsNone)
			{
				value.a = this.alpha.Value;
			}
			this.colorVariable.Value = value;
		}

		// Token: 0x040047A0 RID: 18336
		[RequiredField]
		[UIHint(UIHint.Variable)]
		public FsmColor colorVariable;

		// Token: 0x040047A1 RID: 18337
		[HasFloatSlider(0f, 1f)]
		public FsmFloat red;

		// Token: 0x040047A2 RID: 18338
		[HasFloatSlider(0f, 1f)]
		public FsmFloat green;

		// Token: 0x040047A3 RID: 18339
		[HasFloatSlider(0f, 1f)]
		public FsmFloat blue;

		// Token: 0x040047A4 RID: 18340
		[HasFloatSlider(0f, 1f)]
		public FsmFloat alpha;

		// Token: 0x040047A5 RID: 18341
		public bool everyFrame;
	}
}
