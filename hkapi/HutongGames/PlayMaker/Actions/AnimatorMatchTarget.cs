using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x020008CF RID: 2255
	[ActionCategory(ActionCategory.Animator)]
	[Tooltip("Automatically adjust the gameobject position and rotation so that the AvatarTarget reaches the matchPosition when the current state is at the specified progress")]
	public class AnimatorMatchTarget : FsmStateAction
	{
		// Token: 0x06003240 RID: 12864 RVA: 0x001316A8 File Offset: 0x0012F8A8
		public override void Reset()
		{
			this.gameObject = null;
			this.bodyPart = AvatarTarget.Root;
			this.target = null;
			this.targetPosition = new FsmVector3
			{
				UseVariable = true
			};
			this.targetRotation = new FsmQuaternion
			{
				UseVariable = true
			};
			this.positionWeight = Vector3.one;
			this.rotationWeight = 0f;
			this.startNormalizedTime = null;
			this.targetNormalizedTime = null;
			this.everyFrame = true;
		}

		// Token: 0x06003241 RID: 12865 RVA: 0x00131724 File Offset: 0x0012F924
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
			GameObject value = this.target.Value;
			if (value != null)
			{
				this._transform = value.transform;
			}
			this.DoMatchTarget();
			if (!this.everyFrame)
			{
				base.Finish();
			}
		}

		// Token: 0x06003242 RID: 12866 RVA: 0x001317A9 File Offset: 0x0012F9A9
		public override void OnUpdate()
		{
			this.DoMatchTarget();
		}

		// Token: 0x06003243 RID: 12867 RVA: 0x001317B4 File Offset: 0x0012F9B4
		private void DoMatchTarget()
		{
			if (this._animator == null)
			{
				return;
			}
			Vector3 vector = Vector3.zero;
			Quaternion quaternion = Quaternion.identity;
			if (this._transform != null)
			{
				vector = this._transform.position;
				quaternion = this._transform.rotation;
			}
			if (!this.targetPosition.IsNone)
			{
				vector += this.targetPosition.Value;
			}
			if (!this.targetRotation.IsNone)
			{
				quaternion *= this.targetRotation.Value;
			}
			MatchTargetWeightMask weightMask = new MatchTargetWeightMask(this.positionWeight.Value, this.rotationWeight.Value);
			this._animator.MatchTarget(vector, quaternion, this.bodyPart, weightMask, this.startNormalizedTime.Value, this.targetNormalizedTime.Value);
		}

		// Token: 0x0400338D RID: 13197
		[RequiredField]
		[CheckForComponent(typeof(Animator))]
		[Tooltip("The Target. An Animator component is required")]
		public FsmOwnerDefault gameObject;

		// Token: 0x0400338E RID: 13198
		[Tooltip("The body part that is involved in the match")]
		public AvatarTarget bodyPart;

		// Token: 0x0400338F RID: 13199
		[Tooltip("The gameObject target to match")]
		public FsmGameObject target;

		// Token: 0x04003390 RID: 13200
		[Tooltip("The position of the ik goal. If Goal GameObject set, position is used as an offset from Goal")]
		public FsmVector3 targetPosition;

		// Token: 0x04003391 RID: 13201
		[Tooltip("The rotation of the ik goal.If Goal GameObject set, rotation is used as an offset from Goal")]
		public FsmQuaternion targetRotation;

		// Token: 0x04003392 RID: 13202
		[Tooltip("The MatchTargetWeightMask Position XYZ weight")]
		public FsmVector3 positionWeight;

		// Token: 0x04003393 RID: 13203
		[Tooltip("The MatchTargetWeightMask Rotation weight")]
		public FsmFloat rotationWeight;

		// Token: 0x04003394 RID: 13204
		[Tooltip("Start time within the animation clip (0 - beginning of clip, 1 - end of clip)")]
		public FsmFloat startNormalizedTime;

		// Token: 0x04003395 RID: 13205
		[Tooltip("End time within the animation clip (0 - beginning of clip, 1 - end of clip), values greater than 1 can be set to trigger a match after a certain number of loops. Ex: 2.3 means at 30% of 2nd loop")]
		public FsmFloat targetNormalizedTime;

		// Token: 0x04003396 RID: 13206
		[Tooltip("Should always be true")]
		public bool everyFrame;

		// Token: 0x04003397 RID: 13207
		private Animator _animator;

		// Token: 0x04003398 RID: 13208
		private Transform _transform;
	}
}
