using System;
using TMPro;
using UnityEngine;

// Token: 0x020004B1 RID: 1201
public class ReplaceTextLineBreaks : MonoBehaviour
{
	// Token: 0x06001A9E RID: 6814 RVA: 0x0007F680 File Offset: 0x0007D880
	private void Start()
	{
		this.textMesh = base.GetComponent<TextMeshPro>();
		Debug.Log(this.textMesh.text);
		Debug.Break();
		string text = this.textMesh.text;
		text = text.Replace("<br>", "\n");
		this.textMesh.text = text;
		Debug.Log(text);
		Debug.Log(this.textMesh.text);
	}

	// Token: 0x04001FF5 RID: 8181
	private TextMeshPro textMesh;
}
