using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000AD6 RID: 2774
	[ActionCategory(ActionCategory.Physics2D)]
	[Tooltip("Tests if a Game Object's Rigidbody 2D is sleeping.")]
	public class IsSleeping2d : ComponentAction<Rigidbody2D>
	{
		// Token: 0x06003B9D RID: 15261 RVA: 0x00157D61 File Offset: 0x00155F61
		public override void Reset()
		{
			this.gameObject = null;
			this.trueEvent = null;
			this.falseEvent = null;
			this.store = null;
			this.everyFrame = false;
		}

		// Token: 0x06003B9E RID: 15262 RVA: 0x00157D86 File Offset: 0x00155F86
		public override void OnEnter()
		{
			this.DoIsSleeping();
			if (!this.everyFrame)
			{
				base.Finish();
			}
		}

		// Token: 0x06003B9F RID: 15263 RVA: 0x00157D9C File Offset: 0x00155F9C
		public override void OnUpdate()
		{
			this.DoIsSleeping();
		}

		// Token: 0x06003BA0 RID: 15264 RVA: 0x00157DA4 File Offset: 0x00155FA4
		private void DoIsSleeping()
		{
			GameObject ownerDefaultTarget = base.Fsm.GetOwnerDefaultTarget(this.gameObject);
			if (!base.UpdateCache(ownerDefaultTarget))
			{
				return;
			}
			bool flag = base.rigidbody2d.IsSleeping();
			this.store.Value = flag;
			base.Fsm.Event(flag ? this.trueEvent : this.falseEvent);
		}

		// Token: 0x04003F25 RID: 16165
		[RequiredField]
		[CheckForComponent(typeof(Rigidbody2D))]
		[Tooltip("The GameObject with the Rigidbody2D attached")]
		public FsmOwnerDefault gameObject;

		// Token: 0x04003F26 RID: 16166
		[Tooltip("Event sent if sleeping")]
		public FsmEvent trueEvent;

		// Token: 0x04003F27 RID: 16167
		[Tooltip("Event sent if not sleeping")]
		public FsmEvent falseEvent;

		// Token: 0x04003F28 RID: 16168
		[UIHint(UIHint.Variable)]
		[Tooltip("Store the value in a Boolean variable")]
		public FsmBool store;

		// Token: 0x04003F29 RID: 16169
		[Tooltip("Repeat every frame")]
		public bool everyFrame;
	}
}
