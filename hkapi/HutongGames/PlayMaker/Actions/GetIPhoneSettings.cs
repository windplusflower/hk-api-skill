using System;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000BF0 RID: 3056
	[ActionCategory(ActionCategory.Device)]
	[Tooltip("Get various iPhone settings.")]
	public class GetIPhoneSettings : FsmStateAction
	{
		// Token: 0x0600404C RID: 16460 RVA: 0x00169FD3 File Offset: 0x001681D3
		public override void Reset()
		{
			this.getScreenCanDarken = null;
			this.getUniqueIdentifier = null;
			this.getName = null;
			this.getModel = null;
			this.getSystemName = null;
			this.getGeneration = null;
		}

		// Token: 0x0600404D RID: 16461 RVA: 0x0013ACE9 File Offset: 0x00138EE9
		public override void OnEnter()
		{
			base.Finish();
		}

		// Token: 0x040044B0 RID: 17584
		[UIHint(UIHint.Variable)]
		[Tooltip("Allows device to fall into 'sleep' state with screen being dim if no touches occurred. Default value is true.")]
		public FsmBool getScreenCanDarken;

		// Token: 0x040044B1 RID: 17585
		[UIHint(UIHint.Variable)]
		[Tooltip("A unique device identifier string. It is guaranteed to be unique for every device (Read Only).")]
		public FsmString getUniqueIdentifier;

		// Token: 0x040044B2 RID: 17586
		[UIHint(UIHint.Variable)]
		[Tooltip("The user defined name of the device (Read Only).")]
		public FsmString getName;

		// Token: 0x040044B3 RID: 17587
		[UIHint(UIHint.Variable)]
		[Tooltip("The model of the device (Read Only).")]
		public FsmString getModel;

		// Token: 0x040044B4 RID: 17588
		[UIHint(UIHint.Variable)]
		[Tooltip("The name of the operating system running on the device (Read Only).")]
		public FsmString getSystemName;

		// Token: 0x040044B5 RID: 17589
		[UIHint(UIHint.Variable)]
		[Tooltip("The generation of the device (Read Only).")]
		public FsmString getGeneration;
	}
}
