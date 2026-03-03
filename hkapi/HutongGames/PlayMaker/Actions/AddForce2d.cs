using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000AC4 RID: 2756
	[ActionCategory(ActionCategory.Physics2D)]
	[Tooltip("Adds a 2d force to a Game Object. Use Vector2 variable and/or Float variables for each axis.")]
	public class AddForce2d : ComponentAction<Rigidbody2D>
	{
		// Token: 0x06003B43 RID: 15171 RVA: 0x001561B0 File Offset: 0x001543B0
		public override void Reset()
		{
			this.gameObject = null;
			this.atPosition = new FsmVector2
			{
				UseVariable = true
			};
			this.forceMode = ForceMode2D.Force;
			this.vector = null;
			this.vector3 = new FsmVector3
			{
				UseVariable = true
			};
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

		// Token: 0x06003B44 RID: 15172 RVA: 0x00070581 File Offset: 0x0006E781
		public override void OnPreprocess()
		{
			base.Fsm.HandleFixedUpdate = true;
		}

		// Token: 0x06003B45 RID: 15173 RVA: 0x00156221 File Offset: 0x00154421
		public override void OnEnter()
		{
			this.DoAddForce();
			if (!this.everyFrame)
			{
				base.Finish();
			}
		}

		// Token: 0x06003B46 RID: 15174 RVA: 0x00156237 File Offset: 0x00154437
		public override void OnFixedUpdate()
		{
			this.DoAddForce();
		}

		// Token: 0x06003B47 RID: 15175 RVA: 0x00156240 File Offset: 0x00154440
		private void DoAddForce()
		{
			GameObject ownerDefaultTarget = base.Fsm.GetOwnerDefaultTarget(this.gameObject);
			if (!base.UpdateCache(ownerDefaultTarget))
			{
				return;
			}
			Vector2 force = this.vector.IsNone ? new Vector2(this.x.Value, this.y.Value) : this.vector.Value;
			if (!this.vector3.IsNone)
			{
				force.x = this.vector3.Value.x;
				force.y = this.vector3.Value.y;
			}
			if (!this.x.IsNone)
			{
				force.x = this.x.Value;
			}
			if (!this.y.IsNone)
			{
				force.y = this.y.Value;
			}
			if (!this.atPosition.IsNone)
			{
				base.rigidbody2d.AddForceAtPosition(force, this.atPosition.Value, this.forceMode);
				return;
			}
			base.rigidbody2d.AddForce(force, this.forceMode);
		}

		// Token: 0x04003E9C RID: 16028
		[RequiredField]
		[CheckForComponent(typeof(Rigidbody2D))]
		[Tooltip("The GameObject to apply the force to.")]
		public FsmOwnerDefault gameObject;

		// Token: 0x04003E9D RID: 16029
		[Tooltip("Option for applying the force")]
		public ForceMode2D forceMode;

		// Token: 0x04003E9E RID: 16030
		[UIHint(UIHint.Variable)]
		[Tooltip("Optionally apply the force at a position on the object. This will also add some torque. The position is often returned from MousePick or GetCollision2dInfo actions.")]
		public FsmVector2 atPosition;

		// Token: 0x04003E9F RID: 16031
		[UIHint(UIHint.Variable)]
		[Tooltip("A Vector2 force to add. Optionally override any axis with the X, Y parameters.")]
		public FsmVector2 vector;

		// Token: 0x04003EA0 RID: 16032
		[Tooltip("Force along the X axis. To leave unchanged, set to 'None'.")]
		public FsmFloat x;

		// Token: 0x04003EA1 RID: 16033
		[Tooltip("Force along the Y axis. To leave unchanged, set to 'None'.")]
		public FsmFloat y;

		// Token: 0x04003EA2 RID: 16034
		[Tooltip("A Vector3 force to add. z is ignored")]
		public FsmVector3 vector3;

		// Token: 0x04003EA3 RID: 16035
		[Tooltip("Repeat every frame while the state is active.")]
		public bool everyFrame;
	}
}
