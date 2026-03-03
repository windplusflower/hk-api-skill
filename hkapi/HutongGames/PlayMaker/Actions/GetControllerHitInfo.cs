using System;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000BD8 RID: 3032
	[ActionCategory(ActionCategory.Character)]
	[Tooltip("Gets info on the last Character Controller collision and store in variables.")]
	public class GetControllerHitInfo : FsmStateAction
	{
		// Token: 0x06003FDA RID: 16346 RVA: 0x001688FD File Offset: 0x00166AFD
		public override void Reset()
		{
			this.gameObjectHit = null;
			this.contactPoint = null;
			this.contactNormal = null;
			this.moveDirection = null;
			this.moveLength = null;
			this.physicsMaterialName = null;
		}

		// Token: 0x06003FDB RID: 16347 RVA: 0x00168929 File Offset: 0x00166B29
		public override void OnPreprocess()
		{
			base.Fsm.HandleControllerColliderHit = true;
		}

		// Token: 0x06003FDC RID: 16348 RVA: 0x00168938 File Offset: 0x00166B38
		private void StoreTriggerInfo()
		{
			if (base.Fsm.ControllerCollider == null)
			{
				return;
			}
			this.gameObjectHit.Value = base.Fsm.ControllerCollider.gameObject;
			this.contactPoint.Value = base.Fsm.ControllerCollider.point;
			this.contactNormal.Value = base.Fsm.ControllerCollider.normal;
			this.moveDirection.Value = base.Fsm.ControllerCollider.moveDirection;
			this.moveLength.Value = base.Fsm.ControllerCollider.moveLength;
			this.physicsMaterialName.Value = base.Fsm.ControllerCollider.collider.material.name;
		}

		// Token: 0x06003FDD RID: 16349 RVA: 0x001689FF File Offset: 0x00166BFF
		public override void OnEnter()
		{
			this.StoreTriggerInfo();
			base.Finish();
		}

		// Token: 0x06003FDE RID: 16350 RVA: 0x001621B3 File Offset: 0x001603B3
		public override string ErrorCheck()
		{
			return ActionHelpers.CheckOwnerPhysicsSetup(base.Owner);
		}

		// Token: 0x0400440D RID: 17421
		[UIHint(UIHint.Variable)]
		[Tooltip("Store the GameObject hit in the last collision.")]
		public FsmGameObject gameObjectHit;

		// Token: 0x0400440E RID: 17422
		[UIHint(UIHint.Variable)]
		[Tooltip("Store the contact point of the last collision in world coordinates.")]
		public FsmVector3 contactPoint;

		// Token: 0x0400440F RID: 17423
		[UIHint(UIHint.Variable)]
		[Tooltip("Store the normal of the last collision.")]
		public FsmVector3 contactNormal;

		// Token: 0x04004410 RID: 17424
		[UIHint(UIHint.Variable)]
		[Tooltip("Store the direction of the last move before the collision.")]
		public FsmVector3 moveDirection;

		// Token: 0x04004411 RID: 17425
		[UIHint(UIHint.Variable)]
		[Tooltip("Store the distance of the last move before the collision.")]
		public FsmFloat moveLength;

		// Token: 0x04004412 RID: 17426
		[UIHint(UIHint.Variable)]
		[Tooltip("Store the physics material of the Game Object Hit. Useful for triggering different effects. Audio, particles...")]
		public FsmString physicsMaterialName;
	}
}
