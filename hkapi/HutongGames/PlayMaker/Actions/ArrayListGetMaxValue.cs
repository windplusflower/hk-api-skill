using System;
using System.Runtime.CompilerServices;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x0200094D RID: 2381
	[ActionCategory("ArrayMaker/ArrayList")]
	[Tooltip("Return the maximum value within an arrayList. It can use float, int, vector2 and vector3 ( uses magnitude), rect ( uses surface), gameobject ( using bounding box volume), and string ( use lenght)")]
	public class ArrayListGetMaxValue : ArrayListActions
	{
		// Token: 0x06003467 RID: 13415 RVA: 0x001391E9 File Offset: 0x001373E9
		public override void Reset()
		{
			this.gameObject = null;
			this.reference = null;
			this.maximumValue = null;
			this.maximumValueIndex = null;
			this.everyframe = true;
		}

		// Token: 0x06003468 RID: 13416 RVA: 0x0013920E File Offset: 0x0013740E
		public override void OnEnter()
		{
			if (!base.SetUpArrayListProxyPointer(base.Fsm.GetOwnerDefaultTarget(this.gameObject), this.reference.Value))
			{
				base.Finish();
			}
			this.DoFindMaximumValue();
			if (!this.everyframe)
			{
				base.Finish();
			}
		}

		// Token: 0x06003469 RID: 13417 RVA: 0x0013924E File Offset: 0x0013744E
		public override void OnUpdate()
		{
			this.DoFindMaximumValue();
		}

		// Token: 0x0600346A RID: 13418 RVA: 0x00139258 File Offset: 0x00137458
		private void DoFindMaximumValue()
		{
			if (!base.isProxyValid())
			{
				return;
			}
			VariableType type = this.maximumValue.Type;
			if (!ArrayListGetMaxValue.supportedTypes.Contains(this.maximumValue.Type))
			{
				return;
			}
			float num = float.NegativeInfinity;
			int num2 = 0;
			int num3 = 0;
			foreach (object obj in this.proxy.arrayList)
			{
				float floatFromObject = PlayMakerUtils.GetFloatFromObject(obj, type, true);
				if (num < floatFromObject)
				{
					num = floatFromObject;
					num2 = num3;
				}
				num3++;
			}
			this.maximumValueIndex.Value = num2;
			PlayMakerUtils.ApplyValueToFsmVar(base.Fsm, this.maximumValue, this.proxy.arrayList[num2]);
		}

		// Token: 0x0600346B RID: 13419 RVA: 0x00139330 File Offset: 0x00137530
		public override string ErrorCheck()
		{
			if (!ArrayListGetMaxValue.supportedTypes.Contains(this.maximumValue.Type))
			{
				return "A " + this.maximumValue.Type.ToString() + " can not be processed as a minimum";
			}
			return "";
		}

		// Token: 0x0600346D RID: 13421 RVA: 0x00139382 File Offset: 0x00137582
		// Note: this type is marked as 'beforefieldinit'.
		static ArrayListGetMaxValue()
		{
			VariableType[] array = new VariableType[7];
			RuntimeHelpers.InitializeArray(array, fieldof(<PrivateImplementationDetails>.D18B72E3104D17471D27BD26FBD89EA6685E4AE36B0FDF2562CD7B7B8F692B9C).FieldHandle);
			ArrayListGetMaxValue.supportedTypes = array;
		}

		// Token: 0x04003613 RID: 13843
		private static VariableType[] supportedTypes;

		// Token: 0x04003614 RID: 13844
		[ActionSection("Set up")]
		[RequiredField]
		[Tooltip("The gameObject with the PlayMaker ArrayList Proxy component")]
		[CheckForComponent(typeof(PlayMakerArrayListProxy))]
		public FsmOwnerDefault gameObject;

		// Token: 0x04003615 RID: 13845
		[Tooltip("Author defined Reference of the PlayMaker ArrayList Proxy component ( necessary if several component coexists on the same GameObject")]
		public FsmString reference;

		// Token: 0x04003616 RID: 13846
		[Tooltip("Performs every frame. WARNING, it could be affecting performances.")]
		public bool everyframe;

		// Token: 0x04003617 RID: 13847
		[ActionSection("Result")]
		[RequiredField]
		[UIHint(UIHint.Variable)]
		[Tooltip("The Maximum Value")]
		public FsmVar maximumValue;

		// Token: 0x04003618 RID: 13848
		[UIHint(UIHint.Variable)]
		[Tooltip("The index of the Maximum Value within that arrayList")]
		public FsmInt maximumValueIndex;
	}
}
