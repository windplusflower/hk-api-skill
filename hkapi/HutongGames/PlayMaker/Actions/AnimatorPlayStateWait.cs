using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x0200098D RID: 2445
	[Tooltip("Plays an animator state and waits until it's completion. Will never finish if state or animator can not be found.")]
	public class AnimatorPlayStateWait : FsmStateAction
	{
		// Token: 0x060035AA RID: 13738 RVA: 0x0013CFFD File Offset: 0x0013B1FD
		public override void Reset()
		{
			this.target = null;
			this.stateName = null;
			this.finishEvent = null;
		}

		// Token: 0x060035AB RID: 13739 RVA: 0x0013D014 File Offset: 0x0013B214
		public override void OnEnter()
		{
			this.hasWaited = false;
			this.resumeTime = null;
			GameObject safe = this.target.GetSafe(this);
			if (safe)
			{
				this.animator = safe.GetComponent<Animator>();
				if (this.animator)
				{
					this.animator.Play(this.stateName.Value);
				}
			}
		}

		// Token: 0x060035AC RID: 13740 RVA: 0x0013D078 File Offset: 0x0013B278
		public override void OnUpdate()
		{
			if (this.hasWaited)
			{
				if (this.animator && this.resumeTime == null)
				{
					this.resumeTime = new float?(this.animator.GetCurrentAnimatorStateInfo(0).length + Time.time);
				}
				if (this.resumeTime != null)
				{
					float time = Time.time;
					float? num = this.resumeTime;
					if (time >= num.GetValueOrDefault() & num != null)
					{
						base.Fsm.Event(this.finishEvent);
						return;
					}
				}
			}
			else
			{
				this.hasWaited = true;
			}
		}

		// Token: 0x0400373A RID: 14138
		public FsmOwnerDefault target;

		// Token: 0x0400373B RID: 14139
		public FsmString stateName;

		// Token: 0x0400373C RID: 14140
		public FsmEvent finishEvent;

		// Token: 0x0400373D RID: 14141
		private Animator animator;

		// Token: 0x0400373E RID: 14142
		private bool hasWaited;

		// Token: 0x0400373F RID: 14143
		private float? resumeTime;
	}
}
