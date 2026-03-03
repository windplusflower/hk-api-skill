using System;
using System.Collections;
using HKMenu;
using UnityEngine.EventSystems;

namespace UnityEngine.UI
{
	// Token: 0x0200068A RID: 1674
	public class MenuDisplaySetting : MenuOptionHorizontal, IMoveHandler, IEventSystemHandler, IMenuOptionListSetting, IPointerClickHandler
	{
		// Token: 0x060027A8 RID: 10152 RVA: 0x000DF7D0 File Offset: 0x000DD9D0
		public new void OnEnable()
		{
			this.RefreshControls();
		}

		// Token: 0x060027A9 RID: 10153 RVA: 0x000DF7D8 File Offset: 0x000DD9D8
		public new void OnMove(AxisEventData move)
		{
			if (base.MoveOption(move.moveDir))
			{
				this.UpdateMonitorSetting();
				return;
			}
			base.OnMove(move);
		}

		// Token: 0x060027AA RID: 10154 RVA: 0x000DF7F6 File Offset: 0x000DD9F6
		public new void OnPointerClick(PointerEventData eventData)
		{
			base.PointerClickCheckArrows(eventData);
			this.UpdateMonitorSetting();
		}

		// Token: 0x060027AB RID: 10155 RVA: 0x000DF805 File Offset: 0x000DDA05
		public void RefreshControls()
		{
			this.RefreshCurrentIndex();
			this.PushUpdateOptionList();
			this.UpdateText();
		}

		// Token: 0x060027AC RID: 10156 RVA: 0x000DF819 File Offset: 0x000DDA19
		public void DisableMonitorSelectSetting()
		{
			this.SetOptionTo(0);
			this.UpdateMonitorSetting();
		}

		// Token: 0x060027AD RID: 10157 RVA: 0x000DF828 File Offset: 0x000DDA28
		private void UpdateMonitorSetting()
		{
			Debug.Log("UpdateMonitorSetting...");
			base.StartCoroutine(this.TargetDisplayHack(this.selectedOptionIndex));
		}

		// Token: 0x060027AE RID: 10158 RVA: 0x000DF848 File Offset: 0x000DDA48
		public void RefreshCurrentIndex()
		{
			this.availableDisplays = Display.displays;
			if (this.verboseMode)
			{
				Debug.LogFormat("Monitor Select: There are {0} displays available.", new object[]
				{
					this.availableDisplays.Length
				});
			}
			bool flag = false;
			for (int i = 0; i < this.availableDisplays.Length; i++)
			{
				if (Display.main == this.availableDisplays[i])
				{
					this.selectedOptionIndex = i;
					flag = true;
				}
			}
			if (!flag)
			{
				Debug.LogError("Could not find currently active display");
			}
		}

		// Token: 0x060027AF RID: 10159 RVA: 0x000DF8C4 File Offset: 0x000DDAC4
		public void PushUpdateOptionList()
		{
			string[] array = new string[this.availableDisplays.Length];
			for (int i = 0; i < this.availableDisplays.Length; i++)
			{
				array[i] = (i + 1).ToString();
			}
			base.SetOptionList(array);
		}

		// Token: 0x060027B0 RID: 10160 RVA: 0x000DF907 File Offset: 0x000DDB07
		private IEnumerator TargetDisplayHack(int targetDisplay)
		{
			this.dontMove = true;
			int screenWidth = Screen.width;
			int screenHeight = Screen.height;
			PlayerPrefs.SetInt("UnitySelectMonitor", targetDisplay);
			Screen.SetResolution(800, 600, Screen.fullScreen);
			yield return null;
			Screen.SetResolution(screenWidth, screenHeight, Screen.fullScreen);
			this.dontMove = false;
			yield break;
		}

		// Token: 0x04002CD9 RID: 11481
		private bool verboseMode;

		// Token: 0x04002CDA RID: 11482
		private Display[] availableDisplays;

		// Token: 0x04002CDB RID: 11483
		private bool dontMove;
	}
}
