using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Token: 0x02000133 RID: 307
public class GrassBehaviour : MonoBehaviour
{
	// Token: 0x170000BF RID: 191
	// (get) Token: 0x06000722 RID: 1826 RVA: 0x00028C53 File Offset: 0x00026E53
	public Material SharedMaterial
	{
		get
		{
			return this.sharedMaterial;
		}
	}

	// Token: 0x06000723 RID: 1827 RVA: 0x00028C5B File Offset: 0x00026E5B
	private void Awake()
	{
		this.source = base.GetComponent<AudioSource>();
		this.animator = base.GetComponentInChildren<Animator>();
		this.propertyBlock = new MaterialPropertyBlock();
	}

	// Token: 0x06000724 RID: 1828 RVA: 0x00028C80 File Offset: 0x00026E80
	private void Start()
	{
		if (Mathf.Abs(base.transform.position.z - 0.004f) > 1.8f)
		{
			GrassCut component = base.GetComponent<GrassCut>();
			if (component)
			{
				UnityEngine.Object.Destroy(component);
			}
			Collider2D[] componentsInChildren = base.GetComponentsInChildren<Collider2D>();
			for (int i = 0; i < componentsInChildren.Length; i++)
			{
				UnityEngine.Object.Destroy(componentsInChildren[i]);
			}
		}
		this.renderers = base.GetComponentsInChildren<SpriteRenderer>(true);
		if (this.renderers.Length != 0)
		{
			string key = this.renderers[0].material.name + (this.neverInfected ? "_neverInfected" : "");
			if (GrassBehaviour.sharedMaterials.ContainsKey(key))
			{
				this.sharedMaterial = GrassBehaviour.sharedMaterials[key];
			}
			if (!this.sharedMaterial)
			{
				this.sharedMaterial = new Material(this.renderers[0].material);
				GrassBehaviour.sharedMaterials[key] = this.sharedMaterial;
			}
		}
		if (this.sharedMaterial)
		{
			SpriteRenderer[] array = this.renderers;
			for (int i = 0; i < array.Length; i++)
			{
				array[i].sharedMaterial = this.sharedMaterial;
			}
		}
		if (!GrassBehaviour.colorSet && !this.neverInfected)
		{
			base.StartCoroutine(this.DelayedInfectedCheck());
		}
		this.pushAmountError = UnityEngine.Random.Range(-0.01f, 0.01f);
		foreach (SpriteRenderer rend in this.renderers)
		{
			this.SetPushAmount(rend, this.pushAmountError);
		}
		base.transform.SetPositionZ(base.transform.position.z + UnityEngine.Random.Range(-0.0001f, 0.0001f));
	}

	// Token: 0x06000725 RID: 1829 RVA: 0x00028E34 File Offset: 0x00027034
	private void OnEnable()
	{
		GrassBehaviour.grassCount++;
	}

	// Token: 0x06000726 RID: 1830 RVA: 0x00028E42 File Offset: 0x00027042
	private void OnDisable()
	{
		GrassBehaviour.grassCount--;
		if (GrassBehaviour.colorSet)
		{
			GrassBehaviour.colorSet = false;
			this.sharedMaterial = null;
		}
		if (GrassBehaviour.grassCount <= 0)
		{
			GrassBehaviour.sharedMaterials.Clear();
		}
	}

	// Token: 0x06000727 RID: 1831 RVA: 0x00028E76 File Offset: 0x00027076
	private IEnumerator DelayedInfectedCheck()
	{
		yield return null;
		if (this.sharedMaterial && GameObject.FindWithTag("Infected Flag"))
		{
			GrassBehaviour.colorSet = true;
			this.sharedMaterial.color = this.infectedColor;
			SpriteRenderer[] array = this.renderers;
			for (int i = 0; i < array.Length; i++)
			{
				array[i].sharedMaterial = this.sharedMaterial;
			}
		}
		yield break;
	}

