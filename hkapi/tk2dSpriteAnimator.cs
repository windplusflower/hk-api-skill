using System;
using UnityEngine;

// Token: 0x02000566 RID: 1382
[AddComponentMenu("2D Toolkit/Sprite/tk2dSpriteAnimator")]
public class tk2dSpriteAnimator : MonoBehaviour
{
	// Token: 0x170003ED RID: 1005
	// (get) Token: 0x06001ED1 RID: 7889 RVA: 0x00099684 File Offset: 0x00097884
	// (set) Token: 0x06001ED2 RID: 7890 RVA: 0x00099690 File Offset: 0x00097890
	public static bool g_Paused
	{
		get
		{
			return (tk2dSpriteAnimator.globalState & tk2dSpriteAnimator.State.Paused) > tk2dSpriteAnimator.State.Init;
		}
		set
		{
			tk2dSpriteAnimator.globalState = (value ? tk2dSpriteAnimator.State.Paused : tk2dSpriteAnimator.State.Init);
		}
	}

	// Token: 0x170003EE RID: 1006
	// (get) Token: 0x06001ED3 RID: 7891 RVA: 0x0009969E File Offset: 0x0009789E
	// (set) Token: 0x06001ED4 RID: 7892 RVA: 0x000996AB File Offset: 0x000978AB
	public bool Paused
	{
		get
		{
			return (this.state & tk2dSpriteAnimator.State.Paused) > tk2dSpriteAnimator.State.Init;
		}
		set
		{
			if (value)
			{
				this.state |= tk2dSpriteAnimator.State.Paused;
				return;
			}
			this.state &= (tk2dSpriteAnimator.State)(-3);
		}
	}

	// Token: 0x170003EF RID: 1007
	// (get) Token: 0x06001ED5 RID: 7893 RVA: 0x000996CE File Offset: 0x000978CE
	// (set) Token: 0x06001ED6 RID: 7894 RVA: 0x000996D6 File Offset: 0x000978D6
	public tk2dSpriteAnimation Library
	{
		get
		{
			return this.library;
		}
		set
		{
			this.library = value;
		}
	}

	// Token: 0x170003F0 RID: 1008
	// (get) Token: 0x06001ED7 RID: 7895 RVA: 0x000996DF File Offset: 0x000978DF
	// (set) Token: 0x06001ED8 RID: 7896 RVA: 0x000996E7 File Offset: 0x000978E7
	public int DefaultClipId
	{
		get
		{
			return this.defaultClipId;
		}
		set
		{
			this.defaultClipId = value;
		}
	}

	// Token: 0x170003F1 RID: 1009
	// (get) Token: 0x06001ED9 RID: 7897 RVA: 0x000996F0 File Offset: 0x000978F0
	public tk2dSpriteAnimationClip DefaultClip
	{
		get
		{
			return this.GetClipById(this.defaultClipId);
		}
	}

	// Token: 0x06001EDA RID: 7898 RVA: 0x000996FE File Offset: 0x000978FE
	private void OnEnable()
	{
		if (this.Sprite == null)
		{
			base.enabled = false;
		}
	}

	// Token: 0x06001EDB RID: 7899 RVA: 0x00099715 File Offset: 0x00097915
	private void Start()
	{
		if (this.playAutomatically)
		{
			this.Play(this.DefaultClip);
		}
	}

	// Token: 0x170003F2 RID: 1010
	// (get) Token: 0x06001EDC RID: 7900 RVA: 0x0009972B File Offset: 0x0009792B
	public virtual tk2dBaseSprite Sprite
	{
		get
		{
			if (this._sprite == null)
			{
				this._sprite = base.GetComponent<tk2dBaseSprite>();
				if (this._sprite == null)
				{
					Debug.LogError("Sprite not found attached to tk2dSpriteAnimator.");
				}
			}
			return this._sprite;
		}
	}

