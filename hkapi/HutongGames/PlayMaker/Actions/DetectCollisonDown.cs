using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x020009B4 RID: 2484
	[ActionCategory("Physics 2d")]
	[Tooltip("Detect 2D collisions between the Owner of this FSM and other Game Objects that have RigidBody2D components.\nNOTE: The system events, COLLISION ENTER 2D, COLLISION STAY 2D, and COLLISION EXIT 2D are sent automatically on collisions with any object. Use this action to filter collisions by Tag.")]
	public class DetectCollisonDown : FsmStateAction
	{
		// Token: 0x0600365A RID: 13914 RVA: 0x00140740 File Offset: 0x0013E940
		public override void Reset()
		{
			this.collision = PlayMakerUnity2d.Collision2DType.OnCollisionEnter2D;
			this.collideTag = new FsmString
			{
				UseVariable = true
			};
			this.sendEvent = null;
			this.storeCollider = null;
			this.storeForce = null;
		}

		// Token: 0x0600365B RID: 13915 RVA: 0x00140770 File Offset: 0x0013E970
		public override void OnEnter()
		{
			this._proxy = base.Owner.GetComponent<PlayMakerUnity2DProxy>();
			if (this._proxy == null)
			{
				this._proxy = base.Owner.AddComponent<PlayMakerUnity2DProxy>();
			}
			switch (this.collision)
			{
			case PlayMakerUnity2d.Collision2DType.OnCollisionEnter2D:
				this._proxy.AddOnCollisionEnter2dDelegate(new PlayMakerUnity2DProxy.OnCollisionEnter2dDelegate(this.DoCollisionEnter2D));
				return;
			case PlayMakerUnity2d.Collision2DType.OnCollisionStay2D:
				this._proxy.AddOnCollisionStay2dDelegate(new PlayMakerUnity2DProxy.OnCollisionStay2dDelegate(this.DoCollisionStay2D));
				return;
			case PlayMakerUnity2d.Collision2DType.OnCollisionExit2D:
				this._proxy.AddOnCollisionExit2dDelegate(new PlayMakerUnity2DProxy.OnCollisionExit2dDelegate(this.DoCollisionExit2D));
				return;
			default:
				return;
			}
		}

		// Token: 0x0600365C RID: 13916 RVA: 0x00140810 File Offset: 0x0013EA10
		public override void OnExit()
		{
			if (this._proxy == null)
			{
				return;
			}
			switch (this.collision)
			{
			case PlayMakerUnity2d.Collision2DType.OnCollisionEnter2D:
				this._proxy.RemoveOnCollisionEnter2dDelegate(new PlayMakerUnity2DProxy.OnCollisionEnter2dDelegate(this.DoCollisionEnter2D));
				return;
			case PlayMakerUnity2d.Collision2DType.OnCollisionStay2D:
				this._proxy.RemoveOnCollisionStay2dDelegate(new PlayMakerUnity2DProxy.OnCollisionStay2dDelegate(this.DoCollisionStay2D));
				return;
			case PlayMakerUnity2d.Collision2DType.OnCollisionExit2D:
				this._proxy.RemoveOnCollisionExit2dDelegate(new PlayMakerUnity2DProxy.OnCollisionExit2dDelegate(this.DoCollisionExit2D));
				return;
			default:
				return;
			}
		}

		// Token: 0x0600365D RID: 13917 RVA: 0x00140890 File Offset: 0x0013EA90
		private void StoreCollisionInfo(Collision2D collisionInfo)
		{
			this.storeCollider.Value = collisionInfo.gameObject;
			this.storeForce.Value = collisionInfo.relativeVelocity.magnitude;
		}

		// Token: 0x0600365E RID: 13918 RVA: 0x001408C8 File Offset: 0x0013EAC8
		public new void DoCollisionEnter2D(Collision2D collisionInfo)
		{
			if (this.collision == PlayMakerUnity2d.Collision2DType.OnCollisionEnter2D && (collisionInfo.collider.gameObject.tag == this.collideTag.Value || this.collideTag.IsNone || string.IsNullOrEmpty(this.collideTag.Value)))
			{
				this.StoreCollisionInfo(collisionInfo);
				base.Fsm.Event(this.sendEvent);
			}
		}

		// Token: 0x0600365F RID: 13919 RVA: 0x00140938 File Offset: 0x0013EB38
		public new void DoCollisionStay2D(Collision2D collisionInfo)
		{
			if (this.collision == PlayMakerUnity2d.Collision2DType.OnCollisionStay2D && (collisionInfo.collider.gameObject.tag == this.collideTag.Value || this.collideTag.IsNone || string.IsNullOrEmpty(this.collideTag.Value)))
			{
				this.StoreCollisionInfo(collisionInfo);
				base.Fsm.Event(this.sendEvent);
			}
		}

		// Token: 0x06003660 RID: 13920 RVA: 0x001409A8 File Offset: 0x0013EBA8
		public new void DoCollisionExit2D(Collision2D collisionInfo)
		{
			if (this.collision == PlayMakerUnity2d.Collision2DType.OnCollisionExit2D && (collisionInfo.collider.gameObject.tag == this.collideTag.Value || this.collideTag.IsNone || string.IsNullOrEmpty(this.collideTag.Value)))
			{
				this.StoreCollisionInfo(collisionInfo);
				base.Fsm.Event(this.sendEvent);
			}
		}

		// Token: 0x06003661 RID: 13921 RVA: 0x00140A18 File Offset: 0x0013EC18
		public override string ErrorCheck()
		{
			string text = string.Empty;
			if (base.Owner != null && base.Owner.GetComponent<Collider2D>() == null && base.Owner.GetComponent<Rigidbody2D>() == null)
			{
				text += "Owner requires a RigidBody2D or Collider2D!\n";
			}
			return text;
		}

		// Token: 0x04003827 RID: 14375
		[Tooltip("The type of collision to detect.")]
		public PlayMakerUnity2d.Collision2DType collision;

		// Token: 0x04003828 RID: 14376
		[UIHint(UIHint.Tag)]
		[Tooltip("Filter by Tag.")]
		public FsmString collideTag;

		// Token: 0x04003829 RID: 14377
		[RequiredField]
		[Tooltip("Event to send if a collision is detected.")]
		public FsmEvent sendEvent;

		// Token: 0x0400382A RID: 14378
		[UIHint(UIHint.Variable)]
		[Tooltip("Store the GameObject that collided with the Owner of this FSM.")]
		public FsmGameObject storeCollider;

		// Token: 0x0400382B RID: 14379
		[UIHint(UIHint.Variable)]
		[Tooltip("Store the force of the collision. NOTE: Use Get Collision Info to get more info about the collision.")]
		public FsmFloat storeForce;

		// Token: 0x0400382C RID: 14380
		private PlayMakerUnity2DProxy _proxy;
	}
}
