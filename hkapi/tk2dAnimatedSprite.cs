using System;
using UnityEngine;

// Token: 0x02000558 RID: 1368
[AddComponentMenu("2D Toolkit/Sprite/tk2dAnimatedSprite (Obsolete)")]
public class tk2dAnimatedSprite : tk2dSprite
{
	// Token: 0x170003CD RID: 973
	// (get) Token: 0x06001E08 RID: 7688 RVA: 0x00095732 File Offset: 0x00093932
	public tk2dSpriteAnimator Animator
	{
		get
		{
			this.CheckAddAnimatorInternal();
			return this._animator;
		}
	}

	// Token: 0x06001E09 RID: 7689 RVA: 0x00095740 File Offset: 0x00093940
	private void CheckAddAnimatorInternal()
	{
		if (this._animator == null)
		{
			this._animator = base.gameObject.GetComponent<tk2dSpriteAnimator>();
			if (this._animator == null)
			{
				this._animator = base.gameObject.AddComponent<tk2dSpriteAnimator>();
				this._animator.Library = this.anim;
				this._animator.DefaultClipId = this.clipId;
				this._animator.playAutomatically = this.playAutomatically;
			}
		}
	}

	// Token: 0x06001E0A RID: 7690 RVA: 0x000957BE File Offset: 0x000939BE
	protected override bool NeedBoxCollider()
	{
		return this.createCollider;
	}

	// Token: 0x170003CE RID: 974
	// (get) Token: 0x06001E0B RID: 7691 RVA: 0x000957C6 File Offset: 0x000939C6
	// (set) Token: 0x06001E0C RID: 7692 RVA: 0x000957D3 File Offset: 0x000939D3
	public tk2dSpriteAnimation Library
	{
		get
		{
			return this.Animator.Library;
		}
		set
		{
			this.Animator.Library = value;
		}
	}

	// Token: 0x170003CF RID: 975
	// (get) Token: 0x06001E0D RID: 7693 RVA: 0x000957E1 File Offset: 0x000939E1
	// (set) Token: 0x06001E0E RID: 7694 RVA: 0x000957EE File Offset: 0x000939EE
	public int DefaultClipId
	{
		get
		{
			return this.Animator.DefaultClipId;
		}
		set
		{
			this.Animator.DefaultClipId = value;
		}
	}

	// Token: 0x170003D0 RID: 976
	// (get) Token: 0x06001E0F RID: 7695 RVA: 0x000957FC File Offset: 0x000939FC
	// (set) Token: 0x06001E10 RID: 7696 RVA: 0x00095803 File Offset: 0x00093A03
	public static bool g_paused
	{
		get
		{
			return tk2dSpriteAnimator.g_Paused;
		}
		set
		{
			tk2dSpriteAnimator.g_Paused = value;
		}
	}

	// Token: 0x170003D1 RID: 977
	// (get) Token: 0x06001E11 RID: 7697 RVA: 0x0009580B File Offset: 0x00093A0B
	// (set) Token: 0x06001E12 RID: 7698 RVA: 0x00095818 File Offset: 0x00093A18
	public bool Paused
	{
		get
		{
			return this.Animator.Paused;
		}
		set
		{
			this.Animator.Paused = value;
		}
	}

	// Token: 0x06001E13 RID: 7699 RVA: 0x00095828 File Offset: 0x00093A28
	private void ProxyCompletedHandler(tk2dSpriteAnimator anim, tk2dSpriteAnimationClip clip)
	{
		if (this.animationCompleteDelegate != null)
		{
			int num = -1;
			tk2dSpriteAnimationClip[] array = (anim.Library != null) ? anim.Library.clips : null;
			if (array != null)
			{
				for (int i = 0; i < array.Length; i++)
				{
					if (array[i] == clip)
					{
						num = i;
						break;
					}
				}
			}
			this.animationCompleteDelegate(this, num);
		}
	}

	// Token: 0x06001E14 RID: 7700 RVA: 0x00095884 File Offset: 0x00093A84
	private void ProxyEventTriggeredHandler(tk2dSpriteAnimator anim, tk2dSpriteAnimationClip clip, int frame)
	{
		if (this.animationEventDelegate != null)
		{
			this.animationEventDelegate(this, clip, clip.frames[frame], frame);
		}
	}

	// Token: 0x06001E15 RID: 7701 RVA: 0x000958A4 File Offset: 0x00093AA4
	private void OnEnable()
	{
		this.Animator.AnimationCompleted = new Action<tk2dSpriteAnimator, tk2dSpriteAnimationClip>(this.ProxyCompletedHandler);
		this.Animator.AnimationEventTriggered = new Action<tk2dSpriteAnimator, tk2dSpriteAnimationClip, int>(this.ProxyEventTriggeredHandler);
	}