	// Token: 0x06001EDD RID: 7901 RVA: 0x00099768 File Offset: 0x00097968
	public static tk2dSpriteAnimator AddComponent(GameObject go, tk2dSpriteAnimation anim, int clipId)
	{
		tk2dSpriteAnimationClip tk2dSpriteAnimationClip = anim.clips[clipId];
		tk2dSpriteAnimator tk2dSpriteAnimator = go.AddComponent<tk2dSpriteAnimator>();
		tk2dSpriteAnimator.Library = anim;
		tk2dSpriteAnimator.SetSprite(tk2dSpriteAnimationClip.frames[0].spriteCollection, tk2dSpriteAnimationClip.frames[0].spriteId);
		return tk2dSpriteAnimator;
	}

	// Token: 0x06001EDE RID: 7902 RVA: 0x000997AC File Offset: 0x000979AC
	private tk2dSpriteAnimationClip GetClipByNameVerbose(string name)
	{
		if (this.library == null)
		{
			Debug.LogError("Library not set");
			return null;
		}
		tk2dSpriteAnimationClip clipByName = this.library.GetClipByName(name);
		if (clipByName == null)
		{
			Debug.LogError("Unable to find clip '" + name + "' in library");
			return null;
		}
		return clipByName;
	}

	// Token: 0x06001EDF RID: 7903 RVA: 0x000997FB File Offset: 0x000979FB
	public void Play()
	{
		if (this.currentClip == null)
		{
			this.currentClip = this.DefaultClip;
		}
		this.Play(this.currentClip);
	}

	// Token: 0x06001EE0 RID: 7904 RVA: 0x0009981D File Offset: 0x00097A1D
	public void Play(string name)
	{
		this.Play(this.GetClipByNameVerbose(name));
	}

	// Token: 0x06001EE1 RID: 7905 RVA: 0x0009982C File Offset: 0x00097A2C
	public void Play(tk2dSpriteAnimationClip clip)
	{
		this.Play(clip, 0f, tk2dSpriteAnimator.DefaultFps);
	}

	// Token: 0x06001EE2 RID: 7906 RVA: 0x0009983F File Offset: 0x00097A3F
	public void PlayFromFrame(int frame)
	{
		if (this.currentClip == null)
		{
			this.currentClip = this.DefaultClip;
		}
		this.PlayFromFrame(this.currentClip, frame);
	}

	// Token: 0x06001EE3 RID: 7907 RVA: 0x00099862 File Offset: 0x00097A62
	public void PlayFromFrame(string name, int frame)
	{
		this.PlayFromFrame(this.GetClipByNameVerbose(name), frame);
	}

	// Token: 0x06001EE4 RID: 7908 RVA: 0x00099872 File Offset: 0x00097A72
	public void PlayFromFrame(tk2dSpriteAnimationClip clip, int frame)
	{
		this.PlayFrom(clip, ((float)frame + 0.001f) / clip.fps);
	}

	// Token: 0x06001EE5 RID: 7909 RVA: 0x0009988A File Offset: 0x00097A8A
	public void PlayFrom(float clipStartTime)
	{
		if (this.currentClip == null)
		{
			this.currentClip = this.DefaultClip;
		}
		this.PlayFrom(this.currentClip, clipStartTime);
	}

	// Token: 0x06001EE6 RID: 7910 RVA: 0x000998B0 File Offset: 0x00097AB0
	public void PlayFrom(string name, float clipStartTime)
	{
		tk2dSpriteAnimationClip tk2dSpriteAnimationClip = this.library ? this.library.GetClipByName(name) : null;
		if (tk2dSpriteAnimationClip == null)
		{
			this.ClipNameError(name);
			return;
		}
		this.PlayFrom(tk2dSpriteAnimationClip, clipStartTime);
	}

	// Token: 0x06001EE7 RID: 7911 RVA: 0x000998ED File Offset: 0x00097AED
	public void PlayFrom(tk2dSpriteAnimationClip clip, float clipStartTime)
	{
		this.Play(clip, clipStartTime, tk2dSpriteAnimator.DefaultFps);
	}

