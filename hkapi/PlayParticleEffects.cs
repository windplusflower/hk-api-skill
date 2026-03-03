using System;
using UnityEngine;

// Token: 0x020004AB RID: 1195
public class PlayParticleEffects : MonoBehaviour
{
	// Token: 0x06001A8A RID: 6794 RVA: 0x0007F4A4 File Offset: 0x0007D6A4
	public void PlayParticleSystems()
	{
		for (int i = 0; i < this.particleEffects.Length; i++)
		{
			this.particleEffects[i].Play();
		}
	}

	// Token: 0x04001FEF RID: 8175
	public ParticleSystem[] particleEffects;
}
