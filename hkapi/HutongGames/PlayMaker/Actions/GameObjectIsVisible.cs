using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000BC8 RID: 3016
	[ActionCategory(ActionCategory.Logic)]
	[ActionTarget(typeof(GameObject), "gameObject", false)]
	[Tooltip("Tests if a Game Object is visible.")]
	public class GameObjectIsVisible : ComponentAction<Renderer>
	{
		// Token: 0x06003F9A RID: 16282 RVA: 0x00167C8B File Offset: 0x00165E8B
		public override void Reset()
		{
			this.gameObject = null;
			this.trueEvent = null;
			this.falseEvent = null;
			this.storeResult = null;
			this.everyFrame = false;
		}

		// Token: 0x06003F9B RID: 16283 RVA: 0x00167CB0 File Offset: 0x00165EB0
		public override void OnEnter()
		{
			this.DoIsVisible();
			if (!this.everyFrame)
			{
				base.Finish();
			}
		}

		// Token: 0x06003F9C RID: 16284 RVA: 0x00167CC6 File Offset: 0x00165EC6
		public override void OnUpdate()
		{
			this.DoIsVisible();
		}

		// Token: 0x06003F9D RID: 16285 RVA: 0x00167CD0 File Offset: 0x00165ED0
		private void DoIsVisible()
		{
			GameObject ownerDefaultTarget = base.Fsm.GetOwnerDefaultTarget(this.gameObject);
			if (base.UpdateCache(ownerDefaultTarget))
			{
				bool isVisible = base.renderer.isVisible;
				this.storeResult.Value = isVisible;
				base.Fsm.Event(isVisible ? this.trueEvent : this.falseEvent);
			}
		}

		// Token: 0x040043C6 RID: 17350
		[RequiredField]
		[CheckForComponent(typeof(Renderer))]
		[Tooltip("The GameObject to test.")]
		public FsmOwnerDefault gameObject;

		// Token: 0x040043C7 RID: 17351
		[Tooltip("Event to send if the GameObject is visible.")]
		public FsmEvent trueEvent;

		// Token: 0x040043C8 RID: 17352
		[Tooltip("Event to send if the GameObject is NOT visible.")]
		public FsmEvent falseEvent;

		// Token: 0x040043C9 RID: 17353
		[UIHint(UIHint.Variable)]
		[Tooltip("Store the result in a bool variable.")]
		public FsmBool storeResult;

		// Token: 0x040043CA RID: 17354
		public bool everyFrame;
	}
}
