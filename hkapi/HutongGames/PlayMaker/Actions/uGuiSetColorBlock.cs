using System;
using UnityEngine;
using UnityEngine.UI;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000A89 RID: 2697
	[ActionCategory("uGui")]
	[Tooltip("Sets the Color Block of a Selectable Ugui component. Modifications will not be visible if transition is not ColorTint")]
	public class uGuiSetColorBlock : FsmStateAction
	{
		// Token: 0x06003A1C RID: 14876 RVA: 0x00153080 File Offset: 0x00151280
		public override void Reset()
		{
			this.gameObject = null;
			this.fadeDuration = new FsmFloat
			{
				UseVariable = true
			};
			this.colorMultiplier = new FsmFloat
			{
				UseVariable = true
			};
			this.normalColor = new FsmColor
			{
				UseVariable = true
			};
			this.highlightedColor = new FsmColor
			{
				UseVariable = true
			};
			this.pressedColor = new FsmColor
			{
				UseVariable = true
			};
			this.disabledColor = new FsmColor
			{
				UseVariable = true
			};
			this.resetOnExit = null;
			this.everyFrame = false;
		}

		// Token: 0x06003A1D RID: 14877 RVA: 0x00153110 File Offset: 0x00151310
		public override void OnEnter()
		{
			GameObject ownerDefaultTarget = base.Fsm.GetOwnerDefaultTarget(this.gameObject);
			if (ownerDefaultTarget != null)
			{
				this._selectable = ownerDefaultTarget.GetComponent<Selectable>();
			}
			if (this._selectable != null && this.resetOnExit.Value)
			{
				this._originalColorBlock = this._selectable.colors;
			}
			this.DoSetValue();
			if (!this.everyFrame)
			{
				base.Finish();
			}
		}

		// Token: 0x06003A1E RID: 14878 RVA: 0x00153184 File Offset: 0x00151384
		public override void OnUpdate()
		{
			this.DoSetValue();
		}

		// Token: 0x06003A1F RID: 14879 RVA: 0x0015318C File Offset: 0x0015138C
		private void DoSetValue()
		{
			if (this._selectable == null)
			{
				return;
			}
			this._colorBlock = this._selectable.colors;
			if (!this.colorMultiplier.IsNone)
			{
				this._colorBlock.colorMultiplier = this.colorMultiplier.Value;
			}
			if (!this.fadeDuration.IsNone)
			{
				this._colorBlock.fadeDuration = this.fadeDuration.Value;
			}
			if (!this.normalColor.IsNone)
			{
				this._colorBlock.normalColor = this.normalColor.Value;
			}
			if (!this.pressedColor.IsNone)
			{
				this._colorBlock.pressedColor = this.pressedColor.Value;
			}
			if (!this.highlightedColor.IsNone)
			{
				this._colorBlock.highlightedColor = this.highlightedColor.Value;
			}
			if (!this.disabledColor.IsNone)
			{
				this._colorBlock.disabledColor = this.disabledColor.Value;
			}
			this._selectable.colors = this._colorBlock;
		}

		// Token: 0x06003A20 RID: 14880 RVA: 0x0015329C File Offset: 0x0015149C
		public override void OnExit()
		{
			if (this._selectable == null)
			{
				return;
			}
			if (this.resetOnExit.Value)
			{
				this._selectable.colors = this._originalColorBlock;
			}
		}

		// Token: 0x04003D6D RID: 15725
		[RequiredField]
		[CheckForComponent(typeof(Selectable))]
		[Tooltip("The GameObject with the Selectable ui component.")]
		public FsmOwnerDefault gameObject;

		// Token: 0x04003D6E RID: 15726
		[Tooltip("The fade duration value. Leave to none for no effect")]
		public FsmFloat fadeDuration;

		// Token: 0x04003D6F RID: 15727
		[Tooltip("The color multiplier value. Leave to none for no effect")]
		public FsmFloat colorMultiplier;

		// Token: 0x04003D70 RID: 15728
		[Tooltip("The normal color value. Leave to none for no effect")]
		public FsmColor normalColor;

		// Token: 0x04003D71 RID: 15729
		[Tooltip("The pressed color value. Leave to none for no effect")]
		public FsmColor pressedColor;

		// Token: 0x04003D72 RID: 15730
		[Tooltip("The highlighted color value. Leave to none for no effect")]
		public FsmColor highlightedColor;

		// Token: 0x04003D73 RID: 15731
		[Tooltip("The disabled color value. Leave to none for no effect")]
		public FsmColor disabledColor;

		// Token: 0x04003D74 RID: 15732
		[Tooltip("Reset when exiting this state.")]
		public FsmBool resetOnExit;

		// Token: 0x04003D75 RID: 15733
		[Tooltip("Repeats every frame, useful for animation")]
		public bool everyFrame;

		// Token: 0x04003D76 RID: 15734
		private Selectable _selectable;

		// Token: 0x04003D77 RID: 15735
		private ColorBlock _colorBlock;

		// Token: 0x04003D78 RID: 15736
		private ColorBlock _originalColorBlock;
	}
}