	// Token: 0x06001EE8 RID: 7912 RVA: 0x000998FC File Offset: 0x00097AFC
	public void Play(tk2dSpriteAnimationClip clip, float clipStartTime, float overrideFps)
	{
		if (clip != null)
		{
			float num = (overrideFps > 0f) ? overrideFps : clip.fps;
			if (clipStartTime == 0f && this.IsPlaying(clip))
			{
				this.clipFps = num;
				return;
			}
			this.state |= tk2dSpriteAnimator.State.Playing;
			this.currentClip = clip;
			this.clipFps = num;
			if (this.currentClip.wrapMode == tk2dSpriteAnimationClip.WrapMode.Single || this.currentClip.frames == null)
			{
				this.WarpClipToLocalTime(this.currentClip, 0f);
				this.state &= (tk2dSpriteAnimator.State)(-2);
				return;
			}
			if (this.currentClip.wrapMode == tk2dSpriteAnimationClip.WrapMode.RandomFrame || this.currentClip.wrapMode == tk2dSpriteAnimationClip.WrapMode.RandomLoop)
			{
				int num2 = UnityEngine.Random.Range(0, this.currentClip.frames.Length);
				this.WarpClipToLocalTime(this.currentClip, (float)num2);
				if (this.currentClip.wrapMode == tk2dSpriteAnimationClip.WrapMode.RandomFrame)
				{
					this.previousFrame = -1;
					this.state &= (tk2dSpriteAnimator.State)(-2);
					return;
				}
			}
			else
			{
				float num3 = clipStartTime * this.clipFps;
				if (this.currentClip.wrapMode == tk2dSpriteAnimationClip.WrapMode.Once && num3 >= this.clipFps * (float)this.currentClip.frames.Length)
				{
					this.WarpClipToLocalTime(this.currentClip, (float)(this.currentClip.frames.Length - 1));
					this.state &= (tk2dSpriteAnimator.State)(-2);
					return;
				}
				this.WarpClipToLocalTime(this.currentClip, num3);
				this.clipTime = num3;
				return;
			}
		}
		else
		{
			Debug.LogError("Calling clip.Play() with a null clip");
			this.OnAnimationCompleted();
			this.state &= (tk2dSpriteAnimator.State)(-2);
		}
	}

	// Token: 0x06001EE9 RID: 7913 RVA: 0x00099A8A File Offset: 0x00097C8A
	public void Stop()
	{
		this.state &= (tk2dSpriteAnimator.State)(-2);
	}

	// Token: 0x06001EEA RID: 7914 RVA: 0x00099A9B File Offset: 0x00097C9B
	public void StopAndResetFrame()
	{
		if (this.currentClip != null)
		{
			this.SetSprite(this.currentClip.frames[0].spriteCollection, this.currentClip.frames[0].spriteId);
		}
		this.Stop();
	}

	// Token: 0x06001EEB RID: 7915 RVA: 0x00099AD5 File Offset: 0x00097CD5
	public bool IsPlaying(string name)
	{
		return this.Playing && this.CurrentClip != null && this.CurrentClip.name == name;
	}

	// Token: 0x06001EEC RID: 7916 RVA: 0x00099AFA File Offset: 0x00097CFA
	public bool IsPlaying(tk2dSpriteAnimationClip clip)
	{
		return this.Playing && this.CurrentClip != null && this.CurrentClip == clip;
	}

	// Token: 0x170003F3 RID: 1011
	// (get) Token: 0x06001EED RID: 7917 RVA: 0x00099B17 File Offset: 0x00097D17
	public bool Playing
	{
		get
		{
			return (this.state & tk2dSpriteAnimator.State.Playing) > tk2dSpriteAnimator.State.Init;
		}
	}

	// Token: 0x170003F4 RID: 1012
	// (get) Token: 0x06001EEE RID: 7918 RVA: 0x00099B24 File Offset: 0x00097D24
	public tk2dSpriteAnimationClip CurrentClip
	{
		get
		{
			return this.currentClip;
		}
	}

	// Token: 0x170003F5 RID: 1013
	// (get) Token: 0x06001EEF RID: 7919 RVA: 0x00099B2C File Offset: 0x00097D2C
	public float ClipTimeSeconds
	{
		get
		{
			if (this.clipFps <= 0f)
			{
				return this.clipTime / this.currentClip.fps;
			}
			return this.clipTime / this.clipFps;
		}
	}

	// Token: 0x170003F6 RID: 1014
	// (get) Token: 0x06001EF0 RID: 7920 RVA: 0x00099B5B File Offset: 0x00097D5B
	// (set) Token: 0x06001EF1 RID: 7921 RVA: 0x00099B63 File Offset: 0x00097D63
	public float ClipFps
	{
		get
		{
			return this.clipFps;
		}
		set
		{
			if (this.currentClip != null)
			{
				this.clipFps = ((value > 0f) ? value : this.currentClip.fps);
			}
		}
	}

