using System;
using UnityEngine;

// Token: 0x0200009D RID: 157
[ExecuteInEditMode]
public class HazardRespawnMarker : MonoBehaviour
{
	// Token: 0x06000367 RID: 871 RVA: 0x000123D4 File Offset: 0x000105D4
	private void Awake()
	{
		if (base.transform.parent != null && base.transform.parent.name.Contains("top"))
		{
			this.groundSenseDistance = 50f;
		}
		this.heroSpawnLocation = Physics2D.Raycast(base.transform.position, this.groundSenseRay, this.groundSenseDistance, 256).point;
	}

	// Token: 0x06000368 RID: 872 RVA: 0x00012450 File Offset: 0x00010650
	private void Update()
	{
		if (this.drawDebugRays)
		{
			Debug.DrawRay(base.transform.position, this.groundSenseRay * this.groundSenseDistance, Color.green);
			Debug.DrawRay(this.heroSpawnLocation - Vector2.right / 2f, Vector2.right, Color.green);
		}
	}

	// Token: 0x06000369 RID: 873 RVA: 0x000124C3 File Offset: 0x000106C3
	public HazardRespawnMarker()
	{
		this.groundSenseDistance = 3f;
		this.groundSenseRay = -Vector2.up;
		base..ctor();
	}

	// Token: 0x040002C8 RID: 712
	public bool respawnFacingRight;

	// Token: 0x040002C9 RID: 713
	private float groundSenseDistance;

	// Token: 0x040002CA RID: 714
	private Vector2 groundSenseRay;

	// Token: 0x040002CB RID: 715
	private Vector2 heroSpawnLocation;

	// Token: 0x040002CC RID: 716
	public bool drawDebugRays;
}
