using System;
using UnityEngine;

// Token: 0x020001EF RID: 495
[RequireComponent(typeof(BoxCollider2D))]
public class ActiveRegion : MonoBehaviour
{
	// Token: 0x06000AB4 RID: 2740 RVA: 0x000399EC File Offset: 0x00037BEC
	private void OnTriggerEnter2D(Collider2D col)
	{
		FSMActivator component = col.GetComponent<FSMActivator>();
		if (!component)
		{
			if (this.verboseMode)
			{
				Debug.Log(col.gameObject.name + " doesn't have an FSMActivator component.");
			}
			return;
		}
		if (this.staggeredActivation)
		{
			base.StartCoroutine(component.ActivateStaggered());
			return;
		}
		component.Activate();
	}

	// Token: 0x06000AB5 RID: 2741 RVA: 0x00039A47 File Offset: 0x00037C47
	public ActiveRegion()
	{
		this.staggeredActivation = true;
		base..ctor();
	}

	// Token: 0x04000BD6 RID: 3030
	private bool verboseMode;

	// Token: 0x04000BD7 RID: 3031
	[Tooltip("Activate FSMs immediately or over multiple frames.")]
	[HideInInspector]
	public bool staggeredActivation;

	// Token: 0x04000BD8 RID: 3032
	private BoxCollider2D activeRegion;
}
