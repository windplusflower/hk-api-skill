using System;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000C19 RID: 3097
	[ActionCategory(ActionCategory.GameObject)]
	[Tooltip("Gets a Game Object's Tag and stores it in a String Variable.")]
	public class GetTag : FsmStateAction
	{
		// Token: 0x060040F8 RID: 16632 RVA: 0x0016B588 File Offset: 0x00169788
		public override void Reset()
		{
			this.gameObject = null;
			this.storeResult = null;
			this.everyFrame = false;
		}

		// Token: 0x060040F9 RID: 16633 RVA: 0x0016B59F File Offset: 0x0016979F
		public override void OnEnter()
		{
			this.DoGetTag();
			if (!this.everyFrame)
			{
				base.Finish();
			}
		}

		// Token: 0x060040FA RID: 16634 RVA: 0x0016B5B5 File Offset: 0x001697B5
		public override void OnUpdate()
		{
			this.DoGetTag();
		}

		// Token: 0x060040FB RID: 16635 RVA: 0x0016B5BD File Offset: 0x001697BD
		private void DoGetTag()
		{
			if (this.gameObject.Value == null)
			{
				return;
			}
			this.storeResult.Value = this.gameObject.Value.tag;
		}

		// Token: 0x0400453A RID: 17722
		[RequiredField]
		public FsmGameObject gameObject;

		// Token: 0x0400453B RID: 17723
		[RequiredField]
		[UIHint(UIHint.Variable)]
		public FsmString storeResult;

		// Token: 0x0400453C RID: 17724
		public bool everyFrame;
	}
}
