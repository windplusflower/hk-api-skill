using System;
using UnityEngine;

// Token: 0x020001B5 RID: 437
public class KeepRotation : MonoBehaviour
{
	// Token: 0x0600099C RID: 2460 RVA: 0x00034E06 File Offset: 0x00033006
	private void Start()
	{
		this.tf = base.GetComponent<Transform>();
		this.rotation = new Vector3(0f, 0f, this.angle);
	}

	// Token: 0x0600099D RID: 2461 RVA: 0x00034E2F File Offset: 0x0003302F
	private void Update()
	{
		if (this.tf != null)
		{
			this.tf.localEulerAngles = this.rotation;
		}
	}

	// Token: 0x04000AB6 RID: 2742
	public float angle;

	// Token: 0x04000AB7 RID: 2743
	private Transform tf;

	// Token: 0x04000AB8 RID: 2744
	private Vector3 rotation;
}
