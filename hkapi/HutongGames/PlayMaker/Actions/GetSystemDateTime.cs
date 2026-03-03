using System;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000C18 RID: 3096
	[ActionCategory(ActionCategory.Time)]
	[Tooltip("Gets system date and time info and stores it in a string variable. An optional format string gives you a lot of control over the formatting (see online docs for format syntax).")]
	public class GetSystemDateTime : FsmStateAction
	{
		// Token: 0x060040F4 RID: 16628 RVA: 0x0016B4FC File Offset: 0x001696FC
		public override void Reset()
		{
			this.storeString = null;
			this.format = "MM/dd/yyyy HH:mm";
		}

		// Token: 0x060040F5 RID: 16629 RVA: 0x0016B518 File Offset: 0x00169718
		public override void OnEnter()
		{
			this.storeString.Value = DateTime.Now.ToString(this.format.Value);
			if (!this.everyFrame)
			{
				base.Finish();
			}
		}

		// Token: 0x060040F6 RID: 16630 RVA: 0x0016B558 File Offset: 0x00169758
		public override void OnUpdate()
		{
			this.storeString.Value = DateTime.Now.ToString(this.format.Value);
		}

		// Token: 0x04004537 RID: 17719
		[UIHint(UIHint.Variable)]
		[Tooltip("Store System DateTime as a string.")]
		public FsmString storeString;

		// Token: 0x04004538 RID: 17720
		[Tooltip("Optional format string. E.g., MM/dd/yyyy HH:mm")]
		public FsmString format;

		// Token: 0x04004539 RID: 17721
		[Tooltip("Repeat every frame.")]
		public bool everyFrame;
	}
}
