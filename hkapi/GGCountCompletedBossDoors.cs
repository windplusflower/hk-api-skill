using System;
using System.Reflection;
using HutongGames.PlayMaker;

// Token: 0x0200024D RID: 589
[ActionCategory("Hollow Knight")]
public class GGCountCompletedBossDoors : FSMUtility.GetIntFsmStateAction
{
	// Token: 0x1700015B RID: 347
	// (get) Token: 0x06000C69 RID: 3177 RVA: 0x0003F724 File Offset: 0x0003D924
	public override int IntValue
	{
		get
		{
			int num = 0;
			foreach (FieldInfo fieldInfo in typeof(PlayerData).GetFields())
			{
				if (fieldInfo.FieldType == typeof(BossSequenceDoor.Completion) && ((BossSequenceDoor.Completion)fieldInfo.GetValue(GameManager.instance.playerData)).completed)
				{
					num++;
				}
			}
			return num;
		}
	}
}
