using System;
using UnityEngine.EventSystems;

namespace UnityEngine.UI
{
	// Token: 0x02000688 RID: 1672
	public class MenuButton : MenuSelectable, ISubmitHandler, IEventSystemHandler, IPointerClickHandler
	{
		// Token: 0x0600279F RID: 10143 RVA: 0x000DF694 File Offset: 0x000DD894
		private new void Start()
		{
			base.HookUpAudioPlayer();
		}

		// Token: 0x060027A0 RID: 10144 RVA: 0x000DF69C File Offset: 0x000DD89C
		public void OnSubmit(BaseEventData eventData)
		{
			if (this.buttonType == MenuButton.MenuButtonType.CustomSubmit)
			{
				if (this.flashEffect)
				{
					this.flashEffect.ResetTrigger("Flash");
					this.flashEffect.SetTrigger("Flash");
				}
				if (this.proceed)
				{
					base.ForceDeselect();
				}
				Action<MenuButton> submitAction = this.submitAction;
				if (submitAction != null)
				{
					submitAction(this);
				}
			}
			this.orig_OnSubmit(eventData);
		}

		// Token: 0x060027A1 RID: 10145 RVA: 0x000DF706 File Offset: 0x000DD906
		public void OnPointerClick(PointerEventData eventData)
		{
			this.OnSubmit(eventData);
		}

		// Token: 0x17000566 RID: 1382
		// (get) Token: 0x060027A3 RID: 10147 RVA: 0x000DF717 File Offset: 0x000DD917
		// (set) Token: 0x060027A4 RID: 10148 RVA: 0x000DF71F File Offset: 0x000DD91F
		public Action<MenuButton> submitAction { get; set; }

		// Token: 0x17000567 RID: 1383
		// (get) Token: 0x060027A5 RID: 10149 RVA: 0x000DF728 File Offset: 0x000DD928
		// (set) Token: 0x060027A6 RID: 10150 RVA: 0x000DF730 File Offset: 0x000DD930
		public bool proceed { get; set; }

		// Token: 0x060027A7 RID: 10151 RVA: 0x000DF73C File Offset: 0x000DD93C
		public void orig_OnSubmit(BaseEventData eventData)
		{
			if (this.buttonType == MenuButton.MenuButtonType.Proceed)
			{
				try
				{
					this.flashEffect.ResetTrigger("Flash");
					this.flashEffect.SetTrigger("Flash");
				}
				catch
				{
				}
				base.ForceDeselect();
			}
			else if (this.buttonType == MenuButton.MenuButtonType.Activate)
			{
				try
				{
					this.flashEffect.ResetTrigger("Flash");
					this.flashEffect.SetTrigger("Flash");
				}
				catch
				{
				}
			}
			base.PlaySubmitSound();
		}

		// Token: 0x04002CD1 RID: 11473
		public MenuButton.MenuButtonType buttonType;

		// Token: 0x04002CD2 RID: 11474
		public Animator flashEffect;

		// Token: 0x02000689 RID: 1673
		public enum MenuButtonType
		{
			// Token: 0x04002CD6 RID: 11478
			Proceed,
			// Token: 0x04002CD7 RID: 11479
			Activate,
			// Token: 0x04002CD8 RID: 11480
			CustomSubmit
		}
	}
}
