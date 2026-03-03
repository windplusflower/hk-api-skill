using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000C74 RID: 3188
	[ActionCategory(ActionCategory.Animation)]
	[Tooltip("Removes a mixing transform previously added with Add Mixing Transform. If transform has been added as recursive, then it will be removed as recursive. Once you remove all mixing transforms added to animation state all curves become animated again.")]
	public class RemoveMixingTransform : BaseAnimationAction
	{
		// Token: 0x060042A2 RID: 17058 RVA: 0x00170AC3 File Offset: 0x0016ECC3
		public override void Reset()
		{
			this.gameObject = null;
			this.animationName = "";
		}

		// Token: 0x060042A3 RID: 17059 RVA: 0x00170ADC File Offset: 0x0016ECDC
		public override void OnEnter()
		{
			this.DoRemoveMixingTransform();
			base.Finish();
		}

		// Token: 0x060042A4 RID: 17060 RVA: 0x00170AEC File Offset: 0x0016ECEC
		private void DoRemoveMixingTransform()
		{
			GameObject ownerDefaultTarget = base.Fsm.GetOwnerDefaultTarget(this.gameObject);
			if (!base.UpdateCache(ownerDefaultTarget))
			{
				return;
			}
			AnimationState animationState = base.animation[this.animationName.Value];
			if (animationState == null)
			{
				return;
			}
			Transform mix = ownerDefaultTarget.transform.Find(this.transfrom.Value);
			animationState.AddMixingTransform(mix);
		}

		// Token: 0x04004703 RID: 18179
		[RequiredField]
		[CheckForComponent(typeof(Animation))]
		[Tooltip("The GameObject playing the animation.")]
		public FsmOwnerDefault gameObject;

		// Token: 0x04004704 RID: 18180
		[RequiredField]
		[Tooltip("The name of the animation.")]
		public FsmString animationName;

		// Token: 0x04004705 RID: 18181
		[RequiredField]
		[Tooltip("The mixing transform to remove. E.g., root/upper_body/left_shoulder")]
		public FsmString transfrom;
	}
}
