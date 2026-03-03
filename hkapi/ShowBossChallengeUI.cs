using System;
using HutongGames.PlayMaker;
using UnityEngine;

// Token: 0x02000279 RID: 633
[ActionCategory("Hollow Knight")]
public class ShowBossChallengeUI : FsmStateAction
{
	// Token: 0x06000D48 RID: 3400 RVA: 0x000424D0 File Offset: 0x000406D0
	public override void Reset()
	{
		this.prefab = null;
		this.bossNameSheet = null;
		this.bossNameKey = null;
		this.descriptionSheet = null;
		this.descriptionKey = null;
		this.levelSelectedEvent = null;
	}

	// Token: 0x06000D49 RID: 3401 RVA: 0x000424FC File Offset: 0x000406FC
	public override void OnEnter()
	{
		if (ShowBossChallengeUI.spawnedUI == null && this.prefab.Value)
		{
			ShowBossChallengeUI.spawnedUI = UnityEngine.Object.Instantiate<GameObject>(this.prefab.Value);
			ShowBossChallengeUI.spawnedUI.SetActive(false);
		}
		if (ShowBossChallengeUI.spawnedUI)
		{
			GameObject gameObject = ShowBossChallengeUI.spawnedUI;
			gameObject.transform.position = this.prefab.Value.transform.position;
			gameObject.SetActive(true);
			BossChallengeUI ui = gameObject.GetComponent<BossChallengeUI>();
			if (ui)
			{
				BossStatue componentInParent = base.Owner.GetComponentInParent<BossStatue>();
				BossChallengeUI.HideEvent temp2 = null;
				temp2 = delegate()
				{
					this.Finish();
					ui.OnCancel -= temp2;
				};
				ui.OnCancel += temp2;
				BossChallengeUI.LevelSelectedEvent temp = null;
				temp = delegate()
				{
					this.Fsm.Event(this.levelSelectedEvent);
					ui.OnLevelSelected -= temp;
				};
				ui.OnLevelSelected += temp;
				ui.Setup(componentInParent, this.bossNameSheet.Value, this.bossNameKey.Value, this.descriptionSheet.Value, this.descriptionKey.Value);
				return;
			}
		}
		base.Finish();
	}

	// Token: 0x04000E1E RID: 3614
	private static GameObject spawnedUI;

	// Token: 0x04000E1F RID: 3615
	public FsmGameObject prefab;

	// Token: 0x04000E20 RID: 3616
	public FsmString bossNameSheet;

	// Token: 0x04000E21 RID: 3617
	public FsmString bossNameKey;

	// Token: 0x04000E22 RID: 3618
	public FsmString descriptionSheet;

	// Token: 0x04000E23 RID: 3619
	public FsmString descriptionKey;

	// Token: 0x04000E24 RID: 3620
	public FsmEvent levelSelectedEvent;
}
