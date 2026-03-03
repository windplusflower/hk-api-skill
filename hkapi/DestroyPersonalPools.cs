using System;
using HutongGames.PlayMaker;

// Token: 0x02000311 RID: 785
[ActionCategory("Hollow Knight")]
public class DestroyPersonalPools : FsmStateAction
{
	// Token: 0x06001134 RID: 4404 RVA: 0x00050EAB File Offset: 0x0004F0AB
	public override void OnEnter()
	{
		if (GameManager.instance)
		{
			GameManager.instance.DoDestroyPersonalPools();
		}
		base.Finish();
	}
}
