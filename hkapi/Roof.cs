using System;
using UnityEngine;

// Token: 0x020003DF RID: 991
public class Roof : NonSlider
{
	// Token: 0x06001699 RID: 5785 RVA: 0x0006AFC0 File Offset: 0x000691C0
	protected void OnCollisionEnter2D(Collision2D collision)
	{
		GameObject gameObject = collision.gameObject;
		if (!gameObject.CompareTag("Player"))
		{
			return;
		}
		gameObject.SendMessage("CancelSuperDash", SendMessageOptions.DontRequireReceiver);
		gameObject.SendMessage("CancelHeroJump", SendMessageOptions.DontRequireReceiver);
	}

	// Token: 0x04001B37 RID: 6967
	private const string PlayerTag = "Player";

	// Token: 0x04001B38 RID: 6968
	private const string CancelSuperDashMethod = "CancelSuperDash";

	// Token: 0x04001B39 RID: 6969
	private const string CancelHeroJumpMethod = "CancelHeroJump";
}
