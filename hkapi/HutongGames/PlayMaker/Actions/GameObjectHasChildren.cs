using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000BC5 RID: 3013
	[ActionCategory(ActionCategory.Logic)]
	[Tooltip("Tests if a GameObject has children.")]
	public class GameObjectHasChildren : FsmStateAction
	{
		// Token: 0x06003F8C RID: 16268 RVA: 0x00167AAA File Offset: 0x00165CAA
		public override void Reset()
		{
			this.gameObject = null;
			this.trueEvent = null;
			this.falseEvent = null;
			this.storeResult = null;
			this.everyFrame = false;
		}

		// Token: 0x06003F8D RID: 16269 RVA: 0x00167ACF File Offset: 0x00165CCF
		public override void OnEnter()
		{
			this.DoHasChildren();
			if (!this.everyFrame)
			{
				base.Finish();
			}
		}

		// Token: 0x06003F8E RID: 16270 RVA: 0x00167AE5 File Offset: 0x00165CE5
		public override void OnUpdate()
		{
			this.DoHasChildren();
		}

		// Token: 0x06003F8F RID: 16271 RVA: 0x00167AF0 File Offset: 0x00165CF0
		private void DoHasChildren()
		{
			GameObject ownerDefaultTarget = base.Fsm.GetOwnerDefaultTarget(this.gameObject);
			if (ownerDefaultTarget == null)
			{
				return;
			}
			bool flag = ownerDefaultTarget.transform.childCount > 0;
			this.storeResult.Value = flag;
			base.Fsm.Event(flag ? this.trueEvent : this.falseEvent);
		}

		// Token: 0x040043B7 RID: 17335
		[RequiredField]
		[Tooltip("The GameObject to test.")]
		public FsmOwnerDefault gameObject;

		// Token: 0x040043B8 RID: 17336
		[Tooltip("Event to send if the GameObject has children.")]
		public FsmEvent trueEvent;

		// Token: 0x040043B9 RID: 17337
		[Tooltip("Event to send if the GameObject does not have children.")]
		public FsmEvent falseEvent;

		// Token: 0x040043BA RID: 17338
		[UIHint(UIHint.Variable)]
		[Tooltip("Store the result in a bool variable.")]
		public FsmBool storeResult;

		// Token: 0x040043BB RID: 17339
		[Tooltip("Repeat every frame.")]
		public bool everyFrame;
	}
}
