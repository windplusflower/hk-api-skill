using System;
using System.Collections.Generic;
using GlobalEnums;
using UnityEngine;
using UnityEngine.Audio;

// Token: 0x02000422 RID: 1058
public class TransitionPoint : MonoBehaviour
{
	// Token: 0x14000033 RID: 51
	// (add) Token: 0x060017D6 RID: 6102 RVA: 0x0007072C File Offset: 0x0006E92C
	// (remove) Token: 0x060017D7 RID: 6103 RVA: 0x00070764 File Offset: 0x0006E964
	public event TransitionPoint.BeforeTransitionEvent OnBeforeTransition;

	// Token: 0x17000314 RID: 788
	// (get) Token: 0x060017D8 RID: 6104 RVA: 0x00070799 File Offset: 0x0006E999
	public static List<TransitionPoint> TransitionPoints
	{
		get
		{
			return TransitionPoint.transitionPoints;
		}
	}

	// Token: 0x060017D9 RID: 6105 RVA: 0x000707A0 File Offset: 0x0006E9A0
	[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.BeforeSceneLoad)]
	private static void Init()
	{
		TransitionPoint.transitionPoints = new List<TransitionPoint>();
	}

	// Token: 0x060017DA RID: 6106 RVA: 0x000707AC File Offset: 0x0006E9AC
	protected void Awake()
	{
		TransitionPoint.transitionPoints.Add(this);
	}

	// Token: 0x060017DB RID: 6107 RVA: 0x000707B9 File Offset: 0x0006E9B9
	protected void OnDestroy()
	{
		TransitionPoint.transitionPoints.Remove(this);
	}

	// Token: 0x060017DC RID: 6108 RVA: 0x000707C8 File Offset: 0x0006E9C8
	private void Start()
	{
		this.gm = GameManager.instance;
		this.playerData = PlayerData.instance;
		if (!this.nonHazardGate && this.respawnMarker == null)
		{
			Debug.LogError(string.Concat(new string[]
			{
				"Transition Gate ",
				base.name,
				" in ",
				this.gm.sceneName,
				" does not have its respawn marker set in inspector."
			}));
		}
	}

	// Token: 0x060017DD RID: 6109 RVA: 0x00070840 File Offset: 0x0006EA40
	private void OnTriggerEnter2D(Collider2D movingObj)
	{
		if (!this.isADoor && movingObj.gameObject.layer == 9 && this.gm.gameState == GameState.PLAYING)
		{
			if (!string.IsNullOrEmpty(this.targetScene) && !string.IsNullOrEmpty(this.entryPoint))
			{
				if (this.customFadeFSM)
				{
					this.customFadeFSM.SendEvent("FADE");
				}
				if (this.atmosSnapshot != null)
				{
					this.atmosSnapshot.TransitionTo(1.5f);
				}
				if (this.enviroSnapshot != null)
				{
					this.enviroSnapshot.TransitionTo(1.5f);
				}
				if (this.actorSnapshot != null)
				{
					this.actorSnapshot.TransitionTo(1.5f);
				}
				if (this.musicSnapshot != null)
				{
					this.musicSnapshot.TransitionTo(1.5f);
				}
				this.activated = true;
				TransitionPoint.lastEntered = base.gameObject.name;
				if (this.OnBeforeTransition != null)
				{
					this.OnBeforeTransition();
				}
				this.gm.BeginSceneTransition(new GameManager.SceneLoadInfo
				{
					SceneName = this.targetScene,
					EntryGateName = this.entryPoint,
					HeroLeaveDirection = new GatePosition?(this.GetGatePosition()),
					EntryDelay = this.entryDelay,
					WaitForSceneTransitionCameraFade = true,
					PreventCameraFadeOut = (this.customFadeFSM != null),
					Visualization = this.sceneLoadVisualization,
					AlwaysUnloadUnusedAssets = this.alwaysUnloadUnusedAssets,
					forceWaitFetch = this.forceWaitFetch
				});
				return;
			}
			Debug.LogError(this.gm.sceneName + " " + base.name + " no target scene has been set on this gate.");
		}
	}

	// Token: 0x060017DE RID: 6110 RVA: 0x00070A02 File Offset: 0x0006EC02
	private void OnTriggerStay2D(Collider2D movingObj)
	{
		if (!this.activated)
		{
			this.OnTriggerEnter2D(movingObj);
		}
	}

	// Token: 0x060017DF RID: 6111 RVA: 0x00070A14 File Offset: 0x0006EC14
	private void OnDrawGizmos()
	{
		if (base.transform != null)
		{
			Vector3 position = base.transform.position + new Vector3(0f, base.GetComponent<BoxCollider2D>().bounds.extents.y + 1.5f, 0f);
			GizmoUtility.DrawText(GUI.skin, this.targetScene, position, new Color?(this.myGreen), 10, 0f);
		}
	}

	// Token: 0x060017E0 RID: 6112 RVA: 0x00070A9C File Offset: 0x0006EC9C
	public GatePosition GetGatePosition()
	{
		string name = base.name;
		if (name.Contains("top"))
		{
			return GatePosition.top;
		}
		if (name.Contains("right"))
		{
			return GatePosition.right;
		}
		if (name.Contains("left"))
		{
			return GatePosition.left;
		}
		if (name.Contains("bot"))
		{
			return GatePosition.bottom;
		}
		if (name.Contains("door") || this.isADoor)
		{
			return GatePosition.door;
		}
		Debug.LogError("Gate name " + name + "does not conform to a valid gate position type. Make sure gate name has the form 'left1'");
		return GatePosition.unknown;
	}

	// Token: 0x060017E1 RID: 6113 RVA: 0x00070B19 File Offset: 0x0006ED19
	public void SetTargetScene(string newScene)
	{
		this.targetScene = newScene;
	}

	// Token: 0x060017E2 RID: 6114 RVA: 0x00070B22 File Offset: 0x0006ED22
	public TransitionPoint()
	{
		this.myGreen = new Color(0f, 0.8f, 0f, 0.5f);
		base..ctor();
	}

	// Token: 0x060017E3 RID: 6115 RVA: 0x00070B49 File Offset: 0x0006ED49
	// Note: this type is marked as 'beforefieldinit'.
	static TransitionPoint()
	{
		TransitionPoint.lastEntered = "";
	}

	// Token: 0x04001CA0 RID: 7328
	private GameManager gm;

	// Token: 0x04001CA1 RID: 7329
	private PlayerData playerData;

	// Token: 0x04001CA2 RID: 7330
	private bool activated;

	// Token: 0x04001CA3 RID: 7331
	[Header("Door Type Gate Settings")]
	[Space(5f)]
	public bool isADoor;

	// Token: 0x04001CA4 RID: 7332
	public bool dontWalkOutOfDoor;

	// Token: 0x04001CA5 RID: 7333
	[Header("Gate Entry")]
	[Tooltip("The wait time before entering from this gate (not the target gate).")]
	public float entryDelay;

	// Token: 0x04001CA6 RID: 7334
	public bool alwaysEnterRight;

	// Token: 0x04001CA7 RID: 7335
	public bool alwaysEnterLeft;

	// Token: 0x04001CA8 RID: 7336
	[Header("Force Hard Land (Top Gates Only)")]
	[Space(5f)]
	public bool hardLandOnExit;

	// Token: 0x04001CA9 RID: 7337
	[Header("Destination Scene")]
	[Space(5f)]
	public string targetScene;

	// Token: 0x04001CAA RID: 7338
	public string entryPoint;

	// Token: 0x04001CAB RID: 7339
	public Vector2 entryOffset;

	// Token: 0x04001CAC RID: 7340
	[SerializeField]
	private bool alwaysUnloadUnusedAssets;

	// Token: 0x04001CAD RID: 7341
	public PlayMakerFSM customFadeFSM;

	// Token: 0x04001CAE RID: 7342
	[Header("Hazard Respawn")]
	[Space(5f)]
	public bool nonHazardGate;

	// Token: 0x04001CAF RID: 7343
	public HazardRespawnMarker respawnMarker;

	// Token: 0x04001CB0 RID: 7344
	[Header("Set Audio Snapshots")]
	[Space(5f)]
	public AudioMixerSnapshot atmosSnapshot;

	// Token: 0x04001CB1 RID: 7345
	public AudioMixerSnapshot enviroSnapshot;

	// Token: 0x04001CB2 RID: 7346
	public AudioMixerSnapshot actorSnapshot;

	// Token: 0x04001CB3 RID: 7347
	public AudioMixerSnapshot musicSnapshot;

	// Token: 0x04001CB4 RID: 7348
	private Color myGreen;

	// Token: 0x04001CB5 RID: 7349
	[Header("Cosmetics")]
	public GameManager.SceneLoadVisualizations sceneLoadVisualization;

	// Token: 0x04001CB6 RID: 7350
	public bool customFade;

	// Token: 0x04001CB7 RID: 7351
	public bool forceWaitFetch;

	// Token: 0x04001CB8 RID: 7352
	private static List<TransitionPoint> transitionPoints;

	// Token: 0x04001CB9 RID: 7353
	public static string lastEntered;

	// Token: 0x02000423 RID: 1059
	// (Invoke) Token: 0x060017E5 RID: 6117
	public delegate void BeforeTransitionEvent();
}
