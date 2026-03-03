using System;
using UnityEngine;

// Token: 0x02000090 RID: 144
public class SplashAnimator : MonoBehaviour
{
	// Token: 0x06000300 RID: 768 RVA: 0x0000FE44 File Offset: 0x0000E044
	private void OnEnable()
	{
		float num = UnityEngine.Random.Range(this.scaleMin, this.scaleMax);
		base.transform.localScale = new Vector3(num, num, num);
		if ((float)UnityEngine.Random.Range(0, 100) < 50f)
		{
			base.transform.localScale = new Vector3(-base.transform.localScale.x, base.transform.localScale.y, base.transform.localScale.z);
		}
	}

	// Token: 0x0400027E RID: 638
	public float scaleMin;

	// Token: 0x0400027F RID: 639
	public float scaleMax;
}
