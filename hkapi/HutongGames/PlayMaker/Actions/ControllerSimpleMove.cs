using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000B4D RID: 2893
	[ActionCategory(ActionCategory.Character)]
	[Tooltip("Moves a Game Object with a Character Controller. Velocity along the y-axis is ignored. Speed is in meters/s. Gravity is automatically applied.")]
	public class ControllerSimpleMove : FsmStateAction
	{
		// Token: 0x06003DCE RID: 15822 RVA: 0x00162A6D File Offset: 0x00160C6D
		public override void Reset()
		{
			this.gameObject = null;
			this.moveVector = new FsmVector3
			{
				UseVariable = true
			};
			this.speed = 1f;
			this.space = Space.World;
		}

		// Token: 0x06003DCF RID: 15823 RVA: 0x00162AA0 File Offset: 0x00160CA0
		public override void OnUpdate()
		{
			GameObject ownerDefaultTarget = base.Fsm.GetOwnerDefaultTarget(this.gameObject);
			if (ownerDefaultTarget == null)
			{
				return;
			}
			if (ownerDefaultTarget != this.previousGo)
			{
				this.controller = ownerDefaultTarget.GetComponent<CharacterController>();
				this.previousGo = ownerDefaultTarget;
			}
			if (this.controller != null)
			{
				Vector3 a = (this.space == Space.World) ? this.moveVector.Value : ownerDefaultTarget.transform.TransformDirection(this.moveVector.Value);
				this.controller.SimpleMove(a * this.speed.Value);
			}
		}

		// Token: 0x040041EB RID: 16875
		[RequiredField]
		[CheckForComponent(typeof(CharacterController))]
		[Tooltip("The GameObject to move.")]
		public FsmOwnerDefault gameObject;

		// Token: 0x040041EC RID: 16876
		[RequiredField]
		[Tooltip("The movement vector.")]
		public FsmVector3 moveVector;

		// Token: 0x040041ED RID: 16877
		[Tooltip("Multiply the movement vector by a speed factor.")]
		public FsmFloat speed;

		// Token: 0x040041EE RID: 16878
		[Tooltip("Move in local or word space.")]
		public Space space;

		// Token: 0x040041EF RID: 16879
		private GameObject previousGo;

		// Token: 0x040041F0 RID: 16880
		private CharacterController controller;
	}
}
