using System;
using System.Collections;
using UnityEngine;

// Token: 0x0200003D RID: 61
public static class PlayMakerUtils_Extensions
{
	// Token: 0x06000155 RID: 341 RVA: 0x00006E0F File Offset: 0x0000500F
	public static int IndexOf(ArrayList target, object value)
	{
		return PlayMakerUtils_Extensions.IndexOf(target, value, 0, target.Count);
	}

	// Token: 0x06000156 RID: 342 RVA: 0x00006E1F File Offset: 0x0000501F
	public static int IndexOf(ArrayList target, object value, int startIndex)
	{
		if (startIndex > target.Count)
		{
			throw new ArgumentOutOfRangeException("startIndex", "ArgumentOutOfRange_Index");
		}
		return PlayMakerUtils_Extensions.IndexOf(target, value, startIndex, target.Count - startIndex);
	}

	// Token: 0x06000157 RID: 343 RVA: 0x00006E4C File Offset: 0x0000504C
	public static int IndexOf(ArrayList target, object value, int startIndex, int count)
	{
		Debug.Log(startIndex.ToString() + " " + count.ToString());
		if (startIndex < 0 || startIndex >= target.Count)
		{
			throw new ArgumentOutOfRangeException("startIndex", "ArgumentOutOfRange_Index");
		}
		if (count < 0 || startIndex > target.Count - count)
		{
			throw new ArgumentOutOfRangeException("count", "ArgumentOutOfRange_Count");
		}
		if (target.Count == 0)
		{
			return -1;
		}
		int num = startIndex + count;
		if (value == null)
		{
			for (int i = startIndex; i < num; i++)
			{
				if (target[i] == null)
				{
					return i;
				}
			}
			return -1;
		}
		for (int j = startIndex; j < num; j++)
		{
			if (target[j] != null && target[j].Equals(value))
			{
				return j;
			}
		}
		return -1;
	}

	// Token: 0x06000158 RID: 344 RVA: 0x00006F03 File Offset: 0x00005103
	public static int LastIndexOf(ArrayList target, object value)
	{
		return PlayMakerUtils_Extensions.LastIndexOf(target, value, target.Count - 1, target.Count);
	}

	// Token: 0x06000159 RID: 345 RVA: 0x00006F1A File Offset: 0x0000511A
	public static int LastIndexOf(ArrayList target, object value, int startIndex)
	{
		return PlayMakerUtils_Extensions.LastIndexOf(target, value, startIndex, startIndex + 1);
	}

	// Token: 0x0600015A RID: 346 RVA: 0x00006F28 File Offset: 0x00005128
	public static int LastIndexOf(ArrayList target, object value, int startIndex, int count)
	{
		if (target.Count == 0)
		{
			return -1;
		}
		if (startIndex < 0 || startIndex >= target.Count)
		{
			throw new ArgumentOutOfRangeException("startIndex", "ArgumentOutOfRange_Index");
		}
		if (count < 0 || startIndex > target.Count - count)
		{
			throw new ArgumentOutOfRangeException("count", "ArgumentOutOfRange_Count");
		}
		int num = startIndex + count - 1;
		if (value == null)
		{
			for (int i = num; i >= startIndex; i--)
			{
				if (target[i] == null)
				{
					return i;
				}
			}
			return -1;
		}
		for (int j = num; j >= startIndex; j--)
		{
			if (target[j] != null && target[j].Equals(value))
			{
				return j;
			}
		}
		return -1;
	}
}
