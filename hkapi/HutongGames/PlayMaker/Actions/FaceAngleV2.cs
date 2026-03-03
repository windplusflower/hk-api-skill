using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x020009BC RID: 2492
	[ActionCategory("Enemy AI")]
	[Tooltip("Object rotates to face direction it is travelling in.")]
	public class FaceAngleV2 : RigidBody2dActionBase
	{
		// Token: 0x06003691 RID: 13969 RVA: 0x00141FBD File Offset: 0x001401BD
		public override void Reset()
		{
			this.gameObject = null;
			this.angleOffset = 0f;
			this.everyFrame = false;
		}

		// Token: 0x06003692 RID: 13970 RVA: 0x00070581 File Offset: 0x0006E781
		public override void Awake()
		{
			base.Fsm.HandleFixedUpdate = true;
		}

		// Token: 0x06003693 RID: 13971 RVA: 0x00070581 File Offset: 0x0006E781
		public override void OnPreprocess()
		{
			base.Fsm.HandleFixedUpdate = true;
		}

		// Token: 0x06003694 RID: 13972 RVA: 0x00141FE0 File Offset: 0x001401E0
		public override void OnEnter()
		{
			base.CacheRigidBody2d(base.Fsm.GetOwnerDefaultTarget(this.gameObject));
			this.target = base.Fsm.GetOwnerDefaultTarget(this.gameObject);
			this.DoAngle();
			if (!this.everyFrame)
			{
				base.Finish();
			}
		}

		// Token: 0x06003695 RID: 13973 RVA: 0x00142034 File Offset: 0x00140234
		public override void OnFixedUpdate()
		{
			this.DoAngle();
		}

		// Token: 0x06003696 RID: 13974 RVA: 0x0014203C File Offset: 0x0014023C
		private void DoAngle()
		{
			if (this.rb2d == null)
			{
				return;
			}
			Vector2 velocity = this.rb2d.velocity;
			float z = Mathf.Atan2(velocity.y, velocity.x) * 57.295776f + this.angleOffset.Value;
			if (this.worldSpace.Value)
			{
				this.target.Value.transform.eulerAngles = new Vector3(0f, 0f, z);
				return;
			}
			this.target.Value.transform.localEulerAngles = new Vector3(0f, 0f, z);
		}

		// Token: 0x04003868 RID: 14440
		[RequiredField]
		[CheckForComponent(typeof(Rigidbody2D))]
		public FsmOwnerDefault gameObject;

		// Token: 0x04003869 RID: 14441
		[Tooltip("Offset the angle. If sprite faces right, leave as 0.")]
		public FsmFloat angleOffset;

		// Token: 0x0400386A RID: 14442
		[Tooltip("Use local or world space.")]
		public FsmBool worldSpace;

		// Token: 0x0400386B RID: 14443
		public bool everyFrame;

		// Token: 0x0400386C RID: 14444
		private FsmGameObject target;
	}
}