	// Token: 0x06000728 RID: 1832 RVA: 0x00028E88 File Offset: 0x00027088
	private void LateUpdate()
	{
		if (!this.returned)
		{
			float value = this.curve.Evaluate(this.animElapsed / this.animLength) * this.pushAmount * this.pushDirection * Mathf.Sign(base.transform.localScale.x) + this.pushAmountError;
			foreach (SpriteRenderer rend in this.renderers)
			{
				this.SetPushAmount(rend, value);
			}
			if (this.animElapsed >= this.animLength)
			{
				this.returned = true;
				if (this.animator && this.animator.HasParameter(this.pushAnim, new AnimatorControllerParameterType?(AnimatorControllerParameterType.Bool)))
				{
					this.animator.SetBool(this.pushAnim, false);
				}
			}
			this.animElapsed += Time.deltaTime;
		}
	}

	// Token: 0x06000729 RID: 1833 RVA: 0x00028F64 File Offset: 0x00027164
	private void FixedUpdate()
	{
		if (this.player && this.returned && Mathf.Abs(this.player.velocity.x) >= 0.1f)
		{
			this.pushDirection = Mathf.Sign(this.player.velocity.x);
			this.returned = false;
			this.animElapsed = 0f;
			this.pushAmount = this.walkReactAmount;
			this.curve = this.walkReactCurve;
			this.animLength = this.walkReactLength;
			this.PlayRandomSound(this.isCut ? this.cutPushSounds : this.pushSounds);
			if (this.animator)
			{
				if (this.animator.HasParameter(this.pushAnim, new AnimatorControllerParameterType?(AnimatorControllerParameterType.Bool)))
				{
					this.animator.SetBool(this.pushAnim, true);
					return;
				}
				if (this.animator.HasParameter(this.pushAnim, new AnimatorControllerParameterType?(AnimatorControllerParameterType.Trigger)))
				{
					this.animator.SetTrigger(this.pushAnim);
				}
			}
		}
	}

	// Token: 0x0600072A RID: 1834 RVA: 0x0002907C File Offset: 0x0002727C
	private void OnTriggerEnter2D(Collider2D collision)
	{
		if (this.returned)
		{
			this.pushDirection = Mathf.Sign(base.transform.position.x - collision.transform.position.x);
			this.returned = false;
			this.animElapsed = 0f;
			if (GrassCut.ShouldCut(collision))
			{
				this.pushAmount = this.attackReactAmount;
				this.curve = this.attackReactCurve;
				this.animLength = this.attackReactLength;
				this.PlayRandomSound(this.isCut ? this.cutPushSounds : this.pushSounds);
			}
			else
			{
				this.pushAmount = this.walkReactAmount;
				this.curve = this.walkReactCurve;
				this.animLength = this.walkReactLength;
				if (collision.tag == "Player")
				{
					this.player = collision.GetComponent<Rigidbody2D>();
				}
				this.PlayRandomSound(this.isCut ? this.cutPushSounds : this.pushSounds);
			}
			if (this.animator && this.animator.HasParameter(this.pushAnim, null))
			{
				this.animator.SetBool(this.pushAnim, true);
			}
		}
	}

	// Token: 0x0600072B RID: 1835 RVA: 0x000291B5 File Offset: 0x000273B5
	private void OnTriggerExit2D(Collider2D collision)
	{
		if (collision.tag == "Player")
		{
			this.player = null;
		}
	}

	// Token: 0x0600072C RID: 1836 RVA: 0x000291D0 File Offset: 0x000273D0
	public void CutReact(Collider2D collision)
	{
		if (!this.isCut)
		{
			this.pushDirection = Mathf.Sign(base.transform.position.x - collision.transform.position.x);
			this.returned = false;
			this.animElapsed = 0f;
			this.cutFirstFrame = true;
			this.pushAmount = this.attackReactAmount;
			this.curve = this.attackReactCurve;
			this.animLength = this.attackReactLength;
		}
		this.PlayRandomSound(this.cutSounds);
		this.isCut = true;
	}

	// Token: 0x0600072D RID: 1837 RVA: 0x00029264 File Offset: 0x00027464
	public void WindReact(Collider2D collision)
	{
		if (this.returned)
		{
			this.pushDirection = Mathf.Sign(base.transform.position.x - collision.transform.position.x);
			this.returned = false;
			this.animElapsed = 0f;
			this.pushAmount = this.walkReactAmount;
			this.curve = this.walkReactCurve;
			this.animLength = this.walkReactLength;
			this.PlayRandomSound(this.isCut ? this.cutPushSounds : this.pushSounds);
		}
	}

