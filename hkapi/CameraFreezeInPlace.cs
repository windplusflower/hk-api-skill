using System;
using HutongGames.PlayMaker;

// Token: 0x020000D9 RID: 217
[ActionCategory("Hollow Knight")]
public class CameraFreezeInPlace : FsmStateAction
{
	// Token: 0x06000483 RID: 1155 RVA: 0x00016763 File Offset: 0x00014963
	public override void Reset()
	{
		this.freezeTargetAlso = true;
	}

	// Token: 0x06000484 RID: 1156 RVA: 0x00016771 File Offset: 0x00014971
	public override void OnEnter()
	{
		if (GameManager.instance.cameraCtrl)
		{
			GameManager.instance.cameraCtrl.FreezeInPlace(this.freezeTargetAlso.Value);
		}
		base.Finish();
	}

	// Token: 0x04000421 RID: 1057
	public FsmBool freezeTargetAlso;
}
