using System;
using System.Collections;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

// Token: 0x020004AC RID: 1196
public class PreselectOption : MonoBehaviour
{
	// Token: 0x06001A8C RID: 6796 RVA: 0x0007F4D4 File Offset: 0x0007D6D4
	public void HighlightDefault(bool deselect = false)
	{
		if (EventSystem.current.currentSelectedGameObject == null || deselect)
		{
			if (this.itemToHighlight is MenuSelectable)
			{
				((MenuSelectable)this.itemToHighlight).DontPlaySelectSound = true;
			}
			this.itemToHighlight.Select();
			if (this.itemToHighlight is MenuSelectable)
			{
				((MenuSelectable)this.itemToHighlight).DontPlaySelectSound = false;
			}
			foreach (object obj in this.itemToHighlight.transform)
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

	// Token: 0x06001A8D RID: 6797 RVA: 0x0007F5B0 File Offset: 0x0007D7B0
	public void SetDefaultHighlight(Button button)
	{
		this.itemToHighlight = button;
	}

	// Token: 0x06001A8E RID: 6798 RVA: 0x0007F5B9 File Offset: 0x0007D7B9
	public void DeselectAll()
	{
		base.StartCoroutine(this.ForceDeselect());
	}

	// Token: 0x06001A8F RID: 6799 RVA: 0x0007F5C8 File Offset: 0x0007D7C8
	private IEnumerator ForceDeselect()
	{
		yield return new WaitForSeconds(0.165f);
		UIManager.instance.eventSystem.SetSelectedGameObject(null);
		yield break;
	}

	// Token: 0x04001FF0 RID: 8176
	public Selectable itemToHighlight;
}
