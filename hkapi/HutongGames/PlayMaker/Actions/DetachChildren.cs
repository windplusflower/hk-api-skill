using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000B6E RID: 2926
	[ActionCategory(ActionCategory.GameObject)]
	[Tooltip("Unparents all children from the Game Object.")]
	public class DetachChildren : FsmStateAction
	{
		// Token: 0x06003E47 RID: 15943 RVA: 0x00163D5E File Offset: 0x00161F5E
		public override void Reset()
		{
			this.gameObject = null;
		}

		// Token: 0x06003E48 RID: 15944 RVA: 0x00163D67 File Offset: 0x00161F67
		public override void OnEnter()
		{
			DetachChildren.DoDetachChildren(base.Fsm.GetOwnerDefaultTarget(this.gameObject));
			base.Finish();
		}

		// Token: 0x06003E49 RID: 15945 RVA: 0x00163D85 File Offset: 0x00161F85
		private static void DoDetachChildren(GameObject go)
		{
			if (go != null)
			{
				go.transform.DetachChildren();
			}
		}

		// Token: 0x0400425D RID: 16989
		[RequiredField]
		[Tooltip("GameObject to unparent children from.")]
		public FsmOwnerDefault gameObject;
	}
}
