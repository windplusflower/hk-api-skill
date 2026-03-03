using System;
using System.Collections;
using UnityEngine;

// Token: 0x02000441 RID: 1089
public class CinematicSkipPopup : MonoBehaviour
{
	// Token: 0x06001882 RID: 6274 RVA: 0x00073092 File Offset: 0x00071292
	protected void Awake()
	{
		this.canvasGroup = base.GetComponent<CanvasGroup>();
	}

	// Token: 0x06001883 RID: 6275 RVA: 0x000730A0 File Offset: 0x000712A0
	public void Show(CinematicSkipPopup.Texts text)
	{
		base.gameObject.SetActive(true);
		for (int i = 0; i < this.textGroups.Length; i++)
		{
			this.textGroups[i].SetActive(i == (int)text);
		}
		base.StopCoroutine("ShowRoutine");
		base.StartCoroutine("ShowRoutine");
	}

	// Token: 0x06001884 RID: 6276 RVA: 0x000730F4 File Offset: 0x000712F4
	protected IEnumerator ShowRoutine()
	{
		this.isShowing = true;
		yield return new WaitForSecondsRealtime(this.fadeInDuration);
		yield return new WaitForSecondsRealtime(this.holdDuration);
		this.isShowing = false;
		yield break;
	}

	// Token: 0x06001885 RID: 6277 RVA: 0x00073103 File Offset: 0x00071303
	public void Hide()
	{
		base.StopCoroutine("ShowRoutine");
		this.isShowing = false;
	}

	// Token: 0x06001886 RID: 6278 RVA: 0x00073118 File Offset: 0x00071318
	protected void Update()
	{
		if (this.isShowing)
		{
			float alpha = Mathf.MoveTowards(this.canvasGroup.alpha, 1f, Time.unscaledDeltaTime / this.fadeInDuration);
			this.canvasGroup.alpha = alpha;
			return;
		}
		float num = Mathf.MoveTowards(this.canvasGroup.alpha, 0f, Time.unscaledDeltaTime / this.fadeOutDuration);
		this.canvasGroup.alpha = num;
		if (num < Mathf.Epsilon)
		{
			this.Hide();
			base.gameObject.SetActive(false);
		}
	}

	// Token: 0x04001D5E RID: 7518
	private CanvasGroup canvasGroup;

	// Token: 0x04001D5F RID: 7519
	[SerializeField]
	private GameObject[] textGroups;

	// Token: 0x04001D60 RID: 7520
	[SerializeField]
	private float fadeInDuration;

	// Token: 0x04001D61 RID: 7521
	[SerializeField]
	private float holdDuration;

	// Token: 0x04001D62 RID: 7522
	[SerializeField]
	private float fadeOutDuration;

	// Token: 0x04001D63 RID: 7523
	private bool isShowing;

	// Token: 0x04001D64 RID: 7524
	private float showTimer;

	// Token: 0x02000442 RID: 1090
	public enum Texts
	{
		// Token: 0x04001D66 RID: 7526
		Skip,
		// Token: 0x04001D67 RID: 7527
		Loading
	}
}
