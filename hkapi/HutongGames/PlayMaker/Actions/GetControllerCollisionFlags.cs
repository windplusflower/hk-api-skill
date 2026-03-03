using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000BD7 RID: 3031
	[ActionCategory(ActionCategory.Character)]
	[Tooltip("Gets the Collision Flags from a Character Controller on a Game Object. Collision flags give you a broad overview of where the character collided with any other object.")]
	public class GetControllerCollisionFlags : FsmStateAction
	{
		// Token: 0x06003FD7 RID: 16343 RVA: 0x001687F4 File Offset: 0x001669F4
		public override void Reset()
		{
			this.gameObject = null;
			this.isGrounded = null;
			this.none = null;
			this.sides = null;
			this.above = null;
			this.below = null;
		}

		// Token: 0x06003FD8 RID: 16344 RVA: 0x00168820 File Offset: 0x00166A20
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
				this.isGrounded.Value = this.controller.isGrounded;
				this.none.Value = ((this.controller.collisionFlags & CollisionFlags.None) > CollisionFlags.None);
				this.sides.Value = ((this.controller.collisionFlags & CollisionFlags.Sides) > CollisionFlags.None);
				this.above.Value = ((this.controller.collisionFlags & CollisionFlags.Above) > CollisionFlags.None);
				this.below.Value = ((this.controller.collisionFlags & CollisionFlags.Below) > CollisionFlags.None);
			}
		}

		// Token: 0x04004405 RID: 17413
		[RequiredField]
		[CheckForComponent(typeof(CharacterController))]
		[Tooltip("The GameObject with a Character Controller component.")]
		public FsmOwnerDefault gameObject;

		// Token: 0x04004406 RID: 17414
		[UIHint(UIHint.Variable)]
		[Tooltip("True if the Character Controller capsule is on the ground")]
		public FsmBool isGrounded;

		// Token: 0x04004407 RID: 17415
		[UIHint(UIHint.Variable)]
		[Tooltip("True if no collisions in last move.")]
		public FsmBool none;

		// Token: 0x04004408 RID: 17416
		[UIHint(UIHint.Variable)]
		[Tooltip("True if the Character Controller capsule was hit on the sides.")]
		public FsmBool sides;

		// Token: 0x04004409 RID: 17417
		[UIHint(UIHint.Variable)]
		[Tooltip("True if the Character Controller capsule was hit from above.")]
		public FsmBool above;

		// Token: 0x0400440A RID: 17418
		[UIHint(UIHint.Variable)]
		[Tooltip("True if the Character Controller capsule was hit from below.")]
		public FsmBool below;

		// Token: 0x0400440B RID: 17419
		private GameObject previousGo;

		// Token: 0x0400440C RID: 17420
		private CharacterController controller;
	}
}
