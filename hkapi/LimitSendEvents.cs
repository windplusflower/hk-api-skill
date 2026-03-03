using System;
using System.Collections.Generic;
using UnityEngine;

// Token: 0x020002C4 RID: 708
public class LimitSendEvents : MonoBehaviour
{
	// Token: 0x06000EF5 RID: 3829 RVA: 0x00049C20 File Offset: 0x00047E20
	private void OnEnable()
	{
		this.sentList.Clear();
	}

	// Token: 0x06000EF6 RID: 3830 RVA: 0x00049C30 File Offset: 0x00047E30
	private void Update()
	{
		if (this.monitorCollider)
		{
			bool enabled = this.monitorCollider.enabled;
			bool? flag = this.previousColliderState;
			if (enabled == flag.GetValueOrDefault() & flag != null)
			{
				return;
			}
			this.previousColliderState = new bool?(this.monitorCollider.enabled);
		}
		if (this.sentList.Count > 0)
		{
			this.sentList.Clear();
		}
	}

	// Token: 0x06000EF7 RID: 3831 RVA: 0x00049C9F File Offset: 0x00047E9F
	public bool Add(GameObject obj)
	{
		if (!this.sentList.Contains(obj))
		{
			this.sentList.Add(obj);
			return true;
		}
		return false;
	}

	// Token: 0x06000EF8 RID: 3832 RVA: 0x00049CBE File Offset: 0x00047EBE
	public LimitSendEvents()
	{
		this.sentList = new List<GameObject>();
		base..ctor();
	}

	// Token: 0x04000FB2 RID: 4018
	public Collider2D monitorCollider;

	// Token: 0x04000FB3 RID: 4019
	private bool? previousColliderState;

	// Token: 0x04000FB4 RID: 4020
	private List<GameObject> sentList;
}
