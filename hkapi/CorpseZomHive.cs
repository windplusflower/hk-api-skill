using System;
using UnityEngine;

// Token: 0x02000170 RID: 368
public class CorpseZomHive : CorpseChunker
{
	// Token: 0x0600087C RID: 2172 RVA: 0x0002EAA8 File Offset: 0x0002CCA8
	protected override void LandEffects()
	{
		base.LandEffects();
		GameObject gameObject = GameObject.FindWithTag("Extra Tag");
		if (gameObject)
		{
			for (int i = 0; i < 3; i++)
			{
				int index = UnityEngine.Random.Range(0, gameObject.transform.childCount);
				Transform child = gameObject.transform.GetChild(index);
				if (child)
				{
					child.SetParent(null);
					child.position = base.transform.position;
					FSMUtility.SendEventToGameObject(child.gameObject, "SPAWN", false);
					FlingUtils.FlingObject(new FlingUtils.SelfConfig
					{
						Object = child.gameObject,
						SpeedMin = 5f,
						SpeedMax = 10f,
						AngleMin = 0f,
						AngleMax = 180f
					}, base.transform, Vector3.zero);
				}
			}
		}
	}
}
