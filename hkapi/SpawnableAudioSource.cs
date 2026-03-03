using System;
using UnityEngine;

// Token: 0x020000C5 RID: 197
[RequireComponent(typeof(AudioSource))]
public class SpawnableAudioSource : MonoBehaviour
{
	// Token: 0x0600040B RID: 1035 RVA: 0x00014381 File Offset: 0x00012581
	private void Awake()
	{
		this.audioSource = base.GetComponent<AudioSource>();
	}

	// Token: 0x0600040C RID: 1036 RVA: 0x0001438F File Offset: 0x0001258F
	protected void OnEnable()
	{
		this.framesPassed = 0;
	}

	// Token: 0x0600040D RID: 1037 RVA: 0x00014398 File Offset: 0x00012598
	protected void Update()
	{
		this.framesPassed++;
		if (this.framesPassed > 5 && !this.audioSource.isPlaying)
		{
			this.Recycle<SpawnableAudioSource>();
		}
	}

	// Token: 0x0600040E RID: 1038 RVA: 0x000143C4 File Offset: 0x000125C4
	public void Stop()
	{
		this.audioSource.Stop();
	}

	// Token: 0x04000391 RID: 913
	private AudioSource audioSource;

	// Token: 0x04000392 RID: 914
	private const int MinimumFrames = 5;

	// Token: 0x04000393 RID: 915
	private int framesPassed;
}
