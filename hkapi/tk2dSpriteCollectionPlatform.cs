using System;

// Token: 0x0200057A RID: 1402
[Serializable]
public class tk2dSpriteCollectionPlatform
{
	// Token: 0x170003FC RID: 1020
	// (get) Token: 0x06001F23 RID: 7971 RVA: 0x0009B268 File Offset: 0x00099468
	public bool Valid
	{
		get
		{
			return this.name.Length > 0 && this.spriteCollection != null;
		}
	}

	// Token: 0x06001F24 RID: 7972 RVA: 0x0009B286 File Offset: 0x00099486
	public void CopyFrom(tk2dSpriteCollectionPlatform source)
	{
		this.name = source.name;
		this.spriteCollection = source.spriteCollection;
	}

	// Token: 0x06001F25 RID: 7973 RVA: 0x0009B2A0 File Offset: 0x000994A0
	public tk2dSpriteCollectionPlatform()
	{
		this.name = "";
		base..ctor();
	}

	// Token: 0x040024B0 RID: 9392
	public string name;

	// Token: 0x040024B1 RID: 9393
	public tk2dSpriteCollection spriteCollection;
}
