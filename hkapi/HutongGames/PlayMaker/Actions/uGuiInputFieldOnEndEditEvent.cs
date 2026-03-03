using System;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000A9C RID: 2716
	[ActionCategory("uGui")]
	[Tooltip("Fires an event when editing ended for a UGui InputField component. Event string data will feature the text value")]
	public class uGuiInputFieldOnEndEditEvent : FsmStateAction
	{
		// Token: 0x06003A77 RID: 14967 RVA: 0x00154046 File Offset: 0x00152246
		public override void Reset()
		{
			this.gameObject = null;
			this.sendEvent = null;
		}

		// Token: 0x06003A78 RID: 14968 RVA: 0x00154058 File Offset: 0x00152258
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
				this._inputField.onEndEdit.AddListener(new UnityAction<string>(this.DoOnEndEdit));
				return;
			}
			base.LogError("Missing UI.InputField on " + ownerDefaultTarget.name);
		}

		// Token: 0x06003A79 RID: 14969 RVA: 0x001540D9 File Offset: 0x001522D9
		public override void OnExit()
		{
			if (this._inputField != null)
			{
				this._inputField.onEndEdit.RemoveListener(new UnityAction<string>(this.DoOnEndEdit));
			}
		}

		// Token: 0x06003A7A RID: 14970 RVA: 0x00154105 File Offset: 0x00152305
		public void DoOnEndEdit(string value)
		{
			Fsm.EventData.StringData = value;
			base.Fsm.Event(this.sendEvent);
		}

		// Token: 0x04003DCD RID: 15821
		[RequiredField]
		[CheckForComponent(typeof(InputField))]
		[Tooltip("The GameObject with the InputField ui component.")]
		public FsmOwnerDefault gameObject;

		// Token: 0x04003DCE RID: 15822
		[Tooltip("Send this event when editing ended.")]
		public FsmEvent sendEvent;

		// Token: 0x04003DCF RID: 15823
		private InputField _inputField;
	}
}
