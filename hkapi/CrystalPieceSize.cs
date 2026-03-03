using System;
using UnityEngine;

// Token: 0x0200012C RID: 300
public class CrystalPieceSize : MonoBehaviour
{
	// Token: 0x060006F5 RID: 1781 RVA: 0x00027FEC File Offset: 0x000261EC
	private void OnEnable()
	{
		base.transform.position = new Vector3(base.transform.position.x, base.transform.position.y, UnityEngine.Random.Range(-0.01f, 0.01f));
		float num;
		if (UnityEngine.Random.Range(0, 100) < 75)
		{
			num = UnityEngine.Random.Range(0.65f, 0.85f);
		}
		else
		{
			num = UnityEngine.Random.Range(0.9f, 1.2f);
		}
		base.transform.localScale = new Vector3(num, num, num);
	}
}
