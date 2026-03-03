using System;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000B89 RID: 2953
	[ActionCategory(ActionCategory.Math)]
	[Tooltip("Adds multipe float variables to float variable.")]
	public class FloatAddMultiple : FsmStateAction
	{
		// Token: 0x06003EBA RID: 16058 RVA: 0x0016512A File Offset: 0x0016332A
		public override void Reset()
		{
			this.floatVariables = null;
			this.addTo = null;
			this.everyFrame = false;
		}

		// Token: 0x06003EBB RID: 16059 RVA: 0x00165141 File Offset: 0x00163341
		public override void OnEnter()
		{
			this.DoFloatAdd();
			if (!this.everyFrame)
			{
				base.Finish();
			}
		}

		// Token: 0x06003EBC RID: 16060 RVA: 0x00165157 File Offset: 0x00163357
		public override void OnUpdate()
		{
			this.DoFloatAdd();
		}

		// Token: 0x06003EBD RID: 16061 RVA: 0x00165160 File Offset: 0x00163360
		private void DoFloatAdd()
		{
			for (int i = 0; i < this.floatVariables.Length; i++)
			{
				this.addTo.Value += this.floatVariables[i].Value;
			}
		}

		// Token: 0x040042C6 RID: 17094
		[UIHint(UIHint.Variable)]
		[Tooltip("The float variables to add.")]
		public FsmFloat[] floatVariables;

		// Token: 0x040042C7 RID: 17095
		[RequiredField]
		[UIHint(UIHint.Variable)]
		[Tooltip("Add to this variable.")]
		public FsmFloat addTo;

		// Token: 0x040042C8 RID: 17096
		[Tooltip("Repeat every frame while the state is active.")]
		public bool everyFrame;
	}
}
