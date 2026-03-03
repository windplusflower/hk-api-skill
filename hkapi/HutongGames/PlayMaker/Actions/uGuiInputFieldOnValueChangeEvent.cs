using System;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000A9D RID: 2717
	[ActionCategory("uGui")]
	[Tooltip("Fires an event on value change for a UGui InputField component. Event string data will feature the text value")]
	public class uGuiInputFieldOnValueChangeEvent : FsmStateAction
	{
		// Token: 0x06003A7C RID: 14972 RVA: 0x00154123 File Offset: 0x00152323
		public override void Reset()
		{
			this.gameObject = null;
			this.sendEvent = null;
		}

		// Token: 0x06003A7D RID: 14973 RVA: 0x00154134 File Offset: 0x00152334
		public override void OnEnter()
		{
			GameObject ownerDefaultTarget = base.Fsm.GetOwnerDefaultTarget(this.gameObject);
			if (!(ownerDefaultTarget != null))
			{
				base.LogError("Missing GameObject");
				return;
			}
			this._inputField = ownerDefaultTarget.GetComponent<InputField>();
			if (this._inputField != null)
			{
				this._inputField.onValueChange.AddListener(new UnityAction<string>(this.DoOnValueChange));
				return;
			}
			base.LogError("Missing UI.InputField on " + ownerDefaultTarget.name);
		}

		// Token: 0x06003A7E RID: 14974 RVA: 0x001541B5 File Offset: 0x001523B5
		public override void OnExit()
		{
			if (this._inputField != null)
			{
				this._inputField.onValueChange.RemoveListener(new UnityAction<string>(this.DoOnValueChange));
			}
		}

		// Token: 0x06003A7F RID: 14975 RVA: 0x001541E1 File Offset: 0x001523E1
		public void DoOnValueChange(string value)
		{
			Fsm.EventData.StringData = value;
			base.Fsm.Event(this.sendEvent);
		}

		// Token: 0x04003DD0 RID: 15824
		[RequiredField]
		[CheckForComponent(typeof(InputField))]
		[Tooltip("The GameObject with the InputField ui component.")]
		public FsmOwnerDefault gameObject;

		// Token: 0x04003DD1 RID: 15825
		[Tooltip("Send this event when value changed.")]
		public FsmEvent sendEvent;

		// Token: 0x04003DD2 RID: 15826
		private InputField _inputField;
	}
}
