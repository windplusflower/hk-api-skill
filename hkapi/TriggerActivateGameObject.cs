using System;
using UnityEngine;

// Token: 0x0200020F RID: 527
[RequireComponent(typeof(BoxCollider2D))]
public class TriggerActivateGameObject : MonoBehaviour
{
	// Token: 0x06000B64 RID: 2916 RVA: 0x0003C51A File Offset: 0x0003A71A
	private void Start()
	{
		if (this.deactivateObjectOnLoad && this.gameObjectToSet != null)
		{
			this.gameObjectToSet.SetActive(false);
		}
	}

	// Token: 0x06000B65 RID: 2917 RVA: 0x0003C53E File Offset: 0x0003A73E
	public void OnTriggerEnter2D(Collider2D otherCollider)
	{
		if (otherCollider.gameObject.layer == 9)
		{
			this.gameObjectToSet.SetActive(true);
			this.active = true;
		}
	}

	// Token: 0x06000B66 RID: 2918 RVA: 0x0003C562 File Offset: 0x0003A762
	public void OnTriggerStay2D(Collider2D otherCollider)
	{
		if (!this.active && otherCollider.gameObject.layer == 9)
		{
			this.OnTriggerEnter2D(otherCollider);
		}
	}

	// Token: 0x06000B67 RID: 2919 RVA: 0x0003C582 File Offset: 0x0003A782
	public void OnTriggerExit2D(Collider2D otherCollider)
	{
		if (otherCollider.gameObject.layer == 9)
		{
			this.gameObjectToSet.SetActive(false);
			this.active = false;
		}
	}

	// Token: 0x04000C5B RID: 3163
	public bool deactivateObjectOnLoad;

	// Token: 0x04000C5C RID: 3164
	private bool active;

	// Token: 0x04000C5D RID: 3165
	public GameObject gameObjectToSet;
}
