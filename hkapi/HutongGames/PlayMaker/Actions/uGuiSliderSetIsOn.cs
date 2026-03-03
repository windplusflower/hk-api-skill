using System;
using UnityEngine;
using UnityEngine.UI;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000ABD RID: 2749
	[ActionCategory("uGui")]
	[Tooltip("Sets the isOn property of a UGui Toggle component.")]
	public class uGuiSliderSetIsOn : FsmStateAction
	{
		// Token: 0x06003B29 RID: 15145 RVA: 0x00155C17 File Offset: 0x00153E17
		public override void Reset()
		{
			this.gameObject = null;
			this.isOn = null;
			this.resetOnExit = null;
		}

		// Token: 0x06003B2A RID: 15146 RVA: 0x00155C30 File Offset: 0x00153E30
		public override void OnEnter()
		{
			GameObject ownerDefaultTarget = base.Fsm.GetOwnerDefaultTarget(this.gameObject);
			if (ownerDefaultTarget != null)
			{
				this._toggle = ownerDefaultTarget.GetComponent<Toggle>();
			}
			if (this.resetOnExit.Value)
			{
				this._originalValue = this._toggle.isOn;
			}
			this.DoSetValue();
			base.Finish();
		}

		// Token: 0x06003B2B RID: 15147 RVA: 0x00155C8E File Offset: 0x00153E8E
		private void DoSetValue()
		{
			if (this._toggle != null)
			{
				this._toggle.isOn = this.isOn.Value;
			}
		}

		// Token: 0x06003B2C RID: 15148 RVA: 0x00155CB4 File Offset: 0x00153EB4
		public override void OnExit()
		{
			if (this._toggle == null)
			{
				return;
			}
			if (this.resetOnExit.Value)
			{
				this._toggle.isOn = this._originalValue;
			}
		}

		// Token: 0x04003E73 RID: 15987
		[RequiredField]
		[CheckForComponent(typeof(Toggle))]
		[Tooltip("The GameObject with the Toggle UGui component.")]
		public FsmOwnerDefault gameObject;

		// Token: 0x04003E74 RID: 15988
		[RequiredField]
		[Tooltip("Should the toggle be on?")]
		public FsmBool isOn;

		// Token: 0x04003E75 RID: 15989
		[Tooltip("Reset when exiting this state.")]
		public FsmBool resetOnExit;

		// Token: 0x04003E76 RID: 15990
		private Toggle _toggle;

		// Token: 0x04003E77 RID: 15991
		private bool _originalValue;
	}
}
