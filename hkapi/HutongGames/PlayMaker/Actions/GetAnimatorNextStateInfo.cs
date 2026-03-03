using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x020008F1 RID: 2289
	[ActionCategory(ActionCategory.Animator)]
	[Tooltip("Gets the next State information on a specified layer")]
	public class GetAnimatorNextStateInfo : FsmStateActionAnimatorBase
	{
		// Token: 0x060032D4 RID: 13012 RVA: 0x001334F8 File Offset: 0x001316F8
		public override void Reset()
		{
			base.Reset();
			this.gameObject = null;
			this.layerIndex = null;
			this.name = null;
			this.nameHash = null;
			this.tagHash = null;
			this.length = null;
			this.normalizedTime = null;
			this.isStateLooping = null;
			this.loopCount = null;
			this.currentLoopProgress = null;
		}

		// Token: 0x060032D5 RID: 13013 RVA: 0x00133554 File Offset: 0x00131754
		public override void OnEnter()
		{
			GameObject ownerDefaultTarget = base.Fsm.GetOwnerDefaultTarget(this.gameObject);
			if (ownerDefaultTarget == null)
			{
				base.Finish();
				return;
			}
			this._animator = ownerDefaultTarget.GetComponent<Animator>();
			if (this._animator == null)
			{
				base.Finish();
				return;
			}
			this.GetLayerInfo();
			if (!this.everyFrame)
			{
				base.Finish();
			}
		}

		// Token: 0x060032D6 RID: 13014 RVA: 0x001335B8 File Offset: 0x001317B8
		public override void OnActionUpdate()
		{
			this.GetLayerInfo();
		}

		// Token: 0x060032D7 RID: 13015 RVA: 0x001335C0 File Offset: 0x001317C0
		private void GetLayerInfo()
		{
			if (this._animator != null)
			{
				AnimatorStateInfo nextAnimatorStateInfo = this._animator.GetNextAnimatorStateInfo(this.layerIndex.Value);
				if (!this.nameHash.IsNone)
				{
					this.nameHash.Value = nextAnimatorStateInfo.nameHash;
				}
				if (!this.name.IsNone)
				{
					this.name.Value = this._animator.GetLayerName(this.layerIndex.Value);
				}
				if (!this.tagHash.IsNone)
				{
					this.tagHash.Value = nextAnimatorStateInfo.tagHash;
				}
				if (!this.length.IsNone)
				{
					this.length.Value = nextAnimatorStateInfo.length;
				}
				if (!this.isStateLooping.IsNone)
				{
					this.isStateLooping.Value = nextAnimatorStateInfo.loop;
				}
				if (!this.normalizedTime.IsNone)
				{
					this.normalizedTime.Value = nextAnimatorStateInfo.normalizedTime;
				}
				if (!this.loopCount.IsNone || !this.currentLoopProgress.IsNone)
				{
					this.loopCount.Value = (int)Math.Truncate((double)nextAnimatorStateInfo.normalizedTime);
					this.currentLoopProgress.Value = nextAnimatorStateInfo.normalizedTime - (float)this.loopCount.Value;
				}
			}
		}

		// Token: 0x04003439 RID: 13369
		[RequiredField]
		[CheckForComponent(typeof(Animator))]
		[Tooltip("The target. An Animator component is required")]
		public FsmOwnerDefault gameObject;

		// Token: 0x0400343A RID: 13370
		[RequiredField]
		[Tooltip("The layer's index")]
		public FsmInt layerIndex;

		// Token: 0x0400343B RID: 13371
		[ActionSection("Results")]
		[UIHint(UIHint.Variable)]
		[Tooltip("The layer's name.")]
		public FsmString name;

		// Token: 0x0400343C RID: 13372
		[UIHint(UIHint.Variable)]
		[Tooltip("The layer's name Hash. Obsolete in Unity 5, use fullPathHash or shortPathHash instead, nameHash will be the same as shortNameHash for legacy")]
		public FsmInt nameHash;

		// Token: 0x0400343D RID: 13373
		[UIHint(UIHint.Variable)]
		[Tooltip("The layer's tag hash")]
		public FsmInt tagHash;

		// Token: 0x0400343E RID: 13374
		[UIHint(UIHint.Variable)]
		[Tooltip("Is the state looping. All animations in the state must be looping")]
		public FsmBool isStateLooping;

		// Token: 0x0400343F RID: 13375
		[UIHint(UIHint.Variable)]
		[Tooltip("The Current duration of the state. In seconds, can vary when the State contains a Blend Tree ")]
		public FsmFloat length;

		// Token: 0x04003440 RID: 13376
		[UIHint(UIHint.Variable)]
		[Tooltip("The integer part is the number of time a state has been looped. The fractional part is the % (0-1) of progress in the current loop")]
		public FsmFloat normalizedTime;

		// Token: 0x04003441 RID: 13377
		[UIHint(UIHint.Variable)]
		[Tooltip("The integer part is the number of time a state has been looped. This is extracted from the normalizedTime")]
		public FsmInt loopCount;

		// Token: 0x04003442 RID: 13378
		[UIHint(UIHint.Variable)]
		[Tooltip("The progress in the current loop. This is extracted from the normalizedTime")]
		public FsmFloat currentLoopProgress;

		// Token: 0x04003443 RID: 13379
		private Animator _animator;
	}
}
