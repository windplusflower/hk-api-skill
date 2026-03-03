using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000C35 RID: 3125
	[ActionCategory(ActionCategory.Physics)]
	[Tooltip("Tests if a Game Object's Rigid Body is Kinematic.")]
	public class IsKinematic : ComponentAction<Rigidbody>
	{
		// Token: 0x06004174 RID: 16756 RVA: 0x0016C904 File Offset: 0x0016AB04
		public override void Reset()
		{
			this.gameObject = null;
			this.trueEvent = null;
			this.falseEvent = null;
			this.store = null;
			this.everyFrame = false;
		}

		// Token: 0x06004175 RID: 16757 RVA: 0x0016C929 File Offset: 0x0016AB29
		public override void OnEnter()
		{
			this.DoIsKinematic();
			if (!this.everyFrame)
			{
				base.Finish();
			}
		}

		// Token: 0x06004176 RID: 16758 RVA: 0x0016C93F File Offset: 0x0016AB3F
		public override void OnUpdate()
		{
			this.DoIsKinematic();
		}

		// Token: 0x06004177 RID: 16759 RVA: 0x0016C948 File Offset: 0x0016AB48
		private void DoIsKinematic()
		{
			GameObject ownerDefaultTarget = base.Fsm.GetOwnerDefaultTarget(this.gameObject);
			if (base.UpdateCache(ownerDefaultTarget))
			{
				bool isKinematic = base.rigidbody.isKinematic;
				this.store.Value = isKinematic;
				base.Fsm.Event(isKinematic ? this.trueEvent : this.falseEvent);
			}
		}

		// Token: 0x040045BA RID: 17850
		[RequiredField]
		[CheckForComponent(typeof(Rigidbody))]
		public FsmOwnerDefault gameObject;

		// Token: 0x040045BB RID: 17851
		public FsmEvent trueEvent;

		// Token: 0x040045BC RID: 17852
		public FsmEvent falseEvent;

		// Token: 0x040045BD RID: 17853
		[UIHint(UIHint.Variable)]
		public FsmBool store;

		// Token: 0x040045BE RID: 17854
		public bool everyFrame;
	}
}
