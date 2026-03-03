using System;
using UnityEngine;
using UnityEngine.Audio;

// Token: 0x020000C3 RID: 195
public class SetSceneAudio : MonoBehaviour
{
	// Token: 0x06000406 RID: 1030 RVA: 0x00014326 File Offset: 0x00012526
	private void Start()
	{
		this.atmosSnapshot.TransitionTo(this.transitionTime);
		this.enviroSnapshot.TransitionTo(this.transitionTime);
		this.actorSnapshot.TransitionTo(this.transitionTime);
	}

	// Token: 0x0400038A RID: 906
	public AudioMixerSnapshot atmosSnapshot;

	// Token: 0x0400038B RID: 907
	public AudioMixerSnapshot enviroSnapshot;

	// Token: 0x0400038C RID: 908
	public AudioMixerSnapshot actorSnapshot;

	// Token: 0x0400038D RID: 909
	public float transitionTime;
}
