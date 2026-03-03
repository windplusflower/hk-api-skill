using System;
using UnityEngine;

// Token: 0x02000210 RID: 528
public class TutorialEntryPauser : MonoBehaviour
{
	// Token: 0x06000B69 RID: 2921 RVA: 0x0003C5A8 File Offset: 0x0003A7A8
	private void Start()
	{
		this.gm = GameManager.instance;
		this.pd = PlayerData.instance;
		this.hc = HeroController.instance;
		if (this.hc)
		{
			if (!this.pd.GetBool("openingCreditsPlayed") && !this.pd.GetBool("visitedDirtmouth"))
			{
				this.hc.enterWithoutInput = true;
				this.hc.IgnoreInput();
				this.hc.FaceRight();
				if (this.pd != null)
				{
					this.pd.SetBoolSwappedArgs(true, "disablePause");
					return;
				}
			}
			else if (this.gm.entryGateName == "top1")
			{
				this.hc.enterWithoutInput = true;
				this.hc.IgnoreInput();
				this.hc.FaceRight();
				base.Invoke("EnableControl", 3f);
				return;
			}
		}
		else
		{
			Debug.LogError("Entry Pauser could not find hero");
		}
	}

	// Token: 0x06000B6A RID: 2922 RVA: 0x0003C69A File Offset: 0x0003A89A
	private void EnableControl()
	{
		this.hc.enterWithoutInput = false;
		this.hc.AcceptInput();
	}

	// Token: 0x04000C5E RID: 3166
	private GameManager gm;

	// Token: 0x04000C5F RID: 3167
	private PlayerData pd;

	// Token: 0x04000C60 RID: 3168
	private HeroController hc;
}
