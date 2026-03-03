using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000D34 RID: 3380
	[ActionCategory("iTween")]
	[Tooltip("Resume an iTween action.")]
	public class iTweenResume : FsmStateAction
	{
		// Token: 0x060045F9 RID: 17913 RVA: 0x0017CBA6 File Offset: 0x0017ADA6
		public override void Reset()
		{
			this.iTweenType = iTweenFSMType.all;
			this.includeChildren = false;
			this.inScene = false;
		}

		// Token: 0x060045FA RID: 17914 RVA: 0x0017CBBD File Offset: 0x0017ADBD
		public override void OnEnter()
		{
			base.OnEnter();
			this.DoiTween();
			base.Finish();
		}

		// Token: 0x060045FB RID: 17915 RVA: 0x0017CBD4 File Offset: 0x0017ADD4
		private void DoiTween()
		{
			if (this.iTweenType == iTweenFSMType.all)
			{
				iTween.Resume();
				return;
			}
			if (this.inScene)
			{
				iTween.Resume(Enum.GetName(typeof(iTweenFSMType), this.iTweenType));
				return;
			}
			GameObject ownerDefaultTarget = base.Fsm.GetOwnerDefaultTarget(this.gameObject);
			if (ownerDefaultTarget == null)
			{
				return;
			}
			iTween.Resume(ownerDefaultTarget, Enum.GetName(typeof(iTweenFSMType), this.iTweenType), this.includeChildren);
		}

		// Token: 0x04004AB0 RID: 19120
		[RequiredField]
		public FsmOwnerDefault gameObject;

		// Token: 0x04004AB1 RID: 19121
		public iTweenFSMType iTweenType;

		// Token: 0x04004AB2 RID: 19122
		public bool includeChildren;

		// Token: 0x04004AB3 RID: 19123
		public bool inScene;
	}
}
