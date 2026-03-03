using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x020009AE RID: 2478
	[ActionCategory(ActionCategory.Debug)]
	[Tooltip("Logs a detailed deprecation message.")]
	public class DebugLogDeprecatedEvent : BaseLogAction
	{
		// Token: 0x0600363C RID: 13884 RVA: 0x00140013 File Offset: 0x0013E213
		public override void Reset()
		{
			this.noteText = "";
			base.Reset();
		}

		// Token: 0x0600363D RID: 13885 RVA: 0x0014002C File Offset: 0x0013E22C
		public override void OnEnter()
		{
			string arg;
			if (Fsm.EventData.SentByFsm == null)
			{
				arg = "<native-code>";
			}
			else
			{
				arg = string.Format("{0}.{1}.{2}.{3}", new object[]
				{
					(Fsm.EventData.SentByFsm.GameObject == null) ? "<unknown-game-object>" : Fsm.EventData.SentByFsm.GameObject.name,
					Fsm.EventData.SentByFsm.Name,
					(Fsm.EventData.SentByState == null) ? "<unknown-state>" : Fsm.EventData.SentByState.Name,
					(Fsm.EventData.SentByAction == null) ? "<unknown-action>" : Fsm.EventData.SentByAction.Name
				});
			}
			PlayMakerFSM playMakerFSM = base.Fsm.Owner as PlayMakerFSM;
			string arg2;
			if (playMakerFSM == null)
			{
				arg2 = "<no-owner>";
			}
			else
			{
				arg2 = string.Format("{0}.{1}.{2}", playMakerFSM.gameObject.name, base.Fsm.Name, base.Fsm.ActiveStateName);
			}
			string value = this.noteText.Value;
			string text = string.Format("Entry to {0} (sent by {1}) is deprecated", arg2, arg);
			if (!string.IsNullOrEmpty(value))
			{
				text = text + ": " + value;
			}
			Debug.LogError(text, playMakerFSM);
			base.Finish();
		}

		// Token: 0x0400381B RID: 14363
		[Tooltip("Text to send to the log.")]
		public FsmString noteText;
	}
}
