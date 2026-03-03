using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000C1F RID: 3103
	[ActionCategory(ActionCategory.GameObject)]
	[Tooltip("Gets a Game Object's Transform and stores it in an Object Variable.")]
	public class GetTransform : FsmStateAction
	{
		// Token: 0x0600410F RID: 16655 RVA: 0x0016B9FE File Offset: 0x00169BFE
		public override void Reset()
		{
			this.gameObject = new FsmGameObject
			{
				UseVariable = true
			};
			this.storeTransform = null;
			this.everyFrame = false;
		}

		// Token: 0x06004110 RID: 16656 RVA: 0x0016BA20 File Offset: 0x00169C20
		public override void OnEnter()
		{
			this.DoGetGameObjectName();
			if (!this.everyFrame)
			{
				base.Finish();
			}
		}

		// Token: 0x06004111 RID: 16657 RVA: 0x0016BA36 File Offset: 0x00169C36
		public override void OnUpdate()
		{
			this.DoGetGameObjectName();
		}

		// Token: 0x06004112 RID: 16658 RVA: 0x0016BA40 File Offset: 0x00169C40
		private void DoGetGameObjectName()
		{
			GameObject value = this.gameObject.Value;
			this.storeTransform.Value = ((value != null) ? value.transform : null);
		}

		// Token: 0x0400455A RID: 17754
		[RequiredField]
		public FsmGameObject gameObject;

		// Token: 0x0400455B RID: 17755
		[RequiredField]
		[UIHint(UIHint.Variable)]
		[ObjectType(typeof(Transform))]
		public FsmObject storeTransform;

		// Token: 0x0400455C RID: 17756
		public bool everyFrame;
	}
}
