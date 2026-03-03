using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x020008E5 RID: 2277
	[ActionCategory(ActionCategory.Animator)]
	[Tooltip("Gets the position, rotation and weights of an IK goal. A GameObject can be set to use for the position and rotation")]
	public class GetAnimatorIKGoal : FsmStateActionAnimatorBase
	{
		// Token: 0x060032A1 RID: 12961 RVA: 0x00132B13 File Offset: 0x00130D13
		public override void Reset()
		{
			base.Reset();
			this.gameObject = null;
			this.iKGoal = null;
			this.goal = null;
			this.position = null;
			this.rotation = null;
			this.positionWeight = null;
			this.rotationWeight = null;
		}

		// Token: 0x060032A2 RID: 12962 RVA: 0x00132B4C File Offset: 0x00130D4C
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
			GameObject value = this.goal.Value;
			if (value != null)
			{
				this._transform = value.transform;
			}
			this.DoGetIKGoal();
			if (!this.everyFrame)
			{
				base.Finish();
			}
		}

		// Token: 0x060032A3 RID: 12963 RVA: 0x00132BD1 File Offset: 0x00130DD1
		public override void OnActionUpdate()
		{
			this.DoGetIKGoal();
		}

		// Token: 0x060032A4 RID: 12964 RVA: 0x00132BDC File Offset: 0x00130DDC
		private void DoGetIKGoal()
		{
			if (this._animator == null)
			{
				return;
			}
			this._iKGoal = (AvatarIKGoal)this.iKGoal.Value;
			if (this._transform != null)
			{
				this._transform.position = this._animator.GetIKPosition(this._iKGoal);
				this._transform.rotation = this._animator.GetIKRotation(this._iKGoal);
			}
			if (!this.position.IsNone)
			{
				this.position.Value = this._animator.GetIKPosition(this._iKGoal);
			}
			if (!this.rotation.IsNone)
			{
				this.rotation.Value = this._animator.GetIKRotation(this._iKGoal);
			}
			if (!this.positionWeight.IsNone)
			{
				this.positionWeight.Value = this._animator.GetIKPositionWeight(this._iKGoal);
			}
			if (!this.rotationWeight.IsNone)
			{
				this.rotationWeight.Value = this._animator.GetIKRotationWeight(this._iKGoal);
			}
		}

		// Token: 0x04003400 RID: 13312
		[RequiredField]
		[CheckForComponent(typeof(Animator))]
		[Tooltip("The target. An Animator component is required")]
		public FsmOwnerDefault gameObject;

		// Token: 0x04003401 RID: 13313
		[Tooltip("The IK goal")]
		[ObjectType(typeof(AvatarIKGoal))]
		public FsmEnum iKGoal;

		// Token: 0x04003402 RID: 13314
		[ActionSection("Results")]
		[UIHint(UIHint.Variable)]
		[Tooltip("The gameObject to apply ik goal position and rotation to")]
		public FsmGameObject goal;

		// Token: 0x04003403 RID: 13315
		[UIHint(UIHint.Variable)]
		[Tooltip("Gets The position of the ik goal. If Goal GameObject define, position is used as an offset from Goal")]
		public FsmVector3 position;

		// Token: 0x04003404 RID: 13316
		[UIHint(UIHint.Variable)]
		[Tooltip("Gets The rotation of the ik goal.If Goal GameObject define, rotation is used as an offset from Goal")]
		public FsmQuaternion rotation;

		// Token: 0x04003405 RID: 13317
		[UIHint(UIHint.Variable)]
		[Tooltip("Gets The translative weight of an IK goal (0 = at the original animation before IK, 1 = at the goal)")]
		public FsmFloat positionWeight;

		// Token: 0x04003406 RID: 13318
		[UIHint(UIHint.Variable)]
		[Tooltip("Gets the rotational weight of an IK goal (0 = rotation before IK, 1 = rotation at the IK goal)")]
		public FsmFloat rotationWeight;

		// Token: 0x04003407 RID: 13319
		private Animator _animator;

		// Token: 0x04003408 RID: 13320
		private Transform _transform;

		// Token: 0x04003409 RID: 13321
		private AvatarIKGoal _iKGoal;
	}
}
