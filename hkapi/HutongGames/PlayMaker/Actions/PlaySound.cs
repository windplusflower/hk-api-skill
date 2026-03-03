using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000C4E RID: 3150
	[ActionCategory(ActionCategory.Audio)]
	[Tooltip("Plays an Audio Clip at a position defined by a Game Object or Vector3. If a position is defined, it takes priority over the game object. This action doesn't require an Audio Source component, but offers less control than Audio actions.")]
	public class PlaySound : FsmStateAction
	{
		// Token: 0x060041F0 RID: 16880 RVA: 0x0016EA6F File Offset: 0x0016CC6F
		public override void Reset()
		{
			this.gameObject = null;
			this.position = new FsmVector3
			{
				UseVariable = true
			};
			this.clip = null;
			this.volume = 1f;
		}

		// Token: 0x060041F1 RID: 16881 RVA: 0x0016EAA1 File Offset: 0x0016CCA1
		public override void OnEnter()
		{
			this.DoPlaySound();
			base.Finish();
		}

		// Token: 0x060041F2 RID: 16882 RVA: 0x0016EAB0 File Offset: 0x0016CCB0
		private void DoPlaySound()
		{
			AudioClip x = this.clip.Value as AudioClip;
			if (x == null)
			{
				base.LogWarning("Missing Audio Clip!");
				return;
			}
			if (!this.position.IsNone)
			{
				AudioSource.PlayClipAtPoint(x, this.position.Value, this.volume.Value);
				return;
			}
			GameObject ownerDefaultTarget = base.Fsm.GetOwnerDefaultTarget(this.gameObject);
			if (ownerDefaultTarget == null)
			{
				return;
			}
			AudioSource.PlayClipAtPoint(x, ownerDefaultTarget.transform.position, this.volume.Value);
		}

		// Token: 0x060041F3 RID: 16883 RVA: 0x0016EB45 File Offset: 0x0016CD45
		public PlaySound()
		{
			this.volume = 1f;
			base..ctor();
		}

		// Token: 0x04004663 RID: 18019
		public FsmOwnerDefault gameObject;

		// Token: 0x04004664 RID: 18020
		public FsmVector3 position;

		// Token: 0x04004665 RID: 18021
		[RequiredField]
		[Title("Audio Clip")]
		[ObjectType(typeof(AudioClip))]
		public FsmObject clip;

		// Token: 0x04004666 RID: 18022
		[HasFloatSlider(0f, 1f)]
		public FsmFloat volume;
	}
}
