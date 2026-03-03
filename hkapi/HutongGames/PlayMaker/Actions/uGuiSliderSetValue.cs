using System;
using UnityEngine;
using UnityEngine.UI;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000AB7 RID: 2743
	[ActionCategory("uGui")]
	[Tooltip("Sets the value of a UGui Slider component.")]
	public class uGuiSliderSetValue : FsmStateAction
	{
		// Token: 0x06003B09 RID: 15113 RVA: 0x00155747 File Offset: 0x00153947
		public override void Reset()
		{
			this.gameObject = null;
			this.value = null;
			this.resetOnExit = null;
			this.everyFrame = false;
		}

		// Token: 0x06003B0A RID: 15114 RVA: 0x00155768 File Offset: 0x00153968
		public override void OnEnter()
		{
			GameObject ownerDefaultTarget = base.Fsm.GetOwnerDefaultTarget(this.gameObject);
			if (ownerDefaultTarget != null)
			{
				this._slider = ownerDefaultTarget.GetComponent<Slider>();
			}
			if (this.resetOnExit.Value)
			{
				this._originalValue = this._slider.value;
			}
			this.DoSetValue();
			if (!this.everyFrame)
			{
				base.Finish();
			}
		}

		// Token: 0x06003B0B RID: 15115 RVA: 0x001557CE File Offset: 0x001539CE
		public override void OnUpdate()
		{
			this.DoSetValue();
		}

		// Token: 0x06003B0C RID: 15116 RVA: 0x001557D6 File Offset: 0x001539D6
		private void DoSetValue()
		{
			if (this._slider != null)
			{
				this._slider.value = this.value.Value;
			}
		}

		// Token: 0x06003B0D RID: 15117 RVA: 0x001557FC File Offset: 0x001539FC
		public override void OnExit()
		{
			if (this._slider == null)
			{
				return;
			}
			if (this.resetOnExit.Value)
			{
				this._slider.value = this._originalValue;
			}
		}

		// Token: 0x04003E55 RID: 15957
		[RequiredField]
		[CheckForComponent(typeof(Slider))]
		[Tooltip("The GameObject with the slider UGui component.")]
		public FsmOwnerDefault gameObject;

		// Token: 0x04003E56 RID: 15958
		[RequiredField]
		[Tooltip("The value of the UGui slider component.")]
		public FsmFloat value;

		// Token: 0x04003E57 RID: 15959
		[Tooltip("Reset when exiting this state.")]
		public FsmBool resetOnExit;

		// Token: 0x04003E58 RID: 15960
		[Tooltip("Repeats every frame")]
		public bool everyFrame;

		// Token: 0x04003E59 RID: 15961
		private Slider _slider;

		// Token: 0x04003E5A RID: 15962
		private float _originalValue;
	}
}
