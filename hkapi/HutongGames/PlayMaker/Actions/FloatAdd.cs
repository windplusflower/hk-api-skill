using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000B88 RID: 2952
	[ActionCategory(ActionCategory.Math)]
	[Tooltip("Adds a value to a Float Variable.")]
	public class FloatAdd : FsmStateAction
	{
		// Token: 0x06003EB5 RID: 16053 RVA: 0x00165098 File Offset: 0x00163298
		public override void Reset()
		{
			this.floatVariable = null;
			this.add = null;
			this.everyFrame = false;
			this.perSecond = false;
		}

		// Token: 0x06003EB6 RID: 16054 RVA: 0x001650B6 File Offset: 0x001632B6
		public override void OnEnter()
		{
			this.DoFloatAdd();
			if (!this.everyFrame)
			{
				base.Finish();
			}
		}

		// Token: 0x06003EB7 RID: 16055 RVA: 0x001650CC File Offset: 0x001632CC
		public override void OnUpdate()
		{
			this.DoFloatAdd();
		}

		// Token: 0x06003EB8 RID: 16056 RVA: 0x001650D4 File Offset: 0x001632D4
		private void DoFloatAdd()
		{
			if (!this.perSecond)
			{
				this.floatVariable.Value += this.add.Value;
				return;
			}
			this.floatVariable.Value += this.add.Value * Time.deltaTime;
		}

		// Token: 0x040042C2 RID: 17090
		[RequiredField]
		[UIHint(UIHint.Variable)]
		[Tooltip("The Float variable to add to.")]
		public FsmFloat floatVariable;

		// Token: 0x040042C3 RID: 17091
		[RequiredField]
		[Tooltip("Amount to add.")]
		public FsmFloat add;

		// Token: 0x040042C4 RID: 17092
		[Tooltip("Repeat every frame while the state is active.")]
		public bool everyFrame;

		// Token: 0x040042C5 RID: 17093
		[Tooltip("Used with Every Frame. Adds the value over one second to make the operation frame rate independent.")]
		public bool perSecond;
	}
}
