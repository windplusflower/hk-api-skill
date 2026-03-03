using System;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

// Token: 0x0200043D RID: 1085
public class CaptureMouseEvents : UIBehaviour, IPointerEnterHandler, IEventSystemHandler, IPointerExitHandler
{
	// Token: 0x06001872 RID: 6258 RVA: 0x00072C15 File Offset: 0x00070E15
	public void OnPointerEnter(PointerEventData eventData)
	{
		Debug.Log(base.name + "pointer enter");
		if (this.forwardTarget)
		{
			this.forwardTarget.OnPointerEnter(eventData);
		}
	}

	// Token: 0x06001873 RID: 6259 RVA: 0x00072C45 File Offset: 0x00070E45
	public void OnPointerExit(PointerEventData eventData)
	{
		Debug.Log(base.name + "pointer exit");
		if (this.forwardTarget)
		{
			this.forwardTarget.OnPointerExit(eventData);
		}
	}

	// Token: 0x04001D43 RID: 7491
	public Selectable forwardTarget;
}
