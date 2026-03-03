using System;
using HutongGames.PlayMaker;

// Token: 0x0200030E RID: 782
[ActionCategory("Hollow Knight")]
public class SetRespawningHero : FsmStateAction
{
	// Token: 0x0600112B RID: 4395 RVA: 0x00050D8A File Offset: 0x0004EF8A
	public override void Reset()
	{
		this.value = null;
	}

	// Token: 0x0600112C RID: 4396 RVA: 0x00050D93 File Offset: 0x0004EF93
	public override void OnEnter()
	{
		if (GameManager.instance)
		{
			GameManager.instance.RespawningHero = this.value.Value;
		}
		base.Finish();
	}

	// Token: 0x040010E7 RID: 4327
	public FsmBool value;
}
