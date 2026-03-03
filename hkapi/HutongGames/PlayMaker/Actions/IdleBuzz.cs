using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x020009E2 RID: 2530
	[ActionCategory("Enemy AI")]
	[Tooltip("Object idly buzzes about within a defined range")]
	public class IdleBuzz : RigidBody2dActionBase
	{
		// Token: 0x06003739 RID: 14137 RVA: 0x0014520F File Offset: 0x0014340F
		public override void Reset()
		{
			this.gameObject = null;
			this.waitMin = 0f;
			this.waitMax = 0f;
			this.accelerationMax = 0f;
		}

		// Token: 0x0600373A RID: 14138 RVA: 0x00070581 File Offset: 0x0006E781
		public override void Awake()
		{
			base.Fsm.HandleFixedUpdate = true;
		}

		// Token: 0x0600373B RID: 14139 RVA: 0x00070581 File Offset: 0x0006E781
		public override void OnPreprocess()
		{
			base.Fsm.HandleFixedUpdate = true;
		}

		// Token: 0x0600373C RID: 14140 RVA: 0x00145248 File Offset: 0x00143448
		public override void OnEnter()
		{
			base.CacheRigidBody2d(base.Fsm.GetOwnerDefaultTarget(this.gameObject));
			this.target = base.Fsm.GetOwnerDefaultTarget(this.gameObject);
			this.startX = this.target.Value.transform.position.x;
			this.startY = this.target.Value.transform.position.y;
			this.DoBuzz();
		}

		// Token: 0x0600373D RID: 14141 RVA: 0x001452CE File Offset: 0x001434CE
		public override void OnFixedUpdate()
		{
			this.DoBuzz();
		}

		// Token: 0x0600373E RID: 14142 RVA: 0x001452D8 File Offset: 0x001434D8
		private void DoBuzz()
		{
			if (this.rb2d == null)
			{
				return;
			}
			Vector2 velocity = this.rb2d.velocity;
			if (this.target.Value.transform.position.y < this.startY - this.roamingRange.Value)
			{
				if (velocity.y < 0f)
				{
					this.accelY = this.accelerationMax.Value;
					this.accelY /= 2000f;
					velocity.y /= 1.125f;
					this.waitTime = UnityEngine.Random.Range(this.waitMin.Value, this.waitMax.Value);
				}
			}
			else if (this.target.Value.transform.position.y > this.startY + this.roamingRange.Value && velocity.y > 0f)
			{
				this.accelY = -this.accelerationMax.Value;
				this.accelY /= 2000f;
				velocity.y /= 1.125f;
				this.waitTime = UnityEngine.Random.Range(this.waitMin.Value, this.waitMax.Value);
			}
			if (this.target.Value.transform.position.x < this.startX - this.roamingRange.Value)
			{
				if (velocity.x < 0f)
				{
					this.accelX = this.accelerationMax.Value;
					this.accelX /= 2000f;
					velocity.x /= 1.125f;
					this.waitTime = UnityEngine.Random.Range(this.waitMin.Value, this.waitMax.Value);
				}
			}
			else if (this.target.Value.transform.position.x > this.startX + this.roamingRange.Value && velocity.x > 0f)
			{
				this.accelX = -this.accelerationMax.Value;
				this.accelX /= 2000f;
				velocity.x /= 1.125f;
				this.waitTime = UnityEngine.Random.Range(this.waitMin.Value, this.waitMax.Value);
			}
			if (this.waitTime <= Mathf.Epsilon)
			{
				if (this.target.Value.transform.position.y < this.startY - this.roamingRange.Value)
				{
					this.accelY = UnityEngine.Random.Range(0f, this.accelerationMax.Value);
				}
				else if (this.target.Value.transform.position.y > this.startY + this.roamingRange.Value)
				{
					this.accelY = UnityEngine.Random.Range(-this.accelerationMax.Value, 0f);
				}
				else
				{
					this.accelY = UnityEngine.Random.Range(-this.accelerationMax.Value, this.accelerationMax.Value);
				}
				if (this.target.Value.transform.position.x < this.startX - this.roamingRange.Value)
				{
					this.accelX = UnityEngine.Random.Range(0f, this.accelerationMax.Value);
				}
				else if (this.target.Value.transform.position.x > this.startX + this.roamingRange.Value)
				{
					this.accelX = UnityEngine.Random.Range(-this.accelerationMax.Value, 0f);
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

		// Token: 0x04003963 RID: 14691
		[RequiredField]
		[CheckForComponent(typeof(Rigidbody2D))]
		public FsmOwnerDefault gameObject;

		// Token: 0x04003964 RID: 14692
		public FsmFloat waitMin;

		// Token: 0x04003965 RID: 14693
		public FsmFloat waitMax;

		// Token: 0x04003966 RID: 14694
		public FsmFloat speedMax;

		// Token: 0x04003967 RID: 14695
		public FsmFloat accelerationMax;

		// Token: 0x04003968 RID: 14696
		public FsmFloat roamingRange;

		// Token: 0x04003969 RID: 14697
		private FsmGameObject target;

		// Token: 0x0400396A RID: 14698
		private float startX;

		// Token: 0x0400396B RID: 14699
		private float startY;

		// Token: 0x0400396C RID: 14700
		private float accelX;

		// Token: 0x0400396D RID: 14701
		private float accelY;

		// Token: 0x0400396E RID: 14702
		private float waitTime;

		// Token: 0x0400396F RID: 14703
		private const float dampener = 1.125f;
	}
}
