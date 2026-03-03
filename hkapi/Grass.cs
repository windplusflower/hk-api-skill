using System;
using System.Collections.Generic;
using UnityEngine;

// Token: 0x020003C8 RID: 968
public class Grass : MonoBehaviour, IHitResponder
{
	// Token: 0x0600163D RID: 5693 RVA: 0x000694A8 File Offset: 0x000676A8
	[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.BeforeSceneLoad)]
	private static void Init()
	{
		Grass.grasses = new List<Grass>();
	}

	// Token: 0x0600163E RID: 5694 RVA: 0x000694B4 File Offset: 0x000676B4
	protected void Reset()
	{
		this.inertBackgroundThreshold = 1.8f;
		this.inertForegroundThreshold = -1.8f;
		this.infectedColor = new Color32(byte.MaxValue, 140, 54, byte.MaxValue);
		this.slashImpactRotationMin = 340f;
		this.slashImpactRotationMax = 380f;
		this.slashImpactScale = 0.6f;
		this.preventPushAnimation = false;
		this.childParticleSystemDuration = 5f;
	}

	// Token: 0x0600163F RID: 5695 RVA: 0x0006952B File Offset: 0x0006772B
	protected void Awake()
	{
		this.animator = base.GetComponent<Animator>();
		this.bodyCollider = base.GetComponent<Collider2D>();
		this.audioSource = base.GetComponent<AudioSource>();
		Grass.grasses.Add(this);
	}

	// Token: 0x06001640 RID: 5696 RVA: 0x0006955C File Offset: 0x0006775C
	protected void OnDestroy()
	{
		Grass.grasses.Remove(this);
	}

	// Token: 0x06001641 RID: 5697 RVA: 0x0006956C File Offset: 0x0006776C
	protected void Start()
	{
		float z = base.transform.position.z;
		if (z > this.inertBackgroundThreshold || z < this.inertForegroundThreshold)
		{
			base.enabled = false;
			return;
		}
		this.isInfected = (this.isInfectable && GameObject.FindGameObjectWithTag("Infected Flag") != null);
		if (this.isInfected)
		{
			FSMActionReplacements.SetMaterialColor(this, this.infectedColor);
		}
		this.animator.Play(Grass.IdleStateId, 0, UnityEngine.Random.Range(0f, 1f));
	}

	// Token: 0x06001642 RID: 5698 RVA: 0x000695F9 File Offset: 0x000677F9
	protected void OnTriggerEnter2D(Collider2D other)
	{
		if (this.preventPushAnimation)
		{
			return;
		}
		this.Push(false);
	}

	// Token: 0x06001643 RID: 5699 RVA: 0x0006960B File Offset: 0x0006780B
	public void Push(bool isAllGrass)
	{
		if (this.isCut)
		{
			return;
		}
		if (!isAllGrass)
		{
			this.pushAudioClipTable.PlayOneShot(this.audioSource);
		}
		this.animator.Play(Grass.PushStateId, 0, 0f);
	}

	// Token: 0x06001644 RID: 5700 RVA: 0x00069640 File Offset: 0x00067840
	public static void PushAll()
	{
		if (Grass.grasses != null)
		{
			for (int i = 0; i < Grass.grasses.Count; i++)
			{
				Grass.grasses[i].Push(true);
			}
		}
	}

	// Token: 0x06001645 RID: 5701 RVA: 0x0006967C File Offset: 0x0006787C
	public void Hit(HitInstance damageInstance)
	{
		if (damageInstance.DamageDealt <= 0)
		{
			return;
		}
		if (this.isCut)
		{
			return;
		}
		this.isCut = true;
		this.bodyCollider.enabled = false;
		FSMActionReplacements.Directions directions = FSMActionReplacements.CheckDirectionWithBrokenBehaviour(0f);
		GameObject gameObject = this.slashImpactPrefab.Spawn(base.transform.position, Quaternion.Euler(0f, 0f, UnityEngine.Random.Range(this.slashImpactRotationMin, this.slashImpactRotationMax)));
		gameObject.transform.localScale = new Vector3((directions == FSMActionReplacements.Directions.Left) ? (-this.slashImpactScale) : this.slashImpactScale, this.slashImpactScale, 1f);
		Vector3 localPosition = gameObject.transform.localPosition;
		localPosition.z = 0f;
		gameObject.transform.localPosition = localPosition;
		Quaternion rotation = Quaternion.Euler(-90f, -90f, -0.01f);
		if (this.isInfected)
		{
			if (this.infectedCutPrefab0 != null)
			{
				this.infectedCutPrefab0.Spawn(base.transform.position, rotation);
			}
			if (this.infectedCutPrefab1 != null)
			{
				this.infectedCutPrefab1.Spawn(base.transform.position, rotation);
			}
		}
		else
		{
			if (this.cutPrefab0 != null)
			{
				this.cutPrefab0.Spawn(base.transform.position, rotation);
			}
			if (this.cutPrefab1 != null)
			{
				this.cutPrefab1.Spawn(base.transform.position, rotation);
			}
		}
		this.cutAudioClipTable.PlayOneShot(this.audioSource);
		this.animator.Play(Grass.DeadStateId, 0, 0f);
		if (!this.isInfected && this.childParticleSystem != null)
		{
			this.childParticleSystem.Play();
			this.childParticleSystemTimer = this.childParticleSystemDuration;
			base.enabled = true;
			return;
		}
		base.enabled = false;
	}

	// Token: 0x06001646 RID: 5702 RVA: 0x0006985C File Offset: 0x00067A5C
	protected void Update()
	{
		this.childParticleSystemTimer -= Time.deltaTime;
		if (this.childParticleSystemTimer <= 0f)
		{
			if (this.childParticleSystem != null)
			{
				this.childParticleSystem.Stop();
			}
			base.enabled = false;
		}
	}

	// Token: 0x06001648 RID: 5704 RVA: 0x000698A8 File Offset: 0x00067AA8
	// Note: this type is marked as 'beforefieldinit'.
	static Grass()
	{
		Grass.IdleStateId = Animator.StringToHash("Idle");
		Grass.PushStateId = Animator.StringToHash("Push");
		Grass.DeadStateId = Animator.StringToHash("Dead");
	}

	// Token: 0x04001AA7 RID: 6823
	private Animator animator;

	// Token: 0x04001AA8 RID: 6824
	private Collider2D bodyCollider;

	// Token: 0x04001AA9 RID: 6825
	private AudioSource audioSource;

	// Token: 0x04001AAA RID: 6826
	[SerializeField]
	private bool isInfectable;

	// Token: 0x04001AAB RID: 6827
	[SerializeField]
	private float inertBackgroundThreshold;

	// Token: 0x04001AAC RID: 6828
	[SerializeField]
	private float inertForegroundThreshold;

	// Token: 0x04001AAD RID: 6829
	[SerializeField]
	private Color infectedColor;

	// Token: 0x04001AAE RID: 6830
	[SerializeField]
	private bool preventPushAnimation;

	// Token: 0x04001AAF RID: 6831
	[SerializeField]
	private GameObject slashImpactPrefab;

	// Token: 0x04001AB0 RID: 6832
	[SerializeField]
	private float slashImpactRotationMin;

	// Token: 0x04001AB1 RID: 6833
	[SerializeField]
	private float slashImpactRotationMax;

	// Token: 0x04001AB2 RID: 6834
	[SerializeField]
	private float slashImpactScale;

	// Token: 0x04001AB3 RID: 6835
	[SerializeField]
	private GameObject infectedCutPrefab0;

	// Token: 0x04001AB4 RID: 6836
	[SerializeField]
	private GameObject infectedCutPrefab1;

	// Token: 0x04001AB5 RID: 6837
	[SerializeField]
	private GameObject cutPrefab0;

	// Token: 0x04001AB6 RID: 6838
	[SerializeField]
	private GameObject cutPrefab1;

	// Token: 0x04001AB7 RID: 6839
	[SerializeField]
	private ParticleSystem childParticleSystem;

	// Token: 0x04001AB8 RID: 6840
	[SerializeField]
	private float childParticleSystemDuration;

	// Token: 0x04001AB9 RID: 6841
	[SerializeField]
	private RandomAudioClipTable pushAudioClipTable;

	// Token: 0x04001ABA RID: 6842
	[SerializeField]
	private RandomAudioClipTable cutAudioClipTable;

	// Token: 0x04001ABB RID: 6843
	private static readonly int IdleStateId;

	// Token: 0x04001ABC RID: 6844
	private static readonly int PushStateId;

	// Token: 0x04001ABD RID: 6845
	private static readonly int DeadStateId;

	// Token: 0x04001ABE RID: 6846
	private bool isInfected;

	// Token: 0x04001ABF RID: 6847
	private bool isCut;

	// Token: 0x04001AC0 RID: 6848
	private float childParticleSystemTimer;

	// Token: 0x04001AC1 RID: 6849
	private static List<Grass> grasses;

	// Token: 0x020003C9 RID: 969
	public enum GrassTypes
	{
		// Token: 0x04001AC3 RID: 6851
		White,
		// Token: 0x04001AC4 RID: 6852
		Green,
		// Token: 0x04001AC5 RID: 6853
		SimpleType,
		// Token: 0x04001AC6 RID: 6854
		Rag,
		// Token: 0x04001AC7 RID: 6855
		ChildType
	}
}
