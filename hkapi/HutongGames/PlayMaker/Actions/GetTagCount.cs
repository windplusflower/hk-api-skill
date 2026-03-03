using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000C1A RID: 3098
	[ActionCategory(ActionCategory.GameObject)]
	[Tooltip("Gets the number of Game Objects in the scene with the specified Tag.")]
	public class GetTagCount : FsmStateAction
	{
		// Token: 0x060040FD RID: 16637 RVA: 0x0016B5EE File Offset: 0x001697EE
		public override void Reset()
		{
			this.tag = "Untagged";
			this.storeResult = null;
		}

		// Token: 0x060040FE RID: 16638 RVA: 0x0016B608 File Offset: 0x00169808
		public override void OnEnter()
		{
			GameObject[] array = GameObject.FindGameObjectsWithTag(this.tag.Value);
			if (this.storeResult != null)
			{
				this.storeResult.Value = ((array != null) ? array.Length : 0);
			}
			base.Finish();
		}

		// Token: 0x0400453D RID: 17725
		[UIHint(UIHint.Tag)]
		public FsmString tag;

		// Token: 0x0400453E RID: 17726
		[RequiredField]
		[UIHint(UIHint.Variable)]
		public FsmInt storeResult;
	}
}
