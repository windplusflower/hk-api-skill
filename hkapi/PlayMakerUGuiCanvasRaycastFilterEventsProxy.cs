using System;
using UnityEngine;

// Token: 0x02000040 RID: 64
public class PlayMakerUGuiCanvasRaycastFilterEventsProxy : MonoBehaviour, ICanvasRaycastFilter
{
	// Token: 0x06000171 RID: 369 RVA: 0x00009D27 File Offset: 0x00007F27
	public bool IsRaycastLocationValid(Vector2 sp, Camera eventCamera)
	{
		return this.RayCastingEnabled;
	}

	// Token: 0x06000172 RID: 370 RVA: 0x00009D2F File Offset: 0x00007F2F
	public PlayMakerUGuiCanvasRaycastFilterEventsProxy()
	{
		this.RayCastingEnabled = true;
		base..ctor();
	}

	// Token: 0x040000FF RID: 255
	public bool RayCastingEnabled;
}
