using System;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000BD4 RID: 3028
	[ActionCategory(ActionCategory.Physics)]
	[Tooltip("Gets info on the last collision event and store in variables. See Unity Physics docs.")]
	public class GetCollisionInfo : FsmStateAction
	{
		// Token: 0x06003FC9 RID: 16329 RVA: 0x00168549 File Offset: 0x00166749
		public override void Reset()
		{
			this.gameObjectHit = null;
			this.relativeVelocity = null;
			this.relativeSpeed = null;
			this.contactPoint = null;
			this.contactNormal = null;
			this.physicsMaterialName = null;
		}

		// Token: 0x06003FCA RID: 16330 RVA: 0x00168578 File Offset: 0x00166778
		private void StoreCollisionInfo()
		{
			if (base.Fsm.CollisionInfo == null)
			{
				return;
			}
			this.gameObjectHit.Value = base.Fsm.CollisionInfo.gameObject;
			this.relativeSpeed.Value = base.Fsm.CollisionInfo.relativeVelocity.magnitude;
			this.relativeVelocity.Value = base.Fsm.CollisionInfo.relativeVelocity;
			this.physicsMaterialName.Value = base.Fsm.CollisionInfo.collider.material.name;
			if (base.Fsm.CollisionInfo.contacts != null && base.Fsm.CollisionInfo.contacts.Length != 0)
			{
				this.contactPoint.Value = base.Fsm.CollisionInfo.contacts[0].point;
				this.contactNormal.Value = base.Fsm.CollisionInfo.contacts[0].normal;
			}
		}

		// Token: 0x06003FCB RID: 16331 RVA: 0x00168682 File Offset: 0x00166882
		public override void OnEnter()
		{
			this.StoreCollisionInfo();
			base.Finish();
		}

		// Token: 0x040043F6 RID: 17398
		[UIHint(UIHint.Variable)]
		[Tooltip("Get the GameObject hit.")]
		public FsmGameObject gameObjectHit;

		// Token: 0x040043F7 RID: 17399
		[UIHint(UIHint.Variable)]
		[Tooltip("Get the relative velocity of the collision.")]
		public FsmVector3 relativeVelocity;

		// Token: 0x040043F8 RID: 17400
		[UIHint(UIHint.Variable)]
		[Tooltip("Get the relative speed of the collision. Useful for controlling reactions. E.g., selecting an appropriate sound fx.")]
		public FsmFloat relativeSpeed;

		// Token: 0x040043F9 RID: 17401
		[UIHint(UIHint.Variable)]
		[Tooltip("Get the world position of the collision contact. Useful for spawning effects etc.")]
		public FsmVector3 contactPoint;

		// Token: 0x040043FA RID: 17402
		[UIHint(UIHint.Variable)]
		[Tooltip("Get the collision normal vector. Useful for aligning spawned effects etc.")]
		public FsmVector3 contactNormal;

		// Token: 0x040043FB RID: 17403
		[UIHint(UIHint.Variable)]
		[Tooltip("Get the name of the physics material of the colliding GameObject. Useful for triggering different effects. Audio, particles...")]
		public FsmString physicsMaterialName;
	}
}
