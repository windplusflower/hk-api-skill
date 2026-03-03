using System;
using UnityEngine;

// Token: 0x0200011B RID: 283
public class DeactivateInDarknessWithoutLantern : MonoBehaviour
{
	// Token: 0x060006A6 RID: 1702 RVA: 0x00026DB4 File Offset: 0x00024FB4
	private void Start()
	{
		this.gm = GameManager.instance;
		this.pd = this.gm.playerData;
		this.sm = this.gm.sm;
		if (this.sm.darknessLevel == 2 && !this.pd.GetBool("hasLantern"))
		{
			base.gameObject.SetActive(false);
		}
	}

	// Token: 0x0400073A RID: 1850
	private GameManager gm;

	// Token: 0x0400073B RID: 1851
	private PlayerData pd;

	// Token: 0x0400073C RID: 1852
	private SceneManager sm;
}
