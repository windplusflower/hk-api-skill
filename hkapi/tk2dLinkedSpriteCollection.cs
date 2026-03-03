using System;

// Token: 0x0200056A RID: 1386
[Serializable]
public class tk2dLinkedSpriteCollection
{
	// Token: 0x06001F12 RID: 7954 RVA: 0x0009A5CD File Offset: 0x000987CD
	public tk2dLinkedSpriteCollection()
	{
		this.name = "";
		base..ctor();
	}

	// Token: 0x04002421 RID: 9249
	public string name;

	// Token: 0x04002422 RID: 9250
	public tk2dSpriteCollection spriteCollection;
}
