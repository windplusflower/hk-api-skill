using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x020009BE RID: 2494
	[ActionCategory("Enemy AI")]
	[Tooltip("Object A will flip to face Object B horizontally.")]
	public class FaceObject : FsmStateAction
	{
		// Token: 0x0600369D RID: 13981 RVA: 0x0014242D File Offset: 0x0014062D
		public override void Reset()
		{
			this.objectA = null;
			this.objectB = null;
			this.newAnimationClip = null;
			this.spriteFacesRight = false;
			this.everyFrame = false;
			this.resetFrame = false;
			this.playNewAnimation = false;
		}

		// Token: 0x0600369E RID: 13982 RVA: 0x00142468 File Offset: 0x00140668
		public override void OnEnter()
		{
			this._sprite = this.objectA.Value.GetComponent<tk2dSpriteAnimator>();
			if (this._sprite == null)
			{
				base.Finish();
			}
			this.xScale = this.objectA.Value.transform.localScale.x;
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

		// Token: 0x0600369F RID: 13983 RVA: 0x001424F2 File Offset: 0x001406F2
		public override void OnUpdate()
		{
			this.DoFace();
		}

		// Token: 0x060036A0 RID: 13984 RVA: 0x001424FC File Offset: 0x001406FC
		private void DoFace()
		{
			Vector3 localScale = this.objectA.Value.transform.localScale;
			if (this.objectB.Value == null || this.objectB.IsNone)
			{
				base.Finish();
			}
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
				}
			}
			this.objectA.Value.transform.localScale = new Vector3(localScale.x, this.objectA.Value.transform.localScale.y, this.objectA.Value.transform.localScale.z);
		}

		// Token: 0x060036A1 RID: 13985 RVA: 0x0014273F File Offset: 0x0014093F
		public FaceObject()
		{
			this.resetFrame = true;
			base..ctor();
		}

		// Token: 0x04003878 RID: 14456
		[RequiredField]
		public FsmGameObject objectA;

		// Token: 0x04003879 RID: 14457
		[RequiredField]
		[UIHint(UIHint.Variable)]
		public FsmGameObject objectB;

		// Token: 0x0400387A RID: 14458
		[Tooltip("Does object A's sprite face right?")]
		public FsmBool spriteFacesRight;

		// Token: 0x0400387B RID: 14459
		public bool playNewAnimation;

		// Token: 0x0400387C RID: 14460
		public FsmString newAnimationClip;

		// Token: 0x0400387D RID: 14461
		public bool resetFrame;

		// Token: 0x0400387E RID: 14462
		[Tooltip("Repeat every frame.")]
		public bool everyFrame;

		// Token: 0x0400387F RID: 14463
		private float xScale;

		// Token: 0x04003880 RID: 14464
		private FsmVector3 vector;

		// Token: 0x04003881 RID: 14465
		private tk2dSpriteAnimator _sprite;
	}
}
