using System;
using GlobalEnums;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000997 RID: 2455
	[ActionCategory("Game Manager")]
	[Tooltip("Perform a generic scene transition.")]
	public class CheckGameState : FsmStateAction
	{
		// Token: 0x060035CF RID: 13775 RVA: 0x0013D9F8 File Offset: 0x0013BBF8
		public override void Reset()
		{
			this.playing = null;
			this.otherwise = null;
		}

		// Token: 0x060035D0 RID: 13776 RVA: 0x0013DA08 File Offset: 0x0013BC08
		public override void OnEnter()
		{
			this.Check();
			if (!this.everyFrame)
			{
				base.Finish();
			}
		}

		// Token: 0x060035D1 RID: 13777 RVA: 0x0013DA20 File Offset: 0x0013BC20
		private void Check()
		{
			GameManager unsafeInstance = GameManager.UnsafeInstance;
			if (unsafeInstance == null)
			{
				base.Fsm.Event(this.otherwise);
				base.LogError("Cannot CheckGameState() before the game manager is loaded.");
				return;
			}
			if (unsafeInstance.gameState == GameState.PLAYING)
			{
				base.Fsm.Event(this.playing);
				return;
			}
			base.Fsm.Event(this.otherwise);
		}

		// Token: 0x060035D2 RID: 13778 RVA: 0x0013DA85 File Offset: 0x0013BC85
		public override void OnUpdate()
		{
			base.OnUpdate();
			this.Check();
		}

		// Token: 0x0400376C RID: 14188
		public FsmEvent playing;

		// Token: 0x0400376D RID: 14189
		public FsmEvent otherwise;

		// Token: 0x0400376E RID: 14190
		public bool everyFrame;
	}
}
