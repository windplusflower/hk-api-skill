using System;
using UnityEngine;

// Token: 0x020005B1 RID: 1457
[AddComponentMenu("2D Toolkit/UI/Core/tk2dUIAudioManager")]
public class tk2dUIAudioManager : MonoBehaviour
{
	// Token: 0x17000448 RID: 1096
	// (get) Token: 0x060020EF RID: 8431 RVA: 0x000A56F8 File Offset: 0x000A38F8
	public static tk2dUIAudioManager Instance
	{
		get
		{
			if (tk2dUIAudioManager.instance == null)
			{
				tk2dUIAudioManager.instance = (UnityEngine.Object.FindObjectOfType(typeof(tk2dUIAudioManager)) as tk2dUIAudioManager);
				if (tk2dUIAudioManager.instance == null)
				{
					tk2dUIAudioManager.instance = new GameObject("tk2dUIAudioManager").AddComponent<tk2dUIAudioManager>();
				}
			}
			return tk2dUIAudioManager.instance;
		}
	}

	// Token: 0x060020F0 RID: 8432 RVA: 0x000A5751 File Offset: 0x000A3951
	private void Awake()
	{
		if (tk2dUIAudioManager.instance == null)
		{
			tk2dUIAudioManager.instance = this;
		}
		else if (tk2dUIAudioManager.instance != this)
		{
			UnityEngine.Object.Destroy(this);
			return;
		}
		this.Setup();
	}

	// Token: 0x060020F1 RID: 8433 RVA: 0x000A5784 File Offset: 0x000A3984
	private void Setup()
	{
		if (this.audioSrc == null)
		{
			this.audioSrc = base.gameObject.GetComponent<AudioSource>();
		}
		if (this.audioSrc == null)
		{
			this.audioSrc = base.gameObject.AddComponent<AudioSource>();
			this.audioSrc.playOnAwake = false;
		}
	}

	// Token: 0x060020F2 RID: 8434 RVA: 0x000A57DB File Offset: 0x000A39DB
	public void Play(AudioClip clip)
	{
		this.audioSrc.PlayOneShot(clip, AudioListener.volume);
	}

	// Token: 0x04002677 RID: 9847
	private static tk2dUIAudioManager instance;

	// Token: 0x04002678 RID: 9848
	private AudioSource audioSrc;
}
