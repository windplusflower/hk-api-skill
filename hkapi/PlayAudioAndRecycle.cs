using System;
using UnityEngine;

// Token: 0x020000BE RID: 190
public class PlayAudioAndRecycle : MonoBehaviour
{
	// Token: 0x060003F8 RID: 1016 RVA: 0x00014021 File Offset: 0x00012221
	private void OnEnable()
	{
		this.audioSource.Play();
	}

	// Token: 0x060003F9 RID: 1017 RVA: 0x0001402E File Offset: 0x0001222E
	private void Update()
	{
		if (!this.audioSource.isPlaying)
		{
			base.gameObject.Recycle();
		}
	}

	// Token: 0x0400037E RID: 894
	public AudioSource audioSource;
}
