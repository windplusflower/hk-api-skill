using System;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

// Token: 0x02000494 RID: 1172
public class MenuScreen : MonoBehaviour
{
	// Token: 0x1700032E RID: 814
	// (get) Token: 0x06001A39 RID: 6713 RVA: 0x0007DDE8 File Offset: 0x0007BFE8
	public CanvasGroup screenCanvasGroup
	{
		get
		{
			return base.GetComponent<CanvasGroup>();
		}
	}

	// Token: 0x06001A3A RID: 6714 RVA: 0x0007DDF0 File Offset: 0x0007BFF0
	public void HighlightDefault()
	{
		EventSystem current = EventSystem.current;
		if (this.defaultHighlight != null && current.currentSelectedGameObject == null)
		{
			Selectable firstInteractable = this.defaultHighlight.GetFirstInteractable();
			if (firstInteractable)
			{
				firstInteractable.Select();
				foreach (object obj in this.defaultHighlight.transform)
				{
					Animator component = ((Transform)obj).GetComponent<Animator>();
					if (component != null)
					{
						component.ResetTrigger("hide");
						component.SetTrigger("show");
						break;
					}
				}
			}
		}
	}

	// Token: 0x04001F82 RID: 8066
	public CanvasGroup title;

	// Token: 0x04001F83 RID: 8067
	public Animator topFleur;

	// Token: 0x04001F84 RID: 8068
	public CanvasGroup content;

	// Token: 0x04001F85 RID: 8069
	public CanvasGroup controls;

	// Token: 0x04001F86 RID: 8070
	public Selectable defaultHighlight;

	// Token: 0x04001F87 RID: 8071
	public Animator bottomFleur;
}
