using System;
using System.Collections.Generic;
using System.Linq;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x0200094B RID: 2379
	[ActionCategory("ArrayMaker/ArrayList")]
	[Tooltip("Return the average value within an arrayList. It can use float, int, vector2 and vector3 ( uses magnitude), rect ( uses surface), gameobject ( using bounding box volume), and string ( use lenght)")]
	public class ArrayListGetAverageValue : ArrayListActions
	{
		// Token: 0x0600345F RID: 13407 RVA: 0x00139097 File Offset: 0x00137297
		public override void Reset()
		{
			this.gameObject = null;
			this.reference = null;
			this.averageValue = null;
			this.everyframe = true;
		}

		// Token: 0x06003460 RID: 13408 RVA: 0x001390B5 File Offset: 0x001372B5
		public override void OnEnter()
		{
			if (!base.SetUpArrayListProxyPointer(base.Fsm.GetOwnerDefaultTarget(this.gameObject), this.reference.Value))
			{
				base.Finish();
			}
			this.DoGetAverageValue();
			if (!this.everyframe)
			{
				base.Finish();
			}
		}

		// Token: 0x06003461 RID: 13409 RVA: 0x001390F5 File Offset: 0x001372F5
		public override void OnUpdate()
		{
			this.DoGetAverageValue();
		}

		// Token: 0x06003462 RID: 13410 RVA: 0x00139100 File Offset: 0x00137300
		private void DoGetAverageValue()
		{
			if (!base.isProxyValid())
			{
				return;
			}
			this._floats = new List<float>();
			foreach (object value in this.proxy.arrayList)
			{
				this._floats.Add(Convert.ToSingle(value));
			}
			if (this._floats.Count > 0)
			{
				this.averageValue.Value = this._floats.Aggregate((float acc, float cur) => acc + cur) / (float)this._floats.Count;
				return;
			}
			this.averageValue.Value = 0f;
		}

		// Token: 0x0400360C RID: 13836
		[ActionSection("Set up")]
		[RequiredField]
		[Tooltip("The gameObject with the PlayMaker ArrayList Proxy component")]
		[CheckForComponent(typeof(PlayMakerArrayListProxy))]
		public FsmOwnerDefault gameObject;

		// Token: 0x0400360D RID: 13837
		[Tooltip("Author defined Reference of the PlayMaker ArrayList Proxy component ( necessary if several component coexists on the same GameObject")]
		public FsmString reference;

		// Token: 0x0400360E RID: 13838
		[Tooltip("Performs every frame. WARNING, it could be affecting performances.")]
		public bool everyframe;

		// Token: 0x0400360F RID: 13839
		[ActionSection("Result")]
		[RequiredField]
		[UIHint(UIHint.Variable)]
		[Tooltip("The average Value")]
		public FsmFloat averageValue;

		// Token: 0x04003610 RID: 13840
		private List<float> _floats;
	}
}
