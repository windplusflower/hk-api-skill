using System;
using HutongGames.PlayMaker;
using UnityEngine;

// Token: 0x02000194 RID: 404
public class ExtraDamageable : MonoBehaviour, IExtraDamageable
{
	// Token: 0x060008FF RID: 2303 RVA: 0x000322B0 File Offset: 0x000304B0
	protected void Awake()
	{
		this.healthManagerFsm = FSMUtility.LocateFSM(base.gameObject, "health_manager_enemy");
		if (this.healthManagerFsm != null)
		{
			this.invincibleVar = this.healthManagerFsm.FsmVariables.GetFsmBool("Invincible");
			this.hpVar = this.healthManagerFsm.FsmVariables.GetFsmInt("HP");
		}
		this.healthManager = base.GetComponent<HealthManager>();
		this.spriteFlash = base.GetComponent<SpriteFlash>();
		this.isSpellVulnerable = base.gameObject.CompareTag("Spell Vulnerable");
	}

	// Token: 0x06000900 RID: 2304 RVA: 0x00032345 File Offset: 0x00030545
	private void LateUpdate()
	{
		this.damagedThisFrame = false;
	}

	// Token: 0x06000901 RID: 2305 RVA: 0x00032350 File Offset: 0x00030550
	public void RecieveExtraDamage(ExtraDamageTypes extraDamageType)
	{
		if (this.damagedThisFrame)
		{
			return;
		}
		this.damagedThisFrame = true;
		if (!this.isSpellVulnerable && ((this.invincibleVar != null && this.invincibleVar.Value) || (this.healthManager != null && this.healthManager.IsInvincible)))
		{
			return;
		}
		this.impactClipTable.SpawnAndPlayOneShot(this.audioPlayerPrefab, base.transform.position);
		if (this.spriteFlash != null)
		{
			if (extraDamageType != ExtraDamageTypes.Spore)
			{
				if (extraDamageType - ExtraDamageTypes.Dung <= 1)
				{
					this.spriteFlash.flashDungQuick();
				}
			}
			else
			{
				this.spriteFlash.flashSporeQuick();
			}
		}
		this.ApplyExtraDamageToHealthManager(ExtraDamageable.GetDamageOfType(extraDamageType));
	}

	// Token: 0x06000902 RID: 2306 RVA: 0x000323FF File Offset: 0x000305FF
	public static int GetDamageOfType(ExtraDamageTypes extraDamageTypes)
	{
		if (extraDamageTypes <= ExtraDamageTypes.Dung || extraDamageTypes != ExtraDamageTypes.Dung2)
		{
			return 1;
		}
		return 2;
	}

	// Token: 0x06000903 RID: 2307 RVA: 0x0003240C File Offset: 0x0003060C
	private void ApplyExtraDamageToHealthManager(int damageAmount)
	{
		if (this.healthManagerFsm != null && this.hpVar != null)
		{
			int num = this.hpVar.Value - damageAmount;
			this.hpVar.Value = num;
			if (num <= 0)
			{
				FSMUtility.SendEventToGameObject(base.gameObject, "EXTRA KILL", false);
			}
		}
		if (this.healthManager != null)
		{
			this.healthManager.ApplyExtraDamage(damageAmount);
		}
	}

	// Token: 0x04000A15 RID: 2581
	private PlayMakerFSM healthManagerFsm;

	// Token: 0x04000A16 RID: 2582
	private FsmBool invincibleVar;

	// Token: 0x04000A17 RID: 2583
	private FsmInt hpVar;

	// Token: 0x04000A18 RID: 2584
	private SpriteFlash spriteFlash;

	// Token: 0x04000A19 RID: 2585
	private bool isSpellVulnerable;

	// Token: 0x04000A1A RID: 2586
	private HealthManager healthManager;

	// Token: 0x04000A1B RID: 2587
	[SerializeField]
	private RandomAudioClipTable impactClipTable;

	// Token: 0x04000A1C RID: 2588
	[SerializeField]
	private AudioSource audioPlayerPrefab;

	// Token: 0x04000A1D RID: 2589
	private bool damagedThisFrame;
}
