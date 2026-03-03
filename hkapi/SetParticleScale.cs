using System;
using UnityEngine;

// Token: 0x02000403 RID: 1027
public class SetParticleScale : MonoBehaviour
{
	// Token: 0x06001752 RID: 5970 RVA: 0x0006E48C File Offset: 0x0006C68C
	private void Start()
	{
		if (this.grandParent)
		{
			if (base.transform.parent != null && base.transform.parent.parent != null)
			{
				this.parent = base.transform.parent.gameObject.transform.parent.gameObject;
				return;
			}
		}
		else if (this.greatGrandParent)
		{
			if (base.transform.parent != null && base.transform.parent.parent != null && base.transform.parent.parent.parent != null)
			{
				this.parent = base.transform.parent.gameObject.transform.parent.gameObject.transform.parent.gameObject;
				return;
			}
		}
		else if (base.transform.parent != null)
		{
			this.parent = base.transform.parent.gameObject;
		}
	}

	// Token: 0x06001753 RID: 5971 RVA: 0x0006E5B0 File Offset: 0x0006C7B0
	private void Update()
	{
		if (this.parent != null && !this.unparented)
		{
			this.parentXScale = this.parent.transform.localScale.x;
			this.selfXScale = base.transform.localScale.x;
			if ((this.parentXScale < 0f && this.selfXScale > 0f) || (this.parentXScale > 0f && this.selfXScale < 0f))
			{
				this.scaleVector.Set(-base.transform.localScale.x, base.transform.localScale.y, base.transform.localScale.z);
				base.transform.localScale = this.scaleVector;
				return;
			}
		}
		else
		{
			this.unparented = true;
			this.selfXScale = base.transform.localScale.x;
			if (this.selfXScale < 0f)
			{
				this.scaleVector.Set(-base.transform.localScale.x, base.transform.localScale.y, base.transform.localScale.z);
				base.transform.localScale = this.scaleVector;
			}
		}
	}

	// Token: 0x04001C14 RID: 7188
	public bool grandParent;

	// Token: 0x04001C15 RID: 7189
	public bool greatGrandParent;

	// Token: 0x04001C16 RID: 7190
	private float parentXScale;

	// Token: 0x04001C17 RID: 7191
	private float selfXScale;

	// Token: 0x04001C18 RID: 7192
	private Vector3 scaleVector;

	// Token: 0x04001C19 RID: 7193
	private bool unparented;

	// Token: 0x04001C1A RID: 7194
	private GameObject parent;
}
