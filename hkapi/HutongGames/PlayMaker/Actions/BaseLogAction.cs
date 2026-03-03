using System;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000B32 RID: 2866
	public abstract class BaseLogAction : FsmStateAction
	{
		// Token: 0x06003D48 RID: 15688 RVA: 0x00160856 File Offset: 0x0015EA56
		public override void Reset()
		{
			this.sendToUnityLog = false;
		}

		// Token: 0x04004157 RID: 16727
		public bool sendToUnityLog;
	}
}
