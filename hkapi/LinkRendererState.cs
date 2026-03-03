using System;
using UnityEngine;

// Token: 0x02000472 RID: 1138
public class LinkRendererState : MonoBehaviour
{
	// Token: 0x06001992 RID: 6546 RVA: 0x00079D99 File Offset: 0x00077F99
	private void Start()
	{
		this.UpdateLink();
	}

	// Token: 0x06001993 RID: 6547 RVA: 0x00079D99 File Offset: 0x00077F99
	private void Update()
	{
		this.UpdateLink();
	}

	// Token: 0x06001994 RID: 6548 RVA: 0x00079DA4 File Offset: 0x00077FA4
	private void UpdateLink()
	{
		if (this.parent && this.child && this.child.enabled != this.parent.enabled)
		{
			this.child.enabled = this.parent.enabled;
		}
	}

	// Token: 0x04001EB6 RID: 7862
	public Renderer parent;

	// Token: 0x04001EB7 RID: 7863
	public Renderer child;
}
