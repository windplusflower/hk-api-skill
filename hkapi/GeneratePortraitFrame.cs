using System;
using UnityEngine;

// Token: 0x0200000A RID: 10
public class GeneratePortraitFrame : MonoBehaviour
{
	// Token: 0x06000034 RID: 52 RVA: 0x000031F8 File Offset: 0x000013F8
	private void Start()
	{
		GameObject gameObject = base.transform.parent.gameObject;
		GameObject gameObject2 = UnityEngine.Object.Instantiate<GameObject>(this.frameObject);
		gameObject2.transform.parent = gameObject.transform;
		gameObject2.transform.localPosition = new Vector3(base.transform.localPosition.x, base.transform.localPosition.y, base.transform.localPosition.z - 0.0001f);
		gameObject2.transform.localScale = new Vector3(1f, 1f, 1f);
		gameObject2.SetActive(false);
	}

	// Token: 0x04000024 RID: 36
	public GameObject frameObject;
}
