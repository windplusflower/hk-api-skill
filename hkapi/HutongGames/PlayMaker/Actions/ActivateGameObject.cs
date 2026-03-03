using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000AEE RID: 2798
	[ActionCategory(ActionCategory.GameObject)]
	[Tooltip("Activates/deactivates a Game Object. Use this to hide/show areas, or enable/disable many Behaviours at once.")]
	public class ActivateGameObject : FsmStateAction
	{
		// Token: 0x06003C11 RID: 15377 RVA: 0x00159D9A File Offset: 0x00157F9A
		public override void Reset()
		{
			this.gameObject = null;
			this.activate = true;
			this.recursive = true;
			this.resetOnExit = false;
			this.everyFrame = false;
		}

		// Token: 0x06003C12 RID: 15378 RVA: 0x00159DC9 File Offset: 0x00157FC9
		public override void OnEnter()
		{
			this.DoActivateGameObject();
			if (!this.everyFrame)
			{
				base.Finish();
			}
		}

		// Token: 0x06003C13 RID: 15379 RVA: 0x00159DDF File Offset: 0x00157FDF
		public override void OnUpdate()
		{
			this.DoActivateGameObject();
		}

		// Token: 0x06003C14 RID: 15380 RVA: 0x00159DE8 File Offset: 0x00157FE8
		public override void OnExit()
		{
			if (this.activatedGameObject == null)
			{
				return;
			}
			if (this.resetOnExit)
			{
				if (this.recursive.Value)
				{
					this.SetActiveRecursively(this.activatedGameObject, !this.activate.Value);
					return;
				}
				this.activatedGameObject.SetActive(!this.activate.Value);
			}
		}

		// Token: 0x06003C15 RID: 15381 RVA: 0x00159E50 File Offset: 0x00158050
		private void DoActivateGameObject()
		{
			GameObject ownerDefaultTarget = base.Fsm.GetOwnerDefaultTarget(this.gameObject);
			if (ownerDefaultTarget == null)
			{
				return;
			}
			if (this.recursive.Value)
			{
				this.SetActiveRecursively(ownerDefaultTarget, this.activate.Value);
			}
			else
			{
				ownerDefaultTarget.SetActive(this.activate.Value);
			}
			this.activatedGameObject = ownerDefaultTarget;
		}

		// Token: 0x06003C16 RID: 15382 RVA: 0x00159EB4 File Offset: 0x001580B4
		public void SetActiveRecursively(GameObject go, bool state)
		{
			go.SetActive(state);
			foreach (object obj in go.transform)
			{
				Transform transform = (Transform)obj;
				this.SetActiveRecursively(transform.gameObject, state);
			}
		}

		// Token: 0x04003FB8 RID: 16312
		[RequiredField]
		[Tooltip("The GameObject to activate/deactivate.")]
		public FsmOwnerDefault gameObject;

		// Token: 0x04003FB9 RID: 16313
		[RequiredField]
		[Tooltip("Check to activate, uncheck to deactivate Game Object.")]
		public FsmBool activate;

		// Token: 0x04003FBA RID: 16314
		[Tooltip("Recursively activate/deactivate all children.")]
		public FsmBool recursive;

		// Token: 0x04003FBB RID: 16315
		[Tooltip("Reset the game objects when exiting this state. Useful if you want an object to be active only while this state is active.\nNote: Only applies to the last Game Object activated/deactivated (won't work if Game Object changes).")]
		public bool resetOnExit;

		// Token: 0x04003FBC RID: 16316
		[Tooltip("Repeat this action every frame. Useful if Activate changes over time.")]
		public bool everyFrame;

		// Token: 0x04003FBD RID: 16317
		private GameObject activatedGameObject;
	}
}
