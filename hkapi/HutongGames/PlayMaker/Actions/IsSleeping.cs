using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000C36 RID: 3126
	[ActionCategory(ActionCategory.Physics)]
	[Tooltip("Tests if a Game Object's Rigid Body is sleeping.")]
	public class IsSleeping : ComponentAction<Rigidbody>
	{
		// Token: 0x06004179 RID: 16761 RVA: 0x0016C9A4 File Offset: 0x0016ABA4
		public override void Reset()
		{
			this.gameObject = null;
			this.trueEvent = null;
			this.falseEvent = null;
			this.store = null;
			this.everyFrame = false;
		}

		// Token: 0x0600417A RID: 16762 RVA: 0x0016C9C9 File Offset: 0x0016ABC9
		public override void OnEnter()
		{
			this.DoIsSleeping();
			if (!this.everyFrame)
			{
				base.Finish();
			}
		}

		// Token: 0x0600417B RID: 16763 RVA: 0x0016C9DF File Offset: 0x0016ABDF
		public override void OnUpdate()
		{
			this.DoIsSleeping();
		}

		// Token: 0x0600417C RID: 16764 RVA: 0x0016C9E8 File Offset: 0x0016ABE8
		private void DoIsSleeping()
		{
			GameObject ownerDefaultTarget = base.Fsm.GetOwnerDefaultTarget(this.gameObject);
			if (base.UpdateCache(ownerDefaultTarget))
			{
				bool flag = base.rigidbody.IsSleeping();
				this.store.Value = flag;
				base.Fsm.Event(flag ? this.trueEvent : this.falseEvent);
			}
		}

		// Token: 0x040045BF RID: 17855
		[RequiredField]
		[CheckForComponent(typeof(Rigidbody))]
		public FsmOwnerDefault gameObject;

		// Token: 0x040045C0 RID: 17856
		public FsmEvent trueEvent;

		// Token: 0x040045C1 RID: 17857
		public FsmEvent falseEvent;

		// Token: 0x040045C2 RID: 17858
		[UIHint(UIHint.Variable)]
		public FsmBool store;

		// Token: 0x040045C3 RID: 17859
		public bool everyFrame;
	}
}
