using System;
using UnityEngine;

// Token: 0x0200004A RID: 74
public class PlayMakerUGuiSceneProxy : MonoBehaviour
{
	// Token: 0x06000191 RID: 401 RVA: 0x0000AD6F File Offset: 0x00008F6F
	private void Start()
	{
		PlayMakerUGuiSceneProxy.fsm = base.GetComponent<PlayMakerFSM>();
	}

	// Token: 0x06000192 RID: 402 RVA: 0x00003603 File Offset: 0x00001803
	private void Update()
	{
	}

	// Token: 0x04000137 RID: 311
	public static PlayMakerFSM fsm;
}
