using System;
using UnityEngine;
using UnityEngine.UI;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000A81 RID: 2689
	[ActionCategory("uGui")]
	[Tooltip("Sets various values of a UGui Layout Element component.")]
	public class uGuiLayoutElementSetValues : FsmStateAction
	{
		// Token: 0x060039F6 RID: 14838 RVA: 0x001523C4 File Offset: 0x001505C4
		public override void Reset()
		{
			this.gameObject = null;
			this.minWidth = new FsmFloat
			{
				UseVariable = true
			};
			this.minHeight = new FsmFloat
			{
				UseVariable = true
			};
			this.preferredWidth = new FsmFloat
			{
				UseVariable = true
			};
			this.preferredHeight = new FsmFloat
			{
				UseVariable = true
			};
			this.flexibleWidth = new FsmFloat
			{
				UseVariable = true
			};
			this.flexibleHeight = new FsmFloat
			{
				UseVariable = true
			};
		}

		// Token: 0x060039F7 RID: 14839 RVA: 0x00152444 File Offset: 0x00150644
		public override void OnEnter()
		{
			GameObject ownerDefaultTarget = base.Fsm.GetOwnerDefaultTarget(this.gameObject);
			if (ownerDefaultTarget != null)
			{
				this._layoutElement = ownerDefaultTarget.GetComponent<LayoutElement>();
			}
			this.DoSetValues();
			if (!this.everyFrame)
			{
				base.Finish();
			}
		}

		// Token: 0x060039F8 RID: 14840 RVA: 0x0015248C File Offset: 0x0015068C
		public override void OnUpdate()
		{
			this.DoSetValues();
		}

		// Token: 0x060039F9 RID: 14841 RVA: 0x00152494 File Offset: 0x00150694
		private void DoSetValues()
		{
			if (this._layoutElement != null)
			{
				if (!this.minWidth.IsNone)
				{
					this._layoutElement.minWidth = this.minWidth.Value;
				}
				if (!this.minHeight.IsNone)
				{
					this._layoutElement.minHeight = this.minHeight.Value;
				}
				if (!this.preferredWidth.IsNone)
				{
					this._layoutElement.preferredWidth = this.preferredWidth.Value;
				}
				if (!this.preferredHeight.IsNone)
				{
					this._layoutElement.preferredHeight = this.preferredHeight.Value;
				}
				if (!this.flexibleWidth.IsNone)
				{
					this._layoutElement.flexibleWidth = this.flexibleWidth.Value;
				}
				if (!this.flexibleHeight.IsNone)
				{
					this._layoutElement.flexibleHeight = this.flexibleHeight.Value;
				}
			}
		}

		// Token: 0x04003D2E RID: 15662
		[RequiredField]
		[CheckForComponent(typeof(LayoutElement))]
		[Tooltip("The GameObject with the Layout Element component.")]
		public FsmOwnerDefault gameObject;

		// Token: 0x04003D2F RID: 15663
		[ActionSection("Values")]
		[Tooltip("The minimum width this layout element should have.")]
		public FsmFloat minWidth;

		// Token: 0x04003D30 RID: 15664
		[Tooltip("The minimum height this layout element should have.")]
		public FsmFloat minHeight;

		// Token: 0x04003D31 RID: 15665
		[Tooltip("The preferred width this layout element should have before additional available width is allocated.")]
		public FsmFloat preferredWidth;

		// Token: 0x04003D32 RID: 15666
		[Tooltip("The preferred height this layout element should have before additional available height is allocated.")]
		public FsmFloat preferredHeight;

		// Token: 0x04003D33 RID: 15667
		[Tooltip("The relative amount of additional available width this layout element should fill out relative to its siblings.")]
		public FsmFloat flexibleWidth;

		// Token: 0x04003D34 RID: 15668
		[Tooltip("The relative amount of additional available height this layout element should fill out relative to its siblings.")]
		public FsmFloat flexibleHeight;

		// Token: 0x04003D35 RID: 15669
		[ActionSection("Options")]
		[Tooltip("Repeats every frame")]
		public bool everyFrame;

		// Token: 0x04003D36 RID: 15670
		private LayoutElement _layoutElement;
	}
}
