using System;
using System.Collections;
using UnityEngine;
using UnityEngine.Audio;

// Token: 0x020000AA RID: 170
public class AudioManager : MonoBehaviour
{
	// Token: 0x17000062 RID: 98
	// (get) Token: 0x0600039B RID: 923 RVA: 0x00012EDD File Offset: 0x000110DD
	public MusicCue CurrentMusicCue
	{
		get
		{
			return this.currentMusicCue;
		}
	}

	// Token: 0x0600039C RID: 924 RVA: 0x00003603 File Offset: 0x00001803
	protected void Start()
	{
	}

	// Token: 0x0600039D RID: 925 RVA: 0x00012EE8 File Offset: 0x000110E8
	public void ApplyAtmosCue(AtmosCue atmosCue, float transitionTime)
	{
		if (atmosCue == null)
		{
			Debug.LogError("Unable to apply null AtmosCue");
			return;
		}
		if (this.applyAtmosCueRoutine != null)
		{
			base.StopCoroutine(this.applyAtmosCueRoutine);
			this.applyAtmosCueRoutine = null;
		}
		base.StartCoroutine(this.applyAtmosCueRoutine = this.BeginApplyAtmosCue(atmosCue, transitionTime));
	}

	// Token: 0x0600039E RID: 926 RVA: 0x00012F3C File Offset: 0x0001113C
	protected IEnumerator BeginApplyAtmosCue(AtmosCue atmosCue, float transitionTime)
	{
		this.currentAtmosCue = atmosCue;
		atmosCue.Snapshot.TransitionTo(transitionTime);
		for (int i = 0; i < this.atmosSources.Length; i++)
		{
			if (atmosCue.IsChannelEnabled((AtmosChannels)i))
			{
				AudioSource audioSource = this.atmosSources[i];
				if (!audioSource.isPlaying)
				{
					audioSource.Play();
				}
			}
		}
		yield return new WaitForSecondsRealtime(transitionTime);
		for (int j = 0; j < this.atmosSources.Length; j++)
		{
			if (!atmosCue.IsChannelEnabled((AtmosChannels)j))
			{
				AudioSource audioSource2 = this.atmosSources[j];
				if (audioSource2.isPlaying)
				{
					audioSource2.Stop();
				}
			}
		}
		yield break;
	}

	// Token: 0x0600039F RID: 927 RVA: 0x00012F5C File Offset: 0x0001115C
	public void ApplyMusicCue(MusicCue musicCue, float delayTime, float transitionTime, bool applySnapshot)
	{
		if (musicCue == null)
		{
			Debug.LogError("Unable to apply null MusicCue");
			return;
		}
		GameManager unsafeInstance = GameManager.UnsafeInstance;
		if (unsafeInstance != null)
		{
			PlayerData playerData = unsafeInstance.playerData;
			if (playerData != null)
			{
				MusicCue y = musicCue;
				musicCue = musicCue.ResolveAlternatives(playerData);
				musicCue != y;
			}
		}
		if (this.currentMusicCue == musicCue)
		{
			return;
		}
		if (this.applyMusicCueRoutine != null)
		{
			base.StopCoroutine(this.applyMusicCueRoutine);
			this.applyMusicCueRoutine = null;
		}
		base.StartCoroutine(this.applyMusicCueRoutine = this.BeginApplyMusicCue(musicCue, delayTime, transitionTime, applySnapshot));
	}

