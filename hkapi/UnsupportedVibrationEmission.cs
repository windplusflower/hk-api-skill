using System;

// Token: 0x0200050F RID: 1295
public class UnsupportedVibrationEmission : VibrationEmission
{
	// Token: 0x06001C86 RID: 7302 RVA: 0x00085C6A File Offset: 0x00083E6A
	public UnsupportedVibrationEmission(VibrationTarget target, bool isLooping, string tag)
	{
		this.target = target;
		this.isLooping = isLooping;
		this.tag = tag;
	}

	// Token: 0x17000378 RID: 888
	// (get) Token: 0x06001C87 RID: 7303 RVA: 0x00085C87 File Offset: 0x00083E87
	// (set) Token: 0x06001C88 RID: 7304 RVA: 0x00085C8F File Offset: 0x00083E8F
	public override VibrationTarget Target
	{
		get
		{
			return this.target;
		}
		set
		{
			this.target = value;
		}
	}

	// Token: 0x17000379 RID: 889
	// (get) Token: 0x06001C89 RID: 7305 RVA: 0x00085C98 File Offset: 0x00083E98
	// (set) Token: 0x06001C8A RID: 7306 RVA: 0x00085CA0 File Offset: 0x00083EA0
	public override bool IsLooping
	{
		get
		{
			return this.isLooping;
		}
		set
		{
			this.isLooping = value;
		}
	}

	// Token: 0x1700037A RID: 890
	// (get) Token: 0x06001C8B RID: 7307 RVA: 0x0000D742 File Offset: 0x0000B942
	public override bool IsPlaying
	{
		get
		{
			return false;
		}
	}

	// Token: 0x1700037B RID: 891
	// (get) Token: 0x06001C8C RID: 7308 RVA: 0x00085CA9 File Offset: 0x00083EA9
	// (set) Token: 0x06001C8D RID: 7309 RVA: 0x00085CB1 File Offset: 0x00083EB1
	public override string Tag
	{
		get
		{
			return this.tag;
		}
		set
		{
			this.tag = (value ?? "");
		}
	}

	// Token: 0x06001C8E RID: 7310 RVA: 0x00003603 File Offset: 0x00001803
	public override void Stop()
	{
	}

	// Token: 0x04002214 RID: 8724
	private VibrationTarget target;

	// Token: 0x04002215 RID: 8725
	private bool isLooping;

	// Token: 0x04002216 RID: 8726
	private string tag;
}
