using System;
using System.Collections.Generic;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x0200094F RID: 2383
	[ActionCategory("ArrayMaker/ArrayList")]
	[Tooltip("Return the average value within an arrayList.")]
	public class ArrayListGetNearestFloatValue : ArrayListActions
	{
		// Token: 0x06003475 RID: 13429 RVA: 0x0013954A File Offset: 0x0013774A
		public override void Reset()
		{
			this.gameObject = null;
			this.reference = null;
			this.floatValue = null;
			this.nearestIndex = null;
			this.nearestValue = null;
			this.everyframe = true;
		}

		// Token: 0x06003476 RID: 13430 RVA: 0x00139576 File Offset: 0x00137776
		public override void OnEnter()
		{
			if (!base.SetUpArrayListProxyPointer(base.Fsm.GetOwnerDefaultTarget(this.gameObject), this.reference.Value))
			{
				base.Finish();
			}
			this.DoGetNearestValue();
			if (!this.everyframe)
			{
				base.Finish();
			}
		}

		// Token: 0x06003477 RID: 13431 RVA: 0x001395B6 File Offset: 0x001377B6
		public override void OnUpdate()
		{
			this.DoGetNearestValue();
		}

		// Token: 0x06003478 RID: 13432 RVA: 0x001395C0 File Offset: 0x001377C0
		private void DoGetNearestValue()
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
			float value2 = this.floatValue.Value;
			if (this._floats.Count > 0)
			{
				float value3 = float.MaxValue;
				float num = float.MaxValue;
				int value4 = 0;
				int num2 = 0;
				foreach (float num3 in this._floats)
				{
					float num4 = Mathf.Abs(num3 - value2);
					if (num > num4)
					{
						num = num4;
						value3 = num3;
						value4 = num2;
					}
					num2++;
				}
				this.nearestIndex.Value = value4;
				this.nearestValue.Value = value3;
			}
		}

		// Token: 0x0400361F RID: 13855
		[ActionSection("Set up")]
		[RequiredField]
		[Tooltip("The gameObject with the PlayMaker ArrayList Proxy component")]
		[CheckForComponent(typeof(PlayMakerArrayListProxy))]
		public FsmOwnerDefault gameObject;

		// Token: 0x04003620 RID: 13856
		[Tooltip("Author defined Reference of the PlayMaker ArrayList Proxy component ( necessary if several component coexists on the same GameObject")]
		public FsmString reference;

		// Token: 0x04003621 RID: 13857
		[Tooltip("The target Value")]
		public FsmFloat floatValue;

		// Token: 0x04003622 RID: 13858
		[Tooltip("Performs every frame. WARNING, it could be affecting performances.")]
		public bool everyframe;

		// Token: 0x04003623 RID: 13859
		[ActionSection("Result")]
		[UIHint(UIHint.Variable)]
		[Tooltip("The index of the nearest Value")]
		public FsmInt nearestIndex;

		// Token: 0x04003624 RID: 13860
		[UIHint(UIHint.Variable)]
		[Tooltip("The nearest Value")]
		public FsmFloat nearestValue;

		// Token: 0x04003625 RID: 13861
		private List<float> _floats;
	}
}
