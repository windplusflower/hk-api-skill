using System;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000B64 RID: 2916
	[ActionCategory(ActionCategory.Debug)]
	[Tooltip("Logs the value of a Game Object Variable in the PlayMaker Log Window.")]
	public class DebugGameObject : BaseLogAction
	{
		// Token: 0x06003E27 RID: 15911 RVA: 0x0016386B File Offset: 0x00161A6B
		public override void Reset()
		{
			this.logLevel = LogLevel.Info;
			this.gameObject = null;
			base.Reset();
		}

		// Token: 0x06003E28 RID: 15912 RVA: 0x00163884 File Offset: 0x00161A84
		public override void OnEnter()
		{
			string text = "None";
			if (!this.gameObject.IsNone)
			{
				string name = this.gameObject.Name;
				string str = ": ";
				FsmGameObject fsmGameObject = this.gameObject;
				text = name + str + ((fsmGameObject != null) ? fsmGameObject.ToString() : null);
			}
			ActionHelpers.DebugLog(base.Fsm, this.logLevel, text, this.sendToUnityLog);
			base.Finish();
		}

		// Token: 0x04004247 RID: 16967
		[Tooltip("Info, Warning, or Error.")]
		public LogLevel logLevel;

		// Token: 0x04004248 RID: 16968
		[UIHint(UIHint.Variable)]
		[Tooltip("The GameObject variable to debug.")]
		public FsmGameObject gameObject;
	}
}
