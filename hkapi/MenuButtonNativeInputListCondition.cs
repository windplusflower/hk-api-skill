using System;
using InControl;

// Token: 0x02000491 RID: 1169
public class MenuButtonNativeInputListCondition : MenuButtonListCondition
{
	// Token: 0x06001A33 RID: 6707 RVA: 0x0007DDC8 File Offset: 0x0007BFC8
	public override bool IsFulfilled()
	{
		return NativeInputDeviceManager.CheckPlatformSupport(null);
	}
}
