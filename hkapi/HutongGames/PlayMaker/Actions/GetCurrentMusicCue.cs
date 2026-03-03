using System;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000990 RID: 2448
	[ActionCategory(ActionCategory.Audio)]
	[Tooltip("Get's the currently playing music cue.")]
	public class GetCurrentMusicCue : FsmStateAction
	{
		// Token: 0x060035B4 RID: 13748 RVA: 0x0013D212 File Offset: 0x0013B412
		public override void Reset()
		{
			this.musicCue = new FsmObject
			{
				UseVariable = true
			};
		}

		// Token: 0x060035B5 RID: 13749 RVA: 0x0013D228 File Offset: 0x0013B428
		public override void OnEnter()
		{
			GameManager unsafeInstance = GameManager.UnsafeInstance;
			if (unsafeInstance == null)
			{
				this.musicCue.Value = null;
			}
			else
			{
				this.musicCue.Value = unsafeInstance.AudioManager.CurrentMusicCue;
			}
			base.Finish();
		}

		// Token: 0x04003745 RID: 14149
		[ObjectType(typeof(MusicCue))]
		public FsmObject musicCue;
	}
}
