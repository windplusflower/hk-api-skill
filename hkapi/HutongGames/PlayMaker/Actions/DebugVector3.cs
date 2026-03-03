using System;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000B69 RID: 2921
	[ActionCategory(ActionCategory.Debug)]
	[Tooltip("Logs the value of a Vector3 Variable in the PlayMaker Log Window.")]
	public class DebugVector3 : BaseLogAction
	{
		// Token: 0x06003E36 RID: 15926 RVA: 0x00163AB4 File Offset: 0x00161CB4
		public override void Reset()
		{
			this.logLevel = LogLevel.Info;
			this.vector3Variable = null;
			base.Reset();
		}

		// Token: 0x06003E37 RID: 15927 RVA: 0x00163ACC File Offset: 0x00161CCC
		public override void OnEnter()
		{
			string text = "None";
			if (!this.vector3Variable.IsNone)
			{
				text = this.vector3Variable.Name + ": " + this.vector3Variable.Value.ToString();
			}
			ActionHelpers.DebugLog(base.Fsm, this.logLevel, text, this.sendToUnityLog);
			base.Finish();
		}

		// Token: 0x04004251 RID: 16977
		[Tooltip("Info, Warning, or Error.")]
		public LogLevel logLevel;

		// Token: 0x04004252 RID: 16978
		[UIHint(UIHint.Variable)]
		[Tooltip("The Vector3 variable to debug.")]
		public FsmVector3 vector3Variable;
	}
}
