using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000B4B RID: 2891
	[ActionCategory(ActionCategory.Character)]
	[Tooltip("Moves a Game Object with a Character Controller. See also Controller Simple Move. NOTE: It is recommended that you make only one call to Move or SimpleMove per frame.")]
	public class ControllerMove : FsmStateAction
	{
		// Token: 0x06003DC6 RID: 15814 RVA: 0x001627B1 File Offset: 0x001609B1
		public override void Reset()
		{
			this.gameObject = null;
			this.moveVector = new FsmVector3
			{
				UseVariable = true
			};
			this.space = Space.World;
			this.perSecond = true;
		}

		// Token: 0x06003DC7 RID: 15815 RVA: 0x001627E0 File Offset: 0x001609E0
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
				Vector3 vector = (this.space == Space.World) ? this.moveVector.Value : ownerDefaultTarget.transform.TransformDirection(this.moveVector.Value);
				if (this.perSecond.Value)
				{
					this.controller.Move(vector * Time.deltaTime);
					return;
				}
				this.controller.Move(vector);
			}
		}

		// Token: 0x040041DB RID: 16859
		[RequiredField]
		[CheckForComponent(typeof(CharacterController))]
		[Tooltip("The GameObject to move.")]
		public FsmOwnerDefault gameObject;

		// Token: 0x040041DC RID: 16860
		[RequiredField]
		[Tooltip("The movement vector.")]
		public FsmVector3 moveVector;

		// Token: 0x040041DD RID: 16861
		[Tooltip("Move in local or word space.")]
		public Space space;

		// Token: 0x040041DE RID: 16862
		[Tooltip("Movement vector is defined in units per second. Makes movement frame rate independent.")]
		public FsmBool perSecond;

		// Token: 0x040041DF RID: 16863
		private GameObject previousGo;

		// Token: 0x040041E0 RID: 16864
		private CharacterController controller;
	}
}
