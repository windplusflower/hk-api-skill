using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000B2D RID: 2861
	[ActionCategory(ActionCategory.Audio)]
	[Tooltip("Stops playing the Audio Clip played by an Audio Source component on a Game Object.")]
	public class AudioStop : FsmStateAction
	{
		// Token: 0x06003D38 RID: 15672 RVA: 0x00160481 File Offset: 0x0015E681
		public override void Reset()
		{
			this.gameObject = null;
		}

		// Token: 0x06003D39 RID: 15673 RVA: 0x0016048C File Offset: 0x0015E68C
		public override void OnEnter()
		{
			GameObject ownerDefaultTarget = base.Fsm.GetOwnerDefaultTarget(this.gameObject);
			if (ownerDefaultTarget != null)
			{
				AudioSource component = ownerDefaultTarget.GetComponent<AudioSource>();
				if (component != null)
				{
					component.Stop();
				}
			}
			base.Finish();
		}

		// Token: 0x04004143 RID: 16707
		[RequiredField]
		[CheckForComponent(typeof(AudioSource))]
		[Tooltip("The GameObject with an AudioSource component.")]
		public FsmOwnerDefault gameObject;
	}
}
