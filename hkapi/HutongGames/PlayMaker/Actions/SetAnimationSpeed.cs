using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000C91 RID: 3217
	[ActionCategory(ActionCategory.Animation)]
	[Tooltip("Sets the Speed of an Animation. Check Every Frame to update the animation time continuosly, e.g., if you're manipulating a variable that controls animation speed.")]
	public class SetAnimationSpeed : BaseAnimationAction
	{
		// Token: 0x0600432A RID: 17194 RVA: 0x0017269D File Offset: 0x0017089D
		public override void Reset()
		{
			this.gameObject = null;
			this.animName = null;
			this.speed = 1f;
			this.everyFrame = false;
		}

		// Token: 0x0600432B RID: 17195 RVA: 0x001726C4 File Offset: 0x001708C4
		public override void OnEnter()
		{
			this.DoSetAnimationSpeed((this.gameObject.OwnerOption == OwnerDefaultOption.UseOwner) ? base.Owner : this.gameObject.GameObject.Value);
			if (!this.everyFrame)
			{
				base.Finish();
			}
		}

		// Token: 0x0600432C RID: 17196 RVA: 0x001726FF File Offset: 0x001708FF
		public override void OnUpdate()
		{
			this.DoSetAnimationSpeed((this.gameObject.OwnerOption == OwnerDefaultOption.UseOwner) ? base.Owner : this.gameObject.GameObject.Value);
		}

		// Token: 0x0600432D RID: 17197 RVA: 0x0017272C File Offset: 0x0017092C
		private void DoSetAnimationSpeed(GameObject go)
		{
			if (!base.UpdateCache(go))
			{
				return;
			}
			AnimationState animationState = base.animation[this.animName.Value];
			if (animationState == null)
			{
				base.LogWarning("Missing animation: " + this.animName.Value);
				return;
			}
			animationState.speed = this.speed.Value;
		}

		// Token: 0x0600432E RID: 17198 RVA: 0x00172790 File Offset: 0x00170990
		public SetAnimationSpeed()
		{
			this.speed = 1f;
			base..ctor();
		}

		// Token: 0x0400477C RID: 18300
		[RequiredField]
		[CheckForComponent(typeof(Animation))]
		public FsmOwnerDefault gameObject;

		// Token: 0x0400477D RID: 18301
		[RequiredField]
		[UIHint(UIHint.Animation)]
		public FsmString animName;

		// Token: 0x0400477E RID: 18302
		public FsmFloat speed;

		// Token: 0x0400477F RID: 18303
		public bool everyFrame;
	}
}
