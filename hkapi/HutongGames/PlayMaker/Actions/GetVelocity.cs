using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000C24 RID: 3108
	[ActionCategory(ActionCategory.Physics)]
	[Tooltip("Gets the Velocity of a Game Object and stores it in a Vector3 Variable or each Axis in a Float Variable. NOTE: The Game Object must have a Rigid Body.")]
	public class GetVelocity : ComponentAction<Rigidbody>
	{
		// Token: 0x06004126 RID: 16678 RVA: 0x0016BCAD File Offset: 0x00169EAD
		public override void Reset()
		{
			this.gameObject = null;
			this.vector = null;
			this.x = null;
			this.y = null;
			this.z = null;
			this.space = Space.World;
			this.everyFrame = false;
		}

		// Token: 0x06004127 RID: 16679 RVA: 0x0016BCE0 File Offset: 0x00169EE0
		public override void OnEnter()
		{
			this.DoGetVelocity();
			if (!this.everyFrame)
			{
				base.Finish();
			}
		}

		// Token: 0x06004128 RID: 16680 RVA: 0x0016BCF6 File Offset: 0x00169EF6
		public override void OnUpdate()
		{
			this.DoGetVelocity();
		}

		// Token: 0x06004129 RID: 16681 RVA: 0x0016BD00 File Offset: 0x00169F00
		private void DoGetVelocity()
		{
			GameObject ownerDefaultTarget = base.Fsm.GetOwnerDefaultTarget(this.gameObject);
			if (!base.UpdateCache(ownerDefaultTarget))
			{
				return;
			}
			Vector3 vector = base.rigidbody.velocity;
			if (this.space == Space.Self)
			{
				vector = ownerDefaultTarget.transform.InverseTransformDirection(vector);
			}
			this.vector.Value = vector;
			this.x.Value = vector.x;
			this.y.Value = vector.y;
			this.z.Value = vector.z;
		}

		// Token: 0x0400456A RID: 17770
		[RequiredField]
		[CheckForComponent(typeof(Rigidbody))]
		public FsmOwnerDefault gameObject;

		// Token: 0x0400456B RID: 17771
		[UIHint(UIHint.Variable)]
		public FsmVector3 vector;

		// Token: 0x0400456C RID: 17772
		[UIHint(UIHint.Variable)]
		public FsmFloat x;

		// Token: 0x0400456D RID: 17773
		[UIHint(UIHint.Variable)]
		public FsmFloat y;

		// Token: 0x0400456E RID: 17774
		[UIHint(UIHint.Variable)]
		public FsmFloat z;

		// Token: 0x0400456F RID: 17775
		public Space space;

		// Token: 0x04004570 RID: 17776
		public bool everyFrame;
	}
}