	// Token: 0x060003A0 RID: 928 RVA: 0x00012FF0 File Offset: 0x000111F0
	protected IEnumerator BeginApplyMusicCue(MusicCue musicCue, float delayTime, float transitionTime, bool applySnapshot)
	{
		this.currentMusicCue = musicCue;
		yield return new WaitForSecondsRealtime(delayTime);
		for (int i = 0; i < this.musicSources.Length; i++)
		{
			AudioSource audioSource = this.musicSources[i];
			audioSource.Stop();
			audioSource.clip = null;
		}
		for (int j = 0; j < this.musicSources.Length; j++)
		{
			AudioSource audioSource2 = this.musicSources[j];
			MusicCue.MusicChannelInfo channelInfo = musicCue.GetChannelInfo((MusicChannels)j);
			if (channelInfo != null && channelInfo.IsEnabled)
			{
				if (audioSource2.clip != channelInfo.Clip)
				{
					audioSource2.clip = channelInfo.Clip;
				}
				audioSource2.volume = 1f;
				audioSource2.Play();
			}
			this.UpdateMusicSync((MusicChannels)j, channelInfo != null && channelInfo.IsSyncRequired);
		}
		yield return new WaitForSecondsRealtime(transitionTime);
		for (int k = 0; k < this.musicSources.Length; k++)
		{
			MusicCue.MusicChannelInfo channelInfo2 = musicCue.GetChannelInfo((MusicChannels)k);
			if (channelInfo2 == null || !channelInfo2.IsEnabled)
			{
				AudioSource audioSource3 = this.musicSources[k];
				if (audioSource3.isPlaying)
				{
					audioSource3.clip = null;
					audioSource3.Stop();
				}
			}
		}
		yield break;
	}

	// Token: 0x060003A1 RID: 929 RVA: 0x00013014 File Offset: 0x00011214
	private void UpdateMusicSync(MusicChannels musicChannel, bool isSyncRequired)
	{
		switch (musicChannel)
		{
		case MusicChannels.Main:
			break;
		case MusicChannels.MainAlt:
			this.audioLoopMaster.SetSyncMainAlt(isSyncRequired);
			return;
		case MusicChannels.Action:
			this.audioLoopMaster.SetSyncAction(isSyncRequired);
			return;
		case MusicChannels.Sub:
			this.audioLoopMaster.SetSyncSub(isSyncRequired);
			return;
		case MusicChannels.Tension:
			this.audioLoopMaster.SetSyncTension(isSyncRequired);
			return;
		case MusicChannels.Extra:
			this.audioLoopMaster.SetSyncExtra(isSyncRequired);
			break;
		default:
			return;
		}
	}

	// Token: 0x060003A2 RID: 930 RVA: 0x00013080 File Offset: 0x00011280
	public void ApplyMusicSnapshot(AudioMixerSnapshot snapshot, float delayTime, float transitionTime)
	{
		if (this.applyMusicSnapshotRoutine != null)
		{
			base.StopCoroutine(this.applyMusicSnapshotRoutine);
			this.applyMusicSnapshotRoutine = null;
		}
		if (snapshot != null)
		{
			base.StartCoroutine(this.applyMusicSnapshotRoutine = this.BeginApplyMusicSnapshot(snapshot, delayTime, transitionTime));
		}
	}

	// Token: 0x060003A3 RID: 931 RVA: 0x000130CA File Offset: 0x000112CA
	protected IEnumerator BeginApplyMusicSnapshot(AudioMixerSnapshot snapshot, float delayTime, float transitionTime)
	{
		if (delayTime > Mathf.Epsilon)
		{
			yield return new WaitForSecondsRealtime(delayTime);
		}
		if (snapshot != null)
		{
			snapshot.TransitionTo(transitionTime);
		}
		yield break;
	}

	// Token: 0x04000307 RID: 775
	[SerializeField]
	[ArrayForEnum(typeof(AtmosChannels))]
	private AudioSource[] atmosSources;

	// Token: 0x04000308 RID: 776
	private AtmosCue currentAtmosCue;

	// Token: 0x04000309 RID: 777
	private IEnumerator applyAtmosCueRoutine;

	// Token: 0x0400030A RID: 778
	[SerializeField]
	private AudioLoopMaster audioLoopMaster;

	// Token: 0x0400030B RID: 779
	[SerializeField]
	[ArrayForEnum(typeof(MusicChannels))]
	private AudioSource[] musicSources;

	// Token: 0x0400030C RID: 780
	private MusicCue currentMusicCue;

	// Token: 0x0400030D RID: 781
	private IEnumerator applyMusicCueRoutine;

	// Token: 0x0400030E RID: 782
	private IEnumerator applyMusicSnapshotRoutine;
}
