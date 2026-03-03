using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x020009BD RID: 2493
	[ActionCategory("Enemy AI")]
	[Tooltip("Object will flip to face the direction it is moving on X Axis.")]
	public class FaceDirection : RigidBody2dActionBase
	{
		// Token: 0x06003698 RID: 13976 RVA: 0x001420E0 File Offset: 0x001402E0
		public override void Reset()
		{
			this.gameObject = null;
			this.spriteFacesRight = false;
			this.everyFrame = false;
			this.playNewAnimation = false;
			this.newAnimationClip = null;
		}

		// Token: 0x06003699 RID: 13977 RVA: 0x0014210C File Offset: 0x0014030C
		public override void OnEnter()
		{
			base.CacheRigidBody2d(base.Fsm.GetOwnerDefaultTarget(this.gameObject));
			this.target = base.Fsm.GetOwnerDefaultTarget(this.gameObject);
			this._sprite = this.target.Value.GetComponent<tk2dSpriteAnimator>();
			this.xScale = this.target.Value.transform.localScale.x;
			if (this.xScale < 0f)
			{
				this.xScale *= -1f;
			}
			this.DoFace();
			if (!this.everyFrame)
			{
				base.Finish();
			}
		}

		// Token: 0x0600369A RID: 13978 RVA: 0x001421B5 File Offset: 0x001403B5
		public override void OnUpdate()
		{
			this.DoFace();
		}

		// Token: 0x0600369B RID: 13979 RVA: 0x001421C0 File Offset: 0x001403C0
		private void DoFace()
		{
			if (this.rb2d == null)
			{
				return;
			}
			ref Vector2 velocity = this.rb2d.velocity;
			Vector3 localScale = this.target.Value.transform.localScale;
			float x = velocity.x;
			if (this.pauseTimer <= 0f || !this.pauseBetweenTurns)
			{
				if (x > 0f)
				{
					if (this.spriteFacesRight.Value)
					{
						if (localScale.x != this.xScale)
						{
							this.pauseTimer = this.pauseTime.Value;
							localScale.x = this.xScale;
							if (this.playNewAnimation)
							{
								this._sprite.Play(this.newAnimationClip.Value);
								this._sprite.PlayFromFrame(0);
							}
						}
					}
					else if (localScale.x != -this.xScale)
					{
						this.pauseTimer = this.pauseTime.Value;
						localScale.x = -this.xScale;
						if (this.playNewAnimation)
						{
							this._sprite.Play(this.newAnimationClip.Value);
							this._sprite.PlayFromFrame(0);
						}
					}
				}
				else if (x <= 0f)
				{
					if (this.spriteFacesRight.Value)
					{
						if (localScale.x != -this.xScale)
						{
							this.pauseTimer = this.pauseTime.Value;
							localScale.x = -this.xScale;
							if (this.playNewAnimation)
							{
								this._sprite.Play(this.newAnimationClip.Value);
								this._sprite.PlayFromFrame(0);
							}
						}
					}
					else if (localScale.x != this.xScale)
					{
						this.pauseTimer = this.pauseTime.Value;
						localScale.x = this.xScale;
						if (this.playNewAnimation)
						{
							this._sprite.Play(this.newAnimationClip.Value);
							this._sprite.PlayFromFrame(0);
						}
					}
				}
			}
			else
			{
				this.pauseTimer -= Time.deltaTime;
			}
			this.target.Value.transform.localScale = new Vector3(localScale.x, this.target.Value.transform.localScale.y, this.target.Value.transform.localScale.z);
		}

		// Token: 0x0400386D RID: 14445
		[RequiredField]
		[CheckForComponent(typeof(Rigidbody2D))]
		public FsmOwnerDefault gameObject;

		// Token: 0x0400386E RID: 14446
		[Tooltip("Does the target's sprite face right?")]
		public FsmBool spriteFacesRight;

		// Token: 0x0400386F RID: 14447
		public bool playNewAnimation;

		// Token: 0x04003870 RID: 14448
		public FsmString newAnimationClip;

		// Token: 0x04003871 RID: 14449
		public bool everyFrame;

		// Token: 0x04003872 RID: 14450
		public bool pauseBetweenTurns;

		// Token: 0x04003873 RID: 14451
		public FsmFloat pauseTime;

		// Token: 0x04003874 RID: 14452
		private FsmGameObject target;

		// Token: 0x04003875 RID: 14453
		private tk2dSpriteAnimator _sprite;

		// Token: 0x04003876 RID: 14454
		private float xScale;

		// Token: 0x04003877 RID: 14455
		private float pauseTimer;
	}
}
