using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000900 RID: 2304
	[ActionCategory(ActionCategory.Animator)]
	[Tooltip("Sets the position, rotation and weights of an IK goal. A GameObject can be set to control the position and rotation, or it can be manually expressed.")]
	public class SetAnimatorIKGoal : FsmStateAction
	{
		// Token: 0x0600331D RID: 13085 RVA: 0x00134380 File Offset: 0x00132580
		public override void Reset()
		{
			this.gameObject = null;
			this.goal = null;
			this.position = new FsmVector3
			{
				UseVariable = true
			};
			this.rotation = new FsmQuaternion
			{
				UseVariable = true
			};
			this.positionWeight = 1f;
			this.rotationWeight = 1f;
			this.everyFrame = false;
		}

		// Token: 0x0600331E RID: 13086 RVA: 0x00133EB6 File Offset: 0x001320B6
		public override void OnPreprocess()
		{
			base.Fsm.HandleAnimatorIK = true;
		}

		// Token: 0x0600331F RID: 13087 RVA: 0x001343E8 File Offset: 0x001325E8
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
		}

		// Token: 0x06003320 RID: 13088 RVA: 0x00134459 File Offset: 0x00132659
		public override void DoAnimatorIK(int layerIndex)
		{
			this.DoSetIKGoal();
			if (!this.everyFrame)
			{
				base.Finish();
			}
		}

		// Token: 0x06003321 RID: 13089 RVA: 0x00134470 File Offset: 0x00132670
		private void DoSetIKGoal()
		{
			if (this._animator == null)
			{
				return;
			}
			if (this._transform != null)
			{
				if (this.position.IsNone)
				{
					this._animator.SetIKPosition(this.iKGoal, this._transform.position);
				}
				else
				{
					this._animator.SetIKPosition(this.iKGoal, this._transform.position + this.position.Value);
				}
				if (this.rotation.IsNone)
				{
					this._animator.SetIKRotation(this.iKGoal, this._transform.rotation);
				}
				else
				{
					this._animator.SetIKRotation(this.iKGoal, this._transform.rotation * this.rotation.Value);
				}
			}
			else
			{
				if (!this.position.IsNone)
				{
					this._animator.SetIKPosition(this.iKGoal, this.position.Value);
				}
				if (!this.rotation.IsNone)
				{
					this._animator.SetIKRotation(this.iKGoal, this.rotation.Value);
				}
			}
			if (!this.positionWeight.IsNone)
			{
				this._animator.SetIKPositionWeight(this.iKGoal, this.positionWeight.Value);
			}
			if (!this.rotationWeight.IsNone)
			{
				this._animator.SetIKRotationWeight(this.iKGoal, this.rotationWeight.Value);
			}
		}

		// Token: 0x04003482 RID: 13442
		[RequiredField]
		[CheckForComponent(typeof(Animator))]
		[Tooltip("The target.")]
		public FsmOwnerDefault gameObject;

		// Token: 0x04003483 RID: 13443
		[Tooltip("The IK goal")]
		public AvatarIKGoal iKGoal;

		// Token: 0x04003484 RID: 13444
		[Tooltip("The gameObject target of the ik goal")]
		public FsmGameObject goal;

		// Token: 0x04003485 RID: 13445
		[Tooltip("The position of the ik goal. If Goal GameObject set, position is used as an offset from Goal")]
		public FsmVector3 position;

		// Token: 0x04003486 RID: 13446
		[Tooltip("The rotation of the ik goal.If Goal GameObject set, rotation is used as an offset from Goal")]
		public FsmQuaternion rotation;

		// Token: 0x04003487 RID: 13447
		[HasFloatSlider(0f, 1f)]
		[Tooltip("The translative weight of an IK goal (0 = at the original animation before IK, 1 = at the goal)")]
		public FsmFloat positionWeight;

		// Token: 0x04003488 RID: 13448
		[HasFloatSlider(0f, 1f)]
		[Tooltip("Sets the rotational weight of an IK goal (0 = rotation before IK, 1 = rotation at the IK goal)")]
		public FsmFloat rotationWeight;

		// Token: 0x04003489 RID: 13449
		[Tooltip("Repeat every frame. Useful when changing over time.")]
		public bool everyFrame;

		// Token: 0x0400348A RID: 13450
		private Animator _animator;

		// Token: 0x0400348B RID: 13451
		private Transform _transform;
	}
}
