using System;
using UnityEngine;

// Token: 0x020000A0 RID: 160
public class RespawnTrigger : MonoBehaviour
{
	// Token: 0x0600036F RID: 879 RVA: 0x00012570 File Offset: 0x00010770
	private void Awake()
	{
		this.gm = GameManager.instance;
		this.playerData = PlayerData.instance;
		if (this.playerData == null)
		{
			Debug.LogError(base.name + "- Player Data reference is null, please check this is being set correctly.");
		}
		if (this.singleUse)
		{
			this.myFsm = base.GetComponent<PlayMakerFSM>();
			if (this.myFsm == null)
			{
				Debug.LogError(base.name + " - Respawn Trigger set to Single Use but has no PlayMakerFSM attached.");
			}
		}
	}

	// Token: 0x06000370 RID: 880 RVA: 0x000125E7 File Offset: 0x000107E7
	private void Start()
	{
		if (this.respawnMarker == null)
		{
			Debug.LogWarning(base.name + " does not have a Death Respawn Marker Set");
		}
	}

	// Token: 0x06000371 RID: 881 RVA: 0x0001260C File Offset: 0x0001080C
	private void OnTriggerEnter2D(Collider2D otherCollider)
	{
		if (otherCollider.gameObject.layer == 9)
		{
			if (this.singleUse)
			{
				if (!this.myFsm.FsmVariables.GetFsmBool("Activated").Value)
				{
					this.playerData.SetBenchRespawn(this.respawnMarker, this.gm.sceneName, this.respawnType);
					this.myFsm.FsmVariables.GetFsmBool("Activated").Value = true;
					GameManager.instance.SetCurrentMapZoneAsRespawn();
					return;
				}
			}
			else
			{
				this.playerData.SetBenchRespawn(this.respawnMarker, this.gm.sceneName, this.respawnType);
				GameManager.instance.SetCurrentMapZoneAsRespawn();
			}
		}
	}

	// Token: 0x040002D2 RID: 722
	public RespawnMarker respawnMarker;

	// Token: 0x040002D3 RID: 723
	[Tooltip("If true, trigger deactivates itself after the first instance the hero uses it.")]
	public bool singleUse;

	// Token: 0x040002D4 RID: 724
	[Tooltip("0 = face down, 1 = on bench")]
	public int respawnType;

	// Token: 0x040002D5 RID: 725
	private GameManager gm;

	// Token: 0x040002D6 RID: 726
	private PlayerData playerData;

	// Token: 0x040002D7 RID: 727
	private PlayMakerFSM myFsm;
}
