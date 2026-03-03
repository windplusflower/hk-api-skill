using System;
using System.Collections.Generic;
using tk2dRuntime;
using UnityEngine;

// Token: 0x0200055B RID: 1371
[AddComponentMenu("2D Toolkit/Backend/tk2dBaseSprite")]
public abstract class tk2dBaseSprite : MonoBehaviour, ISpriteCollectionForceBuild
{
	// Token: 0x170003D7 RID: 983
	// (get) Token: 0x06001E3C RID: 7740 RVA: 0x00095ADF File Offset: 0x00093CDF
	// (set) Token: 0x06001E3D RID: 7741 RVA: 0x00095AE7 File Offset: 0x00093CE7
	public tk2dSpriteCollectionData Collection
	{
		get
		{
			return this.collection;
		}
		set
		{
			this.collection = value;
			this.collectionInst = this.collection.inst;
		}
	}

	// Token: 0x14000046 RID: 70
	// (add) Token: 0x06001E3E RID: 7742 RVA: 0x00095B04 File Offset: 0x00093D04
	// (remove) Token: 0x06001E3F RID: 7743 RVA: 0x00095B3C File Offset: 0x00093D3C
	public event Action<tk2dBaseSprite> SpriteChanged;

	// Token: 0x06001E40 RID: 7744 RVA: 0x00095B71 File Offset: 0x00093D71
	private void InitInstance()
	{
		if (this.collectionInst == null && this.collection != null)
		{
			this.collectionInst = this.collection.inst;
		}
	}

	// Token: 0x170003D8 RID: 984
	// (get) Token: 0x06001E41 RID: 7745 RVA: 0x00095BA0 File Offset: 0x00093DA0
	// (set) Token: 0x06001E42 RID: 7746 RVA: 0x00095BA8 File Offset: 0x00093DA8
	public Color color
	{
		get
		{
			return this._color;
		}
		set
		{
			if (value != this._color)
			{
				this._color = value;
				this.InitInstance();
				this.UpdateColors();
			}
		}
	}

	// Token: 0x170003D9 RID: 985
	// (get) Token: 0x06001E43 RID: 7747 RVA: 0x00095BCB File Offset: 0x00093DCB
	// (set) Token: 0x06001E44 RID: 7748 RVA: 0x00095BD3 File Offset: 0x00093DD3
	public Vector3 scale
	{
		get
		{
			return this._scale;
		}
		set
		{
			if (value != this._scale)
			{
				this._scale = value;
				this.InitInstance();
				this.UpdateVertices();
				this.UpdateCollider();
				if (this.SpriteChanged != null)
				{
					this.SpriteChanged(this);
				}
			}
		}
	}

	// Token: 0x170003DA RID: 986
	// (get) Token: 0x06001E45 RID: 7749 RVA: 0x00095C10 File Offset: 0x00093E10
	private Renderer CachedRenderer
	{
		get
		{
			if (this._cachedRenderer == null)
			{
				this._cachedRenderer = base.GetComponent<Renderer>();
			}
			return this._cachedRenderer;
		}
	}

	// Token: 0x170003DB RID: 987
	// (get) Token: 0x06001E46 RID: 7750 RVA: 0x00095C32 File Offset: 0x00093E32
	// (set) Token: 0x06001E47 RID: 7751 RVA: 0x00095C3F File Offset: 0x00093E3F
	public int SortingOrder
	{
		get
		{
			return this.CachedRenderer.sortingOrder;
		}
		set
		{
			if (this.CachedRenderer.sortingOrder != value)
			{
				this.renderLayer = value;
				this.CachedRenderer.sortingOrder = value;
			}
		}
	}

	// Token: 0x170003DC RID: 988
	// (get) Token: 0x06001E48 RID: 7752 RVA: 0x00095C62 File Offset: 0x00093E62
	// (set) Token: 0x06001E49 RID: 7753 RVA: 0x00095C76 File Offset: 0x00093E76
	public bool FlipX
	{
		get
		{
			return this._scale.x < 0f;
		}
		set
		{
			this.scale = new Vector3(Mathf.Abs(this._scale.x) * (float)(value ? -1 : 1), this._scale.y, this._scale.z);
		}
	}

