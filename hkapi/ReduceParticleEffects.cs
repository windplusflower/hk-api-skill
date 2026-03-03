using System;
using UnityEngine;

// Token: 0x02000144 RID: 324
public class ReduceParticleEffects : MonoBehaviour
{
	// Token: 0x06000786 RID: 1926 RVA: 0x0002AAF4 File Offset: 0x00028CF4
	private void Start()
	{
		this.gm = GameManager.instance;
		this.gm.RefreshParticleLevel += this.SetEmission;
		this.emitter = base.GetComponent<ParticleSystem>();
		this.emissionRateHigh = ((this.emitter != null) ? this.emitter.emissionRate : 1f);
		this.emissionRateLow = this.emissionRateHigh / 2f;
		this.maxParticlesHigh = ((this.emitter != null) ? this.emitter.maxParticles : 20);
		this.maxParticlesLow = this.maxParticlesHigh / 2;
		this.SetEmission();
		this.init = true;
	}

	// Token: 0x06000787 RID: 1927 RVA: 0x0002ABA8 File Offset: 0x00028DA8
	private void SetEmission()
	{
		if (this.emitter != null)
		{
			if (this.gm.gameSettings.particleEffectsLevel == 0)
			{
				this.emitter.emissionRate = this.emissionRateLow;
				this.emitter.maxParticles = this.maxParticlesLow;
				return;
			}
			this.emitter.emissionRate = this.emissionRateHigh;
			this.emitter.maxParticles = this.maxParticlesHigh;
		}
	}

	// Token: 0x06000788 RID: 1928 RVA: 0x0002AC1A File Offset: 0x00028E1A
	private void OnEnable()
	{
		if (this.init)
		{
			this.gm.RefreshParticleLevel += this.SetEmission;
		}
	}

	// Token: 0x06000789 RID: 1929 RVA: 0x0002AC3B File Offset: 0x00028E3B
	private void OnDisable()
	{
		if (this.init)
		{
			this.gm.RefreshParticleLevel -= this.SetEmission;
		}
	}

	// Token: 0x04000853 RID: 2131
	private GameManager gm;

	// Token: 0x04000854 RID: 2132
	private ParticleSystem emitter;

	// Token: 0x04000855 RID: 2133
	private float emissionRateHigh;

	// Token: 0x04000856 RID: 2134
	private float emissionRateLow;

	// Token: 0x04000857 RID: 2135
	private int maxParticlesHigh;

	// Token: 0x04000858 RID: 2136
	private int maxParticlesLow;

	// Token: 0x04000859 RID: 2137
	private bool init;
}
