using System;
using UnityEngine;

// Token: 0x02000108 RID: 264
public class InGameCutsceneInfo : MonoBehaviour
{
	// Token: 0x170000B7 RID: 183
	// (get) Token: 0x06000671 RID: 1649 RVA: 0x000261E6 File Offset: 0x000243E6
	public static bool IsInCutscene
	{
		get
		{
			return InGameCutsceneInfo.instance != null;
		}
	}

	// Token: 0x170000B8 RID: 184
	// (get) Token: 0x06000672 RID: 1650 RVA: 0x000261F3 File Offset: 0x000243F3
	public static Vector2 CameraPosition
	{
		get
		{
			if (!(InGameCutsceneInfo.instance != null))
			{
				return Vector2.zero;
			}
			return InGameCutsceneInfo.instance.cameraPosition;
		}
	}

	// Token: 0x06000673 RID: 1651 RVA: 0x00026212 File Offset: 0x00024412
	private void Awake()
	{
		InGameCutsceneInfo.instance = this;
	}

	// Token: 0x06000674 RID: 1652 RVA: 0x0002621A File Offset: 0x0002441A
	private void OnDestroy()
	{
		if (InGameCutsceneInfo.instance == this)
		{
			InGameCutsceneInfo.instance = null;
		}
	}

	// Token: 0x040006E8 RID: 1768
	private static InGameCutsceneInfo instance;

	// Token: 0x040006E9 RID: 1769
	[SerializeField]
	private Vector2 cameraPosition;
}
