using System;
using System.Collections;
using UnityEngine;

// Token: 0x0200025D RID: 605
public class BossStatueDreamToggle : MonoBehaviour, IBossStatueToggle
{
	// Token: 0x06000CB9 RID: 3257 RVA: 0x00040A04 File Offset: 0x0003EC04
	private void OnEnable()
	{
		if (this.bossStatue && !this.bossStatue.UsingDreamVersion)
		{
			ParticleSystem[] array = this.particles;
			for (int i = 0; i < array.Length; i++)
			{
				array[i].Stop(true, ParticleSystemStopBehavior.StopEmitting);
			}
		}
	}

	// Token: 0x06000CBA RID: 3258 RVA: 0x00040A4C File Offset: 0x0003EC4C
	private void Start()
	{
		if (this.litPieces)
		{
			this.litPieces.SetActive(true);
			if (!this.bossStatue || !this.bossStatue.UsingDreamVersion)
			{
				this.litPieces.SetActive(false);
			}
			this.colorFaders = this.litPieces.GetComponentsInChildren<ColorFader>(true);
			ColorFader[] array = this.colorFaders;
			for (int i = 0; i < array.Length; i++)
			{
				array[i].OnFadeEnd += delegate(bool up)
				{
					if (!up)
					{
						this.waitingForFade--;
					}
				};
			}
		}
		if (this.dreamBurstEffectPrefab)
		{
			this.dreamBurstEffect = UnityEngine.Object.Instantiate<GameObject>(this.dreamBurstEffectPrefab, this.dreamBurstSpawnPoint);
			this.dreamBurstEffect.transform.localPosition = Vector3.zero;
			this.dreamBurstEffect.SetActive(false);
		}
		if (this.dreamBurstEffectOffPrefab)
		{
			this.dreamBurstEffectOff = UnityEngine.Object.Instantiate<GameObject>(this.dreamBurstEffectOffPrefab, this.dreamBurstSpawnPoint);
			this.dreamBurstEffectOff.transform.localPosition = Vector3.zero;
			this.dreamBurstEffectOff.SetActive(false);
		}
	}

	// Token: 0x06000CBB RID: 3259 RVA: 0x00040B60 File Offset: 0x0003ED60
	private void OnTriggerEnter2D(Collider2D collision)
	{
		if (!base.gameObject.activeInHierarchy || !this.canToggle)
		{
			return;
		}
		if (this.bossStatue && collision.tag == "Dream Attack")
		{
			bool flag = !this.bossStatue.UsingDreamVersion;
			this.bossStatue.SetDreamVersion(flag, false, true);
			if (this.dreamImpactPoint && this.dreamImpactPrefab)
			{
				this.dreamImpactPrefab.Spawn(this.dreamImpactPoint.position).transform.localScale = this.dreamImpactScale;
			}
			if (this.dreamBurstEffect)
			{
				this.dreamBurstEffect.SetActive(flag);
			}
			if (this.dreamBurstEffectOff)
			{
				this.dreamBurstEffectOff.SetActive(!flag);
			}
			base.StartCoroutine(this.Fade(this.bossStatue.UsingDreamVersion));
		}
	}

	// Token: 0x06000CBC RID: 3260 RVA: 0x00040C52 File Offset: 0x0003EE52
	private IEnumerator Fade(bool usingDreamVersion)
	{
		if (usingDreamVersion)
		{
			ParticleSystem[] array = this.particles;
			for (int i = 0; i < array.Length; i++)
			{
				array[i].Play();
			}
		}
		else
		{
			ParticleSystem[] array = this.particles;
			for (int i = 0; i < array.Length; i++)
			{
				array[i].Stop(true, ParticleSystemStopBehavior.StopEmitting);
			}
		}
		if (this.litPieces)
		{
			this.litPieces.SetActive(true);
		}
		foreach (ColorFader colorFader in this.colorFaders)
		{
			if (!usingDreamVersion)
			{
				this.waitingForFade++;
			}
			colorFader.Fade(usingDreamVersion);
		}
		if (!usingDreamVersion)
		{
			while (this.waitingForFade > 0)
			{
				yield return null;
			}
			if (this.litPieces)
			{
				this.litPieces.SetActive(false);
			}
		}
		yield break;
	}

	// Token: 0x06000CBD RID: 3261 RVA: 0x00040C68 File Offset: 0x0003EE68
	public void SetOwner(BossStatue statue)
	{
		this.bossStatue = statue;
		if (!this.bossStatue.UsingDreamVersion)
		{
			ParticleSystem[] array = this.particles;
			for (int i = 0; i < array.Length; i++)
			{
				array[i].Stop(true, ParticleSystemStopBehavior.StopEmittingAndClear);
			}
			return;
		}
		if (this.litPieces)
		{
			this.litPieces.SetActive(true);
		}
		ColorFader[] array2 = this.colorFaders;
		for (int i = 0; i < array2.Length; i++)
		{
			array2[i].Fade(true);
		}
	}

	// Token: 0x06000CBE RID: 3262 RVA: 0x00040CE0 File Offset: 0x0003EEE0
	public void SetState(bool value)
	{
		this.canToggle = value;
		if (!value)
		{
			base.gameObject.SetActive(this.canToggle);
		}
	}

	// Token: 0x06000CBF RID: 3263 RVA: 0x00040CFD File Offset: 0x0003EEFD
	public BossStatueDreamToggle()
	{
		this.dreamImpactScale = new Vector3(4f, 4f, 1f);
		this.canToggle = true;
		base..ctor();
	}

	// Token: 0x04000DAA RID: 3498
	public GameObject litPieces;

	// Token: 0x04000DAB RID: 3499
	public ParticleSystem[] particles;

	// Token: 0x04000DAC RID: 3500
	public GameObject dreamImpactPrefab;

	// Token: 0x04000DAD RID: 3501
	public Vector3 dreamImpactScale;

	// Token: 0x04000DAE RID: 3502
	public Transform dreamImpactPoint;

	// Token: 0x04000DAF RID: 3503
	private bool canToggle;

	// Token: 0x04000DB0 RID: 3504
	private ColorFader[] colorFaders;

	// Token: 0x04000DB1 RID: 3505
	private int waitingForFade;

	// Token: 0x04000DB2 RID: 3506
	public GameObject dreamBurstEffectPrefab;

	// Token: 0x04000DB3 RID: 3507
	public GameObject dreamBurstEffectOffPrefab;

	// Token: 0x04000DB4 RID: 3508
	public Transform dreamBurstSpawnPoint;

	// Token: 0x04000DB5 RID: 3509
	private GameObject dreamBurstEffect;

	// Token: 0x04000DB6 RID: 3510
	private GameObject dreamBurstEffectOff;

	// Token: 0x04000DB7 RID: 3511
	private BossStatue bossStatue;
}
