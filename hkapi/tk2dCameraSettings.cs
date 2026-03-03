using System;
using UnityEngine;

// Token: 0x0200053C RID: 1340
[Serializable]
public class tk2dCameraSettings
{
	// Token: 0x06001D68 RID: 7528 RVA: 0x00091E50 File Offset: 0x00090050
	public tk2dCameraSettings()
	{
		this.orthographicSize = 10f;
		this.orthographicPixelsPerMeter = 100f;
		this.orthographicOrigin = tk2dCameraSettings.OrthographicOrigin.Center;
		this.fieldOfView = 60f;
		this.rect = new Rect(0f, 0f, 1f, 1f);
		base..ctor();
	}

	// Token: 0x040022D5 RID: 8917
	public tk2dCameraSettings.ProjectionType projection;

	// Token: 0x040022D6 RID: 8918
	public float orthographicSize;

	// Token: 0x040022D7 RID: 8919
	public float orthographicPixelsPerMeter;

	// Token: 0x040022D8 RID: 8920
	public tk2dCameraSettings.OrthographicOrigin orthographicOrigin;

	// Token: 0x040022D9 RID: 8921
	public tk2dCameraSettings.OrthographicType orthographicType;

	// Token: 0x040022DA RID: 8922
	public TransparencySortMode transparencySortMode;

	// Token: 0x040022DB RID: 8923
	public float fieldOfView;

	// Token: 0x040022DC RID: 8924
	public Rect rect;

	// Token: 0x0200053D RID: 1341
	public enum ProjectionType
	{
		// Token: 0x040022DE RID: 8926
		Orthographic,
		// Token: 0x040022DF RID: 8927
		Perspective
	}

	// Token: 0x0200053E RID: 1342
	public enum OrthographicType
	{
		// Token: 0x040022E1 RID: 8929
		PixelsPerMeter,
		// Token: 0x040022E2 RID: 8930
		OrthographicSize
	}

	// Token: 0x0200053F RID: 1343
	public enum OrthographicOrigin
	{
		// Token: 0x040022E4 RID: 8932
		BottomLeft,
		// Token: 0x040022E5 RID: 8933
		Center
	}
}
