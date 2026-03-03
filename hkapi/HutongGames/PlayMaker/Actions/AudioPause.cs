using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000B29 RID: 2857
	[ActionCategory(ActionCategory.Audio)]
	[Tooltip("Pauses playing the Audio Clip played by an Audio Source component on a Game Object.")]
	public class AudioPause : FsmStateAction
	{
		// Token: 0x06003D2A RID: 15658 RVA: 0x00160107 File Offset: 0x0015E307
		public override void Reset()
		{
			this.gameObject = null;
		}

		// Token: 0x06003D2B RID: 15659 RVA: 0x00160110 File Offset: 0x0015E310
		public override void OnEnter()
		{
			GameObject ownerDefaultTarget = base.Fsm.GetOwnerDefaultTarget(this.gameObject);
			if (ownerDefaultTarget != null)
			{
				AudioSource component = ownerDefaultTarget.GetComponent<AudioSource>();
				if (component != null)
				{
					component.Pause();
				}
			}
			base.Finish();
		}

		// Token: 0x04004136 RID: 16694
		[RequiredField]
		[CheckForComponent(typeof(AudioSource))]
		[Tooltip("The GameObject with an Audio Source component.")]
		public FsmOwnerDefault gameObject;
	}
}
