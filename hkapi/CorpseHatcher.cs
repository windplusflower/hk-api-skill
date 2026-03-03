using System;
using UnityEngine;

// Token: 0x0200016D RID: 365
public class CorpseHatcher : Corpse
{
	// Token: 0x06000871 RID: 2161 RVA: 0x0002E7CC File Offset: 0x0002C9CC
	protected override void Smash()
	{
		if (!this.hitAcid)
		{
			GlobalPrefabDefaults.Instance.SpawnBlood(base.transform.position, 40, 40, 15f, 20f, 75f, 105f, null);
			GameObject gameObject = GameObject.FindWithTag("Extra Tag");
			if (gameObject)
			{
				for (int i = 0; i < 2; i++)
				{
					int index = UnityEngine.Random.Range(0, gameObject.transform.childCount);
					Transform child = gameObject.transform.GetChild(index);
					if (child)
					{
						child.SetParent(null);
						child.position = base.transform.position;
						FSMUtility.SendEventToGameObject(child.gameObject, "SPAWN", false);
					}
				}
			}
		}
		base.Smash();
	}
}
