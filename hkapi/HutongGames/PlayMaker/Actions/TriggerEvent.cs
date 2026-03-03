using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000D05 RID: 3333
	[ActionCategory(ActionCategory.Physics)]
	[Tooltip("Detect collisions with objects that have RigidBody components. \nNOTE: The system events, TRIGGER ENTER, TRIGGER STAY, and TRIGGER EXIT are sent when any object collides with the trigger. Use this action to filter collisions by Tag.")]
	public class TriggerEvent : FsmStateAction
	{
		// Token: 0x06004528 RID: 17704 RVA: 0x0017882A File Offset: 0x00176A2A
		public override void Reset()
		{
			this.trigger = TriggerType.OnTriggerEnter;
			this.collideTag = "Untagged";
			this.sendEvent = null;
			this.storeCollider = null;
		}

		// Token: 0x06004529 RID: 17705 RVA: 0x00178854 File Offset: 0x00176A54
		public override void OnPreprocess()
		{
			switch (this.trigger)
			{
			case TriggerType.OnTriggerEnter:
				base.Fsm.HandleTriggerEnter = true;
				return;
			case TriggerType.OnTriggerStay:
				base.Fsm.HandleTriggerStay = true;
				return;
			case TriggerType.OnTriggerExit:
				base.Fsm.HandleTriggerExit = true;
				return;
			default:
				return;
			}
		}

		// Token: 0x0600452A RID: 17706 RVA: 0x001788A1 File Offset: 0x00176AA1
		private void StoreCollisionInfo(Collider collisionInfo)
		{
			this.storeCollider.Value = collisionInfo.gameObject;
		}

		// Token: 0x0600452B RID: 17707 RVA: 0x001788B4 File Offset: 0x00176AB4
		public override void DoTriggerEnter(Collider other)
		{
			if (this.trigger == TriggerType.OnTriggerEnter && other.gameObject.tag == this.collideTag.Value)
			{
				this.StoreCollisionInfo(other);
				base.Fsm.Event(this.sendEvent);
			}
		}

		// Token: 0x0600452C RID: 17708 RVA: 0x001788F3 File Offset: 0x00176AF3
		public override void DoTriggerStay(Collider other)
		{
			if (this.trigger == TriggerType.OnTriggerStay && other.gameObject.tag == this.collideTag.Value)
			{
				this.StoreCollisionInfo(other);
				base.Fsm.Event(this.sendEvent);
			}
		}

		// Token: 0x0600452D RID: 17709 RVA: 0x00178933 File Offset: 0x00176B33
		public override void DoTriggerExit(Collider other)
		{
			if (this.trigger == TriggerType.OnTriggerExit && other.gameObject.tag == this.collideTag.Value)
			{
				this.StoreCollisionInfo(other);
				base.Fsm.Event(this.sendEvent);
			}
		}

		// Token: 0x0600452E RID: 17710 RVA: 0x001621B3 File Offset: 0x001603B3
		public override string ErrorCheck()
		{
			return ActionHelpers.CheckOwnerPhysicsSetup(base.Owner);
		}

		// Token: 0x04004996 RID: 18838
		[Tooltip("The type of trigger event to detect.")]
		public TriggerType trigger;

		// Token: 0x04004997 RID: 18839
		[UIHint(UIHint.Tag)]
		[Tooltip("Filter by Tag.")]
		public FsmString collideTag;

		// Token: 0x04004998 RID: 18840
		[Tooltip("Event to send if the trigger event is detected.")]
		public FsmEvent sendEvent;

		// Token: 0x04004999 RID: 18841
		[UIHint(UIHint.Variable)]
		[Tooltip("Store the GameObject that collided with the Owner of this FSM.")]
		public FsmGameObject storeCollider;
	}
}
