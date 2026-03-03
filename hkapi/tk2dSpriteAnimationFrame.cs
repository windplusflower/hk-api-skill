using System;

// Token: 0x02000562 RID: 1378
[Serializable]
public class tk2dSpriteAnimationFrame
{
	// Token: 0x06001EBF RID: 7871 RVA: 0x000992EF File Offset: 0x000974EF
	public void CopyFrom(tk2dSpriteAnimationFrame source)
	{
		this.CopyFrom(source, true);
	}

	// Token: 0x06001EC0 RID: 7872 RVA: 0x000992F9 File Offset: 0x000974F9
	public void CopyTriggerFrom(tk2dSpriteAnimationFrame source)
	{
		this.triggerEvent = source.triggerEvent;
		this.eventInfo = source.eventInfo;
		this.eventInt = source.eventInt;
		this.eventFloat = source.eventFloat;
	}

	// Token: 0x06001EC1 RID: 7873 RVA: 0x0009932B File Offset: 0x0009752B
	public void ClearTrigger()
	{
		this.triggerEvent = false;
		this.eventInt = 0;
		this.eventFloat = 0f;
		this.eventInfo = "";
	}

	// Token: 0x06001EC2 RID: 7874 RVA: 0x00099351 File Offset: 0x00097551
	public void CopyFrom(tk2dSpriteAnimationFrame source, bool full)
	{
		this.spriteCollection = source.spriteCollection;
		this.spriteId = source.spriteId;
		if (full)
		{
			this.CopyTriggerFrom(source);
		}
	}

	// Token: 0x06001EC3 RID: 7875 RVA: 0x00099375 File Offset: 0x00097575
	public tk2dSpriteAnimationFrame()
	{
		this.eventInfo = "";
		base..ctor();
	}

	// Token: 0x040023F6 RID: 9206
	public tk2dSpriteCollectionData spriteCollection;

	// Token: 0x040023F7 RID: 9207
	public int spriteId;

	// Token: 0x040023F8 RID: 9208
	public bool triggerEvent;

	// Token: 0x040023F9 RID: 9209
	public string eventInfo;

	// Token: 0x040023FA RID: 9210
	public int eventInt;

	// Token: 0x040023FB RID: 9211
	public float eventFloat;
}
