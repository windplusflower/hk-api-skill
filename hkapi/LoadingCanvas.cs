using System;
using UnityEngine;

// Token: 0x02000473 RID: 1139
public class LoadingCanvas : MonoBehaviour
{
	// Token: 0x06001996 RID: 6550 RVA: 0x00079DFC File Offset: 0x00077FFC
	protected void Start()
	{
		for (int i = 0; i < this.visualizationContainers.Length; i++)
		{
			GameObject gameObject = this.visualizationContainers[i];
			if (!(gameObject == null))
			{
				gameObject.SetActive(false);
			}
		}
	}

	// Token: 0x06001997 RID: 6551 RVA: 0x00079E38 File Offset: 0x00078038
	protected void Update()
	{
		GameManager unsafeInstance = GameManager.UnsafeInstance;
		if (unsafeInstance != null && this.isLoading != unsafeInstance.IsLoadingSceneTransition)
		{
			this.isLoading = unsafeInstance.IsLoadingSceneTransition;
			if (this.isLoading)
			{
				this.defaultLoadingSpinner.DisplayDelayAdjustment = ((unsafeInstance.LoadVisualization == GameManager.SceneLoadVisualizations.ContinueFromSave) ? this.continueFromSaveDelayAdjustment : 0f);
				GameObject y = null;
				if (unsafeInstance.LoadVisualization >= GameManager.SceneLoadVisualizations.Default && unsafeInstance.LoadVisualization < (GameManager.SceneLoadVisualizations)this.visualizationContainers.Length)
				{
					y = this.visualizationContainers[(int)unsafeInstance.LoadVisualization];
				}
				for (int i = 0; i < this.visualizationContainers.Length; i++)
				{
					GameObject gameObject = this.visualizationContainers[i];
					if (!(gameObject == null))
					{
						gameObject.SetActive(gameObject == y);
					}
				}
			}
		}
	}

	// Token: 0x04001EB8 RID: 7864
	[SerializeField]
	[ArrayForEnum(typeof(GameManager.SceneLoadVisualizations))]
	private GameObject[] visualizationContainers;

	// Token: 0x04001EB9 RID: 7865
	private bool isLoading;

	// Token: 0x04001EBA RID: 7866
	private GameManager.SceneLoadVisualizations loadingVisualization;

	// Token: 0x04001EBB RID: 7867
	[SerializeField]
	private LoadingSpinner defaultLoadingSpinner;

	// Token: 0x04001EBC RID: 7868
	[SerializeField]
	private float continueFromSaveDelayAdjustment;
}