	// Token: 0x0600072E RID: 1838 RVA: 0x000292FC File Offset: 0x000274FC
	private void PlayRandomSound(AudioClip[] clips)
	{
		if (this.source && clips.Length != 0)
		{
			AudioClip clip = clips[UnityEngine.Random.Range(0, clips.Length)];
			this.source.PlayOneShot(clip);
		}
	}

	// Token: 0x0600072F RID: 1839 RVA: 0x00029332 File Offset: 0x00027532
	private void SetPushAmount(Renderer rend, float value)
	{
		rend.GetPropertyBlock(this.propertyBlock);
		this.propertyBlock.SetFloat("_PushAmount", value);
		rend.SetPropertyBlock(this.propertyBlock);
	}

	// Token: 0x06000730 RID: 1840 RVA: 0x00029360 File Offset: 0x00027560
	public GrassBehaviour()
	{
		this.walkReactAmount = 1f;
		this.attackReactAmount = 2f;
		this.pushAnim = "Push";
		this.infectedColor = Color.white;
		this.animLength = 2f;
		this.pushAmount = 1f;
		this.returned = true;
		base..ctor();
	}

	// Token: 0x06000731 RID: 1841 RVA: 0x000293BC File Offset: 0x000275BC
	// Note: this type is marked as 'beforefieldinit'.
	static GrassBehaviour()
	{
		GrassBehaviour.colorSet = false;
		GrassBehaviour.sharedMaterials = new Dictionary<string, Material>();
		GrassBehaviour.grassCount = 0;
	}

	// Token: 0x040007D7 RID: 2007
	[Header("Animation")]
	public float walkReactAmount;

	// Token: 0x040007D8 RID: 2008
	public AnimationCurve walkReactCurve;

	// Token: 0x040007D9 RID: 2009
	public float walkReactLength;

	// Token: 0x040007DA RID: 2010
	[Space]
	public float attackReactAmount;

	// Token: 0x040007DB RID: 2011
	public AnimationCurve attackReactCurve;

	// Token: 0x040007DC RID: 2012
	public float attackReactLength;

	// Token: 0x040007DD RID: 2013
	[Space]
	public string pushAnim;

	// Token: 0x040007DE RID: 2014
	private Animator animator;

	// Token: 0x040007DF RID: 2015
	[Header("Sound")]
	public AudioClip[] pushSounds;

	// Token: 0x040007E0 RID: 2016
	public AudioClip[] cutPushSounds;

	// Token: 0x040007E1 RID: 2017
	public AudioClip[] cutSounds;

	// Token: 0x040007E2 RID: 2018
	private AudioSource source;

	// Token: 0x040007E3 RID: 2019
	[Header("Extra")]
	public Color infectedColor;

	// Token: 0x040007E4 RID: 2020
	public bool neverInfected;

	// Token: 0x040007E5 RID: 2021
	private static bool colorSet;

	// Token: 0x040007E6 RID: 2022
	private AnimationCurve curve;

	// Token: 0x040007E7 RID: 2023
	private float animLength;

	// Token: 0x040007E8 RID: 2024
	private float animElapsed;

	// Token: 0x040007E9 RID: 2025
	private float pushAmount;

	// Token: 0x040007EA RID: 2026
	private float pushDirection;

	// Token: 0x040007EB RID: 2027
	private bool returned;

	// Token: 0x040007EC RID: 2028
	private bool cutFirstFrame;

	// Token: 0x040007ED RID: 2029
	private bool isCut;

	// Token: 0x040007EE RID: 2030
	private float pushAmountError;

	// Token: 0x040007EF RID: 2031
	private Rigidbody2D player;

	// Token: 0x040007F0 RID: 2032
	private Vector3 oldPlayerPos;

	// Token: 0x040007F1 RID: 2033
	private SpriteRenderer[] renderers;

	// Token: 0x040007F2 RID: 2034
	private static Dictionary<string, Material> sharedMaterials;

	// Token: 0x040007F3 RID: 2035
	private static int grassCount;

	// Token: 0x040007F4 RID: 2036
	private Material sharedMaterial;

	// Token: 0x040007F5 RID: 2037
	private MaterialPropertyBlock propertyBlock;
}
