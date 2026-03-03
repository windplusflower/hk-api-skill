using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x0200098A RID: 2442
	[ActionCategory(ActionCategory.GameObject)]
	[Tooltip("Activate or deactivate all children on a GameObject.")]
	public class ActivateAllChildren : FsmStateAction
	{
		// Token: 0x0600359D RID: 13725 RVA: 0x0013CCB8 File Offset: 0x0013AEB8
		public override void Reset()
		{
			this.gameObject = null;
			this.activate = true;
		}

		// Token: 0x0600359E RID: 13726 RVA: 0x0013CCC8 File Offset: 0x0013AEC8
		public override void OnEnter()
		{
			GameObject value = this.gameObject.Value;
			if (value != null)
			{
				foreach (object obj in value.transform)
				{
					((Transform)obj).gameObject.SetActive(this.activate);
				}
			}
			base.Finish();
		}

		// Token: 0x0400372C RID: 14124
		[RequiredField]
		[UIHint(UIHint.Variable)]
		public FsmGameObject gameObject;

		// Token: 0x0400372D RID: 14125
		public bool activate;
	}
}
