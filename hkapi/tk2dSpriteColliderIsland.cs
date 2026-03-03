using System;
using UnityEngine;

// Token: 0x02000569 RID: 1385
[Serializable]
public class tk2dSpriteColliderIsland
{
	// Token: 0x06001F0E RID: 7950 RVA: 0x0009A4D8 File Offset: 0x000986D8
	public bool IsValid()
	{
		if (this.connected)
		{
			return this.points.Length >= 3;
		}
		return this.points.Length >= 2;
	}

	// Token: 0x06001F0F RID: 7951 RVA: 0x0009A500 File Offset: 0x00098700
	public void CopyFrom(tk2dSpriteColliderIsland src)
	{
		this.connected = src.connected;
		this.points = new Vector2[src.points.Length];
		for (int i = 0; i < this.points.Length; i++)
		{
			this.points[i] = src.points[i];
		}
	}

	// Token: 0x06001F10 RID: 7952 RVA: 0x0009A558 File Offset: 0x00098758
	public bool CompareTo(tk2dSpriteColliderIsland src)
	{
		if (this.connected != src.connected)
		{
			return false;
		}
		if (this.points.Length != src.points.Length)
		{
			return false;
		}
		for (int i = 0; i < this.points.Length; i++)
		{
			if (this.points[i] != src.points[i])
			{
				return false;
			}
		}
		return true;
	}

	// Token: 0x06001F11 RID: 7953 RVA: 0x0009A5BE File Offset: 0x000987BE
	public tk2dSpriteColliderIsland()
	{
		this.connected = true;
		base..ctor();
	}

	// Token: 0x0400241F RID: 9247
	public bool connected;

	// Token: 0x04002420 RID: 9248
	public Vector2[] points;
}
