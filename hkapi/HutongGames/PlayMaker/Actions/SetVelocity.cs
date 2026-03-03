using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000CEA RID: 3306
	[ActionCategory(ActionCategory.Physics)]
	[Tooltip("Sets the Velocity of a Game Object. To leave any axis unchanged, set variable to 'None'. NOTE: Game object must have a rigidbody.")]
	public class SetVelocity : ComponentAction<Rigidbody>
	{
		// Token: 0x060044B7 RID: 17591 RVA: 0x00176A30 File Offset: 0x00174C30
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
			this.z = new FsmFloat
			{
				UseVariable = true
			};
			this.space = Space.Self;
			this.everyFrame = false;
		}

		// Token: 0x060044B8 RID: 17592 RVA: 0x00070581 File Offset: 0x0006E781
		public override void OnPreprocess()
		{
			base.Fsm.HandleFixedUpdate = true;
		}

		// Token: 0x060044B9 RID: 17593 RVA: 0x00176A8F File Offset: 0x00174C8F
		public override void OnEnter()
		{
			this.DoSetVelocity();
			if (!this.everyFrame)
			{
				base.Finish();
			}
		}

		// Token: 0x060044BA RID: 17594 RVA: 0x00176A8F File Offset: 0x00174C8F
		public override void OnFixedUpdate()
		{
			this.DoSetVelocity();
			if (!this.everyFrame)
			{
				base.Finish();
			}
		}

		// Token: 0x060044BB RID: 17595 RVA: 0x00176AA8 File Offset: 0x00174CA8
		private void DoSetVelocity()
		{
			GameObject ownerDefaultTarget = base.Fsm.GetOwnerDefaultTarget(this.gameObject);
			if (!base.UpdateCache(ownerDefaultTarget))
			{
				return;
			}
			Vector3 vector;
			if (this.vector.IsNone)
			{
				vector = ((this.space == Space.World) ? base.rigidbody.velocity : ownerDefaultTarget.transform.InverseTransformDirection(base.rigidbody.velocity));
			}
			else
			{
				vector = this.vector.Value;
			}
			if (!this.x.IsNone)
			{
				vector.x = this.x.Value;
			}
			if (!this.y.IsNone)
			{
				vector.y = this.y.Value;
			}
			if (!this.z.IsNone)
			{
				vector.z = this.z.Value;
			}
			base.rigidbody.velocity = ((this.space == Space.World) ? vector : ownerDefaultTarget.transform.TransformDirection(vector));
		}

		// Token: 0x040048FA RID: 18682
		[RequiredField]
		[CheckForComponent(typeof(Rigidbody))]
		public FsmOwnerDefault gameObject;

		// Token: 0x040048FB RID: 18683
		[UIHint(UIHint.Variable)]
		public FsmVector3 vector;

		// Token: 0x040048FC RID: 18684
		public FsmFloat x;

		// Token: 0x040048FD RID: 18685
		public FsmFloat y;

		// Token: 0x040048FE RID: 18686
		public FsmFloat z;

		// Token: 0x040048FF RID: 18687
		public Space space;

		// Token: 0x04004900 RID: 18688
		public bool everyFrame;
	}
}
