using System;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x020004B6 RID: 1206
public class SaveProfileHealthBar : MonoBehaviour
{
	// Token: 0x06001AB6 RID: 6838 RVA: 0x0007F9C6 File Offset: 0x0007DBC6
	public void Awake()
	{
		this.healthUnits = base.GetComponentsInChildren<Image>(true);
	}

	// Token: 0x06001AB7 RID: 6839 RVA: 0x0007F9D8 File Offset: 0x0007DBD8
	public void showHealth(int numberToShow, bool steelsoulMode)
	{
		if (this.healthUnits == null)
		{
			this.Awake();
		}
		if (numberToShow > 0)
		{
			this.buttonsToShow = numberToShow;
			for (int i = 0; i < this.healthUnits.Length; i++)
			{
				if (i < this.buttonsToShow)
				{
					this.healthUnits[i].gameObject.SetActive(true);
				}
				else
				{
					this.healthUnits[i].gameObject.SetActive(false);
				}
				if (steelsoulMode)
				{
					this.healthUnits[i].sprite = this.steelHealth;
				}
				else
				{
					this.healthUnits[i].sprite = this.normalHealth;
				}
			}
		}
	}

	// Token: 0x04002007 RID: 8199
	private int buttonsToShow;

	// Token: 0x04002008 RID: 8200
	private Image[] healthUnits;

	// Token: 0x04002009 RID: 8201
	public Sprite normalHealth;

	// Token: 0x0400200A RID: 8202
	public Sprite steelHealth;
}
