using System;
using UnityEngine;
using UnityEngine.UI;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000AAE RID: 2734
	[ActionCategory("uGui")]
	[Tooltip("Sets the button normal color value of a UGui button component. With reset on exit option ")]
	public class uGuiSetButtonNormalColor : FsmStateAction
	{
		// Token: 0x06003AD9 RID: 15065 RVA: 0x00154F33 File Offset: 0x00153133
		public override void Reset()
		{
			this.normalColor = null;
			this.resetOnExit = false;
			this.everyFrame = false;
			this.enabled = true;
		}

		// Token: 0x06003ADA RID: 15066 RVA: 0x00154F58 File Offset: 0x00153158
		public override void OnEnter()
		{
			this.Initialize(base.Fsm.GetOwnerDefaultTarget(this.gameObject));
			if (this._Button != null && this.resetOnExit)
			{
				this._OriginalNormalColor = this._Button.colors.normalColor;
			}
			this.DoSetButtonColor();
			if (!this.everyFrame)
			{
				base.Finish();
			}
		}

		// Token: 0x06003ADB RID: 15067 RVA: 0x00154FBF File Offset: 0x001531BF
		public override void OnUpdate()
		{
			this.DoSetButtonColor();
		}

		// Token: 0x06003ADC RID: 15068 RVA: 0x00154FC7 File Offset: 0x001531C7
		public override void OnExit()
		{
			if (this.resetOnExit)
			{
				this.DoSetOldColorValue();
			}
		}

		// Token: 0x06003ADD RID: 15069 RVA: 0x00154FD8 File Offset: 0x001531D8
		private void Initialize(GameObject go)
		{
			if (go == null)
			{
				base.LogError("Missing Button Component!");
				return;
			}
			this._Button = go.GetComponent<Button>();
			if (this._Button == null)
			{
				base.LogError("Missing UI.Button on " + go.name);
				return;
			}
		}

		// Token: 0x06003ADE RID: 15070 RVA: 0x0015502C File Offset: 0x0015322C
		private void DoSetButtonColor()
		{
			if (this._Button != null && this.enabled.Value)
			{
				ColorBlock colors = this._Button.colors;
				colors.normalColor = this.normalColor.Value;
				this._Button.colors = colors;
			}
		}

		// Token: 0x06003ADF RID: 15071 RVA: 0x00155080 File Offset: 0x00153280
		private void DoSetOldColorValue()
		{
			if (this._Button != null && this.enabled.Value)
			{
				ColorBlock colors = this._Button.colors;
				colors.normalColor = this._OriginalNormalColor;
				this._Button.colors = colors;
			}
		}

		// Token: 0x06003AE0 RID: 15072 RVA: 0x001550CD File Offset: 0x001532CD
		public uGuiSetButtonNormalColor()
		{
			this.enabled = true;
			base..ctor();
		}

		// Token: 0x04003E27 RID: 15911
		[RequiredField]
		[CheckForComponent(typeof(Button))]
		[Tooltip("The GameObject with the button ui component.")]
		public FsmOwnerDefault gameObject;

		// Token: 0x04003E28 RID: 15912
		[RequiredField]
		[UIHint(UIHint.TextArea)]
		[Tooltip("The new color of the UGui Button component.")]
		public FsmColor normalColor;

		// Token: 0x04003E29 RID: 15913
		[Tooltip("Reset when exiting this state.")]
		public bool resetOnExit;

		// Token: 0x04003E2A RID: 15914
		[Tooltip("Bypass button to drive the action by bool. Action will not be performed if False")]
		public FsmBool enabled;

		// Token: 0x04003E2B RID: 15915
		[Tooltip("Runs everyframe. Useful to animate values over time.")]
		public bool everyFrame;

		// Token: 0x04003E2C RID: 15916
		private Button _Button;

		// Token: 0x04003E2D RID: 15917
		private Color _OriginalNormalColor;
	}
}
