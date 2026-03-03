using System;
using UnityEngine;
using UnityEngine.UI;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000A9E RID: 2718
	[ActionCategory("uGui")]
	[Tooltip("Rebuild a UGui InputField component.")]
	public class uGuiInputFieldScreenToLocal : FsmStateAction
	{
		// Token: 0x06003A81 RID: 14977 RVA: 0x001541FF File Offset: 0x001523FF
		public override void Reset()
		{
			this.gameObject = null;
			this.screen = null;
			this.local = null;
			this.everyFrame = false;
		}

		// Token: 0x06003A82 RID: 14978 RVA: 0x00154220 File Offset: 0x00152420
		public override void OnEnter()
		{
			GameObject ownerDefaultTarget = base.Fsm.GetOwnerDefaultTarget(this.gameObject);
			if (ownerDefaultTarget != null)
			{
				this._inputField = ownerDefaultTarget.GetComponent<InputField>();
			}
			this.DoAction();
			if (!this.everyFrame)
			{
				base.Finish();
			}
		}

		// Token: 0x06003A83 RID: 14979 RVA: 0x00154268 File Offset: 0x00152468
		public override void OnUpdate()
		{
			this.DoAction();
		}

		// Token: 0x06003A84 RID: 14980 RVA: 0x00154270 File Offset: 0x00152470
		private void DoAction()
		{
			if (this._inputField != null)
			{
				this.local.Value = this._inputField.ScreenToLocal(this.screen.Value);
			}
		}

		// Token: 0x04003DD3 RID: 15827
		[RequiredField]
		[CheckForComponent(typeof(InputField))]
		[Tooltip("The GameObject with the InputField ui component.")]
		public FsmOwnerDefault gameObject;

		// Token: 0x04003DD4 RID: 15828
		[RequiredField]
		[UIHint(UIHint.Variable)]
		[Tooltip("The screen position")]
		public FsmVector2 screen;

		// Token: 0x04003DD5 RID: 15829
		[RequiredField]
		[UIHint(UIHint.Variable)]
		[Tooltip("The resulting local position")]
		public FsmVector2 local;

		// Token: 0x04003DD6 RID: 15830
		[Tooltip("Repeats every frame")]
		public bool everyFrame;

		// Token: 0x04003DD7 RID: 15831
		private InputField _inputField;
	}
}
