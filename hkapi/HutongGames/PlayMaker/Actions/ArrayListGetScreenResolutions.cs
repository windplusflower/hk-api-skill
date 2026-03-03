using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000954 RID: 2388
	[ActionCategory("ArrayMaker/ArrayList")]
	[Tooltip("Store all resolutions")]
	public class ArrayListGetScreenResolutions : ArrayListActions
	{
		// Token: 0x0600348C RID: 13452 RVA: 0x00139AE4 File Offset: 0x00137CE4
		public override void Reset()
		{
			this.gameObject = null;
			this.reference = null;
		}

		// Token: 0x0600348D RID: 13453 RVA: 0x00139AF4 File Offset: 0x00137CF4
		public override void OnEnter()
		{
			if (base.SetUpArrayListProxyPointer(base.Fsm.GetOwnerDefaultTarget(this.gameObject), this.reference.Value))
			{
				this.getResolutions();
			}
			base.Finish();
		}

		// Token: 0x0600348E RID: 13454 RVA: 0x00139B28 File Offset: 0x00137D28
		public void getResolutions()
		{
			if (!base.isProxyValid())
			{
				return;
			}
			this.proxy.arrayList.Clear();
			foreach (Resolution resolution in Screen.resolutions)
			{
				this.proxy.arrayList.Add(new Vector3((float)resolution.width, (float)resolution.height, (float)resolution.refreshRate));
			}
		}

		// Token: 0x04003638 RID: 13880
		[ActionSection("Set up")]
		[RequiredField]
		[Tooltip("The gameObject with the PlayMaker ArrayList Proxy component")]
		[CheckForComponent(typeof(PlayMakerArrayListProxy))]
		public FsmOwnerDefault gameObject;

		// Token: 0x04003639 RID: 13881
		[Tooltip("Author defined Reference of the PlayMaker ArrayList Proxy component ( necessary if several component coexists on the same GameObject")]
		public FsmString reference;
	}
}
