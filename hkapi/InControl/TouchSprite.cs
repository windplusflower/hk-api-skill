using System;
using UnityEngine;

namespace InControl
{
	// Token: 0x0200071C RID: 1820
	[Serializable]
	public class TouchSprite
	{
		// Token: 0x170006DB RID: 1755
		// (get) Token: 0x06002D1F RID: 11551 RVA: 0x000F28F9 File Offset: 0x000F0AF9
		// (set) Token: 0x06002D20 RID: 11552 RVA: 0x000F2901 File Offset: 0x000F0B01
		public bool Dirty { get; set; }

		// Token: 0x170006DC RID: 1756
		// (get) Token: 0x06002D21 RID: 11553 RVA: 0x000F290A File Offset: 0x000F0B0A
		// (set) Token: 0x06002D22 RID: 11554 RVA: 0x000F2912 File Offset: 0x000F0B12
		public bool Ready { get; set; }

		// Token: 0x06002D23 RID: 11555 RVA: 0x000F291C File Offset: 0x000F0B1C
		public TouchSprite()
		{
			this.idleColor = new Color(1f, 1f, 1f, 0.5f);
			this.busyColor = new Color(1f, 1f, 1f, 1f);
			this.size = new Vector2(10f, 10f);
			this.lockAspectRatio = true;
			base..ctor();
		}

		// Token: 0x06002D24 RID: 11556 RVA: 0x000F298C File Offset: 0x000F0B8C
		public TouchSprite(float size)
		{
			this.idleColor = new Color(1f, 1f, 1f, 0.5f);
			this.busyColor = new Color(1f, 1f, 1f, 1f);
			this.size = new Vector2(10f, 10f);
			this.lockAspectRatio = true;
			base..ctor();
			this.size = Vector2.one * size;
		}

		// Token: 0x06002D25 RID: 11557 RVA: 0x000F2A0C File Offset: 0x000F0C0C
		public void Create(string gameObjectName, Transform parentTransform, int sortingOrder)
		{
			this.spriteGameObject = this.CreateSpriteGameObject(gameObjectName, parentTransform);
			this.spriteRenderer = this.CreateSpriteRenderer(this.spriteGameObject, this.idleSprite, sortingOrder);
			this.spriteRenderer.color = this.idleColor;
			this.Ready = true;
		}

		// Token: 0x06002D26 RID: 11558 RVA: 0x000F2A58 File Offset: 0x000F0C58
		public void Delete()
		{
			this.Ready = false;
			UnityEngine.Object.Destroy(this.spriteGameObject);
		}

		// Token: 0x06002D27 RID: 11559 RVA: 0x000F2A6C File Offset: 0x000F0C6C
		public void Update()
		{
			this.Update(false);
		}

		// Token: 0x06002D28 RID: 11560 RVA: 0x000F2A78 File Offset: 0x000F0C78
		public void Update(bool forceUpdate)
		{
			if (this.Dirty || forceUpdate)
			{
				if (this.spriteRenderer != null)
				{
					this.spriteRenderer.sprite = (this.State ? this.busySprite : this.idleSprite);
				}
				if (this.sizeUnitType == TouchUnitType.Pixels)
				{
					Vector2 a = TouchUtility.RoundVector(this.size);
					this.ScaleSpriteInPixels(this.spriteGameObject, this.spriteRenderer, a);
					this.worldSize = a * TouchManager.PixelToWorld;
				}
				else
				{
					this.ScaleSpriteInPercent(this.spriteGameObject, this.spriteRenderer, this.size);
					if (this.lockAspectRatio)
					{
						this.worldSize = this.size * TouchManager.PercentToWorld;
					}
					else
					{
						this.worldSize = Vector2.Scale(this.size, TouchManager.ViewSize);
					}
				}
				this.Dirty = false;
			}
			if (this.spriteRenderer != null)
			{
				Color color = this.State ? this.busyColor : this.idleColor;
				if (this.spriteRenderer.color != color)
				{
					this.spriteRenderer.color = Utility.MoveColorTowards(this.spriteRenderer.color, color, 5f * Time.unscaledDeltaTime);
				}
			}
		}

