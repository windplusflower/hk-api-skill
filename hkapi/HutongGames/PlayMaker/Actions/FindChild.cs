using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000B81 RID: 2945
	[ActionCategory(ActionCategory.GameObject)]
	[Tooltip("Finds the Child of a GameObject by Name.\nNote, you can specify a path to the child, e.g., LeftShoulder/Arm/Hand/Finger. If you need to specify a tag, use GetChild.")]
	public class FindChild : FsmStateAction
	{
		// Token: 0x06003E96 RID: 16022 RVA: 0x00164AFD File Offset: 0x00162CFD
		public override void Reset()
		{
			this.gameObject = null;
			this.childName = "";
			this.storeResult = null;
		}

		// Token: 0x06003E97 RID: 16023 RVA: 0x00164B1D File Offset: 0x00162D1D
		public override void OnEnter()
		{
			this.DoFindChild();
			base.Finish();
		}

		// Token: 0x06003E98 RID: 16024 RVA: 0x00164B2C File Offset: 0x00162D2C
		private void DoFindChild()
		{
			GameObject ownerDefaultTarget = base.Fsm.GetOwnerDefaultTarget(this.gameObject);
			if (ownerDefaultTarget == null)
			{
				return;
			}
			Transform transform = ownerDefaultTarget.transform.Find(this.childName.Value);
			this.storeResult.Value = ((transform != null) ? transform.gameObject : null);
		}

		// Token: 0x040042A7 RID: 17063
		[RequiredField]
		[Tooltip("The GameObject to search.")]
		public FsmOwnerDefault gameObject;

		// Token: 0x040042A8 RID: 17064
		[RequiredField]
		[Tooltip("The name of the child. Note, you can specify a path to the child, e.g., LeftShoulder/Arm/Hand/Finger")]
		public FsmString childName;

		// Token: 0x040042A9 RID: 17065
		[RequiredField]
		[UIHint(UIHint.Variable)]
		[Tooltip("Store the child in a GameObject variable.")]
		public FsmGameObject storeResult;
	}
}