	// Token: 0x170003DD RID: 989
	// (get) Token: 0x06001E4A RID: 7754 RVA: 0x00095CB2 File Offset: 0x00093EB2
	// (set) Token: 0x06001E4B RID: 7755 RVA: 0x00095CC6 File Offset: 0x00093EC6
	public bool FlipY
	{
		get
		{
			return this._scale.y < 0f;
		}
		set
		{
			this.scale = new Vector3(this._scale.x, Mathf.Abs(this._scale.y) * (float)(value ? -1 : 1), this._scale.z);
		}
	}

	// Token: 0x170003DE RID: 990
	// (get) Token: 0x06001E4C RID: 7756 RVA: 0x00095D02 File Offset: 0x00093F02
	// (set) Token: 0x06001E4D RID: 7757 RVA: 0x00095D0C File Offset: 0x00093F0C
	public int spriteId
	{
		get
		{
			return this._spriteId;
		}
		set
		{
			if (value != this._spriteId)
			{
				this.InitInstance();
				value = Mathf.Clamp(value, 0, this.collectionInst.spriteDefinitions.Length - 1);
				if (this._spriteId < 0 || this._spriteId >= this.collectionInst.spriteDefinitions.Length || this.GetCurrentVertexCount() != this.collectionInst.spriteDefinitions[value].positions.Length || this.collectionInst.spriteDefinitions[this._spriteId].complexGeometry != this.collectionInst.spriteDefinitions[value].complexGeometry)
				{
					this._spriteId = value;
					this.UpdateGeometry();
				}
				else
				{
					this._spriteId = value;
					this.UpdateVertices();
				}
				this.UpdateMaterial();
				this.UpdateCollider();
				if (this.SpriteChanged != null)
				{
					this.SpriteChanged(this);
				}
			}
		}
	}

	// Token: 0x06001E4E RID: 7758 RVA: 0x00095DE6 File Offset: 0x00093FE6
	public void SetSprite(int newSpriteId)
	{
		this.spriteId = newSpriteId;
	}

	// Token: 0x06001E4F RID: 7759 RVA: 0x00095DF0 File Offset: 0x00093FF0
	public bool SetSprite(string spriteName)
	{
		int spriteIdByName = this.collection.GetSpriteIdByName(spriteName, -1);
		if (spriteIdByName != -1)
		{
			this.SetSprite(spriteIdByName);
		}
		else
		{
			Debug.LogError("SetSprite - Sprite not found in collection: " + spriteName);
		}
		return spriteIdByName != -1;
	}

	// Token: 0x06001E50 RID: 7760 RVA: 0x00095E30 File Offset: 0x00094030
	public void SetSprite(tk2dSpriteCollectionData newCollection, int newSpriteId)
	{
		bool flag = false;
		if (this.Collection != newCollection)
		{
			this.collection = newCollection;
			this.collectionInst = this.collection.inst;
			this._spriteId = -1;
			flag = true;
		}
		this.spriteId = newSpriteId;
		if (flag)
		{
			this.UpdateMaterial();
		}
	}

	// Token: 0x06001E51 RID: 7761 RVA: 0x00095E80 File Offset: 0x00094080
	public bool SetSprite(tk2dSpriteCollectionData newCollection, string spriteName)
	{
		int spriteIdByName = newCollection.GetSpriteIdByName(spriteName, -1);
		if (spriteIdByName != -1)
		{
			this.SetSprite(newCollection, spriteIdByName);
		}
		else
		{
			Debug.LogError("SetSprite - Sprite not found in collection: " + spriteName);
		}
		return spriteIdByName != -1;
	}