		// Token: 0x06002D29 RID: 11561 RVA: 0x000F2BB8 File Offset: 0x000F0DB8
		private GameObject CreateSpriteGameObject(string name, Transform parentTransform)
		{
			return new GameObject(name)
			{
				transform = 
				{
					parent = parentTransform,
					localPosition = Vector3.zero,
					localScale = Vector3.one
				},
				layer = parentTransform.gameObject.layer
			};
		}

		// Token: 0x06002D2A RID: 11562 RVA: 0x000F2C08 File Offset: 0x000F0E08
		private SpriteRenderer CreateSpriteRenderer(GameObject spriteGameObject, Sprite sprite, int sortingOrder)
		{
			if (!TouchSprite.spriteRendererMaterial)
			{
				TouchSprite.spriteRendererShader = Shader.Find("Sprites/Default");
				TouchSprite.spriteRendererMaterial = new Material(TouchSprite.spriteRendererShader);
				TouchSprite.spriteRendererPixelSnapId = Shader.PropertyToID("PixelSnap");
			}
			SpriteRenderer spriteRenderer = spriteGameObject.AddComponent<SpriteRenderer>();
			spriteRenderer.sprite = sprite;
			spriteRenderer.sortingOrder = sortingOrder;
			spriteRenderer.sharedMaterial = TouchSprite.spriteRendererMaterial;
			spriteRenderer.sharedMaterial.SetFloat(TouchSprite.spriteRendererPixelSnapId, 1f);
			return spriteRenderer;
		}

		// Token: 0x06002D2B RID: 11563 RVA: 0x000F2C84 File Offset: 0x000F0E84
		private void ScaleSpriteInPixels(GameObject spriteGameObject, SpriteRenderer spriteRenderer, Vector2 size)
		{
			if (spriteGameObject == null || spriteRenderer == null || spriteRenderer.sprite == null)
			{
				return;
			}
			float num = spriteRenderer.sprite.rect.width / spriteRenderer.sprite.bounds.size.x;
			float num2 = TouchManager.PixelToWorld * num;
			float x = num2 * size.x / spriteRenderer.sprite.rect.width;
			float y = num2 * size.y / spriteRenderer.sprite.rect.height;
			spriteGameObject.transform.localScale = new Vector3(x, y);
		}

		// Token: 0x06002D2C RID: 11564 RVA: 0x000F2D34 File Offset: 0x000F0F34
		private void ScaleSpriteInPercent(GameObject spriteGameObject, SpriteRenderer spriteRenderer, Vector2 size)
		{
			if (spriteGameObject == null || spriteRenderer == null || spriteRenderer.sprite == null)
			{
				return;
			}
			if (this.lockAspectRatio)
			{
				float num = Mathf.Min(TouchManager.ViewSize.x, TouchManager.ViewSize.y);
				float x = num * size.x / spriteRenderer.sprite.bounds.size.x;
				float y = num * size.y / spriteRenderer.sprite.bounds.size.y;
				spriteGameObject.transform.localScale = new Vector3(x, y);
				return;
			}
			float x2 = TouchManager.ViewSize.x * size.x / spriteRenderer.sprite.bounds.size.x;
			float y2 = TouchManager.ViewSize.y * size.y / spriteRenderer.sprite.bounds.size.y;
			spriteGameObject.transform.localScale = new Vector3(x2, y2);
		}

		// Token: 0x06002D2D RID: 11565 RVA: 0x000F2E44 File Offset: 0x000F1044
		public bool Contains(Vector2 testWorldPoint)
		{
			if (this.shape == TouchSpriteShape.Oval)
			{
				float num = (testWorldPoint.x - this.Position.x) / this.worldSize.x;
				float num2 = (testWorldPoint.y - this.Position.y) / this.worldSize.y;
				return num * num + num2 * num2 < 0.25f;
			}
			float num3 = Utility.Abs(testWorldPoint.x - this.Position.x) * 2f;
			float num4 = Utility.Abs(testWorldPoint.y - this.Position.y) * 2f;
			return num3 <= this.worldSize.x && num4 <= this.worldSize.y;
		}

