using System;
using UnityEngine;

// Token: 0x020003BB RID: 955
public class EnviroRegion : MonoBehaviour
{
	// Token: 0x060015F2 RID: 5618 RVA: 0x00068345 File Offset: 0x00066545
	private void Start()
	{
		this.gm = GameManager.instance;
		this.pd = PlayerData.instance;
		this.heroCtrl = HeroController.instance;
	}

	// Token: 0x060015F3 RID: 5619 RVA: 0x00068368 File Offset: 0x00066568
	private void OnTriggerEnter2D()
	{
		this.pd.SetIntSwappedArgs(this.environmentType, "environmentType");
		this.heroCtrl.checkEnvironment();
	}

	// Token: 0x060015F4 RID: 5620 RVA: 0x0006838B File Offset: 0x0006658B
	private void OnTriggerExit2D()
	{
		this.pd.SetIntSwappedArgs(this.pd.GetInt("environmentTypeDefault"), "environmentType");
		this.heroCtrl.checkEnvironment();
	}

	// Token: 0x04001A58 RID: 6744
	public int environmentType;

	// Token: 0x04001A59 RID: 6745
	private GameManager gm;

	// Token: 0x04001A5A RID: 6746
	private PlayerData pd;

	// Token: 0x04001A5B RID: 6747
	private HeroController heroCtrl;
}
