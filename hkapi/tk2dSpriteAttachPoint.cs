using System;
using System.Collections.Generic;
using UnityEngine;

// Token: 0x02000568 RID: 1384
[ExecuteInEditMode]
[AddComponentMenu("2D Toolkit/Sprite/tk2dSpriteAttachPoint")]
public class tk2dSpriteAttachPoint : MonoBehaviour
{
	// Token: 0x06001F06 RID: 7942 RVA: 0x0009A1BC File Offset: 0x000983BC
	private void Awake()
	{
		if (this.sprite == null)
		{
			this.sprite = base.GetComponent<tk2dBaseSprite>();
			if (this.sprite != null)
			{
				this.HandleSpriteChanged(this.sprite);
			}
		}
	}

	// Token: 0x06001F07 RID: 7943 RVA: 0x0009A1F2 File Offset: 0x000983F2
	private void OnEnable()
	{
		if (this.sprite != null)
		{
			this.sprite.SpriteChanged += this.HandleSpriteChanged;
		}
	}

	// Token: 0x06001F08 RID: 7944 RVA: 0x0009A219 File Offset: 0x00098419
	private void OnDisable()
	{
		if (this.sprite != null)
		{
			this.sprite.SpriteChanged -= this.HandleSpriteChanged;
		}
	}

	// Token: 0x06001F09 RID: 7945 RVA: 0x0009A240 File Offset: 0x00098440
	private void UpdateAttachPointTransform(tk2dSpriteDefinition.AttachPoint attachPoint, Transform t)
	{
		t.localPosition = Vector3.Scale(attachPoint.position, this.sprite.scale);
		t.localScale = this.sprite.scale;
		float num = Mathf.Sign(this.sprite.scale.x) * Mathf.Sign(this.sprite.scale.y);
		t.localEulerAngles = new Vector3(0f, 0f, attachPoint.angle * num);
	}

	// Token: 0x06001F0A RID: 7946 RVA: 0x0009A2C4 File Offset: 0x000984C4
	private string GetInstanceName(Transform t)
	{
		string result = "";
		if (this.cachedInstanceNames.TryGetValue(t, out result))
		{
			return result;
		}
		this.cachedInstanceNames[t] = t.name;
		return t.name;
	}

	// Token: 0x06001F0B RID: 7947 RVA: 0x0009A304 File Offset: 0x00098504
	private void HandleSpriteChanged(tk2dBaseSprite spr)
	{
		tk2dSpriteDefinition currentSprite = spr.CurrentSprite;
		int num = Mathf.Max(currentSprite.attachPoints.Length, this.attachPoints.Count);
		if (num > tk2dSpriteAttachPoint.attachPointUpdated.Length)
		{
			tk2dSpriteAttachPoint.attachPointUpdated = new bool[num];
		}
		foreach (tk2dSpriteDefinition.AttachPoint attachPoint in currentSprite.attachPoints)
		{
			bool flag = false;
			int num2 = 0;
			for (int j = 0; j < this.attachPoints.Count; j++)
			{
				Transform transform = this.attachPoints[j];
				if (transform != null && this.GetInstanceName(transform) == attachPoint.name)
				{
					tk2dSpriteAttachPoint.attachPointUpdated[num2] = true;
					this.UpdateAttachPointTransform(attachPoint, transform);
					flag = true;
				}
				num2++;
			}
			if (!flag)
			{
				Transform transform2 = new GameObject(attachPoint.name).transform;
				transform2.parent = base.transform;
				this.UpdateAttachPointTransform(attachPoint, transform2);
				tk2dSpriteAttachPoint.attachPointUpdated[this.attachPoints.Count] = true;
				this.attachPoints.Add(transform2);
			}
		}
		if (this.deactivateUnusedAttachPoints)
		{
			for (int k = 0; k < this.attachPoints.Count; k++)
			{
				if (this.attachPoints[k] != null)
				{
					GameObject gameObject = this.attachPoints[k].gameObject;
					if (tk2dSpriteAttachPoint.attachPointUpdated[k] && !gameObject.activeSelf)
					{
						gameObject.SetActive(true);
					}
					else if (!tk2dSpriteAttachPoint.attachPointUpdated[k] && gameObject.activeSelf)
					{
						gameObject.SetActive(false);
					}
				}
				tk2dSpriteAttachPoint.attachPointUpdated[k] = false;
			}
		}
	}

	// Token: 0x06001F0C RID: 7948 RVA: 0x0009A4AC File Offset: 0x000986AC
	public tk2dSpriteAttachPoint()
	{
		this.attachPoints = new List<Transform>();
		this.cachedInstanceNames = new Dictionary<Transform, string>();
		base..ctor();
	}

	// Token: 0x06001F0D RID: 7949 RVA: 0x0009A4CA File Offset: 0x000986CA
	// Note: this type is marked as 'beforefieldinit'.
	static tk2dSpriteAttachPoint()
	{
		tk2dSpriteAttachPoint.attachPointUpdated = new bool[32];
	}

	// Token: 0x0400241A RID: 9242
	private tk2dBaseSprite sprite;

	// Token: 0x0400241B RID: 9243
	public List<Transform> attachPoints;

	// Token: 0x0400241C RID: 9244
	private static bool[] attachPointUpdated;

	// Token: 0x0400241D RID: 9245
	public bool deactivateUnusedAttachPoints;

	// Token: 0x0400241E RID: 9246
	private Dictionary<Transform, string> cachedInstanceNames;
}
