using System;
using UnityEngine;
using UnityEngine.UI;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000A8E RID: 2702
	[ActionCategory("uGui")]
	[Tooltip("Gets the color of a UGui graphic component.")]
	public class uGuiGraphicGetColor : FsmStateAction
	{
		// Token: 0x06003A35 RID: 14901 RVA: 0x00153680 File Offset: 0x00151880
		public override void Reset()
		{
			this.gameObject = null;
			this.color = null;
		}

		// Token: 0x06003A36 RID: 14902 RVA: 0x00153690 File Offset: 0x00151890
		public override void OnEnter()
		{
			GameObject ownerDefaultTarget = base.Fsm.GetOwnerDefaultTarget(this.gameObject);
			if (ownerDefaultTarget != null)
			{
				this._component = ownerDefaultTarget.GetComponent<Graphic>();
			}
			this.DoGetColorValue();
			if (!this.everyFrame)
			{
				base.Finish();
			}
		}

		// Token: 0x06003A37 RID: 14903 RVA: 0x001536D8 File Offset: 0x001518D8
		public override void OnUpdate()
		{
			this.DoGetColorValue();
		}

		// Token: 0x06003A38 RID: 14904 RVA: 0x001536E0 File Offset: 0x001518E0
		private void DoGetColorValue()
		{
			if (this._component != null)
			{
				this.color.Value = this._component.color;
			}
		}

		// Token: 0x04003D8E RID: 15758
		[RequiredField]
		[CheckForComponent(typeof(Graphic))]
		[Tooltip("The GameObject with the ui component.")]
		public FsmOwnerDefault gameObject;

		// Token: 0x04003D8F RID: 15759
		[RequiredField]
		[UIHint(UIHint.Variable)]
		[Tooltip("The Color of the UI component")]
		public FsmColor color;

		// Token: 0x04003D90 RID: 15760
		[Tooltip("Repeats every frame")]
		public bool everyFrame;

		// Token: 0x04003D91 RID: 15761
		private Graphic _component;
	}
}
