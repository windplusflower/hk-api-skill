using System;
using UnityEngine;

namespace InControl
{
	// Token: 0x020006E8 RID: 1768
	public enum InputDeviceDriverType : ushort
	{
		// Token: 0x040030F8 RID: 12536
		Unknown,
		// Token: 0x040030F9 RID: 12537
		HID,
		// Token: 0x040030FA RID: 12538
		USB,
		// Token: 0x040030FB RID: 12539
		Bluetooth,
		// Token: 0x040030FC RID: 12540
		[InspectorName("XInput")]
		XInput,
		// Token: 0x040030FD RID: 12541
		[InspectorName("DirectInput")]
		DirectInput,
		// Token: 0x040030FE RID: 12542
		[InspectorName("RawInput")]
		RawInput
	}
}
