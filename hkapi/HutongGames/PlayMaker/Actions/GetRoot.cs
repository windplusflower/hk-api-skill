using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000C0E RID: 3086
	[ActionCategory(ActionCategory.GameObject)]
	[Tooltip("Gets the top most parent of the Game Object.\nIf the game object has no parent, returns itself.")]
	public class GetRoot : FsmStateAction
	{
		// Token: 0x060040C7 RID: 16583 RVA: 0x0016AF47 File Offset: 0x00169147
		public override void Reset()
		{
			this.gameObject = null;
			this.storeRoot = null;
		}

		// Token: 0x060040C8 RID: 16584 RVA: 0x0016AF57 File Offset: 0x00169157
		public override void OnEnter()
		{
			this.DoGetRoot();
			base.Finish();
		}

		// Token: 0x060040C9 RID: 16585 RVA: 0x0016AF68 File Offset: 0x00169168
		private void DoGetRoot()
		{
			GameObject ownerDefaultTarget = base.Fsm.GetOwnerDefaultTarget(this.gameObject);
			if (ownerDefaultTarget == null)
			{
				return;
			}
			this.storeRoot.Value = ownerDefaultTarget.transform.root.gameObject;
		}

		// Token: 0x04004511 RID: 17681
		[RequiredField]
		public FsmOwnerDefault gameObject;

		// Token: 0x04004512 RID: 17682
		[RequiredField]
		[UIHint(UIHint.Variable)]
		public FsmGameObject storeRoot;
	}
}
