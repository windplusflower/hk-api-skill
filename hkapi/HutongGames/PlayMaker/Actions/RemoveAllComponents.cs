using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000A2C RID: 2604
	[ActionCategory(ActionCategory.GameObject)]
	[Tooltip("Remove all components from a GameObject.")]
	public class RemoveAllComponents : FsmStateAction
	{
		// Token: 0x0600388E RID: 14478 RVA: 0x0014B1B8 File Offset: 0x001493B8
		public override void Reset()
		{
			this.gameObject = null;
		}

		// Token: 0x0600388F RID: 14479 RVA: 0x0014B1C4 File Offset: 0x001493C4
		public override void OnEnter()
		{
			GameObject value = this.gameObject.Value;
			if (value != null)
			{
				foreach (MonoBehaviour monoBehaviour in value.GetComponents<MonoBehaviour>())
				{
					Debug.Log(monoBehaviour.name);
					if (monoBehaviour.name != "Play Maker FSM")
					{
						monoBehaviour.name != "Persistent Bool Item";
					}
				}
			}
			base.Finish();
		}

		// Token: 0x04003B36 RID: 15158
		[RequiredField]
		[Tooltip("The GameObject to destroy.")]
		public FsmGameObject gameObject;
	}
}
