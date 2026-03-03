using System;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000AC7 RID: 2759
	[ActionCategory(ActionCategory.Physics2D)]
	[Tooltip("Gets info on the last collision 2D event and store in variables. See Unity and PlayMaker docs on Unity 2D physics.")]
	public class GetCollision2dInfo : FsmStateAction
	{
		// Token: 0x06003B58 RID: 15192 RVA: 0x001566A4 File Offset: 0x001548A4
		public override void Reset()
		{
			this.gameObjectHit = null;
			this.relativeVelocity = null;
			this.relativeSpeed = null;
			this.contactPoint = null;
			this.contactNormal = null;
			this.shapeCount = null;
			this.physics2dMaterialName = null;
		}

		// Token: 0x06003B59 RID: 15193 RVA: 0x001566D8 File Offset: 0x001548D8
		private void StoreCollisionInfo()
		{
			if (base.Fsm.Collision2DInfo == null)
			{
				return;
			}
			this.gameObjectHit.Value = base.Fsm.Collision2DInfo.gameObject;
			this.relativeSpeed.Value = base.Fsm.Collision2DInfo.relativeVelocity.magnitude;
			this.relativeVelocity.Value = base.Fsm.Collision2DInfo.relativeVelocity;
			this.physics2dMaterialName.Value = ((base.Fsm.Collision2DInfo.collider.sharedMaterial != null) ? base.Fsm.Collision2DInfo.collider.sharedMaterial.name : "");
			this.shapeCount.Value = base.Fsm.Collision2DInfo.collider.shapeCount;
			if (base.Fsm.Collision2DInfo.contacts != null && base.Fsm.Collision2DInfo.contacts.Length != 0)
			{
				this.contactPoint.Value = base.Fsm.Collision2DInfo.contacts[0].point;
				this.contactNormal.Value = base.Fsm.Collision2DInfo.contacts[0].normal;
			}
		}

		// Token: 0x06003B5A RID: 15194 RVA: 0x00156835 File Offset: 0x00154A35
		public override void OnEnter()
		{
			this.StoreCollisionInfo();
			base.Finish();
		}

		// Token: 0x04003EAD RID: 16045
		[UIHint(UIHint.Variable)]
		[Tooltip("Get the GameObject hit.")]
		public FsmGameObject gameObjectHit;

		// Token: 0x04003EAE RID: 16046
		[UIHint(UIHint.Variable)]
		[Tooltip("Get the relative velocity of the collision.")]
		public FsmVector3 relativeVelocity;

		// Token: 0x04003EAF RID: 16047
		[UIHint(UIHint.Variable)]
		[Tooltip("Get the relative speed of the collision. Useful for controlling reactions. E.g., selecting an appropriate sound fx.")]
		public FsmFloat relativeSpeed;

		// Token: 0x04003EB0 RID: 16048
		[UIHint(UIHint.Variable)]
		[Tooltip("Get the world position of the collision contact. Useful for spawning effects etc.")]
		public FsmVector3 contactPoint;

		// Token: 0x04003EB1 RID: 16049
		[UIHint(UIHint.Variable)]
		[Tooltip("Get the collision normal vector. Useful for aligning spawned effects etc.")]
		public FsmVector3 contactNormal;

		// Token: 0x04003EB2 RID: 16050
		[UIHint(UIHint.Variable)]
		[Tooltip("The number of separate shaped regions in the collider.")]
		public FsmInt shapeCount;

		// Token: 0x04003EB3 RID: 16051
		[UIHint(UIHint.Variable)]
		[Tooltip("Get the name of the physics 2D material of the colliding GameObject. Useful for triggering different effects. Audio, particles...")]
		public FsmString physics2dMaterialName;
	}
}
