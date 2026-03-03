using System;
using UnityEngine;

// Token: 0x020003E9 RID: 1001
public class SlopePlat : MonoBehaviour
{
	// Token: 0x060016CF RID: 5839 RVA: 0x0006C008 File Offset: 0x0006A208
	private void Start()
	{
		this.hero = GameObject.FindWithTag("Player");
	}

	// Token: 0x060016D0 RID: 5840 RVA: 0x0006C01C File Offset: 0x0006A21C
	private void Update()
	{
		float x = this.hero.transform.position.x;
		if (x <= this.heroXLeft)
		{
			base.transform.localPosition = new Vector3(base.transform.localPosition.x, this.platYLeft, base.transform.localPosition.z);
			return;
		}
		if (x >= this.heroXRight)
		{
			base.transform.localPosition = new Vector3(base.transform.localPosition.x, this.platYRight, base.transform.localPosition.z);
			return;
		}
		float t = Mathf.InverseLerp(this.heroXLeft, this.heroXRight, x);
		base.transform.localPosition = new Vector3(base.transform.localPosition.x, Mathf.Lerp(this.platYLeft, this.platYRight, t), base.transform.localPosition.z);
	}

	// Token: 0x04001B7C RID: 7036
	public float heroXLeft;

	// Token: 0x04001B7D RID: 7037
	public float heroXRight;

	// Token: 0x04001B7E RID: 7038
	public float platYLeft;

	// Token: 0x04001B7F RID: 7039
	public float platYRight;

	// Token: 0x04001B80 RID: 7040
	private GameObject hero;
}
