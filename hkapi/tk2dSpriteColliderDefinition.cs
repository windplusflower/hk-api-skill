using System;
using UnityEngine;

// Token: 0x02000581 RID: 1409
[Serializable]
public class tk2dSpriteColliderDefinition
{
	// Token: 0x06001F2F RID: 7983 RVA: 0x0009B52F File Offset: 0x0009972F
	public tk2dSpriteColliderDefinition(tk2dSpriteColliderDefinition.Type type, Vector3 origin, float angle)
	{
		this.name = "";
		this.vectors = new Vector3[0];
		this.floats = new float[0];
		base..ctor();
		this.type = type;
		this.origin = origin;
		this.angle = angle;
	}

	// Token: 0x170003FF RID: 1023
	// (get) Token: 0x06001F30 RID: 7984 RVA: 0x0009B56F File Offset: 0x0009976F
	public float Radius
	{
		get
		{
			if (this.type != tk2dSpriteColliderDefinition.Type.Circle)
			{
				return 0f;
			}
			return this.floats[0];
		}
	}

	// Token: 0x17000400 RID: 1024
	// (get) Token: 0x06001F31 RID: 7985 RVA: 0x0009B588 File Offset: 0x00099788
	public Vector3 Size
	{
		get
		{
			if (this.type != tk2dSpriteColliderDefinition.Type.Box)
			{
				return Vector3.zero;
			}
			return this.vectors[0];
		}
	}

	// Token: 0x040024F8 RID: 9464
	public tk2dSpriteColliderDefinition.Type type;

	// Token: 0x040024F9 RID: 9465
	public Vector3 origin;

	// Token: 0x040024FA RID: 9466
	public float angle;

	// Token: 0x040024FB RID: 9467
	public string name;

	// Token: 0x040024FC RID: 9468
	public Vector3[] vectors;

	// Token: 0x040024FD RID: 9469
	public float[] floats;

	// Token: 0x02000582 RID: 1410
	public enum Type
	{
		// Token: 0x040024FF RID: 9471
		Box,
		// Token: 0x04002500 RID: 9472
		Circle
	}
}
