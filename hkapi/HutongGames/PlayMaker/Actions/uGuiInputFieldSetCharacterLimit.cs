using System;
using UnityEngine;
using UnityEngine.UI;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000AA1 RID: 2721
	[ActionCategory("uGui")]
	[Tooltip("Sets the maximum number of characters that the user can type into a UGui InputField component. Optionally reset on exit")]
	public class uGuiInputFieldSetCharacterLimit : FsmStateAction
	{
		// Token: 0x06003A92 RID: 14994 RVA: 0x00154490 File Offset: 0x00152690
		public override void Reset()
		{
			this.gameObject = null;
			this.characterLimit = null;
			this.resetOnExit = null;
			this.everyFrame = false;
		}

		// Token: 0x06003A93 RID: 14995 RVA: 0x001544B0 File Offset: 0x001526B0
		public override void OnEnter()
		{
			GameObject ownerDefaultTarget = base.Fsm.GetOwnerDefaultTarget(this.gameObject);
			if (ownerDefaultTarget != null)
			{
				this._inputField = ownerDefaultTarget.GetComponent<InputField>();
			}
			if (this.resetOnExit.Value)
			{
				this._originalValue = this._inputField.characterLimit;
			}
			this.DoSetValue();
			if (!this.everyFrame)
			{
				base.Finish();
			}
		}

		// Token: 0x06003A94 RID: 14996 RVA: 0x00154516 File Offset: 0x00152716
		public override void OnUpdate()
		{
			this.DoSetValue();
		}

		// Token: 0x06003A95 RID: 14997 RVA: 0x0015451E File Offset: 0x0015271E
		private void DoSetValue()
		{
			if (this._inputField != null)
			{
				this._inputField.characterLimit = this.characterLimit.Value;
			}
		}

		// Token: 0x06003A96 RID: 14998 RVA: 0x00154544 File Offset: 0x00152744
		public override void OnExit()
		{
			if (this._inputField == null)
			{
				return;
			}
			if (this.resetOnExit.Value)
			{
				this._inputField.characterLimit = this._originalValue;
			}
		}

		// Token: 0x04003DE4 RID: 15844
		[RequiredField]
		[CheckForComponent(typeof(InputField))]
		[Tooltip("The GameObject with the InputField ui component.")]
		public FsmOwnerDefault gameObject;

		// Token: 0x04003DE5 RID: 15845
		[RequiredField]
		[Tooltip("The maximum number of characters that the user can type into the UGui InputField component. 0 = infinite")]
		public FsmInt characterLimit;

		// Token: 0x04003DE6 RID: 15846
		[Tooltip("Reset when exiting this state.")]
		public FsmBool resetOnExit;

		// Token: 0x04003DE7 RID: 15847
		[Tooltip("Repeats every frame")]
		public bool everyFrame;

		// Token: 0x04003DE8 RID: 15848
		private InputField _inputField;

		// Token: 0x04003DE9 RID: 15849
		private int _originalValue;
	}
}
