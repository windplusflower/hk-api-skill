using System;
using System.Collections;

// Token: 0x02000022 RID: 34
public class PlayMakerHashTableProxy : PlayMakerCollectionProxy
{
	// Token: 0x1700000A RID: 10
	// (get) Token: 0x060000EC RID: 236 RVA: 0x00005C17 File Offset: 0x00003E17
	public Hashtable hashTable
	{
		get
		{
			return this._hashTable;
		}
	}

	// Token: 0x060000ED RID: 237 RVA: 0x00005C1F File Offset: 0x00003E1F
	public void Awake()
	{
		this._hashTable = new Hashtable();
		this.PreFillHashTable();
		this.TakeSnapShot();
	}

	// Token: 0x060000EE RID: 238 RVA: 0x00005C38 File Offset: 0x00003E38
	public bool isCollectionDefined()
	{
		return this.hashTable != null;
	}

	// Token: 0x060000EF RID: 239 RVA: 0x00005C44 File Offset: 0x00003E44
	public void TakeSnapShot()
	{
		this._snapShot = new Hashtable();
		foreach (object key in this._hashTable.Keys)
		{
			this._snapShot[key] = this._hashTable[key];
		}
	}

	// Token: 0x060000F0 RID: 240 RVA: 0x00005CBC File Offset: 0x00003EBC
	public void RevertToSnapShot()
	{
		this._hashTable = new Hashtable();
		foreach (object key in this._snapShot.Keys)
		{
			this._hashTable[key] = this._snapShot[key];
		}
	}

	// Token: 0x060000F1 RID: 241 RVA: 0x00005327 File Offset: 0x00003527
	public void InspectorEdit(int index)
	{
		base.dispatchEvent(this.setEvent, index, "int");
	}

	// Token: 0x060000F2 RID: 242 RVA: 0x00005D34 File Offset: 0x00003F34
	private void PreFillHashTable()
	{
		for (int i = 0; i < this.preFillKeyList.Count; i++)
		{
			switch (this.preFillType)
			{
			case PlayMakerCollectionProxy.VariableEnum.GameObject:
				this.hashTable[this.preFillKeyList[i]] = this.preFillGameObjectList[i];
				break;
			case PlayMakerCollectionProxy.VariableEnum.Int:
				this.hashTable[this.preFillKeyList[i]] = this.preFillIntList[i];
				break;
			case PlayMakerCollectionProxy.VariableEnum.Float:
				this.hashTable[this.preFillKeyList[i]] = this.preFillFloatList[i];
				break;
			case PlayMakerCollectionProxy.VariableEnum.String:
				this.hashTable[this.preFillKeyList[i]] = this.preFillStringList[i];
				break;
			case PlayMakerCollectionProxy.VariableEnum.Bool:
				this.hashTable[this.preFillKeyList[i]] = this.preFillBoolList[i];
				break;
			case PlayMakerCollectionProxy.VariableEnum.Vector3:
				this.hashTable[this.preFillKeyList[i]] = this.preFillVector3List[i];
				break;
			case PlayMakerCollectionProxy.VariableEnum.Rect:
				this.hashTable[this.preFillKeyList[i]] = this.preFillRectList[i];
				break;
			case PlayMakerCollectionProxy.VariableEnum.Quaternion:
				this.hashTable[this.preFillKeyList[i]] = this.preFillQuaternionList[i];
				break;
			case PlayMakerCollectionProxy.VariableEnum.Color:
				this.hashTable[this.preFillKeyList[i]] = this.preFillColorList[i];
				break;
			case PlayMakerCollectionProxy.VariableEnum.Material:
				this.hashTable[this.preFillKeyList[i]] = this.preFillMaterialList[i];
				break;
			case PlayMakerCollectionProxy.VariableEnum.Texture:
				this.hashTable[this.preFillKeyList[i]] = this.preFillTextureList[i];
				break;
			case PlayMakerCollectionProxy.VariableEnum.Vector2:
				this.hashTable[this.preFillKeyList[i]] = this.preFillVector2List[i];
				break;
			case PlayMakerCollectionProxy.VariableEnum.AudioClip:
				this.hashTable[this.preFillKeyList[i]] = this.preFillAudioClipList[i];
				break;
			}
		}
	}

	// Token: 0x040000A5 RID: 165
	public Hashtable _hashTable;

	// Token: 0x040000A6 RID: 166
	private Hashtable _snapShot;
}