	// Token: 0x06001E16 RID: 7702 RVA: 0x000958D4 File Offset: 0x00093AD4
	private void OnDisable()
	{
		this.Animator.AnimationCompleted = null;
		this.Animator.AnimationEventTriggered = null;
	}

	// Token: 0x06001E17 RID: 7703 RVA: 0x000958EE File Offset: 0x00093AEE
	private void Start()
	{
		this.CheckAddAnimatorInternal();
	}

	// Token: 0x06001E18 RID: 7704 RVA: 0x000958F8 File Offset: 0x00093AF8
	public static tk2dAnimatedSprite AddComponent(GameObject go, tk2dSpriteAnimation anim, int clipId)
	{
		tk2dSpriteAnimationClip tk2dSpriteAnimationClip = anim.clips[clipId];
		tk2dAnimatedSprite tk2dAnimatedSprite = go.AddComponent<tk2dAnimatedSprite>();
		tk2dAnimatedSprite.SetSprite(tk2dSpriteAnimationClip.frames[0].spriteCollection, tk2dSpriteAnimationClip.frames[0].spriteId);
		tk2dAnimatedSprite.anim = anim;
		return tk2dAnimatedSprite;
	}

	// Token: 0x06001E19 RID: 7705 RVA: 0x0009593B File Offset: 0x00093B3B
	public void Play()
	{
		if (this.Animator.DefaultClip != null)
		{
			this.Animator.Play(this.Animator.DefaultClip);
		}
	}

	// Token: 0x06001E1A RID: 7706 RVA: 0x00095960 File Offset: 0x00093B60
	public void Play(float clipStartTime)
	{
		if (this.Animator.DefaultClip != null)
		{
			this.Animator.PlayFrom(this.Animator.DefaultClip, clipStartTime);
		}
	}

	// Token: 0x06001E1B RID: 7707 RVA: 0x00095986 File Offset: 0x00093B86
	public void PlayFromFrame(int frame)
	{
		if (this.Animator.DefaultClip != null)
		{
			this.Animator.PlayFromFrame(this.Animator.DefaultClip, frame);
		}
	}

	// Token: 0x06001E1C RID: 7708 RVA: 0x000959AC File Offset: 0x00093BAC
	public void Play(string name)
	{
		this.Animator.Play(name);
	}

	// Token: 0x06001E1D RID: 7709 RVA: 0x000959BA File Offset: 0x00093BBA
	public void PlayFromFrame(string name, int frame)
	{
		this.Animator.PlayFromFrame(name, frame);
	}

	// Token: 0x06001E1E RID: 7710 RVA: 0x000959C9 File Offset: 0x00093BC9
	public void Play(string name, float clipStartTime)
	{
		this.Animator.PlayFrom(name, clipStartTime);
	}

	// Token: 0x06001E1F RID: 7711 RVA: 0x000959D8 File Offset: 0x00093BD8
	public void Play(tk2dSpriteAnimationClip clip, float clipStartTime)
	{
		this.Animator.PlayFrom(clip, clipStartTime);
	}

	// Token: 0x06001E20 RID: 7712 RVA: 0x000959E7 File Offset: 0x00093BE7
	public void Play(tk2dSpriteAnimationClip clip, float clipStartTime, float overrideFps)
	{
		this.Animator.Play(clip, clipStartTime, overrideFps);
	}

	// Token: 0x170003D2 RID: 978
	// (get) Token: 0x06001E21 RID: 7713 RVA: 0x000959F7 File Offset: 0x00093BF7
	public tk2dSpriteAnimationClip CurrentClip
	{
		get
		{
			return this.Animator.CurrentClip;
		}
	}

	// Token: 0x170003D3 RID: 979
	// (get) Token: 0x06001E22 RID: 7714 RVA: 0x00095A04 File Offset: 0x00093C04
	public float ClipTimeSeconds
	{
		get
		{
			return this.Animator.ClipTimeSeconds;
		}
	}

	// Token: 0x170003D4 RID: 980
	// (get) Token: 0x06001E23 RID: 7715 RVA: 0x00095A11 File Offset: 0x00093C11
	// (set) Token: 0x06001E24 RID: 7716 RVA: 0x00095A1E File Offset: 0x00093C1E
	public float ClipFps
	{
		get
		{
			return this.Animator.ClipFps;
		}
		set
		{
			this.Animator.ClipFps = value;
		}
	}