	// Token: 0x06001EF2 RID: 7922 RVA: 0x00099B89 File Offset: 0x00097D89
	public tk2dSpriteAnimationClip GetClipById(int id)
	{
		if (this.library == null)
		{
			return null;
		}
		return this.library.GetClipById(id);
	}

	// Token: 0x170003F7 RID: 1015
	// (get) Token: 0x06001EF3 RID: 7923 RVA: 0x0000D576 File Offset: 0x0000B776
	public static float DefaultFps
	{
		get
		{
			return 0f;
		}
	}

	// Token: 0x06001EF4 RID: 7924 RVA: 0x00099BA7 File Offset: 0x00097DA7
	public int GetClipIdByName(string name)
	{
		if (!this.library)
		{
			return -1;
		}
		return this.library.GetClipIdByName(name);
	}

	// Token: 0x06001EF5 RID: 7925 RVA: 0x00099BC4 File Offset: 0x00097DC4
	public tk2dSpriteAnimationClip GetClipByName(string name)
	{
		if (!this.library)
		{
			return null;
		}
		return this.library.GetClipByName(name);
	}

	// Token: 0x06001EF6 RID: 7926 RVA: 0x00099BE1 File Offset: 0x00097DE1
	public void Pause()
	{
		this.state |= tk2dSpriteAnimator.State.Paused;
	}

	// Token: 0x06001EF7 RID: 7927 RVA: 0x00099BF1 File Offset: 0x00097DF1
	public void Resume()
	{
		this.state &= (tk2dSpriteAnimator.State)(-3);
	}

	// Token: 0x06001EF8 RID: 7928 RVA: 0x00099C02 File Offset: 0x00097E02
	public void SetFrame(int currFrame)
	{
		this.SetFrame(currFrame, true);
	}

	// Token: 0x06001EF9 RID: 7929 RVA: 0x00099C0C File Offset: 0x00097E0C
	public void SetFrame(int currFrame, bool triggerEvent)
	{
		if (this.currentClip == null)
		{
			this.currentClip = this.DefaultClip;
		}
		if (this.currentClip != null)
		{
			int num = currFrame % this.currentClip.frames.Length;
			this.SetFrameInternal(num);
			if (triggerEvent && this.currentClip.frames.Length != 0 && currFrame >= 0)
			{
				this.ProcessEvents(num - 1, num, 1);
			}
		}
	}

	// Token: 0x170003F8 RID: 1016
	// (get) Token: 0x06001EFA RID: 7930 RVA: 0x00099C6C File Offset: 0x00097E6C
	public int CurrentFrame
	{
		get
		{
			switch (this.currentClip.wrapMode)
			{
			case tk2dSpriteAnimationClip.WrapMode.Loop:
			case tk2dSpriteAnimationClip.WrapMode.RandomLoop:
				break;
			case tk2dSpriteAnimationClip.WrapMode.LoopSection:
			{
				int num = (int)this.clipTime;
				int result = this.currentClip.loopStart + (num - this.currentClip.loopStart) % (this.currentClip.frames.Length - this.currentClip.loopStart);
				if (num >= this.currentClip.loopStart)
				{
					return result;
				}
				return num;
			}
			case tk2dSpriteAnimationClip.WrapMode.Once:
				return Mathf.Min((int)this.clipTime, this.currentClip.frames.Length);
			case tk2dSpriteAnimationClip.WrapMode.PingPong:
			{
				int num2 = (this.currentClip.frames.Length > 1) ? ((int)this.clipTime % (this.currentClip.frames.Length + this.currentClip.frames.Length - 2)) : 0;
				if (num2 >= this.currentClip.frames.Length)
				{
					num2 = 2 * this.currentClip.frames.Length - 2 - num2;
				}
				return num2;
			}
			case tk2dSpriteAnimationClip.WrapMode.RandomFrame:
				goto IL_112;
			case tk2dSpriteAnimationClip.WrapMode.Single:
				return 0;
			default:
				goto IL_112;
			}
			IL_4D:
			return (int)this.clipTime % this.currentClip.frames.Length;
			IL_112:
			Debug.LogError("Unhandled clip wrap mode");
			goto IL_4D;
		}
	}

