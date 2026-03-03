using System;
using Language;
using UnityEngine.EventSystems;

namespace UnityEngine.UI
{
	// Token: 0x0200068E RID: 1678
	public class MenuOptionHorizontal : MenuSelectable, IMoveHandler, IEventSystemHandler, IPointerEnterHandler, IPointerClickHandler
	{
		// Token: 0x060027CE RID: 10190 RVA: 0x000DFF20 File Offset: 0x000DE120
		private new void Awake()
		{
			this.gm = GameManager.instance;
		}

		// Token: 0x060027CF RID: 10191 RVA: 0x000DFF2D File Offset: 0x000DE12D
		private new void OnEnable()
		{
			this.gm.RefreshLanguageText += this.UpdateText;
			this.UpdateText();
		}

		// Token: 0x060027D0 RID: 10192 RVA: 0x000DFF4D File Offset: 0x000DE14D
		private new void OnDisable()
		{
			this.gm.RefreshLanguageText -= this.UpdateText;
		}

		// Token: 0x060027D1 RID: 10193 RVA: 0x000DFF67 File Offset: 0x000DE167
		public new void OnMove(AxisEventData move)
		{
			if (!base.interactable)
			{
				return;
			}
			if (!this.MoveOption(move.moveDir))
			{
				base.OnMove(move);
			}
		}

		// Token: 0x060027D2 RID: 10194 RVA: 0x000DFF87 File Offset: 0x000DE187
		public void OnPointerClick(PointerEventData eventData)
		{
			if (!base.interactable)
			{
				return;
			}
			this.PointerClickCheckArrows(eventData);
		}

		// Token: 0x060027D3 RID: 10195 RVA: 0x000DFF99 File Offset: 0x000DE199
		protected bool MoveOption(MoveDirection dir)
		{
			if (dir == MoveDirection.Right)
			{
				this.IncrementOption();
			}
			else
			{
				if (dir != MoveDirection.Left)
				{
					return false;
				}
				this.DecrementOption();
			}
			if (this.uiAudioPlayer)
			{
				this.uiAudioPlayer.PlaySlider();
			}
			return true;
		}

		// Token: 0x060027D4 RID: 10196 RVA: 0x000DFFD0 File Offset: 0x000DE1D0
		protected void PointerClickCheckArrows(PointerEventData eventData)
		{
			if (this.leftCursor && this.IsInside(this.leftCursor.gameObject, eventData))
			{
				this.MoveOption(MoveDirection.Left);
				return;
			}
			if (this.rightCursor && this.IsInside(this.rightCursor.gameObject, eventData))
			{
				this.MoveOption(MoveDirection.Right);
				return;
			}
			this.MoveOption(MoveDirection.Right);
		}

		// Token: 0x060027D5 RID: 10197 RVA: 0x000E003C File Offset: 0x000DE23C
		private bool IsInside(GameObject obj, PointerEventData eventData)
		{
			RectTransform component = obj.GetComponent<RectTransform>();
			return component && RectTransformUtility.RectangleContainsScreenPoint(component, eventData.position, Camera.main);
		}

		// Token: 0x060027D6 RID: 10198 RVA: 0x000E006E File Offset: 0x000DE26E
		public void SetOptionList(string[] optionList)
		{
			this.optionList = optionList;
		}

		// Token: 0x060027D7 RID: 10199 RVA: 0x000E0077 File Offset: 0x000DE277
		public string GetSelectedOptionText()
		{
			if (this.localizeText)
			{
				return Language.Get(this.optionList[this.selectedOptionIndex].ToString(), this.sheetTitle);
			}
			return this.optionList[this.selectedOptionIndex].ToString();
		}

		// Token: 0x060027D8 RID: 10200 RVA: 0x000E00B1 File Offset: 0x000DE2B1
		public string GetSelectedOptionTextRaw()
		{
			return this.optionList[this.selectedOptionIndex].ToString();
		}

		// Token: 0x060027D9 RID: 10201 RVA: 0x000E00C8 File Offset: 0x000DE2C8
		public virtual void SetOptionTo(int optionNumber)
		{
			if (optionNumber >= 0 && optionNumber < this.optionList.Length)
			{
				this.selectedOptionIndex = optionNumber;
				this.UpdateText();
				return;
			}
			Debug.LogErrorFormat("{0} - Trying to select an option outside the list size (index: {1} listsize: {2})", new object[]
			{
				base.name,
				optionNumber,
				this.optionList.Length
			});
		}

