using System;
using System.Collections;
using HutongGames.PlayMaker;
using UnityEngine;
using UnityEngine.Audio;

// Token: 0x020000BB RID: 187
public class MusicRegion : MonoBehaviour
{
	// Token: 0x060003E5 RID: 997 RVA: 0x00013C38 File Offset: 0x00011E38
	private void Reset()
	{
		PlayMakerFSM component = base.GetComponent<PlayMakerFSM>();
		if (component && component.FsmName == "Music Region")
		{
			FsmVariables fsmVariables = component.FsmVariables;
			this.dirtmouth = fsmVariables.GetFsmBool("Dirtmouth").Value;
			this.minesDelay = fsmVariables.GetFsmBool("Mines Delay").Value;
			this.enterMusicCue = (fsmVariables.GetFsmObject("Enter Music Cue").Value as MusicCue);
			this.enterMusicSnapshot = (fsmVariables.GetFsmObject("Enter Music Snapshot").Value as AudioMixerSnapshot);
			this.enterTrackEvent = fsmVariables.GetFsmString("Enter Track Event").Value;
			this.enterTransitionTime = fsmVariables.GetFsmFloat("Enter Transition Time").Value;
			this.exitMusicCue = (fsmVariables.GetFsmObject("Exit Music Cue").Value as MusicCue);
			this.exitMusicSnapshot = (fsmVariables.GetFsmObject("Exit Music Snapshot").Value as AudioMixerSnapshot);
			this.exitTrackEvent = fsmVariables.GetFsmString("Exit Track Event").Value;
			this.exitTransitionTime = fsmVariables.GetFsmFloat("Exit Transition Time").Value;
		}
	}

	// Token: 0x060003E6 RID: 998 RVA: 0x00013D63 File Offset: 0x00011F63
	private void OnTriggerEnter2D(Collider2D collision)
	{
		if (collision.gameObject.layer == 9)
		{
			if (this.fadeInRoutine != null)
			{
				base.StopCoroutine(this.fadeInRoutine);
			}
			this.fadeInRoutine = base.StartCoroutine(this.FadeIn());
		}
	}

	// Token: 0x060003E7 RID: 999 RVA: 0x00013D9A File Offset: 0x00011F9A
	private void OnTriggerExit2D(Collider2D collision)
	{
		if (collision.gameObject.layer == 9)
		{
			if (this.fadeInRoutine != null)
			{
				base.StopCoroutine(this.fadeInRoutine);
			}
			this.FadeOut();
		}
	}

	// Token: 0x060003E8 RID: 1000 RVA: 0x00013DC5 File Offset: 0x00011FC5
	private IEnumerator FadeIn()
	{
		if (this.minesDelay)
		{
			yield return new WaitForSeconds(2.35f);
		}
		float timeToReach = this.enterTransitionTime;
		if (this.dirtmouth)
		{
			MusicCue currentMusicCue = GameManager.instance.AudioManager.CurrentMusicCue;
			if ((currentMusicCue ? currentMusicCue.name : "") != "Dirtmouth")
			{
				timeToReach = 1f;
			}
		}
		if (this.enterMusicSnapshot != null)
		{
			this.enterMusicSnapshot.TransitionTo(timeToReach);
		}
		if (this.enterMusicCue)
		{
			GameManager.instance.AudioManager.ApplyMusicCue(this.enterMusicCue, 0f, 0f, false);
		}
		this.fadeInRoutine = null;
		yield break;
	}

	// Token: 0x060003E9 RID: 1001 RVA: 0x00013DD4 File Offset: 0x00011FD4
	private void FadeOut()
	{
		if (this.exitMusicSnapshot != null)
		{
			this.exitMusicSnapshot.TransitionTo(this.exitTransitionTime);
		}
		if (this.exitMusicCue)
		{
			GameManager.instance.AudioManager.ApplyMusicCue(this.exitMusicCue, 0f, 0f, false);
		}
	}

	// Token: 0x0400036D RID: 877
	public bool dirtmouth;

	// Token: 0x0400036E RID: 878
	public bool minesDelay;

	// Token: 0x0400036F RID: 879
	[Space]
	public MusicCue enterMusicCue;

	// Token: 0x04000370 RID: 880
	public AudioMixerSnapshot enterMusicSnapshot;

	// Token: 0x04000371 RID: 881
	public string enterTrackEvent;

	// Token: 0x04000372 RID: 882
	public float enterTransitionTime;

	// Token: 0x04000373 RID: 883
	[Space]
	public MusicCue exitMusicCue;

	// Token: 0x04000374 RID: 884
	public AudioMixerSnapshot exitMusicSnapshot;

	// Token: 0x04000375 RID: 885
	public string exitTrackEvent;

	// Token: 0x04000376 RID: 886
	public float exitTransitionTime;

	// Token: 0x04000377 RID: 887
	private Coroutine fadeInRoutine;
}
