using System;
using TMPro;
using UnityEngine;

// Token: 0x02000450 RID: 1104
public class DisplayItemAmount : MonoBehaviour
{
	// Token: 0x060018D2 RID: 6354 RVA: 0x000741D8 File Offset: 0x000723D8
	private void OnEnable()
	{
		if (this.playerData == null)
		{
			this.playerData = PlayerData.instance;
		}
		string text = this.playerData.GetInt(this.playerDataInt).ToString();
		this.textObject.text = text;
	}

	// Token: 0x04001DC1 RID: 7617
	public string playerDataInt;

	// Token: 0x04001DC2 RID: 7618
	public TextMeshPro textObject;

	// Token: 0x04001DC3 RID: 7619
	private PlayerData playerData;
}
