using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Ecosystem.Utils
{
	// Token: 0x020008C8 RID: 2248
	[Serializable]
	public class PlayMakerEventTarget
	{
		// Token: 0x0600321F RID: 12831 RVA: 0x00130A79 File Offset: 0x0012EC79
		public PlayMakerEventTarget()
		{
			this.includeChildren = true;
			base..ctor();
		}

		// Token: 0x06003220 RID: 12832 RVA: 0x00130A88 File Offset: 0x0012EC88
		public PlayMakerEventTarget(bool includeChildren = true)
		{
			this.includeChildren = true;
			base..ctor();
			this.includeChildren = includeChildren;
		}

		// Token: 0x06003221 RID: 12833 RVA: 0x00130A9E File Offset: 0x0012EC9E
		public PlayMakerEventTarget(ProxyEventTarget evenTarget, bool includeChildren = true)
		{
			this.includeChildren = true;
			base..ctor();
			this.eventTarget = evenTarget;
			this.includeChildren = includeChildren;
		}

		// Token: 0x04003361 RID: 13153
		public ProxyEventTarget eventTarget;

		// Token: 0x04003362 RID: 13154
		public GameObject gameObject;

		// Token: 0x04003363 RID: 13155
		public bool includeChildren;

		// Token: 0x04003364 RID: 13156
		public PlayMakerFSM fsmComponent;
	}
}
