using System;
using UnityEngine;

// Token: 0x02000511 RID: 1297
[Serializable]
public struct VibrationTarget
{
	// Token: 0x1700037F RID: 895
	// (get) Token: 0x06001C93 RID: 7315 RVA: 0x00085D0A File Offset: 0x00083F0A
	public VibrationMotors Motors
	{
		get
		{
			return this.motors;
		}
	}

	// Token: 0x06001C94 RID: 7316 RVA: 0x00085D12 File Offset: 0x00083F12
	public VibrationTarget(VibrationMotors motors)
	{
		this.motors = motors;
	}

	// Token: 0x0400221A RID: 8730
	[SerializeField]
	private VibrationMotors motors;
}
