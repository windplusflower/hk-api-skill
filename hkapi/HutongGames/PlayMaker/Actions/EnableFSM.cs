using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000B7A RID: 2938
	[ActionCategory(ActionCategory.StateMachine)]
	[ActionTarget(typeof(PlayMakerFSM), "gameObject,fsmName", false)]
	[Tooltip("Enables/Disables an FSM component on a GameObject.")]
	public class EnableFSM : FsmStateAction
	{
		// Token: 0x06003E73 RID: 15987 RVA: 0x001644B5 File Offset: 0x001626B5
		public override void Reset()
		{
			this.gameObject = null;
			this.fsmName = "";
			this.enable = true;
			this.resetOnExit = true;
		}

		// Token: 0x06003E74 RID: 15988 RVA: 0x001644E6 File Offset: 0x001626E6
		public override void OnEnter()
		{
			this.DoEnableFSM();
			base.Finish();
		}

		// Token: 0x06003E75 RID: 15989 RVA: 0x001644F4 File Offset: 0x001626F4
		private void DoEnableFSM()
		{
			GameObject gameObject = (this.gameObject.OwnerOption == OwnerDefaultOption.UseOwner) ? base.Owner : this.gameObject.GameObject.Value;
			if (gameObject == null)
			{
				return;
			}
			if (!string.IsNullOrEmpty(this.fsmName.Value))
			{
				foreach (PlayMakerFSM playMakerFSM in gameObject.GetComponents<PlayMakerFSM>())
				{
					if (playMakerFSM.FsmName == this.fsmName.Value)
					{
						this.fsmComponent = playMakerFSM;
						break;
					}
				}
			}
			else
			{
				this.fsmComponent = gameObject.GetComponent<PlayMakerFSM>();
			}
			if (this.fsmComponent == null)
			{
				base.LogError("Missing FsmComponent!");
				return;
			}
			this.fsmComponent.enabled = this.enable.Value;
		}

		// Token: 0x06003E76 RID: 15990 RVA: 0x001645BB File Offset: 0x001627BB
		public override void OnExit()
		{
			if (this.fsmComponent == null)
			{
				return;
			}
			if (this.resetOnExit.Value)
			{
				this.fsmComponent.enabled = !this.enable.Value;
			}
		}

		// Token: 0x04004285 RID: 17029
		[RequiredField]
		[Tooltip("The GameObject that owns the FSM component.")]
		public FsmOwnerDefault gameObject;

		// Token: 0x04004286 RID: 17030
		[UIHint(UIHint.FsmName)]
		[Tooltip("Optional name of FSM on GameObject. Useful if you have more than one FSM on a GameObject.")]
		public FsmString fsmName;

		// Token: 0x04004287 RID: 17031
		[Tooltip("Set to True to enable, False to disable.")]
		public FsmBool enable;

		// Token: 0x04004288 RID: 17032
		[Tooltip("Reset the initial enabled state when exiting the state.")]
		public FsmBool resetOnExit;

		// Token: 0x04004289 RID: 17033
		private PlayMakerFSM fsmComponent;
	}
}
