using System;
using System.Collections.Generic;
using UnityEngine;

// Token: 0x0200041E RID: 1054
public class TrackTriggerObjects : MonoBehaviour
{
	// Token: 0x17000313 RID: 787
	// (get) Token: 0x060017C1 RID: 6081 RVA: 0x00070114 File Offset: 0x0006E314
	public int InsideCount
	{
		get
		{
			int num = 0;
			using (List<GameObject>.Enumerator enumerator = this.insideGameObjects.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					if (enumerator.Current)
					{
						num++;
					}
				}
			}
			return num;
		}
	}

	// Token: 0x060017C2 RID: 6082 RVA: 0x00070170 File Offset: 0x0006E370
	private void OnDisable()
	{
		this.insideGameObjects.Clear();
		this.gottenOverlappedColliders = false;
		if (this.subscribed)
		{
			HeroController silentInstance = HeroController.SilentInstance;
			if (silentInstance)
			{
				silentInstance.heroInPosition -= this.OnHeroInPosition;
			}
			this.subscribed = false;
		}
	}

	// Token: 0x060017C3 RID: 6083 RVA: 0x000701C0 File Offset: 0x0006E3C0
	private void OnEnable()
	{
		if (this.layerMask < 0)
		{
			this.layerMask = Helper.GetCollidingLayerMaskForLayer(base.gameObject.layer);
		}
		HeroController instance = HeroController.instance;
		if (instance && !instance.isHeroInPosition)
		{
			HeroController.instance.heroInPosition += this.OnHeroInPosition;
			this.subscribed = true;
			return;
		}
		this.GetOverlappedColliders(false);
	}

	// Token: 0x060017C4 RID: 6084 RVA: 0x00070228 File Offset: 0x0006E428
	private void FixedUpdate()
	{
		for (int i = this.insideGameObjects.Count - 1; i >= 0; i--)
		{
			GameObject gameObject = this.insideGameObjects[i];
			if (!gameObject || !gameObject.activeInHierarchy)
			{
				this.insideGameObjects.RemoveAt(i);
			}
		}
	}

	// Token: 0x060017C5 RID: 6085 RVA: 0x00070278 File Offset: 0x0006E478
	private void OnHeroInPosition(bool forceDirect)
	{
		if (this.subscribed)
		{
			HeroController.instance.heroInPosition -= this.OnHeroInPosition;
			this.subscribed = false;
		}
		if (!this)
		{
			Debug.LogError("TrackTriggerObjects native Object was destroyed! This should not happen...", this);
			return;
		}
		this.GetOverlappedColliders(false);
	}

	// Token: 0x060017C6 RID: 6086 RVA: 0x000702C8 File Offset: 0x0006E4C8
	private void GetOverlappedColliders(bool isRefresh = false)
	{
		if (!base.enabled || !base.gameObject.activeInHierarchy)
		{
			return;
		}
		if (this.gottenOverlappedColliders && !isRefresh)
		{
			return;
		}
		this.gottenOverlappedColliders = true;
		Collider2D[] components = base.GetComponents<Collider2D>();
		Collider2D[] array = components;
		for (int i = 0; i < array.Length; i++)
		{
			if (array[i].OverlapCollider(new ContactFilter2D
			{
				useTriggers = true,
				useLayerMask = true,
				layerMask = this.layerMask
			}, TrackTriggerObjects._tempResults) > 0)
			{
				foreach (Collider2D collider2D in TrackTriggerObjects._tempResults)
				{
					if (collider2D)
					{
						this.OnTriggerEnter2D(collider2D);
					}
				}
			}
		}
		for (int k = 0; k < TrackTriggerObjects._tempResults.Length; k++)
		{
			TrackTriggerObjects._tempResults[k] = null;
		}
		if (isRefresh)
		{
			TrackTriggerObjects._refreshTemp.AddRange(this.insideGameObjects);
			foreach (GameObject gameObject in TrackTriggerObjects._refreshTemp)
			{
				bool flag = false;
				array = components;
				for (int i = 0; i < array.Length; i++)
				{
					if (array[i].gameObject == gameObject)
					{
						flag = true;
						break;
					}
				}
				if (!flag)
				{
					this.OnExit(gameObject);
				}
			}
			TrackTriggerObjects._refreshTemp.Clear();
		}
	}

	// Token: 0x060017C7 RID: 6087 RVA: 0x0007043C File Offset: 0x0006E63C
	private void OnTriggerEnter2D(Collider2D collision)
	{
		if (!this.gottenOverlappedColliders)
		{
			return;
		}
		GameObject gameObject = collision.gameObject;
		if (this.IsIgnored(gameObject))
		{
			return;
		}
		if (!this.insideGameObjects.Contains(gameObject))
		{
			this.insideGameObjects.Add(gameObject);
		}
	}

	// Token: 0x060017C8 RID: 6088 RVA: 0x00070480 File Offset: 0x0006E680
	private void OnTriggerExit2D(Collider2D collision)
	{
		GameObject gameObject = collision.gameObject;
		this.OnExit(gameObject);
	}

	// Token: 0x060017C9 RID: 6089 RVA: 0x0007049B File Offset: 0x0006E69B
	private void OnExit(GameObject obj)
	{
		this.insideGameObjects.Remove(obj);
	}

	// Token: 0x060017CA RID: 6090 RVA: 0x000704AC File Offset: 0x0006E6AC
	private bool IsIgnored(GameObject obj)
	{
		int layer = obj.layer;
		int num = 1 << layer;
		return (this.ignoreLayers.value & num) == num;
	}

	// Token: 0x060017CB RID: 6091 RVA: 0x000704D7 File Offset: 0x0006E6D7
	public TrackTriggerObjects()
	{
		this.insideGameObjects = new List<GameObject>();
		this.layerMask = -1;
		base..ctor();
	}

	// Token: 0x060017CC RID: 6092 RVA: 0x000704F1 File Offset: 0x0006E6F1
	// Note: this type is marked as 'beforefieldinit'.
	static TrackTriggerObjects()
	{
		TrackTriggerObjects._tempResults = new Collider2D[10];
		TrackTriggerObjects._refreshTemp = new List<GameObject>();
	}

	// Token: 0x04001C8A RID: 7306
	[SerializeField]
	private LayerMask ignoreLayers;

	// Token: 0x04001C8B RID: 7307
	private List<GameObject> insideGameObjects;

	// Token: 0x04001C8C RID: 7308
	private int layerMask;

	// Token: 0x04001C8D RID: 7309
	private bool gottenOverlappedColliders;

	// Token: 0x04001C8E RID: 7310
	private bool subscribed;

	// Token: 0x04001C8F RID: 7311
	private static readonly Collider2D[] _tempResults;

	// Token: 0x04001C90 RID: 7312
	private static readonly List<GameObject> _refreshTemp;
}
