using System;
using UnityEngine;
using UnityEngine.UI;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000AB6 RID: 2742
	[ActionCategory("uGui")]
	[Tooltip("Sets the normalized value ( between 0 and 1) of a UGui Slider component.")]
	public class uGuiSliderSetNormalizedValue : FsmStateAction
	{
		// Token: 0x06003B03 RID: 15107 RVA: 0x00155665 File Offset: 0x00153865
		public override void Reset()
		{
			this.gameObject = null;
			this.value = null;
			this.resetOnExit = null;
			this.everyFrame = false;
		}

		// Token: 0x06003B04 RID: 15108 RVA: 0x00155684 File Offset: 0x00153884
		public override void OnEnter()
		{
			GameObject ownerDefaultTarget = base.Fsm.GetOwnerDefaultTarget(this.gameObject);
			if (ownerDefaultTarget != null)
			{
				this._slider = ownerDefaultTarget.GetComponent<Slider>();
			}
			if (this.resetOnExit.Value)
			{
				this._originalValue = this._slider.normalizedValue;
			}
			this.DoSetValue();
			if (!this.everyFrame)
			{
				base.Finish();
			}
		}

		// Token: 0x06003B05 RID: 15109 RVA: 0x001556EA File Offset: 0x001538EA
		public override void OnUpdate()
		{
			this.DoSetValue();
		}

		// Token: 0x06003B06 RID: 15110 RVA: 0x001556F2 File Offset: 0x001538F2
		private void DoSetValue()
		{
			if (this._slider != null)
			{
				this._slider.normalizedValue = this.value.Value;
			}
		}

		// Token: 0x06003B07 RID: 15111 RVA: 0x00155718 File Offset: 0x00153918
		public override void OnExit()
		{
			if (this._slider == null)
			{
				return;
			}
			if (this.resetOnExit.Value)
			{
				this._slider.normalizedValue = this._originalValue;
			}
		}

		// Token: 0x04003E4F RID: 15951
		[RequiredField]
		[CheckForComponent(typeof(Slider))]
		[Tooltip("The GameObject with the slider UGui component.")]
		public FsmOwnerDefault gameObject;

		// Token: 0x04003E50 RID: 15952
		[RequiredField]
		[HasFloatSlider(0f, 1f)]
		[Tooltip("The normalized value ( between 0 and 1) of the UGui slider component.")]
		public FsmFloat value;

		// Token: 0x04003E51 RID: 15953
		[Tooltip("Reset when exiting this state.")]
		public FsmBool resetOnExit;

		// Token: 0x04003E52 RID: 15954
		[Tooltip("Repeats every frame")]
		public bool everyFrame;

		// Token: 0x04003E53 RID: 15955
		private Slider _slider;

		// Token: 0x04003E54 RID: 15956
		private float _originalValue;
	}
}
