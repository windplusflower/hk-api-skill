using System;
using UnityEngine;

// Token: 0x02000467 RID: 1127
public class InvMarker : MonoBehaviour
{
	// Token: 0x06001951 RID: 6481 RVA: 0x00078CD0 File Offset: 0x00076ED0
	private void OnDisable()
	{
		if (this.markerMenu)
		{
			this.markerMenu.RemoveFromCollidingList(base.gameObject);
		}
	}

	// Token: 0x04001E62 RID: 7778
	public MapMarkerMenu markerMenu;

	// Token: 0x04001E63 RID: 7779
	public int colour;

	// Token: 0x04001E64 RID: 7780
	public int id;
}
