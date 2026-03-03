using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000A7D RID: 2685
	[ActionCategory("uGui")]
	[Tooltip("Enable or disable the raycasting of events via PlayMakerUGuiCanvasRaycastFilterEventsProxy component. Optionally reset on state exit")]
	public class uGuiCanvasEnableRaycastFilter : FsmStateAction
	{
		// Token: 0x060039E3 RID: 14819 RVA: 0x00151B7D File Offset: 0x0014FD7D
		public override void Reset()
		{
			this.gameObject = null;
			this.enableRaycasting = false;
			this.resetOnExit = null;
			this.everyFrame = false;
		}

		// Token: 0x060039E4 RID: 14820 RVA: 0x00151BA0 File Offset: 0x0014FDA0
		public override void OnEnter()
		{
			GameObject ownerDefaultTarget = base.Fsm.GetOwnerDefaultTarget(this.gameObject);
			if (ownerDefaultTarget != null)
			{
				this._comp = ownerDefaultTarget.GetComponent<PlayMakerUGuiCanvasRaycastFilterEventsProxy>();
				this._originalValue = this._comp.RayCastingEnabled;
			}
			this.DoAction();
			if (!this.everyFrame)
			{
				base.Finish();
			}
		}

		// Token: 0x060039E5 RID: 14821 RVA: 0x00151BF9 File Offset: 0x0014FDF9
		public override void OnUpdate()
		{
			this.DoAction();
		}

		// Token: 0x060039E6 RID: 14822 RVA: 0x00151C01 File Offset: 0x0014FE01
		private void DoAction()
		{
			if (this._comp != null)
			{
				this._comp.RayCastingEnabled = this.enableRaycasting.Value;
			}
		}

		// Token: 0x060039E7 RID: 14823 RVA: 0x00151C27 File Offset: 0x0014FE27
		public override void OnExit()
		{
			if (this._comp == null)
			{
				return;
			}
			if (this.resetOnExit.Value)
			{
				this._comp.RayCastingEnabled = this._originalValue;
			}
		}

		// Token: 0x04003CFC RID: 15612
		[RequiredField]
		[CheckForComponent(typeof(PlayMakerUGuiCanvasRaycastFilterEventsProxy))]
		[Tooltip("The GameObject with the PlayMakerUGuiCanvasRaycastFilterEventsProxy component.")]
		public FsmOwnerDefault gameObject;

		// Token: 0x04003CFD RID: 15613
		public FsmBool enableRaycasting;

		// Token: 0x04003CFE RID: 15614
		[Tooltip("Reset when exiting this state.")]
		public FsmBool resetOnExit;

		// Token: 0x04003CFF RID: 15615
		public bool everyFrame;

		// Token: 0x04003D00 RID: 15616
		private PlayMakerUGuiCanvasRaycastFilterEventsProxy _comp;

		// Token: 0x04003D01 RID: 15617
		private bool _originalValue;
	}
}
