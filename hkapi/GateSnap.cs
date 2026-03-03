using System;
using UnityEngine;

// Token: 0x02000414 RID: 1044
[ExecuteInEditMode]
public class GateSnap : MonoBehaviour
{
	// Token: 0x0600179C RID: 6044 RVA: 0x0006F888 File Offset: 0x0006DA88
	private void Update()
	{
		Vector2 vector = base.transform.position;
		vector.x = Mathf.Round(vector.x / this.snapX) * this.snapX;
		vector.y = Mathf.Round(vector.y / this.snapY) * this.snapY;
		base.transform.position = vector;
	}

	// Token: 0x0600179D RID: 6045 RVA: 0x0006F8F7 File Offset: 0x0006DAF7
	public GateSnap()
	{
		this.snapX = 0.5f;
		this.snapY = 0.5f;
		base..ctor();
	}

	// Token: 0x04001C5B RID: 7259
	private float snapX;

	// Token: 0x04001C5C RID: 7260
	private float snapY;
}