	// Token: 0x06001E52 RID: 7762 RVA: 0x00095EBC File Offset: 0x000940BC
	public void MakePixelPerfect()
	{
		float num = 1f;
		tk2dCamera tk2dCamera = tk2dCamera.CameraForLayer(base.gameObject.layer);
		if (tk2dCamera != null)
		{
			if (this.Collection.version < 2)
			{
				Debug.LogError("Need to rebuild sprite collection.");
			}
			float distance = base.transform.position.z - tk2dCamera.transform.position.z;
			float num2 = this.Collection.invOrthoSize * this.Collection.halfTargetHeight;
			num = tk2dCamera.GetSizeAtDistance(distance) * num2;
		}
		else if (Camera.main)
		{
			if (Camera.main.orthographic)
			{
				num = Camera.main.orthographicSize;
			}
			else
			{
				float zdist = base.transform.position.z - Camera.main.transform.position.z;
				num = tk2dPixelPerfectHelper.CalculateScaleForPerspectiveCamera(Camera.main.fieldOfView, zdist);
			}
			num *= this.Collection.invOrthoSize;
		}
		else
		{
			Debug.LogError("Main camera not found.");
		}
		this.scale = new Vector3(Mathf.Sign(this.scale.x) * num, Mathf.Sign(this.scale.y) * num, Mathf.Sign(this.scale.z) * num);
	}

	// Token: 0x06001E53 RID: 7763
	protected abstract void UpdateMaterial();

	// Token: 0x06001E54 RID: 7764
	protected abstract void UpdateColors();

	// Token: 0x06001E55 RID: 7765
	protected abstract void UpdateVertices();

	// Token: 0x06001E56 RID: 7766
	protected abstract void UpdateGeometry();

	// Token: 0x06001E57 RID: 7767
	protected abstract int GetCurrentVertexCount();

	// Token: 0x06001E58 RID: 7768
	public abstract void Build();

	// Token: 0x06001E59 RID: 7769 RVA: 0x00096003 File Offset: 0x00094203
	public int GetSpriteIdByName(string name)
	{
		this.InitInstance();
		return this.collectionInst.GetSpriteIdByName(name);
	}

	// Token: 0x06001E5A RID: 7770 RVA: 0x00096017 File Offset: 0x00094217
	public static T AddComponent<T>(GameObject go, tk2dSpriteCollectionData spriteCollection, int spriteId) where T : tk2dBaseSprite
	{
		T t = go.AddComponent<T>();
		t._spriteId = -1;
		t.SetSprite(spriteCollection, spriteId);
		t.Build();
		return t;
	}

	// Token: 0x06001E5B RID: 7771 RVA: 0x00096044 File Offset: 0x00094244
	public static T AddComponent<T>(GameObject go, tk2dSpriteCollectionData spriteCollection, string spriteName) where T : tk2dBaseSprite
	{
		int spriteIdByName = spriteCollection.GetSpriteIdByName(spriteName, -1);
		if (spriteIdByName == -1)
		{
			Debug.LogError(string.Format("Unable to find sprite named {0} in sprite collection {1}", spriteName, spriteCollection.spriteCollectionName));
			return default(T);
		}
		return tk2dBaseSprite.AddComponent<T>(go, spriteCollection, spriteIdByName);
	}

	// Token: 0x06001E5C RID: 7772 RVA: 0x00096086 File Offset: 0x00094286
	protected int GetNumVertices()
	{
		this.InitInstance();
		return this.collectionInst.spriteDefinitions[this.spriteId].positions.Length;
	}

	// Token: 0x06001E5D RID: 7773 RVA: 0x000960A7 File Offset: 0x000942A7
	protected int GetNumIndices()
	{
		this.InitInstance();
		return this.collectionInst.spriteDefinitions[this.spriteId].indices.Length;
	}

	// Token: 0x06001E5E RID: 7774 RVA: 0x000960C8 File Offset: 0x000942C8
	protected void SetPositions(Vector3[] positions, Vector3[] normals, Vector4[] tangents)
	{
		tk2dSpriteDefinition tk2dSpriteDefinition = this.collectionInst.spriteDefinitions[this.spriteId];
		int numVertices = this.GetNumVertices();
		for (int i = 0; i < numVertices; i++)
		{
			positions[i].x = tk2dSpriteDefinition.positions[i].x * this._scale.x;
			positions[i].y = tk2dSpriteDefinition.positions[i].y * this._scale.y;
			positions[i].z = tk2dSpriteDefinition.positions[i].z * this._scale.z;
		}
		int num = tk2dSpriteDefinition.normals.Length;
		if (normals.Length == num)
		{
			for (int j = 0; j < num; j++)
			{
				normals[j] = tk2dSpriteDefinition.normals[j];
			}
		}
		int num2 = tk2dSpriteDefinition.tangents.Length;
		if (tangents.Length == num2)
		{
			for (int k = 0; k < num2; k++)
			{
				tangents[k] = tk2dSpriteDefinition.tangents[k];
			}
		}
	}

