using System;
using UnityEngine;
using UnityEngine.UI;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000AAB RID: 2731
	[ActionCategory("uGui")]
	[Tooltip("Sets the number of distinct scroll positions allowed of a uGui Scrollbar component.")]
	public class uGuiScrollbarSetNumberOfSteps : FsmStateAction
	{
		// Token: 0x06003AC7 RID: 15047 RVA: 0x00154C8A File Offset: 0x00152E8A
		public override void Reset()
		{
			this.gameObject = null;
			this.value = null;
			this.resetOnExit = null;
			this.everyFrame = false;
		}

		// Token: 0x06003AC8 RID: 15048 RVA: 0x00154CA8 File Offset: 0x00152EA8
		public override void OnEnter()
		{
			GameObject ownerDefaultTarget = base.Fsm.GetOwnerDefaultTarget(this.gameObject);
			if (ownerDefaultTarget != null)
			{
				this._scrollbar = ownerDefaultTarget.GetComponent<Scrollbar>();
			}
			if (this.resetOnExit.Value)
			{
				this._originalValue = this._scrollbar.numberOfSteps;
			}
			this.DoSetValue();
			if (!this.everyFrame)
			{
				base.Finish();
			}
		}

		// Token: 0x06003AC9 RID: 15049 RVA: 0x00154D0E File Offset: 0x00152F0E
		public override void OnUpdate()
		{
			this.DoSetValue();
		}

		// Token: 0x06003ACA RID: 15050 RVA: 0x00154D16 File Offset: 0x00152F16
		private void DoSetValue()
		{
			if (this._scrollbar != null)
			{
				this._scrollbar.numberOfSteps = this.value.Value;
			}
		}

		// Token: 0x06003ACB RID: 15051 RVA: 0x00154D3C File Offset: 0x00152F3C
		public override void OnExit()
		{
			if (this._scrollbar == null)
			{
				return;
			}
			if (this.resetOnExit.Value)
			{
				this._scrollbar.numberOfSteps = this._originalValue;
			}
		}

		// Token: 0x04003E15 RID: 15893
		[RequiredField]
		[CheckForComponent(typeof(Scrollbar))]
		[Tooltip("The GameObject with the Scrollbar UGui component.")]
		public FsmOwnerDefault gameObject;

		// Token: 0x04003E16 RID: 15894
		[RequiredField]
		[Tooltip("The number of distinct scroll positions allowed of the uGui Scrollbar component.")]
		public FsmInt value;

		// Token: 0x04003E17 RID: 15895
		[Tooltip("Reset when exiting this state.")]
		public FsmBool resetOnExit;

		// Token: 0x04003E18 RID: 15896
		[Tooltip("Repeats every frame")]
		public bool everyFrame;

		// Token: 0x04003E19 RID: 15897
		private Scrollbar _scrollbar;

		// Token: 0x04003E1A RID: 15898
		private int _originalValue;
	}
}
