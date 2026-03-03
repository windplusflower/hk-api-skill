using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x020008D1 RID: 2257
	[ActionCategory(ActionCategory.Animator)]
	[Tooltip("Sets the animator in playback mode.")]
	public class AnimatorStartPlayback : FsmStateAction
	{
		// Token: 0x0600324A RID: 12874 RVA: 0x0013198B File Offset: 0x0012FB8B
		public override void Reset()
		{
			this.gameObject = null;
		}

		// Token: 0x0600324B RID: 12875 RVA: 0x00131994 File Offset: 0x0012FB94
		public override void OnEnter()
		{
			GameObject ownerDefaultTarget = base.Fsm.GetOwnerDefaultTarget(this.gameObject);
			if (ownerDefaultTarget == null)
			{
				base.Finish();
				return;
			}
			Animator component = ownerDefaultTarget.GetComponent<Animator>();
			if (component != null)
			{
				component.StartPlayback();
			}
			base.Finish();
		}

		// Token: 0x0400339F RID: 13215
		[RequiredField]
		[CheckForComponent(typeof(Animator))]
		[Tooltip("The target. An Animator component is required")]
		public FsmOwnerDefault gameObject;
	}
}
