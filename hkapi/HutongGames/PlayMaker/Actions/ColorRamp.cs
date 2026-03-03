using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000B46 RID: 2886
	[ActionCategory(ActionCategory.Color)]
	[Tooltip("Samples a Color on a continuous Colors gradient.")]
	public class ColorRamp : FsmStateAction
	{
		// Token: 0x06003DAC RID: 15788 RVA: 0x001623B3 File Offset: 0x001605B3
		public override void Reset()
		{
			this.colors = new FsmColor[3];
			this.sampleAt = 0f;
			this.storeColor = null;
			this.everyFrame = false;
		}

		// Token: 0x06003DAD RID: 15789 RVA: 0x001623DF File Offset: 0x001605DF
		public override void OnEnter()
		{
			this.DoColorRamp();
			if (!this.everyFrame)
			{
				base.Finish();
			}
		}

		// Token: 0x06003DAE RID: 15790 RVA: 0x001623F5 File Offset: 0x001605F5
		public override void OnUpdate()
		{
			this.DoColorRamp();
		}

		// Token: 0x06003DAF RID: 15791 RVA: 0x00162400 File Offset: 0x00160600
		private void DoColorRamp()
		{
			if (this.colors == null)
			{
				return;
			}
			if (this.colors.Length == 0)
			{
				return;
			}
			if (this.sampleAt == null)
			{
				return;
			}
			if (this.storeColor == null)
			{
				return;
			}
			float num = Mathf.Clamp(this.sampleAt.Value, 0f, (float)(this.colors.Length - 1));
			Color value;
			if (num == 0f)
			{
				value = this.colors[0].Value;
			}
			else if (num == (float)this.colors.Length)
			{
				value = this.colors[this.colors.Length - 1].Value;
			}
			else
			{
				Color value2 = this.colors[Mathf.FloorToInt(num)].Value;
				Color value3 = this.colors[Mathf.CeilToInt(num)].Value;
				num -= Mathf.Floor(num);
				value = Color.Lerp(value2, value3, num);
			}
			this.storeColor.Value = value;
		}

		// Token: 0x06003DB0 RID: 15792 RVA: 0x001624D2 File Offset: 0x001606D2
		public override string ErrorCheck()
		{
			if (this.colors.Length < 2)
			{
				return "Define at least 2 colors to make a gradient.";
			}
			return null;
		}

		// Token: 0x040041C8 RID: 16840
		[RequiredField]
		[Tooltip("Array of colors to defining the gradient.")]
		public FsmColor[] colors;

		// Token: 0x040041C9 RID: 16841
		[RequiredField]
		[Tooltip("Point on the gradient to sample. Should be between 0 and the number of colors in the gradient.")]
		public FsmFloat sampleAt;

		// Token: 0x040041CA RID: 16842
		[RequiredField]
		[UIHint(UIHint.Variable)]
		[Tooltip("Store the sampled color in a Color variable.")]
		public FsmColor storeColor;

		// Token: 0x040041CB RID: 16843
		[Tooltip("Repeat every frame while the state is active.")]
		public bool everyFrame;
	}
}
