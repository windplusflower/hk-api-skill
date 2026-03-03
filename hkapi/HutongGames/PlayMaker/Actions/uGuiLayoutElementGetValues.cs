using System;
using UnityEngine;
using UnityEngine.UI;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000A80 RID: 2688
	[ActionCategory("uGui")]
	[Tooltip("Gets various values of a UGui Layout Element component.")]
	public class uGuiLayoutElementGetValues : FsmStateAction
	{
		// Token: 0x060039F1 RID: 14833 RVA: 0x001520F4 File Offset: 0x001502F4
		public override void Reset()
		{
			this.gameObject = null;
			this.ignoreLayout = null;
			this.minWidthEnabled = null;
			this.minHeightEnabled = null;
			this.preferredWidthEnabled = null;
			this.preferredHeightEnabled = null;
			this.flexibleWidthEnabled = null;
			this.flexibleHeightEnabled = null;
			this.minWidth = null;
			this.minHeight = null;
			this.preferredWidth = null;
			this.preferredHeight = null;
			this.flexibleWidth = null;
			this.flexibleHeight = null;
		}

		// Token: 0x060039F2 RID: 14834 RVA: 0x00152164 File Offset: 0x00150364
		public override void OnEnter()
		{
			GameObject ownerDefaultTarget = base.Fsm.GetOwnerDefaultTarget(this.gameObject);
			if (ownerDefaultTarget != null)
			{
				this._layoutElement = ownerDefaultTarget.GetComponent<LayoutElement>();
			}
			this.DoGetValues();
			if (!this.everyFrame)
			{
				base.Finish();
			}
		}

		// Token: 0x060039F3 RID: 14835 RVA: 0x001521AC File Offset: 0x001503AC
		public override void OnUpdate()
		{
			this.DoGetValues();
		}

		// Token: 0x060039F4 RID: 14836 RVA: 0x001521B4 File Offset: 0x001503B4
		private void DoGetValues()
		{
			if (this._layoutElement != null)
			{
				if (!this.ignoreLayout.IsNone)
				{
					this.ignoreLayout.Value = this._layoutElement.ignoreLayout;
				}
				if (!this.minWidthEnabled.IsNone)
				{
					this.minWidthEnabled.Value = (this._layoutElement.minWidth == 0f);
				}
				if (!this.minWidth.IsNone)
				{
					this.minWidth.Value = this._layoutElement.minWidth;
				}
				if (!this.minHeightEnabled.IsNone)
				{
					this.minHeightEnabled.Value = (this._layoutElement.minHeight == 0f);
				}
				if (!this.minHeight.IsNone)
				{
					this.minHeight.Value = this._layoutElement.minHeight;
				}
				if (!this.preferredWidthEnabled.IsNone)
				{
					this.preferredWidthEnabled.Value = (this._layoutElement.preferredWidth == 0f);
				}
				if (!this.preferredWidth.IsNone)
				{
					this.preferredWidth.Value = this._layoutElement.preferredWidth;
				}
				if (!this.preferredHeightEnabled.IsNone)
				{
					this.preferredHeightEnabled.Value = (this._layoutElement.preferredHeight == 0f);
				}
				if (!this.preferredHeight.IsNone)
				{
					this.preferredHeight.Value = this._layoutElement.preferredHeight;
				}
				if (!this.flexibleWidthEnabled.IsNone)
				{
					this.flexibleWidthEnabled.Value = (this._layoutElement.flexibleWidth == 0f);
				}
				if (!this.flexibleWidth.IsNone)
				{
					this.flexibleWidth.Value = this._layoutElement.flexibleWidth;
				}
				if (!this.flexibleHeightEnabled.IsNone)
				{
					this.flexibleHeightEnabled.Value = (this._layoutElement.flexibleHeight == 0f);
				}
				if (!this.flexibleHeight.IsNone)
				{
					this.flexibleHeight.Value = this._layoutElement.flexibleHeight;
				}
			}
		}

		// Token: 0x04003D1E RID: 15646
		[RequiredField]
		[CheckForComponent(typeof(LayoutElement))]
		[Tooltip("The GameObject with the Layout Element component.")]
		public FsmOwnerDefault gameObject;

		// Token: 0x04003D1F RID: 15647
		[ActionSection("Values")]
		[Tooltip("Is this element use Layout constraints")]
		[UIHint(UIHint.Variable)]
		public FsmBool ignoreLayout;

		// Token: 0x04003D20 RID: 15648
		[Tooltip("The minimum width enabled state")]
		[UIHint(UIHint.Variable)]
		public FsmBool minWidthEnabled;

		// Token: 0x04003D21 RID: 15649
		[Tooltip("The minimum width this layout element should have.")]
		[UIHint(UIHint.Variable)]
		public FsmFloat minWidth;

		// Token: 0x04003D22 RID: 15650
		[Tooltip("The minimum height enabled state")]
		[UIHint(UIHint.Variable)]
		public FsmBool minHeightEnabled;

		// Token: 0x04003D23 RID: 15651
		[Tooltip("The minimum height this layout element should have.")]
		[UIHint(UIHint.Variable)]
		public FsmFloat minHeight;

		// Token: 0x04003D24 RID: 15652
		[Tooltip("The preferred width enabled state")]
		[UIHint(UIHint.Variable)]
		public FsmBool preferredWidthEnabled;

		// Token: 0x04003D25 RID: 15653
		[Tooltip("The preferred width this layout element should have before additional available width is allocated.")]
		[UIHint(UIHint.Variable)]
		public FsmFloat preferredWidth;

		// Token: 0x04003D26 RID: 15654
		[Tooltip("The preferred height enabled state")]
		[UIHint(UIHint.Variable)]
		public FsmBool preferredHeightEnabled;

		// Token: 0x04003D27 RID: 15655
		[Tooltip("The preferred height this layout element should have before additional available height is allocated.")]
		[UIHint(UIHint.Variable)]
		public FsmFloat preferredHeight;

		// Token: 0x04003D28 RID: 15656
		[Tooltip("The flexible width enabled state")]
		[UIHint(UIHint.Variable)]
		public FsmBool flexibleWidthEnabled;

		// Token: 0x04003D29 RID: 15657
		[Tooltip("The relative amount of additional available width this layout element should fill out relative to its siblings.")]
		[UIHint(UIHint.Variable)]
		public FsmFloat flexibleWidth;

		// Token: 0x04003D2A RID: 15658
		[Tooltip("The flexible height enabled state")]
		[UIHint(UIHint.Variable)]
		public FsmBool flexibleHeightEnabled;

		// Token: 0x04003D2B RID: 15659
		[Tooltip("The relative amount of additional available height this layout element should fill out relative to its siblings.")]
		[UIHint(UIHint.Variable)]
		public FsmFloat flexibleHeight;

		// Token: 0x04003D2C RID: 15660
		[ActionSection("Options")]
		[Tooltip("Repeats every frame")]
		public bool everyFrame;

		// Token: 0x04003D2D RID: 15661
		private LayoutElement _layoutElement;
	}
}