	// Token: 0x06001E5F RID: 7775 RVA: 0x000961F0 File Offset: 0x000943F0
	protected void SetColors(Color32[] dest)
	{
		Color color = this._color;
		if (this.collectionInst.premultipliedAlpha)
		{
			color.r *= color.a;
			color.g *= color.a;
			color.b *= color.a;
		}
		Color32 color2 = color;
		int numVertices = this.GetNumVertices();
		for (int i = 0; i < numVertices; i++)
		{
			dest[i] = color2;
		}
	}

	// Token: 0x06001E60 RID: 7776 RVA: 0x00096268 File Offset: 0x00094468
	public Bounds GetBounds()
	{
		this.InitInstance();
		tk2dSpriteDefinition tk2dSpriteDefinition = this.collectionInst.spriteDefinitions[this._spriteId];
		return new Bounds(new Vector3(tk2dSpriteDefinition.boundsData[0].x * this._scale.x, tk2dSpriteDefinition.boundsData[0].y * this._scale.y, tk2dSpriteDefinition.boundsData[0].z * this._scale.z), new Vector3(tk2dSpriteDefinition.boundsData[1].x * Mathf.Abs(this._scale.x), tk2dSpriteDefinition.boundsData[1].y * Mathf.Abs(this._scale.y), tk2dSpriteDefinition.boundsData[1].z * Mathf.Abs(this._scale.z)));
	}

	// Token: 0x06001E61 RID: 7777 RVA: 0x0009635C File Offset: 0x0009455C
	public Bounds GetUntrimmedBounds()
	{
		this.InitInstance();
		tk2dSpriteDefinition tk2dSpriteDefinition = this.collectionInst.spriteDefinitions[this._spriteId];
		return new Bounds(new Vector3(tk2dSpriteDefinition.untrimmedBoundsData[0].x * this._scale.x, tk2dSpriteDefinition.untrimmedBoundsData[0].y * this._scale.y, tk2dSpriteDefinition.untrimmedBoundsData[0].z * this._scale.z), new Vector3(tk2dSpriteDefinition.untrimmedBoundsData[1].x * Mathf.Abs(this._scale.x), tk2dSpriteDefinition.untrimmedBoundsData[1].y * Mathf.Abs(this._scale.y), tk2dSpriteDefinition.untrimmedBoundsData[1].z * Mathf.Abs(this._scale.z)));
	}

	// Token: 0x06001E62 RID: 7778 RVA: 0x00096450 File Offset: 0x00094650
	public static Bounds AdjustedMeshBounds(Bounds bounds, int renderLayer)
	{
		Vector3 center = bounds.center;
		center.z = (float)(-(float)renderLayer) * 0.01f;
		bounds.center = center;
		return bounds;
	}

	// Token: 0x06001E63 RID: 7779 RVA: 0x0009647E File Offset: 0x0009467E
	public tk2dSpriteDefinition GetCurrentSpriteDef()
	{
		this.InitInstance();
		if (!(this.collectionInst == null))
		{
			return this.collectionInst.spriteDefinitions[this._spriteId];
		}
		return null;
	}

	// Token: 0x170003DF RID: 991
	// (get) Token: 0x06001E64 RID: 7780 RVA: 0x0009647E File Offset: 0x0009467E
	public tk2dSpriteDefinition CurrentSprite
	{
		get
		{
			this.InitInstance();
			if (!(this.collectionInst == null))
			{
				return this.collectionInst.spriteDefinitions[this._spriteId];
			}
			return null;
		}
	}

	// Token: 0x06001E65 RID: 7781 RVA: 0x00003603 File Offset: 0x00001803
	public virtual void ReshapeBounds(Vector3 dMin, Vector3 dMax)
	{
	}

