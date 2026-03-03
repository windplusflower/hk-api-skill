using System;

// Token: 0x02000553 RID: 1363
[Serializable]
public class tk2dResourceTocEntry
{
	// Token: 0x06001DEB RID: 7659 RVA: 0x0009534A File Offset: 0x0009354A
	public tk2dResourceTocEntry()
	{
		this.resourceGUID = "";
		this.assetName = "";
		this.assetGUID = "";
		base..ctor();
	}

	// Token: 0x0400239A RID: 9114
	public string resourceGUID;

	// Token: 0x0400239B RID: 9115
	public string assetName;

	// Token: 0x0400239C RID: 9116
	public string assetGUID;
}
