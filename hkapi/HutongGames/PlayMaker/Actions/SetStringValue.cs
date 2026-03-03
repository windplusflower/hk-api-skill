using System;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000CE3 RID: 3299
	[ActionCategory(ActionCategory.String)]
	[Tooltip("Sets the value of a String Variable.")]
	public class SetStringValue : FsmStateAction
	{
		// Token: 0x06004497 RID: 17559 RVA: 0x001763A1 File Offset: 0x001745A1
		public override void Reset()
		{
			this.stringVariable = null;
			this.stringValue = null;
			this.everyFrame = false;
		}

		// Token: 0x06004498 RID: 17560 RVA: 0x001763B8 File Offset: 0x001745B8
		public override void OnEnter()
		{
			this.DoSetStringValue();
			if (!this.everyFrame)
			{
				base.Finish();
			}
		}

		// Token: 0x06004499 RID: 17561 RVA: 0x001763CE File Offset: 0x001745CE
		public override void OnUpdate()
		{
			this.DoSetStringValue();
		}

		// Token: 0x0600449A RID: 17562 RVA: 0x001763D6 File Offset: 0x001745D6
		private void DoSetStringValue()
		{
			if (this.stringVariable == null)
			{
				return;
			}
			if (this.stringValue == null)
			{
				return;
			}
			this.stringVariable.Value = this.stringValue.Value;
		}

		// Token: 0x040048DC RID: 18652
		[RequiredField]
		[UIHint(UIHint.Variable)]
		public FsmString stringVariable;

		// Token: 0x040048DD RID: 18653
		[UIHint(UIHint.TextArea)]
		public FsmString stringValue;

		// Token: 0x040048DE RID: 18654
		public bool everyFrame;
	}
}
