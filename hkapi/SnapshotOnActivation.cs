using System;
using UnityEngine;
using UnityEngine.Audio;

// Token: 0x020000C4 RID: 196
public class SnapshotOnActivation : MonoBehaviour
{
	// Token: 0x06000408 RID: 1032 RVA: 0x0001435B File Offset: 0x0001255B
	private void OnEnable()
	{
		this.activationSnapshot.TransitionTo(this.transitionTime);
	}

	// Token: 0x06000409 RID: 1033 RVA: 0x0001436E File Offset: 0x0001256E
	private void OnDisable()
	{
		this.deactivationSnapshot.TransitionTo(this.transitionTime);
	}

	// Token: 0x0400038E RID: 910
	public AudioMixerSnapshot activationSnapshot;

	// Token: 0x0400038F RID: 911
	public AudioMixerSnapshot deactivationSnapshot;

	// Token: 0x04000390 RID: 912
	public float transitionTime;
}
