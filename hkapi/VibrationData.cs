using System;
using UnityEngine;

// Token: 0x02000510 RID: 1296
[Serializable]
public struct VibrationData
{
	// Token: 0x1700037C RID: 892
	// (get) Token: 0x06001C8F RID: 7311 RVA: 0x00085CC3 File Offset: 0x00083EC3
	public LowFidelityVibrations LowFidelityVibration
	{
		get
		{
			return this.lowFidelityVibration;
		}
	}

	// Token: 0x1700037D RID: 893
	// (get) Token: 0x06001C90 RID: 7312 RVA: 0x00085CCB File Offset: 0x00083ECB
	public TextAsset HighFidelityVibration
	{
		get
		{
			return this.highFidelityVibration;
		}
	}

	// Token: 0x1700037E RID: 894
	// (get) Token: 0x06001C91 RID: 7313 RVA: 0x00085CD3 File Offset: 0x00083ED3
	public GamepadVibration GamepadVibration
	{
		get
		{
			return this.gamepadVibration;
		}
	}

	// Token: 0x06001C92 RID: 7314 RVA: 0x00085CDC File Offset: 0x00083EDC
	public static VibrationData Create(LowFidelityVibrations lowFidelityVibration = LowFidelityVibrations.None, TextAsset highFidelityVibration = null, GamepadVibration gamepadVibration = null)
	{
		return new VibrationData
		{
			lowFidelityVibration = lowFidelityVibration,
			highFidelityVibration = highFidelityVibration,
			gamepadVibration = gamepadVibration
		};
	}

	// Token: 0x04002217 RID: 8727
	[SerializeField]
	private LowFidelityVibrations lowFidelityVibration;

	// Token: 0x04002218 RID: 8728
	[SerializeField]
	private TextAsset highFidelityVibration;

	// Token: 0x04002219 RID: 8729
	[SerializeField]
	private GamepadVibration gamepadVibration;
}
