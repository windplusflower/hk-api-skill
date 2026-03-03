using System;
using UnityEngine;
using UnityEngine.UI;

namespace Modding
{
	// Token: 0x02000D99 RID: 3481
	internal class ProgressBar : MonoBehaviour
	{
		/// <summary>
		///     Updates the progress of the loading bar to the given progress.
		/// </summary>
		/// <param name="value">The progress that should be displayed. 0.0f-1.0f</param>
		// Token: 0x1700075B RID: 1883
		// (get) Token: 0x06004845 RID: 18501 RVA: 0x00187CB0 File Offset: 0x00185EB0
		// (set) Token: 0x06004846 RID: 18502 RVA: 0x00187CB8 File Offset: 0x00185EB8
		public float Progress
		{
			get
			{
				return this._commandedProgress;
			}
			set
			{
				this._commandedProgress = value;
			}
		}

		// Token: 0x06004847 RID: 18503 RVA: 0x00187CC1 File Offset: 0x00185EC1
		public void Start()
		{
			this.CreateBlanker();
			this.CreateLoadingBarBackground();
			this.CreateLoadingBar();
		}

		// Token: 0x06004848 RID: 18504 RVA: 0x00187CD5 File Offset: 0x00185ED5
		private static float ExpDecay(float a, float b, float decay)
		{
			return b + (a - b) * Mathf.Exp(-decay * Time.deltaTime);
		}

		// Token: 0x06004849 RID: 18505 RVA: 0x00187CEA File Offset: 0x00185EEA
		public void Update()
		{
			this._shownProgress = ProgressBar.ExpDecay(this._shownProgress, this._commandedProgress, 16f);
		}

		// Token: 0x0600484A RID: 18506 RVA: 0x00187D08 File Offset: 0x00185F08
		public void LateUpdate()
		{
			this._loadingBarRect.sizeDelta = new Vector2(this._shownProgress * 976f, this._loadingBarRect.sizeDelta.y);
		}

		/// <summary>
		///     Creates the canvas used to show the loading progress.
		///     It is centered on the screen.
		/// </summary>
		// Token: 0x0600484B RID: 18507 RVA: 0x00187D38 File Offset: 0x00185F38
		private void CreateBlanker()
		{
			this._blanker = CanvasUtil.CreateCanvas(RenderMode.ScreenSpaceOverlay, new Vector2(1920f, 1080f));
			UnityEngine.Object.DontDestroyOnLoad(this._blanker);
			CanvasUtil.CreateImagePanel(this._blanker, CanvasUtil.NullSprite(new byte[]
			{
				0,
				0,
				0,
				byte.MaxValue
			}), new CanvasUtil.RectData(Vector2.zero, Vector2.zero, Vector2.zero, Vector2.one)).GetComponent<Image>().preserveAspect = false;
		}

		/// <summary>
		///     Creates the background of the loading bar.
		///     It is centered in the canvas.
		/// </summary>
		// Token: 0x0600484C RID: 18508 RVA: 0x00187DB0 File Offset: 0x00185FB0
		private void CreateLoadingBarBackground()
		{
			this._loadingBarBackground = CanvasUtil.CreateImagePanel(this._blanker, CanvasUtil.NullSprite(new byte[]
			{
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue
			}), new CanvasUtil.RectData(new Vector2(1000f, 100f), Vector2.zero, new Vector2(0.5f, 0.5f), new Vector2(0.5f, 0.5f)));
			this._loadingBarBackground.GetComponent<Image>().preserveAspect = false;
		}

		/// <summary>
		///     Creates the loading bar with an initial width of 0.
		///     It is centered in the canvas.
		/// </summary>
		// Token: 0x0600484D RID: 18509 RVA: 0x00187E2C File Offset: 0x0018602C
		private void CreateLoadingBar()
		{
			this._loadingBar = CanvasUtil.CreateImagePanel(this._blanker, CanvasUtil.NullSprite(new byte[]
			{
				153,
				153,
				153,
				byte.MaxValue
			}), new CanvasUtil.RectData(new Vector2(0f, 76f), Vector2.zero, new Vector2(0.5f, 0.5f), new Vector2(0.5f, 0.5f)));
			this._loadingBar.GetComponent<Image>().preserveAspect = false;
			this._loadingBarRect = this._loadingBar.GetComponent<RectTransform>();
		}

		// Token: 0x0600484E RID: 18510 RVA: 0x00187EB9 File Offset: 0x001860B9
		private void OnDestroy()
		{
			UnityEngine.Object.Destroy(this._loadingBar);
			UnityEngine.Object.Destroy(this._loadingBarBackground);
			UnityEngine.Object.Destroy(this._blanker);
		}

		// Token: 0x04004C6F RID: 19567
		private const int CanvasResolutionWidth = 1920;

		// Token: 0x04004C70 RID: 19568
		private const int CanvasResolutionHeight = 1080;

		// Token: 0x04004C71 RID: 19569
		private const int LoadingBarBackgroundWidth = 1000;

		// Token: 0x04004C72 RID: 19570
		private const int LoadingBarBackgroundHeight = 100;

		// Token: 0x04004C73 RID: 19571
		private const int LoadingBarMargin = 12;

		// Token: 0x04004C74 RID: 19572
		private const int LoadingBarWidth = 976;

		// Token: 0x04004C75 RID: 19573
		private const int LoadingBarHeight = 76;

		// Token: 0x04004C76 RID: 19574
		private GameObject _blanker;

		// Token: 0x04004C77 RID: 19575
		private GameObject _loadingBarBackground;

		// Token: 0x04004C78 RID: 19576
		private GameObject _loadingBar;

		// Token: 0x04004C79 RID: 19577
		private RectTransform _loadingBarRect;

		// Token: 0x04004C7A RID: 19578
		private float _commandedProgress;

		// Token: 0x04004C7B RID: 19579
		private float _shownProgress;
	}
}
