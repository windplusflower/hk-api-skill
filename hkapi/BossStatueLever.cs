using System;
using UnityEngine;

// Token: 0x02000266 RID: 614
public class BossStatueLever : MonoBehaviour, IBossStatueToggle
{
	// Token: 0x06000CE7 RID: 3303 RVA: 0x00041430 File Offset: 0x0003F630
	private void Enable()
	{
		base.gameObject.SetActive(true);
	}

	// Token: 0x06000CE8 RID: 3304 RVA: 0x00041440 File Offset: 0x0003F640
	private void OnTriggerEnter2D(Collider2D collision)
	{
		if (!base.gameObject.activeInHierarchy || !this.canToggle)
		{
			return;
		}
		if (collision.tag == "Nail Attack")
		{
			this.bossStatue.SetDreamVersion(!this.bossStatue.UsingDreamVersion, true, true);
			this.canToggle = false;
			this.switchSound.SpawnAndPlayOneShot(this.audioPlayerPrefab, base.transform.position);
			GameManager.instance.FreezeMoment(1);
			GameCameras.instance.cameraShakeFSM.SendEvent("EnemyKillShake");
			if (this.strikeNailPrefab && this.hitOrigin)
			{
				this.strikeNailPrefab.Spawn(this.hitOrigin.transform.position);
			}
			if (this.leverAnimator)
			{
				this.leverAnimator.Play("Hit");
			}
		}
	}

	// Token: 0x06000CE9 RID: 3305 RVA: 0x00041528 File Offset: 0x0003F728
	public void SetOwner(BossStatue statue)
	{
		this.bossStatue = statue;
		if (this.bossStatue.UsingDreamVersion)
		{
			this.bossStatue.SetDreamVersion(true, true, false);
		}
		this.bossStatue.OnStatueSwapFinished += delegate()
		{
			this.canToggle = true;
			if (this.leverAnimator)
			{
				this.leverAnimator.Play("Shine");
			}
		};
	}

	// Token: 0x06000CEA RID: 3306 RVA: 0x00041563 File Offset: 0x0003F763
	public void SetState(bool value)
	{
		this.canToggle = value;
		if (!value)
		{
			base.gameObject.SetActive(false);
		}
	}

	// Token: 0x06000CEB RID: 3307 RVA: 0x0004157B File Offset: 0x0003F77B
	public BossStatueLever()
	{
		this.canToggle = true;
		base..ctor();
	}

	// Token: 0x04000DD8 RID: 3544
	public Transform hitOrigin;

	// Token: 0x04000DD9 RID: 3545
	public AudioSource audioPlayerPrefab;

	// Token: 0x04000DDA RID: 3546
	public AudioEvent switchSound;

	// Token: 0x04000DDB RID: 3547
	public GameObject strikeNailPrefab;

	// Token: 0x04000DDC RID: 3548
	private bool canToggle;

	// Token: 0x04000DDD RID: 3549
	public Animator leverAnimator;

	// Token: 0x04000DDE RID: 3550
	private BossStatue bossStatue;
}
