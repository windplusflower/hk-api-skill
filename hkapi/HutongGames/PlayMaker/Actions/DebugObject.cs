using System;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000B67 RID: 2919
	[ActionCategory(ActionCategory.Debug)]
	[Tooltip("Logs the value of an Object Variable in the PlayMaker Log Window.")]
	public class DebugObject : BaseLogAction
	{
		// Token: 0x06003E30 RID: 15920 RVA: 0x001639BE File Offset: 0x00161BBE
		public override void Reset()
		{
			this.logLevel = LogLevel.Info;
			this.fsmObject = null;
			base.Reset();
		}

		// Token: 0x06003E31 RID: 15921 RVA: 0x001639D4 File Offset: 0x00161BD4
		public override void OnEnter()
		{
			string text = "None";
			if (!this.fsmObject.IsNone)
			{
				string name = this.fsmObject.Name;
				string str = ": ";
				FsmObject fsmObject = this.fsmObject;
				text = name + str + ((fsmObject != null) ? fsmObject.ToString() : null);
			}
			ActionHelpers.DebugLog(base.Fsm, this.logLevel, text, this.sendToUnityLog);
			base.Finish();
		}

		// Token: 0x0400424D RID: 16973
		[Tooltip("Info, Warning, or Error.")]
		public LogLevel logLevel;

		// Token: 0x0400424E RID: 16974
		[UIHint(UIHint.Variable)]
		[Tooltip("The Object variable to debug.")]
		public FsmObject fsmObject;
	}
}
