using System;
using System.Collections;
using UnityEngine;

// Token: 0x0200029A RID: 666
public class GodfinderIcon : MonoBehaviour
{
	// Token: 0x06000DF6 RID: 3574 RVA: 0x00044DDB File Offset: 0x00042FDB
	private void Awake()
	{
		GodfinderIcon.instance = this;
		this.renderer = base.GetComponent<MeshRenderer>();
		this.spriteAnimator = base.GetComponent<tk2dSpriteAnimator>();
	}

	// Token: 0x06000DF7 RID: 3575 RVA: 0x00044DFB File Offset: 0x00042FFB
	private void Start()
	{
		this.renderer.enabled = false;
	}

	// Token: 0x06000DF8 RID: 3576 RVA: 0x00044E09 File Offset: 0x00043009
	private void Update()
	{
		if (this.isVisible && !this.spriteAnimator.Playing)
		{
			this.Hide();
		}
	}

	// Token: 0x06000DF9 RID: 3577 RVA: 0x00044E28 File Offset: 0x00043028
	public static void ShowIcon(float delay, BossScene bossScene)
	{
		if (GameManager.instance.playerData.GetBool("bossRushMode"))
		{
			return;
		}
		if (GameManager.instance.playerData.GetBool("hasGodfinder"))
		{
			if (bossScene != null && bossScene.IsUnlocked(BossSceneCheckSource.Godfinder))
			{
				return;
			}
			GameManager.instance.playerData.SetBoolSwappedArgs(true, "unlockedNewBossStatue");
			if (GodfinderIcon.instance)
			{
				if (GameManager.instance.GetCurrentMapZone() != "GODS_GLORY")
				{
					GodfinderIcon.instance.StartCoroutine(GodfinderIcon.instance.Show(delay));
					return;
				}
				GameManager.instance.playerData.SetBoolSwappedArgs(true, "queuedGodfinderIcon");
			}
		}
	}

	// Token: 0x06000DFA RID: 3578 RVA: 0x00044EDC File Offset: 0x000430DC
	public static void ShowIconQueued(float delay)
	{
		if (GameManager.instance.playerData.GetBool("bossRushMode"))
		{
			return;
		}
		if (GodfinderIcon.instance && GameManager.instance.playerData.GetBool("queuedGodfinderIcon"))
		{
			GodfinderIcon.instance.StartCoroutine(GodfinderIcon.instance.Show(delay));
			GameManager.instance.playerData.SetBoolSwappedArgs(false, "queuedGodfinderIcon");
		}
	}

	// Token: 0x06000DFB RID: 3579 RVA: 0x00044F4D File Offset: 0x0004314D
	private IEnumerator Show(float delay)
	{
		yield return new WaitForSeconds(delay);
		this.renderer.enabled = true;
		this.spriteAnimator.PlayFromFrame(0);
		this.showSound.SpawnAndPlayOneShot(this.audioPlayerPrefab, this.transform.position);
		this.isVisible = true;
		yield break;
	}

	// Token: 0x06000DFC RID: 3580 RVA: 0x00044F63 File Offset: 0x00043163
	private void Hide()
	{
		this.renderer.enabled = false;
		this.isVisible = false;
	}

	// Token: 0x04000ED1 RID: 3793
	private static GodfinderIcon instance;

	// Token: 0x04000ED2 RID: 3794
	public AudioSource audioPlayerPrefab;

	// Token: 0x04000ED3 RID: 3795
	public AudioEvent showSound;

	// Token: 0x04000ED4 RID: 3796
	private bool isVisible;

	// Token: 0x04000ED5 RID: 3797
	private MeshRenderer renderer;

	// Token: 0x04000ED6 RID: 3798
	private tk2dSpriteAnimator spriteAnimator;
}
