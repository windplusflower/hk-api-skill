using System;
using GlobalEnums;
using UnityEngine.EventSystems;

namespace UnityEngine.UI
{
	// Token: 0x02000699 RID: 1689
	public class PauseMenuButton : MenuSelectable, ISubmitHandler, IEventSystemHandler, IPointerClickHandler, ICancelHandler
	{
		// Token: 0x17000575 RID: 1397
		// (get) Token: 0x06002834 RID: 10292 RVA: 0x000E155E File Offset: 0x000DF75E
		// (set) Token: 0x06002835 RID: 10293 RVA: 0x000E1566 File Offset: 0x000DF766
		public new CancelAction cancelAction { get; private set; }

		// Token: 0x06002836 RID: 10294 RVA: 0x000E156F File Offset: 0x000DF76F
		private new void Start()
		{
			this.gm = GameManager.instance;
			this.ih = this.gm.inputHandler;
			this.ui = UIManager.instance;
			base.HookUpAudioPlayer();
		}

		// Token: 0x06002837 RID: 10295 RVA: 0x000E15A0 File Offset: 0x000DF7A0
		public void OnSubmit(BaseEventData eventData)
		{
			if (this.pauseButtonType == PauseMenuButton.PauseButtonType.Continue)
			{
				if (this.ih.pauseAllowed)
				{
					this.ui.TogglePauseGame();
					this.flashEffect.ResetTrigger("Flash");
					this.flashEffect.SetTrigger("Flash");
					base.ForceDeselect();
					base.PlaySubmitSound();
					return;
				}
			}
			else
			{
				if (this.pauseButtonType == PauseMenuButton.PauseButtonType.Options)
				{
					this.ui.UIGoToOptionsMenu();
					this.flashEffect.ResetTrigger("Flash");
					this.flashEffect.SetTrigger("Flash");
					base.ForceDeselect();
					base.PlaySubmitSound();
					return;
				}
				if (this.pauseButtonType == PauseMenuButton.PauseButtonType.Quit)
				{
					this.ui.UIShowReturnMenuPrompt();
					this.flashEffect.ResetTrigger("Flash");
					this.flashEffect.SetTrigger("Flash");
					base.ForceDeselect();
					base.PlaySubmitSound();
				}
			}
		}

		// Token: 0x06002838 RID: 10296 RVA: 0x000E1680 File Offset: 0x000DF880
		public new void OnCancel(BaseEventData eventData)
		{
			if (this.ih.pauseAllowed)
			{
				this.ui.TogglePauseGame();
				this.flashEffect.ResetTrigger("Flash");
				this.flashEffect.SetTrigger("Flash");
				base.ForceDeselect();
				base.PlaySubmitSound();
			}
		}

		// Token: 0x06002839 RID: 10297 RVA: 0x000E16D1 File Offset: 0x000DF8D1
		public void OnPointerClick(PointerEventData eventData)
		{
			this.OnSubmit(eventData);
		}

		// Token: 0x04002D25 RID: 11557
		public Animator flashEffect;

		// Token: 0x04002D26 RID: 11558
		private GameManager gm;

		// Token: 0x04002D27 RID: 11559
		private UIManager ui;

		// Token: 0x04002D28 RID: 11560
		private InputHandler ih;

		// Token: 0x04002D2A RID: 11562
		public PauseMenuButton.PauseButtonType pauseButtonType;

		// Token: 0x0200069A RID: 1690
		public enum PauseButtonType
		{
			// Token: 0x04002D2C RID: 11564
			Continue,
			// Token: 0x04002D2D RID: 11565
			Options,
			// Token: 0x04002D2E RID: 11566
			Quit
		}
	}
}
