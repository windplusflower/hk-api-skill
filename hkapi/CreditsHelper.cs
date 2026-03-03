using System;
using UnityEngine;

// Token: 0x0200006F RID: 111
public class CreditsHelper : MonoBehaviour
{
	// Token: 0x06000253 RID: 595 RVA: 0x0000D8CC File Offset: 0x0000BACC
	private void Start()
	{
		if (this.creditsType == CreditsHelper.CreditsType.MenuCredits)
		{
			base.Invoke("BeginCredits", 0f);
			return;
		}
		base.Invoke("BeginCredits", 4f);
		GameObject gameObject = GameObject.Find("Knight");
		if (gameObject)
		{
			Rigidbody2D component = gameObject.GetComponent<Rigidbody2D>();
			if (component)
			{
				component.gravityScale = 0f;
				component.velocity = Vector2.zero;
			}
		}
	}

	// Token: 0x06000254 RID: 596 RVA: 0x0000D93B File Offset: 0x0000BB3B
	private void BeginCredits()
	{
		this.creditsAnimator.SetTrigger("BeginCredits");
	}

	// Token: 0x06000255 RID: 597 RVA: 0x0000D94D File Offset: 0x0000BB4D
	public void ShouldStopHere()
	{
		if (this.creditsType == CreditsHelper.CreditsType.MenuCredits)
		{
			base.StartCoroutine(this.cutSceneHelper.SkipCutscene());
			return;
		}
		this.creditsAnimator.SetTrigger("ShowThanks");
	}

	// Token: 0x040001E8 RID: 488
	public CreditsHelper.CreditsType creditsType;

	// Token: 0x040001E9 RID: 489
	public Animator creditsAnimator;

	// Token: 0x040001EA RID: 490
	public CutsceneHelper cutSceneHelper;

	// Token: 0x02000070 RID: 112
	public enum CreditsType
	{
		// Token: 0x040001EC RID: 492
		EndCredits,
		// Token: 0x040001ED RID: 493
		MenuCredits
	}
}
