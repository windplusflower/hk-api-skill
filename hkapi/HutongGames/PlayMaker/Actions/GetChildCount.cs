using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000BD2 RID: 3026
	[ActionCategory(ActionCategory.GameObject)]
	[Tooltip("Gets the number of children that a GameObject has.")]
	public class GetChildCount : FsmStateAction
	{
		// Token: 0x06003FC1 RID: 16321 RVA: 0x00168471 File Offset: 0x00166671
		public override void Reset()
		{
			this.gameObject = null;
			this.storeResult = null;
		}

		// Token: 0x06003FC2 RID: 16322 RVA: 0x00168481 File Offset: 0x00166681
		public override void OnEnter()
		{
			this.DoGetChildCount();
			base.Finish();
		}

		// Token: 0x06003FC3 RID: 16323 RVA: 0x00168490 File Offset: 0x00166690
		private void DoGetChildCount()
		{
			GameObject ownerDefaultTarget = base.Fsm.GetOwnerDefaultTarget(this.gameObject);
			if (ownerDefaultTarget == null)
			{
				return;
			}
			this.storeResult.Value = ownerDefaultTarget.transform.childCount;
		}

		// Token: 0x040043F1 RID: 17393
		[RequiredField]
		[Tooltip("The GameObject to test.")]
		public FsmOwnerDefault gameObject;

		// Token: 0x040043F2 RID: 17394
		[RequiredField]
		[UIHint(UIHint.Variable)]
		[Tooltip("Store the number of children in an int variable.")]
		public FsmInt storeResult;
	}
}
