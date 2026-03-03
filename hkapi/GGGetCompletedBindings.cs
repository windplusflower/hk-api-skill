using System;

// Token: 0x02000233 RID: 563
public class GGGetCompletedBindings : FSMUtility.GetIntFsmStateAction
{
	// Token: 0x17000139 RID: 313
	// (get) Token: 0x06000BFD RID: 3069 RVA: 0x0003DEE7 File Offset: 0x0003C0E7
	public override int IntValue
	{
		get
		{
			return BossSequenceBindingsDisplay.CountCompletedBindings();
		}
	}
}
