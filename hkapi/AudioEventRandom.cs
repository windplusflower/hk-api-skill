using System;
using UnityEngine;

// Token: 0x020000A8 RID: 168
[Serializable]
public struct AudioEventRandom
{
	// Token: 0x06000395 RID: 917 RVA: 0x00012D1A File Offset: 0x00010F1A
	public void Reset()
	{
		this.PitchMin = 0.75f;
		this.PitchMax = 1.25f;
		this.Volume = 1f;
	}

	// Token: 0x06000396 RID: 918 RVA: 0x00012D3D File Offset: 0x00010F3D
	public float SelectPitch()
	{
		if (Mathf.Approximately(this.PitchMin, this.PitchMax))
		{
			return this.PitchMax;
		}
		return UnityEngine.Random.Range(this.PitchMin, this.PitchMax);
	}

	// Token: 0x06000397 RID: 919 RVA: 0x00012D6C File Offset: 0x00010F6C
	public void SpawnAndPlayOneShot(AudioSource prefab, Vector3 position)
	{
		if (this.Clips.Length == 0)
		{
			return;
		}
		AudioClip audioClip = this.Clips[UnityEngine.Random.Range(0, this.Clips.Length)];
		if (audioClip == null)
		{
			return;
		}
		if (this.Volume < Mathf.Epsilon)
		{
			return;
		}
		if (prefab == null)
		{
			return;
		}
		AudioSource audioSource = prefab.Spawn(position);
		audioSource.volume = this.Volume;
		audioSource.pitch = this.SelectPitch();
		audioSource.PlayOneShot(audioClip);
	}

	// Token: 0x040002FC RID: 764
	public AudioClip[] Clips;

	// Token: 0x040002FD RID: 765
	public float PitchMin;

	// Token: 0x040002FE RID: 766
	public float PitchMax;

	// Token: 0x040002FF RID: 767
	public float Volume;
}
