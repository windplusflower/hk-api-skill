using System;
using UnityEngine;

// Token: 0x02000175 RID: 373
public class CycloneDust : MonoBehaviour
{
	// Token: 0x06000891 RID: 2193 RVA: 0x0002F081 File Offset: 0x0002D281
	private void Start()
	{
		this.parent = base.transform.parent;
	}

	// Token: 0x06000892 RID: 2194 RVA: 0x0002F094 File Offset: 0x0002D294
	private void OnEnable()
	{
		this.playing = false;
		this.particle.Stop();
	}

	// Token: 0x06000893 RID: 2195 RVA: 0x0002F0A8 File Offset: 0x0002D2A8
	private void Update()
	{
		if (this.parent.position.y < this.dustY)
		{
			if (!this.playing)
			{
				this.particle.Play();
				this.playing = true;
				return;
			}
		}
		else if (this.playing)
		{
			this.particle.Stop();
			this.playing = false;
		}
	}

	// Token: 0x04000978 RID: 2424
	public float dustY;

	// Token: 0x04000979 RID: 2425
	public ParticleSystem particle;

	// Token: 0x0400097A RID: 2426
	private Transform parent;

	// Token: 0x0400097B RID: 2427
	private bool playing;
}
