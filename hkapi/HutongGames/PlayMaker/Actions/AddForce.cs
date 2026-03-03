using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000AF2 RID: 2802
	[ActionCategory(ActionCategory.Physics)]
	[Tooltip("Adds a force to a Game Object. Use Vector3 variable and/or Float variables for each axis.")]
	public class AddForce : ComponentAction<Rigidbody>
	{
		// Token: 0x06003C27 RID: 15399 RVA: 0x0015A1D8 File Offset: 0x001583D8
		public override void Reset()
		{
			this.gameObject = null;
			this.atPosition = new FsmVector3
			{
				UseVariable = true
			};
			this.vector = null;
			this.x = new FsmFloat
			{
				UseVariable = true
			};
			this.y = new FsmFloat
			{
				UseVariable = true
			};
			this.z = new FsmFloat
			{
				UseVariable = true
			};
			this.space = Space.World;
			this.forceMode = ForceMode.Force;
			this.everyFrame = false;
		}

		// Token: 0x06003C28 RID: 15400 RVA: 0x00070581 File Offset: 0x0006E781
		public override void OnPreprocess()
		{
			base.Fsm.HandleFixedUpdate = true;
		}

		// Token: 0x06003C29 RID: 15401 RVA: 0x0015A250 File Offset: 0x00158450
		public override void OnEnter()
		{
			this.DoAddForce();
			if (!this.everyFrame)
			{
				base.Finish();
			}
		}

		// Token: 0x06003C2A RID: 15402 RVA: 0x0015A266 File Offset: 0x00158466
		public override void OnFixedUpdate()
		{
			this.DoAddForce();
		}

		// Token: 0x06003C2B RID: 15403 RVA: 0x0015A270 File Offset: 0x00158470
		private void DoAddForce()
		{
			GameObject ownerDefaultTarget = base.Fsm.GetOwnerDefaultTarget(this.gameObject);
			if (!base.UpdateCache(ownerDefaultTarget))
			{
				return;
			}
			Vector3 force = this.vector.IsNone ? default(Vector3) : this.vector.Value;
			if (!this.x.IsNone)
			{
				force.x = this.x.Value;
			}
			if (!this.y.IsNone)
			{
				force.y = this.y.Value;
			}
			if (!this.z.IsNone)
			{
				force.z = this.z.Value;
			}
			if (this.space != Space.World)
			{
				base.rigidbody.AddRelativeForce(force, this.forceMode);
				return;
			}
			if (!this.atPosition.IsNone)
			{
				base.rigidbody.AddForceAtPosition(force, this.atPosition.Value, this.forceMode);
				return;
			}
			base.rigidbody.AddForce(force, this.forceMode);
		}

		// Token: 0x04003FD0 RID: 16336
		[RequiredField]
		[CheckForComponent(typeof(Rigidbody))]
		[Tooltip("The GameObject to apply the force to.")]
		public FsmOwnerDefault gameObject;

		// Token: 0x04003FD1 RID: 16337
		[UIHint(UIHint.Variable)]
		[Tooltip("Optionally apply the force at a position on the object. This will also add some torque. The position is often returned from MousePick or GetCollisionInfo actions.")]
		public FsmVector3 atPosition;

		// Token: 0x04003FD2 RID: 16338
		[UIHint(UIHint.Variable)]
		[Tooltip("A Vector3 force to add. Optionally override any axis with the X, Y, Z parameters.")]
		public FsmVector3 vector;

		// Token: 0x04003FD3 RID: 16339
		[Tooltip("Force along the X axis. To leave unchanged, set to 'None'.")]
		public FsmFloat x;

		// Token: 0x04003FD4 RID: 16340
		[Tooltip("Force along the Y axis. To leave unchanged, set to 'None'.")]
		public FsmFloat y;

		// Token: 0x04003FD5 RID: 16341
		[Tooltip("Force along the Z axis. To leave unchanged, set to 'None'.")]
		public FsmFloat z;

		// Token: 0x04003FD6 RID: 16342
		[Tooltip("Apply the force in world or local space.")]
		public Space space;

		// Token: 0x04003FD7 RID: 16343
		[Tooltip("The type of force to apply. See Unity Physics docs.")]
		public ForceMode forceMode;

		// Token: 0x04003FD8 RID: 16344
		[Tooltip("Repeat every frame while the state is active.")]
		public bool everyFrame;
	}
}
