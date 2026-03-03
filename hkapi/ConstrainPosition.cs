using System;
using UnityEngine;

// Token: 0x0200015A RID: 346
public class ConstrainPosition : MonoBehaviour
{
	// Token: 0x0600080D RID: 2061 RVA: 0x0002D2EC File Offset: 0x0002B4EC
	private void Update()
	{
		Vector3 position = base.transform.position;
		bool flag = false;
		if (this.constrainX)
		{
			if (position.x < this.xMin)
			{
				position.x = this.xMin;
				flag = true;
			}
			else if (position.x > this.xMax)
			{
				position.x = this.xMax;
				flag = true;
			}
		}
		if (this.constrainY)
		{
			if (position.y < this.yMin)
			{
				position.y = this.yMin;
				flag = true;
			}
			else if (position.y > this.yMax)
			{
				position.y = this.yMax;
				flag = true;
			}
		}
		if (flag)
		{
			base.transform.position = position;
		}
	}

	// Token: 0x040008F0 RID: 2288
	public bool constrainX;

	// Token: 0x040008F1 RID: 2289
	public float xMin;

	// Token: 0x040008F2 RID: 2290
	public float xMax;

	// Token: 0x040008F3 RID: 2291
	public bool constrainY;

	// Token: 0x040008F4 RID: 2292
	public float yMin;

	// Token: 0x040008F5 RID: 2293
	public float yMax;
}
