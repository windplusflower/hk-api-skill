using System;
using HutongGames.PlayMaker;

// Token: 0x020000DA RID: 218
[ActionCategory("Hollow Knight")]
public class CameraRepositionToHero : FsmStateAction
{
	// Token: 0x06000486 RID: 1158 RVA: 0x000167A4 File Offset: 0x000149A4
	public override void OnEnter()
	{
		if (GameManager.instance && GameManager.instance.cameraCtrl)
		{
			GameManager.instance.cameraCtrl.PositionToHero(false);
		}
		base.Finish();
	}
}
