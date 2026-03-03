using System;
using UnityEngine;
using UnityEngine.UI;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000A85 RID: 2693
	[ActionCategory("uGui")]
	[Tooltip("Gets the interactable flag of a Selectable Ugui component.")]
	public class uGuiGetIsInteractable : FsmStateAction
	{
		// Token: 0x06003A0A RID: 14858 RVA: 0x00152B66 File Offset: 0x00150D66
		public override void Reset()
		{
			this.gameObject = null;
			this.isInteractable = null;
			this.isInteractableEvent = null;
			this.isNotInteractableEvent = null;
		}

		// Token: 0x06003A0B RID: 14859 RVA: 0x00152B84 File Offset: 0x00150D84
		public override void OnEnter()
		{
			GameObject ownerDefaultTarget = base.Fsm.GetOwnerDefaultTarget(this.gameObject);
			if (ownerDefaultTarget != null)
			{
				this._selectable = ownerDefaultTarget.GetComponent<Selectable>();
			}
			this.DoGetValue();
			base.Finish();
		}

		// Token: 0x06003A0C RID: 14860 RVA: 0x00152BC4 File Offset: 0x00150DC4
		private void DoGetValue()
		{
			if (this._selectable == null)
			{
				return;
			}
			bool flag = this._selectable.IsInteractable();
			this.isInteractable.Value = flag;
			if (flag)
			{
				base.Fsm.Event(this.isInteractableEvent);
				return;
			}
			base.Fsm.Event(this.isNotInteractableEvent);
		}

		// Token: 0x04003D4F RID: 15695
		[RequiredField]
		[CheckForComponent(typeof(Selectable))]
		[Tooltip("The GameObject with the Selectable ui component.")]
		public FsmOwnerDefault gameObject;

		// Token: 0x04003D50 RID: 15696
		[Tooltip("The Interactable value")]
		[UIHint(UIHint.Variable)]
		public FsmBool isInteractable;

		// Token: 0x04003D51 RID: 15697
		[Tooltip("Event sent if Component is Interactable")]
		public FsmEvent isInteractableEvent;

		// Token: 0x04003D52 RID: 15698
		[Tooltip("Event sent if Component is not Interactable")]
		public FsmEvent isNotInteractableEvent;

		// Token: 0x04003D53 RID: 15699
		private Selectable _selectable;

		// Token: 0x04003D54 RID: 15700
		private bool _originalState;
	}
}
