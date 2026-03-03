using System;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000CF3 RID: 3315
	[ActionCategory(ActionCategory.Device)]
	[Tooltip("Stops location service updates. This could be useful for saving battery life.")]
	public class StopLocationServiceUpdates : FsmStateAction
	{
		// Token: 0x060044E5 RID: 17637 RVA: 0x00003603 File Offset: 0x00001803
		public override void Reset()
		{
		}

		// Token: 0x060044E6 RID: 17638 RVA: 0x0013ACE9 File Offset: 0x00138EE9
		public override void OnEnter()
		{
			base.Finish();
		}
	}
}
