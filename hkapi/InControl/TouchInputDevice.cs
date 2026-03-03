using System;

namespace InControl
{
	// Token: 0x02000716 RID: 1814
	public class TouchInputDevice : InputDevice
	{
		// Token: 0x06002CDD RID: 11485 RVA: 0x000F19FC File Offset: 0x000EFBFC
		public TouchInputDevice() : base("Touch Input Device", true)
		{
			base.DeviceClass = InputDeviceClass.TouchScreen;
		}
	}
}
