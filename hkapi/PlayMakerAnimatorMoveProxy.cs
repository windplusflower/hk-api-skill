using System;
using UnityEngine;

// Token: 0x0200001C RID: 28
[RequireComponent(typeof(Animator))]
[RequireComponent(typeof(PlayMakerFSM))]
public class PlayMakerAnimatorMoveProxy : MonoBehaviour
{
	// Token: 0x14000003 RID: 3
	// (add) Token: 0x060000CD RID: 205 RVA: 0x00004EC0 File Offset: 0x000030C0
	// (remove) Token: 0x060000CE RID: 206 RVA: 0x00004EF8 File Offset: 0x000030F8
	public event Action OnAnimatorMoveEvent;

	// Token: 0x060000CF RID: 207 RVA: 0x00003603 File Offset: 0x00001803
	private void Start()
	{
	}

	// Token: 0x060000D0 RID: 208 RVA: 0x00003603 File Offset: 0x00001803
	private void Update()
	{
	}

	// Token: 0x060000D1 RID: 209 RVA: 0x00004F2D File Offset: 0x0000312D
	private void OnAnimatorMove()
	{
		if (this.OnAnimatorMoveEvent != null)
		{
			this.OnAnimatorMoveEvent();
		}
	}

	// Token: 0x0400006D RID: 109
	public bool applyRootMotion;
}
