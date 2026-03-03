using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000D1D RID: 3357
	[ActionCategory(ActionCategory.Vector3)]
	[Tooltip("Performs most possible operations on 2 Vector3: Dot product, Cross product, Distance, Angle, Project, Reflect, Add, Subtract, Multiply, Divide, Min, Max")]
	public class Vector3Operator : FsmStateAction
	{
		// Token: 0x06004594 RID: 17812 RVA: 0x001797DF File Offset: 0x001779DF
		public override void Reset()
		{
			this.vector1 = null;
			this.vector2 = null;
			this.operation = Vector3Operator.Vector3Operation.Add;
			this.storeVector3Result = null;
			this.storeFloatResult = null;
			this.everyFrame = false;
		}

		// Token: 0x06004595 RID: 17813 RVA: 0x0017980B File Offset: 0x00177A0B
		public override void OnEnter()
		{
			this.DoVector3Operator();
			if (!this.everyFrame)
			{
				base.Finish();
			}
		}

		// Token: 0x06004596 RID: 17814 RVA: 0x00179821 File Offset: 0x00177A21
		public override void OnUpdate()
		{
			this.DoVector3Operator();
		}

		// Token: 0x06004597 RID: 17815 RVA: 0x0017982C File Offset: 0x00177A2C
		private void DoVector3Operator()
		{
			Vector3 value = this.vector1.Value;
			Vector3 value2 = this.vector2.Value;
			switch (this.operation)
			{
			case Vector3Operator.Vector3Operation.DotProduct:
				this.storeFloatResult.Value = Vector3.Dot(value, value2);
				return;
			case Vector3Operator.Vector3Operation.CrossProduct:
				this.storeVector3Result.Value = Vector3.Cross(value, value2);
				return;
			case Vector3Operator.Vector3Operation.Distance:
				this.storeFloatResult.Value = Vector3.Distance(value, value2);
				return;
			case Vector3Operator.Vector3Operation.Angle:
				this.storeFloatResult.Value = Vector3.Angle(value, value2);
				return;
			case Vector3Operator.Vector3Operation.Project:
				this.storeVector3Result.Value = Vector3.Project(value, value2);
				return;
			case Vector3Operator.Vector3Operation.Reflect:
				this.storeVector3Result.Value = Vector3.Reflect(value, value2);
				return;
			case Vector3Operator.Vector3Operation.Add:
				this.storeVector3Result.Value = value + value2;
				return;
			case Vector3Operator.Vector3Operation.Subtract:
				this.storeVector3Result.Value = value - value2;
				return;
			case Vector3Operator.Vector3Operation.Multiply:
			{
				Vector3 zero = Vector3.zero;
				zero.x = value.x * value2.x;
				zero.y = value.y * value2.y;
				zero.z = value.z * value2.z;
				this.storeVector3Result.Value = zero;
				return;
			}
			case Vector3Operator.Vector3Operation.Divide:
			{
				Vector3 zero2 = Vector3.zero;
				zero2.x = value.x / value2.x;
				zero2.y = value.y / value2.y;
				zero2.z = value.z / value2.z;
				this.storeVector3Result.Value = zero2;
				return;
			}
			case Vector3Operator.Vector3Operation.Min:
				this.storeVector3Result.Value = Vector3.Min(value, value2);
				return;
			case Vector3Operator.Vector3Operation.Max:
				this.storeVector3Result.Value = Vector3.Max(value, value2);
				return;
			default:
				return;
			}
		}

		// Token: 0x06004598 RID: 17816 RVA: 0x001799EC File Offset: 0x00177BEC
		public Vector3Operator()
		{
			this.operation = Vector3Operator.Vector3Operation.Add;
			base..ctor();
		}

		// Token: 0x040049F3 RID: 18931
		[RequiredField]
		public FsmVector3 vector1;

		// Token: 0x040049F4 RID: 18932
		[RequiredField]
		public FsmVector3 vector2;

		// Token: 0x040049F5 RID: 18933
		public Vector3Operator.Vector3Operation operation;

		// Token: 0x040049F6 RID: 18934
		[UIHint(UIHint.Variable)]
		public FsmVector3 storeVector3Result;

		// Token: 0x040049F7 RID: 18935
		[UIHint(UIHint.Variable)]
		public FsmFloat storeFloatResult;

		// Token: 0x040049F8 RID: 18936
		public bool everyFrame;

		// Token: 0x02000D1E RID: 3358
		public enum Vector3Operation
		{
			// Token: 0x040049FA RID: 18938
			DotProduct,
			// Token: 0x040049FB RID: 18939
			CrossProduct,
			// Token: 0x040049FC RID: 18940
			Distance,
			// Token: 0x040049FD RID: 18941
			Angle,
			// Token: 0x040049FE RID: 18942
			Project,
			// Token: 0x040049FF RID: 18943
			Reflect,
			// Token: 0x04004A00 RID: 18944
			Add,
			// Token: 0x04004A01 RID: 18945
			Subtract,
			// Token: 0x04004A02 RID: 18946
			Multiply,
			// Token: 0x04004A03 RID: 18947
			Divide,
			// Token: 0x04004A04 RID: 18948
			Min,
			// Token: 0x04004A05 RID: 18949
			Max
		}
	}
}
