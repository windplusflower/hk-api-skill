using System;
using UnityEngine;

// Token: 0x02000468 RID: 1128
public class InvMarkerCollide : MonoBehaviour
{
	// Token: 0x06001953 RID: 6483 RVA: 0x00078CF0 File Offset: 0x00076EF0
	private void OnTriggerEnter2D(Collider2D collision)
	{
		GameObject gameObject = collision.gameObject;
		InvMarker component = gameObject.GetComponent<InvMarker>();
		if (component)
		{
			component.markerMenu = this.markerMenu;
			this.markerMenu.AddToCollidingList(gameObject);
		}
	}

	// Token: 0x06001954 RID: 6484 RVA: 0x00078D2C File Offset: 0x00076F2C
	private void OnTriggerExit2D(Collider2D collision)
	{
		GameObject gameObject = collision.gameObject;
		if (gameObject.GetComponent<InvMarker>())
		{
			this.markerMenu.RemoveFromCollidingList(gameObject);
		}
	}

	// Token: 0x04001E65 RID: 7781
	public MapMarkerMenu markerMenu;
}
