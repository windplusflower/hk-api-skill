using System;
using UnityEngine;
using UnityEngine.UI;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000AB4 RID: 2740
	[ActionCategory("uGui")]
	[Tooltip("Sets the direction of a UGui Slider component.")]
	public class uGuiSliderSetDirection : FsmStateAction
	{
		// Token: 0x06003AF8 RID: 15096 RVA: 0x00155447 File Offset: 0x00153647
		public override void Reset()
		{
			this.gameObject = null;
			this.direction = Slider.Direction.LeftToRight;
			this.resetOnExit = null;
		}

		// Token: 0x06003AF9 RID: 15097 RVA: 0x00155460 File Offset: 0x00153660
		public override void OnEnter()
		{
			GameObject ownerDefaultTarget = base.Fsm.GetOwnerDefaultTarget(this.gameObject);
			if (ownerDefaultTarget != null)
			{
				this._slider = ownerDefaultTarget.GetComponent<Slider>();
			}
			if (this.resetOnExit.Value)
			{
				this._originalValue = this._slider.direction;
			}
			this.DoSetValue();
		}

		// Token: 0x06003AFA RID: 15098 RVA: 0x001554B8 File Offset: 0x001536B8
		private void DoSetValue()
		{
			if (this._slider != null)
			{
				this._slider.direction = this.direction;
			}
		}

		// Token: 0x06003AFB RID: 15099 RVA: 0x001554D9 File Offset: 0x001536D9
		public override void OnExit()
		{
			if (this._slider == null)
			{
				return;
			}
			if (this.resetOnExit.Value)
			{
				this._slider.direction = this._originalValue;
			}
		}

		// Token: 0x04003E42 RID: 15938
		[RequiredField]
		[CheckForComponent(typeof(Slider))]
		[Tooltip("The GameObject with the slider UGui component.")]
		public FsmOwnerDefault gameObject;

		// Token: 0x04003E43 RID: 15939
		[RequiredField]
		[Tooltip("The direction of the UGui slider component.")]
		public Slider.Direction direction;

		// Token: 0x04003E44 RID: 15940
		[Tooltip("Reset when exiting this state.")]
		public FsmBool resetOnExit;

		// Token: 0x04003E45 RID: 15941
		private Slider _slider;

		// Token: 0x04003E46 RID: 15942
		private Slider.Direction _originalValue;
	}
}
