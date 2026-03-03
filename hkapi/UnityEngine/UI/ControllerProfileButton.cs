using System;
using System.Collections;
using UnityEngine.EventSystems;

namespace UnityEngine.UI
{
	// Token: 0x02000685 RID: 1669
	public class ControllerProfileButton : MonoBehaviour, ISelectHandler, IEventSystemHandler, IDeselectHandler, ISubmitHandler, IPointerClickHandler
	{
		// Token: 0x06002791 RID: 10129 RVA: 0x000DF3CC File Offset: 0x000DD5CC
		public void OnSelect(BaseEventData eventData)
		{
			this.leftCursor.ResetTrigger("hide");
			this.rightCursor.ResetTrigger("hide");
			this.leftCursor.SetTrigger("show");
			this.rightCursor.SetTrigger("show");
			if (!this.dontPlaySelectSound)
			{
				this.uiAudioPlayer.PlaySelect();
				return;
			}
			this.dontPlaySelectSound = false;
		}

		// Token: 0x06002792 RID: 10130 RVA: 0x000DF434 File Offset: 0x000DD634
		public void OnDeselect(BaseEventData eventData)
		{
			base.StartCoroutine(this.ValidateDeselect());
		}

		// Token: 0x06002793 RID: 10131 RVA: 0x000DF443 File Offset: 0x000DD643
		public void OnSubmit(BaseEventData eventData)
		{
			this.highlightCursor.gameObject.SetActive(true);
		}

		// Token: 0x06002794 RID: 10132 RVA: 0x000DF456 File Offset: 0x000DD656
		public void OnPointerClick(PointerEventData eventData)
		{
			this.OnSubmit(eventData);
		}

		// Token: 0x06002795 RID: 10133 RVA: 0x000DF45F File Offset: 0x000DD65F
		private IEnumerator ValidateDeselect()
		{
			this.prevSelectedObject = EventSystem.current.currentSelectedGameObject;
			yield return new WaitForEndOfFrame();
			if (EventSystem.current.currentSelectedGameObject != null)
			{
				this.leftCursor.ResetTrigger("show");
				this.rightCursor.ResetTrigger("show");
				this.leftCursor.SetTrigger("hide");
				this.rightCursor.SetTrigger("hide");
			}
			else
			{
				this.dontPlaySelectSound = true;
				EventSystem.current.SetSelectedGameObject(this.prevSelectedObject);
			}
			yield break;
		}

		// Token: 0x04002CC4 RID: 11460
		public Animator leftCursor;

		// Token: 0x04002CC5 RID: 11461
		public Animator rightCursor;

		// Token: 0x04002CC6 RID: 11462
		public Image highlightCursor;

		// Token: 0x04002CC7 RID: 11463
		public MenuAudioController uiAudioPlayer;

		// Token: 0x04002CC8 RID: 11464
		private GameObject prevSelectedObject;

		// Token: 0x04002CC9 RID: 11465
		private bool dontPlaySelectSound;
	}
}
