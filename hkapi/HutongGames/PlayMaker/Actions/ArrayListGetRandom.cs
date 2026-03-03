using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000917 RID: 2327
	[ActionCategory("ArrayMaker/ArrayList")]
	[Tooltip("Gets a random item from a PlayMaker ArrayList Proxy component")]
	public class ArrayListGetRandom : ArrayListActions
	{
		// Token: 0x06003387 RID: 13191 RVA: 0x00135F34 File Offset: 0x00134134
		public override void Reset()
		{
			this.gameObject = null;
			this.failureEvent = null;
			this.randomItem = null;
			this.randomIndex = null;
		}

		// Token: 0x06003388 RID: 13192 RVA: 0x00135F52 File Offset: 0x00134152
		public override void OnEnter()
		{
			if (base.SetUpArrayListProxyPointer(base.Fsm.GetOwnerDefaultTarget(this.gameObject), this.reference.Value))
			{
				this.GetRandomItem();
			}
			base.Finish();
		}

		// Token: 0x06003389 RID: 13193 RVA: 0x00135F84 File Offset: 0x00134184
		public void GetRandomItem()
		{
			if (!base.isProxyValid())
			{
				return;
			}
			int num = UnityEngine.Random.Range(0, this.proxy.arrayList.Count);
			object value = null;
			try
			{
				value = this.proxy.arrayList[num];
			}
			catch (Exception ex)
			{
				Debug.LogWarning(ex.Message);
				base.Fsm.Event(this.failureEvent);
				return;
			}
			this.randomIndex.Value = num;
			if (!PlayMakerUtils.ApplyValueToFsmVar(base.Fsm, this.randomItem, value))
			{
				Debug.LogWarning("ApplyValueToFsmVar failed");
				base.Fsm.Event(this.failureEvent);
				return;
			}
		}

		// Token: 0x04003500 RID: 13568
		[ActionSection("Set up")]
		[RequiredField]
		[Tooltip("The gameObject with the PlayMaker ArrayList Proxy component")]
		[CheckForComponent(typeof(PlayMakerArrayListProxy))]
		public FsmOwnerDefault gameObject;

		// Token: 0x04003501 RID: 13569
		[Tooltip("Author defined Reference of the PlayMaker ArrayList Proxy component ( necessary if several component coexists on the same GameObject")]
		public FsmString reference;

		// Token: 0x04003502 RID: 13570
		[ActionSection("Result")]
		[Tooltip("The random item data picked from the array")]
		[UIHint(UIHint.Variable)]
		public FsmVar randomItem;

		// Token: 0x04003503 RID: 13571
		[Tooltip("The random item index picked from the array")]
		[UIHint(UIHint.Variable)]
		public FsmInt randomIndex;

		// Token: 0x04003504 RID: 13572
		[UIHint(UIHint.FsmEvent)]
		[Tooltip("The event to trigger if the action fails ( likely and index is out of range exception)")]
		public FsmEvent failureEvent;
	}
}
