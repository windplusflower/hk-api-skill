using System;
using UnityEngine;

// Token: 0x0200038A RID: 906
public class PositionShadeMarkerPerDoor : MonoBehaviour
{
	// Token: 0x06001513 RID: 5395 RVA: 0x00064358 File Offset: 0x00062558
	public void Start()
	{
		if (this.shadeMarker)
		{
			foreach (PositionShadeMarkerPerDoor.DoorShadePosition doorShadePosition in this.shadePositions)
			{
				if (doorShadePosition.door.name == GameManager.instance.entryGateName)
				{
					this.shadeMarker.transform.SetPosition2D(doorShadePosition.position);
					return;
				}
			}
		}
	}

	// Token: 0x0400192A RID: 6442
	public GameObject shadeMarker;

	// Token: 0x0400192B RID: 6443
	public PositionShadeMarkerPerDoor.DoorShadePosition[] shadePositions;

	// Token: 0x0200038B RID: 907
	[Serializable]
	public struct DoorShadePosition
	{
		// Token: 0x0400192C RID: 6444
		public GameObject door;

		// Token: 0x0400192D RID: 6445
		public Vector2 position;
	}
}
