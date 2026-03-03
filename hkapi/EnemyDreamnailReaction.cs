using System;
using HutongGames.PlayMaker;
using UnityEngine;

// Token: 0x02000185 RID: 389
public class EnemyDreamnailReaction : MonoBehaviour
{
	// Token: 0x060008CA RID: 2250 RVA: 0x0003074C File Offset: 0x0002E94C
	protected void Reset()
	{
		this.convoAmount = 8;
		this.convoTitle = "GENERIC";
		this.startSuppressed = false;
	}

	// Token: 0x060008CB RID: 2251 RVA: 0x00030767 File Offset: 0x0002E967
	protected void Start()
	{
		this.state = (this.startSuppressed ? EnemyDreamnailReaction.States.Suppressed : EnemyDreamnailReaction.States.Ready);
	}

	// Token: 0x060008CC RID: 2252 RVA: 0x0003077C File Offset: 0x0002E97C
	public void RecieveDreamImpact()
	{
		if (this.state != EnemyDreamnailReaction.States.Ready)
		{
			return;
		}
		if (!this.noSoul)
		{
			int amount = GameManager.instance.playerData.GetBool("equippedCharm_30") ? 66 : 33;
			HeroController.instance.AddMPCharge(amount);
		}
		this.ShowConvo();
		if (this.dreamImpactPrefab != null)
		{
			this.dreamImpactPrefab.Spawn().transform.position = base.transform.position;
		}
		Recoil component = base.GetComponent<Recoil>();
		if (component != null)
		{
			bool flag = HeroController.instance.transform.localScale.x <= 0f;
			component.RecoilByDirection(flag ? 0 : 2, 2f);
		}
		SpriteFlash component2 = base.gameObject.GetComponent<SpriteFlash>();
		if (component2 != null)
		{
			component2.flashDreamImpact();
		}
		this.state = EnemyDreamnailReaction.States.CoolingDown;
		this.cooldownTimeRemaining = 0.2f;
	}

	// Token: 0x060008CD RID: 2253 RVA: 0x00030865 File Offset: 0x0002EA65
	public void MakeReady()
	{
		if (this.state != EnemyDreamnailReaction.States.Suppressed)
		{
			return;
		}
		this.state = EnemyDreamnailReaction.States.Ready;
	}

	// Token: 0x060008CE RID: 2254 RVA: 0x00030877 File Offset: 0x0002EA77
	public void SetConvoTitle(string title)
	{
		this.convoTitle = title;
	}

	// Token: 0x060008CF RID: 2255 RVA: 0x00030880 File Offset: 0x0002EA80
	private void ShowConvo()
	{
		PlayMakerFSM playMakerFSM = PlayMakerFSM.FindFsmOnGameObject(FsmVariables.GlobalVariables.GetFsmGameObject("Enemy Dream Msg").Value, "Display");
		playMakerFSM.FsmVariables.GetFsmInt("Convo Amount").Value = this.convoAmount;
		playMakerFSM.FsmVariables.GetFsmString("Convo Title").Value = this.convoTitle;
		playMakerFSM.SendEvent("DISPLAY ENEMY DREAM");
	}

	// Token: 0x060008D0 RID: 2256 RVA: 0x000308EB File Offset: 0x0002EAEB
	protected void Update()
	{
		if (this.state == EnemyDreamnailReaction.States.CoolingDown)
		{
			this.cooldownTimeRemaining -= Time.deltaTime;
			if (this.cooldownTimeRemaining <= 0f)
			{
				this.state = EnemyDreamnailReaction.States.Ready;
			}
		}
	}

	// Token: 0x040009C1 RID: 2497
	private const int RegularMPGain = 33;

	// Token: 0x040009C2 RID: 2498
	private const int BoostedMPGain = 66;

	// Token: 0x040009C3 RID: 2499
	private const float AttackMagnitude = 2f;

	// Token: 0x040009C4 RID: 2500
	private const float CooldownDuration = 0.2f;

	// Token: 0x040009C5 RID: 2501
	[SerializeField]
	private int convoAmount;

	// Token: 0x040009C6 RID: 2502
	[SerializeField]
	private string convoTitle;

	// Token: 0x040009C7 RID: 2503
	[SerializeField]
	private bool startSuppressed;

	// Token: 0x040009C8 RID: 2504
	[SerializeField]
	private bool noSoul;

	// Token: 0x040009C9 RID: 2505
	[SerializeField]
	private GameObject dreamImpactPrefab;

	// Token: 0x040009CA RID: 2506
	public bool allowUseChildColliders;

	// Token: 0x040009CB RID: 2507
	private EnemyDreamnailReaction.States state;

	// Token: 0x040009CC RID: 2508
	private float cooldownTimeRemaining;

	// Token: 0x02000186 RID: 390
	private enum States
	{
		// Token: 0x040009CE RID: 2510
		Suppressed,
		// Token: 0x040009CF RID: 2511
		Ready,
		// Token: 0x040009D0 RID: 2512
		CoolingDown
	}
}
