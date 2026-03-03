using System;
using UnityEngine;

// Token: 0x02000143 RID: 323
public class RandomRotationRange : MonoBehaviour
{
	// Token: 0x06000782 RID: 1922 RVA: 0x0002AA9C File Offset: 0x00028C9C
	private void Start()
	{
		this.RandomRotate();
	}

	// Token: 0x06000783 RID: 1923 RVA: 0x0002AA9C File Offset: 0x00028C9C
	private void OnEnable()
	{
		this.RandomRotate();
	}

	// Token: 0x06000784 RID: 1924 RVA: 0x0002AAA4 File Offset: 0x00028CA4
	private void RandomRotate()
	{
		base.transform.localEulerAngles = new Vector3(base.transform.rotation.x, base.transform.rotation.y, UnityEngine.Random.Range(this.min, this.max));
	}

	// Token: 0x04000851 RID: 2129
	public float min;

	// Token: 0x04000852 RID: 2130
	public float max;
}
