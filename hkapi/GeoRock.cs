using System;
using UnityEngine;
using UnityEngine.SceneManagement;

// Token: 0x020003C0 RID: 960
public class GeoRock : MonoBehaviour
{
	// Token: 0x06001611 RID: 5649 RVA: 0x000689C7 File Offset: 0x00066BC7
	private void OnEnable()
	{
		UnityEngine.SceneManagement.SceneManager.activeSceneChanged += this.LevelActivated;
		this.gm = GameManager.instance;
		this.gm.SavePersistentObjects += this.SaveState;
	}

	// Token: 0x06001612 RID: 5650 RVA: 0x000689FC File Offset: 0x00066BFC
	private void OnDisable()
	{
		UnityEngine.SceneManagement.SceneManager.activeSceneChanged -= this.LevelActivated;
		if (this.gm != null)
		{
			this.gm.SavePersistentObjects -= this.SaveState;
		}
	}

	// Token: 0x06001613 RID: 5651 RVA: 0x00068A34 File Offset: 0x00066C34
	private void Start()
	{
		this.SetMyID();
	}

	// Token: 0x06001614 RID: 5652 RVA: 0x00068A3C File Offset: 0x00066C3C
	private void LevelActivated(Scene sceneFrom, Scene sceneTo)
	{
		this.SetMyID();
		GeoRockData geoRockData = SceneData.instance.FindMyState(this.geoRockData);
		if (geoRockData != null)
		{
			this.geoRockData.hitsLeft = geoRockData.hitsLeft;
			base.GetComponent<PlayMakerFSM>().FsmVariables.GetFsmInt("Hits").Value = geoRockData.hitsLeft;
			return;
		}
		this.UpdateHitsLeftFromFSM();
	}

	// Token: 0x06001615 RID: 5653 RVA: 0x00068A9B File Offset: 0x00066C9B
	private void SaveState()
	{
		this.SetMyID();
		this.UpdateHitsLeftFromFSM();
		SceneData.instance.SaveMyState(this.geoRockData);
	}

	// Token: 0x06001616 RID: 5654 RVA: 0x00068ABC File Offset: 0x00066CBC
	private void SetMyID()
	{
		if (string.IsNullOrEmpty(this.geoRockData.id))
		{
			this.geoRockData.id = base.name;
		}
		if (string.IsNullOrEmpty(this.geoRockData.sceneName))
		{
			this.geoRockData.sceneName = GameManager.GetBaseSceneName(base.gameObject.scene.name);
		}
	}

	// Token: 0x06001617 RID: 5655 RVA: 0x00068B21 File Offset: 0x00066D21
	private void UpdateHitsLeftFromFSM()
	{
		this.geoRockData.hitsLeft = base.GetComponent<PlayMakerFSM>().FsmVariables.GetFsmInt("Hits").Value;
	}

	// Token: 0x04001A7A RID: 6778
	[SerializeField]
	public GeoRockData geoRockData;

	// Token: 0x04001A7B RID: 6779
	private GameManager gm;
}
