using System;
using System.Collections.Generic;
using UnityEngine.EventSystems;

namespace UnityEngine.UI
{
	// Token: 0x02000698 RID: 1688
	public class MenuStyleSetting : MenuOptionHorizontal, IMoveHandler, IEventSystemHandler, IPointerClickHandler
	{
		// Token: 0x0600282F RID: 10287 RVA: 0x000E142C File Offset: 0x000DF62C
		private new void OnEnable()
		{
			this.styles = MenuStyles.Instance;
			if (this.styles && this.styles.styles.Length != 0)
			{
				List<string> list = new List<string>();
				for (int i = 0; i < this.styles.styles.Length; i++)
				{
					MenuStyles.MenuStyle menuStyle = this.styles.styles[i];
					if (menuStyle.IsAvailable)
					{
						list.Add(menuStyle.displayName);
						this.indexList.Add(i);
					}
				}
				this.optionList = list.ToArray();
				this.selectedOptionIndex = this.indexList.IndexOf(this.styles.CurrentStyle);
				this.UpdateText();
			}
		}

		// Token: 0x06002830 RID: 10288 RVA: 0x000E14DF File Offset: 0x000DF6DF
		public new void OnMove(AxisEventData move)
		{
			if (!base.interactable)
			{
				return;
			}
			if (base.MoveOption(move.moveDir))
			{
				this.UpdateStyle();
				return;
			}
			base.OnMove(move);
		}

		// Token: 0x06002831 RID: 10289 RVA: 0x000E1506 File Offset: 0x000DF706
		public new void OnPointerClick(PointerEventData eventData)
		{
			if (!base.interactable)
			{
				return;
			}
			base.PointerClickCheckArrows(eventData);
			this.UpdateStyle();
		}

		// Token: 0x06002832 RID: 10290 RVA: 0x000E151E File Offset: 0x000DF71E
		private void UpdateStyle()
		{
			if (this.styles)
			{
				this.styles.SetStyle(this.indexList[this.selectedOptionIndex], true, true);
			}
		}

		// Token: 0x06002833 RID: 10291 RVA: 0x000E154B File Offset: 0x000DF74B
		public MenuStyleSetting()
		{
			this.indexList = new List<int>();
			base..ctor();
		}

		// Token: 0x04002D23 RID: 11555
		private MenuStyles styles;

		// Token: 0x04002D24 RID: 11556
		private List<int> indexList;
	}
}
