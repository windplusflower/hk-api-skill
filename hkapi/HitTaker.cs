using System;
using UnityEngine;

// Token: 0x0200002B RID: 43
public static class HitTaker
{
	// Token: 0x0600010D RID: 269 RVA: 0x000064B8 File Offset: 0x000046B8
	public static void Hit(GameObject targetGameObject, HitInstance damageInstance, int recursionDepth = 3)
	{
		if (targetGameObject != null)
		{
			Transform transform = targetGameObject.transform;
			for (int i = 0; i < recursionDepth; i++)
			{
				IHitResponder component = transform.GetComponent<IHitResponder>();
				if (component != null)
				{
					component.Hit(damageInstance);
				}
				transform = transform.parent;
				if (transform == null)
				{
					break;
				}
			}
		}
	}

	// Token: 0x040000BC RID: 188
	private const int DefaultRecursionDepth = 3;
}
