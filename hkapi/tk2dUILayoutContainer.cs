using System;
using UnityEngine;

// Token: 0x020005B7 RID: 1463
public abstract class tk2dUILayoutContainer : tk2dUILayout
{
	// Token: 0x06002136 RID: 8502 RVA: 0x000A6A7E File Offset: 0x000A4C7E
	public Vector2 GetInnerSize()
	{
		return this.innerSize;
	}

	// Token: 0x06002137 RID: 8503
	protected abstract void DoChildLayout();

	// Token: 0x1400005E RID: 94
	// (add) Token: 0x06002138 RID: 8504 RVA: 0x000A6A88 File Offset: 0x000A4C88
	// (remove) Token: 0x06002139 RID: 8505 RVA: 0x000A6AC0 File Offset: 0x000A4CC0
	public event Action OnChangeContent;

	// Token: 0x0600213A RID: 8506 RVA: 0x000A6AF8 File Offset: 0x000A4CF8
	public override void Reshape(Vector3 dMin, Vector3 dMax, bool updateChildren)
	{
		this.bMin += dMin;
		this.bMax += dMax;
		Vector3 b = new Vector3(this.bMin.x, this.bMax.y);
		base.transform.position += b;
		this.bMin -= b;
		this.bMax -= b;
		this.DoChildLayout();
		if (this.OnChangeContent != null)
		{
			this.OnChangeContent();
		}
	}

	// Token: 0x0600213B RID: 8507 RVA: 0x000A6B9A File Offset: 0x000A4D9A
	public void AddLayout(tk2dUILayout layout, tk2dUILayoutItem item)
	{
		item.gameObj = layout.gameObject;
		item.layout = layout;
		this.layoutItems.Add(item);
		layout.gameObject.transform.parent = base.transform;
		base.Refresh();
	}

	// Token: 0x0600213C RID: 8508 RVA: 0x000A6BD7 File Offset: 0x000A4DD7
	public void AddLayoutAtIndex(tk2dUILayout layout, tk2dUILayoutItem item, int index)
	{
		item.gameObj = layout.gameObject;
		item.layout = layout;
		this.layoutItems.Insert(index, item);
		layout.gameObject.transform.parent = base.transform;
		base.Refresh();
	}

	// Token: 0x0600213D RID: 8509 RVA: 0x000A6C18 File Offset: 0x000A4E18
	public void RemoveLayout(tk2dUILayout layout)
	{
		foreach (tk2dUILayoutItem tk2dUILayoutItem in this.layoutItems)
		{
			if (tk2dUILayoutItem.layout == layout)
			{
				this.layoutItems.Remove(tk2dUILayoutItem);
				layout.gameObject.transform.parent = null;
				break;
			}
		}
		base.Refresh();
	}

	// Token: 0x0600213E RID: 8510 RVA: 0x000A6C98 File Offset: 0x000A4E98
	protected tk2dUILayoutContainer()
	{
		this.innerSize = Vector2.zero;
		base..ctor();
	}

	// Token: 0x040026AB RID: 9899
	protected Vector2 innerSize;
}
