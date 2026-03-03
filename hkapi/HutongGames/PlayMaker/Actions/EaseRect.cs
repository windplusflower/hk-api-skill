using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000B08 RID: 2824
	[ActionCategory("AnimateVariables")]
	[Tooltip("Easing Animation - Rect.")]
	public class EaseRect : EaseFsmAction
	{
		// Token: 0x06003CA9 RID: 15529 RVA: 0x0015E4F3 File Offset: 0x0015C6F3
		public override void Reset()
		{
			base.Reset();
			this.rectVariable = null;
			this.fromValue = null;
			this.toValue = null;
			this.finishInNextStep = false;
		}

		// Token: 0x06003CAA RID: 15530 RVA: 0x0015E518 File Offset: 0x0015C718
		public override void OnEnter()
		{
			base.OnEnter();
			this.fromFloats = new float[4];
			this.fromFloats[0] = this.fromValue.Value.x;
			this.fromFloats[1] = this.fromValue.Value.y;
			this.fromFloats[2] = this.fromValue.Value.width;
			this.fromFloats[3] = this.fromValue.Value.height;
			this.toFloats = new float[4];
			this.toFloats[0] = this.toValue.Value.x;
			this.toFloats[1] = this.toValue.Value.y;
			this.toFloats[2] = this.toValue.Value.width;
			this.toFloats[3] = this.toValue.Value.height;
			this.resultFloats = new float[4];
			this.finishInNextStep = false;
			this.rectVariable.Value = this.fromValue.Value;
		}

		// Token: 0x06003CAB RID: 15531 RVA: 0x0015D460 File Offset: 0x0015B660
		public override void OnExit()
		{
			base.OnExit();
		}

		// Token: 0x06003CAC RID: 15532 RVA: 0x0015E644 File Offset: 0x0015C844
		public override void OnUpdate()
		{
			base.OnUpdate();
			if (!this.rectVariable.IsNone && this.isRunning)
			{
				this.rectVariable.Value = new Rect(this.resultFloats[0], this.resultFloats[1], this.resultFloats[2], this.resultFloats[3]);
			}
			if (this.finishInNextStep)
			{
				base.Finish();
				if (this.finishEvent != null)
				{
					base.Fsm.Event(this.finishEvent);
				}
			}
			if (this.finishAction && !this.finishInNextStep)
			{
				if (!this.rectVariable.IsNone)
				{
					this.rectVariable.Value = new Rect(this.reverse.IsNone ? this.toValue.Value.x : (this.reverse.Value ? this.fromValue.Value.x : this.toValue.Value.x), this.reverse.IsNone ? this.toValue.Value.y : (this.reverse.Value ? this.fromValue.Value.y : this.toValue.Value.y), this.reverse.IsNone ? this.toValue.Value.width : (this.reverse.Value ? this.fromValue.Value.width : this.toValue.Value.width), this.reverse.IsNone ? this.toValue.Value.height : (this.reverse.Value ? this.fromValue.Value.height : this.toValue.Value.height));
				}
				this.finishInNextStep = true;
			}
		}

		// Token: 0x040040B7 RID: 16567
		[RequiredField]
		public FsmRect fromValue;

		// Token: 0x040040B8 RID: 16568
		[RequiredField]
		public FsmRect toValue;

		// Token: 0x040040B9 RID: 16569
		[UIHint(UIHint.Variable)]
		public FsmRect rectVariable;

		// Token: 0x040040BA RID: 16570
		private bool finishInNextStep;
	}
}
