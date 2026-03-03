using System;
using UnityEngine;
using UnityEngine.UI;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000A87 RID: 2695
	[ActionCategory("uGui")]
	[Tooltip("Sets the navigation mode of a Selectable Ugui component.")]
	public class uGuiNavigationSetMode : FsmStateAction
	{
		// Token: 0x06003A12 RID: 14866 RVA: 0x00152D76 File Offset: 0x00150F76
		public override void Reset()
		{
			this.gameObject = null;
			this.navigationMode = Navigation.Mode.Automatic;
			this.resetOnExit = false;
		}

		// Token: 0x06003A13 RID: 14867 RVA: 0x00152D94 File Offset: 0x00150F94
		public override void OnEnter()
		{
			GameObject ownerDefaultTarget = base.Fsm.GetOwnerDefaultTarget(this.gameObject);
			if (ownerDefaultTarget != null)
			{
				this._selectable = ownerDefaultTarget.GetComponent<Selectable>();
			}
			if (this._selectable != null && this.resetOnExit.Value)
			{
				this._originalValue = this._selectable.navigation.mode;
			}
			this.DoSetValue();
			base.Finish();
		}

		// Token: 0x06003A14 RID: 14868 RVA: 0x00152E08 File Offset: 0x00151008
		private void DoSetValue()
		{
			if (this._selectable != null)
			{
				this._navigation = this._selectable.navigation;
				this._navigation.mode = this.navigationMode;
				this._selectable.navigation = this._navigation;
			}
		}

		// Token: 0x06003A15 RID: 14869 RVA: 0x00152E58 File Offset: 0x00151058
		public override void OnExit()
		{
			if (this._selectable == null)
			{
				return;
			}
			if (this.resetOnExit.Value)
			{
				this._navigation = this._selectable.navigation;
				this._navigation.mode = this._originalValue;
				this._selectable.navigation = this._navigation;
			}
		}

		// Token: 0x04003D5E RID: 15710
		[RequiredField]
		[CheckForComponent(typeof(Selectable))]
		[Tooltip("The GameObject with the Selectable ui component.")]
		public FsmOwnerDefault gameObject;

		// Token: 0x04003D5F RID: 15711
		[Tooltip("The navigation mode value")]
		public Navigation.Mode navigationMode;

		// Token: 0x04003D60 RID: 15712
		[Tooltip("Reset when exiting this state.")]
		public FsmBool resetOnExit;

		// Token: 0x04003D61 RID: 15713
		private Selectable _selectable;

		// Token: 0x04003D62 RID: 15714
		private Navigation _navigation;

		// Token: 0x04003D63 RID: 15715
		private Navigation.Mode _originalValue;
	}
}
