using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000D47 RID: 3399
	[ActionCategory("Physics 2d")]
	[Tooltip("Detect 2D trigger collisions between the Owner of this FSM and other Game Objects that have RigidBody2D components.\nNOTE: The system events, TRIGGER ENTER 2D, TRIGGER STAY 2D, and TRIGGER EXIT 2D are sent automatically on collisions triggers with any object. Use this action to filter collision triggers by Tag.")]
	public class Trigger2dEventToParent : FsmStateAction
	{
		// Token: 0x06004657 RID: 18007 RVA: 0x0017F448 File Offset: 0x0017D648
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

		// Token: 0x06004658 RID: 18008 RVA: 0x0017F484 File Offset: 0x0017D684
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

		// Token: 0x06004659 RID: 18009 RVA: 0x0017F524 File Offset: 0x0017D724
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

		// Token: 0x0600465A RID: 18010 RVA: 0x0017F5A1 File Offset: 0x0017D7A1
		private void StoreCollisionInfo(Collider2D collisionInfo)
		{
			this.storeCollider.Value = collisionInfo.gameObject;
		}

		// Token: 0x0600465B RID: 18011 RVA: 0x0017F5B4 File Offset: 0x0017D7B4
		public new void DoTriggerEnter2D(Collider2D collisionInfo)
		{
			if (this.trigger == PlayMakerUnity2d.Trigger2DType.OnTriggerEnter2D && (collisionInfo.gameObject.tag == this.collideTag.Value || this.collideTag.IsNone || string.IsNullOrEmpty(this.collideTag.Value)) && (collisionInfo.gameObject.layer == this.collideLayer.Value || this.collideLayer.IsNone))
			{
				this.StoreCollisionInfo(collisionInfo);
				base.Fsm.Event(this.sendEvent);
			}
		}

		// Token: 0x0600465C RID: 18012 RVA: 0x0017F648 File Offset: 0x0017D848
		public new void DoTriggerStay2D(Collider2D collisionInfo)
		{
			if (this.trigger == PlayMakerUnity2d.Trigger2DType.OnTriggerStay2D && (collisionInfo.gameObject.tag == this.collideTag.Value || this.collideTag.IsNone || string.IsNullOrEmpty(this.collideTag.Value)) && (collisionInfo.gameObject.layer == this.collideLayer.Value || this.collideLayer.IsNone))
			{
				this.StoreCollisionInfo(collisionInfo);
				base.Fsm.Event(this.sendEvent);
			}
		}

		// Token: 0x0600465D RID: 18013 RVA: 0x0017F6DC File Offset: 0x0017D8DC
		public new void DoTriggerExit2D(Collider2D collisionInfo)
		{
			if (this.trigger == PlayMakerUnity2d.Trigger2DType.OnTriggerExit2D && (collisionInfo.gameObject.tag == this.collideTag.Value || this.collideTag.IsNone || string.IsNullOrEmpty(this.collideTag.Value)) && (collisionInfo.gameObject.layer == this.collideLayer.Value || this.collideLayer.IsNone))
			{
				this.StoreCollisionInfo(collisionInfo);
				base.Fsm.Event(this.sendEvent);
			}
		}

		// Token: 0x0600465E RID: 18014 RVA: 0x0017F770 File Offset: 0x0017D970
		public override string ErrorCheck()
		{
			string text = string.Empty;
			if (base.Owner != null && base.Owner.GetComponent<Collider2D>() == null && base.Owner.GetComponent<Rigidbody2D>() == null)
			{
				text += "Owner requires a RigidBody2D or Collider2D!\n";
			}
			return text;
		}

		// Token: 0x04004B2E RID: 19246
		[Tooltip("The type of trigger to detect.")]
		public PlayMakerUnity2d.Trigger2DType trigger;

		// Token: 0x04004B2F RID: 19247
		[UIHint(UIHint.Tag)]
		[Tooltip("Filter by Tag.")]
		public FsmString collideTag;

		// Token: 0x04004B30 RID: 19248
		[UIHint(UIHint.Layer)]
		[Tooltip("Filter by Layer.")]
		public FsmInt collideLayer;

		// Token: 0x04004B31 RID: 19249
		[RequiredField]
		[Tooltip("Event to send if a collision is detected.")]
		public FsmEvent sendEvent;

		// Token: 0x04004B32 RID: 19250
		[UIHint(UIHint.Variable)]
		[Tooltip("Store the GameObject that collided with the Owner of this FSM.")]
		public FsmGameObject storeCollider;

		// Token: 0x04004B33 RID: 19251
		private PlayMakerUnity2DProxy _proxy;
	}
}
