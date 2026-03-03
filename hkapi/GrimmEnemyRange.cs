using System;
using System.Collections.Generic;
using UnityEngine;

// Token: 0x0200000B RID: 11
public class GrimmEnemyRange : MonoBehaviour
{
	// Token: 0x06000036 RID: 54 RVA: 0x0000329D File Offset: 0x0000149D
	private void OnEnable()
	{
		this.ClearEnemyList();
	}

	// Token: 0x06000037 RID: 55 RVA: 0x000032A5 File Offset: 0x000014A5
	public bool IsEnemyInRange()
	{
		return this.enemyList.Count != 0;
	}

	// Token: 0x06000038 RID: 56 RVA: 0x000032B8 File Offset: 0x000014B8
	public GameObject GetTarget()
	{
		GameObject result = null;
		float num = 99999f;
		if (this.enemyList.Count > 0)
		{
			for (int i = this.enemyList.Count - 1; i > -1; i--)
			{
				if (this.enemyList[i] == null || !this.enemyList[i].activeSelf)
				{
					this.enemyList.RemoveAt(i);
				}
			}
			foreach (GameObject gameObject in this.enemyList)
			{
				if (!Physics2D.Linecast(base.transform.position, gameObject.transform.position, 256))
				{
					float sqrMagnitude = (base.transform.position - gameObject.transform.position).sqrMagnitude;
					if (sqrMagnitude < num)
					{
						result = gameObject;
						num = sqrMagnitude;
					}
				}
			}
		}
		return result;
	}

	// Token: 0x06000039 RID: 57 RVA: 0x000033D0 File Offset: 0x000015D0
	private void OnTriggerEnter2D(Collider2D otherCollider)
	{
		this.enemyList.Add(otherCollider.gameObject);
	}

	// Token: 0x0600003A RID: 58 RVA: 0x000033E3 File Offset: 0x000015E3
	private void OnTriggerExit2D(Collider2D otherCollider)
	{
		this.enemyList.Remove(otherCollider.gameObject);
	}

	// Token: 0x0600003B RID: 59 RVA: 0x000033F7 File Offset: 0x000015F7
	public void ClearEnemyList()
	{
		this.enemyList.Clear();
	}

	// Token: 0x04000025 RID: 37
	public List<GameObject> enemyList;
}
