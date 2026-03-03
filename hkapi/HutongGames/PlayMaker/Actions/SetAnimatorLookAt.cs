using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000904 RID: 2308
	[ActionCategory(ActionCategory.Animator)]
	[Tooltip("Sets look at position and weights. A GameObject can be set to control the look at position, or it can be manually expressed.")]
	public class SetAnimatorLookAt : FsmStateAction
	{
		// Token: 0x06003331 RID: 13105 RVA: 0x00134814 File Offset: 0x00132A14
		public override void Reset()
		{
			this.gameObject = null;
			this.target = null;
			this.targetPosition = new FsmVector3
			{
				UseVariable = true
			};
			this.weight = 1f;
			this.bodyWeight = 0.3f;
			this.headWeight = 0.6f;
			this.eyesWeight = 1f;
			this.clampWeight = 0.5f;
			this.everyFrame = false;
		}

		// Token: 0x06003332 RID: 13106 RVA: 0x00133EB6 File Offset: 0x001320B6
		public override void OnPreprocess()
		{
			base.Fsm.HandleAnimatorIK = true;
		}

		// Token: 0x06003333 RID: 13107 RVA: 0x00134898 File Offset: 0x00132A98
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
		}

		// Token: 0x06003334 RID: 13108 RVA: 0x00134909 File Offset: 0x00132B09
		public override void DoAnimatorIK(int layerIndex)
		{
			this.DoSetLookAt();
			if (!this.everyFrame)
			{
				base.Finish();
			}
		}

		// Token: 0x06003335 RID: 13109 RVA: 0x00134920 File Offset: 0x00132B20
		private void DoSetLookAt()
		{
			if (this._animator == null)
			{
				return;
			}
			if (this._transform != null)
			{
				if (this.targetPosition.IsNone)
				{
					this._animator.SetLookAtPosition(this._transform.position);
				}
				else
				{
					this._animator.SetLookAtPosition(this._transform.position + this.targetPosition.Value);
				}
			}
			else if (!this.targetPosition.IsNone)
			{
				this._animator.SetLookAtPosition(this.targetPosition.Value);
			}
			if (!this.clampWeight.IsNone)
			{
				this._animator.SetLookAtWeight(this.weight.Value, this.bodyWeight.Value, this.headWeight.Value, this.eyesWeight.Value, this.clampWeight.Value);
				return;
			}
			if (!this.eyesWeight.IsNone)
			{
				this._animator.SetLookAtWeight(this.weight.Value, this.bodyWeight.Value, this.headWeight.Value, this.eyesWeight.Value);
				return;
			}
			if (!this.headWeight.IsNone)
			{
				this._animator.SetLookAtWeight(this.weight.Value, this.bodyWeight.Value, this.headWeight.Value);
				return;
			}
			if (!this.bodyWeight.IsNone)
			{
				this._animator.SetLookAtWeight(this.weight.Value, this.bodyWeight.Value);
				return;
			}
			if (!this.weight.IsNone)
			{
				this._animator.SetLookAtWeight(this.weight.Value);
			}
		}

		// Token: 0x04003499 RID: 13465
		[RequiredField]
		[CheckForComponent(typeof(Animator))]
		[Tooltip("The target. An Animator component is required.")]
		public FsmOwnerDefault gameObject;

		// Token: 0x0400349A RID: 13466
		[Tooltip("The gameObject to look at")]
		public FsmGameObject target;

		// Token: 0x0400349B RID: 13467
		[Tooltip("The lookat position. If Target GameObject set, targetPosition is used as an offset from Target")]
		public FsmVector3 targetPosition;

		// Token: 0x0400349C RID: 13468
		[HasFloatSlider(0f, 1f)]
		[Tooltip("The global weight of the LookAt, multiplier for other parameters. Range from 0 to 1")]
		public FsmFloat weight;

		// Token: 0x0400349D RID: 13469
		[HasFloatSlider(0f, 1f)]
		[Tooltip("determines how much the body is involved in the LookAt. Range from 0 to 1")]
		public FsmFloat bodyWeight;

		// Token: 0x0400349E RID: 13470
		[HasFloatSlider(0f, 1f)]
		[Tooltip("determines how much the head is involved in the LookAt. Range from 0 to 1")]
		public FsmFloat headWeight;

		// Token: 0x0400349F RID: 13471
		[HasFloatSlider(0f, 1f)]
		[Tooltip("determines how much the eyes are involved in the LookAt. Range from 0 to 1")]
		public FsmFloat eyesWeight;

		// Token: 0x040034A0 RID: 13472
		[HasFloatSlider(0f, 1f)]
		[Tooltip("0.0 means the character is completely unrestrained in motion, 1.0 means he's completely clamped (look at becomes impossible), and 0.5 means he'll be able to move on half of the possible range (180 degrees).")]
		public FsmFloat clampWeight;

		// Token: 0x040034A1 RID: 13473
		[Tooltip("Repeat every frame during OnAnimatorIK(). Useful for changing over time.")]
		public bool everyFrame;

		// Token: 0x040034A2 RID: 13474
		private Animator _animator;

		// Token: 0x040034A3 RID: 13475
		private Transform _transform;
	}
}
