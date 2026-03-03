using System;
using UnityEngine;

// Token: 0x0200009E RID: 158
public class HazardRespawnTrigger : MonoBehaviour
{
	// Token: 0x0600036A RID: 874 RVA: 0x000124E6 File Offset: 0x000106E6
	private void Awake()
	{
		this.playerData = PlayerData.instance;
		if (this.playerData == null)
		{
			Debug.LogError(base.name + "- Player Data reference is null, please check this is being set correctly.");
		}
	}

	// Token: 0x0600036B RID: 875 RVA: 0x00012510 File Offset: 0x00010710
	private void Start()
	{
		if (this.respawnMarker == null)
		{
			Debug.LogWarning(base.name + " does not have a Hazard Respawn Marker Set");
		}
	}

	// Token: 0x0600036C RID: 876 RVA: 0x00012535 File Offset: 0x00010735
	private void OnTriggerEnter2D(Collider2D otherCollider)
	{
		if (!this.inactive && otherCollider.gameObject.layer == 9)
		{
			this.playerData.SetHazardRespawn(this.respawnMarker);
			if (this.fireOnce)
			{
				this.inactive = true;
			}
		}
	}

	// Token: 0x040002CD RID: 717
	public HazardRespawnMarker respawnMarker;

	// Token: 0x040002CE RID: 718
	private PlayerData playerData;

	// Token: 0x040002CF RID: 719
	public bool fireOnce;

	// Token: 0x040002D0 RID: 720
	private bool inactive;
}
