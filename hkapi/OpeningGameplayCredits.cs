using System;
using UnityEngine;

// Token: 0x020001FE RID: 510
public class OpeningGameplayCredits : MonoBehaviour
{
	// Token: 0x06000B1B RID: 2843 RVA: 0x0003AED8 File Offset: 0x000390D8
	private void Start()
	{
		this.pd = PlayerData.instance;
		if (!this.pd.GetBool("openingCreditsPlayed"))
		{
			if (this.animator)
			{
				this.animator.SetBool("playCredits", true);
			}
			this.pd.SetBoolSwappedArgs(true, "openingCreditsPlayed");
		}
	}

	// Token: 0x04000C28 RID: 3112
	public Animator animator;

	// Token: 0x04000C29 RID: 3113
	private PlayerData pd;
}
