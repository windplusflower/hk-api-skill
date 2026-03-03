using System;
using Language;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x020009D4 RID: 2516
	[ActionCategory("Game Text")]
	[Tooltip("Grab a string from the Hollow Knight game text database in the correct language.")]
	public class GetLanguageString : FsmStateAction
	{
		// Token: 0x06003702 RID: 14082 RVA: 0x0014413A File Offset: 0x0014233A
		public override void Reset()
		{
			this.sheetName = null;
			this.convName = null;
			this.storeValue = null;
		}

		// Token: 0x06003703 RID: 14083 RVA: 0x00144154 File Offset: 0x00142354
		public override void OnEnter()
		{
			this.storeValue.Value = Language.Get(this.convName.Value, this.sheetName.Value);
			this.storeValue.Value = this.storeValue.Value.Replace("<br>", "\n");
			base.Finish();
		}

		// Token: 0x04003919 RID: 14617
		[RequiredField]
		public FsmString sheetName;

		// Token: 0x0400391A RID: 14618
		[RequiredField]
		public FsmString convName;

		// Token: 0x0400391B RID: 14619
		[RequiredField]
		[UIHint(UIHint.Variable)]
		public FsmString storeValue;
	}
}
