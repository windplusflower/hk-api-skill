using System;
using UnityEngine;

// Token: 0x02000211 RID: 529
public class GenerateJournalNewDot : MonoBehaviour
{
	// Token: 0x06000B6C RID: 2924 RVA: 0x0003C6B4 File Offset: 0x0003A8B4
	private void Start()
	{
		GameObject gameObject = UnityEngine.Object.Instantiate<GameObject>(this.newDotObject);
		gameObject.transform.parent = base.transform;
		gameObject.transform.localPosition = new Vector3(-0.65f, 0f, -0.0001f);
		gameObject.SetActive(false);
	}

	// Token: 0x04000C61 RID: 3169
	public GameObject newDotObject;
}
