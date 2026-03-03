using System;
using HKMenu;
using Language;
using UnityEngine.EventSystems;

namespace UnityEngine.UI
{
	// Token: 0x0200068C RID: 1676
	public class MenuFrameCapSetting : MenuOptionHorizontal, IMoveHandler, IEventSystemHandler, IMenuOptionListSetting, IPointerClickHandler
	{
		// Token: 0x060027B8 RID: 10168 RVA: 0x000DF9DD File Offset: 0x000DDBDD
		public new void OnEnable()
		{
			this.RefreshControls();
		}

		// Token: 0x060027B9 RID: 10169 RVA: 0x000DF9E5 File Offset: 0x000DDBE5
		public new void OnMove(AxisEventData move)
		{
			if (base.MoveOption(move.moveDir))
			{
				this.UpdateFrameCapSetting();
				return;
			}
			base.OnMove(move);
		}

		// Token: 0x060027BA RID: 10170 RVA: 0x000DFA03 File Offset: 0x000DDC03
		public new void OnPointerClick(PointerEventData eventData)
		{
			base.PointerClickCheckArrows(eventData);
			this.UpdateFrameCapSetting();
		}

		// Token: 0x060027BB RID: 10171 RVA: 0x000DFA14 File Offset: 0x000DDC14
		public void RefreshControls()
		{
			this.RefreshCurrentIndex();
			this.PushUpdateOptionList();
			if (this.selectedOptionIndex == 0)
			{
				this.optionText.text = Language.Get("MOH_OFF", "MainMenu");
				this.textAligner.AlignText();
				return;
			}
			this.UpdateText();
		}

		// Token: 0x060027BC RID: 10172 RVA: 0x000DFA61 File Offset: 0x000DDC61
		public void DisableFrameCapSetting()
		{
			this.SetOptionTo(0);
			this.UpdateFrameCapSetting();
		}

		// Token: 0x060027BD RID: 10173 RVA: 0x000DFA70 File Offset: 0x000DDC70
		public void ApplyValueFromGameSettings()
		{
			Application.targetFrameRate = GameManager.instance.gameSettings.targetFrameRate;
			this.RefreshControls();
		}

		// Token: 0x060027BE RID: 10174 RVA: 0x000DFA8C File Offset: 0x000DDC8C
		private void UpdateFrameCapSetting()
		{
			if (this.selectedOptionIndex == 0)
			{
				this.optionText.text = Language.Get("MOH_OFF", "MainMenu");
				this.textAligner.AlignText();
			}
			else
			{
				UIManager.instance.DisableVsyncSetting();
			}
			GameManager.instance.gameSettings.targetFrameRate = this.frameCapValues[this.selectedOptionIndex];
			Application.targetFrameRate = this.frameCapValues[this.selectedOptionIndex];
		}

		// Token: 0x060027BF RID: 10175 RVA: 0x000DFB00 File Offset: 0x000DDD00
		public void RefreshCurrentIndex()
		{
			bool flag = false;
			for (int i = 0; i < this.frameCapValues.Length; i++)
			{
				if (Application.targetFrameRate == this.frameCapValues[i])
				{
					this.selectedOptionIndex = i;
					flag = true;
				}
			}
			if (!flag)
			{
				Debug.LogError("Couldn't match current Target Frame Rate setting - " + Application.targetFrameRate.ToString());
			}
		}

		// Token: 0x060027C0 RID: 10176 RVA: 0x000DFB5C File Offset: 0x000DDD5C
		public void PushUpdateOptionList()
		{
			string[] array = new string[this.frameCapValues.Length];
			for (int i = 0; i < this.frameCapValues.Length; i++)
			{
				array[i] = this.frameCapValues[i].ToString();
			}
			base.SetOptionList(array);
		}

		// Token: 0x060027C1 RID: 10177 RVA: 0x000DFBA5 File Offset: 0x000DDDA5
		public MenuFrameCapSetting()
		{
			this.frameCapValues = new int[]
			{
				-1,
				30,
				50,
				60,
				72,
				100,
				120,
				144
			};
			this.tfrOff = -1;
			base..ctor();
		}

		// Token: 0x04002CE2 RID: 11490
		private int[] frameCapValues;

		// Token: 0x04002CE3 RID: 11491
		private int tfrOff;

		// Token: 0x04002CE4 RID: 11492
		private GameSettings gs;

		// Token: 0x04002CE5 RID: 11493
		public FixVerticalAlign textAligner;
	}
}
