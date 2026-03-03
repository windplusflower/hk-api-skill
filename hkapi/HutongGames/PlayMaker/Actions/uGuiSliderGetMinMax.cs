using System;
using UnityEngine;
using UnityEngine.UI;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000AAF RID: 2735
	[ActionCategory("uGui")]
	[Tooltip("Gets the minimum and maximum limits for the value of a UGui Slider component.")]
	public class uGuiSliderGetMinMax : FsmStateAction
	{
		// Token: 0x06003AE1 RID: 15073 RVA: 0x001550E1 File Offset: 0x001532E1
		public override void Reset()
		{
			this.gameObject = null;
			this.minValue = null;
			this.maxValue = null;
		}

		// Token: 0x06003AE2 RID: 15074 RVA: 0x001550F8 File Offset: 0x001532F8
		public override void OnEnter()
		{
			GameObject ownerDefaultTarget = base.Fsm.GetOwnerDefaultTarget(this.gameObject);
			if (ownerDefaultTarget != null)
			{
				this._slider = ownerDefaultTarget.GetComponent<Slider>();
			}
			this.DoGetValue();
		}

		// Token: 0x06003AE3 RID: 15075 RVA: 0x00155134 File Offset: 0x00153334
		private void DoGetValue()
		{
			if (this._slider != null)
			{
				if (!this.minValue.IsNone)
				{
					this.minValue.Value = this._slider.minValue;
				}
				if (!this.maxValue.IsNone)
				{
					this.maxValue.Value = this._slider.maxValue;
				}
			}
		}

		// Token: 0x04003E2E RID: 15918
		[RequiredField]
		[CheckForComponent(typeof(Slider))]
		[Tooltip("The GameObject with the slider UGui component.")]
		public FsmOwnerDefault gameObject;

		// Token: 0x04003E2F RID: 15919
		[UIHint(UIHint.Variable)]
		[Tooltip("The minimum value of the UGui slider component. Leave to none for no effect")]
		public FsmFloat minValue;

		// Token: 0x04003E30 RID: 15920
		[UIHint(UIHint.Variable)]
		[Tooltip("The maximum value of the UGui slider component. Leave to none for no effect")]
		public FsmFloat maxValue;

		// Token: 0x04003E31 RID: 15921
		private Slider _slider;
	}
}
