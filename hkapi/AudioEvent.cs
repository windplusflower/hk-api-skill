using System;
using UnityEngine;

// Token: 0x020000A7 RID: 167
[Serializable]
public struct AudioEvent
{
	// Token: 0x06000392 RID: 914 RVA: 0x00012C6C File Offset: 0x00010E6C
	public void Reset()
	{
		this.PitchMin = 0.75f;
		this.PitchMax = 1.25f;
		this.Volume = 1f;
	}

	// Token: 0x06000393 RID: 915 RVA: 0x00012C8F File Offset: 0x00010E8F
	public float SelectPitch()
	{
		if (Mathf.Approximately(this.PitchMin, this.PitchMax))
		{
			return this.PitchMax;
		}
		return UnityEngine.Random.Range(this.PitchMin, this.PitchMax);
	}

	// Token: 0x06000394 RID: 916 RVA: 0x00012CBC File Offset: 0x00010EBC
	public void SpawnAndPlayOneShot(AudioSource prefab, Vector3 position)
	{
		if (this.Clip == null)
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
		audioSource.PlayOneShot(this.Clip);
	}

	// Token: 0x040002F8 RID: 760
	public AudioClip Clip;

	// Token: 0x040002F9 RID: 761
	public float PitchMin;

	// Token: 0x040002FA RID: 762
	public float PitchMax;

	// Token: 0x040002FB RID: 763
	public float Volume;
}
