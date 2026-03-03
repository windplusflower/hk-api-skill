using System;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000C9D RID: 3229
	[ActionCategory(ActionCategory.Color)]
	[Tooltip("Sets the value of a Color Variable.")]
	public class SetColorValue : FsmStateAction
	{
		// Token: 0x06004361 RID: 17249 RVA: 0x00172ECA File Offset: 0x001710CA
		public override void Reset()
		{
			this.colorVariable = null;
			this.color = null;
			this.everyFrame = false;
		}

		// Token: 0x06004362 RID: 17250 RVA: 0x00172EE1 File Offset: 0x001710E1
		public override void OnEnter()
		{
			this.DoSetColorValue();
			if (!this.everyFrame)
			{
				base.Finish();
			}
		}

		// Token: 0x06004363 RID: 17251 RVA: 0x00172EF7 File Offset: 0x001710F7
		public override void OnUpdate()
		{
			this.DoSetColorValue();
		}

		// Token: 0x06004364 RID: 17252 RVA: 0x00172EFF File Offset: 0x001710FF
		private void DoSetColorValue()
		{
			if (this.colorVariable != null)
			{
				this.colorVariable.Value = this.color.Value;
			}
		}

		// Token: 0x040047A6 RID: 18342
		[RequiredField]
		[UIHint(UIHint.Variable)]
		public FsmColor colorVariable;

		// Token: 0x040047A7 RID: 18343
		[RequiredField]
		public FsmColor color;

		// Token: 0x040047A8 RID: 18344
		public bool everyFrame;
	}
}
