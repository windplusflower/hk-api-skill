using System;
using System.Collections;
using UnityEngine;

// Token: 0x02000436 RID: 1078
public class BetaEndPrompt : MonoBehaviour
{
	// Token: 0x0600184B RID: 6219 RVA: 0x000723E4 File Offset: 0x000705E4
	protected void Awake()
	{
		this.audioSource = base.GetComponent<AudioSource>();
	}

	// Token: 0x0600184C RID: 6220 RVA: 0x000723F2 File Offset: 0x000705F2
	protected IEnumerator Start()
	{
		yield return new WaitForSeconds(this.delayDuration);
		this.canEnd = true;
		yield break;
	}

	// Token: 0x0600184D RID: 6221 RVA: 0x00072404 File Offset: 0x00070604
	protected void Update()
	{
		if (this.canEnd && (GameManager.instance.inputHandler.inputActions.menuSubmit.IsPressed || GameManager.instance.inputHandler.inputActions.menuCancel.IsPressed))
		{
			this.canEnd = false;
			base.StartCoroutine(this.BeginEnd());
		}
	}

	// Token: 0x0600184E RID: 6222 RVA: 0x00072463 File Offset: 0x00070663
	protected IEnumerator BeginEnd()
	{
		if (this.audioSource != null)
		{
			this.audioSource.Play();
		}
		this.blackFade.FadeIn();
		yield return new WaitForSeconds(this.blackFade.fadeDuration);
		GameManager.instance.StartCoroutine(GameManager.instance.ReturnToMainMenu(GameManager.ReturnToMainMenuSaveModes.SaveAndContinueOnFail, null));
		yield break;
	}

	// Token: 0x04001D1A RID: 7450
	private AudioSource audioSource;

	// Token: 0x04001D1B RID: 7451
	[SerializeField]
	private float delayDuration;

	// Token: 0x04001D1C RID: 7452
	[SerializeField]
	private SimpleSpriteFade blackFade;

	// Token: 0x04001D1D RID: 7453
	private bool canEnd;
}
