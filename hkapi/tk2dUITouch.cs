using System;
using UnityEngine;

// Token: 0x020005BE RID: 1470
public struct tk2dUITouch
{
	// Token: 0x1700045A RID: 1114
	// (get) Token: 0x06002173 RID: 8563 RVA: 0x000A8916 File Offset: 0x000A6B16
	// (set) Token: 0x06002174 RID: 8564 RVA: 0x000A891E File Offset: 0x000A6B1E
	public TouchPhase phase { readonly get; private set; }

	// Token: 0x1700045B RID: 1115
	// (get) Token: 0x06002175 RID: 8565 RVA: 0x000A8927 File Offset: 0x000A6B27
	// (set) Token: 0x06002176 RID: 8566 RVA: 0x000A892F File Offset: 0x000A6B2F
	public int fingerId { readonly get; private set; }

	// Token: 0x1700045C RID: 1116
	// (get) Token: 0x06002177 RID: 8567 RVA: 0x000A8938 File Offset: 0x000A6B38
	// (set) Token: 0x06002178 RID: 8568 RVA: 0x000A8940 File Offset: 0x000A6B40
	public Vector2 position { readonly get; private set; }

	// Token: 0x1700045D RID: 1117
	// (get) Token: 0x06002179 RID: 8569 RVA: 0x000A8949 File Offset: 0x000A6B49
	// (set) Token: 0x0600217A RID: 8570 RVA: 0x000A8951 File Offset: 0x000A6B51
	public Vector2 deltaPosition { readonly get; private set; }

	// Token: 0x1700045E RID: 1118
	// (get) Token: 0x0600217B RID: 8571 RVA: 0x000A895A File Offset: 0x000A6B5A
	// (set) Token: 0x0600217C RID: 8572 RVA: 0x000A8962 File Offset: 0x000A6B62
	public float deltaTime { readonly get; private set; }

	// Token: 0x0600217D RID: 8573 RVA: 0x000A896B File Offset: 0x000A6B6B
	public tk2dUITouch(TouchPhase _phase, int _fingerId, Vector2 _position, Vector2 _deltaPosition, float _deltaTime)
	{
		this = default(tk2dUITouch);
		this.phase = _phase;
		this.fingerId = _fingerId;
		this.position = _position;
		this.deltaPosition = _deltaPosition;
		this.deltaTime = _deltaTime;
	}

	// Token: 0x0600217E RID: 8574 RVA: 0x000A899C File Offset: 0x000A6B9C
	public tk2dUITouch(Touch touch)
	{
		this = default(tk2dUITouch);
		this.phase = touch.phase;
		this.fingerId = touch.fingerId;
		this.position = touch.position;
		this.deltaPosition = this.deltaPosition;
		this.deltaTime = this.deltaTime;
	}

	// Token: 0x0600217F RID: 8575 RVA: 0x000A89F0 File Offset: 0x000A6BF0
	public override string ToString()
	{
		return string.Concat(new string[]
		{
			this.phase.ToString(),
			",",
			this.fingerId.ToString(),
			",",
			this.position.ToString(),
			",",
			this.deltaPosition.ToString(),
			",",
			this.deltaTime.ToString()
		});
	}

	// Token: 0x040026DE RID: 9950
	public const int MOUSE_POINTER_FINGER_ID = 9999;
}
