using System;
using UnityEngine;

// Token: 0x02000514 RID: 1300
public class VibrationPlayer : MonoBehaviour
{
	// Token: 0x17000380 RID: 896
	// (get) Token: 0x06001C95 RID: 7317 RVA: 0x00085D1B File Offset: 0x00083F1B
	// (set) Token: 0x06001C96 RID: 7318 RVA: 0x00085D24 File Offset: 0x00083F24
	public VibrationData VibrationData
	{
		get
		{
			return this.data;
		}
		set
		{
			if (this.data.LowFidelityVibration != value.LowFidelityVibration || this.data.HighFidelityVibration != value.HighFidelityVibration || this.data.GamepadVibration != value.GamepadVibration)
			{
				this.data = value;
				this.Stop();
			}
		}
	}

	// Token: 0x17000381 RID: 897
	// (get) Token: 0x06001C97 RID: 7319 RVA: 0x00085D84 File Offset: 0x00083F84
	// (set) Token: 0x06001C98 RID: 7320 RVA: 0x00085D8C File Offset: 0x00083F8C
	public VibrationTarget Target
	{
		get
		{
			return this.target;
		}
		set
		{
			if (this.target.Motors != value.Motors)
			{
				this.target = value;
				if (this.emission != null)
				{
					this.emission.Target = this.target;
				}
			}
		}
	}

	// Token: 0x17000382 RID: 898
	// (get) Token: 0x06001C99 RID: 7321 RVA: 0x00085DC2 File Offset: 0x00083FC2
	// (set) Token: 0x06001C9A RID: 7322 RVA: 0x00085DCA File Offset: 0x00083FCA
	public bool PlayAutomatically
	{
		get
		{
			return this.playAutomatically;
		}
		set
		{
			this.playAutomatically = value;
		}
	}

	// Token: 0x17000383 RID: 899
	// (get) Token: 0x06001C9B RID: 7323 RVA: 0x00085DD3 File Offset: 0x00083FD3
	// (set) Token: 0x06001C9C RID: 7324 RVA: 0x00085DDB File Offset: 0x00083FDB
	public bool IsLooping
	{
		get
		{
			return this.isLooping;
		}
		set
		{
			this.isLooping = value;
			if (this.emission != null)
			{
				this.emission.IsLooping = this.isLooping;
			}
		}
	}

	// Token: 0x17000384 RID: 900
	// (get) Token: 0x06001C9D RID: 7325 RVA: 0x00085DFD File Offset: 0x00083FFD
	// (set) Token: 0x06001C9E RID: 7326 RVA: 0x00085E05 File Offset: 0x00084005
	public string VibrationTag
	{
		get
		{
			return this.vibrationTag;
		}
		set
		{
			this.vibrationTag = value;
			if (this.emission != null)
			{
				this.emission.Tag = this.vibrationTag;
			}
		}
	}

	// Token: 0x06001C9F RID: 7327 RVA: 0x00085E27 File Offset: 0x00084027
	protected void OnEnable()
	{
		if (this.playAutomatically)
		{
			this.Play();
		}
	}

	// Token: 0x06001CA0 RID: 7328 RVA: 0x00085E37 File Offset: 0x00084037
	protected void OnDisable()
	{
		this.Stop();
	}

	// Token: 0x06001CA1 RID: 7329 RVA: 0x00085E3F File Offset: 0x0008403F
	public void Play()
	{
		if (this.emission != null)
		{
			this.emission.Stop();
		}
		this.emission = VibrationManager.PlayVibrationClipOneShot(this.data, new VibrationTarget?(this.target), this.isLooping, this.vibrationTag);
	}

	// Token: 0x06001CA2 RID: 7330 RVA: 0x00085E7C File Offset: 0x0008407C
	public void Stop()
	{
		if (this.emission != null)
		{
			this.emission.Stop();
			this.emission = null;
		}
	}

	// Token: 0x04002223 RID: 8739
	[SerializeField]
	private VibrationData data;

	// Token: 0x04002224 RID: 8740
	[SerializeField]
	private VibrationTarget target;

	// Token: 0x04002225 RID: 8741
	[SerializeField]
	private bool playAutomatically;

	// Token: 0x04002226 RID: 8742
	[SerializeField]
	private bool isLooping;

	// Token: 0x04002227 RID: 8743
	[SerializeField]
	private string vibrationTag;

	// Token: 0x04002228 RID: 8744
	private VibrationEmission emission;
}
