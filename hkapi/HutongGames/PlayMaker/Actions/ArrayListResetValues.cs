using System;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000920 RID: 2336
	[ActionCategory("ArrayMaker/ArrayList")]
	[Tooltip("Sets all element to to a given value of a PlayMaker ArrayList Proxy component")]
	public class ArrayListResetValues : ArrayListActions
	{
		// Token: 0x060033AA RID: 13226 RVA: 0x001368F4 File Offset: 0x00134AF4
		public override void Reset()
		{
			this.gameObject = null;
			this.reference = null;
			this.resetValue = null;
		}

		// Token: 0x060033AB RID: 13227 RVA: 0x0013690B File Offset: 0x00134B0B
		public override void OnEnter()
		{
			if (base.SetUpArrayListProxyPointer(base.Fsm.GetOwnerDefaultTarget(this.gameObject), this.reference.Value))
			{
				this.ResetArrayList();
			}
			base.Finish();
		}

		// Token: 0x060033AC RID: 13228 RVA: 0x00136940 File Offset: 0x00134B40
		public void ResetArrayList()
		{
			if (!base.isProxyValid())
			{
				return;
			}
			object valueFromFsmVar = PlayMakerUtils.GetValueFromFsmVar(base.Fsm, this.resetValue);
			for (int i = 0; i < this.proxy.arrayList.Count; i++)
			{
				this.proxy.arrayList[i] = valueFromFsmVar;
			}
		}

		// Token: 0x04003534 RID: 13620
		[ActionSection("Set up")]
		[RequiredField]
		[Tooltip("The gameObject with the PlayMaker ArrayList Proxy component")]
		[CheckForComponent(typeof(PlayMakerArrayListProxy))]
		public FsmOwnerDefault gameObject;

		// Token: 0x04003535 RID: 13621
		[Tooltip("Author defined Reference of the PlayMaker ArrayList Proxy component ( necessary if several component coexists on the same GameObject")]
		public FsmString reference;

		// Token: 0x04003536 RID: 13622
		[Tooltip("The value to reset all the arrayList with")]
		public FsmVar resetValue;
	}
}
