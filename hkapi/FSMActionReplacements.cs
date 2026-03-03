using System;
using UnityEngine;

// Token: 0x020003CA RID: 970
public static class FSMActionReplacements
{
	// Token: 0x06001649 RID: 5705 RVA: 0x000698D8 File Offset: 0x00067AD8
	public static void SetMaterialColor(Component me, Color color)
	{
		Renderer component = me.GetComponent<Renderer>();
		if (component != null)
		{
			component.material.color = color;
		}
	}

	// Token: 0x0600164A RID: 5706 RVA: 0x00069901 File Offset: 0x00067B01
	public static FSMActionReplacements.Directions CheckDirectionWithBrokenBehaviour(float angle)
	{
		if (angle < 45f)
		{
			return FSMActionReplacements.Directions.Right;
		}
		if (angle < 135f)
		{
			return FSMActionReplacements.Directions.Up;
		}
		if (angle < 225f)
		{
			return FSMActionReplacements.Directions.Left;
		}
		if (angle < 360f)
		{
			return FSMActionReplacements.Directions.Down;
		}
		return FSMActionReplacements.Directions.Unknown;
	}

	// Token: 0x020003CB RID: 971
	public enum Directions
	{
		// Token: 0x04001AC9 RID: 6857
		Right,
		// Token: 0x04001ACA RID: 6858
		Up,
		// Token: 0x04001ACB RID: 6859
		Left,
		// Token: 0x04001ACC RID: 6860
		Down,
		// Token: 0x04001ACD RID: 6861
		Unknown
	}
}
