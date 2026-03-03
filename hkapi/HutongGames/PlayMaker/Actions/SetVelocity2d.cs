using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000AE4 RID: 2788
	[ActionCategory(ActionCategory.Physics2D)]
	[Tooltip("Sets the 2d Velocity of a Game Object. To leave any axis unchanged, set variable to 'None'. NOTE: Game object must have a rigidbody 2D.")]
	public class SetVelocity2d : ComponentAction<Rigidbody2D>
	{
		// Token: 0x06003BE0 RID: 15328 RVA: 0x001590EB File Offset: 0x001572EB
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
			this.everyFrame = false;
		}

		// Token: 0x06003BE1 RID: 15329 RVA: 0x00070581 File Offset: 0x0006E781
		public override void Awake()
		{
			base.Fsm.HandleFixedUpdate = true;
		}

		// Token: 0x06003BE2 RID: 15330 RVA: 0x00159126 File Offset: 0x00157326
		public override void OnEnter()
		{
			this.DoSetVelocity();
			if (!this.everyFrame)
			{
				base.Finish();
			}
		}

		// Token: 0x06003BE3 RID: 15331 RVA: 0x00159126 File Offset: 0x00157326
		public override void OnFixedUpdate()
		{
			this.DoSetVelocity();
			if (!this.everyFrame)
			{
				base.Finish();
			}
		}

		// Token: 0x06003BE4 RID: 15332 RVA: 0x0015913C File Offset: 0x0015733C
		private void DoSetVelocity()
		{
			GameObject ownerDefaultTarget = base.Fsm.GetOwnerDefaultTarget(this.gameObject);
			if (!base.UpdateCache(ownerDefaultTarget))
			{
				return;
			}
			Vector2 velocity;
			if (this.vector.IsNone)
			{
				velocity = base.rigidbody2d.velocity;
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
			base.rigidbody2d.velocity = velocity;
		}

		// Token: 0x04003F8A RID: 16266
		[RequiredField]
		[CheckForComponent(typeof(Rigidbody2D))]
		[Tooltip("The GameObject with the Rigidbody2D attached")]
		public FsmOwnerDefault gameObject;

		// Token: 0x04003F8B RID: 16267
		[Tooltip("A Vector2 value for the velocity")]
		public FsmVector2 vector;

		// Token: 0x04003F8C RID: 16268
		[Tooltip("The y value of the velocity. Overrides 'Vector' x value if set")]
		public FsmFloat x;

		// Token: 0x04003F8D RID: 16269
		[Tooltip("The y value of the velocity. Overrides 'Vector' y value if set")]
		public FsmFloat y;

		// Token: 0x04003F8E RID: 16270
		[Tooltip("Repeat every frame.")]
		public bool everyFrame;
	}
}
