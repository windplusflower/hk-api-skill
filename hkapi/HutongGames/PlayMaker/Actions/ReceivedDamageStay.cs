using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000A0D RID: 2573
	[ActionCategory("Combat")]
	[Tooltip("Detect 2D entry collisions or triggers between the Owner of this FSM and other Game Objects that have a Damager FSM.")]
	public class ReceivedDamageStay : FsmStateAction
	{
		// Token: 0x06003800 RID: 14336 RVA: 0x00148EE8 File Offset: 0x001470E8
		public override void Reset()
		{
			this.collideTag = new FsmString
			{
				UseVariable = true
			};
			this.sendEvent = null;
			this.storeGameObject = null;
		}

		// Token: 0x06003801 RID: 14337 RVA: 0x00148F0C File Offset: 0x0014710C
		public override void OnEnter()
		{
			this._proxy = base.Owner.GetComponent<PlayMakerUnity2DProxy>();
			if (this._proxy == null)
			{
				this._proxy = base.Owner.AddComponent<PlayMakerUnity2DProxy>();
			}
			this._proxy.AddOnCollisionEnter2dDelegate(new PlayMakerUnity2DProxy.OnCollisionEnter2dDelegate(this.DoCollisionEnter2D));
			this._proxy.AddOnTriggerEnter2dDelegate(new PlayMakerUnity2DProxy.OnTriggerEnter2dDelegate(this.DoTriggerEnter2D));
		}

		// Token: 0x06003802 RID: 14338 RVA: 0x00148F77 File Offset: 0x00147177
		public override void OnExit()
		{
			if (this._proxy == null)
			{
				return;
			}
			this._proxy.RemoveOnCollisionEnter2dDelegate(new PlayMakerUnity2DProxy.OnCollisionEnter2dDelegate(this.DoCollisionEnter2D));
			this._proxy.RemoveOnTriggerEnter2dDelegate(new PlayMakerUnity2DProxy.OnTriggerEnter2dDelegate(this.DoTriggerEnter2D));
		}

		// Token: 0x06003803 RID: 14339 RVA: 0x00148FB8 File Offset: 0x001471B8
		public new void DoCollisionEnter2D(Collision2D collisionInfo)
		{
			if ((collisionInfo.collider.gameObject.tag == this.collideTag.Value || this.collideTag.IsNone || string.IsNullOrEmpty(this.collideTag.Value)) && (!this.ignoreAcid.Value || collisionInfo.collider.gameObject.tag != "Acid"))
			{
				this.StoreCollisionInfo(collisionInfo);
			}
		}

		// Token: 0x06003804 RID: 14340 RVA: 0x00149038 File Offset: 0x00147238
		public new void DoCollisionStay2D(Collision2D collisionInfo)
		{
			if ((collisionInfo.collider.gameObject.tag == this.collideTag.Value || this.collideTag.IsNone || string.IsNullOrEmpty(this.collideTag.Value)) && (!this.ignoreAcid.Value || collisionInfo.collider.gameObject.tag != "Acid"))
			{
				this.StoreCollisionInfo(collisionInfo);
			}
		}

		// Token: 0x06003805 RID: 14341 RVA: 0x001490B8 File Offset: 0x001472B8
		public new void DoTriggerEnter2D(Collider2D collisionInfo)
		{
			if ((collisionInfo.gameObject.tag == this.collideTag.Value || this.collideTag.IsNone || string.IsNullOrEmpty(this.collideTag.Value)) && (!this.ignoreAcid.Value || collisionInfo.gameObject.tag != "Acid"))
			{
				this.StoreCollisionInfo(collisionInfo);
			}
		}

		// Token: 0x06003806 RID: 14342 RVA: 0x0014912C File Offset: 0x0014732C
		public new void DoTriggerStay2D(Collider2D collisionInfo)
		{
			if ((collisionInfo.gameObject.tag == this.collideTag.Value || this.collideTag.IsNone || string.IsNullOrEmpty(this.collideTag.Value)) && (!this.ignoreAcid.Value || collisionInfo.gameObject.tag != "Acid"))
			{
				this.StoreCollisionInfo(collisionInfo);
			}
		}

		// Token: 0x06003807 RID: 14343 RVA: 0x001491A0 File Offset: 0x001473A0
		private void StoreCollisionInfo(Collision2D collisionInfo)
		{
			this.storeGameObject.Value = collisionInfo.gameObject;
			this.StoreIfDamagingObject(collisionInfo.gameObject);
		}

		// Token: 0x06003808 RID: 14344 RVA: 0x001491BF File Offset: 0x001473BF
		private void StoreCollisionInfo(Collider2D collisionInfo)
		{
			this.storeGameObject.Value = collisionInfo.gameObject;
			this.StoreIfDamagingObject(collisionInfo.gameObject);
		}

		// Token: 0x06003809 RID: 14345 RVA: 0x001491E0 File Offset: 0x001473E0
		private void StoreIfDamagingObject(GameObject go)
		{
			PlayMakerFSM[] components = go.GetComponents<PlayMakerFSM>();
			for (int i = 0; i < components.Length; i++)
			{
				if (components[i].FsmName == this.fsmName.Value)
				{
					this.storeGameObject.Value = go;
					base.Fsm.Event(this.sendEvent);
					return;
				}
			}
		}

		// Token: 0x0600380A RID: 14346 RVA: 0x0014923C File Offset: 0x0014743C
		public override string ErrorCheck()
		{
			string text = string.Empty;
			if (base.Owner != null && base.Owner.GetComponent<Collider2D>() == null && base.Owner.GetComponent<Rigidbody2D>() == null)
			{
				text += "Owner requires a RigidBody2D or Collider2D!\n";
			}
			return text;
		}

		// Token: 0x04003A90 RID: 14992
		[UIHint(UIHint.Tag)]
		[Tooltip("Filter by Tag.")]
		public FsmString collideTag;

		// Token: 0x04003A91 RID: 14993
		[RequiredField]
		[Tooltip("Event to send if a collision is detected.")]
		public FsmEvent sendEvent;

		// Token: 0x04003A92 RID: 14994
		[Tooltip("Name of FSM to look for on colliding object.")]
		public FsmString fsmName;

		// Token: 0x04003A93 RID: 14995
		[UIHint(UIHint.Variable)]
		[Tooltip("Store the GameObject that collided with the Owner of this FSM.")]
		public FsmGameObject storeGameObject;

		// Token: 0x04003A94 RID: 14996
		public FsmBool ignoreAcid;

		// Token: 0x04003A95 RID: 14997
		private PlayMakerUnity2DProxy _proxy;
	}
}
