using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x020009E1 RID: 2529
	[ActionCategory("Enemy AI")]
	[Tooltip("Object A will flip to face Object B horizontally.")]
	public class GrimmChildFly : FsmStateAction
	{
		// Token: 0x06003734 RID: 14132 RVA: 0x00144DC8 File Offset: 0x00142FC8
		public override void Reset()
		{
			this.objectA = null;
			this.objectB = null;
			this.newAnimationClip = null;
			this.spriteFacesRight = false;
			this.resetFrame = false;
			this.playNewAnimation = false;
			this.flyingFast = false;
			this.pauseBetweenAnimChange = null;
			this.timer = 0f;
			this.animatingFast = false;
		}

		// Token: 0x06003735 RID: 14133 RVA: 0x00144E24 File Offset: 0x00143024
		public override void OnEnter()
		{
			this._sprite = this.objectA.Value.GetComponent<tk2dSpriteAnimator>();
			this.rb2d = this.objectA.Value.GetComponent<Rigidbody2D>();
			this.xScale = this.objectA.Value.transform.localScale.x;
			if (this.xScale < 0f)
			{
				this.xScale *= -1f;
			}
			this.DoFace();
		}

		// Token: 0x06003736 RID: 14134 RVA: 0x00144EA2 File Offset: 0x001430A2
		public override void OnUpdate()
		{
			this.DoFace();
		}

		// Token: 0x06003737 RID: 14135 RVA: 0x00144EAC File Offset: 0x001430AC
		private void DoFace()
		{
			Vector3 localScale = this.objectA.Value.transform.localScale;
			if (this.objectA.Value.transform.position.x < this.objectB.Value.transform.position.x)
			{
				if (this.spriteFacesRight.Value)
				{
					if (localScale.x != this.xScale)
					{
						localScale.x = this.xScale;
						if (this.resetFrame)
						{
							this._sprite.PlayFromFrame(0);
						}
						if (this.playNewAnimation)
						{
							this._sprite.Play(this.newAnimationClip.Value);
							this.flyingFast = false;
						}
					}
				}
				else if (localScale.x != -this.xScale)
				{
					localScale.x = -this.xScale;
					if (this.resetFrame)
					{
						this._sprite.PlayFromFrame(0);
					}
					if (this.playNewAnimation)
					{
						this._sprite.Play(this.newAnimationClip.Value);
						this.flyingFast = false;
					}
				}
			}
			else if (this.spriteFacesRight.Value)
			{
				if (localScale.x != -this.xScale)
				{
					localScale.x = -this.xScale;
					if (this.resetFrame)
					{
						this._sprite.PlayFromFrame(0);
					}
					if (this.playNewAnimation)
					{
						this._sprite.Play(this.newAnimationClip.Value);
						this.flyingFast = false;
					}
				}
			}
			else if (localScale.x != this.xScale)
			{
				localScale.x = this.xScale;
				if (this.resetFrame)
				{
					this._sprite.PlayFromFrame(0);
				}
				if (this.playNewAnimation)
				{
					this._sprite.Play(this.newAnimationClip.Value);
					this.flyingFast = false;
				}
			}
			if (!this.flyingFast && this.timer <= 0f && (this.rb2d.velocity.x > this.fastAnimSpeed.Value || this.rb2d.velocity.x < -this.fastAnimSpeed.Value))
			{
				this.flyingFast = true;
				this._sprite.Play(this.fastAnimationClip.Value);
				this.timer = this.pauseBetweenAnimChange.Value;
			}
			if (this.flyingFast && this.timer <= 0f && this.rb2d.velocity.x < this.fastAnimSpeed.Value && this.rb2d.velocity.x > -this.fastAnimSpeed.Value)
			{
				this.flyingFast = false;
				this._sprite.Play(this.normalAnimationClip.Value);
				this.timer = this.pauseBetweenAnimChange.Value;
			}
			if (this.timer > 0f)
			{
				this.timer -= Time.deltaTime;
			}
			this.objectA.Value.transform.localScale = new Vector3(localScale.x, this.objectA.Value.transform.localScale.y, this.objectA.Value.transform.localScale.z);
		}

		// Token: 0x06003738 RID: 14136 RVA: 0x00145200 File Offset: 0x00143400
		public GrimmChildFly()
		{
			this.resetFrame = true;
			base..ctor();
		}

		// Token: 0x04003952 RID: 14674
		[RequiredField]
		public FsmGameObject objectA;

		// Token: 0x04003953 RID: 14675
		[RequiredField]
		[UIHint(UIHint.Variable)]
		public FsmGameObject objectB;

		// Token: 0x04003954 RID: 14676
		[Tooltip("Does object A's sprite face right?")]
		public FsmBool spriteFacesRight;

		// Token: 0x04003955 RID: 14677
		public bool playNewAnimation;

		// Token: 0x04003956 RID: 14678
		public FsmString newAnimationClip;

		// Token: 0x04003957 RID: 14679
		public bool resetFrame;

		// Token: 0x04003958 RID: 14680
		public FsmFloat fastAnimSpeed;

		// Token: 0x04003959 RID: 14681
		public FsmString fastAnimationClip;

		// Token: 0x0400395A RID: 14682
		public FsmString normalAnimationClip;

		// Token: 0x0400395B RID: 14683
		public FsmFloat pauseBetweenAnimChange;

		// Token: 0x0400395C RID: 14684
		private float xScale;

		// Token: 0x0400395D RID: 14685
		public bool flyingFast;

		// Token: 0x0400395E RID: 14686
		private FsmVector3 vector;

		// Token: 0x0400395F RID: 14687
		private tk2dSpriteAnimator _sprite;

		// Token: 0x04003960 RID: 14688
		private Rigidbody2D rb2d;

		// Token: 0x04003961 RID: 14689
		private float timer;

		// Token: 0x04003962 RID: 14690
		private bool animatingFast;
	}
}
