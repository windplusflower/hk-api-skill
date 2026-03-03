using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000BD3 RID: 3027
	[ActionCategory(ActionCategory.GameObject)]
	[Tooltip("Gets the Child of a GameObject by Index.\nE.g., O to get the first child. HINT: Use this with an integer variable to iterate through children.")]
	public class GetChildNum : FsmStateAction
	{
		// Token: 0x06003FC5 RID: 16325 RVA: 0x001684CF File Offset: 0x001666CF
		public override void Reset()
		{
			this.gameObject = null;
			this.childIndex = 0;
			this.store = null;
		}

		// Token: 0x06003FC6 RID: 16326 RVA: 0x001684EB File Offset: 0x001666EB
		public override void OnEnter()
		{
			this.store.Value = this.DoGetChildNum(base.Fsm.GetOwnerDefaultTarget(this.gameObject));
			base.Finish();
		}

		// Token: 0x06003FC7 RID: 16327 RVA: 0x00168515 File Offset: 0x00166715
		private GameObject DoGetChildNum(GameObject go)
		{
			if (!(go == null))
			{
				return go.transform.GetChild(this.childIndex.Value % go.transform.childCount).gameObject;
			}
			return null;
		}

		// Token: 0x040043F3 RID: 17395
		[RequiredField]
		[Tooltip("The GameObject to search.")]
		public FsmOwnerDefault gameObject;

		// Token: 0x040043F4 RID: 17396
		[RequiredField]
		[Tooltip("The index of the child to find.")]
		public FsmInt childIndex;

		// Token: 0x040043F5 RID: 17397
		[RequiredField]
		[UIHint(UIHint.Variable)]
		[Tooltip("Store the child in a GameObject variable.")]
		public FsmGameObject store;
	}
}
