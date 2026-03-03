using System;
using UnityEngine;

// Token: 0x020005B5 RID: 1461
[Serializable]
public class tk2dUILayoutItem
{
	// Token: 0x0600212A RID: 8490 RVA: 0x000A63B7 File Offset: 0x000A45B7
	public static tk2dUILayoutItem FixedSizeLayoutItem()
	{
		return new tk2dUILayoutItem
		{
			fixedSize = true
		};
	}

	// Token: 0x0600212B RID: 8491 RVA: 0x000A63C5 File Offset: 0x000A45C5
	public tk2dUILayoutItem()
	{
		this.fillPercentage = -1f;
		this.sizeProportion = 1f;
		this.oldPos = Vector3.zero;
		base..ctor();
	}

	// Token: 0x04002698 RID: 9880
	public tk2dBaseSprite sprite;

	// Token: 0x04002699 RID: 9881
	public tk2dUIMask UIMask;

	// Token: 0x0400269A RID: 9882
	public tk2dUILayout layout;

	// Token: 0x0400269B RID: 9883
	public GameObject gameObj;

	// Token: 0x0400269C RID: 9884
	public bool snapLeft;

	// Token: 0x0400269D RID: 9885
	public bool snapRight;

	// Token: 0x0400269E RID: 9886
	public bool snapTop;

	// Token: 0x0400269F RID: 9887
	public bool snapBottom;

	// Token: 0x040026A0 RID: 9888
	public bool fixedSize;

	// Token: 0x040026A1 RID: 9889
	public float fillPercentage;

	// Token: 0x040026A2 RID: 9890
	public float sizeProportion;

	// Token: 0x040026A3 RID: 9891
	public bool inLayoutList;

	// Token: 0x040026A4 RID: 9892
	public int childDepth;

	// Token: 0x040026A5 RID: 9893
	public Vector3 oldPos;
}
