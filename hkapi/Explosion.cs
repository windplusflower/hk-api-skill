using System;
using System.Collections;
using UnityEngine;

// Token: 0x02000015 RID: 21
public class Explosion : MonoBehaviour
{
	// Token: 0x06000067 RID: 103 RVA: 0x00003C83 File Offset: 0x00001E83
	private void OnEnable()
	{
		base.StartCoroutine(this.Shrink());
	}

	// Token: 0x06000068 RID: 104 RVA: 0x00003C92 File Offset: 0x00001E92
	private IEnumerator Shrink()
	{
		this.transform.localScale = Vector3.one;
		float elapsed = 0f;
		while (elapsed < this.duration)
		{
			float num = 1f - this.animationCurve.Evaluate(elapsed / this.duration);
			this.transform.localScale = new Vector3(num, num, num);
			elapsed += Time.deltaTime;
			yield return 0;
		}
		this.gameObject.Recycle();
		yield break;
	}

	// Token: 0x04000057 RID: 87
	public AnimationCurve animationCurve;

	// Token: 0x04000058 RID: 88
	public float duration;
}
