using System;
using System.Collections;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x020004A7 RID: 1191
public class ModalDialog : MonoBehaviour
{
	// Token: 0x17000339 RID: 825
	// (get) Token: 0x06001A7D RID: 6781 RVA: 0x0007DDE8 File Offset: 0x0007BFE8
	public CanvasGroup modalWindow
	{
		get
		{
			return base.GetComponent<CanvasGroup>();
		}
	}

	// Token: 0x06001A7E RID: 6782 RVA: 0x0007F208 File Offset: 0x0007D408
	public void HighlightDefault()
	{
		if (this.defaultHighlight != null)
		{
			this.defaultHighlight.Select();
			using (IEnumerator enumerator = this.defaultHighlight.transform.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					object obj = enumerator.Current;
					Animator component = ((Transform)obj).GetComponent<Animator>();
					if (component != null)
					{
						component.ResetTrigger("hide");
						component.SetTrigger("show");
						break;
					}
				}
				return;
			}
		}
		Debug.LogError("No default highlight item defined.");
	}

	// Token: 0x04001FE3 RID: 8163
	public CanvasGroup content;

	// Token: 0x04001FE4 RID: 8164
	public Selectable defaultHighlight;
}
