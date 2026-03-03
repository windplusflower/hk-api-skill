using System;
using UnityEngine;
using UnityEngine.Audio;

// Token: 0x020000B1 RID: 177
public class GateSetAudio : MonoBehaviour
{
	// Token: 0x060003B9 RID: 953 RVA: 0x00013462 File Offset: 0x00011662
	private void OnTriggerEnter2D(Collider2D otherCollider)
	{
		if (otherCollider.gameObject.tag == "Player")
		{
			this.atmosSnapshot.TransitionTo(this.transitionTime);
			this.enviroSnapshot.TransitionTo(this.transitionTime);
		}
	}

	// Token: 0x0400033A RID: 826
	public AudioMixerSnapshot atmosSnapshot;

	// Token: 0x0400033B RID: 827
	public AudioMixerSnapshot enviroSnapshot;

	// Token: 0x0400033C RID: 828
	public float transitionTime;
}
