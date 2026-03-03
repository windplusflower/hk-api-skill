using System;
using System.Runtime.CompilerServices;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x0200094E RID: 2382
	[ActionCategory("ArrayMaker/ArrayList")]
	[Tooltip("Return the minimum value within an arrayList. It can use float, int, vector2 and vector3 ( uses magnitude), rect ( uses surface), gameobject ( using bounding box volume), and string ( use lenght)")]
	public class ArrayListGetMinValue : ArrayListActions
	{
		// Token: 0x0600346E RID: 13422 RVA: 0x0013939A File Offset: 0x0013759A
		public override void Reset()
		{
			this.gameObject = null;
			this.reference = null;
			this.minimumValue = null;
			this.minimumValueIndex = null;
			this.everyframe = true;
		}

		// Token: 0x0600346F RID: 13423 RVA: 0x001393BF File Offset: 0x001375BF
		public override void OnEnter()
		{
			if (!base.SetUpArrayListProxyPointer(base.Fsm.GetOwnerDefaultTarget(this.gameObject), this.reference.Value))
			{
				base.Finish();
			}
			this.DoFindMinimumValue();
			if (!this.everyframe)
			{
				base.Finish();
			}
		}

		// Token: 0x06003470 RID: 13424 RVA: 0x001393FF File Offset: 0x001375FF
		public override void OnUpdate()
		{
			this.DoFindMinimumValue();
		}

		// Token: 0x06003471 RID: 13425 RVA: 0x00139408 File Offset: 0x00137608
		private void DoFindMinimumValue()
		{
			if (!base.isProxyValid())
			{
				return;
			}
			VariableType type = this.minimumValue.Type;
			if (!ArrayListGetMinValue.supportedTypes.Contains(this.minimumValue.Type))
			{
				return;
			}
			float num = float.PositiveInfinity;
			int num2 = 0;
			int num3 = 0;
			foreach (object obj in this.proxy.arrayList)
			{
				float floatFromObject = PlayMakerUtils.GetFloatFromObject(obj, type, true);
				if (num > floatFromObject)
				{
					num = floatFromObject;
					num2 = num3;
				}
				num3++;
			}
			this.minimumValueIndex.Value = num2;
			PlayMakerUtils.ApplyValueToFsmVar(base.Fsm, this.minimumValue, this.proxy.arrayList[num2]);
		}

		// Token: 0x06003472 RID: 13426 RVA: 0x001394E0 File Offset: 0x001376E0
		public override string ErrorCheck()
		{
			if (!ArrayListGetMinValue.supportedTypes.Contains(this.minimumValue.Type))
			{
				return "A " + this.minimumValue.Type.ToString() + " can not be processed as a minimum";
			}
			return "";
		}

		// Token: 0x06003474 RID: 13428 RVA: 0x00139532 File Offset: 0x00137732
		// Note: this type is marked as 'beforefieldinit'.
		static ArrayListGetMinValue()
		{
			VariableType[] array = new VariableType[7];
			RuntimeHelpers.InitializeArray(array, fieldof(<PrivateImplementationDetails>.D18B72E3104D17471D27BD26FBD89EA6685E4AE36B0FDF2562CD7B7B8F692B9C).FieldHandle);
			ArrayListGetMinValue.supportedTypes = array;
		}

		// Token: 0x04003619 RID: 13849
		private static VariableType[] supportedTypes;

		// Token: 0x0400361A RID: 13850
		[ActionSection("Set up")]
		[RequiredField]
		[Tooltip("The gameObject with the PlayMaker ArrayList Proxy component")]
		[CheckForComponent(typeof(PlayMakerArrayListProxy))]
		public FsmOwnerDefault gameObject;

		// Token: 0x0400361B RID: 13851
		[Tooltip("Author defined Reference of the PlayMaker ArrayList Proxy component ( necessary if several component coexists on the same GameObject")]
		public FsmString reference;

		// Token: 0x0400361C RID: 13852
		[Tooltip("Performs every frame. WARNING, it could be affecting performances.")]
		public bool everyframe;

		// Token: 0x0400361D RID: 13853
		[ActionSection("Result")]
		[RequiredField]
		[UIHint(UIHint.Variable)]
		[Tooltip("The Minimum Value")]
		public FsmVar minimumValue;

		// Token: 0x0400361E RID: 13854
		[UIHint(UIHint.Variable)]
		[Tooltip("The index of the Maximum Value within that arrayList")]
		public FsmInt minimumValueIndex;
	}
}
