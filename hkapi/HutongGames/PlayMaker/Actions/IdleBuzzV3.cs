using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x020009E4 RID: 2532
	[ActionCategory("Enemy AI")]
	[Tooltip("Object idly buzzes about within a defined range")]
	public class IdleBuzzV3 : RigidBody2dActionBase
	{
		// Token: 0x06003747 RID: 14151 RVA: 0x00145E78 File Offset: 0x00144078
		public override void Reset()
		{
			this.gameObject = null;
			this.waitMin = 0f;
			this.waitMax = 0f;
			this.accelerationMax = 0f;
			this.roamingRangeX = 0f;
			this.roamingRangeY = 0f;
			this.manualStartPos = new FsmVector3
			{
				UseVariable = true
			};
		}

		// Token: 0x06003748 RID: 14152 RVA: 0x00070581 File Offset: 0x0006E781
		public override void Awake()
		{
			base.Fsm.HandleFixedUpdate = true;
		}

		// Token: 0x06003749 RID: 14153 RVA: 0x00070581 File Offset: 0x0006E781
		public override void OnPreprocess()
		{
			base.Fsm.HandleFixedUpdate = true;
		}

		// Token: 0x0600374A RID: 14154 RVA: 0x00145EF0 File Offset: 0x001440F0
		public override void OnEnter()
		{
			base.CacheRigidBody2d(base.Fsm.GetOwnerDefaultTarget(this.gameObject));
			this.target = base.Fsm.GetOwnerDefaultTarget(this.gameObject);
			this.startX = this.target.Value.transform.position.x;
			this.startY = this.target.Value.transform.position.y;
			if (!this.manualStartPos.IsNone)
			{
				this.startX = this.manualStartPos.Value.x;
				this.startY = this.manualStartPos.Value.y;
			}
			this.DoBuzz();
		}

		// Token: 0x0600374B RID: 14155 RVA: 0x00145FAF File Offset: 0x001441AF
		public override void OnFixedUpdate()
		{
			this.DoBuzz();
		}

		// Token: 0x0600374C RID: 14156 RVA: 0x00145FB8 File Offset: 0x001441B8
		private void DoBuzz()
		{
			if (this.rb2d == null)
			{
				return;
			}
			Vector2 velocity = this.rb2d.velocity;
			if (this.target.Value.transform.position.y < this.startY - this.roamingRangeY.Value)
			{
				if (velocity.y < 0f)
				{
					this.accelY = this.accelerationMax.Value;
					this.accelY /= 2000f;
					velocity.y /= 1.125f;
					this.waitTime = UnityEngine.Random.Range(this.waitMin.Value, this.waitMax.Value);
				}
			}
			else if (this.target.Value.transform.position.y > this.startY + this.roamingRangeY.Value && velocity.y > 0f)
			{
				this.accelY = -this.accelerationMax.Value;
				this.accelY /= 2000f;
				velocity.y /= 1.125f;
				this.waitTime = UnityEngine.Random.Range(this.waitMin.Value, this.waitMax.Value);
			}
			if (this.target.Value.transform.position.x < this.startX - this.roamingRangeX.Value)
			{
				if (velocity.x < 0f)
				{
					this.accelX = this.accelerationMax.Value;
					this.accelX /= 2000f;
					velocity.x /= 1.125f;
					this.waitTime = UnityEngine.Random.Range(this.waitMin.Value, this.waitMax.Value);
				}
			}
			else if (this.target.Value.transform.position.x > this.startX + this.roamingRangeX.Value && velocity.x > 0f)
			{
				this.accelX = -this.accelerationMax.Value;
				this.accelX /= 2000f;
				velocity.x /= 1.125f;
				this.waitTime = UnityEngine.Random.Range(this.waitMin.Value, this.waitMax.Value);
			}
			if (this.waitTime <= Mathf.Epsilon)
			{
				if (this.target.Value.transform.position.y < this.startY - this.roamingRangeY.Value)
				{
					this.accelY = UnityEngine.Random.Range(this.accelerationMin.Value, this.accelerationMax.Value);
				}
				else if (this.target.Value.transform.position.y > this.startY + this.roamingRangeY.Value)
				{
					this.accelY = UnityEngine.Random.Range(-this.accelerationMax.Value, this.accelerationMin.Value);
				}
				else
				{
					this.accelY = UnityEngine.Random.Range(-this.accelerationMax.Value, this.accelerationMax.Value);
				}
				if (this.target.Value.transform.position.x < this.startX - this.roamingRangeX.Value)
				{
					this.accelX = UnityEngine.Random.Range(this.accelerationMin.Value, this.accelerationMax.Value);
				}
				else if (this.target.Value.transform.position.x > this.startX + this.roamingRangeX.Value)
				{
					this.accelX = UnityEngine.Random.Range(-this.accelerationMax.Value, this.accelerationMin.Value);
				}
				else
				{
					this.accelX = UnityEngine.Random.Range(-this.accelerationMax.Value, this.accelerationMax.Value);
				}
				this.accelY /= 2000f;
				this.accelX /= 2000f;
				this.waitTime = UnityEngine.Random.Range(this.waitMin.Value, this.waitMax.Value);
			}
			if (this.waitTime > Mathf.Epsilon)
			{
				this.waitTime -= Time.deltaTime;
			}
			velocity.x += this.accelX;
			velocity.y += this.accelY;
			if (velocity.x > this.speedMax.Value)
			{
				velocity.x = this.speedMax.Value;
			}
			if (velocity.x < -this.speedMax.Value)
			{
				velocity.x = -this.speedMax.Value;
			}
			if (velocity.y > this.speedMax.Value)
			{
				velocity.y = this.speedMax.Value;
			}
			if (velocity.y < -this.speedMax.Value)
			{
				velocity.y = -this.speedMax.Value;
			}
			this.rb2d.velocity = velocity;
		}

		// Token: 0x0400397F RID: 14719
		[RequiredField]
		[CheckForComponent(typeof(Rigidbody2D))]
		public FsmOwnerDefault gameObject;

		// Token: 0x04003980 RID: 14720
		public FsmFloat waitMin;

		// Token: 0x04003981 RID: 14721
		public FsmFloat waitMax;

		// Token: 0x04003982 RID: 14722
		public FsmFloat speedMax;

		// Token: 0x04003983 RID: 14723
		public FsmFloat accelerationMin;

		// Token: 0x04003984 RID: 14724
		public FsmFloat accelerationMax;

		// Token: 0x04003985 RID: 14725
		public FsmFloat roamingRangeX;

		// Token: 0x04003986 RID: 14726
		public FsmFloat roamingRangeY;

		// Token: 0x04003987 RID: 14727
		public FsmVector3 manualStartPos;

		// Token: 0x04003988 RID: 14728
		private FsmGameObject target;

		// Token: 0x04003989 RID: 14729
		private float startX;

		// Token: 0x0400398A RID: 14730
		private float startY;

		// Token: 0x0400398B RID: 14731
		private float accelX;

		// Token: 0x0400398C RID: 14732
		private float accelY;

		// Token: 0x0400398D RID: 14733
		private float waitTime;

		// Token: 0x0400398E RID: 14734
		private const float dampener = 1.125f;
	}
}
