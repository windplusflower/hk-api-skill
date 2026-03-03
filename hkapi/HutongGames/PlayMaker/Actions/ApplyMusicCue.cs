using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x0200098F RID: 2447
	[ActionCategory(ActionCategory.Audio)]
	[ActionTarget(typeof(MusicCue), "musicCue", false)]
	[Tooltip("Plays music cues.")]
	public class ApplyMusicCue : FsmStateAction
	{
		// Token: 0x060035B1 RID: 13745 RVA: 0x0013D170 File Offset: 0x0013B370
		public override void Reset()
		{
			this.musicCue = null;
			this.delayTime = 0f;
			this.transitionTime = 0f;
		}

		// Token: 0x060035B2 RID: 13746 RVA: 0x0013D19C File Offset: 0x0013B39C
		public override void OnEnter()
		{
			MusicCue x = this.musicCue.Value as MusicCue;
			GameManager instance = GameManager.instance;
			if (!(x == null))
			{
				if (instance == null)
				{
					Debug.LogErrorFormat(base.Owner, "Failed to play music cue, because the game manager is not ready", Array.Empty<object>());
				}
				else
				{
					instance.AudioManager.ApplyMusicCue(x, this.delayTime.Value, this.transitionTime.Value, false);
				}
			}
			base.Finish();
		}

		// Token: 0x04003742 RID: 14146
		[Tooltip("Music cue to play.")]
		[ObjectType(typeof(MusicCue))]
		public FsmObject musicCue;

		// Token: 0x04003743 RID: 14147
		[Tooltip("Delay before starting transition")]
		public FsmFloat delayTime;

		// Token: 0x04003744 RID: 14148
		[Tooltip("Transition duration.")]
		public FsmFloat transitionTime;
	}
}
