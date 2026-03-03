using System;
using UnityEngine;
using UnityEngine.UI;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000A88 RID: 2696
	[ActionCategory("uGui")]
	[Tooltip("Sets the Animation Triggers of a Selectable Ugui component. Modifications will not be visible if transition is not Animation")]
	public class uGuiSetAnimationTriggers : FsmStateAction
	{
		// Token: 0x06003A17 RID: 14871 RVA: 0x00152EB4 File Offset: 0x001510B4
		public override void Reset()
		{
			this.gameObject = null;
			this.normalTrigger = new FsmString
			{
				UseVariable = true
			};
			this.highlightedTrigger = new FsmString
			{
				UseVariable = true
			};
			this.pressedTrigger = new FsmString
			{
				UseVariable = true
			};
			this.disabledTrigger = new FsmString
			{
				UseVariable = true
			};
			this.resetOnExit = null;
		}

		// Token: 0x06003A18 RID: 14872 RVA: 0x00152F18 File Offset: 0x00151118
		public override void OnEnter()
		{
			GameObject ownerDefaultTarget = base.Fsm.GetOwnerDefaultTarget(this.gameObject);
			if (ownerDefaultTarget != null)
			{
				this._selectable = ownerDefaultTarget.GetComponent<Selectable>();
			}
			if (this._selectable != null && this.resetOnExit.Value)
			{
				this._originalAnimationTriggers = this._selectable.animationTriggers;
			}
			this.DoSetValue();
			base.Finish();
		}

		// Token: 0x06003A19 RID: 14873 RVA: 0x00152F84 File Offset: 0x00151184
		private void DoSetValue()
		{
			if (this._selectable == null)
			{
				return;
			}
			this._animationTriggers = this._selectable.animationTriggers;
			if (!this.normalTrigger.IsNone)
			{
				this._animationTriggers.normalTrigger = this.normalTrigger.Value;
			}
			if (!this.highlightedTrigger.IsNone)
			{
				this._animationTriggers.highlightedTrigger = this.highlightedTrigger.Value;
			}
			if (!this.pressedTrigger.IsNone)
			{
				this._animationTriggers.pressedTrigger = this.pressedTrigger.Value;
			}
			if (!this.disabledTrigger.IsNone)
			{
				this._animationTriggers.disabledTrigger = this.disabledTrigger.Value;
			}
			this._selectable.animationTriggers = this._animationTriggers;
		}

		// Token: 0x06003A1A RID: 14874 RVA: 0x0015304E File Offset: 0x0015124E
		public override void OnExit()
		{
			if (this._selectable == null)
			{
				return;
			}
			if (this.resetOnExit.Value)
			{
				this._selectable.animationTriggers = this._originalAnimationTriggers;
			}
		}

		// Token: 0x04003D64 RID: 15716
		[RequiredField]
		[CheckForComponent(typeof(Selectable))]
		[Tooltip("The GameObject with the Selectable ui component.")]
		public FsmOwnerDefault gameObject;

		// Token: 0x04003D65 RID: 15717
		[Tooltip("The normal trigger value. Leave to none for no effect")]
		public FsmString normalTrigger;

		// Token: 0x04003D66 RID: 15718
		[Tooltip("The highlighted trigger value. Leave to none for no effect")]
		public FsmString highlightedTrigger;

		// Token: 0x04003D67 RID: 15719
		[Tooltip("The pressed trigger value. Leave to none for no effect")]
		public FsmString pressedTrigger;

		// Token: 0x04003D68 RID: 15720
		[Tooltip("The disabled trigger value. Leave to none for no effect")]
		public FsmString disabledTrigger;

		// Token: 0x04003D69 RID: 15721
		[Tooltip("Reset when exiting this state.")]
		public FsmBool resetOnExit;

		// Token: 0x04003D6A RID: 15722
		private Selectable _selectable;

		// Token: 0x04003D6B RID: 15723
		private AnimationTriggers _animationTriggers;

		// Token: 0x04003D6C RID: 15724
		private AnimationTriggers _originalAnimationTriggers;
	}
}
