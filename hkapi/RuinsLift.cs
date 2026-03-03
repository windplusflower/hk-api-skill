using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Token: 0x020003E0 RID: 992
public class RuinsLift : MonoBehaviour
{
	// Token: 0x0600169B RID: 5787 RVA: 0x0006B004 File Offset: 0x00069204
	private void Start()
	{
		if (this.chainsParent)
		{
			int childCount = this.chainsParent.childCount;
			this.chains = new List<Transform>(childCount);
			for (int i = 0; i < childCount; i++)
			{
				Transform child = this.chainsParent.GetChild(i);
				if (child.gameObject.activeSelf)
				{
					SpriteRenderer component = child.GetComponent<SpriteRenderer>();
					if (!component || (component.enabled && !(component.sprite == null)))
					{
						this.chains.Add(child);
					}
				}
			}
			this.chains.Sort((Transform a, Transform b) => a.transform.position.y.CompareTo(b.transform.position.y));
			this.chains.Reverse();
			base.StartCoroutine(this.HideChains());
		}
	}

	// Token: 0x0600169C RID: 5788 RVA: 0x0006B0D2 File Offset: 0x000692D2
	private IEnumerator HideChains()
	{
		List<float> list = new List<float>(this.stopPositions);
		list.Sort();
		float minYPos = list[0];
		float maxYPos = list[list.Count - 1] - minYPos;
		float lastYPos = 0f;
		for (;;)
		{
			yield return null;
			if (this.transform.position.y != lastYPos)
			{
				lastYPos = this.transform.position.y;
				int num = Mathf.FloorToInt((this.transform.position.y - minYPos) / maxYPos * (float)this.chains.Count);
				for (int i = 0; i < this.chains.Count; i++)
				{
					this.chains[i].gameObject.SetActive(i >= num);
				}
			}
		}
		yield break;
	}

	// Token: 0x0600169D RID: 5789 RVA: 0x0006B0E1 File Offset: 0x000692E1
	public float GetPositionY(int position)
	{
		position--;
		if (position < 0 || position + 1 > this.stopPositions.Length)
		{
			position = 0;
		}
		return this.stopPositions[position];
	}

	// Token: 0x0600169E RID: 5790 RVA: 0x0006B108 File Offset: 0x00069308
	public bool IsCurrentPositionTerminus(int position)
	{
		bool result = false;
		if (position == 1 || position == this.stopPositions.Length)
		{
			result = true;
		}
		return result;
	}

	// Token: 0x0600169F RID: 5791 RVA: 0x0006B129 File Offset: 0x00069329
	public int KeepInBounds(int position)
	{
		position--;
		if (position < 0 || position + 1 > this.stopPositions.Length)
		{
			position = 0;
		}
		return position + 1;
	}

	// Token: 0x04001B3A RID: 6970
	public float[] stopPositions;

	// Token: 0x04001B3B RID: 6971
	public Transform chainsParent;

	// Token: 0x04001B3C RID: 6972
	private List<Transform> chains;
}
