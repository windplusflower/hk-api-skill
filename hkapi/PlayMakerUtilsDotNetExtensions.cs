using System;
using HutongGames.PlayMaker;

// Token: 0x0200003E RID: 62
public static class PlayMakerUtilsDotNetExtensions
{
	// Token: 0x0600015B RID: 347 RVA: 0x00006FC8 File Offset: 0x000051C8
	public static bool Contains(this VariableType[] target, VariableType vType)
	{
		if (target == null)
		{
			return false;
		}
		for (int i = 0; i < target.Length; i++)
		{
			if (target[i] == vType)
			{
				return true;
			}
		}
		return false;
	}
}
