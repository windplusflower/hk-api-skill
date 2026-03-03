using System;
using UnityEngine;
using UnityEngine.UI;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000A8C RID: 2700
	[ActionCategory("uGui")]
	[Tooltip("Sets the transition type of a Selectable Ugui component.")]
	public class uGuiTransitionSetType : FsmStateAction
	{
		// Token: 0x06003A2B RID: 14891 RVA: 0x001534D6 File Offset: 0x001516D6
		public override void Reset()
		{
			this.gameObject = null;
			this.transition = Selectable.Transition.ColorTint;
			this.resetOnExit = false;
		}

		// Token: 0x06003A2C RID: 14892 RVA: 0x001534F4 File Offset: 0x001516F4
		public override void OnEnter()
		{
			GameObject ownerDefaultTarget = base.Fsm.GetOwnerDefaultTarget(this.gameObject);
			if (ownerDefaultTarget != null)
			{
				this._selectable = ownerDefaultTarget.GetComponent<Selectable>();
			}
			if (this._selectable != null && this.resetOnExit.Value)
			{
				this._originalTransition = this._selectable.transition;
			}
			this.DoSetValue();
			base.Finish();
		}

		// Token: 0x06003A2D RID: 14893 RVA: 0x00153560 File Offset: 0x00151760
		private void DoSetValue()
		{
			if (this._selectable != null)
			{
				this._selectable.transition = this.transition;
			}
		}

		// Token: 0x06003A2E RID: 14894 RVA: 0x00153581 File Offset: 0x00151781
		public override void OnExit()
		{
			if (this._selectable == null)
			{
				return;
			}
			if (this.resetOnExit.Value)
			{
				this._selectable.transition = this._originalTransition;
			}
		}

		// Token: 0x04003D86 RID: 15750
		[RequiredField]
		[CheckForComponent(typeof(Selectable))]
		[Tooltip("The GameObject with the Selectable ui component.")]
		public FsmOwnerDefault gameObject;

		// Token: 0x04003D87 RID: 15751
		[Tooltip("The transition value")]
		public Selectable.Transition transition;

		// Token: 0x04003D88 RID: 15752
		[Tooltip("Reset when exiting this state.")]
		public FsmBool resetOnExit;

		// Token: 0x04003D89 RID: 15753
		private Selectable _selectable;

		// Token: 0x04003D8A RID: 15754
		private Selectable.Transition _originalTransition;
	}
}
