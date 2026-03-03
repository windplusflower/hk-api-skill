using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000B09 RID: 2825
	[ActionCategory(ActionCategory.AnimateVariables)]
	[Tooltip("Easing Animation - Vector3")]
	public class EaseVector3 : EaseFsmAction
	{
		// Token: 0x06003CAE RID: 15534 RVA: 0x0015E85C File Offset: 0x0015CA5C
		public override void Reset()
		{
			base.Reset();
			this.vector3Variable = null;
			this.fromValue = null;
			this.toValue = null;
			this.finishInNextStep = false;
		}

		// Token: 0x06003CAF RID: 15535 RVA: 0x0015E880 File Offset: 0x0015CA80
		public override void OnEnter()
		{
			base.OnEnter();
			this.fromFloats = new float[3];
			this.fromFloats[0] = this.fromValue.Value.x;
			this.fromFloats[1] = this.fromValue.Value.y;
			this.fromFloats[2] = this.fromValue.Value.z;
			this.toFloats = new float[3];
			this.toFloats[0] = this.toValue.Value.x;
			this.toFloats[1] = this.toValue.Value.y;
			this.toFloats[2] = this.toValue.Value.z;
			this.resultFloats = new float[3];
			this.finishInNextStep = false;
			this.vector3Variable.Value = this.fromValue.Value;
		}

		// Token: 0x06003CB0 RID: 15536 RVA: 0x0015D460 File Offset: 0x0015B660
		public override void OnExit()
		{
			base.OnExit();
		}

		// Token: 0x06003CB1 RID: 15537 RVA: 0x0015E964 File Offset: 0x0015CB64
		public override void OnUpdate()
		{
			base.OnUpdate();
			if (!this.vector3Variable.IsNone && this.isRunning)
			{
				this.vector3Variable.Value = new Vector3(this.resultFloats[0], this.resultFloats[1], this.resultFloats[2]);
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
				if (!this.vector3Variable.IsNone)
				{
					this.vector3Variable.Value = new Vector3(this.reverse.IsNone ? this.toValue.Value.x : (this.reverse.Value ? this.fromValue.Value.x : this.toValue.Value.x), this.reverse.IsNone ? this.toValue.Value.y : (this.reverse.Value ? this.fromValue.Value.y : this.toValue.Value.y), this.reverse.IsNone ? this.toValue.Value.z : (this.reverse.Value ? this.fromValue.Value.z : this.toValue.Value.z));
				}
				this.finishInNextStep = true;
			}
		}

		// Token: 0x040040BB RID: 16571
		[RequiredField]
		public FsmVector3 fromValue;

		// Token: 0x040040BC RID: 16572
		[RequiredField]
		public FsmVector3 toValue;

		// Token: 0x040040BD RID: 16573
		[UIHint(UIHint.Variable)]
		public FsmVector3 vector3Variable;

		// Token: 0x040040BE RID: 16574
		private bool finishInNextStep;
	}
}
