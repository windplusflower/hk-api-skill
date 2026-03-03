using System;
using UnityEngine;
using UnityEngine.UI;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000AAA RID: 2730
	[ActionCategory("uGui")]
	[Tooltip("Sets the direction of a UGui Scrollbar component.")]
	public class uGuiScrollbarSetDirection : FsmStateAction
	{
		// Token: 0x06003AC2 RID: 15042 RVA: 0x00154BC3 File Offset: 0x00152DC3
		public override void Reset()
		{
			this.gameObject = null;
			this.direction = Scrollbar.Direction.LeftToRight;
			this.resetOnExit = null;
		}

		// Token: 0x06003AC3 RID: 15043 RVA: 0x00154BDC File Offset: 0x00152DDC
		public override void OnEnter()
		{
			GameObject ownerDefaultTarget = base.Fsm.GetOwnerDefaultTarget(this.gameObject);
			if (ownerDefaultTarget != null)
			{
				this._scrollbar = ownerDefaultTarget.GetComponent<Scrollbar>();
			}
			if (this.resetOnExit.Value)
			{
				this._originalValue = this._scrollbar.direction;
			}
			this.DoSetValue();
			base.Finish();
		}

		// Token: 0x06003AC4 RID: 15044 RVA: 0x00154C3A File Offset: 0x00152E3A
		private void DoSetValue()
		{
			if (this._scrollbar != null)
			{
				this._scrollbar.direction = this.direction;
			}
		}

		// Token: 0x06003AC5 RID: 15045 RVA: 0x00154C5B File Offset: 0x00152E5B
		public override void OnExit()
		{
			if (this._scrollbar == null)
			{
				return;
			}
			if (this.resetOnExit.Value)
			{
				this._scrollbar.direction = this._originalValue;
			}
		}

		// Token: 0x04003E10 RID: 15888
		[RequiredField]
		[CheckForComponent(typeof(Scrollbar))]
		[Tooltip("The GameObject with the Scrollbar UGui component.")]
		public FsmOwnerDefault gameObject;

		// Token: 0x04003E11 RID: 15889
		[RequiredField]
		[Tooltip("The direction of the UGui Scrollbar component.")]
		public Scrollbar.Direction direction;

		// Token: 0x04003E12 RID: 15890
		[Tooltip("Reset when exiting this state.")]
		public FsmBool resetOnExit;

		// Token: 0x04003E13 RID: 15891
		private Scrollbar _scrollbar;

		// Token: 0x04003E14 RID: 15892
		private Scrollbar.Direction _originalValue;
	}
}
