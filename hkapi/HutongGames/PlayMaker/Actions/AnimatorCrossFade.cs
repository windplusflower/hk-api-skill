using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x020008CD RID: 2253
	[ActionCategory(ActionCategory.Animator)]
	[Tooltip("Create a dynamic transition between the current state and the destination state.Both state as to be on the same layer. note: You cannot change the current state on a synchronized layer, you need to change it on the referenced layer.")]
	public class AnimatorCrossFade : FsmStateAction
	{
		// Token: 0x0600323A RID: 12858 RVA: 0x0013153C File Offset: 0x0012F73C
		public override void Reset()
		{
			this.gameObject = null;
			this.stateName = null;
			this.transitionDuration = 1f;
			this.layer = new FsmInt
			{
				UseVariable = true
			};
			this.normalizedTime = new FsmFloat
			{
				UseVariable = true
			};
		}

		// Token: 0x0600323B RID: 12859 RVA: 0x0013158C File Offset: 0x0012F78C
		public override void OnEnter()
		{
			GameObject ownerDefaultTarget = base.Fsm.GetOwnerDefaultTarget(this.gameObject);
			if (ownerDefaultTarget == null)
			{
				base.Finish();
				return;
			}
			this._animator = ownerDefaultTarget.GetComponent<Animator>();
			if (this._animator != null)
			{
				int num = this.layer.IsNone ? -1 : this.layer.Value;
				float normalizedTimeOffset = this.normalizedTime.IsNone ? float.NegativeInfinity : this.normalizedTime.Value;
				this._animator.CrossFade(this.stateName.Value, this.transitionDuration.Value, num, normalizedTimeOffset);
			}
			base.Finish();
		}

		// Token: 0x04003384 RID: 13188
		[RequiredField]
		[CheckForComponent(typeof(Animator))]
		[Tooltip("The target. An Animator component is required")]
		public FsmOwnerDefault gameObject;

		// Token: 0x04003385 RID: 13189
		[Tooltip("The name of the state that will be played.")]
		public FsmString stateName;

		// Token: 0x04003386 RID: 13190
		[Tooltip("The duration of the transition. Value is in source state normalized time.")]
		public FsmFloat transitionDuration;

		// Token: 0x04003387 RID: 13191
		[Tooltip("Layer index containing the destination state. Leave to none to ignore")]
		public FsmInt layer;

		// Token: 0x04003388 RID: 13192
		[Tooltip("Start time of the current destination state. Value is in source state normalized time, should be between 0 and 1.")]
		public FsmFloat normalizedTime;

		// Token: 0x04003389 RID: 13193
		private Animator _animator;

		// Token: 0x0400338A RID: 13194
		private int _paramID;
	}
}
