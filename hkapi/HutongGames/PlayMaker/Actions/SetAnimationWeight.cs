using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000C93 RID: 3219
	[ActionCategory(ActionCategory.Animation)]
	[Tooltip("Sets the Blend Weight of an Animation. Check Every Frame to update the weight continuosly, e.g., if you're manipulating a variable that controls the weight.")]
	public class SetAnimationWeight : BaseAnimationAction
	{
		// Token: 0x06004334 RID: 17204 RVA: 0x001728E1 File Offset: 0x00170AE1
		public override void Reset()
		{
			this.gameObject = null;
			this.animName = null;
			this.weight = 1f;
			this.everyFrame = false;
		}

		// Token: 0x06004335 RID: 17205 RVA: 0x00172908 File Offset: 0x00170B08
		public override void OnEnter()
		{
			this.DoSetAnimationWeight((this.gameObject.OwnerOption == OwnerDefaultOption.UseOwner) ? base.Owner : this.gameObject.GameObject.Value);
			if (!this.everyFrame)
			{
				base.Finish();
			}
		}

		// Token: 0x06004336 RID: 17206 RVA: 0x00172943 File Offset: 0x00170B43
		public override void OnUpdate()
		{
			this.DoSetAnimationWeight((this.gameObject.OwnerOption == OwnerDefaultOption.UseOwner) ? base.Owner : this.gameObject.GameObject.Value);
		}

		// Token: 0x06004337 RID: 17207 RVA: 0x00172970 File Offset: 0x00170B70
		private void DoSetAnimationWeight(GameObject go)
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
			animationState.weight = this.weight.Value;
		}

		// Token: 0x06004338 RID: 17208 RVA: 0x001729D4 File Offset: 0x00170BD4
		public SetAnimationWeight()
		{
			this.weight = 1f;
			base..ctor();
		}

		// Token: 0x04004785 RID: 18309
		[RequiredField]
		[CheckForComponent(typeof(Animation))]
		public FsmOwnerDefault gameObject;

		// Token: 0x04004786 RID: 18310
		[RequiredField]
		[UIHint(UIHint.Animation)]
		public FsmString animName;

		// Token: 0x04004787 RID: 18311
		public FsmFloat weight;

		// Token: 0x04004788 RID: 18312
		public bool everyFrame;
	}
}
