using System;
using UnityEngine;

// Token: 0x02000453 RID: 1107
public class EngagementPromptPanel : MonoBehaviour
{
	// Token: 0x060018DB RID: 6363 RVA: 0x00074351 File Offset: 0x00072551
	protected void Start()
	{
		this.lastEngagementState = Platform.Current.EngagementState;
		this.UpdateContent();
	}

	// Token: 0x060018DC RID: 6364 RVA: 0x00074369 File Offset: 0x00072569
	protected void Update()
	{
		this.UpdateContent();
	}

	// Token: 0x060018DD RID: 6365 RVA: 0x00074374 File Offset: 0x00072574
	private void UpdateContent()
	{
		Platform.EngagementStates engagementState = Platform.Current.EngagementState;
		float target = (engagementState == Platform.EngagementStates.NotEngaged) ? 1f : 0f;
		this.canvasGroup.alpha = Mathf.MoveTowards(this.canvasGroup.alpha, target, Time.unscaledDeltaTime * this.fadeRate);
		if (this.lastEngagementState != engagementState)
		{
			if (this.lastEngagementState == Platform.EngagementStates.NotEngaged)
			{
				UIManager.instance.uiAudioPlayer.PlaySubmit();
				this.flashAnimator.SetTrigger("Flash");
			}
			else if (engagementState == Platform.EngagementStates.NotEngaged)
			{
				UIManager.instance.uiAudioPlayer.PlayCancel();
			}
			this.lastEngagementState = engagementState;
		}
	}

	// Token: 0x04001DC9 RID: 7625
	[SerializeField]
	private CanvasGroup canvasGroup;

	// Token: 0x04001DCA RID: 7626
	[SerializeField]
	private Animator flashAnimator;

	// Token: 0x04001DCB RID: 7627
	[SerializeField]
	private float fadeRate;

	// Token: 0x04001DCC RID: 7628
	private Platform.EngagementStates lastEngagementState;
}