	// Token: 0x06001E66 RID: 7782 RVA: 0x0000D742 File Offset: 0x0000B942
	protected virtual bool NeedBoxCollider()
	{
		return false;
	}

	// Token: 0x06001E67 RID: 7783 RVA: 0x000964A8 File Offset: 0x000946A8
	protected virtual void UpdateCollider()
	{
		tk2dSpriteDefinition tk2dSpriteDefinition = this.collectionInst.spriteDefinitions[this._spriteId];
		if (tk2dSpriteDefinition.physicsEngine == tk2dSpriteDefinition.PhysicsEngine.Physics3D)
		{
			if (tk2dSpriteDefinition.colliderType == tk2dSpriteDefinition.ColliderType.Box && this.boxCollider == null)
			{
				this.boxCollider = base.gameObject.GetComponent<BoxCollider>();
				if (this.boxCollider == null)
				{
					this.boxCollider = base.gameObject.AddComponent<BoxCollider>();
				}
			}
			if (this.boxCollider != null)
			{
				if (tk2dSpriteDefinition.colliderType == tk2dSpriteDefinition.ColliderType.Box)
				{
					this.boxCollider.center = new Vector3(tk2dSpriteDefinition.colliderVertices[0].x * this._scale.x, tk2dSpriteDefinition.colliderVertices[0].y * this._scale.y, tk2dSpriteDefinition.colliderVertices[0].z * this._scale.z);
					this.boxCollider.size = new Vector3(2f * tk2dSpriteDefinition.colliderVertices[1].x * this._scale.x, 2f * tk2dSpriteDefinition.colliderVertices[1].y * this._scale.y, 2f * tk2dSpriteDefinition.colliderVertices[1].z * this._scale.z);
					return;
				}
				if (tk2dSpriteDefinition.colliderType != tk2dSpriteDefinition.ColliderType.Unset && this.boxCollider != null)
				{
					this.boxCollider.center = new Vector3(0f, 0f, -100000f);
					this.boxCollider.size = Vector3.zero;
					return;
				}
			}
		}
		else if (tk2dSpriteDefinition.physicsEngine == tk2dSpriteDefinition.PhysicsEngine.Physics2D)
		{
			if (tk2dSpriteDefinition.colliderType == tk2dSpriteDefinition.ColliderType.Box)
			{
				if (this.boxCollider2D == null)
				{
					this.boxCollider2D = base.gameObject.GetComponent<BoxCollider2D>();
					if (this.boxCollider2D == null)
					{
						this.boxCollider2D = base.gameObject.AddComponent<BoxCollider2D>();
					}
				}
				if (this.polygonCollider2D.Count > 0)
				{
					foreach (PolygonCollider2D polygonCollider2D in this.polygonCollider2D)
					{
						if (polygonCollider2D != null && polygonCollider2D.enabled)
						{
							polygonCollider2D.enabled = false;
						}
					}
				}
				if (this.edgeCollider2D.Count > 0)
				{
					foreach (EdgeCollider2D edgeCollider2D in this.edgeCollider2D)
					{
						if (edgeCollider2D != null && edgeCollider2D.enabled)
						{
							edgeCollider2D.enabled = false;
						}
					}
				}
				if (!this.boxCollider2D.enabled)
				{
					this.boxCollider2D.enabled = true;
				}
				this.boxCollider2D.offset = new Vector2(tk2dSpriteDefinition.colliderVertices[0].x * this._scale.x, tk2dSpriteDefinition.colliderVertices[0].y * this._scale.y);
				this.boxCollider2D.size = new Vector2(Mathf.Abs(2f * tk2dSpriteDefinition.colliderVertices[1].x * this._scale.x), Mathf.Abs(2f * tk2dSpriteDefinition.colliderVertices[1].y * this._scale.y));
				return;
			}
			if (tk2dSpriteDefinition.colliderType == tk2dSpriteDefinition.ColliderType.Mesh)
			{
				if (this.boxCollider2D != null && this.boxCollider2D.enabled)
				{
					this.boxCollider2D.enabled = false;
				}
				int num = tk2dSpriteDefinition.polygonCollider2D.Length;
				for (int i = 0; i < this.polygonCollider2D.Count; i++)
				{
					if (this.polygonCollider2D[i] == null)
					{
						this.polygonCollider2D[i] = base.gameObject.AddComponent<PolygonCollider2D>();
					}
				}
				while (this.polygonCollider2D.Count < num)
				{
					this.polygonCollider2D.Add(base.gameObject.AddComponent<PolygonCollider2D>());
				}
				for (int j = 0; j < num; j++)
				{
					if (!this.polygonCollider2D[j].enabled)
					{
						this.polygonCollider2D[j].enabled = true;
					}
					if (this._scale.x != 1f || this._scale.y != 1f)
					{
						Vector2[] points = tk2dSpriteDefinition.polygonCollider2D[j].points;
						Vector2[] array = new Vector2[points.Length];
						for (int k = 0; k < points.Length; k++)
						{
							array[k] = Vector2.Scale(points[k], this._scale);
						}
						this.polygonCollider2D[j].points = array;
					}
					else
					{
						this.polygonCollider2D[j].points = tk2dSpriteDefinition.polygonCollider2D[j].points;
					}
				}
				for (int l = num; l < this.polygonCollider2D.Count; l++)
				{
					if (this.polygonCollider2D[l].enabled)
					{
						this.polygonCollider2D[l].enabled = false;
					}
				}
				int num2 = tk2dSpriteDefinition.edgeCollider2D.Length;
				for (int m = 0; m < this.edgeCollider2D.Count; m++)
				{
					if (this.edgeCollider2D[m] == null)
					{
						this.edgeCollider2D[m] = base.gameObject.AddComponent<EdgeCollider2D>();
					}
				}
				while (this.edgeCollider2D.Count < num2)
				{
					this.edgeCollider2D.Add(base.gameObject.AddComponent<EdgeCollider2D>());
				}
				for (int n = 0; n < num2; n++)
				{
					if (!this.edgeCollider2D[n].enabled)
					{
						this.edgeCollider2D[n].enabled = true;
					}
					if (this._scale.x != 1f || this._scale.y != 1f)
					{
						Vector2[] points2 = tk2dSpriteDefinition.edgeCollider2D[n].points;
						Vector2[] array2 = new Vector2[points2.Length];
						for (int num3 = 0; num3 < points2.Length; num3++)
						{
							array2[num3] = Vector2.Scale(points2[num3], this._scale);
						}
						this.edgeCollider2D[n].points = array2;
					}
					else
					{
						this.edgeCollider2D[n].points = tk2dSpriteDefinition.edgeCollider2D[n].points;
					}
				}
				for (int num4 = num2; num4 < this.edgeCollider2D.Count; num4++)
				{
					if (this.edgeCollider2D[num4].enabled)
					{
						this.edgeCollider2D[num4].enabled = false;
					}
				}
				return;
			}
			if (tk2dSpriteDefinition.colliderType == tk2dSpriteDefinition.ColliderType.None)
			{
				if (this.boxCollider2D != null && this.boxCollider2D.enabled)
				{
					this.boxCollider2D.enabled = false;
				}
				if (this.polygonCollider2D.Count > 0)
				{
					foreach (PolygonCollider2D polygonCollider2D2 in this.polygonCollider2D)
					{
						if (polygonCollider2D2 != null && polygonCollider2D2.enabled)
						{
							polygonCollider2D2.enabled = false;
						}
					}
				}
				if (this.edgeCollider2D.Count > 0)
				{
					foreach (EdgeCollider2D edgeCollider2D2 in this.edgeCollider2D)
					{
						if (edgeCollider2D2 != null && edgeCollider2D2.enabled)
						{
							edgeCollider2D2.enabled = false;
						}
					}
				}
			}
		}
	}

