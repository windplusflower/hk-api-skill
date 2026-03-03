using System;
using GlobalEnums;
using UnityEngine;

// Token: 0x02000487 RID: 1159
[RequireComponent(typeof(SpriteRenderer))]
public class MenuButtonIcon : ActionButtonIconBase
{
	// Token: 0x17000328 RID: 808
	// (get) Token: 0x06001A0D RID: 6669 RVA: 0x0007D6D4 File Offset: 0x0007B8D4
	public override HeroActionButton Action
	{
		get
		{
			Platform.AcceptRejectInputStyles acceptRejectInputStyle = Platform.Current.AcceptRejectInputStyle;
			if (acceptRejectInputStyle != Platform.AcceptRejectInputStyles.NonJapaneseStyle)
			{
				if (acceptRejectInputStyle == Platform.AcceptRejectInputStyles.JapaneseStyle)
				{
					Platform.MenuActions menuActions = this.menuAction;
					if (menuActions == Platform.MenuActions.Submit)
					{
						return HeroActionButton.CAST;
					}
					if (menuActions == Platform.MenuActions.Cancel)
					{
						return HeroActionButton.JUMP;
					}
				}
			}
			else
			{
				Platform.MenuActions menuActions = this.menuAction;
				if (menuActions == Platform.MenuActions.Submit)
				{
					return HeroActionButton.JUMP;
				}
				if (menuActions == Platform.MenuActions.Cancel)
				{
					return HeroActionButton.CAST;
				}
			}
			return HeroActionButton.MENU_CANCEL;
		}
	}

	// Token: 0x04001F6C RID: 8044
	public Platform.MenuActions menuAction;
}
