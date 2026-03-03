using System;
using UnityEngine;
using UnityEngine.UI;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000AB1 RID: 2737
	[ActionCategory("uGui")]
	[Tooltip("Gets the value of a UGui Slider component.")]
	public class uGuiSliderGetValue : FsmStateAction
	{
		// Token: 0x06003AEA RID: 15082 RVA: 0x00155222 File Offset: 0x00153422
		public override void Reset()
		{
			this.gameObject = null;
			this.value = null;
			this.everyFrame = false;
		}

		// Token: 0x06003AEB RID: 15083 RVA: 0x0015523C File Offset: 0x0015343C
		public override void OnEnter()
		{
			GameObject ownerDefaultTarget = base.Fsm.GetOwnerDefaultTarget(this.gameObject);
			if (ownerDefaultTarget != null)
			{
				this._slider = ownerDefaultTarget.GetComponent<Slider>();
			}
			this.DoGetValue();
			if (!this.everyFrame)
			{
				base.Finish();
			}
		}

		// Token: 0x06003AEC RID: 15084 RVA: 0x00155284 File Offset: 0x00153484
		public override void OnUpdate()
		{
			this.DoGetValue();
		}

		// Token: 0x06003AED RID: 15085 RVA: 0x0015528C File Offset: 0x0015348C
		private void DoGetValue()
		{
			if (this._slider != null)
			{
				this.value.Value = this._slider.value;
			}
		}

		// Token: 0x04003E36 RID: 15926
		[RequiredField]
		[CheckForComponent(typeof(Slider))]
		[Tooltip("The GameObject with the slider UGui component.")]
		public FsmOwnerDefault gameObject;

		// Token: 0x04003E37 RID: 15927
		[RequiredField]
		[UIHint(UIHint.Variable)]
		[Tooltip("The value of the UGui slider component.")]
		public FsmFloat value;

		// Token: 0x04003E38 RID: 15928
		[Tooltip("Repeats every frame")]
		public bool everyFrame;

		// Token: 0x04003E39 RID: 15929
		private Slider _slider;
	}
}
