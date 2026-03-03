using System;
using HutongGames.PlayMaker;
using UnityEngine;

// Token: 0x02000420 RID: 1056
[ActionCategory("Hollow Knight")]
[HutongGames.PlayMaker.Tooltip("Check and respond to the amount of objects in a Trigger that has TrackTriggerObjects attached to the same object.")]
public class CheckTrackTriggerCount : FsmStateAction
{
	// Token: 0x060017D0 RID: 6096 RVA: 0x0007055C File Offset: 0x0006E75C
	public override void Reset()
	{
		this.target = null;
		this.count = null;
		this.test = null;
		this.everyFrame = true;
		this.successEvent = null;
	}

	// Token: 0x060017D1 RID: 6097 RVA: 0x00070581 File Offset: 0x0006E781
	public override void OnPreprocess()
	{
		base.Fsm.HandleFixedUpdate = true;
	}

	// Token: 0x060017D2 RID: 6098 RVA: 0x00070590 File Offset: 0x0006E790
	public override void OnEnter()
	{
		GameObject safe = this.target.GetSafe(this);
		if (safe)
		{
			this.track = safe.GetComponent<TrackTriggerObjects>();
			if (this.track)
			{
				if (!this.CheckCount())
				{
					if (this.everyFrame)
					{
						return;
					}
				}
				else
				{
					base.Fsm.Event(this.successEvent);
				}
			}
			else
			{
				Debug.LogError("Target GameObject does not have a TrackTriggerObjects component attached!", base.Owner);
			}
		}
		base.Finish();
	}

	// Token: 0x060017D3 RID: 6099 RVA: 0x00070605 File Offset: 0x0006E805
	public override void OnFixedUpdate()
	{
		if (this.everyFrame && this.CheckCount())
		{
			base.Fsm.Event(this.successEvent);
		}
	}

	// Token: 0x060017D4 RID: 6100 RVA: 0x00070628 File Offset: 0x0006E828
	public bool CheckCount()
	{
		if (this.track)
		{
			switch ((CheckTrackTriggerCount.IntTest)this.test.Value)
			{
			case CheckTrackTriggerCount.IntTest.Equal:
				return this.track.InsideCount == this.count.Value;
			case CheckTrackTriggerCount.IntTest.LessThan:
				return this.track.InsideCount < this.count.Value;
			case CheckTrackTriggerCount.IntTest.MoreThan:
				return this.track.InsideCount > this.count.Value;
			case CheckTrackTriggerCount.IntTest.LessThanOrEqual:
				return this.track.InsideCount <= this.count.Value;
			case CheckTrackTriggerCount.IntTest.MoreThanOrEqual:
				return this.track.InsideCount >= this.count.Value;
			default:
				Debug.LogError(string.Format("IntTest type {0} not implemented!", ((CheckTrackTriggerCount.IntTest)this.test.Value).ToString()), base.Owner);
				break;
			}
		}
		return false;
	}

	// Token: 0x04001C93 RID: 7315
	public FsmOwnerDefault target;

	// Token: 0x04001C94 RID: 7316
	public FsmInt count;

	// Token: 0x04001C95 RID: 7317
	[ObjectType(typeof(CheckTrackTriggerCount.IntTest))]
	public FsmEnum test;

	// Token: 0x04001C96 RID: 7318
	public bool everyFrame;

	// Token: 0x04001C97 RID: 7319
	[Space]
	public FsmEvent successEvent;

	// Token: 0x04001C98 RID: 7320
	private TrackTriggerObjects track;

	// Token: 0x02000421 RID: 1057
	public enum IntTest
	{
		// Token: 0x04001C9A RID: 7322
		Equal,
		// Token: 0x04001C9B RID: 7323
		LessThan,
		// Token: 0x04001C9C RID: 7324
		MoreThan,
		// Token: 0x04001C9D RID: 7325
		LessThanOrEqual,
		// Token: 0x04001C9E RID: 7326
		MoreThanOrEqual
	}
}
