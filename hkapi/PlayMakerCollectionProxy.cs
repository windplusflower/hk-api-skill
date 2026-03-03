using System;
using System.Collections.Generic;
using HutongGames.PlayMaker;
using UnityEngine;

// Token: 0x02000020 RID: 32
public abstract class PlayMakerCollectionProxy : MonoBehaviour
{
	// Token: 0x060000E8 RID: 232 RVA: 0x000054E5 File Offset: 0x000036E5
	internal string getFsmVariableType(VariableType _type)
	{
		return _type.ToString();
	}

	// Token: 0x060000E9 RID: 233 RVA: 0x000054F4 File Offset: 0x000036F4
	internal void dispatchEvent(string anEvent, object value, string type)
	{
		if (!this.enablePlayMakerEvents)
		{
			return;
		}
		if (type != null)
		{
			uint num = <PrivateImplementationDetails>.ComputeStringHash(type);
			if (num <= 1707186308U)
			{
				if (num <= 655918371U)
				{
					if (num != 398550328U)
					{
						if (num != 639140752U)
						{
							if (num == 655918371U)
							{
								if (type == "vector3")
								{
									Fsm.EventData.Vector3Data = (Vector3)value;
								}
							}
						}
						else if (type == "vector2")
						{
							Fsm.EventData.Vector3Data = (Vector3)value;
						}
					}
					else if (type == "string")
					{
						Fsm.EventData.StringData = (string)value;
					}
				}
				else if (num != 1013213428U)
				{
					if (num != 1031692888U)
					{
						if (num == 1707186308U)
						{
							if (type == "gameObject")
							{
								Fsm.EventData.ObjectData = (GameObject)value;
							}
						}
					}
					else if (type == "color")
					{
						Fsm.EventData.ColorData = (Color)value;
					}
				}
				else if (type == "texture")
				{
					Fsm.EventData.TextureData = (Texture)value;
				}
			}
			else if (num <= 3099987130U)
			{
				if (num != 2515107422U)
				{
					if (num != 2797886853U)
					{
						if (num == 3099987130U)
						{
							if (type == "object")
							{
								Fsm.EventData.ObjectData = (UnityEngine.Object)value;
							}
						}
					}
					else if (type == "float")
					{
						Fsm.EventData.FloatData = (float)value;
					}
				}
				else if (type == "int")
				{
					Fsm.EventData.IntData = (int)value;
				}
			}
			else if (num <= 3538210912U)
			{
				if (num != 3365180733U)
				{
					if (num == 3538210912U)
					{
						if (type == "material")
						{
							Fsm.EventData.MaterialData = (Material)value;
						}
					}
				}
				else if (type == "bool")
				{
					Fsm.EventData.BoolData = (bool)value;
				}
			}
			else if (num != 3940830471U)
			{
				if (num == 4091954829U)
				{
					if (type == "quaternion")
					{
						Fsm.EventData.QuaternionData = (Quaternion)value;
					}
				}
			}
			else if (type == "rect")
			{
				Fsm.EventData.RectData = (Rect)value;
			}
		}
		FsmEventTarget fsmEventTarget = new FsmEventTarget();
		fsmEventTarget.target = FsmEventTarget.EventTarget.BroadcastAll;
		List<Fsm> list = new List<Fsm>(Fsm.FsmList);
		if (list.Count > 0)
		{
			list[0].Event(fsmEventTarget, anEvent);
		}
	}

	// Token: 0x060000EA RID: 234 RVA: 0x00005814 File Offset: 0x00003A14
	public void cleanPrefilledLists()
	{
		if (this.preFillKeyList.Count > this.preFillCount)
		{
			this.preFillKeyList.RemoveRange(this.preFillCount, this.preFillKeyList.Count - this.preFillCount);
		}
		if (this.preFillBoolList.Count > this.preFillCount)
		{
			this.preFillBoolList.RemoveRange(this.preFillCount, this.preFillBoolList.Count - this.preFillCount);
		}
		if (this.preFillColorList.Count > this.preFillCount)
		{
			this.preFillColorList.RemoveRange(this.preFillCount, this.preFillColorList.Count - this.preFillCount);
		}
		if (this.preFillFloatList.Count > this.preFillCount)
		{
			this.preFillFloatList.RemoveRange(this.preFillCount, this.preFillFloatList.Count - this.preFillCount);
		}
		if (this.preFillIntList.Count > this.preFillCount)
		{
			this.preFillIntList.RemoveRange(this.preFillCount, this.preFillIntList.Count - this.preFillCount);
		}
		if (this.preFillMaterialList.Count > this.preFillCount)
		{
			this.preFillMaterialList.RemoveRange(this.preFillCount, this.preFillMaterialList.Count - this.preFillCount);
		}
		if (this.preFillGameObjectList.Count > this.preFillCount)
		{
			this.preFillGameObjectList.RemoveRange(this.preFillCount, this.preFillGameObjectList.Count - this.preFillCount);
		}
		if (this.preFillObjectList.Count > this.preFillCount)
		{
			this.preFillObjectList.RemoveRange(this.preFillCount, this.preFillObjectList.Count - this.preFillCount);
		}
		if (this.preFillQuaternionList.Count > this.preFillCount)
		{
			this.preFillQuaternionList.RemoveRange(this.preFillCount, this.preFillQuaternionList.Count - this.preFillCount);
		}
		if (this.preFillRectList.Count > this.preFillCount)
		{
			this.preFillRectList.RemoveRange(this.preFillCount, this.preFillRectList.Count - this.preFillCount);
		}
		if (this.preFillStringList.Count > this.preFillCount)
		{
			this.preFillStringList.RemoveRange(this.preFillCount, this.preFillStringList.Count - this.preFillCount);
		}
		if (this.preFillTextureList.Count > this.preFillCount)
		{
			this.preFillTextureList.RemoveRange(this.preFillCount, this.preFillTextureList.Count - this.preFillCount);
		}
		if (this.preFillVector2List.Count > this.preFillCount)
		{
			this.preFillVector2List.RemoveRange(this.preFillCount, this.preFillVector2List.Count - this.preFillCount);
		}
		if (this.preFillVector3List.Count > this.preFillCount)
		{
			this.preFillVector3List.RemoveRange(this.preFillCount, this.preFillVector3List.Count - this.preFillCount);
		}
		if (this.preFillAudioClipList.Count > this.preFillCount)
		{
			this.preFillAudioClipList.RemoveRange(this.preFillCount, this.preFillAudioClipList.Count - this.preFillCount);
		}
	}