	// Token: 0x06001E68 RID: 7784 RVA: 0x00096CC0 File Offset: 0x00094EC0
	protected virtual void CreateCollider()
	{
		tk2dSpriteDefinition tk2dSpriteDefinition = this.collectionInst.spriteDefinitions[this._spriteId];
		if (tk2dSpriteDefinition.colliderType == tk2dSpriteDefinition.ColliderType.Unset)
		{
			return;
		}
		if (tk2dSpriteDefinition.physicsEngine == tk2dSpriteDefinition.PhysicsEngine.Physics3D)
		{
			if (base.GetComponent<Collider>() != null)
			{
				this.boxCollider = base.GetComponent<BoxCollider>();
				this.meshCollider = base.GetComponent<MeshCollider>();
			}
			if ((this.NeedBoxCollider() || tk2dSpriteDefinition.colliderType == tk2dSpriteDefinition.ColliderType.Box) && this.meshCollider == null)
			{
				if (this.boxCollider == null)
				{
					this.boxCollider = base.gameObject.AddComponent<BoxCollider>();
				}
			}
			else if (tk2dSpriteDefinition.colliderType == tk2dSpriteDefinition.ColliderType.Mesh && this.boxCollider == null)
			{
				if (this.meshCollider == null)
				{
					this.meshCollider = base.gameObject.AddComponent<MeshCollider>();
				}
				if (this.meshColliderMesh == null)
				{
					this.meshColliderMesh = new Mesh();
				}
				this.meshColliderMesh.Clear();
				this.meshColliderPositions = new Vector3[tk2dSpriteDefinition.colliderVertices.Length];
				for (int i = 0; i < this.meshColliderPositions.Length; i++)
				{
					this.meshColliderPositions[i] = new Vector3(tk2dSpriteDefinition.colliderVertices[i].x * this._scale.x, tk2dSpriteDefinition.colliderVertices[i].y * this._scale.y, tk2dSpriteDefinition.colliderVertices[i].z * this._scale.z);
				}
				this.meshColliderMesh.vertices = this.meshColliderPositions;
				float num = this._scale.x * this._scale.y * this._scale.z;
				this.meshColliderMesh.triangles = ((num >= 0f) ? tk2dSpriteDefinition.colliderIndicesFwd : tk2dSpriteDefinition.colliderIndicesBack);
				this.meshCollider.sharedMesh = this.meshColliderMesh;
				this.meshCollider.convex = tk2dSpriteDefinition.colliderConvex;
				if (base.GetComponent<Rigidbody>())
				{
					base.GetComponent<Rigidbody>().centerOfMass = Vector3.zero;
				}
			}
			else if (tk2dSpriteDefinition.colliderType != tk2dSpriteDefinition.ColliderType.None && Application.isPlaying)
			{
				Debug.LogError("Invalid mesh collider on sprite '" + base.name + "', please remove and try again.");
			}
			this.UpdateCollider();
			return;
		}
		if (tk2dSpriteDefinition.physicsEngine == tk2dSpriteDefinition.PhysicsEngine.Physics2D)
		{
			this.UpdateCollider();
		}
	}

