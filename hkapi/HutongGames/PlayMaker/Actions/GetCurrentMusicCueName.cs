using System;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000991 RID: 2449
	[ActionCategory(ActionCategory.Audio)]
	[Tooltip("Get's the name of the currently playing music cue.")]
	public class GetCurrentMusicCueName : FsmStateAction
	{
		// Token: 0x060035B7 RID: 13751 RVA: 0x0013D26E File Offset: 0x0013B46E
		public override void Reset()
		{
			this.musicCueName = new FsmString
			{
				UseVariable = true
			};
		}

		// Token: 0x060035B8 RID: 13752 RVA: 0x0013D284 File Offset: 0x0013B484
		public override void OnEnter()
		{
			GameManager unsafeInstance = GameManager.UnsafeInstance;
			if (unsafeInstance == null)
			{
				this.musicCueName.Value = "";
			}
			else
			{
				MusicCue currentMusicCue = unsafeInstance.AudioManager.CurrentMusicCue;
				if (currentMusicCue == null)
				{
					this.musicCueName.Value = "";
				}
				else
				{
					this.musicCueName.Value = currentMusicCue.name;
				}
			}
			base.Finish();
		}

		// Token: 0x04003746 RID: 14150
		public FsmString musicCueName;
	}
}