	// Token: 0x060000EB RID: 235 RVA: 0x00005B4C File Offset: 0x00003D4C
	protected PlayMakerCollectionProxy()
	{
		this.referenceName = "";
		this.contentPreviewMaxRows = 10;
		this.preFillKeyList = new List<string>();
		this.preFillBoolList = new List<bool>();
		this.preFillColorList = new List<Color>();
		this.preFillFloatList = new List<float>();
		this.preFillGameObjectList = new List<GameObject>();
		this.preFillIntList = new List<int>();
		this.preFillMaterialList = new List<Material>();
		this.preFillObjectList = new List<UnityEngine.Object>();
		this.preFillQuaternionList = new List<Quaternion>();
		this.preFillRectList = new List<Rect>();
		this.preFillStringList = new List<string>();
		this.preFillTextureList = new List<Texture2D>();
		this.preFillVector2List = new List<Vector2>();
		this.preFillVector3List = new List<Vector3>();
		this.preFillAudioClipList = new List<AudioClip>();
		base..ctor();
	}

	// Token: 0x04000079 RID: 121
	public bool showEvents;

	// Token: 0x0400007A RID: 122
	public bool showContent;

	// Token: 0x0400007B RID: 123
	public bool TextureElementSmall;

	// Token: 0x0400007C RID: 124
	public bool condensedView;

	// Token: 0x0400007D RID: 125
	public bool liveUpdate;

	// Token: 0x0400007E RID: 126
	public string referenceName;

	// Token: 0x0400007F RID: 127
	public bool enablePlayMakerEvents;

	// Token: 0x04000080 RID: 128
	public string addEvent;

	// Token: 0x04000081 RID: 129
	public string setEvent;

	// Token: 0x04000082 RID: 130
	public string removeEvent;

	// Token: 0x04000083 RID: 131
	public int contentPreviewStartIndex;

	// Token: 0x04000084 RID: 132
	public int contentPreviewMaxRows;

	// Token: 0x04000085 RID: 133
	public PlayMakerCollectionProxy.VariableEnum preFillType;

	// Token: 0x04000086 RID: 134
	public int preFillObjectTypeIndex;

	// Token: 0x04000087 RID: 135
	public int preFillCount;

	// Token: 0x04000088 RID: 136
	public List<string> preFillKeyList;

	// Token: 0x04000089 RID: 137
	public List<bool> preFillBoolList;

	// Token: 0x0400008A RID: 138
	public List<Color> preFillColorList;

	// Token: 0x0400008B RID: 139
	public List<float> preFillFloatList;

	// Token: 0x0400008C RID: 140
	public List<GameObject> preFillGameObjectList;

	// Token: 0x0400008D RID: 141
	public List<int> preFillIntList;

	// Token: 0x0400008E RID: 142
	public List<Material> preFillMaterialList;

	// Token: 0x0400008F RID: 143
	public List<UnityEngine.Object> preFillObjectList;

	// Token: 0x04000090 RID: 144
	public List<Quaternion> preFillQuaternionList;

	// Token: 0x04000091 RID: 145
	public List<Rect> preFillRectList;

	// Token: 0x04000092 RID: 146
	public List<string> preFillStringList;

	// Token: 0x04000093 RID: 147
	public List<Texture2D> preFillTextureList;

	// Token: 0x04000094 RID: 148
	public List<Vector2> preFillVector2List;

	// Token: 0x04000095 RID: 149
	public List<Vector3> preFillVector3List;

	// Token: 0x04000096 RID: 150
	public List<AudioClip> preFillAudioClipList;

	// Token: 0x02000021 RID: 33
	public enum VariableEnum
	{
		// Token: 0x04000098 RID: 152
		GameObject,
		// Token: 0x04000099 RID: 153
		Int,
		// Token: 0x0400009A RID: 154
		Float,
		// Token: 0x0400009B RID: 155
		String,
		// Token: 0x0400009C RID: 156
		Bool,
		// Token: 0x0400009D RID: 157
		Vector3,
		// Token: 0x0400009E RID: 158
		Rect,
		// Token: 0x0400009F RID: 159
		Quaternion,
		// Token: 0x040000A0 RID: 160
		Color,
		// Token: 0x040000A1 RID: 161
		Material,
		// Token: 0x040000A2 RID: 162
		Texture,
		// Token: 0x040000A3 RID: 163
		Vector2,
		// Token: 0x040000A4 RID: 164
		AudioClip
	}
}
