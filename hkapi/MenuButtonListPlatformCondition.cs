using System;
using UnityEngine;

// Token: 0x0200048F RID: 1167
public class MenuButtonListPlatformCondition : MenuButtonListCondition
{
	// Token: 0x06001A31 RID: 6705 RVA: 0x0007DD6C File Offset: 0x0007BF6C
	public override bool IsFulfilled()
	{
		RuntimePlatform platform = Application.platform;
		bool activate = this.defaultActivation;
		foreach (MenuButtonListPlatformCondition.PlatformBoolPair platformBoolPair in this.platforms)
		{
			if (platformBoolPair.platform == platform)
			{
				activate = platformBoolPair.activate;
				break;
			}
		}
		return activate;
	}

	// Token: 0x06001A32 RID: 6706 RVA: 0x0007DDB9 File Offset: 0x0007BFB9
	public MenuButtonListPlatformCondition()
	{
		this.defaultActivation = true;
		base..ctor();
	}

	// Token: 0x04001F7E RID: 8062
	public MenuButtonListPlatformCondition.PlatformBoolPair[] platforms;

	// Token: 0x04001F7F RID: 8063
	[Space]
	public bool defaultActivation;

	// Token: 0x02000490 RID: 1168
	[Serializable]
	public struct PlatformBoolPair
	{
		// Token: 0x04001F80 RID: 8064
		public RuntimePlatform platform;

		// Token: 0x04001F81 RID: 8065
		public bool activate;
	}
}
