using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000AE5 RID: 2789
	[ActionCategory("Physics 2d")]
	[Tooltip("Sets the 2d Velocity of a Game Object. To leave any axis unchanged, set variable to 'None'. NOTE: Game object must have a rigidbody 2D. If the specified bool is true, ignore.")]
	public class SetVelocity2dIfFalse : RigidBody2dActionBase
	{
		// Token: 0x06003BE6 RID: 15334 RVA: 0x001591D8 File Offset: 0x001573D8
		public override void Reset()
		{
			this.gameObject = null;
			this.vector = null;
			this.x = new FsmFloat
			{
				UseVariable = true
			};
			this.y = new FsmFloat
			{
				UseVariable = true
			};
			this.checkBool = new FsmBool
			{
				UseVariable = true
			};
			this.everyFrame = false;
		}

		// Token: 0x06003BE7 RID: 15335 RVA: 0x00070581 File Offset: 0x0006E781
		public override void Awake()
		{
			base.Fsm.HandleFixedUpdate = true;
		}

		// Token: 0x06003BE8 RID: 15336 RVA: 0x00159230 File Offset: 0x00157430
		public override void OnEnter()
		{
			base.CacheRigidBody2d(base.Fsm.GetOwnerDefaultTarget(this.gameObject));
			this.DoSetVelocity();
			if (!this.everyFrame)
			{
				base.Finish();
			}
		}

		// Token: 0x06003BE9 RID: 15337 RVA: 0x0015925D File Offset: 0x0015745D
		public override void OnFixedUpdate()
		{
			this.DoSetVelocity();
			if (!this.everyFrame)
			{
				base.Finish();
			}
		}

		// Token: 0x06003BEA RID: 15338 RVA: 0x00159274 File Offset: 0x00157474
		private void DoSetVelocity()
		{
			if (this.rb2d == null)
			{
				return;
			}
			if (!this.checkBool.Value)
			{
				Vector2 velocity;
				if (this.vector.IsNone)
				{
					velocity = this.rb2d.velocity;
				}
				else
				{
					velocity = this.vector.Value;
				}
				if (!this.x.IsNone)
				{
					velocity.x = this.x.Value;
				}
				if (!this.y.IsNone)
				{
					velocity.y = this.y.Value;
				}
				this.rb2d.velocity = velocity;
				this.rb2d.angularVelocity = 3f;
			}
		}

		// Token: 0x04003F8F RID: 16271
		[RequiredField]
		[CheckForComponent(typeof(Rigidbody2D))]
		public FsmOwnerDefault gameObject;

		// Token: 0x04003F90 RID: 16272
		[UIHint(UIHint.Variable)]
		public FsmVector2 vector;

		// Token: 0x04003F91 RID: 16273
		public FsmFloat x;

		// Token: 0x04003F92 RID: 16274
		public FsmFloat y;

		// Token: 0x04003F93 RID: 16275
		public FsmBool checkBool;

		// Token: 0x04003F94 RID: 16276
		public bool everyFrame;
	}
}
