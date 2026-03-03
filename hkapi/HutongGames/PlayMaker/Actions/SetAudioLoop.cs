using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000C95 RID: 3221
	[ActionCategory(ActionCategory.Audio)]
	[Tooltip("Sets looping on the AudioSource component on a Game Object.")]
	public class SetAudioLoop : ComponentAction<AudioSource>
	{
		// Token: 0x0600433C RID: 17212 RVA: 0x00172A45 File Offset: 0x00170C45
		public override void Reset()
		{
			this.gameObject = null;
			this.loop = false;
		}

		// Token: 0x0600433D RID: 17213 RVA: 0x00172A5C File Offset: 0x00170C5C
		public override void OnEnter()
		{
			GameObject ownerDefaultTarget = base.Fsm.GetOwnerDefaultTarget(this.gameObject);
			if (base.UpdateCache(ownerDefaultTarget))
			{
				base.audio.loop = this.loop.Value;
			}
			base.Finish();
		}

		// Token: 0x0400478B RID: 18315
		[RequiredField]
		[CheckForComponent(typeof(AudioSource))]
		public FsmOwnerDefault gameObject;

		// Token: 0x0400478C RID: 18316
		public FsmBool loop;
	}
}
