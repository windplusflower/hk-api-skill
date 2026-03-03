using System;
using InControl;

// Token: 0x0200050B RID: 1291
public static class VibrationManager
{
	// Token: 0x17000371 RID: 881
	// (get) Token: 0x06001C6E RID: 7278 RVA: 0x00085B55 File Offset: 0x00083D55
	// (set) Token: 0x06001C6F RID: 7279 RVA: 0x00085B5C File Offset: 0x00083D5C
	public static bool IsMuted
	{
		get
		{
			return VibrationManager.isMuted;
		}
		set
		{
			if (VibrationManager.isMuted != value)
			{
				VibrationManager.isMuted = value;
				if (VibrationManager.isMuted)
				{
					VibrationManager.StopAllVibration();
				}
			}
		}
	}

	// Token: 0x06001C70 RID: 7280 RVA: 0x00085B78 File Offset: 0x00083D78
	public static VibrationMixer GetMixer()
	{
		Platform platform = Platform.Current;
		if (platform != null)
		{
			VibrationManager.IVibrationMixerProvider vibrationMixerProvider = platform as VibrationManager.IVibrationMixerProvider;
			if (vibrationMixerProvider != null)
			{
				VibrationMixer vibrationMixer = vibrationMixerProvider.GetVibrationMixer();
				if (vibrationMixer != null)
				{
					return vibrationMixer;
				}
			}
		}
		InputDevice activeDevice = InputManager.ActiveDevice;
		if (activeDevice != null && activeDevice.IsAttached)
		{
			VibrationManager.IVibrationMixerProvider vibrationMixerProvider2 = activeDevice as VibrationManager.IVibrationMixerProvider;
			if (vibrationMixerProvider2 != null)
			{
				VibrationMixer vibrationMixer2 = vibrationMixerProvider2.GetVibrationMixer();
				if (vibrationMixer2 != null)
				{
					return vibrationMixer2;
				}
			}
		}
		return null;
	}

	// Token: 0x06001C71 RID: 7281 RVA: 0x00085BD8 File Offset: 0x00083DD8
	public static VibrationEmission PlayVibrationClipOneShot(VibrationData vibrationData, VibrationTarget? vibrationTarget = null, bool isLooping = false, string tag = "")
	{
		if (VibrationManager.isMuted)
		{
			return null;
		}
		VibrationMixer mixer = VibrationManager.GetMixer();
		if (mixer == null)
		{
			return null;
		}
		return mixer.PlayEmission(vibrationData, vibrationTarget ?? new VibrationTarget(VibrationMotors.All), isLooping, tag);
	}

	// Token: 0x06001C72 RID: 7282 RVA: 0x00085C1C File Offset: 0x00083E1C
	public static void StopAllVibration()
	{
		if (VibrationManager.isMuted)
		{
			return;
		}
		VibrationMixer mixer = VibrationManager.GetMixer();
		if (mixer == null)
		{
			return;
		}
		mixer.StopAllEmissions();
	}

	// Token: 0x06001C73 RID: 7283 RVA: 0x00085C44 File Offset: 0x00083E44
	public static void StopAllVibrationsWithTag(string tag)
	{
		if (VibrationManager.isMuted)
		{
			return;
		}
		VibrationMixer mixer = VibrationManager.GetMixer();
		if (mixer == null)
		{
			return;
		}
		mixer.StopAllEmissionsWithTag(tag);
	}

	// Token: 0x04002213 RID: 8723
	private static bool isMuted;

	// Token: 0x0200050C RID: 1292
	public interface IVibrationMixerProvider
	{
		// Token: 0x06001C74 RID: 7284
		VibrationMixer GetVibrationMixer();
	}
}
