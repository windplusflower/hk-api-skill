using System;
using System.Collections;
using UnityEngine;

// Token: 0x020000CF RID: 207
public class BridgeLever : MonoBehaviour
{
	// Token: 0x06000439 RID: 1081 RVA: 0x00014A87 File Offset: 0x00012C87
	private void Awake()
	{
		this.anim = base.GetComponent<tk2dSpriteAnimator>();
		this.source = base.GetComponent<AudioSource>();
	}

	// Token: 0x0600043A RID: 1082 RVA: 0x00014AA4 File Offset: 0x00012CA4
	private void Start()
	{
		this.activated = GameManager.instance.playerData.GetBool(this.playerDataBool);
		if (this.activated)
		{
			this.bridgeCollider.enabled = true;
			BridgeSection[] array = this.sections;
			for (int i = 0; i < array.Length; i++)
			{
				array[i].Open(this, false);
			}
			this.anim.Play("Lever Activated");
			return;
		}
		this.bridgeCollider.enabled = false;
	}

	// Token: 0x0600043B RID: 1083 RVA: 0x00014B1C File Offset: 0x00012D1C
	private void OnTriggerEnter2D(Collider2D collision)
	{
		if (!this.activated && collision.tag == "Nail Attack")
		{
			this.activated = true;
			base.StartCoroutine(this.OpenBridge());
		}
	}

	// Token: 0x0600043C RID: 1084 RVA: 0x00014B4C File Offset: 0x00012D4C
	private IEnumerator OpenBridge()
	{
		GameManager.instance.playerData.SetBool(this.playerDataBool, true);
		this.switchSound.SpawnAndPlayOneShot(this.audioPlayerPrefab, this.transform.position);
		GameManager.instance.FreezeMoment(1);
		GameCameras.instance.cameraShakeFSM.SendEvent("EnemyKillShake");
		if (this.strikeNailPrefab)
		{
			this.strikeNailPrefab.Spawn(this.hitOrigin.position);
		}
		this.anim.Play("Lever Hit");
		this.bridgeCollider.enabled = true;
		yield return new WaitForSeconds(0.1f);
		FSMUtility.SetBool(GameCameras.instance.cameraShakeFSM, "RumblingMed", true);
		PlayMakerFSM playMakerFSM = PlayMakerFSM.FindFsmOnGameObject(HeroController.instance.gameObject, "Roar Lock");
		if (playMakerFSM)
		{
			playMakerFSM.FsmVariables.FindFsmGameObject("Roar Object").Value = this.gameObject;
		}
		FSMUtility.SendEventToGameObject(HeroController.instance.gameObject, "ROAR ENTER", false);
		BridgeSection[] array = this.sections;
		for (int i = 0; i < array.Length; i++)
		{
			array[i].Open(this, true);
		}
		this.source.Play();
		yield return new WaitForSeconds(3.25f);
		this.source.Stop();
		FSMUtility.SetBool(GameCameras.instance.cameraShakeFSM, "RumblingMed", false);
		GameCameras.instance.cameraShakeFSM.SendEvent("StopRumble");
		FSMUtility.SendEventToGameObject(HeroController.instance.gameObject, "ROAR EXIT", false);
		yield break;
	}

	// Token: 0x0600043D RID: 1085 RVA: 0x00014B5B File Offset: 0x00012D5B
	public BridgeLever()
	{
		this.playerDataBool = "cityBridge1";
		base..ctor();
	}

	// Token: 0x040003C0 RID: 960
	public string playerDataBool;

	// Token: 0x040003C1 RID: 961
	public Collider2D bridgeCollider;

	// Token: 0x040003C2 RID: 962
	[Space]
	public BridgeSection[] sections;

	// Token: 0x040003C3 RID: 963
	[Space]
	public AudioSource audioPlayerPrefab;

	// Token: 0x040003C4 RID: 964
	public AudioEvent switchSound;

	// Token: 0x040003C5 RID: 965
	public GameObject strikeNailPrefab;

	// Token: 0x040003C6 RID: 966
	public Transform hitOrigin;

	// Token: 0x040003C7 RID: 967
	private tk2dSpriteAnimator anim;

	// Token: 0x040003C8 RID: 968
	private AudioSource source;

	// Token: 0x040003C9 RID: 969
	private bool activated;
}
