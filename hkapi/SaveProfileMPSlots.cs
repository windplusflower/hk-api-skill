using System;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x020004B7 RID: 1207
public class SaveProfileMPSlots : MonoBehaviour
{
	// Token: 0x06001AB9 RID: 6841 RVA: 0x0007FA70 File Offset: 0x0007DC70
	private void Awake()
	{
		this.mpUnits = base.GetComponentsInChildren<Image>(true);
	}

	// Token: 0x06001ABA RID: 6842 RVA: 0x0007FA80 File Offset: 0x0007DC80
	public void showMPSlots(int slotsToShow, bool steelsoulMode)
	{
		if (this.mpUnits == null)
		{
			this.Awake();
		}
		if (slotsToShow >= 0)
		{
			this.slotsToShow = slotsToShow;
			for (int i = 0; i < this.mpUnits.Length; i++)
			{
				if (i < slotsToShow)
				{
					this.mpUnits[i].gameObject.SetActive(true);
				}
				else
				{
					this.mpUnits[i].gameObject.SetActive(false);
				}
				if (steelsoulMode)
				{
					this.mpUnits[i].sprite = this.steelSoulOrb;
				}
				else
				{
					this.mpUnits[i].sprite = this.normalSoulOrb;
				}
			}
		}
	}

	// Token: 0x0400200B RID: 8203
	private int slotsToShow;

	// Token: 0x0400200C RID: 8204
	private Image[] mpUnits;

	// Token: 0x0400200D RID: 8205
	public Sprite normalSoulOrb;

	// Token: 0x0400200E RID: 8206
	public Sprite steelSoulOrb;
}
