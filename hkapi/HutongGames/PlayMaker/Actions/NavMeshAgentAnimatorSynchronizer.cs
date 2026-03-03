using System;
using UnityEngine;
using UnityEngine.AI;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x020008F9 RID: 2297
	[ActionCategory(ActionCategory.Animator)]
	[Tooltip("Synchronize a NavMesh Agent velocity and rotation with the animator process.")]
	public class NavMeshAgentAnimatorSynchronizer : FsmStateAction
	{
		// Token: 0x060032FC RID: 13052 RVA: 0x00133D2E File Offset: 0x00131F2E
		public override void Reset()
		{
			this.gameObject = null;
		}

		// Token: 0x060032FD RID: 13053 RVA: 0x00133D37 File Offset: 0x00131F37
		public override void OnPreprocess()
		{
			base.Fsm.HandleAnimatorMove = true;
		}

		// Token: 0x060032FE RID: 13054 RVA: 0x00133D48 File Offset: 0x00131F48
		public override void OnEnter()
		{
			GameObject ownerDefaultTarget = base.Fsm.GetOwnerDefaultTarget(this.gameObject);
			if (ownerDefaultTarget == null)
			{
				base.Finish();
				return;
			}
			this._agent = ownerDefaultTarget.GetComponent<NavMeshAgent>();
			this._animator = ownerDefaultTarget.GetComponent<Animator>();
			if (this._animator == null)
			{
				base.Finish();
				return;
			}
			this._trans = ownerDefaultTarget.transform;
		}

		// Token: 0x060032FF RID: 13055 RVA: 0x00133DB0 File Offset: 0x00131FB0
		public override void DoAnimatorMove()
		{
			this._agent.velocity = this._animator.deltaPosition / Time.deltaTime;
			this._trans.rotation = this._animator.rootRotation;
		}

		// Token: 0x04003463 RID: 13411
		[RequiredField]
		[CheckForComponent(typeof(NavMeshAgent))]
		[CheckForComponent(typeof(Animator))]
		[Tooltip("The Agent target. An Animator component and a NavMeshAgent component are required")]
		public FsmOwnerDefault gameObject;

		// Token: 0x04003464 RID: 13412
		private Animator _animator;

		// Token: 0x04003465 RID: 13413
		private NavMeshAgent _agent;

		// Token: 0x04003466 RID: 13414
		private Transform _trans;
	}
}
