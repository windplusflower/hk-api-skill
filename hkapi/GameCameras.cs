using System;
using UnityEngine;
using UnityEngine.UI;
using UnityStandardAssets.ImageEffects;

// Token: 0x020000E5 RID: 229
public class GameCameras : MonoBehaviour
{
	// Token: 0x1700008D RID: 141
	// (get) Token: 0x060004C8 RID: 1224 RVA: 0x00018CA4 File Offset: 0x00016EA4
	// (set) Token: 0x060004C9 RID: 1225 RVA: 0x00018CAC File Offset: 0x00016EAC
	public SceneParticlesController sceneParticles { get; private set; }

	// Token: 0x1700008E RID: 142
	// (get) Token: 0x060004CA RID: 1226 RVA: 0x00018CB8 File Offset: 0x00016EB8
	public static GameCameras instance
	{
		get
		{
			if (GameCameras._instance == null)
			{
				GameCameras._instance = UnityEngine.Object.FindObjectOfType<GameCameras>();
				if (GameCameras._instance == null)
				{
					Debug.LogError("Couldn't find GameCameras, make sure one exists in the scene.");
				}
				else
				{
					UnityEngine.Object.DontDestroyOnLoad(GameCameras._instance.gameObject);
				}
			}
			return GameCameras._instance;
		}
	}

	// Token: 0x060004CB RID: 1227 RVA: 0x00018D09 File Offset: 0x00016F09
	private void Awake()
	{
		if (GameCameras._instance == null)
		{
			GameCameras._instance = this;
			UnityEngine.Object.DontDestroyOnLoad(this);
			return;
		}
		if (this != GameCameras._instance)
		{
			UnityEngine.Object.DestroyImmediate(base.gameObject);
			return;
		}
	}

	// Token: 0x060004CC RID: 1228 RVA: 0x00018D3E File Offset: 0x00016F3E
	private void Start()
	{
		this.gs.LoadOverscanSettings();
		this.SetOverscan(this.gs.overScanAdjustment);
	}

	// Token: 0x060004CD RID: 1229 RVA: 0x00018D5C File Offset: 0x00016F5C
	public void SceneInit()
	{
		if (this == GameCameras._instance)
		{
			this.StartScene();
		}
	}

	// Token: 0x060004CE RID: 1230 RVA: 0x00018D71 File Offset: 0x00016F71
	private void OnDestroy()
	{
		UnityEngine.Object.DestroyImmediate(this.sceneParticles);
	}

	// Token: 0x060004CF RID: 1231 RVA: 0x00018D80 File Offset: 0x00016F80
	private void SetupGameRefs()
	{
		this.gm = GameManager.instance;
		this.gs = this.gm.gameSettings;
		this.canvasScaler = UIManager.instance.canvasScaler;
		if (this.cameraController != null)
		{
			this.cameraController.GameInit();
		}
		else
		{
			Debug.LogError("CameraController not set in inspector.");
		}
		if (this.cameraTarget != null)
		{
			this.cameraTarget.GameInit();
		}
		else
		{
			Debug.LogError("CameraTarget not set in inspector.");
		}
		if (this.sceneParticlesPrefab != null)
		{
			this.sceneParticles = UnityEngine.Object.Instantiate<SceneParticlesController>(this.sceneParticlesPrefab);
			this.sceneParticles.name = "SceneParticlesController";
			this.sceneParticles.transform.position = new Vector3(this.tk2dCam.transform.position.x, this.tk2dCam.transform.position.y, 0f);
			this.sceneParticles.transform.SetParent(this.tk2dCam.transform);
		}
		else
		{
			Debug.LogError("Scene Particles Prefab not set in inspector.");
		}
		if (this.sceneColorManager != null)
		{
			this.sceneColorManager.GameInit();
		}
		else
		{
			Debug.LogError("SceneColorManager not set in inspector.");
		}
		this.init = true;
	}

