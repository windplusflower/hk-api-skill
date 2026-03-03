using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000966 RID: 2406
	public class LerpTk2dSpriteColor : FsmStateAction
	{
		// Token: 0x060034D5 RID: 13525 RVA: 0x0013AA7B File Offset: 0x00138C7B
		public override void Reset()
		{
			this.Target = null;
			this.TargetColor = null;
			this.LerpTime = null;
		}

		// Token: 0x060034D6 RID: 13526 RVA: 0x0013AA94 File Offset: 0x00138C94
		public override void OnEnter()
		{
			GameObject safe = this.Target.GetSafe(this);
			if (safe)
			{
				this.sprite = safe.GetComponent<tk2dSprite>();
			}
			else
			{
				this.sprite = null;
			}
			if (!this.sprite)
			{
				base.Finish();
				return;
			}
			this.initialColor = this.sprite.color;
			this.DoAction();
		}

		// Token: 0x060034D7 RID: 13527 RVA: 0x0013AAF6 File Offset: 0x00138CF6
		public override void OnUpdate()
		{
			this.DoAction();
		}

		// Token: 0x060034D8 RID: 13528 RVA: 0x0013AB00 File Offset: 0x00138D00
		private void DoAction()
		{
			float num = base.State.StateTime / this.LerpTime.Value;
			this.sprite.color = Color.Lerp(this.initialColor, this.TargetColor.Value, num);
			if (num >= 1f)
			{
				base.Finish();
			}
		}

		// Token: 0x04003684 RID: 13956
		public FsmOwnerDefault Target;

		// Token: 0x04003685 RID: 13957
		public FsmColor TargetColor;

		// Token: 0x04003686 RID: 13958
		public FsmFloat LerpTime;

		// Token: 0x04003687 RID: 13959
		private tk2dSprite sprite;

		// Token: 0x04003688 RID: 13960
		private Color initialColor;
	}
}
