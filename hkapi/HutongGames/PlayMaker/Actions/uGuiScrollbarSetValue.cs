using System;
using UnityEngine;
using UnityEngine.UI;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000AAD RID: 2733
	[ActionCategory("uGui")]
	[Tooltip("Sets the position's value of a UGui Scrollbar component. Ranges from 0.0 to 1.0.")]
	public class uGuiScrollbarSetValue : FsmStateAction
	{
		// Token: 0x06003AD3 RID: 15059 RVA: 0x00154E4F File Offset: 0x0015304F
		public override void Reset()
		{
			this.gameObject = null;
			this.value = null;
			this.resetOnExit = null;
			this.everyFrame = false;
		}

		// Token: 0x06003AD4 RID: 15060 RVA: 0x00154E70 File Offset: 0x00153070
		public override void OnEnter()
		{
			GameObject ownerDefaultTarget = base.Fsm.GetOwnerDefaultTarget(this.gameObject);
			if (ownerDefaultTarget != null)
			{
				this._scrollbar = ownerDefaultTarget.GetComponent<Scrollbar>();
			}
			if (this.resetOnExit.Value)
			{
				this._originalValue = this._scrollbar.value;
			}
			this.DoSetValue();
			if (!this.everyFrame)
			{
				base.Finish();
			}
		}

		// Token: 0x06003AD5 RID: 15061 RVA: 0x00154ED6 File Offset: 0x001530D6
		public override void OnUpdate()
		{
			this.DoSetValue();
		}

		// Token: 0x06003AD6 RID: 15062 RVA: 0x00154EDE File Offset: 0x001530DE
		private void DoSetValue()
		{
			if (this._scrollbar != null)
			{
				this._scrollbar.value = this.value.Value;
			}
		}

		// Token: 0x06003AD7 RID: 15063 RVA: 0x00154F04 File Offset: 0x00153104
		public override void OnExit()
		{
			if (this._scrollbar == null)
			{
				return;
			}
			if (this.resetOnExit.Value)
			{
				this._scrollbar.value = this._originalValue;
			}
		}

		// Token: 0x04003E21 RID: 15905
		[RequiredField]
		[CheckForComponent(typeof(Scrollbar))]
		[Tooltip("The GameObject with the Scrollbar UGui component.")]
		public FsmOwnerDefault gameObject;

		// Token: 0x04003E22 RID: 15906
		[RequiredField]
		[Tooltip("The position's value of the UGui Scrollbar component. Ranges from 0.0 to 1.0.")]
		[HasFloatSlider(0f, 1f)]
		public FsmFloat value;

		// Token: 0x04003E23 RID: 15907
		[Tooltip("Reset when exiting this state.")]
		public FsmBool resetOnExit;

		// Token: 0x04003E24 RID: 15908
		[Tooltip("Repeats every frame")]
		public bool everyFrame;

		// Token: 0x04003E25 RID: 15909
		private Scrollbar _scrollbar;

		// Token: 0x04003E26 RID: 15910
		private float _originalValue;
	}
}
