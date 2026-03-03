using System;
using System.Collections;
using GlobalEnums;
using UnityEngine;

// Token: 0x020000B2 RID: 178
public class HeroAudioController : MonoBehaviour
{
	// Token: 0x060003BB RID: 955 RVA: 0x0001349D File Offset: 0x0001169D
	private void Awake()
	{
		this.heroCtrl = base.GetComponent<HeroController>();
	}

	// Token: 0x060003BC RID: 956 RVA: 0x000134AC File Offset: 0x000116AC
	public void PlaySound(HeroSounds soundEffect)
	{
		if (!this.heroCtrl.cState.isPaused)
		{
			switch (soundEffect)
			{
			case HeroSounds.FOOTSTEPS_RUN:
				if (!this.footStepsRun.isPlaying && !this.softLanding.isPlaying)
				{
					this.footStepsRun.Play();
					return;
				}
				break;
			case HeroSounds.FOOTSTEPS_WALK:
				if (!this.footStepsWalk.isPlaying && !this.softLanding.isPlaying)
				{
					this.footStepsWalk.Play();
					return;
				}
				break;
			case HeroSounds.JUMP:
				this.RandomizePitch(this.jump, 0.9f, 1.1f);
				this.jump.Play();
				return;
			case HeroSounds.WALLJUMP:
				this.RandomizePitch(this.walljump, 0.9f, 1.1f);
				this.walljump.Play();
				return;
			case HeroSounds.SOFT_LANDING:
				this.RandomizePitch(this.jump, 0.9f, 1.1f);
				this.softLanding.Play();
				return;
			case HeroSounds.HARD_LANDING:
				this.hardLanding.Play();
				return;
			case HeroSounds.BACKDASH:
				this.backDash.Play();
				return;
			case HeroSounds.DASH:
				this.dash.Play();
				return;
			case HeroSounds.TAKE_HIT:
				this.takeHit.Play();
				return;
			case HeroSounds.WALLSLIDE:
				this.wallslide.Play();
				return;
			case HeroSounds.NAIL_ART_CHARGE:
				this.nailArtCharge.Play();
				return;
			case HeroSounds.NAIL_ART_READY:
				this.nailArtReady.Play();
				return;
			case HeroSounds.FALLING:
				this.fallingCo = base.StartCoroutine(this.FadeInVolume(this.falling, 0.7f));
				this.falling.Play();
				break;
			default:
				return;
			}
		}
	}

	// Token: 0x060003BD RID: 957 RVA: 0x0001363C File Offset: 0x0001183C
	public void StopSound(HeroSounds soundEffect)
	{
		if (soundEffect == HeroSounds.FOOTSTEPS_RUN)
		{
			this.footStepsRun.Stop();
			return;
		}
		if (soundEffect == HeroSounds.FOOTSTEPS_WALK)
		{
			this.footStepsWalk.Stop();
			return;
		}
		switch (soundEffect)
		{
		case HeroSounds.WALLSLIDE:
			this.wallslide.Stop();
			return;
		case HeroSounds.NAIL_ART_CHARGE:
			this.nailArtCharge.Stop();
			return;
		case HeroSounds.NAIL_ART_READY:
			this.nailArtReady.Stop();
			return;
		case HeroSounds.FALLING:
			this.falling.Stop();
			if (this.fallingCo != null)
			{
				base.StopCoroutine(this.fallingCo);
			}
			return;
		default:
			return;
		}
	}

	// Token: 0x060003BE RID: 958 RVA: 0x000136C8 File Offset: 0x000118C8
	public void StopAllSounds()
	{
		this.softLanding.Stop();
		this.hardLanding.Stop();
		this.jump.Stop();
		this.takeHit.Stop();
		this.backDash.Stop();
		this.dash.Stop();
		this.footStepsRun.Stop();
		this.footStepsWalk.Stop();
		this.wallslide.Stop();
		this.nailArtCharge.Stop();
		this.nailArtReady.Stop();
		this.falling.Stop();
	}

	// Token: 0x060003BF RID: 959 RVA: 0x0001375C File Offset: 0x0001195C
	public void PauseAllSounds()
	{
		this.softLanding.Pause();
		this.hardLanding.Pause();
		this.jump.Pause();
		this.takeHit.Pause();
		this.backDash.Pause();
		this.dash.Pause();
		this.footStepsRun.Pause();
		this.footStepsWalk.Pause();
		this.wallslide.Pause();
		this.nailArtCharge.Pause();
		this.nailArtReady.Pause();
		this.falling.Pause();
	}

	// Token: 0x060003C0 RID: 960 RVA: 0x000137F0 File Offset: 0x000119F0
	public void UnPauseAllSounds()
	{
		this.softLanding.UnPause();
		this.hardLanding.UnPause();
		this.jump.UnPause();
		this.takeHit.UnPause();
		this.backDash.UnPause();
		this.dash.UnPause();
		this.footStepsRun.UnPause();
		this.footStepsWalk.UnPause();
		this.wallslide.UnPause();
		this.nailArtCharge.UnPause();
		this.nailArtReady.UnPause();
		this.falling.UnPause();
	}

	// Token: 0x060003C1 RID: 961 RVA: 0x00013884 File Offset: 0x00011A84
	private void RandomizePitch(AudioSource src, float minPitch, float maxPitch)
	{
		float pitch = UnityEngine.Random.Range(minPitch, maxPitch);
		src.pitch = pitch;
	}

	// Token: 0x060003C2 RID: 962 RVA: 0x000138A0 File Offset: 0x00011AA0
	private void ResetPitch(AudioSource src)
	{
		src.pitch = 1f;
	}

	// Token: 0x060003C3 RID: 963 RVA: 0x000138AD File Offset: 0x00011AAD
	private IEnumerator FadeInVolume(AudioSource src, float duration)
	{
		float elapsedTime = 0f;
		src.volume = 0f;
		while (elapsedTime < duration)
		{
			elapsedTime += Time.deltaTime;
			float t = elapsedTime / duration;
			src.volume = Mathf.Lerp(0f, 1f, t);
			yield return null;
		}
		yield break;
	}

	// Token: 0x0400033D RID: 829
	private HeroController heroCtrl;

	// Token: 0x0400033E RID: 830
	[Header("Sound Effects")]
	public AudioSource softLanding;

	// Token: 0x0400033F RID: 831
	public AudioSource hardLanding;

	// Token: 0x04000340 RID: 832
	public AudioSource jump;

	// Token: 0x04000341 RID: 833
	public AudioSource takeHit;

	// Token: 0x04000342 RID: 834
	public AudioSource backDash;

	// Token: 0x04000343 RID: 835
	public AudioSource dash;

	// Token: 0x04000344 RID: 836
	public AudioSource footStepsRun;

	// Token: 0x04000345 RID: 837
	public AudioSource footStepsWalk;

	// Token: 0x04000346 RID: 838
	public AudioSource wallslide;

	// Token: 0x04000347 RID: 839
	public AudioSource nailArtCharge;

	// Token: 0x04000348 RID: 840
	public AudioSource nailArtReady;

	// Token: 0x04000349 RID: 841
	public AudioSource falling;

	// Token: 0x0400034A RID: 842
	public AudioSource walljump;

	// Token: 0x0400034B RID: 843
	private Coroutine fallingCo;
}
