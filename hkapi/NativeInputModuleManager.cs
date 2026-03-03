using System;
using InControl;
using UnityEngine;

// Token: 0x020002AE RID: 686
public class NativeInputModuleManager : MonoBehaviour
{
	// Token: 0x1700019E RID: 414
	// (get) Token: 0x06000E80 RID: 3712 RVA: 0x00048011 File Offset: 0x00046211
	// (set) Token: 0x06000E81 RID: 3713 RVA: 0x00048018 File Offset: 0x00046218
	public static bool IsUsed
	{
		get
		{
			return NativeInputModuleManager._isUsed;
		}
		set
		{
			NativeInputModuleManager.ChangeIsUsed(value);
		}
	}

	// Token: 0x1700019F RID: 415
	// (get) Token: 0x06000E82 RID: 3714 RVA: 0x00048020 File Offset: 0x00046220
	public static bool IsRestartRequired
	{
		get
		{
			return NativeInputModuleManager._isUsedAtStart != NativeInputModuleManager._isUsed;
		}
	}

	// Token: 0x06000E83 RID: 3715 RVA: 0x00048031 File Offset: 0x00046231
	private void Awake()
	{
		if (NativeInputModuleManager._instance != null)
		{
			UnityEngine.Object.Destroy(this);
			return;
		}
		NativeInputModuleManager._instance = this;
	}

	// Token: 0x06000E84 RID: 3716 RVA: 0x0004804D File Offset: 0x0004624D
	private void OnDestroy()
	{
		if (NativeInputModuleManager._instance == this)
		{
			NativeInputModuleManager._instance = null;
		}
	}

	// Token: 0x06000E85 RID: 3717 RVA: 0x00048064 File Offset: 0x00046264
	protected void OnEnable()
	{
		if (NativeInputModuleManager._instance != this)
		{
			return;
		}
		NativeInputModuleManager._isUsedAtStart = (Platform.Current.SharedData.GetInt("NativeInput", 1) > 0);
		InControlManager component = base.GetComponent<InControlManager>();
		if (component == null)
		{
			Debug.LogError("Unable to find input manager.");
			return;
		}
		if (InputManager.IsSetup)
		{
			Debug.LogError("Too late to enable native input module.");
			return;
		}
		component.enableXInput = NativeInputModuleManager._isUsedAtStart;
		component.enableNativeInput = NativeInputModuleManager._isUsedAtStart;
		component.nativeInputEnableXInput = NativeInputModuleManager._isUsedAtStart;
		NativeInputModuleManager._isUsed = NativeInputModuleManager._isUsedAtStart;
	}

	// Token: 0x06000E86 RID: 3718 RVA: 0x000480F4 File Offset: 0x000462F4
	private static void ChangeIsUsed(bool willUse)
	{
		if (NativeInputModuleManager._isUsed != willUse)
		{
			NativeInputModuleManager._isUsed = willUse;
			Platform.Current.SharedData.SetInt("NativeInput", NativeInputModuleManager._isUsed ? 1 : 0);
		}
	}

	// Token: 0x04000F37 RID: 3895
	private static NativeInputModuleManager _instance;

	// Token: 0x04000F38 RID: 3896
	private static bool _isUsedAtStart;

	// Token: 0x04000F39 RID: 3897
	private static bool _isUsed;
}
