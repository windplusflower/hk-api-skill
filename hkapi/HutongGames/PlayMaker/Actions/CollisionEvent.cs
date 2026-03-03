using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000B44 RID: 2884
	[ActionCategory(ActionCategory.Physics)]
	[Tooltip("Detect collisions between the Owner of this FSM and other Game Objects that have RigidBody components.\nNOTE: The system events, COLLISION ENTER, COLLISION STAY, and COLLISION EXIT are sent automatically on collisions with any object. Use this action to filter collisions by Tag.")]
	public class CollisionEvent : FsmStateAction
	{
		// Token: 0x06003D9D RID: 15773 RVA: 0x00161F13 File Offset: 0x00160113
		public override void Reset()
		{
			this.collision = CollisionType.OnCollisionEnter;
			this.collideTag = "Untagged";
			this.sendEvent = null;
			this.storeCollider = null;
			this.storeForce = null;
		}

		// Token: 0x06003D9E RID: 15774 RVA: 0x00161F44 File Offset: 0x00160144
		public override void OnPreprocess()
		{
			switch (this.collision)
			{
			case CollisionType.OnCollisionEnter:
				base.Fsm.HandleCollisionEnter = true;
				return;
			case CollisionType.OnCollisionStay:
				base.Fsm.HandleCollisionStay = true;
				return;
			case CollisionType.OnCollisionExit:
				base.Fsm.HandleCollisionExit = true;
				return;
			case CollisionType.OnControllerColliderHit:
				base.Fsm.HandleControllerColliderHit = true;
				return;
			case CollisionType.OnParticleCollision:
				base.Fsm.HandleParticleCollision = true;
				return;
			default:
				return;
			}
		}

		// Token: 0x06003D9F RID: 15775 RVA: 0x00161FB4 File Offset: 0x001601B4
		private void StoreCollisionInfo(Collision collisionInfo)
		{
			this.storeCollider.Value = collisionInfo.gameObject;
			this.storeForce.Value = collisionInfo.relativeVelocity.magnitude;
		}

		// Token: 0x06003DA0 RID: 15776 RVA: 0x00161FEC File Offset: 0x001601EC
		public override void DoCollisionEnter(Collision collisionInfo)
		{
			if (this.collision == CollisionType.OnCollisionEnter && collisionInfo.collider.gameObject.tag == this.collideTag.Value)
			{
				this.StoreCollisionInfo(collisionInfo);
				base.Fsm.Event(this.sendEvent);
			}
		}

		// Token: 0x06003DA1 RID: 15777 RVA: 0x0016203C File Offset: 0x0016023C
		public override void DoCollisionStay(Collision collisionInfo)
		{
			if (this.collision == CollisionType.OnCollisionStay && collisionInfo.collider.gameObject.tag == this.collideTag.Value)
			{
				this.StoreCollisionInfo(collisionInfo);
				base.Fsm.Event(this.sendEvent);
			}
		}

		// Token: 0x06003DA2 RID: 15778 RVA: 0x0016208C File Offset: 0x0016028C
		public override void DoCollisionExit(Collision collisionInfo)
		{
			if (this.collision == CollisionType.OnCollisionExit && collisionInfo.collider.gameObject.tag == this.collideTag.Value)
			{
				this.StoreCollisionInfo(collisionInfo);
				base.Fsm.Event(this.sendEvent);
			}
		}

		// Token: 0x06003DA3 RID: 15779 RVA: 0x001620DC File Offset: 0x001602DC
		public override void DoControllerColliderHit(ControllerColliderHit collisionInfo)
		{
			if (this.collision == CollisionType.OnControllerColliderHit && collisionInfo.collider.gameObject.tag == this.collideTag.Value)
			{
				if (this.storeCollider != null)
				{
					this.storeCollider.Value = collisionInfo.gameObject;
				}
				this.storeForce.Value = 0f;
				base.Fsm.Event(this.sendEvent);
			}
		}

		// Token: 0x06003DA4 RID: 15780 RVA: 0x00162150 File Offset: 0x00160350
		public override void DoParticleCollision(GameObject other)
		{
			if (this.collision == CollisionType.OnParticleCollision && other.tag == this.collideTag.Value)
			{
				if (this.storeCollider != null)
				{
					this.storeCollider.Value = other;
				}
				this.storeForce.Value = 0f;
				base.Fsm.Event(this.sendEvent);
			}
		}

		// Token: 0x06003DA5 RID: 15781 RVA: 0x001621B3 File Offset: 0x001603B3
		public override string ErrorCheck()
		{
			return ActionHelpers.CheckOwnerPhysicsSetup(base.Owner);
		}

		// Token: 0x040041BC RID: 16828
		[Tooltip("The type of collision to detect.")]
		public CollisionType collision;

		// Token: 0x040041BD RID: 16829
		[UIHint(UIHint.Tag)]
		[Tooltip("Filter by Tag.")]
		public FsmString collideTag;

		// Token: 0x040041BE RID: 16830
		[Tooltip("Event to send if a collision is detected.")]
		public FsmEvent sendEvent;

		// Token: 0x040041BF RID: 16831
		[UIHint(UIHint.Variable)]
		[Tooltip("Store the GameObject that collided with the Owner of this FSM.")]
		public FsmGameObject storeCollider;

		// Token: 0x040041C0 RID: 16832
		[UIHint(UIHint.Variable)]
		[Tooltip("Store the force of the collision. NOTE: Use Get Collision Info to get more info about the collision.")]
		public FsmFloat storeForce;
	}
}
