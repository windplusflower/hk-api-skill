using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000B49 RID: 2889
	public abstract class ComponentAction<T> : FsmStateAction where T : Component
	{
		// Token: 0x1700072F RID: 1839
		// (get) Token: 0x06003DB8 RID: 15800 RVA: 0x001625C4 File Offset: 0x001607C4
		protected Rigidbody rigidbody
		{
			get
			{
				return this.component as Rigidbody;
			}
		}

		// Token: 0x17000730 RID: 1840
		// (get) Token: 0x06003DB9 RID: 15801 RVA: 0x001625D6 File Offset: 0x001607D6
		protected Rigidbody2D rigidbody2d
		{
			get
			{
				return this.component as Rigidbody2D;
			}
		}

		// Token: 0x17000731 RID: 1841
		// (get) Token: 0x06003DBA RID: 15802 RVA: 0x001625E8 File Offset: 0x001607E8
		protected Renderer renderer
		{
			get
			{
				return this.component as Renderer;
			}
		}

		// Token: 0x17000732 RID: 1842
		// (get) Token: 0x06003DBB RID: 15803 RVA: 0x001625FA File Offset: 0x001607FA
		protected Animation animation
		{
			get
			{
				return this.component as Animation;
			}
		}

		// Token: 0x17000733 RID: 1843
		// (get) Token: 0x06003DBC RID: 15804 RVA: 0x0016260C File Offset: 0x0016080C
		protected AudioSource audio
		{
			get
			{
				return this.component as AudioSource;
			}
		}

		// Token: 0x17000734 RID: 1844
		// (get) Token: 0x06003DBD RID: 15805 RVA: 0x0016261E File Offset: 0x0016081E
		protected Camera camera
		{
			get
			{
				return this.component as Camera;
			}
		}

		// Token: 0x17000735 RID: 1845
		// (get) Token: 0x06003DBE RID: 15806 RVA: 0x00162630 File Offset: 0x00160830
		protected Light light
		{
			get
			{
				return this.component as Light;
			}
		}

		// Token: 0x06003DBF RID: 15807 RVA: 0x00162644 File Offset: 0x00160844
		protected bool UpdateCache(GameObject go)
		{
			if (go == null)
			{
				return false;
			}
			if (this.component == null || this.cachedGameObject != go)
			{
				this.component = go.GetComponent<T>();
				this.cachedGameObject = go;
				if (this.component == null)
				{
					base.LogWarning("Missing component: " + typeof(T).FullName + " on: " + go.name);
				}
			}
			return this.component != null;
		}

		// Token: 0x040041D2 RID: 16850
		private GameObject cachedGameObject;

		// Token: 0x040041D3 RID: 16851
		private T component;
	}
}
