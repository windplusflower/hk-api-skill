using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000AD5 RID: 2773
	[ActionCategory(ActionCategory.Physics2D)]
	[Tooltip("Tests if a Game Object's Rigid Body 2D is Kinematic.")]
	public class IsKinematic2d : ComponentAction<Rigidbody2D>
	{
		// Token: 0x06003B98 RID: 15256 RVA: 0x00157CC0 File Offset: 0x00155EC0
		public override void Reset()
		{
			this.gameObject = null;
			this.trueEvent = null;
			this.falseEvent = null;
			this.store = null;
			this.everyFrame = false;
		}

		// Token: 0x06003B99 RID: 15257 RVA: 0x00157CE5 File Offset: 0x00155EE5
		public override void OnEnter()
		{
			this.DoIsKinematic();
			if (!this.everyFrame)
			{
				base.Finish();
			}
		}

		// Token: 0x06003B9A RID: 15258 RVA: 0x00157CFB File Offset: 0x00155EFB
		public override void OnUpdate()
		{
			this.DoIsKinematic();
		}

		// Token: 0x06003B9B RID: 15259 RVA: 0x00157D04 File Offset: 0x00155F04
		private void DoIsKinematic()
		{
			GameObject ownerDefaultTarget = base.Fsm.GetOwnerDefaultTarget(this.gameObject);
			if (!base.UpdateCache(ownerDefaultTarget))
			{
				return;
			}
			bool isKinematic = base.rigidbody2d.isKinematic;
			this.store.Value = isKinematic;
			base.Fsm.Event(isKinematic ? this.trueEvent : this.falseEvent);
		}

		// Token: 0x04003F20 RID: 16160
		[RequiredField]
		[CheckForComponent(typeof(Rigidbody2D))]
		[Tooltip("the GameObject with a Rigidbody2D attached")]
		public FsmOwnerDefault gameObject;

		// Token: 0x04003F21 RID: 16161
		[Tooltip("Event Sent if Kinematic")]
		public FsmEvent trueEvent;

		// Token: 0x04003F22 RID: 16162
		[Tooltip("Event sent if not Kinematic")]
		public FsmEvent falseEvent;

		// Token: 0x04003F23 RID: 16163
		[UIHint(UIHint.Variable)]
		[Tooltip("Store the Kinematic state")]
		public FsmBool store;

		// Token: 0x04003F24 RID: 16164
		[Tooltip("Repeat every frame")]
		public bool everyFrame;
	}
}
