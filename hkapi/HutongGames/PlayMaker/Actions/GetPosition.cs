using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000C06 RID: 3078
	[ActionCategory(ActionCategory.Transform)]
	[Tooltip("Gets the Position of a Game Object and stores it in a Vector3 Variable or each Axis in a Float Variable")]
	public class GetPosition : FsmStateAction
	{
		// Token: 0x060040A3 RID: 16547 RVA: 0x0016A9B4 File Offset: 0x00168BB4
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

		// Token: 0x060040A4 RID: 16548 RVA: 0x0016A9E7 File Offset: 0x00168BE7
		public override void OnEnter()
		{
			this.DoGetPosition();
			if (!this.everyFrame)
			{
				base.Finish();
			}
		}

		// Token: 0x060040A5 RID: 16549 RVA: 0x0016A9FD File Offset: 0x00168BFD
		public override void OnUpdate()
		{
			this.DoGetPosition();
		}

		// Token: 0x060040A6 RID: 16550 RVA: 0x0016AA08 File Offset: 0x00168C08
		private void DoGetPosition()
		{
			GameObject ownerDefaultTarget = base.Fsm.GetOwnerDefaultTarget(this.gameObject);
			if (ownerDefaultTarget == null)
			{
				return;
			}
			Vector3 vector = (this.space == Space.World) ? ownerDefaultTarget.transform.position : ownerDefaultTarget.transform.localPosition;
			this.vector.Value = vector;
			this.x.Value = vector.x;
			this.y.Value = vector.y;
			this.z.Value = vector.z;
		}

		// Token: 0x040044F2 RID: 17650
		[RequiredField]
		public FsmOwnerDefault gameObject;

		// Token: 0x040044F3 RID: 17651
		[UIHint(UIHint.Variable)]
		public FsmVector3 vector;

		// Token: 0x040044F4 RID: 17652
		[UIHint(UIHint.Variable)]
		public FsmFloat x;

		// Token: 0x040044F5 RID: 17653
		[UIHint(UIHint.Variable)]
		public FsmFloat y;

		// Token: 0x040044F6 RID: 17654
		[UIHint(UIHint.Variable)]
		public FsmFloat z;

		// Token: 0x040044F7 RID: 17655
		public Space space;

		// Token: 0x040044F8 RID: 17656
		public bool everyFrame;
	}
}
