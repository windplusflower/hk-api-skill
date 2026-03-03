using System;
using UnityEngine;

// Token: 0x02000131 RID: 305
[RequireComponent(typeof(PolygonCollider2D))]
public class GradeTrigger : MonoBehaviour
{
	// Token: 0x0600071C RID: 1820 RVA: 0x00028B6C File Offset: 0x00026D6C
	private void Start()
	{
		if (this.gradeMarker)
		{
			this.gradeMarker.SetStartSizeForTrigger();
			this.gradeMarker.easeDuration = this.easeTime;
			this.gradeMarker.Deactivate();
			return;
		}
		Debug.LogError("No grade marker set for this grade trigger: " + base.name);
	}

	// Token: 0x0600071D RID: 1821 RVA: 0x00028BC3 File Offset: 0x00026DC3
	private void OnTriggerEnter2D(Collider2D triggerObject)
	{
		if (triggerObject.tag == "Player")
		{
			if (this.instantActivate)
			{
				this.gradeMarker.Activate();
				return;
			}
			this.gradeMarker.ActivateGradual();
		}
	}

	// Token: 0x0600071E RID: 1822 RVA: 0x00028BF6 File Offset: 0x00026DF6
	private void OnTriggerExit2D(Collider2D triggerObject)
	{
		if (triggerObject.tag == "Player")
		{
			if (this.instantActivate)
			{
				this.gradeMarker.Deactivate();
				return;
			}
			this.gradeMarker.DeactivateGradual();
		}
	}

	// Token: 0x0600071F RID: 1823 RVA: 0x00028C29 File Offset: 0x00026E29
	public GradeTrigger()
	{
		this.easeTime = 0.8f;
		base..ctor();
	}

	// Token: 0x040007D4 RID: 2004
	public GradeMarker gradeMarker;

	// Token: 0x040007D5 RID: 2005
	public bool instantActivate;

	// Token: 0x040007D6 RID: 2006
	[Range(0.5f, 2f)]
	public float easeTime;
}
