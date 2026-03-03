using System;
using System.Collections;
using UnityEngine;

// Token: 0x020003B5 RID: 949
public class Dripper : MonoBehaviour
{
	// Token: 0x060015CD RID: 5581 RVA: 0x00067A32 File Offset: 0x00065C32
	private void OnEnable()
	{
		if (HeroController.instance && this.spatterPrefab)
		{
			this.routine = base.StartCoroutine(this.Behaviour());
		}
	}

	// Token: 0x060015CE RID: 5582 RVA: 0x00067A5F File Offset: 0x00065C5F
	private void OnDisable()
	{
		if (this.routine != null)
		{
			base.StopCoroutine(this.routine);
		}
	}

	// Token: 0x060015CF RID: 5583 RVA: 0x00067A75 File Offset: 0x00065C75
	private IEnumerator Behaviour()
	{
		this.transform.SetParent(HeroController.instance.transform);
		this.transform.localPosition = new Vector3(0f, -0.5f, 0.01f);
		yield return new WaitForSeconds(0.04f);
		WaitForSeconds frequency = new WaitForSeconds(0.025f);
		float elapsed = 0f;
		while (elapsed <= 0.4f)
		{
			yield return frequency;
			elapsed += 0.025f;
			FlingUtils.SpawnAndFling(new FlingUtils.Config
			{
				Prefab = this.spatterPrefab,
				SpeedMin = 0f,
				SpeedMax = 1f,
				AmountMin = 1,
				AmountMax = 1,
				AngleMin = 90f,
				AngleMax = 90f,
				OriginVariationX = 0.5f,
				OriginVariationY = 0.8f
			}, this.transform, Vector3.zero);
		}
		this.routine = null;
		this.gameObject.Recycle();
		yield break;
	}

	// Token: 0x04001A26 RID: 6694
	public GameObject spatterPrefab;

	// Token: 0x04001A27 RID: 6695
	private Coroutine routine;
}
