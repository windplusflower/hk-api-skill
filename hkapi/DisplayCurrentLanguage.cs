using System;
using Language;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x020002C9 RID: 713
public class DisplayCurrentLanguage : MonoBehaviour
{
	// Token: 0x06000F03 RID: 3843 RVA: 0x00049EF8 File Offset: 0x000480F8
	private void Awake()
	{
		if (!this.textObject)
		{
			this.textObject = base.GetComponent<Text>();
		}
	}

	// Token: 0x06000F04 RID: 3844 RVA: 0x00049F14 File Offset: 0x00048114
	private void OnEnable()
	{
		if (this.textObject)
		{
			string str = Language.CurrentLanguage().ToString();
			string arg = Language.Get("LANG_" + str, "MainMenu");
			this.textObject.text = string.Format(this.replaceText, arg);
		}
	}

	// Token: 0x06000F05 RID: 3845 RVA: 0x00049F6F File Offset: 0x0004816F
	public DisplayCurrentLanguage()
	{
		this.replaceText = "({0})";
		base..ctor();
	}

	// Token: 0x04000FC5 RID: 4037
	public Text textObject;

	// Token: 0x04000FC6 RID: 4038
	public string replaceText;
}
