using System;
using System.Collections;
using UnityEngine;

// Token: 0x02000391 RID: 913
public class PromptMarker : MonoBehaviour
{
	// Token: 0x06001521 RID: 5409 RVA: 0x000645AE File Offset: 0x000627AE
	private void Awake()
	{
		this.anim = base.GetComponent<tk2dSpriteAnimator>();
		if (this.labels)
		{
			this.fadeGroup = this.labels.GetComponent<FadeGroup>();
		}
	}

	// Token: 0x06001522 RID: 5410 RVA: 0x000645DA File Offset: 0x000627DA
	private void Start()
	{
		if (GameManager.instance)
		{
			GameManager.instance.UnloadingLevel += this.RecycleOnLevelLoad;
		}
	}

	// Token: 0x06001523 RID: 5411 RVA: 0x000645FE File Offset: 0x000627FE
	private void OnDestroy()
	{
		if (GameManager.instance)
		{
			GameManager.instance.UnloadingLevel -= this.RecycleOnLevelLoad;
		}
	}

	// Token: 0x06001524 RID: 5412 RVA: 0x00064622 File Offset: 0x00062822
	private void RecycleOnLevelLoad()
	{
		if (base.gameObject.activeSelf)
		{
			base.gameObject.Recycle();
		}
	}

	// Token: 0x06001525 RID: 5413 RVA: 0x0006463C File Offset: 0x0006283C
	private void OnEnable()
	{
		this.anim.Play("Blank");
	}

	// Token: 0x06001526 RID: 5414 RVA: 0x0006464E File Offset: 0x0006284E
	private void Update()
	{
		if (this.isVisible && (!this.owner || !this.owner.activeInHierarchy))
		{
			this.Hide();
		}
	}

	// Token: 0x06001527 RID: 5415 RVA: 0x00064678 File Offset: 0x00062878
	public void SetLabel(string labelName)
	{
		if (this.labels)
		{
			foreach (object obj in this.labels.transform)
			{
				Transform transform = (Transform)obj;
				transform.gameObject.SetActive(transform.name == labelName);
			}
		}
	}

	// Token: 0x06001528 RID: 5416 RVA: 0x000646F4 File Offset: 0x000628F4
	public void Show()
	{
		this.anim.Play("Up");
		base.transform.SetPositionZ(0f);
		this.fadeGroup.FadeUp();
		this.isVisible = true;
	}

	// Token: 0x06001529 RID: 5417 RVA: 0x00064728 File Offset: 0x00062928
	public void Hide()
	{
		this.anim.Play("Down");
		this.fadeGroup.FadeDown();
		this.owner = null;
		base.StartCoroutine(this.RecycleDelayed(this.fadeGroup.fadeOutTime));
		this.isVisible = false;
	}

	// Token: 0x0600152A RID: 5418 RVA: 0x00064776 File Offset: 0x00062976
	private IEnumerator RecycleDelayed(float delay)
	{
		yield return new WaitForSeconds(delay);
		this.gameObject.Recycle();
		yield break;
	}

	// Token: 0x0600152B RID: 5419 RVA: 0x0006478C File Offset: 0x0006298C
	public void SetOwner(GameObject obj)
	{
		this.owner = obj;
	}

	// Token: 0x04001936 RID: 6454
	public GameObject labels;

	// Token: 0x04001937 RID: 6455
	private FadeGroup fadeGroup;

	// Token: 0x04001938 RID: 6456
	private tk2dSpriteAnimator anim;

	// Token: 0x04001939 RID: 6457
	private GameObject owner;

	// Token: 0x0400193A RID: 6458
	private bool isVisible;
}
