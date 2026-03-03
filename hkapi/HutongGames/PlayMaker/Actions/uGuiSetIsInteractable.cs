using System;
using UnityEngine;
using UnityEngine.UI;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000A8A RID: 2698
	[ActionCategory("uGui")]
	[Tooltip("Sets the interactable flag of a Selectable Ugui component.")]
	public class uGuiSetIsInteractable : FsmStateAction
	{
		// Token: 0x06003A22 RID: 14882 RVA: 0x001532CB File Offset: 0x001514CB
		public override void Reset()
		{
			this.gameObject = null;
			this.isInteractable = null;
			this.resetOnExit = false;
		}

		// Token: 0x06003A23 RID: 14883 RVA: 0x001532E8 File Offset: 0x001514E8
		public override void OnEnter()
		{
			GameObject ownerDefaultTarget = base.Fsm.GetOwnerDefaultTarget(this.gameObject);
			if (ownerDefaultTarget != null)
			{
				this._selectable = ownerDefaultTarget.GetComponent<Selectable>();
			}
			if (this._selectable != null && this.resetOnExit.Value)
			{
				this._originalState = this._selectable.IsInteractable();
			}
			this.DoSetValue();
			base.Finish();
		}

		// Token: 0x06003A24 RID: 14884 RVA: 0x00153354 File Offset: 0x00151554
		private void DoSetValue()
		{
			if (this._selectable != null)
			{
				this._selectable.interactable = this.isInteractable.Value;
			}
		}

		// Token: 0x06003A25 RID: 14885 RVA: 0x0015337A File Offset: 0x0015157A
		public override void OnExit()
		{
			if (this._selectable == null)
			{
				return;
			}
			if (this.resetOnExit.Value)
			{
				this._selectable.interactable = this._originalState;
			}
		}

		// Token: 0x04003D79 RID: 15737
		[RequiredField]
		[CheckForComponent(typeof(Selectable))]
		[Tooltip("The GameObject with the Selectable ui component.")]
		public FsmOwnerDefault gameObject;

		// Token: 0x04003D7A RID: 15738
		[Tooltip("The Interactable value")]
		public FsmBool isInteractable;

		// Token: 0x04003D7B RID: 15739
		[Tooltip("Reset when exiting this state.")]
		public FsmBool resetOnExit;

		// Token: 0x04003D7C RID: 15740
		private Selectable _selectable;

		// Token: 0x04003D7D RID: 15741
		private bool _originalState;
	}
}
