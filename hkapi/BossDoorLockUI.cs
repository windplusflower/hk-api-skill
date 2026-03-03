using System;
using System.Collections;
using UnityEngine;

// Token: 0x0200028F RID: 655
public class BossDoorLockUI : MonoBehaviour
{
	// Token: 0x06000DBC RID: 3516 RVA: 0x00044010 File Offset: 0x00042210
	private void Awake()
	{
		this.group = base.GetComponent<CanvasGroup>();
		this.animator = base.GetComponent<Animator>();
		this.bossIcons = (this.iconParent ? this.iconParent.GetComponentsInChildren<BossDoorLockUIIcon>() : new BossDoorLockUIIcon[0]);
	}

	// Token: 0x06000DBD RID: 3517 RVA: 0x00044050 File Offset: 0x00042250
	public void Show(BossSequenceDoor door)
	{
		this.group.alpha = 0f;
		base.gameObject.SetActive(true);
		if (door && door.bossSequence)
		{
			BossSequenceDoor.Completion currentCompletion = door.CurrentCompletion;
			foreach (BossDoorLockUIIcon bossDoorLockUIIcon in this.bossIcons)
			{
				bossDoorLockUIIcon.bossIcon.enabled = false;
				bossDoorLockUIIcon.SetUnlocked(false, false, 0);
			}
			int count = door.bossSequence.Count;
			int num = 0;
			int num2 = 0;
			int num3 = 0;
			for (int j = 0; j < count; j++)
			{
				if (door.bossSequence.IsSceneHidden(j))
				{
					num--;
				}
				else
				{
					BossScene bossScene = door.bossSequence.GetBossScene(j);
					string sceneObjectName = door.bossSequence.GetSceneObjectName(j);
					int num4 = j + num;
					num3 = num4;
					if (num4 < this.bossIcons.Length && this.bossIcons[num4])
					{
						this.bossIcons[num4].gameObject.SetActive(true);
						if (bossScene.DisplayIcon)
						{
							this.bossIcons[num4].bossIcon.enabled = true;
							this.bossIcons[num4].bossIcon.sprite = bossScene.DisplayIcon;
							this.bossIcons[num4].bossIcon.SetNativeSize();
						}
						if (bossScene.IsUnlocked(BossSceneCheckSource.Sequence))
						{
							if (currentCompletion.viewedBossSceneCompletions.Contains(sceneObjectName))
							{
								this.bossIcons[num4].SetUnlocked(true, false, 0);
							}
							else
							{
								this.bossIcons[num4].SetUnlocked(true, true, num2);
								num2++;
								currentCompletion.viewedBossSceneCompletions.Add(sceneObjectName);
							}
						}
					}
				}
			}
			for (int k = num3 + 1; k < this.bossIcons.Length; k++)
			{
				this.bossIcons[k].gameObject.SetActive(false);
			}
			door.CurrentCompletion = currentCompletion;
		}
		if (this.fadeRoutine != null)
		{
			base.StopCoroutine(this.fadeRoutine);
		}
		this.fadeRoutine = base.StartCoroutine(this.ShowRoutine());
		FSMUtility.SendEventToGameObject(GameCameras.instance.hudCanvas, "OUT", false);
	}

	// Token: 0x06000DBE RID: 3518 RVA: 0x0004427C File Offset: 0x0004247C
	public void Hide()
	{
		BossDoorLockUIIcon[] array = this.bossIcons;
		for (int i = 0; i < array.Length; i++)
		{
			array[i].StopAllCoroutines();
		}
		if (this.fadeRoutine != null)
		{
			base.StopCoroutine(this.fadeRoutine);
		}
		this.fadeRoutine = base.StartCoroutine(this.HideRoutine());
	}

	// Token: 0x06000DBF RID: 3519 RVA: 0x000442CC File Offset: 0x000424CC
	private IEnumerator ShowRoutine()
	{
		if (this.buttonPrompts)
		{
			this.buttonPrompts.alpha = 0f;
		}
		if (this.animator)
		{
			this.animator.Play("Open");
			yield return null;
			yield return new WaitForSeconds(this.animator.GetCurrentAnimatorStateInfo(0).length);
		}
		this.group.alpha = 1f;
		if (this.fadeButtonRoutine != null)
		{
			this.StopCoroutine(this.fadeButtonRoutine);
		}
		this.fadeButtonRoutine = this.StartCoroutine(this.FadeButtonPrompts(1f, this.buttonPromptFadeTime));
		yield return this.fadeButtonRoutine;
		this.fadeRoutine = null;
		yield break;
	}

	// Token: 0x06000DC0 RID: 3520 RVA: 0x000442DB File Offset: 0x000424DB
	private IEnumerator HideRoutine()
	{
		if (this.animator)
		{
			this.animator.Play("Close");
			yield return null;
			float length = this.animator.GetCurrentAnimatorStateInfo(0).length;
			if (this.fadeButtonRoutine != null)
			{
				this.StopCoroutine(this.fadeButtonRoutine);
			}
			this.fadeButtonRoutine = this.StartCoroutine(this.FadeButtonPrompts(0f, length));
			yield return new WaitForSeconds(length);
		}
		FSMUtility.SendEventToGameObject(GameCameras.instance.hudCanvas, "IN", false);
		this.gameObject.SetActive(false);
		this.fadeRoutine = null;
		yield break;
	}

	// Token: 0x06000DC1 RID: 3521 RVA: 0x000442EA File Offset: 0x000424EA
	private IEnumerator FadeButtonPrompts(float toAlpha, float time)
	{
		if (this.buttonPrompts)
		{
			float startAlpha = this.buttonPrompts.alpha;
			for (float elapsed = 0f; elapsed < time; elapsed += Time.deltaTime)
			{
				this.buttonPrompts.alpha = Mathf.Lerp(startAlpha, toAlpha, elapsed / time);
				yield return null;
			}
			this.buttonPrompts.alpha = toAlpha;
		}
		this.fadeButtonRoutine = null;
		yield break;
	}

	// Token: 0x06000DC2 RID: 3522 RVA: 0x00044307 File Offset: 0x00042507
	public BossDoorLockUI()
	{
		this.buttonPromptFadeTime = 2f;
		base..ctor();
	}

	// Token: 0x04000E9D RID: 3741
	public GameObject iconParent;

	// Token: 0x04000E9E RID: 3742
	private BossDoorLockUIIcon[] bossIcons;

	// Token: 0x04000E9F RID: 3743
	public CanvasGroup buttonPrompts;

	// Token: 0x04000EA0 RID: 3744
	public float buttonPromptFadeTime;

	// Token: 0x04000EA1 RID: 3745
	private Coroutine fadeRoutine;

	// Token: 0x04000EA2 RID: 3746
	private Coroutine fadeButtonRoutine;

	// Token: 0x04000EA3 RID: 3747
	private CanvasGroup group;

	// Token: 0x04000EA4 RID: 3748
	private Animator animator;
}
