using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000949 RID: 2377
	[ActionCategory("ArrayMaker/ArrayList")]
	[Tooltip("Returns the Gameobject within an arrayList which have the max float value in its FSM")]
	public class ArrayListGetGameobjectMaxFsmFloatIndex : ArrayListActions
	{
		// Token: 0x06003455 RID: 13397 RVA: 0x00138D89 File Offset: 0x00136F89
		public override void Reset()
		{
			this.gameObject = null;
			this.reference = null;
			this.maxGameObject = null;
			this.maxIndex = null;
			this.everyframe = true;
			this.fsmName = "";
			this.storeMaxValue = null;
		}

		// Token: 0x06003456 RID: 13398 RVA: 0x00138DC5 File Offset: 0x00136FC5
		public override void OnEnter()
		{
			if (!base.SetUpArrayListProxyPointer(base.Fsm.GetOwnerDefaultTarget(this.gameObject), this.reference.Value))
			{
				base.Finish();
			}
			this.DoFindMaxGo();
			if (!this.everyframe)
			{
				base.Finish();
			}
		}

		// Token: 0x06003457 RID: 13399 RVA: 0x00138E05 File Offset: 0x00137005
		public override void OnUpdate()
		{
			this.DoFindMaxGo();
		}

		// Token: 0x06003458 RID: 13400 RVA: 0x00138E10 File Offset: 0x00137010
		private void DoFindMaxGo()
		{
			float num = 0f;
			if (this.storeMaxValue.IsNone)
			{
				return;
			}
			if (!base.isProxyValid())
			{
				return;
			}
			int num2 = 0;
			foreach (object obj in this.proxy.arrayList)
			{
				GameObject gameObject = (GameObject)obj;
				if (gameObject != null)
				{
					this.fsm = ActionHelpers.GetGameObjectFsm(gameObject, this.fsmName.Value);
					if (this.fsm == null)
					{
						break;
					}
					FsmFloat fsmFloat = this.fsm.FsmVariables.GetFsmFloat(this.variableName.Value);
					if (fsmFloat == null)
					{
						break;
					}
					if (fsmFloat.Value > num)
					{
						this.storeMaxValue.Value = fsmFloat.Value;
						num = fsmFloat.Value;
						this.maxGameObject.Value = gameObject;
						this.maxIndex.Value = num2;
					}
				}
				num2++;
			}
		}

		// Token: 0x040035FC RID: 13820
		[ActionSection("Set up")]
		[RequiredField]
		[Tooltip("The gameObject with the PlayMaker ArrayList Proxy component")]
		[CheckForComponent(typeof(PlayMakerArrayListProxy))]
		public FsmOwnerDefault gameObject;

		// Token: 0x040035FD RID: 13821
		[Tooltip("Author defined Reference of the PlayMaker ArrayList Proxy component ( necessary if several component coexists on the same GameObject")]
		public FsmString reference;

		// Token: 0x040035FE RID: 13822
		[UIHint(UIHint.FsmName)]
		[Tooltip("Optional name of FSM on Game Object")]
		public FsmString fsmName;

		// Token: 0x040035FF RID: 13823
		[RequiredField]
		[UIHint(UIHint.FsmFloat)]
		public FsmString variableName;

		// Token: 0x04003600 RID: 13824
		public bool everyframe;

		// Token: 0x04003601 RID: 13825
		[ActionSection("Result")]
		[UIHint(UIHint.Variable)]
		public FsmFloat storeMaxValue;

		// Token: 0x04003602 RID: 13826
		[UIHint(UIHint.Variable)]
		public FsmGameObject maxGameObject;

		// Token: 0x04003603 RID: 13827
		[UIHint(UIHint.Variable)]
		public FsmInt maxIndex;

		// Token: 0x04003604 RID: 13828
		private GameObject goLastFrame;

		// Token: 0x04003605 RID: 13829
		private PlayMakerFSM fsm;
	}
}
