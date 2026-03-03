using System;
using UnityEngine;

// Token: 0x020004D1 RID: 1233
public static class Collision2DUtils
{
	// Token: 0x06001B57 RID: 6999 RVA: 0x00083250 File Offset: 0x00081450
	public static Collision2DUtils.Collision2DSafeContact GetSafeContact(this Collision2D collision)
	{
		if (collision.GetContacts(Collision2DUtils.contactsBuffer) >= 1)
		{
			ContactPoint2D contactPoint2D = Collision2DUtils.contactsBuffer[0];
			return new Collision2DUtils.Collision2DSafeContact
			{
				Point = contactPoint2D.point,
				Normal = contactPoint2D.normal,
				IsLegitimate = true
			};
		}
		Vector2 b = collision.collider.transform.TransformPoint(collision.collider.offset);
		Vector2 a = collision.otherCollider.transform.TransformPoint(collision.otherCollider.offset);
		return new Collision2DUtils.Collision2DSafeContact
		{
			Point = (a + b) * 0.5f,
			Normal = (a - b).normalized,
			IsLegitimate = false
		};
	}

	// Token: 0x06001B58 RID: 7000 RVA: 0x00083331 File Offset: 0x00081531
	// Note: this type is marked as 'beforefieldinit'.
	static Collision2DUtils()
	{
		Collision2DUtils.contactsBuffer = new ContactPoint2D[1];
	}

	// Token: 0x040020CF RID: 8399
	private static ContactPoint2D[] contactsBuffer;

	// Token: 0x020004D2 RID: 1234
	public struct Collision2DSafeContact
	{
		// Token: 0x040020D0 RID: 8400
		public Vector2 Point;

		// Token: 0x040020D1 RID: 8401
		public Vector2 Normal;

		// Token: 0x040020D2 RID: 8402
		public bool IsLegitimate;
	}
}
