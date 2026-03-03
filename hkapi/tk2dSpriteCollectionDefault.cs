using System;
using UnityEngine;

// Token: 0x02000575 RID: 1397
[Serializable]
public class tk2dSpriteCollectionDefault
{
	// Token: 0x06001F1A RID: 7962 RVA: 0x0009AE93 File Offset: 0x00099093
	public tk2dSpriteCollectionDefault()
	{
		this.scale = new Vector3(1f, 1f, 1f);
		this.anchor = tk2dSpriteCollectionDefinition.Anchor.MiddleCenter;
		base..ctor();
	}

	// Token: 0x04002480 RID: 9344
	public bool additive;

	// Token: 0x04002481 RID: 9345
	public Vector3 scale;

	// Token: 0x04002482 RID: 9346
	public tk2dSpriteCollectionDefinition.Anchor anchor;

	// Token: 0x04002483 RID: 9347
	public tk2dSpriteCollectionDefinition.Pad pad;

	// Token: 0x04002484 RID: 9348
	public tk2dSpriteCollectionDefinition.ColliderType colliderType;
}
