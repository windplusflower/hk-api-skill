using System;
using UnityEngine;
using UnityEngine.UI;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000ABB RID: 2747
	[ActionCategory("uGui")]
	[Tooltip("Gets the isOn value of a UGui Toggle component. Optionally send events")]
	public class uGuiToggleGetIsOn : FsmStateAction
	{
		// Token: 0x06003B1F RID: 15135 RVA: 0x00155A5F File Offset: 0x00153C5F
		public override void Reset()
		{
			this.gameObject = null;
			this.value = null;
			this.everyFrame = false;
		}

		// Token: 0x06003B20 RID: 15136 RVA: 0x00155A78 File Offset: 0x00153C78
		public override void OnEnter()
		{
			GameObject ownerDefaultTarget = base.Fsm.GetOwnerDefaultTarget(this.gameObject);
			if (ownerDefaultTarget != null)
			{
				this._toggle = ownerDefaultTarget.GetComponent<Toggle>();
			}
			this.DoGetValue();
			if (!this.everyFrame)
			{
				base.Finish();
			}
		}

		// Token: 0x06003B21 RID: 15137 RVA: 0x00155AC0 File Offset: 0x00153CC0
		public override void OnUpdate()
		{
			this.DoGetValue();
		}

		// Token: 0x06003B22 RID: 15138 RVA: 0x00155AC8 File Offset: 0x00153CC8
		private void DoGetValue()
		{
			if (this._toggle != null)
			{
				this.value.Value = this._toggle.isOn;
				if (this._toggle.isOn)
				{
					if (this.isOnEvent != null)
					{
						base.Fsm.Event(this.isOnEvent);
						return;
					}
				}
				else if (this.isOnEvent != null)
				{
					base.Fsm.Event(this.isOffEvent);
				}
			}
		}

		// Token: 0x04003E6A RID: 15978
		[RequiredField]
		[CheckForComponent(typeof(Toggle))]
		[Tooltip("The GameObject with the Toggle UGui component.")]
		public FsmOwnerDefault gameObject;

		// Token: 0x04003E6B RID: 15979
		[UIHint(UIHint.Variable)]
		[Tooltip("The isOn Value of the UGui slider component.")]
		public FsmBool value;

		// Token: 0x04003E6C RID: 15980
		[Tooltip("Event sent when isOn Value is true.")]
		public FsmEvent isOnEvent;

		// Token: 0x04003E6D RID: 15981
		[Tooltip("Event sent when isOn Value is false.")]
		public FsmEvent isOffEvent;

		// Token: 0x04003E6E RID: 15982
		[Tooltip("Repeats every frame")]
		public bool everyFrame;

		// Token: 0x04003E6F RID: 15983
		private Toggle _toggle;
	}
}
