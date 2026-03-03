using System;

// Token: 0x0200006B RID: 107
public abstract class CinematicVideoPlayer : IDisposable
{
	// Token: 0x17000028 RID: 40
	// (get) Token: 0x06000232 RID: 562 RVA: 0x0000D55F File Offset: 0x0000B75F
	protected CinematicVideoPlayerConfig Config
	{
		get
		{
			return this.config;
		}
	}

	// Token: 0x06000233 RID: 563 RVA: 0x0000D567 File Offset: 0x0000B767
	public CinematicVideoPlayer(CinematicVideoPlayerConfig config)
	{
		this.config = config;
	}

	// Token: 0x06000234 RID: 564 RVA: 0x00003603 File Offset: 0x00001803
	public virtual void Dispose()
	{
	}

	// Token: 0x17000029 RID: 41
	// (get) Token: 0x06000235 RID: 565
	public abstract bool IsLoading { get; }

	// Token: 0x1700002A RID: 42
	// (get) Token: 0x06000236 RID: 566
	public abstract bool IsPlaying { get; }

	// Token: 0x1700002B RID: 43
	// (get) Token: 0x06000237 RID: 567
	// (set) Token: 0x06000238 RID: 568
	public abstract bool IsLooping { get; set; }

	// Token: 0x1700002C RID: 44
	// (get) Token: 0x06000239 RID: 569
	// (set) Token: 0x0600023A RID: 570
	public abstract float Volume { get; set; }

	// Token: 0x0600023B RID: 571
	public abstract void Play();

	// Token: 0x0600023C RID: 572
	public abstract void Stop();

	// Token: 0x1700002D RID: 45
	// (get) Token: 0x0600023D RID: 573 RVA: 0x0000D576 File Offset: 0x0000B776
	public virtual float CurrentTime
	{
		get
		{
			return 0f;
		}
	}

	// Token: 0x0600023E RID: 574 RVA: 0x00003603 File Offset: 0x00001803
	public virtual void Update()
	{
	}

	// Token: 0x0600023F RID: 575 RVA: 0x0000D57D File Offset: 0x0000B77D
	public static CinematicVideoPlayer Create(CinematicVideoPlayerConfig config)
	{
		return new XB1CinematicVideoPlayer(config);
	}

	// Token: 0x040001E0 RID: 480
	private CinematicVideoPlayerConfig config;
}
