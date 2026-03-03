using System;
using UnityEngine;

// Token: 0x02000451 RID: 1105
public class DisplayOnWorldMapOnly : MonoBehaviour
{
	// Token: 0x060018D4 RID: 6356 RVA: 0x00074220 File Offset: 0x00072420
	private void OnEnable()
	{
		if (this.meshRenderer == null)
		{
			this.meshRenderer = base.GetComponent<MeshRenderer>();
		}
		if (this.gameMap.displayNextArea)
		{
			this.meshRenderer.enabled = false;
			return;
		}
		this.meshRenderer.enabled = true;
	}

	// Token: 0x04001DC4 RID: 7620
	public GameMap gameMap;

	// Token: 0x04001DC5 RID: 7621
	private MeshRenderer meshRenderer;
}
