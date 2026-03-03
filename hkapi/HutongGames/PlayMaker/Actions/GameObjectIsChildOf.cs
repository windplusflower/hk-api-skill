using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000BC6 RID: 3014
	[ActionCategory(ActionCategory.Logic)]
	[Tooltip("Tests if a GameObject is a Child of another GameObject.")]
	public class GameObjectIsChildOf : FsmStateAction
	{
		// Token: 0x06003F91 RID: 16273 RVA: 0x00167B50 File Offset: 0x00165D50
		public override void Reset()
		{
			this.gameObject = null;
			this.isChildOf = null;
			this.trueEvent = null;
			this.falseEvent = null;
			this.storeResult = null;
		}

		// Token: 0x06003F92 RID: 16274 RVA: 0x00167B75 File Offset: 0x00165D75
		public override void OnEnter()
		{
			this.DoIsChildOf(base.Fsm.GetOwnerDefaultTarget(this.gameObject));
			base.Finish();
		}

		// Token: 0x06003F93 RID: 16275 RVA: 0x00167B94 File Offset: 0x00165D94
		private void DoIsChildOf(GameObject go)
		{
			if (go == null || this.isChildOf == null)
			{
				return;
			}
			bool flag = go.transform.IsChildOf(this.isChildOf.Value.transform);
			this.storeResult.Value = flag;
			base.Fsm.Event(flag ? this.trueEvent : this.falseEvent);
		}

		// Token: 0x040043BC RID: 17340
		[RequiredField]
		[Tooltip("GameObject to test.")]
		public FsmOwnerDefault gameObject;

		// Token: 0x040043BD RID: 17341
		[RequiredField]
		[Tooltip("Is it a child of this GameObject?")]
		public FsmGameObject isChildOf;

		// Token: 0x040043BE RID: 17342
		[Tooltip("Event to send if GameObject is a child.")]
		public FsmEvent trueEvent;

		// Token: 0x040043BF RID: 17343
		[Tooltip("Event to send if GameObject is NOT a child.")]
		public FsmEvent falseEvent;

		// Token: 0x040043C0 RID: 17344
		[RequiredField]
		[UIHint(UIHint.Variable)]
		[Tooltip("Store result in a bool variable")]
		public FsmBool storeResult;
	}
}
