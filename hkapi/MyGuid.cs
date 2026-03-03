using System;
using UnityEngine;

// Token: 0x0200051C RID: 1308
[ExecuteInEditMode]
public class MyGuid : MonoBehaviour
{
	// Token: 0x17000385 RID: 901
	// (get) Token: 0x06001CBB RID: 7355 RVA: 0x000861F8 File Offset: 0x000843F8
	public Guid guid
	{
		get
		{
			if (this._guid == Guid.Empty && !string.IsNullOrEmpty(this.guidAsString))
			{
				this._guid = new Guid(this.guidAsString);
			}
			return this._guid;
		}
	}

	// Token: 0x06001CBC RID: 7356 RVA: 0x00086230 File Offset: 0x00084430
	public void Generate()
	{
		this._guid = Guid.NewGuid();
		this.guidAsString = this.guid.ToString();
	}

	// Token: 0x06001CBD RID: 7357 RVA: 0x00086262 File Offset: 0x00084462
	public string GetGuid()
	{
		return this.guidAsString;
	}

	// Token: 0x04002233 RID: 8755
	[SerializeField]
	private string guidAsString;

	// Token: 0x04002234 RID: 8756
	private Guid _guid;
}
