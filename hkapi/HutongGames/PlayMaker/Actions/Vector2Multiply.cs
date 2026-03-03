using System;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000D12 RID: 3346
	[ActionCategory(ActionCategory.Vector3)]
	[Tooltip("Multiplies a Vector2 variable by a Float.")]
	public class Vector2Multiply : FsmStateAction
	{
		// Token: 0x06004564 RID: 17764 RVA: 0x00178F3A File Offset: 0x0017713A
		public override void Reset()
		{
			this.vector2Variable = null;
			this.multiplyBy = 1f;
			this.everyFrame = false;
		}

		// Token: 0x06004565 RID: 17765 RVA: 0x00178F5A File Offset: 0x0017715A
		public override void OnEnter()
		{
			this.vector2Variable.Value = this.vector2Variable.Value * this.multiplyBy.Value;
			if (!this.everyFrame)
			{
				base.Finish();
			}
		}

		// Token: 0x06004566 RID: 17766 RVA: 0x00178F90 File Offset: 0x00177190
		public override void OnUpdate()
		{
			this.vector2Variable.Value = this.vector2Variable.Value * this.multiplyBy.Value;
		}

		// Token: 0x040049C8 RID: 18888
		[RequiredField]
		[UIHint(UIHint.Variable)]
		public FsmVector2 vector2Variable;

		// Token: 0x040049C9 RID: 18889
		[RequiredField]
		public FsmFloat multiplyBy;

		// Token: 0x040049CA RID: 18890
		public bool everyFrame;
	}
}