	// Token: 0x060004D0 RID: 1232 RVA: 0x00018ECC File Offset: 0x000170CC
	private void StartScene()
	{
		if (!this.init)
		{
			this.SetupGameRefs();
		}
		if (this.gm.IsGameplayScene() || this.gm.ShouldKeepHUDCameraActive())
		{
			this.MoveMenuToHUDCamera();
			if (!this.hudCamera.gameObject.activeSelf)
			{
				this.hudCamera.gameObject.SetActive(true);
			}
		}
		else
		{
			this.DisableHUDCamIfAllowed();
		}
		if (this.gm.IsMenuScene())
		{
			this.cameraController.transform.SetPosition2D(14.6f, 8.5f);
		}
		else if (this.gm.IsCinematicScene())
		{
			this.cameraController.transform.SetPosition2D(14.6f, 8.5f);
		}
		else if (this.gm.IsNonGameplayScene())
		{
			if (this.gm.IsBossDoorScene())
			{
				this.cameraController.transform.SetPosition2D(17.5f, 17.5f);
			}
			else if (InGameCutsceneInfo.IsInCutscene)
			{
				this.cameraController.transform.SetPosition2D(InGameCutsceneInfo.CameraPosition);
			}
			else
			{
				this.cameraController.transform.SetPosition2D(14.6f, 8.5f);
			}
		}
		this.cameraController.SceneInit();
		this.cameraTarget.SceneInit();
		this.sceneColorManager.SceneInit();
		this.sceneParticles.SceneInit();
	}

	// Token: 0x060004D1 RID: 1233 RVA: 0x00019024 File Offset: 0x00017224
	public void MoveMenuToHUDCamera()
	{
		int cullingMask = this.mainCamera.cullingMask;
		int cullingMask2 = this.hudCamera.cullingMask;
		UIManager.instance.UICanvas.worldCamera = this.hudCamera;
		UIManager.instance.UICanvas.renderMode = RenderMode.ScreenSpaceCamera;
		this.mainCamera.cullingMask = (cullingMask ^ 134217728);
		this.hudCamera.cullingMask = (cullingMask2 | 134217728);
	}

	// Token: 0x060004D2 RID: 1234 RVA: 0x00019094 File Offset: 0x00017294
	public void DisableHUDCamIfAllowed()
	{
		if (this.gm.IsNonGameplayScene() && !this.gm.IsStagTravelScene() && !this.gm.IsBossDoorScene() && !this.gm.ShouldKeepHUDCameraActive())
		{
			this.hudCamera.gameObject.SetActive(false);
		}
	}

	// Token: 0x060004D3 RID: 1235 RVA: 0x000190E6 File Offset: 0x000172E6
	public void StopCameraShake()
	{
		this.cameraShakeFSM.Fsm.Event("CANCEL SHAKE");
	}

	// Token: 0x060004D4 RID: 1236 RVA: 0x000190FD File Offset: 0x000172FD
	public void ResumeCameraShake()
	{
		this.cameraShakeFSM.Fsm.Event("RESUME SHAKE");
	}

	// Token: 0x060004D5 RID: 1237 RVA: 0x00019114 File Offset: 0x00017314
	public void DisableImageEffects()
	{
		this.mainCamera.GetComponent<FastNoise>().enabled = false;
		this.mainCamera.GetComponent<BloomOptimized>().enabled = false;
		this.mainCamera.GetComponent<ColorCorrectionCurves>().enabled = false;
	}

	// Token: 0x060004D6 RID: 1238 RVA: 0x00019149 File Offset: 0x00017349
	public void EnableImageEffects(bool isGameplayLevel, bool isBloomForced)
	{
		this.mainCamera.GetComponent<ColorCorrectionCurves>().enabled = true;
		this.cameraController.ApplyEffectConfiguration(isGameplayLevel, isBloomForced);
	}

