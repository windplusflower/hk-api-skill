using System;
using UnityEngine;

// Token: 0x0200002C RID: 44
[Serializable]
public struct HitInstance
{
	// Token: 0x0600010E RID: 270 RVA: 0x00006504 File Offset: 0x00004704
	public float GetActualDirection(Transform target)
	{
		if (this.Source != null && target != null && this.CircleDirection)
		{
			Vector2 vector = target.position - this.Source.transform.position;
			return Mathf.Atan2(vector.y, vector.x) * 57.29578f;
		}
		return this.Direction;
	}

	// Token: 0x040000BD RID: 189
	public GameObject Source;

	// Token: 0x040000BE RID: 190
	public AttackTypes AttackType;

	// Token: 0x040000BF RID: 191
	public bool CircleDirection;

	// Token: 0x040000C0 RID: 192
	public int DamageDealt;

	// Token: 0x040000C1 RID: 193
	public float Direction;

	// Token: 0x040000C2 RID: 194
	public bool IgnoreInvulnerable;

	// Token: 0x040000C3 RID: 195
	public float MagnitudeMultiplier;

	// Token: 0x040000C4 RID: 196
	public float MoveAngle;

	// Token: 0x040000C5 RID: 197
	public bool MoveDirection;

	// Token: 0x040000C6 RID: 198
	public float Multiplier;

	// Token: 0x040000C7 RID: 199
	public SpecialTypes SpecialType;

	// Token: 0x040000C8 RID: 200
	public bool IsExtraDamage;
}
