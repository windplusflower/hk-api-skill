using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000C78 RID: 3192
	[ActionCategory(ActionCategory.Animation)]
	[Tooltip("Rewinds the named animation.")]
	public class RewindAnimation : BaseAnimationAction
	{
		// Token: 0x060042AD RID: 17069 RVA: 0x00170B9A File Offset: 0x0016ED9A
		public override void Reset()
		{
			this.gameObject = null;
			this.animName = null;
		}

		// Token: 0x060042AE RID: 17070 RVA: 0x00170BAA File Offset: 0x0016EDAA
		public override void OnEnter()
		{
			this.DoRewindAnimation();
			base.Finish();
		}

		// Token: 0x060042AF RID: 17071 RVA: 0x00170BB8 File Offset: 0x0016EDB8
		private void DoRewindAnimation()
		{
			if (string.IsNullOrEmpty(this.animName.Value))
			{
				return;
			}
			GameObject ownerDefaultTarget = base.Fsm.GetOwnerDefaultTarget(this.gameObject);
			if (base.UpdateCache(ownerDefaultTarget))
			{
				base.animation.Rewind(this.animName.Value);
			}
		}

		// Token: 0x04004706 RID: 18182
		[RequiredField]
		[CheckForComponent(typeof(Animation))]
		public FsmOwnerDefault gameObject;

		// Token: 0x04004707 RID: 18183
		[UIHint(UIHint.Animation)]
		public FsmString animName;
	}
}
