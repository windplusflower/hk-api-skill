using System;
using HutongGames.PlayMaker.Actions;
using UnityEngine;

// Token: 0x0200004E RID: 78
public class iTweenFSMEvents : MonoBehaviour
{
	// Token: 0x060001A1 RID: 417 RVA: 0x0000AD7C File Offset: 0x00008F7C
	private void iTweenOnStart(int aniTweenID)
	{
		if (this.itweenID == aniTweenID)
		{
			this.itweenFSMAction.Fsm.Event(this.itweenFSMAction.startEvent);
		}
	}

	// Token: 0x060001A2 RID: 418 RVA: 0x0000ADA4 File Offset: 0x00008FA4
	private void iTweenOnComplete(int aniTweenID)
	{
		if (this.itweenID == aniTweenID)
		{
			if (this.islooping)
			{
				if (!this.donotfinish)
				{
					this.itweenFSMAction.Fsm.Event(this.itweenFSMAction.finishEvent);
					this.itweenFSMAction.Finish();
					return;
				}
			}
			else
			{
				this.itweenFSMAction.Fsm.Event(this.itweenFSMAction.finishEvent);
				this.itweenFSMAction.Finish();
			}
		}
	}

	// Token: 0x04000138 RID: 312
	public static int itweenIDCount;

	// Token: 0x04000139 RID: 313
	public int itweenID;

	// Token: 0x0400013A RID: 314
	public iTweenFsmAction itweenFSMAction;

	// Token: 0x0400013B RID: 315
	public bool donotfinish;

	// Token: 0x0400013C RID: 316
	public bool islooping;
}
