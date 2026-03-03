using System;
using UnityEngine;

// Token: 0x020001C2 RID: 450
public class LineOfSightDetector : MonoBehaviour
{
	// Token: 0x1700010B RID: 267
	// (get) Token: 0x060009F2 RID: 2546 RVA: 0x00037155 File Offset: 0x00035355
	public bool CanSeeHero
	{
		get
		{
			return this.canSeeHero;
		}
	}

	// Token: 0x060009F3 RID: 2547 RVA: 0x00003603 File Offset: 0x00001803
	protected void Awake()
	{
	}

	// Token: 0x060009F4 RID: 2548 RVA: 0x00037160 File Offset: 0x00035360
	protected void Update()
	{
		bool flag = false;
		for (int i = 0; i < this.alertRanges.Length; i++)
		{
			AlertRange alertRange = this.alertRanges[i];
			if (!(alertRange == null) && alertRange.IsHeroInRange)
			{
				flag = true;
			}
		}
		if (this.alertRanges.Length != 0 && !flag)
		{
			this.canSeeHero = false;
			return;
		}
		HeroController instance = HeroController.instance;
		if (instance == null)
		{
			this.canSeeHero = false;
			return;
		}
		Vector2 vector = base.transform.position;
		Vector2 vector2 = instance.transform.position;
		Vector2 vector3 = vector2 - vector;
		if (Physics2D.Raycast(vector, vector3.normalized, vector3.magnitude, 256))
		{
			this.canSeeHero = false;
		}
		else
		{
			this.canSeeHero = true;
		}
		Debug.DrawLine(vector, vector2, this.canSeeHero ? Color.green : Color.yellow);
	}

	// Token: 0x04000B17 RID: 2839
	[SerializeField]
	private AlertRange[] alertRanges;

	// Token: 0x04000B18 RID: 2840
	private bool canSeeHero;
}
