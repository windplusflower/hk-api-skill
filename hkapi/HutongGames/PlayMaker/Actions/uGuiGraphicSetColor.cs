using System;
using UnityEngine;
using UnityEngine.UI;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000A8F RID: 2703
	[ActionCategory("uGui")]
	[Tooltip("Set Graphic Color.")]
	public class uGuiGraphicSetColor : FsmStateAction
	{
		// Token: 0x06003A3A RID: 14906 RVA: 0x00153708 File Offset: 0x00151908
		public override void Reset()
		{
			this.gameObject = null;
			this.color = null;
			this.red = new FsmFloat
			{
				UseVariable = true
			};
			this.green = new FsmFloat
			{
				UseVariable = true
			};
			this.blue = new FsmFloat
			{
				UseVariable = true
			};
			this.alpha = new FsmFloat
			{
				UseVariable = true
			};
			this.resetOnExit = null;
			this.everyFrame = false;
		}

		// Token: 0x06003A3B RID: 14907 RVA: 0x0015377C File Offset: 0x0015197C
		public override void OnEnter()
		{
			GameObject ownerDefaultTarget = base.Fsm.GetOwnerDefaultTarget(this.gameObject);
			if (ownerDefaultTarget != null)
			{
				this._component = ownerDefaultTarget.GetComponent<Graphic>();
			}
			if (this.resetOnExit.Value)
			{
				this._originalColor = this._component.color;
			}
			this.DoSetColorValue();
			if (!this.everyFrame)
			{
				base.Finish();
			}
		}

		// Token: 0x06003A3C RID: 14908 RVA: 0x001537E2 File Offset: 0x001519E2
		public override void OnUpdate()
		{
			this.DoSetColorValue();
		}

		// Token: 0x06003A3D RID: 14909 RVA: 0x001537EC File Offset: 0x001519EC
		private void DoSetColorValue()
		{
			if (this._component != null)
			{
				Color value = this._component.color;
				if (!this.color.IsNone)
				{
					value = this.color.Value;
				}
				if (!this.red.IsNone)
				{
					value.r = this.red.Value;
				}
				if (!this.green.IsNone)
				{
					value.g = this.green.Value;
				}
				if (!this.blue.IsNone)
				{
					value.b = this.blue.Value;
				}
				if (!this.alpha.IsNone)
				{
					value.a = this.alpha.Value;
				}
				this._component.color = value;
			}
		}

		// Token: 0x06003A3E RID: 14910 RVA: 0x001538B7 File Offset: 0x00151AB7
		public override void OnExit()
		{
			if (this._component == null)
			{
				return;
			}
			if (this.resetOnExit.Value)
			{
				this._component.color = this._originalColor;
			}
		}

		// Token: 0x04003D92 RID: 15762
		[RequiredField]
		[CheckForComponent(typeof(Graphic))]
		[Tooltip("The GameObject with an Unity UI component.")]
		public FsmOwnerDefault gameObject;

		// Token: 0x04003D93 RID: 15763
		[Tooltip("The Color of the UI component. Leave to none and set the individual color values, for example to affect just the alpha channel")]
		public FsmColor color;

		// Token: 0x04003D94 RID: 15764
		[Tooltip("The red channel Color of the UI component. Leave to none for no effect, else it overrides the color property")]
		public FsmFloat red;

		// Token: 0x04003D95 RID: 15765
		[Tooltip("The green channel Color of the UI component. Leave to none for no effect, else it overrides the color property")]
		public FsmFloat green;

		// Token: 0x04003D96 RID: 15766
		[Tooltip("The blue channel Color of the UI component. Leave to none for no effect, else it overrides the color property")]
		public FsmFloat blue;

		// Token: 0x04003D97 RID: 15767
		[Tooltip("The alpha channel Color of the UI component. Leave to none for no effect, else it overrides the color property")]
		public FsmFloat alpha;

		// Token: 0x04003D98 RID: 15768
		[Tooltip("Reset when exiting this state.")]
		public FsmBool resetOnExit;

		// Token: 0x04003D99 RID: 15769
		[Tooltip("Repeats every frame, useful for animation")]
		public bool everyFrame;

		// Token: 0x04003D9A RID: 15770
		private Graphic _component;

		// Token: 0x04003D9B RID: 15771
		private Color _originalColor;
	}
}
