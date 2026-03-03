using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000AF5 RID: 2805
	[ActionCategory(ActionCategory.Physics)]
	[Tooltip("Adds torque (rotational force) to a Game Object.")]
	public class AddTorque : ComponentAction<Rigidbody>
	{
		// Token: 0x06003C36 RID: 15414 RVA: 0x0015A4F4 File Offset: 0x001586F4
		public override void Reset()
		{
			this.gameObject = null;
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

		// Token: 0x06003C37 RID: 15415 RVA: 0x00070581 File Offset: 0x0006E781
		public override void OnPreprocess()
		{
			base.Fsm.HandleFixedUpdate = true;
		}

		// Token: 0x06003C38 RID: 15416 RVA: 0x0015A553 File Offset: 0x00158753
		public override void OnEnter()
		{
			this.DoAddTorque();
			if (!this.everyFrame)
			{
				base.Finish();
			}
		}

		// Token: 0x06003C39 RID: 15417 RVA: 0x0015A569 File Offset: 0x00158769
		public override void OnFixedUpdate()
		{
			this.DoAddTorque();
		}

		// Token: 0x06003C3A RID: 15418 RVA: 0x0015A574 File Offset: 0x00158774
		private void DoAddTorque()
		{
			GameObject ownerDefaultTarget = base.Fsm.GetOwnerDefaultTarget(this.gameObject);
			if (!base.UpdateCache(ownerDefaultTarget))
			{
				return;
			}
			Vector3 torque = this.vector.IsNone ? new Vector3(this.x.Value, this.y.Value, this.z.Value) : this.vector.Value;
			if (!this.x.IsNone)
			{
				torque.x = this.x.Value;
			}
			if (!this.y.IsNone)
			{
				torque.y = this.y.Value;
			}
			if (!this.z.IsNone)
			{
				torque.z = this.z.Value;
			}
			if (this.space == Space.World)
			{
				base.rigidbody.AddTorque(torque, this.forceMode);
				return;
			}
			base.rigidbody.AddRelativeTorque(torque, this.forceMode);
		}

		// Token: 0x04003FE1 RID: 16353
		[RequiredField]
		[CheckForComponent(typeof(Rigidbody))]
		[Tooltip("The GameObject to add torque to.")]
		public FsmOwnerDefault gameObject;

		// Token: 0x04003FE2 RID: 16354
		[UIHint(UIHint.Variable)]
		[Tooltip("A Vector3 torque. Optionally override any axis with the X, Y, Z parameters.")]
		public FsmVector3 vector;

		// Token: 0x04003FE3 RID: 16355
		[Tooltip("Torque around the X axis. To leave unchanged, set to 'None'.")]
		public FsmFloat x;

		// Token: 0x04003FE4 RID: 16356
		[Tooltip("Torque around the Y axis. To leave unchanged, set to 'None'.")]
		public FsmFloat y;

		// Token: 0x04003FE5 RID: 16357
		[Tooltip("Torque around the Z axis. To leave unchanged, set to 'None'.")]
		public FsmFloat z;

		// Token: 0x04003FE6 RID: 16358
		[Tooltip("Apply the force in world or local space.")]
		public Space space;

		// Token: 0x04003FE7 RID: 16359
		[Tooltip("The type of force to apply. See Unity Physics docs.")]
		public ForceMode forceMode;

		// Token: 0x04003FE8 RID: 16360
		[Tooltip("Repeat every frame while the state is active.")]
		public bool everyFrame;
	}
}
