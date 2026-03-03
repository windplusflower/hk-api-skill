using System;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000ABC RID: 2748
	[ActionCategory("uGui")]
	[Tooltip("Fires an event on value changed for a UGui Toggle component. Event bool data will feature the Toggle value")]
	public class uGuiToggleOnClickEvent : FsmStateAction
	{
		// Token: 0x06003B24 RID: 15140 RVA: 0x00155B39 File Offset: 0x00153D39
		public override void Reset()
		{
			this.gameObject = null;
			this.sendEvent = null;
		}

		// Token: 0x06003B25 RID: 15141 RVA: 0x00155B4C File Offset: 0x00153D4C
		public override void OnEnter()
		{
			GameObject ownerDefaultTarget = base.Fsm.GetOwnerDefaultTarget(this.gameObject);
			if (!(ownerDefaultTarget != null))
			{
				base.LogError("Missing GameObject");
				return;
			}
			this._toggle = ownerDefaultTarget.GetComponent<Toggle>();
			if (this._toggle != null)
			{
				this._toggle.onValueChanged.AddListener(new UnityAction<bool>(this.DoOnValueChanged));
				return;
			}
			base.LogError("Missing UI.Toggle on " + ownerDefaultTarget.name);
		}

		// Token: 0x06003B26 RID: 15142 RVA: 0x00155BCD File Offset: 0x00153DCD
		public override void OnExit()
		{
			if (this._toggle != null)
			{
				this._toggle.onValueChanged.RemoveListener(new UnityAction<bool>(this.DoOnValueChanged));
			}
		}

		// Token: 0x06003B27 RID: 15143 RVA: 0x00155BF9 File Offset: 0x00153DF9
		public void DoOnValueChanged(bool value)
		{
			Fsm.EventData.BoolData = value;
			base.Fsm.Event(this.sendEvent);
		}

		// Token: 0x04003E70 RID: 15984
		[RequiredField]
		[CheckForComponent(typeof(Toggle))]
		[Tooltip("The GameObject with the Toggle ui component.")]
		public FsmOwnerDefault gameObject;

		// Token: 0x04003E71 RID: 15985
		[Tooltip("Send this event when value changed.")]
		public FsmEvent sendEvent;

		// Token: 0x04003E72 RID: 15986
		private Toggle _toggle;
	}
}
