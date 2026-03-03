using System;
using UnityEngine;

// Token: 0x02000139 RID: 313
public class HardLandEffect : MonoBehaviour
{
	// Token: 0x0600074F RID: 1871 RVA: 0x00029A80 File Offset: 0x00027C80
	private void OnEnable()
	{
		this.dustObj.SetActive(false);
		this.dustObj.SetActiveChildren(true);
		this.grassObj.SetActive(false);
		this.grassObj.SetActiveChildren(true);
		this.boneObj.SetActive(false);
		this.boneObj.SetActiveChildren(true);
		this.spaObj.SetActive(false);
		this.spaObj.SetActiveChildren(true);
		this.metalObj.SetActive(false);
		this.metalObj.SetActiveChildren(true);
		this.wetObj.SetActive(false);
		this.wetObj.SetActiveChildren(true);
		GameCameras.instance.cameraShakeFSM.SendEvent("AverageShake");
		bool flag = false;
		switch (GameManager.instance.playerData.GetInt("environmentType"))
		{
		case 0:
			this.dustObj.SetActive(true);
			flag = true;
			break;
		case 1:
			this.grassObj.SetActive(true);
			flag = true;
			break;
		case 2:
			this.boneObj.SetActive(true);
			flag = true;
			break;
		case 3:
			this.spaObj.SetActive(true);
			if (this.spatterWhitePrefab)
			{
				FlingUtils.SpawnAndFling(new FlingUtils.Config
				{
					Prefab = this.spatterWhitePrefab,
					AmountMin = 50,
					AmountMax = 50,
					SpeedMin = 10f,
					SpeedMax = 30f,
					AngleMin = 85f,
					AngleMax = 95f,
					OriginVariationX = 1f,
					OriginVariationY = 0f
				}, base.transform, new Vector3(0f, -0.9f, 0f));
			}
			break;
		case 4:
			this.metalObj.SetActive(true);
			break;
		case 6:
			this.wetObj.SetActive(true);
			break;
		}
		if (flag && this.particleRockPrefab)
		{
			FlingUtils.SpawnAndFling(new FlingUtils.Config
			{
				Prefab = this.particleRockPrefab,
				AmountMin = 2,
				AmountMax = 3,
				SpeedMin = 12f,
				SpeedMax = 15f,
				AngleMin = 95f,
				AngleMax = 140f
			}, base.transform, new Vector3(0f, -0.9f, 0f));
			FlingUtils.SpawnAndFling(new FlingUtils.Config
			{
				Prefab = this.particleRockPrefab,
				AmountMin = 2,
				AmountMax = 3,
				SpeedMin = 12f,
				SpeedMax = 15f,
				AngleMin = 40f,
				AngleMax = 85f
			}, base.transform, new Vector3(0f, -0.9f, 0f));
		}
		this.recycleTime = Time.time + 1.5f;
	}

	// Token: 0x06000750 RID: 1872 RVA: 0x00029D83 File Offset: 0x00027F83
	private void Update()
	{
		if (Time.time > this.recycleTime)
		{
			base.gameObject.Recycle();
		}
	}

	// Token: 0x04000816 RID: 2070
	public GameObject dustObj;

	// Token: 0x04000817 RID: 2071
	public GameObject grassObj;

	// Token: 0x04000818 RID: 2072
	public GameObject boneObj;

	// Token: 0x04000819 RID: 2073
	public GameObject spaObj;

	// Token: 0x0400081A RID: 2074
	public GameObject metalObj;

	// Token: 0x0400081B RID: 2075
	public GameObject wetObj;

	// Token: 0x0400081C RID: 2076
	[Space]
	public GameObject particleRockPrefab;

	// Token: 0x0400081D RID: 2077
	public GameObject spatterWhitePrefab;

	// Token: 0x0400081E RID: 2078
	private float recycleTime;
}
