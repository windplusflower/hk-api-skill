using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000B72 RID: 2930
	[ActionCategory(ActionCategory.Level)]
	[Tooltip("Makes the Game Object not be destroyed automatically when loading a new scene.")]
	public class DontDestroyOnLoad : FsmStateAction
	{
		// Token: 0x06003E56 RID: 15958 RVA: 0x00163E50 File Offset: 0x00162050
		public override void Reset()
		{
			this.gameObject = null;
		}

		// Token: 0x06003E57 RID: 15959 RVA: 0x00163E59 File Offset: 0x00162059
		public override void OnEnter()
		{
			UnityEngine.Object.DontDestroyOnLoad(base.Owner.transform.root.gameObject);
			base.Finish();
		}

		// Token: 0x04004263 RID: 16995
		[RequiredField]
		[Tooltip("GameObject to mark as DontDestroyOnLoad.")]
		public FsmOwnerDefault gameObject;
	}
}