		// Token: 0x06002D2E RID: 11566 RVA: 0x000F2EFF File Offset: 0x000F10FF
		public bool Contains(Touch touch)
		{
			return this.Contains(TouchManager.ScreenToWorldPoint(touch.position));
		}

		// Token: 0x06002D2F RID: 11567 RVA: 0x000F2F17 File Offset: 0x000F1117
		public void DrawGizmos(Vector3 position, Color color)
		{
			if (this.shape == TouchSpriteShape.Oval)
			{
				Utility.DrawOvalGizmo(position, this.WorldSize, color);
				return;
			}
			Utility.DrawRectGizmo(position, this.WorldSize, color);
		}

		// Token: 0x170006DD RID: 1757
		// (get) Token: 0x06002D30 RID: 11568 RVA: 0x000F2F46 File Offset: 0x000F1146
		// (set) Token: 0x06002D31 RID: 11569 RVA: 0x000F2F4E File Offset: 0x000F114E
		public bool State
		{
			get
			{
				return this.state;
			}
			set
			{
				if (this.state != value)
				{
					this.state = value;
					this.Dirty = true;
				}
			}
		}

		// Token: 0x170006DE RID: 1758
		// (get) Token: 0x06002D32 RID: 11570 RVA: 0x000F2F67 File Offset: 0x000F1167
		// (set) Token: 0x06002D33 RID: 11571 RVA: 0x000F2F6F File Offset: 0x000F116F
		public Sprite BusySprite
		{
			get
			{
				return this.busySprite;
			}
			set
			{
				if (this.busySprite != value)
				{
					this.busySprite = value;
					this.Dirty = true;
				}
			}
		}

		// Token: 0x170006DF RID: 1759
		// (get) Token: 0x06002D34 RID: 11572 RVA: 0x000F2F8D File Offset: 0x000F118D
		// (set) Token: 0x06002D35 RID: 11573 RVA: 0x000F2F95 File Offset: 0x000F1195
		public Sprite IdleSprite
		{
			get
			{
				return this.idleSprite;
			}
			set
			{
				if (this.idleSprite != value)
				{
					this.idleSprite = value;
					this.Dirty = true;
				}
			}
		}

		// Token: 0x170006E0 RID: 1760
		// (set) Token: 0x06002D36 RID: 11574 RVA: 0x000F2FB3 File Offset: 0x000F11B3
		public Sprite Sprite
		{
			set
			{
				if (this.idleSprite != value)
				{
					this.idleSprite = value;
					this.Dirty = true;
				}
				if (this.busySprite != value)
				{
					this.busySprite = value;
					this.Dirty = true;
				}
			}
		}

		// Token: 0x170006E1 RID: 1761
		// (get) Token: 0x06002D37 RID: 11575 RVA: 0x000F2FED File Offset: 0x000F11ED
		// (set) Token: 0x06002D38 RID: 11576 RVA: 0x000F2FF5 File Offset: 0x000F11F5
		public Color BusyColor
		{
			get
			{
				return this.busyColor;
			}
			set
			{
				if (this.busyColor != value)
				{
					this.busyColor = value;
					this.Dirty = true;
				}
			}
		}

		// Token: 0x170006E2 RID: 1762
		// (get) Token: 0x06002D39 RID: 11577 RVA: 0x000F3013 File Offset: 0x000F1213
		// (set) Token: 0x06002D3A RID: 11578 RVA: 0x000F301B File Offset: 0x000F121B
		public Color IdleColor
		{
			get
			{
				return this.idleColor;
			}
			set
			{
				if (this.idleColor != value)
				{
					this.idleColor = value;
					this.Dirty = true;
				}
			}
		}

