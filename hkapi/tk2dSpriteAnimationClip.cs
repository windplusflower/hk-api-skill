using System;
using UnityEngine;

// Token: 0x02000563 RID: 1379
[Serializable]
public class tk2dSpriteAnimationClip
{
	// Token: 0x170003EA RID: 1002
	// (get) Token: 0x06001EC4 RID: 7876 RVA: 0x00099388 File Offset: 0x00097588
	public float Duration
	{
		get
		{
			return (float)this.frames.Length / this.fps;
		}
	}

	// Token: 0x06001EC5 RID: 7877 RVA: 0x0009939A File Offset: 0x0009759A
	public tk2dSpriteAnimationClip()
	{
		this.name = "Default";
		this.frames = new tk2dSpriteAnimationFrame[0];
		this.fps = 30f;
		base..ctor();
	}

	// Token: 0x06001EC6 RID: 7878 RVA: 0x000993C4 File Offset: 0x000975C4
	public tk2dSpriteAnimationClip(tk2dSpriteAnimationClip source)
	{
		this.name = "Default";
		this.frames = new tk2dSpriteAnimationFrame[0];
		this.fps = 30f;
		base..ctor();
		this.CopyFrom(source);
	}

	// Token: 0x06001EC7 RID: 7879 RVA: 0x000993F8 File Offset: 0x000975F8
	public void CopyFrom(tk2dSpriteAnimationClip source)
	{
		this.name = source.name;
		if (source.frames == null)
		{
			this.frames = null;
		}
		else
		{
			this.frames = new tk2dSpriteAnimationFrame[source.frames.Length];
			for (int i = 0; i < this.frames.Length; i++)
			{
				if (source.frames[i] == null)
				{
					this.frames[i] = null;
				}
				else
				{
					this.frames[i] = new tk2dSpriteAnimationFrame();
					this.frames[i].CopyFrom(source.frames[i]);
				}
			}
		}
		this.fps = source.fps;
		this.loopStart = source.loopStart;
		this.wrapMode = source.wrapMode;
		if (this.wrapMode == tk2dSpriteAnimationClip.WrapMode.Single && this.frames.Length > 1)
		{
			this.frames = new tk2dSpriteAnimationFrame[]
			{
				this.frames[0]
			};
			Debug.LogError(string.Format("Clip: '{0}' Fixed up frames for WrapMode.Single", this.name));
		}
	}

	// Token: 0x06001EC8 RID: 7880 RVA: 0x000994E3 File Offset: 0x000976E3
	public void Clear()
	{
		this.name = "";
		this.frames = new tk2dSpriteAnimationFrame[0];
		this.fps = 30f;
		this.loopStart = 0;
		this.wrapMode = tk2dSpriteAnimationClip.WrapMode.Loop;
	}

	// Token: 0x170003EB RID: 1003
	// (get) Token: 0x06001EC9 RID: 7881 RVA: 0x00099515 File Offset: 0x00097715
	public bool Empty
	{
		get
		{
			return this.name.Length == 0 || this.frames == null || this.frames.Length == 0;
		}
	}

	// Token: 0x06001ECA RID: 7882 RVA: 0x00099538 File Offset: 0x00097738
	public tk2dSpriteAnimationFrame GetFrame(int frame)
	{
		return this.frames[frame];
	}

	// Token: 0x040023FC RID: 9212
	public string name;

	// Token: 0x040023FD RID: 9213
	public tk2dSpriteAnimationFrame[] frames;

	// Token: 0x040023FE RID: 9214
	public float fps;

	// Token: 0x040023FF RID: 9215
	public int loopStart;

	// Token: 0x04002400 RID: 9216
	public tk2dSpriteAnimationClip.WrapMode wrapMode;

	// Token: 0x02000564 RID: 1380
	public enum WrapMode
	{
		// Token: 0x04002402 RID: 9218
		Loop,
		// Token: 0x04002403 RID: 9219
		LoopSection,
		// Token: 0x04002404 RID: 9220
		Once,
		// Token: 0x04002405 RID: 9221
		PingPong,
		// Token: 0x04002406 RID: 9222
		RandomFrame,
		// Token: 0x04002407 RID: 9223
		RandomLoop,
		// Token: 0x04002408 RID: 9224
		Single
	}
}
