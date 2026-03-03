using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000D42 RID: 3394
	[ActionCategory("iTween")]
	[Tooltip("Stop an iTween action.")]
	public class iTweenStop : FsmStateAction
	{
		// Token: 0x06004640 RID: 17984 RVA: 0x0017EF0E File Offset: 0x0017D10E
		public override void Reset()
		{
			this.id = new FsmString
			{
				UseVariable = true
			};
			this.iTweenType = iTweenFSMType.all;
			this.includeChildren = false;
			this.inScene = false;
		}

		// Token: 0x06004641 RID: 17985 RVA: 0x0017EF37 File Offset: 0x0017D137
		public override void OnEnter()
		{
			base.OnEnter();
			this.DoiTween();
			base.Finish();
		}

		// Token: 0x06004642 RID: 17986 RVA: 0x0017EF4C File Offset: 0x0017D14C
		private void DoiTween()
		{
			if (!this.id.IsNone)
			{
				iTween.StopByName(this.id.Value);
				return;
			}
			if (this.iTweenType == iTweenFSMType.all)
			{
				iTween.Stop();
				return;
			}
			if (this.inScene)
			{
				iTween.Stop(Enum.GetName(typeof(iTweenFSMType), this.iTweenType));
				return;
			}
			GameObject ownerDefaultTarget = base.Fsm.GetOwnerDefaultTarget(this.gameObject);
			if (ownerDefaultTarget == null)
			{
				return;
			}
			iTween.Stop(ownerDefaultTarget, Enum.GetName(typeof(iTweenFSMType), this.iTweenType), this.includeChildren);
		}

		// Token: 0x04004B1E RID: 19230
		[RequiredField]
		public FsmOwnerDefault gameObject;

		// Token: 0x04004B1F RID: 19231
		public FsmString id;

		// Token: 0x04004B20 RID: 19232
		public iTweenFSMType iTweenType;

		// Token: 0x04004B21 RID: 19233
		public bool includeChildren;

		// Token: 0x04004B22 RID: 19234
		public bool inScene;
	}
}
