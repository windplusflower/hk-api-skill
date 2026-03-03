using System;
using UnityEngine;
using UnityEngine.UI;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000AAC RID: 2732
	[ActionCategory("uGui")]
	[Tooltip("Sets the fractional size of the handle of a UGui Scrollbar component. Ranges from 0.0 to 1.0.")]
	public class uGuiScrollbarSetSize : FsmStateAction
	{
		// Token: 0x06003ACD RID: 15053 RVA: 0x00154D6B File Offset: 0x00152F6B
		public override void Reset()
		{
			this.gameObject = null;
			this.value = null;
			this.resetOnExit = null;
			this.everyFrame = false;
		}

		// Token: 0x06003ACE RID: 15054 RVA: 0x00154D8C File Offset: 0x00152F8C
		public override void OnEnter()
		{
			GameObject ownerDefaultTarget = base.Fsm.GetOwnerDefaultTarget(this.gameObject);
			if (ownerDefaultTarget != null)
			{
				this._scrollbar = ownerDefaultTarget.GetComponent<Scrollbar>();
			}
			if (this.resetOnExit.Value)
			{
				this._originalValue = this._scrollbar.size;
			}
			this.DoSetValue();
			if (!this.everyFrame)
			{
				base.Finish();
			}
		}

		// Token: 0x06003ACF RID: 15055 RVA: 0x00154DF2 File Offset: 0x00152FF2
		public override void OnUpdate()
		{
			this.DoSetValue();
		}

		// Token: 0x06003AD0 RID: 15056 RVA: 0x00154DFA File Offset: 0x00152FFA
		private void DoSetValue()
		{
			if (this._scrollbar != null)
			{
				this._scrollbar.size = this.value.Value;
			}
		}

		// Token: 0x06003AD1 RID: 15057 RVA: 0x00154E20 File Offset: 0x00153020
		public override void OnExit()
		{
			if (this._scrollbar == null)
			{
				return;
			}
			if (this.resetOnExit.Value)
			{
				this._scrollbar.size = this._originalValue;
			}
		}

		// Token: 0x04003E1B RID: 15899
		[RequiredField]
		[CheckForComponent(typeof(Scrollbar))]
		[Tooltip("The GameObject with the Scrollbar UGui component.")]
		public FsmOwnerDefault gameObject;

		// Token: 0x04003E1C RID: 15900
		[RequiredField]
		[Tooltip("The fractional size of the handle UGui Scrollbar component. Ranges from 0.0 to 1.0.")]
		[HasFloatSlider(0f, 1f)]
		public FsmFloat value;

		// Token: 0x04003E1D RID: 15901
		[Tooltip("Reset when exiting this state.")]
		public FsmBool resetOnExit;

		// Token: 0x04003E1E RID: 15902
		[Tooltip("Repeats every frame")]
		public bool everyFrame;

		// Token: 0x04003E1F RID: 15903
		private Scrollbar _scrollbar;

		// Token: 0x04003E20 RID: 15904
		private float _originalValue;
	}
}
