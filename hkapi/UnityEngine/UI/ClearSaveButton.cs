using System;
using System.Collections;
using UnityEngine.EventSystems;

namespace UnityEngine.UI
{
	// Token: 0x02000683 RID: 1667
	public class ClearSaveButton : MenuButton, ISubmitHandler, IEventSystemHandler, IPointerClickHandler, ISelectHandler
	{
		// Token: 0x06002786 RID: 10118 RVA: 0x000DF2F7 File Offset: 0x000DD4F7
		public new void OnSubmit(BaseEventData eventData)
		{
			base.ForceDeselect();
			this.saveSlotButton.ClearSavePrompt();
		}

		// Token: 0x06002787 RID: 10119 RVA: 0x000DF30A File Offset: 0x000DD50A
		public new void OnPointerClick(PointerEventData eventData)
		{
			this.OnSubmit(eventData);
		}

		// Token: 0x06002788 RID: 10120 RVA: 0x000DF314 File Offset: 0x000DD514
		public new void OnSelect(BaseEventData eventData)
		{
			base.OnSelect(eventData);
			if (!base.GetComponent<CanvasGroup>().interactable)
			{
				base.StartCoroutine(this.SelectAfterFrame(base.navigation.selectOnLeft.gameObject));
			}
		}

		// Token: 0x06002789 RID: 10121 RVA: 0x000DF355 File Offset: 0x000DD555
		private IEnumerator SelectAfterFrame(GameObject gameObject)
		{
			yield return new WaitForEndOfFrame();
			EventSystem.current.SetSelectedGameObject(gameObject);
			yield break;
		}

		// Token: 0x04002CC0 RID: 11456
		public SaveSlotButton saveSlotButton;
	}
}
