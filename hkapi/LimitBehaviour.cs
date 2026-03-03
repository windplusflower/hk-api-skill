using System;
using System.Collections.Generic;
using UnityEngine;

// Token: 0x020001BF RID: 447
public class LimitBehaviour : MonoBehaviour
{
	// Token: 0x060009E6 RID: 2534 RVA: 0x00036EC0 File Offset: 0x000350C0
	private void OnDisable()
	{
		this.RemoveSelf();
		if (LimitBehaviour.behaviourLists.Count > 0)
		{
			bool flag = true;
			foreach (KeyValuePair<string, List<GameObject>> keyValuePair in LimitBehaviour.behaviourLists)
			{
				if (keyValuePair.Value.Count > 0)
				{
					flag = false;
					break;
				}
			}
			if (flag)
			{
				LimitBehaviour.behaviourLists.Clear();
			}
		}
	}

	// Token: 0x060009E7 RID: 2535 RVA: 0x00036F40 File Offset: 0x00035140
	public void Add()
	{
		if (this.id != "")
		{
			List<GameObject> list;
			if (!LimitBehaviour.behaviourLists.ContainsKey(this.id))
			{
				list = new List<GameObject>();
				LimitBehaviour.behaviourLists.Add(this.id, list);
			}
			else
			{
				list = LimitBehaviour.behaviourLists[this.id];
			}
			if (!list.Contains(base.gameObject))
			{
				list.Add(base.gameObject);
				if (list.Count > 5)
				{
					this.RemoveFirst();
				}
			}
		}
	}

	// Token: 0x060009E8 RID: 2536 RVA: 0x00036FC8 File Offset: 0x000351C8
	public void RemoveFirst()
	{
		if (this.id != "" && LimitBehaviour.behaviourLists.ContainsKey(this.id))
		{
			List<GameObject> list = LimitBehaviour.behaviourLists[this.id];
			GameObject go = list[0];
			list.RemoveAt(0);
			FSMUtility.SendEventToGameObject(go, this.forceRemoveEvent, false);
		}
	}

	// Token: 0x060009E9 RID: 2537 RVA: 0x00037024 File Offset: 0x00035224
	public void RemoveSelf()
	{
		if (this.id != "" && LimitBehaviour.behaviourLists.ContainsKey(this.id) && LimitBehaviour.behaviourLists[this.id].Contains(base.gameObject))
		{
			LimitBehaviour.behaviourLists[this.id].Remove(base.gameObject);
		}
	}

	// Token: 0x060009EA RID: 2538 RVA: 0x0003708E File Offset: 0x0003528E
	public LimitBehaviour()
	{
		this.id = "";
		this.limit = 5;
		this.forceRemoveEvent = "REMOVE";
		base..ctor();
	}

	// Token: 0x060009EB RID: 2539 RVA: 0x000370B3 File Offset: 0x000352B3
	// Note: this type is marked as 'beforefieldinit'.
	static LimitBehaviour()
	{
		LimitBehaviour.behaviourLists = new Dictionary<string, List<GameObject>>();
	}

	// Token: 0x04000B11 RID: 2833
	public static Dictionary<string, List<GameObject>> behaviourLists;

	// Token: 0x04000B12 RID: 2834
	public string id;

	// Token: 0x04000B13 RID: 2835
	public int limit;

	// Token: 0x04000B14 RID: 2836
	public string forceRemoveEvent;
}
