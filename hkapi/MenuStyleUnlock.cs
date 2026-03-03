using System;
using UnityEngine;

// Token: 0x0200049B RID: 1179
public class MenuStyleUnlock : MonoBehaviour
{
	// Token: 0x06001A50 RID: 6736 RVA: 0x0007E570 File Offset: 0x0007C770
	private void Start()
	{
		MenuStyleUnlock.Unlock(this.unlockKey);
		if (GameManager.instance.GetPlayerDataInt("permadeathMode") == 1)
		{
			MenuStyleUnlock.Unlock("steelSoulMenu");
		}
	}

	// Token: 0x06001A51 RID: 6737 RVA: 0x0007E59C File Offset: 0x0007C79C
	public static void Unlock(string key)
	{
		if (key != "" && Platform.Current.EncryptedSharedData.GetInt(key, 0) == 0)
		{
			Platform.Current.SharedData.SetString("unlockedMenuStyle", key);
			Platform.Current.EncryptedSharedData.SetInt(key, 1);
		}
	}

	// Token: 0x06001A52 RID: 6738 RVA: 0x0007E5EF File Offset: 0x0007C7EF
	public MenuStyleUnlock()
	{
		this.unlockKey = "";
		base..ctor();
	}

	// Token: 0x04001FAA RID: 8106
	public string unlockKey;
}
