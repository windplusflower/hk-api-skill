using System;
using UnityEngine;
using UnityEngine.UI;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000A82 RID: 2690
	[ActionCategory("uGui")]
	[Tooltip("Gets the explicit navigation properties of a Selectable Ugui component. ")]
	public class uGuiNavigationExplicitGetProperties : FsmStateAction
	{
		// Token: 0x060039FB RID: 14843 RVA: 0x00152584 File Offset: 0x00150784
		public override void Reset()
		{
			this.gameObject = null;
			this.selectOnDown = null;
			this.selectOnUp = null;
			this.selectOnLeft = null;
			this.selectOnRight = null;
		}

		// Token: 0x060039FC RID: 14844 RVA: 0x001525AC File Offset: 0x001507AC
		public override void OnEnter()
		{
			GameObject ownerDefaultTarget = base.Fsm.GetOwnerDefaultTarget(this.gameObject);
			if (ownerDefaultTarget != null)
			{
				this._selectable = ownerDefaultTarget.GetComponent<Selectable>();
			}
			this.DoGetValue();
			base.Finish();
		}

		// Token: 0x060039FD RID: 14845 RVA: 0x001525EC File Offset: 0x001507EC
		private void DoGetValue()
		{
			if (this._selectable != null)
			{
				if (!this.selectOnUp.IsNone)
				{
					this.selectOnUp.Value = ((this._selectable.navigation.selectOnUp == null) ? null : this._selectable.navigation.selectOnUp.gameObject);
				}
				if (!this.selectOnDown.IsNone)
				{
					this.selectOnDown.Value = ((this._selectable.navigation.selectOnDown == null) ? null : this._selectable.navigation.selectOnDown.gameObject);
				}
				if (!this.selectOnLeft.IsNone)
				{
					this.selectOnLeft.Value = ((this._selectable.navigation.selectOnLeft == null) ? null : this._selectable.navigation.selectOnLeft.gameObject);
				}
				if (!this.selectOnRight.IsNone)
				{
					this.selectOnRight.Value = ((this._selectable.navigation.selectOnRight == null) ? null : this._selectable.navigation.selectOnRight.gameObject);
				}
			}
		}

		// Token: 0x04003D37 RID: 15671
		[RequiredField]
		[CheckForComponent(typeof(Selectable))]
		[Tooltip("The GameObject with the Selectable ui component.")]
		public FsmOwnerDefault gameObject;

		// Token: 0x04003D38 RID: 15672
		[Tooltip("The down Selectable.")]
		[UIHint(UIHint.Variable)]
		public FsmGameObject selectOnDown;

		// Token: 0x04003D39 RID: 15673
		[Tooltip("The up Selectable.")]
		[UIHint(UIHint.Variable)]
		public FsmGameObject selectOnUp;

		// Token: 0x04003D3A RID: 15674
		[Tooltip("The left Selectable.")]
		[UIHint(UIHint.Variable)]
		public FsmGameObject selectOnLeft;

		// Token: 0x04003D3B RID: 15675
		[Tooltip("The right Selectable.")]
		[UIHint(UIHint.Variable)]
		public FsmGameObject selectOnRight;

		// Token: 0x04003D3C RID: 15676
		private Selectable _selectable;
	}
}
