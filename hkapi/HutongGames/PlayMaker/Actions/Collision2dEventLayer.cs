using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x020008CB RID: 2251
	[ActionCategory("Physics 2d")]
	[Tooltip("Detect 2D collisions between the Owner of this FSM and other Game Objects that have RigidBody2D components.\nNOTE: The system events, COLLISION ENTER 2D, COLLISION STAY 2D, and COLLISION EXIT 2D are sent automatically on collisions with any object. Use this action to filter collisions by Tag.")]
	public class Collision2dEventLayer : FsmStateAction
	{
		// Token: 0x0600322C RID: 12844 RVA: 0x00130F2E File Offset: 0x0012F12E
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

		// Token: 0x0600322D RID: 12845 RVA: 0x00130F60 File Offset: 0x0012F160
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

		// Token: 0x0600322E RID: 12846 RVA: 0x00131000 File Offset: 0x0012F200
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

		// Token: 0x0600322F RID: 12847 RVA: 0x00131080 File Offset: 0x0012F280
		private void StoreCollisionInfo(Collision2D collisionInfo)
		{
			this.storeCollider.Value = collisionInfo.gameObject;
			this.storeForce.Value = collisionInfo.relativeVelocity.magnitude;
		}

		// Token: 0x06003230 RID: 12848 RVA: 0x001310B8 File Offset: 0x0012F2B8
		public new void DoCollisionEnter2D(Collision2D collisionInfo)
		{
			if (this.collision == PlayMakerUnity2d.Collision2DType.OnCollisionEnter2D && (collisionInfo.collider.gameObject.tag == this.collideTag.Value || this.collideTag.IsNone || string.IsNullOrEmpty(this.collideTag.Value)) && (collisionInfo.gameObject.layer == this.collideLayer.Value || this.collideLayer.IsNone))
			{
				this.StoreCollisionInfo(collisionInfo);
				base.Fsm.Event(this.sendEvent);
			}
		}

		// Token: 0x06003231 RID: 12849 RVA: 0x00131150 File Offset: 0x0012F350
		public new void DoCollisionStay2D(Collision2D collisionInfo)
		{
			if (this.collision == PlayMakerUnity2d.Collision2DType.OnCollisionStay2D && (collisionInfo.collider.gameObject.tag == this.collideTag.Value || this.collideTag.IsNone || string.IsNullOrEmpty(this.collideTag.Value)) && (collisionInfo.gameObject.layer == this.collideLayer.Value || this.collideLayer.IsNone))
			{
				this.StoreCollisionInfo(collisionInfo);
				base.Fsm.Event(this.sendEvent);
			}
		}

		// Token: 0x06003232 RID: 12850 RVA: 0x001311E8 File Offset: 0x0012F3E8
		public new void DoCollisionExit2D(Collision2D collisionInfo)
		{
			if (this.collision == PlayMakerUnity2d.Collision2DType.OnCollisionExit2D && (collisionInfo.collider.gameObject.tag == this.collideTag.Value || this.collideTag.IsNone || string.IsNullOrEmpty(this.collideTag.Value)) && (collisionInfo.gameObject.layer == this.collideLayer.Value || this.collideLayer.IsNone))
			{
				this.StoreCollisionInfo(collisionInfo);
				base.Fsm.Event(this.sendEvent);
			}
		}

		// Token: 0x06003233 RID: 12851 RVA: 0x00131280 File Offset: 0x0012F480
		public override string ErrorCheck()
		{
			string text = string.Empty;
			if (base.Owner != null && base.Owner.GetComponent<Collider2D>() == null && base.Owner.GetComponent<Rigidbody2D>() == null)
			{
				text += "Owner requires a RigidBody2D or Collider2D!\n";
			}
			return text;
		}

		// Token: 0x04003374 RID: 13172
		[Tooltip("The type of collision to detect.")]
		public PlayMakerUnity2d.Collision2DType collision;

		// Token: 0x04003375 RID: 13173
		[UIHint(UIHint.Tag)]
		[Tooltip("Filter by Tag.")]
		public FsmString collideTag;

		// Token: 0x04003376 RID: 13174
		[UIHint(UIHint.Layer)]
		[Tooltip("Filter by Layer.")]
		public FsmInt collideLayer;

		// Token: 0x04003377 RID: 13175
		[RequiredField]
		[Tooltip("Event to send if a collision is detected.")]
		public FsmEvent sendEvent;

		// Token: 0x04003378 RID: 13176
		[UIHint(UIHint.Variable)]
		[Tooltip("Store the GameObject that collided with the Owner of this FSM.")]
		public FsmGameObject storeCollider;

		// Token: 0x04003379 RID: 13177
		[UIHint(UIHint.Variable)]
		[Tooltip("Store the force of the collision. NOTE: Use Get Collision Info to get more info about the collision.")]
		public FsmFloat storeForce;

		// Token: 0x0400337A RID: 13178
		private PlayMakerUnity2DProxy _proxy;
	}
}