	// Token: 0x06001EFB RID: 7931 RVA: 0x00099D9C File Offset: 0x00097F9C
	public void UpdateAnimation(float deltaTime)
	{
		if ((this.state | tk2dSpriteAnimator.globalState) != tk2dSpriteAnimator.State.Playing)
		{
			return;
		}
		this.clipTime += deltaTime * this.clipFps;
		int num = this.previousFrame;
		switch (this.currentClip.wrapMode)
		{
		case tk2dSpriteAnimationClip.WrapMode.Loop:
		case tk2dSpriteAnimationClip.WrapMode.RandomLoop:
		{
			int num2 = (int)this.clipTime % this.currentClip.frames.Length;
			this.SetFrameInternal(num2);
			if (num2 < num)
			{
				this.ProcessEvents(num, this.currentClip.frames.Length - 1, 1);
				this.ProcessEvents(-1, num2, 1);
				return;
			}
			this.ProcessEvents(num, num2, 1);
			return;
		}
		case tk2dSpriteAnimationClip.WrapMode.LoopSection:
		{
			int num3 = (int)this.clipTime;
			int num4 = this.currentClip.loopStart + (num3 - this.currentClip.loopStart) % (this.currentClip.frames.Length - this.currentClip.loopStart);
			if (num3 < this.currentClip.loopStart)
			{
				this.SetFrameInternal(num3);
				this.ProcessEvents(num, num3, 1);
				return;
			}
			this.SetFrameInternal(num4);
			num3 = num4;
			if (num < this.currentClip.loopStart)
			{
				this.ProcessEvents(num, this.currentClip.loopStart - 1, 1);
				this.ProcessEvents(this.currentClip.loopStart - 1, num3, 1);
				return;
			}
			if (num3 < num)
			{
				this.ProcessEvents(num, this.currentClip.frames.Length - 1, 1);
				this.ProcessEvents(this.currentClip.loopStart - 1, num3, 1);
				return;
			}
			this.ProcessEvents(num, num3, 1);
			return;
		}
		case tk2dSpriteAnimationClip.WrapMode.Once:
		{
			int num5 = (int)this.clipTime;
			if (num5 >= this.currentClip.frames.Length)
			{
				this.SetFrameInternal(this.currentClip.frames.Length - 1);
				this.state &= (tk2dSpriteAnimator.State)(-2);
				this.ProcessEvents(num, this.currentClip.frames.Length - 1, 1);
				this.OnAnimationCompleted();
				return;
			}
			this.SetFrameInternal(num5);
			this.ProcessEvents(num, num5, 1);
			break;
		}
		case tk2dSpriteAnimationClip.WrapMode.PingPong:
		{
			int num6 = (this.currentClip.frames.Length > 1) ? ((int)this.clipTime % (this.currentClip.frames.Length + this.currentClip.frames.Length - 2)) : 0;
			int direction = 1;
			if (num6 >= this.currentClip.frames.Length)
			{
				num6 = 2 * this.currentClip.frames.Length - 2 - num6;
				direction = -1;
			}
			if (num6 < num)
			{
				direction = -1;
			}
			this.SetFrameInternal(num6);
			this.ProcessEvents(num, num6, direction);
			return;
		}
		case tk2dSpriteAnimationClip.WrapMode.RandomFrame:
			break;
		default:
			return;
		}
	}

	// Token: 0x06001EFC RID: 7932 RVA: 0x0009A01B File Offset: 0x0009821B
	private void ClipNameError(string name)
	{
		Debug.LogError("Unable to find clip named '" + name + "' in library");
	}

	// Token: 0x06001EFD RID: 7933 RVA: 0x0009A032 File Offset: 0x00098232
	private void ClipIdError(int id)
	{
		Debug.LogError("Play - Invalid clip id '" + id.ToString() + "' in library");
	}

