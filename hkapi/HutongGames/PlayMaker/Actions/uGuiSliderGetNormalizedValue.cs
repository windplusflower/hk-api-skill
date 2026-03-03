using System;
using UnityEngine;
using UnityEngine.UI;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000AB0 RID: 2736
	[ActionCategory("uGui")]
	[Tooltip("Gets the normalized value ( between 0 and 1) of a UGui Slider component.")]
	public class uGuiSliderGetNormalizedValue : FsmStateAction
	{
		// Token: 0x06003AE5 RID: 15077 RVA: 0x00155195 File Offset: 0x00153395
		public override void Reset()
		{
			this.gameObject = null;
			this.value = null;
			this.everyFrame = false;
		}

		// Token: 0x06003AE6 RID: 15078 RVA: 0x001551AC File Offset: 0x001533AC
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

		// Token: 0x06003AE7 RID: 15079 RVA: 0x001551F4 File Offset: 0x001533F4
		public override void OnUpdate()
		{
			this.DoGetValue();
		}

		// Token: 0x06003AE8 RID: 15080 RVA: 0x001551FC File Offset: 0x001533FC
		private void DoGetValue()
		{
			if (this._slider != null)
			{
				this.value.Value = this._slider.normalizedValue;
			}
		}

		// Token: 0x04003E32 RID: 15922
		[RequiredField]
		[CheckForComponent(typeof(Slider))]
		[Tooltip("The GameObject with the slider UGui component.")]
		public FsmOwnerDefault gameObject;

		// Token: 0x04003E33 RID: 15923
		[RequiredField]
		[UIHint(UIHint.Variable)]
		[Tooltip("The normalized value of the UGui slider component.")]
		public FsmFloat value;

		// Token: 0x04003E34 RID: 15924
		[Tooltip("Repeats every frame")]
		public bool everyFrame;

		// Token: 0x04003E35 RID: 15925
		private Slider _slider;
	}
}
