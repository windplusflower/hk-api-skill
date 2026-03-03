using System;

// Token: 0x02000554 RID: 1364
[Serializable]
public class tk2dAssetPlatform
{
	// Token: 0x06001DEC RID: 7660 RVA: 0x00095373 File Offset: 0x00093573
	public tk2dAssetPlatform(string name, float scale)
	{
		this.name = "";
		this.scale = 1f;
		base..ctor();
		this.name = name;
		this.scale = scale;
	}

	// Token: 0x0400239D RID: 9117
	public string name;

	// Token: 0x0400239E RID: 9118
	public float scale;
}
