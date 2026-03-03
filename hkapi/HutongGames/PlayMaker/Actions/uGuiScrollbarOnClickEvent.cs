using System;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000AA9 RID: 2729
	[ActionCategory("uGui")]
	[Tooltip("Fires an event on value changed for a UGui Scrollbar component. Event float data will feature the slider value")]
	public class uGuiScrollbarOnClickEvent : FsmStateAction
	{
		// Token: 0x06003ABD RID: 15037 RVA: 0x00154AE6 File Offset: 0x00152CE6
		public override void Reset()
		{
			this.gameObject = null;
			this.sendEvent = null;
		}

		// Token: 0x06003ABE RID: 15038 RVA: 0x00154AF8 File Offset: 0x00152CF8
		public override void OnEnter()
		{
			GameObject ownerDefaultTarget = base.Fsm.GetOwnerDefaultTarget(this.gameObject);
			if (!(ownerDefaultTarget != null))
			{
				base.LogError("Missing GameObject");
				return;
			}
			this._scrollbar = ownerDefaultTarget.GetComponent<Scrollbar>();
			if (this._scrollbar != null)
			{
				this._scrollbar.onValueChanged.AddListener(new UnityAction<float>(this.DoOnValueChanged));
				return;
			}
			base.LogError("Missing UI.Scrollbar on " + ownerDefaultTarget.name);
		}

		// Token: 0x06003ABF RID: 15039 RVA: 0x00154B79 File Offset: 0x00152D79
		public override void OnExit()
		{
			if (this._scrollbar != null)
			{
				this._scrollbar.onValueChanged.RemoveListener(new UnityAction<float>(this.DoOnValueChanged));
			}
		}

		// Token: 0x06003AC0 RID: 15040 RVA: 0x00154BA5 File Offset: 0x00152DA5
		public void DoOnValueChanged(float value)
		{
			Fsm.EventData.FloatData = value;
			base.Fsm.Event(this.sendEvent);
		}

		// Token: 0x04003E0D RID: 15885
		[RequiredField]
		[CheckForComponent(typeof(Scrollbar))]
		[Tooltip("The GameObject with the Scrollbar ui component.")]
		public FsmOwnerDefault gameObject;

		// Token: 0x04003E0E RID: 15886
		[Tooltip("Send this event when Clicked.")]
		public FsmEvent sendEvent;

		// Token: 0x04003E0F RID: 15887
		private Scrollbar _scrollbar;
	}
}
