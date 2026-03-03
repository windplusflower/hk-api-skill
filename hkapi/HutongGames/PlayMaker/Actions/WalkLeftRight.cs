using System;
using System.Collections;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000A76 RID: 2678
	public class WalkLeftRight : FsmStateAction
	{
		// Token: 0x1700072A RID: 1834
		// (get) Token: 0x060039BA RID: 14778 RVA: 0x00151054 File Offset: 0x0014F254
		private float Direction
		{
			get
			{
				if (this.target)
				{
					return Mathf.Sign(this.target.transform.localScale.x) * (float)(this.spriteFacesLeft ? -1 : 1);
				}
				return 0f;
			}
		}

		// Token: 0x060039BB RID: 14779 RVA: 0x00151091 File Offset: 0x0014F291
		public override void OnEnter()
		{
			this.UpdateIfTargetChanged();
			this.SetupStartingDirection();
			this.walkRoutine = base.StartCoroutine(this.Walk());
		}

		// Token: 0x060039BC RID: 14780 RVA: 0x001510B1 File Offset: 0x0014F2B1
		public override void OnExit()
		{
			if (this.walkRoutine != null)
			{
				base.StopCoroutine(this.walkRoutine);
				this.walkRoutine = null;
			}
			if (this.turnRoutine != null)
			{
				base.StopCoroutine(this.turnRoutine);
				this.turnRoutine = null;
			}
		}

		// Token: 0x060039BD RID: 14781 RVA: 0x001510EC File Offset: 0x0014F2EC
		private void UpdateIfTargetChanged()
		{
			GameObject ownerDefaultTarget = base.Fsm.GetOwnerDefaultTarget(this.gameObject);
			if (ownerDefaultTarget != this.target)
			{
				this.target = ownerDefaultTarget;
				this.body = this.target.GetComponent<Rigidbody2D>();
				this.spriteAnimator = this.target.GetComponent<tk2dSpriteAnimator>();
				this.collider = this.target.GetComponent<Collider2D>();
			}
		}

		// Token: 0x060039BE RID: 14782 RVA: 0x00151153 File Offset: 0x0014F353
		private IEnumerator Walk()
		{
			if (this.spriteAnimator)
			{
				this.spriteAnimator.Play(this.walkAnimName.Value);
			}
			for (;;)
			{
				if (this.body)
				{
					Vector2 velocity = this.body.velocity;
					velocity.x = this.walkSpeed * this.Direction;
					this.body.velocity = velocity;
					if (this.shouldTurn || (this.CheckIsGrounded() && (this.CheckWall() || this.CheckFloor()) && Time.time >= this.nextTurnTime))
					{
						this.shouldTurn = false;
						this.nextTurnTime = Time.time + this.turnDelay;
						this.turnRoutine = this.StartCoroutine(this.Turn());
						yield return this.turnRoutine;
					}
				}
				yield return new WaitForFixedUpdate();
			}
			yield break;
		}

		// Token: 0x060039BF RID: 14783 RVA: 0x00151162 File Offset: 0x0014F362
		private IEnumerator Turn()
		{
			Vector2 velocity = this.body.velocity;
			velocity.x = 0f;
			this.body.velocity = velocity;
			tk2dSpriteAnimationClip clipByName = this.spriteAnimator.GetClipByName(this.turnAnimName.Value);
			if (clipByName != null)
			{
				float seconds = (float)clipByName.frames.Length / clipByName.fps;
				this.spriteAnimator.Play(clipByName);
				yield return new WaitForSeconds(seconds);
			}
			Vector3 localScale = this.target.transform.localScale;
			localScale.x *= -1f;
			this.target.transform.localScale = localScale;
			if (this.spriteAnimator)
			{
				this.spriteAnimator.Play(this.walkAnimName.Value);
			}
			this.turnRoutine = null;
			yield break;
		}

		// Token: 0x060039C0 RID: 14784 RVA: 0x00151174 File Offset: 0x0014F374
		private bool CheckWall()
		{
			Vector2 vector = this.collider.bounds.center + new Vector2(0f, -(this.collider.bounds.size.y / 2f) + 0.5f);
			Vector2 vector2 = Vector2.right * this.Direction;
			float num = this.collider.bounds.size.x / 2f + 0.1f;
			Debug.DrawLine(vector, vector + vector2 * num);
			return Physics2D.Raycast(vector, vector2, num, 256).collider != null;
		}

		// Token: 0x060039C1 RID: 14785 RVA: 0x00151244 File Offset: 0x0014F444
		private bool CheckFloor()
		{
			Vector2 vector = this.collider.bounds.center + new Vector2((this.collider.bounds.size.x / 2f + 0.1f) * this.Direction, -(this.collider.bounds.size.y / 2f) + 0.5f);
			Debug.DrawLine(vector, vector + Vector2.down * 1f);
			return !(Physics2D.Raycast(vector, Vector2.down, 1f, 256).collider != null);
		}

		// Token: 0x060039C2 RID: 14786 RVA: 0x00151314 File Offset: 0x0014F514
		private bool CheckIsGrounded()
		{
			Vector2 vector = this.collider.bounds.center + new Vector2(0f, -(this.collider.bounds.size.y / 2f) + 0.5f);
			Debug.DrawLine(vector, vector + Vector2.down * 1f);
			return Physics2D.Raycast(vector, Vector2.down, 1f, 256).collider != null;
		}

		// Token: 0x060039C3 RID: 14787 RVA: 0x001513BC File Offset: 0x0014F5BC
		private void SetupStartingDirection()
		{
			if (this.target.transform.localScale.x < 0f)
			{
				if (!this.spriteFacesLeft && this.startRight.Value)
				{
					this.shouldTurn = true;
				}
				if (this.spriteFacesLeft && this.startLeft.Value)
				{
					this.shouldTurn = true;
				}
			}
			else
			{
				if (this.spriteFacesLeft && this.startRight.Value)
				{
					this.shouldTurn = true;
				}
				if (!this.spriteFacesLeft && this.startLeft.Value)
				{
					this.shouldTurn = true;
				}
			}
			if (!this.startLeft.Value && !this.startRight.Value && !this.keepDirection.Value && UnityEngine.Random.Range(0f, 100f) <= 50f)
			{
				this.shouldTurn = true;
			}
			this.startLeft.Value = false;
			this.startRight.Value = false;
		}

		// Token: 0x060039C4 RID: 14788 RVA: 0x001514B3 File Offset: 0x0014F6B3
		public WalkLeftRight()
		{
			this.walkSpeed = 4f;
			this.groundLayer = "Terrain";
			this.turnDelay = 1f;
			base..ctor();
		}

		// Token: 0x04003CCA RID: 15562
		public FsmOwnerDefault gameObject;

		// Token: 0x04003CCB RID: 15563
		public float walkSpeed;

		// Token: 0x04003CCC RID: 15564
		public bool spriteFacesLeft;

		// Token: 0x04003CCD RID: 15565
		public FsmString groundLayer;

		// Token: 0x04003CCE RID: 15566
		public float turnDelay;

		// Token: 0x04003CCF RID: 15567
		private float nextTurnTime;

		// Token: 0x04003CD0 RID: 15568
		[Header("Animation")]
		public FsmString walkAnimName;

		// Token: 0x04003CD1 RID: 15569
		public FsmString turnAnimName;

		// Token: 0x04003CD2 RID: 15570
		public FsmBool startLeft;

		// Token: 0x04003CD3 RID: 15571
		public FsmBool startRight;

		// Token: 0x04003CD4 RID: 15572
		public FsmBool keepDirection;

		// Token: 0x04003CD5 RID: 15573
		private float scaleX_pos;

		// Token: 0x04003CD6 RID: 15574
		private float scaleX_neg;

		// Token: 0x04003CD7 RID: 15575
		private const float wallRayHeight = 0.5f;

		// Token: 0x04003CD8 RID: 15576
		private const float wallRayLength = 0.1f;

		// Token: 0x04003CD9 RID: 15577
		private const float groundRayLength = 1f;

		// Token: 0x04003CDA RID: 15578
		private GameObject target;

		// Token: 0x04003CDB RID: 15579
		private Rigidbody2D body;

		// Token: 0x04003CDC RID: 15580
		private tk2dSpriteAnimator spriteAnimator;

		// Token: 0x04003CDD RID: 15581
		private Collider2D collider;

		// Token: 0x04003CDE RID: 15582
		private Coroutine walkRoutine;

		// Token: 0x04003CDF RID: 15583
		private Coroutine turnRoutine;

		// Token: 0x04003CE0 RID: 15584
		private bool shouldTurn;
	}
}
