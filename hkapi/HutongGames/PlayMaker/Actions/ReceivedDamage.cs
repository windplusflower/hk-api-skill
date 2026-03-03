using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000A0C RID: 2572
	[ActionCategory("Combat")]
	[Tooltip("Detect 2D entry collisions or triggers between the Owner of this FSM and other Game Objects that have a Damager FSM.")]
	public class ReceivedDamage : FsmStateAction
	{
		// Token: 0x060037F5 RID: 14325 RVA: 0x00148B19 File Offset: 0x00146D19
		public override void Reset()
		{
			this.collideTag = new FsmString
			{
				UseVariable = true
			};
			this.sendEvent = null;
			this.storeGameObject = null;
		}

		// Token: 0x060037F6 RID: 14326 RVA: 0x00148B3C File Offset: 0x00146D3C
		public override void OnEnter()
		{
			this._proxy = base.Owner.GetComponent<PlayMakerUnity2DProxy>();
			if (this._proxy == null)
			{
				this._proxy = base.Owner.AddComponent<PlayMakerUnity2DProxy>();
			}
			this._proxy.AddOnCollisionEnter2dDelegate(new PlayMakerUnity2DProxy.OnCollisionEnter2dDelegate(this.DoCollisionEnter2D));
			this._proxy.AddOnTriggerEnter2dDelegate(new PlayMakerUnity2DProxy.OnTriggerEnter2dDelegate(this.DoTriggerEnter2D));
			this._proxy.AddOnTriggerStay2dDelegate(new PlayMakerUnity2DProxy.OnTriggerStay2dDelegate(this.DoTriggerStay2D));
		}

		// Token: 0x060037F7 RID: 14327 RVA: 0x00148BC0 File Offset: 0x00146DC0
		public override void OnExit()
		{
			if (this._proxy == null)
			{
				return;
			}
			this._proxy.RemoveOnCollisionEnter2dDelegate(new PlayMakerUnity2DProxy.OnCollisionEnter2dDelegate(this.DoCollisionEnter2D));
			this._proxy.RemoveOnTriggerEnter2dDelegate(new PlayMakerUnity2DProxy.OnTriggerEnter2dDelegate(this.DoTriggerEnter2D));
			this._proxy.RemoveOnTriggerStay2dDelegate(new PlayMakerUnity2DProxy.OnTriggerStay2dDelegate(this.DoTriggerStay2D));
		}

		// Token: 0x060037F8 RID: 14328 RVA: 0x00148C24 File Offset: 0x00146E24
		public new void DoCollisionEnter2D(Collision2D collisionInfo)
		{
			if ((collisionInfo.collider.gameObject.tag == this.collideTag.Value || this.collideTag.IsNone || string.IsNullOrEmpty(this.collideTag.Value)) && (!this.ignoreAcid.Value || collisionInfo.gameObject.tag != "Acid") && (!this.ignoreWater.Value || collisionInfo.gameObject.tag != "Water Surface"))
			{
				this.StoreCollisionInfo(collisionInfo);
			}
		}

		// Token: 0x060037F9 RID: 14329 RVA: 0x00148CC4 File Offset: 0x00146EC4
		public new void DoTriggerEnter2D(Collider2D collisionInfo)
		{
			if ((collisionInfo.gameObject.tag == this.collideTag.Value || this.collideTag.IsNone || string.IsNullOrEmpty(this.collideTag.Value)) && (!this.ignoreAcid.Value || collisionInfo.gameObject.tag != "Acid") && (!this.ignoreWater.Value || collisionInfo.gameObject.tag != "Water Surface"))
			{
				this.StoreTriggerInfo(collisionInfo);
			}
		}

		// Token: 0x060037FA RID: 14330 RVA: 0x00148D5C File Offset: 0x00146F5C
		public new void DoTriggerStay2D(Collider2D collisionInfo)
		{
			if ((collisionInfo.gameObject.tag == this.collideTag.Value || this.collideTag.IsNone || string.IsNullOrEmpty(this.collideTag.Value)) && (!this.ignoreAcid.Value || collisionInfo.gameObject.tag != "Acid") && (!this.ignoreWater.Value || collisionInfo.gameObject.tag != "Water Surface"))
			{
				this.StoreTriggerInfo(collisionInfo);
			}
		}

		// Token: 0x060037FB RID: 14331 RVA: 0x00148DF4 File Offset: 0x00146FF4
		private void StoreCollisionInfo(Collision2D collisionInfo)
		{
			this.storeGameObject.Value = collisionInfo.gameObject;
			this.StoreIfDamagingObject(collisionInfo.gameObject);
		}

		// Token: 0x060037FC RID: 14332 RVA: 0x00148E13 File Offset: 0x00147013
		private void StoreTriggerInfo(Collider2D collisionInfo)
		{
			this.storeGameObject.Value = collisionInfo.gameObject;
			this.StoreIfDamagingObject(collisionInfo.gameObject);
		}

		// Token: 0x060037FD RID: 14333 RVA: 0x00148E34 File Offset: 0x00147034
		private void StoreIfDamagingObject(GameObject go)
		{
			PlayMakerFSM playMakerFSM = FSMUtility.LocateFSM(go, this.fsmName.Value);
			if (playMakerFSM != null && playMakerFSM.FsmVariables.GetFsmInt("damageDealt").Value > 0)
			{
				this.storeGameObject.Value = go;
				base.Fsm.Event(this.sendEvent);
			}
		}

		// Token: 0x060037FE RID: 14334 RVA: 0x00148E94 File Offset: 0x00147094
		public override string ErrorCheck()
		{
			string text = string.Empty;
			if (base.Owner != null && base.Owner.GetComponent<Collider2D>() == null && base.Owner.GetComponent<Rigidbody2D>() == null)
			{
				text += "Owner requires a RigidBody2D or Collider2D!\n";
			}
			return text;
		}

		// Token: 0x04003A89 RID: 14985
		[UIHint(UIHint.Tag)]
		[Tooltip("Filter by Tag.")]
		public FsmString collideTag;

		// Token: 0x04003A8A RID: 14986
		[RequiredField]
		[Tooltip("Event to send if a collision is detected.")]
		public FsmEvent sendEvent;

		// Token: 0x04003A8B RID: 14987
		[Tooltip("Name of FSM to look for on colliding object.")]
		public FsmString fsmName;

		// Token: 0x04003A8C RID: 14988
		[UIHint(UIHint.Variable)]
		[Tooltip("Store the GameObject that collided with the Owner of this FSM.")]
		public FsmGameObject storeGameObject;

		// Token: 0x04003A8D RID: 14989
		[Tooltip("Ignore damage from Acid")]
		public FsmBool ignoreAcid;

		// Token: 0x04003A8E RID: 14990
		[Tooltip("Ignore damage from Water")]
		public FsmBool ignoreWater;

		// Token: 0x04003A8F RID: 14991
		private PlayMakerUnity2DProxy _proxy;
	}
}
