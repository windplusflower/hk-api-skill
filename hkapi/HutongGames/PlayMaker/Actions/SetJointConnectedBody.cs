using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000CC5 RID: 3269
	[ActionCategory(ActionCategory.Physics)]
	[Tooltip("Connect a joint to a game object.")]
	public class SetJointConnectedBody : FsmStateAction
	{
		// Token: 0x06004411 RID: 17425 RVA: 0x00174D2E File Offset: 0x00172F2E
		public override void Reset()
		{
			this.joint = null;
			this.rigidBody = null;
		}

		// Token: 0x06004412 RID: 17426 RVA: 0x00174D40 File Offset: 0x00172F40
		public override void OnEnter()
		{
			GameObject ownerDefaultTarget = base.Fsm.GetOwnerDefaultTarget(this.joint);
			if (ownerDefaultTarget != null)
			{
				Joint component = ownerDefaultTarget.GetComponent<Joint>();
				if (component != null)
				{
					component.connectedBody = ((this.rigidBody.Value == null) ? null : this.rigidBody.Value.GetComponent<Rigidbody>());
				}
			}
			base.Finish();
		}

		// Token: 0x0400486E RID: 18542
		[RequiredField]
		[CheckForComponent(typeof(Joint))]
		[Tooltip("The joint to connect. Requires a Joint component.")]
		public FsmOwnerDefault joint;

		// Token: 0x0400486F RID: 18543
		[CheckForComponent(typeof(Rigidbody))]
		[Tooltip("The game object to connect to the Joint. Set to none to connect the Joint to the world.")]
		public FsmGameObject rigidBody;
	}
}
