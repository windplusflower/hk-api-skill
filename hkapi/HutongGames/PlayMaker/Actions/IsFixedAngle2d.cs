using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000AD4 RID: 2772
	[ActionCategory(ActionCategory.Physics2D)]
	[Tooltip("Is the rigidbody2D constrained from rotating?Note: Prefer SetRigidBody2dConstraints when working in Unity 5")]
	public class IsFixedAngle2d : ComponentAction<Rigidbody2D>
	{
		// Token: 0x06003B93 RID: 15251 RVA: 0x00157C16 File Offset: 0x00155E16
		public override void Reset()
		{
			this.gameObject = null;
			this.trueEvent = null;
			this.falseEvent = null;
			this.store = null;
			this.everyFrame = false;
		}

		// Token: 0x06003B94 RID: 15252 RVA: 0x00157C3B File Offset: 0x00155E3B
		public override void OnEnter()
		{
			this.DoIsFixedAngle();
			if (!this.everyFrame)
			{
				base.Finish();
			}
		}

		// Token: 0x06003B95 RID: 15253 RVA: 0x00157C51 File Offset: 0x00155E51
		public override void OnUpdate()
		{
			this.DoIsFixedAngle();
		}

		// Token: 0x06003B96 RID: 15254 RVA: 0x00157C5C File Offset: 0x00155E5C
		private void DoIsFixedAngle()
		{
			GameObject ownerDefaultTarget = base.Fsm.GetOwnerDefaultTarget(this.gameObject);
			if (!base.UpdateCache(ownerDefaultTarget))
			{
				return;
			}
			bool flag = (base.rigidbody2d.constraints & RigidbodyConstraints2D.FreezeRotation) > RigidbodyConstraints2D.None;
			this.store.Value = flag;
			base.Fsm.Event(flag ? this.trueEvent : this.falseEvent);
		}

		// Token: 0x04003F1B RID: 16155
		[RequiredField]
		[CheckForComponent(typeof(Rigidbody2D))]
		[Tooltip("The GameObject with the Rigidbody2D attached")]
		public FsmOwnerDefault gameObject;

		// Token: 0x04003F1C RID: 16156
		[Tooltip("Event sent if the Rigidbody2D does have fixed angle")]
		public FsmEvent trueEvent;

		// Token: 0x04003F1D RID: 16157
		[Tooltip("Event sent if the Rigidbody2D doesn't have fixed angle")]
		public FsmEvent falseEvent;

		// Token: 0x04003F1E RID: 16158
		[UIHint(UIHint.Variable)]
		[Tooltip("Store the fixedAngle flag")]
		public FsmBool store;

		// Token: 0x04003F1F RID: 16159
		[Tooltip("Repeat every frame.")]
		public bool everyFrame;
	}
}
