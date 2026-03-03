using System;
using UnityEngine;

// Token: 0x020003F4 RID: 1012
public class TownGrass : MonoBehaviour
{
	// Token: 0x06001710 RID: 5904 RVA: 0x0006D4D8 File Offset: 0x0006B6D8
	private void OnTriggerEnter2D(Collider2D collision)
	{
		if (GrassCut.ShouldCut(collision))
		{
			int num = (int)Mathf.Sign(collision.transform.position.x - base.transform.position.x);
			Vector3 position = (collision.transform.position + base.transform.position) / 2f;
			if (this.nailEffectPrefab)
			{
				GameObject gameObject = this.nailEffectPrefab.Spawn(position);
				Vector3 localScale = gameObject.transform.localScale;
				localScale.x = Mathf.Abs(localScale.x) * (float)(-(float)num);
				gameObject.transform.localScale = localScale;
			}
			else
			{
				Debug.Log("No nail effect assigned to " + base.gameObject.name);
			}
			if (this.debris.Length != 0)
			{
				foreach (GameObject gameObject2 in this.debris)
				{
					gameObject2.SetActive(true);
					gameObject2.transform.SetParent(null, true);
				}
			}
			else
			{
				Debug.Log("No debris assigned to " + base.gameObject.name);
			}
			if (this.source && this.cutSound.Length != 0)
			{
				this.source.transform.SetParent(null, true);
				this.source.PlayOneShot(this.cutSound[UnityEngine.Random.Range(0, this.cutSound.Length)]);
			}
			base.gameObject.SetActive(false);
		}
	}

	// Token: 0x04001BD0 RID: 7120
	public GameObject[] debris;

	// Token: 0x04001BD1 RID: 7121
	public GameObject nailEffectPrefab;

	// Token: 0x04001BD2 RID: 7122
	public AudioClip[] cutSound;

	// Token: 0x04001BD3 RID: 7123
	public AudioSource source;
}
