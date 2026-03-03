using System;
using UnityEngine;

// Token: 0x020001F4 RID: 500
public static class DirectionUtils
{
	// Token: 0x06000AD3 RID: 2771 RVA: 0x00039CBA File Offset: 0x00037EBA
	public static int GetCardinalDirection(float degrees)
	{
		return DirectionUtils.NegSafeMod(Mathf.RoundToInt(degrees / 90f), 4);
	}

	// Token: 0x06000AD4 RID: 2772 RVA: 0x00039CCE File Offset: 0x00037ECE
	public static int NegSafeMod(int val, int len)
	{
		return (val % len + len) % len;
	}

	// Token: 0x06000AD5 RID: 2773 RVA: 0x00039CD8 File Offset: 0x00037ED8
	public static int GetX(int cardinalDirection)
	{
		int num = cardinalDirection % 4;
		if (num == 0)
		{
			return 1;
		}
		if (num != 2)
		{
			return 0;
		}
		return -1;
	}

	// Token: 0x06000AD6 RID: 2774 RVA: 0x00039CF8 File Offset: 0x00037EF8
	public static int GetY(int cardinalDirection)
	{
		int num = cardinalDirection % 4;
		if (num == 1)
		{
			return 1;
		}
		if (num != 3)
		{
			return 0;
		}
		return -1;
	}

	// Token: 0x04000BE4 RID: 3044
	public const int Right = 0;

	// Token: 0x04000BE5 RID: 3045
	public const int Up = 1;

	// Token: 0x04000BE6 RID: 3046
	public const int Left = 2;

	// Token: 0x04000BE7 RID: 3047
	public const int Down = 3;
}
