using System;

// Token: 0x02000234 RID: 564
public class GGGetTotalBindings : FSMUtility.GetIntFsmStateAction
{
	// Token: 0x1700013A RID: 314
	// (get) Token: 0x06000BFF RID: 3071 RVA: 0x0003DEF6 File Offset: 0x0003C0F6
	public override int IntValue
	{
		get
		{
			return BossSequenceBindingsDisplay.CountTotalBindings();
		}
	}
}
