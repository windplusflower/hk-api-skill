using System;
using UnityEngine;
using UnityEngine.UI;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000AB8 RID: 2744
	[ActionCategory("uGui")]
	[Tooltip("Sets the wholeNumbers property of a UGui Slider component. This defines if the slider will be constrained to integer values ")]
	public class uGuiSliderSetWholeNumbers : FsmStateAction
	{
		// Token: 0x06003B0F RID: 15119 RVA: 0x0015582B File Offset: 0x00153A2B
		public override void Reset()
		{
			this.gameObject = null;
			this.wholeNumbers = null;
			this.resetOnExit = null;
		}

		// Token: 0x06003B10 RID: 15120 RVA: 0x00155844 File Offset: 0x00153A44
		public override void OnEnter()
		{
			GameObject ownerDefaultTarget = base.Fsm.GetOwnerDefaultTarget(this.gameObject);
			if (ownerDefaultTarget != null)
			{
				this._slider = ownerDefaultTarget.GetComponent<Slider>();
			}
			if (this.resetOnExit.Value)
			{
				this._originalValue = this._slider.wholeNumbers;
			}
			this.DoSetValue();
			base.Finish();
		}

		// Token: 0x06003B11 RID: 15121 RVA: 0x001558A2 File Offset: 0x00153AA2
		private void DoSetValue()
		{
			if (this._slider != null)
			{
				this._slider.wholeNumbers = this.wholeNumbers.Value;
			}
		}

		// Token: 0x06003B12 RID: 15122 RVA: 0x001558C8 File Offset: 0x00153AC8
		public override void OnExit()
		{
			if (this._slider == null)
			{
				return;
			}
			if (this.resetOnExit.Value)
			{
				this._slider.wholeNumbers = this._originalValue;
			}
		}

		// Token: 0x04003E5B RID: 15963
		[RequiredField]
		[CheckForComponent(typeof(Slider))]
		[Tooltip("The GameObject with the slider UGui component.")]
		public FsmOwnerDefault gameObject;

		// Token: 0x04003E5C RID: 15964
		[RequiredField]
		[Tooltip("Should the slider be constrained to integer values?")]
		public FsmBool wholeNumbers;

		// Token: 0x04003E5D RID: 15965
		[Tooltip("Reset when exiting this state.")]
		public FsmBool resetOnExit;

		// Token: 0x04003E5E RID: 15966
		private Slider _slider;

		// Token: 0x04003E5F RID: 15967
		private bool _originalValue;
	}
}
