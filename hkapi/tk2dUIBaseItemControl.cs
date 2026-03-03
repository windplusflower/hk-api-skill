using System;
using UnityEngine;

// Token: 0x0200059D RID: 1437
[AddComponentMenu("2D Toolkit/UI/tk2dUIBaseItemControl")]
public abstract class tk2dUIBaseItemControl : MonoBehaviour
{
	// Token: 0x17000423 RID: 1059
	// (get) Token: 0x06001FF1 RID: 8177 RVA: 0x000A128C File Offset: 0x0009F48C
	// (set) Token: 0x06001FF2 RID: 8178 RVA: 0x000A12A9 File Offset: 0x0009F4A9
	public GameObject SendMessageTarget
	{
		get
		{
			if (this.uiItem != null)
			{
				return this.uiItem.sendMessageTarget;
			}
			return null;
		}
		set
		{
			if (this.uiItem != null)
			{
				this.uiItem.sendMessageTarget = value;
			}
		}
	}

	// Token: 0x06001FF3 RID: 8179 RVA: 0x000A12C5 File Offset: 0x0009F4C5
	public static void ChangeGameObjectActiveState(GameObject go, bool isActive)
	{
		go.SetActive(isActive);
	}

	// Token: 0x06001FF4 RID: 8180 RVA: 0x000A12CE File Offset: 0x0009F4CE
	public static void ChangeGameObjectActiveStateWithNullCheck(GameObject go, bool isActive)
	{
		if (go != null)
		{
			tk2dUIBaseItemControl.ChangeGameObjectActiveState(go, isActive);
		}
	}

	// Token: 0x06001FF5 RID: 8181 RVA: 0x000A12E0 File Offset: 0x0009F4E0
	protected void DoSendMessage(string methodName, object parameter)
	{
		if (this.SendMessageTarget != null && methodName.Length > 0)
		{
			this.SendMessageTarget.SendMessage(methodName, parameter, SendMessageOptions.RequireReceiver);
		}
	}

	// Token: 0x040025D3 RID: 9683
	public tk2dUIItem uiItem;
}
