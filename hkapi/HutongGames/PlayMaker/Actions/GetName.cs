using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000C01 RID: 3073
	[ActionCategory(ActionCategory.GameObject)]
	[Tooltip("Gets the name of a Game Object and stores it in a String Variable.")]
	public class GetName : FsmStateAction
	{
		// Token: 0x06004090 RID: 16528 RVA: 0x0016A74D File Offset: 0x0016894D
		public override void Reset()
		{
			this.gameObject = new FsmGameObject
			{
				UseVariable = true
			};
			this.storeName = null;
			this.everyFrame = false;
		}

		// Token: 0x06004091 RID: 16529 RVA: 0x0016A76F File Offset: 0x0016896F
		public override void OnEnter()
		{
			this.DoGetGameObjectName();
			if (!this.everyFrame)
			{
				base.Finish();
			}
		}

		// Token: 0x06004092 RID: 16530 RVA: 0x0016A785 File Offset: 0x00168985
		public override void OnUpdate()
		{
			this.DoGetGameObjectName();
		}

		// Token: 0x06004093 RID: 16531 RVA: 0x0016A790 File Offset: 0x00168990
		private void DoGetGameObjectName()
		{
			GameObject value = this.gameObject.Value;
			this.storeName.Value = ((value != null) ? value.name : "");
		}

		// Token: 0x040044E5 RID: 17637
		[RequiredField]
		public FsmGameObject gameObject;

		// Token: 0x040044E6 RID: 17638
		[RequiredField]
		[UIHint(UIHint.Variable)]
		public FsmString storeName;

		// Token: 0x040044E7 RID: 17639
		public bool everyFrame;
	}
}
