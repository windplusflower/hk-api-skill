using System;
using UnityEngine;

// Token: 0x02000142 RID: 322
public class RandomRotation : MonoBehaviour
{
	// Token: 0x0600077E RID: 1918 RVA: 0x0002AA46 File Offset: 0x00028C46
	private void Start()
	{
		this.RandomRotate();
	}

	// Token: 0x0600077F RID: 1919 RVA: 0x0002AA46 File Offset: 0x00028C46
	private void OnEnable()
	{
		this.RandomRotate();
	}

	// Token: 0x06000780 RID: 1920 RVA: 0x0002AA50 File Offset: 0x00028C50
	private void RandomRotate()
	{
		base.transform.localEulerAngles = new Vector3(base.transform.rotation.x, base.transform.rotation.y, UnityEngine.Random.Range(0f, 360f));
	}
}
