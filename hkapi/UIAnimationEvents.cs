using System;
using UnityEngine;

// Token: 0x020004C2 RID: 1218
public class UIAnimationEvents : MonoBehaviour
{
	// Token: 0x06001B00 RID: 6912 RVA: 0x00080D18 File Offset: 0x0007EF18
	public void OnEnable()
	{
		if (!(this.ui == null))
		{
			return;
		}
		GameObject gameObject = GameObject.FindGameObjectWithTag("UIManager");
		if (gameObject != null)
		{
			this.ui = gameObject.GetComponent<UIManager>();
			return;
		}
		Debug.LogError(base.name + " could not find a UI Manager in this scene");
	}

	// Token: 0x06001B01 RID: 6913 RVA: 0x00003603 File Offset: 0x00001803
	public void OnDisable()
	{
	}

	// Token: 0x06001B02 RID: 6914 RVA: 0x00080D6A File Offset: 0x0007EF6A
	private void AnimateIn()
	{
		Debug.Log(base.name + " animate in called.");
		this.animator.ResetTrigger("hide");
		this.animator.SetTrigger("show");
	}

	// Token: 0x06001B03 RID: 6915 RVA: 0x00080DA1 File Offset: 0x0007EFA1
	private void AnimateOut()
	{
		Debug.Log(base.name + " animate out called.");
		this.animator.ResetTrigger("show");
		this.animator.SetTrigger("hide");
	}

	// Token: 0x0400205C RID: 8284
	public Animator animator;

	// Token: 0x0400205D RID: 8285
	private UIManager ui;
}
