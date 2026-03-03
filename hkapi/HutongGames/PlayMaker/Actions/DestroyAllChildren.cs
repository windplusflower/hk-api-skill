using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x020009B3 RID: 2483
	[ActionCategory(ActionCategory.GameObject)]
	[Tooltip("Destroy all children on a GameObject.")]
	public class DestroyAllChildren : FsmStateAction
	{
		// Token: 0x06003657 RID: 13911 RVA: 0x0014068F File Offset: 0x0013E88F
		public override void Reset()
		{
			this.gameObject = null;
			this.disable = new FsmBool(false);
		}

		// Token: 0x06003658 RID: 13912 RVA: 0x001406AC File Offset: 0x0013E8AC
		public override void OnEnter()
		{
			GameObject value = this.gameObject.Value;
			if (value != null)
			{
				foreach (object obj in value.transform)
				{
					Transform transform = (Transform)obj;
					if (this.disable.Value)
					{
						transform.gameObject.SetActive(false);
					}
					else
					{
						UnityEngine.Object.Destroy(transform.gameObject);
					}
				}
			}
			base.Finish();
		}

		// Token: 0x04003825 RID: 14373
		[RequiredField]
		public FsmGameObject gameObject;

		// Token: 0x04003826 RID: 14374
		public FsmBool disable;
	}
}
