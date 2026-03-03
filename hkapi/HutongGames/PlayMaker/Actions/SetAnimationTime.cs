using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000C92 RID: 3218
	[ActionCategory(ActionCategory.Animation)]
	[Tooltip("Sets the current Time of an Animation, Normalize time means 0 (start) to 1 (end); useful if you don't care about the exact time. Check Every Frame to update the time continuosly.")]
	public class SetAnimationTime : BaseAnimationAction
	{
		// Token: 0x0600432F RID: 17199 RVA: 0x001727A8 File Offset: 0x001709A8
		public override void Reset()
		{
			this.gameObject = null;
			this.animName = null;
			this.time = null;
			this.normalized = false;
			this.everyFrame = false;
		}

		// Token: 0x06004330 RID: 17200 RVA: 0x001727CD File Offset: 0x001709CD
		public override void OnEnter()
		{
			this.DoSetAnimationTime((this.gameObject.OwnerOption == OwnerDefaultOption.UseOwner) ? base.Owner : this.gameObject.GameObject.Value);
			if (!this.everyFrame)
			{
				base.Finish();
			}
		}

		// Token: 0x06004331 RID: 17201 RVA: 0x00172808 File Offset: 0x00170A08
		public override void OnUpdate()
		{
			this.DoSetAnimationTime((this.gameObject.OwnerOption == OwnerDefaultOption.UseOwner) ? base.Owner : this.gameObject.GameObject.Value);
		}

		// Token: 0x06004332 RID: 17202 RVA: 0x00172838 File Offset: 0x00170A38
		private void DoSetAnimationTime(GameObject go)
		{
			if (!base.UpdateCache(go))
			{
				return;
			}
			base.animation.Play(this.animName.Value);
			AnimationState animationState = base.animation[this.animName.Value];
			if (animationState == null)
			{
				base.LogWarning("Missing animation: " + this.animName.Value);
				return;
			}
			if (this.normalized)
			{
				animationState.normalizedTime = this.time.Value;
			}
			else
			{
				animationState.time = this.time.Value;
			}
			if (this.everyFrame)
			{
				animationState.speed = 0f;
			}
		}

		// Token: 0x04004780 RID: 18304
		[RequiredField]
		[CheckForComponent(typeof(Animation))]
		public FsmOwnerDefault gameObject;

		// Token: 0x04004781 RID: 18305
		[RequiredField]
		[UIHint(UIHint.Animation)]
		public FsmString animName;

		// Token: 0x04004782 RID: 18306
		public FsmFloat time;

		// Token: 0x04004783 RID: 18307
		public bool normalized;

		// Token: 0x04004784 RID: 18308
		public bool everyFrame;
	}
}
