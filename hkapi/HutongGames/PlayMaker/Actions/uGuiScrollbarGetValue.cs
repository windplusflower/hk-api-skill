using System;
using UnityEngine;
using UnityEngine.UI;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000AA8 RID: 2728
	[ActionCategory("uGui")]
	[Tooltip("Gets the value of a UGui Scrollbar component.")]
	public class uGuiScrollbarGetValue : FsmStateAction
	{
		// Token: 0x06003AB8 RID: 15032 RVA: 0x00154A59 File Offset: 0x00152C59
		public override void Reset()
		{
			this.gameObject = null;
			this.value = null;
			this.everyFrame = false;
		}

		// Token: 0x06003AB9 RID: 15033 RVA: 0x00154A70 File Offset: 0x00152C70
		public override void OnEnter()
		{
			GameObject ownerDefaultTarget = base.Fsm.GetOwnerDefaultTarget(this.gameObject);
			if (ownerDefaultTarget != null)
			{
				this._scrollbar = ownerDefaultTarget.GetComponent<Scrollbar>();
			}
			this.DoGetValue();
			if (!this.everyFrame)
			{
				base.Finish();
			}
		}

		// Token: 0x06003ABA RID: 15034 RVA: 0x00154AB8 File Offset: 0x00152CB8
		public override void OnUpdate()
		{
			this.DoGetValue();
		}

		// Token: 0x06003ABB RID: 15035 RVA: 0x00154AC0 File Offset: 0x00152CC0
		private void DoGetValue()
		{
			if (this._scrollbar != null)
			{
				this.value.Value = this._scrollbar.value;
			}
		}

		// Token: 0x04003E09 RID: 15881
		[RequiredField]
		[CheckForComponent(typeof(Scrollbar))]
		[Tooltip("The GameObject with the Scrollbar UGui component.")]
		public FsmOwnerDefault gameObject;

		// Token: 0x04003E0A RID: 15882
		[RequiredField]
		[UIHint(UIHint.Variable)]
		[Tooltip("The value of the UGui Scrollbar component.")]
		public FsmFloat value;

		// Token: 0x04003E0B RID: 15883
		[Tooltip("Repeats every frame")]
		public bool everyFrame;

		// Token: 0x04003E0C RID: 15884
		private Scrollbar _scrollbar;
	}
}
