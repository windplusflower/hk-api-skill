using System;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000C9F RID: 3231
	[ActionCategory(ActionCategory.Enum)]
	[Tooltip("Sets the value of an Enum Variable.")]
	public class SetEnumValue : FsmStateAction
	{
		// Token: 0x0600436B RID: 17259 RVA: 0x00172F96 File Offset: 0x00171196
		public override void Reset()
		{
			this.enumVariable = null;
			this.enumValue = null;
			this.everyFrame = false;
		}

		// Token: 0x0600436C RID: 17260 RVA: 0x00172FAD File Offset: 0x001711AD
		public override void OnEnter()
		{
			this.DoSetEnumValue();
			if (!this.everyFrame)
			{
				base.Finish();
			}
		}

		// Token: 0x0600436D RID: 17261 RVA: 0x00172FC3 File Offset: 0x001711C3
		public override void OnUpdate()
		{
			this.DoSetEnumValue();
		}

		// Token: 0x0600436E RID: 17262 RVA: 0x00172FCB File Offset: 0x001711CB
		private void DoSetEnumValue()
		{
			this.enumVariable.Value = this.enumValue.Value;
		}

		// Token: 0x040047AC RID: 18348
		[UIHint(UIHint.Variable)]
		[Tooltip("The Enum Variable to set.")]
		public FsmEnum enumVariable;

		// Token: 0x040047AD RID: 18349
		[MatchFieldType("enumVariable")]
		[Tooltip("The Enum value to set the variable to.")]
		public FsmEnum enumValue;

		// Token: 0x040047AE RID: 18350
		[Tooltip("Repeat every frame.")]
		public bool everyFrame;
	}
}
