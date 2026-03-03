using System;

// Token: 0x02000317 RID: 791
public struct PlayTime
{
	// Token: 0x17000204 RID: 516
	// (get) Token: 0x0600115E RID: 4446 RVA: 0x00051307 File Offset: 0x0004F507
	private TimeSpan time
	{
		get
		{
			return TimeSpan.FromSeconds((double)this.RawTime);
		}
	}

	// Token: 0x17000205 RID: 517
	// (get) Token: 0x0600115F RID: 4447 RVA: 0x00051318 File Offset: 0x0004F518
	public float Hours
	{
		get
		{
			return (float)Math.Floor(this.time.TotalHours);
		}
	}

	// Token: 0x17000206 RID: 518
	// (get) Token: 0x06001160 RID: 4448 RVA: 0x0005133C File Offset: 0x0004F53C
	public float Minutes
	{
		get
		{
			return (float)this.time.Minutes;
		}
	}

	// Token: 0x17000207 RID: 519
	// (get) Token: 0x06001161 RID: 4449 RVA: 0x00051358 File Offset: 0x0004F558
	public float Seconds
	{
		get
		{
			return (float)this.time.Seconds;
		}
	}

	// Token: 0x17000208 RID: 520
	// (get) Token: 0x06001162 RID: 4450 RVA: 0x00051374 File Offset: 0x0004F574
	public bool HasHours
	{
		get
		{
			return this.time.TotalHours >= 1.0;
		}
	}

	// Token: 0x17000209 RID: 521
	// (get) Token: 0x06001163 RID: 4451 RVA: 0x000513A0 File Offset: 0x0004F5A0
	public bool HasMinutes
	{
		get
		{
			return this.time.TotalMinutes >= 1.0;
		}
	}

	// Token: 0x04001102 RID: 4354
	public float RawTime;
}
