using System;
using System.Text;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x0200041D RID: 1053
public class SetVersionNumber : MonoBehaviour
{
	// Token: 0x060017BE RID: 6078 RVA: 0x000700B7 File Offset: 0x0006E2B7
	private void Awake()
	{
		this.textUi = base.GetComponent<Text>();
	}

	// Token: 0x060017BF RID: 6079 RVA: 0x000700C8 File Offset: 0x0006E2C8
	private void Start()
	{
		if (this.textUi != null)
		{
			StringBuilder stringBuilder = new StringBuilder("1.5.78.11833");
			if (CheatManager.IsCheatsEnabled)
			{
				stringBuilder.Append("\n(CHEATS ENABLED)");
			}
			this.textUi.text = stringBuilder.ToString();
		}
	}

	// Token: 0x04001C89 RID: 7305
	private Text textUi;
}
