using System;
using UnityEngine;

// Token: 0x020004CB RID: 1227
public class VisibilityControl : MonoBehaviour
{
	// Token: 0x06001B45 RID: 6981 RVA: 0x000830DB File Offset: 0x000812DB
	private void Awake()
	{
		this.myAnimator = base.GetComponent<Animator>();
		if (this.myAnimator == null)
		{
			Debug.Log("VisibilityControl: This UI object does not have an animator component attached. Attach an animator or remove the VisibilityControl component.");
		}
	}

	// Token: 0x06001B46 RID: 6982 RVA: 0x00083101 File Offset: 0x00081301
	public void Reveal()
	{
		if (this.controlType == VisibilityControl.ControlType.SHOW_AND_HIDE)
		{
			this.myAnimator.ResetTrigger("hide");
			this.myAnimator.SetTrigger("show");
		}
	}

	// Token: 0x06001B47 RID: 6983 RVA: 0x0008312B File Offset: 0x0008132B
	public void Hide()
	{
		this.myAnimator.ResetTrigger("show");
		this.myAnimator.SetTrigger("hide");
	}

	// Token: 0x040020C0 RID: 8384
	private Animator myAnimator;

	// Token: 0x040020C1 RID: 8385
	public VisibilityControl.ControlType controlType;

	// Token: 0x020004CC RID: 1228
	public enum ControlType
	{
		// Token: 0x040020C3 RID: 8387
		SHOW_AND_HIDE,
		// Token: 0x040020C4 RID: 8388
		HIDE_ONLY
	}
}
