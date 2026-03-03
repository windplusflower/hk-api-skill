using System;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000BC4 RID: 3012
	[ActionCategory(ActionCategory.Logic)]
	[Tooltip("Tests if a Game Object has a tag.")]
	public class GameObjectCompareTag : FsmStateAction
	{
		// Token: 0x06003F87 RID: 16263 RVA: 0x001679F0 File Offset: 0x00165BF0
		public override void Reset()
		{
			this.gameObject = null;
			this.tag = "Untagged";
			this.trueEvent = null;
			this.falseEvent = null;
			this.storeResult = null;
			this.everyFrame = false;
		}

		// Token: 0x06003F88 RID: 16264 RVA: 0x00167A25 File Offset: 0x00165C25
		public override void OnEnter()
		{
			this.DoCompareTag();
			if (!this.everyFrame)
			{
				base.Finish();
			}
		}

		// Token: 0x06003F89 RID: 16265 RVA: 0x00167A3B File Offset: 0x00165C3B
		public override void OnUpdate()
		{
			this.DoCompareTag();
		}

		// Token: 0x06003F8A RID: 16266 RVA: 0x00167A44 File Offset: 0x00165C44
		private void DoCompareTag()
		{
			bool flag = false;
			if (this.gameObject.Value != null)
			{
				flag = this.gameObject.Value.CompareTag(this.tag.Value);
			}
			this.storeResult.Value = flag;
			base.Fsm.Event(flag ? this.trueEvent : this.falseEvent);
		}

		// Token: 0x040043B1 RID: 17329
		[RequiredField]
		[Tooltip("The GameObject to test.")]
		public FsmGameObject gameObject;

		// Token: 0x040043B2 RID: 17330
		[RequiredField]
		[UIHint(UIHint.Tag)]
		[Tooltip("The Tag to check for.")]
		public FsmString tag;

		// Token: 0x040043B3 RID: 17331
		[Tooltip("Event to send if the GameObject has the Tag.")]
		public FsmEvent trueEvent;

		// Token: 0x040043B4 RID: 17332
		[Tooltip("Event to send if the GameObject does not have the Tag.")]
		public FsmEvent falseEvent;

		// Token: 0x040043B5 RID: 17333
		[UIHint(UIHint.Variable)]
		[Tooltip("Store the result in a Bool variable.")]
		public FsmBool storeResult;

		// Token: 0x040043B6 RID: 17334
		[Tooltip("Repeat every frame.")]
		public bool everyFrame;
	}
}
