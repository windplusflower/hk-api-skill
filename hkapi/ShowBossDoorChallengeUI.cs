using System;
using HutongGames.PlayMaker;
using UnityEngine;

// Token: 0x02000288 RID: 648
[ActionCategory("Hollow Knight")]
public class ShowBossDoorChallengeUI : FsmStateAction
{
	// Token: 0x06000D97 RID: 3479 RVA: 0x00043954 File Offset: 0x00041B54
	public override void Reset()
	{
		this.targetDoor = null;
		this.prefab = null;
		this.challengeEvent = null;
		this.cancelEvent = null;
	}

	// Token: 0x06000D98 RID: 3480 RVA: 0x00043974 File Offset: 0x00041B74
	public override void OnEnter()
	{
		if (ShowBossDoorChallengeUI.spawnedUI == null && this.prefab.Value)
		{
			GameObject gameObject = UnityEngine.Object.Instantiate<GameObject>(this.prefab.Value);
			ShowBossDoorChallengeUI.spawnedUI = gameObject.GetComponent<BossDoorChallengeUI>();
			gameObject.SetActive(false);
		}
		if (ShowBossDoorChallengeUI.spawnedUI)
		{
			GameObject safe = this.targetDoor.GetSafe(this);
			BossSequenceDoor door = safe ? safe.GetComponent<BossSequenceDoor>() : null;
			ShowBossDoorChallengeUI.spawnedUI.Setup(door);
			ShowBossDoorChallengeUI.spawnedUI.Show();
			BossDoorChallengeUI.HideEvent temp2 = null;
			temp2 = delegate()
			{
				this.Fsm.Event(this.cancelEvent);
				ShowBossDoorChallengeUI.spawnedUI.OnHidden -= temp2;
			};
			ShowBossDoorChallengeUI.spawnedUI.OnHidden += temp2;
			BossDoorChallengeUI.BeginEvent temp = null;
			temp = delegate()
			{
				this.Fsm.Event(this.challengeEvent);
				ShowBossDoorChallengeUI.spawnedUI.OnBegin -= temp;
			};
			ShowBossDoorChallengeUI.spawnedUI.OnBegin += temp;
			return;
		}
	}

	// Token: 0x04000E7C RID: 3708
	private static BossDoorChallengeUI spawnedUI;

	// Token: 0x04000E7D RID: 3709
	public FsmOwnerDefault targetDoor;

	// Token: 0x04000E7E RID: 3710
	public FsmGameObject prefab;

	// Token: 0x04000E7F RID: 3711
	public FsmEvent cancelEvent;

	// Token: 0x04000E80 RID: 3712
	public FsmEvent challengeEvent;
}