	// Token: 0x06001E69 RID: 7785 RVA: 0x00096F25 File Offset: 0x00095125
	protected void Awake()
	{
		if (this.collection != null)
		{
			this.collectionInst = this.collection.inst;
		}
		this.CachedRenderer.sortingOrder = this.renderLayer;
	}

	// Token: 0x06001E6A RID: 7786 RVA: 0x00096F58 File Offset: 0x00095158
	public void CreateSimpleBoxCollider()
	{
		if (this.CurrentSprite == null)
		{
			return;
		}
		if (this.CurrentSprite.physicsEngine == tk2dSpriteDefinition.PhysicsEngine.Physics3D)
		{
			this.boxCollider2D = base.GetComponent<BoxCollider2D>();
			if (this.boxCollider2D != null)
			{
				UnityEngine.Object.DestroyImmediate(this.boxCollider2D, true);
			}
			this.boxCollider = base.GetComponent<BoxCollider>();
			if (this.boxCollider == null)
			{
				this.boxCollider = base.gameObject.AddComponent<BoxCollider>();
				return;
			}
		}
		else if (this.CurrentSprite.physicsEngine == tk2dSpriteDefinition.PhysicsEngine.Physics2D)
		{
			this.boxCollider = base.GetComponent<BoxCollider>();
			if (this.boxCollider != null)
			{
				UnityEngine.Object.DestroyImmediate(this.boxCollider, true);
			}
			this.boxCollider2D = base.GetComponent<BoxCollider2D>();
			if (this.boxCollider2D == null)
			{
				this.boxCollider2D = base.gameObject.AddComponent<BoxCollider2D>();
			}
		}
	}

