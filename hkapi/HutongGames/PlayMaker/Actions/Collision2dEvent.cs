using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000AC6 RID: 2758
	[ActionCategory(ActionCategory.Physics2D)]
	[Tooltip("Detect collisions between the Owner of this FSM and other Game Objects that have RigidBody2D components.\nNOTE: The system events, COLLISION ENTER 2D, COLLISION STAY 2D, and COLLISION EXIT 2D are sent automatically on collisions with any object. Use this action to filter collisions by Tag.")]
	public class Collision2dEvent : FsmStateAction
	{
		// Token: 0x06003B4F RID: 15183 RVA: 0x001563D1 File Offset: 0x001545D1
		public override void Reset()
		{
			this.collision = Collision2DType.OnCollisionEnter2D;
			this.collideTag = new FsmString
			{
				UseVariable = true
			};
			this.sendEvent = null;
			this.storeCollider = null;
			this.storeForce = null;
		}

		// Token: 0x06003B50 RID: 15184 RVA: 0x00156404 File Offset: 0x00154604
		public override void OnPreprocess()
		{
			switch (this.collision)
			{
			case Collision2DType.OnCollisionEnter2D:
				base.Fsm.HandleCollisionEnter2D = true;
				return;
			case Collision2DType.OnCollisionStay2D:
				base.Fsm.HandleCollisionStay2D = true;
				return;
			case Collision2DType.OnCollisionExit2D:
				base.Fsm.HandleCollisionExit2D = true;
				return;
			case Collision2DType.OnParticleCollision:
				base.Fsm.HandleParticleCollision = true;
				return;
			default:
				return;
			}
		}

		// Token: 0x06003B51 RID: 15185 RVA: 0x00156464 File Offset: 0x00154664
		private void StoreCollisionInfo(Collision2D collisionInfo)
		{
			this.storeCollider.Value = collisionInfo.gameObject;
			this.storeForce.Value = collisionInfo.relativeVelocity.magnitude;
		}

		// Token: 0x06003B52 RID: 15186 RVA: 0x0015649C File Offset: 0x0015469C
		public override void DoCollisionEnter2D(Collision2D collisionInfo)
		{
			if (this.collision == Collision2DType.OnCollisionEnter2D && (collisionInfo.collider.gameObject.tag == this.collideTag.Value || this.collideTag.IsNone || string.IsNullOrEmpty(this.collideTag.Value) || this.collideTag.Value == "Untagged"))
			{
				this.StoreCollisionInfo(collisionInfo);
				base.Fsm.Event(this.sendEvent);
			}
		}

		// Token: 0x06003B53 RID: 15187 RVA: 0x00156524 File Offset: 0x00154724
		public override void DoCollisionStay2D(Collision2D collisionInfo)
		{
			if (this.collision == Collision2DType.OnCollisionStay2D && (collisionInfo.collider.gameObject.tag == this.collideTag.Value || this.collideTag.IsNone || string.IsNullOrEmpty(this.collideTag.Value) || this.collideTag.Value == "Untagged"))
			{
				this.StoreCollisionInfo(collisionInfo);
				base.Fsm.Event(this.sendEvent);
			}
		}

		// Token: 0x06003B54 RID: 15188 RVA: 0x001565AC File Offset: 0x001547AC
		public override void DoCollisionExit2D(Collision2D collisionInfo)
		{
			if (this.collision == Collision2DType.OnCollisionExit2D && (collisionInfo.collider.gameObject.tag == this.collideTag.Value || this.collideTag.IsNone || string.IsNullOrEmpty(this.collideTag.Value) || this.collideTag.Value == "Untagged"))
			{
				this.StoreCollisionInfo(collisionInfo);
				base.Fsm.Event(this.sendEvent);
			}
		}

		// Token: 0x06003B55 RID: 15189 RVA: 0x00156634 File Offset: 0x00154834
		public override void DoParticleCollision(GameObject other)
		{
			if (this.collision == Collision2DType.OnParticleCollision && other.tag == this.collideTag.Value)
			{
				if (this.storeCollider != null)
				{
					this.storeCollider.Value = other;
				}
				this.storeForce.Value = 0f;
				base.Fsm.Event(this.sendEvent);
			}
		}

		// Token: 0x06003B56 RID: 15190 RVA: 0x00156697 File Offset: 0x00154897
		public override string ErrorCheck()
		{
			return ActionHelpers.CheckOwnerPhysics2dSetup(base.Owner);
		}

		// Token: 0x04003EA8 RID: 16040
		[Tooltip("The type of collision to detect.")]
		public Collision2DType collision;

		// Token: 0x04003EA9 RID: 16041
		[UIHint(UIHint.Tag)]
		[Tooltip("Filter by Tag.")]
		public FsmString collideTag;

		// Token: 0x04003EAA RID: 16042
		[Tooltip("Event to send if a collision is detected.")]
		public FsmEvent sendEvent;

		// Token: 0x04003EAB RID: 16043
		[UIHint(UIHint.Variable)]
		[Tooltip("Store the GameObject that collided with the Owner of this FSM.")]
		public FsmGameObject storeCollider;

		// Token: 0x04003EAC RID: 16044
		[UIHint(UIHint.Variable)]
		[Tooltip("Store the force of the collision. NOTE: Use Get Collision 2D Info to get more info about the collision.")]
		public FsmFloat storeForce;
	}
}
