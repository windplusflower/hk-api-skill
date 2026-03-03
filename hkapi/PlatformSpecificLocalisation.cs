using System;
using UnityEngine;

// Token: 0x020002CF RID: 719
public class PlatformSpecificLocalisation : MonoBehaviour
{
	// Token: 0x06000F0E RID: 3854 RVA: 0x0004A148 File Offset: 0x00048348
	private void Awake()
	{
		AutoLocalizeTextUI component = base.GetComponent<AutoLocalizeTextUI>();
		SetTextMeshProGameText component2 = base.GetComponent<SetTextMeshProGameText>();
		if (component != null || component2 != null)
		{
			PlatformSpecificLocalisation.PlatformKey[] array = this.platformKeys;
			int i = 0;
			while (i < array.Length)
			{
				PlatformSpecificLocalisation.PlatformKey platformKey = array[i];
				if (platformKey.platform == Application.platform)
				{
					if (component != null)
					{
						component.sheetTitle = platformKey.sheetTitle;
						component.textKey = platformKey.textKey;
					}
					if (component2 != null)
					{
						component2.sheetName = platformKey.sheetTitle;
						component2.convName = platformKey.textKey;
						return;
					}
					break;
				}
				else
				{
					i++;
				}
			}
		}
	}

	// Token: 0x04000FD3 RID: 4051
	public PlatformSpecificLocalisation.PlatformKey[] platformKeys;

	// Token: 0x020002D0 RID: 720
	[Serializable]
	public struct PlatformKey
	{
		// Token: 0x04000FD4 RID: 4052
		public RuntimePlatform platform;

		// Token: 0x04000FD5 RID: 4053
		public string sheetTitle;

		// Token: 0x04000FD6 RID: 4054
		public string textKey;
	}
}
