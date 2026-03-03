using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000C09 RID: 3081
	[ActionCategory(ActionCategory.GameObject)]
	[Tooltip("Gets a Random Child of a Game Object.")]
	public class GetRandomChild : FsmStateAction
	{
		// Token: 0x060040AF RID: 16559 RVA: 0x0016AB10 File Offset: 0x00168D10
		public override void Reset()
		{
			this.gameObject = null;
			this.storeResult = null;
		}

		// Token: 0x060040B0 RID: 16560 RVA: 0x0016AB20 File Offset: 0x00168D20
		public override void OnEnter()
		{
			this.DoGetRandomChild();
			base.Finish();
		}

		// Token: 0x060040B1 RID: 16561 RVA: 0x0016AB30 File Offset: 0x00168D30
		private void DoGetRandomChild()
		{
			GameObject ownerDefaultTarget = base.Fsm.GetOwnerDefaultTarget(this.gameObject);
			if (ownerDefaultTarget == null)
			{
				return;
			}
			int childCount = ownerDefaultTarget.transform.childCount;
			if (childCount == 0)
			{
				return;
			}
			this.storeResult.Value = ownerDefaultTarget.transform.GetChild(UnityEngine.Random.Range(0, childCount)).gameObject;
		}

		// Token: 0x040044FC RID: 17660
		[RequiredField]
		public FsmOwnerDefault gameObject;

		// Token: 0x040044FD RID: 17661
		[RequiredField]
		[UIHint(UIHint.Variable)]
		public FsmGameObject storeResult;
	}
}
