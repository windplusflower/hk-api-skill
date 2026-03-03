using System;
using HutongGames.PlayMaker;

// Token: 0x0200022F RID: 559
[ActionCategory("Hollow Knight/GG")]
public class GGSetCanTransition : FSMUtility.SetBoolFsmStateAction
{
	// Token: 0x17000137 RID: 311
	// (set) Token: 0x06000BE9 RID: 3049 RVA: 0x0003DC2B File Offset: 0x0003BE2B
	public override bool BoolValue
	{
		set
		{
			if (BossSceneController.Instance)
			{
				BossSceneController.Instance.CanTransition = value;
			}
		}
	}
}
