using System;
using UnityEngine;
using UnityEngine.UI;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000A8B RID: 2699
	[ActionCategory("uGui")]
	[Tooltip("Gets the transition type of a Selectable Ugui component.")]
	public class uGuiTransitionGetType : FsmStateAction
	{
		// Token: 0x06003A27 RID: 14887 RVA: 0x001533A9 File Offset: 0x001515A9
		public override void Reset()
		{
			this.gameObject = null;
			this.transition = null;
			this.colorTintEvent = null;
			this.spriteSwapEvent = null;
			this.animationEvent = null;
			this.noTransitionEvent = null;
		}

		// Token: 0x06003A28 RID: 14888 RVA: 0x001533D8 File Offset: 0x001515D8
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

		// Token: 0x06003A29 RID: 14889 RVA: 0x00153418 File Offset: 0x00151618
		private void DoGetValue()
		{
			if (this._selectable == null)
			{
				return;
			}
			this.transition.Value = this._selectable.transition.ToString();
			if (this._selectable.transition == Selectable.Transition.None)
			{
				base.Fsm.Event(this.noTransitionEvent);
				return;
			}
			if (this._selectable.transition == Selectable.Transition.ColorTint)
			{
				base.Fsm.Event(this.colorTintEvent);
				return;
			}
			if (this._selectable.transition == Selectable.Transition.SpriteSwap)
			{
				base.Fsm.Event(this.spriteSwapEvent);
				return;
			}
			if (this._selectable.transition == Selectable.Transition.Animation)
			{
				base.Fsm.Event(this.animationEvent);
			}
		}

		// Token: 0x04003D7E RID: 15742
		[RequiredField]
		[CheckForComponent(typeof(Selectable))]
		[Tooltip("The GameObject with the Selectable ui component.")]
		public FsmOwnerDefault gameObject;

		// Token: 0x04003D7F RID: 15743
		[Tooltip("The transition value")]
		public FsmString transition;

		// Token: 0x04003D80 RID: 15744
		[Tooltip("Event sent if transition is ColorTint")]
		public FsmEvent colorTintEvent;

		// Token: 0x04003D81 RID: 15745
		[Tooltip("Event sent if transition is SpriteSwap")]
		public FsmEvent spriteSwapEvent;

		// Token: 0x04003D82 RID: 15746
		[Tooltip("Event sent if transition is Animation")]
		public FsmEvent animationEvent;

		// Token: 0x04003D83 RID: 15747
		[Tooltip("Event sent if transition is none")]
		public FsmEvent noTransitionEvent;

		// Token: 0x04003D84 RID: 15748
		private Selectable _selectable;

		// Token: 0x04003D85 RID: 15749
		private Selectable.Transition _originalTransition;
	}
}
