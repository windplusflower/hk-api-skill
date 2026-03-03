using System;
using System.Collections;
using UnityEngine;

// Token: 0x02000013 RID: 19
public class Bullet : MonoBehaviour
{
	// Token: 0x0600005D RID: 93 RVA: 0x00003B6E File Offset: 0x00001D6E
	private void OnEnable()
	{
		base.StartCoroutine(this.Shoot());
	}

	// Token: 0x0600005E RID: 94 RVA: 0x00003B7D File Offset: 0x00001D7D
	private void OnDisable()
	{
		base.StopAllCoroutines();
	}

	// Token: 0x0600005F RID: 95 RVA: 0x00003B85 File Offset: 0x00001D85
	private IEnumerator Shoot()
	{
		float travelledDistance = 0f;
		while (travelledDistance < this.shootDistance)
		{
			travelledDistance += this.shootSpeed * Time.deltaTime;
			this.transform.position += this.transform.forward * (this.shootSpeed * Time.deltaTime);
			yield return 0;
		}
		this.explosionPrefab.Spawn(this.transform.position);
		this.gameObject.Recycle();
		yield break;
	}

	// Token: 0x04000050 RID: 80
	public Explosion explosionPrefab;

	// Token: 0x04000051 RID: 81
	public float shootDistance;

	// Token: 0x04000052 RID: 82
	public float shootSpeed;
}
