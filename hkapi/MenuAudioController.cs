using System;
using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

// Token: 0x020000B5 RID: 181
public class MenuAudioController : MonoBehaviour
{
	// Token: 0x060003CD RID: 973 RVA: 0x000139E5 File Offset: 0x00011BE5
	private void Awake()
	{
		this.audioSource = base.GetComponent<AudioSource>();
	}

	// Token: 0x060003CE RID: 974 RVA: 0x000139F3 File Offset: 0x00011BF3
	private IEnumerator Start()
	{
		if (UnityEngine.SceneManagement.SceneManager.GetActiveScene().name != "Pre_Menu_Intro")
		{
			float startVol = this.audioSource.volume;
			this.audioSource.volume = 0f;
			yield return GameManager.instance.timeTool.TimeScaleIndependentWaitForSeconds(1f);
			this.audioSource.volume = startVol;
		}
		yield break;
	}

	// Token: 0x060003CF RID: 975 RVA: 0x00013A02 File Offset: 0x00011C02
	public void PlaySelect()
	{
		if (this.select)
		{
			this.audioSource.PlayOneShot(this.select);
		}
	}

	// Token: 0x060003D0 RID: 976 RVA: 0x00013A22 File Offset: 0x00011C22
	public void PlaySubmit()
	{
		if (this.submit)
		{
			this.audioSource.PlayOneShot(this.submit);
		}
	}

	// Token: 0x060003D1 RID: 977 RVA: 0x00013A42 File Offset: 0x00011C42
	public void PlayCancel()
	{
		if (this.cancel)
		{
			this.audioSource.PlayOneShot(this.cancel);
		}
	}

	// Token: 0x060003D2 RID: 978 RVA: 0x00013A62 File Offset: 0x00011C62
	public void PlaySlider()
	{
		if (this.slider)
		{
			this.audioSource.PlayOneShot(this.slider);
		}
	}

	// Token: 0x060003D3 RID: 979 RVA: 0x00013A82 File Offset: 0x00011C82
	public void PlayStartGame()
	{
		if (this.startGame)
		{
			this.audioSource.PlayOneShot(this.startGame);
		}
	}

	// Token: 0x04000356 RID: 854
	private AudioSource audioSource;

	// Token: 0x04000357 RID: 855
	[Header("Sound Effects")]
	public AudioClip select;

	// Token: 0x04000358 RID: 856
	public AudioClip submit;

	// Token: 0x04000359 RID: 857
	public AudioClip cancel;

	// Token: 0x0400035A RID: 858
	public AudioClip slider;

	// Token: 0x0400035B RID: 859
	public AudioClip startGame;
}
