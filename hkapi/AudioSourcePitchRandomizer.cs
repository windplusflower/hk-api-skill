using System;
using UnityEngine;

// Token: 0x020000B0 RID: 176
[RequireComponent(typeof(AudioSource))]
public class AudioSourcePitchRandomizer : MonoBehaviour
{
	// Token: 0x060003B7 RID: 951 RVA: 0x0001341A File Offset: 0x0001161A
	private void Awake()
	{
		this.audioSource = base.GetComponent<AudioSource>();
		this.audioSource.pitch = UnityEngine.Random.Range(this.pitchLower, this.pitchUpper);
	}

	// Token: 0x060003B8 RID: 952 RVA: 0x00013444 File Offset: 0x00011644
	public AudioSourcePitchRandomizer()
	{
		this.pitchLower = 1f;
		this.pitchUpper = 1f;
		base..ctor();
	}

	// Token: 0x04000337 RID: 823
	[Header("Randomize Pitch")]
	[Range(0.75f, 1f)]
	public float pitchLower;

	// Token: 0x04000338 RID: 824
	[Range(1f, 1.25f)]
	public float pitchUpper;

	// Token: 0x04000339 RID: 825
	private AudioSource audioSource;
}
