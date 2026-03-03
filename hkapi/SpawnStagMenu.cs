using System;
using UnityEngine;

// Token: 0x0200040A RID: 1034
public class SpawnStagMenu : MonoBehaviour
{
	// Token: 0x0600176E RID: 5998 RVA: 0x0006EB24 File Offset: 0x0006CD24
	private void Start()
	{
		if (HeroController.instance)
		{
			HeroController.HeroInPosition temp = null;
			temp = delegate(bool <p0>)
			{
				this.SendEvent();
				HeroController.instance.heroInPosition -= temp;
			};
			HeroController.instance.heroInPosition += temp;
			return;
		}
		this.SendEvent();
	}

	// Token: 0x0600176F RID: 5999 RVA: 0x0006EB7A File Offset: 0x0006CD7A
	private void SendEvent()
	{
		if (GameCameras.instance)
		{
			this.fsm = GameCameras.instance.openStagFSM;
		}
		if (this.fsm)
		{
			this.fsm.SendEvent("SPAWN");
		}
	}

	// Token: 0x06001770 RID: 6000 RVA: 0x0006EBB5 File Offset: 0x0006CDB5
	private void OnDestroy()
	{
		if (this.fsm)
		{
			this.fsm.SendEvent("DESPAWN");
		}
	}

	// Token: 0x04001C2D RID: 7213
	private PlayMakerFSM fsm;
}
