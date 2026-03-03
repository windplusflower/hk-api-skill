using System;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000A5C RID: 2652
	public class ShakeAllGrass : FsmStateAction
	{
		// Token: 0x0600394D RID: 14669 RVA: 0x0014DC4A File Offset: 0x0014BE4A
		public override void OnEnter()
		{
			base.OnEnter();
			PlayMakerFSM.BroadcastEvent("SHAKE ALL GRASS");
			Grass.PushAll();
			base.Finish();
		}

		// Token: 0x04003BEE RID: 15342
		private const string DeprecatedEffectName = "SHAKE ALL GRASS";
	}
}
