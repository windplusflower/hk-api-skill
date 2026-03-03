using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000A38 RID: 2616
	[ActionCategory("Physics 2d")]
	[Tooltip("Detect 2D trigger collisions between the Owner of this FSM and other Game Objects that have RigidBody2D components.\nNOTE: The system events, TRIGGER ENTER 2D, TRIGGER STAY 2D, and TRIGGER EXIT 2D are sent automatically on collisions triggers with any object. Use this action to filter collision triggers by Tag.")]
	public class SendTrigger2DEvent : FsmStateAction
	{
		// Token: 0x060038B9 RID: 14521 RVA: 0x0014BF42 File Offset: 0x0014A142
		public override void Reset()
		{
			this.trigger = PlayMakerUnity2d.Trigger2DType.OnTriggerEnter2D;
			this.collideTag = new FsmString
			{
				UseVariable = true
			};
			this.collideLayer = new FsmInt
			{
				UseVariable = true
			};
			this.sendEvent = null;
			this.storeCollider = null;
		}

		// Token: 0x060038BA RID: 14522 RVA: 0x0014BF80 File Offset: 0x0014A180
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

		// Token: 0x060038BB RID: 14523 RVA: 0x0014C020 File Offset: 0x0014A220
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

		// Token: 0x060038BC RID: 14524 RVA: 0x0014C09D File Offset: 0x0014A29D
		private void StoreCollisionInfo(Collider2D collisionInfo)
		{
			this.storeCollider.Value = collisionInfo.gameObject;
		}

		// Token: 0x060038BD RID: 14525 RVA: 0x0014C0B0 File Offset: 0x0014A2B0
		public new void DoTriggerEnter2D(Collider2D collisionInfo)
		{
			if (this.trigger == PlayMakerUnity2d.Trigger2DType.OnTriggerEnter2D && (collisionInfo.gameObject.tag == this.collideTag.Value || this.collideTag.IsNone || string.IsNullOrEmpty(this.collideTag.Value)) && (collisionInfo.gameObject.layer == this.collideLayer.Value || this.collideLayer.IsNone))
			{
				this.StoreCollisionInfo(collisionInfo);
				base.Fsm.Event(this.eventTarget, this.sendEvent);
			}
		}

		// Token: 0x060038BE RID: 14526 RVA: 0x0014C148 File Offset: 0x0014A348
		public new void DoTriggerStay2D(Collider2D collisionInfo)
		{
			if (this.trigger == PlayMakerUnity2d.Trigger2DType.OnTriggerStay2D && (collisionInfo.gameObject.tag == this.collideTag.Value || this.collideTag.IsNone || string.IsNullOrEmpty(this.collideTag.Value)) && (collisionInfo.gameObject.layer == this.collideLayer.Value || this.collideLayer.IsNone))
			{
				this.StoreCollisionInfo(collisionInfo);
				base.Fsm.Event(this.eventTarget, this.sendEvent);
			}
		}

		// Token: 0x060038BF RID: 14527 RVA: 0x0014C1E0 File Offset: 0x0014A3E0
		public new void DoTriggerExit2D(Collider2D collisionInfo)
		{
			if (this.trigger == PlayMakerUnity2d.Trigger2DType.OnTriggerExit2D && (collisionInfo.gameObject.tag == this.collideTag.Value || this.collideTag.IsNone || string.IsNullOrEmpty(this.collideTag.Value)) && (collisionInfo.gameObject.layer == this.collideLayer.Value || this.collideLayer.IsNone))
			{
				this.StoreCollisionInfo(collisionInfo);
				base.Fsm.Event(this.eventTarget, this.sendEvent);
			}
		}

		// Token: 0x060038C0 RID: 14528 RVA: 0x0014C278 File Offset: 0x0014A478
		public override string ErrorCheck()
		{
			string text = string.Empty;
			if (base.Owner != null && base.Owner.GetComponent<Collider2D>() == null && base.Owner.GetComponent<Rigidbody2D>() == null)
			{
				text += "Owner requires a RigidBody2D or Collider2D!\n";
			}
			return text;
		}

		// Token: 0x04003B6B RID: 15211
		[Tooltip("Where to send the event.")]
		public FsmEventTarget eventTarget;

		// Token: 0x04003B6C RID: 15212
		[Tooltip("The type of trigger to detect.")]
		public PlayMakerUnity2d.Trigger2DType trigger;

		// Token: 0x04003B6D RID: 15213
		[UIHint(UIHint.Tag)]
		[Tooltip("Filter by Tag.")]
		public FsmString collideTag;

		// Token: 0x04003B6E RID: 15214
		[UIHint(UIHint.Layer)]
		[Tooltip("Filter by Layer.")]
		public FsmInt collideLayer;

		// Token: 0x04003B6F RID: 15215
		[RequiredField]
		[Tooltip("Event to send if a collision is detected.")]
		public FsmEvent sendEvent;

		// Token: 0x04003B70 RID: 15216
		[UIHint(UIHint.Variable)]
		[Tooltip("Store the GameObject that collided with the Owner of this FSM.")]
		public FsmGameObject storeCollider;

		// Token: 0x04003B71 RID: 15217
		private PlayMakerUnity2DProxy _proxy;
	}
}
