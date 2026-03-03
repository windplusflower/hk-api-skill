using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x020009E3 RID: 2531
	[ActionCategory("Enemy AI")]
	[Tooltip("Object idly buzzes about within a defined range")]
	public class IdleBuzzV2 : RigidBody2dActionBase
	{
		// Token: 0x06003740 RID: 14144 RVA: 0x00145808 File Offset: 0x00143A08
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

		// Token: 0x06003741 RID: 14145 RVA: 0x00070581 File Offset: 0x0006E781
		public override void Awake()
		{
			base.Fsm.HandleFixedUpdate = true;
		}

		// Token: 0x06003742 RID: 14146 RVA: 0x00070581 File Offset: 0x0006E781
		public override void OnPreprocess()
		{
			base.Fsm.HandleFixedUpdate = true;
		}

		// Token: 0x06003743 RID: 14147 RVA: 0x00145880 File Offset: 0x00143A80
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

		// Token: 0x06003744 RID: 14148 RVA: 0x0014593F File Offset: 0x00143B3F
		public override void OnFixedUpdate()
		{
			this.DoBuzz();
		}

		// Token: 0x06003745 RID: 14149 RVA: 0x00145948 File Offset: 0x00143B48
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
					this.accelY = UnityEngine.Random.Range(0f, this.accelerationMax.Value);
				}
				else if (this.target.Value.transform.position.y > this.startY + this.roamingRangeY.Value)
				{
					this.accelY = UnityEngine.Random.Range(-this.accelerationMax.Value, 0f);
				}
				else
				{
					this.accelY = UnityEngine.Random.Range(-this.accelerationMax.Value, this.accelerationMax.Value);
				}
				if (this.target.Value.transform.position.x < this.startX - this.roamingRangeX.Value)
				{
					this.accelX = UnityEngine.Random.Range(0f, this.accelerationMax.Value);
				}
				else if (this.target.Value.transform.position.x > this.startX + this.roamingRangeX.Value)
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

		// Token: 0x04003970 RID: 14704
		[RequiredField]
		[CheckForComponent(typeof(Rigidbody2D))]
		public FsmOwnerDefault gameObject;

		// Token: 0x04003971 RID: 14705
		public FsmFloat waitMin;

		// Token: 0x04003972 RID: 14706
		public FsmFloat waitMax;

		// Token: 0x04003973 RID: 14707
		public FsmFloat speedMax;

		// Token: 0x04003974 RID: 14708
		public FsmFloat accelerationMax;

		// Token: 0x04003975 RID: 14709
		public FsmFloat roamingRangeX;

		// Token: 0x04003976 RID: 14710
		public FsmFloat roamingRangeY;

		// Token: 0x04003977 RID: 14711
		public FsmVector3 manualStartPos;

		// Token: 0x04003978 RID: 14712
		private FsmGameObject target;

		// Token: 0x04003979 RID: 14713
		private float startX;

		// Token: 0x0400397A RID: 14714
		private float startY;

		// Token: 0x0400397B RID: 14715
		private float accelX;

		// Token: 0x0400397C RID: 14716
		private float accelY;

		// Token: 0x0400397D RID: 14717
		private float waitTime;

		// Token: 0x0400397E RID: 14718
		private const float dampener = 1.125f;
	}
}
