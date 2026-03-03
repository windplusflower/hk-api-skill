using System;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000AB3 RID: 2739
	[ActionCategory("uGui")]
	[Tooltip("Fires an event on value changed for a UGui Slider component. Event float data will feature the slider value")]
	public class uGuiSliderOnClickEvent : FsmStateAction
	{
		// Token: 0x06003AF3 RID: 15091 RVA: 0x0015536B File Offset: 0x0015356B
		public override void Reset()
		{
			this.gameObject = null;
			this.sendEvent = null;
		}

		// Token: 0x06003AF4 RID: 15092 RVA: 0x0015537C File Offset: 0x0015357C
		public override void OnEnter()
		{
			GameObject ownerDefaultTarget = base.Fsm.GetOwnerDefaultTarget(this.gameObject);
			if (!(ownerDefaultTarget != null))
			{
				base.LogError("Missing GameObject");
				return;
			}
			this._slider = ownerDefaultTarget.GetComponent<Slider>();
			if (this._slider != null)
			{
				this._slider.onValueChanged.AddListener(new UnityAction<float>(this.DoOnValueChanged));
				return;
			}
			base.LogError("Missing UI.Slider on " + ownerDefaultTarget.name);
		}

		// Token: 0x06003AF5 RID: 15093 RVA: 0x001553FD File Offset: 0x001535FD
		public override void OnExit()
		{
			if (this._slider != null)
			{
				this._slider.onValueChanged.RemoveListener(new UnityAction<float>(this.DoOnValueChanged));
			}
		}

		// Token: 0x06003AF6 RID: 15094 RVA: 0x00155429 File Offset: 0x00153629
		public void DoOnValueChanged(float value)
		{
			Fsm.EventData.FloatData = value;
			base.Fsm.Event(this.sendEvent);
		}

		// Token: 0x04003E3F RID: 15935
		[RequiredField]
		[CheckForComponent(typeof(Slider))]
		[Tooltip("The GameObject with the Slider ui component.")]
		public FsmOwnerDefault gameObject;

		// Token: 0x04003E40 RID: 15936
		[Tooltip("Send this event when Clicked.")]
		public FsmEvent sendEvent;

		// Token: 0x04003E41 RID: 15937
		private Slider _slider;
	}
}
