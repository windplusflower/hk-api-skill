using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x020008DA RID: 2266
	[ActionCategory(ActionCategory.Animator)]
	[Tooltip("Gets the current State information on a specified layer")]
	public class GetAnimatorCurrentStateInfo : FsmStateActionAnimatorBase
	{
		// Token: 0x0600326C RID: 12908 RVA: 0x00131F8C File Offset: 0x0013018C
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
			this.everyFrame = false;
		}

		// Token: 0x0600326D RID: 12909 RVA: 0x00131FEC File Offset: 0x001301EC
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

		// Token: 0x0600326E RID: 12910 RVA: 0x00132050 File Offset: 0x00130250
		public override void OnActionUpdate()
		{
			this.GetLayerInfo();
		}

		// Token: 0x0600326F RID: 12911 RVA: 0x00132058 File Offset: 0x00130258
		private void GetLayerInfo()
		{
			if (this._animator != null)
			{
				AnimatorStateInfo currentAnimatorStateInfo = this._animator.GetCurrentAnimatorStateInfo(this.layerIndex.Value);
				if (!this.nameHash.IsNone)
				{
					this.nameHash.Value = currentAnimatorStateInfo.nameHash;
				}
				if (!this.name.IsNone)
				{
					this.name.Value = this._animator.GetLayerName(this.layerIndex.Value);
				}
				if (!this.tagHash.IsNone)
				{
					this.tagHash.Value = currentAnimatorStateInfo.tagHash;
				}
				if (!this.length.IsNone)
				{
					this.length.Value = currentAnimatorStateInfo.length;
				}
				if (!this.isStateLooping.IsNone)
				{
					this.isStateLooping.Value = currentAnimatorStateInfo.loop;
				}
				if (!this.normalizedTime.IsNone)
				{
					this.normalizedTime.Value = currentAnimatorStateInfo.normalizedTime;
				}
				if (!this.loopCount.IsNone || !this.currentLoopProgress.IsNone)
				{
					this.loopCount.Value = (int)Math.Truncate((double)currentAnimatorStateInfo.normalizedTime);
					this.currentLoopProgress.Value = currentAnimatorStateInfo.normalizedTime - (float)this.loopCount.Value;
				}
			}
		}

		// Token: 0x040033BF RID: 13247
		[RequiredField]
		[CheckForComponent(typeof(Animator))]
		[Tooltip("The target.")]
		public FsmOwnerDefault gameObject;

		// Token: 0x040033C0 RID: 13248
		[RequiredField]
		[Tooltip("The layer's index")]
		public FsmInt layerIndex;

		// Token: 0x040033C1 RID: 13249
		[ActionSection("Results")]
		[UIHint(UIHint.Variable)]
		[Tooltip("The layer's name.")]
		public FsmString name;

		// Token: 0x040033C2 RID: 13250
		[UIHint(UIHint.Variable)]
		[Tooltip("The layer's name Hash. Obsolete in Unity 5, use fullPathHash or shortPathHash instead, nameHash will be the same as shortNameHash for legacy")]
		public FsmInt nameHash;

		// Token: 0x040033C3 RID: 13251
		[UIHint(UIHint.Variable)]
		[Tooltip("The layer's tag hash")]
		public FsmInt tagHash;

		// Token: 0x040033C4 RID: 13252
		[UIHint(UIHint.Variable)]
		[Tooltip("Is the state looping. All animations in the state must be looping")]
		public FsmBool isStateLooping;

		// Token: 0x040033C5 RID: 13253
		[UIHint(UIHint.Variable)]
		[Tooltip("The Current duration of the state. In seconds, can vary when the State contains a Blend Tree ")]
		public FsmFloat length;

		// Token: 0x040033C6 RID: 13254
		[UIHint(UIHint.Variable)]
		[Tooltip("The integer part is the number of time a state has been looped. The fractional part is the % (0-1) of progress in the current loop")]
		public FsmFloat normalizedTime;

		// Token: 0x040033C7 RID: 13255
		[UIHint(UIHint.Variable)]
		[Tooltip("The integer part is the number of time a state has been looped. This is extracted from the normalizedTime")]
		public FsmInt loopCount;

		// Token: 0x040033C8 RID: 13256
		[UIHint(UIHint.Variable)]
		[Tooltip("The progress in the current loop. This is extracted from the normalizedTime")]
		public FsmFloat currentLoopProgress;

		// Token: 0x040033C9 RID: 13257
		private Animator _animator;
	}
}
