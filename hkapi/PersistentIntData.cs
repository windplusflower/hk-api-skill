using System;

// Token: 0x02000524 RID: 1316
[Serializable]
public class PersistentIntData
{
	// Token: 0x06001CE9 RID: 7401 RVA: 0x00086A50 File Offset: 0x00084C50
	public PersistentIntData()
	{
		this.value = -1;
		base..ctor();
	}

	// Token: 0x0400224A RID: 8778
	public string id;

	// Token: 0x0400224B RID: 8779
	public string sceneName;

	// Token: 0x0400224C RID: 8780
	public int value;

	// Token: 0x0400224D RID: 8781
	public bool semiPersistent;
}
