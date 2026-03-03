using System;

// Token: 0x0200050E RID: 1294
public abstract class VibrationEmission
{
	// Token: 0x17000374 RID: 884
	// (get) Token: 0x06001C7D RID: 7293
	// (set) Token: 0x06001C7E RID: 7294
	public abstract VibrationTarget Target { get; set; }

	// Token: 0x17000375 RID: 885
	// (get) Token: 0x06001C7F RID: 7295
	// (set) Token: 0x06001C80 RID: 7296
	public abstract bool IsLooping { get; set; }

	// Token: 0x17000376 RID: 886
	// (get) Token: 0x06001C81 RID: 7297
	// (set) Token: 0x06001C82 RID: 7298
	public abstract string Tag { get; set; }

	// Token: 0x17000377 RID: 887
	// (get) Token: 0x06001C83 RID: 7299
	public abstract bool IsPlaying { get; }

	// Token: 0x06001C84 RID: 7300
	public abstract void Stop();
}
