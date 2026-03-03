using System;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

// Token: 0x020004BA RID: 1210
[RequireComponent(typeof(RectTransform))]
public class ScrollBarHandle : MonoBehaviour
{
	// Token: 0x06001AC0 RID: 6848 RVA: 0x0007FBD3 File Offset: 0x0007DDD3
	private void Awake()
	{
		this.trans = base.GetComponent<RectTransform>();
		if (!this.scrollBar)
		{
			this.scrollBar = base.GetComponentInParent<Scrollbar>();
		}
	}

	// Token: 0x06001AC1 RID: 6849 RVA: 0x0007FBFA File Offset: 0x0007DDFA
	private void Start()
	{
		if (this.scrollBar)
		{
			this.scrollBar.onValueChanged.AddListener(new UnityAction<float>(this.UpdatePosition));
		}
	}

	// Token: 0x06001AC2 RID: 6850 RVA: 0x0007FC28 File Offset: 0x0007DE28
	private void UpdatePosition(float value)
	{
		this.trans.pivot = new Vector2(0.5f, value);
		this.trans.anchorMin = new Vector2(0.5f, value);
		this.trans.anchorMax = new Vector2(0.5f, value);
		this.trans.anchoredPosition.Set(this.trans.anchoredPosition.x, 0f);
	}

	// Token: 0x04002012 RID: 8210
	public Scrollbar scrollBar;

	// Token: 0x04002013 RID: 8211
	private RectTransform trans;
}