	// Token: 0x06001EFE RID: 7934 RVA: 0x0009A050 File Offset: 0x00098250
	private void WarpClipToLocalTime(tk2dSpriteAnimationClip clip, float time)
	{
		this.clipTime = time;
		int num = (int)this.clipTime % clip.frames.Length;
		tk2dSpriteAnimationFrame tk2dSpriteAnimationFrame = clip.frames[num];
		this.SetSprite(tk2dSpriteAnimationFrame.spriteCollection, tk2dSpriteAnimationFrame.spriteId);
		if (tk2dSpriteAnimationFrame.triggerEvent && this.AnimationEventTriggered != null)
		{
			this.AnimationEventTriggered(this, clip, num);
		}
		this.previousFrame = num;
	}

	// Token: 0x06001EFF RID: 7935 RVA: 0x0009A0B5 File Offset: 0x000982B5
	private void SetFrameInternal(int currFrame)
	{
		if (this.previousFrame != currFrame)
		{
			this.SetSprite(this.currentClip.frames[currFrame].spriteCollection, this.currentClip.frames[currFrame].spriteId);
			this.previousFrame = currFrame;
		}
	}

	// Token: 0x06001F00 RID: 7936 RVA: 0x0009A0F4 File Offset: 0x000982F4
	private void ProcessEvents(int start, int last, int direction)
	{
		if (this.AnimationEventTriggered == null || start == last || Mathf.Sign((float)(last - start)) != Mathf.Sign((float)direction))
		{
			return;
		}
		int num = last + direction;
		tk2dSpriteAnimationFrame[] frames = this.currentClip.frames;
		for (int num2 = start + direction; num2 != num; num2 += direction)
		{
			if (frames[num2].triggerEvent && this.AnimationEventTriggered != null)
			{
				this.AnimationEventTriggered(this, this.currentClip, num2);
			}
		}
	}

	// Token: 0x06001F01 RID: 7937 RVA: 0x0009A163 File Offset: 0x00098363
	private void OnAnimationCompleted()
	{
		this.previousFrame = -1;
		if (this.AnimationCompleted != null)
		{
			this.AnimationCompleted(this, this.currentClip);
		}
	}

	// Token: 0x06001F02 RID: 7938 RVA: 0x0009A186 File Offset: 0x00098386
	public virtual void LateUpdate()
	{
		this.UpdateAnimation(Time.deltaTime);
	}

	// Token: 0x06001F03 RID: 7939 RVA: 0x0009A193 File Offset: 0x00098393
	public virtual void SetSprite(tk2dSpriteCollectionData spriteCollection, int spriteId)
	{
		this.Sprite.SetSprite(spriteCollection, spriteId);
	}

	// Token: 0x06001F04 RID: 7940 RVA: 0x0009A1A2 File Offset: 0x000983A2
	public tk2dSpriteAnimator()
	{
		this.clipFps = -1f;
		this.previousFrame = -1;
		base..ctor();
	}

	// Token: 0x0400240A RID: 9226
	[SerializeField]
	private tk2dSpriteAnimation library;

	// Token: 0x0400240B RID: 9227
	[SerializeField]
	private int defaultClipId;

	// Token: 0x0400240C RID: 9228
	public bool playAutomatically;

	// Token: 0x0400240D RID: 9229
	private static tk2dSpriteAnimator.State globalState;

	// Token: 0x0400240E RID: 9230
	private tk2dSpriteAnimationClip currentClip;

	// Token: 0x0400240F RID: 9231
	private float clipTime;

	// Token: 0x04002410 RID: 9232
	private float clipFps;

	// Token: 0x04002411 RID: 9233
	private int previousFrame;

	// Token: 0x04002412 RID: 9234
	public Action<tk2dSpriteAnimator, tk2dSpriteAnimationClip> AnimationCompleted;

	// Token: 0x04002413 RID: 9235
	public Action<tk2dSpriteAnimator, tk2dSpriteAnimationClip, int> AnimationEventTriggered;

	// Token: 0x04002414 RID: 9236
	private tk2dSpriteAnimator.State state;

	// Token: 0x04002415 RID: 9237
	protected tk2dBaseSprite _sprite;

	// Token: 0x02000567 RID: 1383
	private enum State
	{
		// Token: 0x04002417 RID: 9239
		Init,
		// Token: 0x04002418 RID: 9240
		Playing,
		// Token: 0x04002419 RID: 9241
		Paused
	}
}
