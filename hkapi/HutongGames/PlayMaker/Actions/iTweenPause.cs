using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000D30 RID: 3376
	[ActionCategory("iTween")]
	[Tooltip("Pause an iTween action.")]
	public class iTweenPause : FsmStateAction
	{
		// Token: 0x060045E6 RID: 17894 RVA: 0x0017C3F8 File Offset: 0x0017A5F8
		public override void Reset()
		{
			this.iTweenType = iTweenFSMType.all;
			this.includeChildren = false;
			this.inScene = false;
		}

		// Token: 0x060045E7 RID: 17895 RVA: 0x0017C40F File Offset: 0x0017A60F
		public override void OnEnter()
		{
			base.OnEnter();
			this.DoiTween();
			base.Finish();
		}

		// Token: 0x060045E8 RID: 17896 RVA: 0x0017C424 File Offset: 0x0017A624
		private void DoiTween()
		{
			if (this.iTweenType == iTweenFSMType.all)
			{
				iTween.Pause();
				return;
			}
			if (this.inScene)
			{
				iTween.Pause(Enum.GetName(typeof(iTweenFSMType), this.iTweenType));
				return;
			}
			GameObject ownerDefaultTarget = base.Fsm.GetOwnerDefaultTarget(this.gameObject);
			if (ownerDefaultTarget == null)
			{
				return;
			}
			iTween.Pause(ownerDefaultTarget, Enum.GetName(typeof(iTweenFSMType), this.iTweenType), this.includeChildren);
		}

		// Token: 0x04004A97 RID: 19095
		[RequiredField]
		public FsmOwnerDefault gameObject;

		// Token: 0x04004A98 RID: 19096
		public iTweenFSMType iTweenType;

		// Token: 0x04004A99 RID: 19097
		public bool includeChildren;

		// Token: 0x04004A9A RID: 19098
		public bool inScene;
	}
}
