using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000AE9 RID: 2793
	[ActionCategory("Physics 2d")]
	[Tooltip("Detect 2D trigger collisions between the Owner of this FSM and other Game Objects that have RigidBody2D components.\nNOTE: The system events, TRIGGER ENTER 2D, TRIGGER STAY 2D, and TRIGGER EXIT 2D are sent automatically on collisions triggers with any object. Use this action to filter collision triggers by Tag.")]
	public class Trigger2dEvent : FsmStateAction
	{
		// Token: 0x06003BF9 RID: 15353 RVA: 0x00159871 File Offset: 0x00157A71
		public override void Reset()
		{
			this.trigger = PlayMakerUnity2d.Trigger2DType.OnTriggerEnter2D;
			this.collideTag = new FsmString
			{
				UseVariable = true
			};
			this.sendEvent = null;
			this.storeCollider = null;
		}

		// Token: 0x06003BFA RID: 15354 RVA: 0x0015989C File Offset: 0x00157A9C
		public override void OnEnter()
		{
			this._proxy = base.Owner.GetComponent<PlayMakerUnity2DProxy>();
			if (this._proxy == null)
			{
				this._proxy = base.Owner.AddComponent<PlayMakerUnity2DProxy>();
			}
			switch (this.trigger)
			{
			case PlayMakerUnity2d.Trigger2DType.OnTriggerEnter2D:
				this._proxy.AddOnTriggerEnter2dDelegate(new PlayMakerUnity2DProxy.OnTriggerEnter2dDelegate(this.DoTriggerEnter2D));
				return;
			case PlayMakerUnity2d.Trigger2DType.OnTriggerStay2D:
				this._proxy.AddOnTriggerStay2dDelegate(new PlayMakerUnity2DProxy.OnTriggerStay2dDelegate(this.DoTriggerStay2D));
				return;
			case PlayMakerUnity2d.Trigger2DType.OnTriggerExit2D:
				this._proxy.AddOnTriggerExit2dDelegate(new PlayMakerUnity2DProxy.OnTriggerExit2dDelegate(this.DoTriggerExit2D));
				return;
			default:
				return;
			}
		}

		// Token: 0x06003BFB RID: 15355 RVA: 0x0015993C File Offset: 0x00157B3C
		public override void OnExit()
		{
			if (this._proxy == null)
			{
				return;
			}
			switch (this.trigger)
			{
			case PlayMakerUnity2d.Trigger2DType.OnTriggerEnter2D:
				this._proxy.RemoveOnTriggerEnter2dDelegate(new PlayMakerUnity2DProxy.OnTriggerEnter2dDelegate(this.DoTriggerEnter2D));
				return;
			case PlayMakerUnity2d.Trigger2DType.OnTriggerStay2D:
				this._proxy.RemoveOnTriggerStay2dDelegate(new PlayMakerUnity2DProxy.OnTriggerStay2dDelegate(this.DoTriggerStay2D));
				return;
			case PlayMakerUnity2d.Trigger2DType.OnTriggerExit2D:
				this._proxy.RemoveOnTriggerExit2dDelegate(new PlayMakerUnity2DProxy.OnTriggerExit2dDelegate(this.DoTriggerExit2D));
				return;
			default:
				return;
			}
		}

		// Token: 0x06003BFC RID: 15356 RVA: 0x001599B9 File Offset: 0x00157BB9
		private void StoreCollisionInfo(Collider2D collisionInfo)
		{
			this.storeCollider.Value = collisionInfo.gameObject;
		}

		// Token: 0x06003BFD RID: 15357 RVA: 0x001599CC File Offset: 0x00157BCC
		public new void DoTriggerEnter2D(Collider2D collisionInfo)
		{
			if (this.trigger == PlayMakerUnity2d.Trigger2DType.OnTriggerEnter2D && (collisionInfo.gameObject.tag == this.collideTag.Value || this.collideTag.IsNone || string.IsNullOrEmpty(this.collideTag.Value) || this.collideTag.Value == "Untagged"))
			{
				this.StoreCollisionInfo(collisionInfo);
				base.Fsm.Event(this.sendEvent);
			}
		}

		// Token: 0x06003BFE RID: 15358 RVA: 0x00159A4C File Offset: 0x00157C4C
		public new void DoTriggerStay2D(Collider2D collisionInfo)
		{
			if (this.trigger == PlayMakerUnity2d.Trigger2DType.OnTriggerStay2D && (collisionInfo.gameObject.tag == this.collideTag.Value || this.collideTag.IsNone || string.IsNullOrEmpty(this.collideTag.Value) || this.collideTag.Value == "Untagged"))
			{
				this.StoreCollisionInfo(collisionInfo);
				base.Fsm.Event(this.sendEvent);
			}
		}

		// Token: 0x06003BFF RID: 15359 RVA: 0x00159AD0 File Offset: 0x00157CD0
		public new void DoTriggerExit2D(Collider2D collisionInfo)
		{
			if (this.trigger == PlayMakerUnity2d.Trigger2DType.OnTriggerExit2D && (collisionInfo.gameObject.tag == this.collideTag.Value || this.collideTag.IsNone || string.IsNullOrEmpty(this.collideTag.Value) || this.collideTag.Value == "Untagged"))
			{
				this.StoreCollisionInfo(collisionInfo);
				base.Fsm.Event(this.sendEvent);
			}
		}

		// Token: 0x06003C00 RID: 15360 RVA: 0x00159B54 File Offset: 0x00157D54
		public override string ErrorCheck()
		{
			string text = string.Empty;
			if (base.Owner != null && base.Owner.GetComponent<Collider2D>() == null && base.Owner.GetComponent<Rigidbody2D>() == null)
			{
				text += "Owner requires a RigidBody2D or Collider2D!\n";
			}
			return text;
		}

		// Token: 0x04003FAB RID: 16299
		[Tooltip("The type of trigger to detect.")]
		public PlayMakerUnity2d.Trigger2DType trigger;

		// Token: 0x04003FAC RID: 16300
		[UIHint(UIHint.Tag)]
		[Tooltip("Filter by Tag.")]
		public FsmString collideTag;

		// Token: 0x04003FAD RID: 16301
		[UIHint(UIHint.Layer)]
		[Tooltip("Filter by Layer.")]
		public FsmString collideLayer;

		// Token: 0x04003FAE RID: 16302
		[RequiredField]
		[Tooltip("Event to send if a collision is detected.")]
		public FsmEvent sendEvent;

		// Token: 0x04003FAF RID: 16303
		[UIHint(UIHint.Variable)]
		[Tooltip("Store the GameObject that collided with the Owner of this FSM.")]
		public FsmGameObject storeCollider;

		// Token: 0x04003FB0 RID: 16304
		private PlayMakerUnity2DProxy _proxy;
	}
}
