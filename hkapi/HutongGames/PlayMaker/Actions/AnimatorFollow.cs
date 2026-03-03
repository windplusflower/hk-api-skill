using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x0200090B RID: 2315
	[ActionCategory("Animator")]
	[Tooltip("Follow a target")]
	[HelpUrl("https://hutonggames.fogbugz.com/default.asp?W1033")]
	public class AnimatorFollow : FsmStateAction
	{
		// Token: 0x06003354 RID: 13140 RVA: 0x00134EBE File Offset: 0x001330BE
		public override void Reset()
		{
			this.gameObject = null;
			this.target = null;
			this.speedDampTime = 0.25f;
			this.directionDampTime = 0.25f;
			this.minimumDistance = 1f;
		}

		// Token: 0x06003355 RID: 13141 RVA: 0x00134F00 File Offset: 0x00133100
		public override void OnEnter()
		{
			this._go = base.Fsm.GetOwnerDefaultTarget(this.gameObject);
			if (this._go == null)
			{
				base.Finish();
				return;
			}
			this._animatorProxy = this._go.GetComponent<PlayMakerAnimatorMoveProxy>();
			if (this._animatorProxy != null)
			{
				this._animatorProxy.OnAnimatorMoveEvent += this.OnAnimatorMoveEvent;
			}
			this.avatar = this._go.GetComponent<Animator>();
			this.controller = this._go.GetComponent<CharacterController>();
			this.avatar.speed = 1f + UnityEngine.Random.Range(-0.4f, 0.4f);
		}

		// Token: 0x06003356 RID: 13142 RVA: 0x00134FB4 File Offset: 0x001331B4
		public override void OnUpdate()
		{
			GameObject value = this.target.Value;
			float value2 = this.speedDampTime.Value;
			float value3 = this.directionDampTime.Value;
			float value4 = this.minimumDistance.Value;
			if (this.avatar && value)
			{
				if (Vector3.Distance(value.transform.position, this.avatar.rootPosition) > value4)
				{
					this.avatar.SetFloat("Speed", 1f, value2, Time.deltaTime);
					Vector3 lhs = this.avatar.rootRotation * Vector3.forward;
					Vector3 normalized = (value.transform.position - this.avatar.rootPosition).normalized;
					if (Vector3.Dot(lhs, normalized) > 0f)
					{
						this.avatar.SetFloat("Direction", Vector3.Cross(lhs, normalized).y, value3, Time.deltaTime);
					}
					else
					{
						this.avatar.SetFloat("Direction", (float)((Vector3.Cross(lhs, normalized).y > 0f) ? 1 : -1), value3, Time.deltaTime);
					}
				}
				else
				{
					this.avatar.SetFloat("Speed", 0f, value2, Time.deltaTime);
				}
				if (this._animatorProxy == null)
				{
					this.OnAnimatorMoveEvent();
				}
			}
		}

		// Token: 0x06003357 RID: 13143 RVA: 0x0013511C File Offset: 0x0013331C
		public override void OnExit()
		{
			if (this._animatorProxy != null)
			{
				this._animatorProxy.OnAnimatorMoveEvent -= this.OnAnimatorMoveEvent;
			}
		}

		// Token: 0x06003358 RID: 13144 RVA: 0x00135143 File Offset: 0x00133343
		public void OnAnimatorMoveEvent()
		{
			this.controller.Move(this.avatar.deltaPosition);
			this._go.transform.rotation = this.avatar.rootRotation;
		}

		// Token: 0x040034BB RID: 13499
		[RequiredField]
		[CheckForComponent(typeof(Animator))]
		[Tooltip("The GameObject. An Animator component and a PlayMakerAnimatorProxy component are required")]
		public FsmOwnerDefault gameObject;

		// Token: 0x040034BC RID: 13500
		[RequiredField]
		[Tooltip("The Game Object to target.")]
		public FsmGameObject target;

		// Token: 0x040034BD RID: 13501
		[Tooltip("The minimum distance to follow.")]
		public FsmFloat minimumDistance;

		// Token: 0x040034BE RID: 13502
		[Tooltip("The damping for following up.")]
		public FsmFloat speedDampTime;

		// Token: 0x040034BF RID: 13503
		[Tooltip("The damping for turning.")]
		public FsmFloat directionDampTime;

		// Token: 0x040034C0 RID: 13504
		private GameObject _go;

		// Token: 0x040034C1 RID: 13505
		private PlayMakerAnimatorMoveProxy _animatorProxy;

		// Token: 0x040034C2 RID: 13506
		private Animator avatar;

		// Token: 0x040034C3 RID: 13507
		private CharacterController controller;
	}
}
