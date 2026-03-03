using System;
using UnityEngine;

// Token: 0x0200001B RID: 27
[RequireComponent(typeof(Animator))]
[RequireComponent(typeof(PlayMakerFSM))]
public class PlayMakerAnimatorIKProxy : MonoBehaviour
{
	// Token: 0x14000002 RID: 2
	// (add) Token: 0x060000C9 RID: 201 RVA: 0x00004E3C File Offset: 0x0000303C
	// (remove) Token: 0x060000CA RID: 202 RVA: 0x00004E74 File Offset: 0x00003074
	public event Action<int> OnAnimatorIKEvent;

	// Token: 0x060000CB RID: 203 RVA: 0x00004EA9 File Offset: 0x000030A9
	private void OnAnimatorIK(int layerIndex)
	{
		if (this.OnAnimatorIKEvent != null)
		{
			this.OnAnimatorIKEvent(layerIndex);
		}
	}

	// Token: 0x0400006C RID: 108
	private Animator _animator;
}
