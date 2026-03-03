using System;
using System.Collections;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x02000293 RID: 659
[RequireComponent(typeof(Animator))]
public class BossDoorLockUIIcon : MonoBehaviour
{
	// Token: 0x06000DD5 RID: 3541 RVA: 0x0004464A File Offset: 0x0004284A
	private void Awake()
	{
		this.animator = base.GetComponent<Animator>();
	}

	// Token: 0x06000DD6 RID: 3542 RVA: 0x00044658 File Offset: 0x00042858
	public void SetUnlocked(bool unlocked, bool doUnlockAnim = false, int indexAnimOffset = 0)
	{
		if (unlocked)
		{
			base.StartCoroutine(this.PlayAnimWithDelay("Unlock", doUnlockAnim, doUnlockAnim ? (this.unlockAnimDelay + this.indexOffsetDelay * (float)indexAnimOffset) : 0f));
			return;
		}
		this.animator.Play("Locked");
	}

	// Token: 0x06000DD7 RID: 3543 RVA: 0x000446A6 File Offset: 0x000428A6
	private IEnumerator PlayAnimWithDelay(string anim, bool doAnim, float delay)
	{
		yield return new WaitForSeconds(delay);
		if (doAnim)
		{
			this.animator.Play(anim);
			this.unlockSound.SpawnAndPlayOneShot(this.audioSourcePrefab, this.transform.position);
		}
		else
		{
			this.animator.Play(anim, 0, 1f);
		}
		yield break;
	}

	// Token: 0x06000DD8 RID: 3544 RVA: 0x000446CA File Offset: 0x000428CA
	public BossDoorLockUIIcon()
	{
		this.unlockAnimDelay = 1f;
		this.indexOffsetDelay = 0.25f;
		base..ctor();
	}

	// Token: 0x04000EB2 RID: 3762
	public Image bossIcon;

	// Token: 0x04000EB3 RID: 3763
	public float unlockAnimDelay;

	// Token: 0x04000EB4 RID: 3764
	public float indexOffsetDelay;

	// Token: 0x04000EB5 RID: 3765
	public AudioSource audioSourcePrefab;

	// Token: 0x04000EB6 RID: 3766
	public AudioEvent unlockSound;

	// Token: 0x04000EB7 RID: 3767
	private Animator animator;
}
