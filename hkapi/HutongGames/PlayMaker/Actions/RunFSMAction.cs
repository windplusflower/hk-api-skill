using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000C7C RID: 3196
	[Tooltip("Base class for actions that want to run a sub FSM.")]
	public abstract class RunFSMAction : FsmStateAction
	{
		// Token: 0x060042C2 RID: 17090 RVA: 0x00170FFC File Offset: 0x0016F1FC
		public override void Reset()
		{
			this.runFsm = null;
		}

		// Token: 0x060042C3 RID: 17091 RVA: 0x00171005 File Offset: 0x0016F205
		public override bool Event(FsmEvent fsmEvent)
		{
			if (this.runFsm != null && (fsmEvent.IsGlobal || fsmEvent.IsSystemEvent))
			{
				this.runFsm.Event(fsmEvent);
			}
			return false;
		}

		// Token: 0x060042C4 RID: 17092 RVA: 0x0017102C File Offset: 0x0016F22C
		public override void OnEnter()
		{
			if (this.runFsm == null)
			{
				base.Finish();
				return;
			}
			this.runFsm.OnEnable();
			if (!this.runFsm.Started)
			{
				this.runFsm.Start();
			}
			this.CheckIfFinished();
		}

		// Token: 0x060042C5 RID: 17093 RVA: 0x00171066 File Offset: 0x0016F266
		public override void OnUpdate()
		{
			if (this.runFsm != null)
			{
				this.runFsm.Update();
				this.CheckIfFinished();
				return;
			}
			base.Finish();
		}

		// Token: 0x060042C6 RID: 17094 RVA: 0x00171088 File Offset: 0x0016F288
		public override void OnFixedUpdate()
		{
			if (this.runFsm != null)
			{
				this.runFsm.FixedUpdate();
				this.CheckIfFinished();
				return;
			}
			base.Finish();
		}

		// Token: 0x060042C7 RID: 17095 RVA: 0x001710AA File Offset: 0x0016F2AA
		public override void OnLateUpdate()
		{
			if (this.runFsm != null)
			{
				this.runFsm.LateUpdate();
				this.CheckIfFinished();
				return;
			}
			base.Finish();
		}

		// Token: 0x060042C8 RID: 17096 RVA: 0x001710CC File Offset: 0x0016F2CC
		public override void DoTriggerEnter(Collider other)
		{
			if (this.runFsm.HandleTriggerEnter)
			{
				this.runFsm.OnTriggerEnter(other);
			}
		}

		// Token: 0x060042C9 RID: 17097 RVA: 0x001710E7 File Offset: 0x0016F2E7
		public override void DoTriggerStay(Collider other)
		{
			if (this.runFsm.HandleTriggerStay)
			{
				this.runFsm.OnTriggerStay(other);
			}
		}

		// Token: 0x060042CA RID: 17098 RVA: 0x00171102 File Offset: 0x0016F302
		public override void DoTriggerExit(Collider other)
		{
			if (this.runFsm.HandleTriggerExit)
			{
				this.runFsm.OnTriggerExit(other);
			}
		}

		// Token: 0x060042CB RID: 17099 RVA: 0x0017111D File Offset: 0x0016F31D
		public override void DoCollisionEnter(Collision collisionInfo)
		{
			if (this.runFsm.HandleCollisionEnter)
			{
				this.runFsm.OnCollisionEnter(collisionInfo);
			}
		}

		// Token: 0x060042CC RID: 17100 RVA: 0x00171138 File Offset: 0x0016F338
		public override void DoCollisionStay(Collision collisionInfo)
		{
			if (this.runFsm.HandleCollisionStay)
			{
				this.runFsm.OnCollisionStay(collisionInfo);
			}
		}

		// Token: 0x060042CD RID: 17101 RVA: 0x00171153 File Offset: 0x0016F353
		public override void DoCollisionExit(Collision collisionInfo)
		{
			if (this.runFsm.HandleCollisionExit)
			{
				this.runFsm.OnCollisionExit(collisionInfo);
			}
		}

		// Token: 0x060042CE RID: 17102 RVA: 0x0017116E File Offset: 0x0016F36E
		public override void DoParticleCollision(GameObject other)
		{
			if (this.runFsm.HandleParticleCollision)
			{
				this.runFsm.OnParticleCollision(other);
			}
		}

		// Token: 0x060042CF RID: 17103 RVA: 0x00171189 File Offset: 0x0016F389
		public override void DoControllerColliderHit(ControllerColliderHit collisionInfo)
		{
			this.runFsm.OnControllerColliderHit(collisionInfo);
		}

		// Token: 0x060042D0 RID: 17104 RVA: 0x00171197 File Offset: 0x0016F397
		public override void DoTriggerEnter2D(Collider2D other)
		{
			if (this.runFsm.HandleTriggerEnter)
			{
				this.runFsm.OnTriggerEnter2D(other);
			}
		}

		// Token: 0x060042D1 RID: 17105 RVA: 0x001711B2 File Offset: 0x0016F3B2
		public override void DoTriggerStay2D(Collider2D other)
		{
			if (this.runFsm.HandleTriggerStay)
			{
				this.runFsm.OnTriggerStay2D(other);
			}
		}

		// Token: 0x060042D2 RID: 17106 RVA: 0x001711CD File Offset: 0x0016F3CD
		public override void DoTriggerExit2D(Collider2D other)
		{
			if (this.runFsm.HandleTriggerExit)
			{
				this.runFsm.OnTriggerExit2D(other);
			}
		}

		// Token: 0x060042D3 RID: 17107 RVA: 0x001711E8 File Offset: 0x0016F3E8
		public override void DoCollisionEnter2D(Collision2D collisionInfo)
		{
			if (this.runFsm.HandleCollisionEnter)
			{
				this.runFsm.OnCollisionEnter2D(collisionInfo);
			}
		}

		// Token: 0x060042D4 RID: 17108 RVA: 0x00171203 File Offset: 0x0016F403
		public override void DoCollisionStay2D(Collision2D collisionInfo)
		{
			if (this.runFsm.HandleCollisionStay)
			{
				this.runFsm.OnCollisionStay2D(collisionInfo);
			}
		}

		// Token: 0x060042D5 RID: 17109 RVA: 0x0017121E File Offset: 0x0016F41E
		public override void DoCollisionExit2D(Collision2D collisionInfo)
		{
			if (this.runFsm.HandleCollisionExit)
			{
				this.runFsm.OnCollisionExit2D(collisionInfo);
			}
		}

		// Token: 0x060042D6 RID: 17110 RVA: 0x00171239 File Offset: 0x0016F439
		public override void OnGUI()
		{
			if (this.runFsm != null && this.runFsm.HandleOnGUI)
			{
				this.runFsm.OnGUI();
			}
		}

		// Token: 0x060042D7 RID: 17111 RVA: 0x0017125B File Offset: 0x0016F45B
		public override void OnExit()
		{
			if (this.runFsm != null)
			{
				this.runFsm.Stop();
			}
		}

		// Token: 0x060042D8 RID: 17112 RVA: 0x00171270 File Offset: 0x0016F470
		protected virtual void CheckIfFinished()
		{
			if (this.runFsm == null || this.runFsm.Finished)
			{
				base.Finish();
			}
		}

		// Token: 0x0400471B RID: 18203
		protected Fsm runFsm;
	}
}
