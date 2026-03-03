using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000CEB RID: 3307
	[ActionCategory(ActionCategory.Material)]
	[Tooltip("Sets the visibility of a GameObject. Note: this action sets the GameObject Renderer's enabled state.")]
	public class SetVisibility : ComponentAction<Renderer>
	{
		// Token: 0x060044BD RID: 17597 RVA: 0x00176B97 File Offset: 0x00174D97
		public override void Reset()
		{
			this.gameObject = null;
			this.toggle = false;
			this.visible = false;
			this.resetOnExit = true;
			this.initialVisibility = false;
		}

		// Token: 0x060044BE RID: 17598 RVA: 0x00176BC6 File Offset: 0x00174DC6
		public override void OnEnter()
		{
			this.DoSetVisibility(base.Fsm.GetOwnerDefaultTarget(this.gameObject));
			base.Finish();
		}

		// Token: 0x060044BF RID: 17599 RVA: 0x00176BE8 File Offset: 0x00174DE8
		private void DoSetVisibility(GameObject go)
		{
			if (!base.UpdateCache(go))
			{
				return;
			}
			this.initialVisibility = base.renderer.enabled;
			if (!this.toggle.Value)
			{
				base.renderer.enabled = this.visible.Value;
				return;
			}
			base.renderer.enabled = !base.renderer.enabled;
		}

		// Token: 0x060044C0 RID: 17600 RVA: 0x00176C4D File Offset: 0x00174E4D
		public override void OnExit()
		{
			if (this.resetOnExit)
			{
				this.ResetVisibility();
			}
		}

		// Token: 0x060044C1 RID: 17601 RVA: 0x00176C5D File Offset: 0x00174E5D
		private void ResetVisibility()
		{
			if (base.renderer != null)
			{
				base.renderer.enabled = this.initialVisibility;
			}
		}

		// Token: 0x04004901 RID: 18689
		[RequiredField]
		[CheckForComponent(typeof(Renderer))]
		public FsmOwnerDefault gameObject;

		// Token: 0x04004902 RID: 18690
		[Tooltip("Should the object visibility be toggled?\nHas priority over the 'visible' setting")]
		public FsmBool toggle;

		// Token: 0x04004903 RID: 18691
		[Tooltip("Should the object be set to visible or invisible?")]
		public FsmBool visible;

		// Token: 0x04004904 RID: 18692
		[Tooltip("Resets to the initial visibility when it leaves the state")]
		public bool resetOnExit;

		// Token: 0x04004905 RID: 18693
		private bool initialVisibility;
	}
}
