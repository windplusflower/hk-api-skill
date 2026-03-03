using System;

// Token: 0x02000539 RID: 1337
[Serializable]
public class SecureplayerPrefsDemoClass
{
	// Token: 0x17000391 RID: 913
	// (get) Token: 0x06001D2F RID: 7471 RVA: 0x00090954 File Offset: 0x0008EB54
	// (set) Token: 0x06001D30 RID: 7472 RVA: 0x0009095C File Offset: 0x0008EB5C
	public string playID { get; set; }

	// Token: 0x17000392 RID: 914
	// (get) Token: 0x06001D31 RID: 7473 RVA: 0x00090965 File Offset: 0x0008EB65
	// (set) Token: 0x06001D32 RID: 7474 RVA: 0x0009096D File Offset: 0x0008EB6D
	public int type { get; set; }

	// Token: 0x17000393 RID: 915
	// (get) Token: 0x06001D33 RID: 7475 RVA: 0x00090976 File Offset: 0x0008EB76
	// (set) Token: 0x06001D34 RID: 7476 RVA: 0x0009097E File Offset: 0x0008EB7E
	public bool incremental { get; set; }

	// Token: 0x06001D35 RID: 7477 RVA: 0x00090987 File Offset: 0x0008EB87
	public SecureplayerPrefsDemoClass()
	{
		this.playID = "";
		this.type = 0;
		this.incremental = false;
	}
}
