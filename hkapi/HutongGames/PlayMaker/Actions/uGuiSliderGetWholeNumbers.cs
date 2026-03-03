using System;
using UnityEngine;
using UnityEngine.UI;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000AB2 RID: 2738
	[ActionCategory("uGui")]
	[Tooltip("Gets the wholeNumbers property of a UGui Slider component. If true, the slider is constrained to integer values")]
	public class uGuiSliderGetWholeNumbers : FsmStateAction
	{
		// Token: 0x06003AEF RID: 15087 RVA: 0x001552B2 File Offset: 0x001534B2
		public override void Reset()
		{
			this.gameObject = null;
			this.isShowingWholeNumbersEvent = null;
			this.isNotShowingWholeNumbersEvent = null;
			this.wholeNumbers = null;
		}

		// Token: 0x06003AF0 RID: 15088 RVA: 0x001552D0 File Offset: 0x001534D0
		public override void OnEnter()
		{
			GameObject ownerDefaultTarget = base.Fsm.GetOwnerDefaultTarget(this.gameObject);
			if (ownerDefaultTarget != null)
			{
				this._slider = ownerDefaultTarget.GetComponent<Slider>();
			}
			this.DoGetValue();
			base.Finish();
		}

		// Token: 0x06003AF1 RID: 15089 RVA: 0x00155310 File Offset: 0x00153510
		private void DoGetValue()
		{
			bool flag = false;
			if (this._slider != null)
			{
				flag = this._slider.wholeNumbers;
			}
			this.wholeNumbers.Value = flag;
			if (flag)
			{
				base.Fsm.Event(this.isShowingWholeNumbersEvent);
				return;
			}
			base.Fsm.Event(this.isNotShowingWholeNumbersEvent);
		}

		// Token: 0x04003E3A RID: 15930
		[RequiredField]
		[CheckForComponent(typeof(Slider))]
		[Tooltip("The GameObject with the slider UGui component.")]
		public FsmOwnerDefault gameObject;

		// Token: 0x04003E3B RID: 15931
		[UIHint(UIHint.Variable)]
		[Tooltip("Is the slider constrained to integer values?")]
		public FsmBool wholeNumbers;

		// Token: 0x04003E3C RID: 15932
		[Tooltip("Event sent if slider is showing integers")]
		public FsmEvent isShowingWholeNumbersEvent;

		// Token: 0x04003E3D RID: 15933
		[Tooltip("Event sent if slider is showing floats")]
		public FsmEvent isNotShowingWholeNumbersEvent;

		// Token: 0x04003E3E RID: 15934
		private Slider _slider;
	}
}
