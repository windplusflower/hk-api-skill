using System;
using System.Collections;
using GlobalEnums;
using UnityEngine;

// Token: 0x020001F0 RID: 496
public class AutoRecycleSelf : MonoBehaviour
{
	// Token: 0x06000AB6 RID: 2742 RVA: 0x00039A58 File Offset: 0x00037C58
	private void OnEnable()
	{
		if (this.afterEvent == AfterEvent.TIME)
		{
			if (this.timeToWait > 0f)
			{
				base.StartCoroutine(this.StartTimer(this.timeToWait));
				return;
			}
		}
		else
		{
			if (this.afterEvent == AfterEvent.LEVEL_UNLOAD)
			{
				GameManager.instance.DestroyPersonalPools += this.RecycleSelf;
				return;
			}
			if (this.afterEvent == AfterEvent.AUDIO_CLIP_END)
			{
				this.audioSource = base.GetComponent<AudioSource>();
				if (this.audioSource == null)
				{
					Debug.LogError(base.name + " requires an AudioSource to auto-recycle itself.");
					this.validAudioSource = false;
					return;
				}
				this.validAudioSource = true;
			}
		}
	}

	// Token: 0x06000AB7 RID: 2743 RVA: 0x00039AF8 File Offset: 0x00037CF8
	private void Update()
	{
		if (Time.frameCount % 20 == 0)
		{
			this.Update20();
		}
	}

	// Token: 0x06000AB8 RID: 2744 RVA: 0x00039B0A File Offset: 0x00037D0A
	private void Update20()
	{
		if (this.validAudioSource && !this.audioSource.isPlaying)
		{
			this.RecycleSelf();
		}
	}

	// Token: 0x06000AB9 RID: 2745 RVA: 0x00039B27 File Offset: 0x00037D27
	private void OnDisable()
	{
		if (this.afterEvent == AfterEvent.LEVEL_UNLOAD && !this.ApplicationIsQuitting)
		{
			GameManager.instance.DestroyPersonalPools -= this.RecycleSelf;
		}
	}

	// Token: 0x06000ABA RID: 2746 RVA: 0x00039B50 File Offset: 0x00037D50
	private void OnApplicationQuit()
	{
		this.ApplicationIsQuitting = true;
	}

	// Token: 0x06000ABB RID: 2747 RVA: 0x00039B59 File Offset: 0x00037D59
	private IEnumerator StartTimer(float wait)
	{
		yield return new WaitForSeconds(wait);
		this.gameObject.Recycle();
		yield break;
	}

	// Token: 0x06000ABC RID: 2748 RVA: 0x00035934 File Offset: 0x00033B34
	private void RecycleSelf()
	{
		base.gameObject.Recycle();
	}

	// Token: 0x04000BD9 RID: 3033
	[Header("Trigger Event Type")]
	public AfterEvent afterEvent;

	// Token: 0x04000BDA RID: 3034
	[Header("Time Event Settings")]
	public float timeToWait;

	// Token: 0x04000BDB RID: 3035
	private AudioSource audioSource;

	// Token: 0x04000BDC RID: 3036
	private bool validAudioSource;

	// Token: 0x04000BDD RID: 3037
	private bool ApplicationIsQuitting;
}
