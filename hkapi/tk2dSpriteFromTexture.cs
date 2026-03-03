using System;
using tk2dRuntime;
using UnityEngine;

// Token: 0x0200058B RID: 1419
[AddComponentMenu("2D Toolkit/Sprite/tk2dSpriteFromTexture")]
[ExecuteInEditMode]
public class tk2dSpriteFromTexture : MonoBehaviour
{
	// Token: 0x17000409 RID: 1033
	// (get) Token: 0x06001F5B RID: 8027 RVA: 0x0009C094 File Offset: 0x0009A294
	private tk2dBaseSprite Sprite
	{
		get
		{
			if (this._sprite == null)
			{
				this._sprite = base.GetComponent<tk2dBaseSprite>();
				if (this._sprite == null)
				{
					Debug.Log("tk2dSpriteFromTexture - Missing sprite object. Creating.");
					this._sprite = base.gameObject.AddComponent<tk2dSprite>();
				}
			}
			return this._sprite;
		}
	}

	// Token: 0x06001F5C RID: 8028 RVA: 0x0009C0EA File Offset: 0x0009A2EA
	private void Awake()
	{
		this.Create(this.spriteCollectionSize, this.texture, this.anchor);
	}

	// Token: 0x1700040A RID: 1034
	// (get) Token: 0x06001F5D RID: 8029 RVA: 0x0009C104 File Offset: 0x0009A304
	public bool HasSpriteCollection
	{
		get
		{
			return this.spriteCollection != null;
		}
	}

	// Token: 0x06001F5E RID: 8030 RVA: 0x0009C114 File Offset: 0x0009A314
	private void OnDestroy()
	{
		this.DestroyInternal();
		Renderer component = base.GetComponent<Renderer>();
		if (component != null)
		{
			component.material = null;
		}
	}

	// Token: 0x06001F5F RID: 8031 RVA: 0x0009C140 File Offset: 0x0009A340
	public void Create(tk2dSpriteCollectionSize spriteCollectionSize, Texture texture, tk2dBaseSprite.Anchor anchor)
	{
		this.DestroyInternal();
		if (texture != null)
		{
			this.spriteCollectionSize.CopyFrom(spriteCollectionSize);
			this.texture = texture;
			this.anchor = anchor;
			GameObject gameObject = new GameObject("tk2dSpriteFromTexture - " + texture.name);
			gameObject.transform.localPosition = Vector3.zero;
			gameObject.transform.localRotation = Quaternion.identity;
			gameObject.transform.localScale = Vector3.one;
			gameObject.hideFlags = HideFlags.DontSave;
			Vector2 anchorOffset = tk2dSpriteGeomGen.GetAnchorOffset(anchor, (float)texture.width, (float)texture.height);
			this.spriteCollection = SpriteCollectionGenerator.CreateFromTexture(gameObject, texture, spriteCollectionSize, new Vector2((float)texture.width, (float)texture.height), new string[]
			{
				"unnamed"
			}, new Rect[]
			{
				new Rect(0f, 0f, (float)texture.width, (float)texture.height)
			}, null, new Vector2[]
			{
				anchorOffset
			}, new bool[1]);
			string text = "SpriteFromTexture " + texture.name;
			this.spriteCollection.spriteCollectionName = text;
			this.spriteCollection.spriteDefinitions[0].material.name = text;
			this.spriteCollection.spriteDefinitions[0].material.hideFlags = (HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
			this.Sprite.SetSprite(this.spriteCollection, 0);
		}
	}

	// Token: 0x06001F60 RID: 8032 RVA: 0x0009C2AA File Offset: 0x0009A4AA
	public void Clear()
	{
		this.DestroyInternal();
	}

	// Token: 0x06001F61 RID: 8033 RVA: 0x0009C2B2 File Offset: 0x0009A4B2
	public void ForceBuild()
	{
		this.DestroyInternal();
		this.Create(this.spriteCollectionSize, this.texture, this.anchor);
	}

	// Token: 0x06001F62 RID: 8034 RVA: 0x0009C2D4 File Offset: 0x0009A4D4
	private void DestroyInternal()
	{
		if (this.spriteCollection != null)
		{
			if (this.spriteCollection.spriteDefinitions[0].material != null)
			{
				UnityEngine.Object.DestroyImmediate(this.spriteCollection.spriteDefinitions[0].material);
			}
			UnityEngine.Object.DestroyImmediate(this.spriteCollection.gameObject);
			this.spriteCollection = null;
		}
	}

	// Token: 0x06001F63 RID: 8035 RVA: 0x0009C337 File Offset: 0x0009A537
	public tk2dSpriteFromTexture()
	{
		this.spriteCollectionSize = new tk2dSpriteCollectionSize();
		this.anchor = tk2dBaseSprite.Anchor.MiddleCenter;
		base..ctor();
	}

	// Token: 0x04002559 RID: 9561
	public Texture texture;

	// Token: 0x0400255A RID: 9562
	public tk2dSpriteCollectionSize spriteCollectionSize;

	// Token: 0x0400255B RID: 9563
	public tk2dBaseSprite.Anchor anchor;

	// Token: 0x0400255C RID: 9564
	private tk2dSpriteCollectionData spriteCollection;

	// Token: 0x0400255D RID: 9565
	private tk2dBaseSprite _sprite;
}
