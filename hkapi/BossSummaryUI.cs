using System;
using System.Collections;
using System.Collections.Generic;
using Language;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x02000295 RID: 661
public class BossSummaryUI : MonoBehaviour
{
	// Token: 0x06000DDF RID: 3551 RVA: 0x0004479B File Offset: 0x0004299B
	private void Awake()
	{
		this.animator = base.GetComponent<Animator>();
	}

	// Token: 0x06000DE0 RID: 3552 RVA: 0x000447AC File Offset: 0x000429AC
	private void Start()
	{
		CanvasGroup component = base.GetComponent<CanvasGroup>();
		if (component)
		{
			component.alpha = 0f;
		}
	}

	// Token: 0x06000DE1 RID: 3553 RVA: 0x000447D4 File Offset: 0x000429D4
	public void SetupUI(List<BossStatue> bossStatues)
	{
		this.listItemTemplate.SetActive(true);
		foreach (BossStatue bossStatue in bossStatues)
		{
			if (bossStatue.gameObject.activeInHierarchy)
			{
				this.CreateListItem(bossStatue, false);
				if (bossStatue && bossStatue.dreamBossScene)
				{
					this.CreateListItem(bossStatue, true);
				}
			}
		}
		this.listItemTemplate.SetActive(false);
	}

	// Token: 0x06000DE2 RID: 3554 RVA: 0x00044868 File Offset: 0x00042A68
	private void CreateListItem(BossStatue bossStatue, bool isAlt = false)
	{
		BossStatue.Completion completion = (bossStatue != null) ? (isAlt ? bossStatue.DreamStatueState : bossStatue.StatueState) : BossStatue.Completion.None;
		if (this.listItemTemplate)
		{
			if (!bossStatue.isHidden || completion.completedTier1 || completion.completedTier2 || completion.completedTier3)
			{
				GameObject gameObject = UnityEngine.Object.Instantiate<GameObject>(this.listItemTemplate, this.listItemTemplate.transform.parent);
				gameObject.name = string.Format("{0} ({1})", this.listItemTemplate.name, bossStatue ? bossStatue.gameObject.name : "null");
				int num = 0;
				if (completion.completedTier3)
				{
					num = 4;
				}
				else if (completion.completedTier2)
				{
					num = 3;
				}
				else if (completion.completedTier1)
				{
					num = 2;
				}
				else if (completion.isUnlocked)
				{
					num = 1;
				}
				Image componentInChildren = gameObject.GetComponentInChildren<Image>();
				if (componentInChildren)
				{
					if (bossStatue.hasNoTiers)
					{
						num = Mathf.Clamp(num, 0, 3);
						componentInChildren.sprite = this.noTierStateSprites[num];
						componentInChildren.SetNativeSize();
					}
					else if (num < this.stateSprites.Length && num >= 0)
					{
						componentInChildren.sprite = this.stateSprites[num];
						componentInChildren.SetNativeSize();
					}
				}
				Text componentInChildren2 = gameObject.GetComponentInChildren<Text>();
				if (componentInChildren2)
				{
					if (num > 0 && bossStatue)
					{
						componentInChildren2.text = Language.Get(isAlt ? bossStatue.dreamBossDetails.nameKey : bossStatue.bossDetails.nameKey, isAlt ? bossStatue.dreamBossDetails.nameSheet : bossStatue.bossDetails.nameSheet).GetProcessed(LocalisationHelper.FontSource.Trajan).ToUpper();
						return;
					}
					componentInChildren2.text = this.defaultName;
					return;
				}
			}
		}
		else
		{
			Debug.LogError("No List Item template assigned!", this);
		}
	}

	// Token: 0x06000DE3 RID: 3555 RVA: 0x00044A25 File Offset: 0x00042C25
	public void Show()
	{
		base.gameObject.SetActive(true);
		FSMUtility.SendEventToGameObject(GameCameras.instance.hudCanvas, "OUT", false);
	}

	// Token: 0x06000DE4 RID: 3556 RVA: 0x00044A48 File Offset: 0x00042C48
	public void Hide()
	{
		base.StartCoroutine(this.Close());
	}

	// Token: 0x06000DE5 RID: 3557 RVA: 0x00044A57 File Offset: 0x00042C57
	private IEnumerator Close()
	{
		if (this.animator)
		{
			this.animator.Play("Close");
			yield return null;
			yield return new WaitForSeconds(this.animator.GetCurrentAnimatorStateInfo(0).length);
		}
		FSMUtility.SendEventToGameObject(GameCameras.instance.hudCanvas, "IN", false);
		this.gameObject.SetActive(false);
		yield break;
	}

	// Token: 0x06000DE6 RID: 3558 RVA: 0x00044A66 File Offset: 0x00042C66
	public BossSummaryUI()
	{
		this.defaultName = ".....";
		base..ctor();
	}

	// Token: 0x04000EBE RID: 3774
	public GameObject listItemTemplate;

	// Token: 0x04000EBF RID: 3775
	public Sprite[] stateSprites;

	// Token: 0x04000EC0 RID: 3776
	public Sprite[] noTierStateSprites;

	// Token: 0x04000EC1 RID: 3777
	public string defaultName;

	// Token: 0x04000EC2 RID: 3778
	private Animator animator;
}