	// Token: 0x06001E6B RID: 7787 RVA: 0x0009702C File Offset: 0x0009522C
	public bool UsesSpriteCollection(tk2dSpriteCollectionData spriteCollection)
	{
		return this.Collection == spriteCollection;
	}

	// Token: 0x06001E6C RID: 7788 RVA: 0x0009703C File Offset: 0x0009523C
	public virtual void ForceBuild()
	{
		if (this.collection == null)
		{
			return;
		}
		this.collectionInst = this.collection.inst;
		if (this.spriteId < 0 || this.spriteId >= this.collectionInst.spriteDefinitions.Length)
		{
			this.spriteId = 0;
		}
		this.Build();
		if (this.SpriteChanged != null)
		{
			this.SpriteChanged(this);
		}
	}

	// Token: 0x06001E6D RID: 7789 RVA: 0x000970A8 File Offset: 0x000952A8
	public static GameObject CreateFromTexture<T>(Texture texture, tk2dSpriteCollectionSize size, Rect region, Vector2 anchor) where T : tk2dBaseSprite
	{
		tk2dSpriteCollectionData tk2dSpriteCollectionData = SpriteCollectionGenerator.CreateFromTexture(texture, size, region, anchor);
		if (tk2dSpriteCollectionData == null)
		{
			return null;
		}
		GameObject gameObject = new GameObject();
		tk2dBaseSprite.AddComponent<T>(gameObject, tk2dSpriteCollectionData, 0);
		return gameObject;
	}

	// Token: 0x06001E6E RID: 7790 RVA: 0x000970D8 File Offset: 0x000952D8
	protected tk2dBaseSprite()
	{
		this._color = Color.white;
		this._scale = new Vector3(1f, 1f, 1f);
		this.polygonCollider2D = new List<PolygonCollider2D>(1);
		this.edgeCollider2D = new List<EdgeCollider2D>(1);
		base..ctor();
	}

	// Token: 0x040023B2 RID: 9138
	[SerializeField]
	private tk2dSpriteCollectionData collection;

	// Token: 0x040023B3 RID: 9139
	protected tk2dSpriteCollectionData collectionInst;

	// Token: 0x040023B4 RID: 9140
	[SerializeField]
	protected Color _color;

	// Token: 0x040023B5 RID: 9141
	[SerializeField]
	protected Vector3 _scale;

	// Token: 0x040023B6 RID: 9142
	[SerializeField]
	protected int _spriteId;

	// Token: 0x040023B7 RID: 9143
	public BoxCollider2D boxCollider2D;

	// Token: 0x040023B8 RID: 9144
	public List<PolygonCollider2D> polygonCollider2D;

	// Token: 0x040023B9 RID: 9145
	public List<EdgeCollider2D> edgeCollider2D;

	// Token: 0x040023BA RID: 9146
	public BoxCollider boxCollider;

	// Token: 0x040023BB RID: 9147
	public MeshCollider meshCollider;

	// Token: 0x040023BC RID: 9148
	public Vector3[] meshColliderPositions;

	// Token: 0x040023BD RID: 9149
	public Mesh meshColliderMesh;

	// Token: 0x040023BF RID: 9151
	private Renderer _cachedRenderer;

	// Token: 0x040023C0 RID: 9152
	[SerializeField]
	protected int renderLayer;

	// Token: 0x0200055C RID: 1372
	public enum Anchor
	{
		// Token: 0x040023C2 RID: 9154
		LowerLeft,
		// Token: 0x040023C3 RID: 9155
		LowerCenter,
		// Token: 0x040023C4 RID: 9156
		LowerRight,
		// Token: 0x040023C5 RID: 9157
		MiddleLeft,
		// Token: 0x040023C6 RID: 9158
		MiddleCenter,
		// Token: 0x040023C7 RID: 9159
		MiddleRight,
		// Token: 0x040023C8 RID: 9160
		UpperLeft,
		// Token: 0x040023C9 RID: 9161
		UpperCenter,
		// Token: 0x040023CA RID: 9162
		UpperRight
	}
}
