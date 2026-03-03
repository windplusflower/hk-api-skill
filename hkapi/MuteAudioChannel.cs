using System;
using UnityEngine;
using UnityEngine.Audio;

// Token: 0x020000BD RID: 189
public class MuteAudioChannel : MonoBehaviour
{
	// Token: 0x17000075 RID: 117
	// (get) Token: 0x060003F1 RID: 1009 RVA: 0x00013F2C File Offset: 0x0001212C
	// (set) Token: 0x060003F2 RID: 1010 RVA: 0x00013F67 File Offset: 0x00012167
	public float Volume
	{
		get
		{
			float dB = 0f;
			if (this.mixer)
			{
				this.mixer.GetFloat(this.exposedProperty, out dB);
			}
			return this.DecibelToLinear(dB);
		}
		set
		{
			if (this.mixer)
			{
				this.mixer.SetFloat(this.exposedProperty, this.LinearToDecibel(value));
			}
		}
	}

	// Token: 0x060003F3 RID: 1011 RVA: 0x00013F8F File Offset: 0x0001218F
	private void OnEnable()
	{
		if (this.mixer)
		{
			this.initialVolume = this.Volume;
			this.Volume = 0f;
		}
	}

	// Token: 0x060003F4 RID: 1012 RVA: 0x00013FB5 File Offset: 0x000121B5
	private void OnDisable()
	{
		if (this.mixer)
		{
			this.Volume = this.initialVolume;
		}
	}

	// Token: 0x060003F5 RID: 1013 RVA: 0x00013FD0 File Offset: 0x000121D0
	private float LinearToDecibel(float linear)
	{
		float result;
		if (linear != 0f)
		{
			result = 20f * Mathf.Log10(linear);
		}
		else
		{
			result = -144f;
		}
		return result;
	}

	// Token: 0x060003F6 RID: 1014 RVA: 0x00013FFB File Offset: 0x000121FB
	private float DecibelToLinear(float dB)
	{
		return Mathf.Pow(10f, dB / 20f);
	}

	// Token: 0x060003F7 RID: 1015 RVA: 0x0001400E File Offset: 0x0001220E
	public MuteAudioChannel()
	{
		this.exposedProperty = "volActors";
		base..ctor();
	}

	// Token: 0x0400037B RID: 891
	public AudioMixer mixer;

	// Token: 0x0400037C RID: 892
	public string exposedProperty;

	// Token: 0x0400037D RID: 893
	private float initialVolume;
}
