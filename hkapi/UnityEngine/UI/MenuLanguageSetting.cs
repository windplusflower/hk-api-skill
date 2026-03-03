using System;
using GlobalEnums;
using HKMenu;
using Language;
using UnityEngine.EventSystems;

namespace UnityEngine.UI
{
	// Token: 0x0200068D RID: 1677
	public class MenuLanguageSetting : MenuOptionHorizontal, IMoveHandler, IEventSystemHandler, IMenuOptionListSetting, IPointerClickHandler
	{
		// Token: 0x060027C2 RID: 10178 RVA: 0x000DFBCB File Offset: 0x000DDDCB
		private new void OnEnable()
		{
			this.RefreshControls();
			this.UpdateAlpha();
		}

		// Token: 0x060027C3 RID: 10179 RVA: 0x000DFBDC File Offset: 0x000DDDDC
		public void UpdateAlpha()
		{
			CanvasGroup component = base.GetComponent<CanvasGroup>();
			if (component)
			{
				if (!base.interactable)
				{
					component.alpha = 0.5f;
					return;
				}
				component.alpha = 1f;
			}
		}

		// Token: 0x060027C4 RID: 10180 RVA: 0x000DFC17 File Offset: 0x000DDE17
		public new void OnMove(AxisEventData move)
		{
			if (!base.interactable)
			{
				return;
			}
			if (base.MoveOption(move.moveDir))
			{
				this.UpdateLanguageSetting();
				return;
			}
			base.OnMove(move);
		}

		// Token: 0x060027C5 RID: 10181 RVA: 0x000DFC3E File Offset: 0x000DDE3E
		public new void OnPointerClick(PointerEventData eventData)
		{
			if (!base.interactable)
			{
				return;
			}
			base.PointerClickCheckArrows(eventData);
			this.UpdateLanguageSetting();
		}

		// Token: 0x060027C6 RID: 10182 RVA: 0x000DFC58 File Offset: 0x000DDE58
		public static Rect RectTransformToScreenSpace(RectTransform transform)
		{
			Vector2 vector = Vector2.Scale(transform.rect.size, transform.lossyScale);
			return new Rect(transform.position.x, (float)Screen.height - transform.position.y, vector.x, vector.y);
		}

		// Token: 0x060027C7 RID: 10183 RVA: 0x000DFCB2 File Offset: 0x000DDEB2
		public void RefreshControls()
		{
			this.RefreshAvailableLanguages();
			this.RefreshCurrentIndex();
			this.PushUpdateOptionList();
			this.UpdateText();
		}

		// Token: 0x060027C8 RID: 10184 RVA: 0x000DFCCC File Offset: 0x000DDECC
		private void UpdateLanguageSetting()
		{
			GameManager.instance.gameSettings.gameLanguage = this.langs[this.selectedOptionIndex];
			Language.SwitchLanguage((LanguageCode)this.langs[this.selectedOptionIndex]);
			this.gm.RefreshLocalization();
			UIManager.instance.RefreshAchievementsList();
			this.UpdateText();
		}

		// Token: 0x060027C9 RID: 10185 RVA: 0x000DFD24 File Offset: 0x000DDF24
		private void RefreshAvailableLanguages()
		{
			if (GameManager.instance.gameConfig.hideLanguageOption)
			{
				this.langs = (Enum.GetValues(typeof(TestingLanguages)) as SupportedLanguages[]);
				return;
			}
			this.langs = (Enum.GetValues(typeof(SupportedLanguages)) as SupportedLanguages[]);
		}

		// Token: 0x060027CA RID: 10186 RVA: 0x000DFD78 File Offset: 0x000DDF78
		public void RefreshCurrentIndex()
		{
			bool flag = false;
			string a = Language.CurrentLanguage().ToString();
			for (int i = 0; i < this.langs.Length; i++)
			{
				if (a == this.langs[i].ToString())
				{
					this.selectedOptionIndex = i;
					flag = true;
				}
			}
			if (!flag)
			{
				Debug.LogError("Couldn't find currently active language");
			}
		}

		// Token: 0x060027CB RID: 10187 RVA: 0x000DFDE4 File Offset: 0x000DDFE4
		public void PushUpdateOptionList()
		{
			string[] array = new string[this.langs.Length];
			for (int i = 0; i < this.langs.Length; i++)
			{
				array[i] = this.langs[i].ToString();
			}
			base.SetOptionList(array);
		}

		// Token: 0x060027CC RID: 10188 RVA: 0x000DFE34 File Offset: 0x000DE034
		protected override void UpdateText()
		{
			if (this.optionList != null && this.optionText != null)
			{
				try
				{
					this.optionText.text = Language.Get("LANG_" + this.optionList[this.selectedOptionIndex].ToString(), this.sheetTitle);
				}
				catch (Exception ex)
				{
					string[] array = new string[7];
					array[0] = this.optionText.text;
					array[1] = " : ";
					int num = 2;
					string[] optionList = this.optionList;
					array[num] = ((optionList != null) ? optionList.ToString() : null);
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

		// Token: 0x04002CE6 RID: 11494
		private SupportedLanguages[] langs;

		// Token: 0x04002CE7 RID: 11495
		private GameSettings gs;

		// Token: 0x04002CE8 RID: 11496
		public FixVerticalAlign textAligner;
	}
}
