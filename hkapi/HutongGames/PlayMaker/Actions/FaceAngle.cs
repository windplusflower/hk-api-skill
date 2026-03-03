using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x020009BB RID: 2491
	[ActionCategory("Enemy AI")]
	[Tooltip("Object rotates to face direction it is travelling in.")]
	public class FaceAngle : RigidBody2dActionBase
	{
		// Token: 0x0600368A RID: 13962 RVA: 0x00141ECF File Offset: 0x001400CF
		public override void Reset()
		{
			this.gameObject = null;
			this.angleOffset = 0f;
			this.everyFrame = false;
		}

		// Token: 0x0600368B RID: 13963 RVA: 0x00070581 File Offset: 0x0006E781
		public override void Awake()
		{
			base.Fsm.HandleFixedUpdate = true;
		}

		// Token: 0x0600368C RID: 13964 RVA: 0x00070581 File Offset: 0x0006E781
		public override void OnPreprocess()
		{
			base.Fsm.HandleFixedUpdate = true;
		}

		// Token: 0x0600368D RID: 13965 RVA: 0x00141EF0 File Offset: 0x001400F0
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

		// Token: 0x0600368E RID: 13966 RVA: 0x00141F44 File Offset: 0x00140144
		public override void OnFixedUpdate()
		{
			this.DoAngle();
		}

		// Token: 0x0600368F RID: 13967 RVA: 0x00141F4C File Offset: 0x0014014C
		private void DoAngle()
		{
			if (this.rb2d == null)
			{
				return;
			}
			Vector2 velocity = this.rb2d.velocity;
			float z = Mathf.Atan2(velocity.y, velocity.x) * 57.295776f + this.angleOffset.Value;
			this.target.Value.transform.localEulerAngles = new Vector3(0f, 0f, z);
		}

		// Token: 0x04003864 RID: 14436
		[RequiredField]
		[CheckForComponent(typeof(Rigidbody2D))]
		public FsmOwnerDefault gameObject;

		// Token: 0x04003865 RID: 14437
		[Tooltip("Offset the angle. If sprite faces right, leave as 0.")]
		public FsmFloat angleOffset;

		// Token: 0x04003866 RID: 14438
		public bool everyFrame;

		// Token: 0x04003867 RID: 14439
		private FsmGameObject target;
	}
}
