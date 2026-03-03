using System;
using UnityEngine;

// Token: 0x02000117 RID: 279
public class DeactivateAfterDelay : MonoBehaviour
{
	// Token: 0x06000698 RID: 1688 RVA: 0x00026B6E File Offset: 0x00024D6E
	private void Awake()
	{
		if (this.stayInPlace)
		{
			this.startPos = base.transform.localPosition;
		}
	}

	// Token: 0x06000699 RID: 1689 RVA: 0x00026B89 File Offset: 0x00024D89
	private void OnEnable()
	{
		this.timer = this.time;
		if (this.stayInPlace)
		{
			base.transform.localPosition = this.startPos;
			this.worldPos = base.transform.position;
		}
	}

	// Token: 0x0600069A RID: 1690 RVA: 0x00026BC4 File Offset: 0x00024DC4
	private void Update()
	{
		if (this.timer > 0f)
		{
			this.timer -= Time.deltaTime;
			if (this.stayInPlace)
			{
				base.transform.position = this.worldPos;
				return;
			}
		}
		else
		{
			base.gameObject.SetActive(false);
		}
	}

	// Token: 0x0400072B RID: 1835
	public float time;

	// Token: 0x0400072C RID: 1836
	public bool stayInPlace;

	// Token: 0x0400072D RID: 1837
	private float timer;

	// Token: 0x0400072E RID: 1838
	private Vector3 worldPos;

	// Token: 0x0400072F RID: 1839
	private Vector3 startPos;
}
