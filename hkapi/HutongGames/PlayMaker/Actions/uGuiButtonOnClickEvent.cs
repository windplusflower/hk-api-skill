using System;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000A8D RID: 2701
	[ActionCategory("uGui")]
	[Tooltip("Fires an event on click for a UGui Slider component.")]
	public class uGuiButtonOnClickEvent : FsmStateAction
	{
		// Token: 0x06003A30 RID: 14896 RVA: 0x001535B0 File Offset: 0x001517B0
		public override void Reset()
		{
			this.gameObject = null;
			this.sendEvent = null;
		}

		// Token: 0x06003A31 RID: 14897 RVA: 0x001535C0 File Offset: 0x001517C0
		public override void OnEnter()
		{
			GameObject ownerDefaultTarget = base.Fsm.GetOwnerDefaultTarget(this.gameObject);
			if (!(ownerDefaultTarget != null))
			{
				base.LogError("Missing GameObject ");
				return;
			}
			this.button = ownerDefaultTarget.GetComponent<Button>();
			if (this.button != null)
			{
				this.button.onClick.AddListener(new UnityAction(this.DoOnClick));
				return;
			}
			base.LogError("Missing UI.Button on " + ownerDefaultTarget.name);
		}

		// Token: 0x06003A32 RID: 14898 RVA: 0x00153641 File Offset: 0x00151841
		public override void OnExit()
		{
			if (this.button != null)
			{
				this.button.onClick.RemoveListener(new UnityAction(this.DoOnClick));
			}
		}

		// Token: 0x06003A33 RID: 14899 RVA: 0x0015366D File Offset: 0x0015186D
		public void DoOnClick()
		{
			base.Fsm.Event(this.sendEvent);
		}

		// Token: 0x04003D8B RID: 15755
		[RequiredField]
		[CheckForComponent(typeof(Button))]
		[Tooltip("The GameObject with the UGui button component.")]
		public FsmOwnerDefault gameObject;

		// Token: 0x04003D8C RID: 15756
		[Tooltip("Send this event when Clicked.")]
		public FsmEvent sendEvent;

		// Token: 0x04003D8D RID: 15757
		private Button button;
	}
}
