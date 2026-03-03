using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x020008D3 RID: 2259
	[ActionCategory(ActionCategory.Animator)]
	[Tooltip("Stops the animator playback mode. When playback stops, the avatar resumes getting control from game logic")]
	public class AnimatorStopPlayback : FsmStateAction
	{
		// Token: 0x06003250 RID: 12880 RVA: 0x00131A4A File Offset: 0x0012FC4A
		public override void Reset()
		{
			this.gameObject = null;
		}

		// Token: 0x06003251 RID: 12881 RVA: 0x00131A54 File Offset: 0x0012FC54
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
				component.StopPlayback();
			}
			base.Finish();
		}

		// Token: 0x040033A2 RID: 13218
		[RequiredField]
		[CheckForComponent(typeof(Animator))]
		[Tooltip("The target. An Animator component is required")]
		public FsmOwnerDefault gameObject;
	}
}
