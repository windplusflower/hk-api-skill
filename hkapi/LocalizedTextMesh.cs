using System;
using Language;
using UnityEngine;

// Token: 0x0200000F RID: 15
[RequireComponent(typeof(TextMesh))]
public class LocalizedTextMesh : MonoBehaviour
{
	// Token: 0x06000048 RID: 72 RVA: 0x000036D2 File Offset: 0x000018D2
	public void Awake()
	{
		this.LocalizeTextMesh(this.keyValue);
	}

	// Token: 0x06000049 RID: 73 RVA: 0x000036E0 File Offset: 0x000018E0
	public void LocalizeTextMesh(string keyValue)
	{
		if (keyValue == null)
		{
			Debug.LogError("Please set the KeyValue that should be used for this TextMesh (" + base.name + ")");
			return;
		}
		base.gameObject.GetComponent<TextMesh>().text = Language.Get(keyValue);
	}

	// Token: 0x04000033 RID: 51
	public string keyValue;
}