		// Token: 0x060027DA RID: 10202 RVA: 0x000E0124 File Offset: 0x000DE324
		protected virtual void UpdateText()
		{
			if (this.optionList != null && this.optionText != null)
			{
				try
				{
					if (this.localizeText)
					{
						this.optionText.text = Language.Get(this.optionList[this.selectedOptionIndex].ToString(), this.sheetTitle);
					}
					else
					{
						this.optionText.text = this.optionList[this.selectedOptionIndex].ToString();
					}
				}
				catch (Exception ex)
				{
					string[] array = new string[7];
					array[0] = this.optionText.text;
					array[1] = " : ";
					int num = 2;
					string[] array2 = this.optionList;
					array[num] = ((array2 != null) ? array2.ToString() : null);
					array[3] = " : ";
					array[4] = this.selectedOptionIndex.ToString();
					array[5] = " ";
					int num2 = 6;
					Exception ex2 = ex;
					array[num2] = ((ex2 != null) ? ex2.ToString() : null);
					Debug.LogError(string.Concat(array));
				}
				this.optionText.GetComponent<FixVerticalAlign>().AlignText();
			}
		}

		// Token: 0x060027DB RID: 10203 RVA: 0x000E022C File Offset: 0x000DE42C
		protected void UpdateSetting()
		{
			if (this.menuSetting)
			{
				this.menuSetting.UpdateSetting(this.selectedOptionIndex);
			}
		}

		// Token: 0x060027DC RID: 10204 RVA: 0x000E024C File Offset: 0x000DE44C
		protected void DecrementOption()
		{
			if (this.selectedOptionIndex > 0)
			{
				this.selectedOptionIndex--;
				if (this.applySettingOn == MenuOptionHorizontal.ApplyOnType.Scroll)
				{
					this.UpdateSetting();
				}
				this.UpdateText();
				return;
			}
			if (this.selectedOptionIndex == 0)
			{
				this.selectedOptionIndex = this.optionList.Length - 1;
				if (this.applySettingOn == MenuOptionHorizontal.ApplyOnType.Scroll)
				{
					this.UpdateSetting();
				}
				this.UpdateText();
			}
		}

		// Token: 0x060027DD RID: 10205 RVA: 0x000E02B4 File Offset: 0x000DE4B4
		protected void IncrementOption()
		{
			if (this.selectedOptionIndex >= 0 && this.selectedOptionIndex < this.optionList.Length - 1)
			{
				this.selectedOptionIndex++;
				if (this.applySettingOn == MenuOptionHorizontal.ApplyOnType.Scroll)
				{
					this.UpdateSetting();
				}
				this.UpdateText();
				return;
			}
			if (this.selectedOptionIndex == this.optionList.Length - 1)
			{
				this.selectedOptionIndex = 0;
				if (this.applySettingOn == MenuOptionHorizontal.ApplyOnType.Scroll)
				{
					this.UpdateSetting();
				}
				this.UpdateText();
			}
		}

		// Token: 0x04002CE9 RID: 11497
		[Header("Option List Settings")]
		public Text optionText;

		// Token: 0x04002CEA RID: 11498
		public string[] optionList;

		// Token: 0x04002CEB RID: 11499
		public int selectedOptionIndex;

		// Token: 0x04002CEC RID: 11500
		public MenuSetting menuSetting;

		// Token: 0x04002CED RID: 11501
		[Header("Interaction")]
		public MenuOptionHorizontal.ApplyOnType applySettingOn;

		// Token: 0x04002CEE RID: 11502
		[Header("Localization")]
		public bool localizeText;

		// Token: 0x04002CEF RID: 11503
		public string sheetTitle;

		// Token: 0x04002CF0 RID: 11504
		protected GameManager gm;

		// Token: 0x0200068F RID: 1679
		public enum ApplyOnType
		{
			// Token: 0x04002CF2 RID: 11506
			Scroll,
			// Token: 0x04002CF3 RID: 11507
			Submit
		}
	}
}
