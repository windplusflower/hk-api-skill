using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000D26 RID: 3366
	[Tooltip("iTween base action - don't use!")]
	public abstract class iTweenFsmAction : FsmStateAction
	{
		// Token: 0x060045B6 RID: 17846 RVA: 0x00179EF0 File Offset: 0x001780F0
		public override void Reset()
		{
			this.startEvent = null;
			this.finishEvent = null;
			this.realTime = new FsmBool
			{
				Value = false
			};
			this.stopOnExit = new FsmBool
			{
				Value = true
			};
			this.loopDontFinish = new FsmBool
			{
				Value = true
			};
			this.itweenType = "";
		}

		// Token: 0x060045B7 RID: 17847 RVA: 0x00179F4C File Offset: 0x0017814C
		protected void OnEnteriTween(FsmOwnerDefault anOwner)
		{
			GameObject ownerDefaultTarget = base.Fsm.GetOwnerDefaultTarget(anOwner);
			if (ownerDefaultTarget == null)
			{
				return;
			}
			this.itweenEvents = ownerDefaultTarget.AddComponent<iTweenFSMEvents>();
			this.itweenEvents.itweenFSMAction = this;
			iTweenFSMEvents.itweenIDCount++;
			this.itweenID = iTweenFSMEvents.itweenIDCount;
			this.itweenEvents.itweenID = iTweenFSMEvents.itweenIDCount;
			this.itweenEvents.donotfinish = (!this.loopDontFinish.IsNone && this.loopDontFinish.Value);
		}

		// Token: 0x060045B8 RID: 17848 RVA: 0x00179FD5 File Offset: 0x001781D5
		protected void IsLoop(bool aValue)
		{
			if (this.itweenEvents != null)
			{
				this.itweenEvents.islooping = aValue;
			}
		}

		// Token: 0x060045B9 RID: 17849 RVA: 0x00179FF4 File Offset: 0x001781F4
		protected void OnExitiTween(FsmOwnerDefault anOwner)
		{
			GameObject ownerDefaultTarget = base.Fsm.GetOwnerDefaultTarget(anOwner);
			if (ownerDefaultTarget == null)
			{
				return;
			}
			if (this.itweenEvents)
			{
				UnityEngine.Object.Destroy(this.itweenEvents);
			}
			if (this.stopOnExit.IsNone)
			{
				iTween.Stop(ownerDefaultTarget, this.itweenType);
				return;
			}
			if (this.stopOnExit.Value)
			{
				iTween.Stop(ownerDefaultTarget, this.itweenType);
			}
		}

		// Token: 0x060045BA RID: 17850 RVA: 0x0017A063 File Offset: 0x00178263
		protected iTweenFsmAction()
		{
			this.itweenType = "";
			this.itweenID = -1;
			base..ctor();
		}

		// Token: 0x04004A20 RID: 18976
		[ActionSection("Events")]
		public FsmEvent startEvent;

		// Token: 0x04004A21 RID: 18977
		public FsmEvent finishEvent;

		// Token: 0x04004A22 RID: 18978
		[Tooltip("Setting this to true will allow the animation to continue independent of the current time which is helpful for animating menus after a game has been paused by setting Time.timeScale=0.")]
		public FsmBool realTime;

		// Token: 0x04004A23 RID: 18979
		public FsmBool stopOnExit;

		// Token: 0x04004A24 RID: 18980
		public FsmBool loopDontFinish;

		// Token: 0x04004A25 RID: 18981
		internal iTweenFSMEvents itweenEvents;

		// Token: 0x04004A26 RID: 18982
		protected string itweenType;

		// Token: 0x04004A27 RID: 18983
		protected int itweenID;

		// Token: 0x02000D27 RID: 3367
		public enum AxisRestriction
		{
			// Token: 0x04004A29 RID: 18985
			none,
			// Token: 0x04004A2A RID: 18986
			x,
			// Token: 0x04004A2B RID: 18987
			y,
			// Token: 0x04004A2C RID: 18988
			z,
			// Token: 0x04004A2D RID: 18989
			xy,
			// Token: 0x04004A2E RID: 18990
			xz,
			// Token: 0x04004A2F RID: 18991
			yz
		}
	}
}
