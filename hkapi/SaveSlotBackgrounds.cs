using System;
using GlobalEnums;
using UnityEngine;

// Token: 0x020004B8 RID: 1208
public class SaveSlotBackgrounds : MonoBehaviour
{
	// Token: 0x06001ABC RID: 6844 RVA: 0x0007FB14 File Offset: 0x0007DD14
	public AreaBackground GetBackground(string areaName)
	{
		if (this.areaBackgrounds != null && this.areaBackgrounds.Length != 0)
		{
			for (int i = 0; i < this.areaBackgrounds.Length; i++)
			{
				if (this.areaBackgrounds[i].areaName.ToString() == areaName)
				{
					return this.areaBackgrounds[i];
				}
			}
			return null;
		}
		Debug.LogError("No background images have been created in this prefab.");
		return null;
	}

	// Token: 0x06001ABD RID: 6845 RVA: 0x0007FB7C File Offset: 0x0007DD7C
	public AreaBackground GetBackground(MapZone mapZone)
	{
		if (this.areaBackgrounds != null && this.areaBackgrounds.Length != 0)
		{
			for (int i = 0; i < this.areaBackgrounds.Length; i++)
			{
				if (this.areaBackgrounds[i].areaName == mapZone)
				{
					return this.areaBackgrounds[i];
				}
			}
			return null;
		}
		Debug.LogError("No background images have been created in this prefab.");
		return null;
	}

	// Token: 0x0400200F RID: 8207
	[SerializeField]
	public AreaBackground[] areaBackgrounds;
}
