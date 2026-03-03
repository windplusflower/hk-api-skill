using System;
using System.Collections;

// Token: 0x0200001F RID: 31
public class PlayMakerArrayListProxy : PlayMakerCollectionProxy
{
	// Token: 0x17000009 RID: 9
	// (get) Token: 0x060000DC RID: 220 RVA: 0x00005286 File Offset: 0x00003486
	public ArrayList arrayList
	{
		get
		{
			return this._arrayList;
		}
	}

	// Token: 0x060000DD RID: 221 RVA: 0x0000528E File Offset: 0x0000348E
	public void Awake()
	{
		this._arrayList = new ArrayList();
		this.PreFillArrayList();
		this.TakeSnapShot();
	}

	// Token: 0x060000DE RID: 222 RVA: 0x000052A7 File Offset: 0x000034A7
	public bool isCollectionDefined()
	{
		return this.arrayList != null;
	}

	// Token: 0x060000DF RID: 223 RVA: 0x000052B2 File Offset: 0x000034B2
	public void TakeSnapShot()
	{
		this._snapShot = new ArrayList();
		this._snapShot.AddRange(this._arrayList);
	}

	// Token: 0x060000E0 RID: 224 RVA: 0x000052D0 File Offset: 0x000034D0
	public void RevertToSnapShot()
	{
		this._arrayList = new ArrayList();
		this._arrayList.AddRange(this._snapShot);
	}

	// Token: 0x060000E1 RID: 225 RVA: 0x000052EE File Offset: 0x000034EE
	public void Add(object value, string type, bool silent = false)
	{
		this.arrayList.Add(value);
		if (!silent)
		{
			base.dispatchEvent(this.addEvent, value, type);
		}
	}

	// Token: 0x060000E2 RID: 226 RVA: 0x0000530E File Offset: 0x0000350E
	public int AddRange(ICollection collection, string type)
	{
		this.arrayList.AddRange(collection);
		return this.arrayList.Count;
	}

	// Token: 0x060000E3 RID: 227 RVA: 0x00005327 File Offset: 0x00003527
	public void InspectorEdit(int index)
	{
		base.dispatchEvent(this.setEvent, index, "int");
	}

	// Token: 0x060000E4 RID: 228 RVA: 0x00005340 File Offset: 0x00003540
	public void Set(int index, object value, string type)
	{
		this.arrayList[index] = value;
		base.dispatchEvent(this.setEvent, index, "int");
	}

	// Token: 0x060000E5 RID: 229 RVA: 0x00005366 File Offset: 0x00003566
	public bool Remove(object value, string type, bool silent = false)
	{
		if (this.arrayList.Contains(value))
		{
			this.arrayList.Remove(value);
			if (!silent)
			{
				base.dispatchEvent(this.removeEvent, value, type);
			}
			return true;
		}
		return false;
	}

	// Token: 0x060000E6 RID: 230 RVA: 0x00005398 File Offset: 0x00003598
	private void PreFillArrayList()
	{
		switch (this.preFillType)
		{
		case PlayMakerCollectionProxy.VariableEnum.GameObject:
			this.arrayList.InsertRange(0, this.preFillGameObjectList);
			return;
		case PlayMakerCollectionProxy.VariableEnum.Int:
			this.arrayList.InsertRange(0, this.preFillIntList);
			return;
		case PlayMakerCollectionProxy.VariableEnum.Float:
			this.arrayList.InsertRange(0, this.preFillFloatList);
			return;
		case PlayMakerCollectionProxy.VariableEnum.String:
			this.arrayList.InsertRange(0, this.preFillStringList);
			return;
		case PlayMakerCollectionProxy.VariableEnum.Bool:
			this.arrayList.InsertRange(0, this.preFillBoolList);
			return;
		case PlayMakerCollectionProxy.VariableEnum.Vector3:
			this.arrayList.InsertRange(0, this.preFillVector3List);
			return;
		case PlayMakerCollectionProxy.VariableEnum.Rect:
			this.arrayList.InsertRange(0, this.preFillRectList);
			return;
		case PlayMakerCollectionProxy.VariableEnum.Quaternion:
			this.arrayList.InsertRange(0, this.preFillQuaternionList);
			return;
		case PlayMakerCollectionProxy.VariableEnum.Color:
			this.arrayList.InsertRange(0, this.preFillColorList);
			return;
		case PlayMakerCollectionProxy.VariableEnum.Material:
			this.arrayList.InsertRange(0, this.preFillMaterialList);
			return;
		case PlayMakerCollectionProxy.VariableEnum.Texture:
			this.arrayList.InsertRange(0, this.preFillTextureList);
			return;
		case PlayMakerCollectionProxy.VariableEnum.Vector2:
			this.arrayList.InsertRange(0, this.preFillVector2List);
			return;
		case PlayMakerCollectionProxy.VariableEnum.AudioClip:
			this.arrayList.InsertRange(0, this.preFillAudioClipList);
			return;
		default:
			return;
		}
	}

	// Token: 0x04000077 RID: 119
	public ArrayList _arrayList;

	// Token: 0x04000078 RID: 120
	private ArrayList _snapShot;
}
