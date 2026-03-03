using System;
using UnityEngine;

// Token: 0x020000C1 RID: 193
public static class RandomAudioClipTableExtensions
{
	// Token: 0x06000400 RID: 1024 RVA: 0x0001419B File Offset: 0x0001239B
	public static void PlayOneShot(this RandomAudioClipTable table, AudioSource audioSource)
	{
		if (table == null)
		{
			return;
		}
		table.PlayOneShotUnsafe(audioSource);
	}

	// Token: 0x06000401 RID: 1025 RVA: 0x000141B0 File Offset: 0x000123B0
	public static void SpawnAndPlayOneShot(this RandomAudioClipTable table, AudioSource prefab, Vector3 position)
	{
		if (table == null)
		{
			return;
		}
		if (prefab == null)
		{
			return;
		}
		AudioClip audioClip = table.SelectClip();
		if (audioClip == null)
		{
			return;
		}
		AudioSource audioSource = prefab.Spawn<AudioSource>();
		audioSource.transform.position = position;
		audioSource.pitch = table.SelectPitch();
		audioSource.volume = 1f;
		audioSource.PlayOneShot(audioClip);
	}
}