	// Token: 0x06001E25 RID: 7717 RVA: 0x00095A2C File Offset: 0x00093C2C
	public void Stop()
	{
		this.Animator.Stop();
	}

	// Token: 0x06001E26 RID: 7718 RVA: 0x00095A39 File Offset: 0x00093C39
	public void StopAndResetFrame()
	{
		this.Animator.StopAndResetFrame();
	}

	// Token: 0x06001E27 RID: 7719 RVA: 0x00095A46 File Offset: 0x00093C46
	[Obsolete]
	public bool isPlaying()
	{
		return this.Animator.Playing;
	}

	// Token: 0x06001E28 RID: 7720 RVA: 0x00095A53 File Offset: 0x00093C53
	public bool IsPlaying(string name)
	{
		return this.Animator.IsPlaying(name);
	}

	// Token: 0x06001E29 RID: 7721 RVA: 0x00095A61 File Offset: 0x00093C61
	public bool IsPlaying(tk2dSpriteAnimationClip clip)
	{
		return this.Animator.IsPlaying(clip);
	}

	// Token: 0x170003D5 RID: 981
	// (get) Token: 0x06001E2A RID: 7722 RVA: 0x00095A46 File Offset: 0x00093C46
	public bool Playing
	{
		get
		{
			return this.Animator.Playing;
		}
	}

	// Token: 0x06001E2B RID: 7723 RVA: 0x00095A6F File Offset: 0x00093C6F
	public int GetClipIdByName(string name)
	{
		return this.Animator.GetClipIdByName(name);
	}

	// Token: 0x06001E2C RID: 7724 RVA: 0x00095A7D File Offset: 0x00093C7D
	public tk2dSpriteAnimationClip GetClipByName(string name)
	{
		return this.Animator.GetClipByName(name);
	}

	// Token: 0x170003D6 RID: 982
	// (get) Token: 0x06001E2D RID: 7725 RVA: 0x00095A8B File Offset: 0x00093C8B
	public static float DefaultFps
	{
		get
		{
			return tk2dSpriteAnimator.DefaultFps;
		}
	}

	// Token: 0x06001E2E RID: 7726 RVA: 0x00095A92 File Offset: 0x00093C92
	public void Pause()
	{
		this.Animator.Pause();
	}

	// Token: 0x06001E2F RID: 7727 RVA: 0x00095A9F File Offset: 0x00093C9F
	public void Resume()
	{
		this.Animator.Resume();
	}

	// Token: 0x06001E30 RID: 7728 RVA: 0x00095AAC File Offset: 0x00093CAC
	public void SetFrame(int currFrame)
	{
		this.Animator.SetFrame(currFrame);
	}

	// Token: 0x06001E31 RID: 7729 RVA: 0x00095ABA File Offset: 0x00093CBA
	public void SetFrame(int currFrame, bool triggerEvent)
	{
		this.Animator.SetFrame(currFrame, triggerEvent);
	}

	// Token: 0x06001E32 RID: 7730 RVA: 0x00095AC9 File Offset: 0x00093CC9
	public void UpdateAnimation(float deltaTime)
	{
		this.Animator.UpdateAnimation(deltaTime);
	}

	// Token: 0x040023AB RID: 9131
	[SerializeField]
	private tk2dSpriteAnimator _animator;

	// Token: 0x040023AC RID: 9132
	[SerializeField]
	private tk2dSpriteAnimation anim;

	// Token: 0x040023AD RID: 9133
	[SerializeField]
	private int clipId;

	// Token: 0x040023AE RID: 9134
	public bool playAutomatically;

	// Token: 0x040023AF RID: 9135
	public bool createCollider;

	// Token: 0x040023B0 RID: 9136
	public tk2dAnimatedSprite.AnimationCompleteDelegate animationCompleteDelegate;

	// Token: 0x040023B1 RID: 9137
	public tk2dAnimatedSprite.AnimationEventDelegate animationEventDelegate;

	// Token: 0x02000559 RID: 1369
	// (Invoke) Token: 0x06001E35 RID: 7733
	public delegate void AnimationCompleteDelegate(tk2dAnimatedSprite sprite, int clipId);

	// Token: 0x0200055A RID: 1370
	// (Invoke) Token: 0x06001E39 RID: 7737
	public delegate void AnimationEventDelegate(tk2dAnimatedSprite sprite, tk2dSpriteAnimationClip clip, tk2dSpriteAnimationFrame frame, int frameNum);
}
