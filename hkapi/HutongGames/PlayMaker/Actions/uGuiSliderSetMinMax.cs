using System;
using UnityEngine;
using UnityEngine.UI;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000AB5 RID: 2741
	[ActionCategory("uGui")]
	[Tooltip("Sets the minimum and maximum limits for the value of a UGui Slider component. Optionally resets on exit")]
	public class uGuiSliderSetMinMax : FsmStateAction
	{
		// Token: 0x06003AFD RID: 15101 RVA: 0x00155508 File Offset: 0x00153708
		public override void Reset()
		{
			this.gameObject = null;
			this.minValue = new FsmFloat
			{
				UseVariable = true
			};
			this.maxValue = new FsmFloat
			{
				UseVariable = true
			};
			this.resetOnExit = null;
			this.everyFrame = false;
		}

		// Token: 0x06003AFE RID: 15102 RVA: 0x00155544 File Offset: 0x00153744
		public override void OnEnter()
		{
			GameObject ownerDefaultTarget = base.Fsm.GetOwnerDefaultTarget(this.gameObject);
			if (ownerDefaultTarget != null)
			{
				this._slider = ownerDefaultTarget.GetComponent<Slider>();
			}
			if (this.resetOnExit.Value)
			{
				this._originalMinValue = this._slider.minValue;
				this._originalMaxValue = this._slider.maxValue;
			}
			this.DoSetValue();
			if (!this.everyFrame)
			{
				base.Finish();
			}
		}

		// Token: 0x06003AFF RID: 15103 RVA: 0x001555BB File Offset: 0x001537BB
		public override void OnUpdate()
		{
			this.DoSetValue();
		}

		// Token: 0x06003B00 RID: 15104 RVA: 0x001555C4 File Offset: 0x001537C4
		private void DoSetValue()
		{
			if (this._slider != null)
			{
				if (!this.minValue.IsNone)
				{
					this._slider.minValue = this.minValue.Value;
				}
				if (!this.maxValue.IsNone)
				{
					this._slider.maxValue = this.maxValue.Value;
				}
			}
		}

		// Token: 0x06003B01 RID: 15105 RVA: 0x00155625 File Offset: 0x00153825
		public override void OnExit()
		{
			if (this._slider == null)
			{
				return;
			}
			if (this.resetOnExit.Value)
			{
				this._slider.minValue = this._originalMinValue;
				this._slider.maxValue = this._originalMaxValue;
			}
		}

		// Token: 0x04003E47 RID: 15943
		[RequiredField]
		[CheckForComponent(typeof(Slider))]
		[Tooltip("The GameObject with the slider UGui component.")]
		public FsmOwnerDefault gameObject;

		// Token: 0x04003E48 RID: 15944
		[Tooltip("The minimum value of the UGui slider component. Leave to none for no effect")]
		public FsmFloat minValue;

		// Token: 0x04003E49 RID: 15945
		[Tooltip("The maximum value of the UGui slider component. Leave to none for no effect")]
		public FsmFloat maxValue;

		// Token: 0x04003E4A RID: 15946
		[Tooltip("Reset when exiting this state.")]
		public FsmBool resetOnExit;

		// Token: 0x04003E4B RID: 15947
		[Tooltip("Repeats every frame")]
		public bool everyFrame;

		// Token: 0x04003E4C RID: 15948
		private Slider _slider;

		// Token: 0x04003E4D RID: 15949
		private float _originalMinValue;

		// Token: 0x04003E4E RID: 15950
		private float _originalMaxValue;
	}
}