	// Token: 0x060004D7 RID: 1239 RVA: 0x0001916C File Offset: 0x0001736C
	public void SetOverscan(float value)
	{
		if (!this.init)
		{
			this.SetupGameRefs();
		}
		base.Invoke("TestParentForPosition", 0.33f * Time.timeScale);
		float num = (float)Screen.width / (float)Screen.height;
		if (this.canvasScaler == null)
		{
			this.canvasScaler = UIManager.instance.canvasScaler;
		}
		this.canvasScaler.referenceResolution = new Vector2(1920f * (1f - value) + -220f * value, 1080f * (1f - value) + 1f / num * (-220f * value));
		this.forceCameraAspect.SetOverscanViewport(value);
		this.gs.overScanAdjustment = value;
	}

	// Token: 0x060004D8 RID: 1240 RVA: 0x00019224 File Offset: 0x00017424
	public void TestParentForPosition()
	{
		if (this.cameraParent.transform.localPosition.z != 0f)
		{
			this.cameraParent.transform.localPosition = new Vector3(this.cameraParent.transform.localPosition.x, this.cameraParent.transform.localPosition.y, 0f);
		}
	}

	// Token: 0x060004DA RID: 1242 RVA: 0x00019294 File Offset: 0x00017494
	public static GameCameras orig_get_instance()
	{
		if (GameCameras._instance == null)
		{
			GameCameras._instance = UnityEngine.Object.FindObjectOfType<GameCameras>();
			if (GameCameras._instance == null)
			{
				Debug.LogError("Couldn't find GameCameras, make sure one exists in the scene.");
			}
			UnityEngine.Object.DontDestroyOnLoad(GameCameras._instance.gameObject);
		}
		return GameCameras._instance;
	}

	// Token: 0x04000493 RID: 1171
	[Header("Cameras")]
	public Camera hudCamera;

	// Token: 0x04000494 RID: 1172
	public Camera mainCamera;

	// Token: 0x04000495 RID: 1173
	[Header("Controllers")]
	public CameraController cameraController;

	// Token: 0x04000496 RID: 1174
	public CameraTarget cameraTarget;

	// Token: 0x04000497 RID: 1175
	public ForceCameraAspect forceCameraAspect;

	// Token: 0x04000498 RID: 1176
	[Header("FSMs")]
	public PlayMakerFSM cameraFadeFSM;

	// Token: 0x04000499 RID: 1177
	public PlayMakerFSM cameraShakeFSM;

	// Token: 0x0400049A RID: 1178
	public PlayMakerFSM soulOrbFSM;

	// Token: 0x0400049B RID: 1179
	public PlayMakerFSM soulVesselFSM;

	// Token: 0x0400049C RID: 1180
	public PlayMakerFSM openStagFSM;

	// Token: 0x0400049D RID: 1181
	[Header("Camera Effects")]
	public ColorCorrectionCurves colorCorrectionCurves;

	// Token: 0x0400049E RID: 1182
	public SceneColorManager sceneColorManager;

	// Token: 0x0400049F RID: 1183
	public BrightnessEffect brightnessEffect;

	// Token: 0x040004A0 RID: 1184
	public SceneParticlesController sceneParticlesPrefab;

	// Token: 0x040004A2 RID: 1186
	[Header("Other")]
	public tk2dCamera tk2dCam;

	// Token: 0x040004A3 RID: 1187
	public GameObject hudCanvas;

	// Token: 0x040004A4 RID: 1188
	public Transform cameraParent;

	// Token: 0x040004A5 RID: 1189
	public GeoCounter geoCounter;

	// Token: 0x040004A6 RID: 1190
	private GameManager gm;

	// Token: 0x040004A7 RID: 1191
	private GameSettings gs;

	// Token: 0x040004A8 RID: 1192
	private CanvasScaler canvasScaler;

	// Token: 0x040004A9 RID: 1193
	private bool init;

	// Token: 0x040004AA RID: 1194
	private static GameCameras _instance;
}