		// Token: 0x170006E3 RID: 1763
		// (get) Token: 0x06002D3B RID: 11579 RVA: 0x000F3039 File Offset: 0x000F1239
		// (set) Token: 0x06002D3C RID: 11580 RVA: 0x000F3041 File Offset: 0x000F1241
		public TouchSpriteShape Shape
		{
			get
			{
				return this.shape;
			}
			set
			{
				if (this.shape != value)
				{
					this.shape = value;
					this.Dirty = true;
				}
			}
		}

		// Token: 0x170006E4 RID: 1764
		// (get) Token: 0x06002D3D RID: 11581 RVA: 0x000F305A File Offset: 0x000F125A
		// (set) Token: 0x06002D3E RID: 11582 RVA: 0x000F3062 File Offset: 0x000F1262
		public TouchUnitType SizeUnitType
		{
			get
			{
				return this.sizeUnitType;
			}
			set
			{
				if (this.sizeUnitType != value)
				{
					this.sizeUnitType = value;
					this.Dirty = true;
				}
			}
		}

		// Token: 0x170006E5 RID: 1765
		// (get) Token: 0x06002D3F RID: 11583 RVA: 0x000F307B File Offset: 0x000F127B
		// (set) Token: 0x06002D40 RID: 11584 RVA: 0x000F3083 File Offset: 0x000F1283
		public Vector2 Size
		{
			get
			{
				return this.size;
			}
			set
			{
				if (this.size != value)
				{
					this.size = value;
					this.Dirty = true;
				}
			}
		}

		// Token: 0x170006E6 RID: 1766
		// (get) Token: 0x06002D41 RID: 11585 RVA: 0x000F30A1 File Offset: 0x000F12A1
		public Vector2 WorldSize
		{
			get
			{
				return this.worldSize;
			}
		}

		// Token: 0x170006E7 RID: 1767
		// (get) Token: 0x06002D42 RID: 11586 RVA: 0x000F30A9 File Offset: 0x000F12A9
		// (set) Token: 0x06002D43 RID: 11587 RVA: 0x000F30CE File Offset: 0x000F12CE
		public Vector3 Position
		{
			get
			{
				if (!this.spriteGameObject)
				{
					return Vector3.zero;
				}
				return this.spriteGameObject.transform.position;
			}
			set
			{
				if (this.spriteGameObject)
				{
					this.spriteGameObject.transform.position = value;
				}
			}
		}

		// Token: 0x04003298 RID: 12952
		[SerializeField]
		private Sprite idleSprite;

		// Token: 0x04003299 RID: 12953
		[SerializeField]
		private Sprite busySprite;

		// Token: 0x0400329A RID: 12954
		[SerializeField]
		private Color idleColor;

		// Token: 0x0400329B RID: 12955
		[SerializeField]
		private Color busyColor;

		// Token: 0x0400329C RID: 12956
		[SerializeField]
		private TouchSpriteShape shape;

		// Token: 0x0400329D RID: 12957
		[SerializeField]
		private TouchUnitType sizeUnitType;

		// Token: 0x0400329E RID: 12958
		[SerializeField]
		private Vector2 size;

		// Token: 0x0400329F RID: 12959
		[SerializeField]
		private bool lockAspectRatio;

		// Token: 0x040032A0 RID: 12960
		[SerializeField]
		[HideInInspector]
		private Vector2 worldSize;

		// Token: 0x040032A1 RID: 12961
		private GameObject spriteGameObject;

		// Token: 0x040032A2 RID: 12962
		private SpriteRenderer spriteRenderer;

		// Token: 0x040032A3 RID: 12963
		private bool state;

		// Token: 0x040032A6 RID: 12966
		private static Shader spriteRendererShader;

		// Token: 0x040032A7 RID: 12967
		private static Material spriteRendererMaterial;

		// Token: 0x040032A8 RID: 12968
		private static int spriteRendererPixelSnapId;
	}
}
