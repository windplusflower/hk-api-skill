using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000A3A RID: 2618
	[ActionCategory("Physics 2d")]
	[Tooltip("Sets the Angular Velocity of a Game Object. NOTE: Game object must have a rigidbody 2D.")]
	public class SetAngularVelocity2d : RigidBody2dActionBase
	{
		// Token: 0x060038CB RID: 14539 RVA: 0x0014C678 File Offset: 0x0014A878
		public override void Reset()
		{
			this.angularVelocity = null;
			this.everyFrame = false;
		}

		// Token: 0x060038CC RID: 14540 RVA: 0x00070581 File Offset: 0x0006E781
		public override void Awake()
		{
			base.Fsm.HandleFixedUpdate = true;
		}

		// Token: 0x060038CD RID: 14541 RVA: 0x00070581 File Offset: 0x0006E781
		public override void OnPreprocess()
		{
			base.Fsm.HandleFixedUpdate = true;
		}

		// Token: 0x060038CE RID: 14542 RVA: 0x0014C688 File Offset: 0x0014A888
		public override void OnEnter()
		{
			base.CacheRigidBody2d(base.Fsm.GetOwnerDefaultTarget(this.gameObject));
			this.DoSetVelocity();
			if (!this.everyFrame)
			{
				base.Finish();
			}
		}

		// Token: 0x060038CF RID: 14543 RVA: 0x0014C6B5 File Offset: 0x0014A8B5
		public override void OnFixedUpdate()
		{
			this.DoSetVelocity();
			if (!this.everyFrame)
			{
				base.Finish();
			}
		}

		// Token: 0x060038D0 RID: 14544 RVA: 0x0014C6CB File Offset: 0x0014A8CB
		private void DoSetVelocity()
		{
			if (this.rb2d == null)
			{
				return;
			}
			if (!this.angularVelocity.IsNone)
			{
				this.rb2d.angularVelocity = this.angularVelocity.Value;
			}
		}

		// Token: 0x04003B79 RID: 15225
		[RequiredField]
		[CheckForComponent(typeof(Rigidbody2D))]
		public FsmOwnerDefault gameObject;

		// Token: 0x04003B7A RID: 15226
		public FsmFloat angularVelocity;

		// Token: 0x04003B7B RID: 15227
		public bool everyFrame;
	}
}
