using System;
using UnityEngine;
using UnityEngine.UI;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000A84 RID: 2692
	[ActionCategory("uGui")]
	[Tooltip("Gets the Color Block of a Selectable Ugui component.")]
	public class uGuiGetColorBlock : FsmStateAction
	{
		// Token: 0x06003A05 RID: 14853 RVA: 0x001529BC File Offset: 0x00150BBC
		public override void Reset()
		{
			this.gameObject = null;
			this.fadeDuration = null;
			this.colorMultiplier = null;
			this.normalColor = null;
			this.highlightedColor = null;
			this.pressedColor = null;
			this.disabledColor = null;
			this.everyFrame = false;
		}

		// Token: 0x06003A06 RID: 14854 RVA: 0x001529F8 File Offset: 0x00150BF8
		public override void OnEnter()
		{
			GameObject ownerDefaultTarget = base.Fsm.GetOwnerDefaultTarget(this.gameObject);
			if (ownerDefaultTarget != null)
			{
				this._selectable = ownerDefaultTarget.GetComponent<Selectable>();
			}
			this.DoGetValue();
			if (!this.everyFrame)
			{
				base.Finish();
			}
		}

		// Token: 0x06003A07 RID: 14855 RVA: 0x00152A40 File Offset: 0x00150C40
		public override void OnUpdate()
		{
			this.DoGetValue();
		}

		// Token: 0x06003A08 RID: 14856 RVA: 0x00152A48 File Offset: 0x00150C48
		private void DoGetValue()
		{
			if (this._selectable == null)
			{
				return;
			}
			if (!this.colorMultiplier.IsNone)
			{
				this.colorMultiplier.Value = this._selectable.colors.colorMultiplier;
			}
			if (!this.fadeDuration.IsNone)
			{
				this.fadeDuration.Value = this._selectable.colors.fadeDuration;
			}
			if (!this.normalColor.IsNone)
			{
				this.normalColor.Value = this._selectable.colors.normalColor;
			}
			if (!this.pressedColor.IsNone)
			{
				this.pressedColor.Value = this._selectable.colors.pressedColor;
			}
			if (!this.highlightedColor.IsNone)
			{
				this.highlightedColor.Value = this._selectable.colors.highlightedColor;
			}
			if (!this.disabledColor.IsNone)
			{
				this.disabledColor.Value = this._selectable.colors.disabledColor;
			}
		}

		// Token: 0x04003D46 RID: 15686
		[RequiredField]
		[CheckForComponent(typeof(Selectable))]
		[Tooltip("The GameObject with the Selectable ui component.")]
		public FsmOwnerDefault gameObject;

		// Token: 0x04003D47 RID: 15687
		[Tooltip("The fade duration value. Leave to none for no effect")]
		[UIHint(UIHint.Variable)]
		public FsmFloat fadeDuration;

		// Token: 0x04003D48 RID: 15688
		[Tooltip("The color multiplier value. Leave to none for no effect")]
		[UIHint(UIHint.Variable)]
		public FsmFloat colorMultiplier;

		// Token: 0x04003D49 RID: 15689
		[Tooltip("The normal color value. Leave to none for no effect")]
		[UIHint(UIHint.Variable)]
		public FsmColor normalColor;

		// Token: 0x04003D4A RID: 15690
		[Tooltip("The pressed color value. Leave to none for no effect")]
		[UIHint(UIHint.Variable)]
		public FsmColor pressedColor;

		// Token: 0x04003D4B RID: 15691
		[Tooltip("The highlighted color value. Leave to none for no effect")]
		[UIHint(UIHint.Variable)]
		public FsmColor highlightedColor;

		// Token: 0x04003D4C RID: 15692
		[Tooltip("The disabled color value. Leave to none for no effect")]
		[UIHint(UIHint.Variable)]
		public FsmColor disabledColor;

		// Token: 0x04003D4D RID: 15693
		[Tooltip("Repeats every frame, useful for animation")]
		public bool everyFrame;

		// Token: 0x04003D4E RID: 15694
		private Selectable _selectable;
	}
}
