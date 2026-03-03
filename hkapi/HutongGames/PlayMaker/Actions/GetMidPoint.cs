using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x020009D7 RID: 2519
	[ActionCategory(ActionCategory.Transform)]
	[Tooltip("Gets the mid point between two objects")]
	public class GetMidPoint : FsmStateAction
	{
		// Token: 0x0600370C RID: 14092 RVA: 0x00144564 File Offset: 0x00142764
		public override void Reset()
		{
			this.gameObject = null;
			this.target = null;
			this.midPoint = null;
			this.everyFrame = false;
		}

		// Token: 0x0600370D RID: 14093 RVA: 0x00144582 File Offset: 0x00142782
		public override void OnEnter()
		{
			this.DoGetPosition();
			if (!this.everyFrame)
			{
				base.Finish();
			}
		}

		// Token: 0x0600370E RID: 14094 RVA: 0x00144598 File Offset: 0x00142798
		public override void OnUpdate()
		{
			this.DoGetPosition();
		}

		// Token: 0x0600370F RID: 14095 RVA: 0x001445A0 File Offset: 0x001427A0
		private void DoGetPosition()
		{
			GameObject ownerDefaultTarget = base.Fsm.GetOwnerDefaultTarget(this.gameObject);
			if (ownerDefaultTarget == null)
			{
				Debug.Log("lol");
				return;
			}
			Vector3 position = ownerDefaultTarget.transform.position;
			Vector3 position2 = this.target.Value.transform.position;
			Vector3 value = new Vector3(position.x + (position2.x - position.x) / 2f, position.y + (position2.y - position.y) / 2f, position.z + (position2.z - position.z) / 2f);
			this.midPoint.Value = value;
		}

		// Token: 0x04003927 RID: 14631
		[RequiredField]
		public FsmOwnerDefault gameObject;

		// Token: 0x04003928 RID: 14632
		public FsmGameObject target;

		// Token: 0x04003929 RID: 14633
		[UIHint(UIHint.Variable)]
		public FsmVector3 midPoint;

		// Token: 0x0400392A RID: 14634
		public bool everyFrame;
	}
}
