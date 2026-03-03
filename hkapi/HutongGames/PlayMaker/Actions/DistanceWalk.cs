using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x020009BA RID: 2490
	[ActionCategory("Enemy AI")]
	[Tooltip("Try to keep a certain distance from target.")]
	public class DistanceWalk : RigidBody2dActionBase
	{
		// Token: 0x06003682 RID: 13954 RVA: 0x00141A48 File Offset: 0x0013FC48
		public override void Reset()
		{
			this.gameObject = null;
			this.target = null;
			this.speed = 0f;
		}

		// Token: 0x06003683 RID: 13955 RVA: 0x00070581 File Offset: 0x0006E781
		public override void Awake()
		{
			base.Fsm.HandleFixedUpdate = true;
		}

		// Token: 0x06003684 RID: 13956 RVA: 0x00070581 File Offset: 0x0006E781
		public override void OnPreprocess()
		{
			base.Fsm.HandleFixedUpdate = true;
		}

		// Token: 0x06003685 RID: 13957 RVA: 0x00141A68 File Offset: 0x0013FC68
		public override void OnEnter()
		{
			base.CacheRigidBody2d(base.Fsm.GetOwnerDefaultTarget(this.gameObject));
			this.self = base.Fsm.GetOwnerDefaultTarget(this.gameObject);
			if (this.changeAnimation)
			{
				this.animator = this.self.Value.GetComponent<tk2dSpriteAnimator>();
			}
			this.DoWalk();
		}

		// Token: 0x06003686 RID: 13958 RVA: 0x00141ACC File Offset: 0x0013FCCC
		public override void OnUpdate()
		{
			if (this.changeTimer > 0f)
			{
				this.changeTimer -= Time.deltaTime;
			}
		}

		// Token: 0x06003687 RID: 13959 RVA: 0x00141AED File Offset: 0x0013FCED
		public override void OnFixedUpdate()
		{
			this.DoWalk();
		}

		// Token: 0x06003688 RID: 13960 RVA: 0x00141AF8 File Offset: 0x0013FCF8
		private void DoWalk()
		{
			if (this.rb2d == null)
			{
				return;
			}
			this.distanceAway = this.self.Value.transform.position.x - this.target.Value.transform.position.x;
			if (this.distanceAway < 0f)
			{
				this.distanceAway *= -1f;
			}
			Vector2 velocity = this.rb2d.velocity;
			if (this.distanceAway > this.distance.Value + this.range.Value)
			{
				if (this.self.Value.transform.position.x < this.target.Value.transform.position.x)
				{
					if (!this.movingRight && this.changeTimer <= 0f)
					{
						velocity.x = this.speed.Value;
						this.movingRight = true;
						this.changeTimer = this.ANIM_CHANGE_TIME;
					}
				}
				else if (this.movingRight && this.changeTimer <= 0f)
				{
					velocity.x = -this.speed.Value;
					this.movingRight = false;
					this.changeTimer = this.ANIM_CHANGE_TIME;
				}
			}
			else if (this.distanceAway < this.distance.Value - this.range.Value)
			{
				if (this.self.Value.transform.position.x < this.target.Value.transform.position.x)
				{
					if (this.movingRight && this.changeTimer <= 0f)
					{
						velocity.x = -this.speed.Value;
						this.movingRight = false;
						this.changeTimer = this.ANIM_CHANGE_TIME;
					}
				}
				else if (!this.movingRight && this.changeTimer <= 0f)
				{
					velocity.x = this.speed.Value;
					this.movingRight = true;
					this.changeTimer = this.ANIM_CHANGE_TIME;
				}
			}
			if (this.rb2d.velocity.x > -0.1f && this.rb2d.velocity.x < 0.1f)
			{
				if (UnityEngine.Random.value > 0.5f)
				{
					velocity.x = this.speed.Value;
					this.movingRight = true;
				}
				else
				{
					velocity.x = -this.speed.Value;
					this.movingRight = false;
				}
				this.randomStart = true;
			}
			this.rb2d.velocity = velocity;
			if (this.changeAnimation)
			{
				if (this.self.Value.transform.localScale.x > 0f)
				{
					if ((this.spriteFacesRight && this.movingRight) || (!this.spriteFacesRight && !this.movingRight))
					{
						this.animator.Play(this.forwardAnimation.Value);
					}
					if ((!this.spriteFacesRight && this.movingRight) || (this.spriteFacesRight && !this.movingRight))
					{
						this.animator.Play(this.backAnimation.Value);
						return;
					}
				}
				else
				{
					if ((this.spriteFacesRight && this.movingRight) || (!this.spriteFacesRight && !this.movingRight))
					{
						this.animator.Play(this.backAnimation.Value);
					}
					if ((!this.spriteFacesRight && this.movingRight) || (this.spriteFacesRight && !this.movingRight))
					{
						this.animator.Play(this.forwardAnimation.Value);
					}
				}
			}
		}

		// Token: 0x06003689 RID: 13961 RVA: 0x00141EBC File Offset: 0x001400BC
		public DistanceWalk()
		{
			this.ANIM_CHANGE_TIME = 0.6f;
			base..ctor();
		}

		// Token: 0x04003854 RID: 14420
		[RequiredField]
		[CheckForComponent(typeof(Rigidbody2D))]
		[UIHint(UIHint.Variable)]
		public FsmOwnerDefault gameObject;

		// Token: 0x04003855 RID: 14421
		[UIHint(UIHint.Variable)]
		public FsmGameObject target;

		// Token: 0x04003856 RID: 14422
		public FsmFloat distance;

		// Token: 0x04003857 RID: 14423
		public FsmFloat speed;

		// Token: 0x04003858 RID: 14424
		public FsmFloat range;

		// Token: 0x04003859 RID: 14425
		public bool changeAnimation;

		// Token: 0x0400385A RID: 14426
		public bool spriteFacesRight;

		// Token: 0x0400385B RID: 14427
		public FsmString forwardAnimation;

		// Token: 0x0400385C RID: 14428
		public FsmString backAnimation;

		// Token: 0x0400385D RID: 14429
		private float distanceAway;

		// Token: 0x0400385E RID: 14430
		private FsmGameObject self;

		// Token: 0x0400385F RID: 14431
		private tk2dSpriteAnimator animator;

		// Token: 0x04003860 RID: 14432
		private bool movingRight;

		// Token: 0x04003861 RID: 14433
		private float ANIM_CHANGE_TIME;

		// Token: 0x04003862 RID: 14434
		private float changeTimer;

		// Token: 0x04003863 RID: 14435
		private bool randomStart;
	}
}
