using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000A09 RID: 2569
	[ActionCategory("Enemy AI")]
	[Tooltip("Squash projectile to match speed")]
	public class ProjectileSquash : RigidBody2dActionBase
	{
		// Token: 0x060037E4 RID: 14308 RVA: 0x0014848A File Offset: 0x0014668A
		public override void Reset()
		{
			this.gameObject = null;
			this.scaleModifier = 1f;
			this.everyFrame = false;
			this.stretchX = 1f;
			this.stretchY = 1f;
		}

		// Token: 0x060037E5 RID: 14309 RVA: 0x00070581 File Offset: 0x0006E781
		public override void OnPreprocess()
		{
			base.Fsm.HandleFixedUpdate = true;
		}

		// Token: 0x060037E6 RID: 14310 RVA: 0x001484C0 File Offset: 0x001466C0
		public override void OnEnter()
		{
			base.CacheRigidBody2d(base.Fsm.GetOwnerDefaultTarget(this.gameObject));
			this.target = base.Fsm.GetOwnerDefaultTarget(this.gameObject);
			this.DoStretch();
			if (!this.everyFrame)
			{
				base.Finish();
			}
		}

		// Token: 0x060037E7 RID: 14311 RVA: 0x00148514 File Offset: 0x00146714
		public override void OnFixedUpdate()
		{
			this.DoStretch();
		}

		// Token: 0x060037E8 RID: 14312 RVA: 0x0014851C File Offset: 0x0014671C
		private void DoStretch()
		{
			if (this.rb2d == null)
			{
				return;
			}
			this.stretchY = 1f - this.rb2d.velocity.magnitude * this.stretchFactor.Value * 0.01f;
			this.stretchX = 1f + this.rb2d.velocity.magnitude * this.stretchFactor.Value * 0.01f;
			if (this.stretchX < this.stretchMinX)
			{
				this.stretchX = this.stretchMinX;
			}
			if (this.stretchY > this.stretchMaxY)
			{
				this.stretchY = this.stretchMaxY;
			}
			this.stretchY *= this.scaleModifier.Value;
			this.stretchX *= this.scaleModifier.Value;
			this.target.Value.transform.localScale = new Vector3(this.stretchX, this.stretchY, this.target.Value.transform.localScale.z);
		}

		// Token: 0x060037E9 RID: 14313 RVA: 0x00148640 File Offset: 0x00146840
		public ProjectileSquash()
		{
			this.stretchFactor = 1.4f;
			this.stretchMinX = 0.5f;
			this.stretchMaxY = 2f;
			this.stretchX = 1f;
			this.stretchY = 1f;
			base..ctor();
		}

		// Token: 0x04003A67 RID: 14951
		[RequiredField]
		[CheckForComponent(typeof(Rigidbody2D))]
		public FsmOwnerDefault gameObject;

		// Token: 0x04003A68 RID: 14952
		[Tooltip("Increase this value to make the object's stretch more pronounced")]
		public FsmFloat stretchFactor;

		// Token: 0x04003A69 RID: 14953
		[Tooltip("Minimum scale value for X.")]
		public float stretchMinX;

		// Token: 0x04003A6A RID: 14954
		[Tooltip("Maximum scale value for Y")]
		public float stretchMaxY;

		// Token: 0x04003A6B RID: 14955
		[Tooltip("After other calculations, multiply scale by this modifier.")]
		public FsmFloat scaleModifier;

		// Token: 0x04003A6C RID: 14956
		public bool everyFrame;

		// Token: 0x04003A6D RID: 14957
		private FsmGameObject target;

		// Token: 0x04003A6E RID: 14958
		private float stretchX;

		// Token: 0x04003A6F RID: 14959
		private float stretchY;
	}
}
